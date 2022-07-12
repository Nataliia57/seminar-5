// Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве. [345, 897, 568, 234] -> 2

void Zadacha34()
{
    Random random = new Random();
    int size = random.Next(4, 12);
    int [] array = new int [size];
    fillArray (array, 100, 999);
    printArray (array);

    Console.WriteLine (" ");
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
    if (array[i]%2 == 0) 
    sum++;
    }
    Console.WriteLine (sum);
    
}
void fillArray (int [] array, int startNumber = 0, int finishNumber = 0)
{
finishNumber++;
Random random = new Random();
for (int i = 0; i < array.Length; i++)
{
    array [i] = random.Next (startNumber, finishNumber);
}
 }

 void printArray (int [] array)
 {
     for (int i = 0; i < array.Length; i++)
     {
        Console.Write (array[i] + " "); 
     }

 }
Zadacha34();
