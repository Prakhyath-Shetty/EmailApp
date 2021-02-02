using EMailApp.Common;
using EMailApp.Common.Model;
using EMailApp.Common.Setting;
using EMailApp.Repository.Entity;
using EMailApp.Repository.Infrastructure;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Globalization;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using UDMGlobal.Hirchive.Organization.Common.Helpers;

namespace EMailApp.Business
{
    public class UserBusiness
    {
        private readonly IRepository<User> _repository;

        public UserBusiness(IUnitOfWork unitOfWork)
        {
            this._repository = unitOfWork.GetRepository<IRepository<User>>();
        }

        public async Task<User> GetLoginUser(LoginModel loginModel)
        {
            var txtpassword = loginModel.Password;
            var hasher = new SHA256Managed();
            var unhashed = Encoding.Unicode.GetBytes(txtpassword);
            var hashed = hasher.ComputeHash(unhashed);
            var hashedPassword = Convert.ToBase64String(hashed);
            loginModel.Password = hashedPassword;

            var user = (await this._repository.GetByAsync(x => x.Email == loginModel.Email && x.Password == loginModel.Password)).SingleOrDefault();
            return user;
        }
    }
}
