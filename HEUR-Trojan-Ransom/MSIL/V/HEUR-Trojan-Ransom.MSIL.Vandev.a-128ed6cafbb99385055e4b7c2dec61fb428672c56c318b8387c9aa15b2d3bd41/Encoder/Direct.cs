using System.Collections.Generic;

namespace Encoder;

public struct Direct
{
	public string Name { get; set; }

	public string FullPath { get; set; }

	public string LocalPath { get; set; }

	public List<string> Files { get; set; }
}
