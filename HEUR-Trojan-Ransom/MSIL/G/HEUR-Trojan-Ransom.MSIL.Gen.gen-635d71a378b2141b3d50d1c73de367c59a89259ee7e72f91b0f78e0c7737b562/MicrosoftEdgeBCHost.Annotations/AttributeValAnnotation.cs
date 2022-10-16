using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class AttributeValAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static AttributeValAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		VerifyLiteralIdentifier();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void VerifyLiteralIdentifier()
	{
	}
}
