using System.Threading;

namespace xClient.Core.Helper;

public static class MutexHelper
{
	private static Mutex _appMutex;

	public static bool CreateMutex(string name)
	{
		_appMutex = new Mutex(initiallyOwned: false, name, out var createdNew);
		return createdNew;
	}

	public static void CloseMutex()
	{
		if (_appMutex != null)
		{
			_appMutex.Close();
			_appMutex = null;
		}
	}
}
