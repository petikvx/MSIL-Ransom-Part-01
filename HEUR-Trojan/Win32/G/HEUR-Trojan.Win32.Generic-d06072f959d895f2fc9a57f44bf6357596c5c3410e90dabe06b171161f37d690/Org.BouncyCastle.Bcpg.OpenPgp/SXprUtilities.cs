using System.IO;
using Org.BouncyCastle.Utilities.IO;

namespace Org.BouncyCastle.Bcpg.OpenPgp;

public sealed class SXprUtilities
{
	private class MyS2k : S2k
	{
		private readonly long mIterationCount64;

		public override long IterationCount => mIterationCount64;

		internal MyS2k(HashAlgorithmTag algorithm, byte[] iv, long iterationCount64)
			: base(algorithm, iv, (int)iterationCount64)
		{
			mIterationCount64 = iterationCount64;
		}
	}

	private SXprUtilities()
	{
	}

	private static int ReadLength(Stream input, int ch)
	{
		int num = ch - 48;
		while ((ch = input.ReadByte()) >= 0 && ch != 58)
		{
			num = num * 10 + ch - 48;
		}
		return num;
	}

	internal static string ReadString(Stream input, int ch)
	{
		char[] array = new char[ReadLength(input, ch)];
		for (int i = 0; i != array.Length; i++)
		{
			array[i] = (char)input.ReadByte();
		}
		return new string(array);
	}

	internal static byte[] ReadBytes(Stream input, int ch)
	{
		byte[] array = new byte[ReadLength(input, ch)];
		Streams.ReadFully(input, array);
		return array;
	}

	internal static S2k ParseS2k(Stream input)
	{
		SkipOpenParenthesis(input);
		ReadString(input, input.ReadByte());
		byte[] iv = ReadBytes(input, input.ReadByte());
		long iterationCount = long.Parse(ReadString(input, input.ReadByte()));
		SkipCloseParenthesis(input);
		return new MyS2k(HashAlgorithmTag.Sha1, iv, iterationCount);
	}

	internal static void SkipOpenParenthesis(Stream input)
	{
		if (input.ReadByte() != 40)
		{
			throw new IOException("unknown character encountered");
		}
	}

	internal static void SkipCloseParenthesis(Stream input)
	{
		if (input.ReadByte() != 41)
		{
			throw new IOException("unknown character encountered");
		}
	}
}
