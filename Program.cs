int numero, unidade, dezena, centena;
void texto(string frase)
{
    for (int i = 0; i < frase.Length; i++)
    {
        Console.Write(frase[i]);
        if (frase[i].ToString() != " ")
        {
        Thread.Sleep(50);
        }
    }
}
Console.ForegroundColor = ConsoleColor.Yellow;
texto("Escreva um número para decompor: ");
numero = int.Parse(Console.ReadLine()!);
unidade = numero%10;
numero = numero/10; // lembrete

dezena = numero%10;
numero = numero/10;// lembrete

centena = numero;
Console.ForegroundColor = ConsoleColor.DarkBlue;
texto($"{unidade,20} na unidade(s).\n");
Console.ForegroundColor = ConsoleColor.Blue;
texto($"{dezena,20} na dezena(s).\n");
Console.ForegroundColor = ConsoleColor.Cyan;
texto($"{centena,20} na centena(s).\n");
Console.ResetColor();