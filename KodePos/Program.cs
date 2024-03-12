namespace KodePos
{
    using System;
    using static KodePos;

    public class KodePos
    {
        public enum Kelurahan { Batununggal, Kujangsari, Mengger, Wates, Cijaura, Jatisari, Margasari, Sekejati, Kebonwaru, Maleer, Samoja };

        public static int getKodePos(Kelurahan kelurahan)
        {
            int[] kodePos = { 40266, 40287, 40267, 40256, 40287, 40286, 40286, 40286, 40272, 40274, 40273 };
            return kodePos [(int)kelurahan];
        }
    };

    public class main
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Progam menampilkan kode pos pada kelurahan");
            Console.Write("Nama Kelurahan: ");
            String input = Console.ReadLine();
            if (Enum.TryParse<KodePos.Kelurahan>(input, out KodePos.Kelurahan kelurahan))
            {
                Console.WriteLine("Kode Pos: " + KodePos.getKodePos(kelurahan));
            }
            else
            {
                Console.WriteLine("Nama kelurahan tidak terdaftar.");
            }
        }
    }
}
