using System;
using System.Linq;
using System.Management;

namespace Main;

public class Class1
{
	public string GetHwid()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		ManagementObjectCollection obj = new ManagementObjectSearcher("Select ProcessorId From Win32_processor").Get();
		string result = "";
		ManagementObjectEnumerator enumerator = obj.GetEnumerator();
		try
		{
			if (enumerator.MoveNext())
			{
				return ((ManagementBaseObject)(ManagementObject)enumerator.get_Current()).get_Item("ProcessorId").ToString();
			}
			return result;
		}
		finally
		{
			((IDisposable)enumerator)?.Dispose();
		}
	}

	public string MakePass()
	{
		Random num = new Random();
		string text = new string((from s in GetHwid().ToCharArray()
			orderby num.Next(2) % 2 == 0
			select s).ToArray());
		string machineName = Environment.MachineName;
		new Random();
		string text2 = new string((from s in machineName.ToCharArray()
			orderby num.Next(2) % 2 == 0
			select s).ToArray());
		string text3 = text + text2;
		new Random();
		return new string((from s in text3.ToCharArray()
			orderby num.Next(2) % 2 == 0
			select s).ToArray());
	}
}
