using System;

namespace Gecko.Collections;

internal static class GeckoCollectionsHelper
{
	internal static nsIMutableArray CreateArray()
	{
		return Xpcom.CreateInstance<nsIMutableArray>("@mozilla.org/array;1");
	}

	internal static T GetElementAs<T>(this nsIArray array, int index)
	{
		Guid uuid = typeof(T).GUID;
		IntPtr ptr = array.QueryElementAt((uint)index, ref uuid);
		return (T)Xpcom.GetObjectForIUnknown(ptr);
	}
}
