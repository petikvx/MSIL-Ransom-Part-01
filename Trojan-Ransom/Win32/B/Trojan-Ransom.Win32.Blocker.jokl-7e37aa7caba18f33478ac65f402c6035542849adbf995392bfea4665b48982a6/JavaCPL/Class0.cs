using System;
using System.Threading;
using System.Windows.Forms;

namespace JavaCPL;

internal sealed class Class0
{
	[STAThread]
	private static void Main(string[] args)
	{
		bool createdNew;
		using (new Mutex(initiallyOwned: true, "iynGCiVHAugOxMEQblegrhbBHCQfkIxsiKVBfMvyzlrfEj", out createdNew))
		{
			if (createdNew)
			{
				Application.EnableVisualStyles();
				Application.SetCompatibleTextRenderingDefault(false);
				Application.Run((Form)(object)new GForm0());
			}
			else
			{
				Application.EnableVisualStyles();
			}
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run((Form)(object)new GForm0());
		}
	}
}
