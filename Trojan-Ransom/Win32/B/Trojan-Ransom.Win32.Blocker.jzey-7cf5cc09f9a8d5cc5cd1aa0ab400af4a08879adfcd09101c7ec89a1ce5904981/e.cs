using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic.ApplicationServices;
using av2p5dFj;
using iiraiv39;
using sReLFYF2;

[EditorBrowsable(EditorBrowsableState.Advanced)]
[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "14.0.0.0")]
[CompilerGenerated]
internal sealed class e : ApplicationSettingsBase
{
	private static e j5mOKtwh = (e)(object)m8meAX3U.kzDXJ49Y((SettingsBase)(object)new e(), 58776);

	private static bool AtvOa5SM;

	private static object c4dtCsNV;

	public static e ikCop1nj
	{
		get
		{
			//IL_003c: Unknown result type (might be due to invalid IL or missing references)
			//IL_004b: Expected O, but got Unknown
			if (!AtvOa5SM)
			{
				object object_ = c4dtCsNV;
				for (int num = 0; num == 0; num = 1)
				{
					m8meAX3U.CypsVz5W(object_, 36129);
				}
				m8meAX3U.smethod_1(object_, 61094);
				try
				{
					if (!AtvOa5SM)
					{
						ivlgLlId.G4hrsDYW((WindowsFormsApplicationBase)(object)c.A_0, (ShutdownEventHandler)delegate
						{
							if (m8meAX3U.JqSKVYsG((WindowsFormsApplicationBase)(object)c.A_0, 38344))
							{
								m8meAX3U.cRHK8kb3((ApplicationSettingsBase)(object)y6mBH2Vc.Quasq3vR, 23068);
							}
						}, 57216);
						AtvOa5SM = true;
					}
				}
				finally
				{
					m8meAX3U.smethod_1(object_, 61095);
				}
			}
			return j5mOKtwh;
		}
	}

	static e()
	{
		for (int num = 0; num == 0; num = 1)
		{
			c4dtCsNV = m8meAX3U.bErpAbl3(new object(), 6598);
		}
	}

	[DebuggerNonUserCode]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	private static void smethod_0(object sender, EventArgs e)
	{
		if (m8meAX3U.JqSKVYsG((WindowsFormsApplicationBase)(object)c.A_0, 38344))
		{
			m8meAX3U.cRHK8kb3((ApplicationSettingsBase)(object)y6mBH2Vc.Quasq3vR, 23068);
		}
	}
}
