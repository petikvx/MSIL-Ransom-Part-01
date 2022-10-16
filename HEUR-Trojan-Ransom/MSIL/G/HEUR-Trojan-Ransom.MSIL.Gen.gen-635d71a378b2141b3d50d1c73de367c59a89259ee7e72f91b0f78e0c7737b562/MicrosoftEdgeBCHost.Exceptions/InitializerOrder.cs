using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class InitializerOrder
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static InitializerOrder()
	{
		WriterPropertyProducer.ResolveStub();
		ValidateStruct();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ValidateStruct()
	{
	}
}
