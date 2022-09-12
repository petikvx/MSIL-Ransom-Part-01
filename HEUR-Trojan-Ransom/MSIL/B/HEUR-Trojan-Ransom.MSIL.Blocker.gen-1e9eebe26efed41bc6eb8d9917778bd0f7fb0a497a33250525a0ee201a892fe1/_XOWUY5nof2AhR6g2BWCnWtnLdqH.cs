using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using PointBlank.DLL;
using PointBlank.Launcher;

internal static class _XOWUY5nof2AhR6g2BWCnWtnLdqH
{
	[STAThread]
	private static void _YcdIQUnOLp5oD9b4MvctzSqaCLi()
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Invalid comparison between Unknown and I4
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Expected O, but got Unknown
		Application.EnableVisualStyles();
		Application.SetCompatibleTextRenderingDefault(false);
		Connection connection = new Connection();
		try
		{
			Process.GetProcesses();
			try
			{
				if ((int)((Form)connection).ShowDialog() == 1)
				{
					if (!File.Exists(Application.get_StartupPath() + _003CModule_003E.smethod_1<string>(968820316u) + Modul.Ver))
					{
						MessageBox.Show(_003CModule_003E.smethod_4<string>(129360780u), Modul.Name, (MessageBoxButtons)0, (MessageBoxIcon)16);
						Environment.Exit(1);
					}
					else
					{
						Application.Run((Form)(object)new Launcher(connection, new AuthModul()));
					}
				}
			}
			catch
			{
				((Form)connection).Close();
			}
		}
		finally
		{
			((IDisposable)connection)?.Dispose();
		}
	}
}
