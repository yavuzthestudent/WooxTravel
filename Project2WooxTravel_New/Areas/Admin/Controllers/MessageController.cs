using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Project2WooxTravel_New.Entities;
using Project2WooxTravel_New.Context;

namespace Project2WooxTravel_New.Areas.Admin.Controllers
{
    public class MessageController : Controller
    {
        TravelContext context=new TravelContext();
        // GET: Admin/Message
        public ActionResult Inbox()
        {
            var a = Session["x"];
            var email=context.Admins.Where(x=>x.UserName==a).Select(y=>y.Email).FirstOrDefault();
            var values=context.Messages.Where(x=>x.ReceiverMail==email).ToList();
            return View(values);
        }

        public ActionResult Sendbox()
        {
            var a = Session["x"];
            var email = context.Admins.Where(x => x.UserName == a).Select(y => y.Email).FirstOrDefault();
            var values = context.Messages.Where(x => x.SenderMail == email).ToList();
            return View(values);
        }

        public ActionResult SendMessage() 
        {
            return View();
        }

        [HttpPost]
        public ActionResult SendMessage(Message message) 
        {
            var a = Session["x"];
            var email = context.Admins.Where(x => x.UserName == a).Select(y => y.Email).FirstOrDefault();
            message.SenderMail = email;
            message.SendDate = DateTime.Now;
            message.IsRead = false;
            context.Messages.Add(message);
            context.SaveChanges();
            return RedirectToAction("Sendbox", "Message", new {area="Admin"});
        }

        public ActionResult OpenMessage(int id)
        {
            ViewBag.SenderMail = context.Messages.Where(x => x.MessageID == id).Select(x => x.SenderMail).FirstOrDefault();
            ViewBag.Subject=context.Messages.Where(x=>x.MessageID==id).Select(x => x.Subject).FirstOrDefault();
            ViewBag.Content=context.Messages.Where(x=>x.MessageID==id).Select(x=>x.Content).FirstOrDefault();
            ViewBag.Date=context.Messages.Where(x=>x.MessageID==id).Select(x=>x.SendDate).FirstOrDefault();
            return View();
        }

    }
}