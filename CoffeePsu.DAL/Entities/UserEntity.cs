using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeePsu.DAL.Entities
{
    public class UserEntity
    {
    public Guid Id { get; set; }
    public string Login { get; set; }
    public string Password { get; set; }
    }
}
