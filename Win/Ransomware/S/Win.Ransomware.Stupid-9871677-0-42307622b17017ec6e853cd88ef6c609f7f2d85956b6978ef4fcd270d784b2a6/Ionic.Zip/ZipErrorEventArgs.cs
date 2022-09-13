using System;

namespace Ionic.Zip;

public class ZipErrorEventArgs : ZipProgressEventArgs
{
	private Exception _exc;

	public unsafe Exception Exception
	{
		get
		{
			//Discarded unreachable code: IL_000c, IL_0018
			//IL_0013: Incompatible stack heights: 0 vs 2
			while (/*Error near IL_0005: Stack underflow*/ != /*Error near IL_0005: Stack underflow*/)
			{
			}
			*(sbyte*)(nint)/*Error near IL_0007: Stack underflow*/ = 2;
			/*Error near IL_0007: Invalid metadata token*/;
		}
	}

	public extern string FileName { get; }

	private extern ZipErrorEventArgs();

	internal static extern ZipErrorEventArgs Saving(string archiveName, ZipEntry entry, Exception exception);
}
