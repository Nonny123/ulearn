﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VOD.Common.DTOModels;

namespace VOD.Common.Services
{
    public interface IJwtTokenService
    {
        Task<TokenDTO> CreateTokenAsync();
        Task<TokenDTO> GetTokenAsync();
        Task<TokenDTO> CheckTokenAsync(TokenDTO token);
    }
}
