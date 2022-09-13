using System;

namespace Ionic.Zip;

public class ExtractProgressEventArgs : ZipProgressEventArgs
{
	private int _entriesExtracted;

	private string _target;

	public int EntriesExtracted
	{
		get
		{
			//IL_0003: Unknown result type (might be due to invalid IL or missing references)
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			int num = (int)/*Error near IL_0001: Stack underflow*/;
			((IntPtr[])/*Error near IL_0003: Stack underflow*/)[/*Error near IL_0003: Stack underflow*/] = (IntPtr)num;
			checked
			{
				_003F val = /*Error near IL_0004: Stack underflow*/- /*Error near IL_0004: Stack underflow*/;
				short num2 = ((short[])/*Error near IL_0006: Stack underflow*/)[val];
				_ = /*Error near IL_0007: Stack underflow*/+ num2;
				/*Error near IL_0007: Invalid metadata token*/;
			}
		}
	}

	public extern string ExtractLocation { get; }

	internal extern ExtractProgressEventArgs(string archiveName, bool before, int entriesTotal, int entriesExtracted, ZipEntry entry, string extractLocation);

	internal extern ExtractProgressEventArgs(string archiveName, ZipProgressEventType flavor);

	internal ExtractProgressEventArgs()
	{
		//Discarded unreachable code: IL_0006, IL_0007, IL_0009, IL_000f, IL_0017, IL_0018, IL_001d, IL_0022
		//IL_0001: Incompatible stack heights: 0 vs 1
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		while (true)
		{
			/*Error: ldloc 0 (out-of-bounds)*/;
		}
	}

	internal static extern ExtractProgressEventArgs BeforeExtractEntry(string archiveName, ZipEntry entry, string extractLocation);

	internal static extern ExtractProgressEventArgs ExtractExisting(string archiveName, ZipEntry entry, string extractLocation);

	internal static extern ExtractProgressEventArgs AfterExtractEntry(string archiveName, ZipEntry entry, string extractLocation);

	internal static extern ExtractProgressEventArgs ExtractAllStarted(string archiveName, string extractLocation);

	internal static extern ExtractProgressEventArgs ExtractAllCompleted(string archiveName, string extractLocation);

	internal unsafe static ExtractProgressEventArgs ByteUpdate(string archiveName, ZipEntry entry, long bytesWritten, long totalBytes)
	{
		//Discarded unreachable code: IL_0018
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Incompatible stack heights: 0 vs 1
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		do
		{
			((object[])/*Error near IL_0001: Stack underflow*/)[/*Error near IL_0001: Stack underflow*/] = (object)/*Error near IL_0001: Stack underflow*/;
			*(_003F*)(nint)/*Error near IL_0002: Stack underflow*/ = /*Error near IL_0002: Stack underflow*/;
			checked
			{
				nint num = (nint)unchecked(/*Error near IL_0003: Stack underflow*/ / /*Error near IL_0003: Stack underflow*/);
				_ = /*Error near IL_0006: Stack underflow*/& num;
			}
		}
		while ((ushort)/*Error near IL_0006: ldloc 0 (out-of-bounds)*/ > 0);
		_ = (byte)(ushort)(/*Error near IL_0010: Stack underflow*/ % /*Error near IL_0010: Stack underflow*/);
		/*Error near IL_0013: Invalid metadata token*/;
	}
}
