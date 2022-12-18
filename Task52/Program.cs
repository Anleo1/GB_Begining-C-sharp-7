Console.Write("Введите количество строк в массиве: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество элементов в строке: ");
int columns = Convert.ToInt32(Console.ReadLine());
double [,] arr = new double [rows, columns];
Console.WriteLine("Введите элементы массива, по одному: ");

for (int i = 0; i < rows; i++){
    for (int j = 0; j < columns; j++){
        arr[i,j] = Convert.ToInt32(Console.ReadLine());
    }
}
Console.WriteLine();
Console.WriteLine("Массив: ");
for (int i = 0; i < rows; i++){
    for (int j = 0; j < columns; j++){
        Console.Write($"{arr[i,j]} ");
    }
    Console.WriteLine();
}
for (int i = 0; i < columns; i++){
    double res = 0.0;
    double sum = 0;
    for (int j = 0; j < rows; j++){
        sum += arr[j,i];
    }
    res = sum / rows;
    Console.WriteLine($"Среднее арифметическое столбца №{i+1} = {res}");
}