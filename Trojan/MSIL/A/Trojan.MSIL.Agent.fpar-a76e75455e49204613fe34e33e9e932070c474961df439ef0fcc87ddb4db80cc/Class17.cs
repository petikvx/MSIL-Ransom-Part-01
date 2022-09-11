using System;
using System.Security.AccessControl;
using System.Security.Principal;
using System.Text;
using Microsoft.VisualBasic.CompilerServices;

[StandardModule]
internal sealed class Class17
{
	public static string smethod_0(string string_0, string string_1)
	{
		UIntPtr uintptr_ = new UIntPtr(2147483650u);
		IntPtr intptr_ = default(IntPtr);
		if (Class9.RegOpenKeyEx(uintptr_, string_0, 0, 131353, ref intptr_) != 0)
		{
			return string.Empty;
		}
		StringBuilder stringBuilder = null;
		IntPtr intptr_2 = intptr_;
		int int_ = 0;
		int int_2 = default(int);
		if (Class9.RegQueryValueEx(intptr_2, string_1, 0, ref int_, stringBuilder, ref int_2) == 0)
		{
			stringBuilder = new StringBuilder(int_2);
			IntPtr intptr_3 = intptr_;
			int_ = 0;
			Class9.RegQueryValueEx(intptr_3, string_1, 0, ref int_, stringBuilder, ref int_2);
		}
		Class9.RegCloseKey(intptr_);
		if (stringBuilder == null)
		{
			return string.Empty;
		}
		return stringBuilder.ToString();
	}

	public static bool smethod_1()
	{
		try
		{
			RawSecurityDescriptor rawSecurityDescriptor = smethod_3();
			SecurityIdentifier sid = new SecurityIdentifier(WellKnownSidType.WorldSid, null);
			CommonAce ace = new CommonAce(AceFlags.None, AceQualifier.AccessAllowed, 2035707, sid, isCallback: false, null);
			rawSecurityDescriptor.DiscretionaryAcl!.InsertAce(0, ace);
			return smethod_4(rawSecurityDescriptor);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception exception_ = ex;
			Class8.smethod_86(exception_, "RestoreAccessControlEntries");
			bool result = false;
			ProjectData.ClearProjectError();
			return result;
		}
	}

	public static bool smethod_2()
	{
		try
		{
			return smethod_4(smethod_3());
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception exception_ = ex;
			Class8.smethod_86(exception_, "ClearAccessControlEntries");
			bool result = false;
			ProjectData.ClearProjectError();
			return result;
		}
	}

	private static RawSecurityDescriptor smethod_3()
	{
		DiscretionaryAcl discretionaryAcl = new DiscretionaryAcl(isContainer: false, isDS: false, 0);
		byte[] binaryForm = new byte[discretionaryAcl.BinaryLength - 1 + 1];
		discretionaryAcl.GetBinaryForm(binaryForm, 0);
		return new RawSecurityDescriptor(ControlFlags.DiscretionaryAclPresent, null, null, null, new RawAcl(binaryForm, 0));
	}

	private static bool smethod_4(RawSecurityDescriptor rawSecurityDescriptor_0)
	{
		byte[] array = new byte[rawSecurityDescriptor_0.BinaryLength - 1 + 1];
		rawSecurityDescriptor_0.GetBinaryForm(array, 0);
		return Class9.SetKernelObjectSecurity(Class15.intptr_0, 4, array);
	}

	public static bool smethod_5(byte[] byte_0, byte[] byte_1)
	{
		if (byte_0.Length != byte_1.Length)
		{
			return false;
		}
		int num = byte_1.Length - 1;
		int num2 = 0;
		while (true)
		{
			if (num2 <= num)
			{
				if (byte_0[num2] != byte_1[num2])
				{
					break;
				}
				num2++;
				continue;
			}
			return true;
		}
		return false;
	}

	public static string smethod_6(Exception exception_0)
	{
		string text = smethod_7(exception_0);
		if (text.Length > 4096)
		{
			text = text.Remove(4093) + "...";
		}
		return text;
	}

	private static string smethod_7(Exception exception_0)
	{
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.AppendLine(exception_0.Message);
		stringBuilder.AppendLine();
		stringBuilder.AppendLine(exception_0.GetType().FullName);
		stringBuilder.AppendLine(exception_0.StackTrace);
		if (exception_0.InnerException != null)
		{
			stringBuilder.AppendLine();
			stringBuilder.AppendLine(smethod_7(exception_0.InnerException));
		}
		return stringBuilder.ToString();
	}
}
