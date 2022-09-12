using System;
using System.Collections.Generic;
using System.Collections.Generic.Internal;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

namespace ns1;

public static class GClass0
{
	internal static int int_0;

	private const uint uint_0 = default(uint);

	private const uint uint_1 = default(uint);

	public static void smethod_0()
	{
		int_0 = MinCore.GetLastWin32Error();
	}

	public static bool smethod_1(ref Guid guid_0, ref Guid guid_1)
	{
		return InteropExtensions.GuidEquals(ref guid_0, ref guid_1);
	}

	public static bool smethod_2<T>(T gparam_0, T gparam_1)
	{
		return InteropExtensions.ComparerEquals<T>(gparam_0, gparam_1);
	}

	public static T smethod_3<T>() where T : class
	{
		return InteropExtensions.UncheckedCast<T>(InteropExtensions.RuntimeNewObject(typeof(T).TypeHandle));
	}

	public static bool smethod_4(object object_0)
	{
		return InteropExtensions.IsEnum(InteropExtensions.GetTypeHandle(object_0));
	}

	public static bool smethod_5(Type type_0)
	{
		if (!type_0.Equals(typeof(__ComObject)))
		{
			return type_0.GetTypeInfo().IsSubclassOf(typeof(__ComObject));
		}
		return true;
	}

	public static T smethod_6<T>(object object_0) where T : class
	{
		return InteropExtensions.UncheckedCast<T>(object_0);
	}

	public static double smethod_7(DateTime dateTime_0)
	{
		return InteropExtensions.ToNativeOleDate(dateTime_0);
	}

	public static DateTime smethod_8(double double_0)
	{
		return InteropExtensions.FromNativeOleDate(double_0);
	}

	public static void smethod_9(SafeHandle safeHandle_0, IntPtr intptr_0)
	{
		InteropExtensions.InitializeHandle(safeHandle_0, intptr_0);
	}

	public static bool smethod_10(object object_0, RuntimeTypeHandle runtimeTypeHandle_0)
	{
		return InteropExtensions.IsOfType(object_0, runtimeTypeHandle_0);
	}

	public static void smethod_11(Exception exception_0, int int_1)
	{
		InteropExtensions.SetExceptionErrorCode(exception_0, int_1);
	}

	public static Type smethod_12(HSTRING hstring_0, int int_1)
	{
		throw new NotSupportedException("艾儿儿贼艾杰贼儿艾艾儿儿杰儿儿贼杰艾贼艾杰杰艾杰贼");
	}

	public static void smethod_13(Type type_0, ref HSTRING hstring_0, ref int int_1)
	{
		throw new NotSupportedException("丝丝西艾西丝西屁西艾西西西屁艾屁西艾丝西马屁艾丝西马");
	}

	[CLSCompliant(/*Could not decode attribute arguments.*/)]
	public unsafe static void smethod_14(StringBuilder stringBuilder_0, ushort* pUshort_0)
	{
		InteropExtensions.UnsafeCopyTo(stringBuilder_0, (char*)pUshort_0);
	}

	[CLSCompliant(/*Could not decode attribute arguments.*/)]
	public unsafe static void smethod_15(ushort* pUshort_0, StringBuilder stringBuilder_0)
	{
		InteropExtensions.ReplaceBuffer(stringBuilder_0, (char*)pUshort_0);
	}

	[CLSCompliant(/*Could not decode attribute arguments.*/)]
	public unsafe static void smethod_16(StringBuilder stringBuilder_0, byte* pByte_0, bool bool_0, bool bool_1)
	{
		int int_ = default(int);
		char[] buffer = InteropExtensions.GetBuffer(stringBuilder_0, ref int_);
		if (buffer != null)
		{
			fixed (char* pChar_ = buffer)
			{
				smethod_29(pChar_, int_, pByte_0, bool_0: true, bool_0, bool_1);
			}
			return;
		}
		string text = stringBuilder_0.ToString();
		fixed (char* pChar_2 = text)
		{
			smethod_29(pChar_2, text.Length, pByte_0, bool_0: true, bool_0, bool_1);
		}
	}

	[CLSCompliant(/*Could not decode attribute arguments.*/)]
	public unsafe static void smethod_17(byte* pByte_0, StringBuilder stringBuilder_0)
	{
		if (pByte_0 == null)
		{
			throw new ArgumentNullException();
		}
		int int_ = default(int);
		int int_2 = default(int);
		smethod_30(pByte_0, ref int_, ref int_2);
		if (int_2 > 0)
		{
			char[] array = new char[int_2];
			fixed (char* value = array)
			{
				CoreString.MultiByteToWideChar(0u, 0u, new IntPtr(pByte_0), int_, new IntPtr(value), int_2);
			}
			InteropExtensions.ReplaceBuffer(stringBuilder_0, array);
		}
		else
		{
			stringBuilder_0.Clear();
		}
	}

	[CLSCompliant(/*Could not decode attribute arguments.*/)]
	public unsafe static string smethod_18(byte* pByte_0)
	{
		if (pByte_0 == null)
		{
			return null;
		}
		int int_ = default(int);
		int int_2 = default(int);
		smethod_30(pByte_0, ref int_, ref int_2);
		string text = string.Empty;
		if (int_2 > 0)
		{
			text = new string(' ', int_2);
			fixed (char* value = text)
			{
				CoreString.MultiByteToWideChar(0u, 0u, new IntPtr(pByte_0), int_, new IntPtr(value), int_2);
			}
		}
		return text;
	}

	[CLSCompliant(/*Could not decode attribute arguments.*/)]
	public unsafe static byte* smethod_19(string string_0, bool bool_0, bool bool_1)
	{
		if (string_0 != null)
		{
			int length = string_0.Length;
			fixed (char* pChar_ = string_0)
			{
				return smethod_29(pChar_, length, null, bool_0: true, bool_0, bool_1);
			}
		}
		return null;
	}

	[CLSCompliant(/*Could not decode attribute arguments.*/)]
	public unsafe static void smethod_20(char[] char_0, byte* pByte_0, int int_1, bool bool_0, bool bool_1)
	{
		if (char_0 == null)
		{
			for (int i = 0; i < int_1; i++)
			{
				pByte_0[i] = 0;
			}
		}
		int num = char_0.Length;
		if (num < int_1)
		{
			throw new ArgumentException(System.SR.get_WrongSizeArrayInNStruct());
		}
		fixed (char* pChar_ = char_0)
		{
			smethod_29(pChar_, num, pByte_0, bool_0: false, bool_0, bool_1);
		}
	}

	[CLSCompliant(/*Could not decode attribute arguments.*/)]
	public unsafe static void smethod_21(byte* pByte_0, char[] char_0)
	{
		int num = char_0.Length;
		fixed (char* value = char_0)
		{
			CoreString.MultiByteToWideChar(0u, 0u, new IntPtr(pByte_0), num, new IntPtr(value), num);
		}
	}

	[CLSCompliant(/*Could not decode attribute arguments.*/)]
	public unsafe static void smethod_22(char[] char_0, byte* pByte_0, bool bool_0, bool bool_1)
	{
		if (char_0 != null)
		{
			if (pByte_0 == null)
			{
				throw new ArgumentNullException();
			}
			int int_ = char_0.Length;
			fixed (char* pChar_ = char_0)
			{
				smethod_29(pChar_, int_, pByte_0, bool_0: false, bool_0, bool_1);
			}
		}
	}

	[CLSCompliant(/*Could not decode attribute arguments.*/)]
	public unsafe static void smethod_23(byte* pByte_0, char[] char_0)
	{
		if (pByte_0 != null)
		{
			if (char_0 == null)
			{
				throw new ArgumentNullException();
			}
			int num = char_0.Length;
			fixed (char* value = char_0)
			{
				CoreString.MultiByteToWideChar(0u, 0u, new IntPtr(pByte_0), num, new IntPtr(value), num);
			}
		}
	}

	public unsafe static byte smethod_24(char char_0, bool bool_0, bool bool_1)
	{
		byte* intPtr = smethod_29(&char_0, 1, null, bool_0: false, bool_0, bool_1);
		byte result = *intPtr;
		COM.CoTaskMemFree(new IntPtr(intPtr));
		return result;
	}

	public unsafe static char smethod_25(byte byte_0)
	{
		char[] array = new char[1];
		fixed (char* value = array)
		{
			CoreString.MultiByteToWideChar(0u, 0u, new IntPtr(&byte_0), 1, new IntPtr(value), 1);
			return array[0];
		}
	}

	[CLSCompliant(/*Could not decode attribute arguments.*/)]
	public unsafe static void smethod_26(string string_0, byte* pByte_0, int int_1, bool bool_0, bool bool_1)
	{
		if (pByte_0 == null)
		{
			throw new ArgumentNullException();
		}
		if (string_0 != null)
		{
			int num = string_0.Length;
			if (num >= int_1)
			{
				num = int_1 - 1;
			}
			fixed (char* pChar_ = string_0)
			{
				smethod_29(pChar_, num, pByte_0, bool_0: true, bool_0, bool_1);
			}
		}
		else
		{
			*pByte_0 = 0;
		}
	}

	[CLSCompliant(/*Could not decode attribute arguments.*/)]
	public unsafe static string smethod_27(byte* pByte_0, int int_1)
	{
		if (int_1 == 0)
		{
			throw new MarshalDirectiveException();
		}
		int num = smethod_28(pByte_0);
		string result = string.Empty;
		if (int_1 > 0)
		{
			char* value = stackalloc char[int_1];
			int num2 = CoreString.MultiByteToWideChar(0u, 0u, new IntPtr(pByte_0), num, new IntPtr(value), int_1);
			if (num2 > 0)
			{
				result = new string(value, 0, num2);
			}
		}
		return result;
	}

	private unsafe static int smethod_28(byte* pByte_0)
	{
		byte* ptr = pByte_0;
		while (*pByte_0 != 0)
		{
			pByte_0++;
		}
		return (int)(pByte_0 - ptr);
	}

	private unsafe static byte* smethod_29(char* pChar_0, int int_1, byte* pByte_0, bool bool_0, bool bool_1, bool bool_2)
	{
		bool flag = true;
		for (int i = 0; i < int_1; i++)
		{
			if (pChar_0[i] >= '\u0080')
			{
				flag = false;
				break;
			}
		}
		int num = ((!flag) ? CoreString.WideCharToMultiByte(0u, 1024u, pChar_0, int_1, (IntPtr)0, 0, (IntPtr)0, (IntPtr)0) : int_1);
		if (pByte_0 == null)
		{
			pByte_0 = (byte*)(void*)COM.CoTaskMemAlloc((IntPtr)(num + 1));
		}
		if (pByte_0 != null)
		{
			if (flag)
			{
				byte* ptr = pByte_0;
				char* ptr2 = pChar_0;
				while (int_1 > 0)
				{
					byte* intPtr = ptr++;
					char* num2 = ptr2;
					ptr2 = num2 + 1;
					*intPtr = (byte)(*num2);
					int_1--;
				}
			}
			else
			{
				uint num3 = ((!bool_1) ? 1024u : 0u);
				uint num4 = 0u;
				CoreString.WideCharToMultiByte(0u, num3, pChar_0, int_1, new IntPtr(pByte_0), num, (IntPtr)0, bool_2 ? new IntPtr(&num4) : ((IntPtr)0));
				if (num4 != 0)
				{
					throw new ArgumentException(System.SR.get_Arg_InteropMarshalUnmappableChar());
				}
			}
			if (bool_0)
			{
				pByte_0[num] = 0;
			}
			return pByte_0;
		}
		return null;
	}

	private unsafe static bool smethod_30(byte* pByte_0, ref int int_1, ref int int_2)
	{
		int_1 = 0;
		bool flag = true;
		byte* ptr = pByte_0;
		for (byte b = *(ptr++); b != 0; b = *(ptr++))
		{
			if (b >= 128)
			{
				flag = false;
			}
			int_1++;
		}
		if (flag)
		{
			int_2 = int_1;
		}
		else
		{
			int_2 = CoreString.MultiByteToWideChar(0u, 0u, new IntPtr(pByte_0), int_1, (IntPtr)0, 0);
		}
		return flag;
	}

	public unsafe static void smethod_31(char* pChar_0, string string_0, HSTRING_HEADER* pHstring_HEADER_0, HSTRING* pHstring_0)
	{
		if (string_0 == null)
		{
			throw new ArgumentNullException(System.SR.get_Null_HString());
		}
		int num = ExternalInterop.WindowsCreateStringReference(pChar_0, string_0.Length, pHstring_HEADER_0, (void**)pHstring_0);
		if (num < 0)
		{
			throw Marshal.GetExceptionForHR(num);
		}
	}

	public static HSTRING smethod_32(string string_0)
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		if (string_0 == null)
		{
			throw new ArgumentNullException(System.SR.get_Null_HString());
		}
		return smethod_34(string_0);
	}

	public static HSTRING smethod_33(string string_0)
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		if (string_0 == null)
		{
			throw new MarshalDirectiveException(System.SR.get_BadMarshalField_Null_HString());
		}
		return smethod_34(string_0);
	}

	private unsafe static HSTRING smethod_34(string string_0)
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		HSTRING result = default(HSTRING);
		int num = smethod_35(string_0, &result);
		if (num < 0)
		{
			throw Marshal.GetExceptionForHR(num);
		}
		return result;
	}

	internal unsafe static int smethod_35(string string_0, HSTRING* pHstring_0)
	{
		fixed (char* ptr = string_0)
		{
			return WinRT.WindowsCreateString(ptr, (uint)string_0.Length, (void*)pHstring_0);
		}
	}

	internal static string smethod_36(IntPtr intptr_0)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return smethod_37(new HSTRING(intptr_0));
	}

	public unsafe static string smethod_37(HSTRING hstring_0)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		if (hstring_0.handle == IntPtr.Zero)
		{
			return string.Empty;
		}
		uint length = 0u;
		return new string(ExternalInterop.WindowsGetStringRawBuffer(hstring_0.handle.ToPointer(), &length), 0, (int)length);
	}

	public unsafe static void smethod_38(IntPtr intptr_0)
	{
		ExternalInterop.WindowsDeleteString(intptr_0.ToPointer());
	}

	[CLSCompliant(/*Could not decode attribute arguments.*/)]
	public static int smethod_39(__ComObject __ComObject_0)
	{
		return __ComObject_0.AddRef();
	}

	[CLSCompliant(/*Could not decode attribute arguments.*/)]
	public static int smethod_40(__ComObject __ComObject_0)
	{
		return __ComObject_0.Release();
	}

	public unsafe static int smethod_41(IntPtr intptr_0)
	{
		return CalliIntrinsics.StdCall__AddRef(((__vtable_IUnknown)((__com_IUnknown)(void*)intptr_0).pVtable).pfnAddRef, intptr_0);
	}

	internal unsafe static int smethod_42(IntPtr intptr_0)
	{
		return CalliIntrinsics.StdCall__Release(((__vtable_IUnknown)((__com_IUnknown)(void*)intptr_0).pVtable).pfnRelease, intptr_0);
	}

	public unsafe static int smethod_43(IntPtr intptr_0)
	{
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Expected O, but got Unknown
		if (((__vtable_IUnknown)((__com_IUnknown)(void*)intptr_0).pVtable).pfnRelease == AddrOfIntrinsics.AddrOf<AddrOfRelease>(new AddrOfRelease(__vtable_IUnknown.Release)))
		{
			return __interface_ccw.DirectRelease(intptr_0);
		}
		return smethod_42(intptr_0);
	}

	public static int smethod_44(IntPtr intptr_0)
	{
		if (intptr_0 != (IntPtr)0)
		{
			return smethod_43(intptr_0);
		}
		return 0;
	}

	[CLSCompliant(/*Could not decode attribute arguments.*/)]
	public static __ComObject smethod_45(string string_0, McgTypeInfo mcgTypeInfo_0)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		return FactoryCache.Get().GetActivationFactory(string_0, mcgTypeInfo_0, false);
	}

	public static object smethod_46(IntPtr intptr_0)
	{
		return ComCallableObject.GetTarget(intptr_0);
	}

	[CLSCompliant(/*Could not decode attribute arguments.*/)]
	public static object smethod_47(IntPtr intptr_0, McgTypeInfo mcgTypeInfo_0)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		return smethod_49(intptr_0, mcgTypeInfo_0, default(McgClassInfo));
	}

	[CLSCompliant(/*Could not decode attribute arguments.*/)]
	public static object smethod_48(IntPtr intptr_0, McgTypeInfo mcgTypeInfo_0)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		return McgComHelpers.ComInterfaceToObjectInternal(intptr_0, mcgTypeInfo_0, default(McgClassInfo), (CreateComObjectFlags)2);
	}

	[CLSCompliant(/*Could not decode attribute arguments.*/)]
	public static object smethod_49(IntPtr intptr_0, McgTypeInfo mcgTypeInfo_0, McgClassInfo mcgClassInfo_0)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		object obj = McgComHelpers.ComInterfaceToObjectInternal(intptr_0, mcgTypeInfo_0, mcgClassInfo_0, (CreateComObjectFlags)0);
		if (!((McgClassInfo)(ref mcgClassInfo_0)).get_IsNull() && obj != null && !InteropExtensions.IsInstanceOfClass(obj, ((McgClassInfo)(ref mcgClassInfo_0)).get_ClassType()))
		{
			throw new InvalidCastException();
		}
		return obj;
	}

	public static IntPtr smethod_50(IntPtr intptr_0, ref Guid guid_0)
	{
		int int_ = 0;
		return smethod_51(intptr_0, ref guid_0, ref int_);
	}

	public static IntPtr smethod_51(IntPtr intptr_0, ref Guid guid_0, ref int int_1)
	{
		IntPtr intptr_ = default(IntPtr);
		int_1 = smethod_52(intptr_0, ref guid_0, ref intptr_);
		return intptr_;
	}

	internal unsafe static int smethod_52(IntPtr intptr_0, ref Guid guid_0, ref IntPtr intptr_1)
	{
		int num;
		IntPtr intPtr = default(IntPtr);
		fixed (Guid* ptr = &guid_0)
		{
			num = CalliIntrinsics.StdCall__int(((__vtable_IUnknown)((__com_IUnknown)(void*)intptr_0).pVtable).pfnQueryInterface, intptr_0, (void*)ptr, (void*)(&intPtr));
		}
		if (num != 0)
		{
			intptr_1 = default(IntPtr);
			return num;
		}
		intptr_1 = intPtr;
		return num;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static IntPtr smethod_53(object object_0)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return smethod_54(object_0, McgModuleManager.get_IInspectable());
	}

	[CLSCompliant(/*Could not decode attribute arguments.*/)]
	public static IntPtr smethod_54(object object_0, McgTypeInfo mcgTypeInfo_0)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return McgComHelpers.ObjectToComInterfaceInternal(object_0, mcgTypeInfo_0);
	}

	[CLSCompliant(/*Could not decode attribute arguments.*/)]
	public static IntPtr smethod_55(__ComObject __ComObject_0)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		ComCallableObject val = null;
		try
		{
			val = new ComCallableObject((object)__ComObject_0, __ComObject_0);
			return val.GetComInterfaceForTypeInfo_NoCheck(McgModuleManager.get_IInspectable());
		}
		finally
		{
			if (val != null)
			{
				val.Release();
			}
		}
	}

	[CLSCompliant(/*Could not decode attribute arguments.*/)]
	public static IntPtr smethod_56(object object_0, McgTypeInfo mcgTypeInfo_0)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return McgComHelpers.ManagedObjectToComInterface(object_0, mcgTypeInfo_0);
	}

	public static object smethod_57(IntPtr intptr_0)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		return smethod_49(intptr_0, McgModuleManager.get_IInspectable(), default(McgClassInfo));
	}

	public unsafe static IntPtr smethod_58(Guid guid_0)
	{
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		MULTI_QI val = default(MULTI_QI);
		IntPtr intPtr = new IntPtr(&val);
		fixed (Guid* value = &COM.IID_IUnknown)
		{
			Guid* num = &guid_0;
			val.pIID = new IntPtr(value);
			val.pItf = IntPtr.Zero;
			val.hr = 0;
			int num2 = COM.CoCreateInstanceFromApp(num, IntPtr.Zero, 21, IntPtr.Zero, 1, intPtr);
			if (num2 < 0)
			{
				throw smethod_64(num2, bool_0: false);
			}
			if (val.hr < 0)
			{
				throw smethod_64(val.hr, bool_0: false);
			}
			return val.pItf;
		}
	}

	public static void smethod_59()
	{
		ContextEntry.RemoveCurrentContext();
	}

	public static int smethod_60()
	{
		return ((DictionaryBase)ComObjectCache.s_comObjectMap).get_Count();
	}

	public static IEnumerable<__ComObject> smethod_61()
	{
		List<__ComObject> list = new List<__ComObject>();
		for (int i = 0; i < ComObjectCache.s_comObjectMap.GetMaxCount(); i++)
		{
			IntPtr intPtr = default(IntPtr);
			if (ComObjectCache.s_comObjectMap.GetValue(i, ref intPtr) && intPtr != (IntPtr)0)
			{
				list.Add(InteropExtensions.UncheckedCast<__ComObject>(GCHandle.FromIntPtr(intPtr).Target));
			}
		}
		return list;
	}

	public static int smethod_62(Exception exception_0)
	{
		return Marshal.GetHRForException(exception_0);
	}

	public static int smethod_63(Exception exception_0)
	{
		return exception_0.HResult;
	}

	public static Exception smethod_64(int int_1, bool bool_0)
	{
		return Marshal.GetExceptionForHR(int_1);
	}
}
