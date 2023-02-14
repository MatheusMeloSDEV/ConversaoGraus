namespace ConversaoGraus
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
            this.SelectConv = new System.Windows.Forms.ComboBox();
            this.BtnCalc = new System.Windows.Forms.Button();
            this.InsertGrau = new System.Windows.Forms.TextBox();
            this.ShowGrau = new System.Windows.Forms.TextBox();
            this.MetdConv = new System.Windows.Forms.Label();
            this.ClearBtn = new System.Windows.Forms.Button();
            this.Title = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SelectConv
            // 
            this.SelectConv.FormattingEnabled = true;
            this.SelectConv.Items.AddRange(new object[] {
            "celsius => fahrenheit ",
            "fahrenheit => celsius"});
            this.SelectConv.Location = new System.Drawing.Point(143, 233);
            this.SelectConv.Name = "SelectConv";
            this.SelectConv.Size = new System.Drawing.Size(231, 23);
            this.SelectConv.TabIndex = 1;
            // 
            // BtnCalc
            // 
            this.BtnCalc.Location = new System.Drawing.Point(552, 203);
            this.BtnCalc.Name = "BtnCalc";
            this.BtnCalc.Size = new System.Drawing.Size(88, 38);
            this.BtnCalc.TabIndex = 2;
            this.BtnCalc.Text = "Calcular";
            this.BtnCalc.UseVisualStyleBackColor = true;
            this.BtnCalc.Click += new System.EventHandler(this.BtnCalc_Click);
            // 
            // InsertGrau
            // 
            this.InsertGrau.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.InsertGrau.Location = new System.Drawing.Point(527, 141);
            this.InsertGrau.Name = "InsertGrau";
            this.InsertGrau.Size = new System.Drawing.Size(142, 34);
            this.InsertGrau.TabIndex = 3;
            // 
            // ShowGrau
            // 
            this.ShowGrau.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ShowGrau.Location = new System.Drawing.Point(527, 321);
            this.ShowGrau.Name = "ShowGrau";
            this.ShowGrau.ReadOnly = true;
            this.ShowGrau.Size = new System.Drawing.Size(142, 34);
            this.ShowGrau.TabIndex = 4;
            // 
            // MetdConv
            // 
            this.MetdConv.AutoSize = true;
            this.MetdConv.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MetdConv.Location = new System.Drawing.Point(23, 190);
            this.MetdConv.Name = "MetdConv";
            this.MetdConv.Size = new System.Drawing.Size(312, 28);
            this.MetdConv.TabIndex = 5;
            this.MetdConv.Text = "Selecione o método de conversão:";
            // 
            // ClearBtn
            // 
            this.ClearBtn.Location = new System.Drawing.Point(552, 261);
            this.ClearBtn.Name = "ClearBtn";
            this.ClearBtn.Size = new System.Drawing.Size(88, 38);
            this.ClearBtn.TabIndex = 6;
            this.ClearBtn.Text = "Limpar";
            this.ClearBtn.UseVisualStyleBackColor = true;
            this.ClearBtn.Click += new System.EventHandler(this.ClearBtn_Click);
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Title.Font = new System.Drawing.Font("Segoe UI", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Title.Location = new System.Drawing.Point(194, 28);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(412, 74);
            this.Title.TabIndex = 7;
            this.Title.Text = "Conversão Grau";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.ClearBtn);
            this.Controls.Add(this.MetdConv);
            this.Controls.Add(this.ShowGrau);
            this.Controls.Add(this.InsertGrau);
            this.Controls.Add(this.BtnCalc);
            this.Controls.Add(this.SelectConv);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox SelectConv;
        private Button BtnCalc;
        private TextBox InsertGrau;
        private TextBox ShowGrau;
        private Label MetdConv;
        private Button ClearBtn;
        private Label Title;
    }
}