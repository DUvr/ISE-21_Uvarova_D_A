namespace Laba2
{
    partial class Form1
    {
        /// <summary> 
        /// Обязательная переменная конструктора. 
        /// </summary> 
        private System.ComponentModel.IContainer components = null;

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
            this.pictureBoxDraw = new System.Windows.Forms.PictureBox();
            this.buttonSelectColor = new System.Windows.Forms.Button();
            this.buttonSelectDopColor = new System.Windows.Forms.Button();
            this.textBoxMaxSpeed = new System.Windows.Forms.TextBox();
            this.textBoxMaxCountPassenget = new System.Windows.Forms.TextBox();
            this.textBoxWeight = new System.Windows.Forms.TextBox();
            this.checkBoxFrontSpoiler = new System.Windows.Forms.CheckBox();
            this.checkBoxBackSpoiler = new System.Windows.Forms.CheckBox();
            this.checkBoxSideSpoiler = new System.Windows.Forms.CheckBox();
            this.buttonSetAuto = new System.Windows.Forms.Button();
            this.buttonSetGruzovik = new System.Windows.Forms.Button();
            this.buttonMove = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxToplivo = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDraw)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxDraw
            // 
            this.pictureBoxDraw.InitialImage = null;
            this.pictureBoxDraw.Location = new System.Drawing.Point(59, 9);
            this.pictureBoxDraw.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxDraw.Name = "pictureBoxDraw";
            this.pictureBoxDraw.Size = new System.Drawing.Size(719, 370);
            this.pictureBoxDraw.TabIndex = 0;
            this.pictureBoxDraw.TabStop = false;
            // 
            // buttonSelectColor
            // 
            this.buttonSelectColor.Location = new System.Drawing.Point(1060, 42);
            this.buttonSelectColor.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSelectColor.Name = "buttonSelectColor";
            this.buttonSelectColor.Size = new System.Drawing.Size(100, 28);
            this.buttonSelectColor.TabIndex = 1;
            this.buttonSelectColor.Text = "Color";
            this.buttonSelectColor.UseVisualStyleBackColor = true;
            this.buttonSelectColor.Click += new System.EventHandler(this.buttonSelectColor_Click);
            // 
            // buttonSelectDopColor
            // 
            this.buttonSelectDopColor.Location = new System.Drawing.Point(163, 74);
            this.buttonSelectDopColor.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSelectDopColor.Name = "buttonSelectDopColor";
            this.buttonSelectDopColor.Size = new System.Drawing.Size(100, 28);
            this.buttonSelectDopColor.TabIndex = 2;
            this.buttonSelectDopColor.Text = "Color";
            this.buttonSelectDopColor.UseVisualStyleBackColor = true;
            this.buttonSelectDopColor.Click += new System.EventHandler(this.buttonSelectDopColor_Click);
            // 
            // textBoxMaxSpeed
            // 
            this.textBoxMaxSpeed.Location = new System.Drawing.Point(134, 438);
            this.textBoxMaxSpeed.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxMaxSpeed.Name = "textBoxMaxSpeed";
            this.textBoxMaxSpeed.Size = new System.Drawing.Size(84, 22);
            this.textBoxMaxSpeed.TabIndex = 3;
            // 
            // textBoxMaxCountPassenget
            // 
            this.textBoxMaxCountPassenget.Location = new System.Drawing.Point(204, 390);
            this.textBoxMaxCountPassenget.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxMaxCountPassenget.Name = "textBoxMaxCountPassenget";
            this.textBoxMaxCountPassenget.Size = new System.Drawing.Size(50, 22);
            this.textBoxMaxCountPassenget.TabIndex = 4;
            // 
            // textBoxWeight
            // 
            this.textBoxWeight.Location = new System.Drawing.Point(389, 393);
            this.textBoxWeight.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxWeight.Name = "textBoxWeight";
            this.textBoxWeight.Size = new System.Drawing.Size(85, 22);
            this.textBoxWeight.TabIndex = 5;
            // 
            // checkBoxFrontSpoiler
            // 
            this.checkBoxFrontSpoiler.AutoSize = true;
            this.checkBoxFrontSpoiler.Location = new System.Drawing.Point(39, 38);
            this.checkBoxFrontSpoiler.Margin = new System.Windows.Forms.Padding(4);
            this.checkBoxFrontSpoiler.Name = "checkBoxFrontSpoiler";
            this.checkBoxFrontSpoiler.Size = new System.Drawing.Size(88, 21);
            this.checkBoxFrontSpoiler.TabIndex = 6;
            this.checkBoxFrontSpoiler.Text = "Бампера";
            this.checkBoxFrontSpoiler.UseVisualStyleBackColor = true;
            // 
            // checkBoxBackSpoiler
            // 
            this.checkBoxBackSpoiler.AutoSize = true;
            this.checkBoxBackSpoiler.Location = new System.Drawing.Point(39, 79);
            this.checkBoxBackSpoiler.Margin = new System.Windows.Forms.Padding(4);
            this.checkBoxBackSpoiler.Name = "checkBoxBackSpoiler";
            this.checkBoxBackSpoiler.Size = new System.Drawing.Size(85, 21);
            this.checkBoxBackSpoiler.TabIndex = 7;
            this.checkBoxBackSpoiler.Text = "Запаска";
            this.checkBoxBackSpoiler.UseVisualStyleBackColor = true;
            // 
            // checkBoxSideSpoiler
            // 
            this.checkBoxSideSpoiler.AutoSize = true;
            this.checkBoxSideSpoiler.Location = new System.Drawing.Point(163, 38);
            this.checkBoxSideSpoiler.Margin = new System.Windows.Forms.Padding(4);
            this.checkBoxSideSpoiler.Name = "checkBoxSideSpoiler";
            this.checkBoxSideSpoiler.Size = new System.Drawing.Size(78, 21);
            this.checkBoxSideSpoiler.TabIndex = 8;
            this.checkBoxSideSpoiler.Text = "Колеса";
            this.checkBoxSideSpoiler.UseVisualStyleBackColor = true;
            // 
            // buttonSetAuto
            // 
            this.buttonSetAuto.Location = new System.Drawing.Point(795, 31);
            this.buttonSetAuto.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSetAuto.Name = "buttonSetAuto";
            this.buttonSetAuto.Size = new System.Drawing.Size(169, 50);
            this.buttonSetAuto.TabIndex = 9;
            this.buttonSetAuto.Text = "Задать авто";
            this.buttonSetAuto.UseVisualStyleBackColor = true;
            this.buttonSetAuto.Click += new System.EventHandler(this.buttonSetAuto_Click);
            // 
            // buttonSetGruzovik
            // 
            this.buttonSetGruzovik.Location = new System.Drawing.Point(795, 107);
            this.buttonSetGruzovik.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSetGruzovik.Name = "buttonSetGruzovik";
            this.buttonSetGruzovik.Size = new System.Drawing.Size(169, 47);
            this.buttonSetGruzovik.TabIndex = 11;
            this.buttonSetGruzovik.Text = "Задать Внедорожник";
            this.buttonSetGruzovik.UseVisualStyleBackColor = true;
            this.buttonSetGruzovik.Click += new System.EventHandler(this.buttonSetGruzovik_Click);
            // 
            // buttonMove
            // 
            this.buttonMove.Location = new System.Drawing.Point(795, 193);
            this.buttonMove.Margin = new System.Windows.Forms.Padding(4);
            this.buttonMove.Name = "buttonMove";
            this.buttonMove.Size = new System.Drawing.Size(169, 53);
            this.buttonMove.TabIndex = 12;
            this.buttonMove.Text = "Движение";
            this.buttonMove.UseVisualStyleBackColor = true;
            this.buttonMove.Click += new System.EventHandler(this.buttonMove_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 441);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = "Max скорость";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 390);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 17);
            this.label2.TabIndex = 14;
            this.label2.Text = "Max кол-во пассажиров";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(331, 393);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 17);
            this.label3.TabIndex = 15;
            this.label3.Text = "Вес";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(331, 443);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 17);
            this.label4.TabIndex = 16;
            this.label4.Text = "Расход топлива";
            // 
            // textBoxToplivo
            // 
            this.textBoxToplivo.Location = new System.Drawing.Point(451, 443);
            this.textBoxToplivo.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxToplivo.Name = "textBoxToplivo";
            this.textBoxToplivo.Size = new System.Drawing.Size(85, 22);
            this.textBoxToplivo.TabIndex = 17;
            this.textBoxToplivo.TextChanged += new System.EventHandler(this.textBoxСapacity_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonSelectDopColor);
            this.groupBox1.Controls.Add(this.checkBoxFrontSpoiler);
            this.groupBox1.Controls.Add(this.checkBoxBackSpoiler);
            this.groupBox1.Controls.Add(this.checkBoxSideSpoiler);
            this.groupBox1.Location = new System.Drawing.Point(795, 279);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(318, 169);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1279, 701);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBoxToplivo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonMove);
            this.Controls.Add(this.buttonSetGruzovik);
            this.Controls.Add(this.buttonSetAuto);
            this.Controls.Add(this.textBoxWeight);
            this.Controls.Add(this.textBoxMaxCountPassenget);
            this.Controls.Add(this.textBoxMaxSpeed);
            this.Controls.Add(this.buttonSelectColor);
            this.Controls.Add(this.pictureBoxDraw);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDraw)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxDraw;
        private System.Windows.Forms.Button buttonSelectColor;
        private System.Windows.Forms.Button buttonSelectDopColor;
        private System.Windows.Forms.TextBox textBoxMaxSpeed;
        private System.Windows.Forms.TextBox textBoxMaxCountPassenget;
        private System.Windows.Forms.TextBox textBoxWeight;
        private System.Windows.Forms.CheckBox checkBoxFrontSpoiler;
        private System.Windows.Forms.CheckBox checkBoxBackSpoiler;
        private System.Windows.Forms.CheckBox checkBoxSideSpoiler;
        private System.Windows.Forms.Button buttonSetAuto;
        private System.Windows.Forms.Button buttonSetGruzovik;
        private System.Windows.Forms.Button buttonMove;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxToplivo;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

