namespace PostmanCloneUI
{
    partial class Dashboard
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
            formHeader = new Label();
            apiLabel = new Label();
            apiTextBox = new TextBox();
            callApi = new Button();
            resultsTextbox = new TextBox();
            statusStrip = new StatusStrip();
            systemStatus = new ToolStripStatusLabel();
            resultsLabel = new Label();
            statusStrip.SuspendLayout();
            SuspendLayout();
            // 
            // formHeader
            // 
            formHeader.AutoSize = true;
            formHeader.Font = new Font("Segoe UI", 20F);
            formHeader.Location = new Point(32, 24);
            formHeader.Name = "formHeader";
            formHeader.Size = new Size(195, 37);
            formHeader.TabIndex = 0;
            formHeader.Text = "Postman Clone";
            // 
            // apiLabel
            // 
            apiLabel.AutoSize = true;
            apiLabel.Font = new Font("Segoe UI", 16F);
            apiLabel.Location = new Point(41, 88);
            apiLabel.Name = "apiLabel";
            apiLabel.Size = new Size(50, 30);
            apiLabel.TabIndex = 1;
            apiLabel.Text = "API:";
            // 
            // apiTextBox
            // 
            apiTextBox.BackColor = Color.White;
            apiTextBox.BorderStyle = BorderStyle.FixedSingle;
            apiTextBox.Location = new Point(92, 85);
            apiTextBox.Name = "apiTextBox";
            apiTextBox.Size = new Size(294, 39);
            apiTextBox.TabIndex = 2;
            // 
            // callApi
            // 
            callApi.Font = new Font("Segoe UI", 16F);
            callApi.Location = new Point(392, 85);
            callApi.Name = "callApi";
            callApi.Size = new Size(98, 39);
            callApi.TabIndex = 3;
            callApi.Text = "Go";
            callApi.UseVisualStyleBackColor = true;
            callApi.Click += callApi_Click;
            // 
            // resultsTextbox
            // 
            resultsTextbox.BackColor = Color.White;
            resultsTextbox.BorderStyle = BorderStyle.FixedSingle;
            resultsTextbox.Location = new Point(41, 171);
            resultsTextbox.Multiline = true;
            resultsTextbox.Name = "resultsTextbox";
            resultsTextbox.ReadOnly = true;
            resultsTextbox.ScrollBars = ScrollBars.Vertical;
            resultsTextbox.Size = new Size(638, 295);
            resultsTextbox.TabIndex = 4;
            // 
            // statusStrip
            // 
            statusStrip.Items.AddRange(new ToolStripItem[] { systemStatus });
            statusStrip.Location = new Point(0, 478);
            statusStrip.Name = "statusStrip";
            statusStrip.Size = new Size(738, 30);
            statusStrip.TabIndex = 5;
            statusStrip.Text = "statusStrip1";
            // 
            // systemStatus
            // 
            systemStatus.Font = new Font("Segoe UI", 14F);
            systemStatus.Name = "systemStatus";
            systemStatus.Size = new Size(62, 25);
            systemStatus.Text = "Ready";
            // 
            // resultsLabel
            // 
            resultsLabel.AutoSize = true;
            resultsLabel.Font = new Font("Segoe UI", 16F);
            resultsLabel.Location = new Point(41, 138);
            resultsLabel.Name = "resultsLabel";
            resultsLabel.Size = new Size(84, 30);
            resultsLabel.TabIndex = 6;
            resultsLabel.Text = "Results:";
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(738, 508);
            Controls.Add(resultsLabel);
            Controls.Add(statusStrip);
            Controls.Add(resultsTextbox);
            Controls.Add(callApi);
            Controls.Add(apiTextBox);
            Controls.Add(apiLabel);
            Controls.Add(formHeader);
            Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(6);
            Name = "Dashboard";
            Text = "Postman Clone";
            statusStrip.ResumeLayout(false);
            statusStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label formHeader;
        private Label apiLabel;
        private TextBox apiTextBox;
        private Button callApi;
        private TextBox resultsTextbox;
        private StatusStrip statusStrip;
        private Label resultsLabel;
        private ToolStripStatusLabel systemStatus;
    }
}
