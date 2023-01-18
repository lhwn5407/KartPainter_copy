using System.Runtime.InteropServices;

namespace Syroot.KartPainter;

internal static class PInvoke
{
    // ---- CONSTANTS --------------------------------------------------------------------------------------------------

    internal const int VK_RETURN = 0x0D;
    internal const int VK_ESCAPE = 0x1B;
    internal const int VK_HOME = 0x24;
    internal const int VK_DELETE = 0x2E;
    internal const int VK_RIGHT = 0x27;
    internal const int VK_DOWN = 0x28;
    internal const int VK_LSHIFT = 0xA0;
    internal const int VK_RSHIFT = 0xA1;
    internal const int VK_LCONTROL = 0xA2;
    internal const int VK_RCONTROL = 0xA3;
    internal const int VK_LMENU = 0xA4;
    internal const int VK_RMENU = 0xA5;

    internal const int WM_KEYDOWN = 0x0100;
    internal const int WM_KEYUP = 0x0101;
    internal const int WM_CHAR = 0x0102;

    // ---- METHODS (INTERNAL) -----------------------------------------------------------------------------------------

    [DllImport("user32", SetLastError = true)]
    internal static extern nuint FindWindow(string lpClassName, string lpWindowName);

    [DllImport("user32", SetLastError = true)]
    internal static extern nint SendMessage(nuint hWnd, uint uMsg, nuint wParam, nint lParam);
}
