using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class TokenProperty
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static TokenProperty()
	{
		WriterPropertyProducer.ResolveStub();
		StartInterfaceDescriptor();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void StartInterfaceDescriptor()
	{
	}
}
