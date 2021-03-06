using Terraria;
using Terraria.ModLoader;

namespace MusicMaker.Items.Placeable
{
	public class Note_A : ModItem
	{

		//Text: Arial 24pt
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("A Note");
			Tooltip.SetDefault("Plays an A note");
		}

		public override void SetDefaults()
		{
			item.width = 3;
			item.height = 3;
			item.maxStack = 99;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 10;
			item.useStyle = 1;
			item.consumable = true;
			item.UseSound = mod.GetLegacySoundSlot(SoundType.Custom, "Sounds/A");
			item.createTile = mod.TileType("Note_A");
		}

		public override bool UseItem(Player player){
			if(!MusicMaker.musicPlaying){
				MusicMaker.isHigh = false;
				MusicMaker.isLow = false;
			}
			return false;
		} 	

	}
}

