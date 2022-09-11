using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Xml;

namespace Elfie_city;

public class FormMenu : Form
{
	private XmlDocument xDoc = new XmlDocument();

	public static string first_part = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..\\..\\"));

	public static string path = first_part + "/data.xml";

	private IContainer components = null;

	private Button buttonSave;

	private Button buttonLoad;

	private Button buttonExit;

	private TextBox textBoxSaveName;

	public FormMenu()
	{
		InitializeComponent();
	}

	private void buttonExit_Click(object sender, EventArgs e)
	{
		((Form)this).Close();
	}

	private void buttonSave_Click(object sender, EventArgs e)
	{
		//IL_0521: Unknown result type (might be due to invalid IL or missing references)
		xDoc.Load(path);
		XmlNode xmlNode = xDoc.CreateElement("save");
		XmlNode xmlNode2 = xDoc.CreateElement("saveName");
		XmlNode xmlNode3 = xDoc.CreateElement("resources");
		XmlNode xmlNode4 = xDoc.CreateElement("food");
		XmlNode xmlNode5 = xDoc.CreateElement("wood");
		XmlNode xmlNode6 = xDoc.CreateElement("stone");
		XmlNode xmlNode7 = xDoc.CreateElement("iron");
		XmlNode xmlNode8 = xDoc.CreateElement("crystals");
		XmlNode xmlNode9 = xDoc.CreateElement("population");
		XmlNode xmlNode10 = xDoc.CreateElement("elvishBuildings");
		XmlNode xmlNode11 = xDoc.CreateElement("huntingBuild");
		XmlNode xmlNode12 = xDoc.CreateElement("woodshet");
		XmlNode xmlNode13 = xDoc.CreateElement("quarry");
		XmlNode xmlNode14 = xDoc.CreateElement("ironWorks");
		XmlNode xmlNode15 = xDoc.CreateElement("crystalMine");
		XmlNode xmlNode16 = xDoc.CreateElement("houses");
		XmlNode xmlNode17 = xDoc.CreateElement("temple");
		XmlNode xmlNode18 = xDoc.CreateElement("elvishBuilding");
		XmlNode xmlNode19 = xDoc.CreateElement("martialArtsSchool");
		XmlNode xmlNode20 = xDoc.CreateElement("infrastructure");
		XmlNode xmlNode21 = xDoc.CreateElement("elvishUnits");
		XmlNode xmlNode22 = xDoc.CreateElement("elvishArcher");
		XmlNode xmlNode23 = xDoc.CreateElement("elvishWarrior");
		XmlNode xmlNode24 = xDoc.CreateElement("elvishMaster");
		XmlNode xmlNode25 = xDoc.CreateElement("orcishUnits");
		XmlNode xmlNode26 = xDoc.CreateElement("orcishCrossbowman");
		XmlNode xmlNode27 = xDoc.CreateElement("orcishWarrior");
		XmlNode xmlNode28 = xDoc.CreateElement("orcishCommander");
		XmlNode xmlNode29 = xDoc.CreateElement("battleCounter");
		xmlNode2.InnerText = ((Control)textBoxSaveName).get_Text();
		xmlNode4.InnerXml = Resources.ResourcesFood.ToString();
		xmlNode5.InnerXml = Resources.ResourcesWood.ToString();
		xmlNode6.InnerXml = Resources.ResoucresStone.ToString();
		xmlNode7.InnerXml = Resources.ResoucresIron.ToString();
		xmlNode8.InnerXml = Resources.ResoucresCrystals.ToString();
		xmlNode9.InnerXml = Resources.Population.ToString();
		xmlNode11.InnerXml = ElvishBuildings.LevelOfHuntingBuilding.ToString();
		xmlNode12.InnerXml = ElvishBuildings.LevelOfWoodshet.ToString();
		xmlNode13.InnerXml = ElvishBuildings.LevelOfWoodshet.ToString();
		xmlNode14.InnerXml = ElvishBuildings.LevelOfIronWorks.ToString();
		xmlNode15.InnerXml = ElvishBuildings.LevelOfCrystalMine.ToString();
		xmlNode16.InnerXml = ElvishBuildings.LevelOfHouses.ToString();
		xmlNode17.InnerXml = ElvishBuildings.LevelOfTemple.ToString();
		xmlNode18.InnerXml = ElvishBuildings.LevelOfElvishBuilding.ToString();
		xmlNode19.InnerXml = ElvishBuildings.LevelOfMartialArtsSchool.ToString();
		xmlNode20.InnerXml = ElvishBuildings.LevelOfInfrastructure.ToString();
		xmlNode22.InnerXml = ElvishArcher.ElvishList.Count.ToString();
		xmlNode23.InnerXml = ElvishWarrior.ElvishList.Count.ToString();
		xmlNode24.InnerXml = ElvishMaster.ElvishList.Count.ToString();
		xmlNode26.InnerXml = OrcishCrossbowman.OrcishList.Count.ToString();
		xmlNode27.InnerXml = OrcishWarrior.OrcishList.Count.ToString();
		xmlNode28.InnerXml = OrcishCommander.OrcishList.Count.ToString();
		xmlNode29.InnerXml = OrcsAttack.battleCounter.ToString();
		xmlNode3.AppendChild(xmlNode4);
		xmlNode3.AppendChild(xmlNode5);
		xmlNode3.AppendChild(xmlNode6);
		xmlNode3.AppendChild(xmlNode7);
		xmlNode3.AppendChild(xmlNode8);
		xmlNode3.AppendChild(xmlNode9);
		xmlNode10.AppendChild(xmlNode11);
		xmlNode10.AppendChild(xmlNode12);
		xmlNode10.AppendChild(xmlNode13);
		xmlNode10.AppendChild(xmlNode14);
		xmlNode10.AppendChild(xmlNode15);
		xmlNode10.AppendChild(xmlNode16);
		xmlNode10.AppendChild(xmlNode17);
		xmlNode10.AppendChild(xmlNode18);
		xmlNode10.AppendChild(xmlNode19);
		xmlNode10.AppendChild(xmlNode20);
		xmlNode21.AppendChild(xmlNode22);
		xmlNode21.AppendChild(xmlNode23);
		xmlNode21.AppendChild(xmlNode24);
		xmlNode25.AppendChild(xmlNode26);
		xmlNode25.AppendChild(xmlNode27);
		xmlNode25.AppendChild(xmlNode28);
		xmlNode.AppendChild(xmlNode2);
		xmlNode.AppendChild(xmlNode3);
		xmlNode.AppendChild(xmlNode10);
		xmlNode.AppendChild(xmlNode21);
		xmlNode.AppendChild(xmlNode25);
		xmlNode.AppendChild(xmlNode29);
		xDoc.DocumentElement!.AppendChild(xmlNode);
		xDoc.Save(path);
		((Form)this).Close();
		MessageBox.Show("Zapisano!", "Informacja", (MessageBoxButtons)0, (MessageBoxIcon)64);
	}

	private void buttonLoad_Click(object sender, EventArgs e)
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0359: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			xDoc.Load(path);
		}
		catch
		{
			MessageBox.Show("Otworzenie pliku z zapisami nie powiodło sie", "Informacja", (MessageBoxButtons)0, (MessageBoxIcon)16);
		}
		foreach (XmlNode item in xDoc.SelectNodes("saves/save")!)
		{
			if (item.SelectSingleNode("saveName")!.InnerText == ((Control)textBoxSaveName).get_Text())
			{
				Resources.ResourcesFood = int.Parse(item.SelectSingleNode("resources/food")!.InnerXml);
				Resources.ResourcesWood = int.Parse(item.SelectSingleNode("resources/wood")!.InnerXml);
				Resources.ResoucresStone = int.Parse(item.SelectSingleNode("resources/stone")!.InnerXml);
				Resources.ResoucresIron = int.Parse(item.SelectSingleNode("resources/iron")!.InnerXml);
				Resources.ResoucresCrystals = int.Parse(item.SelectSingleNode("resources/crystals")!.InnerXml);
				Resources.Population = int.Parse(item.SelectSingleNode("resources/population")!.InnerXml);
				ElvishBuildings.LevelOfHuntingBuilding = int.Parse(item.SelectSingleNode("elvishBuildings/huntingBuild")!.InnerXml);
				ElvishBuildings.LevelOfWoodshet = int.Parse(item.SelectSingleNode("elvishBuildings/woodshet")!.InnerXml);
				ElvishBuildings.LevelOfQuarry = int.Parse(item.SelectSingleNode("elvishBuildings/quarry")!.InnerXml);
				ElvishBuildings.LevelOfIronWorks = int.Parse(item.SelectSingleNode("elvishBuildings/ironWorks")!.InnerXml);
				ElvishBuildings.LevelOfCrystalMine = int.Parse(item.SelectSingleNode("elvishBuildings/crystalMine")!.InnerXml);
				ElvishBuildings.LevelOfHouses = int.Parse(item.SelectSingleNode("elvishBuildings/houses")!.InnerXml);
				ElvishBuildings.LevelOfTemple = int.Parse(item.SelectSingleNode("elvishBuildings/temple")!.InnerXml);
				ElvishBuildings.LevelOfElvishBuilding = int.Parse(item.SelectSingleNode("elvishBuildings/elvishBuilding")!.InnerXml);
				ElvishBuildings.LevelOfMartialArtsSchool = int.Parse(item.SelectSingleNode("elvishBuildings/martialArtsSchool")!.InnerXml);
				ElvishBuildings.LevelOfInfrastructure = int.Parse(item.SelectSingleNode("elvishBuildings/infrastructure")!.InnerXml);
				for (int i = 1; i <= int.Parse(item.SelectSingleNode("elvishUnits/elvishArcher")!.InnerXml); i++)
				{
					new ElvishArcher();
				}
				for (int j = 1; j <= int.Parse(item.SelectSingleNode("elvishUnits/elvishWarrior")!.InnerXml); j++)
				{
					new ElvishWarrior();
				}
				for (int k = 1; k <= int.Parse(item.SelectSingleNode("elvishUnits/elvishMaster")!.InnerXml); k++)
				{
					new ElvishMaster();
				}
				for (int l = 1; l <= int.Parse(item.SelectSingleNode("orcishUnits/orcishCrossbowman")!.InnerXml); l++)
				{
					new OrcishCrossbowman();
				}
				for (int m = 1; m <= int.Parse(item.SelectSingleNode("orcishUnits/orcishWarrior")!.InnerXml); m++)
				{
					new OrcishWarrior();
				}
				for (int n = 1; n <= int.Parse(item.SelectSingleNode("orcishUnits/orcishCommander")!.InnerXml); n++)
				{
					new OrcishCommander();
				}
				OrcsAttack.battleCounter = int.Parse(item.SelectSingleNode("battleCounter")!.InnerXml);
				((Form)this).Close();
				MessageBox.Show("Wczytano!", "Informacja", (MessageBoxButtons)0, (MessageBoxIcon)64);
			}
		}
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && components != null)
		{
			components.Dispose();
		}
		((Form)this).Dispose(disposing);
	}

	private void InitializeComponent()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Expected O, but got Unknown
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e0: Expected O, but got Unknown
		//IL_016d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0177: Expected O, but got Unknown
		//IL_020b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0215: Expected O, but got Unknown
		buttonSave = new Button();
		buttonLoad = new Button();
		buttonExit = new Button();
		textBoxSaveName = new TextBox();
		((Control)this).SuspendLayout();
		((Control)buttonSave).set_Font(new Font("Times New Roman", 14f));
		((Control)buttonSave).set_Location(new Point(74, 60));
		((Control)buttonSave).set_Name("buttonSave");
		((Control)buttonSave).set_Size(new Size(137, 51));
		((Control)buttonSave).set_TabIndex(0);
		((Control)buttonSave).set_Text("Zapisz");
		((ButtonBase)buttonSave).set_UseVisualStyleBackColor(true);
		((Control)buttonSave).add_Click((EventHandler)buttonSave_Click);
		((Control)buttonLoad).set_Font(new Font("Times New Roman", 14f));
		((Control)buttonLoad).set_Location(new Point(74, 129));
		((Control)buttonLoad).set_Name("buttonLoad");
		((Control)buttonLoad).set_Size(new Size(137, 51));
		((Control)buttonLoad).set_TabIndex(1);
		((Control)buttonLoad).set_Text("Wczytaj");
		((ButtonBase)buttonLoad).set_UseVisualStyleBackColor(true);
		((Control)buttonLoad).add_Click((EventHandler)buttonLoad_Click);
		((Control)buttonExit).set_Font(new Font("Times New Roman", 14f));
		((Control)buttonExit).set_Location(new Point(74, 198));
		((Control)buttonExit).set_Name("buttonExit");
		((Control)buttonExit).set_Size(new Size(137, 51));
		((Control)buttonExit).set_TabIndex(2);
		((Control)buttonExit).set_Text("Wyjdź");
		((ButtonBase)buttonExit).set_UseVisualStyleBackColor(true);
		((Control)buttonExit).add_Click((EventHandler)buttonExit_Click);
		((Control)textBoxSaveName).set_Font(new Font("Times New Roman", 14.25f, (FontStyle)0, (GraphicsUnit)3, (byte)238));
		((Control)textBoxSaveName).set_Location(new Point(74, 13));
		((Control)textBoxSaveName).set_Name("textBoxSaveName");
		((Control)textBoxSaveName).set_Size(new Size(137, 29));
		((Control)textBoxSaveName).set_TabIndex(3);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(284, 261));
		((Control)this).get_Controls().Add((Control)(object)textBoxSaveName);
		((Control)this).get_Controls().Add((Control)(object)buttonExit);
		((Control)this).get_Controls().Add((Control)(object)buttonLoad);
		((Control)this).get_Controls().Add((Control)(object)buttonSave);
		((Control)this).set_MaximumSize(new Size(300, 300));
		((Control)this).set_MinimumSize(new Size(300, 300));
		((Control)this).set_Name("FormMenu");
		((Control)this).set_Text("Menu");
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
