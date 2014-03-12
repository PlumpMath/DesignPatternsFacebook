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
using System.Diagnostics;
using System.IO;
using System.CodeDom.Compiler;

namespace B14_Ex01_Daniel_301840724_Aviv_301547659
{
    public partial class FunnyForm : Form
    {
        private List<RagePerson> m_AllRagePersons;
        private int m_CurrentStartRangeDisplayedIndex = 0;
        private int m_currentPicBoxIndex;
        private PictureBox[] m_RagePersonsTinyPictureBoxes;
        private const int k_RageTinyBoxesAmount = 24;
 
        public FunnyForm()
        {
            InitializeComponent();
            m_AllRagePersons = new List<RagePerson>();
        }

        private void loadDefaultImages()
        {
            pictureBoxFriend.Image = Properties.Resources.madness_this_is_sparta;
            pictureBoxChoosenFriend.Image = Properties.Resources.madness_this_is_sparta;
        }

        protected override void OnShown(EventArgs e)
        {
            WebServerController serverController = new WebServerController();
            serverController.m_notifyFinishedLoadingRagePersons += onRagePersonsDownloadedFromServer;
            serverController.LoadRagePersonsFromServer();
            loadDefaultImages();
            populateFriendsList();
        }

        private void populateRagePictureBoxes()
        {
            m_RagePersonsTinyPictureBoxes = new PictureBox[k_RageTinyBoxesAmount];
            for (int i = 0; i < k_RageTinyBoxesAmount; i++)
            {
                 m_RagePersonsTinyPictureBoxes[i] = new PictureBox();
                 m_RagePersonsTinyPictureBoxes[i].Size = new Size(70, 70);
                 m_RagePersonsTinyPictureBoxes[i].SizeMode = PictureBoxSizeMode.Zoom;
                 m_RagePersonsTinyPictureBoxes[i].Click += new EventHandler(OnRageTinyPicClick);
                 panelRagePersons.Controls.Add(m_RagePersonsTinyPictureBoxes[i]);
             }
        }

        private void OnRageTinyPicClick(Object sender, EventArgs e)
        {
            unMarkTinyRageFaceAsSelected();
            m_currentPicBoxIndex = findPicBoxIndexInCollection(sender as PictureBox);
            markTinyRageFaceAsSelected();
            showBigRageFaceImageUsingCurrentTinyRagePicBox();
        }

        private int findPicBoxIndexInCollection(PictureBox i_PictureBoxToFind)
        {
            int index = 0;
            foreach (PictureBox picBox in m_RagePersonsTinyPictureBoxes)
            {
                if (picBox == i_PictureBoxToFind)
                {
                    break;
                }

                index++;
            }
            return index;
        }

        private void loadRageImagesToPicBoxesAsync()
        {
            int index = m_CurrentStartRangeDisplayedIndex;
            foreach(PictureBox picBox in m_RagePersonsTinyPictureBoxes)
            {
                if (index < m_AllRagePersons.Count)
                {
                    picBox.LoadAsync(m_AllRagePersons[index].jpg);
                    index++;
                }
            }
        }

        private void onRagePersonsDownloadedFromServer(List <RagePerson> i_RagePersons)
        {
            m_AllRagePersons = i_RagePersons;
            populateRagePictureBoxes();
            loadRageImagesToPicBoxesAsync();
            showBigRageFaceImageUsingCurrentTinyRagePicBox();
            markTinyRageFaceAsSelected();
        }


        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            e.Cancel = true;
            Hide();
        }

        private void showBigRageFaceImageUsingCurrentTinyRagePicBox()
        {
            pictureBoxRageFace.LoadAsync(m_AllRagePersons[m_CurrentStartRangeDisplayedIndex + m_currentPicBoxIndex].jpg);
        }

        private void markTinyRageFaceAsSelected()
        {
            m_RagePersonsTinyPictureBoxes[m_currentPicBoxIndex].BorderStyle = BorderStyle.FixedSingle;
            m_RagePersonsTinyPictureBoxes[m_currentPicBoxIndex].BackColor = System.Drawing.SystemColors.ActiveCaption;
        }

        private void unMarkTinyRageFaceAsSelected()
        {
            m_RagePersonsTinyPictureBoxes[m_currentPicBoxIndex].BorderStyle = BorderStyle.None;
            m_RagePersonsTinyPictureBoxes[m_currentPicBoxIndex].BackColor = DefaultBackColor;
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            if (m_currentPicBoxIndex < k_RageTinyBoxesAmount - 1)
            {
                unMarkTinyRageFaceAsSelected();
                m_currentPicBoxIndex++;
                markTinyRageFaceAsSelected();
                showBigRageFaceImageUsingCurrentTinyRagePicBox();
            }
        }

        private void buttonPrev_Click(object sender, EventArgs e)
        {
            if (m_currentPicBoxIndex > 0)
            {
                unMarkTinyRageFaceAsSelected();
                m_currentPicBoxIndex--;
                markTinyRageFaceAsSelected();
                showBigRageFaceImageUsingCurrentTinyRagePicBox();
            }
        }

        private void buttonNextFaces_Click(object sender, EventArgs e)
        {
            int nextStartIndex = m_CurrentStartRangeDisplayedIndex + k_RageTinyBoxesAmount;
            if (nextStartIndex < m_AllRagePersons.Count)
            {
                m_CurrentStartRangeDisplayedIndex = nextStartIndex;
                showNextSeriesOfRageFaces();
            }
        }

        private void showNextSeriesOfRageFaces()
        {
            loadRageImagesToPicBoxesAsync();
            unMarkTinyRageFaceAsSelected();
            m_currentPicBoxIndex = 0;
            markTinyRageFaceAsSelected();
            showBigRageFaceImageUsingCurrentTinyRagePicBox();
        }

        private void buttonPrevFaces_Click(object sender, EventArgs e)
        {
            int nextStartIndex = m_CurrentStartRangeDisplayedIndex - k_RageTinyBoxesAmount;
            if (nextStartIndex >= 0)
            {
                m_CurrentStartRangeDisplayedIndex = nextStartIndex;
                showNextSeriesOfRageFaces();
            }
        }

        private void buttonSaveImage_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.InitialDirectory = Convert.ToString(Environment.SpecialFolder.MyDocuments);
            saveFileDialog1.Filter = "JPG Image (*.JPG)|*.jpg|All Files (*.*)|*.*"; 
            saveFileDialog1.FilterIndex = 1;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBoxRageFace.Image.Save(saveFileDialog1.FileName);
                MessageBox.Show("Image Saved", "Saved Successfully", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
        }

        private void buttonRemoveFriend_Click(object sender, EventArgs e)
        {
            if (listBoxRageChoosenFriends.SelectedIndex >= 0)
            {
                listBoxRageFriendsList.Items.Add(listBoxRageChoosenFriends.SelectedItem as User);
                listBoxRageChoosenFriends.Items.Remove(listBoxRageChoosenFriends.SelectedItem as User);
                pictureBoxChoosenFriend.Image = Properties.Resources.madness_this_is_sparta;
            }
        }

        private void buttonAddFriend_Click(object sender, EventArgs e)
        {
            if (listBoxRageFriendsList.SelectedIndex >= 0)
            {
                listBoxRageChoosenFriends.Items.Add(listBoxRageFriendsList.SelectedItem as User);
                listBoxRageFriendsList.Items.Remove(listBoxRageFriendsList.SelectedItem as User);
                pictureBoxFriend.Image = Properties.Resources.madness_this_is_sparta;
            }
        }

        private void populateFriendsList()
        {
            listBoxRageFriendsList.DisplayMember = "Name";
            listBoxRageChoosenFriends.DisplayMember = "Name";
            foreach (User friend in LoggedInFacebookUser.User.Friends)
            {
                listBoxRageFriendsList.Items.Add(friend);
            }
        }


        private void buttonSubmitPost_Click(object sender, EventArgs e)
        {
            string imageURI = m_AllRagePersons[m_currentPicBoxIndex].png;
            string title = richTextBoxDescription.Text;
            LoggedInFacebookUser.User.PostPhoto(imageURI, title);
        }

        private void buttonPostToFriends_Click(object sender, EventArgs e)
        {
            string imageURI = m_AllRagePersons[m_currentPicBoxIndex].png;
            string title = richTextBoxDescription.Text;

            foreach (User friend in listBoxRageChoosenFriends.Items)
            {
                MemoryStream ms = new MemoryStream();
                pictureBoxRageFace.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                byte[] buff = ms.GetBuffer();
                friend.PostPhoto(buff, title);
            }
        }

        private void listBoxRageFriendsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxRageFriendsList.SelectedIndex >= 0)
            {
                pictureBoxFriend.Image = ((listBoxRageFriendsList.SelectedItem as User).ImageSmall);
            }
        }

        private void listBoxRageChoosenFriends_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxRageChoosenFriends.SelectedIndex >= 0)
            {
                pictureBoxChoosenFriend.Image = ((listBoxRageChoosenFriends.SelectedItem as User).ImageSmall);
            }
        }

        private void buttonOpenInPaint_Click(object sender, EventArgs e)
        {
            try
            {
                string newFilePath = createNewFilePath();
                using (FileStream fileStream = File.Create(newFilePath))
                {
                    MessageBox.Show("Image Was Saved To Your Desktop!", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    pictureBoxRageFace.Image.Save(fileStream, System.Drawing.Imaging.ImageFormat.Jpeg);
                    runPaintProgram(newFilePath);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error openning paint program" ,"Error",  MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string createNewFilePath()
        {
            string myUniqueFileName = string.Format(@"{0}.jpg", Guid.NewGuid());
            string directory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            return Path.Combine(directory, myUniqueFileName);
        }

        private void runPaintProgram(string i_Path)
        {
            System.Diagnostics.ProcessStartInfo procInfo = new System.Diagnostics.ProcessStartInfo();
            procInfo.FileName = ("mspaint.exe");
            procInfo.Arguments = i_Path;
            System.Diagnostics.Process.Start(procInfo);
        }
    }
}
