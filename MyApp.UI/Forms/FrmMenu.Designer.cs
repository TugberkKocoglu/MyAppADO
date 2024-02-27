namespace MyApp.UI.Forms
{
    partial class FrmMenu
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
            this.btn_NewSave = new System.Windows.Forms.Button();
            this.btn_OldSave = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_NewSave
            // 
            this.btn_NewSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_NewSave.Location = new System.Drawing.Point(12, 105);
            this.btn_NewSave.Name = "btn_NewSave";
            this.btn_NewSave.Size = new System.Drawing.Size(205, 171);
            this.btn_NewSave.TabIndex = 0;
            this.btn_NewSave.Text = "+";
            this.btn_NewSave.UseVisualStyleBackColor = true;
            this.btn_NewSave.Click += new System.EventHandler(this.btn_NewSave_Click);
            // 
            // btn_OldSave
            // 
            this.btn_OldSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_OldSave.Location = new System.Drawing.Point(309, 105);
            this.btn_OldSave.Name = "btn_OldSave";
            this.btn_OldSave.Size = new System.Drawing.Size(201, 171);
            this.btn_OldSave.TabIndex = 1;
            this.btn_OldSave.Text = "ÜYELİKLER";
            this.btn_OldSave.UseVisualStyleBackColor = true;
            this.btn_OldSave.Click += new System.EventHandler(this.btn_OldSave_Click);
            // 
            // btn_Update
            // 
            this.btn_Update.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Update.Location = new System.Drawing.Point(601, 105);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(187, 171);
            this.btn_Update.TabIndex = 2;
            this.btn_Update.Text = "GÜNCELLE";
            this.btn_Update.UseVisualStyleBackColor = true;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.btn_OldSave);
            this.Controls.Add(this.btn_NewSave);
            this.Name = "FrmMenu";
            this.Text = "FrmMenu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_NewSave;
        private System.Windows.Forms.Button btn_OldSave;
        private System.Windows.Forms.Button btn_Update;
    }
}