int ncases = int.Parse(Console.ReadLine());

List<int> cases = new();
for (int i = 1; i <= ncases; i++)
{
    cases.Add(int.Parse(Console.ReadLine()));
}

foreach (int @case in cases)
{
    Console.WriteLine(Res.Resolve(@case));
}

public class Res
{
    public static int Resolve(int input)
    {
        if (input == 0) return 0;
        if (input == 1) return 1;
        int[,] matrix = new int[input, input];
        for (int i = 1; i <= input; i++)
        {
            int triangle = Triangle(i);
            matrix[0, i - 1] = triangle;
        }

        for (int i = 1; i < input; i++)
        {
            for (int j = i - 1; j < input; j++)
            {
                matrix[i, j] = matrix[i - 1, j] - 1 - i;
            }
        }

        List<int> posible = new();
        for (int i = 0; i < input; i++)
        {
            bool touched = false;
            for (int j = i; j < input; j++)
            {
                if (matrix[i, j] == input)
                {
                    posible.Add(j + 1);
                    break;
                }

                if (!touched && matrix[i, j] > input)
                {
                    touched = true;
                    posible.Add(j + 1 + (matrix[i, j] - input));
                    break;
                }

                if (matrix[i, j] < 0)
                {
                    break;
                }
            }
        }
        return posible.Min();
    }

    public static int Triangle(int n) => (n * (n + 1)) / 2;

}
