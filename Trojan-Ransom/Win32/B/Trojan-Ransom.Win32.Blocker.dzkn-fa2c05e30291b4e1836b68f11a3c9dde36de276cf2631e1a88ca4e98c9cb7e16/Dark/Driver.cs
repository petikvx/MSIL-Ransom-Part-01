using System;
using System.Windows.Forms;

namespace Dark;

public class Driver
{
	[STAThread]
	public static void Main()
	{
		Application.Run((ApplicationContext)(object)new MainCore());
	}
}
