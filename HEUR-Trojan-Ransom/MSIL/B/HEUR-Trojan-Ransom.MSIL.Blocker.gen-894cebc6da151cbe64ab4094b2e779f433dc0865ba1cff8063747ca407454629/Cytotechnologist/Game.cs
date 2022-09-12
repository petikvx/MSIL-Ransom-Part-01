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
			PlayerState[] playerStates = default(PlayerState[]);
			int num3 = default(int);
			bool result = default(bool);
			while (true)
			{
				int num = -1137023675;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xC480ABB2u) % 15u)
					{
					case 14u:
						playerStates = _playerStates;
						num = ((int)num2 * -2135767960) ^ -2101475083;
						continue;
					case 13u:
						num3++;
						num = -638627173;
						continue;
					case 12u:
						num = (int)(num2 * 1568427800) ^ -1362546292;
						continue;
					case 11u:
						result = true;
						num = (int)((num2 * 122524974) ^ 0x9793194);
						continue;
					case 10u:
					{
						int num5;
						if (num3 < playerStates.Length)
						{
							num = -716845559;
							num5 = -716845559;
						}
						else
						{
							num = -1578856549;
							num5 = -1578856549;
						}
						continue;
					}
					case 9u:
					{
						int num6;
						int num7;
						if (!finished)
						{
							num6 = 1487382731;
							num7 = 1487382731;
						}
						else
						{
							num6 = 222588609;
							num7 = 222588609;
						}
						num = num6 ^ ((int)num2 * -845619691);
						continue;
					}
					case 8u:
						result = true;
						num = (int)((num2 * 994364999) ^ 0x1D386390);
						continue;
					case 7u:
					{
						PlayerState playerState = playerStates[num3];
						int num4;
						if (playerState.State != 0)
						{
							num = -1043647240;
							num4 = -1043647240;
						}
						else
						{
							num = -1222465674;
							num4 = -1222465674;
						}
						continue;
					}
					case 6u:
						num = ((int)num2 * -2024100141) ^ 0x4093B38B;
						continue;
					case 5u:
						result = false;
						num = (int)(num2 * 10415803) ^ -1925242204;
						continue;
					case 2u:
						num3 = 0;
						num = (int)(num2 * 2146085800) ^ -1017954726;
						continue;
					case 1u:
						num = (int)((num2 * 2043476236) ^ 0x183638C);
						continue;
					case 0u:
						num = -1174761931;
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
	}

	public Game(JSONNode json, StringBuilder buffer)
	{
		int num4 = default(int);
		int num3 = default(int);
		JSONNode jSONNode = default(JSONNode);
		int count = default(int);
		bool flag = default(bool);
		while (true)
		{
			int num = 1792201575;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x1CE440D1u) % 17u)
				{
				case 16u:
					num4++;
					num = ((int)num2 * -1546124323) ^ 0xDC62C91;
					continue;
				case 15u:
					num = ((int)num2 * -2093408450) ^ 0x60AB9D01;
					continue;
				case 14u:
					Players[num3] = Player.Deserialize(jSONNode[num3]);
					num3++;
					num = 1724742089;
					continue;
				case 13u:
				{
					int num7;
					if (num4 < count)
					{
						num = 671851126;
						num7 = 671851126;
					}
					else
					{
						num = 569635904;
						num7 = 569635904;
					}
					continue;
				}
				case 12u:
					Rules = Rules.Deserialize(json["rules"]);
					num = ((int)num2 * -1142879314) ^ 0x55309451;
					continue;
				case 11u:
				{
					int num5;
					int num6;
					if (!flag)
					{
						num5 = -2110036794;
						num6 = -2110036794;
					}
					else
					{
						num5 = -1233732260;
						num6 = -1233732260;
					}
					num = num5 ^ (int)(num2 * 951637912);
					continue;
				}
				case 10u:
					_buffer = buffer;
					_random = Game.smethod_0((int)DateTime.Now.Ticks);
					num = ((int)num2 * -1620668617) ^ -1587404445;
					continue;
				case 9u:
					num = (int)((num2 * 1934897116) ^ 0x1FACFB7D);
					continue;
				case 8u:
					num = (int)(num2 * 1469430244) ^ -333535352;
					continue;
				case 7u:
					_playerStates = new PlayerState[count];
					num4 = 0;
					num = (int)((num2 * 1371225029) ^ 0x229364DB);
					continue;
				case 6u:
					flag = num3 < count;
					num = 1559518347;
					continue;
				case 5u:
					jSONNode = json["players"];
					count = jSONNode.Count;
					Players = new Player[count];
					num = ((int)num2 * -916962364) ^ 0x796DD967;
					continue;
				case 4u:
					_playerStates[num4] = new PlayerState();
					num = 1572944844;
					continue;
				case 3u:
					_dice = new Dice();
					num = (int)((num2 * 561899105) ^ 0xE43F8A4);
					continue;
				case 2u:
					num3 = 0;
					num = ((int)num2 * -597094286) ^ 0x56EBD38E;
					continue;
				default:
					return;
				case 0u:
					break;
				case 1u:
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
			int num = -113960023;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x90F5D00Bu) % 3u)
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
				num = ((int)num2 * -49089134) ^ -43585501;
			}
		}
	}

	public void StartNew()
	{
		while (true)
		{
			int num = -1463055599;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x8F58617Au) % 8u)
				{
				case 7u:
					_currentTurn = 0;
					_finished = false;
					num = ((int)num2 * -1509125230) ^ -1405177090;
					continue;
				case 5u:
					Winners.Clear();
					num = ((int)num2 * -1188940446) ^ -1735514124;
					continue;
				case 4u:
					Losers.Clear();
					num = ((int)num2 * -771829877) ^ -615168345;
					continue;
				case 3u:
					ShuffleCards();
					num = ((int)num2 * -463842910) ^ 0x50B21754;
					continue;
				case 1u:
					_currentPlayer = Players.Length;
					num = (int)((num2 * 1238928621) ^ 0x46A192E8);
					continue;
				case 0u:
					num = (int)((num2 * 168404860) ^ 0x7DED0337);
					continue;
				case 6u:
					break;
				default:
					_currentChanceIndex = -1;
					_chances = new List<float>(Rules.RiskChances);
					return;
				}
				break;
			}
		}
	}

	public void PlanningState()
	{
		PlayerState playerState = default(PlayerState);
		int num6 = default(int);
		int planningCardsCount = default(int);
		bool useOneMorePlanningSprint = default(bool);
		Player player = default(Player);
		bool flag2 = default(bool);
		bool flag = default(bool);
		int num3 = default(int);
		while (true)
		{
			int num = -1201599467;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x9AA2C06Bu) % 27u)
				{
				case 26u:
					num = (int)(num2 * 1658784946) ^ -1648761472;
					continue;
				case 25u:
					playerState.Resources -= num6 * Rules.OverPlanningCost;
					num = (int)((num2 * 1578808421) ^ 0x2BB37A91);
					continue;
				case 24u:
					playerState.Resources -= num6 * Rules.NormalPlanningCost;
					num = ((int)num2 * -378931906) ^ 0x3C4ABE99;
					continue;
				case 23u:
					num = -1129851831;
					continue;
				case 22u:
					num6 = planningCardsCount - Rules.NormalPlanningCount;
					useOneMorePlanningSprint = player.UseOneMorePlanningSprint;
					num = ((int)num2 * -1816488530) ^ -1119261051;
					continue;
				case 21u:
				{
					int num7;
					int num8;
					if (flag2)
					{
						num7 = -80782289;
						num8 = -80782289;
					}
					else
					{
						num7 = -1426005019;
						num8 = -1426005019;
					}
					num = num7 ^ (int)(num2 * 506959103);
					continue;
				}
				case 20u:
					flag2 = num6 > 0;
					num = -1210773715;
					continue;
				case 19u:
					num = ((int)num2 * -1607086952) ^ 0x70B00EA2;
					continue;
				case 17u:
					playerState.Resources = Rules.InitialResources;
					playerState.State = State.Playing;
					num = (int)((num2 * 1837067983) ^ 0x142B1DB);
					continue;
				case 15u:
					num6 = 0;
					flag = planningCardsCount == 0;
					num = (int)(num2 * 1699756088) ^ -562397325;
					continue;
				case 14u:
					num = (int)(num2 * 1373832087) ^ -1531749450;
					continue;
				case 13u:
					playerState.Sprint = -1;
					num = (int)((num2 * 1750042708) ^ 0x680D68E0);
					continue;
				case 12u:
				{
					int num11;
					if (num3 >= Players.Length)
					{
						num = -1592206886;
						num11 = -1592206886;
					}
					else
					{
						num = -30372015;
						num11 = -30372015;
					}
					continue;
				}
				case 11u:
					num = ((int)num2 * -2023831480) ^ -1125353823;
					continue;
				case 10u:
					player = Players[num3];
					playerState = _playerStates[num3];
					num = ((int)num2 * -2035365425) ^ -1150805776;
					continue;
				case 9u:
					num6 = 0;
					num = -195105822;
					continue;
				case 8u:
				{
					int num9;
					int num10;
					if (useOneMorePlanningSprint)
					{
						num9 = 1343641403;
						num10 = 1343641403;
					}
					else
					{
						num9 = 1515334871;
						num10 = 1515334871;
					}
					num = num9 ^ (int)(num2 * 1175194298);
					continue;
				}
				case 7u:
					playerState.Resources -= (planningCardsCount - num6) * Rules.NormalPlanningCost;
					num3++;
					num = -764787844;
					continue;
				case 6u:
					playerState.Sprint = 0;
					num = (int)((num2 * 313786134) ^ 0x4BCC264F);
					continue;
				case 5u:
					playerState.Sprint = 1;
					num = ((int)num2 * -46211734) ^ 0x2B5B8EC6;
					continue;
				case 4u:
					planningCardsCount = player.PlanningCardsCount;
					num = (int)(num2 * 1835217503) ^ -2060834350;
					continue;
				case 3u:
				{
					int num4;
					int num5;
					if (flag)
					{
						num4 = 1568062391;
						num5 = 1568062391;
					}
					else
					{
						num4 = 2055051203;
						num5 = 2055051203;
					}
					num = num4 ^ ((int)num2 * -584581616);
					continue;
				}
				case 2u:
					num = -1938222543;
					continue;
				case 1u:
					num3 = 0;
					num = (int)((num2 * 2132729990) ^ 0x161BB231);
					continue;
				case 0u:
					num = -862074485;
					continue;
				default:
					return;
				case 16u:
					break;
				case 18u:
					return;
				}
				break;
			}
		}
	}

	public void TurnState()
	{
		_currentPlayer++;
		bool flag = _currentPlayer >= Players.Length;
		bool flag2 = default(bool);
		while (true)
		{
			int num = -1362151737;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x9B72D744u) % 12u)
				{
				case 11u:
					num = (int)(num2 * 235517349) ^ -553014357;
					continue;
				case 10u:
					Print(Game.smethod_2("RISK CHANCE: ", Rules.RiskChances[_currentChanceIndex].ToString()));
					num = (int)((num2 * 1076319016) ^ 0x31565B5B);
					continue;
				case 7u:
				{
					int num5;
					int num6;
					if (flag)
					{
						num5 = -1728011766;
						num6 = -1728011766;
					}
					else
					{
						num5 = -1906929417;
						num6 = -1906929417;
					}
					num = num5 ^ ((int)num2 * -1928540579);
					continue;
				}
				case 6u:
					Print("\n\nGAME STATE\n{0}\n\n-- END OF TURN {1} --\n\n", this, _currentTurn);
					num = ((int)num2 * -2126960669) ^ -980184869;
					continue;
				case 5u:
					num = ((int)num2 * -1351690103) ^ 0x4B4D77DB;
					continue;
				case 4u:
					PlayerTurn(_currentPlayer);
					num = -176245645;
					continue;
				case 3u:
					num = (int)(num2 * 1383025804) ^ -933881415;
					continue;
				case 2u:
					_currentPlayer = 0;
					flag2 = _currentTurn > 0;
					num = (int)(num2 * 1502971360) ^ -1098671548;
					continue;
				case 1u:
					Print(Game.smethod_1("-- BEGINNING OF TURN ", (++_currentTurn).ToString(), " --"));
					_currentChanceIndex = (_currentChanceIndex + 1) % _chances.Count;
					num = -893380518;
					continue;
				case 0u:
				{
					int num3;
					int num4;
					if (flag2)
					{
						num3 = 1813706138;
						num4 = 1813706138;
					}
					else
					{
						num3 = 1304159361;
						num4 = 1304159361;
					}
					num = num3 ^ ((int)num2 * -683659045);
					continue;
				}
				default:
					return;
				case 8u:
					break;
				case 9u:
					return;
				}
				break;
			}
		}
	}

	private void PlayerTurn(int playerIndex)
	{
		int num3 = default(int);
		bool flag = default(bool);
		bool flag7 = default(bool);
		bool flag2 = default(bool);
		int num9 = default(int);
		Card card = default(Card);
		PlayerState playerState = default(PlayerState);
		bool flag6 = default(bool);
		int num8 = default(int);
		int num11 = default(int);
		Player player = default(Player);
		PlayerState playerState2 = default(PlayerState);
		bool onlyOneWinner = default(bool);
		bool flag9 = default(bool);
		bool flag4 = default(bool);
		bool flag5 = default(bool);
		bool flag8 = default(bool);
		bool flag13 = default(bool);
		bool flag12 = default(bool);
		bool flag11 = default(bool);
		bool flag10 = default(bool);
		bool flag3 = default(bool);
		while (true)
		{
			int num = 930787781;
			while (true)
			{
				uint num2;
				int num20;
				switch ((num2 = (uint)num ^ 0x29920393u) % 87u)
				{
				case 86u:
					num = ((int)num2 * -1266133229) ^ 0x31D79545;
					continue;
				case 85u:
					num = 204525281;
					continue;
				case 84u:
				{
					int num34;
					if (num3 >= _playerStates.Length)
					{
						num = 1567358728;
						num34 = 1567358728;
					}
					else
					{
						num = 694115916;
						num34 = 694115916;
					}
					continue;
				}
				case 83u:
					num = ((int)num2 * -762438756) ^ 0x44D87577;
					continue;
				case 82u:
				{
					int num18;
					int num19;
					if (flag)
					{
						num18 = 927402758;
						num19 = 927402758;
					}
					else
					{
						num18 = 378146615;
						num19 = 378146615;
					}
					num = num18 ^ (int)(num2 * 1979270625);
					continue;
				}
				case 81u:
				{
					int num32;
					int num33;
					if (flag7)
					{
						num32 = -521234980;
						num33 = -521234980;
					}
					else
					{
						num32 = -1687042626;
						num33 = -1687042626;
					}
					num = num32 ^ (int)(num2 * 154877481);
					continue;
				}
				case 80u:
					flag2 = true;
					num9 = card.Impact;
					num = ((int)num2 * -318623938) ^ 0x6CE1283D;
					continue;
				case 79u:
					num = 989196946;
					continue;
				case 78u:
				{
					PlayerState playerState3 = playerState;
					Print(Game.smethod_2("\t", (playerState3 != null) ? Game.smethod_5((object)playerState3) : null));
					num = 1651125620;
					continue;
				}
				case 77u:
					playerState.State = State.Lose;
					num = ((int)num2 * -1282155530) ^ -666096085;
					continue;
				case 76u:
					flag6 = !Losers.Contains(num8);
					num = (int)((num2 * 142148951) ^ 0x340D16D8);
					continue;
				case 75u:
					num = (int)((num2 * 289687120) ^ 0x4301D7E2);
					continue;
				case 74u:
					num = ((int)num2 * -1719905077) ^ -1759943516;
					continue;
				case 73u:
					num11 = card.Impact - player.PlannedForCard(card.Type);
					num = (int)(num2 * 2106730398) ^ -1398695361;
					continue;
				case 72u:
					num = ((int)num2 * -1547359037) ^ 0x2FA3053C;
					continue;
				case 71u:
					num8 = 0;
					num = ((int)num2 * -1265202471) ^ -830906966;
					continue;
				case 70u:
					num = (int)((num2 * 1112755059) ^ 0x77F2D5D);
					continue;
				case 69u:
				{
					playerState.Resources -= num9;
					int num28;
					int num29;
					if (playerState.Resources < 0)
					{
						num28 = -21157780;
						num29 = -21157780;
					}
					else
					{
						num28 = -2138298791;
						num29 = -2138298791;
					}
					num = num28 ^ (int)(num2 * 1487113152);
					continue;
				}
				case 68u:
					num = ((int)num2 * -1857852106) ^ 0x5FE71E8;
					continue;
				case 67u:
					flag2 = num11 < Rules.StayOnSprintMinDiff;
					num = (int)(num2 * 261610784) ^ -1638167904;
					continue;
				case 66u:
					playerState2.Resources -= Game.smethod_3(0, num9 - Players[num8].PlannedForCard(card.Type));
					num = ((int)num2 * -242606469) ^ -1089206933;
					continue;
				case 65u:
				{
					int num23;
					int num24;
					if (onlyOneWinner)
					{
						num23 = 842045600;
						num24 = 842045600;
					}
					else
					{
						num23 = 2064806127;
						num24 = 2064806127;
					}
					num = num23 ^ ((int)num2 * -547095335);
					continue;
				}
				case 64u:
				{
					int num16;
					int num17;
					if (flag9)
					{
						num16 = 47792228;
						num17 = 47792228;
					}
					else
					{
						num16 = 230901337;
						num17 = 230901337;
					}
					num = num16 ^ (int)(num2 * 1954685012);
					continue;
				}
				case 63u:
					onlyOneWinner = Rules.OnlyOneWinner;
					num = (int)((num2 * 486098518) ^ 0x2487BB2A);
					continue;
				case 62u:
					num = (int)((num2 * 1837820387) ^ 0x3141898B);
					continue;
				case 61u:
				{
					int num12;
					int num13;
					if (!flag4)
					{
						num12 = 65047217;
						num13 = 65047217;
					}
					else
					{
						num12 = 815363291;
						num13 = 815363291;
					}
					num = num12 ^ (int)(num2 * 1890837420);
					continue;
				}
				case 60u:
				{
					int num10;
					if (playerState.Sprint < 0)
					{
						num = 693932314;
						num10 = 693932314;
					}
					else
					{
						num = 1963305914;
						num10 = 1963305914;
					}
					continue;
				}
				case 59u:
					playerState2 = _playerStates[num8];
					num = 576110772;
					continue;
				case 58u:
					Print(Game.smethod_2("\nPLAYER ", playerIndex.ToString()));
					flag5 = playerState.State != State.Playing;
					num = ((int)num2 * -1898794261) ^ -1227451332;
					continue;
				case 57u:
					Losers.Add(playerIndex);
					num = ((int)num2 * -706068197) ^ 0x37C5BC2B;
					continue;
				case 56u:
					num = (int)(num2 * 248803886) ^ -1424867256;
					continue;
				case 55u:
					num = 2131273872;
					continue;
				case 54u:
				{
					int num35;
					int num36;
					if (!flag8)
					{
						num35 = 630015527;
						num36 = 630015527;
					}
					else
					{
						num35 = 1832380750;
						num36 = 1832380750;
					}
					num = num35 ^ ((int)num2 * -1687489474);
					continue;
				}
				case 53u:
					num = ((int)num2 * -892883325) ^ -1594649410;
					continue;
				case 52u:
					num = 1278738595;
					continue;
				case 51u:
					num9 = Game.smethod_3(0, num11);
					num = ((int)num2 * -1195670989) ^ -391915134;
					continue;
				case 50u:
					num = 301729626;
					continue;
				case 49u:
				{
					int num30;
					int num31;
					if (!Losers.Contains(playerIndex))
					{
						num30 = -2005511140;
						num31 = -2005511140;
					}
					else
					{
						num30 = -184553717;
						num31 = -184553717;
					}
					num = num30 ^ (int)(num2 * 1411709729);
					continue;
				}
				case 48u:
				{
					int num27;
					if (num8 >= _playerStates.Length)
					{
						num = 1412303661;
						num27 = 1412303661;
					}
					else
					{
						num = 465833129;
						num27 = 465833129;
					}
					continue;
				}
				case 47u:
					num3 = 0;
					num = (int)(num2 * 1134460970) ^ -1410076804;
					continue;
				case 46u:
					Print(playerState.State);
					num = ((int)num2 * -1722225924) ^ -713525264;
					continue;
				case 44u:
					if (Rules.EconomicsAffectsAll)
					{
						num = (int)(num2 * 1251866704) ^ -286953855;
						continue;
					}
					num20 = 0;
					goto IL_0514;
				case 43u:
					playerState = _playerStates[playerIndex];
					num = ((int)num2 * -593614600) ^ -579881968;
					continue;
				case 42u:
				{
					int num25;
					int num26;
					if (!flag13)
					{
						num25 = -115257016;
						num26 = -115257016;
					}
					else
					{
						num25 = -1531977056;
						num26 = -1531977056;
					}
					num = num25 ^ (int)(num2 * 1334055983);
					continue;
				}
				case 41u:
					flag13 = playerState.Sprint > Rules.SprintCount;
					num = 2004039227;
					continue;
				case 40u:
					flag12 = flag2;
					num = 1807153238;
					continue;
				case 39u:
					playerState2.State = State.Lose;
					num = 1374180062;
					continue;
				case 38u:
					_finished = true;
					num = (int)((num2 * 830034607) ^ 0x7985F754);
					continue;
				case 37u:
					num = ((int)num2 * -1083741661) ^ -1714225572;
					continue;
				case 36u:
					flag11 = !flag10;
					num = (int)((num2 * 1964490213) ^ 0x22EF9B27);
					continue;
				case 35u:
					playerState.State = State.Won;
					Winners.Add(playerIndex);
					num = ((int)num2 * -209144052) ^ -64262736;
					continue;
				case 34u:
					num = 3516247;
					continue;
				case 33u:
					playerState.Sprint++;
					num = ((int)num2 * -157240389) ^ 0xA39F4FB;
					continue;
				case 32u:
					Print("Still planning");
					num = ((int)num2 * -536062357) ^ 0x2E17FDE8;
					continue;
				case 31u:
				{
					int num21;
					int num22;
					if (!flag12)
					{
						num21 = -372892552;
						num22 = -372892552;
					}
					else
					{
						num21 = -743672825;
						num22 = -743672825;
					}
					num = num21 ^ ((int)num2 * -1072095608);
					continue;
				}
				case 30u:
					num = (int)((num2 * 1052362157) ^ 0x7E830316);
					continue;
				case 29u:
					card = DrawCard();
					flag3 = card.Impact < 0;
					num = 82507640;
					continue;
				case 28u:
					player = Players[playerIndex];
					num = (int)(num2 * 1388258475) ^ -1376973763;
					continue;
				case 27u:
					num = ((int)num2 * -999175710) ^ -750550071;
					continue;
				case 26u:
					num20 = ((card.Type == 4) ? 1 : 0);
					goto IL_0514;
				case 25u:
				{
					int num14;
					int num15;
					if (!flag11)
					{
						num14 = 789634303;
						num15 = 789634303;
					}
					else
					{
						num14 = 431392648;
						num15 = 431392648;
					}
					num = num14 ^ ((int)num2 * -1559081957);
					continue;
				}
				case 24u:
					num = (int)(num2 * 1595856418) ^ -20258156;
					continue;
				case 23u:
					num = ((int)num2 * -628055601) ^ -1901370635;
					continue;
				case 22u:
					Print("CARD: {0}, {1}{2} {3} and {4}", card, flag10 ? "ALL " : "", flag3 ? "receives" : "pays", Game.smethod_4(num9), flag2 ? "advance" : "stay");
					num = 831356295;
					continue;
				case 21u:
					flag2 = true;
					num = ((int)num2 * -574655141) ^ 0x1BC61A52;
					continue;
				case 20u:
					num3++;
					num = 40302909;
					continue;
				case 19u:
					Losers.Add(num8);
					num = ((int)num2 * -449818269) ^ 0x542DE212;
					continue;
				case 18u:
					flag9 = !Losers.Contains(num3);
					num = 290554989;
					continue;
				case 17u:
					Print("CARD: none, advance");
					num = (int)(num2 * 1806297056) ^ -571202376;
					continue;
				case 16u:
					num = (int)((num2 * 1948514239) ^ 0x3D5FC37);
					continue;
				case 15u:
					num = 2013407736;
					continue;
				case 14u:
					num = ((int)num2 * -323342604) ^ 0x36D6DEA8;
					continue;
				case 13u:
					num = (int)(num2 * 405050726) ^ -1802520861;
					continue;
				case 12u:
					num = ((int)num2 * -218739534) ^ 0x300CE317;
					continue;
				case 11u:
					flag8 = num3 == playerIndex;
					num = 7831806;
					continue;
				case 10u:
					num8++;
					num = 1052442393;
					continue;
				case 9u:
					flag7 = playerState2.Resources >= 0;
					num = ((int)num2 * -497868366) ^ 0x782C6353;
					continue;
				case 8u:
				{
					int num6;
					int num7;
					if (!flag6)
					{
						num6 = 233266194;
						num7 = 233266194;
					}
					else
					{
						num6 = 1021468495;
						num7 = 1021468495;
					}
					num = num6 ^ ((int)num2 * -1097566895);
					continue;
				}
				case 7u:
					num = ((int)num2 * -283069529) ^ -257083267;
					continue;
				case 5u:
				{
					int num4;
					int num5;
					if (!flag5)
					{
						num4 = 290932068;
						num5 = 290932068;
					}
					else
					{
						num4 = 207309552;
						num5 = 207309552;
					}
					num = num4 ^ ((int)num2 * -1537951685);
					continue;
				}
				case 4u:
					flag4 = !flag3;
					num = ((int)num2 * -1097961831) ^ -1180536910;
					continue;
				case 3u:
					flag2 = false;
					num = 1605818777;
					continue;
				case 2u:
					flag = !_dice.Roll(_chances[_currentChanceIndex]);
					num = 268224679;
					continue;
				case 1u:
					playerState.Sprint++;
					num = ((int)num2 * -1496238085) ^ -590793980;
					continue;
				case 0u:
					Losers.Add(num3);
					num = ((int)num2 * -634186894) ^ -1767908369;
					continue;
				default:
					return;
				case 6u:
					break;
				case 45u:
					return;
					IL_0514:
					flag10 = (byte)num20 != 0;
					num = 1511799845;
					continue;
				}
				break;
			}
		}
	}

	private Card DrawCard()
	{
		Card result = default(Card);
		while (true)
		{
			int num = -1141246413;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xCEB808D5u) % 7u)
				{
				case 5u:
				{
					Card card = _deck[0];
					_deck.RemoveAt(0);
					result = card;
					num = -1062057370;
					continue;
				}
				case 4u:
					ShuffleCards();
					num = ((int)num2 * -1793145344) ^ -787545712;
					continue;
				case 3u:
					num = ((int)num2 * -1806349021) ^ 0x1DA81341;
					continue;
				case 2u:
				{
					int num3;
					int num4;
					if (_deck.Count > 0)
					{
						num3 = -2505800;
						num4 = -2505800;
					}
					else
					{
						num3 = -1963634904;
						num4 = -1963634904;
					}
					num = num3 ^ (int)(num2 * 1849807433);
					continue;
				}
				case 1u:
					num = (int)(num2 * 2068067095) ^ -1493205120;
					continue;
				case 6u:
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
		int num3 = default(int);
		string result = default(string);
		string text = default(string);
		while (true)
		{
			int num = 1347123044;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x4CFD922Fu) % 7u)
				{
				case 6u:
				{
					int num4;
					if (num3 >= _playerStates.Length)
					{
						num = 161118136;
						num4 = 161118136;
					}
					else
					{
						num = 1386493225;
						num4 = 1386493225;
					}
					continue;
				}
				case 5u:
					result = text;
					num = ((int)num2 * -201879831) ^ -1399371232;
					continue;
				case 4u:
					text = "";
					num3 = 0;
					num = (int)((num2 * 2106045236) ^ 0x244A98A3);
					continue;
				case 2u:
					num = (int)(num2 * 783319973) ^ -1230174167;
					continue;
				case 0u:
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
					num3++;
					num = 407932761;
					continue;
				}
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
		string result = ToString(initial: false);
		while (true)
		{
			int num = 1029230205;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x70B7EDACu) % 3u)
				{
				case 2u:
					goto IL_000a;
				case 0u:
					break;
				default:
					return result;
				}
				break;
				IL_000a:
				num = ((int)num2 * -963988219) ^ -43550240;
			}
		}
	}

	private void Print(object text, params object[] more)
	{
		string string_ = default(string);
		while (true)
		{
			int num = -782905437;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x9B124BCAu) % 3u)
				{
				case 1u:
					goto IL_0003;
				case 2u:
					break;
				default:
					Game.smethod_8(_buffer, string_);
					return;
				}
				break;
				IL_0003:
				string_ = Game.smethod_7(Game.smethod_5(text), more);
				num = (int)(num2 * 1780574417) ^ -1401091220;
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
