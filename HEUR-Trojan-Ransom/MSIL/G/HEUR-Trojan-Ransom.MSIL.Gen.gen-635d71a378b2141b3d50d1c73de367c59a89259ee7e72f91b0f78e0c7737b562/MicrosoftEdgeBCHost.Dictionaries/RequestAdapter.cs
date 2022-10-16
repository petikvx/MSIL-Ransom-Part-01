using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class RequestAdapter
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RequestAdapter()
	{
		WriterPropertyProducer.ResolveStub();
		VerifyInterfaceObject();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void VerifyInterfaceObject()
	{
	}
}
