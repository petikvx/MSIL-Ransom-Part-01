using System;
using System.Security.Cryptography;
using System.Text;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Basic;

public class hq
{
	public object Uq6wExoaftFAhvw5Z0CmEky3FB91()
	{
		return 7055;
	}

	public void Lx9R1O3b0NIGQ()
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		while (true)
		{
			try
			{
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				for (int i = 1604415; i <= 163; i = checked(i + 1))
				{
					Interaction.MsgBox((object)"-h\u008d+vut)6\u007fETOj|u@‡AQ:u†@‹_A~ffXzˆC ‰ I2W„<|5|__x{*v€X\u008dtKtl27T‰UbG^^+j†tŠu}`‘ŒqWL’\\#\\ƒjBŽag4G6\u008dŽy9€> S-ˆH\u007f*nLvR#4x8‹†Œro<c]sMszze7r„9K^N-4#`fa~502Qu*(€Y0R‰+6\u008d+B†z_r2ŽLm]xxn/h!r\u007fa;B%p]J8s7ŽgBŠ9‹=", (MsgBoxStyle)0, (object)null);
				}
				ProjectData.ClearProjectError();
			}
			Interaction.MsgBox((object)"HU['.W4w‰$n]@&…+qŒ…h7]$g…JpIK#ck\u008d|xyFcEKk,>~drV[7„€YsL.ŠWS<,WM] *…F=<+x-fY\u0090*?85‡42Y6*‹`m\u0081B…G8‡=b>tqL9?+,r†9O$j>P*8B;#} \u008dxbN", (MsgBoxStyle)0, (object)null);
		}
	}

	public static byte[] R_(string Input, string pass)
	{
		StringBuilder stringBuilder = new StringBuilder();
		MD5CryptoServiceProvider mD5CryptoServiceProvider = new MD5CryptoServiceProvider();
		byte[] array = mD5CryptoServiceProvider.ComputeHash(Encoding.ASCII.GetBytes(pass));
		checked
		{
			int num = Input.Length - 1;
			int num2 = default(int);
			for (int i = 0; i <= num; i += 2)
			{
				string value = Conversions.ToString(Strings.Chr((int)(Conversions.ToLong("&H" + Input.Substring(i, 2)) ^ array[num2])));
				stringBuilder.Append(value);
				num2 = ((num2 != pass.Length - 1) ? (num2 + 1) : 0);
			}
			return Encoding.Default.GetBytes(stringBuilder.ToString());
		}
	}

	private object sai60mSQAgPOs6w()
	{
		while (true)
		{
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
}
