using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class DecoratorPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static DecoratorPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		PublishInterfaceHelper();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PublishInterfaceHelper()
	{
	}
}
