using System;
using System.IO;
using NUnit.Framework;

namespace PrimeTables.Test
{
    [TestFixture]
    public class ProgramTest
    {
        [Test]
        public void AcceptsIntForTableSize()
        {
            using (var sw = new StringWriter())
            using (var sr = new StringReader("3\r\n"))
            {
                Console.SetOut(sw);
                Console.SetIn(sr);

                Program.Main(new string[] { });

                const string expected = "Enter Table Size:\r\nTable Size: 3\r\n";
                Assert.That(sw.ToString(), Is.EqualTo(expected));
            }
        }
    }
}
