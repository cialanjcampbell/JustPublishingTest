﻿namespace PublishingTest
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
            this.BtViewMessage = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtViewMessage
            // 
            this.BtViewMessage.Location = new System.Drawing.Point(190, 199);
            this.BtViewMessage.Name = "BtViewMessage";
            this.BtViewMessage.Size = new System.Drawing.Size(149, 33);
            this.BtViewMessage.TabIndex = 0;
            this.BtViewMessage.Text = "View Message";
            this.BtViewMessage.UseVisualStyleBackColor = true;
            this.BtViewMessage.Click += new System.EventHandler(this.BtViewMessage_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 356);
            this.Controls.Add(this.BtViewMessage);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtViewMessage;
    }
}

