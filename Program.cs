using components;
using static System.Console;

List<List<Cube>> Solutions = [];

void verify(List<Cube> cubes2)
{
    List<int> top = [];
    List<int> front = [];
    List<int> rear = [];
    List<int> bottom = [];
    List<int> left = [];
    List<int> right = [];

    foreach (var cube in cubes2)
    {
        if (top.Contains(cube.top))
            return;
        top.Add(cube.top);

        if (front.Contains(cube.front))
            return;
        front.Add(cube.front);

        if (rear.Contains(cube.rear))
            return;
        rear.Add(cube.rear);

        if (bottom.Contains(cube.bottom))
            return;
        bottom.Add(cube.bottom);

        left.Add(cube.left);
        right.Add(cube.right);
    }

    var cubea = new Cube(top[0], front[0], bottom[0], rear[0], left[0], right[0]);
    var cubeb = new Cube(top[1], front[1], bottom[1], rear[1], left[1], right[1]);
    var cubec = new Cube(top[2], front[2], bottom[2], rear[2], left[2], right[2]);
    var cubed = new Cube(top[3], front[3], bottom[3], rear[3], left[3], right[3]);

    List<Cube> newList = [cubea, cubeb, cubec, cubed];

    bool flag = false;
    for (int i = 0; i < Solutions.Count; i++)
    {
        if (Cube.IsEqual(Solutions[i], newList))
        {
            flag = true;
        }
        ;
    }
    if (!flag)
        Solutions.Add(newList);
}

/// 0 = r ; 1 = g; 2 = b; 3 = y

var cubeA = new Cube(3, 3, 1, 3, 2, 0); // y,y,g,y,b,r
var cubeB = new Cube(0, 3, 1, 2, 3, 0); // r,y,g,b,y,r
var cubeC = new Cube(0, 2, 2, 3, 1, 1); // r,b,b,y,g,g
var cubeD = new Cube(0, 3, 2, 1, 1, 0); // r,y,b,g,g,r

List<Cube> cubes = [cubeA, cubeB, cubeC, cubeD];

for (int a = 0; a < 4; a++)
{
    for (int aa = 0; aa < 4; aa++)
    {
        for (int aaa = 0; aaa < 4; aaa++)
        {
            for (int b = 0; b < 4; b++)
            {
                for (int bb = 0; bb < 4; bb++)
                {
                    for (int bbb = 0; bbb < 4; bbb++)
                    {
                        for (int c = 0; c < 4; c++)
                        {
                            for (int cc = 0; cc < 4; cc++)
                            {
                                for (int ccc = 0; ccc < 4; ccc++)
                                {
                                    for (int d = 0; d < 4; d++)
                                    {
                                        for (int dd = 0; dd < 4; dd++)
                                        {
                                            for (int ddd = 0; ddd < 4; ddd++)
                                            {
                                                verify(cubes);
                                                cubeD.TurnZ();
                                            }
                                            cubeD.TurnVertical();
                                        }
                                        cubeD.TurnHorizontal();
                                    }
                                    cubeC.TurnZ();
                                }
                                cubeC.TurnVertical();
                            }
                            cubeC.TurnHorizontal();
                        }
                        cubeB.TurnZ();
                    }
                    cubeB.TurnVertical();
                }
                cubeB.TurnHorizontal();
            }
            cubeA.TurnZ();
        }
        cubeA.TurnVertical();
    }
    cubeA.TurnHorizontal();
}

WriteLine($"Temos {Solutions.Count} solucoes possiveis");

StreamWriter writer = new StreamWriter("Desafio1.csv");
for (int i = 0; i < Solutions.Count; i++)
{
    WriteLine("\n");
    var Listcube = Solutions[i];
    for (int j = 0; j < Listcube.Count; j++)
    {
        var cube = Listcube[j];
        WriteLine(
            $"Cubo {j + 1} top:{cube.top} front:{cube.front} bottom:{cube.bottom} rear:{cube.rear} left:{cube.left} right:{cube.right}"
        );
        writer.WriteLine(
            $"{cube.top},{cube.front},{cube.bottom},{cube.rear},{cube.left},{cube.right}"
        );
    }
}

writer.Close();
