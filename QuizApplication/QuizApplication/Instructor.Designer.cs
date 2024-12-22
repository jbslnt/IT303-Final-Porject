namespace QuizApplication
{
    partial class Instructor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Instructor));
            this.sidePanel = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnResult = new System.Windows.Forms.Button();
            this.btnViewDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblInstructor = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dashbaordPanel = new System.Windows.Forms.Panel();
            this.viewAndDelete1 = new QuizApplication.Instructor_UC.ViewAndDelete();
            this.updateQuestion1 = new QuizApplication.Instructor_UC.UpdateQuestion();
            this.addNewQuestion1 = new QuizApplication.Instructor_UC.AddNewQuestion();
            this.sidePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.dashbaordPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // sidePanel
            // 
            this.sidePanel.BackColor = System.Drawing.Color.SaddleBrown;
            this.sidePanel.Controls.Add(this.btnLogout);
            this.sidePanel.Controls.Add(this.btnResult);
            this.sidePanel.Controls.Add(this.btnViewDelete);
            this.sidePanel.Controls.Add(this.btnUpdate);
            this.sidePanel.Controls.Add(this.btnAdd);
            this.sidePanel.Controls.Add(this.lblInstructor);
            this.sidePanel.Controls.Add(this.pictureBox1);
            this.sidePanel.Location = new System.Drawing.Point(0, 0);
            this.sidePanel.Name = "sidePanel";
            this.sidePanel.Size = new System.Drawing.Size(200, 588);
            this.sidePanel.TabIndex = 0;
            // 
            // btnLogout
            // 
            this.btnLogout.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnLogout.FlatAppearance.BorderSize = 18;
            this.btnLogout.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.Image = ((System.Drawing.Image)(resources.GetObject("btnLogout.Image")));
            this.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.Location = new System.Drawing.Point(36, 488);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(192, 42);
            this.btnLogout.TabIndex = 6;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnResult
            // 
            this.btnResult.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnResult.FlatAppearance.BorderSize = 18;
            this.btnResult.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResult.Image = ((System.Drawing.Image)(resources.GetObject("btnResult.Image")));
            this.btnResult.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnResult.Location = new System.Drawing.Point(36, 423);
            this.btnResult.Name = "btnResult";
            this.btnResult.Size = new System.Drawing.Size(192, 42);
            this.btnResult.TabIndex = 5;
            this.btnResult.Text = "Student Result";
            this.btnResult.UseVisualStyleBackColor = true;
            // 
            // btnViewDelete
            // 
            this.btnViewDelete.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnViewDelete.FlatAppearance.BorderSize = 18;
            this.btnViewDelete.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnViewDelete.Image")));
            this.btnViewDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnViewDelete.Location = new System.Drawing.Point(36, 358);
            this.btnViewDelete.Name = "btnViewDelete";
            this.btnViewDelete.Size = new System.Drawing.Size(192, 42);
            this.btnViewDelete.TabIndex = 4;
            this.btnViewDelete.Text = "View and Delete";
            this.btnViewDelete.UseVisualStyleBackColor = true;
            this.btnViewDelete.Click += new System.EventHandler(this.btnViewDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnUpdate.FlatAppearance.BorderSize = 18;
            this.btnUpdate.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdate.Image")));
            this.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdate.Location = new System.Drawing.Point(36, 293);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(192, 42);
            this.btnUpdate.TabIndex = 3;
            this.btnUpdate.Text = "Update Question";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Transparent;
            this.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.SaddleBrown;
            this.btnAdd.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.Location = new System.Drawing.Point(36, 228);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(0);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(192, 42);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add Question";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblInstructor
            // 
            this.lblInstructor.AutoSize = true;
            this.lblInstructor.Font = new System.Drawing.Font("Cooper Black", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstructor.ForeColor = System.Drawing.Color.White;
            this.lblInstructor.Location = new System.Drawing.Point(47, 180);
            this.lblInstructor.Name = "lblInstructor";
            this.lblInstructor.Size = new System.Drawing.Size(112, 21);
            this.lblInstructor.TabIndex = 1;
            this.lblInstructor.Text = "Instructor";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(7, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(182, 159);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // dashbaordPanel
            // 
            this.dashbaordPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("dashbaordPanel.BackgroundImage")));
            this.dashbaordPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.dashbaordPanel.Controls.Add(this.viewAndDelete1);
            this.dashbaordPanel.Controls.Add(this.updateQuestion1);
            this.dashbaordPanel.Controls.Add(this.addNewQuestion1);
            this.dashbaordPanel.Location = new System.Drawing.Point(200, 0);
            this.dashbaordPanel.Name = "dashbaordPanel";
            this.dashbaordPanel.Size = new System.Drawing.Size(1063, 588);
            this.dashbaordPanel.TabIndex = 1;
            // 
            // viewAndDelete1
            // 
            this.viewAndDelete1.BackColor = System.Drawing.Color.White;
            this.viewAndDelete1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.viewAndDelete1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.viewAndDelete1.Location = new System.Drawing.Point(1, 0);
            this.viewAndDelete1.Name = "viewAndDelete1";
            this.viewAndDelete1.Size = new System.Drawing.Size(1059, 584);
            this.viewAndDelete1.TabIndex = 2;
            // 
            // updateQuestion1
            // 
            this.updateQuestion1.BackColor = System.Drawing.Color.White;
            this.updateQuestion1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.updateQuestion1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.updateQuestion1.Location = new System.Drawing.Point(0, 0);
            this.updateQuestion1.Name = "updateQuestion1";
            this.updateQuestion1.Size = new System.Drawing.Size(1061, 586);
            this.updateQuestion1.TabIndex = 1;
            // 
            // addNewQuestion1
            // 
            this.addNewQuestion1.BackColor = System.Drawing.Color.White;
            this.addNewQuestion1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.addNewQuestion1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.addNewQuestion1.Location = new System.Drawing.Point(0, 0);
            this.addNewQuestion1.Name = "addNewQuestion1";
            this.addNewQuestion1.Size = new System.Drawing.Size(1063, 588);
            this.addNewQuestion1.TabIndex = 0;
            // 
            // Instructor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1263, 588);
            this.Controls.Add(this.dashbaordPanel);
            this.Controls.Add(this.sidePanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Instructor";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Instructor";
            this.Load += new System.EventHandler(this.Instructor_Load);
            this.sidePanel.ResumeLayout(false);
            this.sidePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.dashbaordPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel sidePanel;
        private System.Windows.Forms.Panel dashbaordPanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblInstructor;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnResult;
        private System.Windows.Forms.Button btnViewDelete;
        private System.Windows.Forms.Button btnLogout;
        private Instructor_UC.AddNewQuestion addNewQuestion1;
        private Instructor_UC.UpdateQuestion updateQuestion1;
        private Instructor_UC.ViewAndDelete viewAndDelete1;
    }
}