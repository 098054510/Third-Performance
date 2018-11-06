using System;

namespace Thirdperformance
{
    class Program
    {
        static void Main(string[] args)
        {
            int VolumeInicial, Vazao, Tempo, VolumeFinal;

            VolumeInicial = int.Parse(Console.ReadLine());
            Vazao = int.Parse(Console.ReadLine());
            Tempo = int.Parse(Console.ReadLine());

            if(Vazao * Tempo > VolumeInicial)
            {
                Console.WriteLine("Isto é fisicamente Impossivel!");
            }
            else
            {
                VolumeFinal = VolumeInicial - Vazao * Tempo;
                Console.WriteLine(VolumeFinal);
            }
            Console.ReadLine();
        }
    }
}
