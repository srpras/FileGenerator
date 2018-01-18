using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileGenerator
{
    public class Application : IApplication
    {
        private static IApplication _application;

        static Application()
        {
            _application = new Application();
        }

        public static IApplication Current
        {
            get
            {
                return _application;
            }
        }
    }
}
