using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertiesDemo
{
    internal class Box
    {
        private int _iWidth; //member always private
        
        //MANUAL property
        public int Width
        {
            get { return _iWidth; }
            set 
            {
                if (value < 0)
                    _iWidth = 0;
                else _iWidth = value;
            }
            
        }

        //AUTOMATIC property
        public string boxName {  get; private set; }


        public Box (int Width, string name)
        {
            this.Width = Width;
            //use the property when it exists even though you can directly
            //access the private member from the constructor
            //but you can decide... you're the boss...
            this.boxName = name;
        }
    }
}
