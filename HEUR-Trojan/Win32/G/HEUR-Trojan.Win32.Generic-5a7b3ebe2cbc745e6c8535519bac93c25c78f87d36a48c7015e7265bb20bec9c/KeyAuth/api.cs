using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Runtime.Serialization;
using System.Security.Cryptography;
using System.Security.Principal;
using System.Text;
using System.Threading;

namespace KeyAuth;

public class api
{
	public class app_data_class
	{
		public string customerPanelLink { get; set; }

		public string downloadLink { get; set; }

		public string numKeys { get; set; }

		public string numOnlineUsers { get; set; }

		public string numUsers { get; set; }

		public string version { get; set; }
	}

	[DataContract]
	private class app_data_structure
	{
		[DataMember]
		public string customerPanelLink { get; set; }

		[DataMember]
		public string downloadLink { get; set; }

		[DataMember]
		public string numKeys { get; set; }

		[DataMember]
		public string numOnlineUsers { get; set; }

		[DataMember]
		public string numUsers { get; set; }

		[DataMember]
		public string version { get; set; }
	}

	public class Data
	{
		public string expiry { get; set; }

		public string subscription { get; set; }

		public string timeleft { get; set; }
	}

	public class msg
	{
		public string author { get; set; }

		public string message { get; set; }

		public string timestamp { get; set; }
	}

	public class response_class
	{
		public string message { get; set; }

		public bool success { get; set; }
	}

	[DataContract]
	private class response_structure
	{
		[DataMember(IsRequired = false, EmitDefaultValue = false)]
		public app_data_structure appinfo { get; set; }

		[DataMember]
		public string contents { get; set; }

		[DataMember]
		public string download { get; set; }

		[DataMember(IsRequired = false, EmitDefaultValue = false)]
		public user_data_structure info { get; set; }

		[DataMember]
		public string message { get; set; }

		[DataMember]
		public List<msg> messages { get; set; }

		[DataMember]
		public string response { get; set; }

		[DataMember]
		public string sessionid { get; set; }

		[DataMember]
		public bool success { get; set; }
	}

	public class user_data_class
	{
		public string createdate { get; set; }

		public string hwid { get; set; }

		public string ip { get; set; }

		public string lastlogin { get; set; }

		public List<Data> subscriptions { get; set; }

		public string username { get; set; }
	}

	[DataContract]
	private class user_data_structure
	{
		[DataMember]
		public string createdate { get; set; }

		[DataMember]
		public string hwid { get; set; }

		[DataMember]
		public string ip { get; set; }

		[DataMember]
		public string lastlogin { get; set; }

		[DataMember]
		public List<Data> subscriptions { get; set; }

		[DataMember]
		public string username { get; set; }
	}

	public string name;

	public string ownerid;

	public string secret;

	public string version;

	private string sessionid;

	private string enckey;

	private bool initzalized;

	public app_data_class app_data = new app_data_class();

	public user_data_class user_data = new user_data_class();

	public response_class response = new response_class();

	private json_wrapper response_decoder = new json_wrapper(new response_structure());

	public static bool IsDebugRelease => false;

	public api(string name, string ownerid, string secret, string version)
	{
		if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(ownerid) || string.IsNullOrWhiteSpace(secret) || string.IsNullOrWhiteSpace(version))
		{
			error("Application not setup correctly. Please watch video link found in Program.cs");
			Environment.Exit(0);
		}
		this.name = name;
		this.ownerid = ownerid;
		this.secret = secret;
		this.version = version;
	}

	public void ban()
	{
		Checkinit();
		string text = encryption.sha256(encryption.iv_key());
		NameValueCollection nameValueCollection = new NameValueCollection();
		nameValueCollection["type"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes("ban"));
		nameValueCollection["sessionid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(sessionid));
		nameValueCollection["name"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(name));
		nameValueCollection["ownerid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(ownerid));
		nameValueCollection["init_iv"] = text;
		string message = req(nameValueCollection);
		message = encryption.decrypt(message, enckey, text);
		load_response_struct(response_decoder.string_to_generic<response_structure>(message));
	}

	public List<msg> chatget(string channelname)
	{
		Checkinit();
		string text = encryption.sha256(encryption.iv_key());
		NameValueCollection nameValueCollection = new NameValueCollection();
		nameValueCollection["type"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes("chatget"));
		nameValueCollection["channel"] = encryption.encrypt(channelname, enckey, text);
		nameValueCollection["sessionid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(sessionid));
		nameValueCollection["name"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(name));
		nameValueCollection["ownerid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(ownerid));
		nameValueCollection["init_iv"] = text;
		string message = req(nameValueCollection);
		message = encryption.decrypt(message, enckey, text);
		response_structure response_structure = response_decoder.string_to_generic<response_structure>(message);
		load_response_struct(response_structure);
		if (!response_structure.success)
		{
			return null;
		}
		return response_structure.messages;
	}

	public bool chatsend(string msg, string channelname)
	{
		Checkinit();
		string text = encryption.sha256(encryption.iv_key());
		NameValueCollection nameValueCollection = new NameValueCollection();
		nameValueCollection["type"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes("chatsend"));
		nameValueCollection["message"] = encryption.encrypt(msg, enckey, text);
		nameValueCollection["channel"] = encryption.encrypt(channelname, enckey, text);
		nameValueCollection["sessionid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(sessionid));
		nameValueCollection["name"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(name));
		nameValueCollection["ownerid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(ownerid));
		nameValueCollection["init_iv"] = text;
		string message = req(nameValueCollection);
		message = encryption.decrypt(message, enckey, text);
		response_structure response_structure = response_decoder.string_to_generic<response_structure>(message);
		load_response_struct(response_structure);
		if (response_structure.success)
		{
			return true;
		}
		return false;
	}

	public void check()
	{
		Checkinit();
		string text = encryption.sha256(encryption.iv_key());
		NameValueCollection nameValueCollection = new NameValueCollection();
		nameValueCollection["type"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes("check"));
		nameValueCollection["sessionid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(sessionid));
		nameValueCollection["name"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(name));
		nameValueCollection["ownerid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(ownerid));
		nameValueCollection["init_iv"] = text;
		string message = req(nameValueCollection);
		message = encryption.decrypt(message, enckey, text);
		load_response_struct(response_decoder.string_to_generic<response_structure>(message));
	}

	public bool checkblack()
	{
		Checkinit();
		string value = WindowsIdentity.GetCurrent().User!.Value;
		string text = encryption.sha256(encryption.iv_key());
		NameValueCollection nameValueCollection = new NameValueCollection();
		nameValueCollection["type"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes("checkblacklist"));
		nameValueCollection["hwid"] = encryption.encrypt(value, enckey, text);
		nameValueCollection["sessionid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(sessionid));
		nameValueCollection["name"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(name));
		nameValueCollection["ownerid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(ownerid));
		nameValueCollection["init_iv"] = text;
		string message = req(nameValueCollection);
		message = encryption.decrypt(message, enckey, text);
		response_structure response_structure = response_decoder.string_to_generic<response_structure>(message);
		load_response_struct(response_structure);
		if (response_structure.success)
		{
			return true;
		}
		return false;
	}

	public void Checkinit()
	{
		if (!initzalized)
		{
			if (IsDebugRelease)
			{
				error("Not initialized Check if KeyAuthApp.init() does exist");
			}
			else
			{
				error("Please initialize first");
			}
		}
	}

	public static string checksum(string filename)
	{
		using MD5 mD = MD5.Create();
		using FileStream inputStream = File.OpenRead(filename);
		return BitConverter.ToString(mD.ComputeHash(inputStream)).Replace("-", "").ToLowerInvariant();
	}

	public byte[] download(string fileid)
	{
		Checkinit();
		string text = encryption.sha256(encryption.iv_key());
		NameValueCollection nameValueCollection = new NameValueCollection();
		nameValueCollection["type"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes("file"));
		nameValueCollection["fileid"] = encryption.encrypt(fileid, enckey, text);
		nameValueCollection["sessionid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(sessionid));
		nameValueCollection["name"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(name));
		nameValueCollection["ownerid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(ownerid));
		nameValueCollection["init_iv"] = text;
		string message = req(nameValueCollection);
		message = encryption.decrypt(message, enckey, text);
		response_structure response_structure = response_decoder.string_to_generic<response_structure>(message);
		load_response_struct(response_structure);
		if (!response_structure.success)
		{
			return null;
		}
		return encryption.str_to_byte_arr(response_structure.contents);
	}

	public static void error(string message)
	{
		Process.Start(new ProcessStartInfo("cmd.exe", "/c start cmd /C \"color b && title Error && echo " + message + " && timeout /t 5\"")
		{
			CreateNoWindow = true,
			RedirectStandardOutput = true,
			RedirectStandardError = true,
			UseShellExecute = false
		});
		Environment.Exit(0);
	}

	public string expirydaysleft()
	{
		Checkinit();
		DateTime dateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Local).AddSeconds(long.Parse(user_data.subscriptions[0].expiry)).ToLocalTime();
		TimeSpan timeSpan = dateTime - DateTime.Now;
		string text = timeSpan.Days.ToString();
		return Convert.ToString(text + " Days " + timeSpan.Hours + " Hours Left");
	}

	public string getvar(string var)
	{
		Checkinit();
		string text = encryption.sha256(encryption.iv_key());
		NameValueCollection nameValueCollection = new NameValueCollection();
		nameValueCollection["type"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes("getvar"));
		nameValueCollection["var"] = encryption.encrypt(var, enckey, text);
		nameValueCollection["sessionid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(sessionid));
		nameValueCollection["name"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(name));
		nameValueCollection["ownerid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(ownerid));
		nameValueCollection["init_iv"] = text;
		string message = req(nameValueCollection);
		message = encryption.decrypt(message, enckey, text);
		response_structure response_structure = response_decoder.string_to_generic<response_structure>(message);
		load_response_struct(response_structure);
		if (!response_structure.success)
		{
			return null;
		}
		return response_structure.response;
	}

	public void init()
	{
		enckey = encryption.sha256(encryption.iv_key());
		string text = encryption.sha256(encryption.iv_key());
		NameValueCollection nameValueCollection = new NameValueCollection();
		nameValueCollection["type"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes("init"));
		nameValueCollection["ver"] = encryption.encrypt(version, secret, text);
		nameValueCollection["hash"] = checksum(Process.GetCurrentProcess().MainModule!.FileName);
		nameValueCollection["enckey"] = encryption.encrypt(enckey, secret, text);
		nameValueCollection["name"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(name));
		nameValueCollection["ownerid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(ownerid));
		nameValueCollection["init_iv"] = text;
		string text2 = req(nameValueCollection);
		if (text2 == "KeyAuth_Invalid")
		{
			error("Application not found");
			Environment.Exit(0);
		}
		text2 = encryption.decrypt(text2, secret, text);
		response_structure response_structure = response_decoder.string_to_generic<response_structure>(text2);
		load_response_struct(response_structure);
		if (!response_structure.success)
		{
			if (response_structure.message == "invalidver")
			{
				app_data.downloadLink = response_structure.download;
			}
		}
		else
		{
			load_app_data(response_structure.appinfo);
			sessionid = response_structure.sessionid;
			initzalized = true;
		}
	}

	public void license(string key)
	{
		Checkinit();
		string value = WindowsIdentity.GetCurrent().User!.Value;
		string text = encryption.sha256(encryption.iv_key());
		NameValueCollection nameValueCollection = new NameValueCollection();
		nameValueCollection["type"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes("license"));
		nameValueCollection["key"] = encryption.encrypt(key, enckey, text);
		nameValueCollection["hwid"] = encryption.encrypt(value, enckey, text);
		nameValueCollection["sessionid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(sessionid));
		nameValueCollection["name"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(name));
		nameValueCollection["ownerid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(ownerid));
		nameValueCollection["init_iv"] = text;
		string message = req(nameValueCollection);
		message = encryption.decrypt(message, enckey, text);
		response_structure response_structure = response_decoder.string_to_generic<response_structure>(message);
		load_response_struct(response_structure);
		if (response_structure.success)
		{
			load_user_data(response_structure.info);
		}
	}

	private void load_app_data(app_data_structure data)
	{
		app_data.numUsers = data.numUsers;
		app_data.numOnlineUsers = data.numOnlineUsers;
		app_data.numKeys = data.numKeys;
		app_data.version = data.version;
		app_data.customerPanelLink = data.customerPanelLink;
	}

	private void load_response_struct(response_structure data)
	{
		response.success = data.success;
		response.message = data.message;
	}

	private void load_user_data(user_data_structure data)
	{
		user_data.username = data.username;
		user_data.ip = data.ip;
		user_data.hwid = data.hwid;
		user_data.createdate = data.createdate;
		user_data.lastlogin = data.lastlogin;
		user_data.subscriptions = data.subscriptions;
	}

	public void log(string message)
	{
		Checkinit();
		string text = encryption.sha256(encryption.iv_key());
		NameValueCollection nameValueCollection = new NameValueCollection();
		nameValueCollection["type"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes("log"));
		nameValueCollection["pcuser"] = encryption.encrypt(Environment.UserName, enckey, text);
		nameValueCollection["message"] = encryption.encrypt(message, enckey, text);
		nameValueCollection["sessionid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(sessionid));
		nameValueCollection["name"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(name));
		nameValueCollection["ownerid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(ownerid));
		nameValueCollection["init_iv"] = text;
		req(nameValueCollection);
	}

	public void login(string username, string pass)
	{
		Checkinit();
		string value = WindowsIdentity.GetCurrent().User!.Value;
		string text = encryption.sha256(encryption.iv_key());
		NameValueCollection nameValueCollection = new NameValueCollection();
		nameValueCollection["type"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes("login"));
		nameValueCollection["username"] = encryption.encrypt(username, enckey, text);
		nameValueCollection["pass"] = encryption.encrypt(pass, enckey, text);
		nameValueCollection["hwid"] = encryption.encrypt(value, enckey, text);
		nameValueCollection["sessionid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(sessionid));
		nameValueCollection["name"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(name));
		nameValueCollection["ownerid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(ownerid));
		nameValueCollection["init_iv"] = text;
		string message = req(nameValueCollection);
		message = encryption.decrypt(message, enckey, text);
		response_structure response_structure = response_decoder.string_to_generic<response_structure>(message);
		load_response_struct(response_structure);
		if (response_structure.success)
		{
			load_user_data(response_structure.info);
		}
	}

	public void register(string username, string pass, string key)
	{
		Checkinit();
		string value = WindowsIdentity.GetCurrent().User!.Value;
		string text = encryption.sha256(encryption.iv_key());
		NameValueCollection nameValueCollection = new NameValueCollection();
		nameValueCollection["type"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes("register"));
		nameValueCollection["username"] = encryption.encrypt(username, enckey, text);
		nameValueCollection["pass"] = encryption.encrypt(pass, enckey, text);
		nameValueCollection["key"] = encryption.encrypt(key, enckey, text);
		nameValueCollection["hwid"] = encryption.encrypt(value, enckey, text);
		nameValueCollection["sessionid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(sessionid));
		nameValueCollection["name"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(name));
		nameValueCollection["ownerid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(ownerid));
		nameValueCollection["init_iv"] = text;
		string message = req(nameValueCollection);
		message = encryption.decrypt(message, enckey, text);
		response_structure response_structure = response_decoder.string_to_generic<response_structure>(message);
		load_response_struct(response_structure);
		if (response_structure.success)
		{
			load_user_data(response_structure.info);
		}
	}

	private static string req(NameValueCollection post_data)
	{
		try
		{
			using WebClient webClient = new WebClient();
			byte[] bytes = webClient.UploadValues("https://keyauth.win/api/1.0/", post_data);
			return Encoding.Default.GetString(bytes);
		}
		catch (WebException ex)
		{
			if (((HttpWebResponse)ex.Response).StatusCode != HttpStatusCode.TooManyRequests)
			{
				error("Connection failure. Please try again, or contact us for help.");
				Environment.Exit(0);
				return "";
			}
			Thread.Sleep(1000);
			return req(post_data);
		}
	}

	public void setvar(string var, string data)
	{
		Checkinit();
		string text = encryption.sha256(encryption.iv_key());
		NameValueCollection nameValueCollection = new NameValueCollection();
		nameValueCollection["type"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes("setvar"));
		nameValueCollection["var"] = encryption.encrypt(var, enckey, text);
		nameValueCollection["data"] = encryption.encrypt(data, enckey, text);
		nameValueCollection["sessionid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(sessionid));
		nameValueCollection["name"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(name));
		nameValueCollection["ownerid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(ownerid));
		nameValueCollection["init_iv"] = text;
		string message = req(nameValueCollection);
		message = encryption.decrypt(message, enckey, text);
		load_response_struct(response_decoder.string_to_generic<response_structure>(message));
	}

	public void upgrade(string username, string key)
	{
		Checkinit();
		_ = WindowsIdentity.GetCurrent().User!.Value;
		string text = encryption.sha256(encryption.iv_key());
		NameValueCollection nameValueCollection = new NameValueCollection();
		nameValueCollection["type"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes("upgrade"));
		nameValueCollection["username"] = encryption.encrypt(username, enckey, text);
		nameValueCollection["key"] = encryption.encrypt(key, enckey, text);
		nameValueCollection["sessionid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(sessionid));
		nameValueCollection["name"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(name));
		nameValueCollection["ownerid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(ownerid));
		nameValueCollection["init_iv"] = text;
		string message = req(nameValueCollection);
		message = encryption.decrypt(message, enckey, text);
		response_structure response_structure = response_decoder.string_to_generic<response_structure>(message);
		response_structure.success = false;
		load_response_struct(response_structure);
	}

	public string var(string varid)
	{
		Checkinit();
		_ = WindowsIdentity.GetCurrent().User!.Value;
		string text = encryption.sha256(encryption.iv_key());
		NameValueCollection nameValueCollection = new NameValueCollection();
		nameValueCollection["type"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes("var"));
		nameValueCollection["varid"] = encryption.encrypt(varid, enckey, text);
		nameValueCollection["sessionid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(sessionid));
		nameValueCollection["name"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(name));
		nameValueCollection["ownerid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(ownerid));
		nameValueCollection["init_iv"] = text;
		string message = req(nameValueCollection);
		message = encryption.decrypt(message, enckey, text);
		response_structure response_structure = response_decoder.string_to_generic<response_structure>(message);
		load_response_struct(response_structure);
		if (!response_structure.success)
		{
			return null;
		}
		return response_structure.message;
	}

	public string webhook(string webid, string param, string body = "", string conttype = "")
	{
		Checkinit();
		string text = encryption.sha256(encryption.iv_key());
		NameValueCollection nameValueCollection = new NameValueCollection();
		nameValueCollection["type"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes("webhook"));
		nameValueCollection["webid"] = encryption.encrypt(webid, enckey, text);
		nameValueCollection["params"] = encryption.encrypt(param, enckey, text);
		nameValueCollection["body"] = encryption.encrypt(body, enckey, text);
		nameValueCollection["conttype"] = encryption.encrypt(conttype, enckey, text);
		nameValueCollection["sessionid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(sessionid));
		nameValueCollection["name"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(name));
		nameValueCollection["ownerid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(ownerid));
		nameValueCollection["init_iv"] = text;
		string message = req(nameValueCollection);
		message = encryption.decrypt(message, enckey, text);
		response_structure response_structure = response_decoder.string_to_generic<response_structure>(message);
		load_response_struct(response_structure);
		if (!response_structure.success)
		{
			return null;
		}
		return response_structure.response;
	}
}
