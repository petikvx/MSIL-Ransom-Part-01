using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("4b5ea59e-af89-44f7-8c1c-2dea47a170d1")]
public interface nsIGfxInfo
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetD2DEnabledAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetDWriteEnabledAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetDWriteVersionAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aDWriteVersion);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetCleartypeParametersAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aCleartypeParameters);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetAdapterDescriptionAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aAdapterDescription);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetAdapterDescription2Attribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aAdapterDescription2);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetAdapterDriverAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aAdapterDriver);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetAdapterDriver2Attribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aAdapterDriver2);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetAdapterVendorIDAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aAdapterVendorID);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetAdapterVendorID2Attribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aAdapterVendorID2);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetAdapterDeviceIDAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aAdapterDeviceID);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetAdapterDeviceID2Attribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aAdapterDeviceID2);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetAdapterSubsysIDAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aAdapterSubsysID);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetAdapterSubsysID2Attribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aAdapterSubsysID2);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetAdapterRAMAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aAdapterRAM);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetAdapterRAM2Attribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aAdapterRAM2);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetAdapterDriverVersionAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aAdapterDriverVersion);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetAdapterDriverVersion2Attribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aAdapterDriverVersion2);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetAdapterDriverDateAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aAdapterDriverDate);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetAdapterDriverDate2Attribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aAdapterDriverDate2);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetIsGPU2ActiveAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	JsVal GetMonitors(IntPtr jsContext);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetFailures(ref uint failureCount, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 0)] ref int[] indices, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 0)] ref string[] failures);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void LogFailure([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase failure);

	[MethodImpl(MethodImplOptions.InternalCall)]
	int GetFeatureStatus(int aFeature);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetFeatureSuggestedDriverVersion(int aFeature, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase retval);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetWebGLParameter([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aParam, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase retval);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetData();

	[MethodImpl(MethodImplOptions.InternalCall)]
	JsVal GetInfo(IntPtr jsContext);

	[MethodImpl(MethodImplOptions.InternalCall)]
	JsVal GetFeatures(IntPtr jsContext);
}
