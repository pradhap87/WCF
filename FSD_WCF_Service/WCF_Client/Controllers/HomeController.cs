using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WCF_Client.Models;

namespace WCF_Client.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
             return View();
        }

        public ActionResult TCP()
        {
            HellowVM obj = new HellowVM();

            TCP_ServiceReference.HellowServiceClient TcpClient = new TCP_ServiceReference.HellowServiceClient("NetTcpBinding_IHellowService");
            obj.SayHello = TcpClient.SayHello("Prathap");
            obj.TodayProgram = TcpClient.TodayProgram("Prathap");
            return View(obj);
        }

        public ActionResult Http()
        {
            HellowVM obj = new HellowVM();
            TCP_ServiceReference.HellowServiceClient httpClient = new TCP_ServiceReference.HellowServiceClient("WSHttpBinding_IHellowService");
            obj.SayHello = httpClient.SayHello("Prathap");
            obj.TodayProgram = httpClient.TodayProgram("Prathap");
            return View(obj);
        }
    }
}