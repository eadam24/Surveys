namespace Surveys
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
            Countries = new ComboBox();
            Cities = new ComboBox();
            label1 = new Label();
            eveningButton = new RadioButton();
            afternoonButton = new RadioButton();
            morningButton = new RadioButton();
            submitButton = new Button();
            chosenHobbies = new ListBox();
            listBox1 = new ListBox();
            button_right = new Button();
            button_left = new Button();
            Guitar = new CheckBox();
            Piano = new CheckBox();
            Gym = new CheckBox();
            Dancing = new CheckBox();
            Hiking = new CheckBox();
            groupBox1 = new GroupBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // Countries
            // 
            Countries.FormattingEnabled = true;
            Countries.Items.AddRange(new object[] { "Bulgaria", "Germany", "Austria" });
            Countries.Location = new Point(8, 34);
            Countries.Name = "Countries";
            Countries.Size = new Size(182, 33);
            Countries.TabIndex = 1;
            Countries.Text = "Countries";
            Countries.SelectedIndexChanged += Countries_SelectedIndexChanged;
            // 
            // Cities
            // 
            Cities.FormattingEnabled = true;
            Cities.Location = new Point(200, 34);
            Cities.Name = "Cities";
            Cities.Size = new Size(182, 33);
            Cities.TabIndex = 2;
            Cities.Text = "Cities";
            Cities.SelectedIndexChanged += Cities_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(8, 118);
            label1.Name = "label1";
            label1.Size = new Size(56, 25);
            label1.TabIndex = 3;
            label1.Text = "Time";
            // 
            // eveningButton
            // 
            eveningButton.AutoSize = true;
            eveningButton.Location = new Point(12, 216);
            eveningButton.Name = "eveningButton";
            eveningButton.Size = new Size(99, 29);
            eveningButton.TabIndex = 4;
            eveningButton.TabStop = true;
            eveningButton.Text = "Evening";
            eveningButton.UseVisualStyleBackColor = true;
            eveningButton.CheckedChanged += eveningButton_CheckedChanged;
            // 
            // afternoonButton
            // 
            afternoonButton.AutoSize = true;
            afternoonButton.Location = new Point(12, 181);
            afternoonButton.Name = "afternoonButton";
            afternoonButton.Size = new Size(118, 29);
            afternoonButton.TabIndex = 5;
            afternoonButton.TabStop = true;
            afternoonButton.Text = "Afternoon";
            afternoonButton.UseVisualStyleBackColor = true;
            afternoonButton.CheckedChanged += afternoonButton_CheckedChanged;
            // 
            // morningButton
            // 
            morningButton.AutoSize = true;
            morningButton.Location = new Point(12, 146);
            morningButton.Name = "morningButton";
            morningButton.Size = new Size(105, 29);
            morningButton.TabIndex = 6;
            morningButton.TabStop = true;
            morningButton.Text = "Morning";
            morningButton.UseVisualStyleBackColor = true;
            morningButton.CheckedChanged += morningButton_CheckedChanged;
            // 
            // submitButton
            // 
            submitButton.Location = new Point(12, 294);
            submitButton.Name = "submitButton";
            submitButton.Size = new Size(112, 34);
            submitButton.TabIndex = 9;
            submitButton.Text = "Submit";
            submitButton.UseVisualStyleBackColor = true;
            submitButton.Click += submitButton_Click;
            // 
            // chosenHobbies
            // 
            chosenHobbies.FormattingEnabled = true;
            chosenHobbies.ItemHeight = 25;
            chosenHobbies.Location = new Point(280, 277);
            chosenHobbies.Name = "chosenHobbies";
            chosenHobbies.Size = new Size(180, 129);
            chosenHobbies.TabIndex = 10;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 25;
            listBox1.Location = new Point(580, 277);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(180, 129);
            listBox1.TabIndex = 11;
            // 
            // button_right
            // 
            button_right.Location = new Point(466, 294);
            button_right.Name = "button_right";
            button_right.Size = new Size(112, 34);
            button_right.TabIndex = 12;
            button_right.Text = "--->";
            button_right.UseVisualStyleBackColor = true;
            // 
            // button_left
            // 
            button_left.Location = new Point(466, 348);
            button_left.Name = "button_left";
            button_left.Size = new Size(112, 34);
            button_left.TabIndex = 13;
            button_left.Text = "<---";
            button_left.UseVisualStyleBackColor = true;
            // 
            // Guitar
            // 
            Guitar.AutoSize = true;
            Guitar.Location = new Point(18, 40);
            Guitar.Name = "Guitar";
            Guitar.Size = new Size(85, 29);
            Guitar.TabIndex = 14;
            Guitar.Text = "Guitar";
            Guitar.UseVisualStyleBackColor = true;
            Guitar.CheckedChanged += Guitar_CheckedChanged;
            // 
            // Piano
            // 
            Piano.AutoSize = true;
            Piano.Location = new Point(18, 73);
            Piano.Name = "Piano";
            Piano.Size = new Size(82, 29);
            Piano.TabIndex = 15;
            Piano.Text = "Piano";
            Piano.UseVisualStyleBackColor = true;
            Piano.CheckedChanged += Piano_CheckedChanged;
            // 
            // Gym
            // 
            Gym.AutoSize = true;
            Gym.Location = new Point(18, 108);
            Gym.Name = "Gym";
            Gym.Size = new Size(75, 29);
            Gym.TabIndex = 16;
            Gym.Text = "Gym";
            Gym.UseVisualStyleBackColor = true;
            Gym.CheckedChanged += Gym_CheckedChanged;
            // 
            // Dancing
            // 
            Dancing.AutoSize = true;
            Dancing.Location = new Point(18, 143);
            Dancing.Name = "Dancing";
            Dancing.Size = new Size(103, 29);
            Dancing.TabIndex = 17;
            Dancing.Text = "Dancing";
            Dancing.UseVisualStyleBackColor = true;
            Dancing.CheckedChanged += Dancing_CheckedChanged;
            // 
            // Hiking
            // 
            Hiking.AutoSize = true;
            Hiking.Location = new Point(18, 175);
            Hiking.Name = "Hiking";
            Hiking.Size = new Size(89, 29);
            Hiking.TabIndex = 18;
            Hiking.Text = "Hiking";
            Hiking.UseVisualStyleBackColor = true;
            Hiking.CheckedChanged += Hiking_CheckedChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(Guitar);
            groupBox1.Controls.Add(Hiking);
            groupBox1.Controls.Add(Piano);
            groupBox1.Controls.Add(Dancing);
            groupBox1.Controls.Add(Gym);
            groupBox1.Location = new Point(565, 23);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(195, 233);
            groupBox1.TabIndex = 19;
            groupBox1.TabStop = false;
            groupBox1.Text = "Hobbies";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Controls.Add(button_left);
            Controls.Add(button_right);
            Controls.Add(listBox1);
            Controls.Add(chosenHobbies);
            Controls.Add(submitButton);
            Controls.Add(morningButton);
            Controls.Add(afternoonButton);
            Controls.Add(eveningButton);
            Controls.Add(label1);
            Controls.Add(Cities);
            Controls.Add(Countries);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox Countries;
        private ComboBox Cities;
        private Label label1;
        private RadioButton eveningButton;
        private RadioButton afternoonButton;
        private RadioButton morningButton;
        private Button submitButton;
        private ListBox chosenHobbies;
        private ListBox listBox1;
        private Button button_right;
        private Button button_left;
        private CheckBox Guitar;
        private CheckBox Piano;
        private CheckBox Gym;
        private CheckBox Dancing;
        private CheckBox Hiking;
        private GroupBox groupBox1;
    }
}