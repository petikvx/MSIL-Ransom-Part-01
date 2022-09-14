using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using HOAProject.My;
using Microsoft.VisualBasic.CompilerServices;

namespace HOAProject;

[DesignerGenerated]
public class Salespersons : Form
{
	private IContainer components;

	[field: AccessedThroughProperty("SALESPERSONBindingSource")]
	internal virtual BindingSource SALESPERSONBindingSource
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Button BackButton
	{
		[CompilerGenerated]
		get
		{
			return _BackButton;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = BackButton_Click;
			Button backButton = _BackButton;
			if (backButton != null)
			{
				((Control)backButton).remove_Click(eventHandler);
			}
			_BackButton = value;
			backButton = _BackButton;
			if (backButton != null)
			{
				((Control)backButton).add_Click(eventHandler);
			}
		}
	}

	[field: AccessedThroughProperty("SALESPERSONBindingSource1")]
	internal virtual BindingSource SALESPERSONBindingSource1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("SALESPERSONBindingSource2")]
	internal virtual BindingSource SALESPERSONBindingSource2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("SP_FIRST_NAMETextBox")]
	internal virtual TextBox SP_FIRST_NAMETextBox
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("SP_LAST_NAMETextBox")]
	internal virtual TextBox SP_LAST_NAMETextBox
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("SP_INITIALTextBox")]
	internal virtual TextBox SP_INITIALTextBox
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("SP_CONTACTTextBox")]
	internal virtual TextBox SP_CONTACTTextBox
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("SP_EMAILTextBox")]
	internal virtual TextBox SP_EMAILTextBox
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("MANAGER_IDTextBox")]
	internal virtual TextBox MANAGER_IDTextBox
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("SALESPERSON_IDComboBox")]
	internal virtual ComboBox SALESPERSON_IDComboBox
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	public Salespersons()
	{
		((Form)this).add_Load((EventHandler)Salespersons_Load);
		InitializeComponent();
	}

	[DebuggerNonUserCode]
	protected override void Dispose(bool disposing)
	{
		try
		{
			if (disposing && components != null)
			{
				components.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(disposing);
		}
	}

	[DebuggerStepThrough]
	private void InitializeComponent()
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Expected O, but got Unknown
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Expected O, but got Unknown
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Expected O, but got Unknown
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Expected O, but got Unknown
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Expected O, but got Unknown
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Expected O, but got Unknown
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Expected O, but got Unknown
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Expected O, but got Unknown
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0096: Expected O, but got Unknown
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Expected O, but got Unknown
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Expected O, but got Unknown
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Expected O, but got Unknown
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ae: Expected O, but got Unknown
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b5: Expected O, but got Unknown
		//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bc: Expected O, but got Unknown
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c3: Expected O, but got Unknown
		//IL_011e: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0202: Expected O, but got Unknown
		//IL_02b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02be: Expected O, but got Unknown
		//IL_0371: Unknown result type (might be due to invalid IL or missing references)
		//IL_037b: Expected O, but got Unknown
		//IL_042e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0438: Expected O, but got Unknown
		//IL_04f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_04fb: Expected O, but got Unknown
		//IL_05b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_05be: Expected O, but got Unknown
		//IL_067b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0685: Expected O, but got Unknown
		//IL_0816: Unknown result type (might be due to invalid IL or missing references)
		components = new Container();
		SALESPERSONBindingSource = new BindingSource(components);
		BackButton = new Button();
		SALESPERSONBindingSource1 = new BindingSource(components);
		SALESPERSONBindingSource2 = new BindingSource(components);
		SP_FIRST_NAMETextBox = new TextBox();
		SP_LAST_NAMETextBox = new TextBox();
		SP_INITIALTextBox = new TextBox();
		SP_CONTACTTextBox = new TextBox();
		SP_EMAILTextBox = new TextBox();
		MANAGER_IDTextBox = new TextBox();
		SALESPERSON_IDComboBox = new ComboBox();
		Label val = new Label();
		Label val2 = new Label();
		Label val3 = new Label();
		Label val4 = new Label();
		Label val5 = new Label();
		Label val6 = new Label();
		Label val7 = new Label();
		((ISupportInitialize)SALESPERSONBindingSource).BeginInit();
		((ISupportInitialize)SALESPERSONBindingSource1).BeginInit();
		((ISupportInitialize)SALESPERSONBindingSource2).BeginInit();
		((Control)this).SuspendLayout();
		SALESPERSONBindingSource.set_DataMember("SALESPERSON");
		((Control)BackButton).set_Location(new Point(481, 517));
		((Control)BackButton).set_Margin(new Padding(3, 2, 3, 2));
		((Control)BackButton).set_Name("BackButton");
		((Control)BackButton).set_Size(new Size(91, 23));
		((Control)BackButton).set_TabIndex(5);
		((ButtonBase)BackButton).set_Text("Back");
		((ButtonBase)BackButton).set_UseVisualStyleBackColor(true);
		SALESPERSONBindingSource1.set_DataMember("SALESPERSON");
		SALESPERSONBindingSource2.set_DataMember("SALESPERSON");
		val.set_AutoSize(true);
		((Control)val).set_Location(new Point(230, 176));
		((Control)val).set_Name("SP_FIRST_NAMELabel");
		((Control)val).set_Size(new Size(116, 17));
		((Control)val).set_TabIndex(7);
		val.set_Text("SP FIRST NAME:");
		((Control)SP_FIRST_NAMETextBox).get_DataBindings().Add(new Binding("Text", (object)SALESPERSONBindingSource, "SP_FIRST_NAME", true));
		((Control)SP_FIRST_NAMETextBox).set_Location(new Point(367, 173));
		((Control)SP_FIRST_NAMETextBox).set_Name("SP_FIRST_NAMETextBox");
		((Control)SP_FIRST_NAMETextBox).set_Size(new Size(153, 22));
		((Control)SP_FIRST_NAMETextBox).set_TabIndex(8);
		val2.set_AutoSize(true);
		((Control)val2).set_Location(new Point(230, 204));
		((Control)val2).set_Name("SP_LAST_NAMELabel");
		((Control)val2).set_Size(new Size(112, 17));
		((Control)val2).set_TabIndex(9);
		val2.set_Text("SP LAST NAME:");
		((Control)SP_LAST_NAMETextBox).get_DataBindings().Add(new Binding("Text", (object)SALESPERSONBindingSource, "SP_LAST_NAME", true));
		((Control)SP_LAST_NAMETextBox).set_Location(new Point(367, 201));
		((Control)SP_LAST_NAMETextBox).set_Name("SP_LAST_NAMETextBox");
		((Control)SP_LAST_NAMETextBox).set_Size(new Size(153, 22));
		((Control)SP_LAST_NAMETextBox).set_TabIndex(10);
		val3.set_AutoSize(true);
		((Control)val3).set_Location(new Point(230, 232));
		((Control)val3).set_Name("SP_INITIALLabel");
		((Control)val3).set_Size(new Size(79, 17));
		((Control)val3).set_TabIndex(11);
		val3.set_Text("SP INITIAL:");
		((Control)SP_INITIALTextBox).get_DataBindings().Add(new Binding("Text", (object)SALESPERSONBindingSource, "SP_INITIAL", true));
		((Control)SP_INITIALTextBox).set_Location(new Point(367, 229));
		((Control)SP_INITIALTextBox).set_Name("SP_INITIALTextBox");
		((Control)SP_INITIALTextBox).set_Size(new Size(153, 22));
		((Control)SP_INITIALTextBox).set_TabIndex(12);
		val4.set_AutoSize(true);
		((Control)val4).set_Location(new Point(230, 260));
		((Control)val4).set_Name("SP_CONTACTLabel");
		((Control)val4).set_Size(new Size(100, 17));
		((Control)val4).set_TabIndex(13);
		val4.set_Text("SP CONTACT:");
		((Control)SP_CONTACTTextBox).get_DataBindings().Add(new Binding("Text", (object)SALESPERSONBindingSource, "SP_CONTACT", true));
		((Control)SP_CONTACTTextBox).set_Location(new Point(367, 257));
		((Control)SP_CONTACTTextBox).set_Name("SP_CONTACTTextBox");
		((Control)SP_CONTACTTextBox).set_Size(new Size(153, 22));
		((Control)SP_CONTACTTextBox).set_TabIndex(14);
		val5.set_AutoSize(true);
		((Control)val5).set_Location(new Point(230, 288));
		((Control)val5).set_Name("SP_EMAILLabel");
		((Control)val5).set_Size(new Size(74, 17));
		((Control)val5).set_TabIndex(15);
		val5.set_Text("SP EMAIL:");
		((Control)SP_EMAILTextBox).get_DataBindings().Add(new Binding("Text", (object)SALESPERSONBindingSource, "SP_EMAIL", true));
		((Control)SP_EMAILTextBox).set_Location(new Point(367, 285));
		((Control)SP_EMAILTextBox).set_Name("SP_EMAILTextBox");
		((Control)SP_EMAILTextBox).set_Size(new Size(153, 22));
		((Control)SP_EMAILTextBox).set_TabIndex(16);
		val6.set_AutoSize(true);
		((Control)val6).set_Location(new Point(230, 316));
		((Control)val6).set_Name("MANAGER_IDLabel");
		((Control)val6).set_Size(new Size(98, 17));
		((Control)val6).set_TabIndex(17);
		val6.set_Text("MANAGER ID:");
		((Control)MANAGER_IDTextBox).get_DataBindings().Add(new Binding("Text", (object)SALESPERSONBindingSource, "MANAGER_ID", true));
		((Control)MANAGER_IDTextBox).set_Location(new Point(367, 313));
		((Control)MANAGER_IDTextBox).set_Name("MANAGER_IDTextBox");
		((Control)MANAGER_IDTextBox).set_Size(new Size(153, 22));
		((Control)MANAGER_IDTextBox).set_TabIndex(18);
		val7.set_AutoSize(true);
		((Control)val7).set_Location(new Point(230, 148));
		((Control)val7).set_Name("SALESPERSON_IDLabel");
		((Control)val7).set_Size(new Size(131, 17));
		((Control)val7).set_TabIndex(18);
		val7.set_Text("SALESPERSON ID:");
		((Control)SALESPERSON_IDComboBox).get_DataBindings().Add(new Binding("Text", (object)SALESPERSONBindingSource, "SALESPERSON_ID", true, (DataSourceUpdateMode)2));
		SALESPERSON_IDComboBox.set_DataSource((object)SALESPERSONBindingSource);
		((ListControl)SALESPERSON_IDComboBox).set_DisplayMember("SALESPERSON_ID");
		((ListControl)SALESPERSON_IDComboBox).set_FormattingEnabled(true);
		((Control)SALESPERSON_IDComboBox).set_Location(new Point(367, 145));
		((Control)SALESPERSON_IDComboBox).set_Name("SALESPERSON_IDComboBox");
		((Control)SALESPERSON_IDComboBox).set_Size(new Size(121, 24));
		((Control)SALESPERSON_IDComboBox).set_TabIndex(19);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(8f, 16f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_AutoScroll(true);
		((Form)this).set_ClientSize(new Size(1067, 560));
		((Control)this).get_Controls().Add((Control)(object)val7);
		((Control)this).get_Controls().Add((Control)(object)SALESPERSON_IDComboBox);
		((Control)this).get_Controls().Add((Control)(object)val);
		((Control)this).get_Controls().Add((Control)(object)SP_FIRST_NAMETextBox);
		((Control)this).get_Controls().Add((Control)(object)val2);
		((Control)this).get_Controls().Add((Control)(object)SP_LAST_NAMETextBox);
		((Control)this).get_Controls().Add((Control)(object)val3);
		((Control)this).get_Controls().Add((Control)(object)SP_INITIALTextBox);
		((Control)this).get_Controls().Add((Control)(object)val4);
		((Control)this).get_Controls().Add((Control)(object)SP_CONTACTTextBox);
		((Control)this).get_Controls().Add((Control)(object)val5);
		((Control)this).get_Controls().Add((Control)(object)SP_EMAILTextBox);
		((Control)this).get_Controls().Add((Control)(object)val6);
		((Control)this).get_Controls().Add((Control)(object)MANAGER_IDTextBox);
		((Control)this).get_Controls().Add((Control)(object)BackButton);
		((Form)this).set_Margin(new Padding(4));
		((Control)this).set_Name("Salespersons");
		((Form)this).set_Text("Salespersons");
		((Form)this).set_TopMost(true);
		((ISupportInitialize)SALESPERSONBindingSource).EndInit();
		((ISupportInitialize)SALESPERSONBindingSource1).EndInit();
		((ISupportInitialize)SALESPERSONBindingSource2).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	private void Salespersons_Load(object sender, EventArgs e)
	{
	}

	private void BackButton_Click(object sender, EventArgs e)
	{
		((Control)this).Hide();
		((Control)MyProject.Forms.WelcomePage).Show();
	}

	private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
	{
	}
}
