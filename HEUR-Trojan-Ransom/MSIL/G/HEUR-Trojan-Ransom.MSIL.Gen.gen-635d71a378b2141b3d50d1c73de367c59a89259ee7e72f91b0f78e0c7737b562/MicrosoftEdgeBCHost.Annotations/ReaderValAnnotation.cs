using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class ReaderValAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ReaderValAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		IncludeInterfaceToken();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void IncludeInterfaceToken()
	{
	}
}
