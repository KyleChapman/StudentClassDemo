
namespace StudentClassDemo
{
    partial class formStudentForm
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
            this.components = new System.ComponentModel.Container();
            this.labelStudentOnePrompt = new System.Windows.Forms.Label();
            this.textBoxStudentOneNameInput = new System.Windows.Forms.TextBox();
            this.labelStudentTwoPrompt = new System.Windows.Forms.Label();
            this.textBoxStudentTwoNameInput = new System.Windows.Forms.TextBox();
            this.buttonEnter = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.groupBoxStudentOne = new System.Windows.Forms.GroupBox();
            this.groupBoxStudentTwo = new System.Windows.Forms.GroupBox();
            this.labelStudentOneNamePrompt = new System.Windows.Forms.Label();
            this.textBoxStudentOneNameOutput = new System.Windows.Forms.TextBox();
            this.labelStudentOneCountPrompt = new System.Windows.Forms.Label();
            this.textBoxStudentOneCountOutput = new System.Windows.Forms.TextBox();
            this.labelStudentOneDataPrompt = new System.Windows.Forms.Label();
            this.textBoxStudentOneDataOutput = new System.Windows.Forms.TextBox();
            this.labelStudentTwoNamePrompt = new System.Windows.Forms.Label();
            this.textBoxStudentTwoNameOutput = new System.Windows.Forms.TextBox();
            this.labelStudentTwoCountPrompt = new System.Windows.Forms.Label();
            this.textBoxStudentTwoCountOutput = new System.Windows.Forms.TextBox();
            this.labelStudentTwoDataPrompt = new System.Windows.Forms.Label();
            this.textBoxStudentTwoDataOutput = new System.Windows.Forms.TextBox();
            this.toolTipForStudents = new System.Windows.Forms.ToolTip(this.components);
            this.groupBoxStudentOne.SuspendLayout();
            this.groupBoxStudentTwo.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelStudentOnePrompt
            // 
            this.labelStudentOnePrompt.Location = new System.Drawing.Point(27, 13);
            this.labelStudentOnePrompt.Name = "labelStudentOnePrompt";
            this.labelStudentOnePrompt.Size = new System.Drawing.Size(202, 25);
            this.labelStudentOnePrompt.TabIndex = 0;
            this.labelStudentOnePrompt.Text = "Student &One Name:";
            this.labelStudentOnePrompt.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBoxStudentOneNameInput
            // 
            this.textBoxStudentOneNameInput.Location = new System.Drawing.Point(235, 13);
            this.textBoxStudentOneNameInput.Name = "textBoxStudentOneNameInput";
            this.textBoxStudentOneNameInput.Size = new System.Drawing.Size(410, 27);
            this.textBoxStudentOneNameInput.TabIndex = 1;
            this.toolTipForStudents.SetToolTip(this.textBoxStudentOneNameInput, "Enter a name for student one");
            // 
            // labelStudentTwoPrompt
            // 
            this.labelStudentTwoPrompt.Location = new System.Drawing.Point(27, 52);
            this.labelStudentTwoPrompt.Name = "labelStudentTwoPrompt";
            this.labelStudentTwoPrompt.Size = new System.Drawing.Size(202, 25);
            this.labelStudentTwoPrompt.TabIndex = 2;
            this.labelStudentTwoPrompt.Text = "Student &Two Name:";
            this.labelStudentTwoPrompt.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBoxStudentTwoNameInput
            // 
            this.textBoxStudentTwoNameInput.Location = new System.Drawing.Point(235, 50);
            this.textBoxStudentTwoNameInput.Name = "textBoxStudentTwoNameInput";
            this.textBoxStudentTwoNameInput.Size = new System.Drawing.Size(410, 27);
            this.textBoxStudentTwoNameInput.TabIndex = 3;
            this.toolTipForStudents.SetToolTip(this.textBoxStudentTwoNameInput, "Enter a name for student two");
            // 
            // buttonEnter
            // 
            this.buttonEnter.Location = new System.Drawing.Point(16, 92);
            this.buttonEnter.Name = "buttonEnter";
            this.buttonEnter.Size = new System.Drawing.Size(94, 29);
            this.buttonEnter.TabIndex = 4;
            this.buttonEnter.Text = "&Enter";
            this.toolTipForStudents.SetToolTip(this.buttonEnter, "Click the record the entered students");
            this.buttonEnter.UseVisualStyleBackColor = true;
            this.buttonEnter.Click += new System.EventHandler(this.ButtonEnterClick);
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(294, 92);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(94, 29);
            this.buttonReset.TabIndex = 5;
            this.buttonReset.Text = "&Reset";
            this.toolTipForStudents.SetToolTip(this.buttonReset, "Click to reset this form to its default state");
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.ButtonResetClick);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(572, 92);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(94, 29);
            this.buttonExit.TabIndex = 6;
            this.buttonExit.Text = "E&xit";
            this.toolTipForStudents.SetToolTip(this.buttonExit, "Click to exit the application");
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.ButtonExitClick);
            // 
            // groupBoxStudentOne
            // 
            this.groupBoxStudentOne.Controls.Add(this.textBoxStudentOneDataOutput);
            this.groupBoxStudentOne.Controls.Add(this.labelStudentOneDataPrompt);
            this.groupBoxStudentOne.Controls.Add(this.textBoxStudentOneCountOutput);
            this.groupBoxStudentOne.Controls.Add(this.labelStudentOneCountPrompt);
            this.groupBoxStudentOne.Controls.Add(this.textBoxStudentOneNameOutput);
            this.groupBoxStudentOne.Controls.Add(this.labelStudentOneNamePrompt);
            this.groupBoxStudentOne.Location = new System.Drawing.Point(16, 136);
            this.groupBoxStudentOne.Name = "groupBoxStudentOne";
            this.groupBoxStudentOne.Size = new System.Drawing.Size(650, 150);
            this.groupBoxStudentOne.TabIndex = 7;
            this.groupBoxStudentOne.TabStop = false;
            this.groupBoxStudentOne.Text = "Student One Output:";
            // 
            // groupBoxStudentTwo
            // 
            this.groupBoxStudentTwo.Controls.Add(this.textBoxStudentTwoDataOutput);
            this.groupBoxStudentTwo.Controls.Add(this.labelStudentTwoDataPrompt);
            this.groupBoxStudentTwo.Controls.Add(this.textBoxStudentTwoCountOutput);
            this.groupBoxStudentTwo.Controls.Add(this.labelStudentTwoCountPrompt);
            this.groupBoxStudentTwo.Controls.Add(this.textBoxStudentTwoNameOutput);
            this.groupBoxStudentTwo.Controls.Add(this.labelStudentTwoNamePrompt);
            this.groupBoxStudentTwo.Location = new System.Drawing.Point(16, 289);
            this.groupBoxStudentTwo.Name = "groupBoxStudentTwo";
            this.groupBoxStudentTwo.Size = new System.Drawing.Size(650, 150);
            this.groupBoxStudentTwo.TabIndex = 8;
            this.groupBoxStudentTwo.TabStop = false;
            this.groupBoxStudentTwo.Text = "Student Two Output:";
            // 
            // labelStudentOneNamePrompt
            // 
            this.labelStudentOneNamePrompt.Location = new System.Drawing.Point(10, 25);
            this.labelStudentOneNamePrompt.Name = "labelStudentOneNamePrompt";
            this.labelStudentOneNamePrompt.Size = new System.Drawing.Size(203, 25);
            this.labelStudentOneNamePrompt.TabIndex = 0;
            this.labelStudentOneNamePrompt.Text = "Name (Property):";
            this.labelStudentOneNamePrompt.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBoxStudentOneNameOutput
            // 
            this.textBoxStudentOneNameOutput.Location = new System.Drawing.Point(219, 24);
            this.textBoxStudentOneNameOutput.Name = "textBoxStudentOneNameOutput";
            this.textBoxStudentOneNameOutput.ReadOnly = true;
            this.textBoxStudentOneNameOutput.Size = new System.Drawing.Size(410, 27);
            this.textBoxStudentOneNameOutput.TabIndex = 1;
            this.toolTipForStudents.SetToolTip(this.textBoxStudentOneNameOutput, "Displays the name for student one, based on the Name property");
            // 
            // labelStudentOneCountPrompt
            // 
            this.labelStudentOneCountPrompt.Location = new System.Drawing.Point(10, 62);
            this.labelStudentOneCountPrompt.Name = "labelStudentOneCountPrompt";
            this.labelStudentOneCountPrompt.Size = new System.Drawing.Size(203, 25);
            this.labelStudentOneCountPrompt.TabIndex = 2;
            this.labelStudentOneCountPrompt.Text = "Count (Property):";
            this.labelStudentOneCountPrompt.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBoxStudentOneCountOutput
            // 
            this.textBoxStudentOneCountOutput.Location = new System.Drawing.Point(219, 61);
            this.textBoxStudentOneCountOutput.Name = "textBoxStudentOneCountOutput";
            this.textBoxStudentOneCountOutput.ReadOnly = true;
            this.textBoxStudentOneCountOutput.Size = new System.Drawing.Size(410, 27);
            this.textBoxStudentOneCountOutput.TabIndex = 3;
            this.toolTipForStudents.SetToolTip(this.textBoxStudentOneCountOutput, "Displays the count for student one, based on the Count property");
            // 
            // labelStudentOneDataPrompt
            // 
            this.labelStudentOneDataPrompt.Location = new System.Drawing.Point(10, 99);
            this.labelStudentOneDataPrompt.Name = "labelStudentOneDataPrompt";
            this.labelStudentOneDataPrompt.Size = new System.Drawing.Size(203, 25);
            this.labelStudentOneDataPrompt.TabIndex = 4;
            this.labelStudentOneDataPrompt.Text = "GetStudentData (Method):";
            this.labelStudentOneDataPrompt.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBoxStudentOneDataOutput
            // 
            this.textBoxStudentOneDataOutput.Location = new System.Drawing.Point(219, 98);
            this.textBoxStudentOneDataOutput.Name = "textBoxStudentOneDataOutput";
            this.textBoxStudentOneDataOutput.ReadOnly = true;
            this.textBoxStudentOneDataOutput.Size = new System.Drawing.Size(410, 27);
            this.textBoxStudentOneDataOutput.TabIndex = 5;
            this.toolTipForStudents.SetToolTip(this.textBoxStudentOneDataOutput, "Displays the result of student one\'s GetStudentData method");
            // 
            // labelStudentTwoNamePrompt
            // 
            this.labelStudentTwoNamePrompt.Location = new System.Drawing.Point(10, 25);
            this.labelStudentTwoNamePrompt.Name = "labelStudentTwoNamePrompt";
            this.labelStudentTwoNamePrompt.Size = new System.Drawing.Size(203, 25);
            this.labelStudentTwoNamePrompt.TabIndex = 0;
            this.labelStudentTwoNamePrompt.Text = "Name (Property):";
            this.labelStudentTwoNamePrompt.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBoxStudentTwoNameOutput
            // 
            this.textBoxStudentTwoNameOutput.Location = new System.Drawing.Point(219, 24);
            this.textBoxStudentTwoNameOutput.Name = "textBoxStudentTwoNameOutput";
            this.textBoxStudentTwoNameOutput.ReadOnly = true;
            this.textBoxStudentTwoNameOutput.Size = new System.Drawing.Size(410, 27);
            this.textBoxStudentTwoNameOutput.TabIndex = 1;
            this.toolTipForStudents.SetToolTip(this.textBoxStudentTwoNameOutput, "Displays the name for student two, based on the Name property");
            // 
            // labelStudentTwoCountPrompt
            // 
            this.labelStudentTwoCountPrompt.Location = new System.Drawing.Point(10, 62);
            this.labelStudentTwoCountPrompt.Name = "labelStudentTwoCountPrompt";
            this.labelStudentTwoCountPrompt.Size = new System.Drawing.Size(203, 25);
            this.labelStudentTwoCountPrompt.TabIndex = 2;
            this.labelStudentTwoCountPrompt.Text = "Count (Property):";
            this.labelStudentTwoCountPrompt.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBoxStudentTwoCountOutput
            // 
            this.textBoxStudentTwoCountOutput.Location = new System.Drawing.Point(219, 61);
            this.textBoxStudentTwoCountOutput.Name = "textBoxStudentTwoCountOutput";
            this.textBoxStudentTwoCountOutput.ReadOnly = true;
            this.textBoxStudentTwoCountOutput.Size = new System.Drawing.Size(410, 27);
            this.textBoxStudentTwoCountOutput.TabIndex = 3;
            this.toolTipForStudents.SetToolTip(this.textBoxStudentTwoCountOutput, "Displays the count for student two, based on the Count property");
            // 
            // labelStudentTwoDataPrompt
            // 
            this.labelStudentTwoDataPrompt.Location = new System.Drawing.Point(10, 99);
            this.labelStudentTwoDataPrompt.Name = "labelStudentTwoDataPrompt";
            this.labelStudentTwoDataPrompt.Size = new System.Drawing.Size(203, 25);
            this.labelStudentTwoDataPrompt.TabIndex = 4;
            this.labelStudentTwoDataPrompt.Text = "GetStudentData (Method):";
            this.labelStudentTwoDataPrompt.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBoxStudentTwoDataOutput
            // 
            this.textBoxStudentTwoDataOutput.Location = new System.Drawing.Point(219, 98);
            this.textBoxStudentTwoDataOutput.Name = "textBoxStudentTwoDataOutput";
            this.textBoxStudentTwoDataOutput.ReadOnly = true;
            this.textBoxStudentTwoDataOutput.Size = new System.Drawing.Size(410, 27);
            this.textBoxStudentTwoDataOutput.TabIndex = 5;
            this.toolTipForStudents.SetToolTip(this.textBoxStudentTwoDataOutput, "Displays the result of student two\'s GetStudentData method");
            // 
            // formStudentForm
            // 
            this.AcceptButton = this.buttonEnter;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonReset;
            this.ClientSize = new System.Drawing.Size(682, 453);
            this.Controls.Add(this.groupBoxStudentTwo);
            this.Controls.Add(this.groupBoxStudentOne);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.buttonEnter);
            this.Controls.Add(this.textBoxStudentTwoNameInput);
            this.Controls.Add(this.labelStudentTwoPrompt);
            this.Controls.Add(this.textBoxStudentOneNameInput);
            this.Controls.Add(this.labelStudentOnePrompt);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(700, 500);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(700, 500);
            this.Name = "formStudentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student Demo";
            this.groupBoxStudentOne.ResumeLayout(false);
            this.groupBoxStudentOne.PerformLayout();
            this.groupBoxStudentTwo.ResumeLayout(false);
            this.groupBoxStudentTwo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelStudentOnePrompt;
        private System.Windows.Forms.TextBox textBoxStudentOneNameInput;
        private System.Windows.Forms.Label labelStudentTwoPrompt;
        private System.Windows.Forms.TextBox textBoxStudentTwoNameInput;
        private System.Windows.Forms.Button buttonEnter;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.GroupBox groupBoxStudentOne;
        private System.Windows.Forms.TextBox textBoxStudentOneDataOutput;
        private System.Windows.Forms.Label labelStudentOneDataPrompt;
        private System.Windows.Forms.TextBox textBoxStudentOneCountOutput;
        private System.Windows.Forms.Label labelStudentOneCountPrompt;
        private System.Windows.Forms.TextBox textBoxStudentOneNameOutput;
        private System.Windows.Forms.Label labelStudentOneNamePrompt;
        private System.Windows.Forms.GroupBox groupBoxStudentTwo;
        private System.Windows.Forms.TextBox textBoxStudentTwoDataOutput;
        private System.Windows.Forms.Label labelStudentTwoDataPrompt;
        private System.Windows.Forms.TextBox textBoxStudentTwoCountOutput;
        private System.Windows.Forms.Label labelStudentTwoCountPrompt;
        private System.Windows.Forms.TextBox textBoxStudentTwoNameOutput;
        private System.Windows.Forms.Label labelStudentTwoNamePrompt;
        private System.Windows.Forms.ToolTip toolTipForStudents;
    }
}

