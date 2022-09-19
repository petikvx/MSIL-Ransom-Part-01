using System.Runtime.InteropServices;

namespace nLpTFjJRwUBp;

public class sUtmdNLRyLBV
{
	[DllImport("kernel32", CharSet = CharSet.Unicode, SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool DeleteFile(string xTHdhADrsXhIfLB);

	public bool gsCnkMATdlEVHOMh(string nuoKAZvjqKTXEjNO)
	{
		return DeleteFile(nuoKAZvjqKTXEjNO + ":Zone.Identifier");
	}
}
