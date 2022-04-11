double altura, pesoIdeal;
string sexo;

// Espacamento
Console.WriteLine();


Console.Write("Digite sua altura em metros: ");
altura = Convert.ToDouble(Console.ReadLine());

Console.Write("Sexo [M]asculino/[F]eminino: ");
sexo = Console.ReadLine()!;

// Espacamento
Console.WriteLine();

if (sexo == "M" || sexo == "m")
{
    // Calculando peso ideal
    pesoIdeal = altura * 72.7 - 58;

    Console.WriteLine($"Seu peso ideal é {pesoIdeal:N1} kg");
}
else if (sexo == "F" || sexo == "f")
{
    // Calculando peso ideal
    pesoIdeal = altura * 62.1 - 44.7;

    Console.WriteLine($"Seu peso ideal é {pesoIdeal:N1} kg");
}
else // Será executado caso o usuário tenha escrito um valor inválido para sexo
{
    Console.Beep();
    Console.ForegroundColor = ConsoleColor.Red;

    Console.WriteLine("Por favor, insira M para masculino, ou F para feminino.");
    Console.ResetColor();
}

// Espacamento
Console.WriteLine();
