using System;
using System.Linq;
using System.Management;
using System.Runtime.CompilerServices;

namespace ns2;

public class GClass210
{
	[CompilerGenerated]
	private sealed class Class2
	{
		public Random random_0;

		internal bool method_0(char char_0)
		{
			return random_0.Next(2) % 2 == 0;
		}

		internal bool method_1(char char_0)
		{
			return random_0.Next(2) % 2 == 0;
		}

		internal bool method_2(char char_0)
		{
			return random_0.Next(2) % 2 == 0;
		}
	}

	public string method_0()
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		ManagementObjectCollection obj = new ManagementObjectSearcher(GClass211.smethod_0("tŃɉ\u0341рՖ\u0601ݰ\u086dॱ\u0a7e\u0b79౨൩\u0e76ཪ\u105eᅲስፒᑡᕽᙼᜰᡘᥧ\u1a63\u1b3f\u1c39ᵕṹὺ\u2068Ⅵ≠⍷⑰╭♳")).Get();
		string result = GClass211.smethod_0("");
		ManagementObjectEnumerator enumerator = obj.GetEnumerator();
		try
		{
			if (enumerator.MoveNext())
			{
				return ((ManagementBaseObject)(ManagementObject)enumerator.get_Current()).get_Item(GClass211.smethod_0("[Ÿɦ\u036bѢյٶݫ\u0871\u094b\u0a65")).ToString();
			}
			return result;
		}
		finally
		{
			((IDisposable)enumerator)?.Dispose();
		}
	}

	public string method_1()
	{
		Random random_0 = new Random();
		string text = new string((from char_0 in method_0().ToCharArray()
			orderby random_0.Next(2) % 2 == 0
			select char_0).ToArray());
		string machineName = Environment.MachineName;
		new Random();
		string text2 = new string((from char_0 in machineName.ToCharArray()
			orderby random_0.Next(2) % 2 == 0
			select char_0).ToArray());
		string text3 = text + text2;
		new Random();
		return new string((from char_0 in text3.ToCharArray()
			orderby random_0.Next(2) % 2 == 0
			select char_0).ToArray());
	}
}
