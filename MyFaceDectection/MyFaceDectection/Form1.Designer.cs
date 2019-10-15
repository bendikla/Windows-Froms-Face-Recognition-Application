namespace MyFaceDectection
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
            this.components = new System.ComponentModel.Container();
            this.cameraBox = new Emgu.CV.UI.ImageBox();
            this.start = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.textName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.cameraBox)).BeginInit();
            this.SuspendLayout();
            // 
            // cameraBox
            // 
            this.cameraBox.Location = new System.Drawing.Point(28, 27);
            this.cameraBox.Name = "cameraBox";
            this.cameraBox.Size = new System.Drawing.Size(962, 808);
            this.cameraBox.TabIndex = 2;
            this.cameraBox.TabStop = false;
            // 
            // start
            // 
            this.start.Location = new System.Drawing.Point(1142, 89);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(264, 82);
            this.start.TabIndex = 3;
            this.start.Text = "Start Detection And Recognition";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.Start_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(1142, 547);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(264, 86);
            this.saveButton.TabIndex = 4;
            this.saveButton.Text = "Save Face";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(1262, 323);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(144, 26);
            this.textName.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1142, 323);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Name";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1552, 838);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textName);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.start);
            this.Controls.Add(this.cameraBox);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.cameraBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Emgu.CV.UI.ImageBox cameraBox;
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.Label label1;
    }
}

