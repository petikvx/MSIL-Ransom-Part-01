using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class SetterObject
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static SetterObject()
	{
		WriterPropertyProducer.ResolveStub();
		VerifyLiteralPage();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void VerifyLiteralPage()
	{
	}
}
