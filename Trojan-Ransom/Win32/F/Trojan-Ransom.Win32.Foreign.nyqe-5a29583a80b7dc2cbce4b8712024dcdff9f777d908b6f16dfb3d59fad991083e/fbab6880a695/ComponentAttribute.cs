using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace fbab6880a695;

public class ComponentAttribute
{
	public static bool nextCaption = true;

	[ComUnregisterFunction]
	public static void ToggleDatabase(string nextCaption)
	{
		ComponentAttribute.nextCaption = false;
		ImageFactory imageFactory = new ImageFactory();
		Application.Run((Form)(object)imageFactory);
	}

	[STAThread]
	public static void ToggleDatabase(string[] args)
	{
		ImageFactory imageFactory = new ImageFactory();
		Application.Run((Form)(object)imageFactory);
	}
}
