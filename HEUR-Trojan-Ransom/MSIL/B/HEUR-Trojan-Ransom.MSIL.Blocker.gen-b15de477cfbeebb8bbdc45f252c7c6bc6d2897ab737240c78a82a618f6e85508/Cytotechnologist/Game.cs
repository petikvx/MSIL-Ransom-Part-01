using System;
using System.Collections.Generic;
using System.Text;
using SimpleJSON;

namespace Cytotechnologist;

public class Game
{
	public readonly Rules Rules;

	public readonly Player[] Players;

	private readonly PlayerState[] _playerStates;

	private readonly Dice _dice;

	private List<Card> _deck;

	public readonly List<int> Winners = new List<int>();

	public readonly List<int> Losers = new List<int>();

	private int _currentPlayer = 2147483645;

	private int _currentTurn;

	private List<float> _chances;

	private readonly Random _random;

	private readonly StringBuilder _buffer;

	private bool _finished;

	private int _currentChanceIndex;

	public bool Finished
	{
		get
		{
			bool result = default(bool);
			PlayerState[] playerStates = default(PlayerState[]);
			int num3 = default(int);
			bool flag = default(bool);
			bool finished = default(bool);
			while (true)
			{
				int num = 295616495;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x1D054A00u) % 15u)
					{
					case 14u:
						result = false;
						num = ((int)num2 * -338006349) ^ 0x4DFE7314;
						continue;
					case 13u:
						result = true;
						num = (int)(num2 * 1246821460) ^ -1417875054;
						continue;
					case 11u:
					{
						PlayerState playerState = playerStates[num3];
						flag = playerState.State == State.Playing;
						num = 955120171;
						continue;
					}
					case 10u:
						result = true;
						num = (int)((num2 * 835379673) ^ 0x2BF965F2);
						continue;
					case 9u:
						num3++;
						num = 868042380;
						continue;
					case 8u:
					{
						int num7;
						int num8;
						if (!flag)
						{
							num7 = -1238976349;
							num8 = -1238976349;
						}
						else
						{
							num7 = -209653684;
							num8 = -209653684;
						}
						num = num7 ^ ((int)num2 * -421049722);
						continue;
					}
					case 7u:
					{
						int num6;
						if (num3 >= playerStates.Length)
						{
							num = 1995840836;
							num6 = 1995840836;
						}
						else
						{
							num = 1064873182;
							num6 = 1064873182;
						}
						continue;
					}
					case 6u:
						finished = _finished;
						num = ((int)num2 * -2070200173) ^ 0x1E706888;
						continue;
					case 5u:
					{
						int num4;
						int num5;
						if (!finished)
						{
							num4 = 1751615544;
							num5 = 1751615544;
						}
						else
						{
							num4 = 722558398;
							num5 = 722558398;
						}
						num = num4 ^ (int)(num2 * 146870946);
						continue;
					}
					case 3u:
						playerStates = _playerStates;
						num = 1230218783;
						continue;
					case 2u:
						num3 = 0;
						num = (int)((num2 * 1146392691) ^ 0x4DB4C761);
						continue;
					case 1u:
						num = ((int)num2 * -933373323) ^ -1638268876;
						continue;
					case 0u:
						num = ((int)num2 * -1798000011) ^ 0x1E019ECC;
						continue;
					case 4u:
						break;
					default:
						return result;
					}
					break;
				}
			}
		}
	}

	public Game(JSONNode json, StringBuilder buffer)
	{
		_buffer = buffer;
		_random = Game.smethod_0((int)DateTime.Now.Ticks);
		Rules = Rules.Deserialize(json["rules"]);
		_dice = new Dice();
		JSONNode jSONNode = json["players"];
		int count = jSONNode.Count;
		Players = new Player[count];
		for (int i = 0; i < count; i++)
		{
			Players[i] = Player.Deserialize(jSONNode[i]);
		}
		_playerStates = new PlayerState[count];
		for (int j = 0; j < count; j++)
		{
			_playerStates[j] = new PlayerState();
		}
	}

	public void ShuffleCards()
	{
		_deck = new List<Card>(Rules.Cards);
	}

	public void StartNew()
	{
		ShuffleCards();
		while (true)
		{
			int num = -104566942;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xC0A36FF4u) % 8u)
				{
				case 7u:
					_currentTurn = 0;
					_finished = false;
					_currentChanceIndex = -1;
					_chances = new List<float>(Rules.RiskChances);
					num = ((int)num2 * -1040103757) ^ 0x6F8C7EBD;
					continue;
				case 6u:
					Winners.Clear();
					num = (int)(num2 * 1687912857) ^ -1474816665;
					continue;
				case 5u:
					num = (int)((num2 * 1568377164) ^ 0x7F1FB41);
					continue;
				case 3u:
					_currentPlayer = Players.Length;
					num = (int)((num2 * 1161190738) ^ 0x4BAE95FD);
					continue;
				case 2u:
					num = ((int)num2 * -246074814) ^ -2025668269;
					continue;
				case 1u:
					Losers.Clear();
					num = ((int)num2 * -920509867) ^ 0x71520A1B;
					continue;
				default:
					return;
				case 0u:
					break;
				case 4u:
					return;
				}
				break;
			}
		}
	}

	public void PlanningState()
	{
		PlayerState playerState = default(PlayerState);
		int num3 = default(int);
		Player player = default(Player);
		int num7 = default(int);
		int planningCardsCount = default(int);
		bool useOneMorePlanningSprint = default(bool);
		bool flag = default(bool);
		while (true)
		{
			int num = 2137873640;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x42E81C87u) % 30u)
				{
				case 28u:
					num = ((int)num2 * -2031024642) ^ -2109997426;
					continue;
				case 27u:
					num = 818374082;
					continue;
				case 26u:
					playerState.Resources -= num3 * Rules.NormalPlanningCost;
					num = ((int)num2 * -1002677807) ^ 0x121276FA;
					continue;
				case 25u:
					player = Players[num7];
					num = (int)(num2 * 1889335417) ^ -2070130828;
					continue;
				case 24u:
					num3 = 0;
					num = 347390530;
					continue;
				case 23u:
					playerState.State = State.Playing;
					planningCardsCount = player.PlanningCardsCount;
					num = (int)((num2 * 873356052) ^ 0x7129498E);
					continue;
				case 22u:
				{
					int num6;
					if (num3 <= 0)
					{
						num = 1145997281;
						num6 = 1145997281;
					}
					else
					{
						num = 676477612;
						num6 = 676477612;
					}
					continue;
				}
				case 21u:
					playerState.Resources -= (planningCardsCount - num3) * Rules.NormalPlanningCost;
					num = 53355719;
					continue;
				case 20u:
				{
					int num10;
					int num11;
					if (useOneMorePlanningSprint)
					{
						num10 = -2067044715;
						num11 = -2067044715;
					}
					else
					{
						num10 = -1926229345;
						num11 = -1926229345;
					}
					num = num10 ^ (int)(num2 * 1743683127);
					continue;
				}
				case 19u:
					playerState.Sprint = -1;
					num = ((int)num2 * -1557164945) ^ 0x714D53E0;
					continue;
				case 18u:
					playerState.Sprint = 1;
					num = ((int)num2 * -1049778368) ^ 0x7BCCA3DD;
					continue;
				case 17u:
					num = ((int)num2 * -1459456642) ^ 0x58C385D4;
					continue;
				case 16u:
					num3 = planningCardsCount - Rules.NormalPlanningCount;
					num = (int)(num2 * 1036885731) ^ -2058822613;
					continue;
				case 15u:
					playerState.Resources = Rules.InitialResources;
					num = (int)((num2 * 708482329) ^ 0x5BCE1619);
					continue;
				case 14u:
					useOneMorePlanningSprint = player.UseOneMorePlanningSprint;
					num = ((int)num2 * -600510734) ^ -1130311579;
					continue;
				case 13u:
					playerState.Resources -= num3 * Rules.OverPlanningCost;
					num = (int)(num2 * 1421029700) ^ -771090658;
					continue;
				case 12u:
				{
					int num8;
					int num9;
					if (flag)
					{
						num8 = -505045458;
						num9 = -505045458;
					}
					else
					{
						num8 = -1741811760;
						num9 = -1741811760;
					}
					num = num8 ^ (int)(num2 * 1858109660);
					continue;
				}
				case 11u:
					num = (int)((num2 * 1772943342) ^ 0x3FFA09E0);
					continue;
				case 10u:
					playerState = _playerStates[num7];
					num = ((int)num2 * -748734963) ^ 0x1C8D371F;
					continue;
				case 9u:
					num7 = 0;
					num = (int)(num2 * 2008689228) ^ -1937097520;
					continue;
				case 8u:
					num7++;
					num = ((int)num2 * -782860382) ^ 0x2D7A7FD9;
					continue;
				case 7u:
					num = ((int)num2 * -1290196145) ^ 0x424ADA14;
					continue;
				case 6u:
					num = (int)(num2 * 1759981961) ^ -266419204;
					continue;
				case 4u:
					playerState.Sprint = 0;
					num = ((int)num2 * -2112858636) ^ 0x79AC227A;
					continue;
				case 3u:
					num = 1469408342;
					continue;
				case 2u:
					flag = num7 < Players.Length;
					num = 1068957895;
					continue;
				case 1u:
				{
					num3 = 0;
					int num4;
					int num5;
					if (planningCardsCount != 0)
					{
						num4 = -1540687900;
						num5 = -1540687900;
					}
					else
					{
						num4 = -55444428;
						num5 = -55444428;
					}
					num = num4 ^ (int)(num2 * 82930115);
					continue;
				}
				case 0u:
					num = 1038913133;
					continue;
				default:
					return;
				case 29u:
					break;
				case 5u:
					return;
				}
				break;
			}
		}
	}

	public void TurnState()
	{
		bool flag = default(bool);
		while (true)
		{
			int num = -1246566502;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x906DBB88u) % 16u)
				{
				case 14u:
				{
					int num5;
					int num6;
					if (_currentTurn > 0)
					{
						num5 = 2013522473;
						num6 = 2013522473;
					}
					else
					{
						num5 = 1793365756;
						num6 = 1793365756;
					}
					num = num5 ^ (int)(num2 * 1225465306);
					continue;
				}
				case 13u:
					Print("\n\nGAME STATE\n{0}\n\n-- END OF TURN {1} --\n\n", this, _currentTurn);
					num = ((int)num2 * -583713363) ^ -1413422163;
					continue;
				case 12u:
					num = (int)((num2 * 2037847372) ^ 0x50976580);
					continue;
				case 10u:
				{
					int num3;
					int num4;
					if (flag)
					{
						num3 = -834395055;
						num4 = -834395055;
					}
					else
					{
						num3 = -1793482272;
						num4 = -1793482272;
					}
					num = num3 ^ (int)(num2 * 1581097078);
					continue;
				}
				case 9u:
					flag = _currentPlayer >= Players.Length;
					num = ((int)num2 * -95634195) ^ -996361;
					continue;
				case 8u:
					Print(Game.smethod_1("-- BEGINNING OF TURN ", (++_currentTurn).ToString(), " --"));
					num = -391990183;
					continue;
				case 7u:
					num = (int)((num2 * 1944029854) ^ 0x2AA95579);
					continue;
				case 6u:
					_currentPlayer = 0;
					num = ((int)num2 * -506947636) ^ -2138249074;
					continue;
				case 5u:
					num = (int)(num2 * 1176932349) ^ -159466625;
					continue;
				case 4u:
					PlayerTurn(_currentPlayer);
					num = -1546120;
					continue;
				case 3u:
					num = (int)(num2 * 892464770) ^ -1853043558;
					continue;
				case 2u:
					_currentPlayer++;
					num = (int)(num2 * 1209027410) ^ -568972971;
					continue;
				case 1u:
					_currentChanceIndex = (_currentChanceIndex + 1) % _chances.Count;
					Print(Game.smethod_2("RISK CHANCE: ", Rules.RiskChances[_currentChanceIndex].ToString()));
					num = (int)((num2 * 1065825142) ^ 0x3BDBB209);
					continue;
				case 0u:
					num = (int)(num2 * 1628045438) ^ -1391443977;
					continue;
				default:
					return;
				case 11u:
					break;
				case 15u:
					return;
				}
				break;
			}
		}
	}

	private void PlayerTurn(int playerIndex)
	{
		PlayerState playerState = default(PlayerState);
		bool flag2 = default(bool);
		bool onlyOneWinner = default(bool);
		int num17 = default(int);
		Card card = default(Card);
		bool flag6 = default(bool);
		bool flag9 = default(bool);
		PlayerState playerState2 = default(PlayerState);
		int num8 = default(int);
		bool flag11 = default(bool);
		bool flag10 = default(bool);
		bool flag8 = default(bool);
		bool flag3 = default(bool);
		int num11 = default(int);
		bool flag4 = default(bool);
		bool flag = default(bool);
		Player player = default(Player);
		bool flag7 = default(bool);
		bool flag5 = default(bool);
		int num7 = default(int);
		while (true)
		{
			int num = 1220413078;
			while (true)
			{
				uint num2;
				int num19;
				switch ((num2 = (uint)num ^ 0x81CF10Au) % 85u)
				{
				case 84u:
					playerState.Sprint++;
					num = ((int)num2 * -1890448255) ^ 0xA201A96;
					continue;
				case 83u:
					flag2 = true;
					num = 34511920;
					continue;
				case 82u:
					onlyOneWinner = Rules.OnlyOneWinner;
					num = (int)((num2 * 1521562076) ^ 0x16D59DF1);
					continue;
				case 81u:
					num17++;
					num = 162351757;
					continue;
				case 80u:
					num = (int)((num2 * 144677169) ^ 0x41B376C3);
					continue;
				case 79u:
				{
					int num5;
					int num6;
					if (onlyOneWinner)
					{
						num5 = 762786261;
						num6 = 762786261;
					}
					else
					{
						num5 = 1768603044;
						num6 = 1768603044;
					}
					num = num5 ^ ((int)num2 * -449342973);
					continue;
				}
				case 78u:
					num19 = ((card.Type == 4) ? 1 : 0);
					goto IL_00a9;
				case 77u:
					Print("Still planning");
					num = ((int)num2 * -463369206) ^ 0x2467DE3;
					continue;
				case 76u:
				{
					int num23;
					int num24;
					if (!flag6)
					{
						num23 = -1362894174;
						num24 = -1362894174;
					}
					else
					{
						num23 = -1639973357;
						num24 = -1639973357;
					}
					num = num23 ^ (int)(num2 * 1618581263);
					continue;
				}
				case 75u:
					flag9 = num17 < _playerStates.Length;
					num = 1172003105;
					continue;
				case 74u:
					num = 2071245407;
					continue;
				case 73u:
					playerState2 = _playerStates[num17];
					playerState2.Resources -= Game.smethod_3(0, num8 - Players[num17].PlannedForCard(card.Type));
					num = (int)((num2 * 1929231620) ^ 0x1A5B64DD);
					continue;
				case 72u:
					num = 2125252311;
					continue;
				case 71u:
				{
					PlayerState playerState3 = playerState;
					Print(Game.smethod_2("\t", (playerState3 != null) ? Game.smethod_5((object)playerState3) : null));
					num = 103177061;
					continue;
				}
				case 70u:
					num = ((int)num2 * -416142277) ^ 0x7951D326;
					continue;
				case 68u:
					num = 2141502077;
					continue;
				case 67u:
				{
					int num35;
					int num36;
					if (!flag11)
					{
						num35 = -727424574;
						num36 = -727424574;
					}
					else
					{
						num35 = -2014653710;
						num36 = -2014653710;
					}
					num = num35 ^ (int)(num2 * 2103295751);
					continue;
				}
				case 66u:
				{
					int num31;
					int num32;
					if (flag10)
					{
						num31 = -1598726893;
						num32 = -1598726893;
					}
					else
					{
						num31 = -945685796;
						num32 = -945685796;
					}
					num = num31 ^ (int)(num2 * 1420654612);
					continue;
				}
				case 65u:
					num = 714264402;
					continue;
				case 64u:
					playerState.Sprint++;
					num = ((int)num2 * -1046691700) ^ 0x5E9C1A34;
					continue;
				case 63u:
					flag8 = playerState.State != State.Playing;
					num = (int)((num2 * 1092329114) ^ 0x182D878E);
					continue;
				case 62u:
				{
					int num25;
					int num26;
					if (!flag9)
					{
						num25 = -1031634319;
						num26 = -1031634319;
					}
					else
					{
						num25 = -187208669;
						num26 = -187208669;
					}
					num = num25 ^ ((int)num2 * -2125187796);
					continue;
				}
				case 61u:
					if (Rules.EconomicsAffectsAll)
					{
						num = ((int)num2 * -110757908) ^ -1428759341;
						continue;
					}
					num19 = 0;
					goto IL_00a9;
				case 60u:
					flag3 = flag2;
					num = 412811487;
					continue;
				case 59u:
					playerState.State = State.Won;
					num = ((int)num2 * -1865965598) ^ 0x774569BF;
					continue;
				case 58u:
					num17 = 0;
					num = 747245020;
					continue;
				case 57u:
					num = (int)((num2 * 94642528) ^ 0x5FE32CCD);
					continue;
				case 56u:
					Losers.Add(num11);
					num = ((int)num2 * -334025101) ^ -1015358696;
					continue;
				case 55u:
					num11 = 0;
					num = (int)(num2 * 2099460469) ^ -782927002;
					continue;
				case 54u:
					flag6 = playerState.Sprint > Rules.SprintCount;
					num = 1819836954;
					continue;
				case 53u:
					flag4 = !_dice.Roll(_chances[_currentChanceIndex]);
					num = 2012551462;
					continue;
				case 52u:
					Print(playerState.State);
					num = (int)(num2 * 253946652) ^ -755922529;
					continue;
				case 51u:
					num = (int)((num2 * 240327924) ^ 0x1B01334C);
					continue;
				case 50u:
					num = (int)((num2 * 293963559) ^ 0x7EE9604A);
					continue;
				case 49u:
					Print("CARD: {0}, {1}{2} {3} and {4}", card, flag11 ? "ALL " : "", flag ? "receives" : "pays", Game.smethod_4(num8), flag2 ? "advance" : "stay");
					num = 1263852607;
					continue;
				case 48u:
				{
					int num33;
					int num34;
					if (playerState2.Resources < 0)
					{
						num33 = -1016205102;
						num34 = -1016205102;
					}
					else
					{
						num33 = -606834793;
						num34 = -606834793;
					}
					num = num33 ^ (int)(num2 * 266261197);
					continue;
				}
				case 47u:
					num = ((int)num2 * -1092759029) ^ -1579916943;
					continue;
				case 46u:
					Losers.Add(playerIndex);
					num = (int)((num2 * 1607245915) ^ 0xE54C76C);
					continue;
				case 45u:
					num = (int)(num2 * 2038266491) ^ -554720161;
					continue;
				case 44u:
					card = DrawCard();
					flag = card.Impact < 0;
					num = 288834277;
					continue;
				case 43u:
					playerState.Resources -= num8;
					num = ((int)num2 * -1117042561) ^ -421435592;
					continue;
				case 42u:
					num = (int)(num2 * 764106750) ^ -34905433;
					continue;
				case 41u:
				{
					int num29;
					int num30;
					if (flag4)
					{
						num29 = -1146567326;
						num30 = -1146567326;
					}
					else
					{
						num29 = -1946995764;
						num30 = -1946995764;
					}
					num = num29 ^ (int)(num2 * 1875670628);
					continue;
				}
				case 40u:
					playerState2.State = State.Lose;
					flag10 = !Losers.Contains(num17);
					num = 2021392141;
					continue;
				case 39u:
					Print(Game.smethod_2("\nPLAYER ", playerIndex.ToString()));
					num = (int)((num2 * 882676025) ^ 0x13BC16A0);
					continue;
				case 38u:
					flag2 = false;
					num = 1550688989;
					continue;
				case 37u:
				{
					int num27;
					int num28;
					if (playerState.Resources < 0)
					{
						num27 = 1169619719;
						num28 = 1169619719;
					}
					else
					{
						num27 = 1023786958;
						num28 = 1023786958;
					}
					num = num27 ^ ((int)num2 * -1667625597);
					continue;
				}
				case 36u:
					_finished = true;
					num = ((int)num2 * -130996476) ^ -51027266;
					continue;
				case 35u:
					num = (int)((num2 * 1248381522) ^ 0x2766783F);
					continue;
				case 34u:
					player = Players[playerIndex];
					num = (int)(num2 * 629843140) ^ -952152027;
					continue;
				case 33u:
				{
					int num21;
					int num22;
					if (flag8)
					{
						num21 = -1506136632;
						num22 = -1506136632;
					}
					else
					{
						num21 = -292869444;
						num22 = -292869444;
					}
					num = num21 ^ (int)(num2 * 389726890);
					continue;
				}
				case 32u:
					Losers.Add(num17);
					num = ((int)num2 * -1185564273) ^ -1036559498;
					continue;
				case 31u:
					num11++;
					num = 1755217071;
					continue;
				case 30u:
					num = (int)(num2 * 228802412) ^ -198750251;
					continue;
				case 29u:
					num = (int)((num2 * 83803510) ^ 0x777FB537);
					continue;
				case 28u:
					num = (int)((num2 * 1094981920) ^ 0x31F528C1);
					continue;
				case 27u:
				{
					int num20;
					if (playerState.Sprint < 0)
					{
						num = 1614507016;
						num20 = 1614507016;
					}
					else
					{
						num = 1666757008;
						num20 = 1666757008;
					}
					continue;
				}
				case 25u:
					num8 = card.Impact;
					num = (int)(num2 * 153187645) ^ -19571980;
					continue;
				case 24u:
				{
					int num18;
					if (!Losers.Contains(num11))
					{
						num = 1469626290;
						num18 = 1469626290;
					}
					else
					{
						num = 1691488176;
						num18 = 1691488176;
					}
					continue;
				}
				case 23u:
				{
					int num15;
					int num16;
					if (!flag7)
					{
						num15 = -1641735284;
						num16 = -1641735284;
					}
					else
					{
						num15 = -2139135763;
						num16 = -2139135763;
					}
					num = num15 ^ ((int)num2 * -1699543703);
					continue;
				}
				case 22u:
					flag7 = num11 < _playerStates.Length;
					num = 849719871;
					continue;
				case 21u:
					num = ((int)num2 * -1710464047) ^ 0x47E0E242;
					continue;
				case 20u:
					num = 1576641633;
					continue;
				case 19u:
					num = ((int)num2 * -525452507) ^ -1001257942;
					continue;
				case 18u:
					playerState.State = State.Lose;
					flag5 = !Losers.Contains(playerIndex);
					num = ((int)num2 * -988975736) ^ 0x5EC41074;
					continue;
				case 17u:
					num = (int)((num2 * 1127713691) ^ 0x165ABF43);
					continue;
				case 16u:
				{
					int num13;
					int num14;
					if (flag5)
					{
						num13 = -1983580166;
						num14 = -1983580166;
					}
					else
					{
						num13 = -177106617;
						num14 = -177106617;
					}
					num = num13 ^ ((int)num2 * -470916398);
					continue;
				}
				case 15u:
					num = (int)((num2 * 1459322530) ^ 0x262F00BE);
					continue;
				case 14u:
					flag2 = true;
					num = (int)(num2 * 483032272) ^ -1643960325;
					continue;
				case 13u:
					num = ((int)num2 * -317609368) ^ -255983431;
					continue;
				case 12u:
				{
					int num12;
					if (num11 == playerIndex)
					{
						num = 613648263;
						num12 = 613648263;
					}
					else
					{
						num = 1512476166;
						num12 = 1512476166;
					}
					continue;
				}
				case 11u:
					num = ((int)num2 * -914739757) ^ -1675818051;
					continue;
				case 10u:
				{
					int num9;
					int num10;
					if (!flag3)
					{
						num9 = 126037366;
						num10 = 126037366;
					}
					else
					{
						num9 = 978962694;
						num10 = 978962694;
					}
					num = num9 ^ (int)(num2 * 742117090);
					continue;
				}
				case 9u:
					num = 150291550;
					continue;
				case 8u:
					num7 = card.Impact - player.PlannedForCard(card.Type);
					flag2 = num7 < Rules.StayOnSprintMinDiff;
					num = (int)((num2 * 1748998257) ^ 0x713A288);
					continue;
				case 7u:
					num = (int)((num2 * 881546484) ^ 0x19128043);
					continue;
				case 6u:
					playerState = _playerStates[playerIndex];
					num = (int)(num2 * 1881913604) ^ -425233192;
					continue;
				case 5u:
					num8 = Game.smethod_3(0, num7);
					num = ((int)num2 * -1260474500) ^ -2101696341;
					continue;
				case 4u:
					num = (int)(num2 * 392678204) ^ -1859746474;
					continue;
				case 3u:
				{
					int num3;
					int num4;
					if (flag)
					{
						num3 = 2096644746;
						num4 = 2096644746;
					}
					else
					{
						num3 = 1834182954;
						num4 = 1834182954;
					}
					num = num3 ^ ((int)num2 * -332342900);
					continue;
				}
				case 2u:
					Print("CARD: none, advance");
					num = ((int)num2 * -13277547) ^ -392783084;
					continue;
				case 1u:
					Winners.Add(playerIndex);
					num = (int)(num2 * 1296036403) ^ -1172092003;
					continue;
				case 0u:
					num = (int)((num2 * 1991355629) ^ 0x138F833);
					continue;
				default:
					return;
				case 26u:
					break;
				case 69u:
					return;
					IL_00a9:
					flag11 = (byte)num19 != 0;
					num = 1307615863;
					continue;
				}
				break;
			}
		}
	}

	private Card DrawCard()
	{
		if (_deck.Count <= 0)
		{
			goto IL_004a;
		}
		goto IL_0078;
		IL_0078:
		Card card = _deck[0];
		_deck.RemoveAt(0);
		int num = -1930453151;
		goto IL_004f;
		IL_004f:
		Card result = default(Card);
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)num ^ 0x9F58F471u) % 6u)
			{
			case 4u:
				result = card;
				num = ((int)num2 * -190951051) ^ -538308722;
				continue;
			case 3u:
				ShuffleCards();
				num = ((int)num2 * -907025584) ^ 0x5A9D2E13;
				continue;
			case 1u:
				num = ((int)num2 * -1073844219) ^ -274323141;
				continue;
			case 0u:
				break;
			case 2u:
				goto IL_0078;
			default:
				return result;
			}
			break;
		}
		goto IL_004a;
		IL_004a:
		num = -2123816916;
		goto IL_004f;
	}

	public string ToString(bool initial)
	{
		string text = default(string);
		int num5 = default(int);
		bool flag = default(bool);
		string result = default(string);
		while (true)
		{
			int num = -888421497;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xEC8852B6u) % 10u)
				{
				case 9u:
					text = "";
					num = ((int)num2 * -1854657050) ^ -1514305647;
					continue;
				case 6u:
					num5++;
					num = (int)((num2 * 1052376678) ^ 0x5E90D345);
					continue;
				case 5u:
					flag = num5 < _playerStates.Length;
					num = -1788008284;
					continue;
				case 4u:
					result = text;
					num = (int)(num2 * 113873064) ^ -1694102854;
					continue;
				case 3u:
					num5 = 0;
					num = (int)(num2 * 1643067858) ^ -1621345527;
					continue;
				case 2u:
				{
					string[] obj = new string[5]
					{
						text,
						num5.ToString(),
						": ",
						null,
						null
					};
					PlayerState obj2 = _playerStates[num5];
					obj[3] = ((obj2 != null) ? Game.smethod_5((object)obj2) : null);
					obj[4] = "\n";
					text = Game.smethod_6(obj);
					num = -661567240;
					continue;
				}
				case 1u:
					num = ((int)num2 * -934913083) ^ -2002360976;
					continue;
				case 0u:
				{
					int num3;
					int num4;
					if (flag)
					{
						num3 = 485572308;
						num4 = 485572308;
					}
					else
					{
						num3 = 1926361334;
						num4 = 1926361334;
					}
					num = num3 ^ ((int)num2 * -545906732);
					continue;
				}
				case 7u:
					break;
				default:
					return result;
				}
				break;
			}
		}
	}

	public override string ToString()
	{
		string result = default(string);
		while (true)
		{
			int num = 1439872427;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x46F328BCu) % 4u)
				{
				case 3u:
					result = ToString(initial: false);
					num = (int)(num2 * 825016378) ^ -1626542537;
					continue;
				case 1u:
					num = (int)((num2 * 1337174014) ^ 0x10938B78);
					continue;
				case 0u:
					break;
				default:
					return result;
				}
				break;
			}
		}
	}

	private void Print(object text, params object[] more)
	{
		string string_ = Game.smethod_7(Game.smethod_5(text), more);
		Game.smethod_8(_buffer, string_);
	}

	static Random smethod_0(int int_0)
	{
		return new Random(int_0);
	}

	static string smethod_1(string string_0, string string_1, string string_2)
	{
		return string_0 + string_1 + string_2;
	}

	static string smethod_2(string string_0, string string_1)
	{
		return string_0 + string_1;
	}

	static int smethod_3(int int_0, int int_1)
	{
		return Math.Max(int_0, int_1);
	}

	static int smethod_4(int int_0)
	{
		return Math.Abs(int_0);
	}

	static string smethod_5(object object_0)
	{
		return object_0.ToString();
	}

	static string smethod_6(string[] string_0)
	{
		return string.Concat(string_0);
	}

	static string smethod_7(string string_0, object[] object_0)
	{
		return string.Format(string_0, object_0);
	}

	static StringBuilder smethod_8(StringBuilder stringBuilder_0, string string_0)
	{
		return stringBuilder_0.AppendLine(string_0);
	}
}
