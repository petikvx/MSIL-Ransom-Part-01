using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class ModelFilter
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ModelFilter()
	{
		WriterPropertyProducer.ResolveStub();
		CheckMock();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CheckMock()
	{
	}
}
