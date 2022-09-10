using System.CodeDom.Compiler;
using System.Configuration;
using System.Runtime.CompilerServices;

namespace RansomwarePOC.Properties;

[CompilerGenerated]
[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "11.0.0.0")]
internal sealed class Settings : ApplicationSettingsBase
{
	private static Settings settings_0;

	public unsafe static Settings Default
	{
		get
		{
			byte num;
			checked
			{
				num = (byte)unchecked((uint)(*(short*)(nint)/*Error near IL_0001: Stack underflow*/));
			}
			*(sbyte*)(nint)/*Error near IL_0004: Stack underflow*/ = (sbyte)(int)num;
			/*Error: Unexpected end of block*/;
		}
	}

	public extern Settings();

	unsafe static SettingsBase smethod_0(SettingsBase settingsBase_0)
	{
		//Discarded unreachable code: IL_0013, IL_001b, IL_001c, IL_0021
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Incompatible stack heights: 1 vs 0
		_ = *(double*)(int)checked((ushort)/*Error near IL_0001: Stack underflow*/);
		checked
		{
			_ = (ushort)(object)settingsBase_0;
			_ = -5f;
			/*Error near IL_000e: Invalid metadata token*/;
		}
	}
}
