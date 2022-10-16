using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class ClientContext
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ClientContext()
	{
		WriterPropertyProducer.ResolveStub();
		StartInterfaceSpecification();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void StartInterfaceSpecification()
	{
	}
}
