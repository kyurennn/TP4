using System;

namespace TP_MODUL4_103022400056
{
    public class DoorMachine
    {
        public enum State { Terkunci, Terbuka };

        public State currentState = State.Terkunci;

        public void KunciPintu()
        {
            currentState = State.Terkunci;
            Console.WriteLine("Pintu terkunci");
        }

        public void BukaPintu()
        {
            currentState = State.Terbuka;
            Console.WriteLine("Pintu tidak terkunci");
        }
    }
}