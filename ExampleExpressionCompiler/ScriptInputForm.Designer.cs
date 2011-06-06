namespace ExampleExpressionCompiler
{
    partial class ScriptInputForm
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
            this.EvaluateCommand = new System.Windows.Forms.Button();
            this.ScriptInput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // EvaluateCommand
            // 
            this.EvaluateCommand.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.EvaluateCommand.Location = new System.Drawing.Point(12, 250);
            this.EvaluateCommand.Name = "EvaluateCommand";
            this.EvaluateCommand.Size = new System.Drawing.Size(501, 28);
            this.EvaluateCommand.TabIndex = 3;
            this.EvaluateCommand.Text = "Evaluate!";
            this.EvaluateCommand.UseVisualStyleBackColor = true;
            this.EvaluateCommand.Click += new System.EventHandler(this.EvaluateCommand_Click);
            // 
            // ScriptInput
            // 
            this.ScriptInput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.ScriptInput.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScriptInput.Location = new System.Drawing.Point(12, 12);
            this.ScriptInput.Multiline = true;
            this.ScriptInput.Name = "ScriptInput";
            this.ScriptInput.Size = new System.Drawing.Size(501, 243);
            this.ScriptInput.TabIndex = 2;
            this.ScriptInput.Text = "(-b + Math.Sqrt(b**2 - 4 * a * c)) / 2";
            // 
            // ScriptInputForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 290);
            this.Controls.Add(this.EvaluateCommand);
            this.Controls.Add(this.ScriptInput);
            this.Name = "ScriptInputForm";
            this.Text = "Script Input";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button EvaluateCommand;
        private System.Windows.Forms.TextBox ScriptInput;
    }
}

