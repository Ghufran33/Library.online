using Microsoft.VisualBasic;
using System;

namespace Library.online.Models
{
    public class GraduationProject
    {
        public string  ProjectName { get; set; }
        public int AuthorsId { get; set; }
        public int ProjectId { get; set; }
        public int PageNumbers { get; set; }
        public DateTime  Publication { get; set; }

    }
}
