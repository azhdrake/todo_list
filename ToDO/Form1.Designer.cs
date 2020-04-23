namespace ToDO
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
      this.txtNewToDo = new System.Windows.Forms.TextBox();
      this.btnAdd = new System.Windows.Forms.Button();
      this.clsToDo = new System.Windows.Forms.CheckedListBox();
      this.btnDelete = new System.Windows.Forms.Button();
      this.lstDone = new System.Windows.Forms.ListBox();
      this.label2 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.label1 = new System.Windows.Forms.Label();
      this.cbUrgent = new System.Windows.Forms.CheckBox();
      this.cbCategory = new System.Windows.Forms.ComboBox();
      this.label4 = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // txtNewToDo
      // 
      this.txtNewToDo.Location = new System.Drawing.Point(81, 44);
      this.txtNewToDo.Name = "txtNewToDo";
      this.txtNewToDo.Size = new System.Drawing.Size(336, 31);
      this.txtNewToDo.TabIndex = 0;
      // 
      // btnAdd
      // 
      this.btnAdd.Location = new System.Drawing.Point(686, 77);
      this.btnAdd.Name = "btnAdd";
      this.btnAdd.Size = new System.Drawing.Size(115, 38);
      this.btnAdd.TabIndex = 1;
      this.btnAdd.Text = "Add";
      this.btnAdd.UseVisualStyleBackColor = true;
      this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
      // 
      // clsToDo
      // 
      this.clsToDo.FormattingEnabled = true;
      this.clsToDo.Location = new System.Drawing.Point(80, 121);
      this.clsToDo.Name = "clsToDo";
      this.clsToDo.Size = new System.Drawing.Size(721, 144);
      this.clsToDo.TabIndex = 2;
      // 
      // btnDelete
      // 
      this.btnDelete.Location = new System.Drawing.Point(81, 271);
      this.btnDelete.Name = "btnDelete";
      this.btnDelete.Size = new System.Drawing.Size(115, 38);
      this.btnDelete.TabIndex = 3;
      this.btnDelete.Text = "Resolve";
      this.btnDelete.UseVisualStyleBackColor = true;
      this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
      // 
      // lstDone
      // 
      this.lstDone.FormattingEnabled = true;
      this.lstDone.ItemHeight = 25;
      this.lstDone.Location = new System.Drawing.Point(80, 356);
      this.lstDone.Name = "lstDone";
      this.lstDone.Size = new System.Drawing.Size(721, 154);
      this.lstDone.TabIndex = 4;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(76, 93);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(76, 25);
      this.label2.TabIndex = 6;
      this.label2.Text = "To Do:";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(76, 328);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(121, 25);
      this.label3.TabIndex = 7;
      this.label3.Text = "Completed:";
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(76, 16);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(262, 25);
      this.label1.TabIndex = 5;
      this.label1.Text = "What do you want to add?";
      // 
      // cbUrgent
      // 
      this.cbUrgent.AutoSize = true;
      this.cbUrgent.Location = new System.Drawing.Point(686, 42);
      this.cbUrgent.Name = "cbUrgent";
      this.cbUrgent.Size = new System.Drawing.Size(108, 29);
      this.cbUrgent.TabIndex = 8;
      this.cbUrgent.Text = "Urgent";
      this.cbUrgent.UseVisualStyleBackColor = true;
      // 
      // cbCategory
      // 
      this.cbCategory.FormattingEnabled = true;
      this.cbCategory.Location = new System.Drawing.Point(441, 44);
      this.cbCategory.Name = "cbCategory";
      this.cbCategory.Size = new System.Drawing.Size(227, 33);
      this.cbCategory.TabIndex = 9;
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(436, 16);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(99, 25);
      this.label4.TabIndex = 10;
      this.label4.Text = "Category";
      // 
      // Form1
      // 
      this.AcceptButton = this.btnAdd;
      this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(879, 560);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.cbCategory);
      this.Controls.Add(this.cbUrgent);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.lstDone);
      this.Controls.Add(this.btnDelete);
      this.Controls.Add(this.clsToDo);
      this.Controls.Add(this.btnAdd);
      this.Controls.Add(this.txtNewToDo);
      this.Name = "Form1";
      this.Text = "Form1";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.TextBox txtNewToDo;
    private System.Windows.Forms.Button btnAdd;
    private System.Windows.Forms.CheckedListBox clsToDo;
    private System.Windows.Forms.Button btnDelete;
    private System.Windows.Forms.ListBox lstDone;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.CheckBox cbUrgent;
        private System.Windows.Forms.ComboBox cbCategory;
        private System.Windows.Forms.Label label4;
    }
}

