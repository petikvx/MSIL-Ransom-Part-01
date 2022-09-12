namespace AjScript.Language;

public class ReturnValue
{
	private object value;

	public object Value => value;

	public ReturnValue(object value)
	{
		this.value = value;
	}
}
