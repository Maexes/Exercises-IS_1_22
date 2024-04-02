using System;

namespace Exercise1
{
    class Engine
    {
        private const int StateStopped = 1;
        private const int StateStarted = 2;
        public int EngineState;

        public void start()
        {
            Console.WriteLine( "Старт" );
            EngineState = StateStopped;
        }

        public void stop()
        {
            Console.WriteLine( "Стоп" );
            EngineState = StateStarted;
        }

        public string GetState()
        {
            string state = null;

            if( EngineState == StateStopped )
            {
                state = "STARTED";
            }
            else if( EngineState == StateStarted )
            {
                state = "STOPPED ";
            }

            return state;
        }
    }
}
