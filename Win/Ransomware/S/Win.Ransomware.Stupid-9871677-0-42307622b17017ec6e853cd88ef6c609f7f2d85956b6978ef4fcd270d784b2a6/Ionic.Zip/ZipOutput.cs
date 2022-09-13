using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Ionic.Zip;

internal static class ZipOutput
{
	public static extern bool WriteCentralDirectoryStructure(Stream s, ICollection<ZipEntry> entries, uint numSegments, Zip64Option zip64, string comment, ZipContainer container);

	private static Encoding GetEncoding(ZipContainer container, string t)
	{
		//Discarded unreachable code: IL_0010, IL_0018
		//IL_0013: Incompatible stack heights: 0 vs 1
		while (true)
		{
			if (/*Error near IL_0005: Stack underflow*/ >= /*Error near IL_0005: Stack underflow*/&& /*Error near IL_000a: Stack underflow*/> /*Error near IL_000a: Stack underflow*/)
			{
			}
		}
	}

	private static extern byte[] GenCentralDirectoryFooter(long StartOfCentralDirectory, long EndOfCentralDirectory, Zip64Option zip64, int entryCount, string comment, ZipContainer container);

	private static extern byte[] GenZip64EndOfCentralDirectory(long StartOfCentralDirectory, long EndOfCentralDirectory, int entryCount, uint numSegments);

	private static extern int CountEntries(ICollection<ZipEntry> _entries);
}
