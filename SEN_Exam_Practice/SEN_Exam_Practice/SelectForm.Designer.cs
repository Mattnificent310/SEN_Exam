namespace InterfaceLayer
{
  partial class SelectForm
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
      this.dgvPerson = new System.Windows.Forms.DataGridView();
      this.btnManage = new System.Windows.Forms.Button();
      ((System.ComponentModel.ISupportInitialize)(this.dgvPerson)).BeginInit();
      this.SuspendLayout();
      // 
      // dgvPerson
      // 
      this.dgvPerson.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dgvPerson.Location = new System.Drawing.Point(12, 12);
      this.dgvPerson.Name = "dgvPerson";
      this.dgvPerson.Size = new System.Drawing.Size(776, 150);
      this.dgvPerson.TabIndex = 0;
      // 
      // btnManage
      // 
      this.btnManage.Location = new System.Drawing.Point(629, 304);
      this.btnManage.Name = "btnManage";
      this.btnManage.Size = new System.Drawing.Size(115, 33);
      this.btnManage.TabIndex = 1;
      this.btnManage.Text = "Manage";
      this.btnManage.UseVisualStyleBackColor = true;
      this.btnManage.Click += new System.EventHandler(this.btnManage_Click);
      // 
      // SelectForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.btnManage);
      this.Controls.Add(this.dgvPerson);
      this.Name = "SelectForm";
      this.Text = "SelectForm";
      this.Load += new System.EventHandler(this.SelectForm_Load);
      ((System.ComponentModel.ISupportInitialize)(this.dgvPerson)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.DataGridView dgvPerson;
    private System.Windows.Forms.Button btnManage;
  }
}