using System;

namespace FF2_ShopEditor
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openRomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveRomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.ItemListBox = new System.Windows.Forms.ListBox();
            this.ItemPriceBox = new System.Windows.Forms.TextBox();
            this.SaveAsRom = new System.Windows.Forms.SaveFileDialog();
            this.PriceLabel = new System.Windows.Forms.Label();
            this.UpdateItemPrice = new System.Windows.Forms.Button();
            this.ShopNameComboBox = new System.Windows.Forms.ComboBox();
            this.StoreCostboxA = new System.Windows.Forms.TextBox();
            this.StoreCostboxB = new System.Windows.Forms.TextBox();
            this.StoreCostboxC = new System.Windows.Forms.TextBox();
            this.StoreCostboxD = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ItemAComboBox = new System.Windows.Forms.ComboBox();
            this.ItemBComboBox = new System.Windows.Forms.ComboBox();
            this.ItemCComboBox = new System.Windows.Forms.ComboBox();
            this.ItemDComboBox = new System.Windows.Forms.ComboBox();
            this.UpdateShopButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(631, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openRomToolStripMenuItem,
            this.saveRomToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openRomToolStripMenuItem
            // 
            this.openRomToolStripMenuItem.Name = "openRomToolStripMenuItem";
            this.openRomToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.openRomToolStripMenuItem.Text = "Open Rom";
            this.openRomToolStripMenuItem.Click += new System.EventHandler(this.openRomToolStripMenuItem_Click);
            // 
            // saveRomToolStripMenuItem
            // 
            this.saveRomToolStripMenuItem.Name = "saveRomToolStripMenuItem";
            this.saveRomToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.saveRomToolStripMenuItem.Text = "Save Rom";
            this.saveRomToolStripMenuItem.Click += new System.EventHandler(this.saveRomToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // ItemListBox
            // 
            this.ItemListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ItemListBox.Enabled = false;
            this.ItemListBox.FormattingEnabled = true;
            this.ItemListBox.Items.AddRange(new object[] {
            "Potion",
            "Antidote",
            "Goldpin",
            "Crucifix",
            "Maiden Kiss",
            "Echo Screen",
            "Eye Drop",
            "Pheonix Down",
            "Elixir",
            "Ether",
            "X-Potion",
            "Cottage",
            "WindFlute",
            "Earth Drum",
            "Garlic",
            "Unicorn",
            "Ice Wind",
            "ElderIQ",
            "Heart",
            "Shoes",
            "Thread",
            "Silent Bell",
            "Egg Timer",
            "Death god",
            "Bachhus Wine",
            "Dragon Bean",
            "Valium",
            "Ice Scythe",
            "Fang",
            "Mirror",
            "HellFire",
            "GlitchItem",
            "GlitchItem",
            "Buckler",
            "Bronze Shield",
            "Mithril Shield",
            "Gold Shield",
            "Ice Shield",
            "Flame Shield",
            "Diamond Shield",
            "Dragon Shield",
            "Aegis Shield",
            "Knife",
            "Dagger",
            "Mithril Dagger",
            "Gouche",
            "Orhacon",
            "Ripper",
            "CatClaw",
            "Cane",
            "Mace",
            "Mithril Cane",
            "Were Cane",
            "Magic Cane",
            "Power Cane",
            "Evil Cane",
            "Greed Cane",
            "Diamond Cane",
            "Javelin ",
            "Spear ",
            "Mithril Spear",
            "Trident Spear",
            "Demon Spear",
            "Flame Spear",
            "Ice Spear",
            "Bolt Spear",
            "Holy Spear",
            "Broad Sword",
            "Long Sword",
            "Mithril Sword",
            "Ancient Sword",
            "Sleep Sword",
            "Winged Sword",
            "Blood Sword",
            "Earth Sword",
            "Flame Sword",
            "Ice Sword",
            "Defender",
            "Sun Sword",
            "Xcalibur",
            "Masamune",
            "Axe",
            "Battle Axe",
            "Mithril Axe",
            "Demon Axe",
            "Ogre Axe",
            "Poison Axe",
            "Rune Axe",
            "Bow",
            "Long Bow",
            "Mithril Bow",
            "Blind Bow",
            "Flame Bow",
            "Ice Bow",
            "Killer Bow",
            "Yoichi Bow",
            "Leather H",
            "Bronze H",
            "Mythril H",
            "Giant H",
            "Flame H",
            "Spiral H",
            "Genji H",
            "Spiral LH",
            "Goldpin LH",
            "Ribbon LH",
            "Clothes A",
            "Leather A",
            "Bronze A",
            "Mythril A",
            "Gold A",
            "Knight A",
            "Flame A",
            "Ice A",
            "Diamond A-1 ",
            "Dragon A",
            "Genji A",
            "Copper LA",
            "Silver LA",
            "Ruby LA",
            "Quartz LA",
            "Diamond LA-2",
            "WhtRobe LA",
            "BlkRobe LA",
            "Power LA",
            "Black LA",
            "Leather G",
            "Bronze G",
            "Mythril G",
            "Thief G",
            "Giant G",
            "Ice G",
            "Diamond ",
            "Genji G",
            "Defender G",
            "Power G",
            "Fire Scroll",
            "Bolt Scroll",
            "Ice Scroll",
            "Aero Scroll",
            "Drain Scroll",
            "Osmose Scroll",
            "Flare Scroll",
            "Sleep Scroll",
            "Stone Scroll",
            "Stop Scroll",
            "Charm Scroll",
            "Blind Scroll",
            "Curse Scroll",
            "Toad Scroll",
            "Break Scroll",
            "Death Scroll",
            "Warp Scroll",
            "Berserk Scroll",
            "Haste Scroll",
            "Aura Scroll",
            "Cure Scroll",
            "Life Scroll",
            "Peep Scroll",
            "Heal Scroll",
            "Barrier Scroll",
            "Blink Scroll",
            "Safe Scroll",
            "Shell Scroll",
            "Wall Scroll",
            "Dispel Scroll",
            "Mini Scroll",
            "Mute Scroll",
            "Anti Scroll",
            "Fog Scroll",
            "Slow Scroll",
            "Change Scroll",
            "Fear Scroll",
            "Holy Scroll",
            "Exit Scroll",
            "Ultima Scroll"});
            this.ItemListBox.Location = new System.Drawing.Point(18, 46);
            this.ItemListBox.Name = "ItemListBox";
            this.ItemListBox.Size = new System.Drawing.Size(93, 173);
            this.ItemListBox.TabIndex = 1;
            this.ItemListBox.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // ItemPriceBox
            // 
            this.ItemPriceBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ItemPriceBox.Enabled = false;
            this.ItemPriceBox.Location = new System.Drawing.Point(135, 72);
            this.ItemPriceBox.Name = "ItemPriceBox";
            this.ItemPriceBox.Size = new System.Drawing.Size(62, 20);
            this.ItemPriceBox.TabIndex = 2;
            this.ItemPriceBox.Text = "      N/A";
            // 
            // PriceLabel
            // 
            this.PriceLabel.AutoSize = true;
            this.PriceLabel.Location = new System.Drawing.Point(137, 56);
            this.PriceLabel.Name = "PriceLabel";
            this.PriceLabel.Size = new System.Drawing.Size(57, 13);
            this.PriceLabel.TabIndex = 3;
            this.PriceLabel.Text = "Sell Value:";
            // 
            // UpdateItemPrice
            // 
            this.UpdateItemPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.UpdateItemPrice.Enabled = false;
            this.UpdateItemPrice.Location = new System.Drawing.Point(135, 103);
            this.UpdateItemPrice.Name = "UpdateItemPrice";
            this.UpdateItemPrice.Size = new System.Drawing.Size(62, 23);
            this.UpdateItemPrice.TabIndex = 4;
            this.UpdateItemPrice.Text = "Update";
            this.UpdateItemPrice.UseVisualStyleBackColor = false;
            this.UpdateItemPrice.Click += new System.EventHandler(this.UpdateItemPrice_Click);
            // 
            // ShopNameComboBox
            // 
            this.ShopNameComboBox.Enabled = false;
            this.ShopNameComboBox.FormattingEnabled = true;
            this.ShopNameComboBox.Items.AddRange(new object[] {
            "Altea Weapon",
            "Altea Armor",
            "Altea Magic",
            "Altea Weapon2",
            "Altea Armor2",
            "Gatrea Weapon",
            "Gatrea Armor",
            "Poft Weapon",
            "Poft Armor",
            "Poft Magic",
            "Poft Weapon2",
            "Salamand Weapon",
            "Salamand Armor",
            "Salamand Magic",
            "Bafsk Weapon",
            "Bafsk Armor",
            "Bafsk Magic",
            "Phin Weapon",
            "Phin Armor",
            "Phin Magic",
            "Mysidia Weapon",
            "Mysidia Armor",
            "Mysidia Spell",
            "Topical Isle Shop"});
            this.ShopNameComboBox.Location = new System.Drawing.Point(256, 72);
            this.ShopNameComboBox.Name = "ShopNameComboBox";
            this.ShopNameComboBox.Size = new System.Drawing.Size(125, 21);
            this.ShopNameComboBox.TabIndex = 5;
            this.ShopNameComboBox.SelectedIndexChanged += new System.EventHandler(this.ShopNameComboBox_SelectedIndexChanged);
            // 
            // StoreCostboxA
            // 
            this.StoreCostboxA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.StoreCostboxA.Enabled = false;
            this.StoreCostboxA.Location = new System.Drawing.Point(530, 73);
            this.StoreCostboxA.Name = "StoreCostboxA";
            this.StoreCostboxA.Size = new System.Drawing.Size(63, 20);
            this.StoreCostboxA.TabIndex = 6;
            this.StoreCostboxA.Text = "$a";
            // 
            // StoreCostboxB
            // 
            this.StoreCostboxB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.StoreCostboxB.Enabled = false;
            this.StoreCostboxB.Location = new System.Drawing.Point(530, 113);
            this.StoreCostboxB.Name = "StoreCostboxB";
            this.StoreCostboxB.Size = new System.Drawing.Size(63, 20);
            this.StoreCostboxB.TabIndex = 7;
            this.StoreCostboxB.Text = "$b";
            // 
            // StoreCostboxC
            // 
            this.StoreCostboxC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.StoreCostboxC.Enabled = false;
            this.StoreCostboxC.Location = new System.Drawing.Point(530, 151);
            this.StoreCostboxC.Name = "StoreCostboxC";
            this.StoreCostboxC.Size = new System.Drawing.Size(63, 20);
            this.StoreCostboxC.TabIndex = 8;
            this.StoreCostboxC.Text = "$c";
            // 
            // StoreCostboxD
            // 
            this.StoreCostboxD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.StoreCostboxD.Enabled = false;
            this.StoreCostboxD.Location = new System.Drawing.Point(530, 191);
            this.StoreCostboxD.Name = "StoreCostboxD";
            this.StoreCostboxD.Size = new System.Drawing.Size(63, 20);
            this.StoreCostboxD.TabIndex = 9;
            this.StoreCostboxD.Text = "$d";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(265, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Shop:";
            // 
            // ItemAComboBox
            // 
            this.ItemAComboBox.Enabled = false;
            this.ItemAComboBox.FormattingEnabled = true;
            this.ItemAComboBox.Items.AddRange(new object[] {
            "Nothing",
            "Ring",
            "Canoe",
            "Pass",
            "Mithril",
            "Ice Sled",
            "Goddess Bell",
            "Egil Torch",
            "Sun Flame",
            "Pendant",
            "Egg",
            "White Mask",
            "Black Mask",
            "Crystal Rod",
            "Hiryuu",
            "GlitchItem",
            "Potion",
            "Antidote",
            "Goldpin",
            "Crucifix",
            "Maiden Kiss",
            "Echo Screen",
            "Eye Drop",
            "Pheonix Down",
            "Elixir",
            "Ether",
            "X-Potion",
            "Cottage",
            "WindFlute",
            "Earth Drum",
            "Garlic",
            "Unicorn",
            "Ice Wind",
            "ElderIQ",
            "Heart",
            "Shoes",
            "Thread",
            "Silent Bell",
            "Egg Timer",
            "Death god",
            "Bachhus Wine",
            "Dragon Bean",
            "Valium",
            "Ice Scythe",
            "Fang",
            "Mirror",
            "HellFire",
            "GlitchItem",
            "GlitchItem",
            "Buckler",
            "Bronze Shield",
            "Mithril Shield",
            "Gold Shield",
            "Ice Shield",
            "Flame Shield",
            "Diamond Shield",
            "Dragon Shield",
            "Aegis Shield",
            "Knife",
            "Dagger",
            "Mithril Dagger",
            "Gouche",
            "Orhacon",
            "Ripper",
            "CatClaw",
            "Cane",
            "Mace",
            "Mithril Cane",
            "Were Cane",
            "Magic Cane",
            "Power Cane",
            "Evil Cane",
            "Greed Cane",
            "Diamond Cane",
            "Javelin ",
            "Spear ",
            "Mithril Spear",
            "Trident Spear",
            "Demon Spear",
            "Flame Spear",
            "Ice Spear",
            "Bolt Spear",
            "Holy Spear",
            "Broad Sword",
            "Long Sword",
            "Mithril Sword",
            "Ancient Sword",
            "Sleep Sword",
            "Winged Sword",
            "Blood Sword",
            "Earth Sword",
            "Flame Sword",
            "Ice Sword",
            "Defender",
            "Sun Sword",
            "Xcalibur",
            "Masamune",
            "Axe",
            "Battle Axe",
            "Mithril Axe",
            "Demon Axe",
            "Ogre Axe",
            "Poison Axe",
            "Rune Axe",
            "Bow",
            "Long Bow",
            "Mithril Bow",
            "Blind Bow",
            "Flame Bow",
            "Ice Bow",
            "Killer Bow",
            "Yoichi Bow",
            "Leather H",
            "Bronze H",
            "Mythril H",
            "Giant H",
            "Flame H",
            "Spiral H",
            "Genji H",
            "Spiral LH",
            "Goldpin LH",
            "Ribbon LH",
            "Clothes A",
            "Leather A",
            "Bronze A",
            "Mythril A",
            "Gold A",
            "Knight A",
            "Flame A",
            "Ice A",
            "Diamond A-1 ",
            "Dragon A",
            "Genji A",
            "Copper LA",
            "Silver LA",
            "Ruby LA",
            "Quartz LA",
            "Diamond LA-2",
            "WhtRobe LA",
            "BlkRobe LA",
            "Power LA",
            "Black LA",
            "Leather G",
            "Bronze G",
            "Mythril G",
            "Thief G",
            "Giant G",
            "Ice G",
            "Diamond ",
            "Genji G",
            "Defender G",
            "Power G",
            "Fire Scroll",
            "Bolt Scroll",
            "Ice Scroll",
            "Aero Scroll",
            "Drain Scroll",
            "Osmose Scroll",
            "Flare Scroll",
            "Sleep Scroll",
            "Stone Scroll",
            "Stop Scroll",
            "Charm Scroll",
            "Blind Scroll",
            "Curse Scroll",
            "Toad Scroll",
            "Break Scroll",
            "Death Scroll",
            "Warp Scroll",
            "Berserk Scroll",
            "Haste Scroll",
            "Aura Scroll",
            "Cure Scroll",
            "Life Scroll",
            "Peep Scroll",
            "Heal Scroll",
            "Barrier Scroll",
            "Blink Scroll",
            "Safe Scroll",
            "Shell Scroll",
            "Wall Scroll",
            "Dispel Scroll",
            "Mini Scroll",
            "Mute Scroll",
            "Anti Scroll",
            "Fog Scroll",
            "Slow Scroll",
            "Change Scroll",
            "Fear Scroll",
            "Holy Scroll",
            "Exit Scroll",
            "Ultima Scroll"});
            this.ItemAComboBox.Location = new System.Drawing.Point(412, 72);
            this.ItemAComboBox.Name = "ItemAComboBox";
            this.ItemAComboBox.Size = new System.Drawing.Size(112, 21);
            this.ItemAComboBox.TabIndex = 11;
            // 
            // ItemBComboBox
            // 
            this.ItemBComboBox.Enabled = false;
            this.ItemBComboBox.FormattingEnabled = true;
            this.ItemBComboBox.Items.AddRange(new object[] {
            "Nothing",
            "Ring",
            "Canoe",
            "Pass",
            "Mithril",
            "Ice Sled",
            "Goddess Bell",
            "Egil Torch",
            "Sun Flame",
            "Pendant",
            "Egg",
            "White Mask",
            "Black Mask",
            "Crystal Rod",
            "Hiryuu",
            "GlitchItem",
            "Potion",
            "Antidote",
            "Goldpin",
            "Crucifix",
            "Maiden Kiss",
            "Echo Screen",
            "Eye Drop",
            "Pheonix Down",
            "Elixir",
            "Ether",
            "X-Potion",
            "Cottage",
            "WindFlute",
            "Earth Drum",
            "Garlic",
            "Unicorn",
            "Ice Wind",
            "ElderIQ",
            "Heart",
            "Shoes",
            "Thread",
            "Silent Bell",
            "Egg Timer",
            "Death god",
            "Bachhus Wine",
            "Dragon Bean",
            "Valium",
            "Ice Scythe",
            "Fang",
            "Mirror",
            "HellFire",
            "GlitchItem",
            "GlitchItem",
            "Buckler",
            "Bronze Shield",
            "Mithril Shield",
            "Gold Shield",
            "Ice Shield",
            "Flame Shield",
            "Diamond Shield",
            "Dragon Shield",
            "Aegis Shield",
            "Knife",
            "Dagger",
            "Mithril Dagger",
            "Gouche",
            "Orhacon",
            "Ripper",
            "CatClaw",
            "Cane",
            "Mace",
            "Mithril Cane",
            "Were Cane",
            "Magic Cane",
            "Power Cane",
            "Evil Cane",
            "Greed Cane",
            "Diamond Cane",
            "Javelin ",
            "Spear ",
            "Mithril Spear",
            "Trident Spear",
            "Demon Spear",
            "Flame Spear",
            "Ice Spear",
            "Bolt Spear",
            "Holy Spear",
            "Broad Sword",
            "Long Sword",
            "Mithril Sword",
            "Ancient Sword",
            "Sleep Sword",
            "Winged Sword",
            "Blood Sword",
            "Earth Sword",
            "Flame Sword",
            "Ice Sword",
            "Defender",
            "Sun Sword",
            "Xcalibur",
            "Masamune",
            "Axe",
            "Battle Axe",
            "Mithril Axe",
            "Demon Axe",
            "Ogre Axe",
            "Poison Axe",
            "Rune Axe",
            "Bow",
            "Long Bow",
            "Mithril Bow",
            "Blind Bow",
            "Flame Bow",
            "Ice Bow",
            "Killer Bow",
            "Yoichi Bow",
            "Leather H",
            "Bronze H",
            "Mythril H",
            "Giant H",
            "Flame H",
            "Spiral H",
            "Genji H",
            "Spiral LH",
            "Goldpin LH",
            "Ribbon LH",
            "Clothes A",
            "Leather A",
            "Bronze A",
            "Mythril A",
            "Gold A",
            "Knight A",
            "Flame A",
            "Ice A",
            "Diamond A-1 ",
            "Dragon A",
            "Genji A",
            "Copper LA",
            "Silver LA",
            "Ruby LA",
            "Quartz LA",
            "Diamond LA-2",
            "WhtRobe LA",
            "BlkRobe LA",
            "Power LA",
            "Black LA",
            "Leather G",
            "Bronze G",
            "Mythril G",
            "Thief G",
            "Giant G",
            "Ice G",
            "Diamond ",
            "Genji G",
            "Defender G",
            "Power G",
            "Fire Scroll",
            "Bolt Scroll",
            "Ice Scroll",
            "Aero Scroll",
            "Drain Scroll",
            "Osmose Scroll",
            "Flare Scroll",
            "Sleep Scroll",
            "Stone Scroll",
            "Stop Scroll",
            "Charm Scroll",
            "Blind Scroll",
            "Curse Scroll",
            "Toad Scroll",
            "Break Scroll",
            "Death Scroll",
            "Warp Scroll",
            "Berserk Scroll",
            "Haste Scroll",
            "Aura Scroll",
            "Cure Scroll",
            "Life Scroll",
            "Peep Scroll",
            "Heal Scroll",
            "Barrier Scroll",
            "Blink Scroll",
            "Safe Scroll",
            "Shell Scroll",
            "Wall Scroll",
            "Dispel Scroll",
            "Mini Scroll",
            "Mute Scroll",
            "Anti Scroll",
            "Fog Scroll",
            "Slow Scroll",
            "Change Scroll",
            "Fear Scroll",
            "Holy Scroll",
            "Exit Scroll",
            "Ultima Scroll"});
            this.ItemBComboBox.Location = new System.Drawing.Point(412, 113);
            this.ItemBComboBox.Name = "ItemBComboBox";
            this.ItemBComboBox.Size = new System.Drawing.Size(112, 21);
            this.ItemBComboBox.TabIndex = 12;
            // 
            // ItemCComboBox
            // 
            this.ItemCComboBox.Enabled = false;
            this.ItemCComboBox.FormattingEnabled = true;
            this.ItemCComboBox.Items.AddRange(new object[] {
            "Nothing",
            "Ring",
            "Canoe",
            "Pass",
            "Mithril",
            "Ice Sled",
            "Goddess Bell",
            "Egil Torch",
            "Sun Flame",
            "Pendant",
            "Egg",
            "White Mask",
            "Black Mask",
            "Crystal Rod",
            "Hiryuu",
            "GlitchItem",
            "Potion",
            "Antidote",
            "Goldpin",
            "Crucifix",
            "Maiden Kiss",
            "Echo Screen",
            "Eye Drop",
            "Pheonix Down",
            "Elixir",
            "Ether",
            "X-Potion",
            "Cottage",
            "WindFlute",
            "Earth Drum",
            "Garlic",
            "Unicorn",
            "Ice Wind",
            "ElderIQ",
            "Heart",
            "Shoes",
            "Thread",
            "Silent Bell",
            "Egg Timer",
            "Death god",
            "Bachhus Wine",
            "Dragon Bean",
            "Valium",
            "Ice Scythe",
            "Fang",
            "Mirror",
            "HellFire",
            "GlitchItem",
            "GlitchItem",
            "Buckler",
            "Bronze Shield",
            "Mithril Shield",
            "Gold Shield",
            "Ice Shield",
            "Flame Shield",
            "Diamond Shield",
            "Dragon Shield",
            "Aegis Shield",
            "Knife",
            "Dagger",
            "Mithril Dagger",
            "Gouche",
            "Orhacon",
            "Ripper",
            "CatClaw",
            "Cane",
            "Mace",
            "Mithril Cane",
            "Were Cane",
            "Magic Cane",
            "Power Cane",
            "Evil Cane",
            "Greed Cane",
            "Diamond Cane",
            "Javelin ",
            "Spear ",
            "Mithril Spear",
            "Trident Spear",
            "Demon Spear",
            "Flame Spear",
            "Ice Spear",
            "Bolt Spear",
            "Holy Spear",
            "Broad Sword",
            "Long Sword",
            "Mithril Sword",
            "Ancient Sword",
            "Sleep Sword",
            "Winged Sword",
            "Blood Sword",
            "Earth Sword",
            "Flame Sword",
            "Ice Sword",
            "Defender",
            "Sun Sword",
            "Xcalibur",
            "Masamune",
            "Axe",
            "Battle Axe",
            "Mithril Axe",
            "Demon Axe",
            "Ogre Axe",
            "Poison Axe",
            "Rune Axe",
            "Bow",
            "Long Bow",
            "Mithril Bow",
            "Blind Bow",
            "Flame Bow",
            "Ice Bow",
            "Killer Bow",
            "Yoichi Bow",
            "Leather H",
            "Bronze H",
            "Mythril H",
            "Giant H",
            "Flame H",
            "Spiral H",
            "Genji H",
            "Spiral LH",
            "Goldpin LH",
            "Ribbon LH",
            "Clothes A",
            "Leather A",
            "Bronze A",
            "Mythril A",
            "Gold A",
            "Knight A",
            "Flame A",
            "Ice A",
            "Diamond A-1 ",
            "Dragon A",
            "Genji A",
            "Copper LA",
            "Silver LA",
            "Ruby LA",
            "Quartz LA",
            "Diamond LA-2",
            "WhtRobe LA",
            "BlkRobe LA",
            "Power LA",
            "Black LA",
            "Leather G",
            "Bronze G",
            "Mythril G",
            "Thief G",
            "Giant G",
            "Ice G",
            "Diamond ",
            "Genji G",
            "Defender G",
            "Power G",
            "Fire Scroll",
            "Bolt Scroll",
            "Ice Scroll",
            "Aero Scroll",
            "Drain Scroll",
            "Osmose Scroll",
            "Flare Scroll",
            "Sleep Scroll",
            "Stone Scroll",
            "Stop Scroll",
            "Charm Scroll",
            "Blind Scroll",
            "Curse Scroll",
            "Toad Scroll",
            "Break Scroll",
            "Death Scroll",
            "Warp Scroll",
            "Berserk Scroll",
            "Haste Scroll",
            "Aura Scroll",
            "Cure Scroll",
            "Life Scroll",
            "Peep Scroll",
            "Heal Scroll",
            "Barrier Scroll",
            "Blink Scroll",
            "Safe Scroll",
            "Shell Scroll",
            "Wall Scroll",
            "Dispel Scroll",
            "Mini Scroll",
            "Mute Scroll",
            "Anti Scroll",
            "Fog Scroll",
            "Slow Scroll",
            "Change Scroll",
            "Fear Scroll",
            "Holy Scroll",
            "Exit Scroll",
            "Ultima Scroll"});
            this.ItemCComboBox.Location = new System.Drawing.Point(412, 151);
            this.ItemCComboBox.Name = "ItemCComboBox";
            this.ItemCComboBox.Size = new System.Drawing.Size(112, 21);
            this.ItemCComboBox.TabIndex = 13;
            // 
            // ItemDComboBox
            // 
            this.ItemDComboBox.Enabled = false;
            this.ItemDComboBox.FormattingEnabled = true;
            this.ItemDComboBox.Items.AddRange(new object[] {
            "Nothing",
            "Ring",
            "Canoe",
            "Pass",
            "Mithril",
            "Ice Sled",
            "Goddess Bell",
            "Egil Torch",
            "Sun Flame",
            "Pendant",
            "Egg",
            "White Mask",
            "Black Mask",
            "Crystal Rod",
            "Hiryuu",
            "GlitchItem",
            "Potion",
            "Antidote",
            "Goldpin",
            "Crucifix",
            "Maiden Kiss",
            "Echo Screen",
            "Eye Drop",
            "Pheonix Down",
            "Elixir",
            "Ether",
            "X-Potion",
            "Cottage",
            "WindFlute",
            "Earth Drum",
            "Garlic",
            "Unicorn",
            "Ice Wind",
            "ElderIQ",
            "Heart",
            "Shoes",
            "Thread",
            "Silent Bell",
            "Egg Timer",
            "Death god",
            "Bachhus Wine",
            "Dragon Bean",
            "Valium",
            "Ice Scythe",
            "Fang",
            "Mirror",
            "HellFire",
            "GlitchItem",
            "GlitchItem",
            "Buckler",
            "Bronze Shield",
            "Mithril Shield",
            "Gold Shield",
            "Ice Shield",
            "Flame Shield",
            "Diamond Shield",
            "Dragon Shield",
            "Aegis Shield",
            "Knife",
            "Dagger",
            "Mithril Dagger",
            "Gouche",
            "Orhacon",
            "Ripper",
            "CatClaw",
            "Cane",
            "Mace",
            "Mithril Cane",
            "Were Cane",
            "Magic Cane",
            "Power Cane",
            "Evil Cane",
            "Greed Cane",
            "Diamond Cane",
            "Javelin ",
            "Spear ",
            "Mithril Spear",
            "Trident Spear",
            "Demon Spear",
            "Flame Spear",
            "Ice Spear",
            "Bolt Spear",
            "Holy Spear",
            "Broad Sword",
            "Long Sword",
            "Mithril Sword",
            "Ancient Sword",
            "Sleep Sword",
            "Winged Sword",
            "Blood Sword",
            "Earth Sword",
            "Flame Sword",
            "Ice Sword",
            "Defender",
            "Sun Sword",
            "Xcalibur",
            "Masamune",
            "Axe",
            "Battle Axe",
            "Mithril Axe",
            "Demon Axe",
            "Ogre Axe",
            "Poison Axe",
            "Rune Axe",
            "Bow",
            "Long Bow",
            "Mithril Bow",
            "Blind Bow",
            "Flame Bow",
            "Ice Bow",
            "Killer Bow",
            "Yoichi Bow",
            "Leather H",
            "Bronze H",
            "Mythril H",
            "Giant H",
            "Flame H",
            "Spiral H",
            "Genji H",
            "Spiral LH",
            "Goldpin LH",
            "Ribbon LH",
            "Clothes A",
            "Leather A",
            "Bronze A",
            "Mythril A",
            "Gold A",
            "Knight A",
            "Flame A",
            "Ice A",
            "Diamond A-1 ",
            "Dragon A",
            "Genji A",
            "Copper LA",
            "Silver LA",
            "Ruby LA",
            "Quartz LA",
            "Diamond LA-2",
            "WhtRobe LA",
            "BlkRobe LA",
            "Power LA",
            "Black LA",
            "Leather G",
            "Bronze G",
            "Mythril G",
            "Thief G",
            "Giant G",
            "Ice G",
            "Diamond ",
            "Genji G",
            "Defender G",
            "Power G",
            "Fire Scroll",
            "Bolt Scroll",
            "Ice Scroll",
            "Aero Scroll",
            "Drain Scroll",
            "Osmose Scroll",
            "Flare Scroll",
            "Sleep Scroll",
            "Stone Scroll",
            "Stop Scroll",
            "Charm Scroll",
            "Blind Scroll",
            "Curse Scroll",
            "Toad Scroll",
            "Break Scroll",
            "Death Scroll",
            "Warp Scroll",
            "Berserk Scroll",
            "Haste Scroll",
            "Aura Scroll",
            "Cure Scroll",
            "Life Scroll",
            "Peep Scroll",
            "Heal Scroll",
            "Barrier Scroll",
            "Blink Scroll",
            "Safe Scroll",
            "Shell Scroll",
            "Wall Scroll",
            "Dispel Scroll",
            "Mini Scroll",
            "Mute Scroll",
            "Anti Scroll",
            "Fog Scroll",
            "Slow Scroll",
            "Change Scroll",
            "Fear Scroll",
            "Holy Scroll",
            "Exit Scroll",
            "Ultima Scroll"});
            this.ItemDComboBox.Location = new System.Drawing.Point(412, 191);
            this.ItemDComboBox.Name = "ItemDComboBox";
            this.ItemDComboBox.Size = new System.Drawing.Size(112, 21);
            this.ItemDComboBox.TabIndex = 14;
            // 
            // UpdateShopButton
            // 
            this.UpdateShopButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.UpdateShopButton.Enabled = false;
            this.UpdateShopButton.Location = new System.Drawing.Point(268, 189);
            this.UpdateShopButton.Name = "UpdateShopButton";
            this.UpdateShopButton.Size = new System.Drawing.Size(98, 23);
            this.UpdateShopButton.TabIndex = 15;
            this.UpdateShopButton.Text = "Update Shop";
            this.UpdateShopButton.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(436, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Item for Sale:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(539, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "CostID:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(631, 229);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.UpdateShopButton);
            this.Controls.Add(this.ItemDComboBox);
            this.Controls.Add(this.ItemCComboBox);
            this.Controls.Add(this.ItemBComboBox);
            this.Controls.Add(this.ItemAComboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.StoreCostboxD);
            this.Controls.Add(this.StoreCostboxC);
            this.Controls.Add(this.StoreCostboxB);
            this.Controls.Add(this.StoreCostboxA);
            this.Controls.Add(this.ShopNameComboBox);
            this.Controls.Add(this.UpdateItemPrice);
            this.Controls.Add(this.PriceLabel);
            this.Controls.Add(this.ItemPriceBox);
            this.Controls.Add(this.ItemListBox);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "FF2 Shop Editor";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openRomToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveRomToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ListBox ItemListBox;
        private System.Windows.Forms.TextBox ItemPriceBox;
        private System.Windows.Forms.SaveFileDialog SaveAsRom;
        private System.Windows.Forms.Label PriceLabel;
        private System.Windows.Forms.Button UpdateItemPrice;
        private System.Windows.Forms.ComboBox ShopNameComboBox;
        private System.Windows.Forms.TextBox StoreCostboxA;
        private System.Windows.Forms.TextBox StoreCostboxB;
        private System.Windows.Forms.TextBox StoreCostboxC;
        private System.Windows.Forms.TextBox StoreCostboxD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ItemAComboBox;
        private System.Windows.Forms.ComboBox ItemBComboBox;
        private System.Windows.Forms.ComboBox ItemCComboBox;
        private System.Windows.Forms.ComboBox ItemDComboBox;
        private System.Windows.Forms.Button UpdateShopButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }


    public static class PRG
    {

        public static byte[] ROM;
        public static int ItemOffset = 0x38030;
        public static int CurrentIndex;
        public static byte HiByte;
        public static byte LoByte;
        public static byte[] RealPrice = new byte[2];

        public static int ShopOffset = 0x3861D;
        public static int ShopIndex = 0;
    }
}

