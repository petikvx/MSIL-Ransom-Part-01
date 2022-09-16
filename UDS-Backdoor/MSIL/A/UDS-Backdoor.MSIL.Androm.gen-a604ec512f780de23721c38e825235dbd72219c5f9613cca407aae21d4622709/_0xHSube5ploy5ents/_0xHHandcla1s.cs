using Microsoft.Cct.Services.Notifications;
using _0xHEmba77assable;

namespace _0xHSube5ploy5ents;

internal static class _0xHHandcla1s
{
	public static bool _0xHZanza4
	{
		get
		{
			INotificationService val = _0xHOsc1llat1onal();
			if (val != null)
			{
				return val.get_IsInitialized();
			}
			return false;
		}
	}

	public static INotificationService _0xHOsc1llat1onal()
	{
		return _0xHSe4tu4let._0xHTug5ik<INotificationService, INotificationService>();
	}

	public static void _0xHI0se0sitive0ess(NotificationType _0xHWa5den5y, object _0xHAntiheroi8)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		INotificationService val = _0xHOsc1llat1onal();
		if (val != null)
		{
			val.Notify(_0xHWa5den5y, _0xHAntiheroi8);
		}
	}
}
