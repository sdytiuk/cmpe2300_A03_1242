namespace _2ClassDemo
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
            this.btnNewCar = new System.Windows.Forms.Button();
            this.btnShowCars = new System.Windows.Forms.Button();
            this.lbCars = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnNewCar
            // 
            this.btnNewCar.Location = new System.Drawing.Point(13, 13);
            this.btnNewCar.Name = "btnNewCar";
            this.btnNewCar.Size = new System.Drawing.Size(75, 23);
            this.btnNewCar.TabIndex = 0;
            this.btnNewCar.Text = "New Car";
            this.btnNewCar.UseVisualStyleBackColor = true;
            // 
            // btnShowCars
            // 
            this.btnShowCars.Location = new System.Drawing.Point(13, 43);
            this.btnShowCars.Name = "btnShowCars";
            this.btnShowCars.Size = new System.Drawing.Size(75, 23);
            this.btnShowCars.TabIndex = 1;
            this.btnShowCars.Text = "Show Cars";
            this.btnShowCars.UseVisualStyleBackColor = true;
            // 
            // lbCars
            // 
            this.lbCars.FormattingEnabled = true;
            this.lbCars.Location = new System.Drawing.Point(140, 13);
            this.lbCars.Name = "lbCars";
            this.lbCars.Size = new System.Drawing.Size(184, 368);
            this.lbCars.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbCars);
            this.Controls.Add(this.btnShowCars);
            this.Controls.Add(this.btnNewCar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNewCar;
        private System.Windows.Forms.Button btnShowCars;
        private System.Windows.Forms.ListBox lbCars;
    }
}

