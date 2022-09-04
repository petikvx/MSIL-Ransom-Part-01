namespace iexprorer;

internal sealed class ConnectionLayout
{
	private string valuesMap;

	private string valuesSet;

	private string activeGenerator;

	internal string ProcessPciture
	{
		get
		{
			return valuesMap;
		}
		set
		{
			valuesMap = value;
		}
	}

	internal string ResolveView
	{
		get
		{
			return valuesSet;
		}
		set
		{
			valuesSet = value;
		}
	}

	internal string LoadDeployment
	{
		get
		{
			return activeGenerator;
		}
		set
		{
			activeGenerator = value;
		}
	}
}
