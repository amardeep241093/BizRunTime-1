﻿namespace IndexerProg.NetworkProgramming
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
            this.txtServerMessage = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtServerMessage
            // 
            this.txtServerMessage.Location = new System.Drawing.Point(61, 110);
            this.txtServerMessage.Multiline = true;
            this.txtServerMessage.Name = "txtServerMessage";
            this.txtServerMessage.Size = new System.Drawing.Size(470, 165);
            this.txtServerMessage.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Server Message";
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(61, 326);
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(441, 22);
            this.txtMessage.TabIndex = 2;
            // 
            // btnSend
            // 
            this.btnSend.AutoSize = true;
            this.btnSend.Location = new System.Drawing.Point(529, 331);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(39, 17);
            this.btnSend.TabIndex = 3;
            this.btnSend.Text = "send";
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(71, 294);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Message Send To Server";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtServerMessage);
            this.Name = "Form1";
            this.Text = "Form1";
         
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtServerMessage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.Label btnSend;
        private System.Windows.Forms.Label label2;
    }
}