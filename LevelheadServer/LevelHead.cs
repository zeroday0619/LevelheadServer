﻿using LevelheadServer.Objects;
using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Threading.Tasks;

namespace LevelheadServer
{
	public static class LevelHead
	{
		public static bool FROZEN = false;
		public static string API_KEY = "8ffd39d8-1ad8-41a8-ac1b-895fb7527b91";
		public static Dictionary<string, TypeObj> objlist = new Dictionary<string, TypeObj>();
		public static void setObj()
		{
			objlist = new Dictionary<string, TypeObj>();
			objlist.Add("LEVEL", new TypeObj("Level", 5, 100, ""));
			
			// Bed Wars
			objlist.Add("BW_COINS", new TypeObj("Bed Wars: Coins", 1, 100000, "player.stats.Bedwars.coins"));
			objlist.Add("BW_WINS", new TypeObj("Bed Wars: Wins", 1, 100000, "player.achievements.bedwars_wins"));
			objlist.Add("BW_LEVEL", new TypeObj("Bed Wars: Level", 1, 1000, "player.achievements.bedwars_level"));
			objlist.Add("BW_BEDS", new TypeObj("Bed Wars: Beds", 1, 10000, "player.achievements.bedwars_beds"));

			// Special
			objlist.Add("LEVEL+BW_LEVEL", new TypeObj("Level + Bed Wars: Level", 1, 100, ""));
			Console.WriteLine("Finished writing levelhead type list.");
		}
	}
}
