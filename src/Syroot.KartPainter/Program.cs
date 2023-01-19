using System.Globalization;
using System.Text;

namespace Syroot.KartPainter
{
    internal static class Program
    {
        // ---- METHODS (PRIVATE) ------------------------------------------------------------------------------------------

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        private static async Task<int> Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            CultureInfo.DefaultThreadCurrentCulture = CultureInfo.InvariantCulture;
            CultureInfo.DefaultThreadCurrentUICulture = CultureInfo.InvariantCulture;

            if (args.Length == 1)
            {
                nuint hWnd = Utils.FindGameWindow();
                if (hWnd == 0)
                {
                    Console.Error.WriteLine("Game window not found.");
                    return 1;
                }

                InputSimulator input = new();
                input.HWnd = hWnd;

                Script script = new();
                foreach (string error in script.Load(args[0]))
                    Console.Error.WriteLine($"Ignoring line {error}");

                await script.ImportAsync(input, new Progress<int>(x
                    => Console.WriteLine($"Importing slot {x:000} of {script.Slots.Count - 1:000}...")));
            }
            else
            {
                Application.Run(new FormMain());
            }
            return 0;
        }
    }
}