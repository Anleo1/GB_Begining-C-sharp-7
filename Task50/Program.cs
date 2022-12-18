Console.Write("Введите номер строки: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите номер элемента в строке: ");
int column = Convert.ToInt32(Console.ReadLine());
int [,] arr = new int [20, 20];
Console.WriteLine("Массив: ");
bool check = false;
int elem = 0;

for (int i = 0; i < arr.GetLength(0); i++){
    for (int j = 0; j < arr.GetLength(1); j++){
        arr[i,j] = new Random().Next(-99, 100);
        Console.Write($"{arr[i,j]}  ");
        if (i == row-1 && j == column-1){
            elem = arr[i,j];
            check = true;
        }
    }
    Console.WriteLine();
}
Console.WriteLine();
if (check == true){
    Console.WriteLine($"Элемент на этой позиции = {elem}");
}
else {
    Console.WriteLine("Нет элемента на этой позиции");
}