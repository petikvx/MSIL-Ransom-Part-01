using System.IO;

namespace ICSharpCode.SharpZipLib.Zip;

public class StaticDiskDataSource : IStaticDataSource
{
	private string FYbiDSnWyUrJyqHBLSLSTgeHMMch;

	public StaticDiskDataSource(string fileName)
	{
		FYbiDSnWyUrJyqHBLSLSTgeHMMch = fileName;
	}

	public Stream GetSource()
	{
		return File.OpenRead(FYbiDSnWyUrJyqHBLSLSTgeHMMch);
	}
}
