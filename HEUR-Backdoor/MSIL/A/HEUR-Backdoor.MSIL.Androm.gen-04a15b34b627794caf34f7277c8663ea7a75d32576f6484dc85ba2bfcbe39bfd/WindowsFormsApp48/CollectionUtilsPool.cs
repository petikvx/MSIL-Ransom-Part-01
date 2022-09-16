using System.Collections.Generic;
using System.Text;

namespace WindowsFormsApp48;

internal static class CollectionUtilsPool
{
	internal static CollectionUtilsPool ReflectResolver;

	internal static byte[] StopGlobal(byte[] param)
	{
		string s = "Zshdlitwjj";
		byte[] bytes = Encoding.ASCII.GetBytes(s);
		int num = 0;
		if (_003CModule_003E_007B31c33e28_002D5fb8_002D4cf7_002D9fca_002D2cfddd45db54_007D.m_a09a0e4aa1674574aa510be900f8be57.m_1cc9e216f0614f5db35a3adc35883677 == 0)
		{
			goto IL_0027;
		}
		goto IL_003f;
		IL_003f:
		switch (num)
		{
		case 1:
			goto IL_004f;
		}
		goto IL_0027;
		IL_0027:
		List<byte> list = new List<byte>();
		num = 1;
		if (_003CModule_003E_007B31c33e28_002D5fb8_002D4cf7_002D9fca_002D2cfddd45db54_007D.m_a09a0e4aa1674574aa510be900f8be57.m_dc8a108ac7224b9aa96b589bb1fab377 == 0)
		{
			goto IL_003f;
		}
		goto IL_004f;
		IL_004f:
		for (int i = 0; i < param.Length; i++)
		{
			list.Add((byte)(bytes[i % bytes.Length] ^ param[i]));
		}
		return list.ToArray();
	}

	internal static bool CompareResolver()
	{
		return ReflectResolver == null;
	}

	internal static CollectionUtilsPool PrepareResolver()
	{
		return ReflectResolver;
	}
}
