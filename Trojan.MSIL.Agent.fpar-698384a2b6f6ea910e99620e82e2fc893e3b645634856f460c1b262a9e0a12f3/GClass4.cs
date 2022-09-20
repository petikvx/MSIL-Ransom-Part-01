using System;
using NanoCore.ClientPluginHost;

public sealed class GClass4 : IClientNetworkHost
{
	public GClass3 gclass3_0;

	bool Connected => Class8.client_0.method_35();

	public GClass4(GClass3 gclass3_1)
	{
		gclass3_0 = gclass3_1;
	}

	public void ClosePipe(string string_0)
	{
		if (Class8.dictionary_2.ContainsKey(string_0))
		{
			Class8.dictionary_2[string_0].method_56();
		}
	}

	public bool PipeExists(string string_0)
	{
		return Class8.dictionary_2.ContainsKey(string_0);
	}

	public void Disconnect()
	{
		Class8.client_0.method_56();
	}

	public void SendToServer(string string_0, bool bool_0, params object[] object_0)
	{
		if (object_0 == null)
		{
			Class8.smethod_85(gclass3_0, new Exception("One or more parameters are null."), "SendToServer");
			return;
		}
		Client client_ = Class8.client_0;
		if (!string.IsNullOrEmpty(string_0))
		{
			if (!Class8.dictionary_2.ContainsKey(string_0))
			{
				return;
			}
			client_ = Class8.dictionary_2[string_0];
		}
		Class8.smethod_89(client_, bool_0, CommandType.BaseCommand, 4, gclass3_0.guid_0, object_0);
	}

	public void AddHostEntry(string string_0)
	{
		Class8.smethod_64(string_0);
	}

	public void RebuildHostCache()
	{
		Class8.smethod_63();
	}
}
