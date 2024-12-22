namespace QuizApplication.Instructor_UC
{
    partial class ViewAndDelete
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewAndDelete));
            this.lblViewDelete = new System.Windows.Forms.Label();
            this.vdLogo = new System.Windows.Forms.PictureBox();
            this.cmbSet = new System.Windows.Forms.ComboBox();
            this.lblSet = new System.Windows.Forms.Label();
            this.dataGridViewDelete = new System.Windows.Forms.DataGridView();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.vdLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDelete)).BeginInit();
            this.SuspendLayout();
            // 
            // lblViewDelete
            // 
            this.lblViewDelete.AutoSize = true;
            this.lblViewDelete.Font = new System.Drawing.Font("Cooper Black", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblViewDelete.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblViewDelete.Location = new System.Drawing.Point(125, 48);
            this.lblViewDelete.Name = "lblViewDelete";
            this.lblViewDelete.Size = new System.Drawing.Size(433, 36);
            this.lblViewDelete.TabIndex = 24;
            this.lblViewDelete.Text = "View and Delete Question";
            // 
            // vdLogo
            // 
            this.vdLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.vdLogo.Image = ((System.Drawing.Image)(resources.GetObject("vdLogo.Image")));
            this.vdLogo.Location = new System.Drawing.Point(16, 20);
            this.vdLogo.Name = "vdLogo";
            this.vdLogo.Size = new System.Drawing.Size(103, 102);
            this.vdLogo.TabIndex = 23;
            this.vdLogo.TabStop = false;
            // 
            // cmbSet
            // 
            this.cmbSet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSet.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSet.FormattingEnabled = true;
            this.cmbSet.Location = new System.Drawing.Point(822, 148);
            this.cmbSet.Name = "cmbSet";
            this.cmbSet.Size = new System.Drawing.Size(223, 28);
            this.cmbSet.TabIndex = 39;
            this.cmbSet.SelectedIndexChanged += new System.EventHandler(this.cmbSet_SelectedIndexChanged);
            // 
            // lblSet
            // 
            this.lblSet.AutoSize = true;
            this.lblSet.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSet.Location = new System.Drawing.Point(818, 106);
            this.lblSet.Name = "lblSet";
            this.lblSet.Size = new System.Drawing.Size(35, 21);
            this.lblSet.TabIndex = 38;
            this.lblSet.Text = "Set";
            // 
            // dataGridViewDelete
            // 
            this.dataGridViewDelete.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewDelete.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewDelete.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewDelete.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDelete.Location = new System.Drawing.Point(16, 198);
            this.dataGridViewDelete.Name = "dataGridViewDelete";
            this.dataGridViewDelete.Size = new System.Drawing.Size(1029, 295);
            this.dataGridViewDelete.TabIndex = 40;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Transparent;
            this.btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.SaddleBrown;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.Location = new System.Drawing.Point(925, 511);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(94, 60);
            this.btnDelete.TabIndex = 43;
            this.btnDelete.Text = "Delete";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // ViewAndDelete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.dataGridViewDelete);
            this.Controls.Add(this.cmbSet);
            this.Controls.Add(this.lblSet);
            this.Controls.Add(this.lblViewDelete);
            this.Controls.Add(this.vdLogo);
            this.Name = "ViewAndDelete";
            this.Size = new System.Drawing.Size(1059, 584);
            this.Load += new System.EventHandler(this.ViewAndDelete_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vdLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDelete)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblViewDelete;
        private System.Windows.Forms.PictureBox vdLogo;
        private System.Windows.Forms.ComboBox cmbSet;
        private System.Windows.Forms.Label lblSet;
        private System.Windows.Forms.DataGridView dataGridViewDelete;
        private System.Windows.Forms.Button btnDelete;
    }
}
