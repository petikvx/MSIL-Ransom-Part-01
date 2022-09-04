namespace Lexplorer;

internal class Class22 : Class13
{
	public Class22()
	{
		methodTable.Add("POWER", ToggleSound);
	}

	private bool ToggleSound(Class10 props, bool forced)
	{
		Class24.Mute = props["V"] == "0";
		return true;
	}

	public override string ToString()
	{
		return $"Command type: SOUND, Method={base.ExecutionMethodName}";
	}
}
