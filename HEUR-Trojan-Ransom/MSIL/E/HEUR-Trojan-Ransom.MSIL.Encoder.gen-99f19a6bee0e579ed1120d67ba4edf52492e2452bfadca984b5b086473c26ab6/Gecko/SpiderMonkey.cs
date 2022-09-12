using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace Gecko;

public static class SpiderMonkey
{
	private enum PlatformEnum
	{
		Win32,
		Win64,
		Linux32,
		Linux64
	}

	private delegate IntPtr CompileOptionsDelegate(IntPtr @this, IntPtr cx, int jsver);

	private delegate IntPtr CurrentGlobalOrNullDelegate(IntPtr aJSContext);

	private delegate IntPtr GetGlobalForObjectCrossCompartmentDelegate(IntPtr jsObject);

	private delegate bool IsObjectInContextCompartmentDelegate(IntPtr jsObject, IntPtr context);

	private delegate IntPtr JS_BeginRequestDelegate(IntPtr cx);

	private delegate bool JS_CompileScriptDelegate(IntPtr cx, string str, int strlen, IntPtr compileOptions, ref MutableHandle jsValue);

	private delegate bool JS_CallFunctionNameDelegateA(IntPtr cx, ref IntPtr jsObject, string name, IntPtr data, ref MutableHandleValue jsValue);

	private delegate bool JS_CallFunctionNameDelegateB(IntPtr cx, ref IntPtr jsObject, string name, ref int args, ref MutableHandleValue jsValue);

	private delegate bool JS_CallFunctionValueDelegate(IntPtr cx, IntPtr jsObject, ref JsVal fval, IntPtr passZero, ref MutableHandleValue jsValue);

	private delegate IntPtr JS_EncodeStringDelegate(IntPtr cx, IntPtr jsString);

	private delegate IntPtr JS_EncodeStringUTF8Delegate(IntPtr cx, ref IntPtr jsString);

	private delegate IntPtr JS_EndRequestDelegate(IntPtr cx);

	private delegate IntPtr JS_EnterCompartmentDelegate(IntPtr cx, IntPtr obj);

	private delegate bool JS_ExecuteScriptDelegate(IntPtr cx, ref IntPtr handleScript, ref MutableHandleValue jsValue);

	private delegate void JS_FreeDelegate(IntPtr cx, IntPtr p);

	private delegate IntPtr JS_GetClassDelegate(IntPtr obj);

	private delegate IntPtr JS_GetClassObjectDelegate(IntPtr context, IntPtr proto, ref MutableHandle jsObject);

	private delegate IntPtr JS_GetCompartmentPrincipalsDelegate(IntPtr jsCompartment);

	private delegate IntPtr JS_ContextIteratorDelegate(IntPtr rt, ref IntPtr iterp);

	private delegate IntPtr JS_GetContextPrivateDelegate(IntPtr context);

	private delegate JsVal JS_GetEmptyStringValueDelegate(IntPtr cx);

	private delegate IntPtr JS_GetGlobalForObjectDelegate(IntPtr aJSContext, IntPtr jsObject);

	private delegate void JS_LeaveCompartmentDelegate(IntPtr cx, IntPtr oldCompartment);

	private delegate bool JS_GetPropertyDelegate(IntPtr cx, ref IntPtr jsObject, string name, ref JsVal jsValue);

	private delegate int JS_GetStringLengthDelegate(IntPtr jsString);

	private delegate int JS_GetStringEncodingLengthDelegate(IntPtr cx, IntPtr jsString);

	private delegate bool JS_HasPropertyDelegate(IntPtr cx, ref IntPtr jsObject, string name, [MarshalAs(UnmanagedType.U1)] out bool found);

	private delegate JsVal JS_GetNegativeInfinityValueDelegate(IntPtr cx);

	private delegate bool JS_GetPendingExceptionDelegate(IntPtr cx, ref MutableHandle handle);

	private delegate IntPtr JS_NewContextDelegate(IntPtr runtime, int stacksize);

	private delegate IntPtr JS_NewPlainObjectDelegate(IntPtr cx);

	private delegate IntPtr JS_NewStringCopyNDelegate(IntPtr cx, string str, int length);

	private delegate bool JS_SaveFrameChainDelegate(IntPtr jsContext);

	private delegate void JS_SetCompartmentPrincipalsDelegate(IntPtr jsCompartment, IntPtr principals);

	private delegate void JS_SetContextCallbackDelegate(IntPtr rt, JSContextCallback cb, IntPtr data);

	private delegate void JS_SetContextPrivateDelegate(IntPtr context, IntPtr data);

	private delegate JSErrorReportCallback JS_SetErrorReporterDelegate(IntPtr runtime, JSErrorReportCallback callback);

	private delegate bool JS_SetPropertyDelegate(IntPtr cx, ref IntPtr jsObject, string name, ref JsVal jsValue);

	private delegate void JS_SetTrustedPrincipalsDelegate(IntPtr runtime, IntPtr principals);

	private delegate JSType JS_TypeOfValueDelegate(IntPtr cx, ref JsVal jsVal);

	private delegate bool JS_ValueToObjectDelegate(IntPtr cx, ref JsVal jsValue, ref MutableHandle jsObject);

	private delegate IntPtr JS_GetRuntimeDelegate(IntPtr context);

	private delegate bool JS_WrapObjectDelegate(IntPtr cx, ref MutableHandle p);

	private delegate IntPtr ToStringSlowDelegate(IntPtr cx, ref JsVal v);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate JSBool JSContextCallback(IntPtr cx, uint contextOp);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
	public delegate void JSErrorReportCallback(IntPtr cx, string message, IntPtr report);

	private class HandleValueArray : IDisposable
	{
		private int _length;

		private JsVal[] _args;

		private IntPtr _ptr;

		public IntPtr Ptr
		{
			get
			{
				if (_ptr == IntPtr.Zero)
				{
					_ptr = CopyToNativeMemory();
				}
				return _ptr;
			}
		}

		public HandleValueArray(int length, JsVal[] args)
		{
			_length = length;
			_args = args;
		}

		private IntPtr CopyToNativeMemory()
		{
			IntPtr intPtr = Marshal.AllocCoTaskMem(IntPtr.Size + IntPtr.Size);
			Marshal.WriteIntPtr(intPtr, 0, new IntPtr(_length));
			IntPtr val = Marshal.AllocCoTaskMem(8 * _length);
			Marshal.WriteIntPtr(intPtr, IntPtr.Size, val);
			for (int i = 0; i < _length; i++)
			{
				Marshal.StructureToPtr((object)_args[i], new IntPtr(val.ToInt64() + i * 8), fDeleteOld: true);
			}
			return intPtr;
		}

		private void FreeNativeMemory(IntPtr ptr)
		{
			IntPtr ptr2 = Marshal.ReadIntPtr(ptr, IntPtr.Size);
			Marshal.FreeCoTaskMem(ptr2);
			Marshal.FreeCoTaskMem(ptr);
		}

		public void Dispose()
		{
			if (_ptr != IntPtr.Zero)
			{
				FreeNativeMemory(_ptr);
			}
			_length = -1;
		}
	}

	private static Lazy<PlatformEnum> Platform = new Lazy<PlatformEnum>(GetPlatform);

	private static CompileOptionsDelegate CompileOptionsFunc = Resolve<CompileOptionsDelegate>(_003F_003F0CompileOptions_0040JS_0040_0040QAE_0040PAUJSContext_0040_0040W4JSVersion_0040_0040_0040Z, _003F_003F0CompileOptions_0040JS_0040_0040QEAA_0040PEAUJSContext_0040_0040W4JSVersion_0040_0040_0040Z, _ZN2JS14CompileOptionsC2EP9JSContext9JSVersion, _ZN2JS14CompileOptionsC2EP9JSContext9JSVersion_1);

	private static CurrentGlobalOrNullDelegate CurrentGlobalOrNullFunc = Resolve<CurrentGlobalOrNullDelegate>(_003FCurrentGlobalOrNull_0040JS_0040_0040YAPAVJSObject_0040_0040PAUJSContext_0040_0040_0040Z, _003FCurrentGlobalOrNull_0040JS_0040_0040YAPEAVJSObject_0040_0040PEAUJSContext_0040_0040_0040Z, _ZN2JS19CurrentGlobalOrNullEP9JSContext, _ZN2JS19CurrentGlobalOrNullEP9JSContext_1);

	private static GetGlobalForObjectCrossCompartmentDelegate GetGlobalForObjectCrossCompartmentFunc = Resolve<GetGlobalForObjectCrossCompartmentDelegate>(_003FGetGlobalForObjectCrossCompartment_0040js_0040_0040YAPAVJSObject_0040_0040PAV2_0040_0040Z, _003FGetGlobalForObjectCrossCompartment_0040js_0040_0040YAPEAVJSObject_0040_0040PEAV2_0040_0040Z, _ZN2js34GetGlobalForObjectCrossCompartmentEP8JSObject, _ZN2js34GetGlobalForObjectCrossCompartmentEP8JSObject_1);

	private static IsObjectInContextCompartmentDelegate IsObjectInContextCompartmentFunc = Resolve<IsObjectInContextCompartmentDelegate>(_003FIsObjectInContextCompartment_0040js_0040_0040YA_NPAVJSObject_0040_0040PBUJSContext_0040_0040_0040Z, _003FIsObjectInContextCompartment_0040js_0040_0040YA_NPEAVJSObject_0040_0040PEBUJSContext_0040_0040_0040Z, _ZN2js28IsObjectInContextCompartmentEP8JSObjectPK9JSContext, _ZN2js28IsObjectInContextCompartmentEP8JSObjectPK9JSContext_1);

	private static JS_BeginRequestDelegate JS_BeginRequestFunc = Resolve<JS_BeginRequestDelegate>(_003FJS_BeginRequest_0040_0040YAXPAUJSContext_0040_0040_0040Z, _003FJS_BeginRequest_0040_0040YAXPEAUJSContext_0040_0040_0040Z, _Z15JS_BeginRequestP9JSContext, _Z15JS_BeginRequestP9JSContext_1);

	private static JS_CompileScriptDelegate JS_CompileScriptFunc = Resolve<JS_CompileScriptDelegate>(_003FJS_CompileScript_0040_0040YA_NPAUJSContext_0040_0040PBDIABVCompileOptions_0040JS_0040_0040V_003F_0024MutableHandle_0040PAVJSScript_0040_0040_00403_0040_0040Z, _003FJS_CompileScript_0040_0040YA_NPEAUJSContext_0040_0040PEBD_KAEBVCompileOptions_0040JS_0040_0040V_003F_0024MutableHandle_0040PEAVJSScript_0040_0040_00403_0040_0040Z, _Z16JS_CompileScriptP9JSContextPKcjRKN2JS14CompileOptionsENS3_13MutableHandleIP8JSScriptEE, _Z16JS_CompileScriptP9JSContextPKcmRKN2JS14CompileOptionsENS3_13MutableHandleIP8JSScriptEE);

	private static JS_CallFunctionNameDelegateA JS_CallFunctionNameFuncA = Resolve<JS_CallFunctionNameDelegateA>(_003FJS_CallFunctionName_0040_0040YA_NPAUJSContext_0040_0040V_003F_0024Handle_0040PAVJSObject_0040_0040_0040JS_0040_0040PBDABVHandleValueArray_00403_0040V_003F_0024MutableHandle_0040VValue_0040JS_0040_0040_00403_0040_0040Z, _003FJS_CallFunctionName_0040_0040YA_NPEAUJSContext_0040_0040V_003F_0024Handle_0040PEAVJSObject_0040_0040_0040JS_0040_0040PEBDAEBVHandleValueArray_00403_0040V_003F_0024MutableHandle_0040VValue_0040JS_0040_0040_00403_0040_0040Z, _Z19JS_CallFunctionNameP9JSContextN2JS6HandleIP8JSObjectEEPKcRKNS1_16HandleValueArrayENS1_13MutableHandleINS1_5ValueEEE, _Z19JS_CallFunctionNameP9JSContextN2JS6HandleIP8JSObjectEEPKcRKNS1_16HandleValueArrayENS1_13MutableHandleINS1_5ValueEEE_2);

	private static JS_CallFunctionNameDelegateB JS_CallFunctionNameFuncB = Resolve<JS_CallFunctionNameDelegateB>(_003FJS_CallFunctionName_0040_0040YA_NPAUJSContext_0040_0040V_003F_0024Handle_0040PAVJSObject_0040_0040_0040JS_0040_0040PBDABVHandleValueArray_00403_0040V_003F_0024MutableHandle_0040VValue_0040JS_0040_0040_00403_0040_0040Z_1, _003FJS_CallFunctionName_0040_0040YA_NPEAUJSContext_0040_0040V_003F_0024Handle_0040PEAVJSObject_0040_0040_0040JS_0040_0040PEBDAEBVHandleValueArray_00403_0040V_003F_0024MutableHandle_0040VValue_0040JS_0040_0040_00403_0040_0040Z_1, _Z19JS_CallFunctionNameP9JSContextN2JS6HandleIP8JSObjectEEPKcRKNS1_16HandleValueArrayENS1_13MutableHandleINS1_5ValueEEE_1, _Z19JS_CallFunctionNameP9JSContextN2JS6HandleIP8JSObjectEEPKcRKNS1_16HandleValueArrayENS1_13MutableHandleINS1_5ValueEEE_3);

	private static JS_CallFunctionValueDelegate JS_CallFunctionValueFunc = Resolve<JS_CallFunctionValueDelegate>(_003FJS_CallFunctionValue_0040_0040YA_NPAUJSContext_0040_0040V_003F_0024Handle_0040PAVJSObject_0040_0040_0040JS_0040_0040V_003F_0024Handle_0040VValue_0040JS_0040_0040_00403_0040ABVHandleValueArray_00403_0040V_003F_0024MutableHandle_0040VValue_0040JS_0040_0040_00403_0040_0040Z, _003FJS_CallFunctionValue_0040_0040YA_NPEAUJSContext_0040_0040V_003F_0024Handle_0040PEAVJSObject_0040_0040_0040JS_0040_0040V_003F_0024Handle_0040VValue_0040JS_0040_0040_00403_0040AEBVHandleValueArray_00403_0040V_003F_0024MutableHandle_0040VValue_0040JS_0040_0040_00403_0040_0040Z, _Z20JS_CallFunctionValueP9JSContextN2JS6HandleIP8JSObjectEENS2_INS1_5ValueEEERKNS1_16HandleValueArrayENS1_13MutableHandleIS6_EE, _Z20JS_CallFunctionValueP9JSContextN2JS6HandleIP8JSObjectEENS2_INS1_5ValueEEERKNS1_16HandleValueArrayENS1_13MutableHandleIS6_EE_1);

	private static JS_EncodeStringDelegate JS_EncodeStringFunc = Resolve<JS_EncodeStringDelegate>(_003FJS_EncodeString_0040_0040YAPADPAUJSContext_0040_0040PAVJSString_0040_0040_0040Z, _003FJS_EncodeString_0040_0040YAPEADPEAUJSContext_0040_0040PEAVJSString_0040_0040_0040Z, _Z15JS_EncodeStringP9JSContextP8JSString, _Z15JS_EncodeStringP9JSContextP8JSString_1);

	private static JS_EncodeStringUTF8Delegate JS_EncodeStringUTF8Func = Resolve<JS_EncodeStringUTF8Delegate>(_003FJS_EncodeStringToUTF8_0040_0040YAPADPAUJSContext_0040_0040V_003F_0024Handle_0040PAVJSString_0040_0040_0040JS_0040_0040_0040Z, _003FJS_EncodeStringToUTF8_0040_0040YAPEADPEAUJSContext_0040_0040V_003F_0024Handle_0040PEAVJSString_0040_0040_0040JS_0040_0040_0040Z, _Z21JS_EncodeStringToUTF8P9JSContextN2JS6HandleIP8JSStringEE, _Z21JS_EncodeStringToUTF8P9JSContextN2JS6HandleIP8JSStringEE_1);

	private static JS_EndRequestDelegate JS_EndRequestFunc = Resolve<JS_EndRequestDelegate>(_003FJS_EndRequest_0040_0040YAXPAUJSContext_0040_0040_0040Z, _003FJS_EndRequest_0040_0040YAXPEAUJSContext_0040_0040_0040Z, _Z13JS_EndRequestP9JSContext, _Z13JS_EndRequestP9JSContext_1);

	private static JS_EnterCompartmentDelegate JS_EnterCompartmentFunc = Resolve<JS_EnterCompartmentDelegate>(_003FJS_EnterCompartment_0040_0040YAPAUJSCompartment_0040_0040PAUJSContext_0040_0040PAVJSObject_0040_0040_0040Z, _003FJS_EnterCompartment_0040_0040YAPEAUJSCompartment_0040_0040PEAUJSContext_0040_0040PEAVJSObject_0040_0040_0040Z, _Z19JS_EnterCompartmentP9JSContextP8JSObject, _Z19JS_EnterCompartmentP9JSContextP8JSObject_1);

	private static JS_ExecuteScriptDelegate JS_ExecuteScriptFunc = Resolve<JS_ExecuteScriptDelegate>(_003FJS_ExecuteScript_0040_0040YA_NPAUJSContext_0040_0040V_003F_0024Handle_0040PAVJSScript_0040_0040_0040JS_0040_0040V_003F_0024MutableHandle_0040VValue_0040JS_0040_0040_00403_0040_0040Z, _003FJS_ExecuteScript_0040_0040YA_NPEAUJSContext_0040_0040V_003F_0024Handle_0040PEAVJSScript_0040_0040_0040JS_0040_0040V_003F_0024MutableHandle_0040VValue_0040JS_0040_0040_00403_0040_0040Z, _Z16JS_ExecuteScriptP9JSContextN2JS6HandleIP8JSScriptEENS1_13MutableHandleINS1_5ValueEEE, _Z16JS_ExecuteScriptP9JSContextN2JS6HandleIP8JSScriptEENS1_13MutableHandleINS1_5ValueEEE_1);

	private static JS_FreeDelegate JS_FreeFunc = Resolve<JS_FreeDelegate>(_003FJS_free_0040_0040YAXPAUJSContext_0040_0040PAX_0040Z, _003FJS_free_0040_0040YAXPEAUJSContext_0040_0040PEAX_0040Z, _Z7JS_freeP9JSContextPv, _Z7JS_freeP9JSContextPv_1);

	private static JS_GetClassDelegate JS_GetClassFunc = Resolve<JS_GetClassDelegate>(_003FJS_GetClass_0040_0040YAPBUJSClass_0040_0040PAVJSObject_0040_0040_0040Z, _003FJS_GetClass_0040_0040YAPEBUJSClass_0040_0040PEAVJSObject_0040_0040_0040Z, _Z11JS_GetClassP8JSObject, _Z11JS_GetClassP8JSObject_1);

	private static JS_GetClassObjectDelegate JS_GetClassObjectFunc = Resolve<JS_GetClassObjectDelegate>(_003FJS_GetClassObject_0040_0040YA_NPAUJSContext_0040_0040W4JSProtoKey_0040_0040V_003F_0024MutableHandle_0040PAVJSObject_0040_0040_0040JS_0040_0040_0040Z, _003FJS_GetClassObject_0040_0040YA_NPEAUJSContext_0040_0040W4JSProtoKey_0040_0040V_003F_0024MutableHandle_0040PEAVJSObject_0040_0040_0040JS_0040_0040_0040Z, _Z17JS_GetClassObjectP9JSContext10JSProtoKeyN2JS13MutableHandleIP8JSObjectEE, _Z17JS_GetClassObjectP9JSContext10JSProtoKeyN2JS13MutableHandleIP8JSObjectEE_1);

	private static JS_GetCompartmentPrincipalsDelegate JS_GetCompartmentPrincipalsFunc = Resolve<JS_GetCompartmentPrincipalsDelegate>(_003FJS_GetCompartmentPrincipals_0040_0040YAPAUJSPrincipals_0040_0040PAUJSCompartment_0040_0040_0040Z, _003FJS_GetCompartmentPrincipals_0040_0040YAPEAUJSPrincipals_0040_0040PEAUJSCompartment_0040_0040_0040Z, _Z27JS_GetCompartmentPrincipalsP13JSCompartment, _Z27JS_GetCompartmentPrincipalsP13JSCompartment_1);

	private static JS_ContextIteratorDelegate JS_ContextIteratorFunc = Resolve<JS_ContextIteratorDelegate>(_003FJS_ContextIterator_0040_0040YAPAUJSContext_0040_0040PAUJSRuntime_0040_0040PAPAU1_0040_0040Z, _003FJS_ContextIterator_0040_0040YAPEAUJSContext_0040_0040PEAUJSRuntime_0040_0040PEAPEAU1_0040_0040Z, _Z18JS_ContextIteratorP9JSRuntimePP9JSContext, _Z18JS_ContextIteratorP9JSRuntimePP9JSContext_1);

	private static JS_GetContextPrivateDelegate JS_GetContextPrivateFunc = Resolve<JS_GetContextPrivateDelegate>(_003FJS_GetContextPrivate_0040_0040YAPAXPAUJSContext_0040_0040_0040Z, _003FJS_GetContextPrivate_0040_0040YAPEAXPEAUJSContext_0040_0040_0040Z, _Z20JS_GetContextPrivateP9JSContext, _Z20JS_GetContextPrivateP9JSContext_1);

	private static JS_GetEmptyStringValueDelegate JS_GetEmptyStringValueFunc = Resolve<JS_GetEmptyStringValueDelegate>(_003FJS_GetEmptyStringValue_0040_0040YA_003FAVValue_0040JS_0040_0040PAUJSContext_0040_0040_0040Z, _003FJS_GetEmptyStringValue_0040_0040YA_003FAVValue_0040JS_0040_0040PEAUJSContext_0040_0040_0040Z, _Z22JS_GetEmptyStringValueP9JSContext, _Z22JS_GetEmptyStringValueP9JSContext_1);

	private static JS_GetGlobalForObjectDelegate JS_GetGlobalForObjectFunc = Resolve<JS_GetGlobalForObjectDelegate>(_003FJS_GetGlobalForObject_0040_0040YAPAVJSObject_0040_0040PAUJSContext_0040_0040PAV1_0040_0040Z, _003FJS_GetGlobalForObject_0040_0040YAPEAVJSObject_0040_0040PEAUJSContext_0040_0040PEAV1_0040_0040Z, _Z21JS_GetGlobalForObjectP9JSContextP8JSObject, _Z21JS_GetGlobalForObjectP9JSContextP8JSObject_1);

	private static JS_LeaveCompartmentDelegate JS_LeaveCompartmentFunc = Resolve<JS_LeaveCompartmentDelegate>(_003FJS_LeaveCompartment_0040_0040YAXPAUJSContext_0040_0040PAUJSCompartment_0040_0040_0040Z, _003FJS_LeaveCompartment_0040_0040YAXPEAUJSContext_0040_0040PEAUJSCompartment_0040_0040_0040Z, _Z19JS_LeaveCompartmentP9JSContextP13JSCompartment, _Z19JS_LeaveCompartmentP9JSContextP13JSCompartment_1);

	private static JS_GetPropertyDelegate JS_GetPropertyFunc = Resolve<JS_GetPropertyDelegate>(_003FJS_GetProperty_0040_0040YA_NPAUJSContext_0040_0040V_003F_0024Handle_0040PAVJSObject_0040_0040_0040JS_0040_0040PBDV_003F_0024MutableHandle_0040VValue_0040JS_0040_0040_00403_0040_0040Z, _003FJS_GetProperty_0040_0040YA_NPEAUJSContext_0040_0040V_003F_0024Handle_0040PEAVJSObject_0040_0040_0040JS_0040_0040PEBDV_003F_0024MutableHandle_0040VValue_0040JS_0040_0040_00403_0040_0040Z, _Z14JS_GetPropertyP9JSContextN2JS6HandleIP8JSObjectEEPKcNS1_13MutableHandleINS1_5ValueEEE, _Z14JS_GetPropertyP9JSContextN2JS6HandleIP8JSObjectEEPKcNS1_13MutableHandleINS1_5ValueEEE_1);

	private static JS_GetStringLengthDelegate JS_GetStringLengthFunc = Resolve<JS_GetStringLengthDelegate>(_003FJS_GetStringLength_0040_0040YAIPAVJSString_0040_0040_0040Z, _003FJS_GetStringLength_0040_0040YA_KPEAVJSString_0040_0040_0040Z, _Z18JS_GetStringLengthP8JSString, _Z18JS_GetStringLengthP8JSString_1);

	private static JS_GetStringEncodingLengthDelegate JS_GetStringEncodingLengthFunc = Resolve<JS_GetStringEncodingLengthDelegate>(_003FJS_GetStringEncodingLength_0040_0040YAIPAUJSContext_0040_0040PAVJSString_0040_0040_0040Z, _003FJS_GetStringEncodingLength_0040_0040YA_KPEAUJSContext_0040_0040PEAVJSString_0040_0040_0040Z, _Z26JS_GetStringEncodingLengthP9JSContextP8JSString, _Z26JS_GetStringEncodingLengthP9JSContextP8JSString_1);

	private static JS_HasPropertyDelegate JS_HasPropertyFunc = Resolve<JS_HasPropertyDelegate>(_003FJS_HasProperty_0040_0040YA_NPAUJSContext_0040_0040V_003F_0024Handle_0040PAVJSObject_0040_0040_0040JS_0040_0040PBDPA_N_0040Z, _003FJS_HasProperty_0040_0040YA_NPEAUJSContext_0040_0040V_003F_0024Handle_0040PEAVJSObject_0040_0040_0040JS_0040_0040PEBDPEA_N_0040Z, _Z14JS_HasPropertyP9JSContextN2JS6HandleIP8JSObjectEEPKcPb, _Z14JS_HasPropertyP9JSContextN2JS6HandleIP8JSObjectEEPKcPb_1);

	private static JS_GetNegativeInfinityValueDelegate JS_GetNegativeInfinityValueFunc = Resolve<JS_GetNegativeInfinityValueDelegate>(_003FJS_GetNegativeInfinityValue_0040_0040YA_003FAVValue_0040JS_0040_0040PAUJSContext_0040_0040_0040Z, _003FJS_GetNegativeInfinityValue_0040_0040YA_003FAVValue_0040JS_0040_0040PEAUJSContext_0040_0040_0040Z, _Z27JS_GetNegativeInfinityValueP9JSContext, _Z27JS_GetNegativeInfinityValueP9JSContext_1);

	private static JS_GetPendingExceptionDelegate JS_GetPendingExceptionFunc = Resolve<JS_GetPendingExceptionDelegate>(_003FJS_GetPendingException_0040_0040YA_NPAUJSContext_0040_0040V_003F_0024MutableHandle_0040VValue_0040JS_0040_0040_0040JS_0040_0040_0040Z, _003FJS_GetPendingException_0040_0040YA_NPEAUJSContext_0040_0040V_003F_0024MutableHandle_0040VValue_0040JS_0040_0040_0040JS_0040_0040_0040Z, _Z22JS_GetPendingExceptionP9JSContextN2JS13MutableHandleINS1_5ValueEEE, _Z22JS_GetPendingExceptionP9JSContextN2JS13MutableHandleINS1_5ValueEEE_1);

	private static JS_NewContextDelegate JS_NewContextFunc = Resolve<JS_NewContextDelegate>(_003FJS_NewContext_0040_0040YAPAUJSContext_0040_0040PAUJSRuntime_0040_0040I_0040Z, _003FJS_NewContext_0040_0040YAPEAUJSContext_0040_0040PEAUJSRuntime_0040_0040_K_0040Z, _Z13JS_NewContextP9JSRuntimej, _Z13JS_NewContextP9JSRuntimem);

	private static JS_NewPlainObjectDelegate JS_NewPlainObjectFunc = Resolve<JS_NewPlainObjectDelegate>(_003FJS_NewPlainObject_0040_0040YAPAVJSObject_0040_0040PAUJSContext_0040_0040_0040Z, _003FJS_NewPlainObject_0040_0040YAPEAVJSObject_0040_0040PEAUJSContext_0040_0040_0040Z, _Z17JS_NewPlainObjectP9JSContext, _Z17JS_NewPlainObjectP9JSContext_1);

	private static JS_NewStringCopyNDelegate JS_NewStringCopyNFunc = Resolve<JS_NewStringCopyNDelegate>(_003FJS_NewStringCopyN_0040_0040YAPAVJSString_0040_0040PAUJSContext_0040_0040PBDI_0040Z, _003FJS_NewStringCopyN_0040_0040YAPEAVJSString_0040_0040PEAUJSContext_0040_0040PEBD_K_0040Z, NewStringCopyNP9JSContextPKcj, _Z17JS_NewStringCopyNP9JSContextPKcm);

	private static JS_SaveFrameChainDelegate JS_SaveFrameChainFunc = Resolve<JS_SaveFrameChainDelegate>(_003FJS_SaveFrameChain_0040_0040YA_NPAUJSContext_0040_0040_0040Z, _003FJS_SaveFrameChain_0040_0040YA_NPEAUJSContext_0040_0040_0040Z, _Z17JS_SaveFrameChainP9JSContext, _Z17JS_SaveFrameChainP9JSContext_1);

	private static JS_SetCompartmentPrincipalsDelegate JS_SetCompartmentPrincipalsFunc = Resolve<JS_SetCompartmentPrincipalsDelegate>(_003FJS_SetCompartmentPrincipals_0040_0040YAXPAUJSCompartment_0040_0040PAUJSPrincipals_0040_0040_0040Z, _003FJS_SetCompartmentPrincipals_0040_0040YAXPEAUJSCompartment_0040_0040PEAUJSPrincipals_0040_0040_0040Z, _Z27JS_SetCompartmentPrincipalsP13JSCompartmentP12JSPrincipals, _Z27JS_SetCompartmentPrincipalsP13JSCompartmentP12JSPrincipals_1);

	private static JS_SetContextCallbackDelegate JS_SetContextCallbackFunc = Resolve<JS_SetContextCallbackDelegate>(_003FJS_SetContextCallback_0040_0040YAXPAUJSRuntime_0040_0040P6A_NPAUJSContext_0040_0040IPAX_0040Z2_0040Z, _003FJS_SetContextCallback_0040_0040YAXPEAUJSRuntime_0040_0040P6A_NPEAUJSContext_0040_0040IPEAX_0040Z2_0040Z, _Z21JS_SetContextCallbackP9JSRuntimePFbP9JSContextjPvES3_, _Z21JS_SetContextCallbackP9JSRuntimePFbP9JSContextjPvES3__1);

	private static JS_SetContextPrivateDelegate JS_SetContextPrivateFunc = Resolve<JS_SetContextPrivateDelegate>(_003FJS_SetContextPrivate_0040_0040YAXPAUJSContext_0040_0040PAX_0040Z, _003FJS_SetContextPrivate_0040_0040YAXPEAUJSContext_0040_0040PEAX_0040Z, _Z20JS_SetContextPrivateP9JSContextPv, _Z20JS_SetContextPrivateP9JSContextPv_1);

	private static JS_SetErrorReporterDelegate JS_SetErrorReporterFunc = Resolve<JS_SetErrorReporterDelegate>(_003FJS_SetErrorReporter_0040_0040YAP6AXPAUJSContext_0040_0040PBDPAVJSErrorReport_0040_0040_0040ZPAUJSRuntime_0040_0040P6AX012_0040Z_0040Z, _003FJS_SetErrorReporter_0040_0040YAP6AXPEAUJSContext_0040_0040PEBDPEAVJSErrorReport_0040_0040_0040ZPEAUJSRuntime_0040_0040P6AX012_0040Z_0040Z, _Z19JS_SetErrorReporterP9JSRuntimePFvP9JSContextPKcP13JSErrorReportE, _Z19JS_SetErrorReporterP9JSRuntimePFvP9JSContextPKcP13JSErrorReportE_1);

	private static JS_SetPropertyDelegate JS_SetPropertyFunc = Resolve<JS_SetPropertyDelegate>(_003FJS_SetProperty_0040_0040YA_NPAUJSContext_0040_0040V_003F_0024Handle_0040PAVJSObject_0040_0040_0040JS_0040_0040PBDV_003F_0024Handle_0040VValue_0040JS_0040_0040_00403_0040_0040Z, _003FJS_SetProperty_0040_0040YA_NPEAUJSContext_0040_0040V_003F_0024Handle_0040PEAVJSObject_0040_0040_0040JS_0040_0040PEBDV_003F_0024Handle_0040VValue_0040JS_0040_0040_00403_0040_0040Z, _Z14JS_SetPropertyP9JSContextN2JS6HandleIP8JSObjectEEPKcNS2_INS1_5ValueEEE, _Z14JS_SetPropertyP9JSContextN2JS6HandleIP8JSObjectEEPKcNS2_INS1_5ValueEEE_1);

	private static JS_SetTrustedPrincipalsDelegate JS_SetTrustedPrincipalsFunc = Resolve<JS_SetTrustedPrincipalsDelegate>(_003FJS_SetTrustedPrincipals_0040_0040YAXPAUJSRuntime_0040_0040PAUJSPrincipals_0040_0040_0040Z, _003FJS_SetTrustedPrincipals_0040_0040YAXPEAUJSRuntime_0040_0040PEAUJSPrincipals_0040_0040_0040Z, _Z23JS_SetTrustedPrincipalsP9JSRuntimeP12JSPrincipals, _Z23JS_SetTrustedPrincipalsP9JSRuntimeP12JSPrincipals_1);

	private static JS_TypeOfValueDelegate JS_TypeOfValueFunc = Resolve<JS_TypeOfValueDelegate>(_003FJS_TypeOfValue_0040_0040YA_003FAW4JSType_0040_0040PAUJSContext_0040_0040V_003F_0024Handle_0040VValue_0040JS_0040_0040_0040JS_0040_0040_0040Z, _003FJS_TypeOfValue_0040_0040YA_003FAW4JSType_0040_0040PEAUJSContext_0040_0040V_003F_0024Handle_0040VValue_0040JS_0040_0040_0040JS_0040_0040_0040Z, _Z14JS_TypeOfValueP9JSContextN2JS6HandleINS1_5ValueEEE, _Z14JS_TypeOfValueP9JSContextN2JS6HandleINS1_5ValueEEE_1);

	private static JS_ValueToObjectDelegate JS_ValueToObjectFunc = Resolve<JS_ValueToObjectDelegate>(_003FJS_ValueToObject_0040_0040YA_NPAUJSContext_0040_0040V_003F_0024Handle_0040VValue_0040JS_0040_0040_0040JS_0040_0040V_003F_0024MutableHandle_0040PAVJSObject_0040_0040_00403_0040_0040Z, _003FJS_ValueToObject_0040_0040YA_NPEAUJSContext_0040_0040V_003F_0024Handle_0040VValue_0040JS_0040_0040_0040JS_0040_0040V_003F_0024MutableHandle_0040PEAVJSObject_0040_0040_00403_0040_0040Z, _Z16JS_ValueToObjectP9JSContextN2JS6HandleINS1_5ValueEEENS1_13MutableHandleIP8JSObjectEE, _Z16JS_ValueToObjectP9JSContextN2JS6HandleINS1_5ValueEEENS1_13MutableHandleIP8JSObjectEE_1);

	private static JS_GetRuntimeDelegate JS_GetRuntimeFunc = Resolve<JS_GetRuntimeDelegate>(_003FJS_GetRuntime_0040_0040YAPAUJSRuntime_0040_0040PAUJSContext_0040_0040_0040Z, _003FJS_GetRuntime_0040_0040YAPEAUJSRuntime_0040_0040PEAUJSContext_0040_0040_0040Z, _Z13JS_GetRuntimeP9JSContext, _Z13JS_GetRuntimeP9JSContext_1);

	private static JS_WrapObjectDelegate JS_WrapObjectFunc = Resolve<JS_WrapObjectDelegate>(_003FJS_WrapObject_0040_0040YA_NPAUJSContext_0040_0040V_003F_0024MutableHandle_0040PAVJSObject_0040_0040_0040JS_0040_0040_0040Z, _003FJS_WrapObject_0040_0040YA_NPEAUJSContext_0040_0040V_003F_0024MutableHandle_0040PEAVJSObject_0040_0040_0040JS_0040_0040_0040Z, _Z13JS_WrapObjectP9JSContextN2JS13MutableHandleIP8JSObjectEE, _Z13JS_WrapObjectP9JSContextN2JS13MutableHandleIP8JSObjectEE_1);

	private static ToStringSlowDelegate ToStringSlowFunc = Resolve<ToStringSlowDelegate>(_003FToStringSlow_0040js_0040_0040YAPAVJSString_0040_0040PAUJSContext_0040_0040V_003F_0024Handle_0040VValue_0040JS_0040_0040_0040JS_0040_0040_0040Z, _003FToStringSlow_0040js_0040_0040YAPEAVJSString_0040_0040PEAUJSContext_0040_0040V_003F_0024Handle_0040VValue_0040JS_0040_0040_0040JS_0040_0040_0040Z, _ZN2js12ToStringSlowEP9JSContextN2JS6HandleINS2_5ValueEEE, _ZN2js12ToStringSlowEP9JSContextN2JS6HandleINS2_5ValueEEE_1);

	private static Dictionary<IntPtr, IntPtr> ContextToCompileOptionsMap = new Dictionary<IntPtr, IntPtr>();

	private static PlatformEnum GetPlatform()
	{
		if (Xpcom.Is32Bit)
		{
			return (!Xpcom.IsWindows) ? PlatformEnum.Linux32 : PlatformEnum.Win32;
		}
		if (Xpcom.Is64Bit)
		{
			return Xpcom.IsWindows ? PlatformEnum.Win64 : PlatformEnum.Linux64;
		}
		throw new NotImplementedException();
	}

	private static T Resolve<T>(T win32, T win64, T linux32, T linux64)
	{
		return Platform.Value switch
		{
			PlatformEnum.Win32 => win32, 
			PlatformEnum.Win64 => win64, 
			PlatformEnum.Linux32 => linux32, 
			PlatformEnum.Linux64 => linux64, 
			_ => throw new NotImplementedException(), 
		};
	}

	public static IntPtr CurrentGlobalOrNull(IntPtr aJSContext)
	{
		return CurrentGlobalOrNullFunc(aJSContext);
	}

	public static IntPtr GetGlobalForObjectCrossCompartment(IntPtr jsObject)
	{
		return GetGlobalForObjectCrossCompartmentFunc(jsObject);
	}

	public static bool IsObjectInContextCompartment(IntPtr jsObject, IntPtr cx)
	{
		return IsObjectInContextCompartmentFunc(jsObject, cx);
	}

	public static IntPtr JS_BeginRequest(IntPtr cx)
	{
		return JS_BeginRequestFunc(cx);
	}

	public static JsVal JS_CallFunctionName(IntPtr cx, IntPtr jsObject, string name)
	{
		int args = 0;
		MutableHandleValue jsValue = default(MutableHandleValue);
		if (!JS_CallFunctionNameFuncB(cx, ref jsObject, name, ref args, ref jsValue))
		{
			throw new GeckoException($"Failed to call function {name}");
		}
		return JsVal.FromPtr(jsValue.Handle);
	}

	public static JsVal JS_CallFunctionName(IntPtr cx, IntPtr jsObject, string name, JsVal[] args)
	{
		if (args == null || args.Length == 0)
		{
			return JS_CallFunctionName(cx, jsObject, name);
		}
		JsVal result = default(JsVal);
		bool flag;
		using (HandleValueArray handleValueArray = new HandleValueArray(args.Length, args))
		{
			MutableHandleValue jsValue = default(MutableHandleValue);
			if (flag = JS_CallFunctionNameFuncA(cx, ref jsObject, name, handleValueArray.Ptr, ref jsValue))
			{
				result = JsVal.FromPtr(jsValue.Handle);
			}
		}
		if (!flag)
		{
			throw new GeckoException("Function does not exist!");
		}
		return result;
	}

	public static JsVal JS_CallFunctionValue(IntPtr cx, IntPtr jsObject, JsVal func)
	{
		MutableHandleValue jsValue = default(MutableHandleValue);
		bool flag;
		using (HandleValueArray handleValueArray = new HandleValueArray(0, new JsVal[0]))
		{
			flag = JS_CallFunctionValueFunc(cx, jsObject, ref func, handleValueArray.Ptr, ref jsValue);
		}
		if (!flag)
		{
			throw new GeckoException("failed to call function.");
		}
		return JsVal.FromPtr(jsValue.Handle);
	}

	public static IntPtr JS_EncodeString(IntPtr cx, IntPtr jsString)
	{
		return JS_EncodeStringFunc(cx, jsString);
	}

	public static IntPtr JS_EncodeStringToUTF8(IntPtr cx, IntPtr jsString)
	{
		return JS_EncodeStringUTF8Func(cx, ref jsString);
	}

	public static IntPtr JS_EndRequest(IntPtr cx)
	{
		return JS_EndRequestFunc(cx);
	}

	public static IntPtr JS_EnterCompartment(IntPtr cx, IntPtr obj)
	{
		JS_BeginRequest(cx);
		return JS_EnterCompartmentFunc(cx, obj);
	}

	public static bool JS_ExecuteScript(IntPtr cx, string script, out JsVal jsval)
	{
		jsval = default(JsVal);
		MutableHandle jsValue = default(MutableHandle);
		if (!JS_CompileScriptFunc(cx, script, script.Length, GetCompileOptions(cx), ref jsValue))
		{
			throw new GeckoException("Failed to compile script.");
		}
		MutableHandleValue jsValue2 = default(MutableHandleValue);
		IntPtr handleScript = jsValue.Handle;
		if (!JS_ExecuteScriptFunc(cx, ref handleScript, ref jsValue2))
		{
			return false;
		}
		jsval = JsVal.FromPtr(jsValue2.Handle);
		return true;
	}

	public static bool JS_EvaluateScript(IntPtr cx, string src, uint length, string filename, uint lineno, ref JsVal jsval)
	{
		src = EncodeUnicodeScript(src);
		if (cx == IntPtr.Zero)
		{
			throw new ArgumentNullException("cx");
		}
		return JS_ExecuteScript(cx, src, out jsval);
	}

	public static void JS_Free(IntPtr cx, IntPtr p)
	{
		JS_FreeFunc(cx, p);
	}

	public static IntPtr JS_GetClass(IntPtr obj)
	{
		return JS_GetClassFunc(obj);
	}

	public static IntPtr JS_GetClassObject(IntPtr context, IntPtr proto)
	{
		MutableHandle jsObject = default(MutableHandle);
		JS_GetClassObjectFunc(context, proto, ref jsObject);
		return jsObject.Handle;
	}

	public static IntPtr JS_GetCompartmentPrincipals(IntPtr jsCompartment)
	{
		return JS_GetCompartmentPrincipalsFunc(jsCompartment);
	}

	public static IntPtr JS_ContextIterator(IntPtr rt, ref IntPtr iterp)
	{
		return JS_ContextIteratorFunc(rt, ref iterp);
	}

	public static IntPtr JS_GetContextPrivate(IntPtr jsContext)
	{
		return JS_GetContextPrivateFunc(jsContext);
	}

	public static JsVal JS_GetEmptyStringValue(IntPtr cx)
	{
		return JS_GetEmptyStringValueFunc(cx);
	}

	public static IntPtr JS_GetGlobalForObject(IntPtr jsContext, IntPtr jsObject)
	{
		return JS_GetGlobalForObjectFunc(jsContext, jsObject);
	}

	public static JsVal JS_GetProperty(IntPtr cx, IntPtr jsObject, string name)
	{
		JsVal jsValue = default(JsVal);
		if (!JS_GetPropertyFunc(cx, ref jsObject, name, ref jsValue))
		{
			throw new GeckoException($"Could not get property. {name}");
		}
		return jsValue;
	}

	public static int JS_GetStringLength(IntPtr jsString)
	{
		return JS_GetStringLengthFunc(jsString);
	}

	public static int JS_GetStringEncodingLength(IntPtr cx, IntPtr jsString)
	{
		return JS_GetStringEncodingLengthFunc(cx, jsString);
	}

	public static bool JS_HasProperty(IntPtr cx, IntPtr jsObject, string name)
	{
		JS_HasPropertyFunc(cx, ref jsObject, name, out var found);
		return found;
	}

	public static JsVal JS_GetNegativeInfinityValue(IntPtr cx)
	{
		return JS_GetNegativeInfinityValueFunc(cx);
	}

	public static IntPtr JS_GetPendingException(IntPtr cx)
	{
		MutableHandle handle = default(MutableHandle);
		return JS_GetPendingExceptionFunc(cx, ref handle) ? handle.Handle : IntPtr.Zero;
	}

	public static void JS_LeaveCompartment(IntPtr cx, IntPtr oldCompartment)
	{
		JS_LeaveCompartmentFunc(cx, oldCompartment);
		JS_EndRequest(cx);
	}

	public static IntPtr JS_NewContext(IntPtr runtime, int stackChunkSize)
	{
		return JS_NewContextFunc(runtime, stackChunkSize);
	}

	public static IntPtr JS_NewPlainObject(IntPtr cx)
	{
		return JS_NewPlainObjectFunc(cx);
	}

	public static IntPtr JS_NewStringCopyN(IntPtr cx, string str, int length)
	{
		return JS_NewStringCopyNFunc(cx, str, length);
	}

	public static bool JS_SaveFrameChain(IntPtr jsContext)
	{
		return JS_SaveFrameChainFunc(jsContext);
	}

	public static void JS_SetCompartmentPrincipals(IntPtr jsCompartment, IntPtr principals)
	{
		JS_SetCompartmentPrincipalsFunc(jsCompartment, principals);
	}

	public static JSContextCallback JS_SetContextCallback(IntPtr rt, JSContextCallback cb)
	{
		JS_SetContextCallbackFunc(rt, cb, IntPtr.Zero);
		return null;
	}

	public static void JS_SetContextPrivate(IntPtr jsContext, IntPtr data)
	{
		JS_SetContextPrivateFunc(jsContext, data);
	}

	public static JSErrorReportCallback JS_SetErrorReporter(IntPtr runtime, JSErrorReportCallback callback)
	{
		return JS_SetErrorReporterFunc(runtime, callback);
	}

	public static bool JS_SetProperty(IntPtr cx, IntPtr jsObject, string name, JsVal value)
	{
		return JS_SetPropertyFunc(cx, ref jsObject, name, ref value);
	}

	public static void JS_SetTrustedPrincipals(IntPtr runtime, IntPtr principals)
	{
		JS_SetTrustedPrincipalsFunc(runtime, principals);
	}

	public static JSType JS_TypeOfValue(IntPtr cx, JsVal jsVal)
	{
		return JS_TypeOfValueFunc(cx, ref jsVal);
	}

	public static IntPtr JS_ValueToObject(IntPtr cx, JsVal v)
	{
		MutableHandle jsObject = default(MutableHandle);
		JS_ValueToObjectFunc(cx, ref v, ref jsObject);
		return jsObject.Handle;
	}

	public static IntPtr JS_WrapObject(IntPtr cx, IntPtr jsObject)
	{
		MutableHandle p = new MutableHandle(jsObject);
		return JS_WrapObjectFunc(cx, ref p) ? p.Handle : IntPtr.Zero;
	}

	public static IntPtr ToStringSlow(IntPtr cx, JsVal v)
	{
		return ToStringSlowFunc(cx, ref v);
	}

	public static IntPtr JS_GetRuntime(IntPtr jsContext)
	{
		return JS_GetRuntimeFunc(jsContext);
	}

	private static string EncodeUnicodeScript(string script)
	{
		int i;
		for (i = 0; i < script.Length && script[i] < '\u0080'; i++)
		{
		}
		if (i == script.Length)
		{
			return script;
		}
		StringBuilder stringBuilder = new StringBuilder();
		if (i > 0)
		{
			stringBuilder.Append(script.Substring(0, i));
		}
		for (; i < script.Length; i++)
		{
			char c = script[i];
			if (c < '\u0080')
			{
				stringBuilder.Append(c);
				continue;
			}
			stringBuilder.Append("\\u");
			int num = c;
			stringBuilder.Append(num.ToString("X4"));
		}
		return stringBuilder.ToString();
	}

	private static IntPtr GetCompileOptions(IntPtr context)
	{
		if (!ContextToCompileOptionsMap.TryGetValue(context, out var value))
		{
			IntPtr intPtr = Marshal.AllocCoTaskMem(160);
			CompileOptionsFunc(intPtr, context, 0);
			value = (ContextToCompileOptionsMap[context] = intPtr);
		}
		return value;
	}

	[DllImport("xul", CallingConvention = CallingConvention.ThisCall, CharSet = CharSet.Ansi)]
	private static extern IntPtr _003F_003F0CompileOptions_0040JS_0040_0040QAE_0040PAUJSContext_0040_0040W4JSVersion_0040_0040_0040Z(IntPtr @this, IntPtr cx, int jsver);

	[DllImport("xul", CallingConvention = CallingConvention.Cdecl)]
	private static extern IntPtr _003FCurrentGlobalOrNull_0040JS_0040_0040YAPAVJSObject_0040_0040PAUJSContext_0040_0040_0040Z(IntPtr aJSContext);

	[DllImport("xul", CallingConvention = CallingConvention.Cdecl)]
	private static extern IntPtr _003FGetGlobalForObjectCrossCompartment_0040js_0040_0040YAPAVJSObject_0040_0040PAV2_0040_0040Z(IntPtr jsObject);

	[DllImport("xul", CallingConvention = CallingConvention.Cdecl)]
	[return: MarshalAs(UnmanagedType.U1)]
	private static extern bool _003FIsObjectInContextCompartment_0040js_0040_0040YA_NPAVJSObject_0040_0040PBUJSContext_0040_0040_0040Z(IntPtr jsObject, IntPtr context);

	[DllImport("xul", CallingConvention = CallingConvention.Cdecl)]
	private static extern IntPtr _003FJS_BeginRequest_0040_0040YAXPAUJSContext_0040_0040_0040Z(IntPtr cx);

	[DllImport("xul", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
	[return: MarshalAs(UnmanagedType.U1)]
	private static extern bool _003FJS_CompileScript_0040_0040YA_NPAUJSContext_0040_0040PBDIABVCompileOptions_0040JS_0040_0040V_003F_0024MutableHandle_0040PAVJSScript_0040_0040_00403_0040_0040Z(IntPtr cx, string str, int strlen, IntPtr compileOptions, ref MutableHandle jsValue);

	[DllImport("xul", CallingConvention = CallingConvention.Cdecl)]
	[return: MarshalAs(UnmanagedType.U1)]
	private static extern bool _003FJS_CallFunctionName_0040_0040YA_NPAUJSContext_0040_0040V_003F_0024Handle_0040PAVJSObject_0040_0040_0040JS_0040_0040PBDABVHandleValueArray_00403_0040V_003F_0024MutableHandle_0040VValue_0040JS_0040_0040_00403_0040_0040Z(IntPtr cx, ref IntPtr jsObject, string name, IntPtr data, ref MutableHandleValue jsValue);

	[DllImport("xul", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?JS_CallFunctionName@@YA_NPAUJSContext@@V?$Handle@PAVJSObject@@@JS@@PBDABVHandleValueArray@3@V?$MutableHandle@VValue@JS@@@3@@Z")]
	[return: MarshalAs(UnmanagedType.U1)]
	private static extern bool _003FJS_CallFunctionName_0040_0040YA_NPAUJSContext_0040_0040V_003F_0024Handle_0040PAVJSObject_0040_0040_0040JS_0040_0040PBDABVHandleValueArray_00403_0040V_003F_0024MutableHandle_0040VValue_0040JS_0040_0040_00403_0040_0040Z_1(IntPtr cx, ref IntPtr jsObject, string name, ref int args, ref MutableHandleValue jsValue);

	[DllImport("xul", CallingConvention = CallingConvention.Cdecl)]
	[return: MarshalAs(UnmanagedType.U1)]
	private static extern bool _003FJS_CallFunctionValue_0040_0040YA_NPAUJSContext_0040_0040V_003F_0024Handle_0040PAVJSObject_0040_0040_0040JS_0040_0040V_003F_0024Handle_0040VValue_0040JS_0040_0040_00403_0040ABVHandleValueArray_00403_0040V_003F_0024MutableHandle_0040VValue_0040JS_0040_0040_00403_0040_0040Z(IntPtr cx, IntPtr jsObject, ref JsVal fval, IntPtr passZero, ref MutableHandleValue jsValue);

	[DllImport("xul", CallingConvention = CallingConvention.Cdecl)]
	private static extern IntPtr _003FJS_EncodeString_0040_0040YAPADPAUJSContext_0040_0040PAVJSString_0040_0040_0040Z(IntPtr cx, IntPtr jsString);

	[DllImport("xul", CallingConvention = CallingConvention.Cdecl)]
	private static extern IntPtr _003FJS_EncodeStringToUTF8_0040_0040YAPADPAUJSContext_0040_0040V_003F_0024Handle_0040PAVJSString_0040_0040_0040JS_0040_0040_0040Z(IntPtr cx, ref IntPtr jsString);

	[DllImport("xul", CallingConvention = CallingConvention.Cdecl)]
	private static extern IntPtr _003FJS_EndRequest_0040_0040YAXPAUJSContext_0040_0040_0040Z(IntPtr cx);

	[DllImport("xul", CallingConvention = CallingConvention.Cdecl)]
	private static extern IntPtr _003FJS_EnterCompartment_0040_0040YAPAUJSCompartment_0040_0040PAUJSContext_0040_0040PAVJSObject_0040_0040_0040Z(IntPtr cx, IntPtr obj);

	[DllImport("xul", CallingConvention = CallingConvention.Cdecl)]
	[return: MarshalAs(UnmanagedType.U1)]
	private static extern bool _003FJS_ExecuteScript_0040_0040YA_NPAUJSContext_0040_0040V_003F_0024Handle_0040PAVJSScript_0040_0040_0040JS_0040_0040V_003F_0024MutableHandle_0040VValue_0040JS_0040_0040_00403_0040_0040Z(IntPtr cx, ref IntPtr handleScript, ref MutableHandleValue jsValue);

	[DllImport("xul", CallingConvention = CallingConvention.Cdecl)]
	private static extern void _003FJS_free_0040_0040YAXPAUJSContext_0040_0040PAX_0040Z(IntPtr cx, IntPtr p);

	[DllImport("xul", CallingConvention = CallingConvention.Cdecl)]
	private static extern IntPtr _003FJS_GetClass_0040_0040YAPBUJSClass_0040_0040PAVJSObject_0040_0040_0040Z(IntPtr obj);

	[DllImport("xul", CallingConvention = CallingConvention.Cdecl)]
	private static extern IntPtr _003FJS_GetClassObject_0040_0040YA_NPAUJSContext_0040_0040W4JSProtoKey_0040_0040V_003F_0024MutableHandle_0040PAVJSObject_0040_0040_0040JS_0040_0040_0040Z(IntPtr context, IntPtr proto, ref MutableHandle jsObject);

	[DllImport("xul", CallingConvention = CallingConvention.Cdecl)]
	private static extern IntPtr _003FJS_GetCompartmentPrincipals_0040_0040YAPAUJSPrincipals_0040_0040PAUJSCompartment_0040_0040_0040Z(IntPtr jsCompartment);

	[DllImport("xul", CallingConvention = CallingConvention.Cdecl)]
	private static extern IntPtr _003FJS_ContextIterator_0040_0040YAPAUJSContext_0040_0040PAUJSRuntime_0040_0040PAPAU1_0040_0040Z(IntPtr rt, ref IntPtr iterp);

	[DllImport("xul", CallingConvention = CallingConvention.Cdecl)]
	private static extern IntPtr _003FJS_GetContextPrivate_0040_0040YAPAXPAUJSContext_0040_0040_0040Z(IntPtr context);

	[DllImport("xul", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
	private static extern JsVal _003FJS_GetEmptyStringValue_0040_0040YA_003FAVValue_0040JS_0040_0040PAUJSContext_0040_0040_0040Z(IntPtr cx);

	[DllImport("xul", CallingConvention = CallingConvention.Cdecl)]
	private static extern IntPtr _003FJS_GetGlobalForObject_0040_0040YAPAVJSObject_0040_0040PAUJSContext_0040_0040PAV1_0040_0040Z(IntPtr aJSContext, IntPtr jsObject);

	[DllImport("xul", CallingConvention = CallingConvention.Cdecl)]
	private static extern void _003FJS_LeaveCompartment_0040_0040YAXPAUJSContext_0040_0040PAUJSCompartment_0040_0040_0040Z(IntPtr cx, IntPtr oldCompartment);

	[DllImport("xul", CallingConvention = CallingConvention.Cdecl)]
	[return: MarshalAs(UnmanagedType.U1)]
	private static extern bool _003FJS_GetProperty_0040_0040YA_NPAUJSContext_0040_0040V_003F_0024Handle_0040PAVJSObject_0040_0040_0040JS_0040_0040PBDV_003F_0024MutableHandle_0040VValue_0040JS_0040_0040_00403_0040_0040Z(IntPtr cx, ref IntPtr jsObject, string name, ref JsVal jsValue);

	[DllImport("xul", CallingConvention = CallingConvention.Cdecl)]
	private static extern int _003FJS_GetStringLength_0040_0040YAIPAVJSString_0040_0040_0040Z(IntPtr jsString);

	[DllImport("xul", CallingConvention = CallingConvention.Cdecl)]
	private static extern int _003FJS_GetStringEncodingLength_0040_0040YAIPAUJSContext_0040_0040PAVJSString_0040_0040_0040Z(IntPtr cx, IntPtr jsString);

	[DllImport("xul", CallingConvention = CallingConvention.Cdecl)]
	[return: MarshalAs(UnmanagedType.U1)]
	private static extern bool _003FJS_HasProperty_0040_0040YA_NPAUJSContext_0040_0040V_003F_0024Handle_0040PAVJSObject_0040_0040_0040JS_0040_0040PBDPA_N_0040Z(IntPtr cx, ref IntPtr jsObject, string name, [MarshalAs(UnmanagedType.U1)] out bool found);

	[DllImport("xul", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
	private static extern JsVal _003FJS_GetNegativeInfinityValue_0040_0040YA_003FAVValue_0040JS_0040_0040PAUJSContext_0040_0040_0040Z(IntPtr cx);

	[DllImport("xul", CallingConvention = CallingConvention.Cdecl)]
	[return: MarshalAs(UnmanagedType.U1)]
	private static extern bool _003FJS_GetPendingException_0040_0040YA_NPAUJSContext_0040_0040V_003F_0024MutableHandle_0040VValue_0040JS_0040_0040_0040JS_0040_0040_0040Z(IntPtr cx, ref MutableHandle handle);

	[DllImport("xul", CallingConvention = CallingConvention.Cdecl)]
	private static extern IntPtr _003FJS_NewContext_0040_0040YAPAUJSContext_0040_0040PAUJSRuntime_0040_0040I_0040Z(IntPtr runtime, int stacksize);

	[DllImport("xul", CallingConvention = CallingConvention.Cdecl)]
	private static extern IntPtr _003FJS_NewPlainObject_0040_0040YAPAVJSObject_0040_0040PAUJSContext_0040_0040_0040Z(IntPtr cx);

	[DllImport("xul", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
	private static extern IntPtr _003FJS_NewStringCopyN_0040_0040YAPAVJSString_0040_0040PAUJSContext_0040_0040PBDI_0040Z(IntPtr cx, string str, int length);

	[DllImport("xul", CallingConvention = CallingConvention.Cdecl)]
	[return: MarshalAs(UnmanagedType.U1)]
	private static extern bool _003FJS_SaveFrameChain_0040_0040YA_NPAUJSContext_0040_0040_0040Z(IntPtr jsContext);

	[DllImport("xul", CallingConvention = CallingConvention.Cdecl)]
	private static extern void _003FJS_SetCompartmentPrincipals_0040_0040YAXPAUJSCompartment_0040_0040PAUJSPrincipals_0040_0040_0040Z(IntPtr jsCompartment, IntPtr principals);

	[DllImport("xul", CallingConvention = CallingConvention.Cdecl)]
	private static extern void _003FJS_SetContextCallback_0040_0040YAXPAUJSRuntime_0040_0040P6A_NPAUJSContext_0040_0040IPAX_0040Z2_0040Z(IntPtr rt, JSContextCallback cb, IntPtr data);

	[DllImport("xul", CallingConvention = CallingConvention.Cdecl)]
	private static extern void _003FJS_SetContextPrivate_0040_0040YAXPAUJSContext_0040_0040PAX_0040Z(IntPtr context, IntPtr data);

	[DllImport("xul", CallingConvention = CallingConvention.Cdecl)]
	private static extern JSErrorReportCallback _003FJS_SetErrorReporter_0040_0040YAP6AXPAUJSContext_0040_0040PBDPAVJSErrorReport_0040_0040_0040ZPAUJSRuntime_0040_0040P6AX012_0040Z_0040Z(IntPtr runtime, JSErrorReportCallback callback);

	[DllImport("xul", CallingConvention = CallingConvention.Cdecl)]
	[return: MarshalAs(UnmanagedType.U1)]
	private static extern bool _003FJS_SetProperty_0040_0040YA_NPAUJSContext_0040_0040V_003F_0024Handle_0040PAVJSObject_0040_0040_0040JS_0040_0040PBDV_003F_0024Handle_0040VValue_0040JS_0040_0040_00403_0040_0040Z(IntPtr cx, ref IntPtr jsObject, string name, ref JsVal jsValue);

	[DllImport("xul", CallingConvention = CallingConvention.Cdecl)]
	private static extern void _003FJS_SetTrustedPrincipals_0040_0040YAXPAUJSRuntime_0040_0040PAUJSPrincipals_0040_0040_0040Z(IntPtr runtime, IntPtr principals);

	[DllImport("xul", CallingConvention = CallingConvention.Cdecl)]
	private static extern JSType _003FJS_TypeOfValue_0040_0040YA_003FAW4JSType_0040_0040PAUJSContext_0040_0040V_003F_0024Handle_0040VValue_0040JS_0040_0040_0040JS_0040_0040_0040Z(IntPtr cx, ref JsVal jsVal);

	[DllImport("xul", CallingConvention = CallingConvention.Cdecl)]
	[return: MarshalAs(UnmanagedType.U1)]
	private static extern bool _003FJS_ValueToObject_0040_0040YA_NPAUJSContext_0040_0040V_003F_0024Handle_0040VValue_0040JS_0040_0040_0040JS_0040_0040V_003F_0024MutableHandle_0040PAVJSObject_0040_0040_00403_0040_0040Z(IntPtr cx, ref JsVal jsValue, ref MutableHandle jsObject);

	[DllImport("xul", CallingConvention = CallingConvention.Cdecl)]
	private static extern IntPtr _003FJS_GetRuntime_0040_0040YAPAUJSRuntime_0040_0040PAUJSContext_0040_0040_0040Z(IntPtr context);

	[DllImport("xul", CallingConvention = CallingConvention.Cdecl)]
	[return: MarshalAs(UnmanagedType.U1)]
	private static extern bool _003FJS_WrapObject_0040_0040YA_NPAUJSContext_0040_0040V_003F_0024MutableHandle_0040PAVJSObject_0040_0040_0040JS_0040_0040_0040Z(IntPtr cx, ref MutableHandle p);

	[DllImport("xul", CallingConvention = CallingConvention.Cdecl)]
	private static extern IntPtr _003FToStringSlow_0040js_0040_0040YAPAVJSString_0040_0040PAUJSContext_0040_0040V_003F_0024Handle_0040VValue_0040JS_0040_0040_0040JS_0040_0040_0040Z(IntPtr cx, ref JsVal v);

	[DllImport("xul", CallingConvention = CallingConvention.ThisCall, CharSet = CharSet.Ansi)]
	private static extern IntPtr _003F_003F0CompileOptions_0040JS_0040_0040QEAA_0040PEAUJSContext_0040_0040W4JSVersion_0040_0040_0040Z(IntPtr @this, IntPtr cx, int jsver);

	[DllImport("xul", CallingConvention = CallingConvention.Cdecl)]
	private static extern IntPtr _003FCurrentGlobalOrNull_0040JS_0040_0040YAPEAVJSObject_0040_0040PEAUJSContext_0040_0040_0040Z(IntPtr aJSContext);

	[DllImport("xul", CallingConvention = CallingConvention.Cdecl)]
	private static extern IntPtr _003FGetGlobalForObjectCrossCompartment_0040js_0040_0040YAPEAVJSObject_0040_0040PEAV2_0040_0040Z(IntPtr jsObject);

	[DllImport("xul", CallingConvention = CallingConvention.Cdecl)]
	[return: MarshalAs(UnmanagedType.U1)]
	private static extern bool _003FIsObjectInContextCompartment_0040js_0040_0040YA_NPEAVJSObject_0040_0040PEBUJSContext_0040_0040_0040Z(IntPtr jsObject, IntPtr context);

	[DllImport("xul", CallingConvention = CallingConvention.Cdecl)]
	private static extern IntPtr _003FJS_BeginRequest_0040_0040YAXPEAUJSContext_0040_0040_0040Z(IntPtr cx);

	[DllImport("xul", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
	[return: MarshalAs(UnmanagedType.U1)]
	private static extern bool _003FJS_CompileScript_0040_0040YA_NPEAUJSContext_0040_0040PEBD_KAEBVCompileOptions_0040JS_0040_0040V_003F_0024MutableHandle_0040PEAVJSScript_0040_0040_00403_0040_0040Z(IntPtr cx, string str, int strlen, IntPtr compileOptions, ref MutableHandle jsValue);

	[DllImport("xul", CallingConvention = CallingConvention.Cdecl)]
	[return: MarshalAs(UnmanagedType.U1)]
	private static extern bool _003FJS_CallFunctionName_0040_0040YA_NPEAUJSContext_0040_0040V_003F_0024Handle_0040PEAVJSObject_0040_0040_0040JS_0040_0040PEBDAEBVHandleValueArray_00403_0040V_003F_0024MutableHandle_0040VValue_0040JS_0040_0040_00403_0040_0040Z(IntPtr cx, ref IntPtr jsObject, string name, IntPtr data, ref MutableHandleValue jsValue);

	[DllImport("xul", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?JS_CallFunctionName@@YA_NPEAUJSContext@@V?$Handle@PEAVJSObject@@@JS@@PEBDAEBVHandleValueArray@3@V?$MutableHandle@VValue@JS@@@3@@Z")]
	[return: MarshalAs(UnmanagedType.U1)]
	private static extern bool _003FJS_CallFunctionName_0040_0040YA_NPEAUJSContext_0040_0040V_003F_0024Handle_0040PEAVJSObject_0040_0040_0040JS_0040_0040PEBDAEBVHandleValueArray_00403_0040V_003F_0024MutableHandle_0040VValue_0040JS_0040_0040_00403_0040_0040Z_1(IntPtr cx, ref IntPtr jsObject, string name, ref int args, ref MutableHandleValue jsValue);

	[DllImport("xul", CallingConvention = CallingConvention.Cdecl)]
	[return: MarshalAs(UnmanagedType.U1)]
	private static extern bool _003FJS_CallFunctionValue_0040_0040YA_NPEAUJSContext_0040_0040V_003F_0024Handle_0040PEAVJSObject_0040_0040_0040JS_0040_0040V_003F_0024Handle_0040VValue_0040JS_0040_0040_00403_0040AEBVHandleValueArray_00403_0040V_003F_0024MutableHandle_0040VValue_0040JS_0040_0040_00403_0040_0040Z(IntPtr cx, IntPtr jsObject, ref JsVal fval, IntPtr passZero, ref MutableHandleValue jsValue);

	[DllImport("xul", CallingConvention = CallingConvention.Cdecl)]
	private static extern IntPtr _003FJS_EncodeString_0040_0040YAPEADPEAUJSContext_0040_0040PEAVJSString_0040_0040_0040Z(IntPtr cx, IntPtr jsString);

	[DllImport("xul", CallingConvention = CallingConvention.Cdecl)]
	private static extern IntPtr _003FJS_EncodeStringToUTF8_0040_0040YAPEADPEAUJSContext_0040_0040V_003F_0024Handle_0040PEAVJSString_0040_0040_0040JS_0040_0040_0040Z(IntPtr cx, ref IntPtr jsString);

	[DllImport("xul", CallingConvention = CallingConvention.Cdecl)]
	private static extern IntPtr _003FJS_EndRequest_0040_0040YAXPEAUJSContext_0040_0040_0040Z(IntPtr cx);

	[DllImport("xul", CallingConvention = CallingConvention.Cdecl)]
	private static extern IntPtr _003FJS_EnterCompartment_0040_0040YAPEAUJSCompartment_0040_0040PEAUJSContext_0040_0040PEAVJSObject_0040_0040_0040Z(IntPtr cx, IntPtr obj);

	[DllImport("xul", CallingConvention = CallingConvention.Cdecl)]
	[return: MarshalAs(UnmanagedType.U1)]
	private static extern bool _003FJS_ExecuteScript_0040_0040YA_NPEAUJSContext_0040_0040V_003F_0024Handle_0040PEAVJSScript_0040_0040_0040JS_0040_0040V_003F_0024MutableHandle_0040VValue_0040JS_0040_0040_00403_0040_0040Z(IntPtr cx, ref IntPtr handleScript, ref MutableHandleValue jsValue);

	[DllImport("xul", CallingConvention = CallingConvention.Cdecl)]
	private static extern void _003FJS_free_0040_0040YAXPEAUJSContext_0040_0040PEAX_0040Z(IntPtr cx, IntPtr p);

	[DllImport("xul", CallingConvention = CallingConvention.Cdecl)]
	private static extern IntPtr _003FJS_GetClass_0040_0040YAPEBUJSClass_0040_0040PEAVJSObject_0040_0040_0040Z(IntPtr obj);

	[DllImport("xul", CallingConvention = CallingConvention.Cdecl)]
	private static extern IntPtr _003FJS_GetClassObject_0040_0040YA_NPEAUJSContext_0040_0040W4JSProtoKey_0040_0040V_003F_0024MutableHandle_0040PEAVJSObject_0040_0040_0040JS_0040_0040_0040Z(IntPtr context, IntPtr proto, ref MutableHandle jsObject);

	[DllImport("xul", CallingConvention = CallingConvention.Cdecl)]
	private static extern IntPtr _003FJS_GetCompartmentPrincipals_0040_0040YAPEAUJSPrincipals_0040_0040PEAUJSCompartment_0040_0040_0040Z(IntPtr jsCompartment);

	[DllImport("xul", CallingConvention = CallingConvention.Cdecl)]
	private static extern IntPtr _003FJS_ContextIterator_0040_0040YAPEAUJSContext_0040_0040PEAUJSRuntime_0040_0040PEAPEAU1_0040_0040Z(IntPtr rt, ref IntPtr iterp);

	[DllImport("xul", CallingConvention = CallingConvention.Cdecl)]
	private static extern IntPtr _003FJS_GetContextPrivate_0040_0040YAPEAXPEAUJSContext_0040_0040_0040Z(IntPtr context);

	[DllImport("xul", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
	private static extern JsVal _003FJS_GetEmptyStringValue_0040_0040YA_003FAVValue_0040JS_0040_0040PEAUJSContext_0040_0040_0040Z(IntPtr cx);

	[DllImport("xul", CallingConvention = CallingConvention.Cdecl)]
	private static extern IntPtr _003FJS_GetGlobalForObject_0040_0040YAPEAVJSObject_0040_0040PEAUJSContext_0040_0040PEAV1_0040_0040Z(IntPtr aJSContext, IntPtr jsObject);

	[DllImport("xul", CallingConvention = CallingConvention.Cdecl)]
	private static extern void _003FJS_LeaveCompartment_0040_0040YAXPEAUJSContext_0040_0040PEAUJSCompartment_0040_0040_0040Z(IntPtr cx, IntPtr oldCompartment);

	[DllImport("xul", CallingConvention = CallingConvention.Cdecl)]
	[return: MarshalAs(UnmanagedType.U1)]
	private static extern bool _003FJS_GetProperty_0040_0040YA_NPEAUJSContext_0040_0040V_003F_0024Handle_0040PEAVJSObject_0040_0040_0040JS_0040_0040PEBDV_003F_0024MutableHandle_0040VValue_0040JS_0040_0040_00403_0040_0040Z(IntPtr cx, ref IntPtr jsObject, string name, ref JsVal jsValue);

	[DllImport("xul", CallingConvention = CallingConvention.Cdecl)]
	private static extern int _003FJS_GetStringLength_0040_0040YA_KPEAVJSString_0040_0040_0040Z(IntPtr jsString);

	[DllImport("xul", CallingConvention = CallingConvention.Cdecl)]
	private static extern int _003FJS_GetStringEncodingLength_0040_0040YA_KPEAUJSContext_0040_0040PEAVJSString_0040_0040_0040Z(IntPtr cx, IntPtr jsString);

	[DllImport("xul", CallingConvention = CallingConvention.Cdecl)]
	[return: MarshalAs(UnmanagedType.U1)]
	private static extern bool _003FJS_HasProperty_0040_0040YA_NPEAUJSContext_0040_0040V_003F_0024Handle_0040PEAVJSObject_0040_0040_0040JS_0040_0040PEBDPEA_N_0040Z(IntPtr cx, ref IntPtr jsObject, string name, [MarshalAs(UnmanagedType.U1)] out bool found);

	[DllImport("xul", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
	private static extern JsVal _003FJS_GetNegativeInfinityValue_0040_0040YA_003FAVValue_0040JS_0040_0040PEAUJSContext_0040_0040_0040Z(IntPtr cx);

	[DllImport("xul", CallingConvention = CallingConvention.Cdecl)]
	[return: MarshalAs(UnmanagedType.U1)]
	private static extern bool _003FJS_GetPendingException_0040_0040YA_NPEAUJSContext_0040_0040V_003F_0024MutableHandle_0040VValue_0040JS_0040_0040_0040JS_0040_0040_0040Z(IntPtr cx, ref MutableHandle handle);

	[DllImport("xul", CallingConvention = CallingConvention.Cdecl)]
	private static extern IntPtr _003FJS_NewContext_0040_0040YAPEAUJSContext_0040_0040PEAUJSRuntime_0040_0040_K_0040Z(IntPtr runtime, int stacksize);

	[DllImport("xul", CallingConvention = CallingConvention.Cdecl)]
	private static extern IntPtr _003FJS_NewPlainObject_0040_0040YAPEAVJSObject_0040_0040PEAUJSContext_0040_0040_0040Z(IntPtr cx);

	[DllImport("xul", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
	private static extern IntPtr _003FJS_NewStringCopyN_0040_0040YAPEAVJSString_0040_0040PEAUJSContext_0040_0040PEBD_K_0040Z(IntPtr cx, string str, int length);

	[DllImport("xul", CallingConvention = CallingConvention.Cdecl)]
	[return: MarshalAs(UnmanagedType.U1)]
	private static extern bool _003FJS_SaveFrameChain_0040_0040YA_NPEAUJSContext_0040_0040_0040Z(IntPtr jsContext);

	[DllImport("xul", CallingConvention = CallingConvention.Cdecl)]
	private static extern void _003FJS_SetCompartmentPrincipals_0040_0040YAXPEAUJSCompartment_0040_0040PEAUJSPrincipals_0040_0040_0040Z(IntPtr jsCompartment, IntPtr principals);

	[DllImport("xul", CallingConvention = CallingConvention.Cdecl)]
	private static extern void _003FJS_SetContextCallback_0040_0040YAXPEAUJSRuntime_0040_0040P6A_NPEAUJSContext_0040_0040IPEAX_0040Z2_0040Z(IntPtr rt, JSContextCallback cb, IntPtr data);

	[DllImport("xul", CallingConvention = CallingConvention.Cdecl)]
	private static extern void _003FJS_SetContextPrivate_0040_0040YAXPEAUJSContext_0040_0040PEAX_0040Z(IntPtr context, IntPtr data);

	[DllImport("xul", CallingConvention = CallingConvention.Cdecl)]
	private static extern JSErrorReportCallback _003FJS_SetErrorReporter_0040_0040YAP6AXPEAUJSContext_0040_0040PEBDPEAVJSErrorReport_0040_0040_0040ZPEAUJSRuntime_0040_0040P6AX012_0040Z_0040Z(IntPtr runtime, JSErrorReportCallback callback);

	[DllImport("xul", CallingConvention = CallingConvention.Cdecl)]
	[return: MarshalAs(UnmanagedType.U1)]
	private static extern bool _003FJS_SetProperty_0040_0040YA_NPEAUJSContext_0040_0040V_003F_0024Handle_0040PEAVJSObject_0040_0040_0040JS_0040_0040PEBDV_003F_0024Handle_0040VValue_0040JS_0040_0040_00403_0040_0040Z(IntPtr cx, ref IntPtr jsObject, string name, ref JsVal jsValue);

	[DllImport("xul", CallingConvention = CallingConvention.Cdecl)]
	private static extern void _003FJS_SetTrustedPrincipals_0040_0040YAXPEAUJSRuntime_0040_0040PEAUJSPrincipals_0040_0040_0040Z(IntPtr runtime, IntPtr principals);

	[DllImport("xul", CallingConvention = CallingConvention.Cdecl)]
	private static extern JSType _003FJS_TypeOfValue_0040_0040YA_003FAW4JSType_0040_0040PEAUJSContext_0040_0040V_003F_0024Handle_0040VValue_0040JS_0040_0040_0040JS_0040_0040_0040Z(IntPtr cx, ref JsVal jsVal);

	[DllImport("xul", CallingConvention = CallingConvention.Cdecl)]
	[return: MarshalAs(UnmanagedType.U1)]
	private static extern bool _003FJS_ValueToObject_0040_0040YA_NPEAUJSContext_0040_0040V_003F_0024Handle_0040VValue_0040JS_0040_0040_0040JS_0040_0040V_003F_0024MutableHandle_0040PEAVJSObject_0040_0040_00403_0040_0040Z(IntPtr cx, ref JsVal jsValue, ref MutableHandle jsObject);

	[DllImport("xul", CallingConvention = CallingConvention.Cdecl)]
	private static extern IntPtr _003FJS_GetRuntime_0040_0040YAPEAUJSRuntime_0040_0040PEAUJSContext_0040_0040_0040Z(IntPtr context);

	[DllImport("xul", CallingConvention = CallingConvention.Cdecl)]
	[return: MarshalAs(UnmanagedType.U1)]
	private static extern bool _003FJS_WrapObject_0040_0040YA_NPEAUJSContext_0040_0040V_003F_0024MutableHandle_0040PEAVJSObject_0040_0040_0040JS_0040_0040_0040Z(IntPtr cx, ref MutableHandle p);

	[DllImport("xul", CallingConvention = CallingConvention.Cdecl)]
	private static extern IntPtr _003FToStringSlow_0040js_0040_0040YAPEAVJSString_0040_0040PEAUJSContext_0040_0040V_003F_0024Handle_0040VValue_0040JS_0040_0040_0040JS_0040_0040_0040Z(IntPtr cx, ref JsVal v);

	[DllImport("xul", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
	private static extern IntPtr _ZN2JS14CompileOptionsC2EP9JSContext9JSVersion(IntPtr @this, IntPtr cx, int jsver);

	[DllImport("xul", CallingConvention = CallingConvention.Cdecl)]
	private static extern IntPtr _ZN2JS19CurrentGlobalOrNullEP9JSContext(IntPtr aJSContext);

	[DllImport("xul", CallingConvention = CallingConvention.Cdecl)]
	private static extern IntPtr _ZN2js34GetGlobalForObjectCrossCompartmentEP8JSObject(IntPtr jsObject);

	[DllImport("xul", CallingConvention = CallingConvention.Cdecl)]
	[return: MarshalAs(UnmanagedType.U1)]
	private static extern bool _ZN2js28IsObjectInContextCompartmentEP8JSObjectPK9JSContext(IntPtr jsObject, IntPtr context);

	[DllImport("xul", CallingConvention = CallingConvention.Cdecl)]
	private static extern IntPtr _Z15JS_BeginRequestP9JSContext(IntPtr cx);

	[DllImport("xul", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
	[return: MarshalAs(UnmanagedType.U1)]
	private static extern bool _Z16JS_CompileScriptP9JSContextPKcjRKN2JS14CompileOptionsENS3_13MutableHandleIP8JSScriptEE(IntPtr cx, string str, int strlen, IntPtr compileOptions, ref MutableHandle jsValue);

	[DllImport("xul", CallingConvention = CallingConvention.Cdecl)]
	[return: MarshalAs(UnmanagedType.U1)]
	private static extern bool _Z19JS_CallFunctionNameP9JSContextN2JS6HandleIP8JSObjectEEPKcRKNS1_16HandleValueArrayENS1_13MutableHandleINS1_5ValueEEE(IntPtr cx, ref IntPtr jsObject, string name, IntPtr data, ref MutableHandleValue jsValue);

	[DllImport("xul", CallingConvention = CallingConvention.Cdecl, EntryPoint = "_Z19JS_CallFunctionNameP9JSContextN2JS6HandleIP8JSObjectEEPKcRKNS1_16HandleValueArrayENS1_13MutableHandleINS1_5ValueEEE")]
	[return: MarshalAs(UnmanagedType.U1)]
	private static extern bool _Z19JS_CallFunctionNameP9JSContextN2JS6HandleIP8JSObjectEEPKcRKNS1_16HandleValueArrayENS1_13MutableHandleINS1_5ValueEEE_1(IntPtr cx, ref IntPtr jsObject, string name, ref int args, ref MutableHandleValue jsValue);

	[DllImport("xul", CallingConvention = CallingConvention.Cdecl)]
	[return: MarshalAs(UnmanagedType.U1)]
	private static extern bool _Z20JS_CallFunctionValueP9JSContextN2JS6HandleIP8JSObjectEENS2_INS1_5ValueEEERKNS1_16HandleValueArrayENS1_13MutableHandleIS6_EE(IntPtr cx, IntPtr jsObject, ref JsVal fval, IntPtr passZero, ref MutableHandleValue jsValue);

	[DllImport("xul", CallingConvention = CallingConvention.Cdecl)]
	private static extern IntPtr _Z15JS_EncodeStringP9JSContextP8JSString(IntPtr cx, IntPtr jsString);

	[DllImport("xul", CallingConvention = CallingConvention.Cdecl)]
	private static extern IntPtr _Z21JS_EncodeStringToUTF8P9JSContextN2JS6HandleIP8JSStringEE(IntPtr cx, ref IntPtr jsString);

	[DllImport("xul", CallingConvention = CallingConvention.Cdecl)]
	private static extern IntPtr _Z13JS_EndRequestP9JSContext(IntPtr cx);

	[DllImport("xul", CallingConvention = CallingConvention.Cdecl)]
	private static extern IntPtr _Z19JS_EnterCompartmentP9JSContextP8JSObject(IntPtr cx, IntPtr obj);

	[DllImport("xul", CallingConvention = CallingConvention.Cdecl)]
	[return: MarshalAs(UnmanagedType.U1)]
	private static extern bool _Z16JS_ExecuteScriptP9JSContextN2JS6HandleIP8JSScriptEENS1_13MutableHandleINS1_5ValueEEE(IntPtr cx, ref IntPtr handleScript, ref MutableHandleValue jsValue);

	[DllImport("xul", CallingConvention = CallingConvention.Cdecl)]
	private static extern void _Z7JS_freeP9JSContextPv(IntPtr cx, IntPtr p);

	[DllImport("xul", CallingConvention = CallingConvention.Cdecl)]
	private static extern IntPtr _Z11JS_GetClassP8JSObject(IntPtr obj);

	[DllImport("xul", CallingConvention = CallingConvention.Cdecl)]
	private static extern IntPtr _Z17JS_GetClassObjectP9JSContext10JSProtoKeyN2JS13MutableHandleIP8JSObjectEE(IntPtr context, IntPtr proto, ref MutableHandle jsObject);

	[DllImport("xul", CallingConvention = CallingConvention.Cdecl)]
	private static extern IntPtr _Z27JS_GetCompartmentPrincipalsP13JSCompartment(IntPtr jsCompartment);

	[DllImport("xul", CallingConvention = CallingConvention.Cdecl)]
	private static extern IntPtr _Z18JS_ContextIteratorP9JSRuntimePP9JSContext(IntPtr rt, ref IntPtr iterp);

	[DllImport("xul", CallingConvention = CallingConvention.Cdecl)]
	private static extern IntPtr _Z20JS_GetContextPrivateP9JSContext(IntPtr context);

	[DllImport("xul", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
	private static extern JsVal _Z22JS_GetEmptyStringValueP9JSContext(IntPtr cx);

	[DllImport("xul", CallingConvention = CallingConvention.Cdecl)]
	private static extern IntPtr _Z21JS_GetGlobalForObjectP9JSContextP8JSObject(IntPtr aJSContext, IntPtr jsObject);

	[DllImport("xul", CallingConvention = CallingConvention.Cdecl)]
	private static extern void _Z19JS_LeaveCompartmentP9JSContextP13JSCompartment(IntPtr cx, IntPtr oldCompartment);

	[DllImport("xul", CallingConvention = CallingConvention.Cdecl)]
	[return: MarshalAs(UnmanagedType.U1)]
	private static extern bool _Z14JS_GetPropertyP9JSContextN2JS6HandleIP8JSObjectEEPKcNS1_13MutableHandleINS1_5ValueEEE(IntPtr cx, ref IntPtr jsObject, string name, ref JsVal jsValue);

	[DllImport("xul", CallingConvention = CallingConvention.Cdecl)]
	private static extern int _Z18JS_GetStringLengthP8JSString(IntPtr jsString);

	[DllImport("xul", CallingConvention = CallingConvention.Cdecl)]
	private static extern int _Z26JS_GetStringEncodingLengthP9JSContextP8JSString(IntPtr cx, IntPtr jsString);

	[DllImport("xul", CallingConvention = CallingConvention.Cdecl)]
	[return: MarshalAs(UnmanagedType.U1)]
	private static extern bool _Z14JS_HasPropertyP9JSContextN2JS6HandleIP8JSObjectEEPKcPb(IntPtr cx, ref IntPtr jsObject, string name, [MarshalAs(UnmanagedType.U1)] out bool found);

	[DllImport("xul", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
	private static extern JsVal _Z27JS_GetNegativeInfinityValueP9JSContext(IntPtr cx);

	[DllImport("xul", CallingConvention = CallingConvention.Cdecl)]
	[return: MarshalAs(UnmanagedType.U1)]
	private static extern bool _Z22JS_GetPendingExceptionP9JSContextN2JS13MutableHandleINS1_5ValueEEE(IntPtr cx, ref MutableHandle handle);

	[DllImport("xul", CallingConvention = CallingConvention.Cdecl)]
	private static extern IntPtr _Z13JS_NewContextP9JSRuntimej(IntPtr runtime, int stacksize);

	[DllImport("xul", CallingConvention = CallingConvention.Cdecl)]
	private static extern IntPtr _Z17JS_NewPlainObjectP9JSContext(IntPtr cx);

	[DllImport("xul", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
	private static extern IntPtr NewStringCopyNP9JSContextPKcj(IntPtr cx, string str, int length);

	[DllImport("xul", CallingConvention = CallingConvention.Cdecl)]
	[return: MarshalAs(UnmanagedType.U1)]
	private static extern bool _Z17JS_SaveFrameChainP9JSContext(IntPtr jsContext);

	[DllImport("xul", CallingConvention = CallingConvention.Cdecl)]
	private static extern void _Z27JS_SetCompartmentPrincipalsP13JSCompartmentP12JSPrincipals(IntPtr jsCompartment, IntPtr principals);

	[DllImport("xul", CallingConvention = CallingConvention.Cdecl)]
	private static extern void _Z21JS_SetContextCallbackP9JSRuntimePFbP9JSContextjPvES3_(IntPtr rt, JSContextCallback cb, IntPtr data);

	[DllImport("xul", CallingConvention = CallingConvention.Cdecl)]
	private static extern void _Z20JS_SetContextPrivateP9JSContextPv(IntPtr context, IntPtr data);

	[DllImport("xul", CallingConvention = CallingConvention.Cdecl)]
	private static extern JSErrorReportCallback _Z19JS_SetErrorReporterP9JSRuntimePFvP9JSContextPKcP13JSErrorReportE(IntPtr runtime, JSErrorReportCallback callback);

	[DllImport("xul", CallingConvention = CallingConvention.Cdecl)]
	[return: MarshalAs(UnmanagedType.U1)]
	private static extern bool _Z14JS_SetPropertyP9JSContextN2JS6HandleIP8JSObjectEEPKcNS2_INS1_5ValueEEE(IntPtr cx, ref IntPtr jsObject, string name, ref JsVal jsValue);

	[DllImport("xul", CallingConvention = CallingConvention.Cdecl)]
	private static extern void _Z23JS_SetTrustedPrincipalsP9JSRuntimeP12JSPrincipals(IntPtr runtime, IntPtr principals);

	[DllImport("xul", CallingConvention = CallingConvention.Cdecl)]
	private static extern JSType _Z14JS_TypeOfValueP9JSContextN2JS6HandleINS1_5ValueEEE(IntPtr cx, ref JsVal jsVal);

	[DllImport("xul", CallingConvention = CallingConvention.Cdecl)]
	[return: MarshalAs(UnmanagedType.U1)]
	private static extern bool _Z16JS_ValueToObjectP9JSContextN2JS6HandleINS1_5ValueEEENS1_13MutableHandleIP8JSObjectEE(IntPtr cx, ref JsVal jsValue, ref MutableHandle jsObject);

	[DllImport("xul", CallingConvention = CallingConvention.Cdecl)]
	private static extern IntPtr _Z13JS_GetRuntimeP9JSContext(IntPtr context);

	[DllImport("xul", CallingConvention = CallingConvention.Cdecl)]
	[return: MarshalAs(UnmanagedType.U1)]
	private static extern bool _Z13JS_WrapObjectP9JSContextN2JS13MutableHandleIP8JSObjectEE(IntPtr cx, ref MutableHandle p);

	[DllImport("xul", CallingConvention = CallingConvention.Cdecl)]
	private static extern IntPtr _ZN2js12ToStringSlowEP9JSContextN2JS6HandleINS2_5ValueEEE(IntPtr cx, ref JsVal v);

	[DllImport("xul", CallingConvention = CallingConvention.ThisCall, CharSet = CharSet.Ansi, EntryPoint = "_ZN2JS14CompileOptionsC2EP9JSContext9JSVersion")]
	private static extern IntPtr _ZN2JS14CompileOptionsC2EP9JSContext9JSVersion_1(IntPtr @this, IntPtr cx, int jsver);

	[DllImport("xul", CallingConvention = CallingConvention.Cdecl, EntryPoint = "_ZN2JS19CurrentGlobalOrNullEP9JSContext")]
	private static extern IntPtr _ZN2JS19CurrentGlobalOrNullEP9JSContext_1(IntPtr aJSContext);

	[DllImport("xul", CallingConvention = CallingConvention.Cdecl, EntryPoint = "_ZN2js34GetGlobalForObjectCrossCompartmentEP8JSObject")]
	private static extern IntPtr _ZN2js34GetGlobalForObjectCrossCompartmentEP8JSObject_1(IntPtr jsObject);

	[DllImport("xul", CallingConvention = CallingConvention.Cdecl, EntryPoint = "_ZN2js28IsObjectInContextCompartmentEP8JSObjectPK9JSContext")]
	[return: MarshalAs(UnmanagedType.U1)]
	private static extern bool _ZN2js28IsObjectInContextCompartmentEP8JSObjectPK9JSContext_1(IntPtr jsObject, IntPtr context);

	[DllImport("xul", CallingConvention = CallingConvention.Cdecl, EntryPoint = "_Z15JS_BeginRequestP9JSContext")]
	private static extern IntPtr _Z15JS_BeginRequestP9JSContext_1(IntPtr cx);

	[DllImport("xul", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
	[return: MarshalAs(UnmanagedType.U1)]
	private static extern bool _Z16JS_CompileScriptP9JSContextPKcmRKN2JS14CompileOptionsENS3_13MutableHandleIP8JSScriptEE(IntPtr cx, string str, int strlen, IntPtr compileOptions, ref MutableHandle jsValue);

	[DllImport("xul", CallingConvention = CallingConvention.Cdecl, EntryPoint = "_Z19JS_CallFunctionNameP9JSContextN2JS6HandleIP8JSObjectEEPKcRKNS1_16HandleValueArrayENS1_13MutableHandleINS1_5ValueEEE")]
	[return: MarshalAs(UnmanagedType.U1)]
	private static extern bool _Z19JS_CallFunctionNameP9JSContextN2JS6HandleIP8JSObjectEEPKcRKNS1_16HandleValueArrayENS1_13MutableHandleINS1_5ValueEEE_2(IntPtr cx, ref IntPtr jsObject, string name, IntPtr data, ref MutableHandleValue jsValue);

	[DllImport("xul", CallingConvention = CallingConvention.Cdecl, EntryPoint = "_Z19JS_CallFunctionNameP9JSContextN2JS6HandleIP8JSObjectEEPKcRKNS1_16HandleValueArrayENS1_13MutableHandleINS1_5ValueEEE")]
	[return: MarshalAs(UnmanagedType.U1)]
	private static extern bool _Z19JS_CallFunctionNameP9JSContextN2JS6HandleIP8JSObjectEEPKcRKNS1_16HandleValueArrayENS1_13MutableHandleINS1_5ValueEEE_3(IntPtr cx, ref IntPtr jsObject, string name, ref int args, ref MutableHandleValue jsValue);

	[DllImport("xul", CallingConvention = CallingConvention.Cdecl, EntryPoint = "_Z20JS_CallFunctionValueP9JSContextN2JS6HandleIP8JSObjectEENS2_INS1_5ValueEEERKNS1_16HandleValueArrayENS1_13MutableHandleIS6_EE")]
	[return: MarshalAs(UnmanagedType.U1)]
	private static extern bool _Z20JS_CallFunctionValueP9JSContextN2JS6HandleIP8JSObjectEENS2_INS1_5ValueEEERKNS1_16HandleValueArrayENS1_13MutableHandleIS6_EE_1(IntPtr cx, IntPtr jsObject, ref JsVal fval, IntPtr passZero, ref MutableHandleValue jsValue);

	[DllImport("xul", CallingConvention = CallingConvention.Cdecl, EntryPoint = "_Z15JS_EncodeStringP9JSContextP8JSString")]
	private static extern IntPtr _Z15JS_EncodeStringP9JSContextP8JSString_1(IntPtr cx, IntPtr jsString);

	[DllImport("xul", CallingConvention = CallingConvention.Cdecl, EntryPoint = "_Z21JS_EncodeStringToUTF8P9JSContextN2JS6HandleIP8JSStringEE")]
	private static extern IntPtr _Z21JS_EncodeStringToUTF8P9JSContextN2JS6HandleIP8JSStringEE_1(IntPtr cx, ref IntPtr jsString);

	[DllImport("xul", CallingConvention = CallingConvention.Cdecl, EntryPoint = "_Z13JS_EndRequestP9JSContext")]
	private static extern IntPtr _Z13JS_EndRequestP9JSContext_1(IntPtr cx);

	[DllImport("xul", CallingConvention = CallingConvention.Cdecl, EntryPoint = "_Z19JS_EnterCompartmentP9JSContextP8JSObject")]
	private static extern IntPtr _Z19JS_EnterCompartmentP9JSContextP8JSObject_1(IntPtr cx, IntPtr obj);

	[DllImport("xul", CallingConvention = CallingConvention.Cdecl, EntryPoint = "_Z16JS_ExecuteScriptP9JSContextN2JS6HandleIP8JSScriptEENS1_13MutableHandleINS1_5ValueEEE")]
	[return: MarshalAs(UnmanagedType.U1)]
	private static extern bool _Z16JS_ExecuteScriptP9JSContextN2JS6HandleIP8JSScriptEENS1_13MutableHandleINS1_5ValueEEE_1(IntPtr cx, ref IntPtr handleScript, ref MutableHandleValue jsValue);

	[DllImport("xul", CallingConvention = CallingConvention.Cdecl, EntryPoint = "_Z7JS_freeP9JSContextPv")]
	private static extern void _Z7JS_freeP9JSContextPv_1(IntPtr cx, IntPtr p);

	[DllImport("xul", CallingConvention = CallingConvention.Cdecl, EntryPoint = "_Z11JS_GetClassP8JSObject")]
	private static extern IntPtr _Z11JS_GetClassP8JSObject_1(IntPtr obj);

	[DllImport("xul", CallingConvention = CallingConvention.Cdecl, EntryPoint = "_Z17JS_GetClassObjectP9JSContext10JSProtoKeyN2JS13MutableHandleIP8JSObjectEE")]
	private static extern IntPtr _Z17JS_GetClassObjectP9JSContext10JSProtoKeyN2JS13MutableHandleIP8JSObjectEE_1(IntPtr context, IntPtr proto, ref MutableHandle jsObject);

	[DllImport("xul", CallingConvention = CallingConvention.Cdecl, EntryPoint = "_Z27JS_GetCompartmentPrincipalsP13JSCompartment")]
	private static extern IntPtr _Z27JS_GetCompartmentPrincipalsP13JSCompartment_1(IntPtr jsCompartment);

	[DllImport("xul", CallingConvention = CallingConvention.Cdecl, EntryPoint = "_Z18JS_ContextIteratorP9JSRuntimePP9JSContext")]
	private static extern IntPtr _Z18JS_ContextIteratorP9JSRuntimePP9JSContext_1(IntPtr rt, ref IntPtr iterp);

	[DllImport("xul", CallingConvention = CallingConvention.Cdecl, EntryPoint = "_Z20JS_GetContextPrivateP9JSContext")]
	private static extern IntPtr _Z20JS_GetContextPrivateP9JSContext_1(IntPtr context);

	[DllImport("xul", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, EntryPoint = "_Z22JS_GetEmptyStringValueP9JSContext")]
	private static extern JsVal _Z22JS_GetEmptyStringValueP9JSContext_1(IntPtr cx);

	[DllImport("xul", CallingConvention = CallingConvention.Cdecl, EntryPoint = "_Z21JS_GetGlobalForObjectP9JSContextP8JSObject")]
	private static extern IntPtr _Z21JS_GetGlobalForObjectP9JSContextP8JSObject_1(IntPtr aJSContext, IntPtr jsObject);

	[DllImport("xul", CallingConvention = CallingConvention.Cdecl, EntryPoint = "_Z19JS_LeaveCompartmentP9JSContextP13JSCompartment")]
	private static extern void _Z19JS_LeaveCompartmentP9JSContextP13JSCompartment_1(IntPtr cx, IntPtr oldCompartment);

	[DllImport("xul", CallingConvention = CallingConvention.Cdecl, EntryPoint = "_Z14JS_GetPropertyP9JSContextN2JS6HandleIP8JSObjectEEPKcNS1_13MutableHandleINS1_5ValueEEE")]
	[return: MarshalAs(UnmanagedType.U1)]
	private static extern bool _Z14JS_GetPropertyP9JSContextN2JS6HandleIP8JSObjectEEPKcNS1_13MutableHandleINS1_5ValueEEE_1(IntPtr cx, ref IntPtr jsObject, string name, ref JsVal jsValue);

	[DllImport("xul", CallingConvention = CallingConvention.Cdecl, EntryPoint = "_Z18JS_GetStringLengthP8JSString")]
	private static extern int _Z18JS_GetStringLengthP8JSString_1(IntPtr jsString);

	[DllImport("xul", CallingConvention = CallingConvention.Cdecl, EntryPoint = "_Z26JS_GetStringEncodingLengthP9JSContextP8JSString")]
	private static extern int _Z26JS_GetStringEncodingLengthP9JSContextP8JSString_1(IntPtr cx, IntPtr jsString);

	[DllImport("xul", CallingConvention = CallingConvention.Cdecl, EntryPoint = "_Z14JS_HasPropertyP9JSContextN2JS6HandleIP8JSObjectEEPKcPb")]
	[return: MarshalAs(UnmanagedType.U1)]
	private static extern bool _Z14JS_HasPropertyP9JSContextN2JS6HandleIP8JSObjectEEPKcPb_1(IntPtr cx, ref IntPtr jsObject, string name, [MarshalAs(UnmanagedType.U1)] out bool found);

	[DllImport("xul", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, EntryPoint = "_Z27JS_GetNegativeInfinityValueP9JSContext")]
	private static extern JsVal _Z27JS_GetNegativeInfinityValueP9JSContext_1(IntPtr cx);

	[DllImport("xul", CallingConvention = CallingConvention.Cdecl, EntryPoint = "_Z22JS_GetPendingExceptionP9JSContextN2JS13MutableHandleINS1_5ValueEEE")]
	[return: MarshalAs(UnmanagedType.U1)]
	private static extern bool _Z22JS_GetPendingExceptionP9JSContextN2JS13MutableHandleINS1_5ValueEEE_1(IntPtr cx, ref MutableHandle handle);

	[DllImport("xul", CallingConvention = CallingConvention.Cdecl)]
	private static extern IntPtr _Z13JS_NewContextP9JSRuntimem(IntPtr runtime, int stacksize);

	[DllImport("xul", CallingConvention = CallingConvention.Cdecl, EntryPoint = "_Z17JS_NewPlainObjectP9JSContext")]
	private static extern IntPtr _Z17JS_NewPlainObjectP9JSContext_1(IntPtr cx);

	[DllImport("xul", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
	private static extern IntPtr _Z17JS_NewStringCopyNP9JSContextPKcm(IntPtr cx, string str, int length);

	[DllImport("xul", CallingConvention = CallingConvention.Cdecl, EntryPoint = "_Z17JS_SaveFrameChainP9JSContext")]
	[return: MarshalAs(UnmanagedType.U1)]
	private static extern bool _Z17JS_SaveFrameChainP9JSContext_1(IntPtr jsContext);

	[DllImport("xul", CallingConvention = CallingConvention.Cdecl, EntryPoint = "_Z27JS_SetCompartmentPrincipalsP13JSCompartmentP12JSPrincipals")]
	private static extern void _Z27JS_SetCompartmentPrincipalsP13JSCompartmentP12JSPrincipals_1(IntPtr jsCompartment, IntPtr principals);

	[DllImport("xul", CallingConvention = CallingConvention.Cdecl, EntryPoint = "_Z21JS_SetContextCallbackP9JSRuntimePFbP9JSContextjPvES3_")]
	private static extern void _Z21JS_SetContextCallbackP9JSRuntimePFbP9JSContextjPvES3__1(IntPtr rt, JSContextCallback cb, IntPtr data);

	[DllImport("xul", CallingConvention = CallingConvention.Cdecl, EntryPoint = "_Z20JS_SetContextPrivateP9JSContextPv")]
	private static extern void _Z20JS_SetContextPrivateP9JSContextPv_1(IntPtr context, IntPtr data);

	[DllImport("xul", CallingConvention = CallingConvention.Cdecl, EntryPoint = "_Z19JS_SetErrorReporterP9JSRuntimePFvP9JSContextPKcP13JSErrorReportE")]
	private static extern JSErrorReportCallback _Z19JS_SetErrorReporterP9JSRuntimePFvP9JSContextPKcP13JSErrorReportE_1(IntPtr runtime, JSErrorReportCallback callback);

	[DllImport("xul", CallingConvention = CallingConvention.Cdecl, EntryPoint = "_Z14JS_SetPropertyP9JSContextN2JS6HandleIP8JSObjectEEPKcNS2_INS1_5ValueEEE")]
	[return: MarshalAs(UnmanagedType.U1)]
	private static extern bool _Z14JS_SetPropertyP9JSContextN2JS6HandleIP8JSObjectEEPKcNS2_INS1_5ValueEEE_1(IntPtr cx, ref IntPtr jsObject, string name, ref JsVal jsValue);

	[DllImport("xul", CallingConvention = CallingConvention.Cdecl, EntryPoint = "_Z23JS_SetTrustedPrincipalsP9JSRuntimeP12JSPrincipals")]
	private static extern void _Z23JS_SetTrustedPrincipalsP9JSRuntimeP12JSPrincipals_1(IntPtr runtime, IntPtr principals);

	[DllImport("xul", CallingConvention = CallingConvention.Cdecl, EntryPoint = "_Z14JS_TypeOfValueP9JSContextN2JS6HandleINS1_5ValueEEE")]
	private static extern JSType _Z14JS_TypeOfValueP9JSContextN2JS6HandleINS1_5ValueEEE_1(IntPtr cx, ref JsVal jsVal);

	[DllImport("xul", CallingConvention = CallingConvention.Cdecl, EntryPoint = "_Z16JS_ValueToObjectP9JSContextN2JS6HandleINS1_5ValueEEENS1_13MutableHandleIP8JSObjectEE")]
	[return: MarshalAs(UnmanagedType.U1)]
	private static extern bool _Z16JS_ValueToObjectP9JSContextN2JS6HandleINS1_5ValueEEENS1_13MutableHandleIP8JSObjectEE_1(IntPtr cx, ref JsVal jsValue, ref MutableHandle jsObject);

	[DllImport("xul", CallingConvention = CallingConvention.Cdecl, EntryPoint = "_Z13JS_GetRuntimeP9JSContext")]
	private static extern IntPtr _Z13JS_GetRuntimeP9JSContext_1(IntPtr context);

	[DllImport("xul", CallingConvention = CallingConvention.Cdecl, EntryPoint = "_Z13JS_WrapObjectP9JSContextN2JS13MutableHandleIP8JSObjectEE")]
	[return: MarshalAs(UnmanagedType.U1)]
	private static extern bool _Z13JS_WrapObjectP9JSContextN2JS13MutableHandleIP8JSObjectEE_1(IntPtr cx, ref MutableHandle p);

	[DllImport("xul", CallingConvention = CallingConvention.Cdecl, EntryPoint = "_ZN2js12ToStringSlowEP9JSContextN2JS6HandleINS2_5ValueEEE")]
	private static extern IntPtr _ZN2js12ToStringSlowEP9JSContextN2JS6HandleINS2_5ValueEEE_1(IntPtr cx, ref JsVal v);
}
