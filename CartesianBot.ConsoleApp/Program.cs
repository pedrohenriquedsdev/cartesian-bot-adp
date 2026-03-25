namespace RoboTupiniquim
{
    class Program
    {
        static int largura = 5;
        static int altura = 5;

        static void Main(string[] args)
        {
            Console.Write("Digite a posição inicial (X Y Direção): ");
            string[] entrada = Console.ReadLine()!.Split(' ');

            int x = int.Parse(entrada[0]);
            int y = int.Parse(entrada[1]);
            char direcao = char.Parse(entrada[2].ToUpper());

            Console.Write("Digite os comandos: ");
            string comandos = Console.ReadLine()!.ToUpper();

            foreach (char comando in comandos)
            {
                Console.Clear();

                switch (comando)
                {
                    case 'E':
                        direcao = GirarEsquerda(direcao);
                        break;

                    case 'D':
                        direcao = GirarDireita(direcao);
                        break;

                    case 'M':
                        Mover(ref x, ref y, direcao);
                        break;
                }

                DesenharGrid(x, y, direcao);
                Thread.Sleep(500); // animação
            }

            Console.WriteLine($"\nFinal: {x} {y} {direcao}");
        }

        static void DesenharGrid(int roboX, int roboY, char direcao)
        {
            for (int y = altura - 1; y >= 0; y--)
            {
                for (int x = 0; x < largura; x++)
                {
                    if (x == roboX && y == roboY)
                        Console.Write(GetRoboChar(direcao) + " ");
                    else
                        Console.Write(". ");
                }
                Console.WriteLine();
            }
        }

        static char GetRoboChar(char direcao)
        {
            return direcao switch
            {
                'N' => '^',
                'S' => 'v',
                'L' => '>',
                'O' => '<',
                _ => '?'
            };
        }

        static char GirarEsquerda(char d) => d switch
        {
            'N' => 'O',
            'O' => 'S',
            'S' => 'L',
            'L' => 'N',
            _ => d
        };

        static char GirarDireita(char d) => d switch
        {
            'N' => 'L',
            'L' => 'S',
            'S' => 'O',
            'O' => 'N',
            _ => d
        };

        static void Mover(ref int x, ref int y, char d)
        {
            switch (d)
            {
                case 'N': y++; break;
                case 'S': y--; break;
                case 'L': x++; break;
                case 'O': x--; break;
            }

            x = Math.Clamp(x, 0, largura - 1);
            y = Math.Clamp(y, 0, altura - 1);
        }
    }
}