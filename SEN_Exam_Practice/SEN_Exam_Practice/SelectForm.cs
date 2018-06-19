using BusinessLogicLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterfaceLayer
{
  public partial class SelectForm : Form
  {
    BindingSource data;
    public SelectForm()
    {
      InitializeComponent();
    }

    private void SelectForm_Load(object sender, EventArgs e)
    {
      data = new BindingSource();
      data.DataSource = new Person().persons;
      dgvPerson.DataSource = data;
    }

    private void btnManage_Click(object sender, EventArgs e)
    {
      Form1 form = new Form1((Person)data.Current);      
      form.ShowDialog();
    }
  }
}
