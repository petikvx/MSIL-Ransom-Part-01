namespace SHUV_002D3.Templates;

internal class DicBroadcasterTemplate
{
	private static DicBroadcasterTemplate PatchContext;

	internal void CreateProducer()
	{
	}

	internal void InstantiateProducer()
	{
	}

	internal static bool PublishContext()
	{
		return PatchContext == null;
	}

	internal static DicBroadcasterTemplate FlushContext()
	{
		return PatchContext;
	}
}
