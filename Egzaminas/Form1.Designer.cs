namespace Egzaminas
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
            DateTimePicker = new DateTimePicker();
            buttonConnect = new Button();
            buttonDelete = new Button();
            buttonEdit = new Button();
            buttonInsert = new Button();
            dataGridView1 = new DataGridView();
            comboBoxKategorija = new ComboBox();
            textBoxSuma = new TextBox();
            Suma = new Label();
            Kategorija = new Label();
            label1 = new Label();
            Likutis = new Label();
            Pajamos = new Label();
            Islaidos = new Label();
            buttonExtend = new Button();
            label5 = new Label();
            Ataskaita = new Button();
            buttonUpdate = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // DateTimePicker
            // 
            DateTimePicker.Format = DateTimePickerFormat.Short;
            DateTimePicker.Location = new Point(46, 203);
            DateTimePicker.Name = "DateTimePicker";
            DateTimePicker.Size = new Size(221, 23);
            DateTimePicker.TabIndex = 18;
            DateTimePicker.Value = new DateTime(2024, 1, 9, 0, 0, 0, 0);
            // 
            // buttonConnect
            // 
            buttonConnect.Location = new Point(46, 376);
            buttonConnect.Name = "buttonConnect";
            buttonConnect.Size = new Size(187, 44);
            buttonConnect.TabIndex = 0;
            buttonConnect.Text = "Prisijungti";
            buttonConnect.UseVisualStyleBackColor = true;
            buttonConnect.Click += buttonConnect_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.Enabled = false;
            buttonDelete.Location = new Point(296, 165);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(90, 23);
            buttonDelete.TabIndex = 1;
            buttonDelete.Text = "Trinti";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // buttonEdit
            // 
            buttonEdit.Enabled = false;
            buttonEdit.Location = new Point(296, 110);
            buttonEdit.Name = "buttonEdit";
            buttonEdit.Size = new Size(90, 23);
            buttonEdit.TabIndex = 2;
            buttonEdit.Text = "Keisti";
            buttonEdit.UseVisualStyleBackColor = true;
            buttonEdit.Click += buttonEdit_Click;
            // 
            // buttonInsert
            // 
            buttonInsert.Enabled = false;
            buttonInsert.Location = new Point(46, 262);
            buttonInsert.Name = "buttonInsert";
            buttonInsert.Size = new Size(221, 23);
            buttonInsert.TabIndex = 3;
            buttonInsert.Text = "Pildyti";
            buttonInsert.UseVisualStyleBackColor = true;
            buttonInsert.Click += buttonInsert_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(414, 24);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(561, 340);
            dataGridView1.TabIndex = 4;
            // 
            // comboBoxKategorija
            // 
            comboBoxKategorija.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxKategorija.FormattingEnabled = true;
            comboBoxKategorija.Location = new Point(46, 115);
            comboBoxKategorija.Name = "comboBoxKategorija";
            comboBoxKategorija.Size = new Size(221, 23);
            comboBoxKategorija.TabIndex = 5;
            // 
            // textBoxSuma
            // 
            textBoxSuma.Location = new Point(46, 54);
            textBoxSuma.Name = "textBoxSuma";
            textBoxSuma.Size = new Size(221, 23);
            textBoxSuma.TabIndex = 8;
            // 
            // Suma
            // 
            Suma.AutoSize = true;
            Suma.Location = new Point(51, 36);
            Suma.Name = "Suma";
            Suma.Size = new Size(37, 15);
            Suma.TabIndex = 9;
            Suma.Text = "Suma";
            // 
            // Kategorija
            // 
            Kategorija.AutoSize = true;
            Kategorija.Location = new Point(46, 97);
            Kategorija.Name = "Kategorija";
            Kategorija.Size = new Size(60, 15);
            Kategorija.TabIndex = 10;
            Kategorija.Text = "Kategorija";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(413, 376);
            label1.Name = "label1";
            label1.Size = new Size(125, 15);
            label1.TabIndex = 12;
            label1.Text = "Sumos pasiskirstymas:";
            // 
            // Likutis
            // 
            Likutis.AutoSize = true;
            Likutis.Location = new Point(413, 401);
            Likutis.Name = "Likutis";
            Likutis.Size = new Size(44, 15);
            Likutis.TabIndex = 13;
            Likutis.Text = "Likutis:";
            // 
            // Pajamos
            // 
            Pajamos.AutoSize = true;
            Pajamos.Location = new Point(631, 401);
            Pajamos.Name = "Pajamos";
            Pajamos.Size = new Size(55, 15);
            Pajamos.TabIndex = 14;
            Pajamos.Text = "Pajamos:";
            // 
            // Islaidos
            // 
            Islaidos.AutoSize = true;
            Islaidos.Location = new Point(846, 401);
            Islaidos.Name = "Islaidos";
            Islaidos.Size = new Size(49, 15);
            Islaidos.TabIndex = 15;
            Islaidos.Text = "Islaidos:";
            // 
            // buttonExtend
            // 
            buttonExtend.Enabled = false;
            buttonExtend.Location = new Point(46, 144);
            buttonExtend.Name = "buttonExtend";
            buttonExtend.Size = new Size(221, 23);
            buttonExtend.TabIndex = 16;
            buttonExtend.Text = "Papildomos kategorijos";
            buttonExtend.UseVisualStyleBackColor = true;
            buttonExtend.Click += buttonExtend_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(46, 185);
            label5.Name = "label5";
            label5.Size = new Size(31, 15);
            label5.TabIndex = 17;
            label5.Text = "Data";
            // 
            // Ataskaita
            // 
            Ataskaita.Enabled = false;
            Ataskaita.Location = new Point(296, 54);
            Ataskaita.Name = "Ataskaita";
            Ataskaita.Size = new Size(90, 23);
            Ataskaita.TabIndex = 19;
            Ataskaita.Text = "Kurti ataskaita";
            Ataskaita.UseVisualStyleBackColor = true;
            Ataskaita.Click += Ataskaita_Click;
            // 
            // buttonUpdate
            // 
            buttonUpdate.Enabled = false;
            buttonUpdate.Location = new Point(311, 397);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new Size(75, 23);
            buttonUpdate.TabIndex = 20;
            buttonUpdate.Text = "Atnaujinti";
            buttonUpdate.UseVisualStyleBackColor = true;
            buttonUpdate.Click += buttonUpdate_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1007, 450);
            Controls.Add(buttonUpdate);
            Controls.Add(Ataskaita);
            Controls.Add(DateTimePicker);
            Controls.Add(label5);
            Controls.Add(buttonExtend);
            Controls.Add(Islaidos);
            Controls.Add(Pajamos);
            Controls.Add(Likutis);
            Controls.Add(label1);
            Controls.Add(Kategorija);
            Controls.Add(Suma);
            Controls.Add(textBoxSuma);
            Controls.Add(comboBoxKategorija);
            Controls.Add(dataGridView1);
            Controls.Add(buttonInsert);
            Controls.Add(buttonEdit);
            Controls.Add(buttonDelete);
            Controls.Add(buttonConnect);
            MaximizeBox = false;
            Name = "Form1";
            ShowIcon = false;
            Text = "Asmeniniu finansu apskaita";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonConnect;
        private Button buttonDelete;
        private Button buttonEdit;
        private Button buttonInsert;
        private DataGridView dataGridView1;
        private ComboBox comboBoxKategorija;
        private TextBox textBoxSuma;
        private Label Suma;
        private Label Kategorija;
        private Label label1;
        private Label Likutis;
        private Label Pajamos;
        private Label Islaidos;
        private Button buttonExtend;
        private Label label5;
        private DateTimePicker DateTimePicker;
        private Button Ataskaita;
        private Button buttonUpdate;
    }
}