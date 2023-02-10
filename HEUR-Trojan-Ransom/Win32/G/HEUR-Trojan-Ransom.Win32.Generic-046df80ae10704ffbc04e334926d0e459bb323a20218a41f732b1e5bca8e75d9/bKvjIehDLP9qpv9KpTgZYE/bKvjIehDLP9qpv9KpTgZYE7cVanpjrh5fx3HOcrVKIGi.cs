using System;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
using _19Zwuk09Cmc8JiE7IcFNXkFroOgHswP2hU;

namespace bKvjIehDLP9qpv9KpTgZYE;

[Guid("923e461c-1106-47fc-9752-2b1e3e18ac8f")]
internal static class bKvjIehDLP9qpv9KpTgZYE7cVanpjrh5fx3HOcrVKIGi
{
	[STAThread]
	private static void Main()
	{
		int num = 0;
		while (num < 2)
		{
			bool createdNew;
			using (new Mutex(initiallyOwned: true, "923e461c-1106-47fc-9752-2b1e3e18ac8f", out createdNew))
			{
				if (createdNew)
				{
					Application.EnableVisualStyles();
					Application.SetCompatibleTextRenderingDefault(false);
					Application.Run((Form)(object)new _19Zwuk09Cmc8JiE7IcFNXkFroOgHswP());
					break;
				}
				num++;
				Thread.Sleep(1000);
			}
		}
	}
}
