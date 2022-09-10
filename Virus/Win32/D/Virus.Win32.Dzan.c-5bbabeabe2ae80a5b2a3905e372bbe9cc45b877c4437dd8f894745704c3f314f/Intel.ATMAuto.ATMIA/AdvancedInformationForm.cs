using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Xml;

namespace Intel.ATMAuto.ATMIA;

public class AdvancedInformationForm : Form
{
	private GroupBox groupBox4;

	private ListBox lstOperationInformation;

	private Button cmdExitWindow;

	private Label lblOperationName;

	private TextBox txtOperationName;

	private Button cmdDeleteOperation;

	private Button cmdAddOperation;

	private Label label1;

	private Container components = null;

	private ArrayList operationsList = new ArrayList();

	private OpenFileDialog openFileDialog1;

	private Label label2;

	private Label label47;

	private bool isItemSelected = false;

	public ArrayList OperationsList
	{
		get
		{
			return operationsList;
		}
		set
		{
			operationsList = value;
		}
	}

	public AdvancedInformationForm(XmlNode operationsNode)
	{
		InitializeComponent();
		LoadOpearationsList(operationsNode);
	}

	private void LoadOpearationsList(XmlNode opNode)
	{
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			foreach (XmlNode childNode in opNode.ChildNodes)
			{
				if (childNode.NodeType != XmlNodeType.Comment)
				{
					operationsList.Add(childNode.InnerText);
					lstOperationInformation.get_Items().Add((object)childNode.InnerText);
				}
			}
			((Control)lstOperationInformation).Refresh();
		}
		catch (Exception ex)
		{
			MessageBox.Show(ex.Message);
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
		//IL_0163: Unknown result type (might be due to invalid IL or missing references)
		//IL_016d: Expected O, but got Unknown
		//IL_01e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ee: Expected O, but got Unknown
		//IL_027b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0285: Expected O, but got Unknown
		//IL_0327: Unknown result type (might be due to invalid IL or missing references)
		//IL_0331: Expected O, but got Unknown
		//IL_03a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ab: Expected O, but got Unknown
		//IL_0425: Unknown result type (might be due to invalid IL or missing references)
		//IL_042f: Expected O, but got Unknown
		//IL_04a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b2: Expected O, but got Unknown
		//IL_052b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0535: Expected O, but got Unknown
		//IL_05a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ac: Expected O, but got Unknown
		//IL_062c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0636: Expected O, but got Unknown
		groupBox4 = new GroupBox();
		label2 = new Label();
		label1 = new Label();
		cmdExitWindow = new Button();
		lblOperationName = new Label();
		txtOperationName = new TextBox();
		cmdDeleteOperation = new Button();
		cmdAddOperation = new Button();
		lstOperationInformation = new ListBox();
		openFileDialog1 = new OpenFileDialog();
		label47 = new Label();
		((Control)groupBox4).SuspendLayout();
		((Control)this).SuspendLayout();
		((Control)groupBox4).get_Controls().Add((Control)(object)label47);
		((Control)groupBox4).get_Controls().Add((Control)(object)label2);
		((Control)groupBox4).get_Controls().Add((Control)(object)label1);
		((Control)groupBox4).get_Controls().Add((Control)(object)cmdExitWindow);
		((Control)groupBox4).get_Controls().Add((Control)(object)lblOperationName);
		((Control)groupBox4).get_Controls().Add((Control)(object)txtOperationName);
		((Control)groupBox4).get_Controls().Add((Control)(object)cmdDeleteOperation);
		((Control)groupBox4).get_Controls().Add((Control)(object)cmdAddOperation);
		((Control)groupBox4).get_Controls().Add((Control)(object)lstOperationInformation);
		((Control)groupBox4).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)groupBox4).set_Location(new Point(8, 8));
		((Control)groupBox4).set_Name("groupBox4");
		((Control)groupBox4).set_Size(new Size(632, 256));
		((Control)groupBox4).set_TabIndex(3);
		groupBox4.set_TabStop(false);
		((Control)groupBox4).set_Text("Operation Information");
		((Control)label2).set_Font(new Font("Microsoft Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)label2).set_ForeColor(Color.Red);
		((Control)label2).set_Location(new Point(312, 184));
		((Control)label2).set_Name("label2");
		((Control)label2).set_Size(new Size(288, 40));
		((Control)label2).set_TabIndex(7);
		((Control)label2).set_Text("DISCLAIMER* - DO NOT Add or Delete operations without contacting ATMIA / Felix team");
		label2.set_TextAlign((ContentAlignment)16);
		((Control)label1).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label1).set_ForeColor(Color.Red);
		((Control)label1).set_Location(new Point(312, 104));
		((Control)label1).set_Name("label1");
		((Control)label1).set_Size(new Size(248, 23));
		((Control)label1).set_TabIndex(6);
		((Control)label1).set_Text("Select the OpeartionName to Delete");
		label1.set_TextAlign((ContentAlignment)16);
		cmdExitWindow.set_DialogResult((DialogResult)2);
		((ButtonBase)cmdExitWindow).set_FlatStyle((FlatStyle)3);
		((Control)cmdExitWindow).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)cmdExitWindow).set_Location(new Point(224, 144));
		((Control)cmdExitWindow).set_Name("cmdExitWindow");
		((Control)cmdExitWindow).set_TabIndex(5);
		((Control)cmdExitWindow).set_Text("Exit");
		((Control)cmdExitWindow).add_Click((EventHandler)cmdExitWindow_Click);
		((Control)lblOperationName).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)lblOperationName).set_Location(new Point(224, 24));
		((Control)lblOperationName).set_Name("lblOperationName");
		((Control)lblOperationName).set_Size(new Size(128, 24));
		((Control)lblOperationName).set_TabIndex(4);
		((Control)lblOperationName).set_Text("Name of Operation to be Added");
		lblOperationName.set_TextAlign((ContentAlignment)16);
		((Control)txtOperationName).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)txtOperationName).set_Location(new Point(360, 24));
		((Control)txtOperationName).set_Name("txtOperationName");
		((Control)txtOperationName).set_Size(new Size(216, 20));
		((Control)txtOperationName).set_TabIndex(3);
		((Control)txtOperationName).set_Text("");
		((ButtonBase)cmdDeleteOperation).set_FlatStyle((FlatStyle)3);
		((Control)cmdDeleteOperation).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)cmdDeleteOperation).set_Location(new Point(224, 104));
		((Control)cmdDeleteOperation).set_Name("cmdDeleteOperation");
		((Control)cmdDeleteOperation).set_TabIndex(2);
		((Control)cmdDeleteOperation).set_Text("Delete");
		((Control)cmdDeleteOperation).add_Click((EventHandler)cmdDeleteOperation_Click);
		((ButtonBase)cmdAddOperation).set_FlatStyle((FlatStyle)3);
		((Control)cmdAddOperation).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)cmdAddOperation).set_Location(new Point(224, 64));
		((Control)cmdAddOperation).set_Name("cmdAddOperation");
		((Control)cmdAddOperation).set_TabIndex(1);
		((Control)cmdAddOperation).set_Text("Add");
		((Control)cmdAddOperation).add_Click((EventHandler)cmdAddOperation_Click);
		((Control)lstOperationInformation).set_Font(new Font("Microsoft Sans Serif", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		lstOperationInformation.set_ItemHeight(16);
		((Control)lstOperationInformation).set_Location(new Point(8, 24));
		((Control)lstOperationInformation).set_Name("lstOperationInformation");
		((Control)lstOperationInformation).set_Size(new Size(200, 212));
		((Control)lstOperationInformation).set_TabIndex(0);
		((ListControl)lstOperationInformation).add_SelectedValueChanged((EventHandler)lstOperationInformation_SelectedValueChanged);
		((Control)label47).set_Font(new Font("Microsoft Sans Serif", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)label47).set_ForeColor(Color.Red);
		((Control)label47).set_Location(new Point(352, 24));
		((Control)label47).set_Name("label47");
		((Control)label47).set_Size(new Size(8, 24));
		((Control)label47).set_TabIndex(36);
		((Control)label47).set_Text("*");
		label47.set_TextAlign((ContentAlignment)32);
		((Form)this).set_AutoScaleBaseSize(new Size(5, 13));
		((Form)this).set_ClientSize(new Size(656, 278));
		((Control)this).get_Controls().Add((Control)(object)groupBox4);
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("AdvancedInformationForm");
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Control)this).set_Text("Advanced Information");
		((Control)groupBox4).ResumeLayout(false);
		((Control)this).ResumeLayout(false);
	}

	private void cmdExitWindow_Click(object sender, EventArgs e)
	{
		((Form)this).Close();
	}

	private void cmdAddOperation_Click(object sender, EventArgs e)
	{
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		if (((Control)txtOperationName).get_Text() == "")
		{
			MessageBox.Show("Please type the Operation Name in the Text Box");
			return;
		}
		lstOperationInformation.get_Items().Add((object)((Control)txtOperationName).get_Text());
		operationsList.Add(((Control)txtOperationName).get_Text());
		((Control)txtOperationName).set_Text("");
		((Control)lstOperationInformation).Refresh();
	}

	private void cmdDeleteOperation_Click(object sender, EventArgs e)
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Invalid comparison between I4 and Unknown
		if (1 == (int)MessageBox.Show("This Opearation might be used by the process Are you Sure you want to Delete ??", "Delete an Operation", (MessageBoxButtons)1, (MessageBoxIcon)48) && isItemSelected)
		{
			operationsList.Remove(lstOperationInformation.get_SelectedItem().ToString());
			lstOperationInformation.get_Items().Remove((object)lstOperationInformation.get_SelectedItem().ToString());
		}
		((Control)lstOperationInformation).Refresh();
		isItemSelected = false;
	}

	private void lstOperationInformation_SelectedValueChanged(object sender, EventArgs e)
	{
		isItemSelected = true;
	}
}
