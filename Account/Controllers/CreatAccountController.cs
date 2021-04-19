using Account.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Account.Controllers {
    public class CreatAccountController : Controller {
        // GET: CreatAccount
        public ActionResult Index() {
            return View(new AccountData());
        }

        [HttpPost]
        public ActionResult Index(AccountData data) {
            return View(data);
        }
    }
}