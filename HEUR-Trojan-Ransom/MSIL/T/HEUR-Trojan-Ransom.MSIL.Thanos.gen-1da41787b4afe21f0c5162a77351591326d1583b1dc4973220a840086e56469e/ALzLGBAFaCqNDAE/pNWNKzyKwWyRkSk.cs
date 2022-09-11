using System.Diagnostics;
using System.Threading;

namespace ALzLGBAFaCqNDAE;

public static class pNWNKzyKwWyRkSk
{
	public static void vKMoxHKNOChwQ(string XtfFtRXiaXgZ)
	{
		using Mutex mutex = new Mutex(initiallyOwned: false, "Global\\" + XtfFtRXiaXgZ);
		if (!mutex.WaitOne(0, exitContext: false))
		{
			Process.GetCurrentProcess().Kill();
		}
	}
}
