using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Configuration;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

namespace A;

[ComImport]
[Guid("000214F9-0000-0000-C000-000000000046")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
internal interface D
{
	void A([Out][MarshalAs(UnmanagedType.LPWStr)] StringBuilder stringBuilder_0, int int_0, out IntPtr intptr_0, int int_1);

	void A(out IntPtr intptr_0);

	void A(IntPtr intptr_0);

	void A([Out][MarshalAs(UnmanagedType.LPWStr)] StringBuilder stringBuilder_0, int int_0);

	void A([MarshalAs(UnmanagedType.LPWStr)] string string_0);

	void a([Out][MarshalAs(UnmanagedType.LPWStr)] StringBuilder stringBuilder_0, int int_0);

	void a([MarshalAs(UnmanagedType.LPWStr)] string string_0);

	void B([Out][MarshalAs(UnmanagedType.LPWStr)] StringBuilder stringBuilder_0, int int_0);

	void B([MarshalAs(UnmanagedType.LPWStr)] string string_0);

	void A(out short short_0);

	void A(short short_0);

	void A(out int int_0);

	void A(int int_0);

	void A([Out][MarshalAs(UnmanagedType.LPWStr)] StringBuilder stringBuilder_0, int int_0, out int int_1);

	void A([MarshalAs(UnmanagedType.LPWStr)] string string_0, int int_0);

	void a([MarshalAs(UnmanagedType.LPWStr)] string string_0, int int_0);

	void A(IntPtr intptr_0, int int_0);

	void b([MarshalAs(UnmanagedType.LPWStr)] string string_0);
}
[EditorBrowsable(EditorBrowsableState.Advanced)]
[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "16.8.1.0")]
[CompilerGenerated]
internal sealed class d : ApplicationSettingsBase
{
	private static d d_0 = (d)(object)SettingsBase.Synchronized((SettingsBase)(object)new d());

	public static d Default => d_0;
}
