using System.Collections.Generic;

namespace C4l4nising;

public interface INuGetPathContext
{
	string UserPackageFolder { get; }

	IReadOnlyList<string> FallbackPackageFolders { get; }

	string HttpCacheFolder { get; }
}
