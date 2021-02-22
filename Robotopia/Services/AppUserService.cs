using Robotopia.Data;
using Robotopia.Models;
using Robotopia.Models.ServiceModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Robotopia.Services
{
    public class AppUserService : IAppUserService
    {

        private readonly ApplicationDbContext AppDbContext;


        public AppUserService(ApplicationDbContext appDoContext)
        {
            this.AppDbContext = appDoContext;
        }


        public async Task<ServiceAppUserModel> GetUser(int ?id)
        {
            if (id == null)
                return null;

            var User = AppDbContext.Users.Find(id);

            ServiceAppUserModel result = new ServiceAppUserModel(User);            

            return result;
        }

        public async Task<List<ServiceAppUserModel>> GetAllUsers()
        {
            var Users = AppDbContext.Users.ToList();

            List<ServiceAppUserModel> result = new List<ServiceAppUserModel>();

            foreach (var user in Users)
            {
                result.Add(new ServiceAppUserModel(user));
            }    

            return result;
        }

    }
}
