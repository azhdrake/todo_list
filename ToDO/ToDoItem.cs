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
    public string Category { get; set; }

    // Constructor
    public ToDoItem(string text, string category, bool urgent)
    {
      Text = text;
      Category = category;
      Urgent = urgent;
    }

    // Tostring method
    public override string ToString()
    {
      string dispalyText = $"{Text} - {Category} - {DateCreate:d}";
      if (Urgent)
      {
        dispalyText += " URGENT!";
      }

      return dispalyText;
    }
  }
}
