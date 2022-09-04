namespace Helper;

internal class cMain
{
	public static cConfig ConfigClass = new cConfig();

	public static cFunctions FunctionClass = new cFunctions();

	public static cSystemInfo SystemInfoClass = new cSystemInfo();

	public static cSystem SystemClass = new cSystem();

	private static cControl ControlClass = new cControl();

	public static void Main(string[] args)
	{
		ConfigClass.sHWID = SystemInfoClass.getUniqueID();
		ConfigClass.sWinVersion = SystemInfoClass.getSystemVersion();
		SystemClass.loadSystem();
		ControlClass.ConnectControl();
	}
}
