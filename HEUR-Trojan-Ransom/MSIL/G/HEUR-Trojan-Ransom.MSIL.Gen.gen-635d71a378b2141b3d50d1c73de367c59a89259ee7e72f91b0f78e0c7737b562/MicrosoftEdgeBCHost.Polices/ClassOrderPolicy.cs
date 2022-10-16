using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class ClassOrderPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ClassOrderPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		ConnectInterfaceSerializer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ConnectInterfaceSerializer()
	{
	}
}
