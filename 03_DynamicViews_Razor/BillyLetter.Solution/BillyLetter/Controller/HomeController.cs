using Microsoft.AspNetCore.Mvc;
using BillyLetter.Models;

namespace BillyLetter.Controllers
{
    public class HomeController : Controller
    {
        // [Route("/hello")]
        // public string Hello() { return "Hello friend!"; }

        [Route("/goodbye")]
        public string Goodbye() { return "Goodbye friend."; }

        // [Route("/")]
        // public ActionResult Letter()
        // {
        //   return View();
        // }

        [Route("/")]
        public ActionResult Hello()
        {
          LetterVariable myLetterVariable = new LetterVariable();
          myLetterVariable.SetRecipient("Jessica");
          myLetterVariable.SetSender("John");
          return View(myLetterVariable);
        }

        [Route("/journal")]
        public ActionResult Journal()
        {
          return View();
        }
    }
}
