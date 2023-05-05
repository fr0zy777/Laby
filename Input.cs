using System;


namespace Jmix
{
    class Input
    {

        char prevInp;

            public char GetInput()
            {
                prevInp = Console.ReadLine().ToCharArray()[0];
                return prevInp;
            }
    }



    }
