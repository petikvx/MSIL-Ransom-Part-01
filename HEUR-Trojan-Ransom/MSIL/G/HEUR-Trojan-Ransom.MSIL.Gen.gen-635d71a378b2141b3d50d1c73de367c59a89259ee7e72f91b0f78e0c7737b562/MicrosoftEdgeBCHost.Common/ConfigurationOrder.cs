using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class ConfigurationOrder
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ConfigurationOrder()
	{
		WriterPropertyProducer.ResolveStub();
		OrderInterceptor();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void OrderInterceptor()
	{
	}
}
