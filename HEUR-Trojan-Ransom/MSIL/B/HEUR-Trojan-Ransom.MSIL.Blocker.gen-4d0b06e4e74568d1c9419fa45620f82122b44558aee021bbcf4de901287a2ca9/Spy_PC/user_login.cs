namespace Spy_PC;

internal class user_login
{
	private static user_login instance;

	private static string user_email;

	private static string user_first_name;

	private static string user_last_name;

	private static string user_password;

	private static string user_contact;

	private static string user_contry;

	private static string user_address;

	private string user_name = "";

	private string m_employee_id = "";

	private string employee_img = "";

	private bool employee_img_found;

	private string country_img = "";

	private bool country_img_found;

	private string m_company_id = "";

	private string m_company_name = "";

	public static string URL = "";

	private string LastID = "";

	private string Syncronize_date = "";

	private string total_logs = "";

	private string total_sc = "";

	private string auto_logout = "";

	private string IP = "";

	private string logo = "";

	private bool logo_found;

	private string Language = "English";

	private bool Max_Property;

	private bool TimeFormate24;

	private string ServerTimeZone = "";

	private string Total_Job_Seconds = "0";

	private string shift_check_id = "0";

	private string shift_check_total_seconds = "0";

	private string shift_check_out = "0";

	private string shift_project_id = "0";

	private string shift_task_id = "0";

	private bool shift_out;

	public static user_login Instance
	{
		get
		{
			if (instance == null)
			{
				instance = new user_login();
			}
			return instance;
		}
	}

	public string employee_id
	{
		get
		{
			return this.m_employee_id;
		}
		set
		{
			this.m_employee_id = value;
		}
	}

	public string company_id
	{
		get
		{
			return this.m_company_id;
		}
		set
		{
			this.m_company_id = value;
		}
	}

	public string company_name
	{
		get
		{
			return this.m_company_name;
		}
		set
		{
			this.m_company_name = value;
		}
	}

	public void setUser_ContactValue(string val)
	{
		user_contact = val;
	}

	public string getUser_ContactValue()
	{
		return user_contact;
	}

	public void setUser_ContryValue(string val)
	{
		user_contry = val;
	}

	public string getUser_ContryValue()
	{
		return user_contry;
	}

	public void setUser_AddressValue(string val)
	{
		user_address = val;
	}

	public string getUser_AddressValue()
	{
		return user_address;
	}

	public void setServerTimeZone(string val)
	{
		ServerTimeZone = val;
	}

	public string getServerTimeZone()
	{
		return ServerTimeZone;
	}

	public void setTotal_Job_Hours(string Hours)
	{
		Total_Job_Seconds = Hours;
	}

	public string getTotal_Job_Hours()
	{
		return Total_Job_Seconds;
	}

	private user_login()
	{
		user_email = "";
	}

	public void setTimeFormate24(bool val)
	{
		TimeFormate24 = val;
	}

	public bool getTimeFormate24()
	{
		return TimeFormate24;
	}

	public void setMax_Property(bool val)
	{
		Max_Property = val;
	}

	public bool getMax_Property()
	{
		return Max_Property;
	}

	public void setLanguageValue(string val)
	{
		Language = val;
	}

	public string getLanguageValue()
	{
		return Language;
	}

	public void setCountryImgValue(string val)
	{
		country_img = val;
	}

	public string getCountryImgValue()
	{
		return country_img;
	}

	public void setCountryImgFoundValue(bool val)
	{
		country_img_found = val;
	}

	public bool getCountryImgFoundValue()
	{
		return country_img_found;
	}

	public void setEmailValue(string val)
	{
		user_email = val;
	}

	public string getEmailValue()
	{
		return user_email;
	}

	public void setLogoValue(string val)
	{
		logo = val;
	}

	public string getLogoValue()
	{
		return logo;
	}

	public void setEmployeeImgValue(string val)
	{
		employee_img = val;
	}

	public string getEmployeeImgValue()
	{
		return employee_img;
	}

	public void setEmployeeImgFoundValue(bool val)
	{
		employee_img_found = val;
	}

	public bool getEmployeeImgFoundValue()
	{
		return employee_img_found;
	}

	public void setLogoFoundValue(bool val)
	{
		logo_found = val;
	}

	public bool getLogoFoundValue()
	{
		return logo_found;
	}

	public void setIPValue(string val)
	{
		IP = val;
	}

	public string getIPValue()
	{
		return IP;
	}

	public void setLastNameValue(string val)
	{
		user_last_name = val;
	}

	public string getLastNameValue()
	{
		return user_last_name;
	}

	public void setFirstNameValue(string val)
	{
		user_first_name = val;
	}

	public string getFirstNameValue()
	{
		return user_first_name;
	}

	public void setPasswordValue(string val)
	{
		user_password = val;
	}

	public string getPasswordValue()
	{
		return user_password;
	}

	public void setLastIDValue(string val)
	{
		LastID = val;
	}

	public string getLastIDValue()
	{
		return LastID;
	}

	public void setSyncronized_Date_Value(string val)
	{
		Syncronize_date = val;
	}

	public string getSyncronized_Date_Value()
	{
		return Syncronize_date;
	}

	public void setTotal_Logs_Value(string val)
	{
		total_logs = val;
	}

	public string getTotal_Logs_Value()
	{
		return total_logs;
	}

	public void setTotal_Sc_Value(string val)
	{
		total_sc = val;
	}

	public string getTotal_Sc_Value()
	{
		return total_sc;
	}

	public void setAutoLogout_Value(string val)
	{
		auto_logout = val;
	}

	public string getAutoLogout_Value()
	{
		return auto_logout;
	}

	public void setShift_out(bool val)
	{
		shift_out = val;
	}

	public bool getShift_out()
	{
		return shift_out;
	}

	public void setShift_project_id(string val)
	{
		shift_project_id = val;
	}

	public string getShift_project_id()
	{
		return shift_project_id;
	}

	public void setShift_task_id(string val)
	{
		shift_task_id = val;
	}

	public string getShift_task_id()
	{
		return shift_task_id;
	}

	public void setShiftCheckID(string val)
	{
		shift_check_id = val;
	}

	public void setShift_check_out(string val)
	{
		shift_check_out = val;
	}

	public void setShift_total_seconds(string val)
	{
		shift_check_total_seconds = val;
	}

	public string getShiftCheckID()
	{
		return shift_check_id;
	}

	public string getShift_check_out()
	{
		return shift_check_out;
	}

	public string getShift_total_seconds()
	{
		return shift_check_total_seconds;
	}
}
