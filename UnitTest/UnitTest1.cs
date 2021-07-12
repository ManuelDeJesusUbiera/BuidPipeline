using System;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PipelineAPP;
using PipelineAPP.Controllers;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void index()
        {
            PipelineController control = new PipelineController();
            ViewResult c = control.Index() as ViewResult;
        }
    }
}
