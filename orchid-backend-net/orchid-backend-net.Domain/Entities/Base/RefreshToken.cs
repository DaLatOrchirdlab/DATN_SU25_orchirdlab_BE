﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace orchid_backend_net.Domain.Entities.Base
{
    public class RefreshToken
    {
        public required string Token { get; set; }
        public DateTime Created { get; set; } = DateTime.Now;
        public DateTime Expired { get; set; }

    }
}
