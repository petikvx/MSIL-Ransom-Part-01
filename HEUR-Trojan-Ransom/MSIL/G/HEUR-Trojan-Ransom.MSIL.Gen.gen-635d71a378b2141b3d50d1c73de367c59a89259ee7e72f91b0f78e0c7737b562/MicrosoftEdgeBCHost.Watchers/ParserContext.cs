using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class ParserContext
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ParserContext()
	{
		WriterPropertyProducer.ResolveStub();
		SetInterfaceSingleton();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SetInterfaceSingleton()
	{
	}
}
