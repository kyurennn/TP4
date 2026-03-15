using System;

namespace TP_MODUL4_103022400056
{
    public class KodePos
    {
        public enum Kelurahan
        {
            Batununggal = 40266,
            Kujangsari = 40287,
            Mengger = 40267,
            Wates = 40256,
            Cijaura = 40287,
            Jatisari = 40286,
            Margasari = 40286,
            Sekejati = 40286,
            Kebonwaru = 40272,
            Maleer = 40274
        }

        public static string getKodePos(string kelurahan)
        {
            if (Enum.TryParse(kelurahan, true, out Kelurahan hasilEnum))
            {
                return ((int)hasilEnum).ToString();
            }
            else
            {
                return "Kode pos tidak ditemukan";
            }
        }

        public static void TampilkanSemua()
        {
            Console.WriteLine("-------------------------");
            Console.WriteLine(String.Format("{0,-15} | {1}", "Kelurahan", "Kode pos"));
            Console.WriteLine("-------------------------");

            // Trik fix bug: Ambil daftar nama string-nya dulu, baru diconvert ke angka
            foreach (string nama in Enum.GetNames(typeof(Kelurahan)))
            {
                int kode = (int)Enum.Parse(typeof(Kelurahan), nama);
                Console.WriteLine(String.Format("{0,-15} | {1}", nama, kode));
            }
            Console.WriteLine("-------------------------\n");
        }
    }
}