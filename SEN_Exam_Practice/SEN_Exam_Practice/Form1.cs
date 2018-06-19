using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogicLayer;

namespace InterfaceLayer
{
  public partial class Form1 : Form
  {
    private BindingSource data = new BindingSource();
    public Form1()
    {
      InitializeComponent();
    }
    private  void Bind()
    {
      idTextBox.DataBindings.Add("Text", data, "Identifier");
      firstNameTextBox.DataBindings.Add("Text", data, "Name");
      surnameTextBox.DataBindings.Add("Text", data, "Surname");
      codeNameTextBox.DataBindings.Add("Text", data, "Title");

    }
    private void clearButton_Click(object sender, EventArgs e)
    {

    }

    private void saveButton_Click(object sender, EventArgs e)
    {
      new Person(0,
         idTextBox.Text.Trim(),
         codeNameTextBox.Text.Trim(),
         firstNameTextBox.Text.Trim(),
         surnameTextBox.Text.Trim(),
         "Schedule",
         "Gender",
         DateTime.Now).Insert();
    }
    public Form1(Person person):this()
    {
      data.DataSource = person;
      Bind();
    }
    private void searchButton_Click(object sender, EventArgs e)
    {
      new Person().Update((Person)data.DataSource);//update person
                                                   //rename to update
    }
  }
}
