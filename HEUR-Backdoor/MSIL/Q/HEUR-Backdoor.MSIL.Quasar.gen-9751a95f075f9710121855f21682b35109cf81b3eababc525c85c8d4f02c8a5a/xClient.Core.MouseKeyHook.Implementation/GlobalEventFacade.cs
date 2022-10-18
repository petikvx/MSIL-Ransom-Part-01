namespace xClient.Core.MouseKeyHook.Implementation;

internal class GlobalEventFacade : EventFacade
{
	protected override MouseListener CreateMouseListener()
	{
		return new GlobalMouseListener();
	}

	protected override KeyListener CreateKeyListener()
	{
		return new GlobalKeyListener();
	}
}
