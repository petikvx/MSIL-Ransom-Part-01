namespace Lexplorer;

internal class Class16 : Class13
{
	public Class16()
	{
		methodTable.Add("EXECUTE", EmtyMethod);
	}

	private bool EmtyMethod(Class10 ps, bool forced)
	{
		return true;
	}

	public override string ToString()
	{
		return $"Command type: ENDLOOP, Method={base.ExecutionMethodName}";
	}
}
