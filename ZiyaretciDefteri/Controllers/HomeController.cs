using Microsoft.AspNetCore.Mvc;
using ZiyaretciDefteri.Models;

namespace ZiyaretciDefteri.Controllers
{
    public class HomeController : Controller
    {
        static List<MessageModel> messages = new List<MessageModel>();  
        
        public IActionResult Contact()
        {

            return View(messages);
        }
        [HttpPost]
        public IActionResult Contact(MessageModel messagemodel)
        {
            //parametre adlarına dikkat et!!!!!
                messages.Add(messagemodel);
            

                return RedirectToAction("Contact");
            
           
        }
    }
}
