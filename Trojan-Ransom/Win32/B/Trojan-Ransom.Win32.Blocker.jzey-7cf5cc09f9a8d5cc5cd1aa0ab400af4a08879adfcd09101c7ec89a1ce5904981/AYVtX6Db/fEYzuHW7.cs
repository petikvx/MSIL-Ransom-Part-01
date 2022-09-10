using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace AYVtX6Db;

internal class fEYzuHW7
{
	internal static void RUYROLoJ(Stream stream_0, long long_0, int int_0)
	{
		switch (int_0 ^ 0xEFE1)
		{
		}
		stream_0.Position = long_0;
	}

	internal static string CVS5DEjQ(BinaryReader binaryReader_0, int int_0)
	{
		return (int_0 ^ 0x5F67) switch
		{
			_ => binaryReader_0.ReadString(), 
		};
	}

	internal static byte[] Fl6fbLyQ(string string_0, int int_0)
	{
		return (int_0 ^ 0x9683) switch
		{
			_ => Convert.FromBase64String(string_0), 
		};
	}

	internal static bool zfMKZgwc(int int_0)
	{
		return (int_0 ^ 0x56BD) switch
		{
			_ => Debugger.IsAttached, 
		};
	}

	internal static string L2S57NzP(string string_0, int int_0)
	{
		return (int_0 ^ 0x3BAF) switch
		{
			_ => Environment.GetEnvironmentVariable(string_0), 
		};
	}

	internal static bool smethod_0(string string_0, string string_1, int int_0)
	{
		return (int_0 ^ 0x8EF) switch
		{
			_ => string_0 == string_1, 
		};
	}

	internal static void pFsRLtt5(string string_0, int int_0)
	{
		switch (int_0 ^ 0xCB59)
		{
		}
		Environment.FailFast(string_0);
	}

	internal static string[] l7iyZDKl(Assembly assembly_0, int int_0)
	{
		return (int_0 ^ 0xCD0C) switch
		{
			_ => assembly_0.GetManifestResourceNames(), 
		};
	}

	internal static Rijndael pGjAMdJR(int int_0)
	{
		return (int_0 ^ 0x2916) switch
		{
			_ => Rijndael.Create(), 
		};
	}

	internal static byte[] MhePAUzX(DeriveBytes deriveBytes_0, int int_0, int int_1)
	{
		return (int_1 ^ 0x7B22) switch
		{
			_ => deriveBytes_0.GetBytes(int_0), 
		};
	}

	internal static void QGkjOEqi(SymmetricAlgorithm symmetricAlgorithm_0, byte[] byte_0, int int_0)
	{
		switch (int_0 ^ 0x28E1)
		{
		}
		symmetricAlgorithm_0.Key = byte_0;
	}

	internal static void yNJZv0Pm(SymmetricAlgorithm symmetricAlgorithm_0, byte[] byte_0, int int_0)
	{
		switch (int_0 ^ 0x647C)
		{
		}
		symmetricAlgorithm_0.IV = byte_0;
	}

	internal static ICryptoTransform BPfAiOjc(SymmetricAlgorithm symmetricAlgorithm_0, int int_0)
	{
		return (int_0 ^ 0x4830) switch
		{
			_ => symmetricAlgorithm_0.CreateDecryptor(), 
		};
	}

	internal static void WA4teEur(Stream stream_0, byte[] byte_0, int int_0, int int_1, int int_2)
	{
		switch (int_2 ^ 0x3650)
		{
		}
		stream_0.Write(byte_0, int_0, int_1);
	}

	internal static byte[] ykIjjrxK(MemoryStream memoryStream_0, int int_0)
	{
		return (int_0 ^ 0xC0F9) switch
		{
			_ => memoryStream_0.ToArray(), 
		};
	}

	internal static DialogResult f12YtJmL(string string_0, string string_1, int int_0)
	{
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		return (DialogResult)((int_0 ^ 0x59CD) switch
		{
			_ => MessageBox.Show(string_0, string_1), 
		});
	}
}
