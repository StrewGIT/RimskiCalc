namespace RimskiCalcStefanAndrejevic
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
            this.TxtCalc = new System.Windows.Forms.TextBox();
            this.BtnM = new System.Windows.Forms.Button();
            this.BtnTimes = new System.Windows.Forms.Button();
            this.BtnMinus = new System.Windows.Forms.Button();
            this.BtnPlus = new System.Windows.Forms.Button();
            this.BtnEqual = new System.Windows.Forms.Button();
            this.BtnClear = new System.Windows.Forms.Button();
            this.BtnDivision = new System.Windows.Forms.Button();
            this.BtnBackspace = new System.Windows.Forms.Button();
            this.BtnL = new System.Windows.Forms.Button();
            this.BtnC = new System.Windows.Forms.Button();
            this.BtnV = new System.Windows.Forms.Button();
            this.BtnX = new System.Windows.Forms.Button();
            this.BtnD = new System.Windows.Forms.Button();
            this.BtnI = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TxtCalc
            // 
            this.TxtCalc.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCalc.Location = new System.Drawing.Point(17, 45);
            this.TxtCalc.Name = "TxtCalc";
            this.TxtCalc.Size = new System.Drawing.Size(300, 53);
            this.TxtCalc.TabIndex = 0;
            // 
            // BtnM
            // 
            this.BtnM.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnM.Location = new System.Drawing.Point(17, 232);
            this.BtnM.Name = "BtnM";
            this.BtnM.Size = new System.Drawing.Size(65, 65);
            this.BtnM.TabIndex = 1;
            this.BtnM.Text = "M";
            this.BtnM.UseVisualStyleBackColor = true;
            // 
            // BtnTimes
            // 
            this.BtnTimes.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnTimes.Location = new System.Drawing.Point(251, 232);
            this.BtnTimes.Name = "BtnTimes";
            this.BtnTimes.Size = new System.Drawing.Size(65, 65);
            this.BtnTimes.TabIndex = 1;
            this.BtnTimes.Text = "x";
            this.BtnTimes.UseVisualStyleBackColor = true;
            // 
            // BtnMinus
            // 
            this.BtnMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMinus.Location = new System.Drawing.Point(251, 303);
            this.BtnMinus.Name = "BtnMinus";
            this.BtnMinus.Size = new System.Drawing.Size(65, 65);
            this.BtnMinus.TabIndex = 1;
            this.BtnMinus.Text = "-";
            this.BtnMinus.UseVisualStyleBackColor = true;
            // 
            // BtnPlus
            // 
            this.BtnPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPlus.Location = new System.Drawing.Point(251, 374);
            this.BtnPlus.Name = "BtnPlus";
            this.BtnPlus.Size = new System.Drawing.Size(65, 65);
            this.BtnPlus.TabIndex = 1;
            this.BtnPlus.Text = "+";
            this.BtnPlus.UseVisualStyleBackColor = true;
            // 
            // BtnEqual
            // 
            this.BtnEqual.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.BtnEqual.Location = new System.Drawing.Point(95, 374);
            this.BtnEqual.Name = "BtnEqual";
            this.BtnEqual.Size = new System.Drawing.Size(143, 65);
            this.BtnEqual.TabIndex = 1;
            this.BtnEqual.Text = "=";
            this.BtnEqual.UseVisualStyleBackColor = true;
            // 
            // BtnClear
            // 
            this.BtnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.BtnClear.Location = new System.Drawing.Point(17, 161);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(143, 65);
            this.BtnClear.TabIndex = 1;
            this.BtnClear.Text = "Ce";
            this.BtnClear.UseVisualStyleBackColor = true;
            this.BtnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // BtnDivision
            // 
            this.BtnDivision.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.BtnDivision.Location = new System.Drawing.Point(251, 161);
            this.BtnDivision.Name = "BtnDivision";
            this.BtnDivision.Size = new System.Drawing.Size(65, 65);
            this.BtnDivision.TabIndex = 1;
            this.BtnDivision.Text = "/";
            this.BtnDivision.UseVisualStyleBackColor = true;
            this.BtnDivision.Click += new System.EventHandler(this.BtnDivision_Click);
            // 
            // BtnBackspace
            // 
            this.BtnBackspace.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBackspace.Location = new System.Drawing.Point(173, 161);
            this.BtnBackspace.Name = "BtnBackspace";
            this.BtnBackspace.Size = new System.Drawing.Size(65, 65);
            this.BtnBackspace.TabIndex = 1;
            this.BtnBackspace.Text = "<-";
            this.BtnBackspace.UseVisualStyleBackColor = true;
            this.BtnBackspace.Click += new System.EventHandler(this.BtnBackspace_Click);
            // 
            // BtnL
            // 
            this.BtnL.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnL.Location = new System.Drawing.Point(95, 232);
            this.BtnL.Name = "BtnL";
            this.BtnL.Size = new System.Drawing.Size(65, 65);
            this.BtnL.TabIndex = 1;
            this.BtnL.Text = "L";
            this.BtnL.UseVisualStyleBackColor = true;
            // 
            // BtnC
            // 
            this.BtnC.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnC.Location = new System.Drawing.Point(173, 232);
            this.BtnC.Name = "BtnC";
            this.BtnC.Size = new System.Drawing.Size(65, 65);
            this.BtnC.TabIndex = 1;
            this.BtnC.Text = "C";
            this.BtnC.UseVisualStyleBackColor = true;
            // 
            // BtnV
            // 
            this.BtnV.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnV.Location = new System.Drawing.Point(173, 303);
            this.BtnV.Name = "BtnV";
            this.BtnV.Size = new System.Drawing.Size(65, 65);
            this.BtnV.TabIndex = 1;
            this.BtnV.Text = "V";
            this.BtnV.UseVisualStyleBackColor = true;
            // 
            // BtnX
            // 
            this.BtnX.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnX.Location = new System.Drawing.Point(95, 303);
            this.BtnX.Name = "BtnX";
            this.BtnX.Size = new System.Drawing.Size(65, 65);
            this.BtnX.TabIndex = 1;
            this.BtnX.Text = "X";
            this.BtnX.UseVisualStyleBackColor = true;
            // 
            // BtnD
            // 
            this.BtnD.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnD.Location = new System.Drawing.Point(17, 303);
            this.BtnD.Name = "BtnD";
            this.BtnD.Size = new System.Drawing.Size(65, 65);
            this.BtnD.TabIndex = 1;
            this.BtnD.Text = "D";
            this.BtnD.UseVisualStyleBackColor = true;
            // 
            // BtnI
            // 
            this.BtnI.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnI.Location = new System.Drawing.Point(17, 374);
            this.BtnI.Name = "BtnI";
            this.BtnI.Size = new System.Drawing.Size(65, 65);
            this.BtnI.TabIndex = 1;
            this.BtnI.Text = "I";
            this.BtnI.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 461);
            this.Controls.Add(this.BtnEqual);
            this.Controls.Add(this.BtnPlus);
            this.Controls.Add(this.BtnMinus);
            this.Controls.Add(this.BtnBackspace);
            this.Controls.Add(this.BtnDivision);
            this.Controls.Add(this.BtnTimes);
            this.Controls.Add(this.BtnClear);
            this.Controls.Add(this.BtnI);
            this.Controls.Add(this.BtnD);
            this.Controls.Add(this.BtnX);
            this.Controls.Add(this.BtnV);
            this.Controls.Add(this.BtnC);
            this.Controls.Add(this.BtnL);
            this.Controls.Add(this.BtnM);
            this.Controls.Add(this.TxtCalc);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtCalc;
        private System.Windows.Forms.Button BtnM;
        private System.Windows.Forms.Button BtnTimes;
        private System.Windows.Forms.Button BtnMinus;
        private System.Windows.Forms.Button BtnPlus;
        private System.Windows.Forms.Button BtnEqual;
        private System.Windows.Forms.Button BtnClear;
        private System.Windows.Forms.Button BtnDivision;
        private System.Windows.Forms.Button BtnBackspace;
        private System.Windows.Forms.Button BtnL;
        private System.Windows.Forms.Button BtnC;
        private System.Windows.Forms.Button BtnV;
        private System.Windows.Forms.Button BtnX;
        private System.Windows.Forms.Button BtnD;
        private System.Windows.Forms.Button BtnI;
    }
}

