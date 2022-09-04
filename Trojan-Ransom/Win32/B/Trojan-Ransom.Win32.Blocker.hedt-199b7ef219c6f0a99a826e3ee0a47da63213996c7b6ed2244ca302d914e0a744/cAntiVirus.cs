using System;
using System.Management;

internal class cAntiVirus
{
	public static string Antivirus(string type)
	{
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Expected O, but got Unknown
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected O, but got Unknown
		string text = null;
		string machineName = Environment.MachineName;
		string text2 = "\\\\" + machineName + "\\root\\SecurityCenter";
		try
		{
			ManagementObjectSearcher val = new ManagementObjectSearcher(text2, "SELECT * FROM AntivirusProduct");
			ManagementObjectCollection val2 = val.Get();
			ManagementObjectEnumerator enumerator = val2.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					ManagementObject val3 = (ManagementObject)enumerator.get_Current();
					text = ((ManagementBaseObject)val3).get_Item(type).ToString();
				}
			}
			finally
			{
				((IDisposable)enumerator)?.Dispose();
			}
			if (text == null)
			{
				text = "noAntivirus";
			}
			return text;
		}
		catch
		{
			return "noAntivirus";
		}
	}
}
