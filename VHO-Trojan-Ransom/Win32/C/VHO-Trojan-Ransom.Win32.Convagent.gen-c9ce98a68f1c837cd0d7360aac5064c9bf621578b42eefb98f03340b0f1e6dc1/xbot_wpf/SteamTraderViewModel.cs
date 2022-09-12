using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using Caliburn.Micro;
using xbot.Trader.TradeOffers;
using xbot_wpf.Messages;
using xbot_wpf.Models;
using xbot_wpf.Services;
using xbot_wpf.Views;

namespace xbot_wpf;

public class SteamTraderViewModel : Screen, IHandle<SetLogCsgo>, IHandle<SetLogDota2>, IHandle<GetSettigsForSteamTrader>, IHandle, ISteamTraderViewModel
{
	private readonly IApiMarketCsgoCom iapiMarketCsgoCom_0;

	private readonly GInterface2 ginterface2_0;

	private readonly IMessageBox imessageBox_0;

	private readonly ILog ilog_0;

	private readonly IEventAggregator ieventAggregator_0;

	private Setting setting_0;

	private SettingDota2 settingDota2_0;

	private bool bool_0;

	private bool bool_1;

	public static bool isTradeStartCSGO;

	private bool bool_2;

	public static bool isTradeStartDOTA2;

	private bool bool_3;

	private string string_0;

	private string string_1;

	public List<int> arrayLogCSGO;

	public List<int> arrayLogDOTA2;

	private Class17 class17_0;

	private bool bool_4;

	public bool IsStarting
	{
		get
		{
			return bool_0;
		}
		set
		{
			bool_0 = value;
			((PropertyChangedBase)this).NotifyOfPropertyChange<bool>((Expression<Func<bool>>)(() => IsStarting));
		}
	}

	public bool IsTradeRunningCSGO
	{
		get
		{
			return bool_2;
		}
		set
		{
			bool_2 = value;
			((PropertyChangedBase)this).NotifyOfPropertyChange<bool>((Expression<Func<bool>>)(() => IsTradeRunningCSGO));
		}
	}

	public bool IsTradeRunningDOTA2
	{
		get
		{
			return bool_3;
		}
		set
		{
			bool_3 = value;
			((PropertyChangedBase)this).NotifyOfPropertyChange<bool>((Expression<Func<bool>>)(() => IsTradeRunningDOTA2));
		}
	}

	public bool IsTradeStartAll
	{
		get
		{
			return bool_1;
		}
		set
		{
			bool_1 = value;
			((PropertyChangedBase)this).NotifyOfPropertyChange<bool>((Expression<Func<bool>>)(() => IsTradeStartAll));
		}
	}

	public string String_0
	{
		get
		{
			return string_0;
		}
		set
		{
			string_0 = value;
			((PropertyChangedBase)this).NotifyOfPropertyChange<string>((Expression<Func<string>>)(() => String_0));
		}
	}

	public string LogTextDOTA2
	{
		get
		{
			return string_1;
		}
		set
		{
			string_1 = value;
			((PropertyChangedBase)this).NotifyOfPropertyChange<string>((Expression<Func<string>>)(() => LogTextDOTA2));
		}
	}

	public SteamTraderViewModel(IEventAggregator events, ILog logger, IApiMarketCsgoCom apiMarketCsgoCom, GInterface2 apiMarketDota2Net, IMessageBox messageBox)
	{
		Class24.nhQmSIPz7n4eU();
		string_0 = "Нажмите 'Запустить', чтобы включить приём/передачу CSGO.";
		string_1 = "Нажмите 'Запустить', чтобы включить приём/передачу DOTA2.";
		((Screen)this)._002Ector();
		ilog_0 = logger;
		iapiMarketCsgoCom_0 = apiMarketCsgoCom;
		ginterface2_0 = apiMarketDota2Net;
		imessageBox_0 = messageBox;
		ieventAggregator_0 = events;
		ieventAggregator_0.Subscribe((object)this);
		method_0();
	}

	private async Task method_0()
	{
		await Task.Run(async delegate
		{
			await Task.Delay(3000);
			if (setting_0.AutoStartSteamTraderFlag)
			{
				await TradesAcceptCsgo();
			}
			if (settingDota2_0.AutoStartSteamTraderFlag)
			{
				await TradesAcceptDota2();
			}
		});
	}

	public void makeNewTradeBot(string game)
	{
		if (bool_4)
		{
			ilog_0.Warn("new TraderBot locked " + game, Array.Empty<object>());
			return;
		}
		bool_4 = true;
		ilog_0.Warn("new TraderBot " + game, Array.Empty<object>());
		class17_0 = new Class17(setting_0.Username, setting_0.Password, setting_0.ApiKeySteam, ieventAggregator_0);
		try
		{
			for (int i = 0; i < 3; i++)
			{
				string text = class17_0.imethod_2(game);
				if (!(text == "OK"))
				{
					if (!(text == "Retry") || i == 2)
					{
						break;
					}
					if (!(game == "csgo"))
					{
						if (game == "dota2")
						{
							EventAggregatorExtensions.PublishOnUIThread(ieventAggregator_0, (object)new SetLogDota2
							{
								Text = " Не удалось залогиниться в STEAM. " + (i + 2) + " попытка через 5 секунд...\n",
								Date = DateTime.UtcNow.ToLocalTime().ToString("H:mm:ss"),
								TradeId = 0L
							});
						}
					}
					else
					{
						EventAggregatorExtensions.PublishOnUIThread(ieventAggregator_0, (object)new SetLogCsgo
						{
							Text = " Не удалось залогиниться в STEAM. " + (i + 2) + " попытка через 5 секунд...\n",
							Date = DateTime.UtcNow.ToLocalTime().ToString("H:mm:ss"),
							TradeId = 0L,
							requestId = null,
							request = null
						});
					}
					Thread.Sleep(5000);
					continue;
				}
				if (!(game == "csgo"))
				{
					if (game == "dota2")
					{
						EventAggregatorExtensions.PublishOnUIThread(ieventAggregator_0, (object)new SetLogDota2
						{
							Text = " Перелогинились в STEAM...\n",
							Date = DateTime.UtcNow.ToLocalTime().ToString("H:mm:ss"),
							TradeId = 0L
						});
					}
				}
				else
				{
					EventAggregatorExtensions.PublishOnUIThread(ieventAggregator_0, (object)new SetLogCsgo
					{
						Text = " Перелогинились в STEAM...\n",
						Date = DateTime.UtcNow.ToLocalTime().ToString("H:mm:ss"),
						TradeId = 0L,
						requestId = null,
						request = null
					});
				}
				break;
			}
		}
		catch (Exception ex)
		{
			ilog_0.Warn("Ошибка в приёме/передачи - new TraderBot " + game, Array.Empty<object>());
			ilog_0.Warn(ex.ToString(), Array.Empty<object>());
		}
		finally
		{
			ilog_0.Warn("new TraderBot unlocked " + game, Array.Empty<object>());
			bool_4 = false;
		}
	}

	public async void Relogin(Exception e, string game)
	{
		await Task.Delay(5000);
		ilog_0.Warn(e.ToString(), Array.Empty<object>());
		if (class17_0 != null)
		{
			try
			{
				ilog_0.Warn(class17_0.imethod_6(game), Array.Empty<object>());
				return;
			}
			catch (Exception ex)
			{
				ilog_0.Warn(ex.ToString(), Array.Empty<object>());
				makeNewTradeBot(game);
				return;
			}
		}
		ilog_0.Warn("Ошибка в приёме/передачи - NULL", Array.Empty<object>());
		makeNewTradeBot(game);
	}

	public async void Handle(SetLogCsgo message)
	{
		_003C_003Ec__DisplayClass23_0 _003C_003Ec__DisplayClass23_ = new _003C_003Ec__DisplayClass23_0();
		_003C_003Ec__DisplayClass23_.message = message;
		_003C_003Ec__DisplayClass23_._003C_003E4__this = this;
		await Task.Run(async delegate
		{
			if (_003C_003Ec__DisplayClass23_.message != null)
			{
				string text = _003C_003Ec__DisplayClass23_._003C_003E4__this.String_0;
				string text2 = _003C_003Ec__DisplayClass23_.message.Date + _003C_003Ec__DisplayClass23_.message.Text;
				_003C_003Ec__DisplayClass23_._003C_003E4__this.arrayLogCSGO.Add(text2.Length);
				_003C_003Ec__DisplayClass23_._003C_003E4__this.string_0 = text2 + text;
				if (_003C_003Ec__DisplayClass23_._003C_003E4__this.arrayLogCSGO.Count > 50 && _003C_003Ec__DisplayClass23_._003C_003E4__this.string_0.Length - _003C_003Ec__DisplayClass23_._003C_003E4__this.arrayLogCSGO[0] >= 0)
				{
					_003C_003Ec__DisplayClass23_._003C_003E4__this.string_0 = _003C_003Ec__DisplayClass23_._003C_003E4__this.string_0.Substring(0, _003C_003Ec__DisplayClass23_._003C_003E4__this.string_0.Length - _003C_003Ec__DisplayClass23_._003C_003E4__this.arrayLogCSGO[0]);
					_003C_003Ec__DisplayClass23_._003C_003E4__this.arrayLogCSGO.RemoveAt(0);
				}
				_003C_003Ec__DisplayClass23_._003C_003E4__this.String_0 = _003C_003Ec__DisplayClass23_._003C_003E4__this.string_0;
				if (isTradeStartCSGO)
				{
					try
					{
						if (_003C_003Ec__DisplayClass23_._003C_003E4__this.class17_0 != null)
						{
							if (_003C_003Ec__DisplayClass23_.message.TradeId != 0L)
							{
								try
								{
									if (!_003C_003Ec__DisplayClass23_._003C_003E4__this.class17_0.imethod_4())
									{
										EventAggregatorExtensions.PublishOnUIThread(_003C_003Ec__DisplayClass23_._003C_003E4__this.ieventAggregator_0, (object)new SetLogCsgo
										{
											Text = " Ошибка сессии STEAM. Пробуем обновить сессию...\n",
											Date = DateTime.UtcNow.ToLocalTime().ToString("H:mm:ss"),
											TradeId = 0L,
											requestId = null,
											request = null
										});
										if (!(_003C_003Ec__DisplayClass23_._003C_003E4__this.class17_0.imethod_2("csgo") == "OK"))
										{
											EventAggregatorExtensions.PublishOnUIThread(_003C_003Ec__DisplayClass23_._003C_003E4__this.ieventAggregator_0, (object)new SetLogCsgo
											{
												Text = " Обновить сессию не удалось...\n",
												Date = DateTime.UtcNow.ToLocalTime().ToString("H:mm:ss"),
												TradeId = 0L,
												requestId = null,
												request = null
											});
											return;
										}
										EventAggregatorExtensions.PublishOnUIThread(_003C_003Ec__DisplayClass23_._003C_003E4__this.ieventAggregator_0, (object)new SetLogCsgo
										{
											Text = " Сессия обновлена...\n",
											Date = DateTime.UtcNow.ToLocalTime().ToString("H:mm:ss"),
											TradeId = 0L,
											requestId = null,
											request = null
										});
									}
									_003C_003Ec__DisplayClass23_._003C_003E4__this.class17_0.imethod_8(_003C_003Ec__DisplayClass23_.message.TradeId.ToString(), "csgo");
									EventAggregatorExtensions.PublishOnUIThread(_003C_003Ec__DisplayClass23_._003C_003E4__this.ieventAggregator_0, (object)new SetLogCsgo
									{
										Text = " Обмен принят...\n",
										Date = DateTime.UtcNow.ToLocalTime().ToString("H:mm:ss"),
										TradeId = 0L,
										requestId = null,
										request = null
									});
									await _003C_003Ec__DisplayClass23_._003C_003E4__this.iapiMarketCsgoCom_0.UpdateInventory();
								}
								catch (Exception e)
								{
									if (_003C_003Ec__DisplayClass23_._003C_003E4__this.setting_0.LoggerFlag)
									{
										_003C_003Ec__DisplayClass23_._003C_003E4__this.ilog_0.Warn("Ошибка в приёме/передачи - 2", Array.Empty<object>());
									}
									_003C_003Ec__DisplayClass23_._003C_003E4__this.Relogin(e, "csgo");
								}
							}
							if (_003C_003Ec__DisplayClass23_.message.requestId != null && _003C_003Ec__DisplayClass23_.message.request != null)
							{
								try
								{
									TradeOffer.TradeStatus tradeStatus = new TradeOffer.TradeStatus();
									for (int i = 0; i < _003C_003Ec__DisplayClass23_.message.request.items.Count; i++)
									{
										tradeStatus.AddMyItem(_003C_003Ec__DisplayClass23_.message.request.items[i].appid, Convert.ToInt64(_003C_003Ec__DisplayClass23_.message.request.items[i].contextid), Convert.ToInt64(_003C_003Ec__DisplayClass23_.message.request.items[i].assetid), _003C_003Ec__DisplayClass23_.message.request.items[i].amount);
									}
									if (!_003C_003Ec__DisplayClass23_._003C_003E4__this.class17_0.imethod_4())
									{
										EventAggregatorExtensions.PublishOnUIThread(_003C_003Ec__DisplayClass23_._003C_003E4__this.ieventAggregator_0, (object)new SetLogCsgo
										{
											Text = " Ошибка сессии STEAM. Пробуем обновить сессию...\n",
											Date = DateTime.UtcNow.ToLocalTime().ToString("H:mm:ss"),
											TradeId = 0L,
											requestId = null,
											request = null
										});
										if (!(_003C_003Ec__DisplayClass23_._003C_003E4__this.class17_0.imethod_2("csgo") == "OK"))
										{
											EventAggregatorExtensions.PublishOnUIThread(_003C_003Ec__DisplayClass23_._003C_003E4__this.ieventAggregator_0, (object)new SetLogCsgo
											{
												Text = " Обновить сессию не удалось...\n",
												Date = DateTime.UtcNow.ToLocalTime().ToString("H:mm:ss"),
												TradeId = 0L,
												requestId = null,
												request = null
											});
											return;
										}
										EventAggregatorExtensions.PublishOnUIThread(_003C_003Ec__DisplayClass23_._003C_003E4__this.ieventAggregator_0, (object)new SetLogCsgo
										{
											Text = " Сессия обновлена...\n",
											Date = DateTime.UtcNow.ToLocalTime().ToString("H:mm:ss"),
											TradeId = 0L,
											requestId = null,
											request = null
										});
									}
									string text3 = _003C_003Ec__DisplayClass23_._003C_003E4__this.class17_0.imethod_9(_003C_003Ec__DisplayClass23_.message.request.tradeoffermessage, _003C_003Ec__DisplayClass23_.message.request.partner, tradeStatus, _003C_003Ec__DisplayClass23_.message.request.token, "csgo");
									if (text3 != null)
									{
										if ((await _003C_003Ec__DisplayClass23_._003C_003E4__this.iapiMarketCsgoCom_0.ReportCreatedTrade(_003C_003Ec__DisplayClass23_.message.requestId, text3)).success)
										{
											EventAggregatorExtensions.PublishOnUIThread(_003C_003Ec__DisplayClass23_._003C_003E4__this.ieventAggregator_0, (object)new SetLogCsgo
											{
												Text = " Обмен создан...\n",
												Date = DateTime.UtcNow.ToLocalTime().ToString("H:mm:ss"),
												TradeId = 0L,
												requestId = null,
												request = null
											});
										}
										else
										{
											EventAggregatorExtensions.PublishOnUIThread(_003C_003Ec__DisplayClass23_._003C_003E4__this.ieventAggregator_0, (object)new SetLogCsgo
											{
												Text = " Обмен не создан...\n",
												Date = DateTime.UtcNow.ToLocalTime().ToString("H:mm:ss"),
												TradeId = 0L,
												requestId = null,
												request = null
											});
										}
									}
								}
								catch (ApplicationException ex)
								{
									if (_003C_003Ec__DisplayClass23_._003C_003E4__this.setting_0.LoggerFlag)
									{
										_003C_003Ec__DisplayClass23_._003C_003E4__this.ilog_0.Warn("Создание обмена в SteamTraderView CSGO", Array.Empty<object>());
										_003C_003Ec__DisplayClass23_._003C_003E4__this.ilog_0.Warn(ex.Message, Array.Empty<object>());
									}
								}
								catch (Exception e2)
								{
									if (_003C_003Ec__DisplayClass23_._003C_003E4__this.setting_0.LoggerFlag)
									{
										_003C_003Ec__DisplayClass23_._003C_003E4__this.ilog_0.Warn("Ошибка в приёме/передачи - 3", Array.Empty<object>());
									}
									_003C_003Ec__DisplayClass23_._003C_003E4__this.Relogin(e2, "csgo");
								}
								await _003C_003Ec__DisplayClass23_._003C_003E4__this.iapiMarketCsgoCom_0.UpdateInventory();
							}
						}
					}
					catch (Exception e3)
					{
						if (_003C_003Ec__DisplayClass23_._003C_003E4__this.setting_0.LoggerFlag)
						{
							_003C_003Ec__DisplayClass23_._003C_003E4__this.ilog_0.Warn("Ошибка в приёме/передачи - 4 -", Array.Empty<object>());
						}
						_003C_003Ec__DisplayClass23_._003C_003E4__this.Relogin(e3, "csgo");
					}
				}
			}
		});
	}

	public async void Handle(SetLogDota2 message)
	{
		_003C_003Ec__DisplayClass24_0 _003C_003Ec__DisplayClass24_ = new _003C_003Ec__DisplayClass24_0();
		_003C_003Ec__DisplayClass24_.message = message;
		_003C_003Ec__DisplayClass24_._003C_003E4__this = this;
		await Task.Run(async delegate
		{
			if (_003C_003Ec__DisplayClass24_.message != null)
			{
				string logTextDOTA = _003C_003Ec__DisplayClass24_._003C_003E4__this.LogTextDOTA2;
				string text = _003C_003Ec__DisplayClass24_.message.Date + _003C_003Ec__DisplayClass24_.message.Text;
				_003C_003Ec__DisplayClass24_._003C_003E4__this.arrayLogDOTA2.Add(text.Length);
				_003C_003Ec__DisplayClass24_._003C_003E4__this.string_1 = text + logTextDOTA;
				if (_003C_003Ec__DisplayClass24_._003C_003E4__this.arrayLogDOTA2.Count > 50 && _003C_003Ec__DisplayClass24_._003C_003E4__this.string_1.Length - _003C_003Ec__DisplayClass24_._003C_003E4__this.arrayLogDOTA2[0] >= 0)
				{
					_003C_003Ec__DisplayClass24_._003C_003E4__this.string_1 = _003C_003Ec__DisplayClass24_._003C_003E4__this.string_1.Substring(0, _003C_003Ec__DisplayClass24_._003C_003E4__this.string_1.Length - _003C_003Ec__DisplayClass24_._003C_003E4__this.arrayLogDOTA2[0]);
					_003C_003Ec__DisplayClass24_._003C_003E4__this.arrayLogDOTA2.RemoveAt(0);
				}
				_003C_003Ec__DisplayClass24_._003C_003E4__this.LogTextDOTA2 = _003C_003Ec__DisplayClass24_._003C_003E4__this.string_1;
				try
				{
					if (_003C_003Ec__DisplayClass24_._003C_003E4__this.class17_0 != null && _003C_003Ec__DisplayClass24_.message.TradeId != 0L)
					{
						try
						{
							if (!_003C_003Ec__DisplayClass24_._003C_003E4__this.class17_0.imethod_4())
							{
								EventAggregatorExtensions.PublishOnUIThread(_003C_003Ec__DisplayClass24_._003C_003E4__this.ieventAggregator_0, (object)new SetLogDota2
								{
									Text = " Ошибка сессии STEAM. Пробуем обновить сессию...\n",
									Date = DateTime.UtcNow.ToLocalTime().ToString("H:mm:ss"),
									TradeId = 0L
								});
								if (!(_003C_003Ec__DisplayClass24_._003C_003E4__this.class17_0.imethod_2("dota2") == "OK"))
								{
									EventAggregatorExtensions.PublishOnUIThread(_003C_003Ec__DisplayClass24_._003C_003E4__this.ieventAggregator_0, (object)new SetLogDota2
									{
										Text = " Обновить сессию не удалось...\n",
										Date = DateTime.UtcNow.ToLocalTime().ToString("H:mm:ss"),
										TradeId = 0L
									});
									return;
								}
								EventAggregatorExtensions.PublishOnUIThread(_003C_003Ec__DisplayClass24_._003C_003E4__this.ieventAggregator_0, (object)new SetLogDota2
								{
									Text = " Сессия обновлена...\n",
									Date = DateTime.UtcNow.ToLocalTime().ToString("H:mm:ss"),
									TradeId = 0L
								});
							}
							_003C_003Ec__DisplayClass24_._003C_003E4__this.class17_0.imethod_8(_003C_003Ec__DisplayClass24_.message.TradeId.ToString(), "dota2");
							EventAggregatorExtensions.PublishOnUIThread(_003C_003Ec__DisplayClass24_._003C_003E4__this.ieventAggregator_0, (object)new SetLogDota2
							{
								Text = " Обмен принят...\n",
								Date = DateTime.UtcNow.ToLocalTime().ToString("H:mm:ss"),
								TradeId = 0L
							});
							await _003C_003Ec__DisplayClass24_._003C_003E4__this.ginterface2_0.UpdateInventory();
							return;
						}
						catch (Exception e)
						{
							if (_003C_003Ec__DisplayClass24_._003C_003E4__this.settingDota2_0.LoggerFlag)
							{
								_003C_003Ec__DisplayClass24_._003C_003E4__this.ilog_0.Warn("Ошибка в приёме/передачи Dota2", Array.Empty<object>());
							}
							_003C_003Ec__DisplayClass24_._003C_003E4__this.Relogin(e, "dota2");
							return;
						}
					}
				}
				catch (Exception e2)
				{
					if (_003C_003Ec__DisplayClass24_._003C_003E4__this.settingDota2_0.LoggerFlag)
					{
						_003C_003Ec__DisplayClass24_._003C_003E4__this.ilog_0.Warn("Ошибка в приёме/передачи Dota2", Array.Empty<object>());
					}
					_003C_003Ec__DisplayClass24_._003C_003E4__this.Relogin(e2, "dota2");
				}
			}
		});
	}

	public async Task TradesAcceptCsgo()
	{
		if (!isTradeStartCSGO)
		{
			_003C_003Ec__DisplayClass43_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass43_0();
			CS_0024_003C_003E8__locals0._003C_003E4__this = this;
			IsStarting = true;
			String_0 = "";
			arrayLogCSGO = new List<int>();
			EventAggregatorExtensions.PublishOnUIThread(ieventAggregator_0, (object)new SetLogCsgo
			{
				Text = " Запускаем приём/передачу CSGO...\n",
				Date = DateTime.UtcNow.ToLocalTime().ToString("H:mm:ss"),
				TradeId = 0L,
				requestId = null,
				request = null
			});
			CS_0024_003C_003E8__locals0.isLogin = false;
			if (class17_0 != null && class17_0.imethod_0())
			{
				CS_0024_003C_003E8__locals0.isLogin = true;
				EventAggregatorExtensions.PublishOnUIThread(ieventAggregator_0, (object)new SetLogCsgo
				{
					Text = " Приём/передача включены...\n",
					Date = DateTime.UtcNow.ToLocalTime().ToString("H:mm:ss"),
					TradeId = 0L,
					requestId = null,
					request = null
				});
			}
			else
			{
				EventAggregatorExtensions.PublishOnUIThread(ieventAggregator_0, (object)new SetLogCsgo
				{
					Text = " Логинимся в STEAM...\n",
					Date = DateTime.UtcNow.ToLocalTime().ToString("H:mm:ss"),
					TradeId = 0L,
					requestId = null,
					request = null
				});
				class17_0 = new Class17(setting_0.Username, setting_0.Password, setting_0.ApiKeySteam, ieventAggregator_0);
				await Task.Run(delegate
				{
					try
					{
						for (int i = 0; i < 3; i++)
						{
							string text = CS_0024_003C_003E8__locals0._003C_003E4__this.class17_0.imethod_2("csgo");
							if (text == "OK")
							{
								EventAggregatorExtensions.PublishOnUIThread(CS_0024_003C_003E8__locals0._003C_003E4__this.ieventAggregator_0, (object)new SetLogCsgo
								{
									Text = " Залогинились в STEAM...\n",
									Date = DateTime.UtcNow.ToLocalTime().ToString("H:mm:ss"),
									TradeId = 0L,
									requestId = null,
									request = null
								});
								CS_0024_003C_003E8__locals0.isLogin = true;
								break;
							}
							if (!(text == "Retry") || i == 2)
							{
								break;
							}
							EventAggregatorExtensions.PublishOnUIThread(CS_0024_003C_003E8__locals0._003C_003E4__this.ieventAggregator_0, (object)new SetLogCsgo
							{
								Text = " Не удалось залогиниться в STEAM. " + (i + 2) + " попытка через 5 секунд...\n",
								Date = DateTime.UtcNow.ToLocalTime().ToString("H:mm:ss"),
								TradeId = 0L,
								requestId = null,
								request = null
							});
							Thread.Sleep(5000);
						}
					}
					catch (Exception ex)
					{
						CS_0024_003C_003E8__locals0._003C_003E4__this.ilog_0.Warn("Ошибка в приёме/передачи - Запуск CSGO", Array.Empty<object>());
						CS_0024_003C_003E8__locals0._003C_003E4__this.ilog_0.Warn(ex.ToString(), Array.Empty<object>());
					}
				});
			}
			if (CS_0024_003C_003E8__locals0.isLogin)
			{
				isTradeStartCSGO = true;
				IsTradeRunningCSGO = true;
			}
			else
			{
				EventAggregatorExtensions.PublishOnUIThread(ieventAggregator_0, (object)new SetLogCsgo
				{
					Text = " Не удалось залогиниться в STEAM. Проверьте ваши данные и повторите попытку позже.\n",
					Date = DateTime.UtcNow.ToLocalTime().ToString("H:mm:ss"),
					TradeId = 0L,
					requestId = null,
					request = null
				});
			}
			IsStarting = false;
		}
		else
		{
			String_0 = "Нажмите 'Запустить', чтобы включить приём/передачу CSGO";
			isTradeStartCSGO = false;
			IsTradeRunningCSGO = false;
		}
	}

	public async Task TradesAcceptDota2()
	{
		if (!isTradeStartDOTA2)
		{
			_003C_003Ec__DisplayClass44_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass44_0();
			CS_0024_003C_003E8__locals0._003C_003E4__this = this;
			IsStarting = true;
			LogTextDOTA2 = "";
			arrayLogDOTA2 = new List<int>();
			EventAggregatorExtensions.PublishOnUIThread(ieventAggregator_0, (object)new SetLogDota2
			{
				Text = " Запускаем приём/передачу DOTA2...\n",
				Date = DateTime.UtcNow.ToLocalTime().ToString("H:mm:ss"),
				TradeId = 0L
			});
			CS_0024_003C_003E8__locals0.isLogin = false;
			if (class17_0 != null && class17_0.imethod_0())
			{
				CS_0024_003C_003E8__locals0.isLogin = true;
				EventAggregatorExtensions.PublishOnUIThread(ieventAggregator_0, (object)new SetLogDota2
				{
					Text = " Приём/передача включены...\n",
					Date = DateTime.UtcNow.ToLocalTime().ToString("H:mm:ss"),
					TradeId = 0L
				});
			}
			else
			{
				EventAggregatorExtensions.PublishOnUIThread(ieventAggregator_0, (object)new SetLogDota2
				{
					Text = " Логинимся в STEAM...\n",
					Date = DateTime.UtcNow.ToLocalTime().ToString("H:mm:ss"),
					TradeId = 0L
				});
				await Task.Run(delegate
				{
					try
					{
						for (int i = 0; i < 3; i++)
						{
							CS_0024_003C_003E8__locals0._003C_003E4__this.class17_0 = new Class17(CS_0024_003C_003E8__locals0._003C_003E4__this.settingDota2_0.Username, CS_0024_003C_003E8__locals0._003C_003E4__this.settingDota2_0.Password, CS_0024_003C_003E8__locals0._003C_003E4__this.settingDota2_0.ApiKeySteam, CS_0024_003C_003E8__locals0._003C_003E4__this.ieventAggregator_0);
							string text = CS_0024_003C_003E8__locals0._003C_003E4__this.class17_0.imethod_2("dota2");
							if (text == "OK")
							{
								EventAggregatorExtensions.PublishOnUIThread(CS_0024_003C_003E8__locals0._003C_003E4__this.ieventAggregator_0, (object)new SetLogDota2
								{
									Text = " Залогинились в STEAM...\n",
									Date = DateTime.UtcNow.ToLocalTime().ToString("H:mm:ss"),
									TradeId = 0L
								});
								CS_0024_003C_003E8__locals0.isLogin = true;
								break;
							}
							if (!(text == "Retry") || i == 2)
							{
								break;
							}
							EventAggregatorExtensions.PublishOnUIThread(CS_0024_003C_003E8__locals0._003C_003E4__this.ieventAggregator_0, (object)new SetLogDota2
							{
								Text = " Не удалось залогиниться в STEAM. " + (i + 2) + " попытка через 5 секунд...\n",
								Date = DateTime.UtcNow.ToLocalTime().ToString("H:mm:ss"),
								TradeId = 0L
							});
							Thread.Sleep(5000);
						}
					}
					catch (Exception ex)
					{
						CS_0024_003C_003E8__locals0._003C_003E4__this.ilog_0.Warn("Ошибка в приёме/передачи - Запуск Dota2", Array.Empty<object>());
						CS_0024_003C_003E8__locals0._003C_003E4__this.ilog_0.Warn(ex.ToString(), Array.Empty<object>());
					}
				});
			}
			if (CS_0024_003C_003E8__locals0.isLogin)
			{
				isTradeStartDOTA2 = true;
				IsTradeRunningDOTA2 = true;
			}
			else
			{
				EventAggregatorExtensions.PublishOnUIThread(ieventAggregator_0, (object)new SetLogDota2
				{
					Text = " Не удалось залогиниться в STEAM. Проверьте ваши данные и повторите попытку позже.\n",
					Date = DateTime.UtcNow.ToLocalTime().ToString("H:mm:ss"),
					TradeId = 0L
				});
			}
			IsStarting = false;
		}
		else
		{
			LogTextDOTA2 = "Нажмите 'Запустить', чтобы включить приём/передачу DOTA2";
			isTradeStartDOTA2 = false;
			IsTradeRunningDOTA2 = false;
		}
	}

	public async void StartAll()
	{
		if (!IsTradeStartAll)
		{
			if (!isTradeStartCSGO)
			{
				await TradesAcceptCsgo();
			}
			if (!isTradeStartDOTA2)
			{
				await TradesAcceptDota2();
			}
			IsTradeStartAll = true;
		}
		else
		{
			if (isTradeStartCSGO)
			{
				await TradesAcceptCsgo();
			}
			if (isTradeStartDOTA2)
			{
				await TradesAcceptDota2();
			}
			IsTradeStartAll = false;
		}
	}

	public void Handle(GetSettigsForSteamTrader message)
	{
		setting_0 = message.setting;
		settingDota2_0 = message.settingDota2;
		iapiMarketCsgoCom_0.setting = setting_0;
		ginterface2_0.setting = settingDota2_0;
	}

	static SteamTraderViewModel()
	{
		Class24.nhQmSIPz7n4eU();
	}

	[CompilerGenerated]
	private async Task method_1()
	{
		await Task.Delay(3000);
		if (setting_0.AutoStartSteamTraderFlag)
		{
			await TradesAcceptCsgo();
		}
		if (settingDota2_0.AutoStartSteamTraderFlag)
		{
			await TradesAcceptDota2();
		}
	}
}
