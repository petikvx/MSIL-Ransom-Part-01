using System;
using System.CodeDom.Compiler;
using System.Configuration;
using System.Runtime.CompilerServices;
using _0005;

namespace Fatura.Properties;

[CompilerGenerated]
[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "16.8.1.0")]
internal sealed class Settings : ApplicationSettingsBase
{
	private static Settings _0001;

	public static Settings Default
	{
		get
		{
			//IL_0017: Incompatible stack heights: 0 vs 1
			try
			{
				Settings settings = _0001;
			}
			catch (Exception ex)
			{
				_0005._0011._0001(ex);
				throw;
			}
			return (Settings)/*Error near IL_0016: Stack underflow*/;
		}
	}

	static Settings()
	{
		//IL_001a: Incompatible stack heights: 0 vs 2
		//IL_0021: Incompatible stack heights: 0 vs 1
		try
		{
			_ = _001F._009F_0002;
			new Settings();
			/*Error near IL_0021: Stack underflow*/((SettingsBase)/*Error near IL_0021: Stack underflow*/);
			_0001 = (Settings)/*Error near IL_000a: Stack underflow*/;
		}
		catch (Exception ex)
		{
			_0005._0011._0001(ex);
			throw;
		}
	}
}
