using System;
using System.Collections.Generic;
using System.Text;

namespace treciZadatak
{
    class VeggieSlider:ISlider
    {
        string ime = "Veggie Slider";
        string sir = "Swiss";
        string preljev = "onion and tomato";
        double cijena = 1.99;
        public void Display(int orderTotal)
        {
            Console.WriteLine("Slider #" + orderTotal + ": " + ime + " - topped with " + sir + " cheese and " + preljev + "! $" + cijena.ToString());
        }
    }
}
