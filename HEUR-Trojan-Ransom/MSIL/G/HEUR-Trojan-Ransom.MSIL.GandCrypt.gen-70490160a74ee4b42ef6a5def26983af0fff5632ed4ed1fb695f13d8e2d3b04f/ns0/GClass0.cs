using System;
using System.Xml;

namespace ns0;

public class GClass0 : XmlNameTable
{
	private sealed class Entry
	{
		internal string str;

		internal int hashCode;

		internal Entry next;

		internal Entry(string str, int hashCode, Entry next)
		{
			this.str = str;
			this.hashCode = hashCode;
			this.next = next;
		}
	}

	private int int_0;

	private int int_1;

	private int int_2;

	private ulong ulong_0;

	internal Entry[] E;

	public GClass0()
	{
		int_1 = 31;
		Entry[] array = (E = new Entry[int_1 + 1]);
	}

	public override string vmethod_0(string string_0)
	{
		if (string_0 == null)
		{
			throw GClass0.gsDjFsVGNUUVCEAoTzLsFYBboKWl("");
		}
		if (GClass0.rxyDdiloYIGwqIKwgqJPGnTKXCPd(string_0) == 0)
		{
			return string.Empty;
		}
		int num = method_2(string_0);
		Entry[] e = E;
		int num2 = int_1;
		Class0.char_0[435] = (char)((Class0.char_0[435] ^ Class0.char_0[222]) & '\u008e');
		Entry entry = e[num & num2];
		while (true)
		{
			if (entry != null)
			{
				if (entry.hashCode == num && GClass0.AOUOwheZWiGhEvjSmaarcwhjeVxC(entry.str, string_0))
				{
					break;
				}
				entry = entry.next;
				continue;
			}
			return method_0(string_0, num);
		}
		return entry.str;
	}

	public override string vmethod_1(char[] char_0, int int_3, int int_4)
	{
		if (int_4 == 0)
		{
			return string.Empty;
		}
		if (int_3 < char_0.Length && int_3 >= 0 && (long)int_3 + (long)int_4 <= char_0.Length)
		{
			if (int_4 < 0)
			{
				throw GClass0.YydKvpNEofQtQZLWMuEKSAoCIVfBA();
			}
			int num = method_3(char_0, int_3, int_4);
			Entry entry = E[num & int_1];
			while (true)
			{
				if (entry != null)
				{
					if (entry.hashCode == num && smethod_0(entry.str, char_0, int_3, int_4))
					{
						break;
					}
					entry = entry.next;
					continue;
				}
				return method_0(GClass0.sQBOQXmSQMDpGPYAnvlydTvfzmEh(char_0, int_3, int_4), num);
			}
			return entry.str;
		}
		throw GClass0.HoHAeaMZSRqjiXWmvmXXHgOxIORv();
	}

	public override string vmethod_2(string string_0)
	{
		if (string_0 == null)
		{
			throw GClass0.gsDjFsVGNUUVCEAoTzLsFYBboKWl("");
		}
		if (GClass0.rxyDdiloYIGwqIKwgqJPGnTKXCPd(string_0) == 0)
		{
			return string.Empty;
		}
		int num = method_2(string_0);
		Entry entry = E[num & int_1];
		while (true)
		{
			if (entry != null)
			{
				if (entry.hashCode == num && GClass0.AOUOwheZWiGhEvjSmaarcwhjeVxC(entry.str, string_0))
				{
					break;
				}
				entry = entry.next;
				continue;
			}
			return null;
		}
		return entry.str;
	}

	public override string vmethod_3(char[] char_0, int int_3, int int_4)
	{
		if (int_4 == 0)
		{
			return string.Empty;
		}
		if (int_3 < char_0.Length && int_3 >= 0 && (long)int_3 + (long)int_4 <= char_0.Length)
		{
			if (int_4 < 0)
			{
				return null;
			}
			int num = method_3(char_0, int_3, int_4);
			Entry entry = E[num & int_1];
			while (true)
			{
				if (entry != null)
				{
					if (entry.hashCode == num && smethod_0(entry.str, char_0, int_3, int_4))
					{
						break;
					}
					entry = entry.next;
					continue;
				}
				return null;
			}
			return entry.str;
		}
		throw GClass0.HoHAeaMZSRqjiXWmvmXXHgOxIORv();
	}

	private string method_0(string string_0, int int_3)
	{
		int num = int_3 & int_1;
		Entry entry = new Entry(string_0, int_3, E[num]);
		E[num] = entry;
		if (int_0++ == int_1)
		{
			method_1();
		}
		string str = entry.str;
		Class0.char_0[110] = (char)((Class0.char_0[110] ^ Class6.int_0[396]) & '§');
		return str;
	}

	private void method_1()
	{
		int num = int_1;
		Class0.char_0[368] = (char)((Class0.char_0[368] * Class0.char_0[165]) & '\u0011');
		int num2 = num * 2 + 1;
		Entry[] e = E;
		Entry[] array = new Entry[num2 + 1];
		Entry[] array2 = e;
		foreach (Entry entry in array2)
		{
			while (entry != null)
			{
				int num3 = entry.hashCode & num2;
				entry.next = array[num3];
				array[num3] = entry;
			}
		}
		Entry[] array3 = (E = array);
		int_1 = num2;
	}

	private static bool smethod_0(string string_0, char[] char_0, int int_3, int int_4)
	{
		if (GClass0.rxyDdiloYIGwqIKwgqJPGnTKXCPd(string_0) != int_4)
		{
			return false;
		}
		int num = 0;
		while (true)
		{
			if (num < GClass0.rxyDdiloYIGwqIKwgqJPGnTKXCPd(string_0))
			{
				if (GClass0.xvpEzcjEnriViSQxNAQcrgnJFWab(string_0, num) != char_0[int_3 + num])
				{
					break;
				}
				num++;
				continue;
			}
			return true;
		}
		return false;
	}

	private int method_2(string string_0)
	{
		return 0;
	}

	private int method_3(char[] char_0, int int_3, int int_4)
	{
		return 0;
	}

	static Type PEMBGPAWIsDMOcIvjohSqTQAiHPTB(RuntimeTypeHandle runtimeTypeHandle_0)
	{
		return Type.GetTypeFromHandle(runtimeTypeHandle_0);
	}

	static ArgumentNullException gsDjFsVGNUUVCEAoTzLsFYBboKWl(string string_0)
	{
		return new ArgumentNullException(string_0);
	}

	static int rxyDdiloYIGwqIKwgqJPGnTKXCPd(string string_0)
	{
		return string_0.Length;
	}

	static bool AOUOwheZWiGhEvjSmaarcwhjeVxC(string string_0, string string_1)
	{
		return string_0.Equals(string_1);
	}

	static IndexOutOfRangeException HoHAeaMZSRqjiXWmvmXXHgOxIORv()
	{
		return new IndexOutOfRangeException();
	}

	static ArgumentOutOfRangeException YydKvpNEofQtQZLWMuEKSAoCIVfBA()
	{
		return new ArgumentOutOfRangeException();
	}

	static string sQBOQXmSQMDpGPYAnvlydTvfzmEh(char[] char_0, int int_3, int int_4)
	{
		return new string(char_0, int_3, int_4);
	}

	static char xvpEzcjEnriViSQxNAQcrgnJFWab(string string_0, int int_3)
	{
		return string_0[int_3];
	}
}
