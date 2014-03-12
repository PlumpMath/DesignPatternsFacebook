using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using B14_Ex01_Daniel_301840724_Aviv_301547659.Logic;

namespace B14_Ex01_Daniel_301840724_Aviv_301547659
{
    public partial class MainForm : Form
    {
        private LoginForm m_LoginForm;
        private StatisticsForm m_StatisticsForm;
        private FunnyForm m_FunnyForm;

        public MainForm()
        {
            InitializeComponent();
            m_FunnyForm = new FunnyForm();
            m_StatisticsForm = new StatisticsForm();
            m_LoginForm = new LoginForm();
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            showLoginForm();
        }

        private void loadUserProfilePicture()
        {
            PictureBoxUser.LoadAsync(LoggedInFacebookUser.User.PictureSqaureURL);
        }

        private void showLoginForm()
        {
            if (m_LoginForm.ShowDialog() == DialogResult.Cancel)
            {
                this.Close();
            }
            else
            {
                updateGUIWithFacebookUserInfo();
            }
        }

        private void updateGUIWithFacebookUserInfo()
        {
            loadUserProfilePicture();
            labelWelcome.Text = "Logged In As : " + LoggedInFacebookUser.User.Name;
        }

        private void buttonUploadFunny_Click(object sender, EventArgs e)
        {
            m_FunnyForm.Show();
        }

        private void buttonGetStatics_Click(object sender, EventArgs e)
        {
           m_StatisticsForm.Show();
        }
    }
}
    

