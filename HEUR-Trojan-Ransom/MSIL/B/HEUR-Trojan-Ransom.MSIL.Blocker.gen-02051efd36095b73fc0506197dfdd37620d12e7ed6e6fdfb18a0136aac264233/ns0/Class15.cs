using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;

namespace ns0;

internal class Class15 : Class14
{
	private const int int_1 = 256;

	private const int int_2 = 1048576;

	private const int int_3 = 128;

	private const PaddingMode paddingMode_0 = PaddingMode.PKCS7;

	private const CipherMode cipherMode_0 = CipherMode.CFB;

	public static string string_2 = Class10.smethod_0(4360);

	public static List<string> list_0;

	private string string_3;

	private byte[] byte_0;

	static Class15()
	{
		List<string> object_ = Delegate113.smethod_0();
		Delegate4.smethod_0(object_, Class10.smethod_0(4375));
		Delegate4.smethod_0(object_, Class10.smethod_0(4384));
		Delegate4.smethod_0(object_, Class10.smethod_0(4393));
		Delegate4.smethod_0(object_, Class10.smethod_0(4402));
		Delegate4.smethod_0(object_, Class10.smethod_0(4411));
		Delegate4.smethod_0(object_, Class10.smethod_0(4420));
		Delegate4.smethod_0(object_, Class10.smethod_0(4429));
		Delegate4.smethod_0(object_, Class10.smethod_0(4438));
		Delegate4.smethod_0(object_, Class10.smethod_0(4449));
		Delegate4.smethod_0(object_, Class10.smethod_0(4460));
		Delegate4.smethod_0(object_, Class10.smethod_0(4469));
		Delegate4.smethod_0(object_, Class10.smethod_0(4478));
		Delegate4.smethod_0(object_, Class10.smethod_0(4489));
		Delegate4.smethod_0(object_, Class10.smethod_0(4500));
		Delegate4.smethod_0(object_, Class10.smethod_0(4511));
		Delegate4.smethod_0(object_, Class10.smethod_0(4520));
		Delegate4.smethod_0(object_, Class10.smethod_0(4529));
		Delegate4.smethod_0(object_, Class10.smethod_0(4540));
		Delegate4.smethod_0(object_, Class10.smethod_0(4551));
		Delegate4.smethod_0(object_, Class10.smethod_0(4560));
		Delegate4.smethod_0(object_, Class10.smethod_0(4573));
		Delegate4.smethod_0(object_, Class10.smethod_0(4582));
		Delegate4.smethod_0(object_, Class10.smethod_0(4591));
		Delegate4.smethod_0(object_, Class10.smethod_0(4600));
		Delegate4.smethod_0(object_, Class10.smethod_0(4609));
		Delegate4.smethod_0(object_, Class10.smethod_0(4618));
		Delegate4.smethod_0(object_, Class10.smethod_0(4627));
		Delegate4.smethod_0(object_, Class10.smethod_0(4636));
		Delegate4.smethod_0(object_, Class10.smethod_0(4645));
		Delegate4.smethod_0(object_, Class10.smethod_0(4654));
		Delegate4.smethod_0(object_, Class10.smethod_0(4663));
		Delegate4.smethod_0(object_, Class10.smethod_0(4672));
		Delegate4.smethod_0(object_, Class10.smethod_0(4681));
		Delegate4.smethod_0(object_, Class10.smethod_0(4688));
		Delegate4.smethod_0(object_, Class10.smethod_0(4695));
		Delegate4.smethod_0(object_, Class10.smethod_0(4706));
		Delegate4.smethod_0(object_, Class10.smethod_0(4715));
		Delegate4.smethod_0(object_, Class10.smethod_0(4724));
		Delegate4.smethod_0(object_, Class10.smethod_0(4715));
		Delegate4.smethod_0(object_, Class10.smethod_0(4733));
		Delegate4.smethod_0(object_, Class10.smethod_0(4742));
		Delegate4.smethod_0(object_, Class10.smethod_0(4751));
		Delegate4.smethod_0(object_, Class10.smethod_0(4760));
		Delegate4.smethod_0(object_, Class10.smethod_0(4769));
		Delegate4.smethod_0(object_, Class10.smethod_0(4778));
		Delegate4.smethod_0(object_, Class10.smethod_0(4787));
		Delegate4.smethod_0(object_, Class10.smethod_0(4796));
		Delegate4.smethod_0(object_, Class10.smethod_0(4805));
		Delegate4.smethod_0(object_, Class10.smethod_0(4814));
		Delegate4.smethod_0(object_, Class10.smethod_0(4823));
		Delegate4.smethod_0(object_, Class10.smethod_0(4832));
		Delegate4.smethod_0(object_, Class10.smethod_0(4841));
		Delegate4.smethod_0(object_, Class10.smethod_0(4850));
		Delegate4.smethod_0(object_, Class10.smethod_0(4859));
		Delegate4.smethod_0(object_, Class10.smethod_0(4868));
		Delegate4.smethod_0(object_, Class10.smethod_0(4877));
		Delegate4.smethod_0(object_, Class10.smethod_0(4886));
		Delegate4.smethod_0(object_, Class10.smethod_0(4895));
		Delegate4.smethod_0(object_, Class10.smethod_0(4904));
		Delegate4.smethod_0(object_, Class10.smethod_0(4913));
		Delegate4.smethod_0(object_, Class10.smethod_0(4922));
		Delegate4.smethod_0(object_, Class10.smethod_0(4931));
		Delegate4.smethod_0(object_, Class10.smethod_0(4940));
		Delegate4.smethod_0(object_, Class10.smethod_0(4949));
		Delegate4.smethod_0(object_, Class10.smethod_0(4958));
		Delegate4.smethod_0(object_, Class10.smethod_0(4967));
		Delegate4.smethod_0(object_, Class10.smethod_0(4976));
		Delegate4.smethod_0(object_, Class10.smethod_0(4985));
		Delegate4.smethod_0(object_, Class10.smethod_0(4994));
		Delegate4.smethod_0(object_, Class10.smethod_0(5003));
		Delegate4.smethod_0(object_, Class10.smethod_0(5012));
		Delegate4.smethod_0(object_, Class10.smethod_0(5021));
		Delegate4.smethod_0(object_, Class10.smethod_0(5030));
		Delegate4.smethod_0(object_, Class10.smethod_0(5039));
		Delegate4.smethod_0(object_, Class10.smethod_0(5046));
		list_0 = object_;
	}

	public void method_4(string string_4)
	{
		string_3 = string_4;
	}

	public void method_5()
	{
		Class8 @class = new Class8();
		byte_0 = @class.method_0();
	}

	public void method_6()
	{
		FileStream fileStream = Delegate161.smethod_0(Delegate209.smethod_0(string_3, string_2), (FileMode)Class9.smethod_0(700));
		RijndaelManaged object_ = Delegate229.smethod_0();
		Delegate57.smethod_0(object_, Class9.smethod_0(704));
		Delegate157.smethod_0(object_, Class9.smethod_0(708));
		Delegate193.smethod_0(object_, (PaddingMode)Class9.smethod_0(712));
		Rfc2898DeriveBytes object_2 = Delegate42.smethod_0(Delegate0.smethod_0(Delegate121.smethod_0(), string_0), byte_0, Class9.smethod_0(716));
		Delegate90.smethod_0(object_, Delegate237.smethod_0(object_2, Delegate151.smethod_0(object_) / Class9.smethod_0(720)));
		Delegate67.smethod_0(object_, Delegate237.smethod_0(object_2, Delegate198.smethod_0(object_) / Class9.smethod_0(724)));
		Delegate189.smethod_0(object_, (CipherMode)Class9.smethod_0(728));
		Delegate29.smethod_0(fileStream, byte_0, Class9.smethod_0(732), byte_0.Length);
		CryptoStream object_3 = Delegate84.smethod_0(fileStream, Delegate139.smethod_0(object_), (CryptoStreamMode)Class9.smethod_0(736));
		FileStream object_4 = Delegate161.smethod_0(string_3, (FileMode)Class9.smethod_0(740));
		byte[] array = new byte[Class9.smethod_0(744)];
		try
		{
			int num;
			while ((num = Delegate41.smethod_0(object_4, array, Class9.smethod_0(752), array.Length)) > Class9.smethod_0(756))
			{
				Delegate29.smethod_0(object_3, array, Class9.smethod_0(748), num);
			}
			Delegate190.smethod_0(object_4);
		}
		catch (Exception object_5)
		{
			Delegate221.smethod_0(Delegate209.smethod_0(Class10.smethod_0(4345), Delegate72.smethod_0(object_5)));
		}
		finally
		{
			Delegate190.smethod_0(object_3);
			Delegate190.smethod_0(fileStream);
		}
	}

	public void method_7()
	{
		FileStream fileStream = Delegate161.smethod_0(string_3, (FileMode)Class9.smethod_0(760));
		Delegate41.smethod_0(fileStream, byte_0, Class9.smethod_0(764), byte_0.Length);
		RijndaelManaged object_ = Delegate229.smethod_0();
		Delegate57.smethod_0(object_, Class9.smethod_0(768));
		Delegate157.smethod_0(object_, Class9.smethod_0(772));
		Rfc2898DeriveBytes object_2 = Delegate42.smethod_0(Delegate0.smethod_0(Delegate121.smethod_0(), string_0), byte_0, Class9.smethod_0(776));
		Delegate90.smethod_0(object_, Delegate237.smethod_0(object_2, Delegate151.smethod_0(object_) / Class9.smethod_0(780)));
		Delegate67.smethod_0(object_, Delegate237.smethod_0(object_2, Delegate198.smethod_0(object_) / Class9.smethod_0(784)));
		Delegate193.smethod_0(object_, (PaddingMode)Class9.smethod_0(788));
		Delegate189.smethod_0(object_, (CipherMode)Class9.smethod_0(792));
		CryptoStream object_3 = Delegate84.smethod_0(fileStream, Delegate186.smethod_0(object_), (CryptoStreamMode)Class9.smethod_0(796));
		FileStream object_4 = Delegate161.smethod_0(Delegate209.smethod_0(string_3, string_2), (FileMode)Class9.smethod_0(800));
		byte[] array = new byte[Class9.smethod_0(804)];
		try
		{
			int num;
			while ((num = Delegate41.smethod_0(object_3, array, Class9.smethod_0(812), array.Length)) > Class9.smethod_0(816))
			{
				Delegate29.smethod_0(object_4, array, Class9.smethod_0(808), num);
			}
			Delegate190.smethod_0(object_3);
		}
		catch (Exception object_5)
		{
			Delegate221.smethod_0(Delegate209.smethod_0(Class10.smethod_0(4345), Delegate72.smethod_0(object_5)));
		}
		finally
		{
			Delegate190.smethod_0(object_4);
			Delegate190.smethod_0(fileStream);
		}
	}
}
