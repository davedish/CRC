namespace CrcTester
{
    partial class CRCTester
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CRCTester));
            this.txtInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtHex = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBin = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtRemainder = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTransposed = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTransposedBinary = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtExponents = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCrc1 = new System.Windows.Forms.TextBox();
            this.txtLongDiv = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtDenominator = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtNumerator = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtTransposedCrc = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtHexCrc = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtMsgBackwards = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtFinalMsg = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtDenomBits = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtDenominatorExponents = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtClassTest = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtInput
            // 
            this.txtInput.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInput.Location = new System.Drawing.Point(74, 10);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(705, 23);
            this.txtInput.TabIndex = 0;
            this.txtInput.TextChanged += new System.EventHandler(this.txtInput_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Input Text";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Hex";
            // 
            // txtHex
            // 
            this.txtHex.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHex.Location = new System.Drawing.Point(74, 62);
            this.txtHex.Name = "txtHex";
            this.txtHex.Size = new System.Drawing.Size(705, 23);
            this.txtHex.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Binary";
            // 
            // txtBin
            // 
            this.txtBin.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBin.Location = new System.Drawing.Point(74, 88);
            this.txtBin.Name = "txtBin";
            this.txtBin.Size = new System.Drawing.Size(705, 23);
            this.txtBin.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 411);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Remainder";
            // 
            // txtRemainder
            // 
            this.txtRemainder.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRemainder.Location = new System.Drawing.Point(74, 408);
            this.txtRemainder.Name = "txtRemainder";
            this.txtRemainder.Size = new System.Drawing.Size(705, 23);
            this.txtRemainder.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Transposed";
            // 
            // txtTransposed
            // 
            this.txtTransposed.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTransposed.Location = new System.Drawing.Point(74, 36);
            this.txtTransposed.Name = "txtTransposed";
            this.txtTransposed.Size = new System.Drawing.Size(705, 23);
            this.txtTransposed.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 117);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Bin Txpsd";
            // 
            // txtTransposedBinary
            // 
            this.txtTransposedBinary.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTransposedBinary.Location = new System.Drawing.Point(74, 114);
            this.txtTransposedBinary.Name = "txtTransposedBinary";
            this.txtTransposedBinary.Size = new System.Drawing.Size(705, 23);
            this.txtTransposedBinary.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 143);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Exponents";
            // 
            // txtExponents
            // 
            this.txtExponents.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtExponents.Location = new System.Drawing.Point(74, 140);
            this.txtExponents.Name = "txtExponents";
            this.txtExponents.Size = new System.Drawing.Size(705, 23);
            this.txtExponents.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 437);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Crc (^1)";
            // 
            // txtCrc1
            // 
            this.txtCrc1.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCrc1.Location = new System.Drawing.Point(74, 434);
            this.txtCrc1.Name = "txtCrc1";
            this.txtCrc1.Size = new System.Drawing.Size(705, 23);
            this.txtCrc1.TabIndex = 12;
            // 
            // txtLongDiv
            // 
            this.txtLongDiv.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLongDiv.Location = new System.Drawing.Point(16, 218);
            this.txtLongDiv.Multiline = true;
            this.txtLongDiv.Name = "txtLongDiv";
            this.txtLongDiv.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtLongDiv.Size = new System.Drawing.Size(763, 184);
            this.txtLongDiv.TabIndex = 10;
            this.txtLongDiv.Text = resources.GetString("txtLongDiv.Text");
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 195);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Denominatr";
            // 
            // txtDenominator
            // 
            this.txtDenominator.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDenominator.Location = new System.Drawing.Point(74, 192);
            this.txtDenominator.Name = "txtDenominator";
            this.txtDenominator.Size = new System.Drawing.Size(228, 23);
            this.txtDenominator.TabIndex = 7;
            this.txtDenominator.TextChanged += new System.EventHandler(this.txtInput_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(13, 169);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "Numerator";
            // 
            // txtNumerator
            // 
            this.txtNumerator.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumerator.Location = new System.Drawing.Point(74, 166);
            this.txtNumerator.Name = "txtNumerator";
            this.txtNumerator.Size = new System.Drawing.Size(705, 23);
            this.txtNumerator.TabIndex = 6;
            this.txtNumerator.TextChanged += new System.EventHandler(this.txtInput_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(13, 463);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(63, 13);
            this.label11.TabIndex = 22;
            this.label11.Text = "Transposed";
            // 
            // txtTransposedCrc
            // 
            this.txtTransposedCrc.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTransposedCrc.Location = new System.Drawing.Point(74, 460);
            this.txtTransposedCrc.Name = "txtTransposedCrc";
            this.txtTransposedCrc.Size = new System.Drawing.Size(705, 23);
            this.txtTransposedCrc.TabIndex = 13;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(13, 489);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(26, 13);
            this.label12.TabIndex = 24;
            this.label12.Text = "Hex";
            // 
            // txtHexCrc
            // 
            this.txtHexCrc.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHexCrc.Location = new System.Drawing.Point(74, 486);
            this.txtHexCrc.Name = "txtHexCrc";
            this.txtHexCrc.Size = new System.Drawing.Size(705, 23);
            this.txtHexCrc.TabIndex = 14;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(13, 515);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(59, 13);
            this.label13.TabIndex = 26;
            this.label13.Text = "Msg Txpsd";
            // 
            // txtMsgBackwards
            // 
            this.txtMsgBackwards.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMsgBackwards.Location = new System.Drawing.Point(74, 512);
            this.txtMsgBackwards.Name = "txtMsgBackwards";
            this.txtMsgBackwards.Size = new System.Drawing.Size(705, 23);
            this.txtMsgBackwards.TabIndex = 15;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(13, 541);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(50, 13);
            this.label14.TabIndex = 28;
            this.label14.Text = "Message";
            // 
            // txtFinalMsg
            // 
            this.txtFinalMsg.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFinalMsg.Location = new System.Drawing.Point(74, 538);
            this.txtFinalMsg.Name = "txtFinalMsg";
            this.txtFinalMsg.Size = new System.Drawing.Size(705, 23);
            this.txtFinalMsg.TabIndex = 16;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(311, 195);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(24, 13);
            this.label15.TabIndex = 30;
            this.label15.Text = "Bits";
            // 
            // txtDenomBits
            // 
            this.txtDenomBits.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDenomBits.Location = new System.Drawing.Point(340, 192);
            this.txtDenomBits.Name = "txtDenomBits";
            this.txtDenomBits.Size = new System.Drawing.Size(86, 23);
            this.txtDenomBits.TabIndex = 8;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(432, 196);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(57, 13);
            this.label16.TabIndex = 32;
            this.label16.Text = "Exponents";
            // 
            // txtDenominatorExponents
            // 
            this.txtDenominatorExponents.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDenominatorExponents.Location = new System.Drawing.Point(494, 192);
            this.txtDenominatorExponents.Name = "txtDenominatorExponents";
            this.txtDenominatorExponents.Size = new System.Drawing.Size(285, 23);
            this.txtDenominatorExponents.TabIndex = 9;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(13, 570);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(52, 13);
            this.label17.TabIndex = 34;
            this.label17.Text = "Class test";
            // 
            // txtClassTest
            // 
            this.txtClassTest.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClassTest.Location = new System.Drawing.Point(74, 567);
            this.txtClassTest.Name = "txtClassTest";
            this.txtClassTest.Size = new System.Drawing.Size(705, 23);
            this.txtClassTest.TabIndex = 33;
            // 
            // CRCTester
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 637);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.txtClassTest);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.txtDenominatorExponents);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txtDenomBits);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtFinalMsg);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtMsgBackwards);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtHexCrc);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtTransposedCrc);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtNumerator);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtDenominator);
            this.Controls.Add(this.txtLongDiv);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtCrc1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtExponents);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtTransposedBinary);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtTransposed);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtRemainder);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtHex);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtInput);
            this.Name = "CRCTester";
            this.Text = "CRC Tester";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtHex;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBin;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtRemainder;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTransposed;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTransposedBinary;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtExponents;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtCrc1;
        private System.Windows.Forms.TextBox txtLongDiv;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtDenominator;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtNumerator;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtTransposedCrc;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtHexCrc;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtMsgBackwards;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtFinalMsg;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtDenomBits;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtDenominatorExponents;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtClassTest;
    }
}

