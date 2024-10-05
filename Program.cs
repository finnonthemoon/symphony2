using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace symphony
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Bitmap image = new Bitmap("C:\\Users\\finns\\Downloads\\pix11.jpg");
            Color pixelColor = new Color();

            List<double> frequencies = new List<double>();
            // Get pixel data
            for (int i = 0; i < image.Width; i++)
            {
                for (int j = 0; j < image.Height; j++)
                {
                    pixelColor = image.GetPixel(i, j);
                   
                    
                    // Convert pixel color or brightness to sound parameters
                    float brightness = pixelColor.GetBrightness();
                    // brightness could map to frequency or amplitude
                    if(pixelColor.R < 220 && pixelColor.G < 220 && pixelColor.B < 220)
                    {
                        frequencies.Add(pixelColor.R * pixelColor.G * pixelColor.B);
                    }
                    else
                    {
                        frequencies.Add(-1);
                    }
                }
            }
            Console.WriteLine("hello");
           
            
            
            Console.WriteLine( " hello world" );

            for (int i = 0; i < frequencies.Count; i++)
            {
                if(frequencies.ElementAt(i) > 400)
                {
                    Console.Beep(Convert.ToInt32(Math.Round(frequencies.ElementAt(i)/1000))+100, 200);
                }
                else if(frequencies.ElementAt(i) == -1){
                    Console.Beep(3007, 200);
                }else
                {
                   
                }                    
            }
        }

    }
}
