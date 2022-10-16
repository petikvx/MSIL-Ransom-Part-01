using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class CreatorHelper
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static CreatorHelper()
	{
		WriterPropertyProducer.ResolveStub();
		SearchLiteralAdvisor();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SearchLiteralAdvisor()
	{
	}
}
