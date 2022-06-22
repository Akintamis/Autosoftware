namespace Autosoftware_Akin
{
    partial class Hauptfenster
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Autoshintergrund = new System.Windows.Forms.Panel();
            this.vwknopf = new System.Windows.Forms.Button();
            this.benzknopf = new System.Windows.Forms.Button();
            this.bmwknopf = new System.Windows.Forms.Button();
            this.Audiknopf = new System.Windows.Forms.Button();
            this.Autosknopf = new System.Windows.Forms.Button();
            this.Carkinlogohintergrund = new System.Windows.Forms.Panel();
            this.carkinlogo = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.Autoshintergrund.SuspendLayout();
            this.Carkinlogohintergrund.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Autoshintergrund
            // 
            this.Autoshintergrund.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(117)))), ((int)(((byte)(117)))));
            this.Autoshintergrund.Controls.Add(this.vwknopf);
            this.Autoshintergrund.Controls.Add(this.benzknopf);
            this.Autoshintergrund.Controls.Add(this.bmwknopf);
            this.Autoshintergrund.Controls.Add(this.Audiknopf);
            this.Autoshintergrund.Controls.Add(this.Autosknopf);
            this.Autoshintergrund.Location = new System.Drawing.Point(0, 91);
            this.Autoshintergrund.MaximumSize = new System.Drawing.Size(273, 243);
            this.Autoshintergrund.MinimumSize = new System.Drawing.Size(273, 102);
            this.Autoshintergrund.Name = "Autoshintergrund";
            this.Autoshintergrund.Size = new System.Drawing.Size(273, 102);
            this.Autoshintergrund.TabIndex = 5;
            // 
            // vwknopf
            // 
            this.vwknopf.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(117)))), ((int)(((byte)(117)))));
            this.vwknopf.Dock = System.Windows.Forms.DockStyle.Top;
            this.vwknopf.FlatAppearance.BorderSize = 0;
            this.vwknopf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.vwknopf.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vwknopf.ForeColor = System.Drawing.Color.White;
            this.vwknopf.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.vwknopf.Location = new System.Drawing.Point(0, 207);
            this.vwknopf.Name = "vwknopf";
            this.vwknopf.Size = new System.Drawing.Size(273, 40);
            this.vwknopf.TabIndex = 4;
            this.vwknopf.Text = "Volkswagen";
            this.vwknopf.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.vwknopf.UseVisualStyleBackColor = false;
            // 
            // benzknopf
            // 
            this.benzknopf.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(117)))), ((int)(((byte)(117)))));
            this.benzknopf.Dock = System.Windows.Forms.DockStyle.Top;
            this.benzknopf.FlatAppearance.BorderSize = 0;
            this.benzknopf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.benzknopf.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.benzknopf.ForeColor = System.Drawing.Color.White;
            this.benzknopf.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.benzknopf.Location = new System.Drawing.Point(0, 172);
            this.benzknopf.Name = "benzknopf";
            this.benzknopf.Size = new System.Drawing.Size(273, 35);
            this.benzknopf.TabIndex = 3;
            this.benzknopf.Text = "Mercedes-Benz";
            this.benzknopf.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.benzknopf.UseVisualStyleBackColor = false;
            // 
            // bmwknopf
            // 
            this.bmwknopf.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(117)))), ((int)(((byte)(117)))));
            this.bmwknopf.Dock = System.Windows.Forms.DockStyle.Top;
            this.bmwknopf.FlatAppearance.BorderSize = 0;
            this.bmwknopf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bmwknopf.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bmwknopf.ForeColor = System.Drawing.Color.White;
            this.bmwknopf.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.bmwknopf.Location = new System.Drawing.Point(0, 137);
            this.bmwknopf.Name = "bmwknopf";
            this.bmwknopf.Size = new System.Drawing.Size(273, 35);
            this.bmwknopf.TabIndex = 2;
            this.bmwknopf.Text = "BMW";
            this.bmwknopf.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.bmwknopf.UseVisualStyleBackColor = false;
            // 
            // Audiknopf
            // 
            this.Audiknopf.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(117)))), ((int)(((byte)(117)))));
            this.Audiknopf.Dock = System.Windows.Forms.DockStyle.Top;
            this.Audiknopf.FlatAppearance.BorderSize = 0;
            this.Audiknopf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Audiknopf.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Audiknopf.ForeColor = System.Drawing.Color.White;
            this.Audiknopf.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.Audiknopf.Location = new System.Drawing.Point(0, 102);
            this.Audiknopf.Name = "Audiknopf";
            this.Audiknopf.Size = new System.Drawing.Size(273, 35);
            this.Audiknopf.TabIndex = 1;
            this.Audiknopf.Text = "Audi";
            this.Audiknopf.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Audiknopf.UseVisualStyleBackColor = false;
            // 
            // Autosknopf
            // 
            this.Autosknopf.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(117)))), ((int)(((byte)(117)))));
            this.Autosknopf.Dock = System.Windows.Forms.DockStyle.Top;
            this.Autosknopf.FlatAppearance.BorderSize = 0;
            this.Autosknopf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Autosknopf.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Autosknopf.ForeColor = System.Drawing.Color.White;
            this.Autosknopf.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.Autosknopf.Location = new System.Drawing.Point(0, 0);
            this.Autosknopf.Name = "Autosknopf";
            this.Autosknopf.Size = new System.Drawing.Size(273, 102);
            this.Autosknopf.TabIndex = 0;
            this.Autosknopf.Text = "Autos";
            this.Autosknopf.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Autosknopf.UseVisualStyleBackColor = false;
            // 
            // Carkinlogohintergrund
            // 
            this.Carkinlogohintergrund.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.Carkinlogohintergrund.Controls.Add(this.carkinlogo);
            this.Carkinlogohintergrund.Cursor = System.Windows.Forms.Cursors.Default;
            this.Carkinlogohintergrund.Font = new System.Drawing.Font("Microsoft YaHei", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Carkinlogohintergrund.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Carkinlogohintergrund.Location = new System.Drawing.Point(0, 0);
            this.Carkinlogohintergrund.Name = "Carkinlogohintergrund";
            this.Carkinlogohintergrund.Size = new System.Drawing.Size(848, 92);
            this.Carkinlogohintergrund.TabIndex = 6;
            // 
            // carkinlogo
            // 
            this.carkinlogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.carkinlogo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.carkinlogo.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.carkinlogo.ForeColor = System.Drawing.Color.White;
            this.carkinlogo.Location = new System.Drawing.Point(319, 22);
            this.carkinlogo.Name = "carkinlogo";
            this.carkinlogo.Size = new System.Drawing.Size(241, 42);
            this.carkinlogo.TabIndex = 0;
            this.carkinlogo.Text = "Akincartor";
            this.carkinlogo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 320);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(824, 334);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            this.dataGridView1.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseDoubleClick);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 280);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(163, 34);
            this.button1.TabIndex = 9;
            this.button1.Text = "Details öffnen...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Hauptfenster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(848, 677);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Carkinlogohintergrund);
            this.Controls.Add(this.Autoshintergrund);
            this.Name = "Hauptfenster";
            this.Text = "Akincartor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Hauptfenster_FormClosing);
            this.Load += new System.EventHandler(this.Hauptfenster_Load);
            this.Autoshintergrund.ResumeLayout(false);
            this.Carkinlogohintergrund.ResumeLayout(false);
            this.Carkinlogohintergrund.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel Autoshintergrund;
        private System.Windows.Forms.Button Autosknopf;
        private System.Windows.Forms.Panel Carkinlogohintergrund;
        private System.Windows.Forms.TextBox carkinlogo;
        private System.Windows.Forms.Button vwknopf;
        private System.Windows.Forms.Button benzknopf;
        private System.Windows.Forms.Button bmwknopf;
        private System.Windows.Forms.Button Audiknopf;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button button1;
    }
}

