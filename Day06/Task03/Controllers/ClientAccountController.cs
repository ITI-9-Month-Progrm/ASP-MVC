using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Web;
using System.Web.Mvc;
using Task03.Models;

namespace Task03.Controllers
{
    [AllowAnonymous]
    public class ClientAccountController : Controller
    {
        // GET: ClientAccount
        public ActionResult SignUp()
        {
            return View();
        }
        [HttpPost]
        public ActionResult SignUp(Client client)
        {
            //step 1: check that client data is valid
            if (ModelState.IsValid)
            {
                //step 2: Add client to database
                MainDbContext mainDbContext = new MainDbContext();
                mainDbContext.Clients.Add(client);
                mainDbContext.SaveChanges();
                //step 3:create cliems
                var clientIdentity = new ClaimsIdentity(
                    new List<Claim>
                    {
                        new Claim (ClaimTypes.Email, client.Email),
                        new Claim ("password", client.Password),
                        new Claim ("userName", client.ClientName),
                        new Claim ("Mobile", client.Mobile)
                    }, "AppCookieFile");
                //step 4: use owin to create client identity
                Request.GetOwinContext().Authentication.SignIn(clientIdentity);
                return RedirectToAction("Index", "Home");
            }

            return View();
        }
        public ActionResult SignIn()
        {
            return View();
        }
        [HttpPost]
        public ActionResult SignIn(Client client)
        {
            //step 1: get client from Db
            MainDbContext mainDbContext = new MainDbContext();
            Client loggedinclient = mainDbContext.Clients.FirstOrDefault(c => c.Email == client.Email && c.Password == client.Password);
            //step 2: check that client found
            if (loggedinclient is null)
            {
                return View();
            }
            //step 3; create claims
            else
            {
                var signInIdentity = new ClaimsIdentity(
                    new List<Claim>
                    {
                       new Claim (ClaimTypes.Email, loggedinclient.Email),
                       new Claim ("userName", loggedinclient.ClientName)
                       
                    }, "AppCookieFile");
                Request.GetOwinContext().Authentication.SignIn(signInIdentity);
                return RedirectToAction("Index", "Home");

            }
        }
        public ActionResult SignOut()
        {
            Request.GetOwinContext().Authentication.SignOut("AppCookieFile");
            return RedirectToAction("SignIn");
        }
    }
}