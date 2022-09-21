using NanoCore;
using NanoCore.ClientPluginHost;

public sealed class GClass1 : IClientDataHost
{
	public GClass3 gclass3_0;

	IClientNameObjectCollection Variables => (IClientNameObjectCollection)(object)Class8.gclass6_0;

	IClientNameObjectCollection ClientSettings => (IClientNameObjectCollection)(object)Class8.gclass6_1;

	IClientReadOnlyNameObjectCollection BuilderSettings => (IClientReadOnlyNameObjectCollection)(object)Class8.gclass8_0;

	public GClass1(GClass3 gclass3_1)
	{
		gclass3_0 = gclass3_1;
	}
}
