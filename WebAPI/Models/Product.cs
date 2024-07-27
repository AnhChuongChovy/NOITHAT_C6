﻿using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebAppBlazor.Models
{
    public class Product
    {
        [Required]
        public int ID { get; set; }
        public int IDLoaiDM { get; set; }
        [Required]
        public string TenSP { get; set; }
        [Required]
        public double Gia { get; set; }
        [Required]
        public string MoTa { get; set; }
        [Required]
        public string VatLieu { get; set; }
        [Required]
        public int SoLuongTrongKho  { get; set; }
        [Required]
        public string KichThuoc { get; set; }
        public ICollection<BillDetail> BillDetail { get; set; }
        public ICollection<ProductImage> ProductImage { get; set; }
        public ICollection<Reviews> Reviews { get; set; }
        public ICollection<Favourite> Favourite { get; set; }
        public ICollection<Voucher> Voucher { get; set; }
        public CategoryType CategoryType { get; set; }

    }
}
