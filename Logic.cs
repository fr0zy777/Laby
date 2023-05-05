using System;

namespace Jmix
{
    class Logic
    {

        public char[,] map;
        
        private Input input;
        
        private short horInp, verInp;
        
        private int coordX, coordY;
        
        private bool isRunning;
        
        private int height, width;
        
        public Logic(int height, int width)
        {
            this.height = height;
            this.width = width;

            map = new char[width, height];

            isRunning = true;
            input = new Input();
        }

        public void GameCycle()
        {

            GenerateMap();


            do
            {
                Draw.DrawMap(map, width, height);

                GetDirection(input.GetInput());

                TryMove();



            } while (isRunning) ;
            }

        private void GetDirection(char inp)
        {
            horInp = 0;
            verInp = 0;

            switch (inp)
            {

                case 's':
                    verInp = 1;
                    break;

                case 'd':
                    horInp = 1;
                    break;
                case 'w':
                    verInp = -1;
                    break;

                case 'a':
                    horInp = -1;
                    break;
            }
        }

        public void TryMove()
        {
            if (map[coordY + verInp, coordX + horInp] == 'f') isRunning = false;

            if (map[coordY + verInp, coordX + horInp] != '#') Move();
        }

        public void Move()
        {
            map[coordY + verInp, coordX + horInp] = '0';
            map[coordY, coordX] = ' ';

            coordY += verInp;
            coordX += horInp;
        }

        public void GenerateMap()
        {


            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    int freq = 100;
                    Random random = new Random();
                    freq -= random.Next(0, 100);

                    if (freq < 30) map[i, j] = '#';
                    else map[i, j] = ' ';
                }
            }

            map[0, 0] = '#';
            map[height - 1, width - 1] = '0';
            coordX = -1; coordY = height - 1;
        }

    }



    }
