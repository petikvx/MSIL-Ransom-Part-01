using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class QueueClass
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static QueueClass()
	{
		WriterPropertyProducer.ResolveStub();
		PostInterfaceFilter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PostInterfaceFilter()
	{
	}
}
