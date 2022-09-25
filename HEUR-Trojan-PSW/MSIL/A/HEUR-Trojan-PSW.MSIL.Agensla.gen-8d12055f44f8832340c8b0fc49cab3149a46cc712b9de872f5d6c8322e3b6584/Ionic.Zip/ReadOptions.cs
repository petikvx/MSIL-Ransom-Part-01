using System;
using System.IO;
using System.Text;

namespace Ionic.Zip;

public class ReadOptions
{
	public EventHandler<ReadProgressEventArgs> ReadProgress { get; set; }

	public TextWriter StatusMessageWriter { get; set; }

	public Encoding Encoding { get; set; }
}
