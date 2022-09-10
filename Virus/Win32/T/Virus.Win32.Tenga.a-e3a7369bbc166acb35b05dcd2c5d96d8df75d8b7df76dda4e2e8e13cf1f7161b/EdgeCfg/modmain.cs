using System;
using System.Windows.Forms;
using EdgeUI;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace EdgeCfg;

[StandardModule]
internal sealed class modmain
{
	public static clsEdgeConfig cfg;

	[STAThread]
	public static void main()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Expected O, but got Unknown
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		cfg = new clsEdgeConfig();
		cfg.FromRegistry();
		string executablePath = Application.get_ExecutablePath();
		executablePath = filenames.getDirectoryName(executablePath);
		executablePath += "edge.chm";
		frmConfig val = new frmConfig(executablePath);
		((Form)val).ShowDialog();
	}

	public static void LogException(Exception x)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		Interaction.MsgBox((object)x.Message, (MsgBoxStyle)0, (object)null);
	}
}
