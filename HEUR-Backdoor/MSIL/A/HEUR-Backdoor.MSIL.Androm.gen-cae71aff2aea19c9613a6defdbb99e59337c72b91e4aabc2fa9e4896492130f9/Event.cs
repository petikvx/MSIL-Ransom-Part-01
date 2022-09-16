using System;
using System.Reflection;

internal sealed class Event
{
	internal static Event TestMapping;

	public Event()
	{
		if (_003CModule_003E_007B384aa0ca_002D0a36_002D4b74_002D82c1_002D2fa89a3d3234_007D.m_ddd0318a030847df8f601026ee846780.m_9a663c2eb73645aa9891939951dbfa9e == 0)
		{
			switch (0)
			{
			}
		}
	}

	internal void AwakeEvent()
	{
		MethodInfo method = new StateExporterFilter().SetEvent();
		int num = 0;
		if (_003CModule_003E_007B384aa0ca_002D0a36_002D4b74_002D82c1_002D2fa89a3d3234_007D.m_ddd0318a030847df8f601026ee846780.m_b5a3b2337f6949b8a4da832d03f180e0 == 0)
		{
			goto IL_001e;
		}
		goto IL_004a;
		IL_004a:
		switch (num)
		{
		case 2:
			break;
		default:
			return;
		case 0:
		case 1:
			return;
		}
		goto IL_001e;
		IL_001e:
		CollectMapping((Action)Delegate.CreateDelegate(InsertMapping(typeof(Action).TypeHandle), method));
		num = 1;
		if (_003CModule_003E_007B384aa0ca_002D0a36_002D4b74_002D82c1_002D2fa89a3d3234_007D.m_ddd0318a030847df8f601026ee846780.m_aa75e9124d5541b08c5d005d97f88e3a == 0)
		{
			return;
		}
		goto IL_004a;
	}

	internal static bool ConnectMapping()
	{
		return TestMapping == null;
	}

	internal static Event ReadMapping()
	{
		return TestMapping;
	}

	internal static Type InsertMapping(RuntimeTypeHandle runtimeTypeHandle_0)
	{
		return Type.GetTypeFromHandle(runtimeTypeHandle_0);
	}

	internal static void CollectMapping(object object_0)
	{
		object_0();
	}
}
