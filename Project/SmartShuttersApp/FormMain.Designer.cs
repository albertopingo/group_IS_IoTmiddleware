﻿namespace SmartShuttersApp
{
    partial class FormMain
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
            this.buttonCreateContainer = new System.Windows.Forms.Button();
            this.buttonCreateSubscription = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.textBoxContainerName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxEndPoint = new System.Windows.Forms.TextBox();
            this.comboBoxEvent = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // buttonCreateContainer
            // 
            this.buttonCreateContainer.Location = new System.Drawing.Point(768, 43);
            this.buttonCreateContainer.Name = "buttonCreateContainer";
            this.buttonCreateContainer.Size = new System.Drawing.Size(251, 39);
            this.buttonCreateContainer.TabIndex = 1;
            this.buttonCreateContainer.Text = "Create Container";
            this.buttonCreateContainer.UseVisualStyleBackColor = true;
            this.buttonCreateContainer.Click += new System.EventHandler(this.buttonCreateContainer_Click);
            // 
            // buttonCreateSubscription
            // 
            this.buttonCreateSubscription.Location = new System.Drawing.Point(768, 265);
            this.buttonCreateSubscription.Name = "buttonCreateSubscription";
            this.buttonCreateSubscription.Size = new System.Drawing.Size(251, 39);
            this.buttonCreateSubscription.TabIndex = 2;
            this.buttonCreateSubscription.Text = "Create Subscription";
            this.buttonCreateSubscription.UseVisualStyleBackColor = true;
            this.buttonCreateSubscription.Click += new System.EventHandler(this.buttonCreateSubscription_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(783, 409);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(251, 39);
            this.button4.TabIndex = 3;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // textBoxContainerName
            // 
            this.textBoxContainerName.Location = new System.Drawing.Point(456, 53);
            this.textBoxContainerName.Name = "textBoxContainerName";
            this.textBoxContainerName.Size = new System.Drawing.Size(267, 29);
            this.textBoxContainerName.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(237, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nome do Container";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(560, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "EndPoint";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(859, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Tipo de evento";
            // 
            // textBoxEndPoint
            // 
            this.textBoxEndPoint.Location = new System.Drawing.Point(489, 172);
            this.textBoxEndPoint.Name = "textBoxEndPoint";
            this.textBoxEndPoint.Size = new System.Drawing.Size(234, 29);
            this.textBoxEndPoint.TabIndex = 8;
            // 
            // comboBoxEvent
            // 
            this.comboBoxEvent.FormattingEnabled = true;
            this.comboBoxEvent.Items.AddRange(new object[] {
            "1",
            "2"});
            this.comboBoxEvent.Location = new System.Drawing.Point(825, 169);
            this.comboBoxEvent.Name = "comboBoxEvent";
            this.comboBoxEvent.Size = new System.Drawing.Size(209, 32);
            this.comboBoxEvent.TabIndex = 9;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1066, 551);
            this.Controls.Add(this.comboBoxEvent);
            this.Controls.Add(this.textBoxEndPoint);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxContainerName);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.buttonCreateSubscription);
            this.Controls.Add(this.buttonCreateContainer);
            this.Name = "FormMain";
            this.Text = "FormMain";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonCreateContainer;
        private System.Windows.Forms.Button buttonCreateSubscription;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox textBoxContainerName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxEndPoint;
        private System.Windows.Forms.ComboBox comboBoxEvent;
    }
}