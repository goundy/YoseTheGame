using System;
using System.Diagnostics;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using NUnit.Framework;
using YoseTheGame.Controllers;
using HtmlAgilityPack;

namespace YoseTheGameTests
{
    [TestFixture]
    public class HomeControllerTest
    {
        private ActionResult _result;

        [SetUp]
        public void ThisController()
        {
            var controller = new HomeController();
            _result = controller.Index();
        }

        [Test]
        public void ReturnsView()
        {
            Assert.That(_result, Is.InstanceOf<ViewResult>());
        }

        [Test]
        public void ReturnsTheExpectedView() 
        {
            var view = (ViewResult)_result;
            Assert.That(view.ViewName, Is.EqualTo("Home"));
        }

        [Test]
        public void TheExpectedViewContainsHelloYose()
        {
            HtmlDocument doc = new HtmlDocument();

            doc.Load("..\\..\\..\\YoseTheGame\\Views\\Home\\Home.cshtml");
            HtmlNode node = doc.DocumentNode.SelectSingleNode("//body//h1");

            Assert.IsTrue(node.InnerText == "Hello Yose");
        }

    }
}
