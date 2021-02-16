using KampOdev.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace KampOdev.Concreate
{
    class UserValidationManager : IUserValidationService
    {
        public bool Validation(Player player)
        {
            if (player.FirstName=="Rıfat" && player.LastName=="Kaşıkçı" && player.IdentityNumber=="12345678901" && player.DateOfBirth.Year==2006)
            {
                return true;
            }
            else
            {
                throw new Exception("invalid player");
            }
        }
    }
}
