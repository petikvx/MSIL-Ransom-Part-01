using System;
using NanoCore.ClientPlugin;

public sealed class GClass3
{
	public Guid guid_0;

	public string string_0;

	public IClientData iclientData_0;

	public IClientNetwork iclientNetwork_0;

	public IClientApp iclientApp_0;

	public GClass3(Guid guid_1, string string_1)
	{
		guid_0 = guid_1;
		string_0 = string_1;
	}

	public void method_0(string string_1)
	{
		if (iclientData_0 != null)
		{
			iclientData_0.VariableChanged(string_1);
		}
	}

	public void method_1(string string_1)
	{
		if (iclientData_0 != null)
		{
			iclientData_0.ClientSettingChanged(string_1);
		}
	}

	public void method_2()
	{
		if (iclientNetwork_0 != null)
		{
			iclientNetwork_0.BuildingHostCache();
		}
	}

	public void method_3(string string_1, ushort ushort_0)
	{
		if (iclientNetwork_0 != null)
		{
			iclientNetwork_0.ConnectionFailed(string_1, ushort_0);
		}
	}

	public void method_4(bool bool_0)
	{
		if (iclientNetwork_0 != null)
		{
			iclientNetwork_0.ConnectionStateChanged(bool_0);
		}
	}

	public void method_5(string string_1)
	{
		if (iclientNetwork_0 != null)
		{
			iclientNetwork_0.PipeCreated(string_1);
		}
	}

	public void method_6(string string_1)
	{
		if (iclientNetwork_0 != null)
		{
			iclientNetwork_0.PipeClosed(string_1);
		}
	}

	public void method_7(string string_1, object[] object_0)
	{
		if (iclientNetwork_0 != null)
		{
			iclientNetwork_0.ReadPacket(string_1, object_0);
		}
	}

	public void method_8()
	{
		if (iclientApp_0 != null)
		{
			iclientApp_0.PluginUninstalling();
		}
	}

	public void method_9()
	{
		if (iclientApp_0 != null)
		{
			iclientApp_0.ClientUninstalling();
		}
	}
}
