namespace AjScript.Language;

public class Undefined
{
	private static Undefined instance = new Undefined();

	public static Undefined Instance => instance;

	private Undefined()
	{
	}
}
