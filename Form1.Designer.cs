namespace WindowsFormsApp3
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.membersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.addMember = new System.Windows.Forms.Button();
            this.addStudentButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.membersDataGridView = new System.Windows.Forms.DataGridView();
            this.studentsDataGridView = new System.Windows.Forms.DataGridView();
            this.karateDataSet1 = new WindowsFormsApp3.KarateDataSet1();
            this.studentsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.studentsTableAdapter = new WindowsFormsApp3.KarateDataSet1TableAdapters.StudentsTableAdapter();
            this.studentidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastnameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstnameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ageDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dojoDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.membersBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.karateDataSet = new WindowsFormsApp3.KarateDataSet();
            this.membersTableAdapter = new WindowsFormsApp3.KarateDataSetTableAdapters.MembersTableAdapter();
            this.memberidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rankDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rankvalueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.senseiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dojoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.membersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.membersDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.karateDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.membersBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.karateDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // membersBindingSource
            // 
            this.membersBindingSource.DataMember = "Members";
            // 
            // addMember
            // 
            this.addMember.Location = new System.Drawing.Point(12, 408);
            this.addMember.Name = "addMember";
            this.addMember.Size = new System.Drawing.Size(182, 42);
            this.addMember.TabIndex = 2;
            this.addMember.Text = "Members add";
            this.addMember.UseVisualStyleBackColor = true;
            this.addMember.Click += new System.EventHandler(this.addMemberButton_Click);
            // 
            // addStudentButton
            // 
            this.addStudentButton.Location = new System.Drawing.Point(1087, 408);
            this.addStudentButton.Name = "addStudentButton";
            this.addStudentButton.Size = new System.Drawing.Size(182, 42);
            this.addStudentButton.TabIndex = 3;
            this.addStudentButton.Text = "Students add";
            this.addStudentButton.UseVisualStyleBackColor = true;
            this.addStudentButton.Click += new System.EventHandler(this.addStudentButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(217, 408);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 42);
            this.button1.TabIndex = 4;
            this.button1.Text = "Delete";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.deleteMemberButton_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1293, 408);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(118, 42);
            this.button2.TabIndex = 5;
            this.button2.Text = "Delete";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.deleteStudentButton_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(390, 408);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(111, 42);
            this.button3.TabIndex = 6;
            this.button3.Text = "Edit";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.editMemberButton_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(1439, 408);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(111, 42);
            this.button4.TabIndex = 7;
            this.button4.Text = "Edit";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.editStudentButton_Click);
            // 
            // membersDataGridView
            // 
            this.membersDataGridView.AutoGenerateColumns = false;
            this.membersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.membersDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.memberidDataGridViewTextBoxColumn,
            this.lastnameDataGridViewTextBoxColumn,
            this.firstnameDataGridViewTextBoxColumn,
            this.ageDataGridViewTextBoxColumn,
            this.rankDataGridViewTextBoxColumn,
            this.rankvalueDataGridViewTextBoxColumn,
            this.senseiDataGridViewTextBoxColumn,
            this.dojoDataGridViewTextBoxColumn});
            this.membersDataGridView.DataSource = this.membersBindingSource1;
            this.membersDataGridView.Location = new System.Drawing.Point(12, 12);
            this.membersDataGridView.Name = "membersDataGridView";
            this.membersDataGridView.RowHeadersWidth = 51;
            this.membersDataGridView.RowTemplate.Height = 24;
            this.membersDataGridView.Size = new System.Drawing.Size(1052, 344);
            this.membersDataGridView.TabIndex = 8;
            // 
            // studentsDataGridView
            // 
            this.studentsDataGridView.AutoGenerateColumns = false;
            this.studentsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.studentsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.studentidDataGridViewTextBoxColumn,
            this.lastnameDataGridViewTextBoxColumn1,
            this.firstnameDataGridViewTextBoxColumn1,
            this.ageDataGridViewTextBoxColumn1,
            this.dojoDataGridViewTextBoxColumn1});
            this.studentsDataGridView.DataSource = this.studentsBindingSource1;
            this.studentsDataGridView.Location = new System.Drawing.Point(1136, 12);
            this.studentsDataGridView.Name = "studentsDataGridView";
            this.studentsDataGridView.RowHeadersWidth = 51;
            this.studentsDataGridView.RowTemplate.Height = 24;
            this.studentsDataGridView.Size = new System.Drawing.Size(643, 344);
            this.studentsDataGridView.TabIndex = 9;
            // 
            // karateDataSet1
            // 
            this.karateDataSet1.DataSetName = "KarateDataSet1";
            this.karateDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentsBindingSource1
            // 
            this.studentsBindingSource1.DataMember = "Students";
            this.studentsBindingSource1.DataSource = this.karateDataSet1;
            // 
            // studentsTableAdapter
            // 
            this.studentsTableAdapter.ClearBeforeFill = true;
            // 
            // studentidDataGridViewTextBoxColumn
            // 
            this.studentidDataGridViewTextBoxColumn.DataPropertyName = "student_id";

            this.studentidDataGridViewTextBoxColumn.HeaderText = "student_id";
            this.studentidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.studentidDataGridViewTextBoxColumn.Name = "studentidDataGridViewTextBoxColumn";
            this.studentidDataGridViewTextBoxColumn.Width = 125;
            // 
            // lastnameDataGridViewTextBoxColumn1
            // 
            this.lastnameDataGridViewTextBoxColumn1.DataPropertyName = "last_name";
            this.lastnameDataGridViewTextBoxColumn1.HeaderText = "last_name";
            this.lastnameDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.lastnameDataGridViewTextBoxColumn1.Name = "lastnameDataGridViewTextBoxColumn1";
            this.lastnameDataGridViewTextBoxColumn1.Width = 125;
            // 
            // firstnameDataGridViewTextBoxColumn1
            // 
            this.firstnameDataGridViewTextBoxColumn1.DataPropertyName = "first_name";
            this.firstnameDataGridViewTextBoxColumn1.HeaderText = "first_name";
            this.firstnameDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.firstnameDataGridViewTextBoxColumn1.Name = "firstnameDataGridViewTextBoxColumn1";
            this.firstnameDataGridViewTextBoxColumn1.Width = 125;
            // 
            // ageDataGridViewTextBoxColumn1
            // 
            this.ageDataGridViewTextBoxColumn1.DataPropertyName = "age";
            this.ageDataGridViewTextBoxColumn1.HeaderText = "age";
            this.ageDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.ageDataGridViewTextBoxColumn1.Name = "ageDataGridViewTextBoxColumn1";
            this.ageDataGridViewTextBoxColumn1.Width = 125;
            // 
            // dojoDataGridViewTextBoxColumn1
            // 
            this.dojoDataGridViewTextBoxColumn1.DataPropertyName = "dojo";
            this.dojoDataGridViewTextBoxColumn1.HeaderText = "dojo";
            this.dojoDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dojoDataGridViewTextBoxColumn1.Name = "dojoDataGridViewTextBoxColumn1";
            this.dojoDataGridViewTextBoxColumn1.Width = 125;
            // 
            // membersBindingSource1
            // 
            this.membersBindingSource1.DataMember = "Members";
            this.membersBindingSource1.DataSource = this.karateDataSet;
            // 
            // karateDataSet
            // 
            this.karateDataSet.DataSetName = "KarateDataSet";
            this.karateDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // membersTableAdapter
            // 
            this.membersTableAdapter.ClearBeforeFill = true;
            // 
            // memberidDataGridViewTextBoxColumn
            // 
            this.memberidDataGridViewTextBoxColumn.DataPropertyName = "member_id";
            this.memberidDataGridViewTextBoxColumn.HeaderText = "member_id";
            this.memberidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.memberidDataGridViewTextBoxColumn.Name = "memberidDataGridViewTextBoxColumn";
            this.memberidDataGridViewTextBoxColumn.Width = 125;
            // 
            // lastnameDataGridViewTextBoxColumn
            // 
            this.lastnameDataGridViewTextBoxColumn.DataPropertyName = "last_name";
            this.lastnameDataGridViewTextBoxColumn.HeaderText = "last_name";
            this.lastnameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.lastnameDataGridViewTextBoxColumn.Name = "lastnameDataGridViewTextBoxColumn";
            this.lastnameDataGridViewTextBoxColumn.Width = 125;
            // 
            // firstnameDataGridViewTextBoxColumn
            // 
            this.firstnameDataGridViewTextBoxColumn.DataPropertyName = "first_name";
            this.firstnameDataGridViewTextBoxColumn.HeaderText = "first_name";
            this.firstnameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.firstnameDataGridViewTextBoxColumn.Name = "firstnameDataGridViewTextBoxColumn";
            this.firstnameDataGridViewTextBoxColumn.Width = 125;
            // 
            // ageDataGridViewTextBoxColumn
            // 
            this.ageDataGridViewTextBoxColumn.DataPropertyName = "age";
            this.ageDataGridViewTextBoxColumn.HeaderText = "age";
            this.ageDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ageDataGridViewTextBoxColumn.Name = "ageDataGridViewTextBoxColumn";
            this.ageDataGridViewTextBoxColumn.Width = 125;
            // 
            // rankDataGridViewTextBoxColumn
            // 
            this.rankDataGridViewTextBoxColumn.DataPropertyName = "rank";
            this.rankDataGridViewTextBoxColumn.HeaderText = "rank";
            this.rankDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.rankDataGridViewTextBoxColumn.Name = "rankDataGridViewTextBoxColumn";
            this.rankDataGridViewTextBoxColumn.Width = 125;
            // 
            // rankvalueDataGridViewTextBoxColumn
            // 
            this.rankvalueDataGridViewTextBoxColumn.DataPropertyName = "rank_value";
            this.rankvalueDataGridViewTextBoxColumn.HeaderText = "rank_value";
            this.rankvalueDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.rankvalueDataGridViewTextBoxColumn.Name = "rankvalueDataGridViewTextBoxColumn";
            this.rankvalueDataGridViewTextBoxColumn.Width = 125;
            // 
            // senseiDataGridViewTextBoxColumn
            // 
            this.senseiDataGridViewTextBoxColumn.DataPropertyName = "sensei";
            this.senseiDataGridViewTextBoxColumn.HeaderText = "sensei";
            this.senseiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.senseiDataGridViewTextBoxColumn.Name = "senseiDataGridViewTextBoxColumn";
            this.senseiDataGridViewTextBoxColumn.Width = 125;
            // 
            // dojoDataGridViewTextBoxColumn
            // 
            this.dojoDataGridViewTextBoxColumn.DataPropertyName = "dojo";
            this.dojoDataGridViewTextBoxColumn.HeaderText = "dojo";
            this.dojoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dojoDataGridViewTextBoxColumn.Name = "dojoDataGridViewTextBoxColumn";
            this.dojoDataGridViewTextBoxColumn.Width = 125;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1791, 640);
            this.Controls.Add(this.studentsDataGridView);
            this.Controls.Add(this.membersDataGridView);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.addStudentButton);
            this.Controls.Add(this.addMember);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.membersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.membersDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.karateDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.membersBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.karateDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
    
        private System.Windows.Forms.BindingSource membersBindingSource;
    
        private System.Windows.Forms.BindingSource studentsBindingSource;
 
        private System.Windows.Forms.Button addMember;
        private System.Windows.Forms.Button addStudentButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridView membersDataGridView;
        private System.Windows.Forms.DataGridView studentsDataGridView;
        private KarateDataSet karateDataSet;
        private System.Windows.Forms.BindingSource membersBindingSource1;
        private KarateDataSetTableAdapters.MembersTableAdapter membersTableAdapter;
        private KarateDataSet1 karateDataSet1;
        private System.Windows.Forms.BindingSource studentsBindingSource1;
        private KarateDataSet1TableAdapters.StudentsTableAdapter studentsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastnameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstnameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ageDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dojoDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn memberidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rankDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rankvalueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn senseiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dojoDataGridViewTextBoxColumn;
    }
}

