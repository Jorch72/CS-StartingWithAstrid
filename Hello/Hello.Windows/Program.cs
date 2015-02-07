using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Astrid.Windows;

namespace Hello.Windows
{
    class Program
    {
        static void Main()
        {
            var config = new WindowsApplicationConfig
            {
                Title = "Hello Astrid",
                Width = 800,
                Height = 480,
                ContentPath = "Content"
            };

            using (var application = new WindowsApplication(config))
            {
                var game = new Game(application);
                application.Run(game);
            }
        }
    }
}
