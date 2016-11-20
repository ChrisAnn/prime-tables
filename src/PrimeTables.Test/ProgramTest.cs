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
        public void RejectsIntLessThanOneForTableSize()
        {
            using (var sw = new StringWriter())
            using (var sr = new StringReader("0\r\n"))
            {
                Console.SetOut(sw);
                Console.SetIn(sr);

                Program.Main(new string[] { });

                const string expected = "Enter Table Size:\r\nNot a valid integer.\r\n";
                Assert.That(sw.ToString(), Is.EqualTo(expected));
            }
        }

        [Test]
        public void OutputsExpectedTableWhenSizeisThree()
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

        [Test]
        public void OutputsExpectedTableWhenSizeisTen()
        {
            using (var sw = new StringWriter())
            using (var sr = new StringReader("10\r\n"))
            {
                Console.SetOut(sw);
                Console.SetIn(sr);

                Program.Main(new string[] { });

                const string expected = "Enter Table Size:\r\nTable Size: 10\r\n" +
                                        "|    |  2 |  3 |  5 |  7 | 11 | 13 | 17 | 19 | 23 | 29 |\r\n" +
                                        "|  2 |  4 |  6 | 10 | 14 | 22 | 26 | 34 | 38 | 46 | 58 |\r\n" +
                                        "|  3 |  6 |  9 | 15 | 21 | 33 | 39 | 51 | 57 | 69 | 87 |\r\n" +
                                        "|  5 | 10 | 15 | 25 | 35 | 55 | 65 | 85 | 95 |115 |145 |\r\n" +
                                        "|  7 | 14 | 21 | 35 | 49 | 77 | 91 |119 |133 |161 |203 |\r\n" +
                                        "| 11 | 22 | 33 | 55 | 77 |121 |143 |187 |209 |253 |319 |\r\n" +
                                        "| 13 | 26 | 39 | 65 | 91 |143 |169 |221 |247 |299 |377 |\r\n" +
                                        "| 17 | 34 | 51 | 85 |119 |187 |221 |289 |323 |391 |493 |\r\n" +
                                        "| 19 | 38 | 57 | 95 |133 |209 |247 |323 |361 |437 |551 |\r\n" +
                                        "| 23 | 46 | 69 |115 |161 |253 |299 |391 |437 |529 |667 |\r\n" +
                                        "| 29 | 58 | 87 |145 |203 |319 |377 |493 |551 |667 |841 |\r\n";

                Assert.That(sw.ToString(), Is.EqualTo(expected));
            }
        }
    }
}
