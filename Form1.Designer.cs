namespace AutofacDemoWin
{
    partial class FormAutofacDemoWin
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
            this.buttonObterLinguagemAutofac = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonObterLinguagemAutofac
            // 
            this.buttonObterLinguagemAutofac.Location = new System.Drawing.Point(18, 63);
            this.buttonObterLinguagemAutofac.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonObterLinguagemAutofac.Name = "buttonObterLinguagemAutofac";
            this.buttonObterLinguagemAutofac.Size = new System.Drawing.Size(390, 35);
            this.buttonObterLinguagemAutofac.TabIndex = 1;
            this.buttonObterLinguagemAutofac.Text = "Obter Linguagem usando Autofac";
            this.buttonObterLinguagemAutofac.UseVisualStyleBackColor = true;
            this.buttonObterLinguagemAutofac.Click += new System.EventHandler(this.buttonObterLinguagemAutofac_Click);
            // 
            // FormAutofacDemoWin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 403);
            this.Controls.Add(this.buttonObterLinguagemAutofac);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormAutofacDemoWin";
            this.Text = "Autofac Demo";
            this.Load += new System.EventHandler(this.FormAutofacDemoWin_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonObterLinguagemAutofac;
    }
}

