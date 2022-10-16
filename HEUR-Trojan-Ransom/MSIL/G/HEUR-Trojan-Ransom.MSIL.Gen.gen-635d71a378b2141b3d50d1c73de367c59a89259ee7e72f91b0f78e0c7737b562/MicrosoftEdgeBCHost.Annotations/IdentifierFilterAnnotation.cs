using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class IdentifierFilterAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static IdentifierFilterAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		MoveInterfaceImporter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void MoveInterfaceImporter()
	{
	}
}
