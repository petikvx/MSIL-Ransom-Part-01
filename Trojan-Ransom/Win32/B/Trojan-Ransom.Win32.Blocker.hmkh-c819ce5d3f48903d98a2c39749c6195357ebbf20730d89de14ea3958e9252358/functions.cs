using System.Runtime.InteropServices;

public sealed class functions
{
	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int BlockInput(int fBlock);

	public static object BlockMyControl(bool b)
	{
		if (b)
		{
			BlockInput(0);
		}
		else
		{
			BlockInput(1);
		}
		object result = default(object);
		return result;
	}
}
