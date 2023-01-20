namespace Syroot.KartPainter
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this._btImportRun = new System.Windows.Forms.Button();
            this._nudSettingsDelay = new System.Windows.Forms.NumericUpDown();
            this._lblSettingsDelay = new System.Windows.Forms.Label();
            this._lblImportStep1 = new System.Windows.Forms.Label();
            this._tcMain = new System.Windows.Forms.TabControl();
            this._tpImport = new System.Windows.Forms.TabPage();
            this._cbImportScript = new System.Windows.Forms.ComboBox();
            this._cbImportColor = new System.Windows.Forms.ComboBox();
            this._lblImportColor = new System.Windows.Forms.Label();
            this._lblImportStep3 = new System.Windows.Forms.Label();
            this._lblImportStep2 = new System.Windows.Forms.Label();
            this._tpExport = new System.Windows.Forms.TabPage();
            this._lblExportStep1 = new System.Windows.Forms.Label();
            this._tpSettings = new System.Windows.Forms.TabPage();
            this._nudSettingsDelayRandom = new System.Windows.Forms.NumericUpDown();
            this._lblSettingsDelayRandom = new System.Windows.Forms.Label();
            this._tGameWindow = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this._nudSettingsDelay)).BeginInit();
            this._tcMain.SuspendLayout();
            this._tpImport.SuspendLayout();
            this._tpExport.SuspendLayout();
            this._tpSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._nudSettingsDelayRandom)).BeginInit();
            this.SuspendLayout();
            // 
            // _btImportRun
            // 
            this._btImportRun.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._btImportRun.Enabled = false;
            this._btImportRun.Location = new System.Drawing.Point(23, 166);
            this._btImportRun.Margin = new System.Windows.Forms.Padding(8, 0, 8, 8);
            this._btImportRun.Name = "_btImportRun";
            this._btImportRun.Size = new System.Drawing.Size(179, 27);
            this._btImportRun.TabIndex = 6;
            this._btImportRun.UseVisualStyleBackColor = true;
            this._btImportRun.Click += new System.EventHandler(this._btImportRun_Click);
            // 
            // _nudSettingsDelay
            // 
            this._nudSettingsDelay.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._nudSettingsDelay.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this._nudSettingsDelay.Location = new System.Drawing.Point(11, 27);
            this._nudSettingsDelay.Margin = new System.Windows.Forms.Padding(8, 0, 8, 4);
            this._nudSettingsDelay.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this._nudSettingsDelay.Name = "_nudSettingsDelay";
            this._nudSettingsDelay.Size = new System.Drawing.Size(188, 23);
            this._nudSettingsDelay.TabIndex = 1;
            this._nudSettingsDelay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this._nudSettingsDelay.ValueChanged += new System.EventHandler(this._nudSettingsDelay_ValueChanged);
            // 
            // _lblSettingsDelay
            // 
            this._lblSettingsDelay.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._lblSettingsDelay.AutoSize = true;
            this._lblSettingsDelay.Location = new System.Drawing.Point(8, 8);
            this._lblSettingsDelay.Margin = new System.Windows.Forms.Padding(8, 8, 8, 4);
            this._lblSettingsDelay.Name = "_lblSettingsDelay";
            this._lblSettingsDelay.Size = new System.Drawing.Size(132, 15);
            this._lblSettingsDelay.TabIndex = 0;
            this._lblSettingsDelay.Text = "Minimal Key Delay (ms)";
            // 
            // _lblImportStep1
            // 
            this._lblImportStep1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._lblImportStep1.AutoSize = true;
            this._lblImportStep1.Location = new System.Drawing.Point(8, 8);
            this._lblImportStep1.Margin = new System.Windows.Forms.Padding(8);
            this._lblImportStep1.Name = "_lblImportStep1";
            this._lblImportStep1.Size = new System.Drawing.Size(192, 15);
            this._lblImportStep1.TabIndex = 0;
            this._lblImportStep1.Text = "1. Go to the \"Create Decals\" screen.";
            // 
            // _tcMain
            // 
            this._tcMain.Controls.Add(this._tpImport);
            this._tcMain.Controls.Add(this._tpExport);
            this._tcMain.Controls.Add(this._tpSettings);
            this._tcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this._tcMain.Location = new System.Drawing.Point(8, 8);
            this._tcMain.Name = "_tcMain";
            this._tcMain.SelectedIndex = 0;
            this._tcMain.Size = new System.Drawing.Size(218, 229);
            this._tcMain.TabIndex = 0;
            // 
            // _tpImport
            // 
            this._tpImport.Controls.Add(this._cbImportScript);
            this._tpImport.Controls.Add(this._cbImportColor);
            this._tpImport.Controls.Add(this._btImportRun);
            this._tpImport.Controls.Add(this._lblImportColor);
            this._tpImport.Controls.Add(this._lblImportStep3);
            this._tpImport.Controls.Add(this._lblImportStep2);
            this._tpImport.Controls.Add(this._lblImportStep1);
            this._tpImport.Location = new System.Drawing.Point(4, 24);
            this._tpImport.Name = "_tpImport";
            this._tpImport.Size = new System.Drawing.Size(210, 201);
            this._tpImport.TabIndex = 0;
            this._tpImport.Text = "Import";
            this._tpImport.UseVisualStyleBackColor = true;
            // 
            // _cbImportScript
            // 
            this._cbImportScript.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._cbImportScript.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._cbImportScript.FormattingEnabled = true;
            this._cbImportScript.Location = new System.Drawing.Point(23, 58);
            this._cbImportScript.Margin = new System.Windows.Forms.Padding(8, 0, 8, 4);
            this._cbImportScript.Name = "_cbImportScript";
            this._cbImportScript.Size = new System.Drawing.Size(179, 23);
            this._cbImportScript.TabIndex = 2;
            this._cbImportScript.DropDown += new System.EventHandler(this._cbImportScript_DropDown);
            this._cbImportScript.SelectedIndexChanged += new System.EventHandler(this._cbImportScript_SelectedIndexChanged);
            // 
            // _cbImportColor
            // 
            this._cbImportColor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._cbImportColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._cbImportColor.FormattingEnabled = true;
            this._cbImportColor.Location = new System.Drawing.Point(23, 108);
            this._cbImportColor.Margin = new System.Windows.Forms.Padding(8, 0, 8, 8);
            this._cbImportColor.Name = "_cbImportColor";
            this._cbImportColor.Size = new System.Drawing.Size(179, 23);
            this._cbImportColor.TabIndex = 4;
            this._cbImportColor.SelectedIndexChanged += new System.EventHandler(this._cbImportColor_SelectedIndexChanged);
            // 
            // _lblImportColor
            // 
            this._lblImportColor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._lblImportColor.AutoSize = true;
            this._lblImportColor.Location = new System.Drawing.Point(20, 89);
            this._lblImportColor.Margin = new System.Windows.Forms.Padding(8, 4, 8, 4);
            this._lblImportColor.Name = "_lblImportColor";
            this._lblImportColor.Size = new System.Drawing.Size(68, 15);
            this._lblImportColor.TabIndex = 3;
            this._lblImportColor.Text = "Force Color";
            // 
            // _lblImportStep3
            // 
            this._lblImportStep3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._lblImportStep3.AutoSize = true;
            this._lblImportStep3.Location = new System.Drawing.Point(8, 147);
            this._lblImportStep3.Margin = new System.Windows.Forms.Padding(8, 8, 8, 4);
            this._lblImportStep3.Name = "_lblImportStep3";
            this._lblImportStep3.Size = new System.Drawing.Size(135, 15);
            this._lblImportStep3.TabIndex = 5;
            this._lblImportStep3.Text = "3. Click to start painting.";
            // 
            // _lblImportStep2
            // 
            this._lblImportStep2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._lblImportStep2.AutoSize = true;
            this._lblImportStep2.Location = new System.Drawing.Point(8, 39);
            this._lblImportStep2.Margin = new System.Windows.Forms.Padding(8, 8, 8, 4);
            this._lblImportStep2.Name = "_lblImportStep2";
            this._lblImportStep2.Size = new System.Drawing.Size(148, 15);
            this._lblImportStep2.TabIndex = 1;
            this._lblImportStep2.Text = "2. Select the decal to paint.";
            // 
            // _tpExport
            // 
            this._tpExport.Controls.Add(this._lblExportStep1);
            this._tpExport.Location = new System.Drawing.Point(4, 24);
            this._tpExport.Name = "_tpExport";
            this._tpExport.Size = new System.Drawing.Size(210, 201);
            this._tpExport.TabIndex = 1;
            this._tpExport.Text = "Export";
            this._tpExport.UseVisualStyleBackColor = true;
            // 
            // _lblExportStep1
            // 
            this._lblExportStep1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._lblExportStep1.AutoSize = true;
            this._lblExportStep1.Location = new System.Drawing.Point(8, 8);
            this._lblExportStep1.Margin = new System.Windows.Forms.Padding(8);
            this._lblExportStep1.Name = "_lblExportStep1";
            this._lblExportStep1.Size = new System.Drawing.Size(154, 15);
            this._lblExportStep1.TabIndex = 0;
            this._lblExportStep1.Text = "Sorry, not implemented yet.";
            // 
            // _tpSettings
            // 
            this._tpSettings.Controls.Add(this._nudSettingsDelayRandom);
            this._tpSettings.Controls.Add(this._nudSettingsDelay);
            this._tpSettings.Controls.Add(this._lblSettingsDelayRandom);
            this._tpSettings.Controls.Add(this._lblSettingsDelay);
            this._tpSettings.Location = new System.Drawing.Point(4, 24);
            this._tpSettings.Name = "_tpSettings";
            this._tpSettings.Padding = new System.Windows.Forms.Padding(3);
            this._tpSettings.Size = new System.Drawing.Size(210, 201);
            this._tpSettings.TabIndex = 2;
            this._tpSettings.Text = "Settings";
            this._tpSettings.UseVisualStyleBackColor = true;
            // 
            // _nudSettingsDelayRandom
            // 
            this._nudSettingsDelayRandom.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._nudSettingsDelayRandom.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this._nudSettingsDelayRandom.Location = new System.Drawing.Point(11, 77);
            this._nudSettingsDelayRandom.Margin = new System.Windows.Forms.Padding(8, 0, 8, 8);
            this._nudSettingsDelayRandom.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this._nudSettingsDelayRandom.Name = "_nudSettingsDelayRandom";
            this._nudSettingsDelayRandom.Size = new System.Drawing.Size(188, 23);
            this._nudSettingsDelayRandom.TabIndex = 3;
            this._nudSettingsDelayRandom.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this._nudSettingsDelayRandom.ValueChanged += new System.EventHandler(this._nudSettingsDelayRandom_ValueChanged);
            // 
            // _lblSettingsDelayRandom
            // 
            this._lblSettingsDelayRandom.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._lblSettingsDelayRandom.AutoSize = true;
            this._lblSettingsDelayRandom.Location = new System.Drawing.Point(8, 58);
            this._lblSettingsDelayRandom.Margin = new System.Windows.Forms.Padding(8, 4, 8, 4);
            this._lblSettingsDelayRandom.Name = "_lblSettingsDelayRandom";
            this._lblSettingsDelayRandom.Size = new System.Drawing.Size(191, 15);
            this._lblSettingsDelayRandom.TabIndex = 2;
            this._lblSettingsDelayRandom.Text = "Additional Random Key Delay (ms)";
            // 
            // _tGameWindow
            // 
            this._tGameWindow.Enabled = true;
            this._tGameWindow.Interval = 1000;
            this._tGameWindow.Tick += new System.EventHandler(this._tGameWindow_Tick);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(234, 245);
            this.Controls.Add(this._tcMain);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(64000, 284);
            this.MinimumSize = new System.Drawing.Size(250, 284);
            this.Name = "FormMain";
            this.Padding = new System.Windows.Forms.Padding(8);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KartPainter";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.Load += new System.EventHandler(this.FormMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this._nudSettingsDelay)).EndInit();
            this._tcMain.ResumeLayout(false);
            this._tpImport.ResumeLayout(false);
            this._tpImport.PerformLayout();
            this._tpExport.ResumeLayout(false);
            this._tpExport.PerformLayout();
            this._tpSettings.ResumeLayout(false);
            this._tpSettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._nudSettingsDelayRandom)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Button _btImportRun;
        private NumericUpDown _nudSettingsDelay;
        private Label _lblSettingsDelay;
        private Label _lblImportStep1;
        private TabControl _tcMain;
        private TabPage _tpImport;
        private ComboBox _cbImportColor;
        private Label _lblImportColor;
        private Label _lblImportStep2;
        private TabPage _tpExport;
        private Label _lblExportStep1;
        private TabPage _tpSettings;
        private ComboBox _cbImportScript;
        private System.Windows.Forms.Timer _tGameWindow;
        private Label _lblImportStep3;
        private NumericUpDown _nudSettingsDelayRandom;
        private Label _lblSettingsDelayRandom;
    }
}