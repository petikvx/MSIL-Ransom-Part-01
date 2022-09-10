using System.Text;

namespace iTuner;

public class UsbDisk
{
	private const int KB = 1024;

	private const int MB = 1024000;

	private const int GB = 1024000000;

	public ulong FreeSpace { get; internal set; }

	public string Model { get; internal set; }

	public string Name { get; private set; }

	public ulong Size { get; internal set; }

	public string Volume { get; internal set; }

	internal UsbDisk(string name)
	{
		Name = name;
		Model = string.Empty;
		Volume = string.Empty;
		FreeSpace = 0uL;
		Size = 0uL;
	}

	public override string ToString()
	{
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.Append(Name);
		stringBuilder.Append(" ");
		stringBuilder.Append(Volume);
		stringBuilder.Append(" (");
		stringBuilder.Append(Model);
		stringBuilder.Append(") ");
		stringBuilder.Append(FormatByteCount(FreeSpace));
		stringBuilder.Append(" free of ");
		stringBuilder.Append(FormatByteCount(Size));
		return stringBuilder.ToString();
	}

	private string FormatByteCount(ulong bytes)
	{
		string text = null;
		if (bytes < 1024L)
		{
			return $"{bytes} Bytes";
		}
		if (bytes < 1024000L)
		{
			bytes /= 1024uL;
			return string.Format("{0} KB", bytes.ToString("N"));
		}
		if (bytes < 1024000000L)
		{
			return string.Format("{0} MB", ((double)(bytes / 1024000uL)).ToString("N1"));
		}
		return string.Format("{0} GB", ((double)(bytes / 1024000000uL)).ToString("N1"));
	}
}
