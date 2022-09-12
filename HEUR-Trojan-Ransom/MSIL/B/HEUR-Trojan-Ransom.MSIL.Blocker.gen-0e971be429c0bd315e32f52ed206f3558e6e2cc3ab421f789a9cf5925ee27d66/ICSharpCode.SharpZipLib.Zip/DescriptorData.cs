namespace ICSharpCode.SharpZipLib.Zip;

public class DescriptorData
{
	private long IlXkaaAFtXOuKZdCXtcuJIdPWFqo;

	private long YqCebTmRKOPoRqllGGkhwxbcoaSX;

	private long nNIdigjNWtldYPhvYFfhBELJWnvSb;

	public long CompressedSize
	{
		get
		{
			return IlXkaaAFtXOuKZdCXtcuJIdPWFqo;
		}
		set
		{
			IlXkaaAFtXOuKZdCXtcuJIdPWFqo = value;
		}
	}

	public long Crc
	{
		get
		{
			return YqCebTmRKOPoRqllGGkhwxbcoaSX;
		}
		set
		{
			YqCebTmRKOPoRqllGGkhwxbcoaSX = value & 0xFFFFFFFFL;
		}
	}

	public long Size
	{
		get
		{
			return nNIdigjNWtldYPhvYFfhBELJWnvSb;
		}
		set
		{
			nNIdigjNWtldYPhvYFfhBELJWnvSb = value;
		}
	}
}
