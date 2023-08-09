using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models;

public class UserModel
{
    public int Id { get; set; }
    public string Username { get; set; }
    public string Password { get; set; }
    public string FirstName { get; set; }
    public string SecondName { get; set; }
    public string BirthDate { get; set; }
    public string Gender { get; set; }

    public string Email { get; set; }
    public string Telnum { get; set; }
    public int PostCode { get; set; }
    public int HouseNum { get; set; }
    public string Street { get; set; }
    public string City { get; set; }


}
