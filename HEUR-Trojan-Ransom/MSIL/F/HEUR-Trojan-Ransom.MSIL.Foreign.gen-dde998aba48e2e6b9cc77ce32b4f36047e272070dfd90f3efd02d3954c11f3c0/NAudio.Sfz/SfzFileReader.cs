using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace NAudio.Sfz;

internal sealed class SfzFileReader
{
	[NonSerialized]
	internal static GetString _0089;

	public SfzFileReader(string fileName)
	{
		new StringBuilder();
		using StreamReader streamReader = new StreamReader(fileName);
		List<Region> list = new List<Region>();
		Region region = null;
		StringBuilder stringBuilder = new StringBuilder();
		StringBuilder stringBuilder2 = new StringBuilder();
		int num = 0;
		string text;
		while ((text = streamReader.ReadLine()) != null)
		{
			num++;
			int num2 = text.IndexOf('/');
			if (num2 != -1)
			{
				text = text.Substring(num2);
			}
			for (int i = 0; i < text.Length; i++)
			{
				char c = text[i];
				if (char.IsWhiteSpace(c))
				{
					if (stringBuilder.Length != 0)
					{
						if (stringBuilder2.Length == 0)
						{
							throw new FormatException(string.Format(_0089(107393276), num, i));
						}
						stringBuilder2.Append(c);
					}
				}
				else
				{
					if (c == '=' || c != '<')
					{
						continue;
					}
					if (text.Substring(i).StartsWith(_0089(107393767)))
					{
						if (region != null)
						{
							list.Add(region);
						}
						region = new Region();
						stringBuilder.Length = 0;
						stringBuilder2.Length = 0;
						i += 7;
						continue;
					}
					if (!text.Substring(i).StartsWith(_0089(107393722)))
					{
						throw new FormatException(string.Format(_0089(107393741), num, i));
					}
					if (region != null)
					{
						list.Add(region);
					}
					stringBuilder.Length = 0;
					stringBuilder2.Length = 0;
					region = null;
					new Group();
					i += 6;
				}
			}
		}
	}

	static SfzFileReader()
	{
		Strings.CreateGetStringDelegate(typeof(SfzFileReader));
		bool flag = false;
		Assembly assembly = global::_0005._001B();
		Uri uri = new Uri(_0007._007E_0087(_0007._007E_0087(_0006._007E_001C(assembly), _0089(107397473), _0089(107397436)), _0089(107397431), _0089(107397426)));
		if (StrongNameSignatureVerificationEx(_0006._007E_001D(uri), true, out flag) && flag && global::_0008._007E_0088(_0006._007E_001E(assembly), _0089(107397453)))
		{
			return;
		}
		throw new SecurityException(_0089(107397396));
	}

	[DllImport("mscorwks.dll", CharSet = CharSet.Unicode)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool StrongNameSignatureVerificationEx([MarshalAs(UnmanagedType.LPWStr)] string P_0, [MarshalAs(UnmanagedType.Bool)] bool P_1, [MarshalAs(UnmanagedType.Bool)] out bool P_2);
}
