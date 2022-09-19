using xClient.Core.MouseKeyHook.Implementation;

internal class Class21 : EventFacade
{
	protected override MouseListener CreateMouseListener()
	{
		return new Class18();
	}

	protected override KeyListener CreateKeyListener()
	{
		return new Class16();
	}
}
