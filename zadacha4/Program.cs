//  Напишите программу, которая принимает на вход три числа 
//и выдаёт максимальное из этих чисел.

Console.Clear();
Console.Write("Введите число1:  ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число2:  ");
int num2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число3:  ");
int num3 = Convert.ToInt32(Console.ReadLine());



if ((num1 > num2) || (num1 > num3))

{
   Console.WriteLine("max =" + num1);

   if ((num2 > num1) || (num2 > num3))
    {
        Console.WriteLine("max =" + num2);
    }
}
else
{
Console.WriteLine("max =" + num3);
}


//if ((num2 > num1) || (num2 > num3))
//{
   // Console.WriteLine("max =" + num2);
//}


//if ((num3 > num1) || (num3 > num2))
//{
    //Console.WriteLine("max =" + num3);
//}






