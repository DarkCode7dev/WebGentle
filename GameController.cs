using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication2.Controllers
{
    public class GameController : Controller
    {
        // GET: Game
        public string Name(string name)
        {
            if(name== "webgentle")
            return "Welcome to webgentle";

            return "";
        }

        public string FullName(string firstName, string lastName)
        {
            if (!string.IsNullOrEmpty(firstName) && string.IsNullOrEmpty(lastName))
                return "Your First Name is = " + firstName;
            else if (string.IsNullOrEmpty(firstName) && !string.IsNullOrEmpty(lastName))
                return "Last Name is = " + lastName;
            else
                return "Your First Name is = " + firstName + "And Last Name is = " + lastName;
            
          
        }
    }
}
