﻿using BE_DATN.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace BE_DATN.Data.Entities
{
    public class ThuongHieu
    {
        public int IdThuongHieu { get; set; }
        public string TenThuongHieu { get; set; }
        public string MoTa { get; set; }
        public Status TrangThai { get; set; }

    }

}
