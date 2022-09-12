using System.IO;
using System.Runtime.CompilerServices;

namespace s0s_L_ckr;

public sealed class FileMgr
{
	private FileMgr()
	{
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void ReadFil(FileInfo file, ref byte[] fileDat)
	{
		using FileStream fileStream = File.OpenRead(file.FullName);
		fileDat = new byte[fileStream.Length];
		fileStream.Read(fileDat, 0, fileDat.Length);
	}
}
