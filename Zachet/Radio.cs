using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zachet
{
    public class Radio
    {
        private int channel;
        private int volume;
        public Radio()
        {
            channel = 0;
            volume = 1;
        }
        public void CH_Next()
        {
            if (channel == 9)
            {
                channel = 0;
            }
            else
                channel++;
        }
        public void CH_Prriv()
        {
            if (channel == 0)
            {
                channel = 9;
            }
            else
                channel--;
        }
        public void Vol_Next()
        {
            if (volume < 9)
            {
                volume++;
            }
        }
        public void Vol_Priv()
        {
            if (volume > 0)
            {
                volume--;
            }
        }
        public int Channel
        {
            set
            {
                if ((value <= 10) && (value >= 0))
                {
                    channel = value;
                }
                else
                    Console.WriteLine("Канал должен быть в диапазоне от 0 до 10");
            }
            get { return channel; }

        }

        public int Volume
        {
            set
            {
                if ((value <= 10) && (value >= 0))
                {
                    volume = value;
                }
                else
                    Console.WriteLine("Канал должен быть в диапазоне от 0 до 10");
            }
            get { return volume; }

        }
    }
}
