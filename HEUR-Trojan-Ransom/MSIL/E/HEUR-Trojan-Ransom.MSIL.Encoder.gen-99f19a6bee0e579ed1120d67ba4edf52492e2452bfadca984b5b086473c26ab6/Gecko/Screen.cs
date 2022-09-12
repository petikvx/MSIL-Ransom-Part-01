namespace Gecko;

public sealed class Screen
{
	private readonly nsIScreen _screen;

	public int ColorDepth => _screen.GetColorDepthAttribute();

	public int PixelDepth => _screen.GetPixelDepthAttribute();

	public Screen(nsIScreen screen)
	{
		_screen = screen;
	}
}
