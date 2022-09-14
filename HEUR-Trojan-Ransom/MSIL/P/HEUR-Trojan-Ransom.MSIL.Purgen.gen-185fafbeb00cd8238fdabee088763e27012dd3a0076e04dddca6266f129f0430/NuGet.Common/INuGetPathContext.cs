using System.Collections.Generic;

namespace NuGet.Common;

public interface INuGetPathContext
{
	string UserPackageFolder { get; }

	IReadOnlyList<string> FallbackPackageFolders { get; }

	string HttpCacheFolder { get; }
}
