namespace prySilvaMenendez.GitHub
{
    partial class frmGitHub
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
            btnUno = new Button();
            SuspendLayout();
            // 
            // btnUno
            // 
            btnUno.Location = new Point(213, 90);
            btnUno.Name = "btnUno";
            btnUno.Size = new Size(102, 41);
            btnUno.TabIndex = 0;
            btnUno.Text = "Boton Uno";
            btnUno.UseVisualStyleBackColor = true;
            // 
            // frmGitHub
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnUno);
            Name = "frmGitHub";
            Text = "Registro En GitHub de Mi Proyecto";
            ResumeLayout(false);
        }

        #endregion

        private Button btnUno;
    }
}
