using System;
using System.Reflection;
using System.Security.Cryptography;
using SmartAssembly.SmartExceptionsCore;

namespace SmartAssembly.SmartUsageCore;

[AttributeUsage(AttributeTargets.Constructor | AttributeTargets.Method)]
public class ReportUsageAttribute : Attribute
{
	public ReportUsageAttribute()
	{
		try
		{
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException1(exception, this);
			throw;
		}
	}

	public ReportUsageAttribute(string featureName)
	{
		try
		{
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException2(exception, this, featureName);
			throw;
		}
	}

	static ReportUsageAttribute()
	{
		try
		{
			DoNotPruneAttribute.smethod_8();
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException0(exception);
			throw;
		}
	}

	internal static int smethod_0(MemberInfo memberInfo_0, int int_0, int int_1)
	{
		int num = default(int);
		try
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 23:
					return memberInfo_0.MetadataToken;
				}
				num = 1;
			}
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException4(exception, num, memberInfo_0, int_0, int_1);
			throw;
		}
	}

	internal static string smethod_1(Exception exception_0, int int_0, int int_1)
	{
		int num = default(int);
		try
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 115:
					return exception_0.ToString();
				}
				num = 0;
			}
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException4(exception, num, exception_0, int_0, int_1);
			throw;
		}
	}

	internal static byte[] smethod_2(HashAlgorithm hashAlgorithm_0, byte[] byte_0, int int_0, int int_1)
	{
		int num = default(int);
		try
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 87:
					return hashAlgorithm_0.ComputeHash(byte_0);
				}
				num = 2;
			}
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException5(exception, num, hashAlgorithm_0, byte_0, int_0, int_1);
			throw;
		}
	}

	internal static Assembly[] smethod_3(AppDomain appDomain_0, int int_0, int int_1)
	{
		int num = default(int);
		try
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 89:
					return appDomain_0.GetAssemblies();
				}
				num = 4;
			}
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException4(exception, num, appDomain_0, int_0, int_1);
			throw;
		}
	}

	internal static AppDomain smethod_4(int int_0, int int_1)
	{
		try
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 116:
					return AppDomain.CurrentDomain;
				}
			}
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException2(exception, int_0, int_1);
			throw;
		}
	}
}
