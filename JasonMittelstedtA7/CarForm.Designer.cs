namespace JasonMittelstedtA7
{
    partial class CarForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnChooseFile = new Button();
            btnSortMake = new Button();
            btnSortMakePrice = new Button();
            listBoxCars = new ListBox();
            SuspendLayout();
            // 
            // btnChooseFile
            // 
            btnChooseFile.Location = new Point(147, 133);
            btnChooseFile.Name = "btnChooseFile";
            btnChooseFile.Size = new Size(94, 29);
            btnChooseFile.TabIndex = 1;
            btnChooseFile.Text = "Choose File";
            btnChooseFile.UseVisualStyleBackColor = true;
            btnChooseFile.Click += btnChooseFile_Click;
            // 
            // btnSortMake
            // 
            btnSortMake.Location = new Point(247, 133);
            btnSortMake.Name = "btnSortMake";
            btnSortMake.Size = new Size(104, 29);
            btnSortMake.TabIndex = 2;
            btnSortMake.Text = "Sort by Make";
            btnSortMake.UseVisualStyleBackColor = true;
            btnSortMake.Click += btnSortMake_Click;
            // 
            // btnSortMakePrice
            // 
            btnSortMakePrice.Location = new Point(357, 133);
            btnSortMakePrice.Name = "btnSortMakePrice";
            btnSortMakePrice.Size = new Size(175, 29);
            btnSortMakePrice.TabIndex = 3;
            btnSortMakePrice.Text = "Sort by Make and Price";
            btnSortMakePrice.UseVisualStyleBackColor = true;
            btnSortMakePrice.Click += btnSortMakePrice_Click;
            // 
            // listBoxCars
            // 
            listBoxCars.FormattingEnabled = true;
            listBoxCars.Location = new Point(247, 188);
            listBoxCars.Name = "listBoxCars";
            listBoxCars.Size = new Size(400, 224);
            listBoxCars.TabIndex = 4;
            // 
            // CarForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(listBoxCars);
            Controls.Add(btnSortMakePrice);
            Controls.Add(btnSortMake);
            Controls.Add(btnChooseFile);
            Name = "CarForm";
            Text = "Jason Mittelstedt Assignment 7";
            ResumeLayout(false);
        }

        #endregion

        private Button btnChooseFile;
        private Button btnSortMake;
        private Button btnSortMakePrice;
        private ListBox listBoxCars;
    }
}
