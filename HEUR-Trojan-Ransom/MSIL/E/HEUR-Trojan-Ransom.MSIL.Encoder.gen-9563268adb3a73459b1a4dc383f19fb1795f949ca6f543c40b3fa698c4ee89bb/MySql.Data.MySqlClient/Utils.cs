using System.IO;
using System.Reflection;
using System.Text;

namespace MySql.Data.MySqlClient;

internal class Utils
{
	public static string ReadResource(string name)
	{
		string text = ReadResourceInternal(name);
		if (text != null)
		{
			return text;
		}
		return ReadResourceInternal("MySqlClient/" + name);
	}

	public static string ReadResourceInternal(string name)
	{
		Assembly executingAssembly = Assembly.GetExecutingAssembly();
		string name2 = executingAssembly.GetName().Name + "." + name.Replace(" ", "_").Replace("\\", ".").Replace("/", ".");
		Stream manifestResourceStream = executingAssembly.GetManifestResourceStream(name2);
		if (manifestResourceStream == null)
		{
			return null;
		}
		using StreamReader streamReader = new StreamReader(manifestResourceStream, Encoding.UTF8);
		return streamReader.ReadToEnd();
	}
}
