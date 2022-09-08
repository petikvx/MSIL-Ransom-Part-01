using System;

namespace Orcus.CommandManagement;

public class FilePushRequest
{
	public string EntryName { get; set; }

	public Guid DataMode { get; set; }

	public string FileName { get; set; }

	public bool IsCsvData { get; set; }
}
