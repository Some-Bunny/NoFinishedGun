using ItemAPI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using MonoMod.RuntimeDetour;
using System.Reflection;

namespace NoFinishedGun
{
    public class FinModule : ETGModule
    {
        public static readonly string MOD_NAME = "No Finished Gun in D Tier";
        public static readonly string VERSION = "1.0.0";
        public static readonly string TEXT_COLOR = "#A62919";

        public override void Start()
        {
            if (GameStatsManager.Instance.GetFlag(GungeonFlags.ITEMSPECIFIC_AMMONOMICON_COMPLETE))
            {
                Gun bastard = PickupObjectDatabase.GetById(83) as Gun;
                bastard.quality = PickupObject.ItemQuality.EXCLUDED;
            }
            else
            {
                Log($"Not removed due to lack of Unlock Quota.", TEXT_COLOR);
            }
            FakePrefabHooks.Init();
            //ItemBuilder.Init();
            //ExamplePassive.Register();
            Log($"{MOD_NAME} v{VERSION} started successfully.", TEXT_COLOR);
        }


        public PickupObject.ItemQuality quality;

        public static void Log(string text, string color = "#A62919")
        {
            ETGModConsole.Log($"<color={color}>{text}</color>");
        }

        public override void Exit() { }
        public override void Init()
        {

        }
    }
}
