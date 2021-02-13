
namespace WindowsFormsApp1
{
    partial class Form1
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
            this.userFirstNameText = new System.Windows.Forms.TextBox();
            this.userLastNameText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.maleRadioButton = new System.Windows.Forms.RadioButton();
            this.femaleRadioButton = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.birthDateTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.createUser_button = new System.Windows.Forms.Button();
            this.outputBox = new System.Windows.Forms.RichTextBox();
            this.loadNextForm = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // userFirstNameText
            // 
            this.userFirstNameText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userFirstNameText.Location = new System.Drawing.Point(84, 98);
            this.userFirstNameText.Margin = new System.Windows.Forms.Padding(4);
            this.userFirstNameText.Name = "userFirstNameText";
            this.userFirstNameText.Size = new System.Drawing.Size(166, 27);
            this.userFirstNameText.TabIndex = 0;
            // 
            // userLastNameText
            // 
            this.userLastNameText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userLastNameText.Location = new System.Drawing.Point(295, 98);
            this.userLastNameText.Margin = new System.Windows.Forms.Padding(4);
            this.userLastNameText.Name = "userLastNameText";
            this.userLastNameText.Size = new System.Drawing.Size(177, 27);
            this.userLastNameText.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(82, 74);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "First Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(292, 74);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Last Name:";
            // 
            // maleRadioButton
            // 
            this.maleRadioButton.AutoSize = true;
            this.maleRadioButton.Location = new System.Drawing.Point(85, 167);
            this.maleRadioButton.Margin = new System.Windows.Forms.Padding(4);
            this.maleRadioButton.Name = "maleRadioButton";
            this.maleRadioButton.Size = new System.Drawing.Size(61, 22);
            this.maleRadioButton.TabIndex = 4;
            this.maleRadioButton.TabStop = true;
            this.maleRadioButton.Text = "Male";
            this.maleRadioButton.UseVisualStyleBackColor = true;
            // 
            // femaleRadioButton
            // 
            this.femaleRadioButton.AutoSize = true;
            this.femaleRadioButton.Location = new System.Drawing.Point(173, 167);
            this.femaleRadioButton.Margin = new System.Windows.Forms.Padding(4);
            this.femaleRadioButton.Name = "femaleRadioButton";
            this.femaleRadioButton.Size = new System.Drawing.Size(78, 22);
            this.femaleRadioButton.TabIndex = 5;
            this.femaleRadioButton.TabStop = true;
            this.femaleRadioButton.Text = "Female";
            this.femaleRadioButton.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(670, 363);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 18);
            this.label3.TabIndex = 6;
            // 
            // birthDateTextBox
            // 
            this.birthDateTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.birthDateTextBox.Location = new System.Drawing.Point(84, 236);
            this.birthDateTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.birthDateTextBox.Name = "birthDateTextBox";
            this.birthDateTextBox.Size = new System.Drawing.Size(166, 27);
            this.birthDateTextBox.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(81, 214);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(163, 18);
            this.label4.TabIndex = 8;
            this.label4.Text = "Birthday (MMDDYYYY):";
            // 
            // createUser_button
            // 
            this.createUser_button.Location = new System.Drawing.Point(295, 227);
            this.createUser_button.Margin = new System.Windows.Forms.Padding(4);
            this.createUser_button.Name = "createUser_button";
            this.createUser_button.Size = new System.Drawing.Size(109, 44);
            this.createUser_button.TabIndex = 9;
            this.createUser_button.Text = "Create User";
            this.createUser_button.UseVisualStyleBackColor = true;
            this.createUser_button.Click += new System.EventHandler(this.createUser_button_Click);
            // 
            // outputBox
            // 
            this.outputBox.Location = new System.Drawing.Point(84, 325);
            this.outputBox.Margin = new System.Windows.Forms.Padding(4);
            this.outputBox.Name = "outputBox";
            this.outputBox.Size = new System.Drawing.Size(387, 122);
            this.outputBox.TabIndex = 10;
            this.outputBox.Text = "";
            // 
            // loadNextForm
            // 
            this.loadNextForm.Location = new System.Drawing.Point(539, 406);
            this.loadNextForm.Margin = new System.Windows.Forms.Padding(4);
            this.loadNextForm.Name = "loadNextForm";
            this.loadNextForm.Size = new System.Drawing.Size(148, 41);
            this.loadNextForm.TabIndex = 11;
            this.loadNextForm.Text = "Next Page";
            this.loadNextForm.UseVisualStyleBackColor = true;
            this.loadNextForm.Click += new System.EventHandler(this.loadNextForm_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(199, 10);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(229, 32);
            this.label5.TabIndex = 12;
            this.label5.Text = "Create New User";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 481);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.loadNextForm);
            this.Controls.Add(this.outputBox);
            this.Controls.Add(this.createUser_button);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.birthDateTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.femaleRadioButton);
            this.Controls.Add(this.maleRadioButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.userLastNameText);
            this.Controls.Add(this.userFirstNameText);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox userFirstNameText;
        private System.Windows.Forms.TextBox userLastNameText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton maleRadioButton;
        private System.Windows.Forms.RadioButton femaleRadioButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox birthDateTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button createUser_button;
        private System.Windows.Forms.RichTextBox outputBox;
        private System.Windows.Forms.Button loadNextForm;
        private System.Windows.Forms.Label label5;
    }
}

