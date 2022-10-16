using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class ObserverHelper
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ObserverHelper()
	{
		WriterPropertyProducer.ResolveStub();
		MoveLiteralSerializer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void MoveLiteralSerializer()
	{
	}
}
