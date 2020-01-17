namespace Chapter5StringMethods
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.txtLength = new System.Windows.Forms.TextBox();
            this.txtToUpper = new System.Windows.Forms.TextBox();
            this.txtToLower = new System.Windows.Forms.TextBox();
            this.txtSearchChar = new System.Windows.Forms.TextBox();
            this.txtLastChar = new System.Windows.Forms.TextBox();
            this.txtStartIndex = new System.Windows.Forms.TextBox();
            this.txtRemove = new System.Windows.Forms.TextBox();
            this.txtReplaceChars = new System.Windows.Forms.TextBox();
            this.txtReplaceResult = new System.Windows.Forms.TextBox();
            this.lblIndexOf = new System.Windows.Forms.Label();
            this.lblLastIndexOf = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtEndIndex = new System.Windows.Forms.TextBox();
            this.lblSubstring = new System.Windows.Forms.Label();
            this.txtSubstringResult = new System.Windows.Forms.TextBox();
            this.txtRemoveResult = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtReplaceWith = new System.Windows.Forms.TextBox();
            this.txtSearchIndex = new System.Windows.Forms.TextBox();
            this.txtLastIndexOf = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(35, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "String To Text:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(35, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "String Length:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Location = new System.Drawing.Point(35, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "String.ToUpper():";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Location = new System.Drawing.Point(35, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "String.ToLower():";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Location = new System.Drawing.Point(35, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(150, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Search for Character:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Location = new System.Drawing.Point(35, 197);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(150, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Search for Last Character:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label7.Location = new System.Drawing.Point(35, 230);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(150, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "Extract Substring from Index:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label8.Location = new System.Drawing.Point(35, 264);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(150, 20);
            this.label8.TabIndex = 7;
            this.label8.Text = "txtInput.Remove()=:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label9.Location = new System.Drawing.Point(35, 299);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(150, 20);
            this.label9.TabIndex = 8;
            this.label9.Text = "Find:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label10
            // 
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label10.Location = new System.Drawing.Point(35, 333);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(150, 20);
            this.label10.TabIndex = 9;
            this.label10.Text = "txtInput.Replace()=:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(35, 384);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "&Test";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(681, 384);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "&Close";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(191, 12);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(565, 20);
            this.txtInput.TabIndex = 12;
            this.txtInput.Text = "This is a test of various METHODS.1234567890 and z";
            // 
            // txtLength
            // 
            this.txtLength.Location = new System.Drawing.Point(192, 52);
            this.txtLength.Name = "txtLength";
            this.txtLength.Size = new System.Drawing.Size(70, 20);
            this.txtLength.TabIndex = 13;
            this.txtLength.Text = "58";
            // 
            // txtToUpper
            // 
            this.txtToUpper.Location = new System.Drawing.Point(192, 88);
            this.txtToUpper.Name = "txtToUpper";
            this.txtToUpper.Size = new System.Drawing.Size(564, 20);
            this.txtToUpper.TabIndex = 14;
            this.txtToUpper.Text = "THIS IS A TEST OF VARIOUS STRING METHODS. 1234567890 AND Z";
            // 
            // txtToLower
            // 
            this.txtToLower.Location = new System.Drawing.Point(192, 124);
            this.txtToLower.Name = "txtToLower";
            this.txtToLower.Size = new System.Drawing.Size(564, 20);
            this.txtToLower.TabIndex = 15;
            this.txtToLower.Text = "this is a test of various string methods. 1234567890 and z";
            // 
            // txtSearchChar
            // 
            this.txtSearchChar.Location = new System.Drawing.Point(192, 160);
            this.txtSearchChar.Name = "txtSearchChar";
            this.txtSearchChar.Size = new System.Drawing.Size(33, 20);
            this.txtSearchChar.TabIndex = 16;
            this.txtSearchChar.Text = "v";
            // 
            // txtLastChar
            // 
            this.txtLastChar.Location = new System.Drawing.Point(192, 197);
            this.txtLastChar.Name = "txtLastChar";
            this.txtLastChar.Size = new System.Drawing.Size(33, 20);
            this.txtLastChar.TabIndex = 17;
            this.txtLastChar.Text = "s";
            // 
            // txtStartIndex
            // 
            this.txtStartIndex.Location = new System.Drawing.Point(192, 229);
            this.txtStartIndex.Name = "txtStartIndex";
            this.txtStartIndex.Size = new System.Drawing.Size(33, 20);
            this.txtStartIndex.TabIndex = 18;
            this.txtStartIndex.Text = "18";
            // 
            // txtRemove
            // 
            this.txtRemove.Location = new System.Drawing.Point(192, 264);
            this.txtRemove.Name = "txtRemove";
            this.txtRemove.Size = new System.Drawing.Size(70, 20);
            this.txtRemove.TabIndex = 19;
            this.txtRemove.Text = "string";
            // 
            // txtReplaceChars
            // 
            this.txtReplaceChars.Location = new System.Drawing.Point(192, 299);
            this.txtReplaceChars.Name = "txtReplaceChars";
            this.txtReplaceChars.Size = new System.Drawing.Size(70, 20);
            this.txtReplaceChars.TabIndex = 20;
            this.txtReplaceChars.Text = "1234567890";
            // 
            // txtReplaceResult
            // 
            this.txtReplaceResult.Location = new System.Drawing.Point(192, 333);
            this.txtReplaceResult.Name = "txtReplaceResult";
            this.txtReplaceResult.Size = new System.Drawing.Size(564, 20);
            this.txtReplaceResult.TabIndex = 21;
            this.txtReplaceResult.Text = " This is a test of various string METHODS.*** and z";
            // 
            // lblIndexOf
            // 
            this.lblIndexOf.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblIndexOf.Location = new System.Drawing.Point(252, 161);
            this.lblIndexOf.Name = "lblIndexOf";
            this.lblIndexOf.Size = new System.Drawing.Size(300, 20);
            this.lblIndexOf.TabIndex = 22;
            this.lblIndexOf.Text = "txtInput.Text.IndexOf(\"v\".0)=";
            this.lblIndexOf.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblLastIndexOf
            // 
            this.lblLastIndexOf.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblLastIndexOf.Location = new System.Drawing.Point(252, 197);
            this.lblLastIndexOf.Name = "lblLastIndexOf";
            this.lblLastIndexOf.Size = new System.Drawing.Size(300, 20);
            this.lblLastIndexOf.TabIndex = 23;
            this.lblLastIndexOf.Text = "txtInput.Text.LastIndexOf(\"s\")=";
            this.lblLastIndexOf.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label13
            // 
            this.label13.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label13.Location = new System.Drawing.Point(252, 229);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(150, 20);
            this.label13.TabIndex = 24;
            this.label13.Text = "for this many characters";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtEndIndex
            // 
            this.txtEndIndex.Location = new System.Drawing.Point(409, 229);
            this.txtEndIndex.Name = "txtEndIndex";
            this.txtEndIndex.Size = new System.Drawing.Size(32, 20);
            this.txtEndIndex.TabIndex = 25;
            this.txtEndIndex.Text = "7";
            // 
            // lblSubstring
            // 
            this.lblSubstring.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSubstring.Location = new System.Drawing.Point(447, 228);
            this.lblSubstring.Name = "lblSubstring";
            this.lblSubstring.Size = new System.Drawing.Size(150, 20);
            this.lblSubstring.TabIndex = 26;
            this.lblSubstring.Text = "txtInput.Text.Substring(18,7)=";
            this.lblSubstring.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtSubstringResult
            // 
            this.txtSubstringResult.Location = new System.Drawing.Point(604, 228);
            this.txtSubstringResult.Name = "txtSubstringResult";
            this.txtSubstringResult.Size = new System.Drawing.Size(152, 20);
            this.txtSubstringResult.TabIndex = 27;
            this.txtSubstringResult.Text = "various";
            // 
            // txtRemoveResult
            // 
            this.txtRemoveResult.Location = new System.Drawing.Point(269, 263);
            this.txtRemoveResult.Name = "txtRemoveResult";
            this.txtRemoveResult.Size = new System.Drawing.Size(487, 20);
            this.txtRemoveResult.TabIndex = 28;
            this.txtRemoveResult.Text = "This is a test of various METHODS. 1234567890 and z";
            // 
            // label15
            // 
            this.label15.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label15.Location = new System.Drawing.Point(269, 298);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(100, 20);
            this.label15.TabIndex = 29;
            this.label15.Text = "Replace with:";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtReplaceWith
            // 
            this.txtReplaceWith.Location = new System.Drawing.Point(376, 297);
            this.txtReplaceWith.Name = "txtReplaceWith";
            this.txtReplaceWith.Size = new System.Drawing.Size(100, 20);
            this.txtReplaceWith.TabIndex = 30;
            this.txtReplaceWith.Text = "***";
            // 
            // txtSearchIndex
            // 
            this.txtSearchIndex.Location = new System.Drawing.Point(559, 160);
            this.txtSearchIndex.Name = "txtSearchIndex";
            this.txtSearchIndex.Size = new System.Drawing.Size(197, 20);
            this.txtSearchIndex.TabIndex = 31;
            this.txtSearchIndex.Text = "18";
            // 
            // txtLastIndexOf
            // 
            this.txtLastIndexOf.Location = new System.Drawing.Point(559, 196);
            this.txtLastIndexOf.Name = "txtLastIndexOf";
            this.txtLastIndexOf.Size = new System.Drawing.Size(197, 20);
            this.txtLastIndexOf.TabIndex = 32;
            this.txtLastIndexOf.Text = "26";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtLastIndexOf);
            this.Controls.Add(this.txtSearchIndex);
            this.Controls.Add(this.txtReplaceWith);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txtRemoveResult);
            this.Controls.Add(this.txtSubstringResult);
            this.Controls.Add(this.lblSubstring);
            this.Controls.Add(this.txtEndIndex);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.lblLastIndexOf);
            this.Controls.Add(this.lblIndexOf);
            this.Controls.Add(this.txtReplaceResult);
            this.Controls.Add(this.txtReplaceChars);
            this.Controls.Add(this.txtRemove);
            this.Controls.Add(this.txtStartIndex);
            this.Controls.Add(this.txtLastChar);
            this.Controls.Add(this.txtSearchChar);
            this.Controls.Add(this.txtToLower);
            this.Controls.Add(this.txtToUpper);
            this.Controls.Add(this.txtLength);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "String Tester";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.TextBox txtLength;
        private System.Windows.Forms.TextBox txtToUpper;
        private System.Windows.Forms.TextBox txtToLower;
        private System.Windows.Forms.TextBox txtSearchChar;
        private System.Windows.Forms.TextBox txtLastChar;
        private System.Windows.Forms.TextBox txtStartIndex;
        private System.Windows.Forms.TextBox txtRemove;
        private System.Windows.Forms.TextBox txtReplaceChars;
        private System.Windows.Forms.TextBox txtReplaceResult;
        private System.Windows.Forms.Label lblIndexOf;
        private System.Windows.Forms.Label lblLastIndexOf;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtEndIndex;
        private System.Windows.Forms.Label lblSubstring;
        private System.Windows.Forms.TextBox txtSubstringResult;
        private System.Windows.Forms.TextBox txtRemoveResult;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtReplaceWith;
        private System.Windows.Forms.TextBox txtSearchIndex;
        private System.Windows.Forms.TextBox txtLastIndexOf;
    }
}

