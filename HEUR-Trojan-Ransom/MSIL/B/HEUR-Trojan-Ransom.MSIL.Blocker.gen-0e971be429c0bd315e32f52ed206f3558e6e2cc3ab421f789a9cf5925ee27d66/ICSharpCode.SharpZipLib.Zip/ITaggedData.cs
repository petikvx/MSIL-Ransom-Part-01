namespace ICSharpCode.SharpZipLib.Zip;

public interface ITaggedData
{
	short TagID { get; }

	byte[] GetData();

	void SetData(byte[] data, int offset, int count);
}
