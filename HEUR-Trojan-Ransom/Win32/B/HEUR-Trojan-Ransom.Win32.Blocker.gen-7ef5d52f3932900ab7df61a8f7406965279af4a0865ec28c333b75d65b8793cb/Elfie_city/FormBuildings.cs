using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Elfie_city;

public class FormBuildings : Form
{
	private int[] cost;

	private IContainer components = null;

	private Label labelWoodshet;

	private Label labelWoodshetLevel;

	private Label labelLevelOfWoodshet;

	private Label labelWoodshetCost;

	private Label labelWoodshetWood;

	private Label labelWoodshetStone;

	private Label labelWoodshetIron;

	private Label labelWoodshetCrystals;

	private Label labelWoodshetCostWood;

	private Label labelWoodshetCostStone;

	private Label labelWoodshetCostCrystals;

	private Label labelWoodshetCostIron;

	private Label labelQuarryCostIron;

	private Label labelQuarryCostCrystals;

	private Label labelQuarryCostStone;

	private Label labelQuarryCostWood;

	private Label labelQuarryCrystals;

	private Label labelQuarryIron;

	private Label labelQuarryStone;

	private Label labelQuarryWood;

	private Label labelQuarryCost;

	private Label labelLevelOfQuarry;

	private Label labelQuarryLevel;

	private Label labelHuntingBuildingCostIron;

	private Label labelHuntingBuildingCostCrystals;

	private Label labelHuntingBuildingCostStone;

	private Label labelHuntingBuildingCostWood;

	private Label labelCrystalsHuntingBuildingCrystals;

	private Label labelHuntingBuildingIron;

	private Label labelHuntingBuildingStone;

	private Label labelHuntingBuildingWood;

	private Label labelHuntingBuildingCost;

	private Label labelLevelOfHuntingBuilding;

	private Label labelHuntingBuildingLevel;

	private Label labelHuntingBuilding;

	private Label labelIronWorksCostIron;

	private Label labelIronWorksCostCrystals;

	private Label labelIronWorksCostStone;

	private Label labelIronWorksCostWood;

	private Label labelIronWorksCrystals;

	private Label labelIronWorksIron;

	private Label labelIronWorksStone;

	private Label labelIronWorksWood;

	private Label labelIronWorksCost;

	private Label labelLevelOfIronWorks;

	private Label labelIronworksLevel;

	private Label labelIronWorks;

	private Button buttonUpgradeWoodshet;

	private Button buttonUpgradeQuarry;

	private Button buttonUgradeHuntingBuild;

	private Button buttonUpgradeIronWorks;

	private Button buttonUpgradeHouses;

	private Label labelHousesCostIron;

	private Label labelHousesCostCrystals;

	private Label labelHousesCostStone;

	private Label labelHousesCostWood;

	private Label labelHousesCrystals;

	private Label labelHousesIron;

	private Label labelHousesStone;

	private Label labelHousesWood;

	private Label labelHousesCost;

	private Label labelLevelOfHouses;

	private Label labelHousesLevel;

	private Label labelHouses;

	private Button buttonUpgradeTemple;

	private Label labelTempleCostIron;

	private Label labelTempleCostCrystals;

	private Label labelTempleCostStone;

	private Label labelTempleCostWood;

	private Label labelTempleCrystals;

	private Label labelTempleIron;

	private Label labelTempleStone;

	private Label labelTempleWood;

	private Label labelTempleCost;

	private Label labelLevelOfTemple;

	private Label labelTempleLevel;

	private Label labelTemple;

	private Button buttonUpgradeMartialArtsSchool;

	private Label labelMartialArtsSchoolCostIron;

	private Label labelMartialArtsSchoolCostCrystals;

	private Label labelMartialArtsSchoolCostStone;

	private Label labelMartialArtsSchoolCostWood;

	private Label labelMartialArtsSchoolCrystals;

	private Label labelMartialArtsSchoolIron;

	private Label labelMartialArtsSchoolStone;

	private Label labelMartialArtsSchoolWood;

	private Label labelMartialArtsSchoolCost;

	private Label labelLevelOfMartialArtsSchool;

	private Label labelMartialArtsSchoolLevel;

	private Label labelMartialArtsSchool;

	private Button buttonUpgradeInfrastructure;

	private Label labelInfrastructureCostIron;

	private Label labelInfrastructureCostCrystals;

	private Label labelInfrastructureCostStone;

	private Label labelInfrastructureCostWood;

	private Label labelInfrastructureCrystals;

	private Label labelInfrastructureIron;

	private Label labelInfrastructureStone;

	private Label labelInfrastructureWood;

	private Label labelInfrustructureCost;

	private Label labelLevelOfInfrastructure;

	private Label labelInfrastructureLevel;

	private Label labelInfrastructure;

	private Label labelQuarry;

	private Button buttonUpgradeCrystalMine;

	private Label labelCrystalMineCostIron;

	private Label labelCrystalMineCostCrystals;

	private Label labelCrystalMineCostStone;

	private Label labelCrystalMineCostWood;

	private Label labelCrystalMineCrystals;

	private Label labelCrystalMineIron;

	private Label labelCrystalMineStone;

	private Label labelCrystalMineWood;

	private Label labelCrystalMineCost;

	private Label labelLevelOfCrystalsMine;

	private Label labelCrystalMineLevel;

	private Label labelCrystalMine;

	private Button buttonUpgradeElvishBuilding;

	private Label labelElvishBuildingCostIron;

	private Label labelElvishBuildingCostCrystals;

	private Label labelElvishBuildingCostStone;

	private Label labelElvishBuildingCostWood;

	private Label labelElvishBuildingCrystals;

	private Label labelElvishBuildingIron;

	private Label labelElvishBuildingStone;

	private Label labelElvishBuildingWood;

	private Label labelElvishBuildingCost;

	private Label labelLevelOfElvishBuilding;

	private Label labelElvishBuildingLevel;

	private Label labelElvishBuilding;

	private Timer timerUpdaterLvlOfBuildingsAndCostOfConstruct;

	public FormBuildings()
	{
		InitializeComponent();
	}

	private void FormBuildings_Load(object sender, EventArgs e)
	{
		timerUpdaterLvlOfBuildingsAndCostOfConstruct.set_Interval(500);
		timerUpdaterLvlOfBuildingsAndCostOfConstruct.Start();
	}

	public static void ConstructionCostLabels(int[] cost, Label costWood, Label costStone, Label costIron, Label costCrystals)
	{
		((Control)costWood).set_Text(cost[0].ToString());
		((Control)costStone).set_Text(cost[1].ToString());
		((Control)costIron).set_Text(cost[2].ToString());
		((Control)costCrystals).set_Text(cost[3].ToString());
	}

	private bool IfEnoughtResources(Label costWood, Label costStone, Label costIron, Label costCrystals)
	{
		if (Resources.ResourcesWood >= int.Parse(((Control)costWood).get_Text()) && Resources.ResoucresStone >= int.Parse(((Control)costStone).get_Text()) && Resources.ResoucresIron >= int.Parse(((Control)costIron).get_Text()) && Resources.ResoucresCrystals >= int.Parse(((Control)costCrystals).get_Text()))
		{
			Resources.ResourcesWood -= int.Parse(((Control)costWood).get_Text());
			Resources.ResoucresStone -= int.Parse(((Control)costStone).get_Text());
			Resources.ResoucresIron -= int.Parse(((Control)costIron).get_Text());
			Resources.ResoucresCrystals -= int.Parse(((Control)costCrystals).get_Text());
			return true;
		}
		return false;
	}

	private void buttonUgradeHuntingBuild_Click(object sender, EventArgs e)
	{
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		if (IfEnoughtResources(labelHuntingBuildingCostWood, labelHuntingBuildingCostStone, labelHuntingBuildingCostIron, labelHuntingBuildingCostCrystals))
		{
			ElvishBuildings.LevelOfHuntingBuilding++;
			cost = ElvishBuildings.HuntingBuildingCost();
			ConstructionCostLabels(cost, labelHuntingBuildingCostWood, labelHuntingBuildingCostStone, labelHuntingBuildingCostIron, labelHuntingBuildingCostCrystals);
		}
		else
		{
			MessageBox.Show("Niewystarczająca ilość zasobów!");
		}
	}

	private void buttonUpgradeWoodshet_Click(object sender, EventArgs e)
	{
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		if (IfEnoughtResources(labelWoodshetCostWood, labelWoodshetCostStone, labelWoodshetCostIron, labelWoodshetCostCrystals))
		{
			ElvishBuildings.LevelOfWoodshet++;
			cost = ElvishBuildings.WoodshetCost();
			ConstructionCostLabels(cost, labelWoodshetCostWood, labelWoodshetCostStone, labelWoodshetCostIron, labelWoodshetCostCrystals);
		}
		else
		{
			MessageBox.Show("Niewystarczająca ilość zasobów!");
		}
	}

	private void buttonUpgradeQuarry_Click(object sender, EventArgs e)
	{
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		if (IfEnoughtResources(labelQuarryCostWood, labelQuarryCostStone, labelQuarryCostIron, labelQuarryCostCrystals))
		{
			ElvishBuildings.LevelOfQuarry++;
			cost = ElvishBuildings.QuarryCost();
			ConstructionCostLabels(cost, labelQuarryCostWood, labelQuarryCostStone, labelQuarryCostIron, labelQuarryCostCrystals);
		}
		else
		{
			MessageBox.Show("Niewystarczająca ilość zasobów!");
		}
	}

	private void buttonUpgradeIronWorks_Click(object sender, EventArgs e)
	{
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		if (IfEnoughtResources(labelIronWorksCostWood, labelIronWorksCostStone, labelIronWorksCostIron, labelIronWorksCostCrystals))
		{
			ElvishBuildings.LevelOfIronWorks++;
			cost = ElvishBuildings.IronWorksCost();
			ConstructionCostLabels(cost, labelIronWorksCostWood, labelIronWorksCostStone, labelIronWorksCostIron, labelIronWorksCostCrystals);
		}
		else
		{
			MessageBox.Show("Niewystarczająca ilość zasobów!");
		}
	}

	private void buttonUpgradeCrystalMine_Click(object sender, EventArgs e)
	{
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		if (IfEnoughtResources(labelCrystalMineCostWood, labelCrystalMineCostStone, labelCrystalMineCostIron, labelCrystalMineCostCrystals))
		{
			ElvishBuildings.LevelOfCrystalMine++;
			cost = ElvishBuildings.CrystalMineCost();
			ConstructionCostLabels(cost, labelCrystalMineCostWood, labelCrystalMineCostStone, labelCrystalMineCostIron, labelCrystalMineCostCrystals);
		}
		else
		{
			MessageBox.Show("Niewystarczająca ilość zasobów!");
		}
	}

	private void buttonUpgradeHouses_Click(object sender, EventArgs e)
	{
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		if (IfEnoughtResources(labelHousesCostWood, labelHousesCostStone, labelHousesCostIron, labelHousesCostCrystals))
		{
			ElvishBuildings.LevelOfHouses++;
			cost = ElvishBuildings.HousesCost();
			ConstructionCostLabels(cost, labelHousesCostWood, labelHousesCostStone, labelHousesCostIron, labelHousesCostCrystals);
		}
		else
		{
			MessageBox.Show("Niewystarczająca ilość zasobów!");
		}
	}

	private void buttonUpgradeTemple_Click(object sender, EventArgs e)
	{
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		if (IfEnoughtResources(labelTempleCostWood, labelTempleCostStone, labelTempleCostIron, labelTempleCostCrystals))
		{
			ElvishBuildings.LevelOfTemple++;
			cost = ElvishBuildings.TempleCost();
			ConstructionCostLabels(cost, labelTempleCostWood, labelTempleCostStone, labelTempleCostIron, labelTempleCostCrystals);
			((Control)labelLevelOfTemple).set_Text(ElvishBuildings.LevelOfTemple.ToString());
		}
		else
		{
			MessageBox.Show("Niewystarczająca ilość zasobów!");
		}
	}

	private void buttonUpgradeElvishBuilding_Click(object sender, EventArgs e)
	{
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		if (IfEnoughtResources(labelElvishBuildingCostWood, labelElvishBuildingCostStone, labelElvishBuildingCostIron, labelElvishBuildingCostCrystals))
		{
			ElvishBuildings.LevelOfElvishBuilding++;
			cost = ElvishBuildings.ElvishBuildingCost();
			ConstructionCostLabels(cost, labelElvishBuildingCostWood, labelElvishBuildingCostStone, labelElvishBuildingCostIron, labelElvishBuildingCostCrystals);
		}
		else
		{
			MessageBox.Show("Niewystarczająca ilość zasobów!");
		}
	}

	private void buttonUpgradeMartialArtsSchool_Click(object sender, EventArgs e)
	{
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		if (IfEnoughtResources(labelMartialArtsSchoolCostWood, labelMartialArtsSchoolCostStone, labelMartialArtsSchoolCostIron, labelMartialArtsSchoolCostCrystals))
		{
			ElvishBuildings.LevelOfMartialArtsSchool++;
			cost = ElvishBuildings.MartialArtsSchoolCost();
			ConstructionCostLabels(cost, labelMartialArtsSchoolCostWood, labelMartialArtsSchoolCostStone, labelMartialArtsSchoolCostIron, labelMartialArtsSchoolCostCrystals);
		}
		else
		{
			MessageBox.Show("Niewystarczająca ilość zasobów!");
		}
		if (ElvishBuildings.LevelOfMartialArtsSchool == 20)
		{
			((Control)buttonUpgradeMartialArtsSchool).set_Enabled(false);
		}
	}

	private void buttonUpgradeInfrastructure_Click(object sender, EventArgs e)
	{
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		if (IfEnoughtResources(labelInfrastructureCostWood, labelInfrastructureCostStone, labelInfrastructureCostIron, labelInfrastructureCostCrystals))
		{
			ElvishBuildings.LevelOfInfrastructure++;
			cost = ElvishBuildings.InfrastructureCost();
			ConstructionCostLabels(cost, labelInfrastructureCostWood, labelInfrastructureCostStone, labelInfrastructureCostIron, labelInfrastructureCostCrystals);
		}
		else
		{
			MessageBox.Show("Niewystarczająca ilość zasobów!");
		}
	}

	private void timerUpdaterLvlOfBuildingsAndCostOfConstruct_Tick(object sender, EventArgs e)
	{
		((Control)labelLevelOfHuntingBuilding).set_Text(ElvishBuildings.LevelOfHuntingBuilding.ToString());
		((Control)labelLevelOfWoodshet).set_Text(ElvishBuildings.LevelOfWoodshet.ToString());
		((Control)labelLevelOfQuarry).set_Text(ElvishBuildings.LevelOfQuarry.ToString());
		((Control)labelLevelOfIronWorks).set_Text(ElvishBuildings.LevelOfIronWorks.ToString());
		((Control)labelLevelOfCrystalsMine).set_Text(ElvishBuildings.LevelOfCrystalMine.ToString());
		((Control)labelLevelOfHouses).set_Text(ElvishBuildings.LevelOfHouses.ToString());
		((Control)labelLevelOfTemple).set_Text(ElvishBuildings.LevelOfTemple.ToString());
		((Control)labelLevelOfElvishBuilding).set_Text(ElvishBuildings.LevelOfElvishBuilding.ToString());
		((Control)labelLevelOfMartialArtsSchool).set_Text(ElvishBuildings.LevelOfMartialArtsSchool.ToString());
		((Control)labelLevelOfInfrastructure).set_Text(ElvishBuildings.LevelOfInfrastructure.ToString());
		cost = ElvishBuildings.HuntingBuildingCost();
		ConstructionCostLabels(cost, labelHuntingBuildingCostWood, labelHuntingBuildingCostStone, labelHuntingBuildingCostIron, labelHuntingBuildingCostCrystals);
		cost = ElvishBuildings.WoodshetCost();
		ConstructionCostLabels(cost, labelWoodshetCostWood, labelWoodshetCostStone, labelWoodshetCostIron, labelWoodshetCostCrystals);
		cost = ElvishBuildings.QuarryCost();
		ConstructionCostLabels(cost, labelQuarryCostWood, labelQuarryCostStone, labelQuarryCostIron, labelQuarryCostCrystals);
		cost = ElvishBuildings.IronWorksCost();
		ConstructionCostLabels(cost, labelIronWorksCostWood, labelIronWorksCostStone, labelIronWorksCostIron, labelIronWorksCostCrystals);
		cost = ElvishBuildings.CrystalMineCost();
		ConstructionCostLabels(cost, labelCrystalMineCostWood, labelCrystalMineCostStone, labelCrystalMineCostIron, labelCrystalMineCostCrystals);
		cost = ElvishBuildings.HousesCost();
		ConstructionCostLabels(cost, labelHousesCostWood, labelHousesCostStone, labelHousesCostIron, labelHousesCostCrystals);
		cost = ElvishBuildings.TempleCost();
		ConstructionCostLabels(cost, labelTempleCostWood, labelTempleCostStone, labelTempleCostIron, labelTempleCostCrystals);
		cost = ElvishBuildings.ElvishBuildingCost();
		ConstructionCostLabels(cost, labelElvishBuildingCostWood, labelElvishBuildingCostStone, labelElvishBuildingCostIron, labelElvishBuildingCostCrystals);
		cost = ElvishBuildings.MartialArtsSchoolCost();
		ConstructionCostLabels(cost, labelMartialArtsSchoolCostWood, labelMartialArtsSchoolCostStone, labelMartialArtsSchoolCostIron, labelMartialArtsSchoolCostCrystals);
		cost = ElvishBuildings.InfrastructureCost();
		ConstructionCostLabels(cost, labelInfrastructureCostWood, labelInfrastructureCostStone, labelInfrastructureCostIron, labelInfrastructureCostCrystals);
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
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got Unknown
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Expected O, but got Unknown
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected O, but got Unknown
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Expected O, but got Unknown
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Expected O, but got Unknown
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Expected O, but got Unknown
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Expected O, but got Unknown
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Expected O, but got Unknown
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Expected O, but got Unknown
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Expected O, but got Unknown
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Expected O, but got Unknown
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Expected O, but got Unknown
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Expected O, but got Unknown
		//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Expected O, but got Unknown
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Expected O, but got Unknown
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e7: Expected O, but got Unknown
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f2: Expected O, but got Unknown
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fd: Expected O, but got Unknown
		//IL_00fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0108: Expected O, but got Unknown
		//IL_0109: Unknown result type (might be due to invalid IL or missing references)
		//IL_0113: Expected O, but got Unknown
		//IL_0114: Unknown result type (might be due to invalid IL or missing references)
		//IL_011e: Expected O, but got Unknown
		//IL_011f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0129: Expected O, but got Unknown
		//IL_012a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0134: Expected O, but got Unknown
		//IL_0135: Unknown result type (might be due to invalid IL or missing references)
		//IL_013f: Expected O, but got Unknown
		//IL_0140: Unknown result type (might be due to invalid IL or missing references)
		//IL_014a: Expected O, but got Unknown
		//IL_014b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0155: Expected O, but got Unknown
		//IL_0156: Unknown result type (might be due to invalid IL or missing references)
		//IL_0160: Expected O, but got Unknown
		//IL_0161: Unknown result type (might be due to invalid IL or missing references)
		//IL_016b: Expected O, but got Unknown
		//IL_016c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0176: Expected O, but got Unknown
		//IL_0177: Unknown result type (might be due to invalid IL or missing references)
		//IL_0181: Expected O, but got Unknown
		//IL_0182: Unknown result type (might be due to invalid IL or missing references)
		//IL_018c: Expected O, but got Unknown
		//IL_018d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0197: Expected O, but got Unknown
		//IL_0198: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a2: Expected O, but got Unknown
		//IL_01a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ad: Expected O, but got Unknown
		//IL_01ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b8: Expected O, but got Unknown
		//IL_01b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c3: Expected O, but got Unknown
		//IL_01c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ce: Expected O, but got Unknown
		//IL_01cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d9: Expected O, but got Unknown
		//IL_01da: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e4: Expected O, but got Unknown
		//IL_01e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ef: Expected O, but got Unknown
		//IL_01f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fa: Expected O, but got Unknown
		//IL_01fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0205: Expected O, but got Unknown
		//IL_0206: Unknown result type (might be due to invalid IL or missing references)
		//IL_0210: Expected O, but got Unknown
		//IL_0211: Unknown result type (might be due to invalid IL or missing references)
		//IL_021b: Expected O, but got Unknown
		//IL_021c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0226: Expected O, but got Unknown
		//IL_0227: Unknown result type (might be due to invalid IL or missing references)
		//IL_0231: Expected O, but got Unknown
		//IL_0232: Unknown result type (might be due to invalid IL or missing references)
		//IL_023c: Expected O, but got Unknown
		//IL_023d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0247: Expected O, but got Unknown
		//IL_0248: Unknown result type (might be due to invalid IL or missing references)
		//IL_0252: Expected O, but got Unknown
		//IL_0253: Unknown result type (might be due to invalid IL or missing references)
		//IL_025d: Expected O, but got Unknown
		//IL_025e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0268: Expected O, but got Unknown
		//IL_0269: Unknown result type (might be due to invalid IL or missing references)
		//IL_0273: Expected O, but got Unknown
		//IL_0274: Unknown result type (might be due to invalid IL or missing references)
		//IL_027e: Expected O, but got Unknown
		//IL_027f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0289: Expected O, but got Unknown
		//IL_028a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0294: Expected O, but got Unknown
		//IL_0295: Unknown result type (might be due to invalid IL or missing references)
		//IL_029f: Expected O, but got Unknown
		//IL_02a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02aa: Expected O, but got Unknown
		//IL_02ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b5: Expected O, but got Unknown
		//IL_02b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c0: Expected O, but got Unknown
		//IL_02c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cb: Expected O, but got Unknown
		//IL_02cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d6: Expected O, but got Unknown
		//IL_02d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e1: Expected O, but got Unknown
		//IL_02e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ec: Expected O, but got Unknown
		//IL_02ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f7: Expected O, but got Unknown
		//IL_02f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0302: Expected O, but got Unknown
		//IL_0303: Unknown result type (might be due to invalid IL or missing references)
		//IL_030d: Expected O, but got Unknown
		//IL_030e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0318: Expected O, but got Unknown
		//IL_0319: Unknown result type (might be due to invalid IL or missing references)
		//IL_0323: Expected O, but got Unknown
		//IL_0324: Unknown result type (might be due to invalid IL or missing references)
		//IL_032e: Expected O, but got Unknown
		//IL_032f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0339: Expected O, but got Unknown
		//IL_033a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0344: Expected O, but got Unknown
		//IL_0345: Unknown result type (might be due to invalid IL or missing references)
		//IL_034f: Expected O, but got Unknown
		//IL_0350: Unknown result type (might be due to invalid IL or missing references)
		//IL_035a: Expected O, but got Unknown
		//IL_035b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0365: Expected O, but got Unknown
		//IL_0366: Unknown result type (might be due to invalid IL or missing references)
		//IL_0370: Expected O, but got Unknown
		//IL_0371: Unknown result type (might be due to invalid IL or missing references)
		//IL_037b: Expected O, but got Unknown
		//IL_037c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0386: Expected O, but got Unknown
		//IL_0387: Unknown result type (might be due to invalid IL or missing references)
		//IL_0391: Expected O, but got Unknown
		//IL_0392: Unknown result type (might be due to invalid IL or missing references)
		//IL_039c: Expected O, but got Unknown
		//IL_039d: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a7: Expected O, but got Unknown
		//IL_03a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b2: Expected O, but got Unknown
		//IL_03b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_03bd: Expected O, but got Unknown
		//IL_03be: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c8: Expected O, but got Unknown
		//IL_03c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d3: Expected O, but got Unknown
		//IL_03d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_03de: Expected O, but got Unknown
		//IL_03df: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e9: Expected O, but got Unknown
		//IL_03ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f4: Expected O, but got Unknown
		//IL_03f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ff: Expected O, but got Unknown
		//IL_0400: Unknown result type (might be due to invalid IL or missing references)
		//IL_040a: Expected O, but got Unknown
		//IL_040b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0415: Expected O, but got Unknown
		//IL_0416: Unknown result type (might be due to invalid IL or missing references)
		//IL_0420: Expected O, but got Unknown
		//IL_0421: Unknown result type (might be due to invalid IL or missing references)
		//IL_042b: Expected O, but got Unknown
		//IL_042c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0436: Expected O, but got Unknown
		//IL_0437: Unknown result type (might be due to invalid IL or missing references)
		//IL_0441: Expected O, but got Unknown
		//IL_0442: Unknown result type (might be due to invalid IL or missing references)
		//IL_044c: Expected O, but got Unknown
		//IL_044d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0457: Expected O, but got Unknown
		//IL_0458: Unknown result type (might be due to invalid IL or missing references)
		//IL_0462: Expected O, but got Unknown
		//IL_0463: Unknown result type (might be due to invalid IL or missing references)
		//IL_046d: Expected O, but got Unknown
		//IL_046e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0478: Expected O, but got Unknown
		//IL_0479: Unknown result type (might be due to invalid IL or missing references)
		//IL_0483: Expected O, but got Unknown
		//IL_0484: Unknown result type (might be due to invalid IL or missing references)
		//IL_048e: Expected O, but got Unknown
		//IL_048f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0499: Expected O, but got Unknown
		//IL_049a: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a4: Expected O, but got Unknown
		//IL_04a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_04af: Expected O, but got Unknown
		//IL_04b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ba: Expected O, but got Unknown
		//IL_04bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c5: Expected O, but got Unknown
		//IL_04c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d0: Expected O, but got Unknown
		//IL_04d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_04db: Expected O, but got Unknown
		//IL_04dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e6: Expected O, but got Unknown
		//IL_04e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f1: Expected O, but got Unknown
		//IL_04f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_04fc: Expected O, but got Unknown
		//IL_04fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0507: Expected O, but got Unknown
		//IL_0508: Unknown result type (might be due to invalid IL or missing references)
		//IL_0512: Expected O, but got Unknown
		//IL_0513: Unknown result type (might be due to invalid IL or missing references)
		//IL_051d: Expected O, but got Unknown
		//IL_051e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0528: Expected O, but got Unknown
		//IL_0529: Unknown result type (might be due to invalid IL or missing references)
		//IL_0533: Expected O, but got Unknown
		//IL_0534: Unknown result type (might be due to invalid IL or missing references)
		//IL_053e: Expected O, but got Unknown
		//IL_053f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0549: Expected O, but got Unknown
		//IL_054a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0554: Expected O, but got Unknown
		//IL_0555: Unknown result type (might be due to invalid IL or missing references)
		//IL_055f: Expected O, but got Unknown
		//IL_0560: Unknown result type (might be due to invalid IL or missing references)
		//IL_056a: Expected O, but got Unknown
		//IL_056b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0575: Expected O, but got Unknown
		//IL_0576: Unknown result type (might be due to invalid IL or missing references)
		//IL_0580: Expected O, but got Unknown
		//IL_0581: Unknown result type (might be due to invalid IL or missing references)
		//IL_058b: Expected O, but got Unknown
		//IL_058c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0596: Expected O, but got Unknown
		//IL_0597: Unknown result type (might be due to invalid IL or missing references)
		//IL_05a1: Expected O, but got Unknown
		//IL_05a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b2: Expected O, but got Unknown
		//IL_05d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_05de: Expected O, but got Unknown
		//IL_0651: Unknown result type (might be due to invalid IL or missing references)
		//IL_065b: Expected O, but got Unknown
		//IL_06ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_06d8: Expected O, but got Unknown
		//IL_074c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0756: Expected O, but got Unknown
		//IL_07dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_07e7: Expected O, but got Unknown
		//IL_085b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0865: Expected O, but got Unknown
		//IL_08d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_08e3: Expected O, but got Unknown
		//IL_095a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0964: Expected O, but got Unknown
		//IL_09d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_09e2: Expected O, but got Unknown
		//IL_0a56: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a60: Expected O, but got Unknown
		//IL_0ad4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ade: Expected O, but got Unknown
		//IL_0b52: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b5c: Expected O, but got Unknown
		//IL_0bd3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bdd: Expected O, but got Unknown
		//IL_0c54: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c5e: Expected O, but got Unknown
		//IL_0cd2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cdc: Expected O, but got Unknown
		//IL_0d50: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d5a: Expected O, but got Unknown
		//IL_0dce: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dd8: Expected O, but got Unknown
		//IL_0e4c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e56: Expected O, but got Unknown
		//IL_0ecd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ed7: Expected O, but got Unknown
		//IL_0f4b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f55: Expected O, but got Unknown
		//IL_0fc9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fd3: Expected O, but got Unknown
		//IL_104a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1054: Expected O, but got Unknown
		//IL_10c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_10d2: Expected O, but got Unknown
		//IL_1146: Unknown result type (might be due to invalid IL or missing references)
		//IL_1150: Expected O, but got Unknown
		//IL_11c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_11ce: Expected O, but got Unknown
		//IL_1242: Unknown result type (might be due to invalid IL or missing references)
		//IL_124c: Expected O, but got Unknown
		//IL_12bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_12c7: Expected O, but got Unknown
		//IL_1338: Unknown result type (might be due to invalid IL or missing references)
		//IL_1342: Expected O, but got Unknown
		//IL_13b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_13bd: Expected O, but got Unknown
		//IL_142e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1438: Expected O, but got Unknown
		//IL_14ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_14b6: Expected O, but got Unknown
		//IL_1527: Unknown result type (might be due to invalid IL or missing references)
		//IL_1531: Expected O, but got Unknown
		//IL_15a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_15ac: Expected O, but got Unknown
		//IL_1620: Unknown result type (might be due to invalid IL or missing references)
		//IL_162a: Expected O, but got Unknown
		//IL_169b: Unknown result type (might be due to invalid IL or missing references)
		//IL_16a5: Expected O, but got Unknown
		//IL_1716: Unknown result type (might be due to invalid IL or missing references)
		//IL_1720: Expected O, but got Unknown
		//IL_1794: Unknown result type (might be due to invalid IL or missing references)
		//IL_179e: Expected O, but got Unknown
		//IL_1815: Unknown result type (might be due to invalid IL or missing references)
		//IL_181f: Expected O, but got Unknown
		//IL_1893: Unknown result type (might be due to invalid IL or missing references)
		//IL_189d: Expected O, but got Unknown
		//IL_1911: Unknown result type (might be due to invalid IL or missing references)
		//IL_191b: Expected O, but got Unknown
		//IL_198f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1999: Expected O, but got Unknown
		//IL_1a0d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a17: Expected O, but got Unknown
		//IL_1a8e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a98: Expected O, but got Unknown
		//IL_1b0c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b16: Expected O, but got Unknown
		//IL_1b8a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b94: Expected O, but got Unknown
		//IL_1c0b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c15: Expected O, but got Unknown
		//IL_1c89: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c93: Expected O, but got Unknown
		//IL_1d07: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d11: Expected O, but got Unknown
		//IL_2004: Unknown result type (might be due to invalid IL or missing references)
		//IL_200e: Expected O, but got Unknown
		//IL_2082: Unknown result type (might be due to invalid IL or missing references)
		//IL_208c: Expected O, but got Unknown
		//IL_2100: Unknown result type (might be due to invalid IL or missing references)
		//IL_210a: Expected O, but got Unknown
		//IL_217e: Unknown result type (might be due to invalid IL or missing references)
		//IL_2188: Expected O, but got Unknown
		//IL_21fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_2206: Expected O, but got Unknown
		//IL_227a: Unknown result type (might be due to invalid IL or missing references)
		//IL_2284: Expected O, but got Unknown
		//IL_22f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_2301: Expected O, but got Unknown
		//IL_2374: Unknown result type (might be due to invalid IL or missing references)
		//IL_237e: Expected O, but got Unknown
		//IL_23f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_23fb: Expected O, but got Unknown
		//IL_2471: Unknown result type (might be due to invalid IL or missing references)
		//IL_247b: Expected O, but got Unknown
		//IL_24ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_24f9: Expected O, but got Unknown
		//IL_256c: Unknown result type (might be due to invalid IL or missing references)
		//IL_2576: Expected O, but got Unknown
		//IL_266a: Unknown result type (might be due to invalid IL or missing references)
		//IL_2674: Expected O, but got Unknown
		//IL_26eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_26f5: Expected O, but got Unknown
		//IL_276c: Unknown result type (might be due to invalid IL or missing references)
		//IL_2776: Expected O, but got Unknown
		//IL_27ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_27f7: Expected O, but got Unknown
		//IL_286e: Unknown result type (might be due to invalid IL or missing references)
		//IL_2878: Expected O, but got Unknown
		//IL_28ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_28f9: Expected O, but got Unknown
		//IL_2970: Unknown result type (might be due to invalid IL or missing references)
		//IL_297a: Expected O, but got Unknown
		//IL_29f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_29fb: Expected O, but got Unknown
		//IL_2a72: Unknown result type (might be due to invalid IL or missing references)
		//IL_2a7c: Expected O, but got Unknown
		//IL_2af6: Unknown result type (might be due to invalid IL or missing references)
		//IL_2b00: Expected O, but got Unknown
		//IL_2b77: Unknown result type (might be due to invalid IL or missing references)
		//IL_2b81: Expected O, but got Unknown
		//IL_2bf8: Unknown result type (might be due to invalid IL or missing references)
		//IL_2c02: Expected O, but got Unknown
		//IL_2cfa: Unknown result type (might be due to invalid IL or missing references)
		//IL_2d04: Expected O, but got Unknown
		//IL_2d7b: Unknown result type (might be due to invalid IL or missing references)
		//IL_2d85: Expected O, but got Unknown
		//IL_2dfc: Unknown result type (might be due to invalid IL or missing references)
		//IL_2e06: Expected O, but got Unknown
		//IL_2e7d: Unknown result type (might be due to invalid IL or missing references)
		//IL_2e87: Expected O, but got Unknown
		//IL_2efe: Unknown result type (might be due to invalid IL or missing references)
		//IL_2f08: Expected O, but got Unknown
		//IL_2f7f: Unknown result type (might be due to invalid IL or missing references)
		//IL_2f89: Expected O, but got Unknown
		//IL_3000: Unknown result type (might be due to invalid IL or missing references)
		//IL_300a: Expected O, but got Unknown
		//IL_3081: Unknown result type (might be due to invalid IL or missing references)
		//IL_308b: Expected O, but got Unknown
		//IL_3102: Unknown result type (might be due to invalid IL or missing references)
		//IL_310c: Expected O, but got Unknown
		//IL_3186: Unknown result type (might be due to invalid IL or missing references)
		//IL_3190: Expected O, but got Unknown
		//IL_3207: Unknown result type (might be due to invalid IL or missing references)
		//IL_3211: Expected O, but got Unknown
		//IL_3288: Unknown result type (might be due to invalid IL or missing references)
		//IL_3292: Expected O, but got Unknown
		//IL_338d: Unknown result type (might be due to invalid IL or missing references)
		//IL_3397: Expected O, but got Unknown
		//IL_340e: Unknown result type (might be due to invalid IL or missing references)
		//IL_3418: Expected O, but got Unknown
		//IL_348f: Unknown result type (might be due to invalid IL or missing references)
		//IL_3499: Expected O, but got Unknown
		//IL_3510: Unknown result type (might be due to invalid IL or missing references)
		//IL_351a: Expected O, but got Unknown
		//IL_3591: Unknown result type (might be due to invalid IL or missing references)
		//IL_359b: Expected O, but got Unknown
		//IL_3612: Unknown result type (might be due to invalid IL or missing references)
		//IL_361c: Expected O, but got Unknown
		//IL_3693: Unknown result type (might be due to invalid IL or missing references)
		//IL_369d: Expected O, but got Unknown
		//IL_3714: Unknown result type (might be due to invalid IL or missing references)
		//IL_371e: Expected O, but got Unknown
		//IL_3795: Unknown result type (might be due to invalid IL or missing references)
		//IL_379f: Expected O, but got Unknown
		//IL_3819: Unknown result type (might be due to invalid IL or missing references)
		//IL_3823: Expected O, but got Unknown
		//IL_389a: Unknown result type (might be due to invalid IL or missing references)
		//IL_38a4: Expected O, but got Unknown
		//IL_391b: Unknown result type (might be due to invalid IL or missing references)
		//IL_3925: Expected O, but got Unknown
		//IL_3a1d: Unknown result type (might be due to invalid IL or missing references)
		//IL_3a27: Expected O, but got Unknown
		//IL_3a9e: Unknown result type (might be due to invalid IL or missing references)
		//IL_3aa8: Expected O, but got Unknown
		//IL_3b1c: Unknown result type (might be due to invalid IL or missing references)
		//IL_3b26: Expected O, but got Unknown
		//IL_3b9a: Unknown result type (might be due to invalid IL or missing references)
		//IL_3ba4: Expected O, but got Unknown
		//IL_3c18: Unknown result type (might be due to invalid IL or missing references)
		//IL_3c22: Expected O, but got Unknown
		//IL_3c96: Unknown result type (might be due to invalid IL or missing references)
		//IL_3ca0: Expected O, but got Unknown
		//IL_3d17: Unknown result type (might be due to invalid IL or missing references)
		//IL_3d21: Expected O, but got Unknown
		//IL_3d95: Unknown result type (might be due to invalid IL or missing references)
		//IL_3d9f: Expected O, but got Unknown
		//IL_3e13: Unknown result type (might be due to invalid IL or missing references)
		//IL_3e1d: Expected O, but got Unknown
		//IL_3e94: Unknown result type (might be due to invalid IL or missing references)
		//IL_3e9e: Expected O, but got Unknown
		//IL_3f12: Unknown result type (might be due to invalid IL or missing references)
		//IL_3f1c: Expected O, but got Unknown
		//IL_3f90: Unknown result type (might be due to invalid IL or missing references)
		//IL_3f9a: Expected O, but got Unknown
		//IL_4095: Unknown result type (might be due to invalid IL or missing references)
		//IL_409f: Expected O, but got Unknown
		//IL_4119: Unknown result type (might be due to invalid IL or missing references)
		//IL_4123: Expected O, but got Unknown
		//IL_419d: Unknown result type (might be due to invalid IL or missing references)
		//IL_41a7: Expected O, but got Unknown
		//IL_4221: Unknown result type (might be due to invalid IL or missing references)
		//IL_422b: Expected O, but got Unknown
		//IL_42a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_42af: Expected O, but got Unknown
		//IL_4329: Unknown result type (might be due to invalid IL or missing references)
		//IL_4333: Expected O, but got Unknown
		//IL_43ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_43b7: Expected O, but got Unknown
		//IL_4431: Unknown result type (might be due to invalid IL or missing references)
		//IL_443b: Expected O, but got Unknown
		//IL_44b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_44bf: Expected O, but got Unknown
		//IL_4539: Unknown result type (might be due to invalid IL or missing references)
		//IL_4543: Expected O, but got Unknown
		//IL_45ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_45c4: Expected O, but got Unknown
		//IL_463b: Unknown result type (might be due to invalid IL or missing references)
		//IL_4645: Expected O, but got Unknown
		components = new Container();
		labelWoodshet = new Label();
		labelWoodshetLevel = new Label();
		labelLevelOfWoodshet = new Label();
		labelWoodshetCost = new Label();
		labelWoodshetWood = new Label();
		labelWoodshetStone = new Label();
		labelWoodshetIron = new Label();
		labelWoodshetCrystals = new Label();
		labelWoodshetCostWood = new Label();
		labelWoodshetCostStone = new Label();
		labelWoodshetCostCrystals = new Label();
		labelWoodshetCostIron = new Label();
		labelQuarryCostIron = new Label();
		labelQuarryCostCrystals = new Label();
		labelQuarryCostStone = new Label();
		labelQuarryCostWood = new Label();
		labelQuarryCrystals = new Label();
		labelQuarryIron = new Label();
		labelQuarryStone = new Label();
		labelQuarryWood = new Label();
		labelQuarryCost = new Label();
		labelLevelOfQuarry = new Label();
		labelQuarryLevel = new Label();
		labelQuarry = new Label();
		labelHuntingBuildingCostIron = new Label();
		labelHuntingBuildingCostCrystals = new Label();
		labelHuntingBuildingCostStone = new Label();
		labelHuntingBuildingCostWood = new Label();
		labelCrystalsHuntingBuildingCrystals = new Label();
		labelHuntingBuildingIron = new Label();
		labelHuntingBuildingStone = new Label();
		labelHuntingBuildingWood = new Label();
		labelHuntingBuildingCost = new Label();
		labelLevelOfHuntingBuilding = new Label();
		labelHuntingBuildingLevel = new Label();
		labelHuntingBuilding = new Label();
		labelIronWorksCostIron = new Label();
		labelIronWorksCostCrystals = new Label();
		labelIronWorksCostStone = new Label();
		labelIronWorksCostWood = new Label();
		labelIronWorksCrystals = new Label();
		labelIronWorksIron = new Label();
		labelIronWorksStone = new Label();
		labelIronWorksWood = new Label();
		labelIronWorksCost = new Label();
		labelLevelOfIronWorks = new Label();
		labelIronworksLevel = new Label();
		labelIronWorks = new Label();
		buttonUpgradeWoodshet = new Button();
		buttonUpgradeQuarry = new Button();
		buttonUgradeHuntingBuild = new Button();
		buttonUpgradeIronWorks = new Button();
		buttonUpgradeHouses = new Button();
		labelHousesCostIron = new Label();
		labelHousesCostCrystals = new Label();
		labelHousesCostStone = new Label();
		labelHousesCostWood = new Label();
		labelHousesCrystals = new Label();
		labelHousesIron = new Label();
		labelHousesStone = new Label();
		labelHousesWood = new Label();
		labelHousesCost = new Label();
		labelLevelOfHouses = new Label();
		labelHousesLevel = new Label();
		labelHouses = new Label();
		buttonUpgradeTemple = new Button();
		labelTempleCostIron = new Label();
		labelTempleCostCrystals = new Label();
		labelTempleCostStone = new Label();
		labelTempleCostWood = new Label();
		labelTempleCrystals = new Label();
		labelTempleIron = new Label();
		labelTempleStone = new Label();
		labelTempleWood = new Label();
		labelTempleCost = new Label();
		labelLevelOfTemple = new Label();
		labelTempleLevel = new Label();
		labelTemple = new Label();
		buttonUpgradeMartialArtsSchool = new Button();
		labelMartialArtsSchoolCostIron = new Label();
		labelMartialArtsSchoolCostCrystals = new Label();
		labelMartialArtsSchoolCostStone = new Label();
		labelMartialArtsSchoolCostWood = new Label();
		labelMartialArtsSchoolCrystals = new Label();
		labelMartialArtsSchoolIron = new Label();
		labelMartialArtsSchoolStone = new Label();
		labelMartialArtsSchoolWood = new Label();
		labelMartialArtsSchoolCost = new Label();
		labelLevelOfMartialArtsSchool = new Label();
		labelMartialArtsSchoolLevel = new Label();
		labelMartialArtsSchool = new Label();
		buttonUpgradeInfrastructure = new Button();
		labelInfrastructureCostIron = new Label();
		labelInfrastructureCostCrystals = new Label();
		labelInfrastructureCostStone = new Label();
		labelInfrastructureCostWood = new Label();
		labelInfrastructureCrystals = new Label();
		labelInfrastructureIron = new Label();
		labelInfrastructureStone = new Label();
		labelInfrastructureWood = new Label();
		labelInfrustructureCost = new Label();
		labelLevelOfInfrastructure = new Label();
		labelInfrastructureLevel = new Label();
		labelInfrastructure = new Label();
		buttonUpgradeCrystalMine = new Button();
		labelCrystalMineCostIron = new Label();
		labelCrystalMineCostCrystals = new Label();
		labelCrystalMineCostStone = new Label();
		labelCrystalMineCostWood = new Label();
		labelCrystalMineCrystals = new Label();
		labelCrystalMineIron = new Label();
		labelCrystalMineStone = new Label();
		labelCrystalMineWood = new Label();
		labelCrystalMineCost = new Label();
		labelLevelOfCrystalsMine = new Label();
		labelCrystalMineLevel = new Label();
		labelCrystalMine = new Label();
		buttonUpgradeElvishBuilding = new Button();
		labelElvishBuildingCostIron = new Label();
		labelElvishBuildingCostCrystals = new Label();
		labelElvishBuildingCostStone = new Label();
		labelElvishBuildingCostWood = new Label();
		labelElvishBuildingCrystals = new Label();
		labelElvishBuildingIron = new Label();
		labelElvishBuildingStone = new Label();
		labelElvishBuildingWood = new Label();
		labelElvishBuildingCost = new Label();
		labelLevelOfElvishBuilding = new Label();
		labelElvishBuildingLevel = new Label();
		labelElvishBuilding = new Label();
		timerUpdaterLvlOfBuildingsAndCostOfConstruct = new Timer(components);
		((Control)this).SuspendLayout();
		((Control)labelWoodshet).set_AutoSize(true);
		((Control)labelWoodshet).set_Font(new Font("Times New Roman", 14f));
		((Control)labelWoodshet).set_Location(new Point(204, 9));
		((Control)labelWoodshet).set_Name("labelWoodshet");
		((Control)labelWoodshet).set_Size(new Size(57, 21));
		((Control)labelWoodshet).set_TabIndex(7);
		((Control)labelWoodshet).set_Text("Tartak");
		((Control)labelWoodshetLevel).set_AutoSize(true);
		((Control)labelWoodshetLevel).set_Font(new Font("Times New Roman", 14f));
		((Control)labelWoodshetLevel).set_Location(new Point(204, 30));
		((Control)labelWoodshetLevel).set_Name("labelWoodshetLevel");
		((Control)labelWoodshetLevel).set_Size(new Size(71, 21));
		((Control)labelWoodshetLevel).set_TabIndex(8);
		((Control)labelWoodshetLevel).set_Text("Poziom:");
		((Control)labelLevelOfWoodshet).set_AutoSize(true);
		((Control)labelLevelOfWoodshet).set_Font(new Font("Times New Roman", 14f));
		((Control)labelLevelOfWoodshet).set_Location(new Point(270, 30));
		((Control)labelLevelOfWoodshet).set_Name("labelLevelOfWoodshet");
		((Control)labelLevelOfWoodshet).set_Size(new Size(19, 21));
		((Control)labelLevelOfWoodshet).set_TabIndex(9);
		((Control)labelLevelOfWoodshet).set_Text("1");
		((Control)labelWoodshetCost).set_AutoSize(true);
		((Control)labelWoodshetCost).set_Font(new Font("Times New Roman", 14f));
		((Control)labelWoodshetCost).set_ForeColor(SystemColors.ActiveCaptionText);
		((Control)labelWoodshetCost).set_Location(new Point(204, 51));
		((Control)labelWoodshetCost).set_Name("labelWoodshetCost");
		((Control)labelWoodshetCost).set_Size(new Size(139, 21));
		((Control)labelWoodshetCost).set_TabIndex(10);
		((Control)labelWoodshetCost).set_Text("Koszt ulepszenia:");
		((Control)labelWoodshetWood).set_AutoSize(true);
		((Control)labelWoodshetWood).set_Font(new Font("Times New Roman", 14f));
		((Control)labelWoodshetWood).set_Location(new Point(204, 72));
		((Control)labelWoodshetWood).set_Name("labelWoodshetWood");
		((Control)labelWoodshetWood).set_Size(new Size(73, 21));
		((Control)labelWoodshetWood).set_TabIndex(11);
		((Control)labelWoodshetWood).set_Text("Drewno:");
		((Control)labelWoodshetStone).set_AutoSize(true);
		((Control)labelWoodshetStone).set_Font(new Font("Times New Roman", 14f));
		((Control)labelWoodshetStone).set_Location(new Point(204, 93));
		((Control)labelWoodshetStone).set_Name("labelWoodshetStone");
		((Control)labelWoodshetStone).set_Size(new Size(75, 21));
		((Control)labelWoodshetStone).set_TabIndex(12);
		((Control)labelWoodshetStone).set_Text("Kamień: ");
		((Control)labelWoodshetIron).set_AutoSize(true);
		((Control)labelWoodshetIron).set_Font(new Font("Times New Roman", 14f));
		((Control)labelWoodshetIron).set_Location(new Point(204, 135));
		((Control)labelWoodshetIron).set_Name("labelWoodshetIron");
		((Control)labelWoodshetIron).set_Size(new Size(63, 21));
		((Control)labelWoodshetIron).set_TabIndex(13);
		((Control)labelWoodshetIron).set_Text("Żelazo:");
		((Control)labelWoodshetCrystals).set_AutoSize(true);
		((Control)labelWoodshetCrystals).set_Font(new Font("Times New Roman", 14f));
		((Control)labelWoodshetCrystals).set_Location(new Point(205, 114));
		((Control)labelWoodshetCrystals).set_Name("labelWoodshetCrystals");
		((Control)labelWoodshetCrystals).set_Size(new Size(84, 21));
		((Control)labelWoodshetCrystals).set_TabIndex(14);
		((Control)labelWoodshetCrystals).set_Text("Kryształy:");
		((Control)labelWoodshetCostWood).set_AutoSize(true);
		((Control)labelWoodshetCostWood).set_Font(new Font("Times New Roman", 14f));
		((Control)labelWoodshetCostWood).set_Location(new Point(306, 72));
		((Control)labelWoodshetCostWood).set_Name("labelWoodshetCostWood");
		((Control)labelWoodshetCostWood).set_Size(new Size(19, 21));
		((Control)labelWoodshetCostWood).set_TabIndex(15);
		((Control)labelWoodshetCostWood).set_Text("0");
		((Control)labelWoodshetCostStone).set_AutoSize(true);
		((Control)labelWoodshetCostStone).set_Font(new Font("Times New Roman", 14f));
		((Control)labelWoodshetCostStone).set_Location(new Point(306, 93));
		((Control)labelWoodshetCostStone).set_Name("labelWoodshetCostStone");
		((Control)labelWoodshetCostStone).set_Size(new Size(19, 21));
		((Control)labelWoodshetCostStone).set_TabIndex(16);
		((Control)labelWoodshetCostStone).set_Text("0");
		((Control)labelWoodshetCostCrystals).set_AutoSize(true);
		((Control)labelWoodshetCostCrystals).set_Font(new Font("Times New Roman", 14f));
		((Control)labelWoodshetCostCrystals).set_Location(new Point(306, 114));
		((Control)labelWoodshetCostCrystals).set_Name("labelWoodshetCostCrystals");
		((Control)labelWoodshetCostCrystals).set_Size(new Size(19, 21));
		((Control)labelWoodshetCostCrystals).set_TabIndex(17);
		((Control)labelWoodshetCostCrystals).set_Text("0");
		((Control)labelWoodshetCostIron).set_AutoSize(true);
		((Control)labelWoodshetCostIron).set_Font(new Font("Times New Roman", 14f));
		((Control)labelWoodshetCostIron).set_Location(new Point(306, 135));
		((Control)labelWoodshetCostIron).set_Name("labelWoodshetCostIron");
		((Control)labelWoodshetCostIron).set_Size(new Size(19, 21));
		((Control)labelWoodshetCostIron).set_TabIndex(18);
		((Control)labelWoodshetCostIron).set_Text("0");
		((Control)labelQuarryCostIron).set_AutoSize(true);
		((Control)labelQuarryCostIron).set_Font(new Font("Times New Roman", 14f));
		((Control)labelQuarryCostIron).set_Location(new Point(487, 135));
		((Control)labelQuarryCostIron).set_Name("labelQuarryCostIron");
		((Control)labelQuarryCostIron).set_Size(new Size(19, 21));
		((Control)labelQuarryCostIron).set_TabIndex(30);
		((Control)labelQuarryCostIron).set_Text("0");
		((Control)labelQuarryCostCrystals).set_AutoSize(true);
		((Control)labelQuarryCostCrystals).set_Font(new Font("Times New Roman", 14f));
		((Control)labelQuarryCostCrystals).set_Location(new Point(487, 114));
		((Control)labelQuarryCostCrystals).set_Name("labelQuarryCostCrystals");
		((Control)labelQuarryCostCrystals).set_Size(new Size(19, 21));
		((Control)labelQuarryCostCrystals).set_TabIndex(29);
		((Control)labelQuarryCostCrystals).set_Text("0");
		((Control)labelQuarryCostStone).set_AutoSize(true);
		((Control)labelQuarryCostStone).set_Font(new Font("Times New Roman", 14f));
		((Control)labelQuarryCostStone).set_Location(new Point(487, 93));
		((Control)labelQuarryCostStone).set_Name("labelQuarryCostStone");
		((Control)labelQuarryCostStone).set_Size(new Size(19, 21));
		((Control)labelQuarryCostStone).set_TabIndex(28);
		((Control)labelQuarryCostStone).set_Text("0");
		((Control)labelQuarryCostWood).set_AutoSize(true);
		((Control)labelQuarryCostWood).set_Font(new Font("Times New Roman", 14f));
		((Control)labelQuarryCostWood).set_Location(new Point(487, 72));
		((Control)labelQuarryCostWood).set_Name("labelQuarryCostWood");
		((Control)labelQuarryCostWood).set_Size(new Size(19, 21));
		((Control)labelQuarryCostWood).set_TabIndex(27);
		((Control)labelQuarryCostWood).set_Text("0");
		((Control)labelQuarryCrystals).set_AutoSize(true);
		((Control)labelQuarryCrystals).set_Font(new Font("Times New Roman", 14f));
		((Control)labelQuarryCrystals).set_Location(new Point(386, 114));
		((Control)labelQuarryCrystals).set_Name("labelQuarryCrystals");
		((Control)labelQuarryCrystals).set_Size(new Size(84, 21));
		((Control)labelQuarryCrystals).set_TabIndex(26);
		((Control)labelQuarryCrystals).set_Text("Kryształy:");
		((Control)labelQuarryIron).set_AutoSize(true);
		((Control)labelQuarryIron).set_Font(new Font("Times New Roman", 14f));
		((Control)labelQuarryIron).set_Location(new Point(385, 135));
		((Control)labelQuarryIron).set_Name("labelQuarryIron");
		((Control)labelQuarryIron).set_Size(new Size(63, 21));
		((Control)labelQuarryIron).set_TabIndex(25);
		((Control)labelQuarryIron).set_Text("Żelazo:");
		((Control)labelQuarryStone).set_AutoSize(true);
		((Control)labelQuarryStone).set_Font(new Font("Times New Roman", 14f));
		((Control)labelQuarryStone).set_Location(new Point(385, 93));
		((Control)labelQuarryStone).set_Name("labelQuarryStone");
		((Control)labelQuarryStone).set_Size(new Size(75, 21));
		((Control)labelQuarryStone).set_TabIndex(24);
		((Control)labelQuarryStone).set_Text("Kamień: ");
		((Control)labelQuarryWood).set_AutoSize(true);
		((Control)labelQuarryWood).set_Font(new Font("Times New Roman", 14f));
		((Control)labelQuarryWood).set_Location(new Point(385, 72));
		((Control)labelQuarryWood).set_Name("labelQuarryWood");
		((Control)labelQuarryWood).set_Size(new Size(73, 21));
		((Control)labelQuarryWood).set_TabIndex(23);
		((Control)labelQuarryWood).set_Text("Drewno:");
		((Control)labelQuarryCost).set_AutoSize(true);
		((Control)labelQuarryCost).set_Font(new Font("Times New Roman", 14f));
		((Control)labelQuarryCost).set_Location(new Point(385, 51));
		((Control)labelQuarryCost).set_Name("labelQuarryCost");
		((Control)labelQuarryCost).set_Size(new Size(139, 21));
		((Control)labelQuarryCost).set_TabIndex(22);
		((Control)labelQuarryCost).set_Text("Koszt ulepszenia:");
		((Control)labelLevelOfQuarry).set_AutoSize(true);
		((Control)labelLevelOfQuarry).set_Font(new Font("Times New Roman", 14f));
		((Control)labelLevelOfQuarry).set_Location(new Point(451, 30));
		((Control)labelLevelOfQuarry).set_Name("labelLevelOfQuarry");
		((Control)labelLevelOfQuarry).set_Size(new Size(19, 21));
		((Control)labelLevelOfQuarry).set_TabIndex(21);
		((Control)labelLevelOfQuarry).set_Text("1");
		((Control)labelQuarryLevel).set_AutoSize(true);
		((Control)labelQuarryLevel).set_Font(new Font("Times New Roman", 14f));
		((Control)labelQuarryLevel).set_Location(new Point(385, 30));
		((Control)labelQuarryLevel).set_Name("labelQuarryLevel");
		((Control)labelQuarryLevel).set_Size(new Size(71, 21));
		((Control)labelQuarryLevel).set_TabIndex(20);
		((Control)labelQuarryLevel).set_Text("Poziom:");
		((Control)labelQuarry).set_AutoSize(true);
		((Control)labelQuarry).set_Font(new Font("Times New Roman", 14f));
		((Control)labelQuarry).set_Location(new Point(385, 9));
		((Control)labelQuarry).set_Name("labelQuarry");
		((Control)labelQuarry).set_Size(new Size(108, 21));
		((Control)labelQuarry).set_TabIndex(19);
		((Control)labelQuarry).set_Text("Kamieniołom");
		((Control)labelHuntingBuildingCostIron).set_AutoSize(true);
		((Control)labelHuntingBuildingCostIron).set_Font(new Font("Times New Roman", 14f));
		((Control)labelHuntingBuildingCostIron).set_Location(new Point(114, 135));
		((Control)labelHuntingBuildingCostIron).set_Name("labelHuntingBuildingCostIron");
		((Control)labelHuntingBuildingCostIron).set_Size(new Size(19, 21));
		((Control)labelHuntingBuildingCostIron).set_TabIndex(42);
		((Control)labelHuntingBuildingCostIron).set_Text("0");
		((Control)labelHuntingBuildingCostCrystals).set_AutoSize(true);
		((Control)labelHuntingBuildingCostCrystals).set_Font(new Font("Times New Roman", 14f));
		((Control)labelHuntingBuildingCostCrystals).set_Location(new Point(114, 114));
		((Control)labelHuntingBuildingCostCrystals).set_Name("labelHuntingBuildingCostCrystals");
		((Control)labelHuntingBuildingCostCrystals).set_Size(new Size(19, 21));
		((Control)labelHuntingBuildingCostCrystals).set_TabIndex(41);
		((Control)labelHuntingBuildingCostCrystals).set_Text("0");
		((Control)labelHuntingBuildingCostStone).set_AutoSize(true);
		((Control)labelHuntingBuildingCostStone).set_Font(new Font("Times New Roman", 14f));
		((Control)labelHuntingBuildingCostStone).set_Location(new Point(114, 93));
		((Control)labelHuntingBuildingCostStone).set_Name("labelHuntingBuildingCostStone");
		((Control)labelHuntingBuildingCostStone).set_Size(new Size(19, 21));
		((Control)labelHuntingBuildingCostStone).set_TabIndex(40);
		((Control)labelHuntingBuildingCostStone).set_Text("0");
		((Control)labelHuntingBuildingCostWood).set_AutoSize(true);
		((Control)labelHuntingBuildingCostWood).set_Font(new Font("Times New Roman", 14f));
		((Control)labelHuntingBuildingCostWood).set_Location(new Point(114, 72));
		((Control)labelHuntingBuildingCostWood).set_Name("labelHuntingBuildingCostWood");
		((Control)labelHuntingBuildingCostWood).set_Size(new Size(19, 21));
		((Control)labelHuntingBuildingCostWood).set_TabIndex(39);
		((Control)labelHuntingBuildingCostWood).set_Text("0");
		((Control)labelCrystalsHuntingBuildingCrystals).set_AutoSize(true);
		((Control)labelCrystalsHuntingBuildingCrystals).set_Font(new Font("Times New Roman", 14f));
		((Control)labelCrystalsHuntingBuildingCrystals).set_Location(new Point(13, 114));
		((Control)labelCrystalsHuntingBuildingCrystals).set_Name("labelCrystalsHuntingBuildingCrystals");
		((Control)labelCrystalsHuntingBuildingCrystals).set_Size(new Size(84, 21));
		((Control)labelCrystalsHuntingBuildingCrystals).set_TabIndex(38);
		((Control)labelCrystalsHuntingBuildingCrystals).set_Text("Kryształy:");
		((Control)labelHuntingBuildingIron).set_AutoSize(true);
		((Control)labelHuntingBuildingIron).set_Font(new Font("Times New Roman", 14f));
		((Control)labelHuntingBuildingIron).set_Location(new Point(12, 135));
		((Control)labelHuntingBuildingIron).set_Name("labelHuntingBuildingIron");
		((Control)labelHuntingBuildingIron).set_Size(new Size(63, 21));
		((Control)labelHuntingBuildingIron).set_TabIndex(37);
		((Control)labelHuntingBuildingIron).set_Text("Żelazo:");
		((Control)labelHuntingBuildingStone).set_AutoSize(true);
		((Control)labelHuntingBuildingStone).set_Font(new Font("Times New Roman", 14f));
		((Control)labelHuntingBuildingStone).set_Location(new Point(12, 93));
		((Control)labelHuntingBuildingStone).set_Name("labelHuntingBuildingStone");
		((Control)labelHuntingBuildingStone).set_Size(new Size(75, 21));
		((Control)labelHuntingBuildingStone).set_TabIndex(36);
		((Control)labelHuntingBuildingStone).set_Text("Kamień: ");
		((Control)labelHuntingBuildingWood).set_AutoSize(true);
		((Control)labelHuntingBuildingWood).set_Font(new Font("Times New Roman", 14f));
		((Control)labelHuntingBuildingWood).set_Location(new Point(12, 72));
		((Control)labelHuntingBuildingWood).set_Name("labelHuntingBuildingWood");
		((Control)labelHuntingBuildingWood).set_Size(new Size(73, 21));
		((Control)labelHuntingBuildingWood).set_TabIndex(35);
		((Control)labelHuntingBuildingWood).set_Text("Drewno:");
		((Control)labelHuntingBuildingCost).set_AutoSize(true);
		((Control)labelHuntingBuildingCost).set_Font(new Font("Times New Roman", 14f));
		((Control)labelHuntingBuildingCost).set_Location(new Point(12, 51));
		((Control)labelHuntingBuildingCost).set_Name("labelHuntingBuildingCost");
		((Control)labelHuntingBuildingCost).set_Size(new Size(139, 21));
		((Control)labelHuntingBuildingCost).set_TabIndex(34);
		((Control)labelHuntingBuildingCost).set_Text("Koszt ulepszenia:");
		((Control)labelLevelOfHuntingBuilding).set_AutoSize(true);
		((Control)labelLevelOfHuntingBuilding).set_Font(new Font("Times New Roman", 14f));
		((Control)labelLevelOfHuntingBuilding).set_Location(new Point(78, 30));
		((Control)labelLevelOfHuntingBuilding).set_Name("labelLevelOfHuntingBuilding");
		((Control)labelLevelOfHuntingBuilding).set_Size(new Size(19, 21));
		((Control)labelLevelOfHuntingBuilding).set_TabIndex(33);
		((Control)labelLevelOfHuntingBuilding).set_Text("1");
		((Control)labelHuntingBuildingLevel).set_AutoSize(true);
		((Control)labelHuntingBuildingLevel).set_Font(new Font("Times New Roman", 14f));
		((Control)labelHuntingBuildingLevel).set_Location(new Point(12, 30));
		((Control)labelHuntingBuildingLevel).set_Name("labelHuntingBuildingLevel");
		((Control)labelHuntingBuildingLevel).set_Size(new Size(71, 21));
		((Control)labelHuntingBuildingLevel).set_TabIndex(32);
		((Control)labelHuntingBuildingLevel).set_Text("Poziom:");
		((Control)labelHuntingBuilding).set_AutoSize(true);
		((Control)labelHuntingBuilding).set_Font(new Font("Times New Roman", 14f));
		((Control)labelHuntingBuilding).set_Location(new Point(12, 9));
		((Control)labelHuntingBuilding).set_Name("labelHuntingBuilding");
		((Control)labelHuntingBuilding).set_Size(new Size(135, 21));
		((Control)labelHuntingBuilding).set_TabIndex(31);
		((Control)labelHuntingBuilding).set_Text("Chata myśliwska");
		((Control)labelIronWorksCostIron).set_AutoSize(true);
		((Control)labelIronWorksCostIron).set_Font(new Font("Times New Roman", 14f));
		((Control)labelIronWorksCostIron).set_Location(new Point(674, 135));
		((Control)labelIronWorksCostIron).set_Name("labelIronWorksCostIron");
		((Control)labelIronWorksCostIron).set_Size(new Size(19, 21));
		((Control)labelIronWorksCostIron).set_TabIndex(54);
		((Control)labelIronWorksCostIron).set_Text("0");
		((Control)labelIronWorksCostCrystals).set_AutoSize(true);
		((Control)labelIronWorksCostCrystals).set_Font(new Font("Times New Roman", 14f));
		((Control)labelIronWorksCostCrystals).set_Location(new Point(674, 114));
		((Control)labelIronWorksCostCrystals).set_Name("labelIronWorksCostCrystals");
		((Control)labelIronWorksCostCrystals).set_Size(new Size(19, 21));
		((Control)labelIronWorksCostCrystals).set_TabIndex(53);
		((Control)labelIronWorksCostCrystals).set_Text("0");
		((Control)labelIronWorksCostStone).set_AutoSize(true);
		((Control)labelIronWorksCostStone).set_Font(new Font("Times New Roman", 14f));
		((Control)labelIronWorksCostStone).set_Location(new Point(674, 93));
		((Control)labelIronWorksCostStone).set_Name("labelIronWorksCostStone");
		((Control)labelIronWorksCostStone).set_Size(new Size(19, 21));
		((Control)labelIronWorksCostStone).set_TabIndex(52);
		((Control)labelIronWorksCostStone).set_Text("0");
		((Control)labelIronWorksCostWood).set_AutoSize(true);
		((Control)labelIronWorksCostWood).set_Font(new Font("Times New Roman", 14f));
		((Control)labelIronWorksCostWood).set_Location(new Point(674, 72));
		((Control)labelIronWorksCostWood).set_Name("labelIronWorksCostWood");
		((Control)labelIronWorksCostWood).set_Size(new Size(19, 21));
		((Control)labelIronWorksCostWood).set_TabIndex(51);
		((Control)labelIronWorksCostWood).set_Text("0");
		((Control)labelIronWorksCrystals).set_AutoSize(true);
		((Control)labelIronWorksCrystals).set_Font(new Font("Times New Roman", 14f));
		((Control)labelIronWorksCrystals).set_Location(new Point(573, 114));
		((Control)labelIronWorksCrystals).set_Name("labelIronWorksCrystals");
		((Control)labelIronWorksCrystals).set_Size(new Size(84, 21));
		((Control)labelIronWorksCrystals).set_TabIndex(50);
		((Control)labelIronWorksCrystals).set_Text("Kryształy:");
		((Control)labelIronWorksIron).set_AutoSize(true);
		((Control)labelIronWorksIron).set_Font(new Font("Times New Roman", 14f));
		((Control)labelIronWorksIron).set_Location(new Point(572, 135));
		((Control)labelIronWorksIron).set_Name("labelIronWorksIron");
		((Control)labelIronWorksIron).set_Size(new Size(63, 21));
		((Control)labelIronWorksIron).set_TabIndex(49);
		((Control)labelIronWorksIron).set_Text("Żelazo:");
		((Control)labelIronWorksStone).set_AutoSize(true);
		((Control)labelIronWorksStone).set_Font(new Font("Times New Roman", 14f));
		((Control)labelIronWorksStone).set_Location(new Point(572, 93));
		((Control)labelIronWorksStone).set_Name("labelIronWorksStone");
		((Control)labelIronWorksStone).set_Size(new Size(75, 21));
		((Control)labelIronWorksStone).set_TabIndex(48);
		((Control)labelIronWorksStone).set_Text("Kamień: ");
		((Control)labelIronWorksWood).set_AutoSize(true);
		((Control)labelIronWorksWood).set_Font(new Font("Times New Roman", 14f));
		((Control)labelIronWorksWood).set_Location(new Point(572, 72));
		((Control)labelIronWorksWood).set_Name("labelIronWorksWood");
		((Control)labelIronWorksWood).set_Size(new Size(73, 21));
		((Control)labelIronWorksWood).set_TabIndex(47);
		((Control)labelIronWorksWood).set_Text("Drewno:");
		((Control)labelIronWorksCost).set_AutoSize(true);
		((Control)labelIronWorksCost).set_Font(new Font("Times New Roman", 14f));
		((Control)labelIronWorksCost).set_Location(new Point(572, 51));
		((Control)labelIronWorksCost).set_Name("labelIronWorksCost");
		((Control)labelIronWorksCost).set_Size(new Size(139, 21));
		((Control)labelIronWorksCost).set_TabIndex(46);
		((Control)labelIronWorksCost).set_Text("Koszt ulepszenia:");
		((Control)labelLevelOfIronWorks).set_AutoSize(true);
		((Control)labelLevelOfIronWorks).set_Font(new Font("Times New Roman", 14f));
		((Control)labelLevelOfIronWorks).set_Location(new Point(638, 30));
		((Control)labelLevelOfIronWorks).set_Name("labelLevelOfIronWorks");
		((Control)labelLevelOfIronWorks).set_Size(new Size(19, 21));
		((Control)labelLevelOfIronWorks).set_TabIndex(45);
		((Control)labelLevelOfIronWorks).set_Text("1");
		((Control)labelIronworksLevel).set_AutoSize(true);
		((Control)labelIronworksLevel).set_Font(new Font("Times New Roman", 14f));
		((Control)labelIronworksLevel).set_Location(new Point(572, 30));
		((Control)labelIronworksLevel).set_Name("labelIronworksLevel");
		((Control)labelIronworksLevel).set_Size(new Size(71, 21));
		((Control)labelIronworksLevel).set_TabIndex(44);
		((Control)labelIronworksLevel).set_Text("Poziom:");
		((Control)labelIronWorks).set_AutoSize(true);
		((Control)labelIronWorks).set_Font(new Font("Times New Roman", 14f));
		((Control)labelIronWorks).set_Location(new Point(572, 9));
		((Control)labelIronWorks).set_Name("labelIronWorks");
		((Control)labelIronWorks).set_Size(new Size(45, 21));
		((Control)labelIronWorks).set_TabIndex(43);
		((Control)labelIronWorks).set_Text("Huta");
		((Control)buttonUpgradeWoodshet).set_Location(new Point(208, 174));
		((Control)buttonUpgradeWoodshet).set_Name("buttonUpgradeWoodshet");
		((Control)buttonUpgradeWoodshet).set_Size(new Size(135, 41));
		((Control)buttonUpgradeWoodshet).set_TabIndex(55);
		((Control)buttonUpgradeWoodshet).set_Text("Ulepsz tartak");
		((ButtonBase)buttonUpgradeWoodshet).set_UseVisualStyleBackColor(true);
		((Control)buttonUpgradeWoodshet).add_Click((EventHandler)buttonUpgradeWoodshet_Click);
		((Control)buttonUpgradeQuarry).set_Location(new Point(389, 174));
		((Control)buttonUpgradeQuarry).set_Name("buttonUpgradeQuarry");
		((Control)buttonUpgradeQuarry).set_Size(new Size(135, 41));
		((Control)buttonUpgradeQuarry).set_TabIndex(56);
		((Control)buttonUpgradeQuarry).set_Text("Ulepsz kamieniołom");
		((ButtonBase)buttonUpgradeQuarry).set_UseVisualStyleBackColor(true);
		((Control)buttonUpgradeQuarry).add_Click((EventHandler)buttonUpgradeQuarry_Click);
		((Control)buttonUgradeHuntingBuild).set_Location(new Point(16, 174));
		((Control)buttonUgradeHuntingBuild).set_Name("buttonUgradeHuntingBuild");
		((Control)buttonUgradeHuntingBuild).set_Size(new Size(135, 41));
		((Control)buttonUgradeHuntingBuild).set_TabIndex(57);
		((Control)buttonUgradeHuntingBuild).set_Text("Ulepsz chatę myśliwską");
		((ButtonBase)buttonUgradeHuntingBuild).set_UseVisualStyleBackColor(true);
		((Control)buttonUgradeHuntingBuild).add_Click((EventHandler)buttonUgradeHuntingBuild_Click);
		((Control)buttonUpgradeIronWorks).set_Location(new Point(576, 174));
		((Control)buttonUpgradeIronWorks).set_Name("buttonUpgradeIronWorks");
		((Control)buttonUpgradeIronWorks).set_Size(new Size(135, 41));
		((Control)buttonUpgradeIronWorks).set_TabIndex(58);
		((Control)buttonUpgradeIronWorks).set_Text("Ulepsz hutę");
		((ButtonBase)buttonUpgradeIronWorks).set_UseVisualStyleBackColor(true);
		((Control)buttonUpgradeIronWorks).add_Click((EventHandler)buttonUpgradeIronWorks_Click);
		((Control)buttonUpgradeHouses).set_Location(new Point(12, 439));
		((Control)buttonUpgradeHouses).set_Name("buttonUpgradeHouses");
		((Control)buttonUpgradeHouses).set_Size(new Size(135, 41));
		((Control)buttonUpgradeHouses).set_TabIndex(71);
		((Control)buttonUpgradeHouses).set_Text("Ulepsz elfickie domy");
		((ButtonBase)buttonUpgradeHouses).set_UseVisualStyleBackColor(true);
		((Control)buttonUpgradeHouses).add_Click((EventHandler)buttonUpgradeHouses_Click);
		((Control)labelHousesCostIron).set_AutoSize(true);
		((Control)labelHousesCostIron).set_Font(new Font("Times New Roman", 14f));
		((Control)labelHousesCostIron).set_Location(new Point(110, 400));
		((Control)labelHousesCostIron).set_Name("labelHousesCostIron");
		((Control)labelHousesCostIron).set_Size(new Size(19, 21));
		((Control)labelHousesCostIron).set_TabIndex(70);
		((Control)labelHousesCostIron).set_Text("0");
		((Control)labelHousesCostCrystals).set_AutoSize(true);
		((Control)labelHousesCostCrystals).set_Font(new Font("Times New Roman", 14f));
		((Control)labelHousesCostCrystals).set_Location(new Point(110, 379));
		((Control)labelHousesCostCrystals).set_Name("labelHousesCostCrystals");
		((Control)labelHousesCostCrystals).set_Size(new Size(19, 21));
		((Control)labelHousesCostCrystals).set_TabIndex(69);
		((Control)labelHousesCostCrystals).set_Text("0");
		((Control)labelHousesCostStone).set_AutoSize(true);
		((Control)labelHousesCostStone).set_Font(new Font("Times New Roman", 14f));
		((Control)labelHousesCostStone).set_Location(new Point(110, 358));
		((Control)labelHousesCostStone).set_Name("labelHousesCostStone");
		((Control)labelHousesCostStone).set_Size(new Size(19, 21));
		((Control)labelHousesCostStone).set_TabIndex(68);
		((Control)labelHousesCostStone).set_Text("0");
		((Control)labelHousesCostWood).set_AutoSize(true);
		((Control)labelHousesCostWood).set_Font(new Font("Times New Roman", 14f));
		((Control)labelHousesCostWood).set_Location(new Point(110, 337));
		((Control)labelHousesCostWood).set_Name("labelHousesCostWood");
		((Control)labelHousesCostWood).set_Size(new Size(19, 21));
		((Control)labelHousesCostWood).set_TabIndex(67);
		((Control)labelHousesCostWood).set_Text("0");
		((Control)labelHousesCrystals).set_AutoSize(true);
		((Control)labelHousesCrystals).set_Font(new Font("Times New Roman", 14f));
		((Control)labelHousesCrystals).set_Location(new Point(9, 379));
		((Control)labelHousesCrystals).set_Name("labelHousesCrystals");
		((Control)labelHousesCrystals).set_Size(new Size(84, 21));
		((Control)labelHousesCrystals).set_TabIndex(66);
		((Control)labelHousesCrystals).set_Text("Kryształy:");
		((Control)labelHousesIron).set_AutoSize(true);
		((Control)labelHousesIron).set_Font(new Font("Times New Roman", 14f));
		((Control)labelHousesIron).set_Location(new Point(8, 400));
		((Control)labelHousesIron).set_Name("labelHousesIron");
		((Control)labelHousesIron).set_Size(new Size(63, 21));
		((Control)labelHousesIron).set_TabIndex(65);
		((Control)labelHousesIron).set_Text("Żelazo:");
		((Control)labelHousesStone).set_AutoSize(true);
		((Control)labelHousesStone).set_Font(new Font("Times New Roman", 14f));
		((Control)labelHousesStone).set_Location(new Point(8, 358));
		((Control)labelHousesStone).set_Name("labelHousesStone");
		((Control)labelHousesStone).set_Size(new Size(75, 21));
		((Control)labelHousesStone).set_TabIndex(64);
		((Control)labelHousesStone).set_Text("Kamień: ");
		((Control)labelHousesWood).set_AutoSize(true);
		((Control)labelHousesWood).set_Font(new Font("Times New Roman", 14f));
		((Control)labelHousesWood).set_Location(new Point(8, 337));
		((Control)labelHousesWood).set_Name("labelHousesWood");
		((Control)labelHousesWood).set_Size(new Size(73, 21));
		((Control)labelHousesWood).set_TabIndex(63);
		((Control)labelHousesWood).set_Text("Drewno:");
		((Control)labelHousesCost).set_AutoSize(true);
		((Control)labelHousesCost).set_Font(new Font("Times New Roman", 14f));
		((Control)labelHousesCost).set_Location(new Point(8, 316));
		((Control)labelHousesCost).set_Name("labelHousesCost");
		((Control)labelHousesCost).set_Size(new Size(139, 21));
		((Control)labelHousesCost).set_TabIndex(62);
		((Control)labelHousesCost).set_Text("Koszt ulepszenia:");
		((Control)labelLevelOfHouses).set_AutoSize(true);
		((Control)labelLevelOfHouses).set_Font(new Font("Times New Roman", 14f));
		((Control)labelLevelOfHouses).set_Location(new Point(74, 295));
		((Control)labelLevelOfHouses).set_Name("labelLevelOfHouses");
		((Control)labelLevelOfHouses).set_Size(new Size(19, 21));
		((Control)labelLevelOfHouses).set_TabIndex(61);
		((Control)labelLevelOfHouses).set_Text("1");
		((Control)labelHousesLevel).set_AutoSize(true);
		((Control)labelHousesLevel).set_Font(new Font("Times New Roman", 14f));
		((Control)labelHousesLevel).set_Location(new Point(8, 295));
		((Control)labelHousesLevel).set_Name("labelHousesLevel");
		((Control)labelHousesLevel).set_Size(new Size(71, 21));
		((Control)labelHousesLevel).set_TabIndex(60);
		((Control)labelHousesLevel).set_Text("Poziom:");
		((Control)labelHouses).set_AutoSize(true);
		((Control)labelHouses).set_Font(new Font("Times New Roman", 14f));
		((Control)labelHouses).set_Location(new Point(8, 274));
		((Control)labelHouses).set_Name("labelHouses");
		((Control)labelHouses).set_Size(new Size(91, 21));
		((Control)labelHouses).set_TabIndex(59);
		((Control)labelHouses).set_Text("Elfie domy");
		((Control)buttonUpgradeTemple).set_Location(new Point(208, 439));
		((Control)buttonUpgradeTemple).set_Name("buttonUpgradeTemple");
		((Control)buttonUpgradeTemple).set_Size(new Size(135, 41));
		((Control)buttonUpgradeTemple).set_TabIndex(84);
		((Control)buttonUpgradeTemple).set_Text("Ulepsz świątynię");
		((ButtonBase)buttonUpgradeTemple).set_UseVisualStyleBackColor(true);
		((Control)buttonUpgradeTemple).add_Click((EventHandler)buttonUpgradeTemple_Click);
		((Control)labelTempleCostIron).set_AutoSize(true);
		((Control)labelTempleCostIron).set_Font(new Font("Times New Roman", 14f));
		((Control)labelTempleCostIron).set_Location(new Point(306, 400));
		((Control)labelTempleCostIron).set_Name("labelTempleCostIron");
		((Control)labelTempleCostIron).set_Size(new Size(19, 21));
		((Control)labelTempleCostIron).set_TabIndex(83);
		((Control)labelTempleCostIron).set_Text("0");
		((Control)labelTempleCostCrystals).set_AutoSize(true);
		((Control)labelTempleCostCrystals).set_Font(new Font("Times New Roman", 14f));
		((Control)labelTempleCostCrystals).set_Location(new Point(306, 379));
		((Control)labelTempleCostCrystals).set_Name("labelTempleCostCrystals");
		((Control)labelTempleCostCrystals).set_Size(new Size(19, 21));
		((Control)labelTempleCostCrystals).set_TabIndex(82);
		((Control)labelTempleCostCrystals).set_Text("0");
		((Control)labelTempleCostStone).set_AutoSize(true);
		((Control)labelTempleCostStone).set_Font(new Font("Times New Roman", 14f));
		((Control)labelTempleCostStone).set_Location(new Point(306, 358));
		((Control)labelTempleCostStone).set_Name("labelTempleCostStone");
		((Control)labelTempleCostStone).set_Size(new Size(19, 21));
		((Control)labelTempleCostStone).set_TabIndex(81);
		((Control)labelTempleCostStone).set_Text("0");
		((Control)labelTempleCostWood).set_AutoSize(true);
		((Control)labelTempleCostWood).set_Font(new Font("Times New Roman", 14f));
		((Control)labelTempleCostWood).set_Location(new Point(306, 337));
		((Control)labelTempleCostWood).set_Name("labelTempleCostWood");
		((Control)labelTempleCostWood).set_Size(new Size(19, 21));
		((Control)labelTempleCostWood).set_TabIndex(80);
		((Control)labelTempleCostWood).set_Text("0");
		((Control)labelTempleCrystals).set_AutoSize(true);
		((Control)labelTempleCrystals).set_Font(new Font("Times New Roman", 14f));
		((Control)labelTempleCrystals).set_Location(new Point(205, 379));
		((Control)labelTempleCrystals).set_Name("labelTempleCrystals");
		((Control)labelTempleCrystals).set_Size(new Size(84, 21));
		((Control)labelTempleCrystals).set_TabIndex(79);
		((Control)labelTempleCrystals).set_Text("Kryształy:");
		((Control)labelTempleIron).set_AutoSize(true);
		((Control)labelTempleIron).set_Font(new Font("Times New Roman", 14f));
		((Control)labelTempleIron).set_Location(new Point(204, 400));
		((Control)labelTempleIron).set_Name("labelTempleIron");
		((Control)labelTempleIron).set_Size(new Size(63, 21));
		((Control)labelTempleIron).set_TabIndex(78);
		((Control)labelTempleIron).set_Text("Żelazo:");
		((Control)labelTempleStone).set_AutoSize(true);
		((Control)labelTempleStone).set_Font(new Font("Times New Roman", 14f));
		((Control)labelTempleStone).set_Location(new Point(204, 358));
		((Control)labelTempleStone).set_Name("labelTempleStone");
		((Control)labelTempleStone).set_Size(new Size(75, 21));
		((Control)labelTempleStone).set_TabIndex(77);
		((Control)labelTempleStone).set_Text("Kamień: ");
		((Control)labelTempleWood).set_AutoSize(true);
		((Control)labelTempleWood).set_Font(new Font("Times New Roman", 14f));
		((Control)labelTempleWood).set_Location(new Point(204, 337));
		((Control)labelTempleWood).set_Name("labelTempleWood");
		((Control)labelTempleWood).set_Size(new Size(73, 21));
		((Control)labelTempleWood).set_TabIndex(76);
		((Control)labelTempleWood).set_Text("Drewno:");
		((Control)labelTempleCost).set_AutoSize(true);
		((Control)labelTempleCost).set_Font(new Font("Times New Roman", 14f));
		((Control)labelTempleCost).set_Location(new Point(204, 316));
		((Control)labelTempleCost).set_Name("labelTempleCost");
		((Control)labelTempleCost).set_Size(new Size(139, 21));
		((Control)labelTempleCost).set_TabIndex(75);
		((Control)labelTempleCost).set_Text("Koszt ulepszenia:");
		((Control)labelLevelOfTemple).set_AutoSize(true);
		((Control)labelLevelOfTemple).set_Font(new Font("Times New Roman", 14f));
		((Control)labelLevelOfTemple).set_Location(new Point(270, 295));
		((Control)labelLevelOfTemple).set_Name("labelLevelOfTemple");
		((Control)labelLevelOfTemple).set_Size(new Size(19, 21));
		((Control)labelLevelOfTemple).set_TabIndex(74);
		((Control)labelLevelOfTemple).set_Text("1");
		((Control)labelTempleLevel).set_AutoSize(true);
		((Control)labelTempleLevel).set_Font(new Font("Times New Roman", 14f));
		((Control)labelTempleLevel).set_Location(new Point(204, 295));
		((Control)labelTempleLevel).set_Name("labelTempleLevel");
		((Control)labelTempleLevel).set_Size(new Size(71, 21));
		((Control)labelTempleLevel).set_TabIndex(73);
		((Control)labelTempleLevel).set_Text("Poziom:");
		((Control)labelTemple).set_AutoSize(true);
		((Control)labelTemple).set_Font(new Font("Times New Roman", 14f));
		((Control)labelTemple).set_Location(new Point(204, 274));
		((Control)labelTemple).set_Name("labelTemple");
		((Control)labelTemple).set_Size(new Size(81, 21));
		((Control)labelTemple).set_TabIndex(72);
		((Control)labelTemple).set_Text("Świątynia");
		((Control)buttonUpgradeMartialArtsSchool).set_Location(new Point(576, 439));
		((Control)buttonUpgradeMartialArtsSchool).set_Name("buttonUpgradeMartialArtsSchool");
		((Control)buttonUpgradeMartialArtsSchool).set_Size(new Size(135, 41));
		((Control)buttonUpgradeMartialArtsSchool).set_TabIndex(97);
		((Control)buttonUpgradeMartialArtsSchool).set_Text("Ulepsz szkołę sztuk walki");
		((ButtonBase)buttonUpgradeMartialArtsSchool).set_UseVisualStyleBackColor(true);
		((Control)buttonUpgradeMartialArtsSchool).add_Click((EventHandler)buttonUpgradeMartialArtsSchool_Click);
		((Control)labelMartialArtsSchoolCostIron).set_AutoSize(true);
		((Control)labelMartialArtsSchoolCostIron).set_Font(new Font("Times New Roman", 14f));
		((Control)labelMartialArtsSchoolCostIron).set_Location(new Point(674, 400));
		((Control)labelMartialArtsSchoolCostIron).set_Name("labelMartialArtsSchoolCostIron");
		((Control)labelMartialArtsSchoolCostIron).set_Size(new Size(19, 21));
		((Control)labelMartialArtsSchoolCostIron).set_TabIndex(96);
		((Control)labelMartialArtsSchoolCostIron).set_Text("0");
		((Control)labelMartialArtsSchoolCostCrystals).set_AutoSize(true);
		((Control)labelMartialArtsSchoolCostCrystals).set_Font(new Font("Times New Roman", 14f));
		((Control)labelMartialArtsSchoolCostCrystals).set_Location(new Point(674, 379));
		((Control)labelMartialArtsSchoolCostCrystals).set_Name("labelMartialArtsSchoolCostCrystals");
		((Control)labelMartialArtsSchoolCostCrystals).set_Size(new Size(19, 21));
		((Control)labelMartialArtsSchoolCostCrystals).set_TabIndex(95);
		((Control)labelMartialArtsSchoolCostCrystals).set_Text("0");
		((Control)labelMartialArtsSchoolCostStone).set_AutoSize(true);
		((Control)labelMartialArtsSchoolCostStone).set_Font(new Font("Times New Roman", 14f));
		((Control)labelMartialArtsSchoolCostStone).set_Location(new Point(674, 358));
		((Control)labelMartialArtsSchoolCostStone).set_Name("labelMartialArtsSchoolCostStone");
		((Control)labelMartialArtsSchoolCostStone).set_Size(new Size(19, 21));
		((Control)labelMartialArtsSchoolCostStone).set_TabIndex(94);
		((Control)labelMartialArtsSchoolCostStone).set_Text("0");
		((Control)labelMartialArtsSchoolCostWood).set_AutoSize(true);
		((Control)labelMartialArtsSchoolCostWood).set_Font(new Font("Times New Roman", 14f));
		((Control)labelMartialArtsSchoolCostWood).set_Location(new Point(674, 337));
		((Control)labelMartialArtsSchoolCostWood).set_Name("labelMartialArtsSchoolCostWood");
		((Control)labelMartialArtsSchoolCostWood).set_Size(new Size(19, 21));
		((Control)labelMartialArtsSchoolCostWood).set_TabIndex(93);
		((Control)labelMartialArtsSchoolCostWood).set_Text("0");
		((Control)labelMartialArtsSchoolCrystals).set_AutoSize(true);
		((Control)labelMartialArtsSchoolCrystals).set_Font(new Font("Times New Roman", 14f));
		((Control)labelMartialArtsSchoolCrystals).set_Location(new Point(573, 379));
		((Control)labelMartialArtsSchoolCrystals).set_Name("labelMartialArtsSchoolCrystals");
		((Control)labelMartialArtsSchoolCrystals).set_Size(new Size(84, 21));
		((Control)labelMartialArtsSchoolCrystals).set_TabIndex(92);
		((Control)labelMartialArtsSchoolCrystals).set_Text("Kryształy:");
		((Control)labelMartialArtsSchoolIron).set_AutoSize(true);
		((Control)labelMartialArtsSchoolIron).set_Font(new Font("Times New Roman", 14f));
		((Control)labelMartialArtsSchoolIron).set_Location(new Point(572, 400));
		((Control)labelMartialArtsSchoolIron).set_Name("labelMartialArtsSchoolIron");
		((Control)labelMartialArtsSchoolIron).set_Size(new Size(63, 21));
		((Control)labelMartialArtsSchoolIron).set_TabIndex(91);
		((Control)labelMartialArtsSchoolIron).set_Text("Żelazo:");
		((Control)labelMartialArtsSchoolStone).set_AutoSize(true);
		((Control)labelMartialArtsSchoolStone).set_Font(new Font("Times New Roman", 14f));
		((Control)labelMartialArtsSchoolStone).set_Location(new Point(572, 358));
		((Control)labelMartialArtsSchoolStone).set_Name("labelMartialArtsSchoolStone");
		((Control)labelMartialArtsSchoolStone).set_Size(new Size(75, 21));
		((Control)labelMartialArtsSchoolStone).set_TabIndex(90);
		((Control)labelMartialArtsSchoolStone).set_Text("Kamień: ");
		((Control)labelMartialArtsSchoolWood).set_AutoSize(true);
		((Control)labelMartialArtsSchoolWood).set_Font(new Font("Times New Roman", 14f));
		((Control)labelMartialArtsSchoolWood).set_Location(new Point(572, 337));
		((Control)labelMartialArtsSchoolWood).set_Name("labelMartialArtsSchoolWood");
		((Control)labelMartialArtsSchoolWood).set_Size(new Size(73, 21));
		((Control)labelMartialArtsSchoolWood).set_TabIndex(89);
		((Control)labelMartialArtsSchoolWood).set_Text("Drewno:");
		((Control)labelMartialArtsSchoolCost).set_AutoSize(true);
		((Control)labelMartialArtsSchoolCost).set_Font(new Font("Times New Roman", 14f));
		((Control)labelMartialArtsSchoolCost).set_Location(new Point(572, 316));
		((Control)labelMartialArtsSchoolCost).set_Name("labelMartialArtsSchoolCost");
		((Control)labelMartialArtsSchoolCost).set_Size(new Size(139, 21));
		((Control)labelMartialArtsSchoolCost).set_TabIndex(88);
		((Control)labelMartialArtsSchoolCost).set_Text("Koszt ulepszenia:");
		((Control)labelLevelOfMartialArtsSchool).set_AutoSize(true);
		((Control)labelLevelOfMartialArtsSchool).set_Font(new Font("Times New Roman", 14f));
		((Control)labelLevelOfMartialArtsSchool).set_Location(new Point(638, 295));
		((Control)labelLevelOfMartialArtsSchool).set_Name("labelLevelOfMartialArtsSchool");
		((Control)labelLevelOfMartialArtsSchool).set_Size(new Size(19, 21));
		((Control)labelLevelOfMartialArtsSchool).set_TabIndex(87);
		((Control)labelLevelOfMartialArtsSchool).set_Text("1");
		((Control)labelMartialArtsSchoolLevel).set_AutoSize(true);
		((Control)labelMartialArtsSchoolLevel).set_Font(new Font("Times New Roman", 14f));
		((Control)labelMartialArtsSchoolLevel).set_Location(new Point(572, 295));
		((Control)labelMartialArtsSchoolLevel).set_Name("labelMartialArtsSchoolLevel");
		((Control)labelMartialArtsSchoolLevel).set_Size(new Size(71, 21));
		((Control)labelMartialArtsSchoolLevel).set_TabIndex(86);
		((Control)labelMartialArtsSchoolLevel).set_Text("Poziom:");
		((Control)labelMartialArtsSchool).set_AutoSize(true);
		((Control)labelMartialArtsSchool).set_Font(new Font("Times New Roman", 14f));
		((Control)labelMartialArtsSchool).set_Location(new Point(572, 274));
		((Control)labelMartialArtsSchool).set_Name("labelMartialArtsSchool");
		((Control)labelMartialArtsSchool).set_Size(new Size(147, 21));
		((Control)labelMartialArtsSchool).set_TabIndex(85);
		((Control)labelMartialArtsSchool).set_Text("Szkoła sztuk walki");
		((Control)buttonUpgradeInfrastructure).set_Location(new Point(763, 439));
		((Control)buttonUpgradeInfrastructure).set_Name("buttonUpgradeInfrastructure");
		((Control)buttonUpgradeInfrastructure).set_Size(new Size(135, 41));
		((Control)buttonUpgradeInfrastructure).set_TabIndex(110);
		((Control)buttonUpgradeInfrastructure).set_Text("Ulepsz infrastuktórę");
		((ButtonBase)buttonUpgradeInfrastructure).set_UseVisualStyleBackColor(true);
		((Control)buttonUpgradeInfrastructure).add_Click((EventHandler)buttonUpgradeInfrastructure_Click);
		((Control)labelInfrastructureCostIron).set_AutoSize(true);
		((Control)labelInfrastructureCostIron).set_Font(new Font("Times New Roman", 14f));
		((Control)labelInfrastructureCostIron).set_Location(new Point(861, 400));
		((Control)labelInfrastructureCostIron).set_Name("labelInfrastructureCostIron");
		((Control)labelInfrastructureCostIron).set_Size(new Size(19, 21));
		((Control)labelInfrastructureCostIron).set_TabIndex(109);
		((Control)labelInfrastructureCostIron).set_Text("0");
		((Control)labelInfrastructureCostCrystals).set_AutoSize(true);
		((Control)labelInfrastructureCostCrystals).set_Font(new Font("Times New Roman", 14f));
		((Control)labelInfrastructureCostCrystals).set_Location(new Point(861, 379));
		((Control)labelInfrastructureCostCrystals).set_Name("labelInfrastructureCostCrystals");
		((Control)labelInfrastructureCostCrystals).set_Size(new Size(19, 21));
		((Control)labelInfrastructureCostCrystals).set_TabIndex(108);
		((Control)labelInfrastructureCostCrystals).set_Text("0");
		((Control)labelInfrastructureCostStone).set_AutoSize(true);
		((Control)labelInfrastructureCostStone).set_Font(new Font("Times New Roman", 14f));
		((Control)labelInfrastructureCostStone).set_Location(new Point(861, 358));
		((Control)labelInfrastructureCostStone).set_Name("labelInfrastructureCostStone");
		((Control)labelInfrastructureCostStone).set_Size(new Size(19, 21));
		((Control)labelInfrastructureCostStone).set_TabIndex(107);
		((Control)labelInfrastructureCostStone).set_Text("0");
		((Control)labelInfrastructureCostWood).set_AutoSize(true);
		((Control)labelInfrastructureCostWood).set_Font(new Font("Times New Roman", 14f));
		((Control)labelInfrastructureCostWood).set_Location(new Point(861, 337));
		((Control)labelInfrastructureCostWood).set_Name("labelInfrastructureCostWood");
		((Control)labelInfrastructureCostWood).set_Size(new Size(19, 21));
		((Control)labelInfrastructureCostWood).set_TabIndex(106);
		((Control)labelInfrastructureCostWood).set_Text("0");
		((Control)labelInfrastructureCrystals).set_AutoSize(true);
		((Control)labelInfrastructureCrystals).set_Font(new Font("Times New Roman", 14f));
		((Control)labelInfrastructureCrystals).set_Location(new Point(760, 379));
		((Control)labelInfrastructureCrystals).set_Name("labelInfrastructureCrystals");
		((Control)labelInfrastructureCrystals).set_Size(new Size(84, 21));
		((Control)labelInfrastructureCrystals).set_TabIndex(105);
		((Control)labelInfrastructureCrystals).set_Text("Kryształy:");
		((Control)labelInfrastructureIron).set_AutoSize(true);
		((Control)labelInfrastructureIron).set_Font(new Font("Times New Roman", 14f));
		((Control)labelInfrastructureIron).set_Location(new Point(759, 400));
		((Control)labelInfrastructureIron).set_Name("labelInfrastructureIron");
		((Control)labelInfrastructureIron).set_Size(new Size(63, 21));
		((Control)labelInfrastructureIron).set_TabIndex(104);
		((Control)labelInfrastructureIron).set_Text("Żelazo:");
		((Control)labelInfrastructureStone).set_AutoSize(true);
		((Control)labelInfrastructureStone).set_Font(new Font("Times New Roman", 14f));
		((Control)labelInfrastructureStone).set_Location(new Point(759, 358));
		((Control)labelInfrastructureStone).set_Name("labelInfrastructureStone");
		((Control)labelInfrastructureStone).set_Size(new Size(75, 21));
		((Control)labelInfrastructureStone).set_TabIndex(103);
		((Control)labelInfrastructureStone).set_Text("Kamień: ");
		((Control)labelInfrastructureWood).set_AutoSize(true);
		((Control)labelInfrastructureWood).set_Font(new Font("Times New Roman", 14f));
		((Control)labelInfrastructureWood).set_Location(new Point(759, 337));
		((Control)labelInfrastructureWood).set_Name("labelInfrastructureWood");
		((Control)labelInfrastructureWood).set_Size(new Size(73, 21));
		((Control)labelInfrastructureWood).set_TabIndex(102);
		((Control)labelInfrastructureWood).set_Text("Drewno:");
		((Control)labelInfrustructureCost).set_AutoSize(true);
		((Control)labelInfrustructureCost).set_Font(new Font("Times New Roman", 14f));
		((Control)labelInfrustructureCost).set_Location(new Point(759, 316));
		((Control)labelInfrustructureCost).set_Name("labelInfrustructureCost");
		((Control)labelInfrustructureCost).set_Size(new Size(139, 21));
		((Control)labelInfrustructureCost).set_TabIndex(101);
		((Control)labelInfrustructureCost).set_Text("Koszt ulepszenia:");
		((Control)labelLevelOfInfrastructure).set_AutoSize(true);
		((Control)labelLevelOfInfrastructure).set_Font(new Font("Times New Roman", 14f));
		((Control)labelLevelOfInfrastructure).set_Location(new Point(825, 295));
		((Control)labelLevelOfInfrastructure).set_Name("labelLevelOfInfrastructure");
		((Control)labelLevelOfInfrastructure).set_Size(new Size(19, 21));
		((Control)labelLevelOfInfrastructure).set_TabIndex(100);
		((Control)labelLevelOfInfrastructure).set_Text("1");
		((Control)labelInfrastructureLevel).set_AutoSize(true);
		((Control)labelInfrastructureLevel).set_Font(new Font("Times New Roman", 14f));
		((Control)labelInfrastructureLevel).set_Location(new Point(759, 295));
		((Control)labelInfrastructureLevel).set_Name("labelInfrastructureLevel");
		((Control)labelInfrastructureLevel).set_Size(new Size(71, 21));
		((Control)labelInfrastructureLevel).set_TabIndex(99);
		((Control)labelInfrastructureLevel).set_Text("Poziom:");
		((Control)labelInfrastructure).set_AutoSize(true);
		((Control)labelInfrastructure).set_Font(new Font("Times New Roman", 14f));
		((Control)labelInfrastructure).set_Location(new Point(759, 274));
		((Control)labelInfrastructure).set_Name("labelInfrastructure");
		((Control)labelInfrastructure).set_Size(new Size(110, 21));
		((Control)labelInfrastructure).set_TabIndex(98);
		((Control)labelInfrastructure).set_Text("Infrastruktura");
		((Control)buttonUpgradeCrystalMine).set_Location(new Point(752, 174));
		((Control)buttonUpgradeCrystalMine).set_Name("buttonUpgradeCrystalMine");
		((Control)buttonUpgradeCrystalMine).set_Size(new Size(135, 41));
		((Control)buttonUpgradeCrystalMine).set_TabIndex(123);
		((Control)buttonUpgradeCrystalMine).set_Text("Ulepsz kopalnię kryształów");
		((ButtonBase)buttonUpgradeCrystalMine).set_UseVisualStyleBackColor(true);
		((Control)buttonUpgradeCrystalMine).add_Click((EventHandler)buttonUpgradeCrystalMine_Click);
		((Control)labelCrystalMineCostIron).set_AutoSize(true);
		((Control)labelCrystalMineCostIron).set_Font(new Font("Times New Roman", 14f));
		((Control)labelCrystalMineCostIron).set_Location(new Point(850, 135));
		((Control)labelCrystalMineCostIron).set_Name("labelCrystalMineCostIron");
		((Control)labelCrystalMineCostIron).set_Size(new Size(19, 21));
		((Control)labelCrystalMineCostIron).set_TabIndex(122);
		((Control)labelCrystalMineCostIron).set_Text("0");
		((Control)labelCrystalMineCostCrystals).set_AutoSize(true);
		((Control)labelCrystalMineCostCrystals).set_Font(new Font("Times New Roman", 14f));
		((Control)labelCrystalMineCostCrystals).set_Location(new Point(850, 114));
		((Control)labelCrystalMineCostCrystals).set_Name("labelCrystalMineCostCrystals");
		((Control)labelCrystalMineCostCrystals).set_Size(new Size(19, 21));
		((Control)labelCrystalMineCostCrystals).set_TabIndex(121);
		((Control)labelCrystalMineCostCrystals).set_Text("0");
		((Control)labelCrystalMineCostStone).set_AutoSize(true);
		((Control)labelCrystalMineCostStone).set_Font(new Font("Times New Roman", 14f));
		((Control)labelCrystalMineCostStone).set_Location(new Point(850, 93));
		((Control)labelCrystalMineCostStone).set_Name("labelCrystalMineCostStone");
		((Control)labelCrystalMineCostStone).set_Size(new Size(19, 21));
		((Control)labelCrystalMineCostStone).set_TabIndex(120);
		((Control)labelCrystalMineCostStone).set_Text("0");
		((Control)labelCrystalMineCostWood).set_AutoSize(true);
		((Control)labelCrystalMineCostWood).set_Font(new Font("Times New Roman", 14f));
		((Control)labelCrystalMineCostWood).set_Location(new Point(850, 72));
		((Control)labelCrystalMineCostWood).set_Name("labelCrystalMineCostWood");
		((Control)labelCrystalMineCostWood).set_Size(new Size(19, 21));
		((Control)labelCrystalMineCostWood).set_TabIndex(119);
		((Control)labelCrystalMineCostWood).set_Text("0");
		((Control)labelCrystalMineCrystals).set_AutoSize(true);
		((Control)labelCrystalMineCrystals).set_Font(new Font("Times New Roman", 14f));
		((Control)labelCrystalMineCrystals).set_Location(new Point(749, 114));
		((Control)labelCrystalMineCrystals).set_Name("labelCrystalMineCrystals");
		((Control)labelCrystalMineCrystals).set_Size(new Size(84, 21));
		((Control)labelCrystalMineCrystals).set_TabIndex(118);
		((Control)labelCrystalMineCrystals).set_Text("Kryształy:");
		((Control)labelCrystalMineIron).set_AutoSize(true);
		((Control)labelCrystalMineIron).set_Font(new Font("Times New Roman", 14f));
		((Control)labelCrystalMineIron).set_Location(new Point(748, 135));
		((Control)labelCrystalMineIron).set_Name("labelCrystalMineIron");
		((Control)labelCrystalMineIron).set_Size(new Size(63, 21));
		((Control)labelCrystalMineIron).set_TabIndex(117);
		((Control)labelCrystalMineIron).set_Text("Żelazo:");
		((Control)labelCrystalMineStone).set_AutoSize(true);
		((Control)labelCrystalMineStone).set_Font(new Font("Times New Roman", 14f));
		((Control)labelCrystalMineStone).set_Location(new Point(748, 93));
		((Control)labelCrystalMineStone).set_Name("labelCrystalMineStone");
		((Control)labelCrystalMineStone).set_Size(new Size(75, 21));
		((Control)labelCrystalMineStone).set_TabIndex(116);
		((Control)labelCrystalMineStone).set_Text("Kamień: ");
		((Control)labelCrystalMineWood).set_AutoSize(true);
		((Control)labelCrystalMineWood).set_Font(new Font("Times New Roman", 14f));
		((Control)labelCrystalMineWood).set_Location(new Point(748, 72));
		((Control)labelCrystalMineWood).set_Name("labelCrystalMineWood");
		((Control)labelCrystalMineWood).set_Size(new Size(73, 21));
		((Control)labelCrystalMineWood).set_TabIndex(115);
		((Control)labelCrystalMineWood).set_Text("Drewno:");
		((Control)labelCrystalMineCost).set_AutoSize(true);
		((Control)labelCrystalMineCost).set_Font(new Font("Times New Roman", 14f));
		((Control)labelCrystalMineCost).set_Location(new Point(748, 51));
		((Control)labelCrystalMineCost).set_Name("labelCrystalMineCost");
		((Control)labelCrystalMineCost).set_Size(new Size(139, 21));
		((Control)labelCrystalMineCost).set_TabIndex(114);
		((Control)labelCrystalMineCost).set_Text("Koszt ulepszenia:");
		((Control)labelLevelOfCrystalsMine).set_AutoSize(true);
		((Control)labelLevelOfCrystalsMine).set_Font(new Font("Times New Roman", 14f));
		((Control)labelLevelOfCrystalsMine).set_Location(new Point(814, 30));
		((Control)labelLevelOfCrystalsMine).set_Name("labelLevelOfCrystalsMine");
		((Control)labelLevelOfCrystalsMine).set_Size(new Size(19, 21));
		((Control)labelLevelOfCrystalsMine).set_TabIndex(113);
		((Control)labelLevelOfCrystalsMine).set_Text("1");
		((Control)labelCrystalMineLevel).set_AutoSize(true);
		((Control)labelCrystalMineLevel).set_Font(new Font("Times New Roman", 14f));
		((Control)labelCrystalMineLevel).set_Location(new Point(748, 30));
		((Control)labelCrystalMineLevel).set_Name("labelCrystalMineLevel");
		((Control)labelCrystalMineLevel).set_Size(new Size(71, 21));
		((Control)labelCrystalMineLevel).set_TabIndex(112);
		((Control)labelCrystalMineLevel).set_Text("Poziom:");
		((Control)labelCrystalMine).set_AutoSize(true);
		((Control)labelCrystalMine).set_Font(new Font("Times New Roman", 14f));
		((Control)labelCrystalMine).set_Location(new Point(748, 9));
		((Control)labelCrystalMine).set_Name("labelCrystalMine");
		((Control)labelCrystalMine).set_Size(new Size(161, 21));
		((Control)labelCrystalMine).set_TabIndex(111);
		((Control)labelCrystalMine).set_Text("Kopalnia kryształów");
		((Control)buttonUpgradeElvishBuilding).set_Location(new Point(390, 439));
		((Control)buttonUpgradeElvishBuilding).set_Name("buttonUpgradeElvishBuilding");
		((Control)buttonUpgradeElvishBuilding).set_Size(new Size(135, 41));
		((Control)buttonUpgradeElvishBuilding).set_TabIndex(136);
		((Control)buttonUpgradeElvishBuilding).set_Text("Ulepsz fikuśne budynki");
		((ButtonBase)buttonUpgradeElvishBuilding).set_UseVisualStyleBackColor(true);
		((Control)buttonUpgradeElvishBuilding).add_Click((EventHandler)buttonUpgradeElvishBuilding_Click);
		((Control)labelElvishBuildingCostIron).set_AutoSize(true);
		((Control)labelElvishBuildingCostIron).set_Font(new Font("Times New Roman", 14f));
		((Control)labelElvishBuildingCostIron).set_Location(new Point(488, 400));
		((Control)labelElvishBuildingCostIron).set_Name("labelElvishBuildingCostIron");
		((Control)labelElvishBuildingCostIron).set_Size(new Size(19, 21));
		((Control)labelElvishBuildingCostIron).set_TabIndex(135);
		((Control)labelElvishBuildingCostIron).set_Text("0");
		((Control)labelElvishBuildingCostCrystals).set_AutoSize(true);
		((Control)labelElvishBuildingCostCrystals).set_Font(new Font("Times New Roman", 14f));
		((Control)labelElvishBuildingCostCrystals).set_Location(new Point(488, 379));
		((Control)labelElvishBuildingCostCrystals).set_Name("labelElvishBuildingCostCrystals");
		((Control)labelElvishBuildingCostCrystals).set_Size(new Size(19, 21));
		((Control)labelElvishBuildingCostCrystals).set_TabIndex(134);
		((Control)labelElvishBuildingCostCrystals).set_Text("0");
		((Control)labelElvishBuildingCostStone).set_AutoSize(true);
		((Control)labelElvishBuildingCostStone).set_Font(new Font("Times New Roman", 14f));
		((Control)labelElvishBuildingCostStone).set_Location(new Point(488, 358));
		((Control)labelElvishBuildingCostStone).set_Name("labelElvishBuildingCostStone");
		((Control)labelElvishBuildingCostStone).set_Size(new Size(19, 21));
		((Control)labelElvishBuildingCostStone).set_TabIndex(133);
		((Control)labelElvishBuildingCostStone).set_Text("0");
		((Control)labelElvishBuildingCostWood).set_AutoSize(true);
		((Control)labelElvishBuildingCostWood).set_Font(new Font("Times New Roman", 14f));
		((Control)labelElvishBuildingCostWood).set_Location(new Point(488, 337));
		((Control)labelElvishBuildingCostWood).set_Name("labelElvishBuildingCostWood");
		((Control)labelElvishBuildingCostWood).set_Size(new Size(19, 21));
		((Control)labelElvishBuildingCostWood).set_TabIndex(132);
		((Control)labelElvishBuildingCostWood).set_Text("0");
		((Control)labelElvishBuildingCrystals).set_AutoSize(true);
		((Control)labelElvishBuildingCrystals).set_Font(new Font("Times New Roman", 14f));
		((Control)labelElvishBuildingCrystals).set_Location(new Point(387, 379));
		((Control)labelElvishBuildingCrystals).set_Name("labelElvishBuildingCrystals");
		((Control)labelElvishBuildingCrystals).set_Size(new Size(84, 21));
		((Control)labelElvishBuildingCrystals).set_TabIndex(131);
		((Control)labelElvishBuildingCrystals).set_Text("Kryształy:");
		((Control)labelElvishBuildingIron).set_AutoSize(true);
		((Control)labelElvishBuildingIron).set_Font(new Font("Times New Roman", 14f));
		((Control)labelElvishBuildingIron).set_Location(new Point(386, 400));
		((Control)labelElvishBuildingIron).set_Name("labelElvishBuildingIron");
		((Control)labelElvishBuildingIron).set_Size(new Size(63, 21));
		((Control)labelElvishBuildingIron).set_TabIndex(130);
		((Control)labelElvishBuildingIron).set_Text("Żelazo:");
		((Control)labelElvishBuildingStone).set_AutoSize(true);
		((Control)labelElvishBuildingStone).set_Font(new Font("Times New Roman", 14f));
		((Control)labelElvishBuildingStone).set_Location(new Point(386, 358));
		((Control)labelElvishBuildingStone).set_Name("labelElvishBuildingStone");
		((Control)labelElvishBuildingStone).set_Size(new Size(75, 21));
		((Control)labelElvishBuildingStone).set_TabIndex(129);
		((Control)labelElvishBuildingStone).set_Text("Kamień: ");
		((Control)labelElvishBuildingWood).set_AutoSize(true);
		((Control)labelElvishBuildingWood).set_Font(new Font("Times New Roman", 14f));
		((Control)labelElvishBuildingWood).set_Location(new Point(386, 337));
		((Control)labelElvishBuildingWood).set_Name("labelElvishBuildingWood");
		((Control)labelElvishBuildingWood).set_Size(new Size(73, 21));
		((Control)labelElvishBuildingWood).set_TabIndex(128);
		((Control)labelElvishBuildingWood).set_Text("Drewno:");
		((Control)labelElvishBuildingCost).set_AutoSize(true);
		((Control)labelElvishBuildingCost).set_Font(new Font("Times New Roman", 14f));
		((Control)labelElvishBuildingCost).set_Location(new Point(386, 316));
		((Control)labelElvishBuildingCost).set_Name("labelElvishBuildingCost");
		((Control)labelElvishBuildingCost).set_Size(new Size(139, 21));
		((Control)labelElvishBuildingCost).set_TabIndex(127);
		((Control)labelElvishBuildingCost).set_Text("Koszt ulepszenia:");
		((Control)labelLevelOfElvishBuilding).set_AutoSize(true);
		((Control)labelLevelOfElvishBuilding).set_Font(new Font("Times New Roman", 14f));
		((Control)labelLevelOfElvishBuilding).set_Location(new Point(452, 295));
		((Control)labelLevelOfElvishBuilding).set_Name("labelLevelOfElvishBuilding");
		((Control)labelLevelOfElvishBuilding).set_Size(new Size(19, 21));
		((Control)labelLevelOfElvishBuilding).set_TabIndex(126);
		((Control)labelLevelOfElvishBuilding).set_Text("1");
		((Control)labelElvishBuildingLevel).set_AutoSize(true);
		((Control)labelElvishBuildingLevel).set_Font(new Font("Times New Roman", 14f));
		((Control)labelElvishBuildingLevel).set_Location(new Point(386, 295));
		((Control)labelElvishBuildingLevel).set_Name("labelElvishBuildingLevel");
		((Control)labelElvishBuildingLevel).set_Size(new Size(71, 21));
		((Control)labelElvishBuildingLevel).set_TabIndex(125);
		((Control)labelElvishBuildingLevel).set_Text("Poziom:");
		((Control)labelElvishBuilding).set_AutoSize(true);
		((Control)labelElvishBuilding).set_Font(new Font("Times New Roman", 14f));
		((Control)labelElvishBuilding).set_Location(new Point(386, 274));
		((Control)labelElvishBuilding).set_Name("labelElvishBuilding");
		((Control)labelElvishBuilding).set_Size(new Size(133, 21));
		((Control)labelElvishBuilding).set_TabIndex(124);
		((Control)labelElvishBuilding).set_Text("Fikuśne budynki");
		timerUpdaterLvlOfBuildingsAndCostOfConstruct.add_Tick((EventHandler)timerUpdaterLvlOfBuildingsAndCostOfConstruct_Tick);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(912, 492));
		((Control)this).get_Controls().Add((Control)(object)buttonUpgradeElvishBuilding);
		((Control)this).get_Controls().Add((Control)(object)labelElvishBuildingCostIron);
		((Control)this).get_Controls().Add((Control)(object)labelElvishBuildingCostCrystals);
		((Control)this).get_Controls().Add((Control)(object)labelElvishBuildingCostStone);
		((Control)this).get_Controls().Add((Control)(object)labelElvishBuildingCostWood);
		((Control)this).get_Controls().Add((Control)(object)labelElvishBuildingCrystals);
		((Control)this).get_Controls().Add((Control)(object)labelElvishBuildingIron);
		((Control)this).get_Controls().Add((Control)(object)labelElvishBuildingStone);
		((Control)this).get_Controls().Add((Control)(object)labelElvishBuildingWood);
		((Control)this).get_Controls().Add((Control)(object)labelElvishBuildingCost);
		((Control)this).get_Controls().Add((Control)(object)labelLevelOfElvishBuilding);
		((Control)this).get_Controls().Add((Control)(object)labelElvishBuildingLevel);
		((Control)this).get_Controls().Add((Control)(object)labelElvishBuilding);
		((Control)this).get_Controls().Add((Control)(object)buttonUpgradeCrystalMine);
		((Control)this).get_Controls().Add((Control)(object)labelCrystalMineCostIron);
		((Control)this).get_Controls().Add((Control)(object)labelCrystalMineCostCrystals);
		((Control)this).get_Controls().Add((Control)(object)labelCrystalMineCostStone);
		((Control)this).get_Controls().Add((Control)(object)labelCrystalMineCostWood);
		((Control)this).get_Controls().Add((Control)(object)labelCrystalMineCrystals);
		((Control)this).get_Controls().Add((Control)(object)labelCrystalMineIron);
		((Control)this).get_Controls().Add((Control)(object)labelCrystalMineStone);
		((Control)this).get_Controls().Add((Control)(object)labelCrystalMineWood);
		((Control)this).get_Controls().Add((Control)(object)labelCrystalMineCost);
		((Control)this).get_Controls().Add((Control)(object)labelLevelOfCrystalsMine);
		((Control)this).get_Controls().Add((Control)(object)labelCrystalMineLevel);
		((Control)this).get_Controls().Add((Control)(object)labelCrystalMine);
		((Control)this).get_Controls().Add((Control)(object)buttonUpgradeInfrastructure);
		((Control)this).get_Controls().Add((Control)(object)labelInfrastructureCostIron);
		((Control)this).get_Controls().Add((Control)(object)labelInfrastructureCostCrystals);
		((Control)this).get_Controls().Add((Control)(object)labelInfrastructureCostStone);
		((Control)this).get_Controls().Add((Control)(object)labelInfrastructureCostWood);
		((Control)this).get_Controls().Add((Control)(object)labelInfrastructureCrystals);
		((Control)this).get_Controls().Add((Control)(object)labelInfrastructureIron);
		((Control)this).get_Controls().Add((Control)(object)labelInfrastructureStone);
		((Control)this).get_Controls().Add((Control)(object)labelInfrastructureWood);
		((Control)this).get_Controls().Add((Control)(object)labelInfrustructureCost);
		((Control)this).get_Controls().Add((Control)(object)labelLevelOfInfrastructure);
		((Control)this).get_Controls().Add((Control)(object)labelInfrastructureLevel);
		((Control)this).get_Controls().Add((Control)(object)labelInfrastructure);
		((Control)this).get_Controls().Add((Control)(object)buttonUpgradeMartialArtsSchool);
		((Control)this).get_Controls().Add((Control)(object)labelMartialArtsSchoolCostIron);
		((Control)this).get_Controls().Add((Control)(object)labelMartialArtsSchoolCostCrystals);
		((Control)this).get_Controls().Add((Control)(object)labelMartialArtsSchoolCostStone);
		((Control)this).get_Controls().Add((Control)(object)labelMartialArtsSchoolCostWood);
		((Control)this).get_Controls().Add((Control)(object)labelMartialArtsSchoolCrystals);
		((Control)this).get_Controls().Add((Control)(object)labelMartialArtsSchoolIron);
		((Control)this).get_Controls().Add((Control)(object)labelMartialArtsSchoolStone);
		((Control)this).get_Controls().Add((Control)(object)labelMartialArtsSchoolWood);
		((Control)this).get_Controls().Add((Control)(object)labelMartialArtsSchoolCost);
		((Control)this).get_Controls().Add((Control)(object)labelLevelOfMartialArtsSchool);
		((Control)this).get_Controls().Add((Control)(object)labelMartialArtsSchoolLevel);
		((Control)this).get_Controls().Add((Control)(object)labelMartialArtsSchool);
		((Control)this).get_Controls().Add((Control)(object)buttonUpgradeTemple);
		((Control)this).get_Controls().Add((Control)(object)labelTempleCostIron);
		((Control)this).get_Controls().Add((Control)(object)labelTempleCostCrystals);
		((Control)this).get_Controls().Add((Control)(object)labelTempleCostStone);
		((Control)this).get_Controls().Add((Control)(object)labelTempleCostWood);
		((Control)this).get_Controls().Add((Control)(object)labelTempleCrystals);
		((Control)this).get_Controls().Add((Control)(object)labelTempleIron);
		((Control)this).get_Controls().Add((Control)(object)labelTempleStone);
		((Control)this).get_Controls().Add((Control)(object)labelTempleWood);
		((Control)this).get_Controls().Add((Control)(object)labelTempleCost);
		((Control)this).get_Controls().Add((Control)(object)labelLevelOfTemple);
		((Control)this).get_Controls().Add((Control)(object)labelTempleLevel);
		((Control)this).get_Controls().Add((Control)(object)labelTemple);
		((Control)this).get_Controls().Add((Control)(object)buttonUpgradeHouses);
		((Control)this).get_Controls().Add((Control)(object)labelHousesCostIron);
		((Control)this).get_Controls().Add((Control)(object)labelHousesCostCrystals);
		((Control)this).get_Controls().Add((Control)(object)labelHousesCostStone);
		((Control)this).get_Controls().Add((Control)(object)labelHousesCostWood);
		((Control)this).get_Controls().Add((Control)(object)labelHousesCrystals);
		((Control)this).get_Controls().Add((Control)(object)labelHousesIron);
		((Control)this).get_Controls().Add((Control)(object)labelHousesStone);
		((Control)this).get_Controls().Add((Control)(object)labelHousesWood);
		((Control)this).get_Controls().Add((Control)(object)labelHousesCost);
		((Control)this).get_Controls().Add((Control)(object)labelLevelOfHouses);
		((Control)this).get_Controls().Add((Control)(object)labelHousesLevel);
		((Control)this).get_Controls().Add((Control)(object)labelHouses);
		((Control)this).get_Controls().Add((Control)(object)buttonUpgradeIronWorks);
		((Control)this).get_Controls().Add((Control)(object)buttonUgradeHuntingBuild);
		((Control)this).get_Controls().Add((Control)(object)buttonUpgradeQuarry);
		((Control)this).get_Controls().Add((Control)(object)buttonUpgradeWoodshet);
		((Control)this).get_Controls().Add((Control)(object)labelIronWorksCostIron);
		((Control)this).get_Controls().Add((Control)(object)labelIronWorksCostCrystals);
		((Control)this).get_Controls().Add((Control)(object)labelIronWorksCostStone);
		((Control)this).get_Controls().Add((Control)(object)labelIronWorksCostWood);
		((Control)this).get_Controls().Add((Control)(object)labelIronWorksCrystals);
		((Control)this).get_Controls().Add((Control)(object)labelIronWorksIron);
		((Control)this).get_Controls().Add((Control)(object)labelIronWorksStone);
		((Control)this).get_Controls().Add((Control)(object)labelIronWorksWood);
		((Control)this).get_Controls().Add((Control)(object)labelIronWorksCost);
		((Control)this).get_Controls().Add((Control)(object)labelLevelOfIronWorks);
		((Control)this).get_Controls().Add((Control)(object)labelIronworksLevel);
		((Control)this).get_Controls().Add((Control)(object)labelIronWorks);
		((Control)this).get_Controls().Add((Control)(object)labelHuntingBuildingCostIron);
		((Control)this).get_Controls().Add((Control)(object)labelHuntingBuildingCostCrystals);
		((Control)this).get_Controls().Add((Control)(object)labelHuntingBuildingCostStone);
		((Control)this).get_Controls().Add((Control)(object)labelHuntingBuildingCostWood);
		((Control)this).get_Controls().Add((Control)(object)labelCrystalsHuntingBuildingCrystals);
		((Control)this).get_Controls().Add((Control)(object)labelHuntingBuildingIron);
		((Control)this).get_Controls().Add((Control)(object)labelHuntingBuildingStone);
		((Control)this).get_Controls().Add((Control)(object)labelHuntingBuildingWood);
		((Control)this).get_Controls().Add((Control)(object)labelHuntingBuildingCost);
		((Control)this).get_Controls().Add((Control)(object)labelLevelOfHuntingBuilding);
		((Control)this).get_Controls().Add((Control)(object)labelHuntingBuildingLevel);
		((Control)this).get_Controls().Add((Control)(object)labelHuntingBuilding);
		((Control)this).get_Controls().Add((Control)(object)labelQuarryCostIron);
		((Control)this).get_Controls().Add((Control)(object)labelQuarryCostCrystals);
		((Control)this).get_Controls().Add((Control)(object)labelQuarryCostStone);
		((Control)this).get_Controls().Add((Control)(object)labelQuarryCostWood);
		((Control)this).get_Controls().Add((Control)(object)labelQuarryCrystals);
		((Control)this).get_Controls().Add((Control)(object)labelQuarryIron);
		((Control)this).get_Controls().Add((Control)(object)labelQuarryStone);
		((Control)this).get_Controls().Add((Control)(object)labelQuarryWood);
		((Control)this).get_Controls().Add((Control)(object)labelQuarryCost);
		((Control)this).get_Controls().Add((Control)(object)labelLevelOfQuarry);
		((Control)this).get_Controls().Add((Control)(object)labelQuarryLevel);
		((Control)this).get_Controls().Add((Control)(object)labelQuarry);
		((Control)this).get_Controls().Add((Control)(object)labelWoodshetCostIron);
		((Control)this).get_Controls().Add((Control)(object)labelWoodshetCostCrystals);
		((Control)this).get_Controls().Add((Control)(object)labelWoodshetCostStone);
		((Control)this).get_Controls().Add((Control)(object)labelWoodshetCostWood);
		((Control)this).get_Controls().Add((Control)(object)labelWoodshetCrystals);
		((Control)this).get_Controls().Add((Control)(object)labelWoodshetIron);
		((Control)this).get_Controls().Add((Control)(object)labelWoodshetStone);
		((Control)this).get_Controls().Add((Control)(object)labelWoodshetWood);
		((Control)this).get_Controls().Add((Control)(object)labelWoodshetCost);
		((Control)this).get_Controls().Add((Control)(object)labelLevelOfWoodshet);
		((Control)this).get_Controls().Add((Control)(object)labelWoodshetLevel);
		((Control)this).get_Controls().Add((Control)(object)labelWoodshet);
		((Control)this).set_MaximumSize(new Size(928, 531));
		((Control)this).set_MinimumSize(new Size(928, 531));
		((Control)this).set_Name("FormBuildings");
		((Control)this).set_Text("Budynki");
		((Form)this).add_Load((EventHandler)FormBuildings_Load);
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
