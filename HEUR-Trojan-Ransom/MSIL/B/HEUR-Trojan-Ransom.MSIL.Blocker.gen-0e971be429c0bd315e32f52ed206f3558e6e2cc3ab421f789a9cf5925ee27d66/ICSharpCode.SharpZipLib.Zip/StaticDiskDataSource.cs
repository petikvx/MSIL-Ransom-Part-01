using System.IO;

namespace ICSharpCode.SharpZipLib.Zip;

public class StaticDiskDataSource : IStaticDataSource
{
	private string AQdrYhBdoxdXeDDoOKHlGrpWwbjfA;

	public StaticDiskDataSource(string fileName)
	{
		AQdrYhBdoxdXeDDoOKHlGrpWwbjfA = fileName;
	}

	public Stream GetSource()
	{
		return File.OpenRead(AQdrYhBdoxdXeDDoOKHlGrpWwbjfA);
	}
}
