using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace domain.Entities
{
    public class Owner : User
    { 
        public int PropertyId { get; set; }
        public Property Property { get; set; }

        public int Cvu {  get; set; }

        public Owner() { }

        public Owner(string name, string surname, string email, string password, string numberphone, Enum documentType, string dni,int propertyId, int cvu) 
        { 
            Name = name;
            Surname = surname;
            Email = email;  
            Password = password;
            NumberPhone = numberphone;
            DocumentType = documentType;
            Dni = dni;
            PropertyId = propertyId;
            
            Cvu = cvu;
        }
    }
}
