using System;

namespace Course03 {
    
    class Program {
     
        static void Main(string[] args) {


            char genero = 'F';
            int idade = 32;
            double saldo = 10.357533;
            string nome = "Maria";

            //Placeholders
            Console.WriteLine("{0} tem {1} anos e seu saldo é de {2:F2} reais", nome, idade, saldo);
            
            //Imterpulação
            Console.WriteLine($"{nome} tem {idade} anos e seu saldo é de {saldo:F2} reais");

            //Comcatenação
            Console.WriteLine(nome + " tem " + idade + " anos e seu saldo é de " + saldo.ToString("F2") + " reais");
        }
    }
}
