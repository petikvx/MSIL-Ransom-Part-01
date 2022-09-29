using System;
using System.Net.Security;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;

public class GClass16
{
	public class GClass17
	{
		[Serializable]
		[CompilerGenerated]
		private sealed class Class8
		{
			public static readonly Class8 class8_0 = new Class8();

			public static RemoteCertificateValidationCallback remoteCertificateValidationCallback_0;

			internal bool method_0(object object_0, X509Certificate x509Certificate_0, X509Chain x509Chain_0, SslPolicyErrors sslPolicyErrors_0)
			{
				return true;
			}
		}

		[CompilerGenerated]
		private string string_0;

		[CompilerGenerated]
		private string string_1;

		public string String_0
		{
			[CompilerGenerated]
			get
			{
				return string_0;
			}
			[CompilerGenerated]
			private set
			{
				string_0 = value;
			}
		}

		public string String_1
		{
			[CompilerGenerated]
			get
			{
				return string_1;
			}
			[CompilerGenerated]
			private set
			{
				string_1 = value;
			}
		}

		protected bool method_0(byte[] byte_0)
		{
			int num = BitConverter.ToInt32(byte_0, 32);
			if (num == 0)
			{
				return false;
			}
			int index = BitConverter.ToInt32(byte_0, 28);
			String_0 = Encoding.UTF8.GetString(byte_0, index, num);
			if (String_0[String_0.Length - 1] != '/')
			{
				String_0 += "/";
			}
			return true;
		}

		protected void method_1()
		{
			String_0 = Convert.ToBase64String(Encoding.UTF8.GetBytes(String_0));
		}

		protected void method_2(string string_2, string string_3)
		{
			method_3(string_2, bool_0: false);
			method_3(string_3, bool_0: true);
		}

		private void method_3(string string_2, bool bool_0)
		{
			if (bool_0)
			{
				StringBuilder stringBuilder = new StringBuilder(String_0);
				foreach (char c in string_2)
				{
					switch (c)
					{
					default:
						stringBuilder.Append(c);
						break;
					case '=':
						stringBuilder.Append("%3D");
						break;
					case '/':
						stringBuilder.Append("%2F");
						break;
					case '+':
						stringBuilder.Append("%2B");
						break;
					}
				}
				String_0 = stringBuilder.ToString();
			}
			else
			{
				String_0 += string_2;
			}
		}

		public unsafe static object smethod_0(void* pVoid_0)
		{
			return Pointer.Box(pVoid_0, typeof(void*));
		}

		public unsafe static void* smethod_1(object object_0)
		{
			return Pointer.Unbox(object_0);
		}
	}

	public class GClass18 : GClass17
	{
		[CompilerGenerated]
		private string string_2;
	}

	public class GClass19 : GClass17
	{
	}

	private readonly byte[] byte_0;

	private byte[] byte_1;

	private readonly object object_0;

	private GEnum0 genum0_0;

	private long long_0;

	private readonly int int_0;

	private int int_1;

	private uint uint_0;

	public GClass16(long long_1)
	{
		object[] array = new object[2] { this, long_1 };
		new GClass22().method_112(array, 817085);
	}

	public GClass16(byte[] byte_2)
	{
		object[] array = new object[2] { this, byte_2 };
		new GClass22().method_112(array, 853181);
	}
}
