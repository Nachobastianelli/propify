using domain.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace application.DTOs
{
    public class AddClientRequest
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        public string Password { get; set; }
        public string NumberPhone { get; set; }
        public DocumentType DocumentType { get; set; }
        public string Dni { get; set; }
    }
}
