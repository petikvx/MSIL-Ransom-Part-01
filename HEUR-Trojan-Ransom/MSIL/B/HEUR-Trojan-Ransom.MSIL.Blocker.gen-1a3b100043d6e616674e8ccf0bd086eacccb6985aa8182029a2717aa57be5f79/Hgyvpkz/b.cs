using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Web;

namespace Hgyvpkz;

internal sealed class b
{
	public static Assembly a(object a, ResolveEventArgs b)
	{
		if (!b.Name.Contains("Iezlwrenppcvbtchutuk"))
		{
			return null;
		}
		using MemoryStream memoryStream = new MemoryStream();
		string name = "Hgyvpkz.Iezlwrenppcvbtchutuk.dll";
		Assembly.GetExecutingAssembly().GetManifestResourceStream(name)!.CopyTo(memoryStream);
		return Assembly.Load(new e().a(memoryStream.ToArray()));
	}

	public static string a(string a)
	{
		string result = "";
		try
		{
			string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(new FileInfo(HttpContext.get_Current().get_Server().MapPath(a)).Name);
			int num = new Random().Next(1, 9999999);
			string text = "/video/" + fileNameWithoutExtension + "___(" + num + ").jpg";
			ProcessStartInfo processStartInfo = new ProcessStartInfo();
			processStartInfo.FileName = "\"" + HttpContext.get_Current().get_Server().MapPath("/video/ffmpeg.exe") + "\"";
			processStartInfo.Arguments = string.Format("-ss {0} -i {1} -f image2 -vframes 1 -y {2}", 5, "\"" + HttpContext.get_Current().get_Server().MapPath(a) + "\"", "\"" + HttpContext.get_Current().get_Server().MapPath(text) + "\"");
			processStartInfo.CreateNoWindow = true;
			processStartInfo.UseShellExecute = false;
			Process process = new Process();
			try
			{
				process.StartInfo = processStartInfo;
				process.Start();
				process.WaitForExit();
				result = text;
				return result;
			}
			finally
			{
				((IDisposable)process).Dispose();
			}
		}
		catch (Exception ex)
		{
			_ = ex.Message;
			return result;
		}
	}
}
