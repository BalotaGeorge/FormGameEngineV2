using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormGameEnginePlus
{
    class Demo : FormGameEngine
    {
        public override void OnUserCreate()
        {
            AppName = "Demo";
        }
        public override void OnUserUpdate(float fElapsedTime)
        {
            for (int y = 0; y < ScreenHeight(); y++)
            {
                for (int x = 0; x < ScreenWidth(); x++)
                {
                    DrawPixel(x, y, Pixel.Random());
                }
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Demo demo = new Demo();
            demo.Construct(300, 200, 4, 4);
        }
    }
}
