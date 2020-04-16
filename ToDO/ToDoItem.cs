using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDO
{
  class ToDoItem
  { 
    // Properties
    public string Text { get; set; }
    public bool Urgent { get; set; }
    public DateTime DateCreate { get; set; } = DateTime.Now;

    // Constructor
    public ToDoItem(string text, bool urgent)
    {
      Text = text;
      Urgent = urgent;
    }

    // Tostring method
    public override string ToString()
    {
      string dispalyText = $"{Text} - {DateCreate:d}";
      if (Urgent)
      {
        dispalyText += " URGENT!";
      }

      return dispalyText;
    }
  }
}
