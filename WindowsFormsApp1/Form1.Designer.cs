namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.Num1 = new System.Windows.Forms.Button();
            this.Num2 = new System.Windows.Forms.Button();
            this.Num3 = new System.Windows.Forms.Button();
            this.Num4 = new System.Windows.Forms.Button();
            this.Num5 = new System.Windows.Forms.Button();
            this.Num6 = new System.Windows.Forms.Button();
            this.Num7 = new System.Windows.Forms.Button();
            this.Num8 = new System.Windows.Forms.Button();
            this.Num9 = new System.Windows.Forms.Button();
            this.Num0 = new System.Windows.Forms.Button();
            this.DotBtn = new System.Windows.Forms.Button();
            this.EqualBtn = new System.Windows.Forms.Button();
            this.PlusBtn = new System.Windows.Forms.Button();
            this.MinusBtn = new System.Windows.Forms.Button();
            this.MultiplyBtn = new System.Windows.Forms.Button();
            this.DivBtn = new System.Windows.Forms.Button();
            this.NumScreen = new System.Windows.Forms.Label();
            this.SwitchPM = new System.Windows.Forms.Button();
            this.OneOverXBtn = new System.Windows.Forms.Button();
            this.SqrBtn = new System.Windows.Forms.Button();
            this.RootBtn = new System.Windows.Forms.Button();
            this.PercentBtn = new System.Windows.Forms.Button();
            this.CEBtn = new System.Windows.Forms.Button();
            this.ClearBtn = new System.Windows.Forms.Button();
            this.BackBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Num1
            // 
            this.Num1.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Num1.Location = new System.Drawing.Point(12, 308);
            this.Num1.Name = "Num1";
            this.Num1.Size = new System.Drawing.Size(58, 51);
            this.Num1.TabIndex = 0;
            this.Num1.Text = "1";
            this.Num1.UseVisualStyleBackColor = false;
            this.Num1.Click += new System.EventHandler(this.Digit_Click);
            // 
            // Num2
            // 
            this.Num2.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Num2.Location = new System.Drawing.Point(85, 308);
            this.Num2.Name = "Num2";
            this.Num2.Size = new System.Drawing.Size(58, 51);
            this.Num2.TabIndex = 1;
            this.Num2.Text = "2";
            this.Num2.UseVisualStyleBackColor = false;
            this.Num2.Click += new System.EventHandler(this.Digit_Click);
            // 
            // Num3
            // 
            this.Num3.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Num3.Location = new System.Drawing.Point(159, 308);
            this.Num3.Name = "Num3";
            this.Num3.Size = new System.Drawing.Size(58, 51);
            this.Num3.TabIndex = 2;
            this.Num3.Text = "3";
            this.Num3.UseVisualStyleBackColor = false;
            this.Num3.Click += new System.EventHandler(this.Digit_Click);
            // 
            // Num4
            // 
            this.Num4.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Num4.Location = new System.Drawing.Point(12, 251);
            this.Num4.Name = "Num4";
            this.Num4.Size = new System.Drawing.Size(58, 51);
            this.Num4.TabIndex = 3;
            this.Num4.Text = "4";
            this.Num4.UseVisualStyleBackColor = false;
            this.Num4.Click += new System.EventHandler(this.Digit_Click);
            // 
            // Num5
            // 
            this.Num5.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Num5.Location = new System.Drawing.Point(85, 251);
            this.Num5.Name = "Num5";
            this.Num5.Size = new System.Drawing.Size(58, 51);
            this.Num5.TabIndex = 4;
            this.Num5.Text = "5";
            this.Num5.UseVisualStyleBackColor = false;
            this.Num5.Click += new System.EventHandler(this.Digit_Click);
            // 
            // Num6
            // 
            this.Num6.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Num6.Location = new System.Drawing.Point(159, 251);
            this.Num6.Name = "Num6";
            this.Num6.Size = new System.Drawing.Size(58, 51);
            this.Num6.TabIndex = 5;
            this.Num6.Text = "6";
            this.Num6.UseVisualStyleBackColor = false;
            this.Num6.Click += new System.EventHandler(this.Digit_Click);
            // 
            // Num7
            // 
            this.Num7.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Num7.Location = new System.Drawing.Point(12, 194);
            this.Num7.Name = "Num7";
            this.Num7.Size = new System.Drawing.Size(58, 51);
            this.Num7.TabIndex = 6;
            this.Num7.Text = "7";
            this.Num7.UseVisualStyleBackColor = false;
            this.Num7.Click += new System.EventHandler(this.Digit_Click);
            // 
            // Num8
            // 
            this.Num8.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Num8.Location = new System.Drawing.Point(85, 194);
            this.Num8.Name = "Num8";
            this.Num8.Size = new System.Drawing.Size(58, 51);
            this.Num8.TabIndex = 7;
            this.Num8.Text = "8";
            this.Num8.UseVisualStyleBackColor = false;
            this.Num8.Click += new System.EventHandler(this.Digit_Click);
            // 
            // Num9
            // 
            this.Num9.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Num9.Location = new System.Drawing.Point(159, 194);
            this.Num9.Name = "Num9";
            this.Num9.Size = new System.Drawing.Size(58, 51);
            this.Num9.TabIndex = 8;
            this.Num9.Text = "9";
            this.Num9.UseVisualStyleBackColor = false;
            this.Num9.Click += new System.EventHandler(this.Digit_Click);
            // 
            // Num0
            // 
            this.Num0.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Num0.Location = new System.Drawing.Point(85, 365);
            this.Num0.Name = "Num0";
            this.Num0.Size = new System.Drawing.Size(58, 51);
            this.Num0.TabIndex = 9;
            this.Num0.Text = "0";
            this.Num0.UseVisualStyleBackColor = false;
            this.Num0.Click += new System.EventHandler(this.Digit_Click);
            // 
            // DotBtn
            // 
            this.DotBtn.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.DotBtn.Location = new System.Drawing.Point(159, 365);
            this.DotBtn.Name = "DotBtn";
            this.DotBtn.Size = new System.Drawing.Size(58, 51);
            this.DotBtn.TabIndex = 10;
            this.DotBtn.Text = ".";
            this.DotBtn.UseVisualStyleBackColor = false;
            this.DotBtn.Click += new System.EventHandler(this.DotBtn_Click);
            // 
            // EqualBtn
            // 
            this.EqualBtn.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.EqualBtn.Location = new System.Drawing.Point(255, 365);
            this.EqualBtn.Name = "EqualBtn";
            this.EqualBtn.Size = new System.Drawing.Size(58, 51);
            this.EqualBtn.TabIndex = 11;
            this.EqualBtn.Text = "=";
            this.EqualBtn.UseVisualStyleBackColor = false;
            this.EqualBtn.Click += new System.EventHandler(this.EqualBtn_Click);
            // 
            // PlusBtn
            // 
            this.PlusBtn.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.PlusBtn.Location = new System.Drawing.Point(255, 308);
            this.PlusBtn.Name = "PlusBtn";
            this.PlusBtn.Size = new System.Drawing.Size(58, 51);
            this.PlusBtn.TabIndex = 12;
            this.PlusBtn.Text = "+";
            this.PlusBtn.UseVisualStyleBackColor = false;
            this.PlusBtn.Click += new System.EventHandler(this.Operator_Click);
            // 
            // MinusBtn
            // 
            this.MinusBtn.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.MinusBtn.Location = new System.Drawing.Point(255, 251);
            this.MinusBtn.Name = "MinusBtn";
            this.MinusBtn.Size = new System.Drawing.Size(58, 51);
            this.MinusBtn.TabIndex = 13;
            this.MinusBtn.Text = "-";
            this.MinusBtn.UseVisualStyleBackColor = false;
            this.MinusBtn.Click += new System.EventHandler(this.Operator_Click);
            // 
            // MultiplyBtn
            // 
            this.MultiplyBtn.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.MultiplyBtn.Location = new System.Drawing.Point(255, 194);
            this.MultiplyBtn.Name = "MultiplyBtn";
            this.MultiplyBtn.Size = new System.Drawing.Size(58, 51);
            this.MultiplyBtn.TabIndex = 14;
            this.MultiplyBtn.Text = "x";
            this.MultiplyBtn.UseVisualStyleBackColor = false;
            this.MultiplyBtn.Click += new System.EventHandler(this.Operator_Click);
            // 
            // DivBtn
            // 
            this.DivBtn.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.DivBtn.Location = new System.Drawing.Point(255, 137);
            this.DivBtn.Name = "DivBtn";
            this.DivBtn.Size = new System.Drawing.Size(58, 51);
            this.DivBtn.TabIndex = 15;
            this.DivBtn.Text = "÷";
            this.DivBtn.UseVisualStyleBackColor = false;
            this.DivBtn.Click += new System.EventHandler(this.Operator_Click);
            // 
            // NumScreen
            // 
            this.NumScreen.BackColor = System.Drawing.Color.White;
            this.NumScreen.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.NumScreen.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.NumScreen.Location = new System.Drawing.Point(12, 23);
            this.NumScreen.Name = "NumScreen";
            this.NumScreen.Size = new System.Drawing.Size(301, 56);
            this.NumScreen.TabIndex = 16;
            this.NumScreen.Text = "0";
            this.NumScreen.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // SwitchPM
            // 
            this.SwitchPM.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.SwitchPM.Location = new System.Drawing.Point(12, 365);
            this.SwitchPM.Name = "SwitchPM";
            this.SwitchPM.Size = new System.Drawing.Size(58, 51);
            this.SwitchPM.TabIndex = 17;
            this.SwitchPM.Text = "+/-";
            this.SwitchPM.UseVisualStyleBackColor = false;
            this.SwitchPM.Click += new System.EventHandler(this.SwitchPM_Click);
            // 
            // OneOverXBtn
            // 
            this.OneOverXBtn.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.OneOverXBtn.Location = new System.Drawing.Point(12, 137);
            this.OneOverXBtn.Name = "OneOverXBtn";
            this.OneOverXBtn.Size = new System.Drawing.Size(58, 51);
            this.OneOverXBtn.TabIndex = 18;
            this.OneOverXBtn.Text = "1/𝓍";
            this.OneOverXBtn.UseVisualStyleBackColor = false;
            this.OneOverXBtn.Click += new System.EventHandler(this.OneOverXBtn_Click);
            // 
            // SqrBtn
            // 
            this.SqrBtn.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.SqrBtn.Location = new System.Drawing.Point(85, 137);
            this.SqrBtn.Name = "SqrBtn";
            this.SqrBtn.Size = new System.Drawing.Size(58, 51);
            this.SqrBtn.TabIndex = 19;
            this.SqrBtn.Text = "𝓍²";
            this.SqrBtn.UseVisualStyleBackColor = false;
            this.SqrBtn.Click += new System.EventHandler(this.SqrBtn_Click);
            // 
            // RootBtn
            // 
            this.RootBtn.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.RootBtn.Location = new System.Drawing.Point(159, 137);
            this.RootBtn.Name = "RootBtn";
            this.RootBtn.Size = new System.Drawing.Size(58, 51);
            this.RootBtn.TabIndex = 20;
            this.RootBtn.Text = "²√𝓍";
            this.RootBtn.UseVisualStyleBackColor = false;
            this.RootBtn.Click += new System.EventHandler(this.RootBtn_Click);
            // 
            // PercentBtn
            // 
            this.PercentBtn.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.PercentBtn.Location = new System.Drawing.Point(12, 82);
            this.PercentBtn.Name = "PercentBtn";
            this.PercentBtn.Size = new System.Drawing.Size(58, 51);
            this.PercentBtn.TabIndex = 21;
            this.PercentBtn.Text = "%";
            this.PercentBtn.UseVisualStyleBackColor = false;
            this.PercentBtn.Click += new System.EventHandler(this.PercentBtn_Click);
            // 
            // CEBtn
            // 
            this.CEBtn.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.CEBtn.Location = new System.Drawing.Point(85, 82);
            this.CEBtn.Name = "CEBtn";
            this.CEBtn.Size = new System.Drawing.Size(58, 51);
            this.CEBtn.TabIndex = 22;
            this.CEBtn.Text = "CE";
            this.CEBtn.UseVisualStyleBackColor = false;
            this.CEBtn.Click += new System.EventHandler(this.CEBtn_Click);
            // 
            // ClearBtn
            // 
            this.ClearBtn.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ClearBtn.Location = new System.Drawing.Point(159, 82);
            this.ClearBtn.Name = "ClearBtn";
            this.ClearBtn.Size = new System.Drawing.Size(58, 51);
            this.ClearBtn.TabIndex = 23;
            this.ClearBtn.Text = "C";
            this.ClearBtn.UseVisualStyleBackColor = false;
            this.ClearBtn.Click += new System.EventHandler(this.ClearBtn_Click);
            // 
            // BackBtn
            // 
            this.BackBtn.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.BackBtn.Location = new System.Drawing.Point(255, 80);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(58, 51);
            this.BackBtn.TabIndex = 24;
            this.BackBtn.Text = "<-";
            this.BackBtn.UseVisualStyleBackColor = false;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 439);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.ClearBtn);
            this.Controls.Add(this.CEBtn);
            this.Controls.Add(this.PercentBtn);
            this.Controls.Add(this.RootBtn);
            this.Controls.Add(this.SqrBtn);
            this.Controls.Add(this.OneOverXBtn);
            this.Controls.Add(this.SwitchPM);
            this.Controls.Add(this.NumScreen);
            this.Controls.Add(this.DivBtn);
            this.Controls.Add(this.MultiplyBtn);
            this.Controls.Add(this.MinusBtn);
            this.Controls.Add(this.PlusBtn);
            this.Controls.Add(this.EqualBtn);
            this.Controls.Add(this.DotBtn);
            this.Controls.Add(this.Num0);
            this.Controls.Add(this.Num9);
            this.Controls.Add(this.Num8);
            this.Controls.Add(this.Num7);
            this.Controls.Add(this.Num6);
            this.Controls.Add(this.Num5);
            this.Controls.Add(this.Num4);
            this.Controls.Add(this.Num3);
            this.Controls.Add(this.Num2);
            this.Controls.Add(this.Num1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Num1;
        private System.Windows.Forms.Button Num2;
        private System.Windows.Forms.Button Num3;
        private System.Windows.Forms.Button Num4;
        private System.Windows.Forms.Button Num5;
        private System.Windows.Forms.Button Num6;
        private System.Windows.Forms.Button Num7;
        private System.Windows.Forms.Button Num8;
        private System.Windows.Forms.Button Num9;
        private System.Windows.Forms.Button Num0;
        private System.Windows.Forms.Button DotBtn;
        private System.Windows.Forms.Button EqualBtn;
        private System.Windows.Forms.Button PlusBtn;
        private System.Windows.Forms.Button MinusBtn;
        private System.Windows.Forms.Button MultiplyBtn;
        private System.Windows.Forms.Button DivBtn;
        private System.Windows.Forms.Label NumScreen;
        private System.Windows.Forms.Button SwitchPM;
        private System.Windows.Forms.Button OneOverXBtn;
        private System.Windows.Forms.Button SqrBtn;
        private System.Windows.Forms.Button RootBtn;
        private System.Windows.Forms.Button PercentBtn;
        private System.Windows.Forms.Button CEBtn;
        private System.Windows.Forms.Button ClearBtn;
        private System.Windows.Forms.Button BackBtn;
    }
}

