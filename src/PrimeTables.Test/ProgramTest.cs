using System;
using System.IO;
using NUnit.Framework;
using NUnit.Framework.Constraints;

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
                Assert.That(sw.ToString(), Does.StartWith(expected));
            }
        }

        [Test]
        public void RejectsNonIntForTableSize()
        {
            using (var sw = new StringWriter())
            using (var sr = new StringReader("three\r\n"))
            {
                Console.SetOut(sw);
                Console.SetIn(sr);

                Program.Main(new string[] { });

                const string expected = "Enter Table Size:\r\nNot a valid integer.\r\n";
                Assert.That(sw.ToString(), Is.EqualTo(expected));
            }
        }

        [Test]
        public void OutputsExpectedTableWhenNis3()
        {
            using (var sw = new StringWriter())
            using (var sr = new StringReader("3\r\n"))
            {
                Console.SetOut(sw);
                Console.SetIn(sr);

                Program.Main(new string[] { });

                const string expected = "Enter Table Size:\r\nTable Size: 3\r\n" +
                                        "|    |  2 |  3 |  5 |\r\n" +
                                        "|  2 |  4 |  6 | 10 |\r\n" +
                                        "|  3 |  6 |  9 | 15 |\r\n" +
                                        "|  5 | 10 | 15 | 25 |\r\n";
                Assert.That(sw.ToString(), Is.EqualTo(expected));
            }
        }
    }
}
