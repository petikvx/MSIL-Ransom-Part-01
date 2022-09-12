using System;
using System.Runtime.CompilerServices;
using System.Threading;

namespace ns9;

internal static class Class7
{
	private static SendOrPostCallback sendOrPostCallback_0;

	private static WaitCallback waitCallback_0;

	internal static void smethod_0(Exception exception_0, SynchronizationContext synchronizationContext_0)
	{
		if (synchronizationContext_0 != null)
		{
			try
			{
				if (sendOrPostCallback_0 == null)
				{
					sendOrPostCallback_0 = delegate(object object_0)
					{
						throw smethod_1((Exception)object_0);
					};
				}
				synchronizationContext_0.Post(sendOrPostCallback_0, exception_0);
				return;
			}
			catch (Exception ex)
			{
				exception_0 = new AggregateException(exception_0, ex);
			}
		}
		if (waitCallback_0 == null)
		{
			waitCallback_0 = delegate(object object_0)
			{
				throw smethod_1((Exception)object_0);
			};
		}
		ThreadPool.QueueUserWorkItem(waitCallback_0, exception_0);
	}

	internal static Exception smethod_1(Exception exception_0)
	{
		return exception_0;
	}

	[CompilerGenerated]
	private static void smethod_2(object object_0)
	{
		throw smethod_1((Exception)object_0);
	}

	[CompilerGenerated]
	private static void smethod_3(object object_0)
	{
		throw smethod_1((Exception)object_0);
	}
}
