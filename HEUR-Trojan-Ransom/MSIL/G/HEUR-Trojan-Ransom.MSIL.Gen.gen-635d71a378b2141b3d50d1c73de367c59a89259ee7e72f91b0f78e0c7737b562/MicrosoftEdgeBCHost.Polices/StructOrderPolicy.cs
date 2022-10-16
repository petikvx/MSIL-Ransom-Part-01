using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class StructOrderPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static StructOrderPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		EnableLiteralDescriptor();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void EnableLiteralDescriptor()
	{
	}
}
