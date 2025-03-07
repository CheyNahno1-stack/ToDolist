namespace twodolist
{
    partial class background
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
            txtTask = new TextBox();
            lstTasks = new ListBox();
            bttnRemove = new Button();
            bttnSave = new Button();
            bttnAdd = new Button();
            SuspendLayout();
            // 
            // txtTask
            // 
            txtTask.Location = new Point(116, 99);
            txtTask.Name = "txtTask";
            txtTask.Size = new Size(100, 23);
            txtTask.TabIndex = 0;
            txtTask.UseWaitCursor = true;
            // 
            // lstTasks
            // 
            lstTasks.FormattingEnabled = true;
            lstTasks.ItemHeight = 15;
            lstTasks.Location = new Point(458, 84);
            lstTasks.Name = "lstTasks";
            lstTasks.Size = new Size(286, 214);
            lstTasks.TabIndex = 1;
            lstTasks.UseWaitCursor = true;
            // 
            // bttnRemove
            // 
            bttnRemove.Location = new Point(333, 172);
            bttnRemove.Name = "bttnRemove";
            bttnRemove.Size = new Size(92, 23);
            bttnRemove.TabIndex = 2;
            bttnRemove.Text = "Remove Task";
            bttnRemove.UseVisualStyleBackColor = true;
            bttnRemove.UseWaitCursor = true;
            bttnRemove.Click += bttnRemove_Click;
            // 
            // bttnSave
            // 
            bttnSave.Location = new Point(350, 235);
            bttnSave.Name = "bttnSave";
            bttnSave.Size = new Size(75, 23);
            bttnSave.TabIndex = 3;
            bttnSave.Text = "Save Task";
            bttnSave.UseVisualStyleBackColor = true;
            bttnSave.UseWaitCursor = true;
            bttnSave.Click += bttnSave_Click;
            // 
            // bttnAdd
            // 
            bttnAdd.Location = new Point(350, 114);
            bttnAdd.Name = "bttnAdd";
            bttnAdd.Size = new Size(75, 23);
            bttnAdd.TabIndex = 4;
            bttnAdd.Text = "Add Task";
            bttnAdd.UseVisualStyleBackColor = true;
            bttnAdd.UseWaitCursor = true;
            bttnAdd.Click += bttnAdd_Click;
            // 
            // background
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(bttnAdd);
            Controls.Add(bttnSave);
            Controls.Add(bttnRemove);
            Controls.Add(lstTasks);
            Controls.Add(txtTask);
            Name = "background";
            Text = "remove Task";
            UseWaitCursor = true;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtTask;
        private ListBox lstTasks;
        private Button bttnRemove;
        private Button bttnSave;
        private Button bttnAdd;
    }
}
