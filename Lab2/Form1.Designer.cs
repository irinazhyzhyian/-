namespace lab_2
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.rtbText = new System.Windows.Forms.RichTextBox();
            this.btnClean = new System.Windows.Forms.Button();
            this.btnShowForm = new System.Windows.Forms.Button();
            this.btnFile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rtbText
            // 
            this.rtbText.Font = new System.Drawing.Font("Montserrat Alternates", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rtbText.Location = new System.Drawing.Point(45, 26);
            this.rtbText.Name = "rtbText";
            this.rtbText.Size = new System.Drawing.Size(526, 389);
            this.rtbText.TabIndex = 0;
            this.rtbText.Text = "";
            // 
            // btnClean
            // 
            this.btnClean.Font = new System.Drawing.Font("Montserrat Alternates ExtraBold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnClean.Location = new System.Drawing.Point(599, 60);
            this.btnClean.Name = "btnClean";
            this.btnClean.Size = new System.Drawing.Size(151, 53);
            this.btnClean.TabIndex = 1;
            this.btnClean.Text = "Clean";
            this.btnClean.UseVisualStyleBackColor = true;
            this.btnClean.Click += new System.EventHandler(this.btnClean_Click);
            // 
            // btnShowForm
            // 
            this.btnShowForm.Font = new System.Drawing.Font("Montserrat Alternates ExtraBold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnShowForm.Location = new System.Drawing.Point(599, 303);
            this.btnShowForm.Name = "btnShowForm";
            this.btnShowForm.Size = new System.Drawing.Size(151, 62);
            this.btnShowForm.TabIndex = 2;
            this.btnShowForm.Text = "Delete form";
            this.btnShowForm.UseVisualStyleBackColor = true;
            this.btnShowForm.Click += new System.EventHandler(this.btnShowForm_Click);
            // 
            // btnFile
            // 
            this.btnFile.Font = new System.Drawing.Font("Montserrat Alternates ExtraBold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnFile.Location = new System.Drawing.Point(599, 175);
            this.btnFile.Name = "btnFile";
            this.btnFile.Size = new System.Drawing.Size(151, 61);
            this.btnFile.TabIndex = 3;
            this.btnFile.Text = "From file";
            this.btnFile.UseVisualStyleBackColor = true;
            this.btnFile.Click += new System.EventHandler(this.btnFile_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnFile);
            this.Controls.Add(this.btnShowForm);
            this.Controls.Add(this.btnClean);
            this.Controls.Add(this.rtbText);
            this.Name = "Form1";
            this.Text = "Add text form";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbText;
        private System.Windows.Forms.Button btnClean;
        private System.Windows.Forms.Button btnShowForm;
        private System.Windows.Forms.Button btnFile;
    }
}

