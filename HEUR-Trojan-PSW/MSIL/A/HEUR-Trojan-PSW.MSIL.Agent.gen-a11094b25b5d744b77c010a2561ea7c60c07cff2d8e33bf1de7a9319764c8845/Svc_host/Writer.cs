using System.Collections.Generic;
using System.IO;

namespace Svc_host;

public class Writer
{
	public static void Write(List<string> text, string path)
	{
		using StreamWriter streamWriter = new StreamWriter(path);
		foreach (string item in text)
		{
			streamWriter.WriteLine(item);
		}
	}
}
