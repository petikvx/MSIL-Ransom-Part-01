using System;
using System.Windows.Forms;

namespace WindowBrokerHost;

internal static class Program
{
	public class xcxl : ApplicationContext
	{
		public xcxl()
		{
			sew();
		}

		public void sew()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run((Form)(object)new Form1());
		}
	}

	[STAThread]
	private static void Main()
	{
		Application.Run((ApplicationContext)(object)new xcxl());
	}
}
