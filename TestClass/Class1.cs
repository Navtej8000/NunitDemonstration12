using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using NUnit;
using NUnitDemonstration;
using NUnit.Framework.Legacy;

namespace TestClass
{
    [TestFixture]
    public class Class1
    {
        [Test]
    public void ValidTriangle_Input60and60and60_OutputValidTriangle()
        {

            int firstAngle = 60;
            int secondAngle = 60;
            int thirdAngle = 60;
            string expected = "The triangle is valid.";
            string actual = Triangle.ValidTriangle(firstAngle, secondAngle, thirdAngle);
            ClassicAssert.AreEqual(expected, actual);
            

    }


        



    }
}

