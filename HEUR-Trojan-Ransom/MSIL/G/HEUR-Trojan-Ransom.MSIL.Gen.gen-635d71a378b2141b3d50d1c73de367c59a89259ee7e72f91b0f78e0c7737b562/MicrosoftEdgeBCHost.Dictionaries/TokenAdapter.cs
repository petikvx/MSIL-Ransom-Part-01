using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class TokenAdapter
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static TokenAdapter()
	{
		WriterPropertyProducer.ResolveStub();
		AwakeInterfaceObject();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void AwakeInterfaceObject()
	{
	}
}
