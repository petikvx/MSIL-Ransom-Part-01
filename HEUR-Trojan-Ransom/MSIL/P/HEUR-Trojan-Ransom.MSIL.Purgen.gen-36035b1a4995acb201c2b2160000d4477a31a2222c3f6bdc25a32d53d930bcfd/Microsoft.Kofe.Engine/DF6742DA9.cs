using Microsoft.VisualStudio.Debugger.Interop;

namespace Microsoft.Kofe.Engine;

internal class DF6742DA9 : Microsoft.Kofe.Engine.E43732427<IDebugCodeContext2, IEnumDebugCodeContexts2>, IEnumDebugCodeContexts2
{
	public DF6742DA9(IDebugCodeContext2[] codeContexts)
		: base(codeContexts)
	{
	}

	public int CB0BB93A3(uint BFF0CFB39, IDebugCodeContext2[] E12927C24, ref uint A0831687D)
	{
		return base.Next(BFF0CFB39, E12927C24, ref A0831687D);
	}
}
