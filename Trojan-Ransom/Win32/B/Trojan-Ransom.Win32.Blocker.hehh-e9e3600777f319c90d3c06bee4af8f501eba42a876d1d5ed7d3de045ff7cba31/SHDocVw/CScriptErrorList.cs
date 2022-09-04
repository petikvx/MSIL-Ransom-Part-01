using System.Runtime.InteropServices;

namespace SHDocVw;

[ComImport]
[CoClass(typeof(CScriptErrorListClass))]
[Guid("F3470F24-15FD-11D2-BB2E-00805FF7EFCA")]
public interface CScriptErrorList : IScriptErrorList
{
}
