/*********************************
 * Автор: Куприянова Анна        *
 * Задание 1. Базовые понятия C# *
 * Дата: 13.02.2022              *
 *********************************/

/***********
 * Часть 1 *
 ***********/

Console.WriteLine("First task");

double Result = 1;
int IndexExponent;

Console.WriteLine("Enter number: ");
double Number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter degree: ");
int Exponent = Convert.ToInt32(Console.ReadLine());

if (Exponent == 0) {
  Result = 1; 
} else if (Exponent > 0) {
  for (IndexExponent = 0; IndexExponent < Exponent; ++IndexExponent) {
    Result *= Number1;
  }
} else if (Exponent < 0) {
  Exponent = Math.Abs(Exponent);
  for (IndexExponent = 0; IndexExponent < Exponent; ++IndexExponent) {
    Result *= 1 / Number1;
  }
}

Console.WriteLine(Result);



/***********
 * Часть 2 *
 ***********/

Console.WriteLine("\nSecond task");

Console.WriteLine("Enter number: ");
string Number2 = Convert.ToString(Console.ReadLine());

string ResultX = "", ResultN = "";
int CounterSymbol = 0;

for (int IndexSymbol = 0; IndexSymbol < Number2.Length; ++IndexSymbol) {
  ++CounterSymbol;
}

if (CounterSymbol > 2) {
  for (int IndexSymbol = 0; IndexSymbol < Number2.Length; ++IndexSymbol) {
    if (IndexSymbol != 1) {
      ResultX += Number2[IndexSymbol];
    }
  }

  ResultN = ResultX + Number2[1];

  Console.WriteLine("Result X: ");
  Console.WriteLine(ResultX);

  Console.WriteLine("Result N: ");
  Console.WriteLine(ResultN);
} else {
    Console.WriteLine("Failed");
}



