namespace Syroot.KartPainter;

public class InputSimulator
{
    // ---- CONSTANTS --------------------------------------------------------------------------------------------------

    private const nint _flagsExtended = 1 << 24;
    private const nint _flagsRelease = 1 << 30 | 1 << 31;

    // ---- PROPERTIES -------------------------------------------------------------------------------------------------

    public nuint HWnd { get; set; }

    public int KeyDelay { get; set; } = 30;

    // ---- METHODS (PUBLIC) -------------------------------------------------------------------------------------------

    public async Task Hold(Key key, CancellationToken ct)
    {
        PInvoke.SendMessage(HWnd, PInvoke.WM_KEYDOWN, (nuint)key, _flagsExtended);
        await Task.Delay(KeyDelay, ct);
    }

    public async Task Release(Key key, CancellationToken ct)
    {
        PInvoke.SendMessage(HWnd, PInvoke.WM_KEYUP, (nuint)key, _flagsRelease);
        await Task.Delay(KeyDelay, ct);
    }

    public async Task Send(Key key, CancellationToken ct)
    {
        await Send(key, 1, ct);
    }

    public async Task Send(Key key, int times, CancellationToken ct)
    {
        for (int i = 0; i < times; i++)
        {
            ct.ThrowIfCancellationRequested();
            await Hold(key, ct);
            await Release(key, ct);
        }
    }

    public async Task Send(string text, CancellationToken ct)
    {
        foreach (char c in text)
        {
            ct.ThrowIfCancellationRequested();
            PInvoke.SendMessage(HWnd, PInvoke.WM_CHAR, c, 0);
            await Task.Delay(KeyDelay, ct);
        }
    }
}

public enum Key
{
    Return = PInvoke.VK_RETURN,
    Escape = PInvoke.VK_ESCAPE,
    Home = PInvoke.VK_HOME,
    Delete = PInvoke.VK_DELETE,
    Right = PInvoke.VK_RIGHT,
    Down = PInvoke.VK_DOWN,
    A = 'A',
    D = 'D',
    G = 'G',
    M = 'M',
    X = 'X',
    LShift = PInvoke.VK_LSHIFT,
    RShift = PInvoke.VK_RSHIFT,
    LControl = PInvoke.VK_LCONTROL,
    RControl = PInvoke.VK_RCONTROL,
    LMenu = PInvoke.VK_LMENU,
    RMenu = PInvoke.VK_RMENU,
}
