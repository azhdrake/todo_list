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
      bool repeat = false;

      //ensuring that the new item is not a repeat item.
      foreach(string item in clsToDo.Items)
      {
        if(item.ToLower() == newItem.ToLower())
        {
          repeat = true;
        }
      }

      // makeing sure that there is an item, that it's unique, checking if it's urgent, and adding it to the list.
      if (!String.IsNullOrWhiteSpace(newItem))
      {
        if (repeat)
        {
          MessageBox.Show("That task is aready on the list.", "Error");
        }
        else
        {
          // gets the time and checks if its urgent.
          DateTime todoCreated = DateTime.Now;
          bool urgent = cbUrgent.Checked;
          string todoText = "";

          if (urgent) 
          {
            // I figured that you really only need the date created not the time, hense the :d.
            todoText = ($"{newItem}, created on {todoCreated:d}.  URGENT!");
          }
          else
          {
            todoText = ($"{newItem} - created on {todoCreated:d}.");
          }
        
          clsToDo.Items.Add(todoText);
          txtNewToDo.Text = "";
        }
      }

      txtNewToDo.Focus();

    }

    private void btnDelete_Click(object sender, EventArgs e)
    {
      // puts all the checked items in a list and then takes everything from that list and deletes it from the main checklist and adds it to the completed list.
      List<string> doneItems = new List<string>();

      foreach(string item in clsToDo.CheckedItems)
      {
        doneItems.Add(item);
      }

      foreach(string item in doneItems)
      {
        clsToDo.Items.Remove(item);
        lstDone.Items.Add(item);
      }
    }
  }
}
