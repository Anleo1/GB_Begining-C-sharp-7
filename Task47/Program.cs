Console.Write("Введите количество строк в массиве: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество элементов в строке: ");
int columns = Convert.ToInt32(Console.ReadLine());
double [,] arr = new double [rows, columns];
Console.WriteLine("Массив: ");

for (int i = 0; i < rows; i++){
    for (int j = 0; j < columns; j++){
        arr[i,j] = new Random().Next(-99, 100) + new Random().NextDouble();
        Console.Write($"{arr[i,j]} ");
    }
    Console.WriteLine();
}