namespace DKrypt1337Loader
{
    partial class frmMain
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
            this.lbl_Exit = new System.Windows.Forms.Label();
            this.cmb_CheatList = new System.Windows.Forms.ComboBox();
            this.btn_LoadCheat = new System.Windows.Forms.Button();
            this.lbl_Status = new System.Windows.Forms.Label();
            this.lbl_AppName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_Exit
            // 
            this.lbl_Exit.AutoSize = true;
            this.lbl_Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Exit.Location = new System.Drawing.Point(276, 9);
            this.lbl_Exit.Name = "lbl_Exit";
            this.lbl_Exit.Size = new System.Drawing.Size(31, 29);
            this.lbl_Exit.TabIndex = 0;
            this.lbl_Exit.Text = "&X";
            this.lbl_Exit.Click += new System.EventHandler(this.lbl_Exit_Click);
            // 
            // cmb_CheatList
            // 
            this.cmb_CheatList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.cmb_CheatList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmb_CheatList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_CheatList.ForeColor = System.Drawing.Color.White;
            this.cmb_CheatList.FormattingEnabled = true;
            this.cmb_CheatList.Items.AddRange(new object[] {
            "Assault Cube"});
            this.cmb_CheatList.Location = new System.Drawing.Point(12, 115);
            this.cmb_CheatList.Name = "cmb_CheatList";
            this.cmb_CheatList.Size = new System.Drawing.Size(285, 24);
            this.cmb_CheatList.TabIndex = 1;
            this.cmb_CheatList.Text = "Assault Cube";
            // 
            // btn_LoadCheat
            // 
            this.btn_LoadCheat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_LoadCheat.Location = new System.Drawing.Point(12, 163);
            this.btn_LoadCheat.Name = "btn_LoadCheat";
            this.btn_LoadCheat.Size = new System.Drawing.Size(284, 47);
            this.btn_LoadCheat.TabIndex = 2;
            this.btn_LoadCheat.Text = "Load Cheat";
            this.btn_LoadCheat.UseVisualStyleBackColor = true;
            // 
            // lbl_Status
            // 
            this.lbl_Status.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_Status.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Status.Location = new System.Drawing.Point(12, 225);
            this.lbl_Status.Name = "lbl_Status";
            this.lbl_Status.Size = new System.Drawing.Size(284, 23);
            this.lbl_Status.TabIndex = 3;
            this.lbl_Status.Text = "- Status -";
            this.lbl_Status.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_AppName
            // 
            this.lbl_AppName.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_AppName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lbl_AppName.Location = new System.Drawing.Point(12, 9);
            this.lbl_AppName.Name = "lbl_AppName";
            this.lbl_AppName.Size = new System.Drawing.Size(257, 74);
            this.lbl_AppName.TabIndex = 4;
            this.lbl_AppName.Text = "DKrypt1337 Loader";
            this.lbl_AppName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_AppName.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lbl_AppName_MouseDown);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(313, 257);
            this.Controls.Add(this.lbl_AppName);
            this.Controls.Add(this.lbl_Status);
            this.Controls.Add(this.btn_LoadCheat);
            this.Controls.Add(this.cmb_CheatList);
            this.Controls.Add(this.lbl_Exit);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMain";
            this.Text = "DKrypt1337 Loader";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Exit;
        private System.Windows.Forms.ComboBox cmb_CheatList;
        private System.Windows.Forms.Button btn_LoadCheat;
        private System.Windows.Forms.Label lbl_Status;
        private System.Windows.Forms.Label lbl_AppName;
    }
}

