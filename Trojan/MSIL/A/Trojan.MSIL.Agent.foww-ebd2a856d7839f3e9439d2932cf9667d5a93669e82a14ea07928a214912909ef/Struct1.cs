using System;

internal struct Struct1
{
	private readonly IntPtr intptr_0;

	private readonly IntPtr intptr_1;

	public IntPtr WParam => intptr_1;

	public IntPtr LParam => intptr_0;

	public Struct1(IntPtr wParam, IntPtr lParam)
	{
		intptr_1 = wParam;
		intptr_0 = lParam;
	}
}
