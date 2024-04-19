int numero = 0, controle = 0;

Console.WriteLine("Digite um número para que descobrirmos se ele é primo: ");
numero = int.Parse(Console.ReadLine());

for(int i = 1; i <= numero; i++){
  
    if (numero % i == 0)
    {
        controle++;
    }
}

if (controle == 2)
{
    Console.WriteLine($"o numero {numero} é primo");

}
else
{
    Console.WriteLine("Não é primo");
}

