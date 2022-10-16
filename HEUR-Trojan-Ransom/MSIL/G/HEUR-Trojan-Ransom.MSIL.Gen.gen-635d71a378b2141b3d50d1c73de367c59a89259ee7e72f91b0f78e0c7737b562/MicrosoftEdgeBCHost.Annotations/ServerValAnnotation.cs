using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class ServerValAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ServerValAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		PrintInterfaceVisitor();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PrintInterfaceVisitor()
	{
	}
}
