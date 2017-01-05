using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using class_library;
using NUnit.Framework;


//TODO 1. Change class name from Class1 to GetValueTester
//TODO 2. Change class file name from Class1.cs to GetValueTester.cs
//TODO 3. Add reference class_library to unit test project 
//TODO 4. Through NuGet, install NUnit 3 to this project. Add using NUnit.Framework
//TODO 5. Install Nunit Adapter from Tools-Extenstions and Updates
//TODO 6. Add [TestFixture] to class
//TODO 7. Add Testcase named Converter_From_Int_1_To_String1()
//TODO 8. Add [Test] to method

namespace UnitTestPres.Tester
{
    [TestFixture]
    public class GetValueTester
    {
        [Test]
        public void Converter_From_Int_1_To_String1()
        {
            //Arrange (Prepare test case with required attribute)
            int input = 1;
            string expectedOutput = "1";

            //Act (Perform teh test case and get the actualOutput)
            Converter converter = new Converter();
            string actualOutput = converter.convert(input);

            //Assert (CHeck for errors based on the expected and actualOutput
            Assert.AreEqual(expectedOutput, actualOutput);
        }
    }
}
