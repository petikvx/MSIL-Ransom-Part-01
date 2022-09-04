using System;
using System.Security.Cryptography;
using System.Text;
using Microsoft.VisualBasic.CompilerServices;

namespace oEkqK;

public class NnKXl
{
	public static string B(string input, string pass)
	{
		RijndaelManaged rijndaelManaged = new RijndaelManaged();
		MD5CryptoServiceProvider mD5CryptoServiceProvider = new MD5CryptoServiceProvider();
		string text = "";
		string result = default(string);
		try
		{
			byte[] array = new byte[32];
			byte[] sourceArray = mD5CryptoServiceProvider.ComputeHash(Encoding.ASCII.GetBytes(pass));
			Array.Copy(sourceArray, 0, array, 0, 16);
			Array.Copy(sourceArray, 0, array, 15, 16);
			rijndaelManaged.Key = array;
			rijndaelManaged.Mode = CipherMode.ECB;
			ICryptoTransform cryptoTransform = rijndaelManaged.CreateDecryptor();
			byte[] array2 = Convert.FromBase64String(input);
			text = Encoding.ASCII.GetString(cryptoTransform.TransformFinalBlock(array2, 0, array2.Length));
			result = text;
			return result;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
			return result;
		}
	}

	static void SkWaz()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void nMSOZ()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void cGVoJ()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void yEpip()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void tTibL()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void VqEqd()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void mqQqC()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void GCNes()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void JpKPX()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void djqVi()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void jcNuw()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void FeeGO()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void SsExQ()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void duKRT()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void NgodJ()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void HYyxO()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void dLzUK()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void uWfrT()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void GzSPm()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void MhjsQ()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void FtZVV()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void PBRUX()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void QkaRf()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void vIWEV()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void ifDYw()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void zJTOr()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void cllkp()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void hknfE()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void divGb()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void mUlXb()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void ToNGC()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void jeIJp()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void DBGdj()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void EvVjc()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void MJrFe()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void CarSs()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void QWSdu()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void YaHNg()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void ItzHY()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void XBfdL()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void IIuuW()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void JUJGz()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void iuLMh()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void XdwFt()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void DKoPB()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void vfbQk()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void LxZvI()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void ZWQif()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void OcxzJ()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void NHwcl()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void FSRhk()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void egBdi()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void pMLmU()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void uNKgD()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void cQZwr()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void bHQQO()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void vLPSK()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void fIMaW()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void oRkQn()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void NjTej()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void pOIln()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void STRWH()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void SUMlO()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void PcnWV()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void BgFWi()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void juzwI()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void LoEkq()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void hmXQY()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void cCeJt()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void EmmZM()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void VZymk()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void RNYbq()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void UnIaV()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void uyCsS()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void pcDZY()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void DbTPb()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void lbHQQ()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void ixqaI()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void oRkQn()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void rJXfg()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}
}
