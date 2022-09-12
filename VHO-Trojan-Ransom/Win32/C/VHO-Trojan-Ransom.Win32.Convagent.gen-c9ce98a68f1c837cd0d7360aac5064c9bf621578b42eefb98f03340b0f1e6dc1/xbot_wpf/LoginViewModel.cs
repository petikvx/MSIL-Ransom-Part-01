using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq.Expressions;
using System.Net.Http;
using System.Reflection;
using System.Text;
using System.Windows;
using Caliburn.Micro;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using xbot_wpf.Views;

namespace xbot_wpf;

public class LoginViewModel : OneActive<Screen>, ILoginViewModel
{
	private static readonly HttpClient httpClient_0;

	private readonly ILog ilog_0;

	private WindowState windowState_0;

	private IEventAggregator ieventAggregator_0;

	private readonly IMessageBox imessageBox_0;

	private JObject jobject_0;

	private bool bool_0;

	private bool bool_1;

	private string string_0;

	private string string_1;

	public bool IsVisible
	{
		get
		{
			return bool_0;
		}
		set
		{
			bool_0 = value;
			((PropertyChangedBase)this).NotifyOfPropertyChange<bool>((Expression<Func<bool>>)(() => IsVisible));
		}
	}

	public WindowState WindowState
	{
		get
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			return windowState_0;
		}
		set
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			windowState_0 = value;
			((PropertyChangedBase)this).NotifyOfPropertyChange<WindowState>((Expression<Func<WindowState>>)(() => WindowState));
		}
	}

	public string Login
	{
		get
		{
			return string_0;
		}
		set
		{
			string_0 = value;
			((PropertyChangedBase)this).NotifyOfPropertyChange<string>((Expression<Func<string>>)(() => Login));
		}
	}

	public string Password
	{
		get
		{
			return string_1;
		}
		set
		{
			string_1 = value;
			((PropertyChangedBase)this).NotifyOfPropertyChange<string>((Expression<Func<string>>)(() => Password));
		}
	}

	public void Open()
	{
		IsVisible = true;
	}

	public void Close()
	{
		bool_1 = true;
		((Screen)this).TryClose((bool?)null);
	}

	public LoginViewModel(IEventAggregator events, ILog logger, IMessageBox messageBox)
	{
		Class24.nhQmSIPz7n4eU();
		bool_0 = true;
		string_0 = string.Empty;
		string_1 = string.Empty;
		base._002Ector();
		ilog_0 = logger;
		imessageBox_0 = messageBox;
		if (!Execute.get_InDesignMode())
		{
			string fileVersion = FileVersionInfo.GetVersionInfo(Assembly.GetExecutingAssembly().Location).FileVersion;
			((Screen)this).set_DisplayName("XTRADES " + fileVersion);
			ieventAggregator_0 = events;
			ieventAggregator_0.Subscribe((object)this);
			method_0();
		}
	}

	private void method_0()
	{
		using StreamReader streamReader = new StreamReader("auth.json");
		string text = streamReader.ReadToEnd();
		jobject_0 = JObject.Parse(text);
		Login = ((object)jobject_0.get_Item("Username")).ToString();
		Password = ((object)jobject_0.get_Item("Password")).ToString();
	}

	protected override void OnInitialize()
	{
		((Screen)this).OnInitialize();
	}

	protected override void OnDeactivate(bool close)
	{
		if (close)
		{
			ieventAggregator_0.Unsubscribe((object)this);
		}
		base.OnDeactivate(close);
	}

	public async void DoLogin()
	{
		jobject_0.set_Item("Username", JToken.op_Implicit(Login));
		jobject_0.set_Item("Password", JToken.op_Implicit(Password));
		string contents = JsonConvert.SerializeObject((object)jobject_0);
		File.WriteAllText("auth.json", contents);
		FormUrlEncodedContent content = new FormUrlEncodedContent(new Dictionary<string, string>
		{
			{
				"login",
				"'" + Login + "'"
			},
			{
				"password",
				"'" + Password + "'"
			},
			{ "product", "xtrades" }
		});
		string text = await (await httpClient_0.PostAsync(Encoding.UTF8.GetString(Convert.FromBase64String("aHR0cDovL3hib3RhcHAucnUvYS92My9sLnBocA==")), content)).Content.ReadAsStringAsync();
		if (text.Substring(0, 4) == "true")
		{
			IWindowManager obj = IoC.Get<IWindowManager>((string)null);
			IMainViewModel mainViewModel = IoC.Get<IMainViewModel>((string)null);
			obj.ShowWindow((object)mainViewModel, (object)null, (IDictionary<string, object>)null);
			MainViewModel.sessionID = text.Substring(5, 32);
			Close();
		}
		else
		{
			imessageBox_0.Show(text);
		}
	}

	public void ForgotPassword()
	{
		Process.Start(Encoding.UTF8.GetString(Convert.FromBase64String("aHR0cDovL3hib3RhcHAucnUvZm9yZ290X3Bhc3N3b3JkLmh0bWw/bG9naW49")) + string_0);
	}

	static LoginViewModel()
	{
		Class24.nhQmSIPz7n4eU();
		httpClient_0 = new HttpClient();
	}
}
