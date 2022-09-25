using System;

namespace Ionic.Zip;

public class ZipErrorEventArgs : ZipProgressEventArgs
{
	private Exception _exc;

	private ZipErrorEventArgs()
	{
	}

	internal static ZipErrorEventArgs Saving(string archiveName, ZipEntry entry, Exception exception)
	{
		return new ZipErrorEventArgs
		{
			EventType = ZipProgressEventType.Error_Saving,
			ArchiveName = archiveName,
			CurrentEntry = entry,
			_exc = exception
		};
	}
}
