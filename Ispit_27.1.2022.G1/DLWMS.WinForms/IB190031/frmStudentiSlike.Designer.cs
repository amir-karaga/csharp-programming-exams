
namespace DLWMS.WinForms.IB190031
{
    partial class frmStudentiSlike
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.txtOpisDodaj = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.lblBrojSlike = new System.Windows.Forms.Label();
            this.lblDatumSlikePregled = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtOpisPregled = new System.Windows.Forms.TextBox();
            this.btnDesno = new System.Windows.Forms.Button();
            this.btnLijevo = new System.Windows.Forms.Button();
            this.err = new System.Windows.Forms.ErrorProvider(this.components);
            this.ofd = new System.Windows.Forms.OpenFileDialog();
            this.pbSlikaPregled = new System.Windows.Forms.PictureBox();
            this.pbSlikaDodaj = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.err)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSlikaPregled)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSlikaDodaj)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Slika";
            // 
            // txtOpisDodaj
            // 
            this.txtOpisDodaj.Location = new System.Drawing.Point(244, 50);
            this.txtOpisDodaj.Multiline = true;
            this.txtOpisDodaj.Name = "txtOpisDodaj";
            this.txtOpisDodaj.Size = new System.Drawing.Size(724, 153);
            this.txtOpisDodaj.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(241, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Opis";
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(851, 235);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(106, 28);
            this.btnDodaj.TabIndex = 4;
            this.btnDodaj.Text = "Dodaj sliku";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // lblBrojSlike
            // 
            this.lblBrojSlike.AutoSize = true;
            this.lblBrojSlike.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblBrojSlike.Location = new System.Drawing.Point(457, 304);
            this.lblBrojSlike.Name = "lblBrojSlike";
            this.lblBrojSlike.Size = new System.Drawing.Size(0, 25);
            this.lblBrojSlike.TabIndex = 5;
            // 
            // lblDatumSlikePregled
            // 
            this.lblDatumSlikePregled.AutoSize = true;
            this.lblDatumSlikePregled.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblDatumSlikePregled.Location = new System.Drawing.Point(436, 615);
            this.lblDatumSlikePregled.Name = "lblDatumSlikePregled";
            this.lblDatumSlikePregled.Size = new System.Drawing.Size(0, 20);
            this.lblDatumSlikePregled.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(19, 287);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Pregled slika";
            // 
            // txtOpisPregled
            // 
            this.txtOpisPregled.Location = new System.Drawing.Point(216, 645);
            this.txtOpisPregled.Multiline = true;
            this.txtOpisPregled.Name = "txtOpisPregled";
            this.txtOpisPregled.ReadOnly = true;
            this.txtOpisPregled.Size = new System.Drawing.Size(540, 153);
            this.txtOpisPregled.TabIndex = 9;
            // 
            // btnDesno
            // 
            this.btnDesno.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDesno.Location = new System.Drawing.Point(661, 452);
            this.btnDesno.Name = "btnDesno";
            this.btnDesno.Size = new System.Drawing.Size(106, 28);
            this.btnDesno.TabIndex = 10;
            this.btnDesno.Text = "==>";
            this.btnDesno.UseVisualStyleBackColor = true;
            this.btnDesno.Click += new System.EventHandler(this.btnDesno_Click);
            // 
            // btnLijevo
            // 
            this.btnLijevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnLijevo.Location = new System.Drawing.Point(216, 452);
            this.btnLijevo.Name = "btnLijevo";
            this.btnLijevo.Size = new System.Drawing.Size(106, 28);
            this.btnLijevo.TabIndex = 11;
            this.btnLijevo.Text = "<==";
            this.btnLijevo.UseVisualStyleBackColor = true;
            this.btnLijevo.Click += new System.EventHandler(this.btnLijevo_Click);
            // 
            // err
            // 
            this.err.ContainerControl = this;
            // 
            // ofd
            // 
            this.ofd.FileName = "openFileDialog1";
            // 
            // pbSlikaPregled
            // 
            this.pbSlikaPregled.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbSlikaPregled.Location = new System.Drawing.Point(362, 338);
            this.pbSlikaPregled.Name = "pbSlikaPregled";
            this.pbSlikaPregled.Size = new System.Drawing.Size(270, 268);
            this.pbSlikaPregled.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSlikaPregled.TabIndex = 6;
            this.pbSlikaPregled.TabStop = false;
            // 
            // pbSlikaDodaj
            // 
            this.pbSlikaDodaj.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbSlikaDodaj.Location = new System.Drawing.Point(24, 50);
            this.pbSlikaDodaj.Name = "pbSlikaDodaj";
            this.pbSlikaDodaj.Size = new System.Drawing.Size(203, 213);
            this.pbSlikaDodaj.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSlikaDodaj.TabIndex = 0;
            this.pbSlikaDodaj.TabStop = false;
            this.pbSlikaDodaj.Click += new System.EventHandler(this.pbSlikaDodaj_Click);
            // 
            // frmStudentiSlike
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(988, 810);
            this.Controls.Add(this.btnLijevo);
            this.Controls.Add(this.btnDesno);
            this.Controls.Add(this.txtOpisPregled);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblDatumSlikePregled);
            this.Controls.Add(this.pbSlikaPregled);
            this.Controls.Add(this.lblBrojSlike);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtOpisDodaj);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbSlikaDodaj);
            this.Name = "frmStudentiSlike";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmStudentiSlike";
            this.Load += new System.EventHandler(this.frmStudentiSlike_Load);
            ((System.ComponentModel.ISupportInitialize)(this.err)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSlikaPregled)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSlikaDodaj)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbSlikaDodaj;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtOpisDodaj;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Label lblBrojSlike;
        private System.Windows.Forms.PictureBox pbSlikaPregled;
        private System.Windows.Forms.Label lblDatumSlikePregled;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtOpisPregled;
        private System.Windows.Forms.Button btnDesno;
        private System.Windows.Forms.Button btnLijevo;
        private System.Windows.Forms.ErrorProvider err;
        private System.Windows.Forms.OpenFileDialog ofd;
    }
}