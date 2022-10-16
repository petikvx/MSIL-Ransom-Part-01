using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class DescriptorServer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static DescriptorServer()
	{
		WriterPropertyProducer.ResolveStub();
		ConnectLiteralInterpreter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ConnectLiteralInterpreter()
	{
	}
}
