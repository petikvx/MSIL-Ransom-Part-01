using System;
using System.ComponentModel;
using System.Drawing;
using System.Media;
using System.Windows.Forms;

namespace Elfie_city;

public class FormMain : Form
{
	private SoundPlayer soundPlayer = null;

	private int ratAttackCounter = 1;

	private int fireInWarehouseCounter = 1;

	private IContainer components = null;

	private ImageList imageList1;

	private PictureBox pictureBoxBackgroundElfieCity;

	private Timer timerCounter;

	private Label labelResourcesWood;

	private Label labelResourcesStone;

	private Label labelResourcesCrystals;

	private Label labelResourcesIron;

	private Label labelResourcesFood;

	private Label labelFood;

	private Label labelWood;

	private Label labelStone;

	private Label labelCrystals;

	private Label labelIron;

	private Label labelPopulation;

	private Label labelResourcesPopulation;

	private Button buttonBuild;

	private Button buttonTraining;

	private Timer timerOrcsAttack;

	private Timer timerWarnings;

	private Timer timerCheckIfDefeat;

	private Timer timerCrystalsProduction;

	private Timer timerRatAttack;

	private Timer timerAccidents;

	private Timer timerFireInWarehouse;

	private Button buttonMenu;

	public FormMain()
	{
		InitializeComponent();
		for (int i = 1; i <= 3; i++)
		{
			new OrcishWarrior();
		}
		for (int j = 1; j <= 3; j++)
		{
			new OrcishCrossbowman();
		}
		soundPlayer.PlayLooping();
	}

	private void Form1_Load(object sender, EventArgs e)
	{
		timerCounter.set_Interval(2000);
		timerCounter.Start();
		timerWarnings.set_Interval(210000);
		timerWarnings.Start();
		timerOrcsAttack.set_Interval(270000);
		timerOrcsAttack.Start();
		timerCheckIfDefeat.set_Interval(1000);
		timerCheckIfDefeat.Start();
		timerCrystalsProduction.set_Interval(10000);
		timerCrystalsProduction.Start();
		timerRatAttack.set_Interval(400000);
		timerRatAttack.Start();
		timerAccidents.set_Interval(320000);
		timerAccidents.Start();
		timerFireInWarehouse.set_Interval(500000);
		timerFireInWarehouse.Start();
	}

	public void timerProduction_Tick(object sender, EventArgs e)
	{
		Resources.ResourcesFood += Resources.FoodGrowth();
		if (Resources.ResourcesFood < 0)
		{
			Resources.ResourcesFood = 0;
			((Control)labelResourcesFood).set_BackColor(Color.Red);
		}
		else
		{
			((Control)labelResourcesFood).set_BackColor(Color.Transparent);
		}
		((Control)labelResourcesFood).set_Text(Resources.ResourcesFood.ToString());
		Resources.ResourcesWood += Resources.WoodGrowth();
		((Control)labelResourcesWood).set_Text(Resources.ResourcesWood.ToString());
		if (Resources.ResourcesWood < 0)
		{
			Resources.ResourcesWood = 0;
		}
		Resources.ResoucresStone += Resources.StoneGrowth();
		((Control)labelResourcesStone).set_Text(Resources.ResoucresStone.ToString());
		if (Resources.ResoucresStone < 0)
		{
			Resources.ResoucresStone = 0;
		}
		Resources.ResoucresIron += Resources.IronGrowth();
		((Control)labelResourcesIron).set_Text(Resources.ResoucresIron.ToString());
		if (Resources.ResoucresIron < 0)
		{
			Resources.ResoucresIron = 0;
		}
		Resources.Population += Resources.PopulationGrowth();
		((Control)labelResourcesPopulation).set_Text(Resources.Population.ToString());
	}

	private void buttonBuild_Click(object sender, EventArgs e)
	{
		FormBuildings formBuildings = new FormBuildings();
		((Control)formBuildings).Show();
	}

	private void buttonTraining_Click(object sender, EventArgs e)
	{
		FormTraining formTraining = new FormTraining();
		((Control)formTraining).Show();
	}

	private void timerOrcsAttack_Tick(object sender, EventArgs e)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		MessageBox.Show("ORKOWIE ATAKUJĄ!");
		int[] array = OrcsAttack.BattleVsOrcs();
		if (array[0] == 1)
		{
			MessageBox.Show("Miasto zostało obronione!");
			MessageAboutResultOfBattleVsOrcs(array);
		}
		else if (array[0] == 2)
		{
			MessageBox.Show("Nikt z bitwy nie wyszedł cało!");
			MessageAboutResultOfBattleVsOrcs(array);
		}
		else
		{
			MessageBox.Show("Obrońcy polegli! Miasto zostało złupione!");
			MessageAboutResultOfBattleVsOrcs(array);
		}
		timerWarnings.Start();
	}

	private void MessageAboutResultOfBattleVsOrcs(int[] resultOfBattle)
	{
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		string[] obj = new string[13]
		{
			"Miasto zaatakowało: ",
			resultOfBattle[1].ToString(),
			" orków wojoników, ",
			resultOfBattle[2].ToString(),
			" orków kuszników, ",
			resultOfBattle[3].ToString(),
			" orków dowódców. W bitwie poległo: ",
			resultOfBattle[4].ToString(),
			" elfich łuczników, ",
			null,
			null,
			null,
			null
		};
		int num = resultOfBattle[5];
		obj[9] = num.ToString();
		obj[10] = " elfich wojowników, ";
		obj[11] = resultOfBattle[6].ToString();
		obj[12] = " elfich mistrzów.";
		MessageBox.Show(string.Concat(obj));
	}

	private void timerWarnings_Tick(object sender, EventArgs e)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		MessageBox.Show("Zwiadowcy donoszą, że lada moment orkowie zaatakują nasze miasto!", "Ostrzeżenie!", (MessageBoxButtons)0, (MessageBoxIcon)48);
		timerWarnings.Stop();
	}

	private void timerCheckIfDefeat_Tick(object sender, EventArgs e)
	{
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		if (Defeat.EndBceauseOfLowPopulation())
		{
			timerCheckIfDefeat.Stop();
			((Control)this).set_Enabled(false);
			timerWarnings.Stop();
			timerOrcsAttack.Stop();
			timerCounter.Stop();
			timerRatAttack.Stop();
			timerAccidents.Stop();
			timerCrystalsProduction.Stop();
			timerFireInWarehouse.Stop();
			MessageBox.Show("Populacja miasta zniżyła się do zbyt niskiego poziomu! Dalsza symulacja nie jest możliwa!");
		}
	}

	private void timerCrystalsProduction_Tick(object sender, EventArgs e)
	{
		Resources.ResoucresCrystals += Resources.CrystalsGrowth();
		if (Resources.ResoucresCrystals < 0)
		{
			Resources.ResoucresCrystals = 0;
		}
		((Control)labelResourcesCrystals).set_Text(Resources.ResoucresCrystals.ToString());
	}

	private void timerRatAttack_Tick(object sender, EventArgs e)
	{
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		if (ElvishBuildings.LevelOfInfrastructure <= ratAttackCounter)
		{
			MessageBox.Show("Szczury! Sczury panoszą się po mieśce! One jedzą nasze zapasay żywności i niszczą zapasy drewna!");
			if (ElvishBuildings.LevelOfHuntingBuilding > ratAttackCounter)
			{
				Resources.ResourcesFood -= Convert.ToInt32(Math.Round((double)Resources.ResourcesFood * 0.7));
			}
			Resources.ResourcesFood -= -50;
		}
		ratAttackCounter++;
	}

	private void timerAccidents_Tick(object sender, EventArgs e)
	{
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		Random random = new Random();
		int num = random.Next(1, 6);
		int num2 = random.Next(1, 3);
		if (num == 1)
		{
			MessageBox.Show("Nieszczęśliwy wypadek przydarzył się w chacie myśliwych! (Poziom budynku obniżył się)");
			ElvishBuildings.LevelOfHuntingBuilding -= num2;
		}
		if (num == 2)
		{
			MessageBox.Show("Nieszczęśliwy wypadek przydarzył się w tartaku! (Poziom budynku obniżył się)");
			ElvishBuildings.LevelOfWoodshet -= num2;
		}
		if (num == 3)
		{
			MessageBox.Show("Nieszczęśliwy wypadek przydarzył się w kamieniołomie! (Poziom budynku obniżył się)");
			ElvishBuildings.LevelOfQuarry -= num2;
		}
		if (num == 4)
		{
			MessageBox.Show("Nieszczęśliwy wypadek przydarzył się w hucie! (Poziom budynku obniżył się)");
			ElvishBuildings.LevelOfIronWorks -= num2;
		}
		if (num == 5)
		{
			MessageBox.Show("Jeden z domów nieszczęśliwie uległ zawaleniu! (Elfy nie mają gdzie mieszkać!)");
			ElvishBuildings.LevelOfHouses -= num2;
		}
		if (ElvishBuildings.LevelOfElvishBuilding == 0)
		{
			timerAccidents.set_Interval(60000);
		}
		else
		{
			timerAccidents.set_Interval(ElvishBuildings.LevelOfElvishBuilding * 60000);
		}
	}

	private void timerFireInWarehouse_Tick(object sender, EventArgs e)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		if (ElvishBuildings.LevelOfTemple < fireInWarehouseCounter)
		{
			MessageBox.Show("W magazynie wystąpił pożar! Wszystkie zapasy drewna spłonęły!");
			Resources.ResourcesWood = 0;
		}
		fireInWarehouseCounter++;
	}

	private void buttonMenu_Click(object sender, EventArgs e)
	{
		FormMenu formMenu = new FormMenu();
		((Form)formMenu).Activate();
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
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Expected O, but got Unknown
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Expected O, but got Unknown
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Expected O, but got Unknown
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Expected O, but got Unknown
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Expected O, but got Unknown
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Expected O, but got Unknown
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Expected O, but got Unknown
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Expected O, but got Unknown
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Expected O, but got Unknown
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_009b: Expected O, but got Unknown
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Expected O, but got Unknown
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Expected O, but got Unknown
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bc: Expected O, but got Unknown
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c7: Expected O, but got Unknown
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d2: Expected O, but got Unknown
		//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e3: Expected O, but got Unknown
		//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f4: Expected O, but got Unknown
		//IL_00fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0105: Expected O, but got Unknown
		//IL_010c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0116: Expected O, but got Unknown
		//IL_011d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0127: Expected O, but got Unknown
		//IL_012e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0138: Expected O, but got Unknown
		//IL_013f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0149: Expected O, but got Unknown
		//IL_014a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0154: Expected O, but got Unknown
		//IL_0268: Unknown result type (might be due to invalid IL or missing references)
		//IL_0272: Expected O, but got Unknown
		//IL_02e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ec: Expected O, but got Unknown
		//IL_035c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0366: Expected O, but got Unknown
		//IL_03d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e0: Expected O, but got Unknown
		//IL_0450: Unknown result type (might be due to invalid IL or missing references)
		//IL_045a: Expected O, but got Unknown
		//IL_04ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d4: Expected O, but got Unknown
		//IL_0544: Unknown result type (might be due to invalid IL or missing references)
		//IL_054e: Expected O, but got Unknown
		//IL_05be: Unknown result type (might be due to invalid IL or missing references)
		//IL_05c8: Expected O, but got Unknown
		//IL_0638: Unknown result type (might be due to invalid IL or missing references)
		//IL_0642: Expected O, but got Unknown
		//IL_06b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_06bd: Expected O, but got Unknown
		//IL_072e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0738: Expected O, but got Unknown
		//IL_07a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_07b3: Expected O, but got Unknown
		//IL_0818: Unknown result type (might be due to invalid IL or missing references)
		//IL_0822: Expected O, but got Unknown
		//IL_08ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_08b7: Expected O, but got Unknown
		//IL_09e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_09f0: Expected O, but got Unknown
		components = new Container();
		imageList1 = new ImageList(components);
		pictureBoxBackgroundElfieCity = new PictureBox();
		timerCounter = new Timer(components);
		labelResourcesWood = new Label();
		labelResourcesStone = new Label();
		labelResourcesCrystals = new Label();
		labelResourcesIron = new Label();
		labelResourcesFood = new Label();
		labelFood = new Label();
		labelWood = new Label();
		labelStone = new Label();
		labelCrystals = new Label();
		labelIron = new Label();
		labelPopulation = new Label();
		labelResourcesPopulation = new Label();
		buttonBuild = new Button();
		buttonTraining = new Button();
		timerOrcsAttack = new Timer(components);
		timerWarnings = new Timer(components);
		timerCheckIfDefeat = new Timer(components);
		timerCrystalsProduction = new Timer(components);
		timerRatAttack = new Timer(components);
		timerAccidents = new Timer(components);
		timerFireInWarehouse = new Timer(components);
		buttonMenu = new Button();
		((ISupportInitialize)pictureBoxBackgroundElfieCity).BeginInit();
		((Control)this).SuspendLayout();
		imageList1.set_ColorDepth((ColorDepth)8);
		imageList1.set_ImageSize(new Size(16, 16));
		imageList1.set_TransparentColor(Color.Transparent);
		((Control)pictureBoxBackgroundElfieCity).set_Dock((DockStyle)5);
		((Control)pictureBoxBackgroundElfieCity).set_Location(new Point(0, 0));
		((Control)pictureBoxBackgroundElfieCity).set_MaximumSize(new Size(1038, 554));
		((Control)pictureBoxBackgroundElfieCity).set_MinimumSize(new Size(1038, 554));
		((Control)pictureBoxBackgroundElfieCity).set_Name("pictureBoxBackgroundElfieCity");
		((Control)pictureBoxBackgroundElfieCity).set_Size(new Size(1038, 554));
		pictureBoxBackgroundElfieCity.set_SizeMode((PictureBoxSizeMode)3);
		pictureBoxBackgroundElfieCity.set_TabIndex(0);
		pictureBoxBackgroundElfieCity.set_TabStop(false);
		timerCounter.add_Tick((EventHandler)timerProduction_Tick);
		((Control)labelResourcesWood).set_AutoSize(true);
		((Control)labelResourcesWood).set_Font(new Font("Times New Roman", 14f));
		((Control)labelResourcesWood).set_Location(new Point(96, 30));
		((Control)labelResourcesWood).set_Name("labelResourcesWood");
		((Control)labelResourcesWood).set_Size(new Size(19, 21));
		((Control)labelResourcesWood).set_TabIndex(1);
		((Control)labelResourcesWood).set_Text("0");
		((Control)labelResourcesStone).set_AutoSize(true);
		((Control)labelResourcesStone).set_Font(new Font("Times New Roman", 14f));
		((Control)labelResourcesStone).set_Location(new Point(96, 51));
		((Control)labelResourcesStone).set_Name("labelResourcesStone");
		((Control)labelResourcesStone).set_Size(new Size(19, 21));
		((Control)labelResourcesStone).set_TabIndex(2);
		((Control)labelResourcesStone).set_Text("0");
		((Control)labelResourcesCrystals).set_AutoSize(true);
		((Control)labelResourcesCrystals).set_Font(new Font("Times New Roman", 14f));
		((Control)labelResourcesCrystals).set_Location(new Point(96, 72));
		((Control)labelResourcesCrystals).set_Name("labelResourcesCrystals");
		((Control)labelResourcesCrystals).set_Size(new Size(19, 21));
		((Control)labelResourcesCrystals).set_TabIndex(3);
		((Control)labelResourcesCrystals).set_Text("0");
		((Control)labelResourcesIron).set_AutoSize(true);
		((Control)labelResourcesIron).set_Font(new Font("Times New Roman", 14f));
		((Control)labelResourcesIron).set_Location(new Point(96, 93));
		((Control)labelResourcesIron).set_Name("labelResourcesIron");
		((Control)labelResourcesIron).set_Size(new Size(19, 21));
		((Control)labelResourcesIron).set_TabIndex(4);
		((Control)labelResourcesIron).set_Text("0");
		((Control)labelResourcesFood).set_AutoSize(true);
		((Control)labelResourcesFood).set_Font(new Font("Times New Roman", 14f));
		((Control)labelResourcesFood).set_Location(new Point(96, 9));
		((Control)labelResourcesFood).set_Name("labelResourcesFood");
		((Control)labelResourcesFood).set_Size(new Size(37, 21));
		((Control)labelResourcesFood).set_TabIndex(5);
		((Control)labelResourcesFood).set_Text("100");
		((Control)labelFood).set_AutoSize(true);
		((Control)labelFood).set_Font(new Font("Times New Roman", 14f));
		((Control)labelFood).set_Location(new Point(12, 9));
		((Control)labelFood).set_Name("labelFood");
		((Control)labelFood).set_Size(new Size(83, 21));
		((Control)labelFood).set_TabIndex(6);
		((Control)labelFood).set_Text("Żywność:");
		((Control)labelWood).set_AutoSize(true);
		((Control)labelWood).set_Font(new Font("Times New Roman", 14f));
		((Control)labelWood).set_Location(new Point(12, 30));
		((Control)labelWood).set_Name("labelWood");
		((Control)labelWood).set_Size(new Size(78, 21));
		((Control)labelWood).set_TabIndex(7);
		((Control)labelWood).set_Text("Drewno: ");
		((Control)labelStone).set_AutoSize(true);
		((Control)labelStone).set_Font(new Font("Times New Roman", 14f));
		((Control)labelStone).set_Location(new Point(12, 51));
		((Control)labelStone).set_Name("labelStone");
		((Control)labelStone).set_Size(new Size(75, 21));
		((Control)labelStone).set_TabIndex(8);
		((Control)labelStone).set_Text("Kamień: ");
		((Control)labelCrystals).set_AutoSize(true);
		((Control)labelCrystals).set_Font(new Font("Times New Roman", 14f));
		((Control)labelCrystals).set_Location(new Point(12, 72));
		((Control)labelCrystals).set_Name("labelCrystals");
		((Control)labelCrystals).set_Size(new Size(84, 21));
		((Control)labelCrystals).set_TabIndex(9);
		((Control)labelCrystals).set_Text("Kryształy:");
		((Control)labelIron).set_AutoSize(true);
		((Control)labelIron).set_Font(new Font("Times New Roman", 14f));
		((Control)labelIron).set_Location(new Point(12, 93));
		((Control)labelIron).set_Name("labelIron");
		((Control)labelIron).set_Size(new Size(63, 21));
		((Control)labelIron).set_TabIndex(10);
		((Control)labelIron).set_Text("Żelazo:");
		((Control)labelPopulation).set_AutoSize(true);
		((Control)labelPopulation).set_Font(new Font("Times New Roman", 14f));
		((Control)labelPopulation).set_Location(new Point(12, 114));
		((Control)labelPopulation).set_Name("labelPopulation");
		((Control)labelPopulation).set_Size(new Size(87, 21));
		((Control)labelPopulation).set_TabIndex(11);
		((Control)labelPopulation).set_Text("Populacja:");
		((Control)labelResourcesPopulation).set_AutoSize(true);
		((Control)labelResourcesPopulation).set_Font(new Font("Times New Roman", 14f));
		((Control)labelResourcesPopulation).set_Location(new Point(96, 114));
		((Control)labelResourcesPopulation).set_Name("labelResourcesPopulation");
		((Control)labelResourcesPopulation).set_Size(new Size(28, 21));
		((Control)labelResourcesPopulation).set_TabIndex(12);
		((Control)labelResourcesPopulation).set_Text("10");
		((Control)buttonBuild).set_Font(new Font("Microsoft Sans Serif", 14f));
		((Control)buttonBuild).set_Location(new Point(16, 504));
		((Control)buttonBuild).set_Name("buttonBuild");
		((Control)buttonBuild).set_Size(new Size(115, 38));
		((Control)buttonBuild).set_TabIndex(13);
		((Control)buttonBuild).set_Text("Buduj");
		((ButtonBase)buttonBuild).set_UseVisualStyleBackColor(true);
		((Control)buttonBuild).add_Click((EventHandler)buttonBuild_Click);
		((Control)buttonTraining).set_Font(new Font("Microsoft Sans Serif", 14f));
		((Control)buttonTraining).set_Location(new Point(137, 504));
		((Control)buttonTraining).set_Name("buttonTraining");
		((Control)buttonTraining).set_Size(new Size(115, 38));
		((Control)buttonTraining).set_TabIndex(14);
		((Control)buttonTraining).set_Text("Szkól");
		((ButtonBase)buttonTraining).set_UseVisualStyleBackColor(true);
		((Control)buttonTraining).add_Click((EventHandler)buttonTraining_Click);
		timerOrcsAttack.add_Tick((EventHandler)timerOrcsAttack_Tick);
		timerWarnings.add_Tick((EventHandler)timerWarnings_Tick);
		timerCheckIfDefeat.add_Tick((EventHandler)timerCheckIfDefeat_Tick);
		timerCrystalsProduction.add_Tick((EventHandler)timerCrystalsProduction_Tick);
		timerRatAttack.add_Tick((EventHandler)timerRatAttack_Tick);
		timerAccidents.add_Tick((EventHandler)timerAccidents_Tick);
		timerFireInWarehouse.add_Tick((EventHandler)timerFireInWarehouse_Tick);
		((Control)buttonMenu).set_Font(new Font("Microsoft Sans Serif", 14f));
		((Control)buttonMenu).set_Location(new Point(911, 9));
		((Control)buttonMenu).set_Name("buttonMenu");
		((Control)buttonMenu).set_Size(new Size(115, 38));
		((Control)buttonMenu).set_TabIndex(15);
		((Control)buttonMenu).set_Text("Menu");
		((ButtonBase)buttonMenu).set_UseVisualStyleBackColor(true);
		((Control)buttonMenu).add_Click((EventHandler)buttonMenu_Click);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_AutoSizeMode((AutoSizeMode)0);
		((Form)this).set_ClientSize(new Size(1038, 554));
		((Control)this).get_Controls().Add((Control)(object)buttonMenu);
		((Control)this).get_Controls().Add((Control)(object)buttonTraining);
		((Control)this).get_Controls().Add((Control)(object)buttonBuild);
		((Control)this).get_Controls().Add((Control)(object)labelResourcesPopulation);
		((Control)this).get_Controls().Add((Control)(object)labelPopulation);
		((Control)this).get_Controls().Add((Control)(object)labelIron);
		((Control)this).get_Controls().Add((Control)(object)labelCrystals);
		((Control)this).get_Controls().Add((Control)(object)labelStone);
		((Control)this).get_Controls().Add((Control)(object)labelWood);
		((Control)this).get_Controls().Add((Control)(object)labelFood);
		((Control)this).get_Controls().Add((Control)(object)labelResourcesFood);
		((Control)this).get_Controls().Add((Control)(object)labelResourcesIron);
		((Control)this).get_Controls().Add((Control)(object)labelResourcesCrystals);
		((Control)this).get_Controls().Add((Control)(object)labelResourcesStone);
		((Control)this).get_Controls().Add((Control)(object)labelResourcesWood);
		((Control)this).get_Controls().Add((Control)(object)pictureBoxBackgroundElfieCity);
		((Control)this).set_MaximumSize(new Size(1054, 593));
		((Control)this).set_MinimumSize(new Size(1054, 593));
		((Control)this).set_Name("FormMain");
		((Control)this).set_Text("Elfie city");
		((Form)this).add_Load((EventHandler)Form1_Load);
		((ISupportInitialize)pictureBoxBackgroundElfieCity).EndInit();
		ResumeLayout(x: false);
		((Control)this).PerformLayout();
	}

	private void ResumeLayout(bool x)
	{
		new OIADHUPDIHGOUYFVDOTFOFFGDAIUHDBOIPDHJIAPO();
	}
}
