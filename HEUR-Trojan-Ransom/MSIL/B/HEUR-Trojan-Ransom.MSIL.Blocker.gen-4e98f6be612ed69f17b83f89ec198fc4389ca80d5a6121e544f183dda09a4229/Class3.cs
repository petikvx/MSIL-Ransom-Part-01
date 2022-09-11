using System;
using System.Windows.Forms;

internal static class Class3
{
	[STAThread]
	private static void Main()
	{
		Application.EnableVisualStyles();
		Application.SetCompatibleTextRenderingDefault(false);
		while (true)
		{
			int num = -1363133685;
			while (true)
			{
				int num2 = num;
				uint num3;
				switch ((num3 = (uint)(~((-460320725 - -num2) * 1780342047 * 1662027669 * 667662713) * 1566303413)) % 3u)
				{
				case 2u:
					goto IL_000d;
				default:
					return;
				case 0u:
					break;
				case 1u:
					return;
				}
				break;
				IL_000d:
				Application.Run((Form)(object)new Simulator());
				num = (int)(num3 * 744225210) ^ -774132476;
			}
		}
	}
}
