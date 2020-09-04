using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using SDS.Core.DomainService;
using SDS.Core.Entity;

namespace SDS.Core.AplicationService.Services
{
    public class AvatarService : IAvatarService
    {
        private readonly IAvatarRepository _avatarRepo;

        public static IEnumerable<Avatar> avatarList; //

        public AvatarService(IAvatarRepository avatarRepo)
        {
            _avatarRepo = avatarRepo;
        }

        public Avatar Create(Avatar avatar)
        {
            if (avatar.Name.Length < 1)
            {
                throw new InvalidDataException("Name must be atleast 1 charecter");
            }
            return _avatarRepo.Create(avatar);
        }

        public Avatar CreateAvatar(string name, string type, DateTime birthdate, DateTime soldDate, string color, string previousOwner, double price)
        {
            var avatar = new Avatar()
            {
                Name = name,
                Type = type,
                Birthdate = birthdate,
                SoldDate = soldDate,
                Color = color,
                PreviousOwner = previousOwner,
                Price = price

            };
            return avatar;
        }

        public Avatar FindAvatarById(int id)
        {
            return _avatarRepo.GetAvatarById(id);
        }

        public List<Avatar> GetAvatars()
        {
            return _avatarRepo.ReadAllAvatars().ToList();
        }

        public Avatar UpdateAvatar(Avatar avatarUpdate)
        {
            var avatarFromDB = FindAvatarById(avatarUpdate.Id);
            if (avatarFromDB != null)
            {
                avatarFromDB.Name = avatarUpdate.Name;
                avatarFromDB.Type = avatarUpdate.Type;
                avatarFromDB.Birthdate = avatarUpdate.Birthdate;
                avatarFromDB.SoldDate = avatarUpdate.SoldDate;
                avatarFromDB.Color = avatarUpdate.Color;
                avatarFromDB.PreviousOwner = avatarUpdate.PreviousOwner;
                avatarFromDB.Price = avatarUpdate.Price;


            }
            return avatarFromDB;
        }

        public Avatar DeleteAvatar(int id)
        {
           return _avatarRepo.Delete(id);
        }


        //public Avatar Delete(Avatar avatar)
        //{
        //    if (avatar.Id < 1)
        //    {
        //        throw new InvalidDataException("Id must be atleast 1 charecter");
        //    }
        //    return _avatarRepo.Delete(avatar);
    
    
       

        public Avatar Update(Avatar avatar)
        {
            if(avatar.Name.Length<1)
            {
                throw new InvalidDataException("Name must be atleast 1 charecter");
            }
            return _avatarRepo.Update(avatar);
  
        }

        static void ListAvatars()
        {
            foreach(var avatar in avatarList)
            {
                Console.WriteLine($"Id: {avatar.Id}\n Type: {avatar.Type}\n Birthdate: { avatar.Birthdate}\n Sold date: {avatar.SoldDate}\n Color: {avatar.Color}\n Previous Owner: {avatar.PreviousOwner}\n Price: {avatar.Price}\n");
            }
        }

        public List<Avatar> ReadAllAvatars()
        {
            return _avatarRepo.ReadAllAvatars().ToList();
        }
    }
}
