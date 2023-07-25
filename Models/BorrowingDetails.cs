using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic;
using System;
using System.ComponentModel.DataAnnotations;

namespace Library.online.Models
{
    public class BorrowingDetails
    {

        public int ProjectId { get; set; }
        public int OrderNum { get; set; }
        public DateTime BorrowTime { get; set; }
        public int Priod { get; set; }


    }
   
}
