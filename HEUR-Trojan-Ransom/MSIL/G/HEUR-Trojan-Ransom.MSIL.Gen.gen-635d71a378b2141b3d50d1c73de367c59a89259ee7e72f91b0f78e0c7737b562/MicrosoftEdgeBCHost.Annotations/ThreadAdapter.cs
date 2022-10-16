using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class ThreadAdapter
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ThreadAdapter()
	{
		WriterPropertyProducer.ResolveStub();
		ValidateInterfaceError();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ValidateInterfaceError()
	{
	}
}
