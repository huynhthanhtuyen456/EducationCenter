namespace Views
{
    partial class RoleView
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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewTeacher = new DataGridView();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            RoleName = new DataGridViewTextBoxColumn();
            Description = new DataGridViewTextBoxColumn();
            roleBindingSource = new BindingSource(components);
            teacherBindingSource = new BindingSource(components);
            LblTeacherFormTitle = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            textBox1 = new TextBox();
            button4 = new Button();
            ((System.ComponentModel.ISupportInitialize)DataGridViewTeacher).BeginInit();
            ((System.ComponentModel.ISupportInitialize)roleBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)teacherBindingSource).BeginInit();
            SuspendLayout();
            // 
            // DataGridViewTeacher
            // 
            DataGridViewTeacher.AllowUserToAddRows = false;
            DataGridViewTeacher.AllowUserToDeleteRows = false;
            DataGridViewTeacher.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            DataGridViewTeacher.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            DataGridViewTeacher.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DataGridViewTeacher.AutoGenerateColumns = false;
            DataGridViewTeacher.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DataGridViewTeacher.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            DataGridViewTeacher.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridViewTeacher.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, RoleName, Description });
            DataGridViewTeacher.DataSource = roleBindingSource;
            DataGridViewTeacher.Location = new Point(14, 267);
            DataGridViewTeacher.Margin = new Padding(5);
            DataGridViewTeacher.Name = "DataGridViewTeacher";
            DataGridViewTeacher.ReadOnly = true;
            DataGridViewTeacher.RowHeadersWidth = 82;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            DataGridViewTeacher.RowsDefaultCellStyle = dataGridViewCellStyle2;
            DataGridViewTeacher.Size = new Size(614, 442);
            DataGridViewTeacher.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.Frozen = true;
            idDataGridViewTextBoxColumn.HeaderText = "ID";
            idDataGridViewTextBoxColumn.MinimumWidth = 10;
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.ReadOnly = true;
            idDataGridViewTextBoxColumn.Width = 106;
            // 
            // RoleName
            // 
            RoleName.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            RoleName.DataPropertyName = "Name";
            RoleName.Frozen = true;
            RoleName.HeaderText = "Name";
            RoleName.MinimumWidth = 10;
            RoleName.Name = "RoleName";
            RoleName.ReadOnly = true;
            RoleName.Width = 170;
            // 
            // Description
            // 
            Description.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Description.DataPropertyName = "Description";
            Description.HeaderText = "Description";
            Description.MinimumWidth = 10;
            Description.Name = "Description";
            Description.ReadOnly = true;
            // 
            // roleBindingSource
            // 
            roleBindingSource.DataSource = typeof(DataLayer.Entities.Roles.Role);
            // 
            // teacherBindingSource
            // 
            teacherBindingSource.DataSource = typeof(DataLayer.Entities.Teachers.Teacher);
            // 
            // LblTeacherFormTitle
            // 
            LblTeacherFormTitle.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            LblTeacherFormTitle.AutoSize = true;
            LblTeacherFormTitle.Location = new Point(370, 79);
            LblTeacherFormTitle.Margin = new Padding(5, 0, 5, 0);
            LblTeacherFormTitle.Name = "LblTeacherFormTitle";
            LblTeacherFormTitle.Size = new Size(115, 50);
            LblTeacherFormTitle.TabIndex = 1;
            LblTeacherFormTitle.Text = "Roles";
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button1.Location = new Point(654, 267);
            button1.Name = "button1";
            button1.Size = new Size(150, 66);
            button1.TabIndex = 2;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button2.Location = new Point(654, 339);
            button2.Name = "button2";
            button2.Size = new Size(150, 64);
            button2.TabIndex = 3;
            button2.Text = "Edit";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button3.Location = new Point(654, 409);
            button3.Name = "button3";
            button3.Size = new Size(150, 61);
            button3.TabIndex = 4;
            button3.Text = "Delete";
            button3.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox1.Location = new Point(14, 202);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(614, 57);
            textBox1.TabIndex = 5;
            // 
            // button4
            // 
            button4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button4.Location = new Point(654, 202);
            button4.Name = "button4";
            button4.Size = new Size(150, 57);
            button4.TabIndex = 6;
            button4.Text = "Search";
            button4.UseVisualStyleBackColor = true;
            // 
            // RoleView
            // 
            AutoScaleDimensions = new SizeF(22F, 50F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(816, 723);
            Controls.Add(button4);
            Controls.Add(textBox1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(LblTeacherFormTitle);
            Controls.Add(DataGridViewTeacher);
            Font = new Font("Segoe UI", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(5);
            MinimumSize = new Size(842, 794);
            Name = "RoleView";
            Text = "Role View";
            ((System.ComponentModel.ISupportInitialize)DataGridViewTeacher).EndInit();
            ((System.ComponentModel.ISupportInitialize)roleBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)teacherBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView DataGridViewTeacher;
        private Label LblTeacherFormTitle;
        private BindingSource roleBindingSource;
        private BindingSource teacherBindingSource;
        private Button button1;
        private Button button2;
        private Button button3;
        private TextBox textBox1;
        private Button button4;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn RoleName;
        private DataGridViewTextBoxColumn Description;
    }
}
