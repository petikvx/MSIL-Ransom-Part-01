using System;
using System.IO;
using System.Reflection;
using System.Text;

namespace A;

internal class c632a89bb0d53924867475883f36b4224
{
	internal static readonly byte[] c2c3a4c8237b451486288e478654cc54f;

	static c632a89bb0d53924867475883f36b4224()
	{
		if (c2c3a4c8237b451486288e478654cc54f == null)
		{
			string s = "NTU1NTUuZXhlJA==";
			byte[] array = Convert.FromBase64String(s);
			s = Encoding.UTF8.GetString(array, 0, array.Length);
			Stream manifestResourceStream = Assembly.GetExecutingAssembly().GetManifestResourceStream(s);
			c2c3a4c8237b451486288e478654cc54f = c264cf2e29d5227069de62b1add59d073.c74d0234c557f87e8044b7f546ed7328f(97L, manifestResourceStream);
		}
	}

	internal static string c4d30ab6240cd8b4d2b33df56851ecc87(int cf6dc1514b7401d32ca08240f004a859a)
	{
		int num = 0;
		if ((c2c3a4c8237b451486288e478654cc54f[cf6dc1514b7401d32ca08240f004a859a] & 0x80) == 0)
		{
			num = c2c3a4c8237b451486288e478654cc54f[cf6dc1514b7401d32ca08240f004a859a];
			cf6dc1514b7401d32ca08240f004a859a++;
		}
		else if ((c2c3a4c8237b451486288e478654cc54f[cf6dc1514b7401d32ca08240f004a859a] & 0x40) == 0)
		{
			num = (c2c3a4c8237b451486288e478654cc54f[cf6dc1514b7401d32ca08240f004a859a] & -129) << 8;
			num |= c2c3a4c8237b451486288e478654cc54f[cf6dc1514b7401d32ca08240f004a859a + 1];
			cf6dc1514b7401d32ca08240f004a859a += 2;
		}
		else
		{
			num = (c2c3a4c8237b451486288e478654cc54f[cf6dc1514b7401d32ca08240f004a859a] & -193) << 24;
			num |= c2c3a4c8237b451486288e478654cc54f[cf6dc1514b7401d32ca08240f004a859a + 1] << 16;
			num |= c2c3a4c8237b451486288e478654cc54f[cf6dc1514b7401d32ca08240f004a859a + 2] << 8;
			num |= c2c3a4c8237b451486288e478654cc54f[cf6dc1514b7401d32ca08240f004a859a + 3];
			cf6dc1514b7401d32ca08240f004a859a += 4;
		}
		if (num < 1)
		{
			return string.Empty;
		}
		string @string = Encoding.Unicode.GetString(c2c3a4c8237b451486288e478654cc54f, cf6dc1514b7401d32ca08240f004a859a, num);
		return string.Intern(@string);
	}
}
