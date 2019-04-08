namespace Education.UI.usercontrols
{
    partial class Elementcontrol
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ChemicalSymbolLabel = new System.Windows.Forms.Label();
            this.AtomicNumberLabel = new System.Windows.Forms.Label();
            this.MolecularmassLabel = new System.Windows.Forms.Label();
            this.AtomicradiusLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ChemicalSymbolLabel
            // 
            this.ChemicalSymbolLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ChemicalSymbolLabel.AutoSize = true;
            this.ChemicalSymbolLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChemicalSymbolLabel.Location = new System.Drawing.Point(19, 35);
            this.ChemicalSymbolLabel.Name = "ChemicalSymbolLabel";
            this.ChemicalSymbolLabel.Size = new System.Drawing.Size(18, 20);
            this.ChemicalSymbolLabel.TabIndex = 0;
            this.ChemicalSymbolLabel.Text = "h";
            // 
            // AtomicNumberLabel
            // 
            this.AtomicNumberLabel.AutoSize = true;
            this.AtomicNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AtomicNumberLabel.Location = new System.Drawing.Point(3, 9);
            this.AtomicNumberLabel.Name = "AtomicNumberLabel";
            this.AtomicNumberLabel.Size = new System.Drawing.Size(18, 20);
            this.AtomicNumberLabel.TabIndex = 0;
            this.AtomicNumberLabel.Text = "1";
            // 
            // MolecularmassLabel
            // 
            this.MolecularmassLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.MolecularmassLabel.AutoSize = true;
            this.MolecularmassLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MolecularmassLabel.Location = new System.Drawing.Point(3, 63);
            this.MolecularmassLabel.Name = "MolecularmassLabel";
            this.MolecularmassLabel.Size = new System.Drawing.Size(18, 20);
            this.MolecularmassLabel.TabIndex = 0;
            this.MolecularmassLabel.Text = "1";
            // 
            // AtomicradiusLabel
            // 
            this.AtomicradiusLabel.AutoSize = true;
            this.AtomicradiusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AtomicradiusLabel.Location = new System.Drawing.Point(35, 9);
            this.AtomicradiusLabel.Name = "AtomicradiusLabel";
            this.AtomicradiusLabel.Size = new System.Drawing.Size(18, 20);
            this.AtomicradiusLabel.TabIndex = 0;
            this.AtomicradiusLabel.Text = "1";
            // 
            // Elementcontrol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.AtomicradiusLabel);
            this.Controls.Add(this.AtomicNumberLabel);
            this.Controls.Add(this.MolecularmassLabel);
            this.Controls.Add(this.ChemicalSymbolLabel);
            this.Name = "Elementcontrol";
            this.Size = new System.Drawing.Size(56, 87);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ChemicalSymbolLabel;
        private System.Windows.Forms.Label AtomicNumberLabel;
        private System.Windows.Forms.Label MolecularmassLabel;
        private System.Windows.Forms.Label AtomicradiusLabel;
    }
}
