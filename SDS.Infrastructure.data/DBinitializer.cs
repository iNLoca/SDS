using System;
using SDS.Core.DomainService;
using SDS.Core.Entity;

namespace SDS.Infrastructure.data
{
    public class DBinitializer
    {
        private readonly IAvatarRepository _avatarRepository;

        public DBinitializer(IAvatarRepository avatarRepository)
        {
            _avatarRepository = avatarRepository;
        }

        public void InitData()
        {
            _avatarRepository.Create(new Avatar
            {

                Name = "Ban",
                Type = "Greed",
                Birthdate = DateTime.Now.AddYears(-15),
                SoldDate = DateTime.Now.AddYears(-5),
                Color = "Red",
                PreviousOwner = "Nana",
                Price = 2000

            });
            _avatarRepository.Create(new Avatar
            {

                Name = "Kiki",
                Type = "Sloth",
                Birthdate = DateTime.Now.AddYears(-15),
                SoldDate = DateTime.Now.AddYears(-5),
                Color = "Green",
                PreviousOwner = "Koko",
                Price = 5

            });

            _avatarRepository.Create(new Avatar
            {

                Name = "Chili",
                Type = "Wrath",
                Birthdate = DateTime.Now.AddYears(-15),
                SoldDate = DateTime.Now.AddYears(-5),
                Color = "Red",
                PreviousOwner = "Meliodas",
                Price = 3

            });
            _avatarRepository.Create(new Avatar
            {

                Name = "Kirito",
                Type = "Sloth",
                Birthdate = DateTime.Now.AddYears(-15),
                SoldDate = DateTime.Now.AddYears(-5),
                Color = "Green",
                PreviousOwner = "Koko",
                Price = 4

            });
            _avatarRepository.Create(new Avatar
            {

                Name = "Jerry",
                Type = "Greed",
                Birthdate = DateTime.Now.AddYears(-15),
                SoldDate = DateTime.Now.AddYears(-5),
                Color = "Red",
                PreviousOwner = "Nana",
                Price = 2

            });
            _avatarRepository.Create(new Avatar
            {

                Name = "Marry",
                Type = "Sloth",
                Birthdate = DateTime.Now.AddYears(-15),
                SoldDate = DateTime.Now.AddYears(-5),
                Color = "Green",
                PreviousOwner = "Koko",
                Price = 1

            });
        }
    }
}
