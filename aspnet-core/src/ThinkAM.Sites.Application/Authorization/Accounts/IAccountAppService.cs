﻿using System.Threading.Tasks;
using Abp.Application.Services;
using ThinkAM.Sites.Authorization.Accounts.Dto;

namespace ThinkAM.Sites.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
