namespace IntelliLock.Licensing;

[Attribute1(CBPJIFOEJODEDAIKFEHLINCOJEILAOPJLPJM = true, MILJMOALDHJBDENJEIFBOPJBAHHFENPIBGJJ = true, GPLINEOBJKEEECKFEIKDKBKILCBHDFGDIEPC = true)]
internal class Class28
{
	internal static string string_0;

	public static bool smethod_0()
	{
		Class3.ShowMessage("Method \"DeactivateLicenseViaLicenseServer()\" blocked. DEMO MODE!");
		return false;
	}

	public static bool smethod_1()
	{
		Class3.ShowMessage("Method \"ReactivateLicenseViaLicenseServer()\" blocked. DEMO MODE!");
		return false;
	}

	public static string smethod_2()
	{
		lock (Class3.object_0)
		{
			string_0 = "";
			new Class3().method_12(null, typeof(Class28), null, bool_16: true, bool_17: false, bool_18: true, bool_19: false, "", "", null, bool_20: false, bool_21: false, bool_22: false);
			Class27.smethod_4().method_5(LicenseStatus.Deactivated);
			Class27.smethod_4().method_7(LicenseStatus.Deactivated);
			Class27.smethod_4().method_9(LicenseStatus.Deactivated);
			return string_0;
		}
	}

	public static string smethod_3(bool bool_0, bool bool_1, bool bool_2, bool bool_3, bool bool_4, bool bool_5)
	{
		lock (Class3.object_0)
		{
			string_0 = "";
			new Class3().method_12(null, typeof(Class28), null, bool_16: true, bool_17: false, bool_18: true, bool_19: false, Class3.smethod_27(bool_0, bool_1, bool_2, bool_3, bool_4, bool_5), "", null, bool_20: false, bool_21: false, bool_22: false);
			Class27.smethod_4().method_5(LicenseStatus.Deactivated);
			Class27.smethod_4().method_7(LicenseStatus.Deactivated);
			Class27.smethod_4().method_9(LicenseStatus.Deactivated);
			return string_0;
		}
	}

	public static bool smethod_4(string string_1)
	{
		lock (Class3.object_0)
		{
			if (new Class3().method_12(null, typeof(Class28), null, bool_16: true, bool_17: false, bool_18: false, bool_19: true, string_1, "", null, bool_20: false, bool_21: false, bool_22: false) != null)
			{
				Class27.smethod_4().method_5(LicenseStatus.Reactivated);
				Class27.smethod_4().method_7(LicenseStatus.Reactivated);
				Class27.smethod_4().method_9(LicenseStatus.Reactivated);
				return true;
			}
			return false;
		}
	}

	static Class28()
	{
		string_0 = "";
	}
}
