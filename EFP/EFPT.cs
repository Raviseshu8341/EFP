// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace EFP
{
    public partial class EFPT
    {
        [Key]
        public int Student_id { get; set; }
        [Required]
        [StringLength(50)]
        [Unicode(false)]
        public string Name { get; set; }
        public int Age { get; set; }
        [Required]
        [StringLength(50)]
        [Unicode(false)]
        public string Address { get; set; }
        [Required]
        [StringLength(50)]
        [Unicode(false)]
        public string City { get; set; }
        public bool Is_Deleted { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime Created_Time_Stamp { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime Update_Time_Stamp { get; set; }
    }
}