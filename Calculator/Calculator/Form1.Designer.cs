namespace Calculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            TxtBox = new TextBox();
            PlusBtn = new Button();
            MultiplyBtn = new Button();
            PercentBtn = new Button();
            ZeroBtn = new Button();
            OneBtn = new Button();
            FourBtn = new Button();
            SevenBtn = new Button();
            DotBtn = new Button();
            TwoBtn = new Button();
            FiveBtn = new Button();
            EightBtn = new Button();
            EqualBtn = new Button();
            ThreeBtn = new Button();
            SixBtn = new Button();
            NineBtn = new Button();
            MinusPlusBtn = new Button();
            DivideBtn = new Button();
            MinusBtn = new Button();
            MSaveBtn = new Button();
            MReadBtn = new Button();
            MClearBtn = new Button();
            MPlusBtn = new Button();
            MMinusBtn = new Button();
            ThemeBtn = new Button();
            ClearBtn = new Button();
            SuspendLayout();
            // 
            // TxtBox
            // 
            TxtBox.Font = new Font("Segoe UI", 20F);
            TxtBox.Location = new Point(13, 13);
            TxtBox.Name = "TxtBox";
            TxtBox.ReadOnly = true;
            TxtBox.Size = new Size(434, 47);
            TxtBox.TabIndex = 0;
            TxtBox.Text = "0";
            TxtBox.TextAlign = HorizontalAlignment.Right;
            TxtBox.TextChanged += TxtBox_TextChanged;
            // 
            // PlusBtn
            // 
            PlusBtn.Font = new Font("Segoe UI", 12F);
            PlusBtn.Location = new Point(376, 225);
            PlusBtn.Name = "PlusBtn";
            PlusBtn.Size = new Size(71, 75);
            PlusBtn.TabIndex = 1;
            PlusBtn.Text = "+";
            PlusBtn.UseVisualStyleBackColor = true;
            PlusBtn.Click += PlusBtn_Click;
            // 
            // MultiplyBtn
            // 
            MultiplyBtn.Font = new Font("Segoe UI", 12F);
            MultiplyBtn.Location = new Point(376, 306);
            MultiplyBtn.Name = "MultiplyBtn";
            MultiplyBtn.Size = new Size(71, 75);
            MultiplyBtn.TabIndex = 3;
            MultiplyBtn.Text = "x";
            MultiplyBtn.UseVisualStyleBackColor = true;
            MultiplyBtn.Click += MultiplyBtn_Click;
            // 
            // PercentBtn
            // 
            PercentBtn.Font = new Font("Segoe UI", 12F);
            PercentBtn.Location = new Point(376, 387);
            PercentBtn.Name = "PercentBtn";
            PercentBtn.Size = new Size(71, 75);
            PercentBtn.TabIndex = 4;
            PercentBtn.Text = "%";
            PercentBtn.UseVisualStyleBackColor = true;
            PercentBtn.Click += PercentBtn_Click;
            // 
            // ZeroBtn
            // 
            ZeroBtn.Font = new Font("Segoe UI", 12F);
            ZeroBtn.Location = new Point(13, 387);
            ZeroBtn.Name = "ZeroBtn";
            ZeroBtn.Size = new Size(71, 75);
            ZeroBtn.TabIndex = 8;
            ZeroBtn.Text = "0";
            ZeroBtn.UseVisualStyleBackColor = true;
            ZeroBtn.Click += ZeroBtn_Click;
            // 
            // OneBtn
            // 
            OneBtn.Font = new Font("Segoe UI", 12F);
            OneBtn.Location = new Point(13, 306);
            OneBtn.Name = "OneBtn";
            OneBtn.Size = new Size(71, 75);
            OneBtn.TabIndex = 7;
            OneBtn.Text = "1";
            OneBtn.UseVisualStyleBackColor = true;
            OneBtn.Click += OneBtn_Click;
            // 
            // FourBtn
            // 
            FourBtn.Font = new Font("Segoe UI", 12F);
            FourBtn.Location = new Point(13, 225);
            FourBtn.Name = "FourBtn";
            FourBtn.Size = new Size(71, 75);
            FourBtn.TabIndex = 5;
            FourBtn.Text = "4";
            FourBtn.UseVisualStyleBackColor = true;
            FourBtn.Click += FourBtn_Click;
            // 
            // SevenBtn
            // 
            SevenBtn.Font = new Font("Segoe UI", 12F);
            SevenBtn.Location = new Point(13, 144);
            SevenBtn.Name = "SevenBtn";
            SevenBtn.Size = new Size(71, 75);
            SevenBtn.TabIndex = 6;
            SevenBtn.Text = "7";
            SevenBtn.UseVisualStyleBackColor = true;
            SevenBtn.Click += SevenBtn_Click;
            // 
            // DotBtn
            // 
            DotBtn.Font = new Font("Segoe UI", 12F);
            DotBtn.Location = new Point(90, 387);
            DotBtn.Name = "DotBtn";
            DotBtn.Size = new Size(71, 75);
            DotBtn.TabIndex = 12;
            DotBtn.Text = ".";
            DotBtn.UseVisualStyleBackColor = true;
            DotBtn.Click += DotBtn_Click;
            // 
            // TwoBtn
            // 
            TwoBtn.Font = new Font("Segoe UI", 12F);
            TwoBtn.Location = new Point(90, 306);
            TwoBtn.Name = "TwoBtn";
            TwoBtn.Size = new Size(71, 75);
            TwoBtn.TabIndex = 11;
            TwoBtn.Text = "2";
            TwoBtn.UseVisualStyleBackColor = true;
            TwoBtn.Click += TwoBtn_Click;
            // 
            // FiveBtn
            // 
            FiveBtn.Font = new Font("Segoe UI", 12F);
            FiveBtn.Location = new Point(90, 225);
            FiveBtn.Name = "FiveBtn";
            FiveBtn.Size = new Size(71, 75);
            FiveBtn.TabIndex = 9;
            FiveBtn.Text = "5";
            FiveBtn.UseVisualStyleBackColor = true;
            FiveBtn.Click += FiveBtn_Click;
            // 
            // EightBtn
            // 
            EightBtn.Font = new Font("Segoe UI", 12F);
            EightBtn.Location = new Point(90, 144);
            EightBtn.Name = "EightBtn";
            EightBtn.Size = new Size(71, 75);
            EightBtn.TabIndex = 10;
            EightBtn.Text = "8";
            EightBtn.UseVisualStyleBackColor = true;
            EightBtn.Click += EightBtn_Click;
            // 
            // EqualBtn
            // 
            EqualBtn.Font = new Font("Segoe UI", 12F);
            EqualBtn.Location = new Point(167, 387);
            EqualBtn.Name = "EqualBtn";
            EqualBtn.Size = new Size(71, 75);
            EqualBtn.TabIndex = 16;
            EqualBtn.Text = "=";
            EqualBtn.UseVisualStyleBackColor = true;
            EqualBtn.Click += EqualBtn_Click;
            // 
            // ThreeBtn
            // 
            ThreeBtn.Font = new Font("Segoe UI", 12F);
            ThreeBtn.Location = new Point(167, 306);
            ThreeBtn.Name = "ThreeBtn";
            ThreeBtn.Size = new Size(71, 75);
            ThreeBtn.TabIndex = 15;
            ThreeBtn.Text = "3";
            ThreeBtn.UseVisualStyleBackColor = true;
            ThreeBtn.Click += ThreeBtn_Click;
            // 
            // SixBtn
            // 
            SixBtn.Font = new Font("Segoe UI", 12F);
            SixBtn.Location = new Point(167, 225);
            SixBtn.Name = "SixBtn";
            SixBtn.Size = new Size(71, 75);
            SixBtn.TabIndex = 13;
            SixBtn.Text = "6";
            SixBtn.UseVisualStyleBackColor = true;
            SixBtn.Click += SixBtn_Click;
            // 
            // NineBtn
            // 
            NineBtn.Font = new Font("Segoe UI", 12F);
            NineBtn.Location = new Point(167, 144);
            NineBtn.Name = "NineBtn";
            NineBtn.Size = new Size(71, 75);
            NineBtn.TabIndex = 14;
            NineBtn.Text = "9";
            NineBtn.UseVisualStyleBackColor = true;
            NineBtn.Click += NineBtn_Click;
            // 
            // MinusPlusBtn
            // 
            MinusPlusBtn.Font = new Font("Segoe UI", 12F);
            MinusPlusBtn.Location = new Point(299, 387);
            MinusPlusBtn.Name = "MinusPlusBtn";
            MinusPlusBtn.Size = new Size(71, 75);
            MinusPlusBtn.TabIndex = 20;
            MinusPlusBtn.Text = "-/+";
            MinusPlusBtn.UseVisualStyleBackColor = true;
            MinusPlusBtn.Click += MinusPlusBtn_Click;
            // 
            // DivideBtn
            // 
            DivideBtn.Font = new Font("Segoe UI", 12F);
            DivideBtn.Location = new Point(299, 306);
            DivideBtn.Name = "DivideBtn";
            DivideBtn.Size = new Size(71, 75);
            DivideBtn.TabIndex = 19;
            DivideBtn.Text = "/";
            DivideBtn.UseVisualStyleBackColor = true;
            DivideBtn.Click += DivideBtn_Click;
            // 
            // MinusBtn
            // 
            MinusBtn.Font = new Font("Segoe UI", 12F);
            MinusBtn.Location = new Point(299, 225);
            MinusBtn.Name = "MinusBtn";
            MinusBtn.Size = new Size(71, 75);
            MinusBtn.TabIndex = 17;
            MinusBtn.Text = "-";
            MinusBtn.UseVisualStyleBackColor = true;
            MinusBtn.Click += MinusBtn_Click;
            // 
            // MSaveBtn
            // 
            MSaveBtn.Font = new Font("Segoe UI", 12F);
            MSaveBtn.Location = new Point(13, 66);
            MSaveBtn.Name = "MSaveBtn";
            MSaveBtn.Size = new Size(71, 75);
            MSaveBtn.TabIndex = 21;
            MSaveBtn.Text = "MS";
            MSaveBtn.UseVisualStyleBackColor = true;
            MSaveBtn.Click += MSaveBtn_Click;
            // 
            // MReadBtn
            // 
            MReadBtn.Font = new Font("Segoe UI", 12F);
            MReadBtn.Location = new Point(90, 66);
            MReadBtn.Name = "MReadBtn";
            MReadBtn.Size = new Size(71, 75);
            MReadBtn.TabIndex = 22;
            MReadBtn.Text = "MR";
            MReadBtn.UseVisualStyleBackColor = true;
            MReadBtn.Click += MReadBtn_Click;
            // 
            // MClearBtn
            // 
            MClearBtn.Font = new Font("Segoe UI", 12F);
            MClearBtn.Location = new Point(167, 66);
            MClearBtn.Name = "MClearBtn";
            MClearBtn.Size = new Size(71, 75);
            MClearBtn.TabIndex = 23;
            MClearBtn.Text = "MC";
            MClearBtn.UseVisualStyleBackColor = true;
            MClearBtn.Click += MClearBtn_Click;
            // 
            // MPlusBtn
            // 
            MPlusBtn.Font = new Font("Segoe UI", 12F);
            MPlusBtn.Location = new Point(299, 66);
            MPlusBtn.Name = "MPlusBtn";
            MPlusBtn.Size = new Size(71, 75);
            MPlusBtn.TabIndex = 24;
            MPlusBtn.Text = "M+";
            MPlusBtn.UseVisualStyleBackColor = true;
            MPlusBtn.Click += MPlusBtn_Click;
            // 
            // MMinusBtn
            // 
            MMinusBtn.Font = new Font("Segoe UI", 12F);
            MMinusBtn.Location = new Point(376, 66);
            MMinusBtn.Name = "MMinusBtn";
            MMinusBtn.Size = new Size(71, 75);
            MMinusBtn.TabIndex = 25;
            MMinusBtn.Text = "M-";
            MMinusBtn.UseVisualStyleBackColor = true;
            MMinusBtn.Click += MMinusBtn_Click;
            // 
            // ThemeBtn
            // 
            ThemeBtn.Image = (Image)resources.GetObject("ThemeBtn.Image");
            ThemeBtn.Location = new Point(299, 144);
            ThemeBtn.Name = "ThemeBtn";
            ThemeBtn.Size = new Size(71, 75);
            ThemeBtn.TabIndex = 27;
            ThemeBtn.UseVisualStyleBackColor = true;
            ThemeBtn.Click += ThemeBtn_Click;
            // 
            // ClearBtn
            // 
            ClearBtn.Font = new Font("Segoe UI", 12F);
            ClearBtn.Location = new Point(376, 144);
            ClearBtn.Name = "ClearBtn";
            ClearBtn.Size = new Size(71, 75);
            ClearBtn.TabIndex = 28;
            ClearBtn.Text = "Clear";
            ClearBtn.UseVisualStyleBackColor = true;
            ClearBtn.Click += ClearBtn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(455, 474);
            Controls.Add(ClearBtn);
            Controls.Add(ThemeBtn);
            Controls.Add(MMinusBtn);
            Controls.Add(MPlusBtn);
            Controls.Add(MClearBtn);
            Controls.Add(MReadBtn);
            Controls.Add(MSaveBtn);
            Controls.Add(MinusPlusBtn);
            Controls.Add(DivideBtn);
            Controls.Add(MinusBtn);
            Controls.Add(EqualBtn);
            Controls.Add(ThreeBtn);
            Controls.Add(SixBtn);
            Controls.Add(NineBtn);
            Controls.Add(DotBtn);
            Controls.Add(TwoBtn);
            Controls.Add(FiveBtn);
            Controls.Add(EightBtn);
            Controls.Add(ZeroBtn);
            Controls.Add(OneBtn);
            Controls.Add(FourBtn);
            Controls.Add(SevenBtn);
            Controls.Add(PercentBtn);
            Controls.Add(MultiplyBtn);
            Controls.Add(PlusBtn);
            Controls.Add(TxtBox);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            Text = "Калькулятор";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TxtBox;
        private Button PlusBtn;
        private Button MultiplyBtn;
        private Button PercentBtn;
        private Button ZeroBtn;
        private Button OneBtn;
        private Button FourBtn;
        private Button SevenBtn;
        private Button DotBtn;
        private Button TwoBtn;
        private Button FiveBtn;
        private Button EightBtn;
        private Button EqualBtn;
        private Button ThreeBtn;
        private Button SixBtn;
        private Button NineBtn;
        private Button MinusPlusBtn;
        private Button DivideBtn;
        private Button MinusBtn;
        private Button MSaveBtn;
        private Button MReadBtn;
        private Button MClearBtn;
        private Button MPlusBtn;
        private Button MMinusBtn;
        private Button ThemeBtn;
        private Button ClearBtn;
    }
}
