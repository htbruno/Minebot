﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace C_Minebot.Classes {
    public class Item {
        public int itemID;
        public byte itemCount;
        public short itemDamage;
        public short slot;
        public string itemname;

        public Item(int ItemID, byte ItemCount, short ItemDamage,short Slot) {
            itemID = ItemID;
            itemCount = ItemCount;
            itemDamage = ItemDamage;
            slot = Slot;
            itemname = ((blockitemid)itemID).ToString();
        }

        public enum blockitemid {
        Air,
        Stone,
        Grass,
        Dirt,
        CobbleStone,
        Planks,
        Sapling,
        BedRock,
        Water,
        WaterSpring,
        Lava,
        LavaSpring,
        Sand,
        Gravel,
        GoldOre,
        IronOre,
        CoalOre,
        Wood,
        Leaves,
        Sponge,
        Glass,
        LapisLazuliOre,
        LapisLazuliBlock,
        Dispenser,
        SandStone,
        NoteBlock,
        Bed,
        PoweredRail,
        DetectorRail,
        StickyPison,
        Web,
        TallGrass,
        DeadBush,
        Piston,
        PistonExtension,
        Wool,
        Blackstuff,
        Dandelion,
        Rose,
        BrownMushroom,
        RedMushroom,
        GoldBlock,
        IronBlock,
        DoubleSlabs,
        Slabs,
        BrickBlock,
        TNT,
        BookShelf,
        MossStone,
        Obsidion,
        Torch,
        Fire,
        MonsterSpawner,
        WoodenStairs,
        Chest,
        RedStoneWire,
        DiamondOre,
        DiamondBlock,
        CraftingTable,
        Seeds_Planted,
        Farmland,
        Furnace,
        BurningFurnace,
        SignPost,
        WoodenDoor,
        Ladders,
        Rails,
        CobbleStoneStairs,
        WallSign,
        Lever,
        StonePresurePlate,
        IronDoor,
        WoodenPressurePlate,
        RedStoneOre,
        GlowingRedStoneOre,
        RedStoneTorchoff,
        RedStoneTorchon,
        StoneButton,
        Snow,
        Ice,
        SnowBlock,
        Cactus,
        ClayBlock,
        SugarCane,
        JukeBox,
        Fence,
        Pumpkin,
        Netherrack,
        SoulSand,
        GlowStoneBlock,
        Portal,
        JackOLantern,
        CakeBlock,
        RedStoneRepeateroff,
        RedStoneRepeateron,
        LockedChest,
        Trapdoor,
        HiddenSilverfish,
        StoneBricks,
        HugeBrownMushroom,
        HugeRedMushroom,
        IronBars,
        GlassPane,
        Melon,
        PumpkinStem,
        MelonStem,
        Vines,
        FenceGate,
        BrickStairs,
        StoneBrickStairs,
        Mycelium,
        LilyPad,
        NetherBrick,
        NetherBrickFence,
        NetherBrickStairs,
        NetherWart,
        EnchantmentTable,
        BrewingStand,
        Cauldron,
        EndPortal,
        EndPortalFrame,
        EndStone,
        DragonEgg,



        IronShovel = 256,
        IronPickAxe,
        IronAxe,
        FlintAndSteel,
        Apple,
        Bow,
        Arrow,
        Coal,
        Diamond,
        IronIngot,
        GoldIngot,
        IronSword,
        WoodenSword,
        WoodenShovel,
        WoodenPickAxe,
        WoodenAxe,
        StoneSword,
        StoneShovel,
        StonePickaxe,
        StoneAxe,
        DiamondSword,
        DiamondShovel,
        DiamondPickAxe,
        DiamondAxe,
        Stick,
        Bowl,
        MushroomSoup,
        GoldSword,
        GoldShovel,
        GoldPickAxe,
        GoldAxe,
        String_item,
        Feather,
        GunPowder,
        WoodenHoe,
        StoneHoe,
        IronHoe,
        DiamondHoe,
        GoldHoe,
        Seeds,
        Wheat,
        Bread,
        LeatherCap,
        LeatherTunic,
        LeatherPants,
        LeatherBoots,
        ChainHelmet,
        ChainChestplate,
        ChainLeggings,
        ChainBoots,
        IronHelmet,
        IronChestplate,
        IronLeggings,
        IronBoots,
        DiamondHelmet,
        DiamondChestplate,
        DiamondLeggings,
        DiamondBoots,
        GoldHelmet,
        GoldChestplate,
        GoldLeggings,
        GoldBoots,
        Flint,
        RawPorkchop,
        CookedPorkchop,
        Painting,
        GoldenApple,
        Sign,
        WoodenDoor_Item,
        Bucket,
        WaterBucket,
        LavaBucket,
        Minecart,
        Saddle,
        IronCoor,
        RedStone,
        SnowBall,
        Boat,
        Leather,
        Milk,
        ClayBrick,
        Clay,
        SugarCane_Item,
        Paper,
        Book,
        SlimeBall,
        StorageMinecart,
        PoweredMinecart,
        Egg,
        Compass,
        FishingRod,
        Clock,
        GlowStoneDust,
        RawFish,
        CookedFish,
        Dye,
        Bone,
        Sugar,
        Cake,
        Bed_Item,
        RedstoneRepeater,
        Cookie,
        Map,
        Shears,
        MelonSlice,
        PumpkinSeeds,
        MelonSeeds,
        RawBeef,
        Steak,
        RawChicken,
        CookedChicken,
        RottenFlesh,
        EnderPearl,
        BlazeRod,
        GhastTear,
        GoldNugget,
        NetherWart_item,
        Potions,
        GlassBottle,
        SpiderEye,
        FermentedSpiderEye,
        BlazePowder,
        MagmaCream,
        BrewingStand_Item,
        Cauldron_Item,
        EyeofEnder,
        GlisteringMelon,
        SpawnEgg,
        }
    }
}
