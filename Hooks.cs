using ItemAPI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using MonoMod.RuntimeDetour;
using System.Reflection;
using Dungeonator;

namespace NoFinishedGun
{
	// Token: 0x02000018 RID: 24
	public static class Hooks
	{
		// Token: 0x060000B7 RID: 183 RVA: 0x00008CE4 File Offset: 0x00006EE4
		public static void Init()
		{
			try
			{

				Hook nofinishedgun = new Hook(typeof(RewardManager).GetMethod("ExcludeUnfinishedGunIfNecessary", BindingFlags.Instance | BindingFlags.NonPublic), typeof(FinModule).GetMethod("NoFinishedGun"));
				//Hook nofinishedgun1 = new Hook(typeof(PickupObject).GetMethod("HandleEncounterable", BindingFlags.Instance| BindingFlags.NonPublic), typeof(FinModule).GetMethod("NoBad"));

			}
			catch (Exception e)
			{
				Tools.PrintException(e, "FF0000");
			}
		}
	}
}