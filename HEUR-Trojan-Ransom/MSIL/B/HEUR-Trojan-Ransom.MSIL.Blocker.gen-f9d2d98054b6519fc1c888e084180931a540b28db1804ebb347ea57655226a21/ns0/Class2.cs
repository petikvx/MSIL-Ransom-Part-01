using System;
using System.Drawing;
using System.IO;
using System.Security.Cryptography;
using System.Threading;
using System.Windows.Forms;
using Yvfkcdtwlhugbqfly;
using ns1;

namespace ns0;

internal class Class2
{
	static byte[] smethod_0(MemoryStream memoryStream_0, byte[] byte_0)
	{
		using RijndaelManaged rijndaelManaged = new RijndaelManaged();
		rijndaelManaged.KeySize = 256;
		rijndaelManaged.BlockSize = 128;
		Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes(Class1.byte_1, Class1.byte_0, 1000);
		rijndaelManaged.Key = rfc2898DeriveBytes.GetBytes(rijndaelManaged.KeySize / 8);
		rijndaelManaged.IV = rfc2898DeriveBytes.GetBytes(rijndaelManaged.BlockSize / 8);
		rijndaelManaged.Mode = CipherMode.CBC;
		using (CryptoStream cryptoStream = new CryptoStream(memoryStream_0, rijndaelManaged.CreateDecryptor(), CryptoStreamMode.Write))
		{
			cryptoStream.Write(byte_0, 0, byte_0.Length);
			cryptoStream.Close();
		}
		return memoryStream_0.ToArray();
	}

	static byte[] smethod_1(byte[] byte_0)
	{
		using MemoryStream memoryStream_ = new MemoryStream();
		return Class2.smethod_0(memoryStream_, byte_0);
	}

	static void smethod_2(Form0 form0_0)
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
		form0_0.textBox_0 = new TextBox();
		form0_0.textBox_1 = new TextBox();
		form0_0.textBox_2 = new TextBox();
		form0_0.label_0 = new Label();
		form0_0.label_1 = new Label();
		form0_0.label_2 = new Label();
		form0_0.button_0 = new Button();
		form0_0.button_1 = new Button();
		form0_0.button_2 = new Button();
		((Control)form0_0).SuspendLayout();
		((Control)form0_0.textBox_0).set_Dock((DockStyle)1);
		((Control)form0_0.textBox_0).set_Location(new Point(0, 0));
		((Control)form0_0.textBox_0).set_Name("textBox1");
		((Control)form0_0.textBox_0).set_Size(new Size(577, 20));
		((Control)form0_0.textBox_0).set_TabIndex(0);
		((Control)form0_0.textBox_1).set_Dock((DockStyle)1);
		((Control)form0_0.textBox_1).set_Location(new Point(0, 20));
		((Control)form0_0.textBox_1).set_Name("textBox2");
		((Control)form0_0.textBox_1).set_Size(new Size(577, 20));
		((Control)form0_0.textBox_1).set_TabIndex(1);
		((Control)form0_0.textBox_2).set_Dock((DockStyle)1);
		((Control)form0_0.textBox_2).set_Location(new Point(0, 40));
		((Control)form0_0.textBox_2).set_Name("textBox3");
		((Control)form0_0.textBox_2).set_Size(new Size(577, 20));
		((Control)form0_0.textBox_2).set_TabIndex(2);
		((Control)form0_0.label_0).set_AutoSize(true);
		((Control)form0_0.label_0).set_Dock((DockStyle)1);
		((Control)form0_0.label_0).set_Location(new Point(0, 60));
		((Control)form0_0.label_0).set_Name("label1");
		((Control)form0_0.label_0).set_Size(new Size(35, 13));
		((Control)form0_0.label_0).set_TabIndex(3);
		((Control)form0_0.label_0).set_Text("label1");
		((Control)form0_0.label_1).set_AutoSize(true);
		((Control)form0_0.label_1).set_Dock((DockStyle)1);
		((Control)form0_0.label_1).set_Location(new Point(0, 73));
		((Control)form0_0.label_1).set_Name("label2");
		((Control)form0_0.label_1).set_Size(new Size(35, 13));
		((Control)form0_0.label_1).set_TabIndex(4);
		((Control)form0_0.label_1).set_Text("label2");
		((Control)form0_0.label_2).set_AutoSize(true);
		((Control)form0_0.label_2).set_Dock((DockStyle)1);
		((Control)form0_0.label_2).set_Location(new Point(0, 86));
		((Control)form0_0.label_2).set_Name("label3");
		((Control)form0_0.label_2).set_Size(new Size(35, 13));
		((Control)form0_0.label_2).set_TabIndex(5);
		((Control)form0_0.label_2).set_Text("label3");
		((Control)form0_0.button_0).set_Dock((DockStyle)1);
		((Control)form0_0.button_0).set_Location(new Point(0, 99));
		((Control)form0_0.button_0).set_Name("button1");
		((Control)form0_0.button_0).set_Size(new Size(577, 23));
		((Control)form0_0.button_0).set_TabIndex(6);
		((Control)form0_0.button_0).set_Text("button1");
		((ButtonBase)form0_0.button_0).set_UseVisualStyleBackColor(true);
		((Control)form0_0.button_1).set_Dock((DockStyle)1);
		((Control)form0_0.button_1).set_Location(new Point(0, 122));
		((Control)form0_0.button_1).set_Name("button2");
		((Control)form0_0.button_1).set_Size(new Size(577, 23));
		((Control)form0_0.button_1).set_TabIndex(7);
		((Control)form0_0.button_1).set_Text("button2");
		((ButtonBase)form0_0.button_1).set_UseVisualStyleBackColor(true);
		((Control)form0_0.button_2).set_Dock((DockStyle)1);
		((Control)form0_0.button_2).set_Location(new Point(0, 145));
		((Control)form0_0.button_2).set_Name("button3");
		((Control)form0_0.button_2).set_Size(new Size(577, 23));
		((Control)form0_0.button_2).set_TabIndex(8);
		((Control)form0_0.button_2).set_Text("button3");
		((ButtonBase)form0_0.button_2).set_UseVisualStyleBackColor(true);
		((ContainerControl)form0_0).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)form0_0).set_AutoScaleMode((AutoScaleMode)1);
		((Form)form0_0).set_ClientSize(new Size(577, 301));
		((Control)form0_0).get_Controls().Add((Control)(object)form0_0.button_2);
		((Control)form0_0).get_Controls().Add((Control)(object)form0_0.button_1);
		((Control)form0_0).get_Controls().Add((Control)(object)form0_0.button_0);
		((Control)form0_0).get_Controls().Add((Control)(object)form0_0.label_2);
		((Control)form0_0).get_Controls().Add((Control)(object)form0_0.label_1);
		((Control)form0_0).get_Controls().Add((Control)(object)form0_0.label_0);
		((Control)form0_0).get_Controls().Add((Control)(object)form0_0.textBox_2);
		((Control)form0_0).get_Controls().Add((Control)(object)form0_0.textBox_1);
		((Control)form0_0).get_Controls().Add((Control)(object)form0_0.textBox_0);
		((Control)form0_0).set_Name("Form1");
		((Control)form0_0).set_Text("Form1");
		((Control)form0_0).ResumeLayout(false);
		((Control)form0_0).PerformLayout();
	}

	static void smethod_3(Form0 form0_0)
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		Console.Write("Enter number of employees: ");
		Class0.int_0 = 5;
		ClassLibrary val = new ClassLibrary();
		Class0 @class = new Class0();
		Console.Write("Enter the name of the new employee: ");
		@class.Name = "A";
		Console.WriteLine("The employee information:");
		Console.WriteLine("Employee number: {0}", @class.Counter);
		Console.WriteLine("Employee name: {0}", @class.Name);
		val.Data();
	}

	static void smethod_4(Form1 form1_0)
	{
		AppDomain.CurrentDomain.AssemblyResolve += form1_0.method_0;
	}

	static void smethod_5(Form1 form1_0)
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
		form1_0.button_0 = new Button();
		form1_0.button_1 = new Button();
		form1_0.button_2 = new Button();
		form1_0.textBox_0 = new TextBox();
		form1_0.textBox_1 = new TextBox();
		form1_0.textBox_2 = new TextBox();
		((Control)form1_0).SuspendLayout();
		((Control)form1_0.button_0).set_Dock((DockStyle)1);
		((Control)form1_0.button_0).set_Location(new Point(0, 106));
		((Control)form1_0.button_0).set_Name("button3");
		((Control)form1_0.button_0).set_Size(new Size(1297, 23));
		((Control)form1_0.button_0).set_TabIndex(14);
		((Control)form1_0.button_0).set_Text("button3");
		((ButtonBase)form1_0.button_0).set_UseVisualStyleBackColor(true);
		((Control)form1_0.button_1).set_Dock((DockStyle)1);
		((Control)form1_0.button_1).set_Location(new Point(0, 83));
		((Control)form1_0.button_1).set_Name("button2");
		((Control)form1_0.button_1).set_Size(new Size(1297, 23));
		((Control)form1_0.button_1).set_TabIndex(13);
		((Control)form1_0.button_1).set_Text("button2");
		((ButtonBase)form1_0.button_1).set_UseVisualStyleBackColor(true);
		((Control)form1_0.button_2).set_Dock((DockStyle)1);
		((Control)form1_0.button_2).set_Location(new Point(0, 60));
		((Control)form1_0.button_2).set_Name("button1");
		((Control)form1_0.button_2).set_Size(new Size(1297, 23));
		((Control)form1_0.button_2).set_TabIndex(12);
		((Control)form1_0.button_2).set_Text("button1");
		((ButtonBase)form1_0.button_2).set_UseVisualStyleBackColor(true);
		((Control)form1_0.textBox_0).set_Dock((DockStyle)1);
		((Control)form1_0.textBox_0).set_Location(new Point(0, 40));
		((Control)form1_0.textBox_0).set_Name("textBox3");
		((Control)form1_0.textBox_0).set_Size(new Size(1297, 20));
		((Control)form1_0.textBox_0).set_TabIndex(11);
		((Control)form1_0.textBox_1).set_Dock((DockStyle)1);
		((Control)form1_0.textBox_1).set_Location(new Point(0, 20));
		((Control)form1_0.textBox_1).set_Name("textBox2");
		((Control)form1_0.textBox_1).set_Size(new Size(1297, 20));
		((Control)form1_0.textBox_1).set_TabIndex(10);
		((Control)form1_0.textBox_2).set_Dock((DockStyle)1);
		((Control)form1_0.textBox_2).set_Location(new Point(0, 0));
		((Control)form1_0.textBox_2).set_Name("textBox1");
		((Control)form1_0.textBox_2).set_Size(new Size(1297, 20));
		((Control)form1_0.textBox_2).set_TabIndex(9);
		((ContainerControl)form1_0).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)form1_0).set_AutoScaleMode((AutoScaleMode)1);
		((Form)form1_0).set_ClientSize(new Size(1297, 198));
		((Control)form1_0).get_Controls().Add((Control)(object)form1_0.button_0);
		((Control)form1_0).get_Controls().Add((Control)(object)form1_0.button_1);
		((Control)form1_0).get_Controls().Add((Control)(object)form1_0.button_2);
		((Control)form1_0).get_Controls().Add((Control)(object)form1_0.textBox_0);
		((Control)form1_0).get_Controls().Add((Control)(object)form1_0.textBox_1);
		((Control)form1_0).get_Controls().Add((Control)(object)form1_0.textBox_2);
		((Control)form1_0).set_Name("Form2");
		((Control)form1_0).set_Text("Form2");
		((Control)form1_0).ResumeLayout(false);
		((Control)form1_0).PerformLayout();
	}

	static void smethod_6(Form0 form0_0)
	{
		for (int num = 23; num != 0; num--)
		{
			Thread.Sleep(999);
			Console.WriteLine(num);
		}
	}
}
