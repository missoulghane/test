using Ocrus;
using Ocrus.Instances;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test2
{
    class Program
    {
        static void Main(string[] args)
        {
            SampleInput input = new SampleInput("Input1");

            FieldInstance instance1 = new FieldInstance("Instance1", "", FieldState.Normal);
            input.CheckUseValue(instance1);
        }
    }
}
