using System;
using System.ComponentModel;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;

[EditorBrowsable(EditorBrowsableState.Advanced)]
public class GEventArgs1 : EventArgs
{
	private readonly Graphics graphics_0;

	private readonly TextFormatFlags textFormatFlags_0;

	private Class8.Struct19 struct19_0;

	public extern Graphics Graphics_0 { get; }

	public extern Rectangle Rectangle_0 { get; }

	public extern TextFormatFlags TextFormatFlags_0 { get; }

	public extern GEventArgs1(Graphics graphics_1, TextFormatFlags textFormatFlags_1, Rectangle rectangle_0);

	internal unsafe static string smethod_0<T>(T gparam_0, int int_0, int int_1) where T : Assembly
	{
		//Discarded unreachable code: IL_002e
		//IL_0015: Expected native int or pointer, but got F8
		//IL_0019: Incompatible stack heights: 1 vs 0
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Expected O, but got Unknown
		checked
		{
			while (true)
			{
				if (gparam_0 != null || ((sbyte[])((sbyte[])/*Error near IL_000a: Stack underflow*/)[/*Error near IL_000a: Stack underflow*/])[(nint)(*(float*)null)] != 0)
				{
					_003F val = /*Error near IL_001f: Stack underflow*/* int_0;
					if (((short[])/*Error near IL_0022: Stack underflow*/)[val] != 8)
					{
						break;
					}
				}
			}
			/*Error near IL_0029: Invalid metadata token*/;
		}
	}

	static string smethod_1(Assembly assembly_0)
	{
		_ = (double)((sbyte[])/*Error near IL_0001: Stack underflow*/)[/*Error near IL_0001: Stack underflow*/];
		/*Error: Unexpected end of block*/;
	}
}
