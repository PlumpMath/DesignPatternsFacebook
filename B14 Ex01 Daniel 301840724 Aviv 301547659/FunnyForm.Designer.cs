namespace B14_Ex01_Daniel_301840724_Aviv_301547659
{
    partial class FunnyForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonNext = new System.Windows.Forms.Button();
            this.buttonPrev = new System.Windows.Forms.Button();
            this.pictureBoxRageFace = new System.Windows.Forms.PictureBox();
            this.labelUploadRageFaces = new System.Windows.Forms.Label();
            this.buttonPostToWall = new System.Windows.Forms.Button();
            this.richTextBoxDescription = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panelRagePersons = new System.Windows.Forms.TableLayoutPanel();
            this.buttonNextFaces = new System.Windows.Forms.Button();
            this.buttonPrevFaces = new System.Windows.Forms.Button();
            this.buttonSaveImage = new System.Windows.Forms.Button();
            this.buttonRemoveFriend = new System.Windows.Forms.Button();
            this.buttonAddFriend = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.listBoxRageFriendsList = new System.Windows.Forms.ListBox();
            this.listBoxRageChoosenFriends = new System.Windows.Forms.ListBox();
            this.buttonPostToFriends = new System.Windows.Forms.Button();
            this.pictureBoxChoosenFriend = new System.Windows.Forms.PictureBox();
            this.pictureBoxFriend = new System.Windows.Forms.PictureBox();
            this.buttonOpenInPaint = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRageFace)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxChoosenFriend)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFriend)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonNext
            // 
            this.buttonNext.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNext.Location = new System.Drawing.Point(174, 39);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(141, 31);
            this.buttonNext.TabIndex = 0;
            this.buttonNext.Text = "Next";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // buttonPrev
            // 
            this.buttonPrev.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPrev.Location = new System.Drawing.Point(17, 39);
            this.buttonPrev.Name = "buttonPrev";
            this.buttonPrev.Size = new System.Drawing.Size(139, 31);
            this.buttonPrev.TabIndex = 1;
            this.buttonPrev.Text = "Prev";
            this.buttonPrev.UseVisualStyleBackColor = true;
            this.buttonPrev.Click += new System.EventHandler(this.buttonPrev_Click);
            // 
            // pictureBoxRageFace
            // 
            this.pictureBoxRageFace.Location = new System.Drawing.Point(17, 76);
            this.pictureBoxRageFace.Name = "pictureBoxRageFace";
            this.pictureBoxRageFace.Size = new System.Drawing.Size(298, 200);
            this.pictureBoxRageFace.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxRageFace.TabIndex = 2;
            this.pictureBoxRageFace.TabStop = false;
            // 
            // labelUploadRageFaces
            // 
            this.labelUploadRageFaces.AutoSize = true;
            this.labelUploadRageFaces.Font = new System.Drawing.Font("High Tower Text", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUploadRageFaces.Location = new System.Drawing.Point(193, 2);
            this.labelUploadRageFaces.Name = "labelUploadRageFaces";
            this.labelUploadRageFaces.Size = new System.Drawing.Size(255, 34);
            this.labelUploadRageFaces.TabIndex = 3;
            this.labelUploadRageFaces.Text = "RageFace Madness";
            // 
            // buttonPostToWall
            // 
            this.buttonPostToWall.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPostToWall.Location = new System.Drawing.Point(17, 425);
            this.buttonPostToWall.Name = "buttonPostToWall";
            this.buttonPostToWall.Size = new System.Drawing.Size(298, 36);
            this.buttonPostToWall.TabIndex = 4;
            this.buttonPostToWall.Text = "Post To Your Wall";
            this.buttonPostToWall.UseVisualStyleBackColor = true;
            this.buttonPostToWall.Click += new System.EventHandler(this.buttonSubmitPost_Click);
            // 
            // richTextBoxDescription
            // 
            this.richTextBoxDescription.Location = new System.Drawing.Point(17, 361);
            this.richTextBoxDescription.Name = "richTextBoxDescription";
            this.richTextBoxDescription.Size = new System.Drawing.Size(298, 58);
            this.richTextBoxDescription.TabIndex = 5;
            this.richTextBoxDescription.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(102, 341);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Add Description";
            // 
            // panelRagePersons
            // 
            this.panelRagePersons.AutoScroll = true;
            this.panelRagePersons.ColumnCount = 3;
            this.panelRagePersons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.panelRagePersons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.panelRagePersons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.panelRagePersons.Location = new System.Drawing.Point(339, 39);
            this.panelRagePersons.Name = "panelRagePersons";
            this.panelRagePersons.RowCount = 5;
            this.panelRagePersons.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.panelRagePersons.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.panelRagePersons.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.panelRagePersons.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.panelRagePersons.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.panelRagePersons.Size = new System.Drawing.Size(275, 587);
            this.panelRagePersons.TabIndex = 7;
            // 
            // buttonNextFaces
            // 
            this.buttonNextFaces.Font = new System.Drawing.Font("Britannic Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNextFaces.Location = new System.Drawing.Point(487, 636);
            this.buttonNextFaces.Name = "buttonNextFaces";
            this.buttonNextFaces.Size = new System.Drawing.Size(127, 27);
            this.buttonNextFaces.TabIndex = 8;
            this.buttonNextFaces.Text = "Next Faces";
            this.buttonNextFaces.UseVisualStyleBackColor = true;
            this.buttonNextFaces.Click += new System.EventHandler(this.buttonNextFaces_Click);
            // 
            // buttonPrevFaces
            // 
            this.buttonPrevFaces.Font = new System.Drawing.Font("Britannic Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPrevFaces.Location = new System.Drawing.Point(339, 636);
            this.buttonPrevFaces.Name = "buttonPrevFaces";
            this.buttonPrevFaces.Size = new System.Drawing.Size(124, 28);
            this.buttonPrevFaces.TabIndex = 9;
            this.buttonPrevFaces.Text = "Previous Faces";
            this.buttonPrevFaces.UseVisualStyleBackColor = true;
            this.buttonPrevFaces.Click += new System.EventHandler(this.buttonPrevFaces_Click);
            // 
            // buttonSaveImage
            // 
            this.buttonSaveImage.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSaveImage.Location = new System.Drawing.Point(174, 282);
            this.buttonSaveImage.Name = "buttonSaveImage";
            this.buttonSaveImage.Size = new System.Drawing.Size(141, 36);
            this.buttonSaveImage.TabIndex = 10;
            this.buttonSaveImage.Text = "Save Image";
            this.buttonSaveImage.UseVisualStyleBackColor = true;
            this.buttonSaveImage.Click += new System.EventHandler(this.buttonSaveImage_Click);
            // 
            // buttonRemoveFriend
            // 
            this.buttonRemoveFriend.Font = new System.Drawing.Font("Britannic Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRemoveFriend.Location = new System.Drawing.Point(174, 599);
            this.buttonRemoveFriend.Name = "buttonRemoveFriend";
            this.buttonRemoveFriend.Size = new System.Drawing.Size(141, 27);
            this.buttonRemoveFriend.TabIndex = 16;
            this.buttonRemoveFriend.Text = "Remove";
            this.buttonRemoveFriend.UseVisualStyleBackColor = true;
            this.buttonRemoveFriend.Click += new System.EventHandler(this.buttonRemoveFriend_Click);
            // 
            // buttonAddFriend
            // 
            this.buttonAddFriend.Font = new System.Drawing.Font("Britannic Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddFriend.Location = new System.Drawing.Point(17, 599);
            this.buttonAddFriend.Name = "buttonAddFriend";
            this.buttonAddFriend.Size = new System.Drawing.Size(139, 27);
            this.buttonAddFriend.TabIndex = 15;
            this.buttonAddFriend.Text = "Add";
            this.buttonAddFriend.UseVisualStyleBackColor = true;
            this.buttonAddFriend.Click += new System.EventHandler(this.buttonAddFriend_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Britannic Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(172, 493);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 12);
            this.label2.TabIndex = 13;
            this.label2.Text = "Choosen Friends";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Britannic Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 493);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 12);
            this.label3.TabIndex = 14;
            this.label3.Text = "Friends";
            // 
            // listBoxRageFriendsList
            // 
            this.listBoxRageFriendsList.FormattingEnabled = true;
            this.listBoxRageFriendsList.Location = new System.Drawing.Point(17, 511);
            this.listBoxRageFriendsList.Name = "listBoxRageFriendsList";
            this.listBoxRageFriendsList.Size = new System.Drawing.Size(139, 82);
            this.listBoxRageFriendsList.TabIndex = 11;
            this.listBoxRageFriendsList.SelectedIndexChanged += new System.EventHandler(this.listBoxRageFriendsList_SelectedIndexChanged);
            // 
            // listBoxRageChoosenFriends
            // 
            this.listBoxRageChoosenFriends.FormattingEnabled = true;
            this.listBoxRageChoosenFriends.Location = new System.Drawing.Point(174, 511);
            this.listBoxRageChoosenFriends.Name = "listBoxRageChoosenFriends";
            this.listBoxRageChoosenFriends.Size = new System.Drawing.Size(141, 82);
            this.listBoxRageChoosenFriends.TabIndex = 12;
            this.listBoxRageChoosenFriends.SelectedIndexChanged += new System.EventHandler(this.listBoxRageChoosenFriends_SelectedIndexChanged);
            // 
            // buttonPostToFriends
            // 
            this.buttonPostToFriends.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPostToFriends.Location = new System.Drawing.Point(17, 632);
            this.buttonPostToFriends.Name = "buttonPostToFriends";
            this.buttonPostToFriends.Size = new System.Drawing.Size(298, 34);
            this.buttonPostToFriends.TabIndex = 17;
            this.buttonPostToFriends.Text = "Post To Your Friend\'s Walls";
            this.buttonPostToFriends.UseVisualStyleBackColor = true;
            this.buttonPostToFriends.Click += new System.EventHandler(this.buttonPostToFriends_Click);
            // 
            // pictureBoxChoosenFriend
            // 
            this.pictureBoxChoosenFriend.Location = new System.Drawing.Point(260, 466);
            this.pictureBoxChoosenFriend.Name = "pictureBoxChoosenFriend";
            this.pictureBoxChoosenFriend.Size = new System.Drawing.Size(55, 39);
            this.pictureBoxChoosenFriend.TabIndex = 18;
            this.pictureBoxChoosenFriend.TabStop = false;
            // 
            // pictureBoxFriend
            // 
            this.pictureBoxFriend.InitialImage = null;
            this.pictureBoxFriend.Location = new System.Drawing.Point(61, 466);
            this.pictureBoxFriend.Name = "pictureBoxFriend";
            this.pictureBoxFriend.Size = new System.Drawing.Size(55, 39);
            this.pictureBoxFriend.TabIndex = 19;
            this.pictureBoxFriend.TabStop = false;
            // 
            // buttonOpenInPaint
            // 
            this.buttonOpenInPaint.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOpenInPaint.Location = new System.Drawing.Point(15, 282);
            this.buttonOpenInPaint.Name = "buttonOpenInPaint";
            this.buttonOpenInPaint.Size = new System.Drawing.Size(141, 36);
            this.buttonOpenInPaint.TabIndex = 20;
            this.buttonOpenInPaint.Text = "Open In Paint";
            this.buttonOpenInPaint.UseVisualStyleBackColor = true;
            this.buttonOpenInPaint.Click += new System.EventHandler(this.buttonOpenInPaint_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label4.Location = new System.Drawing.Point(25, 321);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 9);
            this.label4.TabIndex = 21;
            this.label4.Text = "[Image Will Be Saved To Desktop]";
            // 
            // FunnyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 680);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonSaveImage);
            this.Controls.Add(this.buttonOpenInPaint);
            this.Controls.Add(this.pictureBoxFriend);
            this.Controls.Add(this.pictureBoxChoosenFriend);
            this.Controls.Add(this.buttonPostToFriends);
            this.Controls.Add(this.buttonPostToWall);
            this.Controls.Add(this.buttonRemoveFriend);
            this.Controls.Add(this.buttonAddFriend);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBoxRageChoosenFriends);
            this.Controls.Add(this.listBoxRageFriendsList);
            this.Controls.Add(this.buttonPrevFaces);
            this.Controls.Add(this.buttonNextFaces);
            this.Controls.Add(this.panelRagePersons);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBoxDescription);
            this.Controls.Add(this.labelUploadRageFaces);
            this.Controls.Add(this.pictureBoxRageFace);
            this.Controls.Add(this.buttonPrev);
            this.Controls.Add(this.buttonNext);
            this.Name = "FunnyForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Share Funny Stuff";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRageFace)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxChoosenFriend)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFriend)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Button buttonPrev;
        private System.Windows.Forms.PictureBox pictureBoxRageFace;
        private System.Windows.Forms.Label labelUploadRageFaces;
        private System.Windows.Forms.Button buttonPostToWall;
        private System.Windows.Forms.RichTextBox richTextBoxDescription;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel panelRagePersons;
        private System.Windows.Forms.Button buttonNextFaces;
        private System.Windows.Forms.Button buttonPrevFaces;
        private System.Windows.Forms.Button buttonSaveImage;
        private System.Windows.Forms.Button buttonRemoveFriend;
        private System.Windows.Forms.Button buttonAddFriend;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listBoxRageFriendsList;
        private System.Windows.Forms.ListBox listBoxRageChoosenFriends;
        private System.Windows.Forms.Button buttonPostToFriends;
        private System.Windows.Forms.PictureBox pictureBoxChoosenFriend;
        private System.Windows.Forms.PictureBox pictureBoxFriend;
        private System.Windows.Forms.Button buttonOpenInPaint;
        private System.Windows.Forms.Label label4;
    }
}