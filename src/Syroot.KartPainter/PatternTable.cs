namespace Syroot.KartPainter;

public static class PatternTable
{
    // ---- CONSTANTS --------------------------------------------------------------------------------------------------

    private const int _columns = 9;
    private const int _rows = 3;
    private const int _perPage = _columns * _rows;

    private static readonly string[] _names =
    {
        "Hexagon", "Semicircle", "Crescent Moon", "Circle", "Square", "Triangle", "Right Triangle", "Curve 1", "Curve 2",
        "Curve 3", "Curve 4", "Flare 1", "Flare 2", "Flare 3", "Flare 4", "Letter A", "Letter B", "Letter C",
        "Letter D", "Letter E", "Letter F", "Letter G", "Letter H", "Letter I", "Letter J", "Letter K", "Letter L",

        "Letter M", "Letter N", "Letter O", "Letter P", "Letter Q", "Letter R", "Letter S", "Letter T", "Letter U",
        "Letter V", "Letter W", "Letter X", "Letter Y", "Letter Z", "Grinning Shark", "Fierce Bear", "Buck", "Wild Wave",
        "Snowy Mountain", "Tire Pattern 1", "Square Gradation", "Slanted Check Pattern", "Speed", "Paint Splatter 1", "Paint Splatter 2", "Paint Splatter 3", "Paint Splatter 4",

        "Tire Pattern 2", "Fluttering Flag", "Racer Helmet", "Maintenance", "Tire Wheels", "Forked Road", "Feather", "Angel's Flight", "Ancient Wings"
    };

    // ---- METHODS (PUBLIC) -------------------------------------------------------------------------------------------

    public static int GetIndex(string name)
    {
        for (int i = 0; i < _names.Length; i++)
            if (name.IsToken(_names[i]))
                return i;
        return -1;
    }

    public static int GetPage(int index)
    {
        return index / _perPage;
    }

    public static int GetRow(int index)
    {
        int indexOnPage = index % _perPage;
        return indexOnPage / _columns;
    }

    public static int GetColumn(int index)
    {
        int indexOnPage = index % _perPage;
        return indexOnPage % _columns;
    }
}
