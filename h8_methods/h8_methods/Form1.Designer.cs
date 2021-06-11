namespace h8_methods
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
            this.oppButton = new System.Windows.Forms.Button();
            this.oppResult = new System.Windows.Forms.Label();
            this.oppHeight = new System.Windows.Forms.TextBox();
            this.oppWidth = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.oppError = new System.Windows.Forms.Label();
            this.omtError = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.omtWidth = new System.Windows.Forms.TextBox();
            this.omtHeight = new System.Windows.Forms.TextBox();
            this.omtResult = new System.Windows.Forms.Label();
            this.omtButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // oppButton
            // 
            this.oppButton.Location = new System.Drawing.Point(234, 63);
            this.oppButton.Name = "oppButton";
            this.oppButton.Size = new System.Drawing.Size(75, 23);
            this.oppButton.TabIndex = 0;
            this.oppButton.Text = "Bereken";
            this.oppButton.UseVisualStyleBackColor = true;
            this.oppButton.Click += new System.EventHandler(this.oppButton_Click);
            // 
            // oppResult
            // 
            this.oppResult.AutoSize = true;
            this.oppResult.Location = new System.Drawing.Point(315, 68);
            this.oppResult.Name = "oppResult";
            this.oppResult.Size = new System.Drawing.Size(65, 13);
            this.oppResult.TabIndex = 1;
            this.oppResult.Text = "Oppervlakte";
            // 
            // oppHeight
            // 
            this.oppHeight.Location = new System.Drawing.Point(21, 66);
            this.oppHeight.Name = "oppHeight";
            this.oppHeight.Size = new System.Drawing.Size(100, 20);
            this.oppHeight.TabIndex = 2;
            // 
            // oppWidth
            // 
            this.oppWidth.AccessibleName = "";
            this.oppWidth.Location = new System.Drawing.Point(128, 66);
            this.oppWidth.Name = "oppWidth";
            this.oppWidth.Size = new System.Drawing.Size(100, 20);
            this.oppWidth.TabIndex = 3;
            this.oppWidth.Tag = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Hoogte";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(125, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Breedte";
            // 
            // oppError
            // 
            this.oppError.AutoSize = true;
            this.oppError.ForeColor = System.Drawing.Color.Red;
            this.oppError.Location = new System.Drawing.Point(18, 89);
            this.oppError.Name = "oppError";
            this.oppError.Size = new System.Drawing.Size(7, 13);
            this.oppError.TabIndex = 6;
            this.oppError.Text = "\r\n";
            // 
            // omtError
            // 
            this.omtError.AutoSize = true;
            this.omtError.ForeColor = System.Drawing.Color.Red;
            this.omtError.Location = new System.Drawing.Point(18, 185);
            this.omtError.Name = "omtError";
            this.omtError.Size = new System.Drawing.Size(7, 13);
            this.omtError.TabIndex = 13;
            this.omtError.Text = "\r\n";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(125, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Breedte";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Hoogte";
            // 
            // omtWidth
            // 
            this.omtWidth.AccessibleName = "";
            this.omtWidth.Location = new System.Drawing.Point(128, 162);
            this.omtWidth.Name = "omtWidth";
            this.omtWidth.Size = new System.Drawing.Size(100, 20);
            this.omtWidth.TabIndex = 10;
            this.omtWidth.Tag = "";
            // 
            // omtHeight
            // 
            this.omtHeight.Location = new System.Drawing.Point(21, 162);
            this.omtHeight.Name = "omtHeight";
            this.omtHeight.Size = new System.Drawing.Size(100, 20);
            this.omtHeight.TabIndex = 9;
            // 
            // omtResult
            // 
            this.omtResult.AutoSize = true;
            this.omtResult.Location = new System.Drawing.Point(315, 164);
            this.omtResult.Name = "omtResult";
            this.omtResult.Size = new System.Drawing.Size(65, 13);
            this.omtResult.TabIndex = 8;
            this.omtResult.Text = "Oppervlakte";
            // 
            // omtButton
            // 
            this.omtButton.Location = new System.Drawing.Point(234, 159);
            this.omtButton.Name = "omtButton";
            this.omtButton.Size = new System.Drawing.Size(75, 23);
            this.omtButton.TabIndex = 7;
            this.omtButton.Text = "Bereken";
            this.omtButton.UseVisualStyleBackColor = true;
            this.omtButton.Click += new System.EventHandler(this.omtButton_Click);
            // 
            // Form1
            // 
            this.AccessibleDescription = "";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.omtError);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.omtWidth);
            this.Controls.Add(this.omtHeight);
            this.Controls.Add(this.omtResult);
            this.Controls.Add(this.omtButton);
            this.Controls.Add(this.oppError);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.oppWidth);
            this.Controls.Add(this.oppHeight);
            this.Controls.Add(this.oppResult);
            this.Controls.Add(this.oppButton);
            this.Name = "Form1";
            this.Tag = "";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button oppButton;
        private System.Windows.Forms.Label oppResult;
        private System.Windows.Forms.TextBox oppHeight;
        private System.Windows.Forms.TextBox oppWidth;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label oppError;
        private System.Windows.Forms.Label omtError;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox omtWidth;
        private System.Windows.Forms.TextBox omtHeight;
        private System.Windows.Forms.Label omtResult;
        private System.Windows.Forms.Button omtButton;
    }
}

