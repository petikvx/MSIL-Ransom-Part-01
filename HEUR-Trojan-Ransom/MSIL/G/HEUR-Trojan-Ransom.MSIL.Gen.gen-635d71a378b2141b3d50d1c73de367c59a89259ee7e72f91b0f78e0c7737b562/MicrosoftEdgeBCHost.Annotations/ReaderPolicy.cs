using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class ReaderPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ReaderPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		LogoutInterfaceReader();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void LogoutInterfaceReader()
	{
	}
}
