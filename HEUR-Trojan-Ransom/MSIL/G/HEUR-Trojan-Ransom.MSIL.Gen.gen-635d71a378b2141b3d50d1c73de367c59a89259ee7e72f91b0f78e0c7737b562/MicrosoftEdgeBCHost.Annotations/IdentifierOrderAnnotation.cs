using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class IdentifierOrderAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static IdentifierOrderAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		AwakeLiteralStruct();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void AwakeLiteralStruct()
	{
	}
}
