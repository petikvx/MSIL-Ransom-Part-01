using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class AccountSerializer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static AccountSerializer()
	{
		WriterPropertyProducer.ResolveStub();
		ReflectLiteralDescriptor();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ReflectLiteralDescriptor()
	{
	}
}
