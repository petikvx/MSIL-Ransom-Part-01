namespace Orcus.Native.Shell;

internal struct NativeSize
{
	private int width;

	private int height;

	public int Width
	{
		set
		{
			width = value;
		}
	}

	public int Height
	{
		set
		{
			height = value;
		}
	}
}
