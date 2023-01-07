using RPG.Models.Enums;

namespace RPG.Models
{
    public class Armor
    {
        public int Id { get; set; }
        public List<Character>? CharacterId { get; set; }
        public string Name { get; set; } = "Nameless Armor";
        public int Defense { get; set; }
        public int Protection { get; set; }
        public ArmorSlot Slot { get; set; }
        public Material Material { get; set; }
        public decimal MeleeProt { get; set; } = 0;
        public decimal RangeProt { get; set; } = 0;
        public decimal MagicProt { get; set; } = 0;
    }
}