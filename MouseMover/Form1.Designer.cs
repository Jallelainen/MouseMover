namespace MouseMover
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
            this.btnMove = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMove
            // 
            this.btnMove.Location = new System.Drawing.Point(53, 265);
            this.btnMove.Name = "btnMove";
            this.btnMove.Size = new System.Drawing.Size(1093, 78);
            this.btnMove.TabIndex = 0;
            this.btnMove.Text = "Move ";
            this.btnMove.UseVisualStyleBackColor = true;
            this.btnMove.Click += new System.EventHandler(this.btnMove_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(1196, 389);
            this.Controls.Add(this.btnMove);
            this.Name = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnMove;
    }
}