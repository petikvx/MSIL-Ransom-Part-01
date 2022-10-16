using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class FacadeHelper
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static FacadeHelper()
	{
		WriterPropertyProducer.ResolveStub();
		LoginLiteralAdvisor();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void LoginLiteralAdvisor()
	{
	}
}
