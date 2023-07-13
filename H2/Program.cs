Console.WriteLine("Введите координаты первой точки:");
        Console.Write("X1: ");
        double x1 = double.Parse(Console.ReadLine() ?? "0");
        Console.Write("Y1: ");
        double y1 = double.Parse(Console.ReadLine() ?? "0");
        Console.Write("Z1: ");
        double z1 = double.Parse(Console.ReadLine() ?? "0");

        Console.WriteLine("Введите координаты второй точки:");
        Console.Write("X2: ");
        double x2 = double.Parse(Console.ReadLine() ?? "0");
        Console.Write("Y2: ");
        double y2 = double.Parse(Console.ReadLine() ?? "0");
        Console.Write("Z2: ");
        double z2 = double.Parse(Console.ReadLine()?? "0");

        double distance = CalculateDistance(x1, y1, z1, x2, y2, z2);

        Console.WriteLine($"Расстояние между точками: {distance}");
    

    static double CalculateDistance(double x1, double y1, double z1, double x2, double y2, double z2)
    {
        double deltaX = x2 - x1;
        double deltaY = y2 - y1;
        double deltaZ = z2 - z1;

        double distance = Math.Sqrt(Math.Pow(deltaX, 2) + Math.Pow(deltaY, 2) + Math.Pow(deltaZ, 2));
        return distance;
    }



