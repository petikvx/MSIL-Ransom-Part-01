using System.Runtime.InteropServices;

namespace ns18;

public class GClass17
{
	public enum EXECUTION_STATE
	{
		ES_SYSTEM_REQUIRED = 1,
		ES_DISPLAY_REQUIRED = 2,
		ES_CONTINUOUS = int.MinValue
	}

	[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern EXECUTION_STATE SetThreadExecutionState(EXECUTION_STATE execution_STATE_0);

	public static EXECUTION_STATE smethod_0()
	{
		return SetThreadExecutionState((EXECUTION_STATE)(-2147483645));
	}
}
