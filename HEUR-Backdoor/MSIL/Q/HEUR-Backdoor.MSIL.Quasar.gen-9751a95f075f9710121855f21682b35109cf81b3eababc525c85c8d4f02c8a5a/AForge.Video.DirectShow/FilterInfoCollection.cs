using System;
using System.Collections;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
using AForge.Video.DirectShow.Internals;

namespace AForge.Video.DirectShow;

public class FilterInfoCollection : CollectionBase
{
	public FilterInfo this[int index] => (FilterInfo)base.InnerList[index];

	public FilterInfoCollection(Guid category)
	{
		CollectFilters(category);
	}

	private void CollectFilters(Guid category)
	{
		object obj = null;
		IEnumMoniker enumMoniker = null;
		IMoniker[] array = new IMoniker[1];
		try
		{
			Type? typeFromCLSID = Type.GetTypeFromCLSID(Clsid.SystemDeviceEnum);
			if (typeFromCLSID == null)
			{
				throw new ApplicationException("Failed creating device enumerator");
			}
			obj = Activator.CreateInstance(typeFromCLSID);
			if (((ICreateDevEnum)obj).CreateClassEnumerator(ref category, out enumMoniker, 0) != 0)
			{
				throw new ApplicationException("No devices of the category");
			}
			IntPtr zero = IntPtr.Zero;
			while (enumMoniker.Next(1, array, zero) == 0 && array[0] != null)
			{
				FilterInfo value = new FilterInfo(array[0]);
				base.InnerList.Add(value);
				Marshal.ReleaseComObject(array[0]);
				array[0] = null;
			}
			base.InnerList.Sort();
		}
		catch
		{
		}
		finally
		{
			if (obj != null)
			{
				Marshal.ReleaseComObject(obj);
				obj = null;
			}
			if (enumMoniker != null)
			{
				Marshal.ReleaseComObject(enumMoniker);
				enumMoniker = null;
			}
			if (array[0] != null)
			{
				Marshal.ReleaseComObject(array[0]);
				array[0] = null;
			}
		}
	}
}
