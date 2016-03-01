using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RazorEngine;
using RazorEngine.Templating;
using System.IO;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var service = Engine.Razor;
            var template = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Views", "test.cshtml");
            var templateFile = File.ReadAllText(template);
            var result = service.RunCompile(templateFile, Guid.NewGuid().ToString());
        }
    }
}
