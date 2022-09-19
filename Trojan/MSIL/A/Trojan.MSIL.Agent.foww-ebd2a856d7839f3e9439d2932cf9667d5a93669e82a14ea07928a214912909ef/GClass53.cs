using System.Runtime.CompilerServices;
using System.Windows.Forms;

public static class GClass53
{
	[CompilerGenerated]
	private static string string_0;

	[CompilerGenerated]
	private static string string_1;

	[CompilerGenerated]
	private static bool bool_0;

	public static string CurrentPath
	{
		[CompilerGenerated]
		get
		{
			return string_0;
		}
		[CompilerGenerated]
		set
		{
			string_0 = value;
		}
	}

	public static string InstallPath
	{
		[CompilerGenerated]
		get
		{
			return string_1;
		}
		[CompilerGenerated]
		set
		{
			string_1 = value;
		}
	}

	public static bool AddToStartupFailed
	{
		[CompilerGenerated]
		get
		{
			return bool_0;
		}
		[CompilerGenerated]
		set
		{
			bool_0 = value;
		}
	}

	static GClass53()
	{
		CurrentPath = Application.get_ExecutablePath();
	}
}
