namespace e_commerce_NYC.Models
{
    partial class Component_label
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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mainBtn = new System.Windows.Forms.Button();
            // 
            // mainBtn
            // 
            this.mainBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            this.mainBtn.Font = new System.Drawing.Font("Power Grotesk Trial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(29)))), ((int)(((byte)(1)))));
            this.mainBtn.Location = new System.Drawing.Point(0, 0);
            this.mainBtn.Name = "mainBtn";
            this.mainBtn.Size = new System.Drawing.Size(390, 60);
            this.mainBtn.TabIndex = 0;
            this.mainBtn.Text = "Enter Account";
            this.mainBtn.UseVisualStyleBackColor = false;

        }

        #endregion

        private System.Windows.Forms.Button mainBtn;
    }
}
