﻿
namespace Chat
{
    partial class Received
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
            this.tb_from = new System.Windows.Forms.TextBox();
            this.lb_from = new System.Windows.Forms.Label();
            this.tb_message = new System.Windows.Forms.TextBox();
            this.bt_reply = new System.Windows.Forms.Button();
            this.bt_deleteContents = new System.Windows.Forms.Button();
            this.bt_close = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tb_from
            // 
            this.tb_from.BackColor = System.Drawing.Color.White;
            this.tb_from.Enabled = false;
            this.tb_from.Location = new System.Drawing.Point(165, 17);
            this.tb_from.Name = "tb_from";
            this.tb_from.Size = new System.Drawing.Size(100, 22);
            this.tb_from.TabIndex = 0;
            this.tb_from.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lb_from
            // 
            this.lb_from.AutoSize = true;
            this.lb_from.Location = new System.Drawing.Point(115, 17);
            this.lb_from.Name = "lb_from";
            this.lb_from.Size = new System.Drawing.Size(44, 17);
            this.lb_from.TabIndex = 1;
            this.lb_from.Text = "From:";
            // 
            // tb_message
            // 
            this.tb_message.BackColor = System.Drawing.Color.White;
            this.tb_message.Enabled = false;
            this.tb_message.Location = new System.Drawing.Point(28, 55);
            this.tb_message.Multiline = true;
            this.tb_message.Name = "tb_message";
            this.tb_message.Size = new System.Drawing.Size(341, 303);
            this.tb_message.TabIndex = 2;
            // 
            // bt_reply
            // 
            this.bt_reply.Location = new System.Drawing.Point(28, 376);
            this.bt_reply.Name = "bt_reply";
            this.bt_reply.Size = new System.Drawing.Size(86, 62);
            this.bt_reply.TabIndex = 3;
            this.bt_reply.Text = "Reply";
            this.bt_reply.UseVisualStyleBackColor = true;
            this.bt_reply.Click += new System.EventHandler(this.bt_reply_Click);
            // 
            // bt_deleteContents
            // 
            this.bt_deleteContents.Location = new System.Drawing.Point(154, 376);
            this.bt_deleteContents.Name = "bt_deleteContents";
            this.bt_deleteContents.Size = new System.Drawing.Size(86, 62);
            this.bt_deleteContents.TabIndex = 4;
            this.bt_deleteContents.Text = "Delete Contents";
            this.bt_deleteContents.UseVisualStyleBackColor = true;
            this.bt_deleteContents.Click += new System.EventHandler(this.bt_deleteContents_Click);
            // 
            // bt_close
            // 
            this.bt_close.Location = new System.Drawing.Point(283, 376);
            this.bt_close.Name = "bt_close";
            this.bt_close.Size = new System.Drawing.Size(86, 62);
            this.bt_close.TabIndex = 5;
            this.bt_close.Text = "Close";
            this.bt_close.UseVisualStyleBackColor = true;
            this.bt_close.Click += new System.EventHandler(this.button3_Click);
            // 
            // Received
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 450);
            this.Controls.Add(this.bt_close);
            this.Controls.Add(this.bt_deleteContents);
            this.Controls.Add(this.bt_reply);
            this.Controls.Add(this.tb_message);
            this.Controls.Add(this.lb_from);
            this.Controls.Add(this.tb_from);
            this.Name = "Received";
            this.Text = "Received";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_from;
        private System.Windows.Forms.Label lb_from;
        private System.Windows.Forms.TextBox tb_message;
        private System.Windows.Forms.Button bt_reply;
        private System.Windows.Forms.Button bt_deleteContents;
        private System.Windows.Forms.Button bt_close;
    }
}