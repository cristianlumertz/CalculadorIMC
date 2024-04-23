using System.Xml.Serialization;
int cont; //variavel que funciona como contador para encerrar ou continuar o programa
do{ //ordena que o codigo seja repetido sempre que cont for diferente de 0
Console.WriteLine("Calculadora de IMC"); 
Console.WriteLine("------------------"); 
Console.WriteLine("Insira seu nome: "); 
string nome = Console.ReadLine();  //recebe string que atribui a string nome
Console.WriteLine("Insira sua idade: "); 
int idade = Convert.ToInt32(Console.ReadLine()); //recebe um int e atribui a int idade
Console.WriteLine("Informe seu peso em KG: "); 
double peso = Convert.ToDouble(Console.ReadLine()); //recebe um double e atribui a double peso
Console.WriteLine("Informe sua altura em metros (Ex: 1,80): "); 
double altura = Convert.ToDouble(Console.ReadLine());//recebe um double e atribui a double altura
Console.WriteLine("-------------------");
Console.WriteLine("     Relatorio     ");
Console.WriteLine(nome);

// o if serve para enquatrar o imc onde deve ser enquadrado/assim como o if da idade
double imc = peso/(altura *altura);
if (imc < 18.5)
{
    Console.WriteLine($"Seu IMC e {imc}, portanto esta abaixo do peso");
}
else if (imc >= 18.5 && imc <=24.9)
{
   Console.WriteLine($"Seu IMC e {imc}, portanto esta no peso normal"); 
}
else if (imc >= 25 && imc <=29.9)
{
    Console.WriteLine($"Seu IMC e {imc}, portanto esta com sobrepreso"); 
}
else
{
    Console.WriteLine($"Seu IMC e {imc}, portanto voce esta obeso"); 
}

if (idade <10)
{
    Console.WriteLine($"{idade} anos = Crianca");
}
else if(idade >=10 && idade <20)
{
    Console.WriteLine($"{idade} anos = Adolescente");
}
else if(idade >=20 && idade <60)
{
    Console.WriteLine($"{idade} anos = Adulto");
}
else
{
    Console.WriteLine($"{idade} anos = Idoso");
}

Console.WriteLine("Digite 0 para encerrar o programa e 1 para continuar.");
cont = Convert.ToInt32(Console.ReadLine());
} while (cont != 0);
Console.WriteLine("Encerrando o programa...");



