using System;
using System.Management;
using System.Security.Cryptography;
using System.Text;
using _003Cdion2ntty2ic0uyoe_003E_007B43570453_002D3AD8_002D4A5B_002DB273_002D83DF8156D820_007D;

namespace C3904355907;

public class C252678980
{
	public static string C3554254475()
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Expected O, but got Unknown
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Expected O, but got Unknown
		//IL_011f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0125: Expected O, but got Unknown
		//IL_013c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0143: Expected O, but got Unknown
		StringBuilder stringBuilder = new StringBuilder();
		ManagementObjectSearcher val = new ManagementObjectSearcher(DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.cU(), DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.cu());
		ManagementObjectEnumerator enumerator = val.Get().GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				ManagementObject val2 = (ManagementObject)enumerator.get_Current();
				stringBuilder.Append(((ManagementBaseObject)val2).get_Item(DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.cV()));
				stringBuilder.Append(((ManagementBaseObject)val2).get_Item(DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.cv()));
				stringBuilder.Append(((ManagementBaseObject)val2).get_Item(DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.cW()));
				stringBuilder.Append(((ManagementBaseObject)val2).get_Item(DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.cw()));
			}
		}
		finally
		{
			((IDisposable)enumerator)?.Dispose();
		}
		val = new ManagementObjectSearcher(DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.cU(), DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.cX());
		ManagementObjectEnumerator enumerator2 = val.Get().GetEnumerator();
		try
		{
			while (enumerator2.MoveNext())
			{
				ManagementObject val3 = (ManagementObject)enumerator2.get_Current();
				stringBuilder.Append(((ManagementBaseObject)val3).get_Item(DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.cx()));
				stringBuilder.Append(((ManagementBaseObject)val3).get_Item(DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.cW()));
				stringBuilder.Append(((ManagementBaseObject)val3).get_Item(DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.cY()));
			}
		}
		finally
		{
			((IDisposable)enumerator2)?.Dispose();
		}
		val = new ManagementObjectSearcher(DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.cU(), DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.cy());
		ManagementObjectEnumerator enumerator3 = val.Get().GetEnumerator();
		try
		{
			while (enumerator3.MoveNext())
			{
				ManagementObject val4 = (ManagementObject)enumerator3.get_Current();
				stringBuilder.Append(((ManagementBaseObject)val4).get_Item(DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.cZ()));
			}
		}
		finally
		{
			((IDisposable)enumerator3)?.Dispose();
		}
		byte[] bytes = Encoding.ASCII.GetBytes(stringBuilder.ToString());
		SHA256Managed sHA256Managed = new SHA256Managed();
		byte[] array = sHA256Managed.ComputeHash(bytes);
		return BitConverter.ToString(array).ToLower().Replace(DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.cg(), DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.cz());
	}

	private static string C3554254475(string string_0)
	{
		MD5 mD = new MD5CryptoServiceProvider();
		ASCIIEncoding aSCIIEncoding = new ASCIIEncoding();
		byte[] bytes = aSCIIEncoding.GetBytes(string_0);
		return C3554254475(mD.ComputeHash(bytes));
	}

	private static string C3554254475(byte[] byte_0)
	{
		string text = string.Empty;
		for (int i = 0; i < byte_0.Length; i++)
		{
			byte b = byte_0[i];
			int num = b;
			int num2 = num & 0xF;
			int num3 = (num >> 4) & 0xF;
			text = ((num3 <= 9) ? (text + num3) : (text + (char)(num3 - 10 + 65)));
			text = ((num2 <= 9) ? (text + num2) : (text + (char)(num2 - 10 + 65)));
			if (i + 1 != byte_0.Length && (i + 1) % 2 == 0)
			{
				text += DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.cg();
			}
		}
		return text;
	}

	private static string C3554254475(string string_0, string string_1)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Expected O, but got Unknown
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Expected O, but got Unknown
		string text = DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.cz();
		try
		{
			ManagementClass val = new ManagementClass(string_0);
			ManagementObjectCollection instances = val.GetInstances();
			ManagementObjectEnumerator enumerator = instances.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					ManagementObject val2 = (ManagementObject)enumerator.get_Current();
					if (text == DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.cz())
					{
						try
						{
							text = ((ManagementBaseObject)val2).get_Item(string_1).ToString();
						}
						catch (Exception)
						{
							text = DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.DA();
							continue;
						}
						break;
					}
				}
			}
			finally
			{
				((IDisposable)enumerator)?.Dispose();
			}
		}
		catch (Exception)
		{
		}
		return text;
	}
}
