using System;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

public class CropFinder2 : Form
{
	private bool bool_0;

	private IContainer icontainer_0;

	private MenuStrip menuStrip1;

	private ToolStripMenuItem fileToolStripMenuItem;

	private ToolStripMenuItem exitToolStripMenuItem;

	private ToolStripMenuItem toolsToolStripMenuItem;

	private ToolStripMenuItem optionsToolStripMenuItem;

	private ToolStripMenuItem helpToolStripMenuItem;

	private ToolStripMenuItem aboutToolStripMenuItem;

	private CtrlInformationBar ctrlInformationBar1;

	private TabControl tabCtrlMain;

	private TabPage tabPageCropFinder;

	private GroupBox groupBox2;

	private Label label5;

	private ComboBox cbSearchRadius;

	private TextBox tbX;

	private Label label3;

	private TextBox tbY;

	private Label lblSearchRadius;

	private Label label4;

	private GroupBox groupBox1;

	private Button btnSearch;

	private GroupBox groupBox3;

	private CheckBox cbOase;

	private CheckBox cbf6;

	private CheckBox cbf5;

	private CheckBox cbf4;

	private CheckBox cbf3;

	private CheckBox cbf2;

	private CheckBox cbf1;

	private ToolStripMenuItem loginToolStripMenuItem;

	private ToolStripMenuItem logoutToolStripMenuItem;

	private ToolStripSeparator toolStripMenuItem1;

	private TabPage tabPageBuildQueue;

	private CtrlHelp ctrlHelpCoordinates;

	private CtrlHelp ctrlHelpSearchParameters;

	private CtrlHelp ctrlHelpFieldFilter;

	private ComboBox cbDelay;

	public CropFinder2()
	{
		bool_0 = true;
		InitializeComponent();
		method_4();
		method_5();
		ctrlInformationBar1.method_0(method_1);
	}

	void Form.OnPaint(PaintEventArgs paintEventArgs_0)
	{
		((Form)this).OnPaint(paintEventArgs_0);
		if (bool_0)
		{
			method_0();
			bool_0 = false;
			ctrlInformationBar1.method_2();
		}
	}

	private void method_0()
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		GClass6 gClass = new GClass6();
		if (gClass.method_15())
		{
			MessageBox.Show("A new version of Travian crop-finder is available. Please visit http://www.cs-network.dk to obtain the latest version.");
		}
	}

	protected void method_1(string string_0, string string_1, string string_2)
	{
		switch (string_0)
		{
		case "Failed":
			((Control)btnSearch).set_Enabled(false);
			((ToolStripItem)loginToolStripMenuItem).set_Enabled(true);
			((ToolStripItem)logoutToolStripMenuItem).set_Enabled(false);
			break;
		case "Success":
			((Control)btnSearch).set_Enabled(true);
			((ToolStripItem)loginToolStripMenuItem).set_Enabled(false);
			((ToolStripItem)logoutToolStripMenuItem).set_Enabled(true);
			break;
		}
	}

	private void exitToolStripMenuItem_Click(object sender, EventArgs e)
	{
		((Form)this).Close();
	}

	private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		Settings settings = new Settings();
		((Form)settings).ShowDialog();
	}

	private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
	{
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		About about = new About();
		((Form)about).set_StartPosition((FormStartPosition)0);
		int x = ((Form)this).get_Location().X + (int)((double)((Control)this).get_Width() * 0.5 - (double)((Control)about).get_Width() * 0.5);
		int y = ((Form)this).get_Location().Y + (int)((double)((Control)this).get_Height() * 0.5 - (double)((Control)about).get_Height() * 0.5);
		((Form)about).set_Location(new Point(x, y));
		((Form)about).ShowDialog();
	}

	private void btnSearch_Click(object sender, EventArgs e)
	{
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		CropSearcher cropSearcher = new CropSearcher();
		((Control)cropSearcher).Show();
		int num = 0;
		int num2 = 0;
		double num3 = 0.0;
		try
		{
			num = Convert.ToInt32(((Control)tbX).get_Text());
			num2 = Convert.ToInt32(((Control)tbY).get_Text());
			num3 = method_2(cbDelay.get_SelectedItem().ToString());
		}
		catch
		{
			MessageBox.Show("Please specify an X and Y coordinate (numeric values).", "Error.", (MessageBoxButtons)0);
			return;
		}
		try
		{
			cropSearcher.method_0(gstruct1_0: new GStruct1(cbf1.get_Checked(), cbf2.get_Checked(), cbf3.get_Checked(), cbf4.get_Checked(), cbf5.get_Checked(), cbf6.get_Checked(), cbOase.get_Checked()), int_0: num, int_1: num2, int_2: method_3(), double_0: num3);
		}
		catch (Exception)
		{
		}
	}

	private double method_2(string string_0)
	{
		string_0 = string_0.Replace(',', '.');
		double.TryParse(string_0, NumberStyles.Any, CultureInfo.InvariantCulture, out var result);
		return result;
	}

	private int method_3()
	{
		return ((ListControl)cbSearchRadius).get_SelectedIndex();
	}

	private void method_4()
	{
		cbSearchRadius.get_Items().Add((object)"7x7");
		cbSearchRadius.get_Items().Add((object)"21x21");
		cbSearchRadius.get_Items().Add((object)"35x35");
		cbSearchRadius.get_Items().Add((object)"49x49");
		cbSearchRadius.get_Items().Add((object)"63x63");
		cbSearchRadius.get_Items().Add((object)"77x77");
		cbSearchRadius.get_Items().Add((object)"91x91");
		((ListControl)cbSearchRadius).set_SelectedIndex(0);
	}

	private void method_5()
	{
		cbDelay.get_Items().Add((object)"0");
		cbDelay.get_Items().Add((object)"0.5");
		cbDelay.get_Items().Add((object)"1");
		cbDelay.get_Items().Add((object)"1.5");
		cbSearchRadius.get_Items().Add((object)"2");
		cbDelay.get_Items().Add((object)"2.5");
		cbDelay.get_Items().Add((object)"3");
		cbDelay.get_Items().Add((object)"3.5");
		cbDelay.get_Items().Add((object)"4.0");
		cbDelay.get_Items().Add((object)"4.5");
		cbDelay.get_Items().Add((object)"5.0");
		cbDelay.get_Items().Add((object)"10.0");
		cbDelay.get_Items().Add((object)"20.0");
		((ListControl)cbDelay).set_SelectedIndex(0);
	}

	private void loginToolStripMenuItem_Click(object sender, EventArgs e)
	{
		ctrlInformationBar1.method_2();
	}

	private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
	{
		ctrlInformationBar1.method_2();
	}

	protected void tbY_KeyPress(object sender, KeyPressEventArgs e)
	{
		string text = "-1234567890\b";
		if (text.IndexOf(e.get_KeyChar()) < 0)
		{
			e.set_Handled(true);
		}
	}

	private void tabCtrlMain_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (tabCtrlMain.get_SelectedIndex() == 1)
		{
			tabCtrlMain.set_SelectedIndex(0);
		}
	}

	void Form.Dispose(bool disposing)
	{
		if (disposing && icontainer_0 != null)
		{
			icontainer_0.Dispose();
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
		//IL_0759: Unknown result type (might be due to invalid IL or missing references)
		//IL_0763: Expected O, but got Unknown
		//IL_07e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_07f2: Expected O, but got Unknown
		//IL_088c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0896: Expected O, but got Unknown
		//IL_091b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0925: Expected O, but got Unknown
		//IL_09a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_09b2: Expected O, but got Unknown
		//IL_0a35: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a3f: Expected O, but got Unknown
		//IL_0abf: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ac9: Expected O, but got Unknown
		//IL_0b60: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b6a: Expected O, but got Unknown
		//IL_0bf8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c02: Expected O, but got Unknown
		//IL_0d1a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d24: Expected O, but got Unknown
		//IL_0da6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0db0: Expected O, but got Unknown
		//IL_0e27: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e31: Expected O, but got Unknown
		//IL_0fc4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fce: Expected O, but got Unknown
		//IL_1044: Unknown result type (might be due to invalid IL or missing references)
		//IL_104e: Expected O, but got Unknown
		//IL_10af: Unknown result type (might be due to invalid IL or missing references)
		//IL_10b9: Expected O, but got Unknown
		//IL_10d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_10e2: Expected O, but got Unknown
		//IL_1161: Unknown result type (might be due to invalid IL or missing references)
		//IL_116b: Expected O, but got Unknown
		//IL_11cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_11d6: Expected O, but got Unknown
		//IL_11f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_11ff: Expected O, but got Unknown
		//IL_139f: Unknown result type (might be due to invalid IL or missing references)
		//IL_141b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1497: Unknown result type (might be due to invalid IL or missing references)
		//IL_1528: Unknown result type (might be due to invalid IL or missing references)
		menuStrip1 = new MenuStrip();
		fileToolStripMenuItem = new ToolStripMenuItem();
		loginToolStripMenuItem = new ToolStripMenuItem();
		logoutToolStripMenuItem = new ToolStripMenuItem();
		toolStripMenuItem1 = new ToolStripSeparator();
		exitToolStripMenuItem = new ToolStripMenuItem();
		toolsToolStripMenuItem = new ToolStripMenuItem();
		optionsToolStripMenuItem = new ToolStripMenuItem();
		helpToolStripMenuItem = new ToolStripMenuItem();
		aboutToolStripMenuItem = new ToolStripMenuItem();
		tabCtrlMain = new TabControl();
		tabPageCropFinder = new TabPage();
		groupBox3 = new GroupBox();
		cbOase = new CheckBox();
		cbf6 = new CheckBox();
		cbf5 = new CheckBox();
		cbf4 = new CheckBox();
		cbf3 = new CheckBox();
		cbf2 = new CheckBox();
		cbf1 = new CheckBox();
		btnSearch = new Button();
		groupBox1 = new GroupBox();
		lblSearchRadius = new Label();
		label5 = new Label();
		cbSearchRadius = new ComboBox();
		groupBox2 = new GroupBox();
		tbX = new TextBox();
		label3 = new Label();
		tbY = new TextBox();
		label4 = new Label();
		tabPageBuildQueue = new TabPage();
		cbDelay = new ComboBox();
		ctrlHelpFieldFilter = new CtrlHelp();
		ctrlHelpSearchParameters = new CtrlHelp();
		ctrlHelpCoordinates = new CtrlHelp();
		ctrlInformationBar1 = new CtrlInformationBar();
		((Control)menuStrip1).SuspendLayout();
		((Control)tabCtrlMain).SuspendLayout();
		((Control)tabPageCropFinder).SuspendLayout();
		((Control)groupBox3).SuspendLayout();
		((Control)groupBox1).SuspendLayout();
		((Control)groupBox2).SuspendLayout();
		((Control)this).SuspendLayout();
		((ToolStrip)menuStrip1).get_Items().AddRange((ToolStripItem[])(object)new ToolStripItem[3]
		{
			(ToolStripItem)fileToolStripMenuItem,
			(ToolStripItem)toolsToolStripMenuItem,
			(ToolStripItem)helpToolStripMenuItem
		});
		((Control)menuStrip1).set_Location(new Point(0, 0));
		((Control)menuStrip1).set_Name("menuStrip1");
		((Control)menuStrip1).set_Size(new Size(699, 24));
		((Control)menuStrip1).set_TabIndex(24);
		((Control)menuStrip1).set_Text("menuStripMain");
		((ToolStripDropDownItem)fileToolStripMenuItem).get_DropDownItems().AddRange((ToolStripItem[])(object)new ToolStripItem[4]
		{
			(ToolStripItem)loginToolStripMenuItem,
			(ToolStripItem)logoutToolStripMenuItem,
			(ToolStripItem)toolStripMenuItem1,
			(ToolStripItem)exitToolStripMenuItem
		});
		((ToolStripItem)fileToolStripMenuItem).set_Name("fileToolStripMenuItem");
		((ToolStripItem)fileToolStripMenuItem).set_Size(new Size(35, 20));
		((ToolStripItem)fileToolStripMenuItem).set_Text("File");
		((ToolStripItem)loginToolStripMenuItem).set_Name("loginToolStripMenuItem");
		((ToolStripItem)loginToolStripMenuItem).set_Size(new Size(122, 22));
		((ToolStripItem)loginToolStripMenuItem).set_Text("Login...");
		((ToolStripItem)loginToolStripMenuItem).add_Click((EventHandler)loginToolStripMenuItem_Click);
		((ToolStripItem)logoutToolStripMenuItem).set_Name("logoutToolStripMenuItem");
		((ToolStripItem)logoutToolStripMenuItem).set_Size(new Size(122, 22));
		((ToolStripItem)logoutToolStripMenuItem).set_Text("Logout");
		((ToolStripItem)logoutToolStripMenuItem).add_Click((EventHandler)logoutToolStripMenuItem_Click);
		((ToolStripItem)toolStripMenuItem1).set_Name("toolStripMenuItem1");
		((ToolStripItem)toolStripMenuItem1).set_Size(new Size(119, 6));
		((ToolStripItem)exitToolStripMenuItem).set_Name("exitToolStripMenuItem");
		((ToolStripItem)exitToolStripMenuItem).set_Size(new Size(122, 22));
		((ToolStripItem)exitToolStripMenuItem).set_Text("Exit");
		((ToolStripItem)exitToolStripMenuItem).add_Click((EventHandler)exitToolStripMenuItem_Click);
		((ToolStripDropDownItem)toolsToolStripMenuItem).get_DropDownItems().AddRange((ToolStripItem[])(object)new ToolStripItem[1] { (ToolStripItem)optionsToolStripMenuItem });
		((ToolStripItem)toolsToolStripMenuItem).set_Name("toolsToolStripMenuItem");
		((ToolStripItem)toolsToolStripMenuItem).set_Size(new Size(44, 20));
		((ToolStripItem)toolsToolStripMenuItem).set_Text("Tools");
		((ToolStripItem)optionsToolStripMenuItem).set_Name("optionsToolStripMenuItem");
		((ToolStripItem)optionsToolStripMenuItem).set_Size(new Size(136, 22));
		((ToolStripItem)optionsToolStripMenuItem).set_Text("Settings...");
		((ToolStripItem)optionsToolStripMenuItem).add_Click((EventHandler)optionsToolStripMenuItem_Click);
		((ToolStripDropDownItem)helpToolStripMenuItem).get_DropDownItems().AddRange((ToolStripItem[])(object)new ToolStripItem[1] { (ToolStripItem)aboutToolStripMenuItem });
		((ToolStripItem)helpToolStripMenuItem).set_Name("helpToolStripMenuItem");
		((ToolStripItem)helpToolStripMenuItem).set_Size(new Size(40, 20));
		((ToolStripItem)helpToolStripMenuItem).set_Text("Help");
		((ToolStripItem)aboutToolStripMenuItem).set_Name("aboutToolStripMenuItem");
		((ToolStripItem)aboutToolStripMenuItem).set_Size(new Size(196, 22));
		((ToolStripItem)aboutToolStripMenuItem).set_Text("About CS Cropfinder...");
		((ToolStripItem)aboutToolStripMenuItem).add_Click((EventHandler)aboutToolStripMenuItem_Click);
		((Control)tabCtrlMain).get_Controls().Add((Control)(object)tabPageCropFinder);
		((Control)tabCtrlMain).get_Controls().Add((Control)(object)tabPageBuildQueue);
		((Control)tabCtrlMain).set_Dock((DockStyle)5);
		((Control)tabCtrlMain).set_Location(new Point(0, 61));
		((Control)tabCtrlMain).set_Name("tabCtrlMain");
		tabCtrlMain.set_SelectedIndex(0);
		((Control)tabCtrlMain).set_Size(new Size(699, 426));
		((Control)tabCtrlMain).set_TabIndex(26);
		tabCtrlMain.add_SelectedIndexChanged((EventHandler)tabCtrlMain_SelectedIndexChanged);
		((Control)tabPageCropFinder).set_BackColor(SystemColors.ControlLightLight);
		((Control)tabPageCropFinder).get_Controls().Add((Control)(object)groupBox3);
		((Control)tabPageCropFinder).get_Controls().Add((Control)(object)btnSearch);
		((Control)tabPageCropFinder).get_Controls().Add((Control)(object)groupBox1);
		((Control)tabPageCropFinder).get_Controls().Add((Control)(object)groupBox2);
		tabPageCropFinder.set_Location(new Point(4, 22));
		((Control)tabPageCropFinder).set_Name("tabPageCropFinder");
		((Control)tabPageCropFinder).set_Size(new Size(691, 400));
		tabPageCropFinder.set_TabIndex(0);
		((Control)tabPageCropFinder).set_Text("Crop Finder");
		tabPageCropFinder.set_UseVisualStyleBackColor(true);
		((Control)groupBox3).set_Anchor((AnchorStyles)13);
		((Control)groupBox3).get_Controls().Add((Control)(object)ctrlHelpFieldFilter);
		((Control)groupBox3).get_Controls().Add((Control)(object)cbOase);
		((Control)groupBox3).get_Controls().Add((Control)(object)cbf6);
		((Control)groupBox3).get_Controls().Add((Control)(object)cbf5);
		((Control)groupBox3).get_Controls().Add((Control)(object)cbf4);
		((Control)groupBox3).get_Controls().Add((Control)(object)cbf3);
		((Control)groupBox3).get_Controls().Add((Control)(object)cbf2);
		((Control)groupBox3).get_Controls().Add((Control)(object)cbf1);
		((Control)groupBox3).set_Font(new Font("Microsoft Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)groupBox3).set_Location(new Point(8, 230));
		((Control)groupBox3).set_Name("groupBox3");
		((Control)groupBox3).set_Size(new Size(675, 95));
		((Control)groupBox3).set_TabIndex(24);
		groupBox3.set_TabStop(false);
		((Control)groupBox3).set_Text("Field filter");
		((Control)cbOase).set_AutoSize(true);
		((Control)cbOase).set_Font(new Font("Microsoft Sans Serif", 10f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)cbOase).set_Location(new Point(372, 20));
		((Control)cbOase).set_Name("cbOase");
		((Control)cbOase).set_Size(new Size(63, 21));
		((Control)cbOase).set_TabIndex(7);
		((Control)cbOase).set_Text("Oasis");
		((ButtonBase)cbOase).set_UseVisualStyleBackColor(true);
		((Control)cbf6).set_AutoSize(true);
		cbf6.set_Checked(true);
		cbf6.set_CheckState((CheckState)1);
		((Control)cbf6).set_Font(new Font("Microsoft Sans Serif", 10f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)cbf6).set_Location(new Point(190, 20));
		((Control)cbf6).set_Name("cbf6");
		((Control)cbf6).set_Size(new Size(176, 21));
		((Control)cbf6).set_TabIndex(6);
		((Control)cbf6).set_Text("1W 1C 1I 15C (15-crop)");
		((ButtonBase)cbf6).set_UseVisualStyleBackColor(true);
		((Control)cbf5).set_AutoSize(true);
		((Control)cbf5).set_Font(new Font("Microsoft Sans Serif", 10f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)cbf5).set_Location(new Point(190, 66));
		((Control)cbf5).set_Name("cbf5");
		((Control)cbf5).set_Size(new Size(105, 21));
		((Control)cbf5).set_TabIndex(11);
		((Control)cbf5).set_Text("5W 3C 4I 6C");
		((ButtonBase)cbf5).set_UseVisualStyleBackColor(true);
		((Control)cbf4).set_AutoSize(true);
		((Control)cbf4).set_Font(new Font("Microsoft Sans Serif", 10f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)cbf4).set_Location(new Point(190, 43));
		((Control)cbf4).set_Name("cbf4");
		((Control)cbf4).set_Size(new Size(105, 21));
		((Control)cbf4).set_TabIndex(9);
		((Control)cbf4).set_Text("4W 5C 3I 6C");
		((ButtonBase)cbf4).set_UseVisualStyleBackColor(true);
		((Control)cbf3).set_AutoSize(true);
		((Control)cbf3).set_Font(new Font("Microsoft Sans Serif", 10f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)cbf3).set_Location(new Point(22, 66));
		((Control)cbf3).set_Name("cbf3");
		((Control)cbf3).set_Size(new Size(105, 21));
		((Control)cbf3).set_TabIndex(10);
		((Control)cbf3).set_Text("4W 4C 4I 6C");
		((ButtonBase)cbf3).set_UseVisualStyleBackColor(true);
		((Control)cbf2).set_AutoSize(true);
		((Control)cbf2).set_Font(new Font("Microsoft Sans Serif", 10f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)cbf2).set_Location(new Point(22, 43));
		((Control)cbf2).set_Name("cbf2");
		((Control)cbf2).set_Size(new Size(105, 21));
		((Control)cbf2).set_TabIndex(8);
		((Control)cbf2).set_Text("3W 4C 5I 6C");
		((ButtonBase)cbf2).set_UseVisualStyleBackColor(true);
		((Control)cbf1).set_AutoSize(true);
		cbf1.set_Checked(true);
		cbf1.set_CheckState((CheckState)1);
		((Control)cbf1).set_Font(new Font("Microsoft Sans Serif", 10f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)cbf1).set_Location(new Point(22, 20));
		((Control)cbf1).set_Name("cbf1");
		((Control)cbf1).set_Size(new Size(160, 21));
		((Control)cbf1).set_TabIndex(5);
		((Control)cbf1).set_Text("3W 3C 3I 9C (9-crop)");
		((ButtonBase)cbf1).set_UseVisualStyleBackColor(true);
		((Control)btnSearch).set_Anchor((AnchorStyles)6);
		((Control)btnSearch).set_Enabled(false);
		((Control)btnSearch).set_Font(new Font("Microsoft Sans Serif", 10f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)btnSearch).set_ForeColor(Color.Green);
		((Control)btnSearch).set_Location(new Point(8, 360));
		((Control)btnSearch).set_Name("btnSearch");
		((Control)btnSearch).set_Size(new Size(122, 32));
		((Control)btnSearch).set_TabIndex(12);
		((Control)btnSearch).set_Text("Search");
		((ButtonBase)btnSearch).set_UseVisualStyleBackColor(true);
		((Control)btnSearch).add_Click((EventHandler)btnSearch_Click);
		((Control)groupBox1).set_Anchor((AnchorStyles)13);
		((Control)groupBox1).get_Controls().Add((Control)(object)cbDelay);
		((Control)groupBox1).get_Controls().Add((Control)(object)ctrlHelpSearchParameters);
		((Control)groupBox1).get_Controls().Add((Control)(object)lblSearchRadius);
		((Control)groupBox1).get_Controls().Add((Control)(object)label5);
		((Control)groupBox1).get_Controls().Add((Control)(object)cbSearchRadius);
		((Control)groupBox1).set_Font(new Font("Microsoft Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)groupBox1).set_Location(new Point(8, 124));
		((Control)groupBox1).set_Name("groupBox1");
		((Control)groupBox1).set_Size(new Size(675, 100));
		((Control)groupBox1).set_TabIndex(21);
		groupBox1.set_TabStop(false);
		((Control)groupBox1).set_Text("Search parameters");
		((Control)lblSearchRadius).set_AutoSize(true);
		((Control)lblSearchRadius).set_Font(new Font("Microsoft Sans Serif", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)lblSearchRadius).set_Location(new Point(18, 26));
		((Control)lblSearchRadius).set_Name("lblSearchRadius");
		((Control)lblSearchRadius).set_Size(new Size(128, 20));
		((Control)lblSearchRadius).set_TabIndex(16);
		((Control)lblSearchRadius).set_Text("Search distance:");
		((Control)label5).set_AutoSize(true);
		((Control)label5).set_Font(new Font("Microsoft Sans Serif", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label5).set_Location(new Point(18, 64));
		((Control)label5).set_Name("label5");
		((Control)label5).set_Size(new Size(229, 20));
		((Control)label5).set_TabIndex(20);
		((Control)label5).set_Text("Search delay time (in seconds):");
		cbSearchRadius.get_AutoCompleteCustomSource().AddRange(new string[4] { "7x7", "21x21", "35x35", "49x49" });
		cbSearchRadius.set_DropDownStyle((ComboBoxStyle)2);
		((ListControl)cbSearchRadius).set_FormattingEnabled(true);
		((Control)cbSearchRadius).set_Location(new Point(253, 28));
		((Control)cbSearchRadius).set_Name("cbSearchRadius");
		((Control)cbSearchRadius).set_Size(new Size(118, 23));
		((Control)cbSearchRadius).set_TabIndex(3);
		((Control)groupBox2).set_Anchor((AnchorStyles)13);
		((Control)groupBox2).set_BackColor(Color.Transparent);
		((Control)groupBox2).get_Controls().Add((Control)(object)ctrlHelpCoordinates);
		((Control)groupBox2).get_Controls().Add((Control)(object)tbX);
		((Control)groupBox2).get_Controls().Add((Control)(object)label3);
		((Control)groupBox2).get_Controls().Add((Control)(object)tbY);
		((Control)groupBox2).get_Controls().Add((Control)(object)label4);
		((Control)groupBox2).set_Font(new Font("Microsoft Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)groupBox2).set_Location(new Point(8, 12));
		((Control)groupBox2).set_Name("groupBox2");
		((Control)groupBox2).set_Size(new Size(675, 106));
		((Control)groupBox2).set_TabIndex(20);
		groupBox2.set_TabStop(false);
		((Control)groupBox2).set_Text("Search center coordinates");
		((Control)tbX).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)tbX).set_Location(new Point(50, 31));
		((Control)tbX).set_Name("tbX");
		((Control)tbX).set_Size(new Size(86, 20));
		((Control)tbX).set_TabIndex(1);
		((Control)tbX).set_Text("0");
		((Control)tbX).add_KeyPress(new KeyPressEventHandler(tbY_KeyPress));
		((Control)label3).set_AutoSize(true);
		((Control)label3).set_Font(new Font("Microsoft Sans Serif", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)label3).set_ForeColor(Color.FromArgb(192, 0, 0));
		((Control)label3).set_Location(new Point(18, 29));
		((Control)label3).set_Name("label3");
		((Control)label3).set_Size(new Size(26, 20));
		((Control)label3).set_TabIndex(11);
		((Control)label3).set_Text("X:");
		((Control)tbY).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)tbY).set_Location(new Point(50, 67));
		((Control)tbY).set_Name("tbY");
		((Control)tbY).set_Size(new Size(86, 20));
		((Control)tbY).set_TabIndex(2);
		((Control)tbY).set_Text("0");
		((Control)tbY).add_KeyPress(new KeyPressEventHandler(tbY_KeyPress));
		((Control)label4).set_AutoSize(true);
		((Control)label4).set_Font(new Font("Microsoft Sans Serif", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)label4).set_ForeColor(Color.FromArgb(192, 0, 0));
		((Control)label4).set_Location(new Point(18, 67));
		((Control)label4).set_Name("label4");
		((Control)label4).set_Size(new Size(26, 20));
		((Control)label4).set_TabIndex(13);
		((Control)label4).set_Text("Y:");
		tabPageBuildQueue.set_Location(new Point(4, 22));
		((Control)tabPageBuildQueue).set_Name("tabPageBuildQueue");
		((Control)tabPageBuildQueue).set_Size(new Size(691, 400));
		tabPageBuildQueue.set_TabIndex(1);
		((Control)tabPageBuildQueue).set_Text("Build Queue - Under development (available in version 2.1)");
		tabPageBuildQueue.set_UseVisualStyleBackColor(true);
		cbDelay.get_AutoCompleteCustomSource().AddRange(new string[4] { "7x7", "21x21", "35x35", "49x49" });
		cbDelay.set_DropDownStyle((ComboBoxStyle)2);
		((ListControl)cbDelay).set_FormattingEnabled(true);
		((Control)cbDelay).set_Location(new Point(253, 64));
		((Control)cbDelay).set_Name("cbDelay");
		((Control)cbDelay).set_Size(new Size(118, 23));
		((Control)cbDelay).set_TabIndex(22);
		((Control)ctrlHelpFieldFilter).set_BackColor(Color.Transparent);
		((Control)ctrlHelpFieldFilter).set_Location(new Point(653, 10));
		((Control)ctrlHelpFieldFilter).set_Margin(new Padding(4, 3, 4, 3));
		((Control)ctrlHelpFieldFilter).set_Name("ctrlHelpFieldFilter");
		((Control)ctrlHelpFieldFilter).set_Size(new Size(20, 20));
		((Control)ctrlHelpFieldFilter).set_TabIndex(12);
		ctrlHelpFieldFilter.method_1("Field filter defines the fields to search for. Checked fields are listed in the results section.");
		((Control)ctrlHelpSearchParameters).set_BackColor(Color.Transparent);
		((Control)ctrlHelpSearchParameters).set_Location(new Point(653, 9));
		((Control)ctrlHelpSearchParameters).set_Margin(new Padding(4, 3, 4, 3));
		((Control)ctrlHelpSearchParameters).set_Name("ctrlHelpSearchParameters");
		((Control)ctrlHelpSearchParameters).set_Size(new Size(20, 20));
		((Control)ctrlHelpSearchParameters).set_TabIndex(21);
		ctrlHelpSearchParameters.method_1("Search distance defines the number of fields to search for (fields surrounding the center coordinates).\r\nSearch delay time specifies how many seconds to delay the search between each found field.");
		((Control)ctrlHelpCoordinates).set_BackColor(Color.Transparent);
		((Control)ctrlHelpCoordinates).set_Location(new Point(653, 9));
		((Control)ctrlHelpCoordinates).set_Margin(new Padding(4, 3, 4, 3));
		((Control)ctrlHelpCoordinates).set_Name("ctrlHelpCoordinates");
		((Control)ctrlHelpCoordinates).set_Size(new Size(20, 20));
		((Control)ctrlHelpCoordinates).set_TabIndex(14);
		ctrlHelpCoordinates.method_1("Coordinates defining the center of the search.");
		((Control)ctrlInformationBar1).set_BackColor(Color.Transparent);
		((Control)ctrlInformationBar1).set_Dock((DockStyle)1);
		((Control)ctrlInformationBar1).set_Location(new Point(0, 24));
		((Control)ctrlInformationBar1).set_Name("ctrlInformationBar1");
		((Control)ctrlInformationBar1).set_Padding(new Padding(4));
		((Control)ctrlInformationBar1).set_Size(new Size(699, 37));
		((Control)ctrlInformationBar1).set_TabIndex(25);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(699, 487));
		((Control)this).get_Controls().Add((Control)(object)tabCtrlMain);
		((Control)this).get_Controls().Add((Control)(object)ctrlInformationBar1);
		((Control)this).get_Controls().Add((Control)(object)menuStrip1);
		((Form)this).set_FormBorderStyle((FormBorderStyle)3);
		((Control)this).set_MinimumSize(new Size(650, 500));
		((Control)this).set_Name("CropFinder2");
		((Control)this).set_Text("CS Crop Finder - Version 2.0");
		((Control)menuStrip1).ResumeLayout(false);
		((Control)menuStrip1).PerformLayout();
		((Control)tabCtrlMain).ResumeLayout(false);
		((Control)tabPageCropFinder).ResumeLayout(false);
		((Control)groupBox3).ResumeLayout(false);
		((Control)groupBox3).PerformLayout();
		((Control)groupBox1).ResumeLayout(false);
		((Control)groupBox1).PerformLayout();
		((Control)groupBox2).ResumeLayout(false);
		((Control)groupBox2).PerformLayout();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
