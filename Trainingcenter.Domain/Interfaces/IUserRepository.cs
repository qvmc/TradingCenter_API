﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Trainingcenter.Domain.DomainModels;

namespace Trainingcenter.Domain.Interfaces
{
    interface IUserRepository
    {
        Task<User> GetFromIdAsync(int userId);
        Task<User> GetFromUsernameAsync(string username);

        Task<List<User>> GetAllAsync();
    }
}
