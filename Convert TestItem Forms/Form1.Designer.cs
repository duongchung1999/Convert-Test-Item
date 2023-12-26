
namespace Convert_TestItem_Forms
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
            this.btnConvert = new System.Windows.Forms.Button();
            this.rtbInput = new System.Windows.Forms.RichTextBox();
            this.rtbOutput = new System.Windows.Forms.RichTextBox();
            this.rtbDown = new System.Windows.Forms.RichTextBox();
            this.rtbUp = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rtbUnit = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.rtbDevice = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.Number = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Test_item = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Unit = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Low_Limit = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Up_Limit = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Command = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(12, 12);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(110, 36);
            this.btnConvert.TabIndex = 0;
            this.btnConvert.Text = "Convert";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // rtbInput
            // 
            this.rtbInput.Location = new System.Drawing.Point(12, 54);
            this.rtbInput.Name = "rtbInput";
            this.rtbInput.Size = new System.Drawing.Size(218, 95);
            this.rtbInput.TabIndex = 1;
            this.rtbInput.Text = "";
            // 
            // rtbOutput
            // 
            this.rtbOutput.Location = new System.Drawing.Point(256, 54);
            this.rtbOutput.Name = "rtbOutput";
            this.rtbOutput.Size = new System.Drawing.Size(213, 95);
            this.rtbOutput.TabIndex = 1;
            this.rtbOutput.Text = "";
            // 
            // rtbDown
            // 
            this.rtbDown.Location = new System.Drawing.Point(642, 54);
            this.rtbDown.Name = "rtbDown";
            this.rtbDown.Size = new System.Drawing.Size(236, 95);
            this.rtbDown.TabIndex = 1;
            this.rtbDown.Text = "";
            // 
            // rtbUp
            // 
            this.rtbUp.Location = new System.Drawing.Point(890, 54);
            this.rtbUp.Name = "rtbUp";
            this.rtbUp.Size = new System.Drawing.Size(214, 95);
            this.rtbUp.TabIndex = 1;
            this.rtbUp.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("DengXian", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(251, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "测试项目";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("DengXian", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(637, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Down Limit";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("DengXian", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(885, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Up Limit";
            // 
            // rtbUnit
            // 
            this.rtbUnit.Location = new System.Drawing.Point(501, 54);
            this.rtbUnit.Name = "rtbUnit";
            this.rtbUnit.Size = new System.Drawing.Size(121, 95);
            this.rtbUnit.TabIndex = 1;
            this.rtbUnit.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("DengXian", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(496, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 29);
            this.label4.TabIndex = 2;
            this.label4.Text = "Unit";
            // 
            // rtbDevice
            // 
            this.rtbDevice.Location = new System.Drawing.Point(1119, 54);
            this.rtbDevice.Name = "rtbDevice";
            this.rtbDevice.Size = new System.Drawing.Size(121, 95);
            this.rtbDevice.TabIndex = 1;
            this.rtbDevice.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("DengXian", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(1114, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 29);
            this.label6.TabIndex = 2;
            this.label6.Text = "Device";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Number,
            this.Test_item,
            this.Unit,
            this.Low_Limit,
            this.Up_Limit,
            this.Command});
            this.listView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(13, 155);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1227, 401);
            this.listView1.TabIndex = 3;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.DrawItem += new System.Windows.Forms.DrawListViewItemEventHandler(this.listView1_DrawItem);
            // 
            // Number
            // 
            this.Number.Text = "No";
            // 
            // Test_item
            // 
            this.Test_item.Text = "Test_item";
            this.Test_item.Width = 300;
            // 
            // Unit
            // 
            this.Unit.Text = "Unit";
            this.Unit.Width = 80;
            // 
            // Low_Limit
            // 
            this.Low_Limit.Text = "Low Limit";
            this.Low_Limit.Width = 145;
            // 
            // Up_Limit
            // 
            this.Up_Limit.Text = "Up_Limit";
            this.Up_Limit.Width = 145;
            // 
            // Command
            // 
            this.Command.Text = "Command";
            this.Command.Width = 500;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(1270, 568);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rtbUp);
            this.Controls.Add(this.rtbDevice);
            this.Controls.Add(this.rtbUnit);
            this.Controls.Add(this.rtbDown);
            this.Controls.Add(this.rtbOutput);
            this.Controls.Add(this.rtbInput);
            this.Controls.Add(this.btnConvert);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.RichTextBox rtbInput;
        private System.Windows.Forms.RichTextBox rtbOutput;
        private System.Windows.Forms.RichTextBox rtbDown;
        private System.Windows.Forms.RichTextBox rtbUp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox rtbUnit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox rtbDevice;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListView listView1;
        public System.Windows.Forms.ColumnHeader Number;
        public System.Windows.Forms.ColumnHeader Test_item;
        public System.Windows.Forms.ColumnHeader Unit;
        public System.Windows.Forms.ColumnHeader Low_Limit;
        public System.Windows.Forms.ColumnHeader Up_Limit;
        public System.Windows.Forms.ColumnHeader Command;
    }
}

