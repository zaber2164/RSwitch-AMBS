using System;

namespace RSwitch.AMBS.Model.User
{
    public partial class LoginUser: BaseEntity
    {
        public string Login { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; }
        public Levels Level { get; set; }
        public DateTime? LastLoginDate { get; set; }
        public DateTime LastModificationDate { get; set; }
        public  DateTime? PasswordResetDate {get;set;}
        public DateTime? LastPasswordChangeDate {get;set;}
        public  int UnsuccessfulLoginAttempts {get;set;}
        public int SuccessfulLogin {get;set;}
        public LoginStatuses LoginStatus {get;set;}
        public DateTime CreatedDate  {get;set;}
        public string CreatedBy {get;set;}
        public string LastModifiedBy {get;set;}
  
        public string Token {get;set;}
        public long? HRM_EmployeeId {get;set;}
        public string PasswordHistory {get;set;}
        public bool Is2FAFingerEnabled { get;set;}
        public bool? IsEmailOTPEnabled {get;set;}
        public bool? IsSmslOTPEnabled {get;set;}
        public string RefreshToken { get; set; }
        public DateTime? RefreshTokenExpiryDate { get; set; }


        public enum Levels
        {
            Field = 1,
            Head_Office = 2,
            Holding = 3
        }

        public enum LoginStatuses
        {
            LoggedIn = 1,
            LoggedOut = 2
        }
    }
}
