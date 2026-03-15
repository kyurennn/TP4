using System;

namespace TP_MODUL4_103022400056
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- DAFTAR KELURAHAN DAN KODE POS ---");
            KodePos.TampilkanSemua();

            Console.WriteLine("--- SIMULASI DOOR MACHINE ---");
            DoorMachine pintu = new DoorMachine();

            pintu.BukaPintu();
            pintu.KunciPintu();
        }
    }
}