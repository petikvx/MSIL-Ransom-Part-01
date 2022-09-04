using System.IO;

namespace SevenZip;

public interface ICoder
{
	void Code(Stream inStream, Stream outStream, long inSize, long outSize, ICodeProgress progress);
}
