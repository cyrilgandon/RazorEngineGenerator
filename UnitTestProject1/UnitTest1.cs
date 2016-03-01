using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RazorEngine;
using RazorEngine.Templating;
using System.IO;
using ConsoleApplication;
using RazorEngine.Configuration;
using System.Linq;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var config = new TemplateServiceConfiguration();
            config.ReferenceResolver = new MyIReferenceResolver();
            using (var service = RazorEngineService.Create(config))
            {
                var template = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Views", "test.cshtml");
                var templateFile = File.ReadAllText(template);
                var result = service.RunCompile(templateFile, Guid.NewGuid().ToString());
            }
        }
    }
}
