using Microsoft.EntityFrameworkCore;
using pira.Models;

namespace pira.Data
{
    public class FormContext : DbContext
    {
        public DbSet<Form> Presentacion{ get; set; }

        public FormContext(DbContextOptions dco) : base(dco){

        } 
    }
}