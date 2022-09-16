using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Digite Sua Senha :");
            int senha;
            senha = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Comfirme Sua Senha");
            int comfirm;
            comfirm = int.Parse(Console.ReadLine());
            
            while (senha != comfirm) {
            Console.WriteLine("Acesso Negado, Digite Sua senha novamete");
            senha = int.Parse(Console.ReadLine());
            Console.WriteLine("Comfirme Sua senha novamete");
            comfirm = int.Parse(Console.ReadLine());
        }
        if (comfirm == senha) {
        Console.WriteLine("Acesso liberado");
    }
    }
}