using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test;
using NUnit.Framework;
namespace TestTest
{
    [TestFixture]
    public class LietKeSoTest
    {
        LietKeSo lietKe;
        [SetUp]
        public void Setup()
        {
            lietKe = new LietKeSo();
        }
        [Test]
        public void Test_KhongChiahetcho5()
        {
            var result = lietKe.LietKe();
            Assert.That(result.Count, Is.EqualTo(80));
        }
        [Test]
        public void Test_KhongChiahetcho5_1()
        {
            var result = lietKe.LietKe();
            Assert.That(result.Any(x => x % 5 == 0), Is.False);
        }
        [Test]
        public void Test_coSo1()
        {
           var result = lietKe.LietKe();
           Assert.That(result.Contains(1), Is.True);
        }
        [Test]
        public void Test_coSo100()
        {
            var result = lietKe.LietKe();
            Assert.That(result.Contains(100), Is.False);
        }
        [Test]
        public void Test_coSo5()
        {
            var result = lietKe.LietKe();
            Assert.That(result.Contains(5), Is.False);
        }
    }
}
