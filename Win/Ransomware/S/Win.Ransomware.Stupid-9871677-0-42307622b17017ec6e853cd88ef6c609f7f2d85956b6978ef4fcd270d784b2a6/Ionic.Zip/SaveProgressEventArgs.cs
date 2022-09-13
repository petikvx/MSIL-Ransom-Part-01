using System;

namespace Ionic.Zip;

public class SaveProgressEventArgs : ZipProgressEventArgs
{
	private int _entriesSaved;

	public extern int EntriesSaved { get; }

	internal extern SaveProgressEventArgs(string archiveName, bool before, int entriesTotal, int entriesSaved, ZipEntry entry);

	internal SaveProgressEventArgs()
	{
		//Discarded unreachable code: IL_000a, IL_0013
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected I4, but got Unknown
		byte num = checked((byte)/*Error near IL_0001: ldloc 3 (out-of-bounds)*/);
		_ = (long)checked(/*Error near IL_0006: Stack underflow*/ - num);
		/*Error near IL_0009: Unknown opcode: 0xFB*/;
	}

	internal extern SaveProgressEventArgs(string archiveName, ZipProgressEventType flavor);

	internal unsafe static SaveProgressEventArgs ByteUpdate(string archiveName, ZipEntry entry, long bytesXferred, long totalBytes)
	{
		throw (uint)checked((short)(*unchecked((int*)(nint)/*Error near IL_0001: Stack underflow*/)));
	}

	internal static extern SaveProgressEventArgs Started(string archiveName);

	internal static SaveProgressEventArgs Completed(string archiveName)
	{
		//Discarded unreachable code: IL_000a, IL_000c, IL_0011, IL_0019, IL_001f, IL_0028
		//IL_000a: Incompatible stack heights: 2 vs 0
		//IL_000c: Incompatible stack heights: 0 vs 1
		//IL_001a: Invalid comparison between Unknown and I8
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		_ = ((IntPtr[])/*Error: Stack underflow*/)[checked((nuint)/*Error near IL_0001: ldloc 2 (out-of-bounds)*/)];
		/*Error near IL_0005: Invalid metadata token*/;
	}
}
