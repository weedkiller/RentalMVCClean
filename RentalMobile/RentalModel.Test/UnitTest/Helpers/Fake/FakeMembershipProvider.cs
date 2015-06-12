﻿using System;
using System.Collections.Specialized;
using System.Data.Odbc;
using System.Web.Security;

namespace TestProject.UnitTest.Helpers.Fake
{

    public  class FakeMembershipProvider : MembershipProvider
    {
        private string _applicationName = "";
        private bool _enablePasswordReset = true;
        private bool _enablePasswordRetrieval = true;
        private bool _requiresQuestionAndAnswer = true;
        private bool _requiresUniqueEmail = true;
        private int _maxInvalidPasswordAttempts = 0;
        private int _passwordAttemptWindow = 0;
        private MembershipPasswordFormat _passwordFormat = MembershipPasswordFormat.Encrypted;
        private int _minRequiredNonAlphanumericCharacters = 0;
        private int _minRequiredPasswordLength = 3;
        private string _passwordStrengthRegularExpression = "";

        public static MembershipUser FakeUserFred = new MembershipUser("AspNetSqlMembershipProvider", "fred", "fredKey",
            "fred@microsoft.com", "Mother's maiden name", "fake existing user", true, false,
            DateTime.Now.Subtract(TimeSpan.FromDays(10.0)), DateTime.Now.Subtract(TimeSpan.FromDays(2.0)),
            DateTime.Now.Subtract(TimeSpan.FromDays(2.0)), DateTime.Now.Subtract(TimeSpan.FromDays(8.0)),
            DateTime.Now.Subtract(TimeSpan.FromDays(9.0)));

        public static MembershipUser FakeUserLisa = new MembershipUser("AspNetSqlMembershipProvider", "lisa", "lisaKey",
            "lisa@microsoft.com", "Cat's middle name", "fake new user", true, false,
            DateTime.Now.Subtract(TimeSpan.FromDays(40.0)), DateTime.Now.Subtract(TimeSpan.FromDays(4.0)),
            DateTime.Now.Subtract(TimeSpan.FromDays(4.0)), DateTime.Now.Subtract(TimeSpan.FromDays(28.0)),
            DateTime.Now.Subtract(TimeSpan.FromDays(29.0)));

        private string _fakePasswordFred = "css!";
        private string _fakeAnswerFred = "Flintstone";
        private string _fakePasswordLisa = "css!";
        private string _fakeAnswerLisa = "Libby";

        public override string ApplicationName
        {
            get { return _applicationName; }
            set { _applicationName = value; }
        }

        public override bool EnablePasswordReset
        {
            get { return _enablePasswordReset; }
        }

        public override bool EnablePasswordRetrieval
        {
            get { return _enablePasswordRetrieval; }
        }

        public override bool RequiresQuestionAndAnswer
        {
            get { return _requiresQuestionAndAnswer; }
        }

        public override bool RequiresUniqueEmail
        {
            get { return _requiresUniqueEmail; }
        }

        public override int MaxInvalidPasswordAttempts
        {
            get { return _maxInvalidPasswordAttempts; }
        }

        public override int PasswordAttemptWindow
        {
            get { return _passwordAttemptWindow; }
        }

        public override MembershipPasswordFormat PasswordFormat
        {
            get { return _passwordFormat; }
        }

        public override int MinRequiredNonAlphanumericCharacters
        {
            get { return _minRequiredNonAlphanumericCharacters; }
        }

        public override int MinRequiredPasswordLength
        {
            get { return _minRequiredPasswordLength; }
        }

        public override string PasswordStrengthRegularExpression
        {
            get { return _passwordStrengthRegularExpression; }
        }

        // See...
        // http://windowssdk.msdn.microsoft.com/en-us/library/6tc47t75.aspx
        public override void Initialize(string name, NameValueCollection config)
        {
            if (config == null)
            {
                throw new ArgumentNullException("config");
            }

            // Initialize the abstract base class.
            base.Initialize(name, config);

            _applicationName = GetConfigValue(config["applicationName"],
                System.Web.Hosting.HostingEnvironment.ApplicationVirtualPath);
            _minRequiredNonAlphanumericCharacters =
                Convert.ToInt32(GetConfigValue(config["minRequiredNonAlphanumericCharacters"], "0"));
            _minRequiredPasswordLength = Convert.ToInt32(GetConfigValue(config["minRequiredPasswordLength"], "3"));
            _passwordStrengthRegularExpression =
                Convert.ToString(GetConfigValue(config["passwordStrengthRegularExpression"], ""));
            _enablePasswordReset = Convert.ToBoolean(GetConfigValue(config["enablePasswordReset"], "true"));
            _enablePasswordRetrieval = Convert.ToBoolean(GetConfigValue(config["enablePasswordRetrieval"], "true"));
            _requiresQuestionAndAnswer =
                Convert.ToBoolean(GetConfigValue(config["requiresQuestionAndAnswer"], "true"));
            _requiresUniqueEmail = Convert.ToBoolean(GetConfigValue(config["requiresUniqueEmail"], "true"));
        }

        // See...
        // http://windowssdk.msdn.microsoft.com/en-us/library/6tc47t75.aspx
        private string GetConfigValue(string configValue, string defaultValue)
        {
            if (String.IsNullOrEmpty(configValue))
            {
                return defaultValue;
            }

            return configValue;
        }

        public override bool ChangePassword(string username, string oldPwd, string newPwd)
        {
            bool bRet = false;
            if (((username == FakeUserFred.UserName) && (oldPwd == _fakePasswordFred)) ||
                ((username == FakeUserLisa.UserName) && (oldPwd == _fakePasswordLisa)))
            {
                bRet = true;
            }
            return bRet;
        }

        public override bool ChangePasswordQuestionAndAnswer(string username, string password, string newPwdQuestion,
            string newPwdAnswer)
        {
            bool bRet = false;
            if (((username == FakeUserFred.UserName) && (password == _fakePasswordFred)) ||
                ((username == FakeUserLisa.UserName) && (password == _fakePasswordLisa)))
            {
                bRet = true;
            }
            return bRet;
        }

        public override MembershipUser CreateUser(string username, string password, string email,
            string passwordQuestion, string passwordAnswer,
            bool isApproved, object providerUserKey, out MembershipCreateStatus status)
        {
            MembershipUser userRet = null;
            status = MembershipCreateStatus.UserRejected;
            if (((username == FakeUserFred.UserName) && (password == _fakePasswordFred)) ||
                ((username == FakeUserLisa.UserName) && (password == _fakePasswordLisa)))
            {
                userRet = (username == FakeUserFred.UserName) ? FakeUserFred : FakeUserLisa;
                status = MembershipCreateStatus.Success;
            }
            return userRet;
        }

        public override bool DeleteUser(string username, bool deleteAllRelatedData)
        {
            bool bRet = false;
            if ((username == FakeUserFred.UserName) || (username == FakeUserLisa.UserName))
            {
                bRet = true;
            }
            return bRet;
        }

        public override MembershipUserCollection GetAllUsers(int pageIndex, int pageSize, out int totalRecords)
        {
            totalRecords = 2;
            MembershipUserCollection coll = new MembershipUserCollection();
            coll.Add(FakeUserFred);
            coll.Add(FakeUserLisa);
            return coll;
        }

        public override int GetNumberOfUsersOnline()
        {
            return 2;
        }

        public override string GetPassword(string username, string answer)
        {
            //  From the MSDN documentation:
            //
            //  Takes, as input, a user name and a password answer and retrieves the password for that user
            //  from the data source and returns the password as a string.
            //
            //  The GetPassword method ensures that the EnablePasswordRetrieval flag is set to true before
            //  performing any action. If EnablePasswordRetrieval is false, a NotSupportedException exception
            //  is thrown.
            //
            //  GetPassword also checks the value of the RequiresQuestionAndAnswer property. If
            //  RequiresQuestionAndAnswer is true, GetPassword checks the value of the supplied answer 
            //  parameter against the stored password answer in the data source. If they do not match,
            //  a MembershipPasswordException exception is thrown.
            //
            //  (And... but not relevant here...)
            //  If your custom membership provider supports hashed passwords, the GetPassword method should return
            //  an exception if the EnablePasswordRetrieval property is set to true and the password format is set
            //  to Hashed. Hashed passwords cannot be retrieved.

            string strRet = "";

            if (EnablePasswordRetrieval)
            {
                if (RequiresQuestionAndAnswer)
                {
                    if ((username == FakeUserFred.UserName) && (_fakeAnswerFred == answer))
                    {
                        strRet = _fakeAnswerFred;
                    }
                    else if ((username == FakeUserLisa.UserName) && (_fakeAnswerLisa == answer))
                    {
                        strRet = _fakePasswordLisa;
                    }
                    else
                    {
                        throw (new MembershipPasswordException());
                    }
                }
            }
            else
            {
                throw (new NotSupportedException());
            }

            return strRet;
        }

        public override MembershipUser GetUser(string username, bool userIsOnline)
        {
            MembershipUser userRet = null;
            if (username == FakeUserFred.UserName)
            {
                userRet = FakeUserFred;
            }
            else if (username == FakeUserLisa.UserName)
            {
                userRet = FakeUserLisa;
            }
            return userRet;
        }

        public override MembershipUser GetUser(object providerUserKey, bool userIsOnline)
        {
            MembershipUser userRet = null;
            if (providerUserKey == FakeUserFred.ProviderUserKey)
            {
                userRet = FakeUserFred;
            }
            else if (providerUserKey == FakeUserLisa.ProviderUserKey)
            {
                userRet = FakeUserLisa;
            }
            return userRet;
        }

        private MembershipUser GetUserFromReader(OdbcDataReader reader)
        {
            return null;
        }

        public override bool UnlockUser(string username)
        {
            return true;
        }

        public override string GetUserNameByEmail(string email)
        {
            string strRet = "";
            if (email == FakeUserFred.Email)
            {
                strRet = _fakeAnswerFred;
            }
            else if (email == FakeUserLisa.Email)
            {
                strRet = _fakePasswordLisa;
            }
            return strRet;
        }

        public override string ResetPassword(string username, string answer)
        {
            //  From MSDN documentation:
            //
            //  ResetPassword ensures that the EnablePasswordReset flag is set to true before performing any action.
            //  If EnablePasswordReset is false, a NotSupportedException exception is thrown.
            //
            //  ResetPassword also checks the value of the RequiresQuestionAndAnswer property. If
            //  RequiresQuestionAndAnswer is true, ResetPassword checks the value of the supplied answer parameter
            //  against the stored password answer in the data source. If they do not match, a
            //  MembershipPasswordException exception is thrown.

            string strRet = "";

            if (EnablePasswordReset)
            {
                if (RequiresQuestionAndAnswer)
                {
                    if ((username == FakeUserFred.UserName) && (_fakeAnswerFred == answer))
                    {
                        strRet = _fakeAnswerFred;
                    }
                    else if ((username == FakeUserLisa.UserName) && (_fakeAnswerLisa == answer))
                    {
                        strRet = _fakePasswordLisa;
                    }
                    else
                    {
                        throw (new MembershipPasswordException());
                    }
                }
                else
                {
                    if (username == FakeUserFred.UserName)
                    {
                        strRet = _fakeAnswerFred;
                    }
                    else if (username == FakeUserLisa.UserName)
                    {
                        strRet = _fakePasswordLisa;
                    }
                    else
                    {
                        throw (new MembershipPasswordException());
                    }
                }
            }
            else
            {
                throw (new NotSupportedException());
            }

            return strRet;
        }

        public override void UpdateUser(MembershipUser user)
        {
        }

        public override bool ValidateUser(string username, string password)
        {
            bool bRet = false;
            if (((username == FakeUserFred.UserName) && (password == _fakePasswordFred)) ||
                ((username == FakeUserLisa.UserName) && (password == _fakePasswordLisa)))
            {
                bRet = true;
            }
            return bRet;
        }

        public override MembershipUserCollection FindUsersByName(string usernameToMatch, int pageIndex, int pageSize,
            out int totalRecords)
        {
            totalRecords = 0;
            MembershipUserCollection coll = new MembershipUserCollection();
            if (usernameToMatch == FakeUserFred.UserName)
            {
                coll.Add(FakeUserFred);
                totalRecords = 1;
            }
            else if (usernameToMatch == FakeUserLisa.UserName)
            {
                coll.Add(FakeUserLisa);
                totalRecords = 1;
            }
            return coll;
        }

        public override MembershipUserCollection FindUsersByEmail(string emailToMatch, int pageIndex, int pageSize,
            out int totalRecords)
        {
            totalRecords = 0;
            MembershipUserCollection coll = new MembershipUserCollection();
            if (emailToMatch == FakeUserFred.Email)
            {
                coll.Add(FakeUserFred);
                totalRecords = 1;
            }
            else if (emailToMatch == FakeUserLisa.Email)
            {
                coll.Add(FakeUserLisa);
                totalRecords = 1;
            }
            return coll;
        }
    }
}
