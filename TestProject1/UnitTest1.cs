using ClassLibrary1;

namespace TestProject1
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            int[] a = { 3 };
            int[] b = { 0 };
            int exp = 3;
            int res1 = Class1.Func1(a, b);
            Assert.That(res1, Is.EqualTo(exp));
        }
        [Test]
        public void Test2()
        {
            int[] a = { 1 };
            Element exp = new Element(1,0);
            Element res1 = Class1.Func2(a);
            Assert.That(res1.index, Is.EqualTo(exp.index));
            Assert.That(res1.value, Is.EqualTo(exp.value));
        }
        [Test]
        public void Test3()
        {
            double[] a = { 3.14, 5.12 };
            double[] exp = { 5.12 , 3.14 };
            double[] res1 = Class1.Func3(a);
            Assert.That(res1, Is.EqualTo(exp));
        }
    }
}