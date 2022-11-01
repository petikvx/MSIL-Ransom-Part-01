using System;
using System.Runtime.InteropServices;

namespace AForge.Video.DirectShow.Internals;

[ComVisible(false)]
internal struct CAUUID
{
	public int cElems;

	public IntPtr pElems;

	public Guid[] ToGuidArray()
	{
		Guid[] array = new Guid[cElems];
		for (int i = 0; i < cElems; i++)
		{
			IntPtr ptr = new IntPtr(pElems.ToInt64() + i * Marshal.SizeOf(typeof(Guid)));
			array[i] = (Guid)Marshal.PtrToStructure(ptr, typeof(Guid));
		}
		return array;
	}
}
