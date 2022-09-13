using System.IO;

namespace Ionic.Zlib;

internal class SharedUtils
{
	public static extern int URShift(int number, int bits);

	public static extern int ReadInput(TextReader sourceTextReader, byte[] target, int start, int count);

	internal static extern byte[] ToByteArray(string sourceString);

	internal static extern char[] ToCharArray(byte[] byteArray);

	public extern SharedUtils();
}
