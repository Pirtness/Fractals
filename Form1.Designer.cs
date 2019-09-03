namespace Fractal
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
            this.start_Drawing = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.Kantor = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Levi = new System.Windows.Forms.RadioButton();
            this.Kvasi = new System.Windows.Forms.RadioButton();
            this.labelDepth = new System.Windows.Forms.Label();
            this.labelCol1 = new System.Windows.Forms.Label();
            this.labelCol2 = new System.Windows.Forms.Label();
            this.depth = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.startColor = new System.Windows.Forms.PictureBox();
            this.endColor = new System.Windows.Forms.PictureBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.zoomLabel = new System.Windows.Forms.Label();
            this.distanceKant = new System.Windows.Forms.NumericUpDown();
            this.labelPar = new System.Windows.Forms.Label();
            this.direction = new System.Windows.Forms.Panel();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton0 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.zoom2 = new System.Windows.Forms.Button();
            this.zoom3 = new System.Windows.Forms.Button();
            this.zoom5 = new System.Windows.Forms.Button();
            this.zoom1 = new System.Windows.Forms.Button();
            this.center = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.depth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.startColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.endColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.distanceKant)).BeginInit();
            this.direction.SuspendLayout();
            this.SuspendLayout();
            // 
            // start_Drawing
            // 
            this.start_Drawing.Location = new System.Drawing.Point(38, 266);
            this.start_Drawing.Name = "start_Drawing";
            this.start_Drawing.Size = new System.Drawing.Size(88, 23);
            this.start_Drawing.TabIndex = 0;
            this.start_Drawing.Text = "Рисовать";
            this.start_Drawing.UseVisualStyleBackColor = true;
            this.start_Drawing.Visible = false;
            this.start_Drawing.Click += new System.EventHandler(this.button1_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(27, 611);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(106, 23);
            this.saveButton.TabIndex = 1;
            this.saveButton.Text = "Сохранить";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Visible = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // Kantor
            // 
            this.Kantor.AutoSize = true;
            this.Kantor.Location = new System.Drawing.Point(20, 3);
            this.Kantor.Name = "Kantor";
            this.Kantor.Size = new System.Drawing.Size(162, 21);
            this.Kantor.TabIndex = 2;
            this.Kantor.Text = "Множество Кантора";
            this.Kantor.UseVisualStyleBackColor = true;
            this.Kantor.CheckedChanged += new System.EventHandler(this.Kantor_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Levi);
            this.panel1.Controls.Add(this.Kvasi);
            this.panel1.Controls.Add(this.Kantor);
            this.panel1.Location = new System.Drawing.Point(27, 37);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(193, 81);
            this.panel1.TabIndex = 3;
            // 
            // Levi
            // 
            this.Levi.AutoSize = true;
            this.Levi.Location = new System.Drawing.Point(20, 57);
            this.Levi.Name = "Levi";
            this.Levi.Size = new System.Drawing.Size(128, 21);
            this.Levi.TabIndex = 4;
            this.Levi.Text = "С-Кривая Леви";
            this.Levi.UseVisualStyleBackColor = true;
            this.Levi.CheckedChanged += new System.EventHandler(this.Levi_CheckedChanged);
            // 
            // Kvasi
            // 
            this.Kvasi.AutoSize = true;
            this.Kvasi.Location = new System.Drawing.Point(20, 30);
            this.Kvasi.Name = "Kvasi";
            this.Kvasi.Size = new System.Drawing.Size(114, 21);
            this.Kvasi.TabIndex = 3;
            this.Kvasi.Text = "Квазиклевер";
            this.Kvasi.UseVisualStyleBackColor = true;
            this.Kvasi.CheckedChanged += new System.EventHandler(this.Kvasi_CheckedChanged);
            // 
            // labelDepth
            // 
            this.labelDepth.AutoSize = true;
            this.labelDepth.Location = new System.Drawing.Point(35, 145);
            this.labelDepth.Name = "labelDepth";
            this.labelDepth.Size = new System.Drawing.Size(63, 17);
            this.labelDepth.TabIndex = 4;
            this.labelDepth.Text = "Глубина";
            this.labelDepth.Visible = false;
            // 
            // labelCol1
            // 
            this.labelCol1.AutoSize = true;
            this.labelCol1.Location = new System.Drawing.Point(35, 201);
            this.labelCol1.Name = "labelCol1";
            this.labelCol1.Size = new System.Drawing.Size(117, 17);
            this.labelCol1.TabIndex = 6;
            this.labelCol1.Text = "Начальный цвет";
            this.labelCol1.Visible = false;
            // 
            // labelCol2
            // 
            this.labelCol2.AutoSize = true;
            this.labelCol2.Location = new System.Drawing.Point(35, 236);
            this.labelCol2.Name = "labelCol2";
            this.labelCol2.Size = new System.Drawing.Size(109, 17);
            this.labelCol2.TabIndex = 7;
            this.labelCol2.Text = "Конечный цвет";
            this.labelCol2.Visible = false;
            // 
            // depth
            // 
            this.depth.Location = new System.Drawing.Point(38, 165);
            this.depth.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.depth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.depth.Name = "depth";
            this.depth.Size = new System.Drawing.Size(56, 22);
            this.depth.TabIndex = 8;
            this.depth.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.depth.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Выбор фрактала";
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox.Location = new System.Drawing.Point(340, 30);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(750, 600);
            this.pictureBox.TabIndex = 12;
            this.pictureBox.TabStop = false;
            this.pictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseDown);
            this.pictureBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseUp);
            // 
            // startColor
            // 
            this.startColor.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.startColor.Location = new System.Drawing.Point(179, 201);
            this.startColor.Name = "startColor";
            this.startColor.Size = new System.Drawing.Size(55, 17);
            this.startColor.TabIndex = 13;
            this.startColor.TabStop = false;
            this.startColor.Visible = false;
            this.startColor.Click += new System.EventHandler(this.startColor_Click);
            // 
            // endColor
            // 
            this.endColor.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.endColor.Location = new System.Drawing.Point(179, 236);
            this.endColor.Name = "endColor";
            this.endColor.Size = new System.Drawing.Size(55, 17);
            this.endColor.TabIndex = 14;
            this.endColor.TabStop = false;
            this.endColor.Visible = false;
            this.endColor.Click += new System.EventHandler(this.endColor_Click);
            // 
            // zoomLabel
            // 
            this.zoomLabel.AutoSize = true;
            this.zoomLabel.Location = new System.Drawing.Point(40, 486);
            this.zoomLabel.Name = "zoomLabel";
            this.zoomLabel.Size = new System.Drawing.Size(88, 17);
            this.zoomLabel.TabIndex = 16;
            this.zoomLabel.Text = "Увеличение";
            this.zoomLabel.Visible = false;
            // 
            // distanceKant
            // 
            this.distanceKant.Location = new System.Drawing.Point(38, 357);
            this.distanceKant.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.distanceKant.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.distanceKant.Name = "distanceKant";
            this.distanceKant.Size = new System.Drawing.Size(120, 22);
            this.distanceKant.TabIndex = 17;
            this.distanceKant.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.distanceKant.Visible = false;
            // 
            // labelPar
            // 
            this.labelPar.AutoSize = true;
            this.labelPar.Location = new System.Drawing.Point(35, 337);
            this.labelPar.Name = "labelPar";
            this.labelPar.Size = new System.Drawing.Size(205, 17);
            this.labelPar.TabIndex = 18;
            this.labelPar.Text = "Расстояние между отрезками";
            this.labelPar.Visible = false;
            // 
            // direction
            // 
            this.direction.Controls.Add(this.radioButton2);
            this.direction.Controls.Add(this.radioButton1);
            this.direction.Controls.Add(this.radioButton0);
            this.direction.Controls.Add(this.radioButton3);
            this.direction.Location = new System.Drawing.Point(38, 357);
            this.direction.Name = "direction";
            this.direction.Size = new System.Drawing.Size(90, 90);
            this.direction.TabIndex = 19;
            this.direction.Visible = false;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(37, 59);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(17, 16);
            this.radioButton2.TabIndex = 3;
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(58, 37);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(17, 16);
            this.radioButton1.TabIndex = 2;
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton0
            // 
            this.radioButton0.AutoSize = true;
            this.radioButton0.Checked = true;
            this.radioButton0.Location = new System.Drawing.Point(37, 15);
            this.radioButton0.Name = "radioButton0";
            this.radioButton0.Size = new System.Drawing.Size(17, 16);
            this.radioButton0.TabIndex = 1;
            this.radioButton0.TabStop = true;
            this.radioButton0.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(15, 37);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(17, 16);
            this.radioButton3.TabIndex = 0;
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // zoom2
            // 
            this.zoom2.Location = new System.Drawing.Point(88, 506);
            this.zoom2.Name = "zoom2";
            this.zoom2.Size = new System.Drawing.Size(40, 40);
            this.zoom2.TabIndex = 20;
            this.zoom2.Text = "x2";
            this.zoom2.UseVisualStyleBackColor = true;
            this.zoom2.Visible = false;
            this.zoom2.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // zoom3
            // 
            this.zoom3.Location = new System.Drawing.Point(38, 552);
            this.zoom3.Name = "zoom3";
            this.zoom3.Size = new System.Drawing.Size(40, 40);
            this.zoom3.TabIndex = 21;
            this.zoom3.Text = "x3";
            this.zoom3.UseVisualStyleBackColor = true;
            this.zoom3.Visible = false;
            this.zoom3.Click += new System.EventHandler(this.button2_Click);
            // 
            // zoom5
            // 
            this.zoom5.Location = new System.Drawing.Point(88, 552);
            this.zoom5.Name = "zoom5";
            this.zoom5.Size = new System.Drawing.Size(40, 40);
            this.zoom5.TabIndex = 22;
            this.zoom5.Text = "x5";
            this.zoom5.UseVisualStyleBackColor = true;
            this.zoom5.Visible = false;
            this.zoom5.Click += new System.EventHandler(this.button3_Click);
            // 
            // zoom1
            // 
            this.zoom1.Location = new System.Drawing.Point(38, 506);
            this.zoom1.Name = "zoom1";
            this.zoom1.Size = new System.Drawing.Size(40, 40);
            this.zoom1.TabIndex = 25;
            this.zoom1.Text = "x1";
            this.zoom1.UseVisualStyleBackColor = true;
            this.zoom1.Visible = false;
            this.zoom1.Click += new System.EventHandler(this.button6_Click);
            // 
            // center
            // 
            this.center.Location = new System.Drawing.Point(145, 611);
            this.center.Name = "center";
            this.center.Size = new System.Drawing.Size(116, 23);
            this.center.TabIndex = 26;
            this.center.Text = "Центрировать";
            this.center.UseVisualStyleBackColor = true;
            this.center.Visible = false;
            this.center.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1193, 653);
            this.Controls.Add(this.center);
            this.Controls.Add(this.labelDepth);
            this.Controls.Add(this.zoom1);
            this.Controls.Add(this.zoom5);
            this.Controls.Add(this.zoom3);
            this.Controls.Add(this.zoom2);
            this.Controls.Add(this.direction);
            this.Controls.Add(this.labelPar);
            this.Controls.Add(this.distanceKant);
            this.Controls.Add(this.zoomLabel);
            this.Controls.Add(this.endColor);
            this.Controls.Add(this.startColor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.depth);
            this.Controls.Add(this.labelCol2);
            this.Controls.Add(this.labelCol1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.start_Drawing);
            this.Controls.Add(this.pictureBox);
            this.MinimumSize = new System.Drawing.Size(1200, 700);
            this.Name = "Form1";
            this.Text = "Фрактал";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.depth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.startColor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.endColor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.distanceKant)).EndInit();
            this.direction.ResumeLayout(false);
            this.direction.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button start_Drawing;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.RadioButton Kantor;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton Levi;
        private System.Windows.Forms.RadioButton Kvasi;
        private System.Windows.Forms.Label labelDepth;
        private System.Windows.Forms.Label labelCol1;
        private System.Windows.Forms.Label labelCol2;
        private System.Windows.Forms.NumericUpDown depth;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.PictureBox startColor;
        private System.Windows.Forms.PictureBox endColor;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Label zoomLabel;
        private System.Windows.Forms.NumericUpDown distanceKant;
        private System.Windows.Forms.Label labelPar;
        private System.Windows.Forms.Panel direction;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton0;
        private System.Windows.Forms.Button zoom2;
        private System.Windows.Forms.Button zoom3;
        private System.Windows.Forms.Button zoom5;
        private System.Windows.Forms.Button zoom1;
        private System.Windows.Forms.Button center;
    }
}

