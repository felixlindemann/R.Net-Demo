namespace RHelper
{
    partial class ucRConsole
    {
        /// <summary> 
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Komponenten-Designer generierter Code

        /// <summary> 
        /// Erforderliche Methode für die Designerunterstützung. 
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonClearConsole = new System.Windows.Forms.Button();
            this.buttonLoadRScript = new System.Windows.Forms.Button();
            this.buttonExecManualRCode = new System.Windows.Forms.Button();
            this.textBoxManualRcode = new System.Windows.Forms.TextBox();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.richTextBoxRScript = new System.Windows.Forms.RichTextBox();
            this.checkBoxExecuteLinewise = new System.Windows.Forms.CheckBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBoxExecuteLinewise);
            this.groupBox1.Controls.Add(this.buttonClearConsole);
            this.groupBox1.Controls.Add(this.buttonLoadRScript);
            this.groupBox1.Controls.Add(this.buttonExecManualRCode);
            this.groupBox1.Controls.Add(this.textBoxManualRcode);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(0, 135);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(548, 84);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Execute your Code";
            // 
            // buttonClearConsole
            // 
            this.buttonClearConsole.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClearConsole.Location = new System.Drawing.Point(430, 19);
            this.buttonClearConsole.Name = "buttonClearConsole";
            this.buttonClearConsole.Size = new System.Drawing.Size(112, 23);
            this.buttonClearConsole.TabIndex = 5;
            this.buttonClearConsole.Text = "Clear Console";
            this.buttonClearConsole.UseVisualStyleBackColor = true;
            this.buttonClearConsole.Click += new System.EventHandler(this.buttonClearConsole_Click);
            // 
            // buttonLoadRScript
            // 
            this.buttonLoadRScript.Image = global::RHelper.Properties.Resources.openHS;
            this.buttonLoadRScript.Location = new System.Drawing.Point(6, 19);
            this.buttonLoadRScript.Name = "buttonLoadRScript";
            this.buttonLoadRScript.Size = new System.Drawing.Size(28, 23);
            this.buttonLoadRScript.TabIndex = 3;
            this.toolTip1.SetToolTip(this.buttonLoadRScript, "Open and Execute R");
            this.buttonLoadRScript.UseVisualStyleBackColor = true;
            this.buttonLoadRScript.Click += new System.EventHandler(this.buttonLoadRScript_Click);
            // 
            // buttonExecManualRCode
            // 
            this.buttonExecManualRCode.Image = global::RHelper.Properties.Resources.RIconImg;
            this.buttonExecManualRCode.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonExecManualRCode.Location = new System.Drawing.Point(6, 48);
            this.buttonExecManualRCode.Name = "buttonExecManualRCode";
            this.buttonExecManualRCode.Size = new System.Drawing.Size(28, 23);
            this.buttonExecManualRCode.TabIndex = 1;
            this.buttonExecManualRCode.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.buttonExecManualRCode, "Execute R Code");
            this.buttonExecManualRCode.UseVisualStyleBackColor = true;
            this.buttonExecManualRCode.Click += new System.EventHandler(this.buttonExecManualRCode_Click);
            // 
            // textBoxManualRcode
            // 
            this.textBoxManualRcode.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxManualRcode.BackColor = System.Drawing.Color.White;
            this.textBoxManualRcode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxManualRcode.ForeColor = System.Drawing.Color.MidnightBlue;
            this.textBoxManualRcode.Location = new System.Drawing.Point(40, 22);
            this.textBoxManualRcode.Multiline = true;
            this.textBoxManualRcode.Name = "textBoxManualRcode";
            this.textBoxManualRcode.Size = new System.Drawing.Size(384, 59);
            this.textBoxManualRcode.TabIndex = 2;
            this.textBoxManualRcode.Text = "# write your own code here";
            // 
            // splitter1
            // 
            this.splitter1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitter1.Location = new System.Drawing.Point(0, 132);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(548, 3);
            this.splitter1.TabIndex = 0;
            this.splitter1.TabStop = false;
            // 
            // richTextBoxRScript
            // 
            this.richTextBoxRScript.BackColor = System.Drawing.Color.White;
            this.richTextBoxRScript.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richTextBoxRScript.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBoxRScript.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxRScript.ForeColor = System.Drawing.Color.Red;
            this.richTextBoxRScript.Location = new System.Drawing.Point(0, 0);
            this.richTextBoxRScript.Name = "richTextBoxRScript";
            this.richTextBoxRScript.Size = new System.Drawing.Size(548, 132);
            this.richTextBoxRScript.TabIndex = 16;
            this.richTextBoxRScript.Text = "";
            // 
            // checkBoxExecuteLinewise
            // 
            this.checkBoxExecuteLinewise.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxExecuteLinewise.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxExecuteLinewise.Checked = true;
            this.checkBoxExecuteLinewise.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxExecuteLinewise.Location = new System.Drawing.Point(430, 48);
            this.checkBoxExecuteLinewise.Name = "checkBoxExecuteLinewise";
            this.checkBoxExecuteLinewise.Size = new System.Drawing.Size(112, 24);
            this.checkBoxExecuteLinewise.TabIndex = 6;
            this.checkBoxExecuteLinewise.Text = "Excecute linewise";
            this.toolTip1.SetToolTip(this.checkBoxExecuteLinewise, "deactivate if you want to setup user defined functions!");
            this.checkBoxExecuteLinewise.UseVisualStyleBackColor = true;
            // 
            // ucRConsole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.richTextBoxRScript);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.groupBox1);
            this.Name = "ucRConsole";
            this.Size = new System.Drawing.Size(548, 219);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonExecManualRCode;
        private System.Windows.Forms.Button buttonLoadRScript;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxManualRcode;
        private System.Windows.Forms.Button buttonClearConsole;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.RichTextBox richTextBoxRScript;
        private System.Windows.Forms.CheckBox checkBoxExecuteLinewise;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}
