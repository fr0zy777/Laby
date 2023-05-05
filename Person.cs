using LabirintMax;
using System.Collections.Generic;


namespace Jmix
{
    class Person
        {
            const int maxHp = 200;

            private int hp
            {
                get => hp;
                set
                {
                    if (value > Consts.maxHp) hp = Consts.maxHp;
                    else if (value < 0) hp = 0;
                    else hp = value;
                }
            }
            private int armor;

            private List<Item> items;

            public char symbol = '0';



            public Person()
            {
                items = new List<Item>();

                symbol = Consts.PersonSymbol;


            }
        }



    }
