using System;
using System.Windows.Forms;
using TrueCrypter.Ransomware.Core.Forms;

namespace TrueCrypter;

internal static class Program
{
	[STAThread]
	private static void Main()
	{
		Application.EnableVisualStyles();
		Application.SetCompatibleTextRenderingDefault(false);
		Application.Run((Form)(object)new frmMain());
	}
}
