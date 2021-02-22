using Robotopia.Models.ServiceModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Robotopia.Services
{
    public interface IAppUserService
    {


        public Task<ServiceAppUserModel> GetUser(int ?id);
        public Task<List<ServiceAppUserModel>> GetAllUsers();
    }
}
