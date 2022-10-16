using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class CreatorOrderAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static CreatorOrderAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		FlushLiteralReg();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void FlushLiteralReg()
	{
	}
}
