using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuizAPI.Models
{
    public class User
    {
        public int Id { get; internal set; }
        public string Name { get; internal set; }
        public string Phone { get; internal set; }
        public string Password { get; internal set; }
        public string Address { get; internal set; }
        public string PhotoURL { get; internal set; }

    }
}
