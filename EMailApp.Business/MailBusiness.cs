using EMailApp.Common;
using EMailApp.Common.ViewModel;
using EMailApp.Repository.Entity;
using EMailApp.Repository.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMailApp.Business
{
    public class MailBusiness
    {
        private readonly IRepository<Mail> _mailRepository;
        private readonly IRepository<User> _userRepository;
        private readonly IUnitOfWork _unitOfWork;
        private readonly ApplicationContext _applicationContext;
        public MailBusiness(IUnitOfWork unitOfWork, ApplicationContext applicationContext)
        {
            this._unitOfWork = unitOfWork;
            this._mailRepository = unitOfWork.GetRepository<IRepository<Mail>>();
            this._userRepository = unitOfWork.GetRepository<IRepository<User>>();
            this._applicationContext = applicationContext;
        }

        public async Task<List<Mail>> GetAllInboxMails()
        {
            var receiverMails = (await this._mailRepository.GetByAsync(x => x.ReceiverId == this._applicationContext.UserId, x=> x.Sender, x=> x.Receiver)).OrderByDescending(y=> y.CreatedDate).ToList();
            return receiverMails;
        }

        public async Task<List<Mail>> GetAllSentMails()
        {
            var senderMails = (await this._mailRepository.GetByAsync(x => x.SenderId == this._applicationContext.UserId, x => x.Sender, x => x.Receiver)).OrderByDescending(y => y.CreatedDate).ToList();
            return senderMails;
        }

        public async Task<List<Mail>> GetAllDraftMails()
        {
            var senderMails = (await this._mailRepository.GetByAsync(x => (x.SenderId == this._applicationContext.UserId && x.IsDraft == true ), x => x.Sender, x => x.Receiver)).OrderByDescending(y => y.CreatedDate).ToList();
            return senderMails;
        }

        public async Task<MailViewModel> GetMailById(int mailId)
        {
            var mail = (await this._mailRepository.GetByAsync(x => x.Id == mailId, x => x.Sender, x => x.Receiver)).FirstOrDefault();
            MailViewModel mailDetail = new MailViewModel()
            {
                Id = mail.Id,
                From = mail.Sender.Email,
                To = mail.Receiver?.Email ?? null,
                Subject = mail.Subject,
                Description = mail.Description,
                CreatedDate = mail.CreatedDate,
            };
            return mailDetail;
        }

        public async Task CreateMail(MailViewModel mailViewModel)
        {
            var receiverId = (await this._userRepository.GetByAsync(x => x.Email == mailViewModel.To)).FirstOrDefault().Id;
            Mail mail = new Mail()
            {
                Subject = mailViewModel.Subject,
                Description = mailViewModel.Description,
                SenderId = this._applicationContext.UserId,
                ReceiverId = receiverId,
                CreatedDate = DateTime.Now.ToLocalTime()
            };

            this._mailRepository.Add(mail);
            await this._unitOfWork.SaveAsync();
        }

        public async Task CreateDraftMail(MailViewModel mailViewModel)
        {
            Mail mail = new Mail()
            {
                Subject = mailViewModel.Subject,
                Description = mailViewModel.Description,
                SenderId = this._applicationContext.UserId,
                IsDraft = true,
                CreatedDate = DateTime.Now.ToLocalTime()
            };

            this._mailRepository.Add(mail);
            await this._unitOfWork.SaveAsync();
        }
    }
}
