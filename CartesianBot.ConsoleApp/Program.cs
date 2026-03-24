namespace CartesianBot.ConsoleApp;

class Program
{
    static void Main(string[] args)
    {
        // Posição e Orientação: A posição do robô é dada por coordenadas(X, Y) e uma
        // letra que representa a direção para onde ele está olhando(Norte, Sul, Leste, Oeste).
        int x = 3;
        int y = 3;
        char direcao = 'L';

        //A AEB envia strings de comando simples(E, D, M):
        Console.Write("Envie os comandos de direção e avanço: ");
        string comandos = Console.ReadLine()!.ToUpper();

        //Verificação das direções e dos comandos
        for (int i = 0; i < comandos.Length; i++)
        {
            char comando = comandos[i];

            if (comando == 'D')
            {
                if (direcao == 'N') direcao = 'L';
                else if (direcao == 'L') direcao = 'S';
                else if (direcao == 'S') direcao = 'O';
                else if (direcao == 'O') direcao = 'N';
            }

            else if (comando == 'E')
            {
                if (direcao == 'N') direcao = 'O';
                else if (direcao == 'O') direcao = 'S';
                else if (direcao == 'S') direcao = 'L';
                else if (direcao == 'L') direcao = 'N';
            }

            else if (comando == 'M')
            {
                if (direcao == 'N') y++;
                else if (direcao == 'S') y--;
                else if (direcao == 'L') x++;
                else if (direcao == 'O') x--;
            }
        }

        Console.WriteLine($"Posicão Final do User: {x} {y} {direcao}");


    }
}
