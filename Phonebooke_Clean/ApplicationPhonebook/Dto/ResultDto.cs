﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationPhonebook.Dto
{
    public class ResultDto
    {
        public bool IsSuccess { get; set; }
        public required string Message { get; set; }
    }

    public class ResultDto<T>
    {
        public bool IsSuccess { get; set; }
        public required string Message { get; set; }
        public required T Data { get; set; }
    }
}
