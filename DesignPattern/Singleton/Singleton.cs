using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Singleton
{
    public class Singleton
    {
        private Singleton() { }

        private static Singleton UniqueInstance;

        public static Singleton GetInstance()
        {
            if (UniqueInstance == null)
            {
                UniqueInstance = new Singleton();
            }
            return UniqueInstance;
        }
    }
}
