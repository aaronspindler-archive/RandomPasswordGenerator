namespace RandomPasswordGenerator
{
    partial class mainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.printToFileButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.numberOfPasswordsUD = new System.Windows.Forms.NumericUpDown();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.outputLabel = new System.Windows.Forms.Label();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numberOfPasswordsUD)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.printToFileButton, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.numberOfPasswordsUD, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.progressBar, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.outputLabel, 0, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(379, 138);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // printToFileButton
            // 
            this.printToFileButton.AutoSize = true;
            this.printToFileButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.printToFileButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printToFileButton.Location = new System.Drawing.Point(3, 67);
            this.printToFileButton.Name = "printToFileButton";
            this.printToFileButton.Size = new System.Drawing.Size(373, 26);
            this.printToFileButton.TabIndex = 3;
            this.printToFileButton.Text = "Print to file";
            this.printToFileButton.UseVisualStyleBackColor = true;
            this.printToFileButton.Click += new System.EventHandler(this.printToFileButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(373, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select the number of passwords you want";
            // 
            // numberOfPasswordsUD
            // 
            this.numberOfPasswordsUD.AutoSize = true;
            this.numberOfPasswordsUD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numberOfPasswordsUD.Location = new System.Drawing.Point(3, 35);
            this.numberOfPasswordsUD.Name = "numberOfPasswordsUD";
            this.numberOfPasswordsUD.Size = new System.Drawing.Size(373, 20);
            this.numberOfPasswordsUD.TabIndex = 1;
            this.numberOfPasswordsUD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numberOfPasswordsUD.ValueChanged += new System.EventHandler(this.numberOfPasswordsUD_ValueChanged);
            // 
            // progressBar
            // 
            this.progressBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.progressBar.Location = new System.Drawing.Point(3, 119);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(373, 16);
            this.progressBar.TabIndex = 6;
            // 
            // outputLabel
            // 
            this.outputLabel.AutoSize = true;
            this.outputLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.outputLabel.Location = new System.Drawing.Point(3, 96);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(373, 20);
            this.outputLabel.TabIndex = 7;
            this.outputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.Filter = "(*.txt)|*.txt|All files (*.*)|*.*";
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 138);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "mainForm";
            this.Text = "Random Password Generator";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numberOfPasswordsUD)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button printToFileButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numberOfPasswordsUD;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.Label outputLabel;
    }
}

