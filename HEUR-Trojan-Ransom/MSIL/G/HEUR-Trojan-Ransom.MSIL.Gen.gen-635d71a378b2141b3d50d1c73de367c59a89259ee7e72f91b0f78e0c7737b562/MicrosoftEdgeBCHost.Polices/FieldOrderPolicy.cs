using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class FieldOrderPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static FieldOrderPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		CloneLiteralImporter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CloneLiteralImporter()
	{
	}
}
