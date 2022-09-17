using System.Reflection;
using System.Windows.Forms;

namespace Server.Helper;

public static class ListviewDoubleBuffer
{
	public static void Enable(ListView listView)
	{
		typeof(Control).GetProperty("DoubleBuffered", BindingFlags.Instance | BindingFlags.NonPublic)!.SetValue(listView, true, null);
	}
}
