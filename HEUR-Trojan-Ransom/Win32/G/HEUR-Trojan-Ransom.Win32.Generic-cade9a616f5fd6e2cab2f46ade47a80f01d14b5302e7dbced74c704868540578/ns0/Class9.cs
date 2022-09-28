using System;
using System.ComponentModel.Design;
using System.Configuration;
using System.Reflection;
using System.Runtime.Serialization;
using System.Security;
using System.Windows.Forms;
using System.Xml.Linq;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.CompilerServices;
using prince.My;

namespace ns0;

[StandardModule]
[HideModuleName]
internal sealed class Class9
{
	[HelpKeyword("My.Settings")]
	internal static MySettings MySettings_0 => (MySettings)(ApplicationSettingsBase)MySettings.Default;

	[SecuritySafeCritical]
	static Class9()
	{
		Class3.Class5.smethod_2();
	}

	[SecuritySafeCritical]
	internal static bool smethod_0<T>(T gparam_0, int int_0, char char_0) where T : WindowsFormsApplicationBase
	{
		int num = 0;
		bool result;
		int num2;
		do
		{
			result = (((char_0 ^ int_0) - 104) ^ num) switch
			{
				0 => Class10.Class11.smethod_0<WindowsFormsApplicationBase>((WindowsFormsApplicationBase)(object)gparam_0, (short)860, 856), 
				_ => false, 
			};
			num++;
			num2 = char_0 * char_0;
			num2 = char_0 + num2;
		}
		while (num2 % 2 != 0);
		return result;
	}

	[SecuritySafeCritical]
	internal static void smethod_1<T>(T gparam_0, char char_0, char char_1)
	{
		int num = 0;
		do
		{
			switch (((char_0 ^ char_1) - 80) ^ num)
			{
			case 1:
				Class12.Class13.smethod_0((object)gparam_0, (short)877, (short)811);
				break;
			case 0:
				Class12.Class13.smethod_0((object)gparam_0, (short)422, (short)483);
				break;
			}
			num++;
		}
		while ((char_1 * char_1 + char_1) % 2 != 0);
	}

	[SecuritySafeCritical]
	internal static void smethod_2<T, U>(U gparam_0, T gparam_1, short short_0, int int_0) where T : ShutdownEventHandler where U : WindowsFormsApplicationBase
	{
		int num = 0;
		switch (((short_0 ^ int_0) - 77) ^ 0)
		{
		case 0:
			Class12.Class13.smethod_1<WindowsFormsApplicationBase, ShutdownEventHandler>((WindowsFormsApplicationBase)(object)gparam_0, (ShutdownEventHandler)(object)gparam_1, 263, 'Ū');
			break;
		}
		num++;
	}

	[SecuritySafeCritical]
	internal static void smethod_3<T>(T gparam_0, short short_0, short short_1) where T : Control
	{
		int num = 0;
		switch (((short_0 ^ short_1) - 49) ^ 0)
		{
		case 0:
			Class10.Class11.smethod_1<Control>((Control)(object)gparam_0, 723, 663);
			break;
		}
		num++;
	}

	[SecuritySafeCritical]
	internal static void smethod_4<T, U>(T gparam_0, U gparam_1, int int_0, short short_0) where T : Control where U : string
	{
		int num = 0;
		do
		{
			switch (((short_0 ^ int_0) - 122) ^ num)
			{
			case 0:
				Class12.Class13.smethod_2<string, Control>((Control)(object)gparam_0, (string)gparam_1, '\u02fa', (short)722);
				break;
			}
			num++;
		}
		while ((short_0 * short_0 + short_0) % 2 != 0);
	}

	[SecuritySafeCritical]
	internal static Assembly smethod_5(short short_0, char char_0)
	{
		int num = 0;
		Assembly result = (((char_0 ^ short_0) - 75) ^ 0) switch
		{
			0 => (Assembly)(ISerializable)Class10.Class11.smethod_2(981, 967), 
			_ => null, 
		};
		num++;
		return result;
	}

	[SecuritySafeCritical]
	internal static Assembly smethod_6(byte[] byte_0, byte[] byte_1, SecurityContextSource securityContextSource_0, short short_0, int int_0)
	{
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Expected O, but got Unknown
		int num = 0;
		Assembly result = (((short_0 ^ int_0) - 108) ^ 0) switch
		{
			0 => (Assembly)(IEvidenceFactory)Class12.smethod_0(byte_0, byte_1, securityContextSource_0, 404, 493), 
			_ => null, 
		};
		num++;
		return result;
	}

	[SecuritySafeCritical]
	internal static void smethod_7<T, U, V>(T gparam_0, U gparam_1, V gparam_2, int int_0, int int_1) where T : XElement where U : XName
	{
		int num = 0;
		switch (((int_1 ^ int_0) - 63) ^ 0)
		{
		case 0:
			Class10.Class11.smethod_3<XElement, object, XName>((XElement)(object)gparam_0, (XName)(object)gparam_1, (object)gparam_2, 964, (short)945);
			break;
		}
		num++;
	}

	[SecuritySafeCritical]
	internal static string smethod_8<T>(T gparam_0, string[] string_0, char char_0, char char_1) where T : string
	{
		int num = 0;
		string result = (((char_1 ^ char_0) - 60) ^ 0) switch
		{
			0 => (string)(ICloneable)Class12.smethod_1((string)gparam_0, string_0, 427, 'ƞ'), 
			_ => null, 
		};
		num++;
		return result;
	}
}
