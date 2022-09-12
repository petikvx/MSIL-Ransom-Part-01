using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq.Expressions;
using System.Media;
using System.Net;
using System.Net.Http;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.Windows;
using System.Windows.Input;
using System.Windows.Threading;
using Caliburn.Micro;
using Newtonsoft.Json.Linq;
using xbot_wpf.Messages;
using xbot_wpf.Models;
using xbot_wpf.Responses;
using xbot_wpf.Services;
using xbot_wpf.Views;

namespace xbot_wpf;

public class MainViewModel : OneActive<Screen>, IHandle<FinishedAnalytics>, IHandle<FinishedAnalyticsDota2>, IHandle<SyncBuyOrdersFinished>, IHandle<SyncSellOrdersFinished>, IHandle<SellSumCsgo>, IHandle<SellSumDota2>, IHandle<OrdersSumCsgo>, IHandle<OrdersSumDota2>, IHandle<SumAll>, IHandle<GetSettigsForMain>, IHandle, IMainViewModel
{
	private static readonly HttpClient httpClient_0;

	private readonly ILog ilog_0;

	private readonly IMessageBox imessageBox_0;

	public static string sessionID;

	public const string DOMAIN = "aHR0cDovL3hib3RhcHAucnUv";

	public const string VERSION = "YS92ZXJzaW9uLnBocA==";

	public const string DOWNLOADS = "ZG93bmxvYWRzL2Rvd25sb2FkLnBocA==";

	public const string L = "YS92My9sLnBocA==";

	public const string PP = "YS92My9wcC5waHA=";

	public const string D = "YS92My9kLnBocA==";

	public const string DATE = "YS92My9kYXRlLnBocA==";

	public const string TWO = "YS92My8yLnBocA==";

	public const string FORGOT = "Zm9yZ290X3Bhc3N3b3JkLmh0bWw/bG9naW49";

	private readonly IApiMarketCsgoCom iapiMarketCsgoCom_0;

	private readonly GInterface2 ginterface2_0;

	public SettingsViewModel SettingsViewModel;

	public SteamTraderViewModel SteamTraderViewModel;

	private bool bool_0;

	private bool bool_1;

	private bool bool_2;

	private bool bool_3;

	private bool bool_4;

	private WindowState windowState_0;

	private Setting setting_0;

	private SettingDota2 settingDota2_0;

	private DispatcherTimer dispatcherTimer_0;

	private IEventAggregator ieventAggregator_0;

	private string string_0;

	private string string_1;

	private string string_2;

	private string string_3;

	private float float_0;

	private float float_1;

	private string string_4;

	private bool bool_5;

	private bool bool_6;

	private bool bool_7;

	public bool IsBadKey
	{
		get
		{
			return bool_5;
		}
		set
		{
			bool_5 = value;
			((PropertyChangedBase)this).NotifyOfPropertyChange<bool>((Expression<Func<bool>>)(() => IsBadKey));
		}
	}

	public bool IsVisible
	{
		get
		{
			return bool_6;
		}
		set
		{
			bool_6 = value;
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

	public bool OrdersIsEnable
	{
		get
		{
			return bool_0;
		}
		set
		{
			bool_0 = value;
			((PropertyChangedBase)this).NotifyOfPropertyChange<bool>((Expression<Func<bool>>)(() => OrdersIsEnable));
		}
	}

	public bool DbIsEnable
	{
		get
		{
			return bool_2;
		}
		set
		{
			bool_2 = value;
			((PropertyChangedBase)this).NotifyOfPropertyChange<bool>((Expression<Func<bool>>)(() => DbIsEnable));
		}
	}

	public bool SettingsIsEnable
	{
		get
		{
			return bool_3;
		}
		set
		{
			bool_3 = value;
			((PropertyChangedBase)this).NotifyOfPropertyChange<bool>((Expression<Func<bool>>)(() => SettingsIsEnable));
		}
	}

	public bool SteamTraderIsEnable
	{
		get
		{
			return bool_4;
		}
		set
		{
			bool_4 = value;
			((PropertyChangedBase)this).NotifyOfPropertyChange<bool>((Expression<Func<bool>>)(() => SteamTraderIsEnable));
		}
	}

	public bool SellIsEnable
	{
		get
		{
			return bool_1;
		}
		set
		{
			bool_1 = value;
			((PropertyChangedBase)this).NotifyOfPropertyChange<bool>((Expression<Func<bool>>)(() => SellIsEnable));
		}
	}

	public string SearchText
	{
		get
		{
			return string_4;
		}
		set
		{
			if (string_4 != value)
			{
				string_4 = value;
				((PropertyChangedBase)this).NotifyOfPropertyChange<string>((Expression<Func<string>>)(() => SearchText));
				if (string.IsNullOrWhiteSpace(string_4))
				{
					Search();
				}
			}
		}
	}

	public string CountBuyOrders
	{
		get
		{
			return "Всего ордеров: " + string_0;
		}
		set
		{
			string_0 = value;
			((PropertyChangedBase)this).NotifyOfPropertyChange<string>((Expression<Func<string>>)(() => CountBuyOrders));
		}
	}

	public string SumSellOrders
	{
		get
		{
			return "На продаже: " + string_1;
		}
		set
		{
			string_1 = value;
			((PropertyChangedBase)this).NotifyOfPropertyChange<string>((Expression<Func<string>>)(() => SumSellOrders));
		}
	}

	public string License
	{
		get
		{
			return "Срок лицензии: " + string_2;
		}
		set
		{
			string_2 = value;
			((PropertyChangedBase)this).NotifyOfPropertyChange<string>((Expression<Func<string>>)(() => License));
		}
	}

	public string SumAll
	{
		get
		{
			return "Общий баланс: " + string_3;
		}
		set
		{
			string_3 = value;
			((PropertyChangedBase)this).NotifyOfPropertyChange<string>((Expression<Func<string>>)(() => SumAll));
		}
	}

	public void Window_StateChanged(object sender, EventArgs e)
	{
	}

	public void OnClosing(CancelEventArgs e)
	{
		if (!bool_7)
		{
			e.Cancel = true;
			IsVisible = false;
		}
	}

	public void Open()
	{
		IsVisible = true;
	}

	public void Close()
	{
		bool_7 = true;
		KillSteamBot();
		((Screen)this).TryClose((bool?)null);
	}

	public void SearchTextKeyDown(ActionExecutionContext context)
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Invalid comparison between Unknown and I4
		object eventArgs = context.EventArgs;
		KeyEventArgs val = (KeyEventArgs)((eventArgs is KeyEventArgs) ? eventArgs : null);
		if (val != null && (int)val.get_Key() == 6)
		{
			Search();
		}
	}

	public void Search()
	{
		EventAggregatorExtensions.PublishOnUIThread(ieventAggregator_0, (object)new TextFilterChanged
		{
			Text = string_4
		});
	}

	public MainViewModel(IEventAggregator events, ILog logger, IMessageBox messageBox, IApiMarketCsgoCom apiMarketCsgoCom, GInterface2 apiMarketDota2Net)
	{
		//IL_0253: Unknown result type (might be due to invalid IL or missing references)
		//IL_0398: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a2: Expected O, but got Unknown
		Class24.nhQmSIPz7n4eU();
		bool_0 = true;
		bool_1 = true;
		bool_3 = true;
		bool_4 = true;
		setting_0 = new Setting();
		settingDota2_0 = new SettingDota2();
		string_0 = "0";
		string_1 = "0";
		string_2 = " ... ";
		string_3 = "0";
		bool_6 = true;
		base._002Ector();
		ilog_0 = logger;
		imessageBox_0 = messageBox;
		iapiMarketCsgoCom_0 = apiMarketCsgoCom;
		ginterface2_0 = apiMarketDota2Net;
		if (Execute.get_InDesignMode())
		{
			return;
		}
		string fileVersion = FileVersionInfo.GetVersionInfo(Assembly.GetExecutingAssembly().Location).FileVersion;
		((Screen)this).set_DisplayName("XTRADES " + fileVersion);
		ieventAggregator_0 = events;
		SettingsViewModel = IoC.Get<GInterface0>((string)null) as SettingsViewModel;
		SteamTraderViewModel = IoC.Get<ISteamTraderViewModel>((string)null) as SteamTraderViewModel;
		ieventAggregator_0.Subscribe((object)this);
		using (StreamReader streamReader = new StreamReader("settings.json"))
		{
			JObject val = JObject.Parse(streamReader.ReadToEnd());
			setting_0.ApiKey = ((object)val.get_Item("ApiKey")).ToString();
			settingDota2_0.ApiKey = ((object)val.get_Item("ApiKey")).ToString();
		}
		using (StreamReader streamReader2 = new StreamReader("auth.json"))
		{
			JObject val2 = JObject.Parse(streamReader2.ReadToEnd());
			setting_0.LoginXbot = ((object)val2.get_Item("Username")).ToString();
			setting_0.PasswordXbot = ((object)val2.get_Item("Password")).ToString();
		}
		iapiMarketCsgoCom_0.setting = setting_0;
		ginterface2_0.setting = settingDota2_0;
		((ConductorBase<Screen>)(object)this).ActivateItem((Screen)(object)SteamTraderViewModel);
		((ConductorBase<Screen>)(object)this).ActivateItem((Screen)(object)SettingsViewModel);
		if (!string.IsNullOrEmpty(setting_0.ApiKey))
		{
			try
			{
				WebRequest webRequest = WebRequest.Create("https://market.csgo.com/api/PingPong/direct/?key=" + setting_0.ApiKey);
				webRequest.Credentials = CredentialCache.DefaultCredentials;
				webRequest.Timeout = 1200;
				using WebResponse webResponse = webRequest.GetResponse();
				using StreamReader streamReader3 = new StreamReader(webResponse.GetResponseStream());
				string text = streamReader3.ReadToEnd();
				streamReader3.Close();
				webResponse.Close();
				try
				{
					if (new JavaScriptSerializer().Deserialize<Dictionary<string, string>>(text)["error"] == "Bad KEY")
					{
						SumAll = "Проверьте API-ключ";
						SumSellOrders = "Проверьте API-ключ";
						CountBuyOrders = "Проверьте API-ключ";
						IsBadKey = true;
					}
					else
					{
						IsBadKey = false;
					}
				}
				catch (KeyNotFoundException)
				{
					IsBadKey = false;
				}
				catch (ArgumentException)
				{
					SumAll = "Сайт недоступен";
					SumSellOrders = "Сайт недоступен";
					CountBuyOrders = "Сайт недоступен";
					IsBadKey = true;
				}
			}
			catch (ApplicationException ex3)
			{
				if (setting_0.LoggerFlag)
				{
					logger.Warn("Ping-Pong сайта", Array.Empty<object>());
					logger.Warn(ex3.Message, Array.Empty<object>());
				}
			}
			catch (WebException ex4)
			{
				if (setting_0.LoggerFlag)
				{
					logger.Warn("Ping-Pong сайта", Array.Empty<object>());
					logger.Warn(ex4.Message, Array.Empty<object>());
				}
			}
			catch (HttpRequestException ex5)
			{
				if (setting_0.LoggerFlag)
				{
					logger.Warn("Ping-Pong сайта", Array.Empty<object>());
					logger.Warn(ex5.Message, Array.Empty<object>());
				}
			}
		}
		dispatcherTimer_0 = new DispatcherTimer();
		dispatcherTimer_0.add_Tick((EventHandler)dispatcherTimer_0_Tick);
		dispatcherTimer_0.set_Interval(new TimeSpan(0, 0, 30));
		dispatcherTimer_0.Start();
	}

	private async void dispatcherTimer_0_Tick(object sender, EventArgs e)
	{
		try
		{
			string key = method_3(16);
			FormUrlEncodedContent content = new FormUrlEncodedContent(new Dictionary<string, string>
			{
				{
					"login",
					"'" + setting_0.LoginXbot + "'"
				},
				{
					"password",
					"'" + setting_0.PasswordXbot + "'"
				},
				{ "product", "xtrades" },
				{
					"session_id",
					"'" + sessionID + "'"
				},
				{ "key", key }
			});
			HttpResponseMessage responseXbot = await httpClient_0.PostAsync(Encoding.UTF8.GetString(Convert.FromBase64String("aHR0cDovL3hib3RhcHAucnUvYS92My9wcC5waHA=")), content);
			string text = await responseXbot.Content.ReadAsStringAsync();
			HttpStatusCode statusCode = responseXbot.StatusCode;
			if (string.Compare(text, method_4(key), ignoreCase: true) != 0 && statusCode == HttpStatusCode.OK)
			{
				if (setting_0.LoggerFlag)
				{
					ilog_0.Info("status = " + statusCode, Array.Empty<object>());
					ilog_0.Info("responseString = " + text, Array.Empty<object>());
				}
				Close();
			}
			if (statusCode == HttpStatusCode.ProxyAuthenticationRequired)
			{
				imessageBox_0.Show("Прокси требует проверки подлинности");
			}
			if (statusCode != HttpStatusCode.OK)
			{
				ilog_0.Info("HttpStatusCode.notOK", Array.Empty<object>());
				ilog_0.Info("status = " + statusCode, Array.Empty<object>());
				ilog_0.Info("responseString = " + text, Array.Empty<object>());
			}
		}
		catch (HttpRequestException ex)
		{
			if (setting_0.LoggerFlag)
			{
				ilog_0.Warn(ex.Message, Array.Empty<object>());
			}
			ilog_0.Warn("Скорее всего проблема с интернетом.", Array.Empty<object>());
		}
		catch (WebException ex2)
		{
			if (setting_0.LoggerFlag)
			{
				ilog_0.Warn(ex2.Message, Array.Empty<object>());
			}
			ilog_0.Warn("Скорее всего проблема с интернетом.", Array.Empty<object>());
		}
		if (!string.IsNullOrEmpty(setting_0.ApiKey))
		{
			try
			{
				WebRequest webRequest = WebRequest.Create("https://market.csgo.com/api/PingPong/direct/?key=" + setting_0.ApiKey);
				webRequest.Credentials = CredentialCache.DefaultCredentials;
				webRequest.Timeout = 1200;
				using WebResponse response = webRequest.GetResponse();
				Stream responseStream = response.GetResponseStream();
				using StreamReader reader = new StreamReader(responseStream);
				string text2 = reader.ReadToEnd();
				reader.Close();
				response.Close();
				try
				{
					if (new JavaScriptSerializer().Deserialize<Dictionary<string, string>>(text2)["error"] == "Bad KEY")
					{
						SumAll = "Проверьте API-ключ";
						SumSellOrders = "Проверьте API-ключ";
						CountBuyOrders = "Проверьте API-ключ";
						IsBadKey = true;
						SystemSounds.get_Beep().Play();
					}
					else
					{
						IsBadKey = false;
						await method_1();
						await method_2();
						await method_0();
					}
				}
				catch (KeyNotFoundException)
				{
					IsBadKey = false;
					try
					{
						await method_1();
						await method_2();
						await method_0();
					}
					catch (Exception ex3)
					{
						ilog_0.Warn("Main Ping KeyNotFound", Array.Empty<object>());
						ilog_0.Warn(ex3.ToString(), Array.Empty<object>());
					}
				}
				catch (ArgumentException)
				{
					SumAll = "Сайт недоступен";
					SumSellOrders = "Сайт недоступен";
					CountBuyOrders = "Сайт недоступен";
					IsBadKey = true;
				}
				catch (Exception ex6)
				{
					ilog_0.Warn("Main Ping", Array.Empty<object>());
					ilog_0.Warn(ex6.ToString(), Array.Empty<object>());
				}
			}
			catch (ApplicationException ex7)
			{
				if (setting_0.LoggerFlag)
				{
					ilog_0.Warn("Ping-Pong сайта", Array.Empty<object>());
					ilog_0.Warn(ex7.Message, Array.Empty<object>());
				}
			}
			catch (WebException ex8)
			{
				if (setting_0.LoggerFlag)
				{
					ilog_0.Warn("Ping-Pong сайта", Array.Empty<object>());
					ilog_0.Warn(ex8.Message, Array.Empty<object>());
				}
			}
			catch (HttpRequestException ex9)
			{
				if (setting_0.LoggerFlag)
				{
					ilog_0.Warn("Ping-Pong сайта", Array.Empty<object>());
					ilog_0.Warn(ex9.Message, Array.Empty<object>());
				}
			}
		}
		if (SteamTraderViewModel.isTradeStartCSGO)
		{
			try
			{
				List<TradesResponse> tradesResponce2 = await iapiMarketCsgoCom_0.Trades();
				bool flag = false;
				for (int i = 0; i < tradesResponce2.Count; i++)
				{
					if (tradesResponce2[i].ui_status == 2L)
					{
						ItemRequestInResponse itemRequestInResponse = await iapiMarketCsgoCom_0.ItemRequestIn();
						if (itemRequestInResponse.success)
						{
							EventAggregatorExtensions.PublishOnUIThread(ieventAggregator_0, (object)new SetLogCsgo
							{
								Text = " Запросили передачу вещей CSGO...\n",
								Date = DateTime.UtcNow.ToLocalTime().ToString("H:mm:ss"),
								TradeId = 0L,
								requestId = itemRequestInResponse.requestId,
								request = itemRequestInResponse.request
							});
						}
						else
						{
							EventAggregatorExtensions.PublishOnUIThread(ieventAggregator_0, (object)new SetLogCsgo
							{
								Text = " Не удалось загрузить ваш инвентарь. Обновляем его...\n",
								Date = DateTime.UtcNow.ToLocalTime().ToString("H:mm:ss"),
								TradeId = 0L,
								requestId = null,
								request = null
							});
							await iapiMarketCsgoCom_0.UpdateInventory();
						}
						flag = true;
						break;
					}
				}
				for (int j = 0; j < tradesResponce2.Count; j++)
				{
					if (tradesResponce2[j].ui_status == 4L)
					{
						ItemRequestOutResponse itemRequestOutResponse = await iapiMarketCsgoCom_0.ItemRequestOut(Convert.ToInt64(tradesResponce2[j].ui_bid));
						if (itemRequestOutResponse.success)
						{
							EventAggregatorExtensions.PublishOnUIThread(ieventAggregator_0, (object)new SetLogCsgo
							{
								Text = " Запросили приём вещей CSGO...\n",
								Date = DateTime.UtcNow.ToLocalTime().ToString("H:mm:ss"),
								TradeId = itemRequestOutResponse.trade,
								requestId = null,
								request = null
							});
						}
						else
						{
							EventAggregatorExtensions.PublishOnUIThread(ieventAggregator_0, (object)new SetLogCsgo
							{
								Text = " Не удалось загрузить ваш инвентарь. Обновляем его...\n",
								Date = DateTime.UtcNow.ToLocalTime().ToString("H:mm:ss"),
								TradeId = 0L,
								requestId = null,
								request = null
							});
							await iapiMarketCsgoCom_0.UpdateInventory();
						}
						flag = true;
						break;
					}
				}
				if (!flag)
				{
					EventAggregatorExtensions.PublishOnUIThread(ieventAggregator_0, (object)new SetLogCsgo
					{
						Text = " Нет вещей для приёма/передачи...\n",
						Date = DateTime.UtcNow.ToLocalTime().ToString("H:mm:ss"),
						TradeId = 0L,
						requestId = null,
						request = null
					});
				}
			}
			catch (ApplicationException ex10)
			{
				if (setting_0.LoggerFlag)
				{
					ilog_0.Warn("Таймер приёма/перачи CSGO", Array.Empty<object>());
					ilog_0.Warn(ex10.Message, Array.Empty<object>());
				}
			}
			catch (NullReferenceException ex11)
			{
				EventAggregatorExtensions.PublishOnUIThread(ieventAggregator_0, (object)new SetLogCsgo
				{
					Text = " Нет вещей для приёма/передачи...\n",
					Date = DateTime.UtcNow.ToLocalTime().ToString("H:mm:ss"),
					TradeId = 0L,
					requestId = null,
					request = null
				});
				if (setting_0.LoggerFlag)
				{
					ilog_0.Warn("Таймер приёма/перачи CSGO", Array.Empty<object>());
					ilog_0.Warn(ex11.Message, Array.Empty<object>());
				}
			}
		}
		if (!SteamTraderViewModel.isTradeStartDOTA2)
		{
			return;
		}
		try
		{
			List<TradesResponse> tradesResponce2 = await ginterface2_0.Trades();
			bool flag2 = false;
			for (int k = 0; k < tradesResponce2.Count; k++)
			{
				if (tradesResponce2[k].ui_status == 2L)
				{
					ItemRequestOutResponse itemRequestOutResponse2 = await ginterface2_0.ItemRequest("in", 1L);
					if (itemRequestOutResponse2.success)
					{
						EventAggregatorExtensions.PublishOnUIThread(ieventAggregator_0, (object)new SetLogDota2
						{
							Text = " Запросили передачу вещей DOTA2...\n",
							Date = DateTime.UtcNow.ToLocalTime().ToString("H:mm:ss"),
							TradeId = itemRequestOutResponse2.trade
						});
					}
					else
					{
						EventAggregatorExtensions.PublishOnUIThread(ieventAggregator_0, (object)new SetLogDota2
						{
							Text = " Не удалось загрузить ваш инвентарь. Обновляем его...\n",
							Date = DateTime.UtcNow.ToLocalTime().ToString("H:mm:ss"),
							TradeId = 0L
						});
						await ginterface2_0.UpdateInventory();
					}
					flag2 = true;
					break;
				}
			}
			for (int l = 0; l < tradesResponce2.Count; l++)
			{
				if (tradesResponce2[l].ui_status == 4L)
				{
					ItemRequestOutResponse itemRequestOutResponse3 = await ginterface2_0.ItemRequest("out", Convert.ToInt64(tradesResponce2[l].ui_bid));
					if (itemRequestOutResponse3.success)
					{
						EventAggregatorExtensions.PublishOnUIThread(ieventAggregator_0, (object)new SetLogDota2
						{
							Text = " Запросили приём вещей DOTA2...\n",
							Date = DateTime.UtcNow.ToLocalTime().ToString("H:mm:ss"),
							TradeId = itemRequestOutResponse3.trade
						});
					}
					else
					{
						EventAggregatorExtensions.PublishOnUIThread(ieventAggregator_0, (object)new SetLogDota2
						{
							Text = " Не удалось загрузить ваш инвентарь. Обновляем его...\n",
							Date = DateTime.UtcNow.ToLocalTime().ToString("H:mm:ss"),
							TradeId = 0L
						});
						await ginterface2_0.UpdateInventory();
					}
					flag2 = true;
					break;
				}
			}
			if (!flag2)
			{
				EventAggregatorExtensions.PublishOnUIThread(ieventAggregator_0, (object)new SetLogDota2
				{
					Text = " Нет вещей для приёма/передачи...\n",
					Date = DateTime.UtcNow.ToLocalTime().ToString("H:mm:ss"),
					TradeId = 0L
				});
			}
		}
		catch (ApplicationException ex12)
		{
			if (setting_0.LoggerFlag)
			{
				ilog_0.Warn("Таймер приёма/перачи Dota2", Array.Empty<object>());
				ilog_0.Warn(ex12.Message, Array.Empty<object>());
			}
		}
		catch (NullReferenceException ex13)
		{
			EventAggregatorExtensions.PublishOnUIThread(ieventAggregator_0, (object)new SetLogDota2
			{
				Text = " Нет вещей для приёма/передачи...\n",
				Date = DateTime.UtcNow.ToLocalTime().ToString("H:mm:ss"),
				TradeId = 0L
			});
			if (setting_0.LoggerFlag)
			{
				ilog_0.Warn("Таймер приёма/перачи Dota2", Array.Empty<object>());
				ilog_0.Warn(ex13.Message, Array.Empty<object>());
			}
		}
	}

	public void Settings()
	{
		OrdersIsEnable = true;
		SellIsEnable = true;
		DbIsEnable = true;
		SettingsIsEnable = false;
		SteamTraderIsEnable = true;
		((ConductorBase<Screen>)(object)this).ActivateItem((Screen)(object)SettingsViewModel);
	}

	public void SteamTrader()
	{
		OrdersIsEnable = true;
		SellIsEnable = true;
		DbIsEnable = true;
		SettingsIsEnable = true;
		SteamTraderIsEnable = false;
		((ConductorBase<Screen>)(object)this).ActivateItem((Screen)(object)SteamTraderViewModel);
	}

	protected override async void OnInitialize()
	{
		method_6();
		await Task.Delay(2000);
		await method_0();
	}

	protected override void OnDeactivate(bool close)
	{
		if (close)
		{
			ieventAggregator_0.Unsubscribe((object)this);
			if (dispatcherTimer_0 != null)
			{
				dispatcherTimer_0.Stop();
				dispatcherTimer_0 = null;
			}
		}
		base.OnDeactivate(close);
	}

	public async void Handle(FinishedAnalytics message)
	{
	}

	public async void Handle(FinishedAnalyticsDota2 message)
	{
	}

	private async Task method_0()
	{
		FormUrlEncodedContent content = new FormUrlEncodedContent(new Dictionary<string, string>
		{
			{
				"login",
				"'" + setting_0.LoginXbot + "'"
			},
			{
				"password",
				"'" + setting_0.PasswordXbot + "'"
			},
			{ "product", "xtrades" }
		});
		License = await (await httpClient_0.PostAsync(Encoding.UTF8.GetString(Convert.FromBase64String("aHR0cDovL3hib3RhcHAucnUvYS92My9kYXRlLnBocA==")), content)).Content.ReadAsStringAsync();
		string key = method_3(16);
		content = new FormUrlEncodedContent(new Dictionary<string, string>
		{
			{
				"login",
				"'" + setting_0.LoginXbot + "'"
			},
			{
				"password",
				"'" + setting_0.PasswordXbot + "'"
			},
			{ "product", "xtrades" },
			{
				"session_id",
				"'" + sessionID + "'"
			},
			{ "key", key }
		});
		HttpResponseMessage responseXbot = await httpClient_0.PostAsync(Encoding.UTF8.GetString(Convert.FromBase64String("aHR0cDovL3hib3RhcHAucnUvYS92My8yLnBocA==")), content);
		string text = await responseXbot.Content.ReadAsStringAsync();
		HttpStatusCode statusCode = responseXbot.StatusCode;
		if (string.Compare(text, method_4(key), ignoreCase: true) != 0 && statusCode == HttpStatusCode.OK)
		{
			if (setting_0.LoggerFlag)
			{
				ilog_0.Info("status = " + statusCode, Array.Empty<object>());
				ilog_0.Info("responseString = " + text, Array.Empty<object>());
			}
			Close();
		}
	}

	public async void Handle(SyncBuyOrdersFinished message)
	{
		await method_1();
	}

	private async Task method_1()
	{
	}

	public async void Handle(SyncSellOrdersFinished message)
	{
		await method_2();
	}

	private async Task method_2()
	{
	}

	public async void Handle(SellSumCsgo message)
	{
	}

	public async void Handle(SellSumDota2 message)
	{
	}

	public async void Handle(OrdersSumCsgo message)
	{
	}

	public async void Handle(OrdersSumDota2 message)
	{
	}

	public async void Handle(SumAll message)
	{
		try
		{
			float sum = float_0 + float_1;
			float num = (await iapiMarketCsgoCom_0.GetMoney()).money / 100L;
			SumAll = (sum + num).ToString(CultureInfo.InvariantCulture) + " руб.";
		}
		catch (ApplicationException ex)
		{
			if (setting_0.LoggerFlag)
			{
				ilog_0.Warn("Баланс с сайта", Array.Empty<object>());
				ilog_0.Warn(ex.Message, Array.Empty<object>());
			}
		}
		catch (NullReferenceException ex2)
		{
			if (setting_0.LoggerFlag)
			{
				ilog_0.Warn("Баланс с сайта", Array.Empty<object>());
				ilog_0.Warn(ex2.Message, Array.Empty<object>());
			}
		}
	}

	public void Handle(GetSettigsForMain message)
	{
		setting_0 = message.setting;
		settingDota2_0 = message.settingDota2;
		iapiMarketCsgoCom_0.setting = setting_0;
		ginterface2_0.setting = settingDota2_0;
	}

	public void KillSteamBot()
	{
		FormUrlEncodedContent content = new FormUrlEncodedContent(new Dictionary<string, string>
		{
			{
				"login",
				"'" + setting_0.LoginXbot + "'"
			},
			{
				"password",
				"'" + setting_0.PasswordXbot + "'"
			},
			{ "product", "xtrades" },
			{
				"session_id",
				"'" + sessionID + "'"
			}
		});
		httpClient_0.PostAsync(Encoding.UTF8.GetString(Convert.FromBase64String("aHR0cDovL3hib3RhcHAucnUvYS92My9kLnBocA==")), content);
		Thread.Sleep(2000);
	}

	private string method_3(int int_0)
	{
		string text = "";
		Random random = new Random();
		while (text.Length < int_0)
		{
			char c = (char)random.Next(33, 125);
			if (char.IsLetterOrDigit(c))
			{
				text += c;
			}
		}
		return text;
	}

	private string method_4(string string_5)
	{
		string text = "";
		for (int i = 0; i < string_5.Length; i++)
		{
			int num = string_5[i];
			num++;
			if (i % 2 == 0 && i != 0)
			{
				num += 2;
			}
			if (i % 3 == 0 && i != 0)
			{
				num -= 3;
			}
			if (i % 4 == 0 && i != 0)
			{
				num--;
			}
			if (i % 5 == 0 && i != 0)
			{
				num++;
			}
			if (i % 7 == 0 && i != 0)
			{
				num -= 2;
			}
			text += Convert.ToChar(num);
		}
		return method_5(text);
	}

	private string method_5(string string_5)
	{
		using MD5 mD = MD5.Create();
		byte[] bytes = Encoding.ASCII.GetBytes(string_5);
		byte[] array = mD.ComputeHash(bytes);
		StringBuilder stringBuilder = new StringBuilder();
		for (int i = 0; i < array.Length; i++)
		{
			stringBuilder.Append(array[i].ToString("X2"));
		}
		return stringBuilder.ToString();
	}

	static MainViewModel()
	{
		Class24.nhQmSIPz7n4eU();
		httpClient_0 = new HttpClient();
	}

	[CompilerGenerated]
	[DebuggerHidden]
	private void method_6()
	{
		((Screen)this).OnInitialize();
	}
}
