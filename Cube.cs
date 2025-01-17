namespace components;

public class Cube(int top, int front, int bottom, int rear, int left, int right)
{
    public int top { get; set; } = top;
    public int front { get; set; } = front;
    public int bottom { get; set; } = bottom;
    public int rear { get; set; } = rear;
    public int left { get; set; } = left;
    public int right { get; set; } = right;

    public void TurnHorizontal()
    {
        var temp = rear;
        rear = left;
        left = front;
        front = right;
        right = temp;
    }

    public void TurnVertical()
    {
        var temp = top;
        top = front;
        front = bottom;
        bottom = rear;
        rear = temp;
    }

    public void TurnZ()
    {
        var temp = top;
        top = right;
        right = bottom;
        bottom = left;
        left = temp;
    }

    public static bool IsEqual(List<Cube> L1, List<Cube> L2)
    {
        for (int i = 0; i < L1.Count; i++)
        {
            if (L1[i].top != L2[i].top)
                return false;
            if (L1[i].front != L2[i].front)
                return false;
            if (L1[i].top != L2[i].top)
                return false;
            if (L1[i].bottom != L2[i].bottom)
                return false;
            if (L1[i].rear != L2[i].rear)
                return false;
            if (L1[i].left != L2[i].left)
                return false;
            if (L1[i].right != L2[i].right)
                return false;
        }

        return true;
    }
}
