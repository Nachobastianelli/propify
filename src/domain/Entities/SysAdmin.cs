﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace domain.Entities
{
    public class SysAdmin : User
    {
        public SysAdmin() { }

        public SysAdmin(string name, string surname, string email, string password, string numberphone, Enum documentType, string dni) {
            Name = name;
            Surname = surname;
            Email = email;
            Password = password;
            NumberPhone = numberphone;
            DocumentType = documentType;
            Dni = dni;
        }
    }
}
