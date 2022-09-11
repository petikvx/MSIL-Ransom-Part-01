namespace White.Core.WindowsAPI;

public struct COLORREF
{
	public byte R;

	public byte G;

	public byte B;

	public override string ToString()
	{
		return $"R={R},G={G},B={B}";
	}
}
