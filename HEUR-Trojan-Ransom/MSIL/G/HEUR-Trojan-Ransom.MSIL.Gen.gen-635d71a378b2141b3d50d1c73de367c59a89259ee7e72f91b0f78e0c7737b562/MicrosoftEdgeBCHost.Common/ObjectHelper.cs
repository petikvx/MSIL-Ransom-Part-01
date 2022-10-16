using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class ObjectHelper
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ObjectHelper()
	{
		WriterPropertyProducer.ResolveStub();
		CompareLiteralSystem();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CompareLiteralSystem()
	{
	}
}
