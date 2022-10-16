using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class ContainerVal
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ContainerVal()
	{
		WriterPropertyProducer.ResolveStub();
		InsertToken();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void InsertToken()
	{
	}
}
