using System.Text;

namespace Syroot.KartPainter;

public partial class FormMain : Form
{
    // ---- FIELDS -----------------------------------------------------------------------------------------------------

    private readonly InputSimulator _input = new();
    private string? _scriptName;
    private bool _scriptImporting;
    private CancellationTokenSource _scriptCts = new();
    private int _forceColorColumn = -1;
    private int _forceColorRow = -1;

    // ---- CONSTRUCTORS & DESTRUCTOR ----------------------------------------------------------------------------------

    public FormMain()
    {
        InitializeComponent();
    }

    // ---- METHODS (PRIVATE) ------------------------------------------------------------------------------------------

    private void ValidateScriptRun()
    {
        if (!_scriptImporting)
        {
            string? error = null;
            if ((_input.HWnd = Utils.FindGameWindow()) == 0)
                error = "Waiting for game...";
            else if (_scriptName == null)
                error = "Select decal to paint...";

            _btImportRun.Enabled = String.IsNullOrEmpty(error);
            if (_btImportRun.Enabled)
                _btImportRun.Text = "Paint!";
            else
                _btImportRun.Text = error;
        }
    }

    // ---- EVENTHANDLERS ----------------------------------------------------------------------------------------------

    private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
    {
        _scriptCts.Cancel();
    }

    private void FormMain_Load(object sender, EventArgs e)
    {
        // Configure script list.
        void addScriptDirectory(string name)
        {
            string path = Path.Combine(Environment.CurrentDirectory, name);
            if (!Directory.Exists(path))
                return;
            _cbImportScript.Items
                .AddRange(Directory.EnumerateFiles(path, "*.txt")
                .Select(x => Path.Combine(name, Path.GetFileNameWithoutExtension(x)))
                .ToArray());
        }
        addScriptDirectory(String.Empty);
        addScriptDirectory("Scripts");
        if (_cbImportScript.Items.Count > 0)
            _cbImportScript.SelectedIndex = 0;

        // Configure forced color.
        _cbImportColor.Items.Add("None");
        _cbImportColor.Items.AddRange(ColorTable.GetColorNames().ToArray());
        _cbImportColor.SelectedIndex = 0;

        // Configure run button.
        ValidateScriptRun();

        // Configure key delay.
        _nudSettingsDelay.Value = _input.KeyDelay;
        _nudSettingsDelayRandom.Value = _input.KeyDelayRandom;
    }

    private void _cbImportScript_SelectedIndexChanged(object sender, EventArgs e)
    {
        _scriptName = _cbImportScript.Text;
        ValidateScriptRun();
    }

    private void _cbImportColor_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (_cbImportColor.SelectedIndex == 0)
        {
            _forceColorColumn = -1;
            _forceColorRow = -1;
        }
        else
        {
            _forceColorColumn = ColorTable.GetColumn(_cbImportColor.Text);
            _forceColorRow = ColorTable.GetRow(_cbImportColor.Text);
        }
    }

    private async void _btImportRun_Click(object sender, EventArgs e)
    {
        if (_scriptImporting)
        {
            _scriptCts.Cancel();
        }
        else
        {
            // Load script and display any errors.
            string filePath = Path.Combine(Environment.CurrentDirectory, Path.ChangeExtension(_scriptName, "txt"));
            if (!File.Exists(filePath))
            {
                MessageBox.Show($"Decal script '{_scriptName}' was deleted.", "KartPainter", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            Script script = new();
            IList<string> errors = script.Load(filePath);

            if (errors.Count > 0)
            {
                StringBuilder message = new();
                message.AppendLine($"Decal script '{_scriptName}' has {errors.Count} incorrect lines:");
                foreach (string error in errors.Take(5))
                    message.AppendLine(error);
                if (errors.Count > 5)
                    message.AppendLine("...");
                message.AppendLine();
                message.AppendLine("Do you want to paint without those parts?");
                if (MessageBox.Show(message.ToString(), "KartPainter", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning) == DialogResult.No)
                {
                    return;
                }
            }

            // Replace colors if requested.
            if (_forceColorColumn != -1 && _forceColorRow != -1)
            {
                for (int i = 0; i < script.Slots.Count; i++)
                {
                    script.Slots[i].ColorColumn = _forceColorColumn;
                    script.Slots[i].ColorRow = _forceColorRow;
                }
            }

            // Run script import.
            _scriptCts = new();
            _scriptImporting = true;
            try
            {
                await script.ImportAsync(_input, new Progress<int>(x => Invoke(()
                    => _btImportRun.Text = $"Cancel import ({x:000} of {script.Slots.Count - 1:000})...")),
                    _scriptCts.Token);
            }
            catch (OperationCanceledException) { }
            _scriptImporting = false;
        }
        ValidateScriptRun();
    }

    private void _nudSettingsDelay_ValueChanged(object sender, EventArgs e)
    {
        _input.KeyDelay = (int)_nudSettingsDelay.Value;
    }

    private void _nudSettingsDelayRandom_ValueChanged(object sender, EventArgs e)
    {
        _input.KeyDelayRandom = (int)_nudSettingsDelayRandom.Value;
    }

    private void _tGameWindow_Tick(object sender, EventArgs e)
    {
        ValidateScriptRun();
    }
}
