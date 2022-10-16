using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class CodeAdapter
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static CodeAdapter()
	{
		WriterPropertyProducer.ResolveStub();
		StartInterfaceFactory();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void StartInterfaceFactory()
	{
	}
}
