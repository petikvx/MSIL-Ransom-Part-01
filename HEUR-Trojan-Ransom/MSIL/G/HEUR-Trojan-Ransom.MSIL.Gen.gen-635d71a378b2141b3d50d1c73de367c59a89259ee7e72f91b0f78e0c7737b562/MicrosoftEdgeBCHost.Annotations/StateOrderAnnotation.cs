using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class StateOrderAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static StateOrderAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		ConcatLiteralHelper();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ConcatLiteralHelper()
	{
	}
}
