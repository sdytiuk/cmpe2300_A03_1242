using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CBasicString s1 = new CBasicString("Hello Base!");
            s1.BaseShow();

            CLengthString s2 = new CLengthString("Hello Derived!");
            s2.DerivedShow();
            s2.BaseShow();
            s2.SayHello();

            CBasicString s3 = new CLengthString("Wow, I'm a Basic Length String!");
            //we have upcasted s3 from a CLengthString to a CBasicString
            //so... it can only use the BasicString members... unless...
            s3.BaseShow();
            //you cast it as a CLengthString!!!
            ((CLengthString)s3).DerivedShow();

            Console.Read();

        }

        
    }

    internal class CBasicString
    {
        protected string sDisplay;

        public CBasicString(string sInit)
        {
            sDisplay = sInit;
        }

        public void BaseShow()
        {
            Console.WriteLine(sDisplay);
        }

        public void SayHello()
        {
            Console.WriteLine("Hello! Good thing we don't delete things!");
        }
    }

    internal class CLengthString : CBasicString
    {
        public CLengthString(string sInit) : base(sInit)
        {

        }

        public void DerivedShow()
        {
            Console.WriteLine($"{sDisplay.Length:d4}: {sDisplay}");
        }

        new public void SayHello()
        {
            Console.WriteLine("Hello Connor McDavid. We are glad you arrived!");
            base.SayHello();
        }
    }
}
