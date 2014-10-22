namespace ProduktApplikationSpace
{
	partial class ProduktApplikationForm
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
			this.btnNy = new System.Windows.Forms.Button();
			this.btnTaBort = new System.Windows.Forms.Button();
			this.lblIndex = new System.Windows.Forms.Label();
			this.panelFunktion = new System.Windows.Forms.Panel();
			this.btnAndra = new System.Windows.Forms.Button();
			this.cboxProduktBox = new System.Windows.Forms.ComboBox();
			this.lblID = new System.Windows.Forms.Label();
			this.panelInmatning = new System.Windows.Forms.Panel();
			this.txtRefID = new JRINCCustomControls.currencyTextBox(this.components);
			this.txtID = new JRINCCustomControls.currencyTextBox(this.components);
			this.txtPris = new JRINCCustomControls.currencyTextBox(this.components);
			this.txtNamn = new System.Windows.Forms.RichTextBox();
			this.lblNamn = new System.Windows.Forms.Label();
			this.lblRefID = new System.Windows.Forms.Label();
			this.txtRitningsfil = new System.Windows.Forms.RichTextBox();
			this.lblRitningsfil = new System.Windows.Forms.Label();
			this.txtBildfil = new System.Windows.Forms.RichTextBox();
			this.lblBildfil = new System.Windows.Forms.Label();
			this.txtFarg = new System.Windows.Forms.RichTextBox();
			this.lblFarg = new System.Windows.Forms.Label();
			this.txtTyp = new System.Windows.Forms.RichTextBox();
			this.lblTyp = new System.Windows.Forms.Label();
			this.txtMontering = new System.Windows.Forms.RichTextBox();
			this.txtBeskrivning = new System.Windows.Forms.RichTextBox();
			this.lblMontering = new System.Windows.Forms.Label();
			this.lblBeskrivning = new System.Windows.Forms.Label();
			this.lblPris = new System.Windows.Forms.Label();
			this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
			this.panelFunktion.SuspendLayout();
			this.panelInmatning.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnNy
			// 
			this.btnNy.Location = new System.Drawing.Point(62, -1);
			this.btnNy.Name = "btnNy";
			this.btnNy.Size = new System.Drawing.Size(50, 25);
			this.btnNy.TabIndex = 0;
			this.btnNy.Text = "Ny";
			this.btnNy.UseVisualStyleBackColor = true;
			this.btnNy.Click += new System.EventHandler(this.btnNy_Click);
			// 
			// btnTaBort
			// 
			this.btnTaBort.Location = new System.Drawing.Point(118, -1);
			this.btnTaBort.Name = "btnTaBort";
			this.btnTaBort.Size = new System.Drawing.Size(50, 25);
			this.btnTaBort.TabIndex = 3;
			this.btnTaBort.Text = "Ta bort";
			this.btnTaBort.UseVisualStyleBackColor = true;
			this.btnTaBort.Click += new System.EventHandler(this.btnTaBort_Click);
			// 
			// lblIndex
			// 
			this.lblIndex.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lblIndex.Location = new System.Drawing.Point(3, 0);
			this.lblIndex.Name = "lblIndex";
			this.lblIndex.Size = new System.Drawing.Size(50, 23);
			this.lblIndex.TabIndex = 4;
			this.lblIndex.Text = "0";
			this.lblIndex.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// panelFunktion
			// 
			this.panelFunktion.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.panelFunktion.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.panelFunktion.Controls.Add(this.btnAndra);
			this.panelFunktion.Controls.Add(this.cboxProduktBox);
			this.panelFunktion.Controls.Add(this.lblIndex);
			this.panelFunktion.Controls.Add(this.btnTaBort);
			this.panelFunktion.Controls.Add(this.btnNy);
			this.panelFunktion.Location = new System.Drawing.Point(37, 30);
			this.panelFunktion.Name = "panelFunktion";
			this.panelFunktion.Size = new System.Drawing.Size(404, 27);
			this.panelFunktion.TabIndex = 5;
			// 
			// btnAndra
			// 
			this.btnAndra.Location = new System.Drawing.Point(174, -1);
			this.btnAndra.Name = "btnAndra";
			this.btnAndra.Size = new System.Drawing.Size(50, 25);
			this.btnAndra.TabIndex = 7;
			this.btnAndra.Text = "Spara";
			this.btnAndra.UseVisualStyleBackColor = true;
			this.btnAndra.Click += new System.EventHandler(this.btnAndra_Click);
			// 
			// cboxProduktBox
			// 
			this.cboxProduktBox.FormattingEnabled = true;
			this.cboxProduktBox.Location = new System.Drawing.Point(238, 2);
			this.cboxProduktBox.Name = "cboxProduktBox";
			this.cboxProduktBox.Size = new System.Drawing.Size(159, 21);
			this.cboxProduktBox.TabIndex = 6;
			this.cboxProduktBox.SelectedIndexChanged += new System.EventHandler(this.cboxProduktBox_SelectedIndexChanged);
			// 
			// lblID
			// 
			this.lblID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblID.Location = new System.Drawing.Point(3, 0);
			this.lblID.Name = "lblID";
			this.lblID.Size = new System.Drawing.Size(164, 30);
			this.lblID.TabIndex = 6;
			this.lblID.Text = "ID:";
			this.lblID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// panelInmatning
			// 
			this.panelInmatning.Controls.Add(this.txtRefID);
			this.panelInmatning.Controls.Add(this.txtID);
			this.panelInmatning.Controls.Add(this.txtPris);
			this.panelInmatning.Controls.Add(this.txtNamn);
			this.panelInmatning.Controls.Add(this.lblNamn);
			this.panelInmatning.Controls.Add(this.lblRefID);
			this.panelInmatning.Controls.Add(this.txtRitningsfil);
			this.panelInmatning.Controls.Add(this.lblRitningsfil);
			this.panelInmatning.Controls.Add(this.txtBildfil);
			this.panelInmatning.Controls.Add(this.lblBildfil);
			this.panelInmatning.Controls.Add(this.txtFarg);
			this.panelInmatning.Controls.Add(this.lblFarg);
			this.panelInmatning.Controls.Add(this.txtTyp);
			this.panelInmatning.Controls.Add(this.lblTyp);
			this.panelInmatning.Controls.Add(this.txtMontering);
			this.panelInmatning.Controls.Add(this.txtBeskrivning);
			this.panelInmatning.Controls.Add(this.lblMontering);
			this.panelInmatning.Controls.Add(this.lblBeskrivning);
			this.panelInmatning.Controls.Add(this.lblPris);
			this.panelInmatning.Controls.Add(this.lblID);
			this.panelInmatning.Location = new System.Drawing.Point(34, 97);
			this.panelInmatning.Name = "panelInmatning";
			this.panelInmatning.Size = new System.Drawing.Size(725, 365);
			this.panelInmatning.TabIndex = 7;
			// 
			// txtRefID
			// 
			this.txtRefID.DecimalPlaces = 5;
			this.txtRefID.DecimalsSeparator = '\0';
			this.txtRefID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtRefID.Location = new System.Drawing.Point(528, 0);
			this.txtRefID.MaxLength = 5;
			this.txtRefID.Multiline = true;
			this.txtRefID.Name = "txtRefID";
			this.txtRefID.PreFix = "";
			this.txtRefID.Size = new System.Drawing.Size(194, 30);
			this.txtRefID.TabIndex = 33;
			this.txtRefID.Text = "00000";
			this.txtRefID.ThousandsSeparator = '\0';
			// 
			// txtID
			// 
			this.txtID.DecimalPlaces = 5;
			this.txtID.DecimalsSeparator = '\0';
			this.txtID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtID.Location = new System.Drawing.Point(164, 0);
			this.txtID.MaxLength = 5;
			this.txtID.Multiline = true;
			this.txtID.Name = "txtID";
			this.txtID.PreFix = "";
			this.txtID.Size = new System.Drawing.Size(194, 30);
			this.txtID.TabIndex = 32;
			this.txtID.Text = "00000";
			this.txtID.ThousandsSeparator = '\0';
			// 
			// txtPris
			// 
			this.txtPris.DecimalPlaces = 2;
			this.txtPris.DecimalsSeparator = ',';
			this.txtPris.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtPris.Location = new System.Drawing.Point(164, 60);
			this.txtPris.MaxLength = 10;
			this.txtPris.Multiline = true;
			this.txtPris.Name = "txtPris";
			this.txtPris.PreFix = "kr";
			this.txtPris.Size = new System.Drawing.Size(194, 30);
			this.txtPris.TabIndex = 8;
			this.txtPris.Text = "0,00";
			this.txtPris.ThousandsSeparator = ' ';
			// 
			// txtNamn
			// 
			this.txtNamn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtNamn.Location = new System.Drawing.Point(164, 30);
			this.txtNamn.MaxLength = 30;
			this.txtNamn.Name = "txtNamn";
			this.txtNamn.Size = new System.Drawing.Size(194, 30);
			this.txtNamn.TabIndex = 30;
			this.txtNamn.Text = "";
			// 
			// lblNamn
			// 
			this.lblNamn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lblNamn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblNamn.Location = new System.Drawing.Point(3, 30);
			this.lblNamn.Name = "lblNamn";
			this.lblNamn.Size = new System.Drawing.Size(164, 30);
			this.lblNamn.TabIndex = 29;
			this.lblNamn.Text = "Namn:";
			this.lblNamn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblRefID
			// 
			this.lblRefID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lblRefID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblRefID.Location = new System.Drawing.Point(364, 0);
			this.lblRefID.Name = "lblRefID";
			this.lblRefID.Size = new System.Drawing.Size(164, 30);
			this.lblRefID.TabIndex = 27;
			this.lblRefID.Text = "RefID:";
			this.lblRefID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txtRitningsfil
			// 
			this.txtRitningsfil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtRitningsfil.Location = new System.Drawing.Point(164, 180);
			this.txtRitningsfil.MaxLength = 30;
			this.txtRitningsfil.Name = "txtRitningsfil";
			this.txtRitningsfil.Size = new System.Drawing.Size(194, 30);
			this.txtRitningsfil.TabIndex = 26;
			this.txtRitningsfil.Text = "";
			// 
			// lblRitningsfil
			// 
			this.lblRitningsfil.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lblRitningsfil.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblRitningsfil.Location = new System.Drawing.Point(3, 180);
			this.lblRitningsfil.Name = "lblRitningsfil";
			this.lblRitningsfil.Size = new System.Drawing.Size(164, 30);
			this.lblRitningsfil.TabIndex = 25;
			this.lblRitningsfil.Text = "Ritningsfilnamn:";
			this.lblRitningsfil.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txtBildfil
			// 
			this.txtBildfil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtBildfil.Location = new System.Drawing.Point(164, 150);
			this.txtBildfil.MaxLength = 30;
			this.txtBildfil.Name = "txtBildfil";
			this.txtBildfil.Size = new System.Drawing.Size(194, 30);
			this.txtBildfil.TabIndex = 24;
			this.txtBildfil.Text = "";
			// 
			// lblBildfil
			// 
			this.lblBildfil.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lblBildfil.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblBildfil.Location = new System.Drawing.Point(3, 150);
			this.lblBildfil.Name = "lblBildfil";
			this.lblBildfil.Size = new System.Drawing.Size(164, 30);
			this.lblBildfil.TabIndex = 23;
			this.lblBildfil.Text = "Bildfilnamn:";
			this.lblBildfil.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txtFarg
			// 
			this.txtFarg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtFarg.Location = new System.Drawing.Point(164, 120);
			this.txtFarg.MaxLength = 30;
			this.txtFarg.Name = "txtFarg";
			this.txtFarg.Size = new System.Drawing.Size(194, 30);
			this.txtFarg.TabIndex = 22;
			this.txtFarg.Text = "";
			// 
			// lblFarg
			// 
			this.lblFarg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lblFarg.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblFarg.Location = new System.Drawing.Point(3, 120);
			this.lblFarg.Name = "lblFarg";
			this.lblFarg.Size = new System.Drawing.Size(164, 30);
			this.lblFarg.TabIndex = 21;
			this.lblFarg.Text = "Färg:";
			this.lblFarg.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txtTyp
			// 
			this.txtTyp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtTyp.Location = new System.Drawing.Point(164, 90);
			this.txtTyp.MaxLength = 30;
			this.txtTyp.Name = "txtTyp";
			this.txtTyp.Size = new System.Drawing.Size(194, 30);
			this.txtTyp.TabIndex = 20;
			this.txtTyp.Text = "";
			// 
			// lblTyp
			// 
			this.lblTyp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lblTyp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTyp.Location = new System.Drawing.Point(3, 90);
			this.lblTyp.Name = "lblTyp";
			this.lblTyp.Size = new System.Drawing.Size(164, 30);
			this.lblTyp.TabIndex = 19;
			this.lblTyp.Text = "Typ:";
			this.lblTyp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txtMontering
			// 
			this.txtMontering.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtMontering.Location = new System.Drawing.Point(3, 240);
			this.txtMontering.MaxLength = 300;
			this.txtMontering.Name = "txtMontering";
			this.txtMontering.Size = new System.Drawing.Size(355, 118);
			this.txtMontering.TabIndex = 18;
			this.txtMontering.Text = "";
			// 
			// txtBeskrivning
			// 
			this.txtBeskrivning.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtBeskrivning.Location = new System.Drawing.Point(364, 60);
			this.txtBeskrivning.MaxLength = 800;
			this.txtBeskrivning.Name = "txtBeskrivning";
			this.txtBeskrivning.Size = new System.Drawing.Size(355, 298);
			this.txtBeskrivning.TabIndex = 17;
			this.txtBeskrivning.Text = "";
			// 
			// lblMontering
			// 
			this.lblMontering.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lblMontering.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblMontering.Location = new System.Drawing.Point(3, 210);
			this.lblMontering.Name = "lblMontering";
			this.lblMontering.Size = new System.Drawing.Size(164, 30);
			this.lblMontering.TabIndex = 10;
			this.lblMontering.Text = "Monteringsbeskrivning:";
			this.lblMontering.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblBeskrivning
			// 
			this.lblBeskrivning.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lblBeskrivning.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblBeskrivning.Location = new System.Drawing.Point(364, 30);
			this.lblBeskrivning.Name = "lblBeskrivning";
			this.lblBeskrivning.Size = new System.Drawing.Size(164, 30);
			this.lblBeskrivning.TabIndex = 9;
			this.lblBeskrivning.Text = "Beskrivning:";
			this.lblBeskrivning.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblPris
			// 
			this.lblPris.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lblPris.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblPris.Location = new System.Drawing.Point(3, 60);
			this.lblPris.Name = "lblPris";
			this.lblPris.Size = new System.Drawing.Size(164, 30);
			this.lblPris.TabIndex = 8;
			this.lblPris.Text = "Pris (sek):";
			this.lblPris.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// ProduktApplikationForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(784, 562);
			this.Controls.Add(this.panelInmatning);
			this.Controls.Add(this.panelFunktion);
			this.Name = "ProduktApplikationForm";
			this.Text = "Ljus och Miljö AB - Produkt Hanteraren";
			this.Load += new System.EventHandler(this.ProduktApplikationForm_Load);
			this.panelFunktion.ResumeLayout(false);
			this.panelInmatning.ResumeLayout(false);
			this.panelInmatning.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnNy;
		private System.Windows.Forms.Button btnTaBort;
		private System.Windows.Forms.Label lblIndex;
		private System.Windows.Forms.Panel panelFunktion;
		private System.Windows.Forms.ComboBox cboxProduktBox;
		private System.Windows.Forms.Button btnAndra;
		private System.Windows.Forms.Label lblID;
		private System.Windows.Forms.Panel panelInmatning;
		private System.Windows.Forms.Label lblMontering;
		private System.Windows.Forms.Label lblBeskrivning;
		private System.Windows.Forms.Label lblPris;
		private System.Windows.Forms.Label lblRefID;
		private System.Windows.Forms.RichTextBox txtRitningsfil;
		private System.Windows.Forms.Label lblRitningsfil;
		private System.Windows.Forms.RichTextBox txtBildfil;
		private System.Windows.Forms.Label lblBildfil;
		private System.Windows.Forms.RichTextBox txtFarg;
		private System.Windows.Forms.Label lblFarg;
		private System.Windows.Forms.RichTextBox txtTyp;
		private System.Windows.Forms.Label lblTyp;
		private System.Windows.Forms.RichTextBox txtMontering;
		private System.Windows.Forms.RichTextBox txtBeskrivning;
		private System.Windows.Forms.RichTextBox txtNamn;
		private System.Windows.Forms.Label lblNamn;
		private System.ComponentModel.BackgroundWorker backgroundWorker1;
		private JRINCCustomControls.currencyTextBox txtPris;
		private JRINCCustomControls.currencyTextBox txtID;
		private JRINCCustomControls.currencyTextBox txtRefID;
	}
}

