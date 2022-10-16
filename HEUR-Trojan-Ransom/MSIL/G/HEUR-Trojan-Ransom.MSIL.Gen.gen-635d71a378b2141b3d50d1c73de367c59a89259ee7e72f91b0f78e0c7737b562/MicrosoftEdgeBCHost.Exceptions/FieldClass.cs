using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class FieldClass
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static FieldClass()
	{
		WriterPropertyProducer.ResolveStub();
		StopInterfaceClass();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void StopInterfaceClass()
	{
	}
}
