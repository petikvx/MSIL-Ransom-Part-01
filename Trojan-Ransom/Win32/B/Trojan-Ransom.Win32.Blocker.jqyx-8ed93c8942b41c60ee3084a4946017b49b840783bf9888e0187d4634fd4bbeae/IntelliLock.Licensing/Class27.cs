using System;
using System.ComponentModel;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading;

namespace IntelliLock.Licensing;

[Attribute1(CBPJIFOEJODEDAIKFEHLINCOJEILAOPJLPJM = true, MILJMOALDHJBDENJEIFBOPJBAHHFENPIBGJJ = true, GPLINEOBJKEEECKFEIKDKBKILCBHDFGDIEPC = true)]
internal class Class27
{
	[Attribute1(CBPJIFOEJODEDAIKFEHLINCOJEILAOPJLPJM = true, GPLINEOBJKEEECKFEIKDKBKILCBHDFGDIEPC = true)]
	internal delegate void Delegate1();

	[Attribute1(CBPJIFOEJODEDAIKFEHLINCOJEILAOPJLPJM = true, GPLINEOBJKEEECKFEIKDKBKILCBHDFGDIEPC = true)]
	public delegate void Delegate2();

	private static Class25 class25_0;

	internal static bool bool_0;

	internal static bool bool_1;

	internal static Timer timer_0;

	internal static Timer timer_1;

	private static Delegate1 delegate1_0;

	private static Delegate1 delegate1_1;

	private static Delegate2 delegate2_0;

	internal static bool bool_2;

	[Attribute1(CBPJIFOEJODEDAIKFEHLINCOJEILAOPJLPJM = true, GPLINEOBJKEEECKFEIKDKBKILCBHDFGDIEPC = true)]
	internal static event Delegate1 Event_0
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			delegate1_0 = (Delegate1)Delegate.Combine(delegate1_0, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			delegate1_0 = (Delegate1)Delegate.Remove(delegate1_0, value);
		}
	}

	internal static event Delegate1 Event_1
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			delegate1_1 = (Delegate1)Delegate.Combine(delegate1_1, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			delegate1_1 = (Delegate1)Delegate.Remove(delegate1_1, value);
		}
	}

	[Attribute1(CBPJIFOEJODEDAIKFEHLINCOJEILAOPJLPJM = true, GPLINEOBJKEEECKFEIKDKBKILCBHDFGDIEPC = true)]
	public static event Delegate2 Event_2
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			delegate2_0 = (Delegate2)Delegate.Combine(delegate2_0, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			delegate2_0 = (Delegate2)Delegate.Remove(delegate2_0, value);
		}
	}

	internal static void smethod_0()
	{
		lock (Class3.object_0)
		{
			if (delegate2_0 != null)
			{
				if (timer_1 != null)
				{
					timer_1.Change(-1, -1);
					timer_1 = null;
				}
				delegate2_0();
			}
			else if (timer_1 == null)
			{
				timer_1 = new Timer(smethod_1, null, 2000, 2000);
			}
		}
	}

	internal static void smethod_1(object object_0)
	{
		lock (Class3.object_0)
		{
			if (delegate2_0 != null && timer_1 != null)
			{
				timer_1.Change(-1, -1);
				timer_1 = null;
				delegate2_0();
			}
		}
	}

	internal static void smethod_2()
	{
		if (!bool_2)
		{
			bool_2 = true;
			if (delegate1_1 != null)
			{
				delegate1_1();
			}
			string text = "System.Reflection.ObfuscationAttribute";
			string text2 = "INTELLILOCKCALLBACK";
			try
			{
				Type[] types = typeof(Class3).Assembly.GetTypes();
				for (int i = 0; i < types.Length; i++)
				{
					object[] customAttributes = types[i].GetCustomAttributes(inherit: false);
					bool flag = false;
					for (int j = 0; j < customAttributes.Length; j++)
					{
						if (customAttributes[j].GetType().FullName == text && ((ObfuscationAttribute)customAttributes[j]).Feature == text2)
						{
							flag = true;
							break;
						}
					}
					if (!flag)
					{
						continue;
					}
					MethodInfo[] methods = types[i].GetMethods();
					foreach (MethodInfo methodInfo in methods)
					{
						customAttributes = methodInfo.GetCustomAttributes(inherit: false);
						for (int l = 0; l < customAttributes.Length; l++)
						{
							if (customAttributes[l].GetType().FullName == text && ((ObfuscationAttribute)customAttributes[l]).Feature == text2)
							{
								methodInfo.Invoke(null, new object[0]);
							}
						}
					}
				}
			}
			catch
			{
			}
		}
		lock (Class3.object_0)
		{
			if (delegate1_0 != null)
			{
				if (timer_0 != null)
				{
					timer_0.Change(-1, -1);
					timer_0 = null;
				}
				delegate1_0();
			}
			else if (timer_0 == null)
			{
				timer_0 = new Timer(smethod_3, null, 2000, 2000);
			}
		}
	}

	internal static void smethod_3(object object_0)
	{
		lock (Class3.object_0)
		{
			if (delegate1_0 != null && timer_0 != null)
			{
				timer_0.Change(-1, -1);
				timer_0 = null;
				delegate1_0();
			}
		}
	}

	[SpecialName]
	public static Class25 smethod_4()
	{
		lock (Class3.object_0)
		{
			if (!bool_0 && !bool_1)
			{
				new Class3().method_12(LicenseManager.CurrentContext, typeof(Class27), null, bool_16: true, bool_17: false, bool_18: false, bool_19: false, "", "", null, bool_20: false, bool_21: false, bool_22: false);
				smethod_2();
			}
			return class25_0;
		}
	}

	public static void smethod_5(string string_0)
	{
		smethod_7(Class3.smethod_38(string_0), string_0);
	}

	public static void smethod_6(byte[] byte_0)
	{
		smethod_7(byte_0, null);
	}

	public static void smethod_7(byte[] byte_0, string string_0)
	{
		try
		{
			LicenseManager.CurrentContext?.SetSavedLicenseKey(typeof(ILLicenseModule), Convert.ToBase64String(byte_0));
		}
		catch
		{
		}
		string string_ = Class3.smethod_3("<RSAKeyValue><Modulus>t0R+zt7wCeBClCmwRoOzVMQ4RbT7l4UXdrdrZ3hwYkE2LqCdBZujJLaZcoeozjRDu5zgr7slwKQpFQiQ3eu0vj07Khot/6fVgkTIoHQ58sn1weQnPy4DrvNYGuYTOT1ceNg+3vkFWrLdp8Mjo8gRNHRLqDKCMRATAWni5g/bvfVIJDmuNlF6dJqP2tHldZUoOfuIg5j+f1jO73oMSC6Hagm56i1oVDLjAusRgjY5+no8+bdhEE8JwxDFz2NA9pLo6uYX7K9eCb4N1vML6wUD5V/2kYIEO+vg0K+P987kceI78o5fwI2Hn8wSK5Bsl9aezOgUWtMbMOz+0izBKoDUGw==</Modulus><Exponent>AQAB</Exponent></RSAKeyValue>");
		try
		{
			string string_2 = Class3.smethod_0(string_);
			Class3.smethod_39(string_2, byte_0);
			if (string_0 != null)
			{
				string path = Class3.smethod_1(string_);
				File.WriteAllLines(path, new string[2]
				{
					string_0,
					Convert.ToBase64String(Class1.smethod_9(byte_0))
				});
			}
		}
		catch (Exception)
		{
			try
			{
				string string_3 = Class3.smethod_2(string_);
				Class3.smethod_39(string_3, byte_0);
			}
			catch
			{
			}
		}
	}

	public static byte[] smethod_8()
	{
		return Class3.byte_0;
	}

	public static void smethod_9(string string_0)
	{
		lock (Class3.object_0)
		{
			new Class3().method_12(LicenseManager.CurrentContext, typeof(Class28), null, bool_16: true, bool_17: true, bool_18: false, bool_19: false, "", string_0, null, bool_20: false, bool_21: false, bool_22: false);
			smethod_2();
		}
	}

	public static void smethod_10(byte[] byte_0)
	{
		lock (Class3.object_0)
		{
			new Class3().method_12(LicenseManager.CurrentContext, typeof(Class28), null, bool_16: true, bool_17: true, bool_18: false, bool_19: false, "", "", byte_0, bool_20: false, bool_21: false, bool_22: false);
			smethod_2();
		}
	}

	static Class27()
	{
		class25_0 = new Class25();
		bool_0 = false;
		bool_1 = false;
		timer_0 = null;
		timer_1 = null;
		bool_2 = false;
	}
}
