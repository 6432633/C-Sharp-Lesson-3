using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_3
{
    class Example : InterfaceExample
    {
        int i;
        double k;

        public void summ()
        {
            throw new NotImplementedException();
        }

        int summ(int i, int j)
        {
            return i + j;
        }
    }
}
