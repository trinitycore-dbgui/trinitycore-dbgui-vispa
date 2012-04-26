using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Collections;

using TrinityCore_DBGUI_Library;
using TrinityCore_DBGUI_ControlLib;

namespace TrinityCore_DBGUI
{
    public partial class frmGameItemSearch : Form
    {
        public ArrayList ItemSetList = new ArrayList();

        public frmGameItemSearch()
        {
            InitializeComponent();
        }
        
        private void frmGameItemSearch_Load(object sender, EventArgs e)
        {
            this.PopulateCategories();
            this.PopulateCriterias();
        }

        private void PopulateCriterias()
        {
            this.ucSearchCriteriaInput1.AddCriteriaType("entry", CriteriaRequester.CriteriaType.Text);
            this.ucSearchCriteriaInput1.AddCriteriaType("name", CriteriaRequester.CriteriaType.Text);
            this.ucSearchCriteriaInput1.AddCriteriaType("ItemLevel", CriteriaRequester.CriteriaType.Text);
            this.ucSearchCriteriaInput1.AddCriteriaType("RequiredLevel", CriteriaRequester.CriteriaType.Text);

            CriteriaRequester cRequesterQuality = new CriteriaRequester(CriteriaRequester.CriteriaType.DropDown, "Quality");
            cRequesterQuality.DropDownContent.Add("0 : Poor");
            cRequesterQuality.DropDownContent.Add("1 : Common");
            cRequesterQuality.DropDownContent.Add("2 : Uncommon");
            cRequesterQuality.DropDownContent.Add("3 : Rare");
            cRequesterQuality.DropDownContent.Add("4 : Epic");
            cRequesterQuality.DropDownContent.Add("5 : Legendary");
            cRequesterQuality.DropDownContent.Add("6 : Artifact");
            cRequesterQuality.DropDownContent.Add("7 : Heirloom");
            this.ucSearchCriteriaInput1.AddCriteriaType(cRequesterQuality);

            CriteriaRequester cRequesterBonding = new CriteriaRequester(CriteriaRequester.CriteriaType.DropDown, "bonding");
            cRequesterBonding.DropDownContent.Add("0 : No Bind");
            cRequesterBonding.DropDownContent.Add("1 : Binds when picked up");
            cRequesterBonding.DropDownContent.Add("2 : Binds when equipped");
            cRequesterBonding.DropDownContent.Add("3 : Binds when used");
            cRequesterBonding.DropDownContent.Add("4 : Quest Item ?");
            cRequesterBonding.DropDownContent.Add("5 : Quest Item ?");
            this.ucSearchCriteriaInput1.AddCriteriaType(cRequesterBonding);

        }

        private void PopulateCategories()
        {
            /* Top Level */
            TreeNode tnAll = this.tViewType.Nodes.Add("Search Everything");
            tnAll.Tag = new ItemSearchCriteria(-1, -1, -1);

            TreeNode tnWeapons = tnAll.Nodes.Add("Weapon"); //class WEAPON            
            tnWeapons.Tag = new ItemSearchCriteria(GameItemReference.WEAPON, -1, -1);

            TreeNode tnArmor = tnAll.Nodes.Add("Armor"); //class ARMOR
            tnArmor.Tag = new ItemSearchCriteria(GameItemReference.ARMOR, -1, -1);

            TreeNode tnContainer = tnAll.Nodes.Add("Container"); //class CONTAINER
            tnContainer.Tag = new ItemSearchCriteria(GameItemReference.CONTAINER, -1, -1);

            TreeNode tnConsumable = tnAll.Nodes.Add("Consumable"); //class CONSUMABLE
            tnConsumable.Tag = new ItemSearchCriteria(GameItemReference.CONSUMABLE, -1, -1);

            TreeNode tnGlyph = tnAll.Nodes.Add("Glyph"); //class GLYPH
            tnGlyph.Tag = new ItemSearchCriteria(GameItemReference.GLYPH, -1, -1);

            TreeNode tnTradeGoods = tnAll.Nodes.Add("Trade Goods"); //class TRADEGOODS
            tnTradeGoods.Tag = new ItemSearchCriteria(GameItemReference.TRADEGOODS, -1, -1);

            TreeNode tnRecipe = tnAll.Nodes.Add("Recipe"); //class RECIPE
            tnTradeGoods.Tag = new ItemSearchCriteria(GameItemReference.RECIPE, -1, -1);

            TreeNode tnGem = tnAll.Nodes.Add("Gem"); //class GEM
            tnGem.Tag = new ItemSearchCriteria(GameItemReference.GEM, -1, -1);

            TreeNode tnMiscellaneous = tnAll.Nodes.Add("Miscellaneous"); //class MISCCLASS
            tnMiscellaneous.Tag = new ItemSearchCriteria(GameItemReference.MISCCLASS, -1, -1);

            TreeNode tnQuest = tnAll.Nodes.Add("Quest"); //class QUEST
            tnQuest.Tag = new ItemSearchCriteria(GameItemReference.QUEST, -1, -1);

            TreeNode tnTokensCurrency = tnAll.Nodes.Add("Tokens / Currency"); //class CURRENCYTOKENS
            tnTokensCurrency.Tag = new ItemSearchCriteria(GameItemReference.CURRENCYTOKENS, -1, -1);

            TreeNode tnKey = tnAll.Nodes.Add("Key"); //class KEY
            tnKey.Tag = new ItemSearchCriteria(GameItemReference.KEY, -1, -1);

            TreeNode tnProjectile = tnAll.Nodes.Add("Projectile"); //class PROJECTILE
            tnProjectile.Tag = new ItemSearchCriteria(GameItemReference.PROJECTILE, -1, -1);

            /* Weapons */
            TreeNode tnWeaponOneHandedAxes = tnWeapons.Nodes.Add("One Handed Axes"); // invtype: 13, subclass: 0
            tnWeaponOneHandedAxes.Tag = new ItemSearchCriteria(GameItemReference.WEAPON, GameItemReference.WEAPON_ONEHAND, GameItemReference.AXE);

            TreeNode tnWeaponTwoHandedAxes = tnWeapons.Nodes.Add("Two Handed Axes"); // invtype: 
            tnWeaponTwoHandedAxes.Tag = new ItemSearchCriteria(GameItemReference.WEAPON, GameItemReference.WEAPON_TWOHAND, GameItemReference.AXE);

            TreeNode tnWeaponBows = tnWeapons.Nodes.Add("Bows");
            tnWeaponBows.Tag = new ItemSearchCriteria(GameItemReference.WEAPON, GameItemReference.WEAPON_RANGED, GameItemReference.BOW);

            TreeNode tnWeaponGuns = tnWeapons.Nodes.Add("Guns");
            tnWeaponGuns.Tag = new ItemSearchCriteria(GameItemReference.WEAPON, GameItemReference.WEAPON_RANGED_GUNWAND, GameItemReference.GUN); 

            TreeNode tnWeaponOneHandedMaces = tnWeapons.Nodes.Add("One Handed Maces");
            tnWeaponOneHandedMaces.Tag = new ItemSearchCriteria(GameItemReference.WEAPON, GameItemReference.WEAPON_ONEHAND, GameItemReference.MACE);

            TreeNode tnWeaponTwoHandedMaces = tnWeapons.Nodes.Add("Two Handed Maces");
            tnWeaponTwoHandedMaces.Tag = new ItemSearchCriteria(GameItemReference.WEAPON, GameItemReference.WEAPON_TWOHAND, GameItemReference.MACE);

            TreeNode tnWeaponPolearms = tnWeapons.Nodes.Add("Polearms");
            tnWeaponPolearms.Tag = new ItemSearchCriteria(GameItemReference.WEAPON, GameItemReference.WEAPON_TWOHAND, GameItemReference.POLEARM);

            TreeNode tnWeaponOneHandedSwords = tnWeapons.Nodes.Add("One Handed Swords");
            tnWeaponOneHandedSwords.Tag = new ItemSearchCriteria(GameItemReference.WEAPON, GameItemReference.WEAPON_ONEHAND, GameItemReference.SWORD);

            TreeNode tnWeaponTwoHandedSwords = tnWeapons.Nodes.Add("Two Handed Swords");
            tnWeaponTwoHandedSwords.Tag = new ItemSearchCriteria(GameItemReference.WEAPON, GameItemReference.WEAPON_TWOHAND, GameItemReference.SWORD);
            
            TreeNode tnWeaponStaves = tnWeapons.Nodes.Add("Staves");
            tnWeaponStaves.Tag = new ItemSearchCriteria(GameItemReference.WEAPON, GameItemReference.WEAPON_TWOHAND, GameItemReference.STAVES);

            TreeNode tnWeaponFistWeapons = tnWeapons.Nodes.Add("Fist Weapons");
            tnWeaponFistWeapons.Tag = new ItemSearchCriteria(GameItemReference.WEAPON, GameItemReference.WEAPON_ONEHAND, GameItemReference.FISTWEAPON);

            TreeNode tnWeaponMiscellaneous = tnWeapons.Nodes.Add("Miscellaneous");
            //tnWeaponMiscellaneous.Tag = new ItemSearchCriteria(GameItemReference.WEAPON, -1, GameItemReference.MISC_OFFHAN);

            TreeNode tnWeaponDaggers = tnWeapons.Nodes.Add("Daggers");
            tnWeaponDaggers.Tag = new ItemSearchCriteria(GameItemReference.WEAPON, GameItemReference.WEAPON_ONEHAND, GameItemReference.DAGGER);

            TreeNode tnWeaponThrown = tnWeapons.Nodes.Add("Thrown");
            tnWeaponThrown.Tag = new ItemSearchCriteria(GameItemReference.WEAPON, GameItemReference.WEAPON_ONEHAND, GameItemReference.SCTHROWN);

            TreeNode tnWeaponCrossBows = tnWeapons.Nodes.Add("CrossBows");
            tnWeaponCrossBows.Tag = new ItemSearchCriteria(GameItemReference.WEAPON, GameItemReference.WEAPON_RANGED_GUNWAND, GameItemReference.CROSSBOW);

            TreeNode tnWeaponWands = tnWeapons.Nodes.Add("Wands");
            tnWeaponWands.Tag = new ItemSearchCriteria(GameItemReference.WEAPON, GameItemReference.WEAPON_RANGED_GUNWAND, GameItemReference.WAND);

            TreeNode tnWeaponFishingPoles = tnWeapons.Nodes.Add("Fishing Poles");
            tnWeaponFishingPoles.Tag = new ItemSearchCriteria(GameItemReference.WEAPON, GameItemReference.WEAPON_TWOHAND, GameItemReference.FISHINGPOLE);

            /* Armor */
            TreeNode tnArmorMiscellaneous = tnArmor.Nodes.Add("Miscellaneous");

            TreeNode tnArmorCloth = tnArmor.Nodes.Add("Cloth");
            tnArmorCloth.Tag = new ItemSearchCriteria(GameItemReference.ARMOR, -1, GameItemReference.SUBCLASS_ARMOR_CLOTH); 

            TreeNode tnArmorLeather = tnArmor.Nodes.Add("Leather");
            tnArmorLeather.Tag = new ItemSearchCriteria(GameItemReference.ARMOR, -1, GameItemReference.SUBCLASS_ARMOR_LEATHER);
            
            TreeNode tnArmorMail = tnArmor.Nodes.Add("Mail");
            tnArmorMail.Tag = new ItemSearchCriteria(GameItemReference.ARMOR, -1, GameItemReference.SUBCLASS_ARMOR_MAIL);
            
            TreeNode tnArmorPlate = tnArmor.Nodes.Add("Plate");
            tnArmorPlate.Tag = new ItemSearchCriteria(GameItemReference.ARMOR, -1, GameItemReference.SUBCLASS_ARMOR_PLATE);
            
            TreeNode tnArmorShields = tnArmor.Nodes.Add("Shields");
            tnArmorShields.Tag = new ItemSearchCriteria(GameItemReference.ARMOR, -1, GameItemReference.SUBCLASS_ARMOR_SHIELD);
            
            TreeNode tnArmorRelic = tnArmor.Nodes.Add("Relic");
            tnArmorRelic.Tag = new ItemSearchCriteria(GameItemReference.ARMOR, -1, GameItemReference.SUBCLASS_ARMOR_RELIC); 

            /* Container (Final) */
            TreeNode tnContainerBag = tnContainer.Nodes.Add("Bag");
            tnContainerBag.Tag = new ItemSearchCriteria(GameItemReference.CONTAINER, GameItemReference.BAG, GameItemReference.SUBCLASS_CONTAINER_BAG);

            TreeNode tnContainerHerbBag = tnContainer.Nodes.Add("Herb Bag");
            tnContainerHerbBag.Tag = new ItemSearchCriteria(GameItemReference.CONTAINER, GameItemReference.BAG, GameItemReference.SUBCLASS_CONTAINER_HERB_BAG);

            TreeNode tnContainerEnchantingBag = tnContainer.Nodes.Add("Enchanting Bag");
            tnContainerEnchantingBag.Tag = new ItemSearchCriteria(GameItemReference.CONTAINER, GameItemReference.BAG, GameItemReference.SUBCLASS_CONTAINER_ENCHANTING_BAG);

            TreeNode tnContainerEngineeringBag = tnContainer.Nodes.Add("Engineering Bag");
            tnContainerEngineeringBag.Tag = new ItemSearchCriteria(GameItemReference.CONTAINER, GameItemReference.BAG, GameItemReference.SUBCLASS_CONTAINER_ENGINEERING_BAG);

            TreeNode tnContainerGemBag = tnContainer.Nodes.Add("Gem Bag");
            tnContainerGemBag.Tag = new ItemSearchCriteria(GameItemReference.CONTAINER, GameItemReference.BAG, GameItemReference.SUBCLASS_CONTAINER_GEM_BAG);

            TreeNode tnContainerMiningBag = tnContainer.Nodes.Add("Mining Bag");
            tnContainerMiningBag.Tag = new ItemSearchCriteria(GameItemReference.CONTAINER, GameItemReference.BAG, GameItemReference.SUBCLASS_CONTAINER_MINING_BAG);

            TreeNode tnContainerLeatherworkingBag = tnContainer.Nodes.Add("Leatherworking Bag");
            tnContainerLeatherworkingBag.Tag = new ItemSearchCriteria(GameItemReference.CONTAINER, GameItemReference.BAG, GameItemReference.SUBCLASS_CONTAINER_LEATHERWORKING_BAG);

            TreeNode tnContainerInscriptionBag = tnContainer.Nodes.Add("Inscription Bag");
            tnContainerInscriptionBag.Tag = new ItemSearchCriteria(GameItemReference.CONTAINER, GameItemReference.BAG, GameItemReference.SUBCLASS_CONTAINER_INSCRIPTION_BAG);

            TreeNode tnContainerTackleBox = tnContainer.Nodes.Add("Tackle Box");
            tnContainerTackleBox.Tag = new ItemSearchCriteria(GameItemReference.CONTAINER, GameItemReference.BAG, GameItemReference.SUBCLASS_CONTAINER_TACKLEBOX_BAG);

            /* Consumables (Final) */
            TreeNode tnConsumableFoodDrink = tnConsumable.Nodes.Add("Food & Drink");
            TreeNode tnConsumablePotion = tnConsumable.Nodes.Add("Potion");
            TreeNode tnConsumableElixir = tnConsumable.Nodes.Add("Elixir");
            TreeNode tnConsumableFlask = tnConsumable.Nodes.Add("Flask");
            TreeNode tnConsumableBandage = tnConsumable.Nodes.Add("Bandage");
            TreeNode tnConsumableItemEnchantment = tnConsumable.Nodes.Add("Item Enchantment");
            TreeNode tnConsumableScroll = tnConsumable.Nodes.Add("Scroll");
            TreeNode tnConsumableOther = tnConsumable.Nodes.Add("Other");

            /* Glyph (Final) */
            TreeNode tnGlyphWarrior = tnGlyph.Nodes.Add("Warrior");
            TreeNode tnGlyphPaladin = tnGlyph.Nodes.Add("Paladin");
            TreeNode tnGlyphHunter = tnGlyph.Nodes.Add("Hunter");
            TreeNode tnGlyphRogue = tnGlyph.Nodes.Add("Rogue");
            TreeNode tnGlyphPriest = tnGlyph.Nodes.Add("Priest");
            TreeNode tnGlyphDeathKnight = tnGlyph.Nodes.Add("Death Knight");
            TreeNode tnGlyphShaman = tnGlyph.Nodes.Add("Shaman");
            TreeNode tnGlyphMage = tnGlyph.Nodes.Add("Mage");
            TreeNode tnGlyphWarlock = tnGlyph.Nodes.Add("Warlock");
            TreeNode tnGlyphMonk = tnGlyph.Nodes.Add("Monk");

            /* Trade Goods (Final) */
            TreeNode tnTradeGoodsElemental = tnTradeGoods.Nodes.Add("Elemental");
            TreeNode tnTradeGoodsCloth = tnTradeGoods.Nodes.Add("Cloth");
            TreeNode tnTradeGoodsLeather = tnTradeGoods.Nodes.Add("Leather");
            TreeNode tnTradeGoodsMetalStone = tnTradeGoods.Nodes.Add("Metal & Stone");
            TreeNode tnTradeGoodsMeat = tnTradeGoods.Nodes.Add("Meat");
            TreeNode tnTradeGoodsHerb = tnTradeGoods.Nodes.Add("Herb");
            TreeNode tnTradeGoodsEnchanting = tnTradeGoods.Nodes.Add("Enchanting");
            TreeNode tnTradeGoodsJewelcrafting = tnTradeGoods.Nodes.Add("Jewelcrafting");
            TreeNode tnTradeGoodsParts = tnTradeGoods.Nodes.Add("Parts");

            /* Recipe (Final) */
            TreeNode tnRecipeBook = tnRecipe.Nodes.Add("Book");
            TreeNode tnRecipeLeatherworking = tnRecipe.Nodes.Add("Leatherworking");
            TreeNode tnRecipeTailoring = tnRecipe.Nodes.Add("Tailoring");
            TreeNode tnRecipeEngineering = tnRecipe.Nodes.Add("Engineering");
            TreeNode tnRecipeBlacksmithing = tnRecipe.Nodes.Add("Blacksmithing");
            TreeNode tnRecipeCooking = tnRecipe.Nodes.Add("Cooking");
            TreeNode tnRecipeAlchemy = tnRecipe.Nodes.Add("Alchemy");
            TreeNode tnRecipeFirstAid = tnRecipe.Nodes.Add("First Aid");
            TreeNode tnRecipeEnchanting = tnRecipe.Nodes.Add("Enchanting");
            TreeNode tnRecipeFishing = tnRecipe.Nodes.Add("Fishing");
            TreeNode tnRecipeJewelcrafting = tnRecipe.Nodes.Add("Jewelcrafting");
            TreeNode tnRecipeInscription = tnRecipe.Nodes.Add("Inscription");

            /* Gem (Final) */
            TreeNode tnGemRed = tnGem.Nodes.Add("Red");
            TreeNode tnGemBlue = tnGem.Nodes.Add("Blue");
            TreeNode tnGemYellow = tnGem.Nodes.Add("Yellow");
            TreeNode tnGemPurple = tnGem.Nodes.Add("Purple");
            TreeNode tnGemGreen = tnGem.Nodes.Add("Green");
            TreeNode tnGemOrange = tnGem.Nodes.Add("Orange");
            TreeNode tnGemMeta = tnGem.Nodes.Add("Meta");
            TreeNode tnGemSimple = tnGem.Nodes.Add("Simple");
            TreeNode tnGemPrismatic = tnGem.Nodes.Add("Prismatic");
            TreeNode tnGemCogWheel = tnGem.Nodes.Add("CogWheel");

            /* Miscellaneous (Final) */
            TreeNode tnMiscellaneousJunk = tnMiscellaneous.Nodes.Add("Junk");
            TreeNode tnMiscellaneousReagent = tnMiscellaneous.Nodes.Add("Reagent");
            TreeNode tnMiscellaneousPet = tnMiscellaneous.Nodes.Add("Pet");
            TreeNode tnMiscellaneousHoliday = tnMiscellaneous.Nodes.Add("Holiday");
            TreeNode tnMiscellaneousOther = tnMiscellaneous.Nodes.Add("Other");
            TreeNode tnMiscellaneousMount = tnMiscellaneous.Nodes.Add("Mount");

            /* Armor Miscellaneous */
            TreeNode tnArmorMiscellaneousHead = tnArmorMiscellaneous.Nodes.Add("Head");
            TreeNode tnArmorMiscellaneousNeck = tnArmorMiscellaneous.Nodes.Add("Neck");
            TreeNode tnArmorMiscellaneousShirt = tnArmorMiscellaneous.Nodes.Add("Shirt");
            TreeNode tnArmorMiscellaneousFinger = tnArmorMiscellaneous.Nodes.Add("Finger");
            TreeNode tnArmorMiscellaneousTrinket = tnArmorMiscellaneous.Nodes.Add("Trinket");
            TreeNode tnArmorMiscellaneousOffHand = tnArmorMiscellaneous.Nodes.Add("Held In Off-Hand");

            /* Armor Cloth */
            TreeNode tnArmorClothHead = tnArmorCloth.Nodes.Add("Head");
            tnArmorClothHead.Tag = new ItemSearchCriteria(GameItemReference.ARMOR, GameItemReference.HEAD, GameItemReference.SUBCLASS_ARMOR_CLOTH); 

            TreeNode tnArmorClothShoulder = tnArmorCloth.Nodes.Add("Shoulder");
            tnArmorClothShoulder.Tag = new ItemSearchCriteria(GameItemReference.ARMOR, GameItemReference.SHOULDER, GameItemReference.SUBCLASS_ARMOR_CLOTH); 

            TreeNode tnArmorClothChest = tnArmorCloth.Nodes.Add("Chest");
            tnArmorClothChest.Tag = new ItemSearchCriteria(GameItemReference.ARMOR, GameItemReference.CHEST, GameItemReference.SUBCLASS_ARMOR_CLOTH);
            
            TreeNode tnArmorClothWaist = tnArmorCloth.Nodes.Add("Waist");
            tnArmorClothWaist.Tag = new ItemSearchCriteria(GameItemReference.ARMOR, GameItemReference.WAIST, GameItemReference.SUBCLASS_ARMOR_CLOTH);
            
            TreeNode tnArmorClothLegs = tnArmorCloth.Nodes.Add("Legs");
            tnArmorClothLegs.Tag = new ItemSearchCriteria(GameItemReference.ARMOR, GameItemReference.LEGS, GameItemReference.SUBCLASS_ARMOR_CLOTH);
            
            TreeNode tnArmorClothFeet = tnArmorCloth.Nodes.Add("Feet");
            tnArmorClothFeet.Tag = new ItemSearchCriteria(GameItemReference.ARMOR, GameItemReference.FEET, GameItemReference.SUBCLASS_ARMOR_CLOTH);
            
            TreeNode tnArmorClothWrist = tnArmorCloth.Nodes.Add("Wrist");
            tnArmorClothWrist.Tag = new ItemSearchCriteria(GameItemReference.ARMOR, GameItemReference.WRIST, GameItemReference.SUBCLASS_ARMOR_CLOTH);
            
            TreeNode tnArmorClothHands = tnArmorCloth.Nodes.Add("Hands");
            tnArmorClothHands.Tag = new ItemSearchCriteria(GameItemReference.ARMOR, GameItemReference.HANDS, GameItemReference.SUBCLASS_ARMOR_CLOTH);
            
            TreeNode tnArmorClothBack = tnArmorCloth.Nodes.Add("Back");
            tnArmorClothBack.Tag = new ItemSearchCriteria(GameItemReference.ARMOR, GameItemReference.BACK, GameItemReference.SUBCLASS_ARMOR_CLOTH); 

            /* Armor Leather */
            TreeNode tnArmorLeatherHead = tnArmorLeather.Nodes.Add("Head");
            tnArmorLeatherHead.Tag = new ItemSearchCriteria(GameItemReference.ARMOR, GameItemReference.HEAD, GameItemReference.SUBCLASS_ARMOR_LEATHER);
            
            TreeNode tnArmorLeatherShoulder = tnArmorLeather.Nodes.Add("Shoulder");
            tnArmorLeatherShoulder.Tag = new ItemSearchCriteria(GameItemReference.ARMOR, GameItemReference.SHOULDER, GameItemReference.SUBCLASS_ARMOR_LEATHER); 

            TreeNode tnArmorLeatherChest = tnArmorLeather.Nodes.Add("Chest");
            tnArmorLeatherChest.Tag = new ItemSearchCriteria(GameItemReference.ARMOR, GameItemReference.CHEST, GameItemReference.SUBCLASS_ARMOR_LEATHER); 

            TreeNode tnArmorLeatherWaist = tnArmorLeather.Nodes.Add("Waist");
            tnArmorLeatherWaist.Tag = new ItemSearchCriteria(GameItemReference.ARMOR, GameItemReference.WAIST, GameItemReference.SUBCLASS_ARMOR_LEATHER);
            
            TreeNode tnArmorLeatherLegs = tnArmorLeather.Nodes.Add("Legs");
            tnArmorLeatherLegs.Tag = new ItemSearchCriteria(GameItemReference.ARMOR, GameItemReference.LEGS, GameItemReference.SUBCLASS_ARMOR_LEATHER);
            
            TreeNode tnArmorLeatherFeet = tnArmorLeather.Nodes.Add("Feet");
            tnArmorLeatherFeet.Tag = new ItemSearchCriteria(GameItemReference.ARMOR, GameItemReference.FEET, GameItemReference.SUBCLASS_ARMOR_LEATHER);
            
            TreeNode tnArmorLeatherWrist = tnArmorLeather.Nodes.Add("Wrist");
            tnArmorLeatherWrist.Tag = new ItemSearchCriteria(GameItemReference.ARMOR, GameItemReference.WRIST, GameItemReference.SUBCLASS_ARMOR_LEATHER);
            
            TreeNode tnArmorLeatherHands = tnArmorLeather.Nodes.Add("Hands");
            tnArmorLeatherHands.Tag = new ItemSearchCriteria(GameItemReference.ARMOR, GameItemReference.HANDS, GameItemReference.SUBCLASS_ARMOR_LEATHER); 

            /* Armor Mail */
            TreeNode tnArmorMailHead = tnArmorMail.Nodes.Add("Head");
            tnArmorMailHead.Tag = new ItemSearchCriteria(GameItemReference.ARMOR, GameItemReference.HEAD, GameItemReference.SUBCLASS_ARMOR_MAIL);
            
            TreeNode tnArmorMailShoulder = tnArmorMail.Nodes.Add("Shoulder");
            tnArmorMailShoulder.Tag = new ItemSearchCriteria(GameItemReference.ARMOR, GameItemReference.SHOULDER, GameItemReference.SUBCLASS_ARMOR_MAIL);
            
            TreeNode tnArmorMailChest = tnArmorMail.Nodes.Add("Chest");
            tnArmorMailChest.Tag = new ItemSearchCriteria(GameItemReference.ARMOR, GameItemReference.CHEST, GameItemReference.SUBCLASS_ARMOR_MAIL);
            
            TreeNode tnArmorMailWaist = tnArmorMail.Nodes.Add("Waist");
            tnArmorMailWaist.Tag = new ItemSearchCriteria(GameItemReference.ARMOR, GameItemReference.WAIST, GameItemReference.SUBCLASS_ARMOR_MAIL);
            
            TreeNode tnArmorMailLegs = tnArmorMail.Nodes.Add("Legs");
            tnArmorMailLegs.Tag = new ItemSearchCriteria(GameItemReference.ARMOR, GameItemReference.LEGS, GameItemReference.SUBCLASS_ARMOR_MAIL);
            
            TreeNode tnArmorMailFeet = tnArmorMail.Nodes.Add("Feet");
            tnArmorMailFeet.Tag = new ItemSearchCriteria(GameItemReference.ARMOR, GameItemReference.FEET, GameItemReference.SUBCLASS_ARMOR_MAIL);
            
            TreeNode tnArmorMailWrist = tnArmorMail.Nodes.Add("Wrist");
            tnArmorMailWrist.Tag = new ItemSearchCriteria(GameItemReference.ARMOR, GameItemReference.WRIST, GameItemReference.SUBCLASS_ARMOR_MAIL);
            
            TreeNode tnArmorMailHands = tnArmorMail.Nodes.Add("Hands");
            tnArmorMailHands.Tag = new ItemSearchCriteria(GameItemReference.ARMOR, GameItemReference.HANDS, GameItemReference.SUBCLASS_ARMOR_MAIL); 

            /* Armor Plate */
            TreeNode tnArmorPlateHead = tnArmorPlate.Nodes.Add("Head");
            tnArmorPlateHead.Tag = new ItemSearchCriteria(GameItemReference.ARMOR, GameItemReference.HEAD, GameItemReference.SUBCLASS_ARMOR_PLATE);
            
            TreeNode tnArmorPlateShoulder = tnArmorPlate.Nodes.Add("Shoulder");
            tnArmorPlateShoulder.Tag = new ItemSearchCriteria(GameItemReference.ARMOR, GameItemReference.SHOULDER, GameItemReference.SUBCLASS_ARMOR_PLATE);
            
            TreeNode tnArmorPlateChest = tnArmorPlate.Nodes.Add("Chest");
            tnArmorPlateChest.Tag = new ItemSearchCriteria(GameItemReference.ARMOR, GameItemReference.CHEST, GameItemReference.SUBCLASS_ARMOR_PLATE);
            
            TreeNode tnArmorPlateWaist = tnArmorPlate.Nodes.Add("Waist");
            tnArmorPlateWaist.Tag = new ItemSearchCriteria(GameItemReference.ARMOR, GameItemReference.WAIST, GameItemReference.SUBCLASS_ARMOR_PLATE);
            
            TreeNode tnArmorPlateLegs = tnArmorPlate.Nodes.Add("Legs");
            tnArmorPlateLegs.Tag = new ItemSearchCriteria(GameItemReference.ARMOR, GameItemReference.LEGS, GameItemReference.SUBCLASS_ARMOR_PLATE);
            
            TreeNode tnArmorPlateFeet = tnArmorPlate.Nodes.Add("Feet");
            tnArmorPlateFeet.Tag = new ItemSearchCriteria(GameItemReference.ARMOR, GameItemReference.FEET, GameItemReference.SUBCLASS_ARMOR_PLATE);
            
            TreeNode tnArmorPlateWrist = tnArmorPlate.Nodes.Add("Wrist");
            tnArmorPlateWrist.Tag = new ItemSearchCriteria(GameItemReference.ARMOR, GameItemReference.WRIST, GameItemReference.SUBCLASS_ARMOR_PLATE);
            
            TreeNode tnArmorPlateHands = tnArmorPlate.Nodes.Add("Hands");
            tnArmorPlateHands.Tag = new ItemSearchCriteria(GameItemReference.ARMOR, GameItemReference.HANDS, GameItemReference.SUBCLASS_ARMOR_PLATE);


            tnAll.Expand();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

            frmMain fMain = (frmMain)this.MdiParent;

            //this.tViewType.SelectedNode.Tag

            if (this.tViewType.SelectedNode.Tag == null)
                return;

            /* concat all actualSQLs */
            FlowLayoutPanel flpItems = this.ucSearchCriteriaSet1.GetAllCriteria();

            String SpecificCriteriaSQL = "";

            if (flpItems.Controls.Count > 0)
            {
                foreach (ucSearchCriteriaItem uItem in flpItems.Controls)
                {
                    if (SpecificCriteriaSQL != "")
                    {
                        SpecificCriteriaSQL = SpecificCriteriaSQL + " AND " + uItem.ActualCriteriaSQL;
                    }
                    else
                    {
                        SpecificCriteriaSQL = uItem.ActualCriteriaSQL;
                    }
                }
            }

            TrinityCore_DBGUI_Library.ItemSearchCriteria iSrchCriteria = (TrinityCore_DBGUI_Library.ItemSearchCriteria)this.tViewType.SelectedNode.Tag;
            
            iSrchCriteria.ExtraSQL = SpecificCriteriaSQL;

            try
            {
                iSrchCriteria.LIMIT_RESULTS = int.Parse(this.txtLimitBy.Text);
            }
            catch (Exception ex)
            {
                iSrchCriteria.LIMIT_RESULTS = 500;
                this.txtLimitBy.Text = "500";
            }

            this.Cursor = Cursors.WaitCursor;
            ArrayList nResults = fMain.trinityCoreController.worldDb.GetGameItemList(iSrchCriteria);
            this.Cursor = Cursors.Default;

            if (nResults.Count < 1)
                return;


            this.lstItemSearchResults.Items.Clear();

            foreach (GameItem gItem in nResults)
            {

                ListViewItem lvItem = new ListViewItem(gItem.EntryID.ToString());

                if (gItem.Quality == GameItemReference.QUALITY_POOR)
                    lvItem.ForeColor = Color.Gray;

                if (gItem.Quality == GameItemReference.QUALITY_COMMON)
                    lvItem.ForeColor = Color.NavajoWhite;

                if (gItem.Quality == GameItemReference.QUALITY_UNCOMMON)
                    lvItem.ForeColor = Color.Green;

                if (gItem.Quality == GameItemReference.QUALITY_RARE)
                    lvItem.ForeColor = Color.Blue;

                if (gItem.Quality == GameItemReference.QUALITY_EPIC)
                    lvItem.ForeColor = Color.Purple;

                if (gItem.Quality == GameItemReference.QUALITY_LEGENDARY)
                    lvItem.ForeColor = Color.Orange;

                if (gItem.Quality == GameItemReference.QUALITY_ARTIFACT)
                    lvItem.ForeColor = Color.LightYellow;

                if (gItem.Quality == GameItemReference.QUALITY_HEIRLOOM)
                    lvItem.ForeColor = Color.Wheat;

                lvItem.SubItems.Add(gItem.Name, Color.Purple, Color.White, null);
                lvItem.SubItems.Add(gItem.ItemLevel.ToString(), Color.Purple, Color.White, null);
                lvItem.SubItems.Add(gItem.RequiredLevel.ToString(), Color.Purple, Color.White, null);

                this.lstItemSearchResults.Items.Add(lvItem);

                this.lblSQLQuery.Text = fMain.trinityCoreController.worldDb.LastSQLQuery;
                this.lblResults.Text = nResults.Count.ToString() + " Results";
            }

        }

        private void ucSearchCriteriaInput1_RequestedAddCriteria(ucSearchCriteriaItem uCriteriaItem)
        {
            this.ucSearchCriteriaSet1.AddCriteria(uCriteriaItem);
        }

        private void createItemSetToolStripMenuItem_MouseHover(object sender, EventArgs e)
        {
            frmMain fMain = (frmMain)this.MdiParent;

            if (this.ItemSetList.Count < 1)
            {
                this.ItemSetList = fMain.trinityCoreController.worldDb.GetItemSetList();
                ToolStripComboBox cboItemList = new ToolStripComboBox();

                foreach (ItemSet iSet in this.ItemSetList)
                {
                    this.cMenuRightClickResultAddtoItemSetItemList.Items.Add(iSet.EntryID + " : " + iSet.Name);
                }
                
            }
        }

        private void viewOnWowHeadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //

            if (this.lstItemSearchResults.SelectedItems.Count < 1)
                return;

            foreach (ListViewItem lvi in this.lstItemSearchResults.SelectedItems)
            {
                System.Diagnostics.Process.Start("http://www.wowhead.com/item=" + lvi.Text);
            }
        }


    }
}
