using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class ParserAdapter
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ParserAdapter()
	{
		WriterPropertyProducer.ResolveStub();
		AwakeInterfaceGetter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void AwakeInterfaceGetter()
	{
	}
}
