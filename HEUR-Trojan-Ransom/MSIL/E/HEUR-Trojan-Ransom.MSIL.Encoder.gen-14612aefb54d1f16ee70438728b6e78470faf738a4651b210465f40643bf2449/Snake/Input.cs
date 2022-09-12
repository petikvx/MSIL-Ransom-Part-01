using System.Collections.Generic;
using System.Windows.Forms;

namespace Snake;

internal class Input
{
	private static Dictionary<Keys, bool> KeyTable = new Dictionary<Keys, bool>();

	public static bool IsKeyDown(Keys key)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		if (KeyTable.TryGetValue(key, out var value))
		{
			return value;
		}
		return false;
	}

	public static void SetKey(Keys key, bool IsDown)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		KeyTable[key] = IsDown;
	}
}
