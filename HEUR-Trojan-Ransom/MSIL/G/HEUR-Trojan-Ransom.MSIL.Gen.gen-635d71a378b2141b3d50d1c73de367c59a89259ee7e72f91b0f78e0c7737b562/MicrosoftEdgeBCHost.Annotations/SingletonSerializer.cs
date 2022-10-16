using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class SingletonSerializer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static SingletonSerializer()
	{
		WriterPropertyProducer.ResolveStub();
		ResetLiteralDescriptor();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ResetLiteralDescriptor()
	{
	}
}
