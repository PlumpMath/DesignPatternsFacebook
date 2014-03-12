using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;
using B14_Ex01_Daniel_301840724_Aviv_301547659.Logic;

namespace B14_Ex01_Daniel_301840724_Aviv_301547659
{
    public partial class LoginForm : Form
    {
        private const string k_APPID = "1441993139370754";
        private const int k_CollectionLimit = 10000;
        private readonly string[] k_FaceboookPermissions = 
                    { 
                      "friends_events", "friends_likes", "friends_photos", "user_photos",
                      "publish_actions", "read_stream", "friends_status", "friends_videos" 
                    };

        public LoginForm()
        {
            InitializeComponent();
            FacebookService.s_CollectionLimit = k_CollectionLimit;
        }

        private void login()
        {
            LoginResult result = FacebookService.Login(k_APPID, k_FaceboookPermissions);

            if (result != null && result.LoggedInUser != null)
            {
                setCurrentFacebookUser(result.LoggedInUser);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Failed To Login", "Login Fail", MessageBoxButtons.OK ,MessageBoxIcon.Warning);
            }
        }

        private void setCurrentFacebookUser(User i_LoggedInUser)
        {
            new LoggedInFacebookUser(i_LoggedInUser);
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            login();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
    
