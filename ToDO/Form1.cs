using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
  
namespace ToDO
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private void btnAdd_Click(object sender, EventArgs e)
    {
      string newItem = txtNewToDo.Text.Trim();
      bool urgent = cbUrgent.Checked;

      // makeing sure that there is an item, that it's unique, checking if it's urgent, and adding it to the list.
      if (!String.IsNullOrWhiteSpace(newItem))
      {
        if (!checkRepeat(newItem))
        {
          ToDoItem todoItem = new ToDoItem(newItem, urgent);

          clsToDo.Items.Add(todoItem);

          txtNewToDo.Text = "";
        }
        else
        {
          MessageBox.Show("You already have that entry on your list.", "Error");
        }
      }
      txtNewToDo.Focus();
    }

    private bool checkRepeat(string newItem)
    {
      // You'll never believe this, it checks... the repeats! Funniest thing I've seen.
      foreach (ToDoItem item in clsToDo.Items)
      {
        if (item.Text.ToLower() == newItem.ToLower())
        {
          return true;
        }
      }
      return false;
    }

    private void btnDelete_Click(object sender, EventArgs e)
    {
      // puts all the checked items in a list and then takes everything from that list and deletes it from the main checklist and adds it to the completed list.
      List<ToDoItem> doneItems = new List<ToDoItem>();

      foreach(ToDoItem item in clsToDo.CheckedItems)
      {
        doneItems.Add(item);
      }

      foreach(ToDoItem item in doneItems)
      {
        clsToDo.Items.Remove(item);
        lstDone.Items.Add(item);
      }
    }
  }
}
