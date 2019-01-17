namespace addon_sample1
{
    partial class ItemEditorForm
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
            this.label3 = new System.Windows.Forms.Label();
            this.button_select = new System.Windows.Forms.Button();
            this.textBox_method = new System.Windows.Forms.TextBox();
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.textBoxPageHelp = new System.Windows.Forms.TextBox();
            this.tabPageHelp = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxRef = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxPageComment = new System.Windows.Forms.TextBox();
            this.tabPageComment = new System.Windows.Forms.TabPage();
            this.groupBoxRef = new System.Windows.Forms.GroupBox();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.cancel_button = new System.Windows.Forms.Button();
            this.ok_button = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tabPageHelp.SuspendLayout();
            this.tabPageComment.SuspendLayout();
            this.groupBoxRef.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(60, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 16);
            this.label3.TabIndex = 17;
            this.label3.Text = "clear";
            // 
            // button_select
            // 
            this.button_select.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_select.Location = new System.Drawing.Point(601, 81);
            this.button_select.Margin = new System.Windows.Forms.Padding(4);
            this.button_select.Name = "button_select";
            this.button_select.Size = new System.Drawing.Size(135, 31);
            this.button_select.TabIndex = 15;
            this.button_select.Text = "SELECT";
            this.button_select.UseVisualStyleBackColor = true;
            // 
            // textBox_method
            // 
            this.textBox_method.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_method.Location = new System.Drawing.Point(600, 119);
            this.textBox_method.Multiline = true;
            this.textBox_method.Name = "textBox_method";
            this.textBox_method.ReadOnly = true;
            this.textBox_method.Size = new System.Drawing.Size(137, 232);
            this.textBox_method.TabIndex = 14;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            // 
            // textBoxPageHelp
            // 
            this.textBoxPageHelp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxPageHelp.Location = new System.Drawing.Point(6, 10);
            this.textBoxPageHelp.Multiline = true;
            this.textBoxPageHelp.Name = "textBoxPageHelp";
            this.textBoxPageHelp.ReadOnly = true;
            this.textBoxPageHelp.Size = new System.Drawing.Size(566, 148);
            this.textBoxPageHelp.TabIndex = 0;
            // 
            // tabPageHelp
            // 
            this.tabPageHelp.Controls.Add(this.textBoxPageHelp);
            this.tabPageHelp.Location = new System.Drawing.Point(4, 22);
            this.tabPageHelp.Name = "tabPageHelp";
            this.tabPageHelp.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageHelp.Size = new System.Drawing.Size(578, 161);
            this.tabPageHelp.TabIndex = 1;
            this.tabPageHelp.Text = "Help";
            this.tabPageHelp.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 12);
            this.label2.TabIndex = 16;
            this.label2.Text = "Value";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(462, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "OPEN";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBoxRef
            // 
            this.textBoxRef.Location = new System.Drawing.Point(40, 14);
            this.textBoxRef.Name = "textBoxRef";
            this.textBoxRef.Size = new System.Drawing.Size(416, 19);
            this.textBoxRef.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "ref";
            // 
            // textBoxPageComment
            // 
            this.textBoxPageComment.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxPageComment.Enabled = false;
            this.textBoxPageComment.Location = new System.Drawing.Point(3, 8);
            this.textBoxPageComment.Multiline = true;
            this.textBoxPageComment.Name = "textBoxPageComment";
            this.textBoxPageComment.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxPageComment.Size = new System.Drawing.Size(569, 116);
            this.textBoxPageComment.TabIndex = 0;
            // 
            // tabPageComment
            // 
            this.tabPageComment.Controls.Add(this.label1);
            this.tabPageComment.Controls.Add(this.textBoxPageComment);
            this.tabPageComment.Controls.Add(this.groupBoxRef);
            this.tabPageComment.Location = new System.Drawing.Point(4, 22);
            this.tabPageComment.Name = "tabPageComment";
            this.tabPageComment.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageComment.Size = new System.Drawing.Size(578, 161);
            this.tabPageComment.TabIndex = 0;
            this.tabPageComment.Text = "Comment";
            this.tabPageComment.UseVisualStyleBackColor = true;
            // 
            // groupBoxRef
            // 
            this.groupBoxRef.Controls.Add(this.button1);
            this.groupBoxRef.Controls.Add(this.textBoxRef);
            this.groupBoxRef.Enabled = false;
            this.groupBoxRef.Location = new System.Drawing.Point(4, 113);
            this.groupBoxRef.Name = "groupBoxRef";
            this.groupBoxRef.Size = new System.Drawing.Size(544, 43);
            this.groupBoxRef.TabIndex = 4;
            this.groupBoxRef.TabStop = false;
            // 
            // tabControl
            // 
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.Controls.Add(this.tabPageComment);
            this.tabControl.Controls.Add(this.tabPageHelp);
            this.tabControl.Location = new System.Drawing.Point(8, 168);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(586, 187);
            this.tabControl.TabIndex = 13;
            // 
            // cancel_button
            // 
            this.cancel_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cancel_button.Location = new System.Drawing.Point(601, 42);
            this.cancel_button.Margin = new System.Windows.Forms.Padding(4);
            this.cancel_button.Name = "cancel_button";
            this.cancel_button.Size = new System.Drawing.Size(135, 31);
            this.cancel_button.TabIndex = 12;
            this.cancel_button.Text = "CANCEL";
            this.cancel_button.UseVisualStyleBackColor = true;
            // 
            // ok_button
            // 
            this.ok_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ok_button.Location = new System.Drawing.Point(601, 3);
            this.ok_button.Margin = new System.Windows.Forms.Padding(4);
            this.ok_button.Name = "ok_button";
            this.ok_button.Size = new System.Drawing.Size(135, 31);
            this.ok_button.TabIndex = 11;
            this.ok_button.Text = "OK";
            this.ok_button.UseVisualStyleBackColor = true;
            this.ok_button.Click += new System.EventHandler(this.ok_button_Click);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox1.Location = new System.Drawing.Point(8, 23);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox1.Size = new System.Drawing.Size(582, 138);
            this.textBox1.TabIndex = 10;
            this.textBox1.WordWrap = false;
            // 
            // ItemEditorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 359);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button_select);
            this.Controls.Add(this.textBox_method);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.cancel_button);
            this.Controls.Add(this.ok_button);
            this.Controls.Add(this.textBox1);
            this.Name = "ItemEditorForm";
            this.Text = "ItemEditorForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ItemEditorForm_FormClosing);
            this.tabPageHelp.ResumeLayout(false);
            this.tabPageHelp.PerformLayout();
            this.tabPageComment.ResumeLayout(false);
            this.tabPageComment.PerformLayout();
            this.groupBoxRef.ResumeLayout(false);
            this.groupBoxRef.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button_select;
        private System.Windows.Forms.TextBox textBox_method;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox textBoxPageHelp;
        private System.Windows.Forms.TabPage tabPageHelp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxRef;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxPageComment;
        private System.Windows.Forms.TabPage tabPageComment;
        private System.Windows.Forms.GroupBox groupBoxRef;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.Button cancel_button;
        private System.Windows.Forms.Button ok_button;
        public System.Windows.Forms.TextBox textBox1;
    }
}