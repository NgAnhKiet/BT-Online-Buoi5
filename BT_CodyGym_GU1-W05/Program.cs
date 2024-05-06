internal class Program
{
    private static void Main(string[] args)
    {
        int[] srcArray = { 12, 7, 9, 24, 5 };

        double fahrenheit;
        double celsius;
        int choice;

        do
        {
            Console.WriteLine("Menu.");
            Console.WriteLine("1. Fahrenheit to Celsius");
            Console.WriteLine("2. Celsius to Fahrenheit");
            Console.WriteLine("0. Exit");
            Console.WriteLine("Enter your choice: ");
            choice = Int32.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine("Enter fahrenheit: ");
                    fahrenheit = Double.Parse(Console.ReadLine());
                    Console.WriteLine("Fahrenheit to Celsius: " + FahrenheitToCelsius(fahrenheit));
                    break;
                case 2:
                    Console.WriteLine("Enter Celsius: ");
                    celsius = Double.Parse(Console.ReadLine());
                    Console.WriteLine("Celsius to Fahrenheit: " + CelsiusToFahrenheit(celsius));
                    break;
                case 0:
                    Environment.Exit(0);
                    break;
            }
        } while (choice != 0);

        findMinInArray(srcArray);

        int[] newArray = deleteElementFromArray(srcArray, 2);
    }

    //Thực hành viết chương trình chuyển đổi nhiệt độ
    public static double CelsiusToFahrenheit(double celsius)
    {
        double fahrenheit = (9.0 / 5) * celsius + 32;
        return fahrenheit;
    }
    public static double FahrenheitToCelsius(double fahrenheit)
    {
        double celsius = (5.0 / 9) * (fahrenheit - 32);
        return celsius;
    }

    //Thực hành tìm giá trị nhỏ nhất trong mảng sử dụng phương thức
    public static int findMinInArray(int[] array)
    {
        int min;
        min = array[0];
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] < min)
            {
                min = array[i];
            }
        }
        System.Console.WriteLine(min);
        return min;
    }

    //Bài tập viết phương thức xóa phần tử khỏi mảng
    public static int[] deleteElementFromArray(int[] array, int index)
    {
        int[] newArray = new int[array.Length - 1];
        Array.Copy(array, 0, newArray, 0, index);
        Array.Copy(array, index + 1, newArray, index, array.Length - index - 1);
        foreach (int element in newArray)
        {
            System.Console.Write(element + " ");
        }
        return newArray;
    }
}