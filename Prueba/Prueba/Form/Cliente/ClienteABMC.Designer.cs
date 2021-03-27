
namespace Prueba
{
    partial class FrmClienteABMC
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
            this.BtnClean = new System.Windows.Forms.Button();
            this.BtnSaveClient = new System.Windows.Forms.Button();
            this.TxtNumberDoc = new System.Windows.Forms.MaskedTextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.LblDistrictNumb = new System.Windows.Forms.Label();
            this.CmbDistrict = new System.Windows.Forms.ComboBox();
            this.CmbTypeDoc = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.TxtPhone = new System.Windows.Forms.MaskedTextBox();
            this.TxtAddress = new System.Windows.Forms.TextBox();
            this.TxtCuit = new System.Windows.Forms.TextBox();
            this.TxtSurname = new System.Windows.Forms.TextBox();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.LblAddress = new System.Windows.Forms.Label();
            this.LblDistrict = new System.Windows.Forms.Label();
            this.LblDocument = new System.Windows.Forms.Label();
            this.LblTypeDoc = new System.Windows.Forms.Label();
            this.LblMail = new System.Windows.Forms.Label();
            this.LblCuit = new System.Windows.Forms.Label();
            this.LblPhone = new System.Windows.Forms.Label();
            this.LblSurname = new System.Windows.Forms.Label();
            this.LblName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnClean
            // 
            this.BtnClean.Location = new System.Drawing.Point(440, 362);
            this.BtnClean.Name = "BtnClean";
            this.BtnClean.Size = new System.Drawing.Size(75, 23);
            this.BtnClean.TabIndex = 48;
            this.BtnClean.Text = "Limpiar";
            this.BtnClean.UseVisualStyleBackColor = true;
            // 
            // BtnSaveClient
            // 
            this.BtnSaveClient.Location = new System.Drawing.Point(345, 362);
            this.BtnSaveClient.Name = "BtnSaveClient";
            this.BtnSaveClient.Size = new System.Drawing.Size(75, 23);
            this.BtnSaveClient.TabIndex = 47;
            this.BtnSaveClient.Text = "Guardar";
            this.BtnSaveClient.UseVisualStyleBackColor = true;
            // 
            // TxtNumberDoc
            // 
            this.TxtNumberDoc.Location = new System.Drawing.Point(415, 218);
            this.TxtNumberDoc.Mask = "99999999";
            this.TxtNumberDoc.Name = "TxtNumberDoc";
            this.TxtNumberDoc.Size = new System.Drawing.Size(100, 20);
            this.TxtNumberDoc.TabIndex = 46;
            this.TxtNumberDoc.ValidatingType = typeof(int);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(414, 270);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 45;
            // 
            // LblDistrictNumb
            // 
            this.LblDistrictNumb.AutoSize = true;
            this.LblDistrictNumb.Location = new System.Drawing.Point(285, 275);
            this.LblDistrictNumb.Name = "LblDistrictNumb";
            this.LblDistrictNumb.Size = new System.Drawing.Size(50, 13);
            this.LblDistrictNumb.TabIndex = 44;
            this.LblDistrictNumb.Text = "Numero: ";
            // 
            // CmbDistrict
            // 
            this.CmbDistrict.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbDistrict.FormattingEnabled = true;
            this.CmbDistrict.Location = new System.Drawing.Point(414, 296);
            this.CmbDistrict.Name = "CmbDistrict";
            this.CmbDistrict.Size = new System.Drawing.Size(100, 21);
            this.CmbDistrict.TabIndex = 43;
            // 
            // CmbTypeDoc
            // 
            this.CmbTypeDoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbTypeDoc.FormattingEnabled = true;
            this.CmbTypeDoc.Location = new System.Drawing.Point(414, 191);
            this.CmbTypeDoc.Name = "CmbTypeDoc";
            this.CmbTypeDoc.Size = new System.Drawing.Size(100, 21);
            this.CmbTypeDoc.TabIndex = 42;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(414, 168);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 41;
            // 
            // TxtPhone
            // 
            this.TxtPhone.Location = new System.Drawing.Point(414, 118);
            this.TxtPhone.Mask = "(999)000-0000";
            this.TxtPhone.Name = "TxtPhone";
            this.TxtPhone.Size = new System.Drawing.Size(100, 20);
            this.TxtPhone.TabIndex = 40;
            // 
            // TxtAddress
            // 
            this.TxtAddress.Location = new System.Drawing.Point(414, 244);
            this.TxtAddress.Name = "TxtAddress";
            this.TxtAddress.Size = new System.Drawing.Size(100, 20);
            this.TxtAddress.TabIndex = 39;
            // 
            // TxtCuit
            // 
            this.TxtCuit.Location = new System.Drawing.Point(414, 144);
            this.TxtCuit.Name = "TxtCuit";
            this.TxtCuit.Size = new System.Drawing.Size(100, 20);
            this.TxtCuit.TabIndex = 38;
            // 
            // TxtSurname
            // 
            this.TxtSurname.Location = new System.Drawing.Point(414, 92);
            this.TxtSurname.Name = "TxtSurname";
            this.TxtSurname.Size = new System.Drawing.Size(100, 20);
            this.TxtSurname.TabIndex = 37;
            // 
            // TxtName
            // 
            this.TxtName.Location = new System.Drawing.Point(414, 66);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(100, 20);
            this.TxtName.TabIndex = 36;
            // 
            // LblAddress
            // 
            this.LblAddress.AutoSize = true;
            this.LblAddress.Location = new System.Drawing.Point(285, 251);
            this.LblAddress.Name = "LblAddress";
            this.LblAddress.Size = new System.Drawing.Size(55, 13);
            this.LblAddress.TabIndex = 35;
            this.LblAddress.Text = "Domicilio: ";
            // 
            // LblDistrict
            // 
            this.LblDistrict.AutoSize = true;
            this.LblDistrict.Location = new System.Drawing.Point(285, 296);
            this.LblDistrict.Name = "LblDistrict";
            this.LblDistrict.Size = new System.Drawing.Size(40, 13);
            this.LblDistrict.TabIndex = 34;
            this.LblDistrict.Text = "Barrio: ";
            // 
            // LblDocument
            // 
            this.LblDocument.AutoSize = true;
            this.LblDocument.Location = new System.Drawing.Point(285, 225);
            this.LblDocument.Name = "LblDocument";
            this.LblDocument.Size = new System.Drawing.Size(123, 13);
            this.LblDocument.TabIndex = 33;
            this.LblDocument.Text = "Numero de Documento: ";
            // 
            // LblTypeDoc
            // 
            this.LblTypeDoc.AutoSize = true;
            this.LblTypeDoc.Location = new System.Drawing.Point(285, 199);
            this.LblTypeDoc.Name = "LblTypeDoc";
            this.LblTypeDoc.Size = new System.Drawing.Size(107, 13);
            this.LblTypeDoc.TabIndex = 32;
            this.LblTypeDoc.Text = "Tipo de Documento: ";
            // 
            // LblMail
            // 
            this.LblMail.AutoSize = true;
            this.LblMail.Location = new System.Drawing.Point(285, 175);
            this.LblMail.Name = "LblMail";
            this.LblMail.Size = new System.Drawing.Size(32, 13);
            this.LblMail.TabIndex = 31;
            this.LblMail.Text = "Mail: ";
            // 
            // LblCuit
            // 
            this.LblCuit.AutoSize = true;
            this.LblCuit.Location = new System.Drawing.Point(285, 151);
            this.LblCuit.Name = "LblCuit";
            this.LblCuit.Size = new System.Drawing.Size(38, 13);
            this.LblCuit.TabIndex = 30;
            this.LblCuit.Text = "CUIT: ";
            // 
            // LblPhone
            // 
            this.LblPhone.AutoSize = true;
            this.LblPhone.Location = new System.Drawing.Point(285, 127);
            this.LblPhone.Name = "LblPhone";
            this.LblPhone.Size = new System.Drawing.Size(55, 13);
            this.LblPhone.TabIndex = 29;
            this.LblPhone.Text = "Telefono: ";
            // 
            // LblSurname
            // 
            this.LblSurname.AutoSize = true;
            this.LblSurname.Location = new System.Drawing.Point(285, 101);
            this.LblSurname.Name = "LblSurname";
            this.LblSurname.Size = new System.Drawing.Size(50, 13);
            this.LblSurname.TabIndex = 28;
            this.LblSurname.Text = "Apellido: ";
            // 
            // LblName
            // 
            this.LblName.AutoSize = true;
            this.LblName.Location = new System.Drawing.Point(285, 75);
            this.LblName.Name = "LblName";
            this.LblName.Size = new System.Drawing.Size(44, 13);
            this.LblName.TabIndex = 27;
            this.LblName.Text = "Nombre";
            // 
            // FrmClienteABMC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnClean);
            this.Controls.Add(this.BtnSaveClient);
            this.Controls.Add(this.TxtNumberDoc);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.LblDistrictNumb);
            this.Controls.Add(this.CmbDistrict);
            this.Controls.Add(this.CmbTypeDoc);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.TxtPhone);
            this.Controls.Add(this.TxtAddress);
            this.Controls.Add(this.TxtCuit);
            this.Controls.Add(this.TxtSurname);
            this.Controls.Add(this.TxtName);
            this.Controls.Add(this.LblAddress);
            this.Controls.Add(this.LblDistrict);
            this.Controls.Add(this.LblDocument);
            this.Controls.Add(this.LblTypeDoc);
            this.Controls.Add(this.LblMail);
            this.Controls.Add(this.LblCuit);
            this.Controls.Add(this.LblPhone);
            this.Controls.Add(this.LblSurname);
            this.Controls.Add(this.LblName);
            this.Name = "FrmClienteABMC";
            this.Text = "ClienteABMC";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnClean;
        private System.Windows.Forms.Button BtnSaveClient;
        private System.Windows.Forms.MaskedTextBox TxtNumberDoc;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label LblDistrictNumb;
        private System.Windows.Forms.ComboBox CmbDistrict;
        private System.Windows.Forms.ComboBox CmbTypeDoc;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.MaskedTextBox TxtPhone;
        private System.Windows.Forms.TextBox TxtAddress;
        private System.Windows.Forms.TextBox TxtCuit;
        private System.Windows.Forms.TextBox TxtSurname;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.Label LblAddress;
        private System.Windows.Forms.Label LblDistrict;
        private System.Windows.Forms.Label LblDocument;
        private System.Windows.Forms.Label LblTypeDoc;
        private System.Windows.Forms.Label LblMail;
        private System.Windows.Forms.Label LblCuit;
        private System.Windows.Forms.Label LblPhone;
        private System.Windows.Forms.Label LblSurname;
        private System.Windows.Forms.Label LblName;
    }
}