using LabirintMax;
using System;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;


namespace Jmix
{

    internal class Program
    {
        public static void Main(string[] args)
        {
            var logic = new Logic(Consts.LabirintHeight, Consts.LabirintWidth);
            logic.GameCycle();
        }
    }
}
