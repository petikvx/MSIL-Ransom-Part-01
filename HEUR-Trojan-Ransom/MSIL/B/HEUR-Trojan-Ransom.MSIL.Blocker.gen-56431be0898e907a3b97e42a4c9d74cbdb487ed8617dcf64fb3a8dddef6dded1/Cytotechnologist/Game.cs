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
			if (_finished)
			{
				goto IL_0106;
			}
			goto IL_0156;
			IL_0156:
			int num = -940171413;
			goto IL_010b;
			IL_010b:
			PlayerState playerState = default(PlayerState);
			PlayerState[] playerStates = default(PlayerState[]);
			int num3 = default(int);
			bool flag = default(bool);
			bool result = default(bool);
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x99C58F8Bu) % 14u)
				{
				case 13u:
					playerState = playerStates[num3];
					num = -1417330152;
					continue;
				case 12u:
					break;
				case 11u:
					flag = playerState.State == State.Playing;
					num = (int)((num2 * 787642259) ^ 0x17002273);
					continue;
				case 10u:
					result = true;
					num = (int)((num2 * 730902028) ^ 0x6B9ABEC);
					continue;
				case 8u:
					num3 = 0;
					num = (int)(num2 * 307835484) ^ -341770997;
					continue;
				case 7u:
					result = true;
					num = (int)((num2 * 2007227107) ^ 0x791F76D9);
					continue;
				case 5u:
				{
					int num4;
					int num5;
					if (!flag)
					{
						num4 = 1645684792;
						num5 = 1645684792;
					}
					else
					{
						num4 = 1831749941;
						num5 = 1831749941;
					}
					num = num4 ^ (int)(num2 * 804942128);
					continue;
				}
				case 4u:
					result = false;
					num = ((int)num2 * -13128662) ^ -1228939606;
					continue;
				case 3u:
					num = ((int)num2 * -1137460270) ^ 0x5FDDF458;
					continue;
				case 2u:
					playerStates = _playerStates;
					num = (int)(num2 * 2041340245) ^ -1107498199;
					continue;
				case 1u:
					num3++;
					num = -198964045;
					continue;
				case 0u:
					goto end_IL_010b;
				case 6u:
					goto IL_0156;
				default:
					return result;
				}
				int num6;
				if (num3 >= playerStates.Length)
				{
					num = -406339714;
					num6 = -406339714;
				}
				else
				{
					num = -238797544;
					num6 = -238797544;
				}
				continue;
				end_IL_010b:
				break;
			}
			goto IL_0106;
			IL_0106:
			num = -491303389;
			goto IL_010b;
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
		while (true)
		{
			int num = 1722627708;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x78561516u) % 8u)
				{
				case 7u:
					_currentTurn = 0;
					num = ((int)num2 * -722661987) ^ 0x24928778;
					continue;
				case 6u:
					Winners.Clear();
					Losers.Clear();
					num = ((int)num2 * -1574899528) ^ 0x7921E70E;
					continue;
				case 5u:
					_finished = false;
					num = ((int)num2 * -1012498170) ^ -1469344935;
					continue;
				case 2u:
					ShuffleCards();
					num = ((int)num2 * -516223601) ^ 0x23858CD6;
					continue;
				case 1u:
					_currentChanceIndex = -1;
					_chances = new List<float>(Rules.RiskChances);
					num = (int)(num2 * 1872232789) ^ -660972337;
					continue;
				case 0u:
					_currentPlayer = Players.Length;
					num = (int)((num2 * 793841227) ^ 0x58B744F1);
					continue;
				default:
					return;
				case 3u:
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
		int num5 = default(int);
		int planningCardsCount = default(int);
		Player player = default(Player);
		int num3 = default(int);
		while (true)
		{
			int num = 1836394219;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x4E74F758u) % 26u)
				{
				case 25u:
					playerState.Sprint = -1;
					playerState.Resources -= num5 * Rules.NormalPlanningCost;
					num = ((int)num2 * -811629823) ^ 0x730E56;
					continue;
				case 24u:
					num = (int)((num2 * 1815091084) ^ 0x15EB3302);
					continue;
				case 23u:
					num = 1078303138;
					continue;
				case 22u:
					playerState.Resources -= num5 * Rules.OverPlanningCost;
					num = (int)(num2 * 500969015) ^ -1437939290;
					continue;
				case 21u:
					num5 = 0;
					num = 337847897;
					continue;
				case 19u:
					num = 1822355207;
					continue;
				case 18u:
					num5 = 0;
					num = (int)(num2 * 1890224622) ^ -926341951;
					continue;
				case 17u:
					num = (int)(num2 * 591009064) ^ -915016735;
					continue;
				case 16u:
				{
					num5 = planningCardsCount - Rules.NormalPlanningCount;
					int num9;
					if (player.UseOneMorePlanningSprint)
					{
						num = 2036720450;
						num9 = 2036720450;
					}
					else
					{
						num = 1389626949;
						num9 = 1389626949;
					}
					continue;
				}
				case 15u:
				{
					int num8;
					if (num5 <= 0)
					{
						num = 88759929;
						num8 = 88759929;
					}
					else
					{
						num = 1534018280;
						num8 = 1534018280;
					}
					continue;
				}
				case 13u:
				{
					int num6;
					int num7;
					if (planningCardsCount == 0)
					{
						num6 = 1892176499;
						num7 = 1892176499;
					}
					else
					{
						num6 = 821984241;
						num7 = 821984241;
					}
					num = num6 ^ ((int)num2 * -1863782887);
					continue;
				}
				case 12u:
					playerState.Resources = Rules.InitialResources;
					num = (int)((num2 * 564367803) ^ 0x1FD7A7B7);
					continue;
				case 11u:
					playerState.Sprint = 0;
					num = ((int)num2 * -1518031300) ^ 0x119A2714;
					continue;
				case 10u:
					playerState.Resources -= (planningCardsCount - num5) * Rules.NormalPlanningCost;
					num3++;
					num = 397859588;
					continue;
				case 9u:
					playerState = _playerStates[num3];
					num = ((int)num2 * -414717078) ^ -817891567;
					continue;
				case 8u:
					num = (int)((num2 * 1539499326) ^ 0x66149D2C);
					continue;
				case 7u:
					player = Players[num3];
					num = (int)((num2 * 1580407750) ^ 0x283CB721);
					continue;
				case 6u:
					num = ((int)num2 * -1646879124) ^ 0x3CF49931;
					continue;
				case 5u:
					num3 = 0;
					num = (int)(num2 * 1872990097) ^ -1773597609;
					continue;
				case 4u:
					playerState.Sprint = 1;
					num = ((int)num2 * -1493835265) ^ 0x73CCF6E;
					continue;
				case 3u:
					playerState.State = State.Playing;
					num = ((int)num2 * -220418841) ^ 0x4DA849B4;
					continue;
				case 2u:
				{
					int num4;
					if (num3 >= Players.Length)
					{
						num = 720134854;
						num4 = 720134854;
					}
					else
					{
						num = 1937234951;
						num4 = 1937234951;
					}
					continue;
				}
				case 1u:
					planningCardsCount = player.PlanningCardsCount;
					num = ((int)num2 * -1725691235) ^ -1160158283;
					continue;
				case 0u:
					num = ((int)num2 * -1720198853) ^ 0x4B050183;
					continue;
				default:
					return;
				case 20u:
					break;
				case 14u:
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
			int num = 2064726885;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x2C1D3406u) % 19u)
				{
				case 18u:
					Print(Game.smethod_1("-- BEGINNING OF TURN ", (++_currentTurn).ToString(), " --"));
					num = 390304081;
					continue;
				case 17u:
					PlayerTurn(_currentPlayer);
					num = 307184906;
					continue;
				case 16u:
					num = (int)((num2 * 909670604) ^ 0x31EE43DD);
					continue;
				case 14u:
					Print("\n\nGAME STATE\n{0}\n\n-- END OF TURN {1} --\n\n", this, _currentTurn);
					num = (int)((num2 * 804040051) ^ 0x3EDDB3A4);
					continue;
				case 13u:
					_currentPlayer = 0;
					num = ((int)num2 * -1052423569) ^ -1762902508;
					continue;
				case 11u:
					num = (int)((num2 * 1959056614) ^ 0x493DD554);
					continue;
				case 10u:
					_currentPlayer++;
					num = (int)((num2 * 589710795) ^ 0x7345BF68);
					continue;
				case 9u:
					_currentChanceIndex = (_currentChanceIndex + 1) % _chances.Count;
					num = (int)((num2 * 2080541280) ^ 0x7875AC23);
					continue;
				case 8u:
					num = ((int)num2 * -1214413807) ^ -1771117323;
					continue;
				case 7u:
				{
					int num5;
					int num6;
					if (!flag)
					{
						num5 = 1142093960;
						num6 = 1142093960;
					}
					else
					{
						num5 = 1409458270;
						num6 = 1409458270;
					}
					num = num5 ^ ((int)num2 * -44789993);
					continue;
				}
				case 6u:
				{
					int num3;
					int num4;
					if (!flag2)
					{
						num3 = 436916363;
						num4 = 436916363;
					}
					else
					{
						num3 = 277829822;
						num4 = 277829822;
					}
					num = num3 ^ (int)(num2 * 1902288570);
					continue;
				}
				case 5u:
					flag2 = _currentTurn > 0;
					num = ((int)num2 * -1389631658) ^ -1137119125;
					continue;
				case 4u:
					num = (int)(num2 * 822045614) ^ -1118340029;
					continue;
				case 3u:
					num = (int)(num2 * 1271894150) ^ -1168021283;
					continue;
				case 2u:
					Print(Game.smethod_2("RISK CHANCE: ", Rules.RiskChances[_currentChanceIndex].ToString()));
					num = (int)((num2 * 1462500610) ^ 0x7B4DF528);
					continue;
				case 1u:
					flag = _currentPlayer >= Players.Length;
					num = ((int)num2 * -2072389253) ^ 0xFE4BC74;
					continue;
				case 0u:
					num = ((int)num2 * -607877004) ^ -1891278888;
					continue;
				default:
					return;
				case 12u:
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
		int num10 = default(int);
		bool flag8 = default(bool);
		bool flag5 = default(bool);
		bool flag12 = default(bool);
		bool flag = default(bool);
		int num11 = default(int);
		bool flag7 = default(bool);
		PlayerState playerState2 = default(PlayerState);
		bool flag13 = default(bool);
		PlayerState playerState = default(PlayerState);
		bool flag4 = default(bool);
		bool flag11 = default(bool);
		int num21 = default(int);
		Card card = default(Card);
		bool flag6 = default(bool);
		int num3 = default(int);
		Player player = default(Player);
		bool flag3 = default(bool);
		bool flag10 = default(bool);
		bool flag2 = default(bool);
		bool flag9 = default(bool);
		while (true)
		{
			int num = 1667445706;
			while (true)
			{
				uint num2;
				int num19;
				switch ((num2 = (uint)num ^ 0x4713EFC7u) % 94u)
				{
				case 93u:
					_finished = true;
					num10 = 0;
					num = ((int)num2 * -1833462574) ^ -1605344985;
					continue;
				case 92u:
					flag8 = !_dice.Roll(_chances[_currentChanceIndex]);
					num = 2126411529;
					continue;
				case 91u:
				{
					int num33;
					int num34;
					if (flag5)
					{
						num33 = 630414202;
						num34 = 630414202;
					}
					else
					{
						num33 = 421566883;
						num34 = 421566883;
					}
					num = num33 ^ (int)(num2 * 464191184);
					continue;
				}
				case 90u:
					num = ((int)num2 * -915021971) ^ -356006289;
					continue;
				case 89u:
					flag12 = flag;
					num = 729587606;
					continue;
				case 88u:
					Losers.Add(playerIndex);
					num = (int)((num2 * 1271824202) ^ 0x645E6C5);
					continue;
				case 87u:
					num11++;
					num = 1402872185;
					continue;
				case 85u:
					flag7 = playerState2.Sprint < 0;
					num = 1338957119;
					continue;
				case 84u:
				{
					int num14;
					if (Losers.Contains(num10))
					{
						num = 1482783146;
						num14 = 1482783146;
					}
					else
					{
						num = 1492315148;
						num14 = 1492315148;
					}
					continue;
				}
				case 83u:
					num = (int)(num2 * 1365370392) ^ -1063967039;
					continue;
				case 82u:
					num = ((int)num2 * -1254454000) ^ -1697249223;
					continue;
				case 81u:
					playerState2 = _playerStates[playerIndex];
					Print(Game.smethod_2("\nPLAYER ", playerIndex.ToString()));
					num = (int)((num2 * 461742734) ^ 0x5791C816);
					continue;
				case 80u:
					playerState2.Sprint++;
					num = ((int)num2 * -1231476168) ^ -1102638683;
					continue;
				case 79u:
					Losers.Add(num11);
					num = ((int)num2 * -1234062656) ^ -2053624141;
					continue;
				case 78u:
					Print(playerState2.State);
					num = ((int)num2 * -978802745) ^ -2099617945;
					continue;
				case 77u:
					Print("CARD: none, advance");
					num = ((int)num2 * -348238590) ^ 0x2DA93CC2;
					continue;
				case 76u:
					playerState2.Sprint++;
					num = ((int)num2 * -50053346) ^ 0xC63CF82;
					continue;
				case 75u:
				{
					int num29;
					int num30;
					if (!flag13)
					{
						num29 = 1736806890;
						num30 = 1736806890;
					}
					else
					{
						num29 = 1218259213;
						num30 = 1218259213;
					}
					num = num29 ^ ((int)num2 * -1546179173);
					continue;
				}
				case 74u:
					num = (int)((num2 * 2011491910) ^ 0x17F61B12);
					continue;
				case 73u:
					playerState = _playerStates[num11];
					num = 1013229881;
					continue;
				case 72u:
					num = (int)((num2 * 1282485699) ^ 0x8D262B7);
					continue;
				case 71u:
					flag4 = !flag11;
					num = (int)(num2 * 1448962181) ^ -1777974311;
					continue;
				case 70u:
					playerState.Resources -= Game.smethod_3(0, num21 - Players[num11].PlannedForCard(card.Type));
					num = ((int)num2 * -2020583115) ^ -218522354;
					continue;
				case 69u:
					num = ((int)num2 * -1723328831) ^ 0x1005DFA4;
					continue;
				case 68u:
					if (Rules.EconomicsAffectsAll)
					{
						num = ((int)num2 * -1317604641) ^ -1246471808;
						continue;
					}
					num19 = 0;
					goto IL_0309;
				case 67u:
					num10++;
					num = 1619868624;
					continue;
				case 66u:
					num = (int)((num2 * 1897958496) ^ 0x6CAE2898);
					continue;
				case 65u:
				{
					int num22;
					if (num10 >= _playerStates.Length)
					{
						num = 2131942859;
						num22 = 2131942859;
					}
					else
					{
						num = 1903150171;
						num22 = 1903150171;
					}
					continue;
				}
				case 64u:
					num = ((int)num2 * -1535085297) ^ -1190342113;
					continue;
				case 63u:
					playerState2.Resources -= num21;
					flag6 = playerState2.Resources < 0;
					num = (int)((num2 * 931464430) ^ 0x1164C34A);
					continue;
				case 62u:
					num = 1861641422;
					continue;
				case 61u:
					num3 = card.Impact - player.PlannedForCard(card.Type);
					num = ((int)num2 * -1640653691) ^ 0x67397358;
					continue;
				case 60u:
					flag = true;
					num = (int)(num2 * 1155625668) ^ -1905079783;
					continue;
				case 59u:
					num19 = ((card.Type == 4) ? 1 : 0);
					goto IL_0309;
				case 58u:
					num = 1511835203;
					continue;
				case 57u:
				{
					int num12;
					int num13;
					if (!flag6)
					{
						num12 = 228092562;
						num13 = 228092562;
					}
					else
					{
						num12 = 91659870;
						num13 = 91659870;
					}
					num = num12 ^ ((int)num2 * -273548939);
					continue;
				}
				case 56u:
				{
					playerState2.State = State.Lose;
					int num8;
					int num9;
					if (!Losers.Contains(playerIndex))
					{
						num8 = -1048210479;
						num9 = -1048210479;
					}
					else
					{
						num8 = -1834720810;
						num9 = -1834720810;
					}
					num = num8 ^ ((int)num2 * -851848684);
					continue;
				}
				case 55u:
					flag3 = card.Impact < 0;
					num = ((int)num2 * -1946445832) ^ -1845637895;
					continue;
				case 54u:
					num = ((int)num2 * -1179258136) ^ 0x6DDDAAA4;
					continue;
				case 53u:
				{
					int num35;
					int num36;
					if (!flag10)
					{
						num35 = 524133520;
						num36 = 524133520;
					}
					else
					{
						num35 = 1521174567;
						num36 = 1521174567;
					}
					num = num35 ^ (int)(num2 * 1792864543);
					continue;
				}
				case 52u:
					num11 = 0;
					num = (int)(num2 * 204303657) ^ -875496611;
					continue;
				case 51u:
				{
					int num31;
					int num32;
					if (Rules.OnlyOneWinner)
					{
						num31 = 214158379;
						num32 = 214158379;
					}
					else
					{
						num31 = 831665814;
						num32 = 831665814;
					}
					num = num31 ^ ((int)num2 * -1010791339);
					continue;
				}
				case 50u:
					flag13 = !flag3;
					num = (int)((num2 * 513836827) ^ 0x13CDE37C);
					continue;
				case 49u:
					num = ((int)num2 * -259401703) ^ -1363601665;
					continue;
				case 48u:
					num21 = card.Impact;
					num = ((int)num2 * -1189480274) ^ 0x172D9D97;
					continue;
				case 47u:
					player = Players[playerIndex];
					num = (int)(num2 * 204255616) ^ -325933198;
					continue;
				case 46u:
				{
					int num27;
					int num28;
					if (flag8)
					{
						num27 = 1147198701;
						num28 = 1147198701;
					}
					else
					{
						num27 = 427632575;
						num28 = 427632575;
					}
					num = num27 ^ ((int)num2 * -111864066);
					continue;
				}
				case 45u:
				{
					int num25;
					int num26;
					if (!flag2)
					{
						num25 = 1384876747;
						num26 = 1384876747;
					}
					else
					{
						num25 = 1335399781;
						num26 = 1335399781;
					}
					num = num25 ^ ((int)num2 * -171325601);
					continue;
				}
				case 44u:
					flag9 = num11 < _playerStates.Length;
					num = 1651592922;
					continue;
				case 43u:
					num = (int)(num2 * 272523049) ^ -623724692;
					continue;
				case 42u:
					num = ((int)num2 * -788414061) ^ -171235834;
					continue;
				case 41u:
				{
					int num23;
					int num24;
					if (flag12)
					{
						num23 = -1322558421;
						num24 = -1322558421;
					}
					else
					{
						num23 = -1991757963;
						num24 = -1991757963;
					}
					num = num23 ^ (int)(num2 * 510909936);
					continue;
				}
				case 40u:
					num = (int)(num2 * 1462307369) ^ -583060629;
					continue;
				case 39u:
					num = (int)((num2 * 2051683360) ^ 0x827CDCA);
					continue;
				case 38u:
					num = 979016551;
					continue;
				case 37u:
					Print("Still planning");
					num = ((int)num2 * -380414953) ^ 0x6CC57CC;
					continue;
				case 36u:
					Print("CARD: {0}, {1}{2} {3} and {4}", card, flag11 ? "ALL " : "", flag3 ? "receives" : "pays", Game.smethod_4(num21), flag ? "advance" : "stay");
					num = 443248782;
					continue;
				case 35u:
					flag10 = num10 == playerIndex;
					num = (int)(num2 * 1784426202) ^ -425066598;
					continue;
				case 34u:
					num = ((int)num2 * -1630497845) ^ 0x15F0668F;
					continue;
				case 33u:
					num21 = Game.smethod_3(0, num3);
					num = ((int)num2 * -756668730) ^ 0x24E56818;
					continue;
				case 32u:
				{
					int num20;
					if (playerState2.Sprint > Rules.SprintCount)
					{
						num = 1781098553;
						num20 = 1781098553;
					}
					else
					{
						num = 1160551371;
						num20 = 1160551371;
					}
					continue;
				}
				case 31u:
				{
					int num17;
					int num18;
					if (!flag9)
					{
						num17 = 1752943841;
						num18 = 1752943841;
					}
					else
					{
						num17 = 1039818035;
						num18 = 1039818035;
					}
					num = num17 ^ (int)(num2 * 1082684153);
					continue;
				}
				case 30u:
					num = 1989079688;
					continue;
				case 29u:
					playerState.State = State.Lose;
					num = 92480497;
					continue;
				case 28u:
				{
					int num15;
					int num16;
					if (flag7)
					{
						num15 = 1604253536;
						num16 = 1604253536;
					}
					else
					{
						num15 = 950929353;
						num16 = 950929353;
					}
					num = num15 ^ (int)(num2 * 1349367947);
					continue;
				}
				case 27u:
					flag = true;
					num = ((int)num2 * -954884229) ^ -24262023;
					continue;
				case 26u:
					num = 20894087;
					continue;
				case 25u:
					num = ((int)num2 * -1965546042) ^ -1173864382;
					continue;
				case 24u:
					num = 1672678428;
					continue;
				case 23u:
					flag = false;
					num = 1134153496;
					continue;
				case 22u:
					num = (int)(num2 * 135176160) ^ -591575551;
					continue;
				case 21u:
					num = ((int)num2 * -410969427) ^ -1195440628;
					continue;
				case 20u:
					playerState2.State = State.Won;
					num = ((int)num2 * -568846893) ^ 0x29F1AEFE;
					continue;
				case 19u:
					num = ((int)num2 * -701137616) ^ -2089122483;
					continue;
				case 18u:
					num = 1160551371;
					continue;
				case 17u:
					num = (int)(num2 * 191297668) ^ -243107039;
					continue;
				case 16u:
					num = (int)(num2 * 864307776) ^ -1548183135;
					continue;
				case 15u:
					num = 1318591850;
					continue;
				case 14u:
				{
					PlayerState playerState3 = playerState2;
					Print(Game.smethod_2("\t", (playerState3 != null) ? Game.smethod_5((object)playerState3) : null));
					num = 1714086021;
					continue;
				}
				case 13u:
					num = (int)((num2 * 964158680) ^ 0x460BBE34);
					continue;
				case 12u:
					flag5 = !Losers.Contains(num11);
					num = ((int)num2 * -825165519) ^ -1682728276;
					continue;
				case 11u:
					Winners.Add(playerIndex);
					num = ((int)num2 * -1388165801) ^ -765276793;
					continue;
				case 9u:
					num = (int)(num2 * 703883875) ^ -1167465967;
					continue;
				case 8u:
					num = (int)(num2 * 614701227) ^ -755795287;
					continue;
				case 7u:
					Losers.Add(num10);
					num = ((int)num2 * -1501563018) ^ 0x874E538;
					continue;
				case 6u:
					card = DrawCard();
					num = 1780450652;
					continue;
				case 5u:
				{
					int num6;
					int num7;
					if (!flag4)
					{
						num6 = 1023751399;
						num7 = 1023751399;
					}
					else
					{
						num6 = 1822871803;
						num7 = 1822871803;
					}
					num = num6 ^ (int)(num2 * 169003806);
					continue;
				}
				case 4u:
					num = ((int)num2 * -1002587795) ^ 0x1BEC2D20;
					continue;
				case 3u:
					num = ((int)num2 * -63686) ^ -1109344453;
					continue;
				case 2u:
				{
					int num4;
					int num5;
					if (playerState2.State == State.Playing)
					{
						num4 = 1446378248;
						num5 = 1446378248;
					}
					else
					{
						num4 = 1713032004;
						num5 = 1713032004;
					}
					num = num4 ^ (int)(num2 * 1603422665);
					continue;
				}
				case 1u:
					flag2 = playerState.Resources >= 0;
					num = (int)(num2 * 100287179) ^ -717562375;
					continue;
				case 0u:
					flag = num3 < Rules.StayOnSprintMinDiff;
					num = ((int)num2 * -1260425039) ^ 0x6C2CA5E2;
					continue;
				default:
					return;
				case 86u:
					break;
				case 10u:
					return;
					IL_0309:
					flag11 = (byte)num19 != 0;
					num = 575739441;
					continue;
				}
				break;
			}
		}
	}

	private Card DrawCard()
	{
		Card result = default(Card);
		Card card = default(Card);
		bool flag = default(bool);
		while (true)
		{
			int num = -1074024504;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xEE18BAF3u) % 10u)
				{
				case 9u:
					result = card;
					num = (int)(num2 * 2018628978) ^ -1567748023;
					continue;
				case 7u:
					num = ((int)num2 * -1651259546) ^ -316988766;
					continue;
				case 6u:
					num = ((int)num2 * -54986668) ^ -1691097023;
					continue;
				case 5u:
				{
					int num3;
					int num4;
					if (flag)
					{
						num3 = 343377757;
						num4 = 343377757;
					}
					else
					{
						num3 = 1384597415;
						num4 = 1384597415;
					}
					num = num3 ^ ((int)num2 * -1532881008);
					continue;
				}
				case 4u:
					ShuffleCards();
					num = (int)(num2 * 2130384531) ^ -1406880936;
					continue;
				case 3u:
					flag = _deck.Count <= 0;
					num = ((int)num2 * -1390830312) ^ 0x4219C996;
					continue;
				case 2u:
					card = _deck[0];
					_deck.RemoveAt(0);
					num = -1720914584;
					continue;
				case 1u:
					num = (int)(num2 * 1864747294) ^ -582214711;
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
		string text = "";
		int num = 0;
		string result = default(string);
		while (true)
		{
			bool flag = num < _playerStates.Length;
			int num2 = 235436214;
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)num2 ^ 0x504485D3u) % 8u)
				{
				case 7u:
					num2 = 151289698;
					continue;
				case 5u:
				{
					int num4;
					int num5;
					if (!flag)
					{
						num4 = -526963866;
						num5 = -526963866;
					}
					else
					{
						num4 = -697289180;
						num5 = -697289180;
					}
					num2 = num4 ^ ((int)num3 * -805193010);
					continue;
				}
				case 4u:
					num++;
					num2 = ((int)num3 * -1446802197) ^ 0x446FB439;
					continue;
				case 3u:
					result = text;
					num2 = (int)((num3 * 1958289728) ^ 0x2159CD71);
					continue;
				case 2u:
					num2 = ((int)num3 * -370900964) ^ -466485757;
					continue;
				case 1u:
				{
					string[] obj = new string[5]
					{
						text,
						num.ToString(),
						": ",
						null,
						null
					};
					PlayerState obj2 = _playerStates[num];
					obj[3] = ((obj2 != null) ? Game.smethod_5((object)obj2) : null);
					obj[4] = "\n";
					text = Game.smethod_6(obj);
					num2 = 1593627103;
					continue;
				}
				case 6u:
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
			int num = 981941228;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x3ADE10E8u) % 3u)
				{
				case 1u:
					goto IL_000f;
				default:
					return;
				case 0u:
					break;
				case 2u:
					return;
				}
				break;
				IL_000f:
				Game.smethod_8(_buffer, string_);
				num = ((int)num2 * -841333144) ^ 0x29E8F043;
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
