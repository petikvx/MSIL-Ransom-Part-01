namespace VanillaStub.Helpers.Services.StreamLibrary.src;

public class ArrayOffset
{
	public int BeginOffset { get; }

	public int EndOffset { get; }

	public int Stride { get; }

	public int X { get; }

	public int Y { get; }

	public int Width { get; }

	public int Height { get; }

	public ArrayOffset(int begin, int end, int Stride, int x, int y, int width, int height)
	{
		BeginOffset = begin;
		EndOffset = end;
		this.Stride = Stride;
		X = x;
		Y = y;
		Width = width;
		Height = height;
	}
}
