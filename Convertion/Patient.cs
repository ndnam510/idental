using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using idental.Domain;
using idental.DaoOD;
using idental.Const;
using idental.Utils;
namespace idental.Convertion
{
    class Patient
    {
        public static void Migrate()
        {
            Logger.start("Patient");
            List<PatientDomain> listPatients = PatientDaoOD.GetListPatients();
            int count = 0, total = listPatients.Count;
            foreach (PatientDomain domain in listPatients)
            {
                #region INSERT_USER
                UserDto userDto = new UserDto();
                userDto.UserType = iDentalSoftConst.Patient.USER_TYPE;
                userDto.FirstName = Convert.ToString(domain.FName).Trim();
                userDto.LastName = Convert.ToString(domain.LName).Trim();
                userDto.MiddleInitial = Convert.ToString(domain.MiddleI).Trim();
                userDto.OtherName = Convert.ToString(domain.Preferred).Trim();
                userDto.PhotoLink = iDentalSoftConst.DEFAULT_PHOTO_LINK;
                userDto.Address = (Convert.ToString(domain.Address) +" "+ Convert.ToString(domain.Address2)).Replace("  "," ").Trim();
                userDto.HomePhone = ConvertionUtils.convertPhoneFax(domain.HmPhone);
                userDto.MobilePhone = ConvertionUtils.convertPhoneFax(domain.WirelessPhone);
                userDto.Email = Convert.ToString(domain.Email);
                userDto.ZipCodeID = ConvertionUtils.FormatZip(Convert.ToString(domain.Zip));
                int insertSuccess = UserDao.InsertUser(userDto);
                if (insertSuccess == 0)
                {
                    Logger.log(++count, total, "Fail insert user:" + userDto.FirstName + " " + userDto.LastName);
                    continue;
                }
                #endregion

                #region INSERT_PATIENT
                Int64 userID = DatabaseUtils.GetLastUserID();
                if (userID == 0)
                    continue;
                PatientDto patient = new PatientDto();
                patient.Title = ConvertionUtils.Patient.convertTitle(domain.Gender);
                patient.Gender = ConvertionUtils.Patient.convertGender(domain.Gender);
                patient.MaritalStatus = iDentalSoftConst.Patient.MARITAL_STATUS;
                patient.MedicalAlert = Convert.ToString(domain.MedUrgNote);
                patient.TimeZone = iDentalSoftConst.Patient.TIME_ZONE;
                patient.OfficePhone = ConvertionUtils.convertPhoneFax(domain.WkPhone);
                patient.ProviderID = Convert.ToInt64(ProviderDao.GetProviderIDbyProviderKey(domain.PriProv.ToString()));
                patient.ResponsibleParty = iDentalSoftConst.Patient.RESPONSIBLE_PARTY;
                patient.Coverage = iDentalSoftConst.Patient.COVERAGE;
                patient.DOB = ConvertionUtils.Patient.convertDate(domain.BirthDate);
                patient.ActiveDate = DateTime.Now.ToString("yyyyMMdd");
                patient.Note = "";
                patient.PracticeID = PracticeDao.GetPracticeID(Practice.s_PracticeName);
                patient.Active = ConvertionUtils.Patient.convertActiceStatus(domain.PatStatus);
                patient.PatientKey = Convert.ToString(domain.PatNum);
                patient.PatientID = Convert.ToString(domain.PatNum);
                patient.PatientIDNumeric = Convert.ToInt64(domain.PatNum);
                patient.UserID = userID;
                insertSuccess = PatientDao.insert(patient);
                if (insertSuccess == 0)
                {
                    Logger.log(++count, total, "Fail insert patient:" + userDto.FirstName + " " + userDto.LastName);
                    continue;
                }
                string logMess = "Insert patient: " + userDto.FirstName + " " + userDto.LastName + " ";
                logMess += string.IsNullOrEmpty(userDto.OtherName) ? "" : "(" + userDto.OtherName + ")";
                Logger.log(++count, total, logMess);
                #endregion
            }
            Logger.end("Patient");
        }
    }
}
