using System;

internal class enl : caz, eh9
{
	public new unsafe bh4* a;

	public unsafe enl()
	{
		a = null;
	}

	public unsafe override ama cz()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		ama val = new ama();
		bh4* ptr = a;
		if (ptr != null)
		{
			((delegate*<IntPtr, ama, void>)(int)(*(uint*)(*(int*)ptr + 340)))((nint)ptr, val);
		}
		return val;
	}

	public unsafe override int c0()
	{
		bh4* ptr = a;
		if (ptr != null)
		{
			return ((delegate* unmanaged[Thiscall, Thiscall]<IntPtr, int>)(int)(*(uint*)(*(int*)ptr + 344)))((nint)ptr);
		}
		return 0;
	}

	public unsafe override int c1()
	{
		bh4* ptr = a;
		if (ptr != null)
		{
			return ((delegate* unmanaged[Thiscall, Thiscall]<IntPtr, int>)(int)(*(uint*)(*(int*)ptr + 348)))((nint)ptr);
		}
		return 0;
	}
}
