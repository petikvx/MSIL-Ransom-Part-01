namespace Ionic.Zlib;

public sealed class Adler
{
	private static readonly uint BASE;

	private static readonly int NMAX;

	public static extern uint Adler32(uint adler, byte[] buf, int index, int len);

	public extern Adler();

	static Adler()
	{
		//Discarded unreachable code: IL_0005
		/*Error: Invalid metadata token*/;
	}
}
