namespace LAB03.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Book")]
    public partial class Book
    {
        [Required(ErrorMessage = "ID khong duoc de trong")]
        public int ID { get; set; }

        [Required(ErrorMessage = "Tieu de khong duoc de trong")]
        [StringLength(255, ErrorMessage = "Tieu de khong duoc qua 255 ky tu")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Mo ta khong duoc de trong")]
        [StringLength(255, ErrorMessage = "Mo ta khong duoc qua 255 ky tu")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Tac gia khong duoc de trong")]
        [StringLength(30, ErrorMessage = "Ten tac gia khong duoc qua 30 ky tu")]
        public string Author { get; set; }

        [Required(ErrorMessage = "Hinh anh khong duoc de trong")]
        [StringLength(255)]
        public string Images { get; set; }

        [Required(ErrorMessage = "Tieu de khong duoc de trong")]
        [Range(1000, 1000000, ErrorMessage = "Gia sach tu 1000 den 1000000")]
        public int Price { get; set; }
    }
}
