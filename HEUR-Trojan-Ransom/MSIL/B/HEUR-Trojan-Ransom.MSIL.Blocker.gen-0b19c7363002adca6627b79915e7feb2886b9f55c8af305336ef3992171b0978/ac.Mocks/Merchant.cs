using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Globalization;
using System.Resources;

namespace ac.Mocks;

[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
[DebuggerNonUserCode]
internal sealed class Merchant
{
	private static ResourceManager _Customer;

	private static CultureInfo _Adapter;

	internal static Merchant ChangeDic;

	internal Merchant()
	{
		if (_003CModule_003E_007B97c19ca2_002Dd30d_002D4926_002Db319_002D0f9297a6a699_007D.m_1ab4802455a04df097e1c71b73e237b2 != 0)
		{
			switch (0)
			{
			}
		}
	}

	internal static ResourceManager RestartMerchant()
	{
		if (_Customer == null)
		{
			_Customer = new ResourceManager("Tsjxretch.Properties.Resources", typeof(Merchant).Assembly);
		}
		return _Customer;
	}

	internal static CultureInfo PatchMerchant()
	{
		return _Adapter;
	}

	internal static void WriteMerchant(CultureInfo asset)
	{
		_Adapter = asset;
	}

	internal static byte[] FindMerchant()
	{
		return (byte[])RestartMerchant().GetObject("Pwizmylqnpqkwakaslbasrx", _Adapter);
	}

	internal static bool ConnectDic()
	{
		return ChangeDic == null;
	}

	internal static Merchant PrepareDic()
	{
		return ChangeDic;
	}
}
