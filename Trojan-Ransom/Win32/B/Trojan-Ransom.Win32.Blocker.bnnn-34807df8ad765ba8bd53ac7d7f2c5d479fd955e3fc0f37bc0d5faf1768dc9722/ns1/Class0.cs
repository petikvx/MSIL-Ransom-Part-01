using System;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
using vifc5jEr5oNDtDKYKQb3DrNl6v;

namespace ns1;

[Guid("0aa3f37e-dea8-4268-bcbf-1cd4dd5fe8b4")]
internal static class Class0
{
	[STAThread]
	private static void Main()
	{
		int num = 0;
		while (true)
		{
			bool createdNew;
			using (new Mutex(initiallyOwned: true, "0aa3f37e-dea8-4268-bcbf-1cd4dd5fe8b4", out createdNew))
			{
				if (createdNew)
				{
					Application.EnableVisualStyles();
					Application.SetCompatibleTextRenderingDefault(false);
					Application.Run((Form)(object)new vifc5jEr5oNDtDKYKQb3DrNl6vflwhXYuDUVZfxV());
					break;
				}
				if (num != 4)
				{
					num++;
					Thread.Sleep(500);
					continue;
				}
				break;
			}
		}
	}
}
