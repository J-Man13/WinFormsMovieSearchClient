namespace MovieSearchClient.View
{
    partial class MovieInfoForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelReleaseDate = new System.Windows.Forms.Label();
            this.labelDirector = new System.Windows.Forms.Label();
            this.labelGenre = new System.Windows.Forms.Label();
            this.labelRunTime = new System.Windows.Forms.Label();
            this.labelFilmName = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBoxFilmSearch = new System.Windows.Forms.PictureBox();
            this.readOnlyRichTextBox1 = new MovieSearchClient.Components.ReadOnlyRichTextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFilmSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.Controls.Add(this.labelReleaseDate);
            this.panel1.Controls.Add(this.labelDirector);
            this.panel1.Controls.Add(this.labelGenre);
            this.panel1.Controls.Add(this.labelRunTime);
            this.panel1.Controls.Add(this.readOnlyRichTextBox1);
            this.panel1.Controls.Add(this.labelFilmName);
            this.panel1.Location = new System.Drawing.Point(0, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(443, 690);
            this.panel1.TabIndex = 0;
            // 
            // labelReleaseDate
            // 
            this.labelReleaseDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelReleaseDate.Location = new System.Drawing.Point(3, 78);
            this.labelReleaseDate.Name = "labelReleaseDate";
            this.labelReleaseDate.Size = new System.Drawing.Size(428, 24);
            this.labelReleaseDate.TabIndex = 6;
            this.labelReleaseDate.Text = "Release date";
            this.labelReleaseDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelDirector
            // 
            this.labelDirector.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDirector.Location = new System.Drawing.Point(3, 30);
            this.labelDirector.Name = "labelDirector";
            this.labelDirector.Size = new System.Drawing.Size(428, 24);
            this.labelDirector.TabIndex = 5;
            this.labelDirector.Text = "Director";
            this.labelDirector.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelGenre
            // 
            this.labelGenre.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelGenre.Location = new System.Drawing.Point(3, 102);
            this.labelGenre.Name = "labelGenre";
            this.labelGenre.Size = new System.Drawing.Size(428, 24);
            this.labelGenre.TabIndex = 4;
            this.labelGenre.Text = "Genre";
            this.labelGenre.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelRunTime
            // 
            this.labelRunTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelRunTime.Location = new System.Drawing.Point(3, 54);
            this.labelRunTime.Name = "labelRunTime";
            this.labelRunTime.Size = new System.Drawing.Size(428, 24);
            this.labelRunTime.TabIndex = 3;
            this.labelRunTime.Text = "Run time";
            this.labelRunTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelFilmName
            // 
            this.labelFilmName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFilmName.Location = new System.Drawing.Point(3, 5);
            this.labelFilmName.Name = "labelFilmName";
            this.labelFilmName.Size = new System.Drawing.Size(428, 25);
            this.labelFilmName.TabIndex = 0;
            this.labelFilmName.Text = "Film name";
            this.labelFilmName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.pictureBoxFilmSearch);
            this.panel2.Location = new System.Drawing.Point(446, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(659, 690);
            this.panel2.TabIndex = 1;
            // 
            // pictureBoxFilmSearch
            // 
            this.pictureBoxFilmSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxFilmSearch.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBoxFilmSearch.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxFilmSearch.Name = "pictureBoxFilmSearch";
            this.pictureBoxFilmSearch.Size = new System.Drawing.Size(659, 690);
            this.pictureBoxFilmSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxFilmSearch.TabIndex = 2;
            this.pictureBoxFilmSearch.TabStop = false;
            // 
            // readOnlyRichTextBox1
            // 
            this.readOnlyRichTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.readOnlyRichTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.readOnlyRichTextBox1.Location = new System.Drawing.Point(0, 129);
            this.readOnlyRichTextBox1.Name = "readOnlyRichTextBox1";
            this.readOnlyRichTextBox1.ReadOnly = true;
            this.readOnlyRichTextBox1.Size = new System.Drawing.Size(440, 561);
            this.readOnlyRichTextBox1.TabIndex = 2;
            this.readOnlyRichTextBox1.Text = "";
            // 
            // MovieInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1105, 696);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "MovieInfoForm";
            this.Text = "Roof Top Film Club";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFilmSearch)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBoxFilmSearch;
        private System.Windows.Forms.Label labelFilmName;
        private Components.ReadOnlyRichTextBox readOnlyRichTextBox1;
        private System.Windows.Forms.Label labelReleaseDate;
        private System.Windows.Forms.Label labelDirector;
        private System.Windows.Forms.Label labelGenre;
        private System.Windows.Forms.Label labelRunTime;
    }
}