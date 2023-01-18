namespace Syroot.KartPainter;

public static class ColorTable
{
    // ---- CONSTANTS --------------------------------------------------------------------------------------------------

    private const int _valueMin = 50;
    private const int _valueMax = 900;
    private const int _valueStep = 50;

    private static readonly string[] _names =
    {
        "Red",
        "Pink",
        "Purple",
        "Deep Purple",
        "Indigo",
        "Blue",
        "Light Blue",
        "Cyan",
        "Teal",
        "Green",
        "Light Green",
        "Lime",
        "Yellow",
        "Orange",
        "Deep Orange",
        "Brown",
        "Gray"
    };

    // ---- METHODS (PUBLIC) -------------------------------------------------------------------------------------------

    public static IEnumerable<string> GetColorNames()
    {
        yield return "White";
        yield return "Black";
        foreach (string colorName in _names)
            for (int i = _valueMin; i <= _valueMax; i += _valueStep)
                yield return $"{colorName} {i}";
    }

    public static int GetColumn(string name)
    {
        if (name.IsToken("White"))
            return 0;
        if (name.IsToken("Black"))
            return 0;

        int valueIndex = name.LastIndexOf(' ');
        if (valueIndex == -1)
            return -1;
        name = name.Substring(0, valueIndex);
        for (int i = 0; i < _names.Length; i++)
            if (name.IsToken(_names[i]))
                return i + 1;

        return -1;
    }

    public static int GetRow(string name)
    {
        if (name.IsToken("White"))
            return 0;
        if (name.IsToken("Black"))
            return 1;

        int valueIndex = name.LastIndexOf(' ');
        if (valueIndex == -1)
            return -1;
        if (!Int32.TryParse(name.Substring(valueIndex + 1), out int value))
            return -1;
        if (value < _valueMin || value > _valueMax || value % _valueStep != 0)
            return -1;

        return (value - _valueMin) / _valueStep;
    }
}
