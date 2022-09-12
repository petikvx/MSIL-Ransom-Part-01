namespace Gecko;

public static class GeckoWindowExtension
{
	public static bool IsTopWindow(this GeckoWindow geckoWindow)
	{
		if (geckoWindow == null)
		{
			return true;
		}
		using GeckoWindow geckoWindow2 = geckoWindow.Top;
		if (geckoWindow2 == null)
		{
			return true;
		}
		return geckoWindow2.DomWindow.GetHashCode() == geckoWindow.DomWindow.GetHashCode();
	}
}
