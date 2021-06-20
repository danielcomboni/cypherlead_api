﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace Cypherlead.Api.ViewModels
{
    public class CustomerViewModel : BaseViewModel
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public JsonDocument ExtraDetails { get; set; }
    }
}
