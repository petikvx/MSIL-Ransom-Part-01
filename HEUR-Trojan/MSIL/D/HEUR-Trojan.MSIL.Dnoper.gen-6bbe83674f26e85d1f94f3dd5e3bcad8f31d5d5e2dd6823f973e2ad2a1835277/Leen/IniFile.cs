using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;

namespace Leen;

internal class IniFile
{
	private string Path;

	private string EXE = Assembly.GetExecutingAssembly().GetName().Name;

	[DllImport("kernel32", CharSet = CharSet.Unicode)]
	private static extern long WritePrivateProfileString(string Section, string Key, string Value, string FilePath);

	[DllImport("kernel32", CharSet = CharSet.Unicode)]
	private static extern int GetPrivateProfileString(string Section, string Key, string Default, StringBuilder RetVal, int Size, string FilePath);

	public IniFile(string IniPath = null)
	{
		Path = new FileInfo(IniPath).FullName;
	}

	public string Read(string Key, string Section = null)
	{
		StringBuilder stringBuilder = new StringBuilder(255);
		GetPrivateProfileString(Section ?? EXE, Key, "", stringBuilder, 255, Path);
		return stringBuilder.ToString();
	}

	public void Write(string Key, string Value, string Section = null)
	{
		WritePrivateProfileString(Section ?? EXE, Key, Value, Path);
	}

	public void DeleteKey(string Key, string Section = null)
	{
		Write(Key, null, Section ?? EXE);
	}

	public void DeleteSection(string Section = null)
	{
		Write(null, null, Section ?? EXE);
	}

	public bool KeyExists(string Key, string Section = null)
	{
		return Read(Key, Section).Length > 0;
	}
}
