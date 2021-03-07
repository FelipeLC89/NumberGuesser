using System;

// Namespace
namespace NumberGuesser
{       
    //Main Class
    class Program
    {
        //Entry Point Mehod
        static void Main(string[] args)
        {
            GetAppInfo(); // Executa a função GetAppInfo

            GreetUser(); //Pergunta o nome do usuário

            while (true) { 

            // Init correct number
            //int correctNumber = 7;

            //Criar objeto aleatório
            Random random = new Random();

            //Init guess var
            int correctNumber = random.Next(1, 10);

            // Init guess var
            int guess = 0;

            // Perguntar o número
            Console.WriteLine("Chute um número entre 1 e 10");

            // Enquanto a escolha não for correta
            while(guess != correctNumber){
                //Get users input
                string input = Console.ReadLine();

                //Certificar que é um número
                if (!int.TryParse(input, out guess))
                {
                    //Mensagem de erro
                    PrintColorMessage(ConsoleColor.Red, "Digite um número");
                    //keep going
                    continue;
                }

                // Cast to int and put in guess
                guess = Int32.Parse(input);

                ///Match guess to correct number
                if (guess != correctNumber)
                {
                    //Print error message
                    PrintColorMessage(ConsoleColor.Red, "Número errado, tente novamente");
                    }
            }

                //Output success message
                // Mudar a cor do texto
                PrintColorMessage(ConsoleColor.Yellow, "Você acertou!");

                // Ask to play again
                Console.WriteLine("Jogar novamente?[S ou N]");

                //Get Answer
                string answer = Console.ReadLine().ToUpper();

                if (answer == "S")
                {
                    continue;
                }
                else if (answer == "N")
                {
                    return;
                }
                else
                {
                    return;
                }

            }
        }

        //Get and display app info
        static void GetAppInfo()
        {
            //Definir as variáveis
            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string appAuthor = "Felipe Castro";

            // Mudar a cor do texto
            Console.ForegroundColor = ConsoleColor.Green;

            //Write out app info
            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);

            //Resetar a cor do texto
            Console.ResetColor();
        }

        //Perguntar o nome do usuário
        static void GreetUser()
        {
            // Perguntar o nome do usuário
            Console.WriteLine("What is your name?");

            //Get user input
            string inputName = Console.ReadLine();

            Console.WriteLine("Olá {0}, vamos jogar...", inputName);
        }

        //Muda a cor da fonte
        static void PrintColorMessage(ConsoleColor color, string message)
        {
            // Mudar a cor do texto
            Console.ForegroundColor = color;

            //Diz ao usuário que não é um número
            Console.WriteLine(message);

            //Reseta a cor do texto
            Console.ResetColor();
        }
    }
}
