using System;

namespace WindowsFormsApplication2
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private EventHandler Form1_Load;

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
            this.radioButtonOpen = new System.Windows.Forms.RadioButton();
            this.radioButtonClose = new System.Windows.Forms.RadioButton();
            this.numericUpDownPotatos = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.numericUpDownLuk = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownSalt = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonWash = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.buttonRezkaTesto = new System.Windows.Forms.Button();
            this.buttonClearPotatos = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.buttonGetPotatos = new System.Windows.Forms.Button();
            this.buttonDrain = new System.Windows.Forms.Button();
            this.numericUpDownManti = new System.Windows.Forms.NumericUpDown();
            this.buttonAddManti = new System.Windows.Forms.Button();
            this.buttonAddWater = new System.Windows.Forms.Button();
            this.buttonAddPotatos = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.buttonAddSalt = new System.Windows.Forms.Button();
            this.buttonAddLuk = new System.Windows.Forms.Button();
            this.buttonAddTesto = new System.Windows.Forms.Button();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.checkBoxOn = new System.Windows.Forms.CheckBox();
            this.buttonCook = new System.Windows.Forms.Button();
            this.buttonAddPan = new System.Windows.Forms.Button();
            this.buttonGetPan = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPotatos)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLuk)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSalt)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownManti)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.SuspendLayout();
            // 
            // radioButtonOpen
            // 
            this.radioButtonOpen.AutoSize = true;
            this.radioButtonOpen.Location = new System.Drawing.Point(17, 32);
            this.radioButtonOpen.Name = "radioButtonOpen";
            this.radioButtonOpen.Size = new System.Drawing.Size(86, 21);
            this.radioButtonOpen.TabIndex = 0;
            this.radioButtonOpen.TabStop = true;
            this.radioButtonOpen.Text = "Открыть";
            this.radioButtonOpen.UseVisualStyleBackColor = true;
            // 
            // radioButtonClose
            // 
            this.radioButtonClose.AutoSize = true;
            this.radioButtonClose.Location = new System.Drawing.Point(17, 78);
            this.radioButtonClose.Name = "radioButtonClose";
            this.radioButtonClose.Size = new System.Drawing.Size(85, 21);
            this.radioButtonClose.TabIndex = 1;
            this.radioButtonClose.TabStop = true;
            this.radioButtonClose.Text = "Закрыть";
            this.radioButtonClose.UseVisualStyleBackColor = true;
            // 
            // numericUpDownPotatos
            // 
            this.numericUpDownPotatos.Location = new System.Drawing.Point(111, 31);
            this.numericUpDownPotatos.Name = "numericUpDownPotatos";
            this.numericUpDownPotatos.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownPotatos.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.numericUpDownLuk);
            this.groupBox1.Controls.Add(this.numericUpDownSalt);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.numericUpDownPotatos);
            this.groupBox1.Location = new System.Drawing.Point(480, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(272, 226);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ингридиенты";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // numericUpDownLuk
            // 
            this.numericUpDownLuk.Location = new System.Drawing.Point(111, 123);
            this.numericUpDownLuk.Name = "numericUpDownLuk";
            this.numericUpDownLuk.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownLuk.TabIndex = 11;
            // 
            // numericUpDownSalt
            // 
            this.numericUpDownSalt.Location = new System.Drawing.Point(111, 78);
            this.numericUpDownSalt.Name = "numericUpDownSalt";
            this.numericUpDownSalt.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownSalt.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Лук";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Специи";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Картошка";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonWash);
            this.groupBox2.Controls.Add(this.radioButtonOpen);
            this.groupBox2.Controls.Add(this.radioButtonClose);
            this.groupBox2.Location = new System.Drawing.Point(29, 35);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(361, 170);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Кран";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // buttonWash
            // 
            this.buttonWash.Location = new System.Drawing.Point(221, 32);
            this.buttonWash.Name = "buttonWash";
            this.buttonWash.Size = new System.Drawing.Size(121, 88);
            this.buttonWash.TabIndex = 2;
            this.buttonWash.Text = "Помыть картошку";
            this.buttonWash.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.buttonRezkaTesto);
            this.groupBox3.Controls.Add(this.buttonClearPotatos);
            this.groupBox3.Location = new System.Drawing.Point(909, 35);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(325, 170);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Нож";
            // 
            // buttonRezkaTesto
            // 
            this.buttonRezkaTesto.Location = new System.Drawing.Point(180, 32);
            this.buttonRezkaTesto.Name = "buttonRezkaTesto";
            this.buttonRezkaTesto.Size = new System.Drawing.Size(116, 67);
            this.buttonRezkaTesto.TabIndex = 1;
            this.buttonRezkaTesto.Text = "Разделить тесто на части";
            this.buttonRezkaTesto.UseVisualStyleBackColor = true;
            // 
            // buttonClearPotatos
            // 
            this.buttonClearPotatos.Location = new System.Drawing.Point(23, 32);
            this.buttonClearPotatos.Name = "buttonClearPotatos";
            this.buttonClearPotatos.Size = new System.Drawing.Size(111, 67);
            this.buttonClearPotatos.TabIndex = 0;
            this.buttonClearPotatos.Text = "Почистить картошку";
            this.buttonClearPotatos.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.buttonGetPotatos);
            this.groupBox4.Controls.Add(this.buttonDrain);
            this.groupBox4.Controls.Add(this.numericUpDownManti);
            this.groupBox4.Controls.Add(this.buttonAddManti);
            this.groupBox4.Controls.Add(this.buttonAddWater);
            this.groupBox4.Location = new System.Drawing.Point(29, 359);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(361, 338);
            this.groupBox4.TabIndex = 9;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Кастрюля";
            // 
            // buttonGetPotatos
            // 
            this.buttonGetPotatos.Location = new System.Drawing.Point(123, 254);
            this.buttonGetPotatos.Name = "buttonGetPotatos";
            this.buttonGetPotatos.Size = new System.Drawing.Size(128, 60);
            this.buttonGetPotatos.TabIndex = 5;
            this.buttonGetPotatos.Text = "готовые манты";
            this.buttonGetPotatos.UseVisualStyleBackColor = true;
            // 
            // buttonDrain
            // 
            this.buttonDrain.Location = new System.Drawing.Point(17, 147);
            this.buttonDrain.Name = "buttonDrain";
            this.buttonDrain.Size = new System.Drawing.Size(143, 60);
            this.buttonDrain.TabIndex = 4;
            this.buttonDrain.Text = "слить воду";
            this.buttonDrain.UseVisualStyleBackColor = true;
            // 
            // numericUpDownManti
            // 
            this.numericUpDownManti.Location = new System.Drawing.Point(188, 147);
            this.numericUpDownManti.Name = "numericUpDownManti";
            this.numericUpDownManti.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownManti.TabIndex = 3;
            // 
            // buttonAddManti
            // 
            this.buttonAddManti.Location = new System.Drawing.Point(188, 36);
            this.buttonAddManti.Name = "buttonAddManti";
            this.buttonAddManti.Size = new System.Drawing.Size(143, 73);
            this.buttonAddManti.TabIndex = 2;
            this.buttonAddManti.Text = "Добавить манты";
            this.buttonAddManti.UseVisualStyleBackColor = true;
            // 
            // buttonAddWater
            // 
            this.buttonAddWater.Location = new System.Drawing.Point(17, 36);
            this.buttonAddWater.Name = "buttonAddWater";
            this.buttonAddWater.Size = new System.Drawing.Size(143, 73);
            this.buttonAddWater.TabIndex = 1;
            this.buttonAddWater.Text = "Залить воду";
            this.buttonAddWater.UseVisualStyleBackColor = true;
            // 
            // buttonAddPotatos
            // 
            this.buttonAddPotatos.Location = new System.Drawing.Point(287, 29);
            this.buttonAddPotatos.Name = "buttonAddPotatos";
            this.buttonAddPotatos.Size = new System.Drawing.Size(143, 73);
            this.buttonAddPotatos.TabIndex = 0;
            this.buttonAddPotatos.Text = "Добавить картошку";
            this.buttonAddPotatos.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.buttonAddSalt);
            this.groupBox5.Controls.Add(this.buttonAddLuk);
            this.groupBox5.Controls.Add(this.buttonAddPotatos);
            this.groupBox5.Controls.Add(this.buttonAddTesto);
            this.groupBox5.Location = new System.Drawing.Point(661, 299);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(573, 169);
            this.groupBox5.TabIndex = 10;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Манты";
            // 
            // buttonAddSalt
            // 
            this.buttonAddSalt.Location = new System.Drawing.Point(445, 36);
            this.buttonAddSalt.Name = "buttonAddSalt";
            this.buttonAddSalt.Size = new System.Drawing.Size(107, 73);
            this.buttonAddSalt.TabIndex = 0;
            this.buttonAddSalt.Text = "Добавить специи";
            this.buttonAddSalt.UseVisualStyleBackColor = true;
            // 
            // buttonAddLuk
            // 
            this.buttonAddLuk.Location = new System.Drawing.Point(157, 29);
            this.buttonAddLuk.Name = "buttonAddLuk";
            this.buttonAddLuk.Size = new System.Drawing.Size(99, 73);
            this.buttonAddLuk.TabIndex = 1;
            this.buttonAddLuk.Text = "Добавить лук";
            this.buttonAddLuk.UseVisualStyleBackColor = true;
            // 
            // buttonAddTesto
            // 
            this.buttonAddTesto.Location = new System.Drawing.Point(16, 36);
            this.buttonAddTesto.Name = "buttonAddTesto";
            this.buttonAddTesto.Size = new System.Drawing.Size(124, 59);
            this.buttonAddTesto.TabIndex = 0;
            this.buttonAddTesto.Text = "Тесто";
            this.buttonAddTesto.UseVisualStyleBackColor = true;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.checkBoxOn);
            this.groupBox7.Controls.Add(this.buttonCook);
            this.groupBox7.Controls.Add(this.buttonAddPan);
            this.groupBox7.Controls.Add(this.buttonGetPan);
            this.groupBox7.Location = new System.Drawing.Point(800, 492);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(315, 328);
            this.groupBox7.TabIndex = 12;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Плита";
            // 
            // checkBoxOn
            // 
            this.checkBoxOn.AutoSize = true;
            this.checkBoxOn.Location = new System.Drawing.Point(111, 21);
            this.checkBoxOn.Name = "checkBoxOn";
            this.checkBoxOn.Size = new System.Drawing.Size(54, 21);
            this.checkBoxOn.TabIndex = 2;
            this.checkBoxOn.Text = "Вкл";
            this.checkBoxOn.UseVisualStyleBackColor = true;
            // 
            // buttonCook
            // 
            this.buttonCook.Location = new System.Drawing.Point(174, 88);
            this.buttonCook.Name = "buttonCook";
            this.buttonCook.Size = new System.Drawing.Size(99, 73);
            this.buttonCook.TabIndex = 1;
            this.buttonCook.Text = "Готовить";
            this.buttonCook.UseVisualStyleBackColor = true;
            this.buttonCook.Click += new System.EventHandler(this.buttonCook_Click);
            // 
            // buttonAddPan
            // 
            this.buttonAddPan.Location = new System.Drawing.Point(16, 88);
            this.buttonAddPan.Name = "buttonAddPan";
            this.buttonAddPan.Size = new System.Drawing.Size(107, 73);
            this.buttonAddPan.TabIndex = 0;
            this.buttonAddPan.Text = "Поставить кастрюлю";
            this.buttonAddPan.UseVisualStyleBackColor = true;
            // 
            // buttonGetPan
            // 
            this.buttonGetPan.Location = new System.Drawing.Point(92, 201);
            this.buttonGetPan.Name = "buttonGetPan";
            this.buttonGetPan.Size = new System.Drawing.Size(143, 73);
            this.buttonGetPan.TabIndex = 0;
            this.buttonGetPan.Text = "Убрать кастрюлю";
            this.buttonGetPan.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1482, 1037);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPotatos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLuk)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSalt)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownManti)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.ResumeLayout(false);

        }


        #endregion

        private System.Windows.Forms.RadioButton radioButtonOpen;
        private System.Windows.Forms.RadioButton radioButtonClose;
        private System.Windows.Forms.NumericUpDown numericUpDownPotatos;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonWash;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button buttonClearPotatos;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button buttonAddManti;
        private System.Windows.Forms.Button buttonAddWater;
        private System.Windows.Forms.Button buttonAddPotatos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button buttonRezkaTesto;
        private System.Windows.Forms.Button buttonAddTesto;
        private System.Windows.Forms.Button buttonAddSalt;
        private System.Windows.Forms.NumericUpDown numericUpDownSalt;
        private System.Windows.Forms.Button buttonAddLuk;
        private System.Windows.Forms.NumericUpDown numericUpDownLuk;
        private System.Windows.Forms.NumericUpDown numericUpDownManti;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Button buttonCook;
        private System.Windows.Forms.Button buttonAddPan;
        private System.Windows.Forms.Button buttonGetPan;
        private System.Windows.Forms.CheckBox checkBoxOn;
        private System.Windows.Forms.Button buttonDrain;
        private System.Windows.Forms.Button buttonGetPotatos;
    }
}

