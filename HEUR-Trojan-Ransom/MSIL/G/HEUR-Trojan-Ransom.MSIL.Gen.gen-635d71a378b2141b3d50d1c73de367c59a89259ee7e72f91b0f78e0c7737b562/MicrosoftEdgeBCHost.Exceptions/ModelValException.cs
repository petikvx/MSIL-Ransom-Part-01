using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class ModelValException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ModelValException()
	{
		WriterPropertyProducer.ResolveStub();
		CheckEvent();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CheckEvent()
	{
	}
}
