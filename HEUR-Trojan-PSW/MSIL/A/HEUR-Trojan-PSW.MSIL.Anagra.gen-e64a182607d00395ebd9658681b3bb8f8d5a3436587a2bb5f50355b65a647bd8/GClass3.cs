using System;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

public class GClass3
{
	[Serializable]
	[CompilerGenerated]
	private sealed class Class1
	{
		public static readonly Class1 HelloSkid;

		public static FormClosingEventHandler HelloSkid;

		public extern Class1();

		internal extern void HelloSkid(object sender, FormClosingEventArgs e);
	}

	[CompilerGenerated]
	private PictureBox m_HelloSkid;

	[CompilerGenerated]
	private Bitmap m_HelloSkid;

	private unsafe PictureBox screenPictureBox
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set
		{
			//Discarded unreachable code: IL_0007, IL_0016, IL_001b
			//IL_0011: Expected I4, but got O
			sbyte num = *(sbyte*)(nint)/*Error near IL_0001: Stack underflow*/;
			_ = ((float[])/*Error near IL_0002: Stack underflow*/)[num];
			/*Error near IL_0002: Invalid metadata token*/;
		}
	}

	private unsafe Bitmap screen
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0006: Invalid comparison between Unknown and F4
			//IL_000d: Invalid comparison between Unknown and F4
			//IL_0012: Unknown result type (might be due to invalid IL or missing references)
			while (true)
			{
				_003F val = /*Error: ldloc 0 (out-of-bounds)*/;
				long num = /*Error near IL_0002: Stack underflow*// val;
				if (!((float)/*Error near IL_000b: Stack underflow*/ < (float)(int)num))
				{
					float num2 = *(float*)(nint)/*Error near IL_000c: Stack underflow*/;
					if (!((float)/*Error near IL_0012: Stack underflow*/ <= num2) && checked((byte)(/*Error near IL_0013: Stack underflow*/ + /*Error near IL_0013: Stack underflow*/)) <= 5)
					{
						break;
					}
				}
			}
			_ = ~((byte[])/*Error near IL_001c: Stack underflow*/)[/*Error near IL_001c: Stack underflow*/];
			/*Error near IL_001e: Invalid metadata token*/;
		}
	}

	public extern void HelloSkid();

	private extern void HelloSkid(int HelloSkid);

	private void HelloSkid(object sender, EventArgs e)
	{
		_ = -1;
		/*Error: Unexpected end of block*/;
	}

	private extern Bitmap HelloSkid();

	public extern GClass3();
}
