using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class SchemaGlobal
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static SchemaGlobal()
	{
		WriterPropertyProducer.ResolveStub();
		RateInterfaceCandidate();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RateInterfaceCandidate()
	{
	}
}
