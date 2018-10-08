﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace yanjiuyuanWeb.Models
{
    public class NewErrorModel
    {
        public Error error { get; set; }
        public object data { get; set; }
    }

    public class Error
    {
        public Error(int errorCode, string errorMessage, string content)
        {
            this.errorCode = errorCode;
            this.errorMessage = errorMessage;
            this.content = content;
        }
        public int errorCode { get; set; }

        public string errorMessage { get; set; }

        public string content { get; set; }
    }
}