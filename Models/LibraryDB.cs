using Library.online.Models;
using Microsoft.EntityFrameworkCore;
using static System.Net.Mime.MediaTypeNames;

namespace Library.online.Models
{
    public class LibraryDB : DbContext
    {
        public LibraryDB(DbContextOptions<LibraryDB> options)
            : base(options)
        {
        }
        public virtual DbSet<Users> Users { get; set; }
        public virtual DbSet<GraduationProject> GraduationProjects { get; set; }
        public virtual DbSet<BorrowingDetails> BorrowingDetails { get; set; }
        public virtual DbSet<Borrow> Borrows { get; set; }
        public virtual DbSet<Authors> Authors { get; set; }
        
    }
}
