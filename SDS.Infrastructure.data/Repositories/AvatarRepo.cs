using System.Collections.Generic;
using System.IO;
using SDS.Core.DomainService;
using SDS.Core.Entity;

namespace SDS.Infrastructure.data.Repositories
{
    public class AvatarRepo:IAvatarRepository
    {
        static int id = 1;
        private static List<Avatar> _avatarLst = new List<Avatar>();
        
        

        public Avatar Create(Avatar avatar)
        {
            avatar.Id = id++;
            _avatarLst.Add(avatar);
            return avatar;
        }

        public IEnumerable<Avatar> ReadAllAvatars()
        {
            return _avatarLst;
        }

        public Avatar GetAvatarById(int id)
        {
            foreach (var avatar in _avatarLst)
            {
                if (avatar.Id == id)
                {
                    return avatar;
                }
            }
            return null;
        }


        public Avatar Update(Avatar avatarUpdate)
        {
            var avatarFromDB = this.GetAvatarById(avatarUpdate.Id);
            if (avatarFromDB != null)
            {
                avatarFromDB.Name = avatarUpdate.Name;
                avatarFromDB.Type = avatarUpdate.Type;
                avatarFromDB.Birthdate = avatarUpdate.Birthdate;
                avatarFromDB.SoldDate = avatarUpdate.SoldDate;
                avatarFromDB.Color = avatarUpdate.Color;
                avatarFromDB.PreviousOwner = avatarUpdate.PreviousOwner;
                avatarFromDB.Price = avatarUpdate.Price;

                return avatarFromDB;
            }

            return null;
        }

        public Avatar Delete(int id)
        {
            var avatarFound = this.GetAvatarById(id);
            if (avatarFound != null)
            {
                _avatarLst.Remove(avatarFound);
                return avatarFound;
            }
            return null;
        }
       



    }
}
