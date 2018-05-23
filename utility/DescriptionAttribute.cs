using System;

namespace GmTools.TreasureGenerator.Utility
{
  public class DescriptionAttribute : Attribute
  {
    public string Description { get; set; }

    public DescriptionAttribute(string description) => this.Description = description;
  }
}