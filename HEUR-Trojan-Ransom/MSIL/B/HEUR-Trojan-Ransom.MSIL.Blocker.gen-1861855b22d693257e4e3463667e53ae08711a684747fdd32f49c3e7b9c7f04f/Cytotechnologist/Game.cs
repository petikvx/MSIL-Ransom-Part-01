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
			bool finished = _finished;
			int num3 = default(int);
			PlayerState[] playerStates = default(PlayerState[]);
			bool flag = default(bool);
			bool result = default(bool);
			while (true)
			{
				int num = 1340824488;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x6EA2714Eu) % 16u)
					{
					case 15u:
						num = (int)(num2 * 1059523338) ^ -643825134;
						continue;
					case 14u:
						num = ((int)num2 * -212791953) ^ 0x1D2ABCA4;
						continue;
					case 13u:
						num3++;
						num = 1943870148;
						continue;
					case 11u:
						num3 = 0;
						num = ((int)num2 * -1089418217) ^ -511065620;
						continue;
					case 10u:
					{
						int num6;
						if (num3 >= playerStates.Length)
						{
							num = 207679455;
							num6 = 207679455;
						}
						else
						{
							num = 1818235147;
							num6 = 1818235147;
						}
						continue;
					}
					case 9u:
					{
						int num7;
						int num8;
						if (flag)
						{
							num7 = 1165031276;
							num8 = 1165031276;
						}
						else
						{
							num7 = 823817478;
							num8 = 823817478;
						}
						num = num7 ^ (int)(num2 * 238568813);
						continue;
					}
					case 7u:
						result = false;
						num = ((int)num2 * -1928950085) ^ -201361715;
						continue;
					case 6u:
					{
						int num4;
						int num5;
						if (finished)
						{
							num4 = -683463517;
							num5 = -683463517;
						}
						else
						{
							num4 = -1025038924;
							num5 = -1025038924;
						}
						num = num4 ^ (int)(num2 * 1646207949);
						continue;
					}
					case 5u:
					{
						PlayerState playerState = playerStates[num3];
						flag = playerState.State == State.Playing;
						num = 1130494103;
						continue;
					}
					case 4u:
						num = 1653666332;
						continue;
					case 3u:
						result = true;
						num = ((int)num2 * -662482395) ^ 0x4254FD01;
						continue;
					case 2u:
						playerStates = _playerStates;
						num = ((int)num2 * -624027362) ^ -859678423;
						continue;
					case 1u:
						result = true;
						num = (int)(num2 * 1221770790) ^ -1603624992;
						continue;
					case 0u:
						num = (int)(num2 * 1301103077) ^ -1154009978;
						continue;
					case 12u:
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
		while (true)
		{
			int num = -1552611648;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xB3E68B74u) % 8u)
				{
				case 6u:
					num = ((int)num2 * -979909022) ^ -1006177966;
					continue;
				case 5u:
					_currentTurn = 0;
					_finished = false;
					num = (int)(num2 * 1017159603) ^ -807029870;
					continue;
				case 4u:
					ShuffleCards();
					num = ((int)num2 * -1481296100) ^ -1228076598;
					continue;
				case 3u:
					Losers.Clear();
					_currentPlayer = Players.Length;
					num = ((int)num2 * -1283939694) ^ 0x53D412FF;
					continue;
				case 2u:
					Winners.Clear();
					num = (int)((num2 * 1630114918) ^ 0x51507533);
					continue;
				case 1u:
					_currentChanceIndex = -1;
					_chances = new List<float>(Rules.RiskChances);
					num = ((int)num2 * -380288533) ^ -1034539097;
					continue;
				default:
					return;
				case 7u:
					break;
				case 0u:
					return;
				}
				break;
			}
		}
	}

	public void PlanningState()
	{
		int num8 = default(int);
		PlayerState playerState = default(PlayerState);
		bool flag3 = default(bool);
		int num7 = default(int);
		bool flag = default(bool);
		bool flag2 = default(bool);
		int planningCardsCount = default(int);
		Player player = default(Player);
		bool useOneMorePlanningSprint = default(bool);
		while (true)
		{
			int num = -246560045;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xA017CABBu) % 29u)
				{
				case 27u:
					num8 = 0;
					num = -1710360779;
					continue;
				case 26u:
					playerState.Sprint = -1;
					playerState.Resources -= num8 * Rules.NormalPlanningCost;
					num = (int)(num2 * 2031249699) ^ -26640169;
					continue;
				case 25u:
					num = ((int)num2 * -1105169613) ^ -2088946564;
					continue;
				case 24u:
					flag3 = num7 < Players.Length;
					num = -1891458535;
					continue;
				case 23u:
					num = -446990099;
					continue;
				case 22u:
					playerState.Resources -= num8 * Rules.OverPlanningCost;
					num = ((int)num2 * -1111702624) ^ 0x78034A55;
					continue;
				case 21u:
				{
					int num5;
					int num6;
					if (!flag)
					{
						num5 = -267052809;
						num6 = -267052809;
					}
					else
					{
						num5 = -243662218;
						num6 = -243662218;
					}
					num = num5 ^ (int)(num2 * 1248221082);
					continue;
				}
				case 20u:
					playerState.State = State.Playing;
					num = (int)(num2 * 380234994) ^ -182766036;
					continue;
				case 19u:
					playerState.Sprint = 1;
					num = (int)((num2 * 1040081644) ^ 0x4EBB3775);
					continue;
				case 18u:
					flag = num8 > 0;
					num = -488202190;
					continue;
				case 17u:
					num = (int)((num2 * 1166961303) ^ 0x6660966D);
					continue;
				case 16u:
					playerState.Sprint = 0;
					playerState.Resources = Rules.InitialResources;
					num = (int)(num2 * 745880867) ^ -1895068727;
					continue;
				case 15u:
					playerState = _playerStates[num7];
					num = ((int)num2 * -820263378) ^ 0x1DBC1F65;
					continue;
				case 14u:
					num = (int)((num2 * 1660070416) ^ 0x16D74D43);
					continue;
				case 13u:
					num7++;
					num = ((int)num2 * -2037101136) ^ -1718891120;
					continue;
				case 12u:
				{
					int num11;
					int num12;
					if (!flag2)
					{
						num11 = 183293232;
						num12 = 183293232;
					}
					else
					{
						num11 = 1314683257;
						num12 = 1314683257;
					}
					num = num11 ^ (int)(num2 * 1884922485);
					continue;
				}
				case 11u:
					playerState.Resources -= (planningCardsCount - num8) * Rules.NormalPlanningCost;
					num = -503414481;
					continue;
				case 10u:
				{
					int num9;
					int num10;
					if (!flag3)
					{
						num9 = 1982320244;
						num10 = 1982320244;
					}
					else
					{
						num9 = 452486085;
						num10 = 452486085;
					}
					num = num9 ^ ((int)num2 * -1433155835);
					continue;
				}
				case 9u:
					num = ((int)num2 * -152682339) ^ -666973440;
					continue;
				case 8u:
					player = Players[num7];
					num = ((int)num2 * -401071746) ^ 0x438BE306;
					continue;
				case 7u:
					num8 = 0;
					flag2 = planningCardsCount == 0;
					num = (int)((num2 * 1257679174) ^ 0x3E8CBC73);
					continue;
				case 6u:
					num = -841030630;
					continue;
				case 4u:
					planningCardsCount = player.PlanningCardsCount;
					num = ((int)num2 * -1444538158) ^ -234810151;
					continue;
				case 3u:
					num = -1080005324;
					continue;
				case 2u:
					num8 = planningCardsCount - Rules.NormalPlanningCount;
					useOneMorePlanningSprint = player.UseOneMorePlanningSprint;
					num = ((int)num2 * -1891769918) ^ -1097529862;
					continue;
				case 1u:
					num7 = 0;
					num = ((int)num2 * -141960617) ^ 0x49450158;
					continue;
				case 0u:
				{
					int num3;
					int num4;
					if (!useOneMorePlanningSprint)
					{
						num3 = -1082816966;
						num4 = -1082816966;
					}
					else
					{
						num3 = -205941269;
						num4 = -205941269;
					}
					num = num3 ^ ((int)num2 * -1682775788);
					continue;
				}
				default:
					return;
				case 28u:
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
		while (true)
		{
			int num = 68191961;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x49E738B1u) % 13u)
				{
				case 12u:
				{
					int num5;
					int num6;
					if (_currentPlayer < Players.Length)
					{
						num5 = 1097533770;
						num6 = 1097533770;
					}
					else
					{
						num5 = 727629641;
						num6 = 727629641;
					}
					num = num5 ^ (int)(num2 * 68616881);
					continue;
				}
				case 11u:
					num = (int)((num2 * 1440578580) ^ 0x96231DD);
					continue;
				case 10u:
				{
					_currentPlayer = 0;
					int num3;
					int num4;
					if (_currentTurn > 0)
					{
						num3 = 234692767;
						num4 = 234692767;
					}
					else
					{
						num3 = 1753256167;
						num4 = 1753256167;
					}
					num = num3 ^ ((int)num2 * -1075133426);
					continue;
				}
				case 9u:
					_currentChanceIndex = (_currentChanceIndex + 1) % _chances.Count;
					num = ((int)num2 * -1648691256) ^ 0x222E6B39;
					continue;
				case 7u:
					num = ((int)num2 * -903748827) ^ -1361268808;
					continue;
				case 6u:
					_currentPlayer++;
					num = (int)(num2 * 95181768) ^ -670957656;
					continue;
				case 5u:
					Print(Game.smethod_1("-- BEGINNING OF TURN ", (++_currentTurn).ToString(), " --"));
					num = 81866071;
					continue;
				case 4u:
					Print("\n\nGAME STATE\n{0}\n\n-- END OF TURN {1} --\n\n", this, _currentTurn);
					num = ((int)num2 * -901393373) ^ -1038574224;
					continue;
				case 3u:
					Print(Game.smethod_2("RISK CHANCE: ", Rules.RiskChances[_currentChanceIndex].ToString()));
					num = (int)(num2 * 2088182544) ^ -586313176;
					continue;
				case 1u:
					PlayerTurn(_currentPlayer);
					num = 1874712459;
					continue;
				case 0u:
					num = (int)(num2 * 1542433433) ^ -1879036238;
					continue;
				default:
					return;
				case 2u:
					break;
				case 8u:
					return;
				}
				break;
			}
		}
	}

	private void PlayerTurn(int playerIndex)
	{
		Card card = default(Card);
		int num17 = default(int);
		bool flag8 = default(bool);
		PlayerState playerState2 = default(PlayerState);
		bool flag11 = default(bool);
		int num3 = default(int);
		PlayerState playerState = default(PlayerState);
		int num13 = default(int);
		bool flag4 = default(bool);
		bool flag5 = default(bool);
		Player player = default(Player);
		bool onlyOneWinner = default(bool);
		bool flag10 = default(bool);
		bool flag3 = default(bool);
		bool flag = default(bool);
		int num16 = default(int);
		bool flag12 = default(bool);
		bool flag6 = default(bool);
		bool flag7 = default(bool);
		bool flag9 = default(bool);
		bool flag2 = default(bool);
		while (true)
		{
			int num = -1715949496;
			while (true)
			{
				uint num2;
				int num20;
				switch ((num2 = (uint)num ^ 0xB87F0A41u) % 83u)
				{
				case 82u:
					num20 = ((card.Type == 4) ? 1 : 0);
					goto IL_0010;
				case 81u:
					num = (int)((num2 * 27650676) ^ 0x7699F63C);
					continue;
				case 80u:
				{
					int num27;
					if (!Losers.Contains(num17))
					{
						num = -985506112;
						num27 = -985506112;
					}
					else
					{
						num = -1260468770;
						num27 = -1260468770;
					}
					continue;
				}
				case 79u:
					num = -950208869;
					continue;
				case 78u:
					flag8 = card.Impact < 0;
					num = ((int)num2 * -1496760047) ^ -684439638;
					continue;
				case 77u:
					playerState2.State = State.Lose;
					num = -393928948;
					continue;
				case 76u:
					num = ((int)num2 * -1151652103) ^ -952397745;
					continue;
				case 75u:
				{
					int num34;
					int num35;
					if (flag11)
					{
						num34 = -573778270;
						num35 = -573778270;
					}
					else
					{
						num34 = -1177553799;
						num35 = -1177553799;
					}
					num = num34 ^ ((int)num2 * -565347613);
					continue;
				}
				case 74u:
				{
					int num23;
					int num24;
					if (!Losers.Contains(num3))
					{
						num23 = -1594558377;
						num24 = -1594558377;
					}
					else
					{
						num23 = -1062247421;
						num24 = -1062247421;
					}
					num = num23 ^ (int)(num2 * 1398791839);
					continue;
				}
				case 73u:
					playerState.State = State.Won;
					Winners.Add(playerIndex);
					num = ((int)num2 * -7165272) ^ -1086168421;
					continue;
				case 72u:
					num = (int)(num2 * 1470371477) ^ -470978355;
					continue;
				case 71u:
					playerState.Resources -= num13;
					num = (int)(num2 * 1863279982) ^ -911956941;
					continue;
				case 70u:
				{
					int num11;
					int num12;
					if (!flag4)
					{
						num11 = -461956373;
						num12 = -461956373;
					}
					else
					{
						num11 = -898212270;
						num12 = -898212270;
					}
					num = num11 ^ ((int)num2 * -917205501);
					continue;
				}
				case 68u:
					playerState.State = State.Lose;
					num = (int)(num2 * 1502880052) ^ -1406625410;
					continue;
				case 67u:
					Print(playerState.State);
					num = ((int)num2 * -1113637218) ^ -1919310456;
					continue;
				case 66u:
					num3 = 0;
					num = -958532755;
					continue;
				case 65u:
				{
					int num32;
					int num33;
					if (!flag5)
					{
						num32 = 352469966;
						num33 = 352469966;
					}
					else
					{
						num32 = 1766927977;
						num33 = 1766927977;
					}
					num = num32 ^ (int)(num2 * 1121017050);
					continue;
				}
				case 64u:
				{
					int num28;
					int num29;
					if (playerState.State == State.Playing)
					{
						num28 = 80097256;
						num29 = 80097256;
					}
					else
					{
						num28 = 1898144162;
						num29 = 1898144162;
					}
					num = num28 ^ (int)(num2 * 1135932538);
					continue;
				}
				case 63u:
				{
					PlayerState playerState3 = playerState;
					Print(Game.smethod_2("\t", (playerState3 != null) ? Game.smethod_5((object)playerState3) : null));
					num = -70148196;
					continue;
				}
				case 62u:
					num = ((int)num2 * -1766756937) ^ -489377730;
					continue;
				case 61u:
				{
					int num21;
					int num22;
					if (playerState.Resources >= 0)
					{
						num21 = 1208159026;
						num22 = 1208159026;
					}
					else
					{
						num21 = 12294076;
						num22 = 12294076;
					}
					num = num21 ^ (int)(num2 * 1325089014);
					continue;
				}
				case 60u:
					playerState.Sprint++;
					Print("Still planning");
					num = ((int)num2 * -1209609571) ^ 0x7283FC44;
					continue;
				case 59u:
					Losers.Add(playerIndex);
					num = ((int)num2 * -247735144) ^ 0x3F5F6D0;
					continue;
				case 58u:
					num = (int)((num2 * 1615871430) ^ 0x793FF69);
					continue;
				case 57u:
					num = (int)(num2 * 1646380263) ^ -1821197036;
					continue;
				case 56u:
					num13 = card.Impact;
					num = ((int)num2 * -1542602844) ^ -1432836858;
					continue;
				case 55u:
				{
					int num10;
					if (playerState.Sprint > Rules.SprintCount)
					{
						num = -1685369721;
						num10 = -1685369721;
					}
					else
					{
						num = -500204387;
						num10 = -500204387;
					}
					continue;
				}
				case 54u:
					player = Players[playerIndex];
					num = ((int)num2 * -908484724) ^ -253439362;
					continue;
				case 53u:
					onlyOneWinner = Rules.OnlyOneWinner;
					num = ((int)num2 * -629063283) ^ 0x13968F17;
					continue;
				case 52u:
					playerState = _playerStates[playerIndex];
					Print(Game.smethod_2("\nPLAYER ", playerIndex.ToString()));
					num = ((int)num2 * -1184029277) ^ -199481250;
					continue;
				case 51u:
					num = (int)((num2 * 1571388046) ^ 0x71A3F79);
					continue;
				case 50u:
				{
					int num36;
					int num37;
					if (flag10)
					{
						num36 = -1600640405;
						num37 = -1600640405;
					}
					else
					{
						num36 = -215994427;
						num37 = -215994427;
					}
					num = num36 ^ ((int)num2 * -1905784311);
					continue;
				}
				case 49u:
					if (Rules.EconomicsAffectsAll)
					{
						num = ((int)num2 * -1707130610) ^ 0x1EDD761;
						continue;
					}
					num20 = 0;
					goto IL_0010;
				case 48u:
					flag3 = !flag8;
					num = (int)(num2 * 1646953630) ^ -59799679;
					continue;
				case 47u:
					flag = num16 < Rules.StayOnSprintMinDiff;
					num13 = Game.smethod_3(0, num16);
					num = (int)(num2 * 1313871446) ^ -1233827355;
					continue;
				case 46u:
					num = ((int)num2 * -1367311678) ^ -722419546;
					continue;
				case 45u:
					Print("CARD: none, advance");
					num = (int)((num2 * 1764620107) ^ 0x71AAD99A);
					continue;
				case 44u:
					num = -436312998;
					continue;
				case 43u:
					flag12 = !_dice.Roll(_chances[_currentChanceIndex]);
					num = -1935584740;
					continue;
				case 42u:
					num = (int)(num2 * 2064071761) ^ -1872220651;
					continue;
				case 41u:
				{
					int num30;
					int num31;
					if (!flag12)
					{
						num30 = -1496591369;
						num31 = -1496591369;
					}
					else
					{
						num30 = -613753641;
						num31 = -613753641;
					}
					num = num30 ^ ((int)num2 * -2058137083);
					continue;
				}
				case 40u:
					num = (int)(num2 * 876486025) ^ -244350974;
					continue;
				case 39u:
					flag11 = !Losers.Contains(playerIndex);
					num = (int)(num2 * 898568459) ^ -36897046;
					continue;
				case 38u:
					num = -408436945;
					continue;
				case 37u:
					num = ((int)num2 * -1737493923) ^ -72781846;
					continue;
				case 36u:
					num17++;
					num = -1370363659;
					continue;
				case 35u:
					num = ((int)num2 * -752042666) ^ -1866603990;
					continue;
				case 34u:
					flag10 = num3 < _playerStates.Length;
					num = -1225487263;
					continue;
				case 33u:
					flag6 = !flag7;
					num = ((int)num2 * -2044181858) ^ 0x391289E;
					continue;
				case 32u:
					num = (int)(num2 * 8900226) ^ -1633804271;
					continue;
				case 31u:
					flag9 = num17 == playerIndex;
					num = (int)(num2 * 1114695539) ^ -804283569;
					continue;
				case 30u:
					_finished = true;
					num17 = 0;
					num = (int)(num2 * 1498222691) ^ -1280351847;
					continue;
				case 29u:
					flag = true;
					num = -1389625071;
					continue;
				case 28u:
				{
					int num25;
					int num26;
					if (!flag9)
					{
						num25 = 1640053822;
						num26 = 1640053822;
					}
					else
					{
						num25 = 1783596174;
						num26 = 1783596174;
					}
					num = num25 ^ (int)(num2 * 14075560);
					continue;
				}
				case 27u:
					playerState.Sprint++;
					num = (int)(num2 * 890136535) ^ -1532034703;
					continue;
				case 26u:
					num = ((int)num2 * -953258389) ^ -91806653;
					continue;
				case 25u:
					flag4 = num17 < _playerStates.Length;
					num = -1631826205;
					continue;
				case 24u:
					num = -1044399932;
					continue;
				case 22u:
					num = ((int)num2 * -1534325644) ^ 0x63017C47;
					continue;
				case 21u:
					num = ((int)num2 * -1985133519) ^ 0x6D9D2A10;
					continue;
				case 20u:
					Print("CARD: {0}, {1}{2} {3} and {4}", card, flag7 ? "ALL " : "", flag8 ? "receives" : "pays", Game.smethod_4(num13), flag ? "advance" : "stay");
					num = -2096503028;
					continue;
				case 19u:
				{
					int num18;
					int num19;
					if (flag6)
					{
						num18 = -340146078;
						num19 = -340146078;
					}
					else
					{
						num18 = -865677961;
						num19 = -865677961;
					}
					num = num18 ^ ((int)num2 * -1191042090);
					continue;
				}
				case 18u:
					Losers.Add(num17);
					num = ((int)num2 * -825340946) ^ -2142593232;
					continue;
				case 17u:
					num = ((int)num2 * -436736608) ^ 0x6F050CFD;
					continue;
				case 16u:
					num = ((int)num2 * -34162351) ^ 0x70164770;
					continue;
				case 15u:
					num16 = card.Impact - player.PlannedForCard(card.Type);
					num = (int)(num2 * 423485440) ^ -449457475;
					continue;
				case 14u:
					num = -500204387;
					continue;
				case 13u:
					num = ((int)num2 * -275484779) ^ 0x7D74682D;
					continue;
				case 12u:
				{
					playerState2.Resources -= Game.smethod_3(0, num13 - Players[num3].PlannedForCard(card.Type));
					int num14;
					int num15;
					if (playerState2.Resources < 0)
					{
						num14 = -1272055800;
						num15 = -1272055800;
					}
					else
					{
						num14 = -1766305110;
						num15 = -1766305110;
					}
					num = num14 ^ (int)(num2 * 546453263);
					continue;
				}
				case 11u:
					flag5 = playerState.Sprint < 0;
					num = -418027471;
					continue;
				case 10u:
				{
					int num8;
					int num9;
					if (!onlyOneWinner)
					{
						num8 = 790282738;
						num9 = 790282738;
					}
					else
					{
						num8 = 365809716;
						num9 = 365809716;
					}
					num = num8 ^ ((int)num2 * -1747742420);
					continue;
				}
				case 9u:
					card = DrawCard();
					num = -195097541;
					continue;
				case 8u:
				{
					int num6;
					int num7;
					if (flag3)
					{
						num6 = -2007654181;
						num7 = -2007654181;
					}
					else
					{
						num6 = -1445444120;
						num7 = -1445444120;
					}
					num = num6 ^ (int)(num2 * 988579938);
					continue;
				}
				case 7u:
					flag2 = flag;
					num = -668338600;
					continue;
				case 6u:
					playerState2 = _playerStates[num3];
					num = -1279891245;
					continue;
				case 5u:
					Losers.Add(num3);
					num = ((int)num2 * -187304664) ^ -411757800;
					continue;
				case 4u:
				{
					int num4;
					int num5;
					if (flag2)
					{
						num4 = -1023974339;
						num5 = -1023974339;
					}
					else
					{
						num4 = -511493477;
						num5 = -511493477;
					}
					num = num4 ^ ((int)num2 * -19738603);
					continue;
				}
				case 3u:
					flag = true;
					num = (int)(num2 * 2121212249) ^ -1428698999;
					continue;
				case 2u:
					flag = false;
					num = -286298998;
					continue;
				case 1u:
					num = -169989489;
					continue;
				case 0u:
					num3++;
					num = -1449542063;
					continue;
				default:
					return;
				case 23u:
					break;
				case 69u:
					return;
					IL_0010:
					flag7 = (byte)num20 != 0;
					num = -1347885113;
					continue;
				}
				break;
			}
		}
	}

	private Card DrawCard()
	{
		Card card = default(Card);
		Card result = default(Card);
		while (true)
		{
			int num = -24365545;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xB1FA2AA9u) % 8u)
				{
				case 7u:
					ShuffleCards();
					num = (int)((num2 * 2030563563) ^ 0x45DC320D);
					continue;
				case 6u:
				{
					int num3;
					int num4;
					if (_deck.Count <= 0)
					{
						num3 = -1824521026;
						num4 = -1824521026;
					}
					else
					{
						num3 = -1517205680;
						num4 = -1517205680;
					}
					num = num3 ^ (int)(num2 * 515170096);
					continue;
				}
				case 4u:
					num = (int)((num2 * 769830319) ^ 0x51F1DF57);
					continue;
				case 3u:
					_deck.RemoveAt(0);
					num = (int)((num2 * 276737149) ^ 0x4C7E817E);
					continue;
				case 1u:
					card = _deck[0];
					num = -586886918;
					continue;
				case 0u:
					result = card;
					num = (int)(num2 * 1748137985) ^ -168858083;
					continue;
				case 5u:
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
		string result = default(string);
		int num3 = default(int);
		while (true)
		{
			int num = -1621745804;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xE70977EEu) % 9u)
				{
				case 8u:
					num = (int)((num2 * 193955822) ^ 0x3A967764);
					continue;
				case 7u:
					result = text;
					num = ((int)num2 * -322270958) ^ 0x71DC7D12;
					continue;
				case 6u:
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
					num = -387791343;
					continue;
				}
				case 5u:
					num3 = 0;
					num = (int)((num2 * 30843348) ^ 0x5A4273A1);
					continue;
				case 4u:
					num3++;
					num = ((int)num2 * -920340480) ^ 0x33A7A0A5;
					continue;
				case 2u:
				{
					int num4;
					if (num3 < _playerStates.Length)
					{
						num = -683279828;
						num4 = -683279828;
					}
					else
					{
						num = -440948504;
						num4 = -440948504;
					}
					continue;
				}
				case 1u:
					num = ((int)num2 * -174432247) ^ -2021792934;
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

	public override string ToString()
	{
		return ToString(initial: false);
	}

	private void Print(object text, params object[] more)
	{
		string string_ = default(string);
		while (true)
		{
			int num = -2098393874;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xA86D6743u) % 4u)
				{
				case 2u:
					Game.smethod_8(_buffer, string_);
					num = (int)(num2 * 441925866) ^ -1120058485;
					continue;
				case 1u:
					string_ = Game.smethod_7(Game.smethod_5(text), more);
					num = (int)(num2 * 981836162) ^ -1427030193;
					continue;
				default:
					return;
				case 3u:
					break;
				case 0u:
					return;
				}
				break;
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
