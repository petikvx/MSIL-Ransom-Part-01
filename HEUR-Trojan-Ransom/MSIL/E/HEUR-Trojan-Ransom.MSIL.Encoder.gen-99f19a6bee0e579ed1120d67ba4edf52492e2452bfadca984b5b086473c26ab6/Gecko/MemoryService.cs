using System;
using System.Runtime.InteropServices;

namespace Gecko;

public static class MemoryService
{
	public static void MinimizeHeap(bool immeadiate)
	{
		nsIMemory service = Xpcom.GetService<nsIMemory>("@mozilla.org/xpcom/memory-service;1");
		try
		{
			service.HeapMinimize(immeadiate);
		}
		catch (Exception)
		{
		}
		finally
		{
			Marshal.ReleaseComObject(service);
		}
	}
}
