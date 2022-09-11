namespace System.Data.SQLite;

[AttributeUsage(AttributeTargets.Assembly, Inherited = false)]
public sealed class AssemblySourceTimeStampAttribute : Attribute
{
	private string sourceTimeStamp;

	public string SourceTimeStamp => sourceTimeStamp;

	public AssemblySourceTimeStampAttribute(string value)
	{
		sourceTimeStamp = value;
	}
}
