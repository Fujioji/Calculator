namespace Calculator
{
    partial class CalculatorForm
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.NumberKeyZero = new System.Windows.Forms.Button();
            this.NumberKeyOne = new System.Windows.Forms.Button();
            this.NumberKeyTwo = new System.Windows.Forms.Button();
            this.NumberKeyThree = new System.Windows.Forms.Button();
            this.NumberKeyFour = new System.Windows.Forms.Button();
            this.NumberKeyFive = new System.Windows.Forms.Button();
            this.NumberKeySix = new System.Windows.Forms.Button();
            this.NumberKeySeven = new System.Windows.Forms.Button();
            this.NumberKeyEight = new System.Windows.Forms.Button();
            this.NumberKeyNine = new System.Windows.Forms.Button();
            this.NumberKeyPoint = new System.Windows.Forms.Button();
            this.NumberKeyPlusMinus = new System.Windows.Forms.Button();
            this.FunctionKeyEqual = new System.Windows.Forms.Button();
            this.OperatorKeyPlus = new System.Windows.Forms.Button();
            this.OperatorKeyMinus = new System.Windows.Forms.Button();
            this.OperatorKeyMultiple = new System.Windows.Forms.Button();
            this.OperatorKeyDivide = new System.Windows.Forms.Button();
            this.FunctionKeyBackSpace = new System.Windows.Forms.Button();
            this.FunctionKeyClear = new System.Windows.Forms.Button();
            this.FunctionKeyClearEntry = new System.Windows.Forms.Button();
            this.DisplayMain = new System.Windows.Forms.TextBox();
            this.DisplaySub = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // NumberKeyZero
            // 
            this.NumberKeyZero.Font = new System.Drawing.Font("MS UI Gothic", 18F);
            this.NumberKeyZero.Location = new System.Drawing.Point(93, 365);
            this.NumberKeyZero.Name = "NumberKeyZero";
            this.NumberKeyZero.Size = new System.Drawing.Size(75, 58);
            this.NumberKeyZero.TabIndex = 20;
            this.NumberKeyZero.Text = "0";
            this.NumberKeyZero.UseVisualStyleBackColor = true;
            this.NumberKeyZero.Click += new System.EventHandler(this.NumberKeyZero_Click);
            // 
            // NumberKeyOne
            // 
            this.NumberKeyOne.Font = new System.Drawing.Font("MS UI Gothic", 18F);
            this.NumberKeyOne.Location = new System.Drawing.Point(12, 301);
            this.NumberKeyOne.Name = "NumberKeyOne";
            this.NumberKeyOne.Size = new System.Drawing.Size(75, 58);
            this.NumberKeyOne.TabIndex = 15;
            this.NumberKeyOne.Text = "1";
            this.NumberKeyOne.UseVisualStyleBackColor = true;
            this.NumberKeyOne.Click += new System.EventHandler(this.NumberKeyOne_Click);
            // 
            // NumberKeyTwo
            // 
            this.NumberKeyTwo.Font = new System.Drawing.Font("MS UI Gothic", 18F);
            this.NumberKeyTwo.Location = new System.Drawing.Point(93, 301);
            this.NumberKeyTwo.Name = "NumberKeyTwo";
            this.NumberKeyTwo.Size = new System.Drawing.Size(75, 58);
            this.NumberKeyTwo.TabIndex = 16;
            this.NumberKeyTwo.Text = "2";
            this.NumberKeyTwo.UseVisualStyleBackColor = true;
            this.NumberKeyTwo.Click += new System.EventHandler(this.NumberKeyTwo_Click);
            // 
            // NumberKeyThree
            // 
            this.NumberKeyThree.Font = new System.Drawing.Font("MS UI Gothic", 18F);
            this.NumberKeyThree.Location = new System.Drawing.Point(174, 301);
            this.NumberKeyThree.Name = "NumberKeyThree";
            this.NumberKeyThree.Size = new System.Drawing.Size(75, 58);
            this.NumberKeyThree.TabIndex = 17;
            this.NumberKeyThree.Text = "3";
            this.NumberKeyThree.UseVisualStyleBackColor = true;
            this.NumberKeyThree.Click += new System.EventHandler(this.NumberKeyThree_Click);
            // 
            // NumberKeyFour
            // 
            this.NumberKeyFour.Font = new System.Drawing.Font("MS UI Gothic", 18F);
            this.NumberKeyFour.Location = new System.Drawing.Point(12, 237);
            this.NumberKeyFour.Name = "NumberKeyFour";
            this.NumberKeyFour.Size = new System.Drawing.Size(75, 58);
            this.NumberKeyFour.TabIndex = 11;
            this.NumberKeyFour.Text = "4";
            this.NumberKeyFour.UseVisualStyleBackColor = true;
            this.NumberKeyFour.Click += new System.EventHandler(this.NumberKeyFour_Click);
            // 
            // NumberKeyFive
            // 
            this.NumberKeyFive.Font = new System.Drawing.Font("MS UI Gothic", 18F);
            this.NumberKeyFive.Location = new System.Drawing.Point(93, 237);
            this.NumberKeyFive.Name = "NumberKeyFive";
            this.NumberKeyFive.Size = new System.Drawing.Size(75, 58);
            this.NumberKeyFive.TabIndex = 12;
            this.NumberKeyFive.Text = "5";
            this.NumberKeyFive.UseVisualStyleBackColor = true;
            this.NumberKeyFive.Click += new System.EventHandler(this.NumberKeyFive_Click);
            // 
            // NumberKeySix
            // 
            this.NumberKeySix.Font = new System.Drawing.Font("MS UI Gothic", 18F);
            this.NumberKeySix.Location = new System.Drawing.Point(174, 237);
            this.NumberKeySix.Name = "NumberKeySix";
            this.NumberKeySix.Size = new System.Drawing.Size(75, 58);
            this.NumberKeySix.TabIndex = 13;
            this.NumberKeySix.Text = "6";
            this.NumberKeySix.UseVisualStyleBackColor = true;
            this.NumberKeySix.Click += new System.EventHandler(this.NumberKeySix_Click);
            // 
            // NumberKeySeven
            // 
            this.NumberKeySeven.Font = new System.Drawing.Font("MS UI Gothic", 18F);
            this.NumberKeySeven.Location = new System.Drawing.Point(12, 173);
            this.NumberKeySeven.Name = "NumberKeySeven";
            this.NumberKeySeven.Size = new System.Drawing.Size(75, 58);
            this.NumberKeySeven.TabIndex = 7;
            this.NumberKeySeven.Text = "7";
            this.NumberKeySeven.UseVisualStyleBackColor = true;
            this.NumberKeySeven.Click += new System.EventHandler(this.NumberKeySeven_Click);
            // 
            // NumberKeyEight
            // 
            this.NumberKeyEight.Font = new System.Drawing.Font("MS UI Gothic", 18F);
            this.NumberKeyEight.Location = new System.Drawing.Point(93, 173);
            this.NumberKeyEight.Name = "NumberKeyEight";
            this.NumberKeyEight.Size = new System.Drawing.Size(75, 58);
            this.NumberKeyEight.TabIndex = 8;
            this.NumberKeyEight.Text = "8";
            this.NumberKeyEight.UseVisualStyleBackColor = true;
            this.NumberKeyEight.Click += new System.EventHandler(this.NumberKeyEight_Click);
            // 
            // NumberKeyNine
            // 
            this.NumberKeyNine.Font = new System.Drawing.Font("MS UI Gothic", 18F);
            this.NumberKeyNine.Location = new System.Drawing.Point(174, 173);
            this.NumberKeyNine.Name = "NumberKeyNine";
            this.NumberKeyNine.Size = new System.Drawing.Size(75, 58);
            this.NumberKeyNine.TabIndex = 9;
            this.NumberKeyNine.Text = "9";
            this.NumberKeyNine.UseVisualStyleBackColor = true;
            this.NumberKeyNine.Click += new System.EventHandler(this.NumberKeyNine_Click);
            // 
            // NumberKeyPoint
            // 
            this.NumberKeyPoint.Enabled = false;
            this.NumberKeyPoint.Font = new System.Drawing.Font("MS UI Gothic", 18F);
            this.NumberKeyPoint.Location = new System.Drawing.Point(174, 365);
            this.NumberKeyPoint.Name = "NumberKeyPoint";
            this.NumberKeyPoint.Size = new System.Drawing.Size(75, 58);
            this.NumberKeyPoint.TabIndex = 21;
            this.NumberKeyPoint.Text = ".";
            this.NumberKeyPoint.UseVisualStyleBackColor = true;
            this.NumberKeyPoint.Click += new System.EventHandler(this.NumberKeyPoint_Click);
            // 
            // NumberKeyPlusMinus
            // 
            this.NumberKeyPlusMinus.Enabled = false;
            this.NumberKeyPlusMinus.Font = new System.Drawing.Font("MS UI Gothic", 18F);
            this.NumberKeyPlusMinus.Location = new System.Drawing.Point(12, 365);
            this.NumberKeyPlusMinus.Name = "NumberKeyPlusMinus";
            this.NumberKeyPlusMinus.Size = new System.Drawing.Size(75, 58);
            this.NumberKeyPlusMinus.TabIndex = 19;
            this.NumberKeyPlusMinus.Text = "+/-";
            this.NumberKeyPlusMinus.UseVisualStyleBackColor = true;
            this.NumberKeyPlusMinus.Click += new System.EventHandler(this.NumberKeyPlusMinus_Click);
            // 
            // FunctionKeyEqual
            // 
            this.FunctionKeyEqual.Font = new System.Drawing.Font("MS UI Gothic", 18F);
            this.FunctionKeyEqual.Location = new System.Drawing.Point(255, 365);
            this.FunctionKeyEqual.Name = "FunctionKeyEqual";
            this.FunctionKeyEqual.Size = new System.Drawing.Size(75, 58);
            this.FunctionKeyEqual.TabIndex = 22;
            this.FunctionKeyEqual.Text = "＝";
            this.FunctionKeyEqual.UseVisualStyleBackColor = true;
            this.FunctionKeyEqual.Click += new System.EventHandler(this.FunctionKeyEqual_Click);
            // 
            // OperatorKeyPlus
            // 
            this.OperatorKeyPlus.Font = new System.Drawing.Font("MS UI Gothic", 18F);
            this.OperatorKeyPlus.Location = new System.Drawing.Point(253, 301);
            this.OperatorKeyPlus.Name = "OperatorKeyPlus";
            this.OperatorKeyPlus.Size = new System.Drawing.Size(75, 58);
            this.OperatorKeyPlus.TabIndex = 18;
            this.OperatorKeyPlus.Text = "＋";
            this.OperatorKeyPlus.UseVisualStyleBackColor = true;
            this.OperatorKeyPlus.Click += new System.EventHandler(this.OperatorKeyPlus_Click);
            // 
            // OperatorKeyMinus
            // 
            this.OperatorKeyMinus.Font = new System.Drawing.Font("MS UI Gothic", 18F);
            this.OperatorKeyMinus.Location = new System.Drawing.Point(253, 237);
            this.OperatorKeyMinus.Name = "OperatorKeyMinus";
            this.OperatorKeyMinus.Size = new System.Drawing.Size(75, 58);
            this.OperatorKeyMinus.TabIndex = 14;
            this.OperatorKeyMinus.Text = "－";
            this.OperatorKeyMinus.UseVisualStyleBackColor = true;
            this.OperatorKeyMinus.Click += new System.EventHandler(this.OperatorKeyMinus_Click);
            // 
            // OperatorKeyMultiple
            // 
            this.OperatorKeyMultiple.Font = new System.Drawing.Font("MS UI Gothic", 18F);
            this.OperatorKeyMultiple.Location = new System.Drawing.Point(253, 173);
            this.OperatorKeyMultiple.Name = "OperatorKeyMultiple";
            this.OperatorKeyMultiple.Size = new System.Drawing.Size(75, 58);
            this.OperatorKeyMultiple.TabIndex = 10;
            this.OperatorKeyMultiple.Text = "×";
            this.OperatorKeyMultiple.UseVisualStyleBackColor = true;
            this.OperatorKeyMultiple.Click += new System.EventHandler(this.OperatorKeyMultiple_Click);
            // 
            // OperatorKeyDivide
            // 
            this.OperatorKeyDivide.Font = new System.Drawing.Font("MS UI Gothic", 18F);
            this.OperatorKeyDivide.Location = new System.Drawing.Point(253, 109);
            this.OperatorKeyDivide.Name = "OperatorKeyDivide";
            this.OperatorKeyDivide.Size = new System.Drawing.Size(75, 58);
            this.OperatorKeyDivide.TabIndex = 6;
            this.OperatorKeyDivide.Text = "÷";
            this.OperatorKeyDivide.UseVisualStyleBackColor = true;
            this.OperatorKeyDivide.Click += new System.EventHandler(this.OperatorKeyDivide_Click);
            // 
            // FunctionKeyBackSpace
            // 
            this.FunctionKeyBackSpace.Enabled = false;
            this.FunctionKeyBackSpace.Font = new System.Drawing.Font("MS UI Gothic", 18F);
            this.FunctionKeyBackSpace.Location = new System.Drawing.Point(174, 109);
            this.FunctionKeyBackSpace.Name = "FunctionKeyBackSpace";
            this.FunctionKeyBackSpace.Size = new System.Drawing.Size(75, 58);
            this.FunctionKeyBackSpace.TabIndex = 5;
            this.FunctionKeyBackSpace.Text = "☒";
            this.FunctionKeyBackSpace.UseVisualStyleBackColor = true;
            this.FunctionKeyBackSpace.Click += new System.EventHandler(this.FunctionKeyBackSpace_Click);
            // 
            // FunctionKeyClear
            // 
            this.FunctionKeyClear.Enabled = false;
            this.FunctionKeyClear.Font = new System.Drawing.Font("MS UI Gothic", 18F);
            this.FunctionKeyClear.Location = new System.Drawing.Point(93, 109);
            this.FunctionKeyClear.Name = "FunctionKeyClear";
            this.FunctionKeyClear.Size = new System.Drawing.Size(75, 58);
            this.FunctionKeyClear.TabIndex = 4;
            this.FunctionKeyClear.Text = "C";
            this.FunctionKeyClear.UseVisualStyleBackColor = true;
            this.FunctionKeyClear.Click += new System.EventHandler(this.FunctionKeyClear_Click);
            // 
            // FunctionKeyClearEntry
            // 
            this.FunctionKeyClearEntry.Enabled = false;
            this.FunctionKeyClearEntry.Font = new System.Drawing.Font("MS UI Gothic", 18F);
            this.FunctionKeyClearEntry.Location = new System.Drawing.Point(12, 109);
            this.FunctionKeyClearEntry.Name = "FunctionKeyClearEntry";
            this.FunctionKeyClearEntry.Size = new System.Drawing.Size(75, 58);
            this.FunctionKeyClearEntry.TabIndex = 3;
            this.FunctionKeyClearEntry.Text = "CE";
            this.FunctionKeyClearEntry.UseVisualStyleBackColor = true;
            this.FunctionKeyClearEntry.Click += new System.EventHandler(this.FunctionKeyClearEntry_Click);
            // 
            // DisplayMain
            // 
            this.DisplayMain.Font = new System.Drawing.Font("MS UI Gothic", 30F);
            this.DisplayMain.Location = new System.Drawing.Point(13, 45);
            this.DisplayMain.Name = "DisplayMain";
            this.DisplayMain.ReadOnly = true;
            this.DisplayMain.Size = new System.Drawing.Size(315, 47);
            this.DisplayMain.TabIndex = 2;
            this.DisplayMain.Text = "0";
            this.DisplayMain.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // DisplaySub
            // 
            this.DisplaySub.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.DisplaySub.Location = new System.Drawing.Point(12, 12);
            this.DisplaySub.Name = "DisplaySub";
            this.DisplaySub.ReadOnly = true;
            this.DisplaySub.Size = new System.Drawing.Size(315, 27);
            this.DisplaySub.TabIndex = 1;
            this.DisplaySub.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // CalculatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 437);
            this.Controls.Add(this.DisplaySub);
            this.Controls.Add(this.DisplayMain);
            this.Controls.Add(this.FunctionKeyClearEntry);
            this.Controls.Add(this.FunctionKeyClear);
            this.Controls.Add(this.FunctionKeyBackSpace);
            this.Controls.Add(this.OperatorKeyDivide);
            this.Controls.Add(this.OperatorKeyMultiple);
            this.Controls.Add(this.OperatorKeyMinus);
            this.Controls.Add(this.OperatorKeyPlus);
            this.Controls.Add(this.FunctionKeyEqual);
            this.Controls.Add(this.NumberKeyPlusMinus);
            this.Controls.Add(this.NumberKeyPoint);
            this.Controls.Add(this.NumberKeyNine);
            this.Controls.Add(this.NumberKeyEight);
            this.Controls.Add(this.NumberKeySeven);
            this.Controls.Add(this.NumberKeySix);
            this.Controls.Add(this.NumberKeyFive);
            this.Controls.Add(this.NumberKeyFour);
            this.Controls.Add(this.NumberKeyThree);
            this.Controls.Add(this.NumberKeyTwo);
            this.Controls.Add(this.NumberKeyOne);
            this.Controls.Add(this.NumberKeyZero);
            this.Name = "CalculatorForm";
            this.Text = "電卓";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button NumberKeyZero;
        private System.Windows.Forms.Button NumberKeyOne;
        private System.Windows.Forms.Button NumberKeyTwo;
        private System.Windows.Forms.Button NumberKeyThree;
        private System.Windows.Forms.Button NumberKeyFour;
        private System.Windows.Forms.Button NumberKeyFive;
        private System.Windows.Forms.Button NumberKeySix;
        private System.Windows.Forms.Button NumberKeySeven;
        private System.Windows.Forms.Button NumberKeyEight;
        private System.Windows.Forms.Button NumberKeyNine;
        private System.Windows.Forms.Button NumberKeyPoint;
        private System.Windows.Forms.Button NumberKeyPlusMinus;
        private System.Windows.Forms.Button FunctionKeyEqual;
        private System.Windows.Forms.Button OperatorKeyPlus;
        private System.Windows.Forms.Button OperatorKeyMinus;
        private System.Windows.Forms.Button OperatorKeyMultiple;
        private System.Windows.Forms.Button OperatorKeyDivide;
        private System.Windows.Forms.Button FunctionKeyBackSpace;
        private System.Windows.Forms.Button FunctionKeyClear;
        private System.Windows.Forms.Button FunctionKeyClearEntry;
        private System.Windows.Forms.TextBox DisplayMain;
        private System.Windows.Forms.TextBox DisplaySub;
    }
}

