using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Elfie_city;

public class FormTraining : Form
{
	private IContainer components = null;

	private PictureBox pictureBoxElvishArcher;

	private PictureBox pictureBoxElvishWarrior;

	private PictureBox pictureBoxElvishMaster;

	private Label labelElvishArcher;

	private Label labelElvishWarrior;

	private Label labelElvishMaster;

	private Label labelElvishArcherTrainingCost;

	private Label labelElvishWarriorTrainingCost;

	private Label labelElvishMasterTrainingCost;

	private Label labelElvishArcherTrainingWood;

	private Label labelElvishWarriorTrainingWood;

	private Label labelElvishMasterTrainingWood;

	private Label labelElvishArcherTrainingStone;

	private Label labelElvishWarriorTrainingStone;

	private Label labelElvishMasterTrainingStone;

	private Label labelElvishArcherTrainingIron;

	private Label labelElvishWarriorTrainingIron;

	private Label labelElvishMasterTrainingIron;

	private Label labelElvishArcherTrainingCrytals;

	private Label labelElvishWarriorTrainingCrystals;

	private Label labelElvishMasterTrainingCrystals;

	private Label labelElvishArcherTrainingCostWood;

	private Label labelElvishArcherTrainingCostStone;

	private Label labelElvishArcherTrainingCostIron;

	private Label labelElvishArcherTrainingCostCrystals;

	private Label labelElvishWarriorTrainingCostCrystals;

	private Label labelElvishWarriorTrainingCostIron;

	private Label labelElvishWarriorTrainingCostStone;

	private Label labelElvishWarriorTrainingCostWood;

	private Label labelElvishMasterTrainingCostCrystals;

	private Label labelElvishMasterTrainingCostIron;

	private Label labelElvishMasterTrainingCostStone;

	private Label labelElvishMasterTrainingCostWood;

	private Label labelElvishArcherTrainingPopulation;

	private Label labelElvishArcherTrainingCostPopulation;

	private Label labelElvishWarriorTrainingCostPopulation;

	private Label labelElvishWarriorTrainingPopulation;

	private Label labelElvishMasterTrainingCostPopulation;

	private Label labelElvishMasterTrainingPopulation;

	private Label labelElvishArcherTrainingFood;

	private Label labelElvishArcherTrainingCostFood;

	private Label label1;

	private Label labelElvishWarriorTrainingCostFood;

	private Label label2;

	private Label labelElvishMasterTrainingCostFood;

	private Label labelWarning;

	private Button buttonElvishArcherTrain;

	private Button buttonElvishWarriorTrain;

	private Button buttonElvishMasterTrain;

	private Label labelElvishArcherQuantity;

	private Label labelElvishWarriorQuantity;

	private Label labelElvishMasterQuantity;

	private Label labelElvishArcherTrainingTime;

	private Label labelElvishArcherTrainingCostTime;

	private Label labelElvishWarriorTrainingCostTime;

	private Label labelElvishWarriorTrainingTime;

	private Label labelElvishMasterTrainingTime;

	private Label labelElvishMasterTrainingCostTime;

	private Timer timerElvishArcherTraining;

	private Timer timer2;

	private Timer timerElvishWarriorTraining;

	private Timer timerElvishMasterTraining;

	private Label label3;

	private Timer timerUpdater;

	private ProgressBar progressBarElvishMasterTraining;

	private ProgressBar progressBarElvishWarriorTraining;

	private ProgressBar progressBarElvishArcherTraining;

	private Timer timerElvishArcherProgressBar;

	private Timer timerElvishWarriorProgressBar;

	private Timer timerElvishMasterProgressBar;

	public FormTraining()
	{
		InitializeComponent();
	}

	private void FormTraining_Load(object sender, EventArgs e)
	{
		((Control)labelElvishArcherQuantity).set_Text(ElvishArcher.ElvishList.Count.ToString());
		((Control)labelElvishWarriorQuantity).set_Text(ElvishWarrior.ElvishList.Count.ToString());
		((Control)labelElvishMasterQuantity).set_Text(ElvishMaster.ElvishList.Count.ToString());
		int[] array = ElvishArcher.TrainingCost();
		((Control)labelElvishArcherTrainingCostFood).set_Text(array[0].ToString());
		((Control)labelElvishArcherTrainingCostWood).set_Text(array[1].ToString());
		((Control)labelElvishArcherTrainingCostStone).set_Text(array[2].ToString());
		((Control)labelElvishArcherTrainingCostIron).set_Text(array[3].ToString());
		((Control)labelElvishArcherTrainingCostCrystals).set_Text(array[4].ToString());
		((Control)labelElvishArcherTrainingCostPopulation).set_Text(array[5].ToString());
		array = ElvishWarrior.TrainingCost();
		((Control)labelElvishWarriorTrainingCostFood).set_Text(array[0].ToString());
		((Control)labelElvishWarriorTrainingCostWood).set_Text(array[1].ToString());
		((Control)labelElvishWarriorTrainingCostStone).set_Text(array[2].ToString());
		((Control)labelElvishWarriorTrainingCostIron).set_Text(array[3].ToString());
		((Control)labelElvishWarriorTrainingCostCrystals).set_Text(array[4].ToString());
		((Control)labelElvishWarriorTrainingCostPopulation).set_Text(array[5].ToString());
		array = ElvishMaster.TrainingCost();
		((Control)labelElvishMasterTrainingCostFood).set_Text(array[0].ToString());
		((Control)labelElvishMasterTrainingCostWood).set_Text(array[1].ToString());
		((Control)labelElvishMasterTrainingCostStone).set_Text(array[2].ToString());
		((Control)labelElvishMasterTrainingCostIron).set_Text(array[3].ToString());
		((Control)labelElvishMasterTrainingCostCrystals).set_Text(array[4].ToString());
		((Control)labelElvishMasterTrainingCostPopulation).set_Text(array[5].ToString());
		((Control)labelElvishArcherTrainingCostTime).set_Text((ElvishArcher.TrainingTime() / 1000).ToString());
		((Control)labelElvishWarriorTrainingCostTime).set_Text((ElvishWarrior.TrainingTime() / 1000).ToString());
		((Control)labelElvishMasterTrainingCostTime).set_Text((ElvishMaster.TrainingTime() / 1000).ToString());
		timerUpdater.set_Interval(100);
		timerUpdater.Start();
	}

	private bool IfEnoughtResources(Label costFood, Label costWood, Label costStone, Label costIron, Label costCrystals, Label costPopulation)
	{
		int num = Convert.ToInt32(Math.Round((double)Resources.Population / 2.0)) - ElvishArcher.ElvishList.Count - ElvishWarrior.ElvishList.Count - int.Parse(((Control)labelElvishMasterTrainingCostPopulation).get_Text()) * ElvishMaster.ElvishList.Count;
		if (Resources.ResourcesFood >= int.Parse(((Control)costFood).get_Text()) && Resources.ResourcesWood >= int.Parse(((Control)costWood).get_Text()) && Resources.ResoucresStone >= int.Parse(((Control)costStone).get_Text()) && Resources.ResoucresIron >= int.Parse(((Control)costIron).get_Text()) && Resources.ResoucresCrystals >= int.Parse(((Control)costCrystals).get_Text()) && num >= int.Parse(((Control)costPopulation).get_Text()))
		{
			Resources.ResourcesFood -= int.Parse(((Control)costFood).get_Text());
			Resources.ResourcesWood -= int.Parse(((Control)costWood).get_Text());
			Resources.ResoucresStone -= int.Parse(((Control)costStone).get_Text());
			Resources.ResoucresIron -= int.Parse(((Control)costIron).get_Text());
			Resources.ResoucresCrystals -= int.Parse(((Control)costCrystals).get_Text());
			return true;
		}
		return false;
	}

	private void buttonElvishArcherTrain_Click(object sender, EventArgs e)
	{
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		if (IfEnoughtResources(labelElvishArcherTrainingCostFood, labelElvishArcherTrainingCostWood, labelElvishArcherTrainingCostStone, labelElvishArcherTrainingCostIron, labelElvishArcherTrainingCostCrystals, labelElvishArcherTrainingCostPopulation))
		{
			timerElvishArcherTraining.set_Interval(ElvishArcher.TrainingTime());
			timerElvishArcherProgressBar.set_Interval(ElvishArcher.TrainingTime() / 110 + 1);
			timerElvishArcherProgressBar.Start();
			timerElvishArcherTraining.Start();
			((Control)buttonElvishArcherTrain).set_Enabled(false);
		}
		else
		{
			MessageBox.Show("Brak wystarczajacych ilosci zasobow");
		}
	}

	private void buttonElvishWarriorTrain_Click(object sender, EventArgs e)
	{
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		if (IfEnoughtResources(labelElvishWarriorTrainingCostFood, labelElvishWarriorTrainingCostWood, labelElvishWarriorTrainingCostStone, labelElvishWarriorTrainingCostIron, labelElvishWarriorTrainingCostCrystals, labelElvishWarriorTrainingCostPopulation))
		{
			timerElvishWarriorTraining.set_Interval(ElvishWarrior.TrainingTime());
			timerElvishWarriorProgressBar.set_Interval(timerElvishWarriorTraining.get_Interval() / 110 + 1);
			timerElvishWarriorProgressBar.Start();
			timerElvishWarriorTraining.Start();
			((Control)buttonElvishWarriorTrain).set_Enabled(false);
		}
		else
		{
			MessageBox.Show("Brak wystarczajacych ilosci zasobow");
		}
	}

	private void buttonElvishMasterTrain_Click(object sender, EventArgs e)
	{
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		if (IfEnoughtResources(labelElvishMasterTrainingCostFood, labelElvishMasterTrainingCostWood, labelElvishMasterTrainingCostStone, labelElvishMasterTrainingCostIron, labelElvishMasterTrainingCostCrystals, labelElvishMasterTrainingCostPopulation))
		{
			timerElvishMasterTraining.set_Interval(ElvishMaster.TrainingTime());
			timerElvishMasterProgressBar.set_Interval(timerElvishMasterTraining.get_Interval() / 110 + 1);
			timerElvishMasterProgressBar.Start();
			timerElvishMasterTraining.Start();
			((Control)buttonElvishMasterTrain).set_Enabled(false);
		}
		else
		{
			MessageBox.Show("Brak wystarczajacych ilosci zasobow");
		}
	}

	private void timerElvishArcherTraining_Tick(object sender, EventArgs e)
	{
		timerElvishArcherTraining.Stop();
		timerElvishArcherProgressBar.Stop();
		progressBarElvishArcherTraining.set_Value(0);
		new ElvishArcher();
		((Control)buttonElvishArcherTrain).set_Enabled(true);
	}

	private void timerElvishWarriorTraining_Tick(object sender, EventArgs e)
	{
		timerElvishWarriorTraining.Stop();
		timerElvishWarriorProgressBar.Stop();
		new ElvishWarrior();
		progressBarElvishWarriorTraining.set_Value(0);
		((Control)buttonElvishWarriorTrain).set_Enabled(true);
	}

	private void timerElvishMasterTraining_Tick(object sender, EventArgs e)
	{
		timerElvishMasterTraining.Stop();
		timerElvishMasterProgressBar.Stop();
		new ElvishMaster();
		progressBarElvishMasterTraining.set_Value(0);
		((Control)buttonElvishMasterTrain).set_Enabled(true);
	}

	private void timerUpdater_Tick(object sender, EventArgs e)
	{
		((Control)labelElvishArcherQuantity).set_Text(ElvishArcher.ElvishList.Count.ToString());
		((Control)labelElvishWarriorQuantity).set_Text(ElvishWarrior.ElvishList.Count.ToString());
		((Control)labelElvishMasterQuantity).set_Text(ElvishMaster.ElvishList.Count.ToString());
		((Control)labelElvishArcherTrainingCostTime).set_Text((ElvishArcher.TrainingTime() / 1000).ToString());
		((Control)labelElvishWarriorTrainingCostTime).set_Text((ElvishWarrior.TrainingTime() / 1000).ToString());
		((Control)labelElvishMasterTrainingCostTime).set_Text((ElvishMaster.TrainingTime() / 1000).ToString());
	}

	private void timerElvishArcherProgressBar_Tick(object sender, EventArgs e)
	{
		progressBarElvishArcherTraining.Increment(1);
	}

	private void timerElvishWarriorProgressBar_Tick(object sender, EventArgs e)
	{
		progressBarElvishWarriorTraining.Increment(1);
	}

	private void timerElvishMasterProgressBar_Tick(object sender, EventArgs e)
	{
		progressBarElvishMasterTraining.Increment(1);
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
		//IL_0290: Unknown result type (might be due to invalid IL or missing references)
		//IL_029a: Expected O, but got Unknown
		//IL_02a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ab: Expected O, but got Unknown
		//IL_02b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bc: Expected O, but got Unknown
		//IL_02c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cd: Expected O, but got Unknown
		//IL_02ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d8: Expected O, but got Unknown
		//IL_02df: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e9: Expected O, but got Unknown
		//IL_02ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f4: Expected O, but got Unknown
		//IL_02f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ff: Expected O, but got Unknown
		//IL_0300: Unknown result type (might be due to invalid IL or missing references)
		//IL_030a: Expected O, but got Unknown
		//IL_0311: Unknown result type (might be due to invalid IL or missing references)
		//IL_031b: Expected O, but got Unknown
		//IL_0322: Unknown result type (might be due to invalid IL or missing references)
		//IL_032c: Expected O, but got Unknown
		//IL_0333: Unknown result type (might be due to invalid IL or missing references)
		//IL_033d: Expected O, but got Unknown
		//IL_0380: Unknown result type (might be due to invalid IL or missing references)
		//IL_038a: Expected O, but got Unknown
		//IL_03fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0406: Expected O, but got Unknown
		//IL_047f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0489: Expected O, but got Unknown
		//IL_04ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0509: Expected O, but got Unknown
		//IL_057b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0585: Expected O, but got Unknown
		//IL_05fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0605: Expected O, but got Unknown
		//IL_067b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0685: Expected O, but got Unknown
		//IL_06f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0703: Expected O, but got Unknown
		//IL_077a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0784: Expected O, but got Unknown
		//IL_07fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0805: Expected O, but got Unknown
		//IL_0879: Unknown result type (might be due to invalid IL or missing references)
		//IL_0883: Expected O, but got Unknown
		//IL_08fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0904: Expected O, but got Unknown
		//IL_097b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0985: Expected O, but got Unknown
		//IL_09f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a03: Expected O, but got Unknown
		//IL_0a7a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a84: Expected O, but got Unknown
		//IL_0afb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b05: Expected O, but got Unknown
		//IL_0b79: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b83: Expected O, but got Unknown
		//IL_0bfa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c04: Expected O, but got Unknown
		//IL_0c7b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c85: Expected O, but got Unknown
		//IL_0cf9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d03: Expected O, but got Unknown
		//IL_0d77: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d81: Expected O, but got Unknown
		//IL_0df5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dff: Expected O, but got Unknown
		//IL_0f9f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fa9: Expected O, but got Unknown
		//IL_1020: Unknown result type (might be due to invalid IL or missing references)
		//IL_102a: Expected O, but got Unknown
		//IL_10a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_10ab: Expected O, but got Unknown
		//IL_1122: Unknown result type (might be due to invalid IL or missing references)
		//IL_112c: Expected O, but got Unknown
		//IL_11a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_11ad: Expected O, but got Unknown
		//IL_1224: Unknown result type (might be due to invalid IL or missing references)
		//IL_122e: Expected O, but got Unknown
		//IL_12a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_12af: Expected O, but got Unknown
		//IL_1326: Unknown result type (might be due to invalid IL or missing references)
		//IL_1330: Expected O, but got Unknown
		//IL_13a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_13b1: Expected O, but got Unknown
		//IL_1425: Unknown result type (might be due to invalid IL or missing references)
		//IL_142f: Expected O, but got Unknown
		//IL_14a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_14ad: Expected O, but got Unknown
		//IL_1524: Unknown result type (might be due to invalid IL or missing references)
		//IL_152e: Expected O, but got Unknown
		//IL_15a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_15af: Expected O, but got Unknown
		//IL_1626: Unknown result type (might be due to invalid IL or missing references)
		//IL_1630: Expected O, but got Unknown
		//IL_16a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_16b1: Expected O, but got Unknown
		//IL_1725: Unknown result type (might be due to invalid IL or missing references)
		//IL_172f: Expected O, but got Unknown
		//IL_17a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_17ad: Expected O, but got Unknown
		//IL_1824: Unknown result type (might be due to invalid IL or missing references)
		//IL_182e: Expected O, but got Unknown
		//IL_18a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_18af: Expected O, but got Unknown
		//IL_1926: Unknown result type (might be due to invalid IL or missing references)
		//IL_1930: Expected O, but got Unknown
		//IL_19a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_19b1: Expected O, but got Unknown
		//IL_1bb6: Unknown result type (might be due to invalid IL or missing references)
		//IL_1bc0: Expected O, but got Unknown
		//IL_1c4b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c55: Expected O, but got Unknown
		//IL_1ce3: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ced: Expected O, but got Unknown
		//IL_1d74: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d7e: Expected O, but got Unknown
		//IL_1df2: Unknown result type (might be due to invalid IL or missing references)
		//IL_1dfc: Expected O, but got Unknown
		//IL_1e70: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e7a: Expected O, but got Unknown
		//IL_1ef1: Unknown result type (might be due to invalid IL or missing references)
		//IL_1efb: Expected O, but got Unknown
		//IL_1f72: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f7c: Expected O, but got Unknown
		//IL_1ff3: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ffd: Expected O, but got Unknown
		//IL_20b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_20c3: Expected O, but got Unknown
		components = new Container();
		labelElvishArcher = new Label();
		labelElvishWarrior = new Label();
		labelElvishMaster = new Label();
		labelElvishArcherTrainingCost = new Label();
		labelElvishWarriorTrainingCost = new Label();
		labelElvishMasterTrainingCost = new Label();
		labelElvishArcherTrainingWood = new Label();
		labelElvishWarriorTrainingWood = new Label();
		labelElvishMasterTrainingWood = new Label();
		labelElvishArcherTrainingStone = new Label();
		labelElvishWarriorTrainingStone = new Label();
		labelElvishMasterTrainingStone = new Label();
		labelElvishArcherTrainingIron = new Label();
		labelElvishWarriorTrainingIron = new Label();
		labelElvishMasterTrainingIron = new Label();
		labelElvishArcherTrainingCrytals = new Label();
		labelElvishWarriorTrainingCrystals = new Label();
		labelElvishMasterTrainingCrystals = new Label();
		labelElvishArcherTrainingCostWood = new Label();
		labelElvishArcherTrainingCostStone = new Label();
		labelElvishArcherTrainingCostIron = new Label();
		labelElvishArcherTrainingCostCrystals = new Label();
		pictureBoxElvishMaster = new PictureBox();
		pictureBoxElvishWarrior = new PictureBox();
		pictureBoxElvishArcher = new PictureBox();
		labelElvishWarriorTrainingCostCrystals = new Label();
		labelElvishWarriorTrainingCostIron = new Label();
		labelElvishWarriorTrainingCostStone = new Label();
		labelElvishWarriorTrainingCostWood = new Label();
		labelElvishMasterTrainingCostCrystals = new Label();
		labelElvishMasterTrainingCostIron = new Label();
		labelElvishMasterTrainingCostStone = new Label();
		labelElvishMasterTrainingCostWood = new Label();
		labelElvishArcherTrainingPopulation = new Label();
		labelElvishArcherTrainingCostPopulation = new Label();
		labelElvishWarriorTrainingCostPopulation = new Label();
		labelElvishWarriorTrainingPopulation = new Label();
		labelElvishMasterTrainingCostPopulation = new Label();
		labelElvishMasterTrainingPopulation = new Label();
		labelElvishArcherTrainingFood = new Label();
		labelElvishArcherTrainingCostFood = new Label();
		label1 = new Label();
		labelElvishWarriorTrainingCostFood = new Label();
		label2 = new Label();
		labelElvishMasterTrainingCostFood = new Label();
		labelWarning = new Label();
		buttonElvishArcherTrain = new Button();
		buttonElvishWarriorTrain = new Button();
		buttonElvishMasterTrain = new Button();
		labelElvishArcherQuantity = new Label();
		labelElvishWarriorQuantity = new Label();
		labelElvishMasterQuantity = new Label();
		labelElvishArcherTrainingTime = new Label();
		labelElvishArcherTrainingCostTime = new Label();
		labelElvishWarriorTrainingCostTime = new Label();
		labelElvishWarriorTrainingTime = new Label();
		labelElvishMasterTrainingTime = new Label();
		labelElvishMasterTrainingCostTime = new Label();
		timerElvishArcherTraining = new Timer(components);
		timer2 = new Timer(components);
		timerElvishWarriorTraining = new Timer(components);
		timerElvishMasterTraining = new Timer(components);
		label3 = new Label();
		timerUpdater = new Timer(components);
		progressBarElvishMasterTraining = new ProgressBar();
		progressBarElvishWarriorTraining = new ProgressBar();
		progressBarElvishArcherTraining = new ProgressBar();
		timerElvishArcherProgressBar = new Timer(components);
		timerElvishWarriorProgressBar = new Timer(components);
		timerElvishMasterProgressBar = new Timer(components);
		((ISupportInitialize)pictureBoxElvishMaster).BeginInit();
		((ISupportInitialize)pictureBoxElvishWarrior).BeginInit();
		((ISupportInitialize)pictureBoxElvishArcher).BeginInit();
		((Control)this).SuspendLayout();
		((Control)labelElvishArcher).set_AutoSize(true);
		((Control)labelElvishArcher).set_Font(new Font("Times New Roman", 16f));
		((Control)labelElvishArcher).set_Location(new Point(7, 329));
		((Control)labelElvishArcher).set_Name("labelElvishArcher");
		((Control)labelElvishArcher).set_Size(new Size(113, 25));
		((Control)labelElvishArcher).set_TabIndex(3);
		((Control)labelElvishArcher).set_Text("Elfi łucznik");
		((Control)labelElvishWarrior).set_AutoSize(true);
		((Control)labelElvishWarrior).set_Font(new Font("Times New Roman", 16f));
		((Control)labelElvishWarrior).set_Location(new Point(252, 332));
		((Control)labelElvishWarrior).set_Name("labelElvishWarrior");
		((Control)labelElvishWarrior).set_Size(new Size(135, 25));
		((Control)labelElvishWarrior).set_TabIndex(4);
		((Control)labelElvishWarrior).set_Text("Elfi wojownik");
		((Control)labelElvishMaster).set_AutoSize(true);
		((Control)labelElvishMaster).set_Font(new Font("Times New Roman", 16f));
		((Control)labelElvishMaster).set_Location(new Point(481, 331));
		((Control)labelElvishMaster).set_Name("labelElvishMaster");
		((Control)labelElvishMaster).set_Size(new Size(106, 25));
		((Control)labelElvishMaster).set_TabIndex(5);
		((Control)labelElvishMaster).set_Text("Elfi Mistrz");
		((Control)labelElvishArcherTrainingCost).set_AutoSize(true);
		((Control)labelElvishArcherTrainingCost).set_Font(new Font("Times New Roman", 14f));
		((Control)labelElvishArcherTrainingCost).set_Location(new Point(8, 354));
		((Control)labelElvishArcherTrainingCost).set_Name("labelElvishArcherTrainingCost");
		((Control)labelElvishArcherTrainingCost).set_Size(new Size(122, 21));
		((Control)labelElvishArcherTrainingCost).set_TabIndex(6);
		((Control)labelElvishArcherTrainingCost).set_Text("Koszt treningu:");
		((Control)labelElvishWarriorTrainingCost).set_AutoSize(true);
		((Control)labelElvishWarriorTrainingCost).set_Font(new Font("Times New Roman", 14f));
		((Control)labelElvishWarriorTrainingCost).set_Location(new Point(253, 355));
		((Control)labelElvishWarriorTrainingCost).set_Name("labelElvishWarriorTrainingCost");
		((Control)labelElvishWarriorTrainingCost).set_Size(new Size(122, 21));
		((Control)labelElvishWarriorTrainingCost).set_TabIndex(7);
		((Control)labelElvishWarriorTrainingCost).set_Text("Koszt treningu:");
		((Control)labelElvishMasterTrainingCost).set_AutoSize(true);
		((Control)labelElvishMasterTrainingCost).set_Font(new Font("Times New Roman", 14f));
		((Control)labelElvishMasterTrainingCost).set_Location(new Point(482, 356));
		((Control)labelElvishMasterTrainingCost).set_Name("labelElvishMasterTrainingCost");
		((Control)labelElvishMasterTrainingCost).set_Size(new Size(122, 21));
		((Control)labelElvishMasterTrainingCost).set_TabIndex(8);
		((Control)labelElvishMasterTrainingCost).set_Text("Koszt treningu:");
		((Control)labelElvishArcherTrainingWood).set_AutoSize(true);
		((Control)labelElvishArcherTrainingWood).set_Font(new Font("Times New Roman", 14f));
		((Control)labelElvishArcherTrainingWood).set_Location(new Point(22, 394));
		((Control)labelElvishArcherTrainingWood).set_Name("labelElvishArcherTrainingWood");
		((Control)labelElvishArcherTrainingWood).set_Size(new Size(73, 21));
		((Control)labelElvishArcherTrainingWood).set_TabIndex(9);
		((Control)labelElvishArcherTrainingWood).set_Text("Drewno:");
		((Control)labelElvishWarriorTrainingWood).set_AutoSize(true);
		((Control)labelElvishWarriorTrainingWood).set_Font(new Font("Times New Roman", 14f));
		((Control)labelElvishWarriorTrainingWood).set_Location(new Point(264, 397));
		((Control)labelElvishWarriorTrainingWood).set_Name("labelElvishWarriorTrainingWood");
		((Control)labelElvishWarriorTrainingWood).set_Size(new Size(73, 21));
		((Control)labelElvishWarriorTrainingWood).set_TabIndex(10);
		((Control)labelElvishWarriorTrainingWood).set_Text("Drewno:");
		((Control)labelElvishMasterTrainingWood).set_AutoSize(true);
		((Control)labelElvishMasterTrainingWood).set_Font(new Font("Times New Roman", 14f));
		((Control)labelElvishMasterTrainingWood).set_Location(new Point(496, 396));
		((Control)labelElvishMasterTrainingWood).set_Name("labelElvishMasterTrainingWood");
		((Control)labelElvishMasterTrainingWood).set_Size(new Size(73, 21));
		((Control)labelElvishMasterTrainingWood).set_TabIndex(11);
		((Control)labelElvishMasterTrainingWood).set_Text("Drewno:");
		((Control)labelElvishArcherTrainingStone).set_AutoSize(true);
		((Control)labelElvishArcherTrainingStone).set_Font(new Font("Times New Roman", 14f));
		((Control)labelElvishArcherTrainingStone).set_Location(new Point(22, 415));
		((Control)labelElvishArcherTrainingStone).set_Name("labelElvishArcherTrainingStone");
		((Control)labelElvishArcherTrainingStone).set_Size(new Size(70, 21));
		((Control)labelElvishArcherTrainingStone).set_TabIndex(12);
		((Control)labelElvishArcherTrainingStone).set_Text("Kamień:");
		((Control)labelElvishWarriorTrainingStone).set_AutoSize(true);
		((Control)labelElvishWarriorTrainingStone).set_Font(new Font("Times New Roman", 14f));
		((Control)labelElvishWarriorTrainingStone).set_Location(new Point(263, 418));
		((Control)labelElvishWarriorTrainingStone).set_Name("labelElvishWarriorTrainingStone");
		((Control)labelElvishWarriorTrainingStone).set_Size(new Size(70, 21));
		((Control)labelElvishWarriorTrainingStone).set_TabIndex(13);
		((Control)labelElvishWarriorTrainingStone).set_Text("Kamień:");
		((Control)labelElvishMasterTrainingStone).set_AutoSize(true);
		((Control)labelElvishMasterTrainingStone).set_Font(new Font("Times New Roman", 14f));
		((Control)labelElvishMasterTrainingStone).set_Location(new Point(495, 417));
		((Control)labelElvishMasterTrainingStone).set_Name("labelElvishMasterTrainingStone");
		((Control)labelElvishMasterTrainingStone).set_Size(new Size(70, 21));
		((Control)labelElvishMasterTrainingStone).set_TabIndex(14);
		((Control)labelElvishMasterTrainingStone).set_Text("Kamień:");
		((Control)labelElvishArcherTrainingIron).set_AutoSize(true);
		((Control)labelElvishArcherTrainingIron).set_Font(new Font("Times New Roman", 14f));
		((Control)labelElvishArcherTrainingIron).set_Location(new Point(22, 436));
		((Control)labelElvishArcherTrainingIron).set_Name("labelElvishArcherTrainingIron");
		((Control)labelElvishArcherTrainingIron).set_Size(new Size(63, 21));
		((Control)labelElvishArcherTrainingIron).set_TabIndex(15);
		((Control)labelElvishArcherTrainingIron).set_Text("Żelazo:");
		((Control)labelElvishWarriorTrainingIron).set_AutoSize(true);
		((Control)labelElvishWarriorTrainingIron).set_Font(new Font("Times New Roman", 14f));
		((Control)labelElvishWarriorTrainingIron).set_Location(new Point(263, 439));
		((Control)labelElvishWarriorTrainingIron).set_Name("labelElvishWarriorTrainingIron");
		((Control)labelElvishWarriorTrainingIron).set_Size(new Size(63, 21));
		((Control)labelElvishWarriorTrainingIron).set_TabIndex(16);
		((Control)labelElvishWarriorTrainingIron).set_Text("Żelazo:");
		((Control)labelElvishMasterTrainingIron).set_AutoSize(true);
		((Control)labelElvishMasterTrainingIron).set_Font(new Font("Times New Roman", 14f));
		((Control)labelElvishMasterTrainingIron).set_Location(new Point(495, 438));
		((Control)labelElvishMasterTrainingIron).set_Name("labelElvishMasterTrainingIron");
		((Control)labelElvishMasterTrainingIron).set_Size(new Size(63, 21));
		((Control)labelElvishMasterTrainingIron).set_TabIndex(17);
		((Control)labelElvishMasterTrainingIron).set_Text("Żelazo:");
		((Control)labelElvishArcherTrainingCrytals).set_AutoSize(true);
		((Control)labelElvishArcherTrainingCrytals).set_Font(new Font("Times New Roman", 14f));
		((Control)labelElvishArcherTrainingCrytals).set_Location(new Point(22, 457));
		((Control)labelElvishArcherTrainingCrytals).set_Name("labelElvishArcherTrainingCrytals");
		((Control)labelElvishArcherTrainingCrytals).set_Size(new Size(84, 21));
		((Control)labelElvishArcherTrainingCrytals).set_TabIndex(18);
		((Control)labelElvishArcherTrainingCrytals).set_Text("Kryształy:");
		((Control)labelElvishWarriorTrainingCrystals).set_AutoSize(true);
		((Control)labelElvishWarriorTrainingCrystals).set_Font(new Font("Times New Roman", 14f));
		((Control)labelElvishWarriorTrainingCrystals).set_Location(new Point(263, 460));
		((Control)labelElvishWarriorTrainingCrystals).set_Name("labelElvishWarriorTrainingCrystals");
		((Control)labelElvishWarriorTrainingCrystals).set_Size(new Size(84, 21));
		((Control)labelElvishWarriorTrainingCrystals).set_TabIndex(19);
		((Control)labelElvishWarriorTrainingCrystals).set_Text("Kryształy:");
		((Control)labelElvishMasterTrainingCrystals).set_AutoSize(true);
		((Control)labelElvishMasterTrainingCrystals).set_Font(new Font("Times New Roman", 14f));
		((Control)labelElvishMasterTrainingCrystals).set_Location(new Point(495, 459));
		((Control)labelElvishMasterTrainingCrystals).set_Name("labelElvishMasterTrainingCrystals");
		((Control)labelElvishMasterTrainingCrystals).set_Size(new Size(84, 21));
		((Control)labelElvishMasterTrainingCrystals).set_TabIndex(20);
		((Control)labelElvishMasterTrainingCrystals).set_Text("Kryształy:");
		((Control)labelElvishArcherTrainingCostWood).set_AutoSize(true);
		((Control)labelElvishArcherTrainingCostWood).set_Font(new Font("Times New Roman", 14f));
		((Control)labelElvishArcherTrainingCostWood).set_Location(new Point(120, 394));
		((Control)labelElvishArcherTrainingCostWood).set_Name("labelElvishArcherTrainingCostWood");
		((Control)labelElvishArcherTrainingCostWood).set_Size(new Size(19, 21));
		((Control)labelElvishArcherTrainingCostWood).set_TabIndex(21);
		((Control)labelElvishArcherTrainingCostWood).set_Text("0");
		((Control)labelElvishArcherTrainingCostStone).set_AutoSize(true);
		((Control)labelElvishArcherTrainingCostStone).set_Font(new Font("Times New Roman", 14f));
		((Control)labelElvishArcherTrainingCostStone).set_Location(new Point(120, 415));
		((Control)labelElvishArcherTrainingCostStone).set_Name("labelElvishArcherTrainingCostStone");
		((Control)labelElvishArcherTrainingCostStone).set_Size(new Size(19, 21));
		((Control)labelElvishArcherTrainingCostStone).set_TabIndex(22);
		((Control)labelElvishArcherTrainingCostStone).set_Text("0");
		((Control)labelElvishArcherTrainingCostIron).set_AutoSize(true);
		((Control)labelElvishArcherTrainingCostIron).set_Font(new Font("Times New Roman", 14f));
		((Control)labelElvishArcherTrainingCostIron).set_Location(new Point(120, 436));
		((Control)labelElvishArcherTrainingCostIron).set_Name("labelElvishArcherTrainingCostIron");
		((Control)labelElvishArcherTrainingCostIron).set_Size(new Size(19, 21));
		((Control)labelElvishArcherTrainingCostIron).set_TabIndex(23);
		((Control)labelElvishArcherTrainingCostIron).set_Text("0");
		((Control)labelElvishArcherTrainingCostCrystals).set_AutoSize(true);
		((Control)labelElvishArcherTrainingCostCrystals).set_Font(new Font("Times New Roman", 14f));
		((Control)labelElvishArcherTrainingCostCrystals).set_Location(new Point(120, 457));
		((Control)labelElvishArcherTrainingCostCrystals).set_Name("labelElvishArcherTrainingCostCrystals");
		((Control)labelElvishArcherTrainingCostCrystals).set_Size(new Size(19, 21));
		((Control)labelElvishArcherTrainingCostCrystals).set_TabIndex(24);
		((Control)labelElvishArcherTrainingCostCrystals).set_Text("0");
		((Control)pictureBoxElvishMaster).set_Location(new Point(486, 12));
		((Control)pictureBoxElvishMaster).set_Name("pictureBoxElvishMaster");
		((Control)pictureBoxElvishMaster).set_Size(new Size(187, 312));
		pictureBoxElvishMaster.set_SizeMode((PictureBoxSizeMode)1);
		pictureBoxElvishMaster.set_TabIndex(2);
		pictureBoxElvishMaster.set_TabStop(false);
		((Control)pictureBoxElvishWarrior).set_Location(new Point(257, 14));
		((Control)pictureBoxElvishWarrior).set_Name("pictureBoxElvishWarrior");
		((Control)pictureBoxElvishWarrior).set_Size(new Size(195, 312));
		pictureBoxElvishWarrior.set_SizeMode((PictureBoxSizeMode)1);
		pictureBoxElvishWarrior.set_TabIndex(1);
		pictureBoxElvishWarrior.set_TabStop(false);
		((Control)pictureBoxElvishArcher).set_Location(new Point(12, 12));
		((Control)pictureBoxElvishArcher).set_Name("pictureBoxElvishArcher");
		((Control)pictureBoxElvishArcher).set_Size(new Size(211, 312));
		pictureBoxElvishArcher.set_SizeMode((PictureBoxSizeMode)1);
		pictureBoxElvishArcher.set_TabIndex(0);
		pictureBoxElvishArcher.set_TabStop(false);
		((Control)labelElvishWarriorTrainingCostCrystals).set_AutoSize(true);
		((Control)labelElvishWarriorTrainingCostCrystals).set_Font(new Font("Times New Roman", 14f));
		((Control)labelElvishWarriorTrainingCostCrystals).set_Location(new Point(368, 460));
		((Control)labelElvishWarriorTrainingCostCrystals).set_Name("labelElvishWarriorTrainingCostCrystals");
		((Control)labelElvishWarriorTrainingCostCrystals).set_Size(new Size(19, 21));
		((Control)labelElvishWarriorTrainingCostCrystals).set_TabIndex(28);
		((Control)labelElvishWarriorTrainingCostCrystals).set_Text("0");
		((Control)labelElvishWarriorTrainingCostIron).set_AutoSize(true);
		((Control)labelElvishWarriorTrainingCostIron).set_Font(new Font("Times New Roman", 14f));
		((Control)labelElvishWarriorTrainingCostIron).set_Location(new Point(368, 439));
		((Control)labelElvishWarriorTrainingCostIron).set_Name("labelElvishWarriorTrainingCostIron");
		((Control)labelElvishWarriorTrainingCostIron).set_Size(new Size(19, 21));
		((Control)labelElvishWarriorTrainingCostIron).set_TabIndex(27);
		((Control)labelElvishWarriorTrainingCostIron).set_Text("0");
		((Control)labelElvishWarriorTrainingCostStone).set_AutoSize(true);
		((Control)labelElvishWarriorTrainingCostStone).set_Font(new Font("Times New Roman", 14f));
		((Control)labelElvishWarriorTrainingCostStone).set_Location(new Point(368, 418));
		((Control)labelElvishWarriorTrainingCostStone).set_Name("labelElvishWarriorTrainingCostStone");
		((Control)labelElvishWarriorTrainingCostStone).set_Size(new Size(19, 21));
		((Control)labelElvishWarriorTrainingCostStone).set_TabIndex(26);
		((Control)labelElvishWarriorTrainingCostStone).set_Text("0");
		((Control)labelElvishWarriorTrainingCostWood).set_AutoSize(true);
		((Control)labelElvishWarriorTrainingCostWood).set_Font(new Font("Times New Roman", 14f));
		((Control)labelElvishWarriorTrainingCostWood).set_Location(new Point(368, 397));
		((Control)labelElvishWarriorTrainingCostWood).set_Name("labelElvishWarriorTrainingCostWood");
		((Control)labelElvishWarriorTrainingCostWood).set_Size(new Size(19, 21));
		((Control)labelElvishWarriorTrainingCostWood).set_TabIndex(25);
		((Control)labelElvishWarriorTrainingCostWood).set_Text("0");
		((Control)labelElvishMasterTrainingCostCrystals).set_AutoSize(true);
		((Control)labelElvishMasterTrainingCostCrystals).set_Font(new Font("Times New Roman", 14f));
		((Control)labelElvishMasterTrainingCostCrystals).set_Location(new Point(595, 459));
		((Control)labelElvishMasterTrainingCostCrystals).set_Name("labelElvishMasterTrainingCostCrystals");
		((Control)labelElvishMasterTrainingCostCrystals).set_Size(new Size(19, 21));
		((Control)labelElvishMasterTrainingCostCrystals).set_TabIndex(32);
		((Control)labelElvishMasterTrainingCostCrystals).set_Text("0");
		((Control)labelElvishMasterTrainingCostIron).set_AutoSize(true);
		((Control)labelElvishMasterTrainingCostIron).set_Font(new Font("Times New Roman", 14f));
		((Control)labelElvishMasterTrainingCostIron).set_Location(new Point(595, 438));
		((Control)labelElvishMasterTrainingCostIron).set_Name("labelElvishMasterTrainingCostIron");
		((Control)labelElvishMasterTrainingCostIron).set_Size(new Size(19, 21));
		((Control)labelElvishMasterTrainingCostIron).set_TabIndex(31);
		((Control)labelElvishMasterTrainingCostIron).set_Text("0");
		((Control)labelElvishMasterTrainingCostStone).set_AutoSize(true);
		((Control)labelElvishMasterTrainingCostStone).set_Font(new Font("Times New Roman", 14f));
		((Control)labelElvishMasterTrainingCostStone).set_Location(new Point(595, 417));
		((Control)labelElvishMasterTrainingCostStone).set_Name("labelElvishMasterTrainingCostStone");
		((Control)labelElvishMasterTrainingCostStone).set_Size(new Size(19, 21));
		((Control)labelElvishMasterTrainingCostStone).set_TabIndex(30);
		((Control)labelElvishMasterTrainingCostStone).set_Text("0");
		((Control)labelElvishMasterTrainingCostWood).set_AutoSize(true);
		((Control)labelElvishMasterTrainingCostWood).set_Font(new Font("Times New Roman", 14f));
		((Control)labelElvishMasterTrainingCostWood).set_Location(new Point(595, 396));
		((Control)labelElvishMasterTrainingCostWood).set_Name("labelElvishMasterTrainingCostWood");
		((Control)labelElvishMasterTrainingCostWood).set_Size(new Size(19, 21));
		((Control)labelElvishMasterTrainingCostWood).set_TabIndex(29);
		((Control)labelElvishMasterTrainingCostWood).set_Text("0");
		((Control)labelElvishArcherTrainingPopulation).set_AutoSize(true);
		((Control)labelElvishArcherTrainingPopulation).set_Font(new Font("Times New Roman", 14f));
		((Control)labelElvishArcherTrainingPopulation).set_Location(new Point(22, 478));
		((Control)labelElvishArcherTrainingPopulation).set_Name("labelElvishArcherTrainingPopulation");
		((Control)labelElvishArcherTrainingPopulation).set_Size(new Size(87, 21));
		((Control)labelElvishArcherTrainingPopulation).set_TabIndex(33);
		((Control)labelElvishArcherTrainingPopulation).set_Text("Populacja:");
		((Control)labelElvishArcherTrainingCostPopulation).set_AutoSize(true);
		((Control)labelElvishArcherTrainingCostPopulation).set_Font(new Font("Times New Roman", 14f));
		((Control)labelElvishArcherTrainingCostPopulation).set_Location(new Point(120, 478));
		((Control)labelElvishArcherTrainingCostPopulation).set_Name("labelElvishArcherTrainingCostPopulation");
		((Control)labelElvishArcherTrainingCostPopulation).set_Size(new Size(19, 21));
		((Control)labelElvishArcherTrainingCostPopulation).set_TabIndex(34);
		((Control)labelElvishArcherTrainingCostPopulation).set_Text("0");
		((Control)labelElvishWarriorTrainingCostPopulation).set_AutoSize(true);
		((Control)labelElvishWarriorTrainingCostPopulation).set_Font(new Font("Times New Roman", 14f));
		((Control)labelElvishWarriorTrainingCostPopulation).set_Location(new Point(368, 481));
		((Control)labelElvishWarriorTrainingCostPopulation).set_Name("labelElvishWarriorTrainingCostPopulation");
		((Control)labelElvishWarriorTrainingCostPopulation).set_Size(new Size(19, 21));
		((Control)labelElvishWarriorTrainingCostPopulation).set_TabIndex(36);
		((Control)labelElvishWarriorTrainingCostPopulation).set_Text("0");
		((Control)labelElvishWarriorTrainingPopulation).set_AutoSize(true);
		((Control)labelElvishWarriorTrainingPopulation).set_Font(new Font("Times New Roman", 14f));
		((Control)labelElvishWarriorTrainingPopulation).set_Location(new Point(263, 481));
		((Control)labelElvishWarriorTrainingPopulation).set_Name("labelElvishWarriorTrainingPopulation");
		((Control)labelElvishWarriorTrainingPopulation).set_Size(new Size(87, 21));
		((Control)labelElvishWarriorTrainingPopulation).set_TabIndex(35);
		((Control)labelElvishWarriorTrainingPopulation).set_Text("Populacja:");
		((Control)labelElvishMasterTrainingCostPopulation).set_AutoSize(true);
		((Control)labelElvishMasterTrainingCostPopulation).set_Font(new Font("Times New Roman", 14f));
		((Control)labelElvishMasterTrainingCostPopulation).set_Location(new Point(595, 480));
		((Control)labelElvishMasterTrainingCostPopulation).set_Name("labelElvishMasterTrainingCostPopulation");
		((Control)labelElvishMasterTrainingCostPopulation).set_Size(new Size(19, 21));
		((Control)labelElvishMasterTrainingCostPopulation).set_TabIndex(38);
		((Control)labelElvishMasterTrainingCostPopulation).set_Text("0");
		((Control)labelElvishMasterTrainingPopulation).set_AutoSize(true);
		((Control)labelElvishMasterTrainingPopulation).set_Font(new Font("Times New Roman", 14f));
		((Control)labelElvishMasterTrainingPopulation).set_Location(new Point(495, 480));
		((Control)labelElvishMasterTrainingPopulation).set_Name("labelElvishMasterTrainingPopulation");
		((Control)labelElvishMasterTrainingPopulation).set_Size(new Size(87, 21));
		((Control)labelElvishMasterTrainingPopulation).set_TabIndex(37);
		((Control)labelElvishMasterTrainingPopulation).set_Text("Populacja:");
		((Control)labelElvishArcherTrainingFood).set_AutoSize(true);
		((Control)labelElvishArcherTrainingFood).set_Font(new Font("Times New Roman", 14f));
		((Control)labelElvishArcherTrainingFood).set_Location(new Point(22, 373));
		((Control)labelElvishArcherTrainingFood).set_Name("labelElvishArcherTrainingFood");
		((Control)labelElvishArcherTrainingFood).set_Size(new Size(83, 21));
		((Control)labelElvishArcherTrainingFood).set_TabIndex(39);
		((Control)labelElvishArcherTrainingFood).set_Text("Żywność:");
		((Control)labelElvishArcherTrainingCostFood).set_AutoSize(true);
		((Control)labelElvishArcherTrainingCostFood).set_Font(new Font("Times New Roman", 14f));
		((Control)labelElvishArcherTrainingCostFood).set_Location(new Point(120, 373));
		((Control)labelElvishArcherTrainingCostFood).set_Name("labelElvishArcherTrainingCostFood");
		((Control)labelElvishArcherTrainingCostFood).set_Size(new Size(19, 21));
		((Control)labelElvishArcherTrainingCostFood).set_TabIndex(40);
		((Control)labelElvishArcherTrainingCostFood).set_Text("0");
		((Control)label1).set_AutoSize(true);
		((Control)label1).set_Font(new Font("Times New Roman", 14f));
		((Control)label1).set_Location(new Point(263, 376));
		((Control)label1).set_Name("label1");
		((Control)label1).set_Size(new Size(83, 21));
		((Control)label1).set_TabIndex(41);
		((Control)label1).set_Text("Żywność:");
		((Control)labelElvishWarriorTrainingCostFood).set_AutoSize(true);
		((Control)labelElvishWarriorTrainingCostFood).set_Font(new Font("Times New Roman", 14f));
		((Control)labelElvishWarriorTrainingCostFood).set_Location(new Point(368, 376));
		((Control)labelElvishWarriorTrainingCostFood).set_Name("labelElvishWarriorTrainingCostFood");
		((Control)labelElvishWarriorTrainingCostFood).set_Size(new Size(19, 21));
		((Control)labelElvishWarriorTrainingCostFood).set_TabIndex(42);
		((Control)labelElvishWarriorTrainingCostFood).set_Text("0");
		((Control)label2).set_AutoSize(true);
		((Control)label2).set_Font(new Font("Times New Roman", 14f));
		((Control)label2).set_Location(new Point(495, 375));
		((Control)label2).set_Name("label2");
		((Control)label2).set_Size(new Size(83, 21));
		((Control)label2).set_TabIndex(43);
		((Control)label2).set_Text("Żywność:");
		((Control)labelElvishMasterTrainingCostFood).set_AutoSize(true);
		((Control)labelElvishMasterTrainingCostFood).set_Font(new Font("Times New Roman", 14f));
		((Control)labelElvishMasterTrainingCostFood).set_Location(new Point(595, 375));
		((Control)labelElvishMasterTrainingCostFood).set_Name("labelElvishMasterTrainingCostFood");
		((Control)labelElvishMasterTrainingCostFood).set_Size(new Size(19, 21));
		((Control)labelElvishMasterTrainingCostFood).set_TabIndex(44);
		((Control)labelElvishMasterTrainingCostFood).set_Text("0");
		((Control)labelWarning).set_AutoSize(true);
		((Control)labelWarning).set_Font(new Font("Microsoft Sans Serif", 14.5f));
		((Control)labelWarning).set_ForeColor(Color.Red);
		((Control)labelWarning).set_Location(new Point(12, 619));
		((Control)labelWarning).set_Name("labelWarning");
		((Control)labelWarning).set_Size(new Size(676, 25));
		((Control)labelWarning).set_TabIndex(45);
		((Control)labelWarning).set_Text("Pamiętaj, tylko połowa populacji elfickiego miasta może zostać przeszkolona!");
		((Control)buttonElvishArcherTrain).set_Location(new Point(26, 555));
		((Control)buttonElvishArcherTrain).set_Name("buttonElvishArcherTrain");
		((Control)buttonElvishArcherTrain).set_Size(new Size(115, 42));
		((Control)buttonElvishArcherTrain).set_TabIndex(46);
		((Control)buttonElvishArcherTrain).set_Text("Szkól");
		((ButtonBase)buttonElvishArcherTrain).set_UseVisualStyleBackColor(true);
		((Control)buttonElvishArcherTrain).add_Click((EventHandler)buttonElvishArcherTrain_Click);
		((Control)buttonElvishWarriorTrain).set_Location(new Point(267, 555));
		((Control)buttonElvishWarriorTrain).set_Name("buttonElvishWarriorTrain");
		((Control)buttonElvishWarriorTrain).set_Size(new Size(120, 42));
		((Control)buttonElvishWarriorTrain).set_TabIndex(47);
		((Control)buttonElvishWarriorTrain).set_Text("Szkól");
		((ButtonBase)buttonElvishWarriorTrain).set_UseVisualStyleBackColor(true);
		((Control)buttonElvishWarriorTrain).add_Click((EventHandler)buttonElvishWarriorTrain_Click);
		((Control)buttonElvishMasterTrain).set_Location(new Point(500, 555));
		((Control)buttonElvishMasterTrain).set_Name("buttonElvishMasterTrain");
		((Control)buttonElvishMasterTrain).set_Size(new Size(114, 42));
		((Control)buttonElvishMasterTrain).set_TabIndex(48);
		((Control)buttonElvishMasterTrain).set_Text("Szkól");
		((ButtonBase)buttonElvishMasterTrain).set_UseVisualStyleBackColor(true);
		((Control)buttonElvishMasterTrain).add_Click((EventHandler)buttonElvishMasterTrain_Click);
		((Control)labelElvishArcherQuantity).set_AutoSize(true);
		((Control)labelElvishArcherQuantity).set_Font(new Font("Times New Roman", 18f, (FontStyle)0, (GraphicsUnit)3, (byte)238));
		((Control)labelElvishArcherQuantity).set_ForeColor(Color.Green);
		((Control)labelElvishArcherQuantity).set_Location(new Point(126, 329));
		((Control)labelElvishArcherQuantity).set_Name("labelElvishArcherQuantity");
		((Control)labelElvishArcherQuantity).set_Size(new Size(36, 27));
		((Control)labelElvishArcherQuantity).set_TabIndex(49);
		((Control)labelElvishArcherQuantity).set_Text("10");
		((Control)labelElvishWarriorQuantity).set_AutoSize(true);
		((Control)labelElvishWarriorQuantity).set_Font(new Font("Times New Roman", 18f, (FontStyle)0, (GraphicsUnit)3, (byte)238));
		((Control)labelElvishWarriorQuantity).set_ForeColor(Color.Green);
		((Control)labelElvishWarriorQuantity).set_Location(new Point(393, 332));
		((Control)labelElvishWarriorQuantity).set_Name("labelElvishWarriorQuantity");
		((Control)labelElvishWarriorQuantity).set_Size(new Size(36, 27));
		((Control)labelElvishWarriorQuantity).set_TabIndex(50);
		((Control)labelElvishWarriorQuantity).set_Text("10");
		((Control)labelElvishMasterQuantity).set_AutoSize(true);
		((Control)labelElvishMasterQuantity).set_Font(new Font("Times New Roman", 18f, (FontStyle)0, (GraphicsUnit)3, (byte)238));
		((Control)labelElvishMasterQuantity).set_ForeColor(Color.Green);
		((Control)labelElvishMasterQuantity).set_Location(new Point(593, 331));
		((Control)labelElvishMasterQuantity).set_Name("labelElvishMasterQuantity");
		((Control)labelElvishMasterQuantity).set_Size(new Size(36, 27));
		((Control)labelElvishMasterQuantity).set_TabIndex(51);
		((Control)labelElvishMasterQuantity).set_Text("10");
		((Control)labelElvishArcherTrainingTime).set_AutoSize(true);
		((Control)labelElvishArcherTrainingTime).set_Font(new Font("Times New Roman", 14f));
		((Control)labelElvishArcherTrainingTime).set_Location(new Point(22, 499));
		((Control)labelElvishArcherTrainingTime).set_Name("labelElvishArcherTrainingTime");
		((Control)labelElvishArcherTrainingTime).set_Size(new Size(71, 21));
		((Control)labelElvishArcherTrainingTime).set_TabIndex(52);
		((Control)labelElvishArcherTrainingTime).set_Text("Czas[s]:");
		((Control)labelElvishArcherTrainingCostTime).set_AutoSize(true);
		((Control)labelElvishArcherTrainingCostTime).set_Font(new Font("Times New Roman", 14f));
		((Control)labelElvishArcherTrainingCostTime).set_Location(new Point(120, 499));
		((Control)labelElvishArcherTrainingCostTime).set_Name("labelElvishArcherTrainingCostTime");
		((Control)labelElvishArcherTrainingCostTime).set_Size(new Size(19, 21));
		((Control)labelElvishArcherTrainingCostTime).set_TabIndex(53);
		((Control)labelElvishArcherTrainingCostTime).set_Text("0");
		((Control)labelElvishWarriorTrainingCostTime).set_AutoSize(true);
		((Control)labelElvishWarriorTrainingCostTime).set_Font(new Font("Times New Roman", 14f));
		((Control)labelElvishWarriorTrainingCostTime).set_Location(new Point(368, 502));
		((Control)labelElvishWarriorTrainingCostTime).set_Name("labelElvishWarriorTrainingCostTime");
		((Control)labelElvishWarriorTrainingCostTime).set_Size(new Size(19, 21));
		((Control)labelElvishWarriorTrainingCostTime).set_TabIndex(55);
		((Control)labelElvishWarriorTrainingCostTime).set_Text("0");
		((Control)labelElvishWarriorTrainingTime).set_AutoSize(true);
		((Control)labelElvishWarriorTrainingTime).set_Font(new Font("Times New Roman", 14f));
		((Control)labelElvishWarriorTrainingTime).set_Location(new Point(263, 502));
		((Control)labelElvishWarriorTrainingTime).set_Name("labelElvishWarriorTrainingTime");
		((Control)labelElvishWarriorTrainingTime).set_Size(new Size(71, 21));
		((Control)labelElvishWarriorTrainingTime).set_TabIndex(54);
		((Control)labelElvishWarriorTrainingTime).set_Text("Czas[s]:");
		((Control)labelElvishMasterTrainingTime).set_AutoSize(true);
		((Control)labelElvishMasterTrainingTime).set_Font(new Font("Times New Roman", 14f));
		((Control)labelElvishMasterTrainingTime).set_Location(new Point(495, 501));
		((Control)labelElvishMasterTrainingTime).set_Name("labelElvishMasterTrainingTime");
		((Control)labelElvishMasterTrainingTime).set_Size(new Size(71, 21));
		((Control)labelElvishMasterTrainingTime).set_TabIndex(56);
		((Control)labelElvishMasterTrainingTime).set_Text("Czas[s]:");
		((Control)labelElvishMasterTrainingCostTime).set_AutoSize(true);
		((Control)labelElvishMasterTrainingCostTime).set_Font(new Font("Times New Roman", 14f));
		((Control)labelElvishMasterTrainingCostTime).set_Location(new Point(595, 501));
		((Control)labelElvishMasterTrainingCostTime).set_Name("labelElvishMasterTrainingCostTime");
		((Control)labelElvishMasterTrainingCostTime).set_Size(new Size(19, 21));
		((Control)labelElvishMasterTrainingCostTime).set_TabIndex(57);
		((Control)labelElvishMasterTrainingCostTime).set_Text("0");
		timerElvishArcherTraining.add_Tick((EventHandler)timerElvishArcherTraining_Tick);
		timerElvishWarriorTraining.add_Tick((EventHandler)timerElvishWarriorTraining_Tick);
		timerElvishMasterTraining.add_Tick((EventHandler)timerElvishMasterTraining_Tick);
		((Control)label3).set_AutoSize(true);
		((Control)label3).set_Font(new Font("Microsoft Sans Serif", 15f));
		((Control)label3).set_ForeColor(Color.Red);
		((Control)label3).set_Location(new Point(64, 663));
		((Control)label3).set_Name("label3");
		((Control)label3).set_Size(new Size(540, 25));
		((Control)label3).set_TabIndex(58);
		((Control)label3).set_Text("Nie wyłączaj tego okna zanim szkolenie nie dobiegnie końca!");
		timerUpdater.add_Tick((EventHandler)timerUpdater_Tick);
		((Control)progressBarElvishMasterTraining).set_Location(new Point(499, 525));
		((Control)progressBarElvishMasterTraining).set_Name("progressBarElvishMasterTraining");
		((Control)progressBarElvishMasterTraining).set_Size(new Size(115, 23));
		((Control)progressBarElvishMasterTraining).set_TabIndex(59);
		((Control)progressBarElvishWarriorTraining).set_Location(new Point(268, 525));
		((Control)progressBarElvishWarriorTraining).set_Name("progressBarElvishWarriorTraining");
		((Control)progressBarElvishWarriorTraining).set_Size(new Size(119, 23));
		((Control)progressBarElvishWarriorTraining).set_TabIndex(60);
		((Control)progressBarElvishArcherTraining).set_Location(new Point(26, 526));
		((Control)progressBarElvishArcherTraining).set_Name("progressBarElvishArcherTraining");
		((Control)progressBarElvishArcherTraining).set_Size(new Size(115, 23));
		((Control)progressBarElvishArcherTraining).set_TabIndex(61);
		timerElvishArcherProgressBar.add_Tick((EventHandler)timerElvishArcherProgressBar_Tick);
		timerElvishWarriorProgressBar.add_Tick((EventHandler)timerElvishWarriorProgressBar_Tick);
		timerElvishMasterProgressBar.add_Tick((EventHandler)timerElvishMasterProgressBar_Tick);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).set_BackColor(SystemColors.Control);
		((Form)this).set_ClientSize(new Size(694, 711));
		((Control)this).get_Controls().Add((Control)(object)progressBarElvishArcherTraining);
		((Control)this).get_Controls().Add((Control)(object)progressBarElvishWarriorTraining);
		((Control)this).get_Controls().Add((Control)(object)progressBarElvishMasterTraining);
		((Control)this).get_Controls().Add((Control)(object)label3);
		((Control)this).get_Controls().Add((Control)(object)labelElvishMasterTrainingCostTime);
		((Control)this).get_Controls().Add((Control)(object)labelElvishMasterTrainingTime);
		((Control)this).get_Controls().Add((Control)(object)labelElvishWarriorTrainingCostTime);
		((Control)this).get_Controls().Add((Control)(object)labelElvishWarriorTrainingTime);
		((Control)this).get_Controls().Add((Control)(object)labelElvishArcherTrainingCostTime);
		((Control)this).get_Controls().Add((Control)(object)labelElvishArcherTrainingTime);
		((Control)this).get_Controls().Add((Control)(object)labelElvishMasterQuantity);
		((Control)this).get_Controls().Add((Control)(object)labelElvishWarriorQuantity);
		((Control)this).get_Controls().Add((Control)(object)labelElvishArcherQuantity);
		((Control)this).get_Controls().Add((Control)(object)buttonElvishMasterTrain);
		((Control)this).get_Controls().Add((Control)(object)buttonElvishWarriorTrain);
		((Control)this).get_Controls().Add((Control)(object)buttonElvishArcherTrain);
		((Control)this).get_Controls().Add((Control)(object)labelWarning);
		((Control)this).get_Controls().Add((Control)(object)labelElvishMasterTrainingCostFood);
		((Control)this).get_Controls().Add((Control)(object)label2);
		((Control)this).get_Controls().Add((Control)(object)labelElvishWarriorTrainingCostFood);
		((Control)this).get_Controls().Add((Control)(object)label1);
		((Control)this).get_Controls().Add((Control)(object)labelElvishArcherTrainingCostFood);
		((Control)this).get_Controls().Add((Control)(object)labelElvishArcherTrainingFood);
		((Control)this).get_Controls().Add((Control)(object)labelElvishMasterTrainingCostPopulation);
		((Control)this).get_Controls().Add((Control)(object)labelElvishMasterTrainingPopulation);
		((Control)this).get_Controls().Add((Control)(object)labelElvishWarriorTrainingCostPopulation);
		((Control)this).get_Controls().Add((Control)(object)labelElvishWarriorTrainingPopulation);
		((Control)this).get_Controls().Add((Control)(object)labelElvishArcherTrainingCostPopulation);
		((Control)this).get_Controls().Add((Control)(object)labelElvishArcherTrainingPopulation);
		((Control)this).get_Controls().Add((Control)(object)labelElvishMasterTrainingCostCrystals);
		((Control)this).get_Controls().Add((Control)(object)labelElvishMasterTrainingCostIron);
		((Control)this).get_Controls().Add((Control)(object)labelElvishMasterTrainingCostStone);
		((Control)this).get_Controls().Add((Control)(object)labelElvishMasterTrainingCostWood);
		((Control)this).get_Controls().Add((Control)(object)labelElvishWarriorTrainingCostCrystals);
		((Control)this).get_Controls().Add((Control)(object)labelElvishWarriorTrainingCostIron);
		((Control)this).get_Controls().Add((Control)(object)labelElvishWarriorTrainingCostStone);
		((Control)this).get_Controls().Add((Control)(object)labelElvishWarriorTrainingCostWood);
		((Control)this).get_Controls().Add((Control)(object)labelElvishArcherTrainingCostCrystals);
		((Control)this).get_Controls().Add((Control)(object)labelElvishArcherTrainingCostIron);
		((Control)this).get_Controls().Add((Control)(object)labelElvishArcherTrainingCostStone);
		((Control)this).get_Controls().Add((Control)(object)labelElvishArcherTrainingCostWood);
		((Control)this).get_Controls().Add((Control)(object)labelElvishMasterTrainingCrystals);
		((Control)this).get_Controls().Add((Control)(object)labelElvishWarriorTrainingCrystals);
		((Control)this).get_Controls().Add((Control)(object)labelElvishArcherTrainingCrytals);
		((Control)this).get_Controls().Add((Control)(object)labelElvishMasterTrainingIron);
		((Control)this).get_Controls().Add((Control)(object)labelElvishWarriorTrainingIron);
		((Control)this).get_Controls().Add((Control)(object)labelElvishArcherTrainingIron);
		((Control)this).get_Controls().Add((Control)(object)labelElvishMasterTrainingStone);
		((Control)this).get_Controls().Add((Control)(object)labelElvishWarriorTrainingStone);
		((Control)this).get_Controls().Add((Control)(object)labelElvishArcherTrainingStone);
		((Control)this).get_Controls().Add((Control)(object)labelElvishMasterTrainingWood);
		((Control)this).get_Controls().Add((Control)(object)labelElvishWarriorTrainingWood);
		((Control)this).get_Controls().Add((Control)(object)labelElvishArcherTrainingWood);
		((Control)this).get_Controls().Add((Control)(object)labelElvishMasterTrainingCost);
		((Control)this).get_Controls().Add((Control)(object)labelElvishWarriorTrainingCost);
		((Control)this).get_Controls().Add((Control)(object)labelElvishArcherTrainingCost);
		((Control)this).get_Controls().Add((Control)(object)labelElvishMaster);
		((Control)this).get_Controls().Add((Control)(object)labelElvishWarrior);
		((Control)this).get_Controls().Add((Control)(object)labelElvishArcher);
		((Control)this).get_Controls().Add((Control)(object)pictureBoxElvishMaster);
		((Control)this).get_Controls().Add((Control)(object)pictureBoxElvishWarrior);
		((Control)this).get_Controls().Add((Control)(object)pictureBoxElvishArcher);
		((Control)this).set_MaximumSize(new Size(710, 750));
		((Control)this).set_MinimumSize(new Size(710, 750));
		((Control)this).set_Name("FormTraining");
		((Control)this).set_Text("Trening");
		((Form)this).add_Load((EventHandler)FormTraining_Load);
		((ISupportInitialize)pictureBoxElvishMaster).EndInit();
		((ISupportInitialize)pictureBoxElvishWarrior).EndInit();
		((ISupportInitialize)pictureBoxElvishArcher).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
