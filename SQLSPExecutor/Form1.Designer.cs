
namespace SQLSPExecutor
{
    partial class Form1
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
            this.continueToExecuteButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.connectionStringTextBox = new System.Windows.Forms.TextBox();
            this.databaseCombobox = new System.Windows.Forms.ComboBox();
            this.connectionWizzard = new System.Windows.Forms.TabControl();
            this.connectionStringPanel = new System.Windows.Forms.TabPage();
            this.connectButton = new System.Windows.Forms.Button();
            this.databasePanel = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.executePanel = new System.Windows.Forms.TabPage();
            this.resultsView = new System.Windows.Forms.DataGridView();
            this.executeProcedureButton = new System.Windows.Forms.Button();
            this.proceduresComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.connectionWizzard.SuspendLayout();
            this.connectionStringPanel.SuspendLayout();
            this.databasePanel.SuspendLayout();
            this.executePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.resultsView)).BeginInit();
            this.SuspendLayout();
            // 
            // continueToExecuteButton
            // 
            this.continueToExecuteButton.Location = new System.Drawing.Point(709, 38);
            this.continueToExecuteButton.Name = "continueToExecuteButton";
            this.continueToExecuteButton.Size = new System.Drawing.Size(75, 23);
            this.continueToExecuteButton.TabIndex = 0;
            this.continueToExecuteButton.Text = "Continue >";
            this.continueToExecuteButton.UseVisualStyleBackColor = true;
            this.continueToExecuteButton.Click += new System.EventHandler(this.continueToExecution_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Type here the Connection String";
            // 
            // connectionStringTextBox
            // 
            this.connectionStringTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.connectionStringTextBox.Location = new System.Drawing.Point(3, 18);
            this.connectionStringTextBox.Name = "connectionStringTextBox";
            this.connectionStringTextBox.Size = new System.Drawing.Size(700, 23);
            this.connectionStringTextBox.TabIndex = 1;
            // 
            // databaseCombobox
            // 
            this.databaseCombobox.FormattingEnabled = true;
            this.databaseCombobox.Location = new System.Drawing.Point(3, 38);
            this.databaseCombobox.Name = "databaseCombobox";
            this.databaseCombobox.Size = new System.Drawing.Size(700, 23);
            this.databaseCombobox.TabIndex = 2;
            this.databaseCombobox.SelectedIndexChanged += new System.EventHandler(this.databaseCombobox_SelectedIndexChanged);
            // 
            // connectionWizzard
            // 
            this.connectionWizzard.Controls.Add(this.connectionStringPanel);
            this.connectionWizzard.Controls.Add(this.databasePanel);
            this.connectionWizzard.Controls.Add(this.executePanel);
            this.connectionWizzard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.connectionWizzard.Location = new System.Drawing.Point(0, 0);
            this.connectionWizzard.Name = "connectionWizzard";
            this.connectionWizzard.SelectedIndex = 0;
            this.connectionWizzard.Size = new System.Drawing.Size(800, 450);
            this.connectionWizzard.TabIndex = 2;
            this.connectionWizzard.SelectedIndexChanged += new System.EventHandler(this.connectionWizzard_SelectedIndexChanged);
            // 
            // connectionStringPanel
            // 
            this.connectionStringPanel.Controls.Add(this.connectButton);
            this.connectionStringPanel.Controls.Add(this.connectionStringTextBox);
            this.connectionStringPanel.Controls.Add(this.label1);
            this.connectionStringPanel.Location = new System.Drawing.Point(4, 24);
            this.connectionStringPanel.Name = "connectionStringPanel";
            this.connectionStringPanel.Padding = new System.Windows.Forms.Padding(3);
            this.connectionStringPanel.Size = new System.Drawing.Size(792, 422);
            this.connectionStringPanel.TabIndex = 0;
            this.connectionStringPanel.Text = "Connection String";
            this.connectionStringPanel.UseVisualStyleBackColor = true;
            // 
            // connectButton
            // 
            this.connectButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.connectButton.Location = new System.Drawing.Point(709, 18);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(75, 23);
            this.connectButton.TabIndex = 2;
            this.connectButton.Text = "Connect";
            this.connectButton.UseVisualStyleBackColor = true;
            this.connectButton.Click += new System.EventHandler(this.connectButton_Click);
            // 
            // databasePanel
            // 
            this.databasePanel.Controls.Add(this.label2);
            this.databasePanel.Controls.Add(this.databaseCombobox);
            this.databasePanel.Controls.Add(this.continueToExecuteButton);
            this.databasePanel.Location = new System.Drawing.Point(4, 24);
            this.databasePanel.Name = "databasePanel";
            this.databasePanel.Padding = new System.Windows.Forms.Padding(3);
            this.databasePanel.Size = new System.Drawing.Size(792, 422);
            this.databasePanel.TabIndex = 1;
            this.databasePanel.Text = "Database";
            this.databasePanel.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Select a database";
            // 
            // executePanel
            // 
            this.executePanel.Controls.Add(this.resultsView);
            this.executePanel.Controls.Add(this.executeProcedureButton);
            this.executePanel.Controls.Add(this.proceduresComboBox);
            this.executePanel.Controls.Add(this.label3);
            this.executePanel.Location = new System.Drawing.Point(4, 24);
            this.executePanel.Name = "executePanel";
            this.executePanel.Padding = new System.Windows.Forms.Padding(3);
            this.executePanel.Size = new System.Drawing.Size(792, 422);
            this.executePanel.TabIndex = 2;
            this.executePanel.Text = "Execute";
            this.executePanel.UseVisualStyleBackColor = true;
            // 
            // resultsView
            // 
            this.resultsView.AllowUserToAddRows = false;
            this.resultsView.AllowUserToDeleteRows = false;
            this.resultsView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.resultsView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.resultsView.Location = new System.Drawing.Point(8, 57);
            this.resultsView.Name = "resultsView";
            this.resultsView.ReadOnly = true;
            this.resultsView.RowTemplate.Height = 25;
            this.resultsView.Size = new System.Drawing.Size(781, 365);
            this.resultsView.TabIndex = 3;
            // 
            // executeProcedureButton
            // 
            this.executeProcedureButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.executeProcedureButton.Location = new System.Drawing.Point(709, 28);
            this.executeProcedureButton.Name = "executeProcedureButton";
            this.executeProcedureButton.Size = new System.Drawing.Size(75, 23);
            this.executeProcedureButton.TabIndex = 2;
            this.executeProcedureButton.Text = "Execute";
            this.executeProcedureButton.UseVisualStyleBackColor = true;
            this.executeProcedureButton.Click += new System.EventHandler(this.executeProcedureButton_Click);
            // 
            // proceduresComboBox
            // 
            this.proceduresComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.proceduresComboBox.FormattingEnabled = true;
            this.proceduresComboBox.Location = new System.Drawing.Point(8, 28);
            this.proceduresComboBox.Name = "proceduresComboBox";
            this.proceduresComboBox.Size = new System.Drawing.Size(695, 23);
            this.proceduresComboBox.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Select a procedure";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.connectionWizzard);
            this.Name = "Form1";
            this.Text = "Form1";
            this.connectionWizzard.ResumeLayout(false);
            this.connectionStringPanel.ResumeLayout(false);
            this.connectionStringPanel.PerformLayout();
            this.databasePanel.ResumeLayout(false);
            this.databasePanel.PerformLayout();
            this.executePanel.ResumeLayout(false);
            this.executePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.resultsView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button continueToExecuteButton;
        private System.Windows.Forms.ComboBox databaseCombobox;
        private System.Windows.Forms.TextBox connectionStringTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl connectionWizzard;
        private System.Windows.Forms.TabPage connectionStringPanel;
        private System.Windows.Forms.TabPage databasePanel;
        private System.Windows.Forms.Button connectButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage executePanel;
        private System.Windows.Forms.ComboBox proceduresComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button executeProcedureButton;
        private System.Windows.Forms.DataGridView resultsView;
    }
}

