using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class FactoryPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static FactoryPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		LoginInterfaceReader();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void LoginInterfaceReader()
	{
	}
}
