using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using idental.Dao;
using idental.Domain;
using idental.Utils;
using idental.Const;
namespace idental.Convertion
{
    class Provider
    {
        public static void Migrate()
        {
            Logger.start("Provider");
            List<ProviderDomain> listProviderDomain = ProviderDaoOD.getProviders();
            int total = listProviderDomain.Count;
            int count = 0;
            foreach (ProviderDomain domain in listProviderDomain)
            {
                #region INSERT_USER
                UserDto userDto = new UserDto();
                userDto.UserType = iDentalSoftConst.USER_PROVIDER_TYPE;
                userDto.FirstName = Convert.ToString(domain.FName);
                userDto.LastName = Convert.ToString(domain.LName);
                userDto.MiddleInitial = Convert.ToString(domain.MI);
                userDto.OtherName = Convert.ToString(domain.Abbr);
                userDto.PhotoLink = iDentalSoftConst.DEFAULT_PHOTO_LINK;
                userDto.Address = "";
                userDto.HomePhone = "";
                userDto.MobilePhone = "";
                userDto.Email = "";
                int insertSuccess = UserDao.InsertUser(userDto);
                if (insertSuccess==0) 
                {
                    Logger.log(++count, total, "Fail insert user:" + userDto.FirstName + " " + userDto.LastName);
                    continue;
                }
                #endregion

                #region INSERT_PROVIDER
                Int64 userID = DatabaseUtils.GetLastUserID();
                if (userID == 0)
                    continue;
                ProviderDto providerDto = new ProviderDto();
                providerDto.DisplayID = Convert.ToString(domain.Abbr);
                providerDto.ProviderColor = Convert.ToString(domain.ProvColor);
                providerDto.StaffKey = Convert.ToString(domain.ProvNum);
                providerDto.PracticeID = PracticeDao.GetPracticeID(Practice.s_PracticeName);
                providerDto.UserID = userID;
                insertSuccess = ProviderDao.InsertStaffPractice(providerDto);
                if (insertSuccess==0)
                {
                    Logger.log(++count, total, "Fail insert provider:" + userDto.FirstName + " " + userDto.LastName);
                    continue;
                }
                Logger.log(++count, total, "Insert provider: " + userDto.FirstName + " " + userDto.LastName + "(" + userDto.OtherName + ")");
                #endregion
            }
            Logger.end("Provider");
        }
    }
}
