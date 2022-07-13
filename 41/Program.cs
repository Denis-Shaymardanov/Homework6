//Задача 41: Пользователь вводит с клавиатуры M чисел. 
//Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//-1, -7, 567, 89, 223-> 3
void Count(int result)
{
    Console.WriteLine("Введите число или введите 'q' чтобы закончить ввод");
    string? S = Console.ReadLine();
    if (S!="q") 
    {  
        int N = Convert.ToInt32(S);
        if (N>0) result++;
        Count(result);
        return;
    }
    Console.WriteLine($"Среди введённых Вами чисел {result} положительных");
    
}

Count(0);



