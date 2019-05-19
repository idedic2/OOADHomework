using System;
using System.Collections.Generic;
using System.Text;

namespace treciZadatak
{
    class BaconMaster:ISlider
    {
        string ime = "Bacon Master";
        string sir = "American";
        string preljev = "lots of bacon";
        double cijena = 2.39;
        public void Display(int orderTotal)
        {
            Console.WriteLine("Slider #" + orderTotal + ": " + ime + " - topped with " + sir + " cheese and " + preljev + "! $" + cijena.ToString());
        }
    }
}
