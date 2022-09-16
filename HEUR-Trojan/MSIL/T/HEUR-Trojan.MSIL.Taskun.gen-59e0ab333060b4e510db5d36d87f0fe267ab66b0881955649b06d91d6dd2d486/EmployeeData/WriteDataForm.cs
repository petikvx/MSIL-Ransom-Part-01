using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using EmployeeData.My;
using Microsoft.VisualBasic.CompilerServices;

namespace EmployeeData;

[DesignerGenerated]
public class WriteDataForm : Form
{
	private IContainer components;

	private string strFilePath;

	private DialogResult ResponseSaveDialogResult;

	private StreamWriter employeeFile;

	private bool addFlag;

	[field: AccessedThroughProperty("GroupBox1")]
	internal virtual GroupBox GroupBox1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label8")]
	internal virtual Label Label8
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label7")]
	internal virtual Label Label7
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label6")]
	internal virtual Label Label6
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label5")]
	internal virtual Label Label5
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label4")]
	internal virtual Label Label4
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label3")]
	internal virtual Label Label3
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label2")]
	internal virtual Label Label2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label9")]
	internal virtual Label Label9
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Button btnClear
	{
		[CompilerGenerated]
		get
		{
			return _btnClear;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler_ = btnClear_Click;
			Button val = _btnClear;
			if (val != null)
			{
				WriteDataForm.smethod_38((Control)(object)val, eventHandler_);
			}
			_btnClear = value;
			val = _btnClear;
			if (val != null)
			{
				WriteDataForm.smethod_39((Control)(object)val, eventHandler_);
			}
		}
	}

	internal virtual Button btnSave
	{
		[CompilerGenerated]
		get
		{
			return _btnSave;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler_ = btnSave_Click;
			Button val = _btnSave;
			if (val != null)
			{
				WriteDataForm.smethod_38((Control)(object)val, eventHandler_);
			}
			_btnSave = value;
			val = _btnSave;
			if (val != null)
			{
				WriteDataForm.smethod_39((Control)(object)val, eventHandler_);
			}
		}
	}

	internal virtual Button btnExit
	{
		[CompilerGenerated]
		get
		{
			return _btnExit;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler_ = btnExit_Click;
			Button val = _btnExit;
			if (val != null)
			{
				WriteDataForm.smethod_38((Control)(object)val, eventHandler_);
			}
			_btnExit = value;
			val = _btnExit;
			if (val != null)
			{
				WriteDataForm.smethod_39((Control)(object)val, eventHandler_);
			}
		}
	}

	[field: AccessedThroughProperty("cboDepartment")]
	internal virtual ComboBox cboDepartment
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtEmail")]
	internal virtual TextBox txtEmail
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtExtension")]
	internal virtual TextBox txtExtension
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtTelephone")]
	internal virtual TextBox txtTelephone
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtEmployeeNumber")]
	internal virtual TextBox txtEmployeeNumber
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtLastName")]
	internal virtual TextBox txtLastName
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtMiddleName")]
	internal virtual TextBox txtMiddleName
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtFirstName")]
	internal virtual TextBox txtFirstName
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("SaveFileDialog1")]
	internal virtual SaveFileDialog SaveFileDialog1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label1")]
	internal virtual Label Label1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	public WriteDataForm()
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Expected O, but got Unknown
		WriteDataForm.smethod_0((Form)(object)this, new FormClosedEventHandler(WriteDataForm_FormClosed));
		strFilePath = MyProject.Forms.MainForm.strFilePath;
		addFlag = false;
		InitializeComponent();
	}

	[DebuggerNonUserCode]
	protected override void Dispose(bool disposing)
	{
		try
		{
			if (disposing && components != null)
			{
				WriteDataForm.smethod_1((IDisposable)components);
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
		//IL_027e: Unknown result type (might be due to invalid IL or missing references)
		//IL_029f: Unknown result type (might be due to invalid IL or missing references)
		//IL_05d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_064a: Unknown result type (might be due to invalid IL or missing references)
		//IL_06c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_073a: Unknown result type (might be due to invalid IL or missing references)
		//IL_07ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_0825: Unknown result type (might be due to invalid IL or missing references)
		//IL_0899: Unknown result type (might be due to invalid IL or missing references)
		//IL_090d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0978: Unknown result type (might be due to invalid IL or missing references)
		//IL_09ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a65: Unknown result type (might be due to invalid IL or missing references)
		GroupBox1 = WriteDataForm.smethod_2();
		cboDepartment = WriteDataForm.smethod_3();
		txtEmail = WriteDataForm.smethod_4();
		txtExtension = WriteDataForm.smethod_4();
		txtTelephone = WriteDataForm.smethod_4();
		txtEmployeeNumber = WriteDataForm.smethod_4();
		txtLastName = WriteDataForm.smethod_4();
		txtMiddleName = WriteDataForm.smethod_4();
		txtFirstName = WriteDataForm.smethod_4();
		Label8 = WriteDataForm.smethod_5();
		Label7 = WriteDataForm.smethod_5();
		Label6 = WriteDataForm.smethod_5();
		Label5 = WriteDataForm.smethod_5();
		Label4 = WriteDataForm.smethod_5();
		Label3 = WriteDataForm.smethod_5();
		Label2 = WriteDataForm.smethod_5();
		Label9 = WriteDataForm.smethod_5();
		btnClear = WriteDataForm.smethod_6();
		btnSave = WriteDataForm.smethod_6();
		btnExit = WriteDataForm.smethod_6();
		SaveFileDialog1 = WriteDataForm.smethod_7();
		Label1 = WriteDataForm.smethod_5();
		WriteDataForm.smethod_8((Control)(object)GroupBox1);
		WriteDataForm.smethod_9((Control)(object)this);
		WriteDataForm.smethod_11(WriteDataForm.smethod_10((Control)(object)GroupBox1), (Control)(object)cboDepartment);
		WriteDataForm.smethod_11(WriteDataForm.smethod_10((Control)(object)GroupBox1), (Control)(object)txtEmail);
		WriteDataForm.smethod_11(WriteDataForm.smethod_10((Control)(object)GroupBox1), (Control)(object)txtExtension);
		WriteDataForm.smethod_11(WriteDataForm.smethod_10((Control)(object)GroupBox1), (Control)(object)txtTelephone);
		WriteDataForm.smethod_11(WriteDataForm.smethod_10((Control)(object)GroupBox1), (Control)(object)txtEmployeeNumber);
		WriteDataForm.smethod_11(WriteDataForm.smethod_10((Control)(object)GroupBox1), (Control)(object)txtLastName);
		WriteDataForm.smethod_11(WriteDataForm.smethod_10((Control)(object)GroupBox1), (Control)(object)txtMiddleName);
		WriteDataForm.smethod_11(WriteDataForm.smethod_10((Control)(object)GroupBox1), (Control)(object)txtFirstName);
		WriteDataForm.smethod_11(WriteDataForm.smethod_10((Control)(object)GroupBox1), (Control)(object)Label8);
		WriteDataForm.smethod_11(WriteDataForm.smethod_10((Control)(object)GroupBox1), (Control)(object)Label7);
		WriteDataForm.smethod_11(WriteDataForm.smethod_10((Control)(object)GroupBox1), (Control)(object)Label6);
		WriteDataForm.smethod_11(WriteDataForm.smethod_10((Control)(object)GroupBox1), (Control)(object)Label5);
		WriteDataForm.smethod_11(WriteDataForm.smethod_10((Control)(object)GroupBox1), (Control)(object)Label4);
		WriteDataForm.smethod_11(WriteDataForm.smethod_10((Control)(object)GroupBox1), (Control)(object)Label3);
		WriteDataForm.smethod_11(WriteDataForm.smethod_10((Control)(object)GroupBox1), (Control)(object)Label2);
		WriteDataForm.smethod_11(WriteDataForm.smethod_10((Control)(object)GroupBox1), (Control)(object)Label9);
		WriteDataForm.smethod_12((Control)(object)GroupBox1, new Point(30, 36));
		WriteDataForm.smethod_13((Control)(object)GroupBox1, new Padding(4));
		WriteDataForm.smethod_14((Control)(object)GroupBox1, "GroupBox1");
		WriteDataForm.smethod_15((Control)(object)GroupBox1, new Padding(4));
		WriteDataForm.smethod_16((Control)(object)GroupBox1, new Size(336, 295));
		WriteDataForm.smethod_17((Control)(object)GroupBox1, 8);
		WriteDataForm.smethod_18(GroupBox1, bool_0: false);
		WriteDataForm.smethod_19(GroupBox1, "Enter Employee Data");
		WriteDataForm.smethod_20((Control)(object)cboDepartment, bool_0: true);
		WriteDataForm.smethod_21((ListControl)(object)cboDepartment, bool_0: true);
		WriteDataForm.smethod_23(WriteDataForm.smethod_22(cboDepartment), new object[5] { "Accounting", "Administration", "Marketing", "MIS", "Sales" });
		WriteDataForm.smethod_12((Control)(object)cboDepartment, new Point(158, 159));
		WriteDataForm.smethod_14((Control)(object)cboDepartment, "cboDepartment");
		WriteDataForm.smethod_16((Control)(object)cboDepartment, new Size(148, 24));
		WriteDataForm.smethod_17((Control)(object)cboDepartment, 23);
		WriteDataForm.smethod_12((Control)(object)txtEmail, new Point(158, 255));
		WriteDataForm.smethod_14((Control)(object)txtEmail, "txtEmail");
		WriteDataForm.smethod_16((Control)(object)txtEmail, new Size(148, 22));
		WriteDataForm.smethod_17((Control)(object)txtEmail, 22);
		WriteDataForm.smethod_12((Control)(object)txtExtension, new Point(158, 223));
		WriteDataForm.smethod_14((Control)(object)txtExtension, "txtExtension");
		WriteDataForm.smethod_16((Control)(object)txtExtension, new Size(148, 22));
		WriteDataForm.smethod_17((Control)(object)txtExtension, 21);
		WriteDataForm.smethod_12((Control)(object)txtTelephone, new Point(158, 191));
		WriteDataForm.smethod_14((Control)(object)txtTelephone, "txtTelephone");
		WriteDataForm.smethod_16((Control)(object)txtTelephone, new Size(148, 22));
		WriteDataForm.smethod_17((Control)(object)txtTelephone, 20);
		WriteDataForm.smethod_12((Control)(object)txtEmployeeNumber, new Point(158, 127));
		WriteDataForm.smethod_14((Control)(object)txtEmployeeNumber, "txtEmployeeNumber");
		WriteDataForm.smethod_16((Control)(object)txtEmployeeNumber, new Size(148, 22));
		WriteDataForm.smethod_17((Control)(object)txtEmployeeNumber, 18);
		WriteDataForm.smethod_12((Control)(object)txtLastName, new Point(158, 95));
		WriteDataForm.smethod_14((Control)(object)txtLastName, "txtLastName");
		WriteDataForm.smethod_16((Control)(object)txtLastName, new Size(148, 22));
		WriteDataForm.smethod_17((Control)(object)txtLastName, 17);
		WriteDataForm.smethod_12((Control)(object)txtMiddleName, new Point(158, 63));
		WriteDataForm.smethod_14((Control)(object)txtMiddleName, "txtMiddleName");
		WriteDataForm.smethod_16((Control)(object)txtMiddleName, new Size(148, 22));
		WriteDataForm.smethod_17((Control)(object)txtMiddleName, 16);
		WriteDataForm.smethod_12((Control)(object)txtFirstName, new Point(158, 31));
		WriteDataForm.smethod_14((Control)(object)txtFirstName, "txtFirstName");
		WriteDataForm.smethod_16((Control)(object)txtFirstName, new Size(148, 22));
		WriteDataForm.smethod_17((Control)(object)txtFirstName, 15);
		WriteDataForm.smethod_24(Label8, bool_0: true);
		WriteDataForm.smethod_12((Control)(object)Label8, new Point(56, 255));
		WriteDataForm.smethod_13((Control)(object)Label8, new Padding(4, 0, 4, 0));
		WriteDataForm.smethod_14((Control)(object)Label8, "Label8");
		WriteDataForm.smethod_16((Control)(object)Label8, new Size(107, 17));
		WriteDataForm.smethod_17((Control)(object)Label8, 14);
		WriteDataForm.smethod_25(Label8, "E-mail Address:");
		WriteDataForm.smethod_24(Label7, bool_0: true);
		WriteDataForm.smethod_12((Control)(object)Label7, new Point(87, 223));
		WriteDataForm.smethod_13((Control)(object)Label7, new Padding(4, 0, 4, 0));
		WriteDataForm.smethod_14((Control)(object)Label7, "Label7");
		WriteDataForm.smethod_16((Control)(object)Label7, new Size(73, 17));
		WriteDataForm.smethod_17((Control)(object)Label7, 12);
		WriteDataForm.smethod_25(Label7, "Extension:");
		WriteDataForm.smethod_24(Label6, bool_0: true);
		WriteDataForm.smethod_12((Control)(object)Label6, new Point(80, 191));
		WriteDataForm.smethod_13((Control)(object)Label6, new Padding(4, 0, 4, 0));
		WriteDataForm.smethod_14((Control)(object)Label6, "Label6");
		WriteDataForm.smethod_16((Control)(object)Label6, new Size(80, 17));
		WriteDataForm.smethod_17((Control)(object)Label6, 10);
		WriteDataForm.smethod_25(Label6, "Telephone:");
		WriteDataForm.smethod_24(Label5, bool_0: true);
		WriteDataForm.smethod_12((Control)(object)Label5, new Point(75, 159));
		WriteDataForm.smethod_13((Control)(object)Label5, new Padding(4, 0, 4, 0));
		WriteDataForm.smethod_14((Control)(object)Label5, "Label5");
		WriteDataForm.smethod_16((Control)(object)Label5, new Size(86, 17));
		WriteDataForm.smethod_17((Control)(object)Label5, 8);
		WriteDataForm.smethod_25(Label5, "Department:");
		WriteDataForm.smethod_24(Label4, bool_0: true);
		WriteDataForm.smethod_12((Control)(object)Label4, new Point(33, 127));
		WriteDataForm.smethod_13((Control)(object)Label4, new Padding(4, 0, 4, 0));
		WriteDataForm.smethod_14((Control)(object)Label4, "Label4");
		WriteDataForm.smethod_16((Control)(object)Label4, new Size(128, 17));
		WriteDataForm.smethod_17((Control)(object)Label4, 6);
		WriteDataForm.smethod_25(Label4, "Employee Number:");
		WriteDataForm.smethod_24(Label3, bool_0: true);
		WriteDataForm.smethod_12((Control)(object)Label3, new Point(80, 95));
		WriteDataForm.smethod_13((Control)(object)Label3, new Padding(4, 0, 4, 0));
		WriteDataForm.smethod_14((Control)(object)Label3, "Label3");
		WriteDataForm.smethod_16((Control)(object)Label3, new Size(80, 17));
		WriteDataForm.smethod_17((Control)(object)Label3, 4);
		WriteDataForm.smethod_25(Label3, "Last Name:");
		WriteDataForm.smethod_24(Label2, bool_0: true);
		WriteDataForm.smethod_12((Control)(object)Label2, new Point(65, 63));
		WriteDataForm.smethod_13((Control)(object)Label2, new Padding(4, 0, 4, 0));
		WriteDataForm.smethod_14((Control)(object)Label2, "Label2");
		WriteDataForm.smethod_16((Control)(object)Label2, new Size(94, 17));
		WriteDataForm.smethod_17((Control)(object)Label2, 2);
		WriteDataForm.smethod_25(Label2, "Middle Name:");
		WriteDataForm.smethod_24(Label9, bool_0: true);
		WriteDataForm.smethod_12((Control)(object)Label9, new Point(81, 31));
		WriteDataForm.smethod_13((Control)(object)Label9, new Padding(4, 0, 4, 0));
		WriteDataForm.smethod_14((Control)(object)Label9, "Label9");
		WriteDataForm.smethod_16((Control)(object)Label9, new Size(80, 17));
		WriteDataForm.smethod_17((Control)(object)Label9, 0);
		WriteDataForm.smethod_25(Label9, "First Name:");
		WriteDataForm.smethod_12((Control)(object)btnClear, new Point(145, 363));
		WriteDataForm.smethod_13((Control)(object)btnClear, new Padding(4));
		WriteDataForm.smethod_14((Control)(object)btnClear, "btnClear");
		WriteDataForm.smethod_16((Control)(object)btnClear, new Size(107, 49));
		WriteDataForm.smethod_17((Control)(object)btnClear, 10);
		WriteDataForm.smethod_26((ButtonBase)(object)btnClear, "C&lear");
		WriteDataForm.smethod_27((ButtonBase)(object)btnClear, bool_0: true);
		WriteDataForm.smethod_12((Control)(object)btnSave, new Point(30, 363));
		WriteDataForm.smethod_13((Control)(object)btnSave, new Padding(4));
		WriteDataForm.smethod_14((Control)(object)btnSave, "btnSave");
		WriteDataForm.smethod_16((Control)(object)btnSave, new Size(107, 49));
		WriteDataForm.smethod_17((Control)(object)btnSave, 9);
		WriteDataForm.smethod_26((ButtonBase)(object)btnSave, "&Save Record");
		WriteDataForm.smethod_27((ButtonBase)(object)btnSave, bool_0: true);
		WriteDataForm.smethod_12((Control)(object)btnExit, new Point(260, 363));
		WriteDataForm.smethod_13((Control)(object)btnExit, new Padding(4));
		WriteDataForm.smethod_14((Control)(object)btnExit, "btnExit");
		WriteDataForm.smethod_16((Control)(object)btnExit, new Size(107, 49));
		WriteDataForm.smethod_17((Control)(object)btnExit, 11);
		WriteDataForm.smethod_26((ButtonBase)(object)btnExit, "E&xit");
		WriteDataForm.smethod_27((ButtonBase)(object)btnExit, bool_0: true);
		WriteDataForm.smethod_24(Label1, bool_0: true);
		WriteDataForm.smethod_12((Control)(object)Label1, new Point(243, 424));
		WriteDataForm.smethod_14((Control)(object)Label1, "Label1");
		WriteDataForm.smethod_16((Control)(object)Label1, new Size(141, 17));
		WriteDataForm.smethod_17((Control)(object)Label1, 16);
		WriteDataForm.smethod_25(Label1, "Smith Amornsaensuk");
		WriteDataForm.smethod_28((ContainerControl)(object)this, new SizeF(8f, 16f));
		WriteDataForm.smethod_29((ContainerControl)(object)this, (AutoScaleMode)1);
		WriteDataForm.smethod_30((Form)(object)this, new Size(424, 450));
		WriteDataForm.smethod_11(WriteDataForm.smethod_31((Control)(object)this), (Control)(object)Label1);
		WriteDataForm.smethod_11(WriteDataForm.smethod_31((Control)(object)this), (Control)(object)GroupBox1);
		WriteDataForm.smethod_11(WriteDataForm.smethod_31((Control)(object)this), (Control)(object)btnClear);
		WriteDataForm.smethod_11(WriteDataForm.smethod_31((Control)(object)this), (Control)(object)btnSave);
		WriteDataForm.smethod_11(WriteDataForm.smethod_31((Control)(object)this), (Control)(object)btnExit);
		WriteDataForm.smethod_32((Control)(object)this, "WriteDataForm");
		WriteDataForm.smethod_33((Form)(object)this, "Employee Data");
		WriteDataForm.smethod_34((Control)(object)GroupBox1, bool_0: false);
		WriteDataForm.smethod_35((Control)(object)GroupBox1);
		WriteDataForm.smethod_36((Control)(object)this, bool_0: false);
		WriteDataForm.smethod_37((Control)(object)this);
	}

	private void btnExit_Click(object sender, EventArgs e)
	{
		MyProject.Forms.MainForm.inputFile = WriteDataForm.smethod_40(strFilePath);
		WriteDataForm.smethod_41((Form)(object)this);
	}

	private void btnClear_Click(object sender, EventArgs e)
	{
		WriteDataForm.smethod_42(txtFirstName, string.Empty);
		WriteDataForm.smethod_42(txtMiddleName, string.Empty);
		WriteDataForm.smethod_42(txtLastName, string.Empty);
		WriteDataForm.smethod_42(txtEmployeeNumber, string.Empty);
		WriteDataForm.smethod_43(cboDepartment, string.Empty);
		WriteDataForm.smethod_42(txtTelephone, string.Empty);
		WriteDataForm.smethod_42(txtExtension, string.Empty);
		WriteDataForm.smethod_42(txtEmail, string.Empty);
		WriteDataForm.smethod_44((Control)(object)txtFirstName);
	}

	private void btnSave_Click(object sender, EventArgs e)
	{
		//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			employeeFile = WriteDataForm.smethod_45(strFilePath);
			WriteDataForm.smethod_47((TextWriter)employeeFile, WriteDataForm.smethod_46(txtFirstName));
			WriteDataForm.smethod_47((TextWriter)employeeFile, WriteDataForm.smethod_46(txtMiddleName));
			WriteDataForm.smethod_47((TextWriter)employeeFile, WriteDataForm.smethod_46(txtLastName));
			WriteDataForm.smethod_47((TextWriter)employeeFile, WriteDataForm.smethod_46(txtEmployeeNumber));
			WriteDataForm.smethod_47((TextWriter)employeeFile, WriteDataForm.smethod_48(cboDepartment));
			WriteDataForm.smethod_47((TextWriter)employeeFile, WriteDataForm.smethod_46(txtTelephone));
			WriteDataForm.smethod_47((TextWriter)employeeFile, WriteDataForm.smethod_46(txtExtension));
			WriteDataForm.smethod_47((TextWriter)employeeFile, WriteDataForm.smethod_46(txtEmail));
			WriteDataForm.smethod_49(employeeFile);
			addFlag = true;
			WriteDataForm.smethod_50("The record has been saved.");
		}
		catch (Exception exception_)
		{
			WriteDataForm.smethod_51(exception_);
			WriteDataForm.smethod_50("Cannot process file");
			WriteDataForm.smethod_52();
		}
	}

	private void WriteDataForm_FormClosed(object sender, FormClosedEventArgs e)
	{
		if (addFlag)
		{
			MyProject.Forms.MainForm.populateDataToArray();
		}
	}

	static void smethod_0(Form form_0, FormClosedEventHandler formClosedEventHandler_0)
	{
		form_0.add_FormClosed(formClosedEventHandler_0);
	}

	static void smethod_1(IDisposable idisposable_0)
	{
		idisposable_0.Dispose();
	}

	static GroupBox smethod_2()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new GroupBox();
	}

	static ComboBox smethod_3()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new ComboBox();
	}

	static TextBox smethod_4()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new TextBox();
	}

	static Label smethod_5()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new Label();
	}

	static Button smethod_6()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new Button();
	}

	static SaveFileDialog smethod_7()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new SaveFileDialog();
	}

	static void smethod_8(Control control_0)
	{
		control_0.SuspendLayout();
	}

	static void smethod_9(Control control_0)
	{
		control_0.SuspendLayout();
	}

	static ControlCollection smethod_10(Control control_0)
	{
		return control_0.get_Controls();
	}

	static void smethod_11(ControlCollection controlCollection_0, Control control_0)
	{
		controlCollection_0.Add(control_0);
	}

	static void smethod_12(Control control_0, Point point_0)
	{
		control_0.set_Location(point_0);
	}

	static void smethod_13(Control control_0, Padding padding_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		control_0.set_Margin(padding_0);
	}

	static void smethod_14(Control control_0, string string_0)
	{
		control_0.set_Name(string_0);
	}

	static void smethod_15(Control control_0, Padding padding_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		control_0.set_Padding(padding_0);
	}

	static void smethod_16(Control control_0, Size size_0)
	{
		control_0.set_Size(size_0);
	}

	static void smethod_17(Control control_0, int int_0)
	{
		control_0.set_TabIndex(int_0);
	}

	static void smethod_18(GroupBox groupBox_0, bool bool_0)
	{
		groupBox_0.set_TabStop(bool_0);
	}

	static void smethod_19(GroupBox groupBox_0, string string_0)
	{
		groupBox_0.set_Text(string_0);
	}

	static void smethod_20(Control control_0, bool bool_0)
	{
		control_0.set_AllowDrop(bool_0);
	}

	static void smethod_21(ListControl listControl_0, bool bool_0)
	{
		listControl_0.set_FormattingEnabled(bool_0);
	}

	static ObjectCollection smethod_22(ComboBox comboBox_0)
	{
		return comboBox_0.get_Items();
	}

	static void smethod_23(ObjectCollection objectCollection_0, object[] object_0)
	{
		objectCollection_0.AddRange(object_0);
	}

	static void smethod_24(Label label_0, bool bool_0)
	{
		label_0.set_AutoSize(bool_0);
	}

	static void smethod_25(Label label_0, string string_0)
	{
		label_0.set_Text(string_0);
	}

	static void smethod_26(ButtonBase buttonBase_0, string string_0)
	{
		buttonBase_0.set_Text(string_0);
	}

	static void smethod_27(ButtonBase buttonBase_0, bool bool_0)
	{
		buttonBase_0.set_UseVisualStyleBackColor(bool_0);
	}

	static void smethod_28(ContainerControl containerControl_0, SizeF sizeF_0)
	{
		containerControl_0.set_AutoScaleDimensions(sizeF_0);
	}

	static void smethod_29(ContainerControl containerControl_0, AutoScaleMode autoScaleMode_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		containerControl_0.set_AutoScaleMode(autoScaleMode_0);
	}

	static void smethod_30(Form form_0, Size size_0)
	{
		form_0.set_ClientSize(size_0);
	}

	static ControlCollection smethod_31(Control control_0)
	{
		return control_0.get_Controls();
	}

	static void smethod_32(Control control_0, string string_0)
	{
		control_0.set_Name(string_0);
	}

	static void smethod_33(Form form_0, string string_0)
	{
		form_0.set_Text(string_0);
	}

	static void smethod_34(Control control_0, bool bool_0)
	{
		control_0.ResumeLayout(bool_0);
	}

	static void smethod_35(Control control_0)
	{
		control_0.PerformLayout();
	}

	static void smethod_36(Control control_0, bool bool_0)
	{
		control_0.ResumeLayout(bool_0);
	}

	static void smethod_37(Control control_0)
	{
		control_0.PerformLayout();
	}

	static void smethod_38(Control control_0, EventHandler eventHandler_0)
	{
		control_0.remove_Click(eventHandler_0);
	}

	static void smethod_39(Control control_0, EventHandler eventHandler_0)
	{
		control_0.add_Click(eventHandler_0);
	}

	static StreamReader smethod_40(string string_0)
	{
		return File.OpenText(string_0);
	}

	static void smethod_41(Form form_0)
	{
		form_0.Close();
	}

	static void smethod_42(TextBox textBox_0, string string_0)
	{
		textBox_0.set_Text(string_0);
	}

	static void smethod_43(ComboBox comboBox_0, string string_0)
	{
		comboBox_0.set_Text(string_0);
	}

	static bool smethod_44(Control control_0)
	{
		return control_0.Focus();
	}

	static StreamWriter smethod_45(string string_0)
	{
		return File.AppendText(string_0);
	}

	static string smethod_46(TextBox textBox_0)
	{
		return textBox_0.get_Text();
	}

	static void smethod_47(TextWriter textWriter_0, string string_0)
	{
		textWriter_0.WriteLine(string_0);
	}

	static string smethod_48(ComboBox comboBox_0)
	{
		return comboBox_0.get_Text();
	}

	static void smethod_49(StreamWriter streamWriter_0)
	{
		streamWriter_0.Close();
	}

	static DialogResult smethod_50(string string_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return MessageBox.Show(string_0);
	}

	static void smethod_51(Exception exception_0)
	{
		ProjectData.SetProjectError(exception_0);
	}

	static void smethod_52()
	{
		ProjectData.ClearProjectError();
	}
}
