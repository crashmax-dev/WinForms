namespace WinForms
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.CustomPanel = new System.Windows.Forms.Label();
            this.MaxMinButton = new System.Windows.Forms.Button();
            this.MinButton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CustomPanel
            // 
            this.CustomPanel.BackColor = System.Drawing.SystemColors.Control;
            this.CustomPanel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CustomPanel.Location = new System.Drawing.Point(0, 0);
            this.CustomPanel.Name = "CustomPanel";
            this.CustomPanel.Size = new System.Drawing.Size(400, 21);
            this.CustomPanel.TabIndex = 4;
            this.CustomPanel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CustomPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormMove);
            // 
            // MaxMinButton
            // 
            this.MaxMinButton.BackColor = System.Drawing.SystemColors.Control;
            this.MaxMinButton.Enabled = false;
            this.MaxMinButton.FlatAppearance.BorderSize = 0;
            this.MaxMinButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MaxMinButton.Image = global::WinForms.Properties.Resources.max_gray;
            this.MaxMinButton.Location = new System.Drawing.Point(350, 0);
            this.MaxMinButton.Name = "MaxMinButton";
            this.MaxMinButton.Size = new System.Drawing.Size(25, 21);
            this.MaxMinButton.TabIndex = 5;
            this.MaxMinButton.UseVisualStyleBackColor = false;
            this.MaxMinButton.Click += new System.EventHandler(this.ToggleMaximize);
            // 
            // MinButton
            // 
            this.MinButton.BackColor = System.Drawing.SystemColors.Control;
            this.MinButton.FlatAppearance.BorderSize = 0;
            this.MinButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MinButton.Image = ((System.Drawing.Image)(resources.GetObject("MinButton.Image")));
            this.MinButton.Location = new System.Drawing.Point(325, 0);
            this.MinButton.Name = "MinButton";
            this.MinButton.Size = new System.Drawing.Size(25, 21);
            this.MinButton.TabIndex = 1;
            this.MinButton.UseVisualStyleBackColor = false;
            this.MinButton.Click += new System.EventHandler(this.MinApp);
            // 
            // CloseButton
            // 
            this.CloseButton.BackColor = System.Drawing.SystemColors.Control;
            this.CloseButton.FlatAppearance.BorderSize = 0;
            this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseButton.Image = global::WinForms.Properties.Resources.close_gray;
            this.CloseButton.Location = new System.Drawing.Point(375, 0);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(25, 21);
            this.CloseButton.TabIndex = 0;
            this.CloseButton.UseVisualStyleBackColor = false;
            this.CloseButton.Click += new System.EventHandler(this.CloseApp);
            this.CloseButton.MouseLeave += new System.EventHandler(this.CloseButtonLeave);
            this.CloseButton.MouseMove += new System.Windows.Forms.MouseEventHandler(this.CloseButtonHover);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(400, 400);
            this.Controls.Add(this.MaxMinButton);
            this.Controls.Add(this.MinButton);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.CustomPanel);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Opacity = 0D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.LoadApp);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Button MinButton;
        private System.Windows.Forms.Label CustomPanel;
        private System.Windows.Forms.Button MaxMinButton;
    }
}