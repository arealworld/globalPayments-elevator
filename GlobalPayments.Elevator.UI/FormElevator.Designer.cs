
namespace GlobalPayments.Elevator.UI
{
    partial class FormElevator
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn5Down = new System.Windows.Forms.Button();
            this.btn4Down = new System.Windows.Forms.Button();
            this.btn3Down = new System.Windows.Forms.Button();
            this.btn3Up = new System.Windows.Forms.Button();
            this.btn4Up = new System.Windows.Forms.Button();
            this.btn2Down = new System.Windows.Forms.Button();
            this.btn2Up = new System.Windows.Forms.Button();
            this.btn1Up = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnFloor5 = new System.Windows.Forms.Button();
            this.btnFloor4 = new System.Windows.Forms.Button();
            this.btnFloor3 = new System.Windows.Forms.Button();
            this.btnFloor2 = new System.Windows.Forms.Button();
            this.btnFloor1 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.progressBarElevator = new System.Windows.Forms.ProgressBar();
            this.lblDirection = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.listOfRequests = new System.Windows.Forms.ListBox();
            this.lblCurrentFloor = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblState = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.elevatorTimer = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn5Down);
            this.groupBox1.Controls.Add(this.btn4Down);
            this.groupBox1.Controls.Add(this.btn3Down);
            this.groupBox1.Controls.Add(this.btn3Up);
            this.groupBox1.Controls.Add(this.btn4Up);
            this.groupBox1.Controls.Add(this.btn2Down);
            this.groupBox1.Controls.Add(this.btn2Up);
            this.groupBox1.Controls.Add(this.btn1Up);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(197, 495);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "External buttons";
            // 
            // btn5Down
            // 
            this.btn5Down.Location = new System.Drawing.Point(23, 30);
            this.btn5Down.Name = "btn5Down";
            this.btn5Down.Size = new System.Drawing.Size(149, 34);
            this.btn5Down.TabIndex = 8;
            this.btn5Down.Tag = "5";
            this.btn5Down.Text = "5th Floor Down";
            this.btn5Down.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn5Down.UseVisualStyleBackColor = true;
            this.btn5Down.Click += new System.EventHandler(this.btn5Down_Click);
            // 
            // btn4Down
            // 
            this.btn4Down.Location = new System.Drawing.Point(23, 132);
            this.btn4Down.Name = "btn4Down";
            this.btn4Down.Size = new System.Drawing.Size(149, 34);
            this.btn4Down.TabIndex = 6;
            this.btn4Down.Tag = "4";
            this.btn4Down.Text = "4th Floor Down";
            this.btn4Down.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn4Down.UseVisualStyleBackColor = true;
            this.btn4Down.Click += new System.EventHandler(this.btn4Down_Click);
            // 
            // btn3Down
            // 
            this.btn3Down.Location = new System.Drawing.Point(23, 234);
            this.btn3Down.Name = "btn3Down";
            this.btn3Down.Size = new System.Drawing.Size(149, 34);
            this.btn3Down.TabIndex = 4;
            this.btn3Down.Tag = "3";
            this.btn3Down.Text = "3rd Floor Down";
            this.btn3Down.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn3Down.UseVisualStyleBackColor = true;
            this.btn3Down.Click += new System.EventHandler(this.btn3Down_Click);
            // 
            // btn3Up
            // 
            this.btn3Up.Location = new System.Drawing.Point(23, 194);
            this.btn3Up.Name = "btn3Up";
            this.btn3Up.Size = new System.Drawing.Size(149, 34);
            this.btn3Up.TabIndex = 3;
            this.btn3Up.Tag = "3";
            this.btn3Up.Text = "3rd Floor Up";
            this.btn3Up.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn3Up.UseVisualStyleBackColor = true;
            this.btn3Up.Click += new System.EventHandler(this.btn3Up_Click);
            // 
            // btn4Up
            // 
            this.btn4Up.Location = new System.Drawing.Point(23, 92);
            this.btn4Up.Name = "btn4Up";
            this.btn4Up.Size = new System.Drawing.Size(149, 34);
            this.btn4Up.TabIndex = 5;
            this.btn4Up.Tag = "4";
            this.btn4Up.Text = "4th Floor Up";
            this.btn4Up.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn4Up.UseVisualStyleBackColor = true;
            this.btn4Up.Click += new System.EventHandler(this.btn4Up_Click);
            // 
            // btn2Down
            // 
            this.btn2Down.Location = new System.Drawing.Point(23, 335);
            this.btn2Down.Name = "btn2Down";
            this.btn2Down.Size = new System.Drawing.Size(149, 34);
            this.btn2Down.TabIndex = 2;
            this.btn2Down.Tag = "2";
            this.btn2Down.Text = "2nd Floor Down";
            this.btn2Down.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn2Down.UseVisualStyleBackColor = true;
            this.btn2Down.Click += new System.EventHandler(this.btn2Down_Click);
            // 
            // btn2Up
            // 
            this.btn2Up.Location = new System.Drawing.Point(23, 295);
            this.btn2Up.Name = "btn2Up";
            this.btn2Up.Size = new System.Drawing.Size(149, 34);
            this.btn2Up.TabIndex = 1;
            this.btn2Up.Tag = "2";
            this.btn2Up.Text = "2nd Floor Up";
            this.btn2Up.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn2Up.UseVisualStyleBackColor = true;
            this.btn2Up.Click += new System.EventHandler(this.btn2Up_Click);
            // 
            // btn1Up
            // 
            this.btn1Up.Location = new System.Drawing.Point(23, 398);
            this.btn1Up.Name = "btn1Up";
            this.btn1Up.Size = new System.Drawing.Size(149, 34);
            this.btn1Up.TabIndex = 0;
            this.btn1Up.Tag = "1";
            this.btn1Up.Text = "1st Floor Up";
            this.btn1Up.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn1Up.UseVisualStyleBackColor = true;
            this.btn1Up.Click += new System.EventHandler(this.btn1Up_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnFloor5);
            this.groupBox2.Controls.Add(this.btnFloor4);
            this.groupBox2.Controls.Add(this.btnFloor3);
            this.groupBox2.Controls.Add(this.btnFloor2);
            this.groupBox2.Controls.Add(this.btnFloor1);
            this.groupBox2.Location = new System.Drawing.Point(238, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(197, 495);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Internal buttons";
            // 
            // btnFloor5
            // 
            this.btnFloor5.Location = new System.Drawing.Point(15, 30);
            this.btnFloor5.Name = "btnFloor5";
            this.btnFloor5.Size = new System.Drawing.Size(149, 34);
            this.btnFloor5.TabIndex = 13;
            this.btnFloor5.Text = "5th Floor";
            this.btnFloor5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFloor5.UseVisualStyleBackColor = true;
            this.btnFloor5.Click += new System.EventHandler(this.btnFloor5_Click);
            // 
            // btnFloor4
            // 
            this.btnFloor4.Location = new System.Drawing.Point(15, 92);
            this.btnFloor4.Name = "btnFloor4";
            this.btnFloor4.Size = new System.Drawing.Size(149, 34);
            this.btnFloor4.TabIndex = 12;
            this.btnFloor4.Text = "4th Floor";
            this.btnFloor4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFloor4.UseVisualStyleBackColor = true;
            this.btnFloor4.Click += new System.EventHandler(this.btnFloor4_Click);
            // 
            // btnFloor3
            // 
            this.btnFloor3.Location = new System.Drawing.Point(15, 194);
            this.btnFloor3.Name = "btnFloor3";
            this.btnFloor3.Size = new System.Drawing.Size(149, 34);
            this.btnFloor3.TabIndex = 11;
            this.btnFloor3.Text = "3rd Floor";
            this.btnFloor3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFloor3.UseVisualStyleBackColor = true;
            this.btnFloor3.Click += new System.EventHandler(this.btnFloor3_Click);
            // 
            // btnFloor2
            // 
            this.btnFloor2.Location = new System.Drawing.Point(15, 295);
            this.btnFloor2.Name = "btnFloor2";
            this.btnFloor2.Size = new System.Drawing.Size(149, 34);
            this.btnFloor2.TabIndex = 10;
            this.btnFloor2.Text = "2nd Floor";
            this.btnFloor2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFloor2.UseVisualStyleBackColor = true;
            this.btnFloor2.Click += new System.EventHandler(this.btnFloor2_Click);
            // 
            // btnFloor1
            // 
            this.btnFloor1.Location = new System.Drawing.Point(15, 398);
            this.btnFloor1.Name = "btnFloor1";
            this.btnFloor1.Size = new System.Drawing.Size(149, 34);
            this.btnFloor1.TabIndex = 9;
            this.btnFloor1.Text = "1st Floor";
            this.btnFloor1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFloor1.UseVisualStyleBackColor = true;
            this.btnFloor1.Click += new System.EventHandler(this.btnFloor1_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.progressBarElevator);
            this.groupBox3.Controls.Add(this.lblDirection);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.listOfRequests);
            this.groupBox3.Controls.Add(this.lblCurrentFloor);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.lblState);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(466, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(365, 495);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Elevator State";
            // 
            // progressBarElevator
            // 
            this.progressBarElevator.Location = new System.Drawing.Point(18, 131);
            this.progressBarElevator.Name = "progressBarElevator";
            this.progressBarElevator.Size = new System.Drawing.Size(326, 34);
            this.progressBarElevator.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.progressBarElevator.TabIndex = 9;
            this.progressBarElevator.Visible = false;
            // 
            // lblDirection
            // 
            this.lblDirection.AutoSize = true;
            this.lblDirection.Location = new System.Drawing.Point(111, 91);
            this.lblDirection.Name = "lblDirection";
            this.lblDirection.Size = new System.Drawing.Size(54, 25);
            this.lblDirection.TabIndex = 8;
            this.lblDirection.Text = "Value";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Direction:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 194);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 25);
            this.label5.TabIndex = 6;
            this.label5.Text = "Requests:";
            // 
            // listOfRequests
            // 
            this.listOfRequests.Enabled = false;
            this.listOfRequests.FormattingEnabled = true;
            this.listOfRequests.ItemHeight = 25;
            this.listOfRequests.Location = new System.Drawing.Point(18, 234);
            this.listOfRequests.Name = "listOfRequests";
            this.listOfRequests.Size = new System.Drawing.Size(326, 204);
            this.listOfRequests.TabIndex = 5;
            this.listOfRequests.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.listOfRequests_DrawItem);
            // 
            // lblCurrentFloor
            // 
            this.lblCurrentFloor.AutoSize = true;
            this.lblCurrentFloor.Location = new System.Drawing.Point(144, 65);
            this.lblCurrentFloor.Name = "lblCurrentFloor";
            this.lblCurrentFloor.Size = new System.Drawing.Size(54, 25);
            this.lblCurrentFloor.TabIndex = 3;
            this.lblCurrentFloor.Text = "Value";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 25);
            this.label4.TabIndex = 2;
            this.label4.Text = "Current Floor:";
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.Location = new System.Drawing.Point(79, 39);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(54, 25);
            this.lblState.TabIndex = 1;
            this.lblState.Text = "Value";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "State:";
            // 
            // elevatorTimer
            // 
            this.elevatorTimer.Interval = 1000;
            this.elevatorTimer.Tick += new System.EventHandler(this.elevatorTimer_Tick);
            // 
            // FormElevator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 534);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormElevator";
            this.Text = "Elevator";
            this.Load += new System.EventHandler(this.FormElevator_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn5Down;
        private System.Windows.Forms.Button btn4Down;
        private System.Windows.Forms.Button btn4Up;
        private System.Windows.Forms.Button btn3Down;
        private System.Windows.Forms.Button btn3Up;
        private System.Windows.Forms.Button btn2Down;
        private System.Windows.Forms.Button btn2Up;
        private System.Windows.Forms.Button btn1Up;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnFloor4;
        private System.Windows.Forms.Button btnFloor3;
        private System.Windows.Forms.Button btnFloor2;
        private System.Windows.Forms.Button btnFloor1;
        private System.Windows.Forms.Button btnFloor5;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox listOfRequests;
        private System.Windows.Forms.Label lblCurrentFloor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDirection;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer elevatorTimer;
        private System.Windows.Forms.ProgressBar progressBarElevator;
    }
}

