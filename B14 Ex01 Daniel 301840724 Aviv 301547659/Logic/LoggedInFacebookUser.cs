
namespace B14_Ex01_Daniel_301840724_Aviv_301547659.Logic
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using FacebookWrapper.ObjectModel;

    public class LoggedInFacebookUser
    {
        private static User m_FacebookUser;

        public LoggedInFacebookUser(User i_LoggedInUser)
        {
            m_FacebookUser = i_LoggedInUser;
        }

        public static User User 
        {
            get { return m_FacebookUser; }
        }
    }


    //private class Singleton
    //{
    //    private static Singleton instance;

    //    private Singleton() { }

    //    public static Singleton getInstance()
    //    {
    //        if (instance == null)
    //        {
    //            instance = new Singleton();
    //        }
    //        return instance;
    //    }

    //}




}
