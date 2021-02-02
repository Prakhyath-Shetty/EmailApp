using EMailApp.Business;
using EMailApp.Common.ViewModel;
using EMailApp.Web.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace EMailApp.Web.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        private readonly MailBusiness _mailBusiness;
        public HomeController(MailBusiness mailBusiness)
        {
            this._mailBusiness = mailBusiness;
        }
        public async Task<IActionResult> Index()
        {
            var mails = await this._mailBusiness.GetAllInboxMails();
            return View("Index", mails);
        }

        public IActionResult Compose()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> NewMail(MailViewModel mailViewModel)
        {
            if (mailViewModel.To != null)
            {
                await this._mailBusiness.CreateMail(mailViewModel);
                var mails = await this._mailBusiness.GetAllSentMails();
                return View("Sent", mails);
            }
            return View("Compose");
        }

        public async Task<IActionResult> Sent()
        {
            var mails = await this._mailBusiness.GetAllSentMails();
            return View("Sent", mails);
        }

        public async Task<IActionResult> Mail(int id)
        {
            var mail = await this._mailBusiness.GetMailById(id);
            if (mail != null)
            {
                return View("Mail", mail);
            }
            var mails = await this._mailBusiness.GetAllInboxMails();
            return View("Index", mails);
        }

        public async Task<IActionResult> Draft(MailViewModel mailViewModel)
        {
            if (ModelState.IsValid && mailViewModel.From != null)
            {
                await this._mailBusiness.CreateDraftMail(mailViewModel);
            }
            var mails = await this._mailBusiness.GetAllDraftMails();
            return View("Draft", mails);
        }

        public IActionResult Trash()
        {
            return View();
        }

        public IActionResult Important()
        {
            return View();
        }

        public IActionResult MailDetail()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
