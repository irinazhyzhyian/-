namespace lab_2
{
    partial class DeleteForm
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
            this.btnDel = new System.Windows.Forms.Button();
            this.txtMask = new System.Windows.Forms.TextBox();
            this.rbtnStart = new System.Windows.Forms.RadioButton();
            this.rbtnCursor = new System.Windows.Forms.RadioButton();
            this.btnSelectAll = new System.Windows.Forms.Button();
            this.btnDelAll = new System.Windows.Forms.Button();
            this.btnSelOff = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDel
            // 
            this.btnDel.Font = new System.Drawing.Font("Montserrat Alternates ExtraBold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDel.Location = new System.Drawing.Point(48, 119);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(236, 50);
            this.btnDel.TabIndex = 0;
            this.btnDel.Text = "delete by one";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // txtMask
            // 
            this.txtMask.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtMask.Location = new System.Drawing.Point(48, 61);
            this.txtMask.Name = "txtMask";
            this.txtMask.Size = new System.Drawing.Size(236, 36);
            this.txtMask.TabIndex = 1;
            // 
            // rbtnStart
            // 
            this.rbtnStart.AutoSize = true;
            this.rbtnStart.Checked = true;
            this.rbtnStart.Font = new System.Drawing.Font("Montserrat Alternates ExtraBold", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbtnStart.Location = new System.Drawing.Point(361, 61);
            this.rbtnStart.Name = "rbtnStart";
            this.rbtnStart.Size = new System.Drawing.Size(125, 28);
            this.rbtnStart.TabIndex = 2;
            this.rbtnStart.TabStop = true;
            this.rbtnStart.Text = "from start";
            this.rbtnStart.UseVisualStyleBackColor = true;
            // 
            // rbtnCursor
            // 
            this.rbtnCursor.AutoSize = true;
            this.rbtnCursor.Font = new System.Drawing.Font("Montserrat Alternates ExtraBold", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbtnCursor.Location = new System.Drawing.Point(361, 95);
            this.rbtnCursor.Name = "rbtnCursor";
            this.rbtnCursor.Size = new System.Drawing.Size(140, 28);
            this.rbtnCursor.TabIndex = 3;
            this.rbtnCursor.TabStop = true;
            this.rbtnCursor.Text = "from cursor";
            this.rbtnCursor.UseVisualStyleBackColor = true;
            // 
            // btnSelectAll
            // 
            this.btnSelectAll.Font = new System.Drawing.Font("Montserrat Alternates ExtraBold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSelectAll.Location = new System.Drawing.Point(48, 191);
            this.btnSelectAll.Name = "btnSelectAll";
            this.btnSelectAll.Size = new System.Drawing.Size(236, 50);
            this.btnSelectAll.TabIndex = 4;
            this.btnSelectAll.Text = "select all";
            this.btnSelectAll.UseVisualStyleBackColor = true;
            this.btnSelectAll.Click += new System.EventHandler(this.btnSelectAll_Click);
            // 
            // btnDelAll
            // 
            this.btnDelAll.Font = new System.Drawing.Font("Montserrat Alternates ExtraBold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDelAll.Location = new System.Drawing.Point(48, 266);
            this.btnDelAll.Name = "btnDelAll";
            this.btnDelAll.Size = new System.Drawing.Size(231, 50);
            this.btnDelAll.TabIndex = 5;
            this.btnDelAll.Text = "delete all";
            this.btnDelAll.UseVisualStyleBackColor = true;
            this.btnDelAll.Click += new System.EventHandler(this.btnDelAll_Click);
            // 
            // btnSelOff
            // 
            this.btnSelOff.Font = new System.Drawing.Font("Montserrat Alternates ExtraBold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSelOff.Location = new System.Drawing.Point(292, 191);
            this.btnSelOff.Name = "btnSelOff";
            this.btnSelOff.Size = new System.Drawing.Size(236, 50);
            this.btnSelOff.TabIndex = 6;
            this.btnSelOff.Text = "selection off";
            this.btnSelOff.UseVisualStyleBackColor = true;
            this.btnSelOff.Click += new System.EventHandler(this.btnSelOff_Click);
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Font = new System.Drawing.Font("Montserrat Alternates Black", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnClose.Location = new System.Drawing.Point(296, 257);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(231, 58);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "close form";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // DeleteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(540, 328);
            this.ControlBox = false;
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSelOff);
            this.Controls.Add(this.btnDelAll);
            this.Controls.Add(this.btnSelectAll);
            this.Controls.Add(this.rbtnCursor);
            this.Controls.Add(this.rbtnStart);
            this.Controls.Add(this.txtMask);
            this.Controls.Add(this.btnDel);
            this.ImeMode = System.Windows.Forms.ImeMode.AlphaFull;
            this.Name = "DeleteForm";
            this.Text = "DeleteForm";
            this.Load += new System.EventHandler(this.DeleteForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.TextBox txtMask;
        private System.Windows.Forms.RadioButton rbtnStart;
        private System.Windows.Forms.RadioButton rbtnCursor;
        private System.Windows.Forms.Button btnSelectAll;
        private System.Windows.Forms.Button btnDelAll;
        private System.Windows.Forms.Button btnSelOff;
        private System.Windows.Forms.Button btnClose;
    }
}