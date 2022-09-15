using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;

public static class O
{
	public static void YDLNsFw0x8rjLiEgMJfVvzwyfcWKuL(string A, string B, string C, string D)
	{
		L.M m = L.N5NIAW7vydDyg0sqDgvzcHtfRvCA4M();
		Marshal.ThrowExceptionForHR(m.SetDescription(D));
		Marshal.ThrowExceptionForHR(m.SetPath(A));
		Marshal.ThrowExceptionForHR(m.SetArguments(C));
		((IPersistFile)m).Save(B, fRemember: false);
	}
}
