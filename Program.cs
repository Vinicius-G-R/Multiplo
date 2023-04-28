Console.Clear();
    
    string opcao = "";
    while (opcao != "N")
{
    Console.Clear();
    int n1, n2;
    Console.WriteLine("--- Múltiplo ---\n");
    Console.Write("Digite um número...........: ");
    n1 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Avaliar se é múltiplo de...: ");
    n2 = Convert.ToInt32(Console.ReadLine());
   
    if (n1 % n2 == 0)
   {
    Console.WriteLine($"\n{n1} é múltiplo de {n2}");
   }
    else 
    {
    Console.Write($"\n{n1} ");
    Console.ForegroundColor = ConsoleColor.Red;
    Console.Write("NÃO");
    Console.ResetColor();   
    Console.WriteLine($" é múltiplo de {n2}");

    }
  Console.ForegroundColor = ConsoleColor.Green;
  Console.Write("\nQuer verificar outro múltiplo S/N? ");
  opcao = Console.ReadLine().ToUpper();
  Console.ResetColor();
}

