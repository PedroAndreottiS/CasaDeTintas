/*Crie um programa que exiba a quantidade ideal de latas e galeões de tinta
serão necessários para pintar uma área(Com uma margem de 10% de erro)*/

double Area;

int Total, Lata, Galoes;
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine ("--- Casa de Tintas ---");
Console.ResetColor();
Console.Write("Informe o tamanho da área:");
Area = Convert.ToDouble(Console.ReadLine()!);

Console.WriteLine($"Área a ser pintada (m²)...: {Area}");

Total = Convert.ToInt32 (Area/3)*110/100;

Console.WriteLine($"Total de {Total}litro(s) de tinta.");

   // Lata =  Total/18;    Galoes = Total/36/10;
   Lata =  Total/18;    Galoes = ((Total%18)/(36/10));

Console.ForegroundColor = ConsoleColor.Blue;   
Console.WriteLine($"Distribuição:");

Console.WriteLine($"Latas...: {Lata:N0} unidade(s)");

Console.WriteLine($"Galões..: {Galoes:N0} unidade(s)");
Console.ResetColor();

Console.WriteLine($"Operação finalizada...");
#pragma warning disable CA1416
Console.Beep(1320,200);
Console.Beep(2700,200);
Console.Beep(1320,200);
Console.Beep(100,200);
Console.Beep(3000,200);