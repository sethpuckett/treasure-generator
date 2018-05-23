using GmTools.TreasureGenerator.Domain.Model;

namespace GmTools.TreasureGenerator.Utility
{
  public static class MagicItemRarityExtensions
  {
    public static string Description(this MagicItemRarity val)
    {
      DescriptionAttribute[] attributes = (DescriptionAttribute[])val.GetType().GetField(val.ToString()).GetCustomAttributes(typeof(DescriptionAttribute), false);
      return attributes.Length > 0 ? attributes[0].Description : string.Empty;
    }
  }
}