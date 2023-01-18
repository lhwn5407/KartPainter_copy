namespace Syroot.KartPainter;

public static class Utils
{
    // ---- METHODS (PUBLIC) -------------------------------------------------------------------------------------------

    public static nuint FindGameWindow()
    {
        return PInvoke.FindWindow("UnrealWindow", "KartDrift  ");
    }

    public static bool IsToken(this string a, string b)
    {
        return String.Equals(a, b, StringComparison.OrdinalIgnoreCase);
    }
}
