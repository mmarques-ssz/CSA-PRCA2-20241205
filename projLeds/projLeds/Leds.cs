using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projLeds
{
    internal class Leds
    {
        private byte dado;
        public Leds()
        {
            this.dado = 0;
        }
        public Leds(byte dado)
        {
            this.dado = dado;
        }
        public void acender(int led)
        {
            dado = (byte)((int)dado | (int)(Math.Pow(2, (led-1))));
        }
        public void apagar(int led)
        {
            dado = (byte)(((int)dado & 255 - (int)(Math.Pow(2, (led - 1)))));
        }
        public byte getDado()
        {
            return this.dado;
        }
        public bool getLed(int led)
        {
            byte teste;
            teste = (byte)((int)dado & (int)(Math.Pow(2, (led - 1))));
            return (teste>0);
        }

    }
}
