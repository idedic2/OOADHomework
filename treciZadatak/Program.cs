using System;

namespace treciZadatak
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesite hamburger koji zelite koristeći B za BaconMaster ili V za VeggieSlider:");
            var order = Console.ReadLine();
            char[] chars = order.ToCharArray();

            SliderFactory factory = new SliderFactory();

            int orderTotal = 0;

           
            foreach (char c in chars)
            {
                orderTotal++;
                ISlider character = factory.GetSlider(c);
                character.Display(orderTotal);
            }

            Console.ReadKey();
        }
    
    }
}
