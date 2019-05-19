using System;
using System.Collections.Generic;
using System.Text;

namespace treciZadatak
{
    class SliderFactory
    {
        Dictionary<char, ISlider> sliders = new Dictionary<char, ISlider>();

        public ISlider GetSlider(char key)
        {
            ISlider slider = null;
            if (sliders.ContainsKey(key)) 
            {
                slider = sliders[key];
            }
            else
            {
                switch (key)
              
                {
                    case 'B': slider = new BaconMaster(); break;
                    case 'V': slider = new VeggieSlider(); break;
                    
                }
                sliders.Add(key, slider);
            }
            return slider;
        }
    }
}

