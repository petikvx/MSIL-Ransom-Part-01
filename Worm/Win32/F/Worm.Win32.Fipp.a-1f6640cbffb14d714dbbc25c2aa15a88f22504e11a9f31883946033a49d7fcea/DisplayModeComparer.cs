using System;
using System.Collections;
using Microsoft.DirectX.Direct3D;

internal class DisplayModeComparer : IComparer
{
	public int Compare(object x, object y)
	{
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		DisplayMode val = (DisplayMode)(x ?? Activator.CreateInstance(typeof(DisplayMode)));
		DisplayMode val2 = (DisplayMode)(y ?? Activator.CreateInstance(typeof(DisplayMode)));
		if (((DisplayMode)(ref val)).get_Width() > ((DisplayMode)(ref val2)).get_Width())
		{
			return 1;
		}
		if (((DisplayMode)(ref val)).get_Width() < ((DisplayMode)(ref val2)).get_Width())
		{
			return -1;
		}
		if (((DisplayMode)(ref val)).get_Height() > ((DisplayMode)(ref val2)).get_Height())
		{
			return 1;
		}
		if (((DisplayMode)(ref val)).get_Height() < ((DisplayMode)(ref val2)).get_Height())
		{
			return -1;
		}
		if (((DisplayMode)(ref val)).get_Format() > ((DisplayMode)(ref val2)).get_Format())
		{
			return 1;
		}
		if (((DisplayMode)(ref val)).get_Format() < ((DisplayMode)(ref val2)).get_Format())
		{
			return -1;
		}
		if (((DisplayMode)(ref val)).get_RefreshRate() > ((DisplayMode)(ref val2)).get_RefreshRate())
		{
			return 1;
		}
		if (((DisplayMode)(ref val)).get_RefreshRate() < ((DisplayMode)(ref val2)).get_RefreshRate())
		{
			return -1;
		}
		return 0;
	}
}
