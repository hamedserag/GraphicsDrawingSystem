
namespace GFX_Package
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
            this.components = new System.ComponentModel.Container();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.uilog = new System.Windows.Forms.RichTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioRect = new System.Windows.Forms.RadioButton();
            this.radioSquare = new System.Windows.Forms.RadioButton();
            this.radioEllipse = new System.Windows.Forms.RadioButton();
            this.clrbtn = new System.Windows.Forms.Button();
            this.radioCircle = new System.Windows.Forms.RadioButton();
            this.drawBtn = new System.Windows.Forms.Button();
            this.radioBresh = new System.Windows.Forms.RadioButton();
            this.radioDDA = new System.Windows.Forms.RadioButton();
            this.startX = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label16 = new System.Windows.Forms.Label();
            this.widthTxt = new System.Windows.Forms.TextBox();
            this.lengthTxt = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.sideTxt = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.radiusY = new System.Windows.Forms.TextBox();
            this.radius = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.centerY = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.centerX = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.endY = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.endX = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.startY = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.reflectRB = new System.Windows.Forms.RadioButton();
            this.shearRB = new System.Windows.Forms.RadioButton();
            this.RotateRB = new System.Windows.Forms.RadioButton();
            this.transformBtn = new System.Windows.Forms.Button();
            this.ScaleRB = new System.Windows.Forms.RadioButton();
            this.TransRB = new System.Windows.Forms.RadioButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.VerticallCB = new System.Windows.Forms.CheckBox();
            this.HorizontalCB = new System.Windows.Forms.CheckBox();
            this.shearTxt = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.rotateTxt = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.scaleTxt = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tVectorYTxt = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tVectorXTxt = new System.Windows.Forms.TextBox();
            this.shapeIndexTxt = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.consoleError = new System.Windows.Forms.RichTextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // uilog
            // 
            this.uilog.Location = new System.Drawing.Point(276, 13);
            this.uilog.Name = "uilog";
            this.uilog.Size = new System.Drawing.Size(304, 137);
            this.uilog.TabIndex = 1;
            this.uilog.Text = "";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radioRect);
            this.panel1.Controls.Add(this.radioSquare);
            this.panel1.Controls.Add(this.radioEllipse);
            this.panel1.Controls.Add(this.clrbtn);
            this.panel1.Controls.Add(this.radioCircle);
            this.panel1.Controls.Add(this.drawBtn);
            this.panel1.Controls.Add(this.radioBresh);
            this.panel1.Controls.Add(this.radioDDA);
            this.panel1.Location = new System.Drawing.Point(13, 275);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(127, 234);
            this.panel1.TabIndex = 2;
            // 
            // radioRect
            // 
            this.radioRect.AutoSize = true;
            this.radioRect.Location = new System.Drawing.Point(4, 131);
            this.radioRect.Name = "radioRect";
            this.radioRect.Size = new System.Drawing.Size(77, 19);
            this.radioRect.TabIndex = 13;
            this.radioRect.Text = "Rectangle";
            this.radioRect.UseVisualStyleBackColor = true;
            // 
            // radioSquare
            // 
            this.radioSquare.AutoSize = true;
            this.radioSquare.Location = new System.Drawing.Point(4, 106);
            this.radioSquare.Name = "radioSquare";
            this.radioSquare.Size = new System.Drawing.Size(61, 19);
            this.radioSquare.TabIndex = 12;
            this.radioSquare.Text = "Square";
            this.radioSquare.UseVisualStyleBackColor = true;
            // 
            // radioEllipse
            // 
            this.radioEllipse.AutoSize = true;
            this.radioEllipse.Location = new System.Drawing.Point(4, 80);
            this.radioEllipse.Name = "radioEllipse";
            this.radioEllipse.Size = new System.Drawing.Size(58, 19);
            this.radioEllipse.TabIndex = 11;
            this.radioEllipse.Text = "Ellipse";
            this.radioEllipse.UseVisualStyleBackColor = true;
            // 
            // clrbtn
            // 
            this.clrbtn.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.clrbtn.Location = new System.Drawing.Point(4, 194);
            this.clrbtn.Name = "clrbtn";
            this.clrbtn.Size = new System.Drawing.Size(112, 32);
            this.clrbtn.TabIndex = 10;
            this.clrbtn.Text = "Clear";
            this.clrbtn.UseVisualStyleBackColor = true;
            this.clrbtn.Click += new System.EventHandler(this.clrbtn_Click);
            // 
            // radioCircle
            // 
            this.radioCircle.AutoSize = true;
            this.radioCircle.Location = new System.Drawing.Point(4, 54);
            this.radioCircle.Name = "radioCircle";
            this.radioCircle.Size = new System.Drawing.Size(55, 19);
            this.radioCircle.TabIndex = 2;
            this.radioCircle.Text = "Circle";
            this.radioCircle.UseVisualStyleBackColor = true;
            // 
            // drawBtn
            // 
            this.drawBtn.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.drawBtn.Location = new System.Drawing.Point(3, 156);
            this.drawBtn.Name = "drawBtn";
            this.drawBtn.Size = new System.Drawing.Size(112, 32);
            this.drawBtn.TabIndex = 9;
            this.drawBtn.Text = "Draw";
            this.drawBtn.UseVisualStyleBackColor = true;
            this.drawBtn.Click += new System.EventHandler(this.drawBtn_Click);
            // 
            // radioBresh
            // 
            this.radioBresh.AutoSize = true;
            this.radioBresh.Location = new System.Drawing.Point(4, 29);
            this.radioBresh.Name = "radioBresh";
            this.radioBresh.Size = new System.Drawing.Size(78, 19);
            this.radioBresh.TabIndex = 1;
            this.radioBresh.Text = "Breshnem";
            this.radioBresh.UseVisualStyleBackColor = true;
            // 
            // radioDDA
            // 
            this.radioDDA.AutoSize = true;
            this.radioDDA.Checked = true;
            this.radioDDA.Location = new System.Drawing.Point(4, 4);
            this.radioDDA.Name = "radioDDA";
            this.radioDDA.Size = new System.Drawing.Size(49, 19);
            this.radioDDA.TabIndex = 0;
            this.radioDDA.TabStop = true;
            this.radioDDA.Text = "DDA";
            this.radioDDA.UseVisualStyleBackColor = true;
            // 
            // startX
            // 
            this.startX.Location = new System.Drawing.Point(52, 6);
            this.startX.Name = "startX";
            this.startX.Size = new System.Drawing.Size(31, 23);
            this.startX.TabIndex = 3;
            this.startX.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Start";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label16);
            this.panel2.Controls.Add(this.widthTxt);
            this.panel2.Controls.Add(this.lengthTxt);
            this.panel2.Controls.Add(this.label17);
            this.panel2.Controls.Add(this.sideTxt);
            this.panel2.Controls.Add(this.label15);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.radiusY);
            this.panel2.Controls.Add(this.radius);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.centerY);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.centerX);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.endY);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.endX);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.startY);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.startX);
            this.panel2.Location = new System.Drawing.Point(146, 275);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(151, 234);
            this.panel2.TabIndex = 10;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(85, 161);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(18, 15);
            this.label16.TabIndex = 25;
            this.label16.Text = "W";
            // 
            // widthTxt
            // 
            this.widthTxt.Location = new System.Drawing.Point(105, 158);
            this.widthTxt.Name = "widthTxt";
            this.widthTxt.Size = new System.Drawing.Size(31, 23);
            this.widthTxt.TabIndex = 24;
            this.widthTxt.Text = "10";
            // 
            // lengthTxt
            // 
            this.lengthTxt.Location = new System.Drawing.Point(52, 158);
            this.lengthTxt.Name = "lengthTxt";
            this.lengthTxt.Size = new System.Drawing.Size(31, 23);
            this.lengthTxt.TabIndex = 22;
            this.lengthTxt.Text = "10";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(5, 161);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(44, 15);
            this.label17.TabIndex = 23;
            this.label17.Text = "Length";
            // 
            // sideTxt
            // 
            this.sideTxt.Location = new System.Drawing.Point(52, 130);
            this.sideTxt.Name = "sideTxt";
            this.sideTxt.Size = new System.Drawing.Size(31, 23);
            this.sideTxt.TabIndex = 18;
            this.sideTxt.Text = "10";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(5, 133);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(29, 15);
            this.label15.TabIndex = 19;
            this.label15.Text = "Side";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(89, 106);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(14, 15);
            this.label9.TabIndex = 17;
            this.label9.Text = "X";
            // 
            // radiusY
            // 
            this.radiusY.Location = new System.Drawing.Point(105, 102);
            this.radiusY.Name = "radiusY";
            this.radiusY.Size = new System.Drawing.Size(31, 23);
            this.radiusY.TabIndex = 16;
            this.radiusY.Text = "10";
            // 
            // radius
            // 
            this.radius.Location = new System.Drawing.Point(52, 102);
            this.radius.Name = "radius";
            this.radius.Size = new System.Drawing.Size(31, 23);
            this.radius.TabIndex = 15;
            this.radius.Text = "10";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(5, 105);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 15);
            this.label7.TabIndex = 15;
            this.label7.Text = "Radius";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(89, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(10, 15);
            this.label5.TabIndex = 14;
            this.label5.Text = ",";
            // 
            // centerY
            // 
            this.centerY.Location = new System.Drawing.Point(105, 72);
            this.centerY.Name = "centerY";
            this.centerY.Size = new System.Drawing.Size(31, 23);
            this.centerY.TabIndex = 13;
            this.centerY.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 75);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 15);
            this.label6.TabIndex = 12;
            this.label6.Text = "Center";
            // 
            // centerX
            // 
            this.centerX.Location = new System.Drawing.Point(52, 72);
            this.centerX.Name = "centerX";
            this.centerX.Size = new System.Drawing.Size(31, 23);
            this.centerX.TabIndex = 11;
            this.centerX.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(89, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(10, 15);
            this.label2.TabIndex = 10;
            this.label2.Text = ",";
            // 
            // endY
            // 
            this.endY.Location = new System.Drawing.Point(105, 40);
            this.endY.Name = "endY";
            this.endY.Size = new System.Drawing.Size(31, 23);
            this.endY.TabIndex = 9;
            this.endY.Text = "127";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "End";
            // 
            // endX
            // 
            this.endX.Location = new System.Drawing.Point(52, 40);
            this.endX.Name = "endX";
            this.endX.Size = new System.Drawing.Size(31, 23);
            this.endX.TabIndex = 7;
            this.endX.Text = "127";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(89, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(10, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = ",";
            // 
            // startY
            // 
            this.startY.Location = new System.Drawing.Point(105, 6);
            this.startY.Name = "startY";
            this.startY.Size = new System.Drawing.Size(31, 23);
            this.startY.TabIndex = 5;
            this.startY.Text = "0";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.reflectRB);
            this.panel3.Controls.Add(this.shearRB);
            this.panel3.Controls.Add(this.RotateRB);
            this.panel3.Controls.Add(this.transformBtn);
            this.panel3.Controls.Add(this.ScaleRB);
            this.panel3.Controls.Add(this.TransRB);
            this.panel3.Location = new System.Drawing.Point(306, 276);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(121, 233);
            this.panel3.TabIndex = 10;
            // 
            // reflectRB
            // 
            this.reflectRB.AutoSize = true;
            this.reflectRB.Location = new System.Drawing.Point(3, 105);
            this.reflectRB.Name = "reflectRB";
            this.reflectRB.Size = new System.Drawing.Size(61, 19);
            this.reflectRB.TabIndex = 11;
            this.reflectRB.Text = "Reflect";
            this.reflectRB.UseVisualStyleBackColor = true;
            // 
            // shearRB
            // 
            this.shearRB.AutoSize = true;
            this.shearRB.Location = new System.Drawing.Point(3, 79);
            this.shearRB.Name = "shearRB";
            this.shearRB.Size = new System.Drawing.Size(54, 19);
            this.shearRB.TabIndex = 10;
            this.shearRB.Text = "Shear";
            this.shearRB.UseVisualStyleBackColor = true;
            // 
            // RotateRB
            // 
            this.RotateRB.AutoSize = true;
            this.RotateRB.Location = new System.Drawing.Point(4, 54);
            this.RotateRB.Name = "RotateRB";
            this.RotateRB.Size = new System.Drawing.Size(59, 19);
            this.RotateRB.TabIndex = 2;
            this.RotateRB.Text = "Rotate";
            this.RotateRB.UseVisualStyleBackColor = true;
            // 
            // transformBtn
            // 
            this.transformBtn.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.transformBtn.Location = new System.Drawing.Point(3, 160);
            this.transformBtn.Name = "transformBtn";
            this.transformBtn.Size = new System.Drawing.Size(112, 65);
            this.transformBtn.TabIndex = 9;
            this.transformBtn.Text = "Transform";
            this.transformBtn.UseVisualStyleBackColor = true;
            this.transformBtn.Click += new System.EventHandler(this.transformBtn_Click);
            // 
            // ScaleRB
            // 
            this.ScaleRB.AutoSize = true;
            this.ScaleRB.Location = new System.Drawing.Point(4, 29);
            this.ScaleRB.Name = "ScaleRB";
            this.ScaleRB.Size = new System.Drawing.Size(52, 19);
            this.ScaleRB.TabIndex = 1;
            this.ScaleRB.Text = "Scale";
            this.ScaleRB.UseVisualStyleBackColor = true;
            // 
            // TransRB
            // 
            this.TransRB.AutoSize = true;
            this.TransRB.Checked = true;
            this.TransRB.Location = new System.Drawing.Point(4, 4);
            this.TransRB.Name = "TransRB";
            this.TransRB.Size = new System.Drawing.Size(71, 19);
            this.TransRB.TabIndex = 0;
            this.TransRB.TabStop = true;
            this.TransRB.Text = "Translate";
            this.TransRB.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.VerticallCB);
            this.panel4.Controls.Add(this.HorizontalCB);
            this.panel4.Controls.Add(this.shearTxt);
            this.panel4.Controls.Add(this.label13);
            this.panel4.Controls.Add(this.rotateTxt);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.scaleTxt);
            this.panel4.Controls.Add(this.label10);
            this.panel4.Controls.Add(this.label11);
            this.panel4.Controls.Add(this.tVectorYTxt);
            this.panel4.Controls.Add(this.label12);
            this.panel4.Controls.Add(this.tVectorXTxt);
            this.panel4.Controls.Add(this.shapeIndexTxt);
            this.panel4.Controls.Add(this.label14);
            this.panel4.Location = new System.Drawing.Point(433, 275);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(147, 234);
            this.panel4.TabIndex = 16;
            // 
            // VerticallCB
            // 
            this.VerticallCB.AutoSize = true;
            this.VerticallCB.Location = new System.Drawing.Point(6, 181);
            this.VerticallCB.Name = "VerticallCB";
            this.VerticallCB.Size = new System.Drawing.Size(64, 19);
            this.VerticallCB.TabIndex = 19;
            this.VerticallCB.Text = "Vertical";
            this.VerticallCB.UseVisualStyleBackColor = true;
            // 
            // HorizontalCB
            // 
            this.HorizontalCB.AutoSize = true;
            this.HorizontalCB.Location = new System.Drawing.Point(6, 156);
            this.HorizontalCB.Name = "HorizontalCB";
            this.HorizontalCB.Size = new System.Drawing.Size(81, 19);
            this.HorizontalCB.TabIndex = 18;
            this.HorizontalCB.Text = "Horizontal";
            this.HorizontalCB.UseVisualStyleBackColor = true;
            // 
            // shearTxt
            // 
            this.shearTxt.Location = new System.Drawing.Point(105, 126);
            this.shearTxt.Name = "shearTxt";
            this.shearTxt.Size = new System.Drawing.Size(31, 23);
            this.shearTxt.TabIndex = 16;
            this.shearTxt.Text = "10";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(5, 130);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(83, 15);
            this.label13.TabIndex = 17;
            this.label13.Text = "Shear Amount";
            // 
            // rotateTxt
            // 
            this.rotateTxt.Location = new System.Drawing.Point(105, 101);
            this.rotateTxt.Name = "rotateTxt";
            this.rotateTxt.Size = new System.Drawing.Size(31, 23);
            this.rotateTxt.TabIndex = 15;
            this.rotateTxt.Text = "10";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(5, 105);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 15);
            this.label8.TabIndex = 15;
            this.label8.Text = "Rotation angle";
            // 
            // scaleTxt
            // 
            this.scaleTxt.Location = new System.Drawing.Point(105, 72);
            this.scaleTxt.Name = "scaleTxt";
            this.scaleTxt.Size = new System.Drawing.Size(31, 23);
            this.scaleTxt.TabIndex = 13;
            this.scaleTxt.Text = "2";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(5, 75);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(88, 15);
            this.label10.TabIndex = 12;
            this.label10.Text = "Scale Multiplier";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(89, 43);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(10, 15);
            this.label11.TabIndex = 10;
            this.label11.Text = ",";
            // 
            // tVectorYTxt
            // 
            this.tVectorYTxt.Location = new System.Drawing.Point(105, 40);
            this.tVectorYTxt.Name = "tVectorYTxt";
            this.tVectorYTxt.Size = new System.Drawing.Size(31, 23);
            this.tVectorYTxt.TabIndex = 9;
            this.tVectorYTxt.Text = "10";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(5, 43);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(44, 15);
            this.label12.TabIndex = 8;
            this.label12.Text = "tVector";
            // 
            // tVectorXTxt
            // 
            this.tVectorXTxt.Location = new System.Drawing.Point(52, 40);
            this.tVectorXTxt.Name = "tVectorXTxt";
            this.tVectorXTxt.Size = new System.Drawing.Size(31, 23);
            this.tVectorXTxt.TabIndex = 7;
            this.tVectorXTxt.Text = "10";
            // 
            // shapeIndexTxt
            // 
            this.shapeIndexTxt.Location = new System.Drawing.Point(105, 6);
            this.shapeIndexTxt.Name = "shapeIndexTxt";
            this.shapeIndexTxt.Size = new System.Drawing.Size(31, 23);
            this.shapeIndexTxt.TabIndex = 5;
            this.shapeIndexTxt.Text = "0";
            this.shapeIndexTxt.TextChanged += new System.EventHandler(this.shapeIndexTxt_TextChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(5, 9);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(71, 15);
            this.label14.TabIndex = 4;
            this.label14.Text = "Shape Index";
            // 
            // consoleError
            // 
            this.consoleError.BackColor = System.Drawing.Color.Black;
            this.consoleError.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.consoleError.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.consoleError.Location = new System.Drawing.Point(276, 156);
            this.consoleError.Name = "consoleError";
            this.consoleError.Size = new System.Drawing.Size(304, 113);
            this.consoleError.TabIndex = 17;
            this.consoleError.Text = "";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(13, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(250, 250);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 517);
            this.Controls.Add(this.consoleError);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.uilog);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "GFX Package";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.RichTextBox uilog;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radioCircle;
        private System.Windows.Forms.RadioButton radioBresh;
        private System.Windows.Forms.RadioButton radioDDA;
        private System.Windows.Forms.TextBox startX;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button drawBtn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox centerY;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox centerX;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox endY;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox endX;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox startY;
        private System.Windows.Forms.TextBox radius;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RadioButton RotateRB;
        private System.Windows.Forms.Button transformBtn;
        private System.Windows.Forms.RadioButton ScaleRB;
        private System.Windows.Forms.RadioButton TransRB;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox rotateTxt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox scaleTxt;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tVectorYTxt;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tVectorXTxt;
        private System.Windows.Forms.TextBox shapeIndexTxt;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button clrbtn;
        private System.Windows.Forms.RichTextBox consoleError;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RadioButton radioRect;
        private System.Windows.Forms.RadioButton radioSquare;
        private System.Windows.Forms.RadioButton radioEllipse;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox widthTxt;
        private System.Windows.Forms.TextBox lengthTxt;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox sideTxt;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox radiusY;
        private System.Windows.Forms.RadioButton reflectRB;
        private System.Windows.Forms.RadioButton shearRB;
        private System.Windows.Forms.CheckBox VerticallCB;
        private System.Windows.Forms.CheckBox HorizontalCB;
        private System.Windows.Forms.TextBox shearTxt;
        private System.Windows.Forms.Label label13;
    }
}

