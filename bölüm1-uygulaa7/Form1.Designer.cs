namespace bölüm1_uygulaa7
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
            this.txtEklenecekmeyve = new System.Windows.Forms.TextBox();
            this.btnSepeteekle = new System.Windows.Forms.Button();
            this.lboxmeyveler = new System.Windows.Forms.ListBox();
            this.btnSil = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnsecilinesneyisil = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtEklenecekmeyve
            // 
            this.txtEklenecekmeyve.Location = new System.Drawing.Point(134, 96);
            this.txtEklenecekmeyve.Name = "txtEklenecekmeyve";
            this.txtEklenecekmeyve.Size = new System.Drawing.Size(100, 20);
            this.txtEklenecekmeyve.TabIndex = 0;
            this.txtEklenecekmeyve.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnSepeteekle
            // 
            this.btnSepeteekle.BackColor = System.Drawing.Color.Yellow;
            this.btnSepeteekle.Location = new System.Drawing.Point(134, 154);
            this.btnSepeteekle.Name = "btnSepeteekle";
            this.btnSepeteekle.Size = new System.Drawing.Size(100, 23);
            this.btnSepeteekle.TabIndex = 1;
            this.btnSepeteekle.Text = "sepete ekle";
            this.btnSepeteekle.UseVisualStyleBackColor = false;
            this.btnSepeteekle.Click += new System.EventHandler(this.button1_Click);
            // 
            // lboxmeyveler
            // 
            this.lboxmeyveler.FormattingEnabled = true;
            this.lboxmeyveler.Location = new System.Drawing.Point(334, 64);
            this.lboxmeyveler.Name = "lboxmeyveler";
            this.lboxmeyveler.Size = new System.Drawing.Size(120, 160);
            this.lboxmeyveler.TabIndex = 2;
            // 
            // btnSil
            // 
            this.btnSil.AutoSize = true;
            this.btnSil.BackColor = System.Drawing.Color.Blue;
            this.btnSil.Location = new System.Drawing.Point(137, 194);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(97, 23);
            this.btnSil.TabIndex = 3;
            this.btnSil.Text = "sil";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(131, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "eklenecek meyveler";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(331, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "meyveler";
            // 
            // btnsecilinesneyisil
            // 
            this.btnsecilinesneyisil.AutoSize = true;
            this.btnsecilinesneyisil.BackColor = System.Drawing.Color.Blue;
            this.btnsecilinesneyisil.Location = new System.Drawing.Point(137, 242);
            this.btnsecilinesneyisil.Name = "btnsecilinesneyisil";
            this.btnsecilinesneyisil.Size = new System.Drawing.Size(97, 23);
            this.btnsecilinesneyisil.TabIndex = 6;
            this.btnsecilinesneyisil.Text = "seçili nesneyi sil";
            this.btnsecilinesneyisil.UseVisualStyleBackColor = false;
            this.btnsecilinesneyisil.Click += new System.EventHandler(this.btnsecilinesneyisil_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(532, 450);
            this.Controls.Add(this.btnsecilinesneyisil);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.lboxmeyveler);
            this.Controls.Add(this.btnSepeteekle);
            this.Controls.Add(this.txtEklenecekmeyve);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEklenecekmeyve;
        private System.Windows.Forms.Button btnSepeteekle;
        private System.Windows.Forms.ListBox lboxmeyveler;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnsecilinesneyisil;
    }
}

