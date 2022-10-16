using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class ErrorClass
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ErrorClass()
	{
		WriterPropertyProducer.ResolveStub();
		RegisterInterfaceTokenizer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RegisterInterfaceTokenizer()
	{
	}
}
