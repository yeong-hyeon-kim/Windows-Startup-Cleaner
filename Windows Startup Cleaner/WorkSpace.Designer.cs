
namespace Windows_Startup_Cleaner
{
    partial class WorkSpace
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
            this.btnSearchStartup = new System.Windows.Forms.Button();
            this.lvStartupList = new System.Windows.Forms.ListView();
            this.btnRemoveStartup = new System.Windows.Forms.Button();
            this.lblSubject = new System.Windows.Forms.Label();
            this.textStartupPath = new System.Windows.Forms.TextBox();
            this.lblStartupPath = new System.Windows.Forms.Label();
            this.btnAddStartup = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.textStartupName = new System.Windows.Forms.TextBox();
            this.btnGetProgramPath = new System.Windows.Forms.Button();
            this.cmbRegistry = new System.Windows.Forms.ComboBox();
            this.lblRegistry = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSearchStartup
            // 
            this.btnSearchStartup.BackColor = System.Drawing.Color.Navy;
            this.btnSearchStartup.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSearchStartup.ForeColor = System.Drawing.Color.White;
            this.btnSearchStartup.Location = new System.Drawing.Point(661, 54);
            this.btnSearchStartup.Name = "btnSearchStartup";
            this.btnSearchStartup.Size = new System.Drawing.Size(125, 40);
            this.btnSearchStartup.TabIndex = 1;
            this.btnSearchStartup.Text = "조회";
            this.btnSearchStartup.UseVisualStyleBackColor = false;
            this.btnSearchStartup.Click += new System.EventHandler(this.btnSearchStartup_Click);
            // 
            // lvStartupList
            // 
            this.lvStartupList.HideSelection = false;
            this.lvStartupList.Location = new System.Drawing.Point(33, 54);
            this.lvStartupList.Name = "lvStartupList";
            this.lvStartupList.Size = new System.Drawing.Size(610, 351);
            this.lvStartupList.TabIndex = 2;
            this.lvStartupList.UseCompatibleStateImageBehavior = false;
            this.lvStartupList.SelectedIndexChanged += new System.EventHandler(this.lvStartupList_SelectedIndexChanged);
            // 
            // btnRemoveStartup
            // 
            this.btnRemoveStartup.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnRemoveStartup.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnRemoveStartup.ForeColor = System.Drawing.Color.White;
            this.btnRemoveStartup.Location = new System.Drawing.Point(661, 100);
            this.btnRemoveStartup.Name = "btnRemoveStartup";
            this.btnRemoveStartup.Size = new System.Drawing.Size(125, 40);
            this.btnRemoveStartup.TabIndex = 3;
            this.btnRemoveStartup.Text = "제거";
            this.btnRemoveStartup.UseVisualStyleBackColor = false;
            this.btnRemoveStartup.Click += new System.EventHandler(this.btnRemoveStartup_Click);
            // 
            // lblSubject
            // 
            this.lblSubject.AutoSize = true;
            this.lblSubject.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSubject.Location = new System.Drawing.Point(33, 12);
            this.lblSubject.Name = "lblSubject";
            this.lblSubject.Size = new System.Drawing.Size(222, 32);
            this.lblSubject.TabIndex = 4;
            this.lblSubject.Text = "시작 프로그램 관리";
            // 
            // textStartupPath
            // 
            this.textStartupPath.Location = new System.Drawing.Point(154, 457);
            this.textStartupPath.Name = "textStartupPath";
            this.textStartupPath.Size = new System.Drawing.Size(489, 23);
            this.textStartupPath.TabIndex = 5;
            // 
            // lblStartupPath
            // 
            this.lblStartupPath.AutoSize = true;
            this.lblStartupPath.Location = new System.Drawing.Point(154, 429);
            this.lblStartupPath.Name = "lblStartupPath";
            this.lblStartupPath.Size = new System.Drawing.Size(83, 15);
            this.lblStartupPath.TabIndex = 6;
            this.lblStartupPath.Text = "프로그램 위치";
            // 
            // btnAddStartup
            // 
            this.btnAddStartup.BackColor = System.Drawing.Color.MediumPurple;
            this.btnAddStartup.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAddStartup.ForeColor = System.Drawing.Color.White;
            this.btnAddStartup.Location = new System.Drawing.Point(661, 147);
            this.btnAddStartup.Name = "btnAddStartup";
            this.btnAddStartup.Size = new System.Drawing.Size(125, 40);
            this.btnAddStartup.TabIndex = 7;
            this.btnAddStartup.Text = "추가";
            this.btnAddStartup.UseVisualStyleBackColor = false;
            this.btnAddStartup.Click += new System.EventHandler(this.btnAddStartup_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 429);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "프로그램명";
            // 
            // textStartupName
            // 
            this.textStartupName.Location = new System.Drawing.Point(33, 457);
            this.textStartupName.Name = "textStartupName";
            this.textStartupName.Size = new System.Drawing.Size(115, 23);
            this.textStartupName.TabIndex = 9;
            // 
            // btnGetProgramPath
            // 
            this.btnGetProgramPath.BackColor = System.Drawing.Color.BlueViolet;
            this.btnGetProgramPath.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnGetProgramPath.ForeColor = System.Drawing.Color.White;
            this.btnGetProgramPath.Location = new System.Drawing.Point(661, 448);
            this.btnGetProgramPath.Name = "btnGetProgramPath";
            this.btnGetProgramPath.Size = new System.Drawing.Size(125, 40);
            this.btnGetProgramPath.TabIndex = 10;
            this.btnGetProgramPath.Text = "프로그램 위치";
            this.btnGetProgramPath.UseVisualStyleBackColor = false;
            this.btnGetProgramPath.Click += new System.EventHandler(this.btnGetProgramPath_Click);
            // 
            // cmbRegistry
            // 
            this.cmbRegistry.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRegistry.FormattingEnabled = true;
            this.cmbRegistry.Items.AddRange(new object[] {
            "Current User 1",
            "Current User 2",
            "Local Machine(32Bit) 1",
            "Local Machine(32Bit) 2",
            "Local Machine(64Bit) 1",
            "Local Machine(64Bit) 2"});
            this.cmbRegistry.Location = new System.Drawing.Point(472, 25);
            this.cmbRegistry.Name = "cmbRegistry";
            this.cmbRegistry.Size = new System.Drawing.Size(171, 23);
            this.cmbRegistry.TabIndex = 11;
            this.cmbRegistry.SelectedIndexChanged += new System.EventHandler(this.cmbRegistry_SelectedIndexChanged);
            // 
            // lblRegistry
            // 
            this.lblRegistry.AutoSize = true;
            this.lblRegistry.Location = new System.Drawing.Point(371, 29);
            this.lblRegistry.Name = "lblRegistry";
            this.lblRegistry.Size = new System.Drawing.Size(95, 15);
            this.lblRegistry.TabIndex = 12;
            this.lblRegistry.Text = "레지스트리 선택";
            // 
            // WorkSpace
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.lblRegistry);
            this.Controls.Add(this.cmbRegistry);
            this.Controls.Add(this.btnGetProgramPath);
            this.Controls.Add(this.textStartupName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAddStartup);
            this.Controls.Add(this.lblStartupPath);
            this.Controls.Add(this.textStartupPath);
            this.Controls.Add(this.lblSubject);
            this.Controls.Add(this.btnRemoveStartup);
            this.Controls.Add(this.lvStartupList);
            this.Controls.Add(this.btnSearchStartup);
            this.MaximizeBox = false;
            this.Name = "WorkSpace";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Windows Startup Cleaner";
            this.Load += new System.EventHandler(this.WorkSpace_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSearchStartup;
        private System.Windows.Forms.ListView lvStartupList;
        private System.Windows.Forms.Button btnRemoveStartup;
        private System.Windows.Forms.Label lblSubject;
        private System.Windows.Forms.TextBox textStartupPath;
        private System.Windows.Forms.Label lblStartupPath;
        private System.Windows.Forms.Button btnAddStartup;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textStartupName;
        private System.Windows.Forms.Button btnGetProgramPath;
        private System.Windows.Forms.ComboBox cmbRegistry;
        private System.Windows.Forms.Label lblRegistry;
    }
}

