using System.IO;
using System.Threading;
using Shell32;

namespace ns0;

internal class Class4
{
	private bool method_0(string string_0, string string_1)
	{
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Expected O, but got Unknown
		byte[] array = new byte[24]
		{
			80, 75, 5, 6, 0, 0, 0, 0, 0, 0,
			0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
			0, 0, 0, 0
		};
		FileStream fileStream = File.Create(string_1);
		fileStream.Write(array, 0, array.Length);
		fileStream.Flush();
		fileStream.Close();
		fileStream = null;
		ShellClass val = new ShellClass();
		Folder val2 = val.NameSpace((object)string_0);
		Folder val3 = val.NameSpace((object)string_1);
		FolderItems val4 = val2.Items();
		val3.CopyHere((object)val4, (object)20);
		Thread.Sleep(1000);
		return true;
	}
}
