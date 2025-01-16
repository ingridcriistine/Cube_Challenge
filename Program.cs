using System.Collections.Generic;
using Cubes;

/*
    1 yellow
    2 blue
    3 red
    4 green
*/

//(int top, int back, int front, int bottom, int right, int left)
Cube blockA = new(1, 2, 1, 4, 3, 2);
Cube blockB = new(3, 2, 1, 4, 3, 1);
Cube blockC = new(3, 1, 2, 2, 4, 4);
Cube blockD = new(3, 4, 1, 2, 3, 4);

List<Cube> cubes = [blockA, blockB, blockC, blockD];

int check(List<Cube> cubes)
{
    List<int> front = [];
    List<int> top = [];
    List<int> solutions = [];

    foreach (var cube in cubes)
    {
        if (front.Contains(cube.front))
        {
            return 0;
        }
        front.Add(cube.front);

        if (top.Contains(cube.top))
        {
            return 0;
        }
        top.Add(cube.top);

        
    }

    return 1;
}

foreach (var cube in cubes)
{
    for (int i = 0; i < 4; i++)
    {
        cube.TurnHorizontal();
        for (int j = 0; j < 4; j++)
        {
            for (int a = 0; a < 4; a++)
            {
                for (int b = 0; b < 4; b++)
                {
                    for (int c = 0; c < 4; c++)
                    {
                        for (int d = 0; d < 4; d++)
                        {
                            
                        }
                    }
                }
            }
            cube.TurnVertical();
        }
    }
}
