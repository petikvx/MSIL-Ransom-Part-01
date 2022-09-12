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
			int num3 = default(int);
			bool result = default(bool);
			PlayerState playerState = default(PlayerState);
			PlayerState[] playerStates = default(PlayerState[]);
			bool finished = default(bool);
			while (true)
			{
				int num = 773320696;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x11B6332Du) % 16u)
					{
					case 14u:
						num3 = 0;
						num = (int)(num2 * 1032763774) ^ -42665672;
						continue;
					case 13u:
						result = true;
						num = ((int)num2 * -1028182964) ^ -712255142;
						continue;
					case 12u:
						result = false;
						num = (int)(num2 * 195206464) ^ -1653436579;
						continue;
					case 11u:
						num = (int)((num2 * 16856966) ^ 0x405D5B4C);
						continue;
					case 10u:
					{
						int num5;
						int num6;
						if (playerState.State != 0)
						{
							num5 = -1993962962;
							num6 = -1993962962;
						}
						else
						{
							num5 = -506302293;
							num6 = -506302293;
						}
						num = num5 ^ ((int)num2 * -620571655);
						continue;
					}
					case 9u:
						num3++;
						num = 1894735260;
						continue;
					case 8u:
						result = true;
						num = ((int)num2 * -1521549036) ^ 0x6895A8EE;
						continue;
					case 7u:
						playerStates = _playerStates;
						num = (int)((num2 * 185990632) ^ 0x6786605B);
						continue;
					case 6u:
						num = 1907640170;
						continue;
					case 5u:
						finished = _finished;
						num = ((int)num2 * -47634935) ^ 0x1DE03E52;
						continue;
					case 4u:
						playerState = playerStates[num3];
						num = 349951703;
						continue;
					case 2u:
					{
						int num7;
						int num8;
						if (!finished)
						{
							num7 = 1391616815;
							num8 = 1391616815;
						}
						else
						{
							num7 = 1500677393;
							num8 = 1500677393;
						}
						num = num7 ^ (int)(num2 * 1345257658);
						continue;
					}
					case 1u:
					{
						int num4;
						if (num3 < playerStates.Length)
						{
							num = 1362864569;
							num4 = 1362864569;
						}
						else
						{
							num = 580983536;
							num4 = 580983536;
						}
						continue;
					}
					case 0u:
						num = (int)(num2 * 68585591) ^ -927739810;
						continue;
					case 15u:
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
		int num4 = default(int);
		int num3 = default(int);
		bool flag2 = default(bool);
		int count = default(int);
		JSONNode jSONNode = default(JSONNode);
		bool flag = default(bool);
		while (true)
		{
			int num = 2130821143;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x5EC0CBACu) % 17u)
				{
				case 16u:
					_buffer = buffer;
					_random = Game.smethod_0((int)DateTime.Now.Ticks);
					Rules = Rules.Deserialize(json["rules"]);
					num = ((int)num2 * -1606599217) ^ -304710018;
					continue;
				case 15u:
					num4++;
					num = (int)((num2 * 1542127599) ^ 0x25844AA7);
					continue;
				case 14u:
					num3++;
					num = ((int)num2 * -1233353120) ^ -2067855609;
					continue;
				case 13u:
					_dice = new Dice();
					num = (int)(num2 * 2026353378) ^ -581449109;
					continue;
				case 12u:
					flag2 = num3 < count;
					num = 831730068;
					continue;
				case 10u:
					Players = new Player[count];
					num4 = 0;
					num = ((int)num2 * -25239505) ^ -1246000977;
					continue;
				case 9u:
					num = (int)(num2 * 151029174) ^ -1140067793;
					continue;
				case 7u:
				{
					int num7;
					int num8;
					if (!flag2)
					{
						num7 = -1753037292;
						num8 = -1753037292;
					}
					else
					{
						num7 = -1533958978;
						num8 = -1533958978;
					}
					num = num7 ^ ((int)num2 * -2131807344);
					continue;
				}
				case 6u:
					Players[num4] = Player.Deserialize(jSONNode[num4]);
					num = 46290366;
					continue;
				case 5u:
					jSONNode = json["players"];
					count = jSONNode.Count;
					num = (int)(num2 * 1847488749) ^ -1972748221;
					continue;
				case 4u:
				{
					int num5;
					int num6;
					if (!flag)
					{
						num5 = -1488259396;
						num6 = -1488259396;
					}
					else
					{
						num5 = -393711395;
						num6 = -393711395;
					}
					num = num5 ^ (int)(num2 * 625422560);
					continue;
				}
				case 3u:
					flag = num4 < count;
					num = 689438599;
					continue;
				case 2u:
					_playerStates[num3] = new PlayerState();
					num = 270975882;
					continue;
				case 1u:
					num3 = 0;
					num = (int)(num2 * 880596436) ^ -1425298756;
					continue;
				case 0u:
					_playerStates = new PlayerState[count];
					num = ((int)num2 * -198033936) ^ -1850337461;
					continue;
				default:
					return;
				case 11u:
					break;
				case 8u:
					return;
				}
				break;
			}
		}
	}

	public void ShuffleCards()
	{
		while (true)
		{
			int num = -476738098;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xF18C79F7u) % 3u)
				{
				case 2u:
					goto IL_0003;
				default:
					return;
				case 0u:
					break;
				case 1u:
					return;
				}
				break;
				IL_0003:
				_deck = new List<Card>(Rules.Cards);
				num = (int)(num2 * 1587512438) ^ -551844165;
			}
		}
	}

	public void StartNew()
	{
		ShuffleCards();
		while (true)
		{
			int num = -1645630580;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x846C0500u) % 8u)
				{
				case 6u:
					Losers.Clear();
					num = (int)((num2 * 214930780) ^ 0x5C137562);
					continue;
				case 4u:
					Winners.Clear();
					num = ((int)num2 * -1049691605) ^ -475435539;
					continue;
				case 3u:
					_currentPlayer = Players.Length;
					_currentTurn = 0;
					_finished = false;
					num = ((int)num2 * -307141271) ^ -1731879941;
					continue;
				case 2u:
					num = (int)(num2 * 683081023) ^ -2085657003;
					continue;
				case 1u:
					num = (int)(num2 * 424223368) ^ -102753674;
					continue;
				case 0u:
					_currentChanceIndex = -1;
					num = ((int)num2 * -1656485462) ^ 0x3F8FD25;
					continue;
				case 7u:
					break;
				default:
					_chances = new List<float>(Rules.RiskChances);
					return;
				}
				break;
			}
		}
	}

	public void PlanningState()
	{
		int num3 = default(int);
		PlayerState playerState = default(PlayerState);
		bool flag2 = default(bool);
		int planningCardsCount = default(int);
		int num9 = default(int);
		Player player = default(Player);
		bool flag = default(bool);
		while (true)
		{
			int num = -515399539;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xAEDE2475u) % 23u)
				{
				case 22u:
				{
					int num6;
					if (num3 <= 0)
					{
						num = -534200598;
						num6 = -534200598;
					}
					else
					{
						num = -414459339;
						num6 = -414459339;
					}
					continue;
				}
				case 21u:
					playerState.Resources -= num3 * Rules.OverPlanningCost;
					num = ((int)num2 * -736569531) ^ 0x3301D48;
					continue;
				case 20u:
					num = ((int)num2 * -1734392077) ^ 0x57DACB5;
					continue;
				case 19u:
					num3 = 0;
					num = -1255173614;
					continue;
				case 18u:
					num3 = 0;
					flag2 = planningCardsCount == 0;
					num = (int)(num2 * 1481728303) ^ -2138779470;
					continue;
				case 17u:
					num9++;
					num = (int)(num2 * 1416058149) ^ -1616840208;
					continue;
				case 15u:
				{
					num3 = planningCardsCount - Rules.NormalPlanningCount;
					int num10;
					int num11;
					if (!player.UseOneMorePlanningSprint)
					{
						num10 = -946280929;
						num11 = -946280929;
					}
					else
					{
						num10 = -1401902943;
						num11 = -1401902943;
					}
					num = num10 ^ ((int)num2 * -717795574);
					continue;
				}
				case 14u:
					num9 = 0;
					num = (int)((num2 * 2017288055) ^ 0xCD764B);
					continue;
				case 13u:
					num = (int)(num2 * 779006926) ^ -1282435310;
					continue;
				case 12u:
					planningCardsCount = player.PlanningCardsCount;
					num = (int)((num2 * 663612082) ^ 0x357CE672);
					continue;
				case 11u:
					num = -1413340115;
					continue;
				case 10u:
					num = (int)(num2 * 1304675727) ^ -348693822;
					continue;
				case 9u:
					playerState.Sprint = 0;
					playerState.Resources = Rules.InitialResources;
					playerState.State = State.Playing;
					num = (int)((num2 * 1122336404) ^ 0x1BE84D3D);
					continue;
				case 8u:
					flag = num9 < Players.Length;
					num = -2505280;
					continue;
				case 7u:
					playerState.Sprint = -1;
					playerState.Resources -= num3 * Rules.NormalPlanningCost;
					num = (int)((num2 * 189493571) ^ 0x190FE19);
					continue;
				case 6u:
					playerState.Sprint = 1;
					num = ((int)num2 * -1956751016) ^ -84560663;
					continue;
				case 5u:
					num = -1286992303;
					continue;
				case 4u:
					player = Players[num9];
					playerState = _playerStates[num9];
					num = -1754015931;
					continue;
				case 2u:
				{
					int num7;
					int num8;
					if (!flag2)
					{
						num7 = 1292256275;
						num8 = 1292256275;
					}
					else
					{
						num7 = 1532736110;
						num8 = 1532736110;
					}
					num = num7 ^ ((int)num2 * -768051471);
					continue;
				}
				case 1u:
				{
					int num4;
					int num5;
					if (!flag)
					{
						num4 = 2032039234;
						num5 = 2032039234;
					}
					else
					{
						num4 = 1112193412;
						num5 = 1112193412;
					}
					num = num4 ^ (int)(num2 * 2134487859);
					continue;
				}
				case 0u:
					playerState.Resources -= (planningCardsCount - num3) * Rules.NormalPlanningCost;
					num = -2123693427;
					continue;
				default:
					return;
				case 3u:
					break;
				case 16u:
					return;
				}
				break;
			}
		}
	}

	public void TurnState()
	{
		bool flag = default(bool);
		bool flag2 = default(bool);
		while (true)
		{
			int num = 2017186330;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x5EB3988Eu) % 13u)
				{
				case 12u:
					_currentPlayer++;
					flag = _currentPlayer >= Players.Length;
					num = ((int)num2 * -931323437) ^ 0x75DF55ED;
					continue;
				case 11u:
					_currentChanceIndex = (_currentChanceIndex + 1) % _chances.Count;
					Print(Game.smethod_2("RISK CHANCE: ", Rules.RiskChances[_currentChanceIndex].ToString()));
					num = (int)((num2 * 433422482) ^ 0x673A1A38);
					continue;
				case 10u:
					_currentPlayer = 0;
					flag2 = _currentTurn > 0;
					num = ((int)num2 * -514040940) ^ 0x567D5DA6;
					continue;
				case 9u:
				{
					int num5;
					int num6;
					if (flag2)
					{
						num5 = 107034410;
						num6 = 107034410;
					}
					else
					{
						num5 = 1973370563;
						num6 = 1973370563;
					}
					num = num5 ^ (int)(num2 * 1467453669);
					continue;
				}
				case 8u:
					Print(Game.smethod_1("-- BEGINNING OF TURN ", (++_currentTurn).ToString(), " --"));
					num = 587158419;
					continue;
				case 6u:
				{
					int num3;
					int num4;
					if (flag)
					{
						num3 = 301136579;
						num4 = 301136579;
					}
					else
					{
						num3 = 1484832549;
						num4 = 1484832549;
					}
					num = num3 ^ (int)(num2 * 799054682);
					continue;
				}
				case 4u:
					PlayerTurn(_currentPlayer);
					num = 612225610;
					continue;
				case 3u:
					num = ((int)num2 * -2124817518) ^ 0x191BCFF5;
					continue;
				case 2u:
					Print("\n\nGAME STATE\n{0}\n\n-- END OF TURN {1} --\n\n", this, _currentTurn);
					num = (int)((num2 * 2097359046) ^ 0x85881C7);
					continue;
				case 1u:
					num = ((int)num2 * -326402346) ^ 0x11A9FD05;
					continue;
				case 0u:
					num = ((int)num2 * -624178630) ^ 0x7BCAEAFF;
					continue;
				default:
					return;
				case 5u:
					break;
				case 7u:
					return;
				}
				break;
			}
		}
	}

	private void PlayerTurn(int playerIndex)
	{
		int num8 = default(int);
		Card card = default(Card);
		bool flag4 = default(bool);
		bool flag5 = default(bool);
		int num11 = default(int);
		bool flag2 = default(bool);
		bool flag11 = default(bool);
		PlayerState playerState3 = default(PlayerState);
		bool flag7 = default(bool);
		bool flag = default(bool);
		PlayerState playerState = default(PlayerState);
		bool flag3 = default(bool);
		int num3 = default(int);
		bool flag10 = default(bool);
		bool flag8 = default(bool);
		bool flag9 = default(bool);
		bool flag6 = default(bool);
		int num10 = default(int);
		Player player = default(Player);
		while (true)
		{
			int num = 1217956529;
			while (true)
			{
				uint num2;
				int num14;
				switch ((num2 = (uint)num ^ 0x3A549B69u) % 81u)
				{
				case 80u:
					num = 412217615;
					continue;
				case 79u:
					num = ((int)num2 * -785841783) ^ 0x4710070B;
					continue;
				case 78u:
					Losers.Add(num8);
					num = (int)(num2 * 1641479203) ^ -1576010946;
					continue;
				case 77u:
					Losers.Add(playerIndex);
					num = (int)((num2 * 981195157) ^ 0x6B3B6BE2);
					continue;
				case 76u:
					num = (int)((num2 * 105798662) ^ 0x3DE09B8);
					continue;
				case 75u:
					Print("CARD: {0}, {1}{2} {3} and {4}", card, flag4 ? "ALL " : "", flag5 ? "receives" : "pays", Game.smethod_4(num11), flag2 ? "advance" : "stay");
					num = 1479070657;
					continue;
				case 74u:
					num = ((int)num2 * -1257810641) ^ -2093866374;
					continue;
				case 73u:
					flag11 = playerState3.Resources >= 0;
					num = (int)((num2 * 789999989) ^ 0x48C5B48);
					continue;
				case 72u:
					Print("CARD: none, advance");
					num = (int)(num2 * 974026928) ^ -46762153;
					continue;
				case 71u:
					num = 435873601;
					continue;
				case 70u:
					flag7 = num8 == playerIndex;
					num = (int)(num2 * 1932070715) ^ -489749768;
					continue;
				case 69u:
				{
					int num9;
					if (num8 >= _playerStates.Length)
					{
						num = 575508305;
						num9 = 575508305;
					}
					else
					{
						num = 181301844;
						num9 = 181301844;
					}
					continue;
				}
				case 68u:
					flag = playerState.Sprint > Rules.SprintCount;
					num = 1309139274;
					continue;
				case 67u:
					num = (int)(num2 * 159702042) ^ -2050551035;
					continue;
				case 66u:
					num = ((int)num2 * -865550354) ^ 0x6153514F;
					continue;
				case 65u:
					num = ((int)num2 * -1983440194) ^ 0x5127C7A1;
					continue;
				case 64u:
					flag3 = !_dice.Roll(_chances[_currentChanceIndex]);
					num = 1132116515;
					continue;
				case 63u:
					Losers.Add(num3);
					num = ((int)num2 * -1073576921) ^ 0x5E3B4289;
					continue;
				case 62u:
					num = ((int)num2 * -1373751892) ^ 0x267C004;
					continue;
				case 61u:
					num3++;
					num = 336558885;
					continue;
				case 60u:
				{
					int num29;
					int num30;
					if (flag11)
					{
						num29 = -827622704;
						num30 = -827622704;
					}
					else
					{
						num29 = -543282026;
						num30 = -543282026;
					}
					num = num29 ^ ((int)num2 * -1983640612);
					continue;
				}
				case 59u:
					playerState3 = _playerStates[num3];
					playerState3.Resources -= Game.smethod_3(0, num11 - Players[num3].PlannedForCard(card.Type));
					num = 820291914;
					continue;
				case 58u:
				{
					int num24;
					int num25;
					if (!flag10)
					{
						num24 = 1694633831;
						num25 = 1694633831;
					}
					else
					{
						num24 = 1835791149;
						num25 = 1835791149;
					}
					num = num24 ^ (int)(num2 * 879437470);
					continue;
				}
				case 57u:
					flag5 = card.Impact < 0;
					num = ((int)num2 * -206297673) ^ 0x49F31D0;
					continue;
				case 56u:
				{
					int num19;
					int num20;
					if (flag8)
					{
						num19 = -160958621;
						num20 = -160958621;
					}
					else
					{
						num19 = -280968348;
						num20 = -280968348;
					}
					num = num19 ^ ((int)num2 * -1447253922);
					continue;
				}
				case 55u:
					num = ((int)num2 * -1151831593) ^ -719548393;
					continue;
				case 54u:
					num8 = 0;
					num = ((int)num2 * -1866199247) ^ -1386908696;
					continue;
				case 53u:
					playerState.Sprint++;
					Print("Still planning");
					num = ((int)num2 * -216093419) ^ -200547242;
					continue;
				case 52u:
					num = ((int)num2 * -213052107) ^ 0x34D2FFF9;
					continue;
				case 51u:
					num14 = ((card.Type == 4) ? 1 : 0);
					goto IL_039b;
				case 50u:
					num = 478020335;
					continue;
				case 49u:
				{
					PlayerState playerState2 = playerState;
					Print(Game.smethod_2("\t", (playerState2 != null) ? Game.smethod_5((object)playerState2) : null));
					num = 1436326505;
					continue;
				}
				case 48u:
					if (Rules.EconomicsAffectsAll)
					{
						num = ((int)num2 * -350192490) ^ -969372223;
						continue;
					}
					num14 = 0;
					goto IL_039b;
				case 46u:
					flag2 = false;
					num = 1430291347;
					continue;
				case 45u:
				{
					playerState.State = State.Lose;
					int num34;
					int num35;
					if (!Losers.Contains(playerIndex))
					{
						num34 = 1121633988;
						num35 = 1121633988;
					}
					else
					{
						num34 = 236073864;
						num35 = 236073864;
					}
					num = num34 ^ ((int)num2 * -1240492247);
					continue;
				}
				case 44u:
					num = (int)((num2 * 1775523787) ^ 0x68A5D16D);
					continue;
				case 43u:
					flag2 = true;
					num11 = card.Impact;
					num = (int)(num2 * 1694496937) ^ -1039322139;
					continue;
				case 42u:
					num = ((int)num2 * -1180846429) ^ -990690504;
					continue;
				case 41u:
				{
					int num32;
					int num33;
					if (flag)
					{
						num32 = 1537597857;
						num33 = 1537597857;
					}
					else
					{
						num32 = 1783063326;
						num33 = 1783063326;
					}
					num = num32 ^ ((int)num2 * -650426777);
					continue;
				}
				case 40u:
				{
					int num31;
					if (!flag2)
					{
						num = 1226288071;
						num31 = 1226288071;
					}
					else
					{
						num = 2008220335;
						num31 = 2008220335;
					}
					continue;
				}
				case 39u:
					num = (int)(num2 * 1766693921) ^ -1050617868;
					continue;
				case 38u:
					playerState.Sprint++;
					num = ((int)num2 * -975638592) ^ -1975220921;
					continue;
				case 37u:
					_finished = true;
					num = ((int)num2 * -824897431) ^ -2145295488;
					continue;
				case 36u:
				{
					int num27;
					int num28;
					if (!flag4)
					{
						num27 = 1906909610;
						num28 = 1906909610;
					}
					else
					{
						num27 = 1007637936;
						num28 = 1007637936;
					}
					num = num27 ^ (int)(num2 * 337430242);
					continue;
				}
				case 35u:
					flag10 = num3 < _playerStates.Length;
					num = 1296213096;
					continue;
				case 34u:
					num = ((int)num2 * -91161493) ^ 0x5230F97F;
					continue;
				case 33u:
					Print(playerState.State);
					num = (int)((num2 * 1562758159) ^ 0x42714FF7);
					continue;
				case 32u:
					flag2 = true;
					num = (int)((num2 * 1997858446) ^ 0x71045ABE);
					continue;
				case 31u:
					num = 1117877805;
					continue;
				case 30u:
					num = 2117524686;
					continue;
				case 29u:
				{
					int num26;
					if (!Losers.Contains(num8))
					{
						num = 740001570;
						num26 = 740001570;
					}
					else
					{
						num = 2048547086;
						num26 = 2048547086;
					}
					continue;
				}
				case 28u:
					num3 = 0;
					num = 981756369;
					continue;
				case 27u:
					num8++;
					num = 403628085;
					continue;
				case 26u:
					num = (int)((num2 * 1907832577) ^ 0xCC9E1E8);
					continue;
				case 25u:
					playerState.State = State.Won;
					num = (int)((num2 * 1531143904) ^ 0x36F1EE58);
					continue;
				case 24u:
					num = (int)(num2 * 1790139513) ^ -127923544;
					continue;
				case 23u:
					playerState = _playerStates[playerIndex];
					num = (int)(num2 * 1287142029) ^ -618323276;
					continue;
				case 22u:
					card = DrawCard();
					num = 39264004;
					continue;
				case 21u:
					playerState.Resources -= num11;
					flag9 = playerState.Resources < 0;
					num = (int)(num2 * 1117744384) ^ -761646645;
					continue;
				case 20u:
					num = ((int)num2 * -1796430046) ^ 0x4598E5E3;
					continue;
				case 19u:
				{
					int num22;
					int num23;
					if (!flag9)
					{
						num22 = -248441373;
						num23 = -248441373;
					}
					else
					{
						num22 = -692945619;
						num23 = -692945619;
					}
					num = num22 ^ (int)(num2 * 2006947256);
					continue;
				}
				case 18u:
				{
					int num21;
					if (playerState.Sprint < 0)
					{
						num = 1118980030;
						num21 = 1118980030;
					}
					else
					{
						num = 911136020;
						num21 = 911136020;
					}
					continue;
				}
				case 17u:
				{
					int num17;
					int num18;
					if (flag6)
					{
						num17 = 398652906;
						num18 = 398652906;
					}
					else
					{
						num17 = 1270443408;
						num18 = 1270443408;
					}
					num = num17 ^ (int)(num2 * 782087978);
					continue;
				}
				case 16u:
					Winners.Add(playerIndex);
					num = (int)((num2 * 1805052413) ^ 0x771C7C02);
					continue;
				case 15u:
					flag8 = playerState.State != State.Playing;
					num = (int)(num2 * 1220737514) ^ -1031168334;
					continue;
				case 14u:
					num = (int)(num2 * 414666273) ^ -1130065448;
					continue;
				case 13u:
				{
					int num15;
					int num16;
					if (flag7)
					{
						num15 = 1946338081;
						num16 = 1946338081;
					}
					else
					{
						num15 = 1660955999;
						num16 = 1660955999;
					}
					num = num15 ^ (int)(num2 * 316795342);
					continue;
				}
				case 11u:
					Print(Game.smethod_2("\nPLAYER ", playerIndex.ToString()));
					num = ((int)num2 * -118232904) ^ -77560227;
					continue;
				case 10u:
				{
					int num12;
					int num13;
					if (flag3)
					{
						num12 = 711039255;
						num13 = 711039255;
					}
					else
					{
						num12 = 972170500;
						num13 = 972170500;
					}
					num = num12 ^ ((int)num2 * -2140536850);
					continue;
				}
				case 9u:
					num10 = card.Impact - player.PlannedForCard(card.Type);
					num = (int)((num2 * 1677918042) ^ 0x5606E98B);
					continue;
				case 8u:
					player = Players[playerIndex];
					num = ((int)num2 * -1798678090) ^ -659031526;
					continue;
				case 7u:
					num = ((int)num2 * -1772215420) ^ -126667323;
					continue;
				case 6u:
					playerState3.State = State.Lose;
					num = 93740954;
					continue;
				case 5u:
					flag2 = num10 < Rules.StayOnSprintMinDiff;
					num11 = Game.smethod_3(0, num10);
					num = ((int)num2 * -991198163) ^ 0x578D760D;
					continue;
				case 4u:
					num = 1938278086;
					continue;
				case 3u:
					num = 407622923;
					continue;
				case 2u:
					num = (int)(num2 * 2080295414) ^ -224062184;
					continue;
				case 1u:
				{
					int num6;
					int num7;
					if (!Rules.OnlyOneWinner)
					{
						num6 = -356026388;
						num7 = -356026388;
					}
					else
					{
						num6 = -446688403;
						num7 = -446688403;
					}
					num = num6 ^ ((int)num2 * -553452250);
					continue;
				}
				case 0u:
				{
					int num4;
					int num5;
					if (!Losers.Contains(num3))
					{
						num4 = -421454054;
						num5 = -421454054;
					}
					else
					{
						num4 = -2076748474;
						num5 = -2076748474;
					}
					num = num4 ^ (int)(num2 * 224524962);
					continue;
				}
				default:
					return;
				case 47u:
					break;
				case 12u:
					return;
					IL_039b:
					flag4 = (byte)num14 != 0;
					flag6 = !flag5;
					num = 831782575;
					continue;
				}
				break;
			}
		}
	}

	private Card DrawCard()
	{
		Card card = default(Card);
		bool flag = default(bool);
		Card result = default(Card);
		while (true)
		{
			int num = 700257847;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x35EB001Bu) % 9u)
				{
				case 8u:
					card = _deck[0];
					num = 1806206711;
					continue;
				case 7u:
					num = (int)(num2 * 636435999) ^ -1663423040;
					continue;
				case 6u:
					flag = _deck.Count <= 0;
					num = (int)(num2 * 2133913465) ^ -942687718;
					continue;
				case 5u:
					result = card;
					num = (int)((num2 * 841732266) ^ 0x1652DA51);
					continue;
				case 4u:
				{
					int num3;
					int num4;
					if (flag)
					{
						num3 = -1729766264;
						num4 = -1729766264;
					}
					else
					{
						num3 = -1081965377;
						num4 = -1081965377;
					}
					num = num3 ^ ((int)num2 * -545821876);
					continue;
				}
				case 3u:
					_deck.RemoveAt(0);
					num = ((int)num2 * -520948511) ^ 0xB09E22B;
					continue;
				case 1u:
					ShuffleCards();
					num = ((int)num2 * -572702014) ^ 0x271538BD;
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

	public string ToString(bool initial)
	{
		bool flag = default(bool);
		int num3 = default(int);
		string result = default(string);
		string text = default(string);
		while (true)
		{
			int num = 785799441;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x31324488u) % 10u)
				{
				case 9u:
					num = (int)(num2 * 497342031) ^ -901764265;
					continue;
				case 8u:
				{
					int num4;
					int num5;
					if (!flag)
					{
						num4 = 1395468923;
						num5 = 1395468923;
					}
					else
					{
						num4 = 1866056172;
						num5 = 1866056172;
					}
					num = num4 ^ ((int)num2 * -1216694509);
					continue;
				}
				case 7u:
					num3++;
					num = ((int)num2 * -792518365) ^ 0x14239479;
					continue;
				case 6u:
					num3 = 0;
					num = ((int)num2 * -1956038836) ^ -845923775;
					continue;
				case 5u:
					result = text;
					num = ((int)num2 * -594651016) ^ 0x2A239DFC;
					continue;
				case 4u:
				{
					string[] obj = new string[5]
					{
						text,
						num3.ToString(),
						": ",
						null,
						null
					};
					PlayerState obj2 = _playerStates[num3];
					obj[3] = ((obj2 != null) ? Game.smethod_5((object)obj2) : null);
					obj[4] = "\n";
					text = Game.smethod_6(obj);
					num = 1711091035;
					continue;
				}
				case 1u:
					text = "";
					num = ((int)num2 * -2126952165) ^ 0x1D660187;
					continue;
				case 0u:
					flag = num3 < _playerStates.Length;
					num = 328713512;
					continue;
				case 3u:
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
		return ToString(initial: false);
	}

	private void Print(object text, params object[] more)
	{
		string string_ = Game.smethod_7(Game.smethod_5(text), more);
		while (true)
		{
			int num = -652404946;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xA60F00C2u) % 3u)
				{
				case 2u:
					goto IL_000f;
				default:
					return;
				case 0u:
					break;
				case 1u:
					return;
				}
				break;
				IL_000f:
				Game.smethod_8(_buffer, string_);
				num = (int)((num2 * 162705088) ^ 0x6EEEEA51);
			}
		}
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
