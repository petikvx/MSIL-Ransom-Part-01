using System;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Security.Cryptography;
using SmartAssembly.SmartExceptionsCore;
using SmartAssembly.SmartUsageCore;
using ns0;

namespace SmartAssembly.Zip;

public sealed class AESCryptoIndirector : IDisposable
{
	internal Type type_0;

	internal object object_0;

	public AESCryptoIndirector()
	{
		Assembly assembly = default(Assembly);
		Type o = default(Type);
		Type o2 = default(Type);
		object o3 = default(object);
		try
		{
			try
			{
				try
				{
					assembly = DoNotPruneTypeAttribute.smethod_3("System.Core, Version=2.0.5.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e", 120, 8);
					o = (type_0 = Form1.smethod_0(assembly, "System.Security.Cryptography.AesManaged", 284, 316));
				}
				catch (FileNotFoundException)
				{
					assembly = DoNotPruneTypeAttribute.smethod_3("mscorlib", 644, 756);
					o2 = (type_0 = Form1.smethod_0(assembly, "System.Security.Cryptography.RijndaelManaged", 858, 890));
				}
				o3 = (object_0 = Activator.CreateInstance(type_0));
			}
			catch (Exception exception)
			{
				StackFrameHelper.CreateException2(exception, assembly, this);
				throw;
			}
		}
		catch (Exception exception2)
		{
			StackFrameHelper.CreateException5(exception2, assembly, o, o2, o3, this);
			throw;
		}
	}

	public ICryptoTransform GetAESCryptoTransform(byte[] key, byte[] iv, bool decrypt)
	{
		int num = default(int);
		object[] array = default(object[]);
		MethodInfo methodInfo = default(MethodInfo);
		ICryptoTransform cryptoTransform = default(ICryptoTransform);
		int num2 = default(int);
		try
		{
			try
			{
				num = 0;
				MethodInfo methodInfo_ = Class3.smethod_3(SendingReportFeedbackEventArgs.smethod_0(type_0, "Key", 644, 695), 306, 365);
				object obj = object_0;
				array = new object[1] { key };
				UsageCounts.smethod_2(methodInfo_, obj, array, 337, 354);
				num = 3;
				MethodInfo methodInfo_2 = Class3.smethod_3(SendingReportFeedbackEventArgs.smethod_0(type_0, "IV", 17, 34), 274, 333);
				object obj2 = object_0;
				array = new object[1] { iv };
				UsageCounts.smethod_2(methodInfo_2, obj2, array, 947, 896);
				num = 6;
				methodInfo = ReportSender1.smethod_0(type_0, decrypt ? "CreateDecryptor" : "CreateEncryptor", new Type[0], 316, 382);
				cryptoTransform = (ICryptoTransform)methodInfo.Invoke(object_0, new object[0]);
			}
			catch (Exception exception)
			{
				StackFrameHelper.CreateException6(exception, methodInfo, array, this, key, iv, decrypt);
				throw;
			}
			num2 = 2;
			return cryptoTransform;
		}
		catch (Exception exception2)
		{
			StackFrameHelper.CreateException9(exception2, methodInfo, array, cryptoTransform, num, num2, this, key, iv, decrypt);
			throw;
		}
	}

	public void Clear()
	{
		try
		{
			try
			{
				UsageCounts.smethod_2(Class28.smethod_2(type_0, "Clear", 147, 128), object_0, new object[0], 197, 246);
			}
			catch (Exception exception)
			{
				StackFrameHelper.CreateException1(exception, this);
				throw;
			}
		}
		catch (Exception exception2)
		{
			StackFrameHelper.CreateException1(exception2, this);
			throw;
		}
	}

	public void Dispose()
	{
		try
		{
			try
			{
				Clear();
			}
			catch (Exception exception)
			{
				StackFrameHelper.CreateException1(exception, this);
				throw;
			}
		}
		catch (Exception exception2)
		{
			StackFrameHelper.CreateException1(exception2, this);
			throw;
		}
	}

	static AESCryptoIndirector()
	{
		try
		{
			SmartAssembly.SmartUsageCore.DoNotPruneAttribute.smethod_8();
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException0(exception);
			throw;
		}
	}

	internal static void smethod_0(Icon icon_0, int int_0, int int_1)
	{
		int num = default(int);
		try
		{
			num = 5;
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 24:
					icon_0.Dispose();
					return;
				}
				num = 5;
			}
		}
		catch (Exception exception)
		{
			int num2 = default(int);
			StackFrameHelper.CreateException5(exception, num, num2, icon_0, int_0, int_1);
			throw;
		}
	}

	internal static void smethod_1(Graphics graphics_0, IntPtr intptr_0, int int_0, int int_1)
	{
		int num = default(int);
		try
		{
			num = 2;
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 98:
					graphics_0.ReleaseHdc(intptr_0);
					return;
				}
				num = 2;
			}
		}
		catch (Exception exception)
		{
			int num2 = default(int);
			StackFrameHelper.CreateException6(exception, num, num2, graphics_0, intptr_0, int_0, int_1);
			throw;
		}
	}
}
