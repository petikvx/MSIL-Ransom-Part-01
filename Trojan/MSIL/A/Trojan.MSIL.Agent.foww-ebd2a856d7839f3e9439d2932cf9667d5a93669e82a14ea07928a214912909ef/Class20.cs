using xClient.Core.MouseKeyHook.Implementation;

internal class Class20 : EventFacade
{
	protected override MouseListener CreateMouseListener()
	{
		return new Class17();
	}

	protected override KeyListener CreateKeyListener()
	{
		return new Class15();
	}
}
