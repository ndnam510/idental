using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using java.sql;
namespace idental.Utils
{
    class DatabaseUtils
    {
        public static void SetParameters(ref PreparedStatement stat, PatientDto dto)
        {
            stat.setString(1, dto.Title);
            stat.setString(2, dto.Gender);
            stat.setString(3, dto.MaritalStatus);
            stat.setString(4, dto.MedicalAlert);
            stat.setString(5, dto.TimeZone);
            stat.setString(6, dto.OfficePhone);
            stat.setLong(7, dto.ProviderID);
            stat.setString(8, dto.ResponsibleParty);
            stat.setString(9, dto.Coverage);
            stat.setString(10, dto.DOB);
            stat.setString(11, dto.ActiveDate);
            stat.setString(12, dto.Note);
            stat.setLong(13, dto.PracticeID);
            stat.setBoolean(14, dto.Active);
            stat.setString(15, dto.PatientKey);
            stat.setString(16, dto.PatientID);
            stat.setLong(17, dto.PatientIDNumeric);
            stat.setLong(18, dto.UserID);
        }
        public static void SetParameters(ref PreparedStatement stat, ProviderDto dto)
        {
            stat.setLong(1, dto.UserID);
            stat.setInt(2, dto.PracticeID);
            stat.setString(3, dto.ProviderColor);
            stat.setString(4, dto.StaffKey);
            stat.setString(5, dto.DisplayID);
        }
        public static void SetParameters(ref PreparedStatement stat, UserDto dto)
        {
            stat.setString(1, dto.LastName);
            stat.setString(2, dto.MiddleInitial);
            stat.setString(3, dto.FirstName);
            stat.setString(4, dto.PhotoLink);
            stat.setString(5, dto.UserType);
            stat.setString(6, dto.OtherName);
            if (dto.ZipCodeID == 0)
                stat.setNull(7, java.sql.Types.NULL);
            else
                stat.setLong(7, dto.ZipCodeID);
            stat.setString(8, dto.Address);
            stat.setString(9, dto.Email);
            stat.setString(10, dto.HomePhone);
            stat.setString(11, dto.MobilePhone);
        }
        public static string GetSqlCommandText(PatientDto dto)
        {
            string sql = "INSERT INTO PATIENT(";
            sql += "TITLE,GENDER,MARITAL_STATUS,MEDICAL_ALERT,TIME_ZONE,OFFICE_PHONE,PROVIDER_ID,RESPONSIBLE_PARTY,"
                  + "COVERAGE,DOB,ACTIVE_DATE,NOTE,PRACTICE_ID,ACTIVE,PATIENT_KEY,PATIENT_ID,PATIENT_ID_NUMERIC,USER_ID)"
                  + "VALUES(?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?);";
            return sql;
        }
        public static Int64 GetLastUserID()
        {
            string sql = "SELECT MAX(USER_ID) FROM USERS;";
            ResultSet rs = Database.iDentalSoft.ExecuteQuery(sql);
            if (rs.next())
                return rs.getLong(1);
            else
                return 0;
        }
    }
}
