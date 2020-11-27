namespace Circustrein_S2_Software
{
    partial class Circustrein
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
            this.btnAddAnimal = new System.Windows.Forms.Button();
            this.lbxWagons = new System.Windows.Forms.ListBox();
            this.lbxAnimals = new System.Windows.Forms.ListBox();
            this.lbWagons = new System.Windows.Forms.Label();
            this.lbAnimals = new System.Windows.Forms.Label();
            this.nmudAmount = new System.Windows.Forms.NumericUpDown();
            this.cbxAnimalType = new System.Windows.Forms.ComboBox();
            this.lbAnimaltype = new System.Windows.Forms.Label();
            this.lbAmount = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nmudAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddAnimal
            // 
            this.btnAddAnimal.Location = new System.Drawing.Point(12, 226);
            this.btnAddAnimal.Name = "btnAddAnimal";
            this.btnAddAnimal.Size = new System.Drawing.Size(213, 33);
            this.btnAddAnimal.TabIndex = 0;
            this.btnAddAnimal.Text = "Add";
            this.btnAddAnimal.UseVisualStyleBackColor = true;
            // 
            // lbxWagons
            // 
            this.lbxWagons.FormattingEnabled = true;
            this.lbxWagons.Location = new System.Drawing.Point(253, 28);
            this.lbxWagons.Name = "lbxWagons";
            this.lbxWagons.Size = new System.Drawing.Size(178, 303);
            this.lbxWagons.TabIndex = 1;
            // 
            // lbxAnimals
            // 
            this.lbxAnimals.FormattingEnabled = true;
            this.lbxAnimals.Location = new System.Drawing.Point(437, 28);
            this.lbxAnimals.Name = "lbxAnimals";
            this.lbxAnimals.Size = new System.Drawing.Size(178, 303);
            this.lbxAnimals.TabIndex = 2;
            // 
            // lbWagons
            // 
            this.lbWagons.AutoSize = true;
            this.lbWagons.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbWagons.Location = new System.Drawing.Point(248, 0);
            this.lbWagons.Name = "lbWagons";
            this.lbWagons.Size = new System.Drawing.Size(97, 25);
            this.lbWagons.TabIndex = 3;
            this.lbWagons.Text = "Wagons";
            // 
            // lbAnimals
            // 
            this.lbAnimals.AutoSize = true;
            this.lbAnimals.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAnimals.Location = new System.Drawing.Point(432, 0);
            this.lbAnimals.Name = "lbAnimals";
            this.lbAnimals.Size = new System.Drawing.Size(95, 25);
            this.lbAnimals.TabIndex = 4;
            this.lbAnimals.Text = "Animals";
            // 
            // nmudAmount
            // 
            this.nmudAmount.Location = new System.Drawing.Point(12, 175);
            this.nmudAmount.Name = "nmudAmount";
            this.nmudAmount.Size = new System.Drawing.Size(213, 20);
            this.nmudAmount.TabIndex = 5;
            // 
            // cbxAnimalType
            // 
            this.cbxAnimalType.FormattingEnabled = true;
            this.cbxAnimalType.Location = new System.Drawing.Point(12, 83);
            this.cbxAnimalType.Name = "cbxAnimalType";
            this.cbxAnimalType.Size = new System.Drawing.Size(213, 21);
            this.cbxAnimalType.TabIndex = 6;
            // 
            // lbAnimaltype
            // 
            this.lbAnimaltype.AutoSize = true;
            this.lbAnimaltype.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAnimaltype.Location = new System.Drawing.Point(12, 55);
            this.lbAnimaltype.Name = "lbAnimaltype";
            this.lbAnimaltype.Size = new System.Drawing.Size(135, 25);
            this.lbAnimaltype.TabIndex = 7;
            this.lbAnimaltype.Text = "AnimalType";
            // 
            // lbAmount
            // 
            this.lbAmount.AutoSize = true;
            this.lbAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAmount.Location = new System.Drawing.Point(12, 147);
            this.lbAmount.Name = "lbAmount";
            this.lbAmount.Size = new System.Drawing.Size(91, 25);
            this.lbAmount.TabIndex = 8;
            this.lbAmount.Text = "Amount";
            // 
            // Circustrein
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 345);
            this.Controls.Add(this.lbAmount);
            this.Controls.Add(this.lbAnimaltype);
            this.Controls.Add(this.cbxAnimalType);
            this.Controls.Add(this.nmudAmount);
            this.Controls.Add(this.lbAnimals);
            this.Controls.Add(this.lbWagons);
            this.Controls.Add(this.lbxAnimals);
            this.Controls.Add(this.lbxWagons);
            this.Controls.Add(this.btnAddAnimal);
            this.Name = "Circustrein";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.nmudAmount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddAnimal;
        private System.Windows.Forms.ListBox lbxWagons;
        private System.Windows.Forms.ListBox lbxAnimals;
        private System.Windows.Forms.Label lbWagons;
        private System.Windows.Forms.Label lbAnimals;
        private System.Windows.Forms.NumericUpDown nmudAmount;
        private System.Windows.Forms.ComboBox cbxAnimalType;
        private System.Windows.Forms.Label lbAnimaltype;
        private System.Windows.Forms.Label lbAmount;
    }
}

