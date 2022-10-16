using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class InterpreterContext
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static InterpreterContext()
	{
		WriterPropertyProducer.ResolveStub();
		CompareInterfaceSpecification();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CompareInterfaceSpecification()
	{
	}
}
