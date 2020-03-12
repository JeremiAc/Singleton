using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace Singleton
    
{
    public class Singleton
    {
        private static Singleton estructura = null;

            public string enviar = "";
        protected Singleton() 
        {
            enviar = "Bienvenid@";
        }

        public static Singleton Instance
            
        {
            get
            {
                if (estructura == null)
                    estructura = new Singleton();

                return estructura;
            }
        }
    }
}
