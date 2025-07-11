
//Task 1;

// int a = Convert.ToInt32(Console.ReadLine());

// System.Console.WriteLine(Usmon(a));

// int Usmon(int a)
// {
//     if (a == 1) { return 1; }
//     else
//     {
//         int result = a * Usmon(a - 1);
//         return result;
//     }
// } 


//task 2

// int a = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(fib(a));

// int fib (int a )
// {
//     if (a <= 1)
//     {
//         return a;
//     }
//     return fib(a - 1) + fib(a - 2);
// }

//task 3;

// int a = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(doublefactorial(a));
// int doublefactorial (int a)
// {
//     if (a == 1 || a == 0)
//     {
//         return 1;
//     }
//     else
//     {
//         return a * doublefactorial(a - 2);
//     }
// }







//HOME TASK 





//Task 1                   
// int a = Convert.ToInt32(Console.ReadLine());
// usmon(a);

// void usmon(int a)
// {
//     if (a == 0)
//     {
//         return;
//     }
//     else
//     {
//         usmon(a - 1);
//       System.Console.Write(a + " ");
//     }
// }



//Task2

// int a = Convert.ToInt32(Console.ReadLine());
// usmon(a);

// void usmon(int a)
// {
//     if (a == 0)
//     {
//         return;
//     }
//     else
//     {
//       System.Console.Write(a + " ");
//         usmon(a - 1);
//     }
// }



//Task3;

// int a = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine(usmon(a));

// int usmon(int a)
// {
//     if (a <= 0)
//     {
//         return 0;

//     }
//     else
//     {
//         var res = a + usmon(a-1);
//         return res;
//     }
// }


//Task 4;

int a = Convert.ToInt32(Console.ReadLine());
usmon(a);

void usmon(int a)
{
   
    if (a == 0)
    {
        return ;

    }
    else
    {
         usmon(a / 10);
      System.Console.Write(($"{a%10} "));
        
  }
        
}