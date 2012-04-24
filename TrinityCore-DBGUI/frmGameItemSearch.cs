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
            this.ucSearchCriteriaInput1.AddCriteriaType("name", CriteriaRequester.CriteriaType.Text);

            CriteriaRequester cRequester = new CriteriaRequester(CriteriaRequester.CriteriaType.DropDown, "Quality");
            cRequester.DropDownContent.Add("0 : Poor");
            cRequester.DropDownContent.Add("1 : Common");
            cRequester.DropDownContent.Add("2 : Uncommon");
            cRequester.DropDownContent.Add("3 : Rare");
            cRequester.DropDownContent.Add("4 : Epic");
            cRequester.DropDownContent.Add("5 : Legendary");
            cRequester.DropDownContent.Add("6 : Artifact");
            cRequester.DropDownContent.Add("7 : Heirloom");

            this.ucSearchCriteriaInput1.AddCriteriaType(cRequester);

        }

        private void PopulateCategories()
        {
            /* Top Level */
            TreeNode tnWeapons = this.tViewType.Nodes.Add("Weapon"); //class WEAPON            
            tnWeapons.Tag = new ItemSearchCriteria(GameItemReference.WEAPON, -1, -1);

            TreeNode tnArmor = this.tViewType.Nodes.Add("Armor"); //class ARMOR
            tnArmor.Tag = new ItemSearchCriteria(GameItemReference.ARMOR, -1, -1);

            TreeNode tnContainer = this.tViewType.Nodes.Add("Container"); //class CONTAINER
            tnContainer.Tag = new ItemSearchCriteria(GameItemReference.CONTAINER, -1, -1);

            TreeNode tnConsumable = this.tViewType.Nodes.Add("Consumable"); //class CONSUMABLE
            tnConsumable.Tag = new ItemSearchCriteria(GameItemReference.CONSUMABLE, -1, -1);

            TreeNode tnGlyph = this.tViewType.Nodes.Add("Glyph"); //class GLYPH
            tnGlyph.Tag = new ItemSearchCriteria(GameItemReference.GLYPH, -1, -1);

            TreeNode tnTradeGoods = this.tViewType.Nodes.Add("Trade Goods"); //class TRADEGOODS
            tnTradeGoods.Tag = new ItemSearchCriteria(GameItemReference.TRADEGOODS, -1, -1);

            TreeNode tnRecipe = this.tViewType.Nodes.Add("Recipe"); //class RECIPE
            tnTradeGoods.Tag = new ItemSearchCriteria(GameItemReference.RECIPE, -1, -1);

            TreeNode tnGem = this.tViewType.Nodes.Add("Gem"); //class GEM
            tnGem.Tag = new ItemSearchCriteria(GameItemReference.GEM, -1, -1);

            TreeNode tnMiscellaneous = this.tViewType.Nodes.Add("Miscellaneous"); //class MISCCLASS
            tnMiscellaneous.Tag = new ItemSearchCriteria(GameItemReference.MISCCLASS, -1, -1);

            TreeNode tnQuest = this.tViewType.Nodes.Add("Quest"); //class QUEST
            tnQuest.Tag = new ItemSearchCriteria(GameItemReference.QUEST, -1, -1);

            TreeNode tnTokensCurrency = this.tViewType.Nodes.Add("Tokens / Currency"); //class CURRENCYTOKENS
            tnTokensCurrency.Tag = new ItemSearchCriteria(GameItemReference.CURRENCYTOKENS, -1, -1);

            TreeNode tnKey = this.tViewType.Nodes.Add("Key"); //class KEY
            tnKey.Tag = new ItemSearchCriteria(GameItemReference.KEY, -1, -1);

            TreeNode tnProjectile = this.tViewType.Nodes.Add("Projectile"); //class PROJECTILE
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
            TreeNode tnArmorLeather = tnArmor.Nodes.Add("Leather");
            TreeNode tnArmorMail = tnArmor.Nodes.Add("Mail");
            TreeNode tnArmorPlate = tnArmor.Nodes.Add("Plate");
            TreeNode tnArmorShields = tnArmor.Nodes.Add("Shields");
            TreeNode tnArmorRelic = tnArmor.Nodes.Add("Relic");

            /* Container (Final) */
            TreeNode tnContainerBag = tnContainer.Nodes.Add("Bag");
            TreeNode tnContainerHerbBag = tnContainer.Nodes.Add("Herb Bag");
            TreeNode tnContainerEnchantingBag = tnContainer.Nodes.Add("Enchanting Bag");
            TreeNode tnContainerEngineeringBag = tnContainer.Nodes.Add("Engineering Bag");
            TreeNode tnContainerGemBag = tnContainer.Nodes.Add("Gem Bag");
            TreeNode tnContainerMiningBag = tnContainer.Nodes.Add("Mining Bag");
            TreeNode tnContainerLeatherworkingBag = tnContainer.Nodes.Add("Leatherworking Bag");
            TreeNode tnContainerInscriptionBag = tnContainer.Nodes.Add("Inscription Bag");
            TreeNode tnContainerTackleBox = tnContainer.Nodes.Add("Tackle Box");

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
            TreeNode tnArmorClothShoulder = tnArmorCloth.Nodes.Add("Shoulder");
            TreeNode tnArmorClothChest = tnArmorCloth.Nodes.Add("Chest");
            TreeNode tnArmorClothWaist = tnArmorCloth.Nodes.Add("Waist");
            TreeNode tnArmorClothLegs = tnArmorCloth.Nodes.Add("Legs");
            TreeNode tnArmorClothFeet = tnArmorCloth.Nodes.Add("Feet");
            TreeNode tnArmorClothWrist = tnArmorCloth.Nodes.Add("Wrist");
            TreeNode tnArmorClothHands = tnArmorCloth.Nodes.Add("Hands");
            TreeNode tnArmorClothBack = tnArmorCloth.Nodes.Add("Back");

            /* Armor Leather */
            TreeNode tnArmorLeatherHead = tnArmorLeather.Nodes.Add("Head");
            TreeNode tnArmorLeatherShoulder = tnArmorLeather.Nodes.Add("Shoulder");
            TreeNode tnArmorLeatherChest = tnArmorLeather.Nodes.Add("Chest");
            TreeNode tnArmorLeatherWaist = tnArmorLeather.Nodes.Add("Waist");
            TreeNode tnArmorLeatherLegs = tnArmorLeather.Nodes.Add("Legs");
            TreeNode tnArmorLeatherFeet = tnArmorLeather.Nodes.Add("Feet");
            TreeNode tnArmorLeatherWrist = tnArmorLeather.Nodes.Add("Wrist");
            TreeNode tnArmorLeatherHands = tnArmorLeather.Nodes.Add("Hands");

            /* Armor Mail */
            TreeNode tnArmorMailHead = tnArmorMail.Nodes.Add("Head");
            TreeNode tnArmorMailShoulder = tnArmorMail.Nodes.Add("Shoulder");
            TreeNode tnArmorMailChest = tnArmorMail.Nodes.Add("Chest");
            TreeNode tnArmorMailWaist = tnArmorMail.Nodes.Add("Waist");
            TreeNode tnArmorMailLegs = tnArmorMail.Nodes.Add("Legs");
            TreeNode tnArmorMailFeet = tnArmorMail.Nodes.Add("Feet");
            TreeNode tnArmorMailWrist = tnArmorMail.Nodes.Add("Wrist");
            TreeNode tnArmorMailHands = tnArmorMail.Nodes.Add("Hands");

            /* Armor Plate */
            TreeNode tnArmorPlateHead = tnArmorPlate.Nodes.Add("Head");
            TreeNode tnArmorPlateShoulder = tnArmorPlate.Nodes.Add("Shoulder");
            TreeNode tnArmorPlateChest = tnArmorPlate.Nodes.Add("Chest");
            TreeNode tnArmorPlateWaist = tnArmorPlate.Nodes.Add("Waist");
            TreeNode tnArmorPlateLegs = tnArmorPlate.Nodes.Add("Legs");
            TreeNode tnArmorPlateFeet = tnArmorPlate.Nodes.Add("Feet");
            TreeNode tnArmorPlateWrist = tnArmorPlate.Nodes.Add("Wrist");
            TreeNode tnArmorPlateHands = tnArmorPlate.Nodes.Add("Hands");
            

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

            ArrayList nResults = fMain.trinityCoreController.worldDb.GetGameItemList(iSrchCriteria);

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

                this.lstItemSearchResults.Items.Add(lvItem);

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            //ucSearchTest.SetCriteriaText("Test 1 2 3 4 5 6 7");

            //ucSearchCriteriaItem uItem = new ucSearchCriteriaItem();
            //uItem.SetCriteriaText("Name=Test");
            //this.ucSearchCriteriaSet1.AddCriteria(uItem);

        }

        private void ucSearchCriteriaInput1_RequestedAddCriteria(ucSearchCriteriaItem uCriteriaItem)
        {
            this.ucSearchCriteriaSet1.AddCriteria(uCriteriaItem);
        }


    }
}
