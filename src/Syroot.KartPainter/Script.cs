namespace Syroot.KartPainter;

public class Script
{
    // ---- PROPERTIES -------------------------------------------------------------------------------------------------

    public IList<Slot> Slots { get; } = new List<Slot>();

    // ---- METHODS (PUBLIC) -------------------------------------------------------------------------------------------

    public IList<string> Load(string fileName)
    {
        Slots.Clear();

        string line;
        int lineIndex = 0;
        List<string> errors = new();

        using StreamReader reader = new(File.OpenRead(fileName));
        while ((line = reader.ReadLine()) != null)
        {
            lineIndex++;

            // Ignore anything starting at a # character.
            int commentIndex = line.IndexOf('#');
            if (commentIndex != -1)
                line = line.Substring(0, commentIndex);
            if (String.IsNullOrWhiteSpace(line))
                continue;

            if (Slot.TryParse(line, out Slot? slot))
                Slots.Add(slot!);
            else
                errors.Add($"{lineIndex}: {line}");
        }

        return errors;
    }

    public async Task ImportAsync(InputSimulator input, IProgress<int>? progress = null, CancellationToken ct = default)
    {
        for (int i = 0; i < Slots.Count; i++)
        {
            progress?.Report(i);
            ct.ThrowIfCancellationRequested();

            Slot slot = Slots[i];

            // Select pattern.
            await input.Send(Key.Return, ct);
            await input.Send(Key.D, slot.PatternPage, ct);
            await input.Send(Key.Right, slot.PatternColumn, ct);
            await input.Send(Key.Down, slot.PatternRow, ct);
            await input.Send(Key.Return, ct);

            // Select color.
            await input.Send(Key.Right, slot.ColorColumn, ct);
            await input.Send(Key.Down, slot.ColorRow, ct);
            await input.Send(Key.Return, ct);

            // Select position.
            await input.Send(Key.X, ct); // Edit Position
            await Task.Delay(500); // wait for animation
            await input.Send(Key.M, ct); // Options
            await input.Send(Key.Down, 5, ct); // Direct Value Input
            await input.Send(Key.Return, ct);

            await input.Send(Key.Home, ct);
            if (slot.X != 0)
            {
                await input.Send(Key.Delete, 4, ct);
                await input.Send(slot.X.ToString(), ct);
            }

            await input.Send(Key.LMenu, ct); // next value
            if (slot.Y != 0)
            {
                await input.Send(Key.Home, ct); // clear
                await input.Send(Key.Delete, 4, ct);
                await input.Send(slot.Y.ToString(), ct);
            }

            await input.Send(Key.LMenu, ct); // next value
            if (slot.Width != 50)
            {
                await input.Send(Key.Home, ct); // clear
                await input.Send(Key.Delete, 2, ct);
                await input.Send(slot.Width.ToString(), ct);
            }

            await input.Send(Key.LMenu, ct); // next value
            if (slot.Height != 50)
            {
                await input.Send(Key.Home, ct); // clear
                await input.Send(Key.Delete, 2, ct);
                await input.Send(slot.Height.ToString(), ct);
            }

            await input.Send(Key.LMenu, ct); // next value
            if (slot.Rotate != 0)
            {
                await input.Send(Key.Home, ct); // clear
                await input.Send(Key.Delete, 4, ct);
                await input.Send(slot.Rotate.ToString(), ct);
            }

            // Finish and return to slot list.
            await input.Send(Key.Escape, ct); // back
            await input.Send(Key.G, ct); // done
            await input.Send(Key.D, ct); // select next slot
        }
    }
}

public record Slot
{
    // ---- FIELDS -----------------------------------------------------------------------------------------------------

    public int PatternPage;
    public int PatternColumn;
    public int PatternRow;
    public int ColorColumn;
    public int ColorRow;
    public float X;
    public float Y;
    public int Width;
    public int Height;
    public float Rotate;

    // ---- METHODS (PUBLIC) -------------------------------------------------------------------------------------------

    public static bool TryParse(string text, out Slot? slot)
    {
        slot = null;

        string[] tokens = text.Split(',');
        if (tokens.Length != 7)
            return false;
        for (int i = 0; i < tokens.Length; i++)
            tokens[i] = tokens[i].Trim();

        int patternIndex = PatternTable.GetIndex(tokens[0]);
        if (patternIndex == -1)
            return false;

        slot = new();

        slot.PatternPage = PatternTable.GetPage(patternIndex);
        slot.PatternColumn = PatternTable.GetColumn(patternIndex);
        slot.PatternRow = PatternTable.GetRow(patternIndex);

        slot.ColorColumn = ColorTable.GetColumn(tokens[1]);
        slot.ColorRow = ColorTable.GetRow(tokens[1]);
        if (slot.ColorColumn == -1 || slot.ColorRow == -1)
            return false;

        if (!Single.TryParse(tokens[2], out slot.X))
            return false;
        if (!Single.TryParse(tokens[3], out slot.Y))
            return false;
        if (!Int32.TryParse(tokens[4], out slot.Width))
            return false;
        if (!Int32.TryParse(tokens[5], out slot.Height))
            return false;
        if (!Single.TryParse(tokens[6], out slot.Rotate))
            return false;

        return true;
    }
}
