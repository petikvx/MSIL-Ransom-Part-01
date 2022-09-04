using System;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
using cOd6pt08ewVXCYj0RSmhmhgHEp2dXTPgMR9bF;

namespace ns0;

[Guid("5ed1ed4d-6b2b-4a0c-b267-7c501a413797")]
internal static class ZENYxbLOXcqbnaIBQjhun9
{
	[STAThread]
	private static void Main()
	{
		int num = 0;
		while (num < 2)
		{
			bool createdNew;
			using (new Mutex(initiallyOwned: true, "5ed1ed4d-6b2b-4a0c-b267-7c501a413797", out createdNew))
			{
				if (createdNew)
				{
					Application.EnableVisualStyles();
					Application.SetCompatibleTextRenderingDefault(false);
					Application.Run((Form)(object)new cOd6pt08ewVXCYj0RSmhmhgHEp2dXT());
					break;
				}
				num++;
				Thread.Sleep(1000);
			}
		}
	}
}
