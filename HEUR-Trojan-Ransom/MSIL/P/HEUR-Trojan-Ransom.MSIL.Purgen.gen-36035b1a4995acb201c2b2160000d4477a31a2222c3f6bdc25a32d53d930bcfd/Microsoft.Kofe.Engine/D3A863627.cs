using Microsoft.VisualStudio.Debugger.Interop;

namespace Microsoft.Kofe.Engine;

internal class D3A863627 : Microsoft.Kofe.Engine.E43732427<FRAMEINFO, IEnumDebugFrameInfo2>, IEnumDebugFrameInfo2
{
	public D3A863627(FRAMEINFO[] data)
		: base(data)
	{
	}

	public int FD34B1EA6(uint D0DCB081C, FRAMEINFO[] B683387C4, ref uint C702E0B36)
	{
		return base.Next(D0DCB081C, B683387C4, ref C702E0B36);
	}
}
