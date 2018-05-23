using GmTools.TreasureGenerator.Utility;

namespace GmTools.TreasureGenerator.Domain.Model
{
  public enum MagicItemRarity
  {
    [Description("Common")]
    Common,

    [Description("Uncommon")]
    Uncommon,

    [Description("Rare")]
    Rare,

    [Description("Very Rare")]
    VeryRare,

    [Description("Legendary")]
    Legendary
  }
}