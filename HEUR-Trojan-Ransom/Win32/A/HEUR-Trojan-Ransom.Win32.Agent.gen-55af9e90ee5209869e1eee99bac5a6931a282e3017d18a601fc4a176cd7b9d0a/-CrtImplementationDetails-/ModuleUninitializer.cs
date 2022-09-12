using System;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;
using System.Security;
using System.Threading;

namespace _003CCrtImplementationDetails_003E;

internal class ModuleUninitializer : Stack
{
	private static object @lock = new object();

	internal static ModuleUninitializer _ModuleUninitializer = new ModuleUninitializer();

	[SecuritySafeCritical]
	internal void AddHandler(EventHandler handler)
	{
		bool lockTaken = false;
		RuntimeHelpers.PrepareConstrainedRegions();
		try
		{
			RuntimeHelpers.PrepareConstrainedRegions();
			Monitor.Enter(@lock, ref lockTaken);
			RuntimeHelpers.PrepareDelegate(handler);
			Push(handler);
		}
		finally
		{
			if (lockTaken)
			{
				Monitor.Exit(@lock);
			}
		}
	}

	[SecuritySafeCritical]
	private ModuleUninitializer()
	{
		EventHandler eventHandler = null;
		base._002Ector();
		eventHandler = SingletonDomainUnload;
		AppDomain.CurrentDomain.DomainUnload += eventHandler;
		AppDomain.CurrentDomain.ProcessExit += eventHandler;
	}

	[SecurityCritical]
	[PrePrepareMethod]
	private void SingletonDomainUnload(object sender, EventArgs e)
	{
		IEnumerator enumerator = null;
		EventHandler eventHandler = null;
		bool lockTaken = false;
		RuntimeHelpers.PrepareConstrainedRegions();
		try
		{
			RuntimeHelpers.PrepareConstrainedRegions();
			Monitor.Enter(@lock, ref lockTaken);
			IEnumerator enumerator2 = GetEnumerator();
			try
			{
				while (enumerator2.MoveNext())
				{
					eventHandler = (EventHandler)enumerator2.Current;
					eventHandler(sender, e);
				}
			}
			finally
			{
				IDisposable disposable = enumerator2 as IDisposable;
				if (disposable != null)
				{
					disposable.Dispose();
				}
			}
		}
		finally
		{
			if (lockTaken)
			{
				Monitor.Exit(@lock);
			}
		}
	}
}
