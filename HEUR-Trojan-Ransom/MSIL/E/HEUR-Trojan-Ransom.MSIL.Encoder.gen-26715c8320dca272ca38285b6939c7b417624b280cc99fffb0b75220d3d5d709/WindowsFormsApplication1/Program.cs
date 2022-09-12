using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using IWshRuntimeLibrary;
using Poshmark_tools;

namespace WindowsFormsApplication1;

internal static class Program
{
	[STAThread]
	private static void Main()
	{
		Application.EnableVisualStyles();
		Application.SetCompatibleTextRenderingDefault(false);
		try
		{
			string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
			string[] files = Directory.GetFiles(folderPath);
			string[] array = files;
			foreach (string text in array)
			{
				if (text.Contains("Poshmark_tools") && text.Contains("Shortcut") && text.Contains(".lnk"))
				{
					File.Delete(text);
				}
			}
		}
		catch
		{
		}
		unzip_from_Zip();
		add_app_on_desktop();
		console_start_class console_start_class = new console_start_class();
		console_start_class.main();
	}

	public static void copy_files(string sourcePath, string targetPath)
	{
		if (!Directory.Exists(targetPath))
		{
			Directory.CreateDirectory(targetPath);
		}
		string[] files = Directory.GetFiles(sourcePath);
		foreach (string text in files)
		{
			File.Copy(text, text.Replace(sourcePath, targetPath), overwrite: true);
		}
	}

	public static void unzip_from_Zip()
	{
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Expected O, but got Unknown
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Invalid comparison between Unknown and I4
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		string friendlyName = AppDomain.CurrentDomain.FriendlyName;
		string currentDirectory = Directory.GetCurrentDirectory();
		if (!currentDirectory.Contains("AppData") && !currentDirectory.ToLower().Contains("downloads"))
		{
			return;
		}
		MessageBox.Show("You cannot run app directly from that folder, select folder to copy app files", "Warning!", (MessageBoxButtons)0, (MessageBoxIcon)48);
		FolderBrowserDialog val = new FolderBrowserDialog();
		try
		{
			if ((int)((CommonDialog)val).ShowDialog() == 1)
			{
				string sourcePath = currentDirectory;
				string text = val.get_SelectedPath().ToString() + "\\PoshmarkTools";
				copy_files(sourcePath, text);
				Process process = new Process
				{
					StartInfo = 
					{
						WorkingDirectory = text,
						FileName = text + "\\" + friendlyName
					}
				};
				process.Start();
				Environment.Exit(1);
			}
			else
			{
				MessageBox.Show("No Folder Selected, app cannot run from zip folder");
				Environment.Exit(1);
			}
		}
		finally
		{
			((IDisposable)val)?.Dispose();
		}
	}

	public static void add_app_on_desktop()
	{
		try
		{
			string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
			string friendlyName = AppDomain.CurrentDomain.FriendlyName;
			string text = folderPath;
			string text2 = text + "\\" + friendlyName.Replace(".vshost", "") + "V4-Shortcut.lnk";
			if (!File.Exists(text2))
			{
				string location = Assembly.GetExecutingAssembly().Location;
				WshShell wshShell = (WshShell)Activator.CreateInstance(Marshal.GetTypeFromCLSID(new Guid("72C24DD5-D70A-438B-8A42-98424B88AFB8")));
				IWshShortcut wshShortcut = (IWshShortcut)(dynamic)wshShell.CreateShortcut(text2);
				wshShortcut.TargetPath = location;
				wshShortcut.Description = "Poshmark Pro Tools by http://poshmarktools.com";
				wshShortcut.WorkingDirectory = Path.GetDirectoryName(Assembly.GetEntryAssembly()!.Location);
				wshShortcut.Save();
			}
		}
		catch (Exception)
		{
		}
	}
}
