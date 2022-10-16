using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class Specification
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static Specification()
	{
		WriterPropertyProducer.ResolveStub();
		ComputeIdentifier();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ComputeIdentifier()
	{
	}
}
