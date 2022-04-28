
namespace save_table
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.openFileBTN = new System.Windows.Forms.Button();
            this.saveInFileBTN = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileBTN
            // 
            this.openFileBTN.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.openFileBTN.Location = new System.Drawing.Point(8, 7);
            this.openFileBTN.Margin = new System.Windows.Forms.Padding(2);
            this.openFileBTN.Name = "openFileBTN";
            this.openFileBTN.Size = new System.Drawing.Size(106, 26);
            this.openFileBTN.TabIndex = 0;
            this.openFileBTN.Text = "Открыть файл";
            this.openFileBTN.UseVisualStyleBackColor = false;
            this.openFileBTN.Click += new System.EventHandler(this.openFileBTN_Click);
            // 
            // saveInFileBTN
            // 
            this.saveInFileBTN.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.saveInFileBTN.Location = new System.Drawing.Point(127, 7);
            this.saveInFileBTN.Margin = new System.Windows.Forms.Padding(2);
            this.saveInFileBTN.Name = "saveInFileBTN";
            this.saveInFileBTN.Size = new System.Drawing.Size(122, 26);
            this.saveInFileBTN.TabIndex = 1;
            this.saveInFileBTN.Text = "Сохранить в файл";
            this.saveInFileBTN.UseVisualStyleBackColor = false;
            this.saveInFileBTN.Click += new System.EventHandler(this.saveInFileBTN_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.Color.LightGray;
            this.dataGridView1.Location = new System.Drawing.Point(11, 37);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(493, 600);
            this.dataGridView1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(515, 648);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.saveInFileBTN);
            this.Controls.Add(this.openFileBTN);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Сохранение таблицы";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button openFileBTN;
        private System.Windows.Forms.Button saveInFileBTN;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

