namespace WindowsFormsApp3
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.firstname = new System.Windows.Forms.TextBox();
            this.f_name = new System.Windows.Forms.Label();
            this.l_name = new System.Windows.Forms.Label();
            this.lastName = new System.Windows.Forms.TextBox();
            this.gender = new System.Windows.Forms.Label();
            this.maleBtn = new System.Windows.Forms.RadioButton();
            this.femaleBtn = new System.Windows.Forms.RadioButton();
            this.s_street = new System.Windows.Forms.Label();
            this.street = new System.Windows.Forms.TextBox();
            this.c_city = new System.Windows.Forms.Label();
            this.city = new System.Windows.Forms.TextBox();
            this.p_parish = new System.Windows.Forms.Label();
            this.parish = new System.Windows.Forms.ComboBox();
            this.s_subpack = new System.Windows.Forms.Label();
            this.package = new System.Windows.Forms.ComboBox();
            this.video = new System.Windows.Forms.Label();
            this.yesBtn = new System.Windows.Forms.RadioButton();
            this.noBtn = new System.Windows.Forms.RadioButton();
            this.tot_vid_rent = new System.Windows.Forms.Label();
            this.total = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // firstname
            // 
            this.firstname.Location = new System.Drawing.Point(103, 90);
            this.firstname.Name = "firstname";
            this.firstname.Size = new System.Drawing.Size(121, 20);
            this.firstname.TabIndex = 0;
            // 
            // f_name
            // 
            this.f_name.AutoSize = true;
            this.f_name.Location = new System.Drawing.Point(26, 93);
            this.f_name.Name = "f_name";
            this.f_name.Size = new System.Drawing.Size(60, 13);
            this.f_name.TabIndex = 1;
            this.f_name.Text = "First Name:";
            // 
            // l_name
            // 
            this.l_name.AutoSize = true;
            this.l_name.Location = new System.Drawing.Point(26, 149);
            this.l_name.Name = "l_name";
            this.l_name.Size = new System.Drawing.Size(61, 13);
            this.l_name.TabIndex = 2;
            this.l_name.Text = "Last Name:";
            // 
            // lastName
            // 
            this.lastName.Location = new System.Drawing.Point(103, 146);
            this.lastName.Name = "lastName";
            this.lastName.Size = new System.Drawing.Size(121, 20);
            this.lastName.TabIndex = 3;
            // 
            // gender
            // 
            this.gender.AutoSize = true;
            this.gender.Location = new System.Drawing.Point(26, 196);
            this.gender.Name = "gender";
            this.gender.Size = new System.Drawing.Size(42, 13);
            this.gender.TabIndex = 4;
            this.gender.Text = "Gender";
            // 
            // maleBtn
            // 
            this.maleBtn.AutoSize = true;
            this.maleBtn.Location = new System.Drawing.Point(103, 194);
            this.maleBtn.Name = "maleBtn";
            this.maleBtn.Size = new System.Drawing.Size(48, 17);
            this.maleBtn.TabIndex = 5;
            this.maleBtn.TabStop = true;
            this.maleBtn.Text = "Male";
            this.maleBtn.UseVisualStyleBackColor = true;
            // 
            // femaleBtn
            // 
            this.femaleBtn.AutoSize = true;
            this.femaleBtn.Location = new System.Drawing.Point(165, 194);
            this.femaleBtn.Name = "femaleBtn";
            this.femaleBtn.Size = new System.Drawing.Size(59, 17);
            this.femaleBtn.TabIndex = 6;
            this.femaleBtn.TabStop = true;
            this.femaleBtn.Text = "Female";
            this.femaleBtn.UseVisualStyleBackColor = true;
            // 
            // s_street
            // 
            this.s_street.AutoSize = true;
            this.s_street.Location = new System.Drawing.Point(27, 245);
            this.s_street.Name = "s_street";
            this.s_street.Size = new System.Drawing.Size(35, 13);
            this.s_street.TabIndex = 7;
            this.s_street.Text = "Street";
            // 
            // street
            // 
            this.street.Location = new System.Drawing.Point(103, 242);
            this.street.Name = "street";
            this.street.Size = new System.Drawing.Size(121, 20);
            this.street.TabIndex = 8;
            // 
            // c_city
            // 
            this.c_city.AutoSize = true;
            this.c_city.Location = new System.Drawing.Point(30, 302);
            this.c_city.Name = "c_city";
            this.c_city.Size = new System.Drawing.Size(24, 13);
            this.c_city.TabIndex = 9;
            this.c_city.Text = "City";
            // 
            // city
            // 
            this.city.Location = new System.Drawing.Point(103, 299);
            this.city.Name = "city";
            this.city.Size = new System.Drawing.Size(121, 20);
            this.city.TabIndex = 10;
            // 
            // p_parish
            // 
            this.p_parish.AutoSize = true;
            this.p_parish.Location = new System.Drawing.Point(27, 357);
            this.p_parish.Name = "p_parish";
            this.p_parish.Size = new System.Drawing.Size(36, 13);
            this.p_parish.TabIndex = 11;
            this.p_parish.Text = "Parish";
            // 
            // parish
            // 
            this.parish.FormattingEnabled = true;
            this.parish.Items.AddRange(new object[] {
            "Kingston",
            "St Mary",
            "Westmoreland",
            "Montegobay"});
            this.parish.Location = new System.Drawing.Point(103, 354);
            this.parish.Name = "parish";
            this.parish.Size = new System.Drawing.Size(121, 21);
            this.parish.TabIndex = 12;
            this.parish.Text = "Select Parish";
            // 
            // s_subpack
            // 
            this.s_subpack.AutoSize = true;
            this.s_subpack.Location = new System.Drawing.Point(404, 89);
            this.s_subpack.Name = "s_subpack";
            this.s_subpack.Size = new System.Drawing.Size(101, 13);
            this.s_subpack.TabIndex = 13;
            this.s_subpack.Text = "Subcribed Package";
            // 
            // package
            // 
            this.package.FormattingEnabled = true;
            this.package.Items.AddRange(new object[] {
            "mondays regular ($1500)",
            "tuesdays regular \"\"",
            "wednesdays regular \"\"",
            "Thursdays 2 for 1 ($2000)",
            "Sundays couples day($2000)"});
            this.package.Location = new System.Drawing.Point(534, 89);
            this.package.Name = "package";
            this.package.Size = new System.Drawing.Size(154, 21);
            this.package.TabIndex = 14;
            this.package.Text = "Select Package";
            // 
            // video
            // 
            this.video.AutoSize = true;
            this.video.Location = new System.Drawing.Point(407, 136);
            this.video.Name = "video";
            this.video.Size = new System.Drawing.Size(92, 13);
            this.video.TabIndex = 15;
            this.video.Text = "Video on Demand";
            // 
            // yesBtn
            // 
            this.yesBtn.AutoSize = true;
            this.yesBtn.Location = new System.Drawing.Point(534, 136);
            this.yesBtn.Name = "yesBtn";
            this.yesBtn.Size = new System.Drawing.Size(43, 17);
            this.yesBtn.TabIndex = 16;
            this.yesBtn.TabStop = true;
            this.yesBtn.Text = "Yes";
            this.yesBtn.UseVisualStyleBackColor = true;
            // 
            // noBtn
            // 
            this.noBtn.AutoSize = true;
            this.noBtn.Location = new System.Drawing.Point(649, 136);
            this.noBtn.Name = "noBtn";
            this.noBtn.Size = new System.Drawing.Size(39, 17);
            this.noBtn.TabIndex = 17;
            this.noBtn.TabStop = true;
            this.noBtn.Text = "No";
            this.noBtn.UseVisualStyleBackColor = true;
            // 
            // tot_vid_rent
            // 
            this.tot_vid_rent.AutoSize = true;
            this.tot_vid_rent.Location = new System.Drawing.Point(407, 178);
            this.tot_vid_rent.Name = "tot_vid_rent";
            this.tot_vid_rent.Size = new System.Drawing.Size(99, 13);
            this.tot_vid_rent.TabIndex = 18;
            this.tot_vid_rent.Text = "Total Video Rented";
            // 
            // total
            // 
            this.total.Location = new System.Drawing.Point(534, 178);
            this.total.Name = "total";
            this.total.Size = new System.Drawing.Size(154, 20);
            this.total.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Red;
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(239, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(287, 41);
            this.label10.TabIndex = 20;
            this.label10.Text = "Customer Details";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(407, 213);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(299, 151);
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(401, 387);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 22;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(523, 387);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 23;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(633, 386);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 24;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 439);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.total);
            this.Controls.Add(this.tot_vid_rent);
            this.Controls.Add(this.noBtn);
            this.Controls.Add(this.yesBtn);
            this.Controls.Add(this.video);
            this.Controls.Add(this.package);
            this.Controls.Add(this.s_subpack);
            this.Controls.Add(this.parish);
            this.Controls.Add(this.p_parish);
            this.Controls.Add(this.city);
            this.Controls.Add(this.c_city);
            this.Controls.Add(this.street);
            this.Controls.Add(this.s_street);
            this.Controls.Add(this.femaleBtn);
            this.Controls.Add(this.maleBtn);
            this.Controls.Add(this.gender);
            this.Controls.Add(this.lastName);
            this.Controls.Add(this.l_name);
            this.Controls.Add(this.f_name);
            this.Controls.Add(this.firstname);
            this.Name = "Form1";
            this.Text = "Select Package";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox firstname;
        private System.Windows.Forms.Label f_name;
        private System.Windows.Forms.Label l_name;
        private System.Windows.Forms.TextBox lastName;
        private System.Windows.Forms.Label gender;
        private System.Windows.Forms.RadioButton maleBtn;
        private System.Windows.Forms.RadioButton femaleBtn;
        private System.Windows.Forms.Label s_street;
        private System.Windows.Forms.TextBox street;
        private System.Windows.Forms.Label c_city;
        private System.Windows.Forms.TextBox city;
        private System.Windows.Forms.Label p_parish;
        private System.Windows.Forms.ComboBox parish;
        private System.Windows.Forms.Label s_subpack;
        private System.Windows.Forms.ComboBox package;
        private System.Windows.Forms.Label video;
        private System.Windows.Forms.RadioButton yesBtn;
        private System.Windows.Forms.RadioButton noBtn;
        private System.Windows.Forms.Label tot_vid_rent;
        private System.Windows.Forms.TextBox total;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSubmit;
    }
}

