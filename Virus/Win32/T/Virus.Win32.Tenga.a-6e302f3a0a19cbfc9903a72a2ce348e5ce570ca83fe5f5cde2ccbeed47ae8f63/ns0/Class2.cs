using System.IO;

namespace ns0;

internal class Class2
{
	public static void smethod_0()
	{
		if (File.Exists(Directory.GetCurrentDirectory() + "\\ServerCNAS.bat") && !Class3.smethod_0(Directory.GetCurrentDirectory() + "\\ServerCNAS.bat"))
		{
			using (StreamWriter streamWriter = new StreamWriter(Directory.GetCurrentDirectory() + "\\ServerCNAS.bat"))
			{
				streamWriter.WriteLine("if exist ..\\APP\\serverCnas.exe (");
				streamWriter.WriteLine("copy ..\\APP\\ServerCnas.exe .");
				streamWriter.WriteLine(")");
				streamWriter.WriteLine("if exist ..\\APP\\ICSharpCode.SharpZipLib.dll (");
				streamWriter.WriteLine("copy ..\\APP\\ICSharpCode.SharpZipLib.dll .");
				streamWriter.WriteLine(")");
				streamWriter.WriteLine("if exist .\\serverCnas.exe (");
				streamWriter.WriteLine("start ServerCnas.exe");
				streamWriter.WriteLine(")");
				streamWriter.Flush();
			}
		}
	}
}
