using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Runtime.CompilerServices;
using Caliburn.Micro;
using Newtonsoft.Json;
using SteamAuth;
using xbot.Trader;
using xbot.Trader.TradeOffers;
using xbot_wpf.Messages;

internal class Class17 : Interface0
{
	private xbot.Trader.SteamWeb steamWeb_0;

	private TradeOfferWebAPI tradeOfferWebAPI_0;

	private TradeOfferManager tradeOfferManager_0;

	private OfferSession offerSession_0;

	private SteamGuardAccount steamGuardAccount_0;

	private UserLogin userLogin_0;

	private string string_0;

	private string string_1;

	private string string_2;

	private string string_3;

	private IEnumerable<Cookie> ienumerable_0;

	private readonly IEventAggregator ieventAggregator_0;

	private bool bool_0;

	public Class17(string string_4, string string_5, string string_6, IEventAggregator ieventAggregator_1)
	{
		Class24.nhQmSIPz7n4eU();
		base._002Ector();
		string_0 = string_4;
		string_1 = string_5;
		string_2 = string_6;
		ieventAggregator_0 = ieventAggregator_1;
		ieventAggregator_0.Subscribe((object)this);
	}

	[SpecialName]
	public bool imethod_0()
	{
		return bool_0;
	}

	[SpecialName]
	public void imethod_1(bool bool_1)
	{
		bool_0 = bool_1;
	}

	public string imethod_2(string string_4)
	{
		userLogin_0 = new UserLogin(string_0, string_1);
		LoginResult loginResult = LoginResult.BadCredentials;
		string text = null;
		bool flag = false;
		bool flag2 = false;
		while ((loginResult = userLogin_0.DoLogin()) != 0 && !flag2)
		{
			switch (loginResult)
			{
			default:
				text = " Unknown error: " + loginResult;
				flag2 = true;
				break;
			case LoginResult.GeneralFailure:
				text = " Error logging in: Steam returned \"GeneralFailure\"...\n";
				flag2 = true;
				break;
			case LoginResult.BadRSA:
				text = " Error logging in: Steam returned \"BadRSA\"...\n";
				flag2 = true;
				break;
			case LoginResult.BadCredentials:
				text = " Error logging in: Username or password was incorrect...\n";
				flag2 = true;
				break;
			case LoginResult.NeedCaptcha:
				text = " Нужна каптча...\n";
				flag2 = true;
				break;
			case LoginResult.Need2FA:
				text = " Генерируем код SteamGuard...\n";
				userLogin_0.TwoFactorCode = imethod_5();
				flag = true;
				break;
			case LoginResult.NeedEmail:
				text = " Нужна почта ...\n";
				flag2 = true;
				break;
			case LoginResult.TooManyFailedLogins:
				text = " Error logging in: Too many failed logins, try again later...\n";
				flag2 = true;
				break;
			}
		}
		if (!(string_4 == "csgo"))
		{
			if (string_4 == "dota2")
			{
				EventAggregatorExtensions.PublishOnUIThread(ieventAggregator_0, (object)new SetLogDota2
				{
					Text = text,
					Date = DateTime.UtcNow.ToLocalTime().ToString("H:mm:ss"),
					TradeId = 0L
				});
			}
		}
		else
		{
			EventAggregatorExtensions.PublishOnUIThread(ieventAggregator_0, (object)new SetLogCsgo
			{
				Text = text,
				Date = DateTime.UtcNow.ToLocalTime().ToString("H:mm:ss"),
				TradeId = 0L,
				requestId = null,
				request = null
			});
		}
		if (flag)
		{
			steamGuardAccount_0.Session = userLogin_0.Session;
			ienumerable_0 = new List<Cookie>
			{
				new Cookie("sessionid", steamGuardAccount_0.Session.SessionID.ToString(), string.Empty, "steamcommunity.com"),
				new Cookie("steamLogin", steamGuardAccount_0.Session.SteamLogin.ToString(), string.Empty, "steamcommunity.com"),
				new Cookie("steamLoginSecure", steamGuardAccount_0.Session.SteamLoginSecure.ToString(), string.Empty, "steamcommunity.com")
			};
			steamWeb_0 = new xbot.Trader.SteamWeb();
			steamWeb_0.Authenticate(ienumerable_0);
			if (!steamWeb_0.VerifyCookies())
			{
				return "Retry";
			}
			tradeOfferWebAPI_0 = new TradeOfferWebAPI(string_2, steamWeb_0);
			tradeOfferManager_0 = new TradeOfferManager(string_2, steamWeb_0);
			offerSession_0 = new OfferSession(tradeOfferWebAPI_0, steamWeb_0);
			bool_0 = true;
			return "OK";
		}
		return "Fail";
	}

	public bool imethod_3(string string_4)
	{
		try
		{
			TimeAligner.AlignTime();
			userLogin_0.TwoFactorCode = steamGuardAccount_0.GenerateSteamGuardCode();
			steamGuardAccount_0.Session = userLogin_0.Session;
			ienumerable_0 = new List<Cookie>
			{
				new Cookie("sessionid", steamGuardAccount_0.Session.SessionID.ToString(), string.Empty, "steamcommunity.com"),
				new Cookie("steamLogin", steamGuardAccount_0.Session.SteamLogin.ToString(), string.Empty, "steamcommunity.com"),
				new Cookie("steamLoginSecure", steamGuardAccount_0.Session.SteamLoginSecure.ToString(), string.Empty, "steamcommunity.com")
			};
			steamWeb_0 = new xbot.Trader.SteamWeb();
			steamWeb_0.Authenticate(ienumerable_0);
			if (!steamWeb_0.VerifyCookies())
			{
				return false;
			}
			tradeOfferWebAPI_0 = new TradeOfferWebAPI(string_2, steamWeb_0);
			tradeOfferManager_0 = new TradeOfferManager(string_2, steamWeb_0);
			offerSession_0 = new OfferSession(tradeOfferWebAPI_0, steamWeb_0);
			bool_0 = true;
			return true;
		}
		catch (Exception ex)
		{
			string_3 = ex.Message;
			return false;
		}
	}

	public bool imethod_4()
	{
		if (!steamWeb_0.VerifyCookies())
		{
			return false;
		}
		return true;
	}

	public bool imethod_8(string string_4, string string_5)
	{
		OfferResponse tradeOffer = tradeOfferWebAPI_0.GetTradeOffer(string_4);
		TradeOfferAcceptResponse tradeOfferAcceptResponse = new TradeOffer(offerSession_0, tradeOffer.Offer).Accept();
		string text = imethod_6(string_5);
		text += tradeOfferAcceptResponse.TradeError;
		if (text != null && text != "")
		{
			if (!(string_5 == "csgo"))
			{
				if (string_5 == "dota2")
				{
					EventAggregatorExtensions.PublishOnUIThread(ieventAggregator_0, (object)new SetLogDota2
					{
						Text = text,
						Date = DateTime.UtcNow.ToLocalTime().ToString("H:mm:ss"),
						TradeId = 0L
					});
				}
			}
			else
			{
				EventAggregatorExtensions.PublishOnUIThread(ieventAggregator_0, (object)new SetLogCsgo
				{
					Text = text,
					Date = DateTime.UtcNow.ToLocalTime().ToString("H:mm:ss"),
					TradeId = 0L,
					requestId = null,
					request = null
				});
			}
		}
		return true;
	}

	public string imethod_5()
	{
		string path = Directory.GetFiles("MaFiles", "*.maFile")[0];
		if (File.Exists(path))
		{
			steamGuardAccount_0 = JsonConvert.DeserializeObject<SteamGuardAccount>(File.ReadAllText(path));
			return steamGuardAccount_0.GenerateSteamGuardCode();
		}
		return string.Empty;
	}

	public string imethod_6(string string_4)
	{
		if (steamGuardAccount_0 == null)
		{
			return " Аккаунт не поключён к SteamGuard...\n";
		}
		steamGuardAccount_0.Session.SteamLogin = steamWeb_0.Token;
		steamGuardAccount_0.Session.SteamLoginSecure = steamWeb_0.TokenSecure;
		try
		{
			Confirmation[] array = steamGuardAccount_0.FetchConfirmations();
			int num = 0;
			while (true)
			{
				if (num < array.Length)
				{
					Confirmation conf = array[num];
					if (steamGuardAccount_0.AcceptConfirmation(conf))
					{
						break;
					}
					num++;
					continue;
				}
				return null;
			}
			return " Подтвердили в аутентификаторе...\n";
		}
		catch (SteamGuardAccount.WGTokenInvalidException)
		{
			if (imethod_3(string_4))
			{
				return " Ошибка сессии. Перелогиниваемся в STEAM...\n";
			}
			string result = " Ошибка сессии. Не удаётся перелогиниться в STEAM... " + string_3 + "\n";
			string_3 = null;
			return result;
		}
	}

	public bool imethod_7()
	{
		if (Directory.GetFiles("MaFiles", "*.auth").Length == 0)
		{
			string sourceFileName = Directory.GetFiles("MaFiles", "*.maFile")[0];
			string destFileName = "MaFiles/" + string_0 + ".auth";
			File.Copy(sourceFileName, destFileName);
		}
		return true;
	}

	public string imethod_9(string string_4, string string_5, TradeOffer.TradeStatus tradeStatus_0, string string_6, string string_7)
	{
		string newTradeOfferId = null;
		try
		{
			offerSession_0.SendTradeOfferWithToken(string_4, string_5, tradeStatus_0, string_6, out newTradeOfferId);
			string text = imethod_6(string_7);
			if (!(string_7 == "csgo"))
			{
				if (string_7 == "dota2")
				{
					EventAggregatorExtensions.PublishOnUIThread(ieventAggregator_0, (object)new SetLogDota2
					{
						Text = text,
						Date = DateTime.UtcNow.ToLocalTime().ToString("H:mm:ss"),
						TradeId = 0L
					});
					return newTradeOfferId;
				}
				return newTradeOfferId;
			}
			EventAggregatorExtensions.PublishOnUIThread(ieventAggregator_0, (object)new SetLogCsgo
			{
				Text = text,
				Date = DateTime.UtcNow.ToLocalTime().ToString("H:mm:ss"),
				TradeId = 0L,
				requestId = null,
				request = null
			});
			return newTradeOfferId;
		}
		catch (WebException)
		{
			string text2 = "Ошибка создания обмена: не удалось найти нужную вещь, возможно она уже передана.\n";
			if (!(string_7 == "csgo"))
			{
				if (string_7 == "dota2")
				{
					EventAggregatorExtensions.PublishOnUIThread(ieventAggregator_0, (object)new SetLogDota2
					{
						Text = text2,
						Date = DateTime.UtcNow.ToLocalTime().ToString("H:mm:ss"),
						TradeId = 0L
					});
					return newTradeOfferId;
				}
				return newTradeOfferId;
			}
			EventAggregatorExtensions.PublishOnUIThread(ieventAggregator_0, (object)new SetLogCsgo
			{
				Text = text2,
				Date = DateTime.UtcNow.ToLocalTime().ToString("H:mm:ss"),
				TradeId = 0L,
				requestId = null,
				request = null
			});
			return newTradeOfferId;
		}
	}
}
