namespace Topic_12_13_GUI_Assignment_2
{
    partial class FormUnitConverstion
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
            this.txtHeightInput = new System.Windows.Forms.TextBox();
            this.grpHeightStartingUnit = new System.Windows.Forms.GroupBox();
            this.radFromHH = new System.Windows.Forms.RadioButton();
            this.radFromFeet = new System.Windows.Forms.RadioButton();
            this.radFromCM = new System.Windows.Forms.RadioButton();
            this.radFromInches = new System.Windows.Forms.RadioButton();
            this.lblTitle = new System.Windows.Forms.Label();
            this.grpHeightConverter = new System.Windows.Forms.GroupBox();
            this.radfromMeters = new System.Windows.Forms.RadioButton();
            this.grpHeightConvertTo = new System.Windows.Forms.GroupBox();
            this.radToMeters = new System.Windows.Forms.RadioButton();
            this.radToCM = new System.Windows.Forms.RadioButton();
            this.radToInches = new System.Windows.Forms.RadioButton();
            this.radToFeet = new System.Windows.Forms.RadioButton();
            this.radToHH = new System.Windows.Forms.RadioButton();
            this.lblHeightTo = new System.Windows.Forms.Label();
            this.lblHeightFrom = new System.Windows.Forms.Label();
            this.grpHeightStartingUnit.SuspendLayout();
            this.grpHeightConverter.SuspendLayout();
            this.grpHeightConvertTo.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtHeightInput
            // 
            this.txtHeightInput.Font = new System.Drawing.Font("Calisto MT", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHeightInput.Location = new System.Drawing.Point(23, 32);
            this.txtHeightInput.Name = "txtHeightInput";
            this.txtHeightInput.Size = new System.Drawing.Size(133, 27);
            this.txtHeightInput.TabIndex = 0;
            this.txtHeightInput.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // grpHeightStartingUnit
            // 
            this.grpHeightStartingUnit.Controls.Add(this.radfromMeters);
            this.grpHeightStartingUnit.Controls.Add(this.radFromCM);
            this.grpHeightStartingUnit.Controls.Add(this.radFromInches);
            this.grpHeightStartingUnit.Controls.Add(this.radFromFeet);
            this.grpHeightStartingUnit.Controls.Add(this.radFromHH);
            this.grpHeightStartingUnit.Font = new System.Drawing.Font("Harlow Solid Italic", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpHeightStartingUnit.Location = new System.Drawing.Point(23, 73);
            this.grpHeightStartingUnit.Name = "grpHeightStartingUnit";
            this.grpHeightStartingUnit.Size = new System.Drawing.Size(178, 218);
            this.grpHeightStartingUnit.TabIndex = 1;
            this.grpHeightStartingUnit.TabStop = false;
            this.grpHeightStartingUnit.Text = "Starting unit:";
            // 
            // radFromHH
            // 
            this.radFromHH.AutoSize = true;
            this.radFromHH.Font = new System.Drawing.Font("Calisto MT", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radFromHH.Location = new System.Drawing.Point(25, 30);
            this.radFromHH.Name = "radFromHH";
            this.radFromHH.Size = new System.Drawing.Size(120, 24);
            this.radFromHH.TabIndex = 0;
            this.radFromHH.TabStop = true;
            this.radFromHH.Text = "Horse hands";
            this.radFromHH.UseVisualStyleBackColor = true;
            // 
            // radFromFeet
            // 
            this.radFromFeet.AutoSize = true;
            this.radFromFeet.Font = new System.Drawing.Font("Calisto MT", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radFromFeet.Location = new System.Drawing.Point(25, 67);
            this.radFromFeet.Name = "radFromFeet";
            this.radFromFeet.Size = new System.Drawing.Size(62, 24);
            this.radFromFeet.TabIndex = 1;
            this.radFromFeet.TabStop = true;
            this.radFromFeet.Text = "Feet";
            this.radFromFeet.UseVisualStyleBackColor = true;
            // 
            // radFromCM
            // 
            this.radFromCM.AutoSize = true;
            this.radFromCM.Font = new System.Drawing.Font("Calisto MT", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radFromCM.Location = new System.Drawing.Point(25, 142);
            this.radFromCM.Name = "radFromCM";
            this.radFromCM.Size = new System.Drawing.Size(117, 24);
            this.radFromCM.TabIndex = 3;
            this.radFromCM.TabStop = true;
            this.radFromCM.Text = "Centimeters";
            this.radFromCM.UseVisualStyleBackColor = true;
            // 
            // radFromInches
            // 
            this.radFromInches.AutoSize = true;
            this.radFromInches.Font = new System.Drawing.Font("Calisto MT", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radFromInches.Location = new System.Drawing.Point(25, 105);
            this.radFromInches.Name = "radFromInches";
            this.radFromInches.Size = new System.Drawing.Size(77, 24);
            this.radFromInches.TabIndex = 2;
            this.radFromInches.TabStop = true;
            this.radFromInches.Text = "Inches";
            this.radFromInches.UseVisualStyleBackColor = true;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Harlow Solid Italic", 19.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(12, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(489, 43);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "Unit conversion tool for equestrians";
            // 
            // grpHeightConverter
            // 
            this.grpHeightConverter.Controls.Add(this.lblHeightFrom);
            this.grpHeightConverter.Controls.Add(this.lblHeightTo);
            this.grpHeightConverter.Controls.Add(this.grpHeightConvertTo);
            this.grpHeightConverter.Controls.Add(this.txtHeightInput);
            this.grpHeightConverter.Controls.Add(this.grpHeightStartingUnit);
            this.grpHeightConverter.Font = new System.Drawing.Font("Harlow Solid Italic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpHeightConverter.Location = new System.Drawing.Point(82, 122);
            this.grpHeightConverter.Name = "grpHeightConverter";
            this.grpHeightConverter.Size = new System.Drawing.Size(419, 316);
            this.grpHeightConverter.TabIndex = 3;
            this.grpHeightConverter.TabStop = false;
            this.grpHeightConverter.Text = "Height";
            // 
            // radfromMeters
            // 
            this.radfromMeters.AutoSize = true;
            this.radfromMeters.Font = new System.Drawing.Font("Calisto MT", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radfromMeters.Location = new System.Drawing.Point(25, 178);
            this.radfromMeters.Name = "radfromMeters";
            this.radfromMeters.Size = new System.Drawing.Size(80, 24);
            this.radfromMeters.TabIndex = 4;
            this.radfromMeters.TabStop = true;
            this.radfromMeters.Text = "Meters";
            this.radfromMeters.UseVisualStyleBackColor = true;
            // 
            // grpHeightConvertTo
            // 
            this.grpHeightConvertTo.Controls.Add(this.radToMeters);
            this.grpHeightConvertTo.Controls.Add(this.radToCM);
            this.grpHeightConvertTo.Controls.Add(this.radToInches);
            this.grpHeightConvertTo.Controls.Add(this.radToFeet);
            this.grpHeightConvertTo.Controls.Add(this.radToHH);
            this.grpHeightConvertTo.Font = new System.Drawing.Font("Harlow Solid Italic", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpHeightConvertTo.Location = new System.Drawing.Point(224, 73);
            this.grpHeightConvertTo.Name = "grpHeightConvertTo";
            this.grpHeightConvertTo.Size = new System.Drawing.Size(170, 218);
            this.grpHeightConvertTo.TabIndex = 5;
            this.grpHeightConvertTo.TabStop = false;
            this.grpHeightConvertTo.Text = "Convert to:";
            // 
            // radToMeters
            // 
            this.radToMeters.AutoSize = true;
            this.radToMeters.Font = new System.Drawing.Font("Calisto MT", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radToMeters.Location = new System.Drawing.Point(25, 178);
            this.radToMeters.Name = "radToMeters";
            this.radToMeters.Size = new System.Drawing.Size(80, 24);
            this.radToMeters.TabIndex = 4;
            this.radToMeters.TabStop = true;
            this.radToMeters.Text = "Meters";
            this.radToMeters.UseVisualStyleBackColor = true;
            // 
            // radToCM
            // 
            this.radToCM.AutoSize = true;
            this.radToCM.Font = new System.Drawing.Font("Calisto MT", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radToCM.Location = new System.Drawing.Point(25, 142);
            this.radToCM.Name = "radToCM";
            this.radToCM.Size = new System.Drawing.Size(117, 24);
            this.radToCM.TabIndex = 3;
            this.radToCM.TabStop = true;
            this.radToCM.Text = "Centimeters";
            this.radToCM.UseVisualStyleBackColor = true;
            // 
            // radToInches
            // 
            this.radToInches.AutoSize = true;
            this.radToInches.Font = new System.Drawing.Font("Calisto MT", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radToInches.Location = new System.Drawing.Point(25, 105);
            this.radToInches.Name = "radToInches";
            this.radToInches.Size = new System.Drawing.Size(77, 24);
            this.radToInches.TabIndex = 2;
            this.radToInches.TabStop = true;
            this.radToInches.Text = "Inches";
            this.radToInches.UseVisualStyleBackColor = true;
            // 
            // radToFeet
            // 
            this.radToFeet.AutoSize = true;
            this.radToFeet.Font = new System.Drawing.Font("Calisto MT", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radToFeet.Location = new System.Drawing.Point(25, 67);
            this.radToFeet.Name = "radToFeet";
            this.radToFeet.Size = new System.Drawing.Size(62, 24);
            this.radToFeet.TabIndex = 1;
            this.radToFeet.TabStop = true;
            this.radToFeet.Text = "Feet";
            this.radToFeet.UseVisualStyleBackColor = true;
            // 
            // radToHH
            // 
            this.radToHH.AutoSize = true;
            this.radToHH.Font = new System.Drawing.Font("Calisto MT", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radToHH.Location = new System.Drawing.Point(25, 30);
            this.radToHH.Name = "radToHH";
            this.radToHH.Size = new System.Drawing.Size(120, 24);
            this.radToHH.TabIndex = 0;
            this.radToHH.TabStop = true;
            this.radToHH.Text = "Horse hands";
            this.radToHH.UseVisualStyleBackColor = true;
            // 
            // lblHeightTo
            // 
            this.lblHeightTo.Font = new System.Drawing.Font("Calisto MT", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeightTo.Location = new System.Drawing.Point(224, 32);
            this.lblHeightTo.Name = "lblHeightTo";
            this.lblHeightTo.Size = new System.Drawing.Size(170, 23);
            this.lblHeightTo.TabIndex = 6;
            this.lblHeightTo.Text = "= ___ unit";
            this.lblHeightTo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblHeightFrom
            // 
            this.lblHeightFrom.Font = new System.Drawing.Font("Calisto MT", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeightFrom.Location = new System.Drawing.Point(162, 34);
            this.lblHeightFrom.Name = "lblHeightFrom";
            this.lblHeightFrom.Size = new System.Drawing.Size(39, 23);
            this.lblHeightFrom.TabIndex = 7;
            this.lblHeightFrom.Text = "unit";
            this.lblHeightFrom.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormUnitConverstion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(954, 553);
            this.Controls.Add(this.grpHeightConverter);
            this.Controls.Add(this.lblTitle);
            this.Name = "FormUnitConverstion";
            this.Text = "Unit Conversion Tool";
            this.grpHeightStartingUnit.ResumeLayout(false);
            this.grpHeightStartingUnit.PerformLayout();
            this.grpHeightConverter.ResumeLayout(false);
            this.grpHeightConverter.PerformLayout();
            this.grpHeightConvertTo.ResumeLayout(false);
            this.grpHeightConvertTo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtHeightInput;
        private System.Windows.Forms.GroupBox grpHeightStartingUnit;
        private System.Windows.Forms.RadioButton radFromHH;
        private System.Windows.Forms.RadioButton radFromCM;
        private System.Windows.Forms.RadioButton radFromInches;
        private System.Windows.Forms.RadioButton radFromFeet;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox grpHeightConverter;
        private System.Windows.Forms.RadioButton radfromMeters;
        private System.Windows.Forms.Label lblHeightFrom;
        private System.Windows.Forms.Label lblHeightTo;
        private System.Windows.Forms.GroupBox grpHeightConvertTo;
        private System.Windows.Forms.RadioButton radToMeters;
        private System.Windows.Forms.RadioButton radToCM;
        private System.Windows.Forms.RadioButton radToInches;
        private System.Windows.Forms.RadioButton radToFeet;
        private System.Windows.Forms.RadioButton radToHH;
    }
}

