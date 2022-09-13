using System.Runtime.InteropServices;

namespace youknowcaliber;

internal sealed class Json
{
	public string Data;

	public extern Json(string data);

	public extern string GetValue(string value);

	public void Remove(string[] values)
	{
		//Discarded unreachable code: IL_0006
		checked
		{
			_ = (sbyte)/*Error near IL_0001: Stack underflow*/;
			/*Error near IL_0001: Invalid metadata token*/;
		}
	}

	public extern string[] SplitData([Optional] string delimiter);
}
