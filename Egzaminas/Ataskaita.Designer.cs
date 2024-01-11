namespace Egzaminas
{
    partial class Ataskaita
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
            dateTimePickerStart = new DateTimePicker();
            dateTimePickerEnd = new DateTimePicker();
            comboBoxKategorija = new ComboBox();
            textBoxMin = new TextBox();
            textBoxMax = new TextBox();
            label1 = new Label();
            Dienos = new Label();
            label3 = new Label();
            comboBoxTipas = new ComboBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            Filtruoti = new Button();
            label8 = new Label();
            label9 = new Label();
            SuspendLayout();
            // 
            // dateTimePickerStart
            // 
            dateTimePickerStart.CustomFormat = "yyyy-MM-dd";
            dateTimePickerStart.Format = DateTimePickerFormat.Short;
            dateTimePickerStart.Location = new Point(18, 50);
            dateTimePickerStart.Name = "dateTimePickerStart";
            dateTimePickerStart.Size = new Size(160, 23);
            dateTimePickerStart.TabIndex = 0;
            dateTimePickerStart.Value = new DateTime(2024, 1, 1, 0, 0, 0, 0);
            dateTimePickerStart.ValueChanged += dateTimePickerStart_ValueChanged;
            // 
            // dateTimePickerEnd
            // 
            dateTimePickerEnd.CustomFormat = "yyyy-MM-dd";
            dateTimePickerEnd.Format = DateTimePickerFormat.Short;
            dateTimePickerEnd.Location = new Point(298, 50);
            dateTimePickerEnd.Name = "dateTimePickerEnd";
            dateTimePickerEnd.Size = new Size(160, 23);
            dateTimePickerEnd.TabIndex = 1;
            dateTimePickerEnd.Value = new DateTime(2024, 1, 31, 0, 0, 0, 0);
            dateTimePickerEnd.ValueChanged += dateTimePickerEnd_ValueChanged;
            // 
            // comboBoxKategorija
            // 
            comboBoxKategorija.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxKategorija.FormattingEnabled = true;
            comboBoxKategorija.Items.AddRange(new object[] { "Kuras" });
            comboBoxKategorija.Location = new Point(145, 128);
            comboBoxKategorija.Name = "comboBoxKategorija";
            comboBoxKategorija.Size = new Size(187, 23);
            comboBoxKategorija.TabIndex = 2;
            // 
            // textBoxMin
            // 
            textBoxMin.Location = new Point(18, 276);
            textBoxMin.Name = "textBoxMin";
            textBoxMin.Size = new Size(160, 23);
            textBoxMin.TabIndex = 3;
            // 
            // textBoxMax
            // 
            textBoxMax.Location = new Point(298, 276);
            textBoxMax.Name = "textBoxMax";
            textBoxMax.Size = new Size(160, 23);
            textBoxMax.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(211, 18);
            label1.Name = "label1";
            label1.Size = new Size(70, 15);
            label1.TabIndex = 5;
            label1.Text = "Laiko tarpas";
            // 
            // Dienos
            // 
            Dienos.AutoSize = true;
            Dienos.Location = new Point(18, 87);
            Dienos.Name = "Dienos";
            Dienos.Size = new Size(73, 15);
            Dienos.TabIndex = 6;
            Dienos.Text = "Dienu kiekis:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(211, 110);
            label3.Name = "label3";
            label3.Size = new Size(60, 15);
            label3.TabIndex = 7;
            label3.Text = "Kategorija";
            // 
            // comboBoxTipas
            // 
            comboBoxTipas.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxTipas.FormattingEnabled = true;
            comboBoxTipas.Items.AddRange(new object[] { "Pajamos", "Islaidos" });
            comboBoxTipas.Location = new Point(145, 188);
            comboBoxTipas.Name = "comboBoxTipas";
            comboBoxTipas.Size = new Size(187, 23);
            comboBoxTipas.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(225, 170);
            label4.Name = "label4";
            label4.Size = new Size(34, 15);
            label4.TabIndex = 9;
            label4.Text = "Tipas";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(222, 240);
            label5.Name = "label5";
            label5.Size = new Size(37, 15);
            label5.TabIndex = 10;
            label5.Text = "Suma";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(79, 258);
            label6.Name = "label6";
            label6.Size = new Size(28, 15);
            label6.TabIndex = 11;
            label6.Text = "Min";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(367, 258);
            label7.Name = "label7";
            label7.Size = new Size(30, 15);
            label7.TabIndex = 12;
            label7.Text = "Max";
            // 
            // Filtruoti
            // 
            Filtruoti.Location = new Point(145, 357);
            Filtruoti.Name = "Filtruoti";
            Filtruoti.Size = new Size(187, 56);
            Filtruoti.TabIndex = 13;
            Filtruoti.Text = "Filtruoti";
            Filtruoti.UseVisualStyleBackColor = true;
            Filtruoti.Click += Filtruoti_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(77, 32);
            label8.Name = "label8";
            label8.Size = new Size(30, 15);
            label8.TabIndex = 14;
            label8.Text = "Nuo";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(367, 32);
            label9.Name = "label9";
            label9.Size = new Size(19, 15);
            label9.TabIndex = 15;
            label9.Text = "Iki";
            // 
            // Ataskaita
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(490, 450);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(Filtruoti);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(comboBoxTipas);
            Controls.Add(label3);
            Controls.Add(Dienos);
            Controls.Add(label1);
            Controls.Add(textBoxMax);
            Controls.Add(textBoxMin);
            Controls.Add(comboBoxKategorija);
            Controls.Add(dateTimePickerEnd);
            Controls.Add(dateTimePickerStart);
            MaximizeBox = false;
            Name = "Ataskaita";
            ShowIcon = false;
            Text = "Ataskaita";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dateTimePickerStart;
        private DateTimePicker dateTimePickerEnd;
        private ComboBox comboBoxKategorija;
        private TextBox textBoxMin;
        private TextBox textBoxMax;
        private Label label1;
        private Label Dienos;
        private Label label3;
        private ComboBox comboBoxTipas;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Button Filtruoti;
        private Label label8;
        private Label label9;
    }
}