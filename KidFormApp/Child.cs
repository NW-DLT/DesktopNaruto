using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace KidFormApp
{
    class Child
    {
        public bool hungry;
        public bool WantToSleep;
        public bool WantToPlay;
        public int happiness;
        public Child(bool hungry, bool WantToSleep, bool WantToPlay)
        {
            this.hungry = hungry;
            this.WantToSleep = WantToSleep;
            this.WantToPlay = WantToPlay;
            this.happiness = 10;
        }
        public void getFood()
        {
            if (!hungry)
            {
                happiness--;
            }
            else
            {
                happiness+=4;
                hungry = false;
            }
        }
        public void ChildSleep()
        {
            if (!WantToSleep)
            {
                happiness--;
            }
            else
            {
                happiness+=8;
                WantToSleep = false;
            }
        }
        public void ChildPlay()
        {
            if (!WantToPlay)
            {
                happiness--;
            }
            else
            {
                happiness++;
                WantToPlay = false;
            }
        }
    }
}