using System;
using System.IO;
using NUnit.Framework;

namespace PrimeTables.Test
{
    [TestFixture]
    public class ProgramTest
    {
        [Test]
        public void ValidateConsoleOutput()
        {
            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);

                Program.Main(null);

                string expected = $"Hello, world!{Environment.NewLine}";
                Assert.That(sw.ToString(), Is.EqualTo(expected));
            }
        }
    }
}
