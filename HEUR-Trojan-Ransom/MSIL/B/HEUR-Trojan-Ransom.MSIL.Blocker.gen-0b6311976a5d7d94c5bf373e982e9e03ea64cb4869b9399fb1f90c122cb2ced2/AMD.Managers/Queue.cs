using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Resources;
using AMD.Containers;

namespace AMD.Managers;

[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
[DebuggerNonUserCode]
internal sealed class Queue
{
	private static ResourceManager helper;

	private static CultureInfo m_Listener;

	private static Queue CountExporter;

	internal Queue()
	{
		CreatorStrategyContainer.PopCollection();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Beaae710d_002De3d8_002D46b8_002Db6da_002Dd6c3c29ddccd_007D.m_059cda777b844334968efd282ba295de != 0)
		{
			int num2 = default(int);
			num = num2;
		}
		switch (num)
		{
		}
	}

	internal static ResourceManager WriteInterpreter()
	{
		if (helper != null)
		{
			goto IL_001d;
		}
		int num = 4;
		if (_003CModule_003E_007Beaae710d_002De3d8_002D46b8_002Db6da_002Dd6c3c29ddccd_007D.m_dcd88c89e3294b8985f5f4e69eac327d != 0)
		{
			int num2 = default(int);
			num = num2;
		}
		goto IL_0056;
		IL_0056:
		ResourceManager resourceManager = default(ResourceManager);
		switch (num)
		{
		case 2:
		case 3:
			break;
		case 4:
			resourceManager = new ResourceManager("Lzzowqrhuwjro.Properties.Resources", typeof(Queue).Assembly);
			goto case 1;
		case 1:
		case 5:
			helper = resourceManager;
			break;
		default:
			goto IL_0076;
		}
		goto IL_001d;
		IL_0076:
		ResourceManager result = default(ResourceManager);
		return result;
		IL_001d:
		result = helper;
		num = 0;
		if (_003CModule_003E_007Beaae710d_002De3d8_002D46b8_002Db6da_002Dd6c3c29ddccd_007D.m_a0de9df76099407fa946191cfff5df17 != 0)
		{
			goto IL_0056;
		}
		goto IL_0076;
	}

	internal static CultureInfo ReadInterpreter()
	{
		CultureInfo listener = m_Listener;
		if (_003CModule_003E_007Beaae710d_002De3d8_002D46b8_002Db6da_002Dd6c3c29ddccd_007D.m_a687724ef1a0499e900512d92ebc800c == 0)
		{
			switch (0)
			{
			}
		}
		return listener;
	}

	internal static void ResetInterpreter(CultureInfo asset)
	{
		m_Listener = asset;
		if (_003CModule_003E_007Beaae710d_002De3d8_002D46b8_002Db6da_002Dd6c3c29ddccd_007D.m_d8d618b498234f1290804a6b43c437d3 == 0)
		{
			switch (0)
			{
			}
		}
	}

	internal static Icon VerifyInterpreter()
	{
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Expected O, but got Unknown
		int num = 2;
		while (true)
		{
			object @object = ((ResourceManager)CancelExporter()).GetObject("Spotify", m_Listener);
			int num2 = 0;
			if (_003CModule_003E_007Beaae710d_002De3d8_002D46b8_002Db6da_002Dd6c3c29ddccd_007D.m_e60d090d0d2c4a87bbc74de8a414e392 == 0)
			{
				num2 = num;
			}
			switch (num2)
			{
			case 2:
				continue;
			}
			return (Icon)@object;
		}
	}

	internal static Icon PushInterpreter()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected O, but got Unknown
		while (true)
		{
			object @object = WriteInterpreter().GetObject("xmrig", m_Listener);
			while (true)
			{
				Icon result = (Icon)@object;
				if (_003CModule_003E_007Beaae710d_002De3d8_002D46b8_002Db6da_002Dd6c3c29ddccd_007D.m_3b836e45f2e94792a88b5ddb4836d1a8 != 0)
				{
					switch (0)
					{
					case 1:
						break;
					case 2:
						goto end_IL_0003;
					default:
						goto IL_0044;
					}
					continue;
				}
				goto IL_0044;
				IL_0044:
				return result;
				continue;
				end_IL_0003:
				break;
			}
		}
	}

	internal static bool PostExporter()
	{
		return CountExporter == null;
	}

	internal static Queue PrintExporter()
	{
		return CountExporter;
	}

	internal static object CancelExporter()
	{
		return WriteInterpreter();
	}
}
