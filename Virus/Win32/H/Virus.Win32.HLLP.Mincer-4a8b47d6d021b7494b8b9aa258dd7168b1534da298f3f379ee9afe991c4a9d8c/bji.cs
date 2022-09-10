using System;

internal class bji : caz, b9r
{
	public new unsafe cwr* a;

	public unsafe bji()
	{
		a = null;
	}

	public unsafe override ama cz()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		ama val = new ama();
		cwr* ptr = a;
		if (ptr != null)
		{
			((delegate*<IntPtr, ama, void>)(int)(*(uint*)(*(int*)ptr + 340)))((nint)ptr, val);
		}
		return val;
	}

	public unsafe override int c0()
	{
		cwr* ptr = a;
		if (ptr != null)
		{
			return ((delegate* unmanaged[Thiscall, Thiscall]<IntPtr, int>)(int)(*(uint*)(*(int*)ptr + 344)))((nint)ptr);
		}
		return 0;
	}

	public unsafe override int c1()
	{
		cwr* ptr = a;
		if (ptr != null)
		{
			return ((delegate* unmanaged[Thiscall, Thiscall]<IntPtr, int>)(int)(*(uint*)(*(int*)ptr + 348)))((nint)ptr);
		}
		return 0;
	}
}
