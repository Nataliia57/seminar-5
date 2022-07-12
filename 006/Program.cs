//Задача 36: Задайте одномерный массив, заполненный случайными числами. 
//найти сумму элементов, стоящих на нечётных позициях.

//[3, 7, 23, 12] -> 19

//[-4, -6, 89, 6] -> 0

void Zadacha36()

{
    Random random = new Random();
    int size = random.Next(4, 12);
    int [] array = new int [size];
    fillArray (array, 2, 100);
    printArray (array);

    int count = 0;
    int sum = 0;
    for (int i = 1; i < array.Length; i+=2)
    {
       sum+=array[i];
       count++;
    }
    Console.WriteLine (" ");
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
 Zadacha36();
