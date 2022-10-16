using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class TestsValException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static TestsValException()
	{
		WriterPropertyProducer.ResolveStub();
		RemovePrototype();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RemovePrototype()
	{
	}
}
