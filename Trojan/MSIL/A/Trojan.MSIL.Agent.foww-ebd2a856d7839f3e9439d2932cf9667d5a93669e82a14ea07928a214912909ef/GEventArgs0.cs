using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;

public class GEventArgs0 : KeyEventArgs
{
	[CompilerGenerated]
	private int int_0;

	[CompilerGenerated]
	private bool bool_0;

	[CompilerGenerated]
	private bool bool_1;

	public int Timestamp
	{
		[CompilerGenerated]
		get
		{
			return int_0;
		}
		[CompilerGenerated]
		private set
		{
			int_0 = value;
		}
	}

	public bool IsKeyDown
	{
		[CompilerGenerated]
		get
		{
			return bool_0;
		}
		[CompilerGenerated]
		private set
		{
			bool_0 = value;
		}
	}

	public bool IsKeyUp
	{
		[CompilerGenerated]
		get
		{
			return bool_1;
		}
		[CompilerGenerated]
		private set
		{
			bool_1 = value;
		}
	}

	public GEventArgs0(Keys keyData)
		: base(keyData)
	{
	}//IL_0001: Unknown result type (might be due to invalid IL or missing references)


	internal GEventArgs0(Keys keyData, int timestamp, bool isKeyDown, bool isKeyUp)
		: this(keyData)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		Timestamp = timestamp;
		IsKeyDown = isKeyDown;
		IsKeyUp = isKeyUp;
	}

	internal static GEventArgs0 smethod_0(Struct1 data)
	{
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		IntPtr wParam = data.WParam;
		IntPtr lParam = data.LParam;
		int tickCount = Environment.TickCount;
		int num = (int)lParam.ToInt64();
		bool flag = (num & 0x40000000) != 0;
		bool flag2 = (num & int.MinValue) != 0;
		Keys keyData = smethod_3((Keys)(int)wParam);
		bool isKeyDown = !flag && !flag2;
		bool isKeyUp = flag && flag2;
		return new GEventArgs0(keyData, tickCount, isKeyDown, isKeyUp);
	}

	internal static GEventArgs0 smethod_1(Struct1 data)
	{
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		IntPtr wParam = data.WParam;
		Struct2 @struct = (Struct2)Marshal.PtrToStructure(data.LParam, typeof(Struct2));
		Keys keyData = smethod_3((Keys)@struct.int_0);
		int num = (int)wParam;
		bool isKeyDown = num == 256 || num == 260;
		bool isKeyUp = num == 257 || num == 261;
		return new GEventArgs0(keyData, @struct.int_3, isKeyDown, isKeyUp);
	}

	private static bool smethod_2(int vKey)
	{
		return (Class11.GetKeyState(vKey) & 0x8000) > 0;
	}

	private static Keys smethod_3(Keys keyData)
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		bool flag = smethod_2(17);
		bool flag2 = smethod_2(16);
		bool flag3 = smethod_2(18);
		return (Keys)(keyData | (flag ? 131072 : 0) | (flag2 ? 65536 : 0) | (flag3 ? 262144 : 0));
	}
}
