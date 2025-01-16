namespace Cubes;

public class Cube (int top, int back, int front, int bottom, int right, int left)
{
    public int top { get; set; } = top;
    public int back { get; set; } = back;
    public int front { get; set; } = front;
    public int bottom { get; set; } = bottom;
    public int right { get; set; } = right;
    public int left { get; set; } = left;

    public int TurnVertical()
    {
        var temp = front;
        front = top;
        top = back;
        back = bottom;
        bottom = temp;

        return 0;
    }

    public int TurnHorizontal()
    {
        var temp = front;
        front = right;
        right = back;
        back = left;
        left = temp;

        return 0;
    }
}
