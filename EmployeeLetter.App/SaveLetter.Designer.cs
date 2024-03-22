namespace EmployeeLetter.App
{
    partial class SaveLetter
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
            SaveButton = new Button();
            Header = new Panel();
            Content = new TextBox();
            ContentLabel = new Label();
            SenderLabel = new Label();
            Sender = new TextBox();
            Recipient = new TextBox();
            RecipientLabel = new Label();
            Title = new TextBox();
            TitleLabel = new Label();
            Header2 = new Label();
            Header.SuspendLayout();
            SuspendLayout();
            // 
            // SaveButton
            // 
            SaveButton.BackColor = Color.AliceBlue;
            SaveButton.Cursor = Cursors.Hand;
            SaveButton.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            SaveButton.Location = new Point(204, 475);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(120, 40);
            SaveButton.TabIndex = 0;
            SaveButton.Text = "Отправить";
            SaveButton.UseVisualStyleBackColor = false;
            SaveButton.Click += SaveButton_Click;
            // 
            // Header
            // 
            Header.BackColor = Color.Teal;
            Header.Controls.Add(SaveButton);
            Header.Controls.Add(Content);
            Header.Controls.Add(ContentLabel);
            Header.Controls.Add(SenderLabel);
            Header.Controls.Add(Sender);
            Header.Controls.Add(Recipient);
            Header.Controls.Add(RecipientLabel);
            Header.Controls.Add(Title);
            Header.Controls.Add(TitleLabel);
            Header.Controls.Add(Header2);
            Header.Dock = DockStyle.Fill;
            Header.Location = new Point(0, 0);
            Header.Name = "Header";
            Header.Size = new Size(529, 531);
            Header.TabIndex = 1;
            // 
            // Content
            // 
            Content.Location = new Point(140, 220);
            Content.Multiline = true;
            Content.Name = "Content";
            Content.Size = new Size(350, 240);
            Content.TabIndex = 9;
            // 
            // ContentLabel
            // 
            ContentLabel.BackColor = Color.FromArgb(224, 224, 224);
            ContentLabel.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ContentLabel.ForeColor = SystemColors.ControlText;
            ContentLabel.Location = new Point(20, 220);
            ContentLabel.Name = "ContentLabel";
            ContentLabel.Size = new Size(110, 25);
            ContentLabel.TabIndex = 8;
            ContentLabel.Text = "Содержание";
            ContentLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // SenderLabel
            // 
            SenderLabel.BackColor = Color.FromArgb(224, 224, 224);
            SenderLabel.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            SenderLabel.ForeColor = SystemColors.ControlText;
            SenderLabel.Location = new Point(20, 180);
            SenderLabel.Name = "SenderLabel";
            SenderLabel.Size = new Size(110, 25);
            SenderLabel.TabIndex = 7;
            SenderLabel.Text = "Отправитель";
            SenderLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Sender
            // 
            Sender.Location = new Point(140, 180);
            Sender.Multiline = true;
            Sender.Name = "Sender";
            Sender.Size = new Size(350, 25);
            Sender.TabIndex = 6;
            // 
            // Recipient
            // 
            Recipient.Location = new Point(140, 140);
            Recipient.Multiline = true;
            Recipient.Name = "Recipient";
            Recipient.Size = new Size(350, 25);
            Recipient.TabIndex = 5;
            // 
            // RecipientLabel
            // 
            RecipientLabel.BackColor = Color.FromArgb(224, 224, 224);
            RecipientLabel.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            RecipientLabel.ForeColor = SystemColors.ControlText;
            RecipientLabel.Location = new Point(20, 140);
            RecipientLabel.Name = "RecipientLabel";
            RecipientLabel.Size = new Size(110, 25);
            RecipientLabel.TabIndex = 4;
            RecipientLabel.Text = "Адресат";
            RecipientLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Title
            // 
            Title.Location = new Point(140, 100);
            Title.Multiline = true;
            Title.Name = "Title";
            Title.Size = new Size(350, 25);
            Title.TabIndex = 3;
            // 
            // TitleLabel
            // 
            TitleLabel.BackColor = Color.FromArgb(224, 224, 224);
            TitleLabel.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TitleLabel.ForeColor = SystemColors.ControlText;
            TitleLabel.Location = new Point(20, 100);
            TitleLabel.Name = "TitleLabel";
            TitleLabel.Size = new Size(110, 25);
            TitleLabel.TabIndex = 2;
            TitleLabel.Text = "Название";
            TitleLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Header2
            // 
            Header2.BackColor = Color.FromArgb(0, 0, 192);
            Header2.Dock = DockStyle.Top;
            Header2.Font = new Font("Comic Sans MS", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            Header2.ForeColor = Color.FromArgb(224, 224, 224);
            Header2.Location = new Point(0, 0);
            Header2.Name = "Header2";
            Header2.Size = new Size(529, 81);
            Header2.TabIndex = 1;
            Header2.Text = "Регистрация входящего письма";
            Header2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // SaveLetter
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(529, 531);
            Controls.Add(Header);
            Name = "SaveLetter";
            Text = "SaveLetter";
            Header.ResumeLayout(false);
            Header.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button SaveButton;
        private Panel Header;
        private Label Header2;
        private Label TitleLabel;
        private Label SenderLabel;
        private TextBox Sender;
        private TextBox Recipient;
        private Label RecipientLabel;
        private TextBox Title;
        private TextBox Content;
        private Label ContentLabel;
    }
}