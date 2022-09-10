using System.Collections;

namespace OpenNETCF.Desktop.Communication;

public class FileList : CollectionBase
{
	public FileInformation this[int index] => (FileInformation)base.List[index];

	internal FileList()
	{
	}

	internal void Add(FileInformation fi)
	{
		base.List.Add(fi);
	}
}
