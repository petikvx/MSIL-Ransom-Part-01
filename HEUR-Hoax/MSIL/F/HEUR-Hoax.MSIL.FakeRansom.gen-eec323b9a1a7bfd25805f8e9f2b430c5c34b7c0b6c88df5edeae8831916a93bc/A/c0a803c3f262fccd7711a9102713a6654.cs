using System;
using System.IO;
using System.Reflection;
using System.Text;

namespace A;

internal class c0a803c3f262fccd7711a9102713a6654
{
	internal static readonly byte[] c2c3a4c8237b451486288e478654cc54f;

	internal readonly int c76b8365e2974856c7e977bad4b191af4;

	static c0a803c3f262fccd7711a9102713a6654()
	{
		if (c2c3a4c8237b451486288e478654cc54f == null)
		{
			string s = "NTU1NTUuZXhlJQ==";
			byte[] array = Convert.FromBase64String(s);
			s = Encoding.UTF8.GetString(array, 0, array.Length);
			Stream manifestResourceStream = Assembly.GetExecutingAssembly().GetManifestResourceStream(s);
			c2c3a4c8237b451486288e478654cc54f = c264cf2e29d5227069de62b1add59d073.c74d0234c557f87e8044b7f546ed7328f(97L, manifestResourceStream);
		}
	}

	internal static int cf4113dbb17d51f0f9b0f245f8ad9a7fd(int cf6dc1514b7401d32ca08240f004a859a)
	{
		return BitConverter.ToInt32(c2c3a4c8237b451486288e478654cc54f, cf6dc1514b7401d32ca08240f004a859a);
	}

	internal static long cb4ad711436428cea6799ae2a48177b3d(int cf6dc1514b7401d32ca08240f004a859a)
	{
		return BitConverter.ToInt64(c2c3a4c8237b451486288e478654cc54f, cf6dc1514b7401d32ca08240f004a859a);
	}

	internal static float cb423775907283001481cd249eae7ce47(int cf6dc1514b7401d32ca08240f004a859a)
	{
		return BitConverter.ToSingle(c2c3a4c8237b451486288e478654cc54f, cf6dc1514b7401d32ca08240f004a859a);
	}

	internal static double c3b3c939ecdceb49bbbbcd4c1e6963650(int cf6dc1514b7401d32ca08240f004a859a)
	{
		return BitConverter.ToDouble(c2c3a4c8237b451486288e478654cc54f, cf6dc1514b7401d32ca08240f004a859a);
	}

	internal static void c440df18a35458be0814434322f392aa3(Array ce85c60d1be81ba72ca398333a2ae0c9e, int cf6dc1514b7401d32ca08240f004a859a)
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
		if (num >= 1)
		{
			Buffer.BlockCopy(c2c3a4c8237b451486288e478654cc54f, cf6dc1514b7401d32ca08240f004a859a, ce85c60d1be81ba72ca398333a2ae0c9e, 0, num);
		}
	}
}
