using System;

namespace Ionic.Zip;

public class ZipProgressEventArgs : EventArgs
{
	private int _entriesTotal;

	private bool _cancel;

	private ZipEntry _latestEntry;

	private ZipProgressEventType _flavor;

	private string _archiveName;

	private long _bytesTransferred;

	private long _totalBytesToTransfer;

	public unsafe int EntriesTotal
	{
		get; set
		{
			//Discarded unreachable code: IL_001e, IL_0023, IL_002b
			//IL_0003: Invalid comparison between Unknown and I
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			//IL_000c: Invalid comparison between Unknown and O
			nuint num;
			do
			{
				num = checked((nuint)/*Error near IL_0001: Stack underflow*/);
			}
			while ((nint)/*Error near IL_0008: Stack underflow*/ < (nint)(0 - num) || (object)checked(/*Error near IL_0009: Stack underflow*/ - /*Error near IL_0009: Stack underflow*/) < this);
			*(double*)(nint)/*Error near IL_0017: Stack underflow*/ = -27903.212890625;
			/*Error near IL_0019: Invalid metadata token*/;
		}
	}

	public unsafe ZipEntry CurrentEntry
	{
		get
		{
			//Discarded unreachable code: IL_0015, IL_001a, IL_0022, IL_0027, IL_0032, IL_0038
			//IL_0003: Invalid comparison between Unknown and O
			//IL_002b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0033: Invalid comparison between Unknown and F8
			while (/*Error near IL_0008: Stack underflow*/ < this)
			{
			}
			*(double*)(nint)/*Error near IL_000e: Stack underflow*/ = -27903.212890625;
			/*Error near IL_0010: Invalid metadata token*/;
		}
		set; }

	public bool Cancel
	{
		get; set
		{
			//Discarded unreachable code: IL_0005, IL_000b, IL_0010, IL_001b, IL_0021, IL_002e, IL_0039
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_001c: Invalid comparison between Unknown and F8
			//IL_002e: Unknown result type (might be due to invalid IL or missing references)
			//IL_003a: Invalid comparison between Unknown and I4
			/*Error: Invalid metadata token*/;
		}
	}

	public extern ZipProgressEventType EventType { get; set; }

	public unsafe string ArchiveName
	{
		get
		{
			//Discarded unreachable code: IL_0012, IL_0013, IL_0018, IL_0020, IL_0030, IL_0034
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			//IL_0013: Invalid comparison between Unknown and I4
			//IL_002b: Expected I8, but got O
			//IL_0032: Invalid comparison between Unknown and I4
			//IL_0032: Incompatible stack heights: 1 vs 0
			while ((int)/*Error near IL_0007: Stack underflow*/ != 0)
			{
			}
			_ = *(ushort*)(nint)(~/*Error near IL_0008: Stack underflow*/);
			checked
			{
				_ = (nuint)/*Error near IL_0009: ldloc 0 (out-of-bounds)*/;
				/*Error near IL_000d: Invalid metadata token*/;
			}
		}
		set
		{
			//Discarded unreachable code: IL_000a, IL_0010, IL_0018
			//IL_000b: Invalid comparison between Unknown and I4
			_ = *(ushort*)(nint)/*Error near IL_0001: Stack underflow*/;
			checked
			{
				_ = (nuint)/*Error near IL_0001: ldloc 0 (out-of-bounds)*/;
				/*Error near IL_0005: Invalid metadata token*/;
			}
		}
	}

	public long BytesTransferred
	{
		get
		{
			//IL_0002: Invalid comparison between Unknown and I4
			while ((int)/*Error near IL_0007: Stack underflow*/ >= 8)
			{
			}
			_ = ((ushort[])/*Error near IL_0009: Stack underflow*/)[/*Error near IL_0009: Stack underflow*/];
			/*Error near IL_000a: Invalid metadata token*/;
		}
		set; }

	public unsafe long TotalBytesToTransfer
	{
		get
		{
			//Discarded unreachable code: IL_000e, IL_0015, IL_0021, IL_0029
			//IL_0009: Expected I8, but got O
			//IL_0010: Invalid comparison between Unknown and I4
			//IL_0024: Invalid comparison between Unknown and I4
			//IL_002a: Unknown result type (might be due to invalid IL or missing references)
			//IL_002f: Invalid comparison between Unknown and I4
			*(long*)(int)checked((uint)(-1206691834)) = (long)this;
			/*Error near IL_0009: Invalid metadata token*/;
		}
		set; }

	internal extern ZipProgressEventArgs();

	internal extern ZipProgressEventArgs(string archiveName, ZipProgressEventType flavor);
}
