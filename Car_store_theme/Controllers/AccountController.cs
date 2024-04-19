using Car_store_theme.Models;
using AutoMapper;
using Car_store_theme.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Car_store_theme.Entity;

namespace Car_store_theme.Controllers
{
    public class AccountController : Controller
    {
        private readonly IUserService _UserService;
        public AccountController(IUserService UserService)
        {
            _UserService = UserService;
        }
        // GET: Account
        /* public ActionResult Index()
         {
             return View();
         }*/
        public ActionResult Registration()
        {


            return View();
        }

        public ActionResult Login()
        {

            return View();
        }


        [HttpPost]
        public JsonResult InsertUserDetails(UserModel UserInformation)
        {
            var UserDetail = Mapper.Map<UserModel, User>(UserInformation);
            var User = _UserService.InsertUserDetails(UserDetail);
            return Json(User, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public JsonResult Access(UserModel UserDetails)
        {
            var userData = Mapper.Map<UserModel, User>(UserDetails);
            var userDetails = _UserService.Access(userData);
            return Json(userDetails, JsonRequestBehavior.AllowGet);
        }


    }
}