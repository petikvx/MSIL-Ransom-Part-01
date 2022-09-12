using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("AEB8936F-219C-4D3C-8385-D9382DAA551A")]
public interface mozISpellI18NManager
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	mozISpellI18NUtil GetUtil([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.WStringMarshaler")] string language);
}
