using System;
using System.Collections;
using System.ComponentModel;
using System.Globalization;
using System.Resources;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

public sealed class GClass1
{
	private static bool bool_0;

	private static c6 c6_0;

	private static ee ee_0;

	private static Hashtable hashtable_0 = new Hashtable();

	private static ResourceManager resourceManager_0;

	[DllImport("kernel32.dll")]
	private static extern bool FreeConsole();

	[STAThread]
	private static int Main(string[] args)
	{
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Expected O, but got Unknown
		//IL_017b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0257: Unknown result type (might be due to invalid IL or missing references)
		//IL_0261: Expected O, but got Unknown
		//IL_026a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0274: Expected O, but got Unknown
		//IL_032f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0336: Expected O, but got Unknown
		//IL_0367: Unknown result type (might be due to invalid IL or missing references)
		//IL_036e: Expected O, but got Unknown
		//IL_0370: Unknown result type (might be due to invalid IL or missing references)
		int num = 5;
		bool_0 = smethod_3(args);
		cx val = null;
		resourceManager_0 = fw.a();
		try
		{
			val = new cx(GClass0.smethod_0(args));
			c6_0 = val.a();
		}
		catch (Exception ex)
		{
			Console.WriteLine(resourceManager_0.GetString("MSG_CLI_ENGINE_INIT"));
			Console.WriteLine(ex.Message);
			return 1;
		}
		catch
		{
			Console.WriteLine(resourceManager_0.GetString("MSG_CLI_ENGINE_INIT"));
			return 1;
		}
		Exception ex2 = null;
		bool flag = false;
		bool flag2 = false;
		c2 val2 = null;
		string text = null;
		try
		{
			if (!c6_0.a())
			{
				smethod_4();
			}
			try
			{
				text = c6_0.b();
				c6_0.a(text);
				if (text == null)
				{
				}
				if (c6_0.a().Length <= 1)
				{
					return 1;
				}
			}
			catch (Exception ex3)
			{
				ex2 = ex3;
				flag = true;
			}
			catch
			{
				flag2 = true;
			}
			c6_0.a(Console.Out);
			ee_0 = val.a();
			val2 = GClass0.smethod_1(args, ee_0, hashtable_0);
			if (val2 != null)
			{
				if (!GClass0.bool_0)
				{
					smethod_0(val2);
				}
				val2.c();
			}
		}
		catch (Exception ex4)
		{
			if (ex2 == null)
			{
				ex2 = ex4;
			}
		}
		catch
		{
			flag2 = true;
		}
		if (ex2 != null)
		{
			smethod_1();
			Console.WriteLine(ex2.Message);
			if (flag)
			{
				MessageBox.Show(ex2.Message, c6_0.d(), (MessageBoxButtons)0, (MessageBoxIcon)64);
			}
			if (GClass0.bool_3)
			{
				Console.WriteLine(ex2);
			}
			smethod_2();
			return 1;
		}
		if (flag2)
		{
			Console.WriteLine(resourceManager_0.GetString("MSG_CLI_ENGINE_INIT"));
			return 1;
		}
		if (!GClass0.bool_0 && (!c6_0.d() || !c6_0.b()))
		{
			Thread thread = new Thread(smethod_5);
			thread.ApartmentState = ApartmentState.STA;
			thread.CurrentUICulture = Thread.CurrentThread.CurrentUICulture;
			thread.Start();
		}
		if (GClass0.bool_1)
		{
			smethod_1();
			smethod_2();
			return 0;
		}
		if (GClass0.bool_0)
		{
			FreeConsole();
			if (val2 != null && !bool_0)
			{
				Application.Run((Form)new bw(val, ee_0));
			}
			else
			{
				Application.Run((Form)new bw(val, hashtable_0, (string)null));
			}
			return 0;
		}
		smethod_1();
		c6_0.c();
		if (GClass0.bool_2 && hashtable_0.Count != 0)
		{
			if (GClass0.string_0 != null)
			{
				Console.WriteLine(resourceManager_0.GetString("MSG_CLI_READING_CONFIG"), GClass0.string_0);
			}
			IEnumerator enumerator = hashtable_0.Keys.GetEnumerator();
			while (enumerator.MoveNext())
			{
				string text2 = (string)enumerator.Current;
				Console.WriteLine("\t" + resourceManager_0.GetString("MSG_CLI_PROPERTIES"), text2, (string)hashtable_0[text2]);
			}
			Console.WriteLine();
		}
		e6 val3 = new e6(ee_0, val);
		val3.a();
		if (val3.a())
		{
			return 1;
		}
		ei val4 = ee_0.a();
		if (!val4.o())
		{
			Form val5 = (Form)new gu(ee_0);
			val5.ShowDialog();
			((Component)(object)val5).Dispose();
		}
		return 0;
	}

	private static void smethod_0(c2 c2_0)
	{
		int num = 16;
		ArrayList arrayList = c2_0.e();
		if (arrayList == null || arrayList.Count == 0)
		{
			throw new ApplicationException(resourceManager_0.GetString("MSG_CLI_NOTRIGGER"));
		}
	}

	private static void smethod_1()
	{
		Console.WriteLine(c6_0.d() + " " + fw.a(resourceManager_0.GetString("MSG_CLI_VERSION"), new object[1] { c6_0.a() }) + " " + c6_0.i());
		Console.WriteLine(c6_0.c());
		Console.WriteLine(resourceManager_0.GetString("MSG_CLI_LICENSEE"), c6_0.g());
		Console.WriteLine(resourceManager_0.GetString("MSG_CLI_SERIAL"), c6_0.a());
	}

	private static void smethod_2()
	{
		Console.WriteLine();
		Console.WriteLine(fw.a(resourceManager_0.GetString("CLI_USAGE_SUMMARY"), new object[1] { c6_0.e() }));
		Console.WriteLine();
		Console.WriteLine(resourceManager_0.GetString("CLI_USAGE_OPTIONS"));
		Console.WriteLine(resourceManager_0.GetString("CLI_USAGE_G_OPTION"));
		Console.WriteLine(resourceManager_0.GetString("CLI_USAGE_I_OPTION"));
		Console.WriteLine(resourceManager_0.GetString("CLI_USAGE_P_OPTION"));
		Console.WriteLine(resourceManager_0.GetString("CLI_USAGE_P_OPTION_EXAMPLE"));
		Console.WriteLine(resourceManager_0.GetString("CLI_USAGE_Q_OPTION"));
		Console.WriteLine(resourceManager_0.GetString("CLI_USAGE_V_OPTION"));
		Console.WriteLine(resourceManager_0.GetString("CLI_USAGE_HELP_OPTION"));
		Console.WriteLine(resourceManager_0.GetString("CLI_USAGE_CONFIGFILE_OPTION"));
		Console.WriteLine();
		Console.WriteLine(resourceManager_0.GetString("CLI_USAGE_EXT_OPTIONS"));
		Console.WriteLine(resourceManager_0.GetString("CLI_USAGE_IN_OPTION"));
		Console.WriteLine(resourceManager_0.GetString("CLI_USAGE_OUT_OPTION"));
		Console.WriteLine(resourceManager_0.GetString("CLI_USAGE_MAKE_OPTION"));
		Console.WriteLine(resourceManager_0.GetString("CLI_USAGE_DISABLE_OPTION"));
		Console.WriteLine();
		Console.WriteLine(resourceManager_0.GetString("CLI_USAGE_EXT_PRO_STD_OPTIONS"));
		Console.WriteLine(resourceManager_0.GetString("CLI_USAGE_DEBUG_OPTION"));
		Console.WriteLine();
		Console.WriteLine(resourceManager_0.GetString("CLI_USAGE_EXT_RENAMING_OPTIONS"));
		Console.WriteLine(resourceManager_0.GetString("CLI_USAGE_RENAME_OPTION"));
		Console.WriteLine(resourceManager_0.GetString("CLI_USAGE_MAPOUT_OPTION"));
		Console.WriteLine(resourceManager_0.GetString("CLI_USAGE_CLOBBERMAP_OPTION"));
		Console.WriteLine(resourceManager_0.GetString("CLI_USAGE_KEEP_OPTION"));
		Console.WriteLine();
		Console.WriteLine(resourceManager_0.GetString("CLI_USAGE_EXT_RENAMING_PRO_STD_OPTIONS"));
		Console.WriteLine(resourceManager_0.GetString("CLI_USAGE_NAMING_OPTION"));
		Console.WriteLine(resourceManager_0.GetString("CLI_USAGE_PREFIX_OPTION"));
		Console.WriteLine();
		Console.WriteLine(resourceManager_0.GetString("CLI_USAGE_EXT_RENAMING_PRO_OPTIONS"));
		Console.WriteLine(resourceManager_0.GetString("CLI_USAGE_MAPIN_OPTION"));
		Console.WriteLine(resourceManager_0.GetString("CLI_USAGE_ENHANCEDOI_OPTION"));
		Console.WriteLine();
		Console.WriteLine(resourceManager_0.GetString("CLI_USAGE_EXT_CONTROLFLOW_OPTIONS"));
		Console.WriteLine(resourceManager_0.GetString("CLI_USAGE_CONTROLFLOW_OPTION"));
		Console.WriteLine();
		Console.WriteLine(resourceManager_0.GetString("CLI_USAGE_EXT_ENCRYPTION_OPTIONS"));
		Console.WriteLine(resourceManager_0.GetString("CLI_USAGE_ENCRYPT_OPTION"));
		Console.WriteLine();
		Console.WriteLine(resourceManager_0.GetString("CLI_USAGE_EXT_PRUNING_OPTIONS"));
		Console.WriteLine(resourceManager_0.GetString("CLI_USAGE_PRUNE_OPTION"));
		Console.WriteLine();
		Console.WriteLine(resourceManager_0.GetString("CLI_USAGE_EXT_LINKING_OPTIONS"));
		Console.WriteLine(resourceManager_0.GetString("CLI_USAGE_LINK_OPTION"));
		Console.WriteLine();
		Console.WriteLine(resourceManager_0.GetString("CLI_USAGE_EXT_PREMARK_OPTIONS"));
		Console.WriteLine(resourceManager_0.GetString("CLI_USAGE_PREMARK_OPTION"));
		Console.WriteLine(resourceManager_0.GetString("CLI_USAGE_PREMARKSTRING_OPTION"));
		Console.WriteLine(resourceManager_0.GetString("CLI_USAGE_PREMARKPASS_OPTION"));
		Console.WriteLine(resourceManager_0.GetString("CLI_USAGE_PREMARKCHARMAP_OPTION"));
		Console.WriteLine();
		Console.WriteLine(resourceManager_0.GetString("CLI_USAGE_EXT_OPTIONKEY"));
		Console.WriteLine(resourceManager_0.GetString("CLI_USAGE_EXTOPTIONS_OVERRIDE_CONFIGFILE"));
	}

	private static bool smethod_3(string[] string_0)
	{
		int num = 2;
		int num2 = 0;
		string text;
		while (true)
		{
			if (num2 < string_0.Length)
			{
				text = string_0[num2];
				if (text.StartsWith("/c:") || text.StartsWith("-c:"))
				{
					break;
				}
				num2++;
				continue;
			}
			return false;
		}
		string text2 = text.Substring(3);
		Console.WriteLine("Setting culture to {0}", text2);
		Thread.CurrentThread.CurrentUICulture = new CultureInfo(text2);
		return true;
	}

	private static void smethod_4()
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		int num = 6;
		b0 val = new b0(c6_0.h());
		((Control)val).set_Text(c6_0.d());
		((Form)val).ShowDialog();
		c6_0.a(val.a());
		if (!val.a())
		{
			throw new ApplicationException(fw.a().GetString("MSG_CLI_LICENSE"));
		}
	}

	private static void smethod_5()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected O, but got Unknown
		Application.Run((Form)new ai(c6_0, true));
	}
}
