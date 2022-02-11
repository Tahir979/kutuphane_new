
namespace Kütüphane
{
    partial class frmdil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmdil));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_sil = new MetroFramework.Controls.MetroButton();
            this.cmb_kitaplıkismiekle = new MetroFramework.Controls.MetroComboBox();
            this.btn_kitaplıkismiekle = new MetroFramework.Controls.MetroButton();
            this.textBox1 = new MetroFramework.Controls.MetroTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(228, 16);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(22, 19);
            this.dataGridView1.TabIndex = 9;
            this.dataGridView1.Visible = false;
            // 
            // btn_sil
            // 
            this.btn_sil.Location = new System.Drawing.Point(166, 98);
            this.btn_sil.Name = "btn_sil";
            this.btn_sil.Size = new System.Drawing.Size(75, 29);
            this.btn_sil.TabIndex = 8;
            this.btn_sil.Text = "Sil";
            this.btn_sil.UseSelectable = true;
            this.btn_sil.Click += new System.EventHandler(this.btn_sil_Click);
            // 
            // cmb_kitaplıkismiekle
            // 
            this.cmb_kitaplıkismiekle.FormattingEnabled = true;
            this.cmb_kitaplıkismiekle.ItemHeight = 23;
            this.cmb_kitaplıkismiekle.Location = new System.Drawing.Point(23, 98);
            this.cmb_kitaplıkismiekle.Name = "cmb_kitaplıkismiekle";
            this.cmb_kitaplıkismiekle.Size = new System.Drawing.Size(137, 29);
            this.cmb_kitaplıkismiekle.Sorted = true;
            this.cmb_kitaplıkismiekle.TabIndex = 7;
            this.cmb_kitaplıkismiekle.UseSelectable = true;
            // 
            // btn_kitaplıkismiekle
            // 
            this.btn_kitaplıkismiekle.Location = new System.Drawing.Point(166, 63);
            this.btn_kitaplıkismiekle.Name = "btn_kitaplıkismiekle";
            this.btn_kitaplıkismiekle.Size = new System.Drawing.Size(75, 29);
            this.btn_kitaplıkismiekle.TabIndex = 6;
            this.btn_kitaplıkismiekle.Text = "Ekle";
            this.btn_kitaplıkismiekle.UseSelectable = true;
            this.btn_kitaplıkismiekle.Click += new System.EventHandler(this.btn_kitaplıkismiekle_Click);
            // 
            // textBox1
            // 
            // 
            // 
            // 
            this.textBox1.CustomButton.Image = null;
            this.textBox1.CustomButton.Location = new System.Drawing.Point(109, 1);
            this.textBox1.CustomButton.Name = "";
            this.textBox1.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.textBox1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textBox1.CustomButton.TabIndex = 1;
            this.textBox1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textBox1.CustomButton.UseSelectable = true;
            this.textBox1.CustomButton.Visible = false;
            this.textBox1.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.textBox1.Lines = new string[0];
            this.textBox1.Location = new System.Drawing.Point(23, 63);
            this.textBox1.MaxLength = 32767;
            this.textBox1.Name = "textBox1";
            this.textBox1.PasswordChar = '\0';
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textBox1.SelectedText = "";
            this.textBox1.SelectionLength = 0;
            this.textBox1.SelectionStart = 0;
            this.textBox1.ShortcutsEnabled = true;
            this.textBox1.Size = new System.Drawing.Size(137, 29);
            this.textBox1.TabIndex = 5;
            this.textBox1.UseSelectable = true;
            this.textBox1.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textBox1.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // frmdil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(260, 150);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_sil);
            this.Controls.Add(this.cmb_kitaplıkismiekle);
            this.Controls.Add(this.btn_kitaplıkismiekle);
            this.Controls.Add(this.textBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmdil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Style = MetroFramework.MetroColorStyle.Magenta;
            this.Text = "Dilleri Düzenle";
            this.Load += new System.EventHandler(this.frmdil_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private MetroFramework.Controls.MetroButton btn_sil;
        private MetroFramework.Controls.MetroComboBox cmb_kitaplıkismiekle;
        private MetroFramework.Controls.MetroButton btn_kitaplıkismiekle;
        private MetroFramework.Controls.MetroTextBox textBox1;
    }
}