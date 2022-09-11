using System;

namespace Spy_PC;

internal class url_controller
{
	private string url;

	private string token_string = "&token=MlTKLWzv%2BWFRdinMi4GRt2ooIjvmjDwncqa3MtPlpJo%3D";

	public string IP_Details_URL => "http://www.geoplugin.net/json.gp";

	public url_controller()
	{
		url = user_login.URL + "index.php?user=";
	}

	public string system_url()
	{
		url = user_login.URL + "index.php?user=";
		return url;
	}

	public string windows_task_detials_insert()
	{
		url = user_login.URL + "index.php?user=";
		return url + "tracker_add_activity" + token_string;
	}

	public string shift_check_insert()
	{
		url = user_login.URL + "index.php?user=";
		return url + "tracker_add_check" + token_string;
	}

	public string login_url()
	{
		url = user_login.URL + "index.php?user=";
		return url + "tracker_login" + token_string;
	}

	public string shift_check_list()
	{
		Console.WriteLine("URL shift_check_list >> " + url + "tracker_view_check" + token_string);
		return url + "tracker_view_check" + token_string;
	}

	public string windows_task_list()
	{
		return url + "tracker_view_activity" + token_string;
	}

	public string project()
	{
		return url + "tracker_project" + token_string;
	}

	public string windows_task_list_view_image()
	{
		return url + "tracker_preview" + token_string;
	}

	public string dashboard()
	{
		return url + "tracker_dashboard" + token_string;
	}

	public string dashboard_chart1()
	{
		Console.WriteLine("URL Chart1 : " + url + "tracker_chart1" + token_string);
		return url + "tracker_chart1" + token_string;
	}

	public string dashboard_chart2()
	{
		Console.WriteLine("URL Chart2 : " + url + "tracker_chart2" + token_string);
		return url + "tracker_chart2" + token_string;
	}

	public string logs()
	{
		Console.WriteLine("Logs : " + url + "tracker_logs" + token_string);
		return url + "tracker_logs" + token_string;
	}

	public string tracker_counter()
	{
		Console.WriteLine("Logs : " + url + "tracker_counter" + token_string);
		return url + "tracker_counter" + token_string;
	}

	public string tracker_sign_up()
	{
		return url + "signup" + token_string;
	}

	public string tracker_project()
	{
		return url + "tracker_project" + token_string;
	}

	public string tracker_task()
	{
		return url + "tracker_task" + token_string;
	}

	public string mail_URL()
	{
		return "http://www.iwcnetwork.com/timenox/send_mail_new.php";
	}

	public string tracker_user()
	{
		Console.WriteLine("User Information Update : " + url + "tracker_user_profile" + token_string);
		return url + "tracker_user_profile" + token_string;
	}

	public int currentVersion()
	{
		return 2;
	}

	public string checkUpdate()
	{
		return "http://iwcnetwork.com/timenox/timenoxUpdate/checkVersion.php";
	}

	public string getApplicationName()
	{
		return "BlaqClouds Inc";
	}
}
