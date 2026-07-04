using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    internal class constructorExample
    {
        int num;
        //internal constructorExample() {
        //    num = 100;
        //}
        internal constructorExample(int n) {
            num = n;
        }
        public void show()
        {
            Console.WriteLine(num);
        }
    }
}
