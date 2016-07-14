using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalDataLayer.Respo
{
    public class ClassManager
    {
        public string GetUserPassword(string Email)
        {
            using (HospitalDbContext db = new HospitalDbContext())
            {
                var user = db.admin.Where(o =>o.Email.ToLower().Equals(Email));
                if (user.Any())
                    return user.FirstOrDefault().Password;
                else
                    return string.Empty;
            }
        }

        
    public bool IsEmailExist(string Email)
        {
            using (HospitalDbContext db = new HospitalDbContext())
            {
                return db.admin.Where(o => o.Email.Equals(Email)).Any();
            }
        }

        public string GetUserFullName(string Email)
        {
            using (HospitalDbContext db = new HospitalDbContext())
            {

                var user = db.admin.Where(u => u.Email.Equals(Email));
                if (user.Any())
                    return user.FirstOrDefault().FirstName;
                else
                    return string.Empty;
            }
        }
        //public bool IsUserInRole(string Email, string roleName)
        //{
        //    using (HospitalDbContext  db = new HospitalDbContext ())
        //    {
        //        SYSUser SU = db.SYSUsers.Where(o => o.Email.ToLower().Equals(Email))?.FirstOrDefault();
        //        if (SU != null)
        //        {
        //            var roles = from q in db.SYSUserRoles
        //                        join r in db.LOOKUPRoles on q.LOOKUPRoleID equals r.LOOKUPRoleID
        //                        where r.RoleName.Equals(roleName) && q.SYSUserID.Equals(SU.SYSUserID)
        //                        select r.RoleName;

        //            if (roles != null)
        //            {
        //                return roles.Any();
        //            }
        //        }

        //        return false;
        //    }
        //}

        //public int GetUserID(string Email)
        //{
        //    using (HospitalDbContext  db = new HospitalDbContext ())
        //    {
        //        var user = db.SYSUsers.Where(o => o.Email.Equals(Email));
        //        if (user.Any())
        //            return user.FirstOrDefault().SYSUserID;
        //    }
        //    return 0;
        //}
    }
}
