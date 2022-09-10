namespace Microsoft.InfoCards;

internal class IssuerInformationEntry
{
	private string entryName;

	private string entryValue;

	public string Name => entryName;

	public string Value => entryValue;

	public IssuerInformationEntry(string name, string value)
	{
		entryName = name;
		entryValue = value;
	}
}
