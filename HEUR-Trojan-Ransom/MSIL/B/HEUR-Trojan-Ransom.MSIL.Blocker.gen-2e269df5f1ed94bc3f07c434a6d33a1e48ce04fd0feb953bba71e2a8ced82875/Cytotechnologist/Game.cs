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
			PlayerState[] playerStates = default(PlayerState[]);
			bool result = default(bool);
			bool flag = default(bool);
			while (true)
			{
				int num = -1297758011;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xFD6B5EBBu) % 14u)
					{
					case 13u:
						num3++;
						num = -989201500;
						continue;
					case 12u:
						playerStates = _playerStates;
						num = -10107625;
						continue;
					case 11u:
						num = (int)((num2 * 1997117087) ^ 0x548BEBFD);
						continue;
					case 10u:
						num3 = 0;
						num = (int)(num2 * 1262716329) ^ -780084440;
						continue;
					case 8u:
						result = true;
						num = ((int)num2 * -970509885) ^ 0x5E8BCC78;
						continue;
					case 7u:
						num = (int)((num2 * 851880079) ^ 0x303E66DF);
						continue;
					case 6u:
					{
						int num7;
						int num8;
						if (!_finished)
						{
							num7 = -1448277313;
							num8 = -1448277313;
						}
						else
						{
							num7 = -1885672736;
							num8 = -1885672736;
						}
						num = num7 ^ (int)(num2 * 604113198);
						continue;
					}
					case 5u:
					{
						int num6;
						if (num3 < playerStates.Length)
						{
							num = -1064057405;
							num6 = -1064057405;
						}
						else
						{
							num = -1781020631;
							num6 = -1781020631;
						}
						continue;
					}
					case 4u:
					{
						int num4;
						int num5;
						if (flag)
						{
							num4 = 1519165700;
							num5 = 1519165700;
						}
						else
						{
							num4 = 486390;
							num5 = 486390;
						}
						num = num4 ^ ((int)num2 * -1312113844);
						continue;
					}
					case 3u:
						result = false;
						num = (int)(num2 * 1954831680) ^ -698771004;
						continue;
					case 2u:
					{
						PlayerState playerState = playerStates[num3];
						flag = playerState.State == State.Playing;
						num = -1332128827;
						continue;
					}
					case 1u:
						result = true;
						num = (int)((num2 * 371052105) ^ 0x49EF2F6B);
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
			int num = 105853119;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x54C2244Bu) % 9u)
				{
				case 7u:
					ShuffleCards();
					num = (int)((num2 * 1370571661) ^ 0x7143FBDB);
					continue;
				case 6u:
					_currentChanceIndex = -1;
					num = (int)((num2 * 561553706) ^ 0x244F8DE3);
					continue;
				case 5u:
					_finished = false;
					num = ((int)num2 * -1786307148) ^ 0x375C56F4;
					continue;
				case 4u:
					num = ((int)num2 * -1018299775) ^ -1695655425;
					continue;
				case 3u:
					Winners.Clear();
					num = (int)(num2 * 697240871) ^ -887559342;
					continue;
				case 2u:
					Losers.Clear();
					num = (int)(num2 * 628669338) ^ -1800947464;
					continue;
				case 1u:
					_currentPlayer = Players.Length;
					_currentTurn = 0;
					num = (int)((num2 * 250935642) ^ 0x365C1225);
					continue;
				case 0u:
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
		int num = 0;
		PlayerState playerState = default(PlayerState);
		int planningCardsCount = default(int);
		int num5 = default(int);
		bool flag2 = default(bool);
		Player player = default(Player);
		bool useOneMorePlanningSprint = default(bool);
		bool flag = default(bool);
		while (true)
		{
			int num2;
			int num3;
			if (num < Players.Length)
			{
				num2 = 944577959;
				num3 = 944577959;
			}
			else
			{
				num2 = 1188677053;
				num3 = 1188677053;
			}
			while (true)
			{
				uint num4;
				switch ((num4 = (uint)num2 ^ 0x118FB46Au) % 24u)
				{
				case 23u:
					playerState.Resources -= (planningCardsCount - num5) * Rules.NormalPlanningCost;
					num++;
					num2 = 315526497;
					continue;
				case 22u:
				{
					int num10;
					int num11;
					if (flag2)
					{
						num10 = -2034951956;
						num11 = -2034951956;
					}
					else
					{
						num10 = -1285064280;
						num11 = -1285064280;
					}
					num2 = num10 ^ ((int)num4 * -1241944889);
					continue;
				}
				case 21u:
					player = Players[num];
					playerState = _playerStates[num];
					playerState.Sprint = 0;
					num2 = 252554163;
					continue;
				case 20u:
					num2 = (int)(num4 * 2133542023) ^ -113947415;
					continue;
				case 18u:
					num2 = 2058566885;
					continue;
				case 17u:
					flag2 = num5 > 0;
					num2 = 1477660764;
					continue;
				case 16u:
					num5 = 0;
					num2 = 1188895760;
					continue;
				case 14u:
					num2 = 944577959;
					continue;
				case 13u:
					num2 = (int)(num4 * 696021499) ^ -339762921;
					continue;
				case 12u:
					playerState.Resources -= num5 * Rules.OverPlanningCost;
					num2 = ((int)num4 * -221996305) ^ 0x1C88CDDD;
					continue;
				case 11u:
					num2 = (int)((num4 * 968109793) ^ 0x44D2AE03);
					continue;
				case 10u:
					planningCardsCount = player.PlanningCardsCount;
					num2 = (int)((num4 * 1114120002) ^ 0x20E2532E);
					continue;
				case 9u:
					playerState.Resources = Rules.InitialResources;
					playerState.State = State.Playing;
					num2 = ((int)num4 * -1855799810) ^ 0x742B0A2E;
					continue;
				case 8u:
					useOneMorePlanningSprint = player.UseOneMorePlanningSprint;
					num2 = ((int)num4 * -741799926) ^ -1412225658;
					continue;
				case 7u:
				{
					int num8;
					int num9;
					if (!flag)
					{
						num8 = -62386114;
						num9 = -62386114;
					}
					else
					{
						num8 = -230069371;
						num9 = -230069371;
					}
					num2 = num8 ^ (int)(num4 * 161970266);
					continue;
				}
				case 6u:
					num2 = ((int)num4 * -1205794841) ^ 0x6D98B33;
					continue;
				case 5u:
					num5 = planningCardsCount - Rules.NormalPlanningCount;
					num2 = ((int)num4 * -650182787) ^ -1923843261;
					continue;
				case 4u:
				{
					int num6;
					int num7;
					if (useOneMorePlanningSprint)
					{
						num6 = -1824790224;
						num7 = -1824790224;
					}
					else
					{
						num6 = -161028609;
						num7 = -161028609;
					}
					num2 = num6 ^ (int)(num4 * 718785521);
					continue;
				}
				case 3u:
					playerState.Sprint = -1;
					playerState.Resources -= num5 * Rules.NormalPlanningCost;
					num2 = (int)(num4 * 1865550113) ^ -704824276;
					continue;
				case 2u:
					num2 = 1029021895;
					continue;
				case 1u:
					playerState.Sprint = 1;
					num2 = ((int)num4 * -63615173) ^ -1224671731;
					continue;
				case 0u:
					num5 = 0;
					flag = planningCardsCount == 0;
					num2 = ((int)num4 * -908406419) ^ -124866699;
					continue;
				default:
					return;
				case 19u:
					break;
				case 15u:
					return;
				}
				break;
			}
		}
	}

	public void TurnState()
	{
		_currentPlayer++;
		if (_currentPlayer >= Players.Length)
		{
			goto IL_003a;
		}
		goto IL_01b3;
		IL_01b3:
		PlayerTurn(_currentPlayer);
		int num = 1046834474;
		goto IL_0175;
		IL_0175:
		bool flag = default(bool);
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)num ^ 0x1C46A644u) % 11u)
			{
			case 10u:
				num = (int)(num2 * 1518285375) ^ -114818351;
				continue;
			case 9u:
				break;
			case 8u:
			{
				int num3;
				int num4;
				if (flag)
				{
					num3 = -30567868;
					num4 = -30567868;
				}
				else
				{
					num3 = -70250047;
					num4 = -70250047;
				}
				num = num3 ^ (int)(num2 * 1040383094);
				continue;
			}
			case 7u:
				flag = _currentTurn > 0;
				num = (int)(num2 * 1205915996) ^ -1144576061;
				continue;
			case 6u:
				Print("\n\nGAME STATE\n{0}\n\n-- END OF TURN {1} --\n\n", this, _currentTurn);
				num = ((int)num2 * -432013609) ^ -151384723;
				continue;
			case 4u:
				_currentPlayer = 0;
				num = ((int)num2 * -1255561606) ^ 0x7C04C283;
				continue;
			case 2u:
				_currentChanceIndex = (_currentChanceIndex + 1) % _chances.Count;
				Print(Game.smethod_2("RISK CHANCE: ", Rules.RiskChances[_currentChanceIndex].ToString()));
				num = (int)((num2 * 1142208528) ^ 0x22253D46);
				continue;
			case 1u:
				Print(Game.smethod_1("-- BEGINNING OF TURN ", (++_currentTurn).ToString(), " --"));
				num = 909093050;
				continue;
			case 0u:
				num = ((int)num2 * -769189448) ^ -2072453192;
				continue;
			default:
				return;
			case 3u:
				goto IL_01b3;
			case 5u:
				return;
			}
			break;
		}
		goto IL_003a;
		IL_003a:
		num = 1267121648;
		goto IL_0175;
	}

	private void PlayerTurn(int playerIndex)
	{
		bool flag15 = default(bool);
		int num18 = default(int);
		bool flag7 = default(bool);
		PlayerState playerState = default(PlayerState);
		Card card = default(Card);
		bool flag2 = default(bool);
		PlayerState playerState3 = default(PlayerState);
		bool flag8 = default(bool);
		int num22 = default(int);
		bool flag14 = default(bool);
		int num14 = default(int);
		bool flag9 = default(bool);
		int num19 = default(int);
		Player player = default(Player);
		bool flag5 = default(bool);
		bool flag12 = default(bool);
		bool flag10 = default(bool);
		bool flag11 = default(bool);
		bool flag4 = default(bool);
		bool flag13 = default(bool);
		bool flag = default(bool);
		bool flag6 = default(bool);
		bool flag3 = default(bool);
		while (true)
		{
			int num = 1930643570;
			while (true)
			{
				uint num2;
				int num5;
				switch ((num2 = (uint)num ^ 0x32C34250u) % 88u)
				{
				case 87u:
					num = ((int)num2 * -1756522326) ^ 0x26764F27;
					continue;
				case 86u:
				{
					int num37;
					int num38;
					if (flag15)
					{
						num37 = -1688388003;
						num38 = -1688388003;
					}
					else
					{
						num37 = -762597573;
						num38 = -762597573;
					}
					num = num37 ^ (int)(num2 * 601354451);
					continue;
				}
				case 85u:
					Losers.Add(num18);
					num = (int)((num2 * 825724579) ^ 0x6158848E);
					continue;
				case 84u:
					flag7 = !Losers.Contains(num18);
					num = 1112482760;
					continue;
				case 82u:
					num = 785073631;
					continue;
				case 81u:
					if (Rules.EconomicsAffectsAll)
					{
						num = ((int)num2 * -1853223227) ^ 0xDFD403;
						continue;
					}
					num5 = 0;
					goto IL_00a9;
				case 80u:
					num = (int)((num2 * 1124639306) ^ 0x17DC4059);
					continue;
				case 79u:
				{
					PlayerState playerState2 = playerState;
					Print(Game.smethod_2("\t", (playerState2 != null) ? Game.smethod_5((object)playerState2) : null));
					num = 1159403976;
					continue;
				}
				case 78u:
					num = (int)(num2 * 558383857) ^ -2134926313;
					continue;
				case 77u:
					num = ((int)num2 * -1812736164) ^ -1380240179;
					continue;
				case 76u:
					card = DrawCard();
					flag2 = card.Impact < 0;
					num = 263747161;
					continue;
				case 75u:
				{
					int num33;
					int num34;
					if (num18 == playerIndex)
					{
						num33 = -1839877183;
						num34 = -1839877183;
					}
					else
					{
						num33 = -1834817035;
						num34 = -1834817035;
					}
					num = num33 ^ (int)(num2 * 1852318563);
					continue;
				}
				case 74u:
					playerState3.State = State.Lose;
					num = 2104686691;
					continue;
				case 73u:
					flag8 = true;
					num = (int)(num2 * 1745656205) ^ -224181497;
					continue;
				case 72u:
					num = (int)((num2 * 1008348406) ^ 0x36136CAC);
					continue;
				case 71u:
					num = 369197704;
					continue;
				case 70u:
					flag8 = num22 < Rules.StayOnSprintMinDiff;
					num = ((int)num2 * -892504933) ^ -2117433393;
					continue;
				case 69u:
					num = (int)(num2 * 1894447881) ^ -1442287025;
					continue;
				case 68u:
					playerState = _playerStates[playerIndex];
					Print(Game.smethod_2("\nPLAYER ", playerIndex.ToString()));
					num = ((int)num2 * -1842147922) ^ 0x3335FCF4;
					continue;
				case 67u:
					flag14 = !Losers.Contains(num14);
					num = (int)((num2 * 1699953963) ^ 0x327A3D41);
					continue;
				case 66u:
					flag8 = true;
					num = ((int)num2 * -1319310959) ^ -202656184;
					continue;
				case 65u:
				{
					int num23;
					int num24;
					if (flag9)
					{
						num23 = 1099947017;
						num24 = 1099947017;
					}
					else
					{
						num23 = 693588188;
						num24 = 693588188;
					}
					num = num23 ^ (int)(num2 * 1314774298);
					continue;
				}
				case 64u:
					flag8 = false;
					num = 2067559849;
					continue;
				case 63u:
					num18++;
					num = 1118890958;
					continue;
				case 62u:
					playerState.Resources -= num19;
					num = (int)((num2 * 279728357) ^ 0x734B7964);
					continue;
				case 61u:
					_finished = true;
					num18 = 0;
					num = (int)(num2 * 930451925) ^ -307905839;
					continue;
				case 60u:
					num = ((int)num2 * -55233704) ^ 0x167F5051;
					continue;
				case 59u:
					num = (int)(num2 * 193487802) ^ -422672823;
					continue;
				case 58u:
					Print("CARD: none, advance");
					num = ((int)num2 * -2075387266) ^ -1642603875;
					continue;
				case 57u:
					num22 = card.Impact - player.PlannedForCard(card.Type);
					num = ((int)num2 * -2027607369) ^ -200001311;
					continue;
				case 56u:
				{
					int num17;
					if (!flag8)
					{
						num = 894836255;
						num17 = 894836255;
					}
					else
					{
						num = 1771784532;
						num17 = 1771784532;
					}
					continue;
				}
				case 55u:
					Print(playerState.State);
					num = ((int)num2 * -1160023864) ^ -1901300444;
					continue;
				case 54u:
					num5 = ((card.Type == 4) ? 1 : 0);
					goto IL_00a9;
				case 53u:
					num = (int)((num2 * 878481975) ^ 0x20F717C7);
					continue;
				case 52u:
					playerState.Sprint++;
					num = ((int)num2 * -853964722) ^ -683186905;
					continue;
				case 51u:
				{
					int num8;
					int num9;
					if (flag5)
					{
						num8 = -1250042055;
						num9 = -1250042055;
					}
					else
					{
						num8 = -891475029;
						num9 = -891475029;
					}
					num = num8 ^ (int)(num2 * 1166091452);
					continue;
				}
				case 50u:
					player = Players[playerIndex];
					num = (int)(num2 * 1774774829) ^ -889936490;
					continue;
				case 49u:
					num = ((int)num2 * -1395073905) ^ 0xC996961;
					continue;
				case 48u:
					num = ((int)num2 * -1130867903) ^ 0x2DF379BE;
					continue;
				case 47u:
				{
					int num35;
					int num36;
					if (!flag12)
					{
						num35 = -399150974;
						num36 = -399150974;
					}
					else
					{
						num35 = -330244149;
						num36 = -330244149;
					}
					num = num35 ^ ((int)num2 * -418457045);
					continue;
				}
				case 46u:
				{
					int num31;
					int num32;
					if (flag10)
					{
						num31 = 30123964;
						num32 = 30123964;
					}
					else
					{
						num31 = 1611073454;
						num32 = 1611073454;
					}
					num = num31 ^ ((int)num2 * -985933630);
					continue;
				}
				case 45u:
					num19 = Game.smethod_3(0, num22);
					num = ((int)num2 * -1879624423) ^ 0x2E71752E;
					continue;
				case 44u:
				{
					int num29;
					int num30;
					if (playerState.State == State.Playing)
					{
						num29 = -1598430915;
						num30 = -1598430915;
					}
					else
					{
						num29 = -805480009;
						num30 = -805480009;
					}
					num = num29 ^ ((int)num2 * -1750216846);
					continue;
				}
				case 43u:
					flag15 = !flag2;
					num = ((int)num2 * -1741904545) ^ -512062165;
					continue;
				case 42u:
					Losers.Add(num14);
					num = (int)(num2 * 1646169174) ^ -823870353;
					continue;
				case 41u:
					num = ((int)num2 * -718904545) ^ -2099608569;
					continue;
				case 40u:
				{
					int num27;
					int num28;
					if (flag14)
					{
						num27 = -1440808142;
						num28 = -1440808142;
					}
					else
					{
						num27 = -689152125;
						num28 = -689152125;
					}
					num = num27 ^ (int)(num2 * 1236551750);
					continue;
				}
				case 39u:
					num = 266715919;
					continue;
				case 38u:
					flag11 = num18 < _playerStates.Length;
					num = 2098473363;
					continue;
				case 37u:
					playerState.State = State.Won;
					num = ((int)num2 * -873330080) ^ -1475279232;
					continue;
				case 36u:
					playerState.Sprint++;
					Print("Still planning");
					num = (int)(num2 * 903166942) ^ -1422676640;
					continue;
				case 35u:
					num = ((int)num2 * -1207374180) ^ -1231193093;
					continue;
				case 34u:
					flag4 = !Losers.Contains(playerIndex);
					num = ((int)num2 * -258567057) ^ -818890915;
					continue;
				case 33u:
					num = 664877335;
					continue;
				case 32u:
					num = ((int)num2 * -61522169) ^ -2004314209;
					continue;
				case 31u:
					num = (int)((num2 * 507095016) ^ 0x532C6819);
					continue;
				case 30u:
					num = 159264727;
					continue;
				case 29u:
				{
					int num25;
					int num26;
					if (!flag13)
					{
						num25 = 2147232672;
						num26 = 2147232672;
					}
					else
					{
						num25 = 191014085;
						num26 = 191014085;
					}
					num = num25 ^ (int)(num2 * 1130815759);
					continue;
				}
				case 28u:
					playerState.State = State.Lose;
					num = (int)((num2 * 1317164484) ^ 0x6E628E42);
					continue;
				case 27u:
					num = (int)((num2 * 1886783796) ^ 0x29970148);
					continue;
				case 26u:
					num19 = card.Impact;
					num = ((int)num2 * -1197532580) ^ 0x238ABF4D;
					continue;
				case 25u:
					Print("CARD: {0}, {1}{2} {3} and {4}", card, flag ? "ALL " : "", flag2 ? "receives" : "pays", Game.smethod_4(num19), flag8 ? "advance" : "stay");
					num = 383423374;
					continue;
				case 24u:
					num = (int)(num2 * 379806958) ^ -658245754;
					continue;
				case 23u:
					flag13 = num14 < _playerStates.Length;
					num = 1385220021;
					continue;
				case 22u:
					flag12 = !flag;
					num = ((int)num2 * -1253311676) ^ 0x4F3B4A1F;
					continue;
				case 21u:
					num = 1938567123;
					continue;
				case 20u:
					num14++;
					num = 1125178167;
					continue;
				case 19u:
				{
					int num20;
					int num21;
					if (!flag11)
					{
						num20 = -284362747;
						num21 = -284362747;
					}
					else
					{
						num20 = -1881550835;
						num21 = -1881550835;
					}
					num = num20 ^ ((int)num2 * -768737256);
					continue;
				}
				case 18u:
					flag6 = playerState3.Resources >= 0;
					num = (int)((num2 * 1843107130) ^ 0x50463B9);
					continue;
				case 17u:
					num = ((int)num2 * -948662967) ^ 0x6B38BEE6;
					continue;
				case 16u:
					num = (int)(num2 * 567820495) ^ -178511463;
					continue;
				case 15u:
					flag5 = playerState.Sprint > Rules.SprintCount;
					num = 55729827;
					continue;
				case 14u:
					playerState3 = _playerStates[num14];
					playerState3.Resources -= Game.smethod_3(0, num19 - Players[num14].PlannedForCard(card.Type));
					num = 1568642922;
					continue;
				case 13u:
					flag10 = playerState.Sprint < 0;
					num = 933058662;
					continue;
				case 12u:
					Losers.Add(playerIndex);
					num = ((int)num2 * -205610059) ^ 0x19212854;
					continue;
				case 11u:
					num = 901117796;
					continue;
				case 10u:
					flag9 = playerState.Resources < 0;
					num = (int)(num2 * 1085081824) ^ -1444865031;
					continue;
				case 8u:
				{
					int num15;
					int num16;
					if (flag7)
					{
						num15 = -1511470651;
						num16 = -1511470651;
					}
					else
					{
						num15 = -419852623;
						num16 = -419852623;
					}
					num = num15 ^ ((int)num2 * -1949441122);
					continue;
				}
				case 7u:
					num14 = 0;
					num = ((int)num2 * -559472490) ^ 0x220D3B3;
					continue;
				case 6u:
					num = (int)((num2 * 1636055604) ^ 0x77163CE5);
					continue;
				case 5u:
				{
					int num12;
					int num13;
					if (!flag6)
					{
						num12 = -1106130578;
						num13 = -1106130578;
					}
					else
					{
						num12 = -4285007;
						num13 = -4285007;
					}
					num = num12 ^ ((int)num2 * -1635519132);
					continue;
				}
				case 4u:
				{
					int num10;
					int num11;
					if (flag3)
					{
						num10 = 1109826792;
						num11 = 1109826792;
					}
					else
					{
						num10 = 1203009676;
						num11 = 1203009676;
					}
					num = num10 ^ (int)(num2 * 417219228);
					continue;
				}
				case 3u:
				{
					int num6;
					int num7;
					if (flag4)
					{
						num6 = 1683575684;
						num7 = 1683575684;
					}
					else
					{
						num6 = 709599312;
						num7 = 709599312;
					}
					num = num6 ^ ((int)num2 * -467882568);
					continue;
				}
				case 2u:
					flag3 = !_dice.Roll(_chances[_currentChanceIndex]);
					num = 557880100;
					continue;
				case 1u:
					num = 1791085714;
					continue;
				case 0u:
				{
					Winners.Add(playerIndex);
					int num3;
					int num4;
					if (!Rules.OnlyOneWinner)
					{
						num3 = -660951478;
						num4 = -660951478;
					}
					else
					{
						num3 = -1860614962;
						num4 = -1860614962;
					}
					num = num3 ^ (int)(num2 * 1850905664);
					continue;
				}
				default:
					return;
				case 83u:
					break;
				case 9u:
					return;
					IL_00a9:
					flag = (byte)num5 != 0;
					num = 37336099;
					continue;
				}
				break;
			}
		}
	}

	private Card DrawCard()
	{
		bool flag = default(bool);
		Card result = default(Card);
		Card card = default(Card);
		while (true)
		{
			int num = 507494662;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x20B688A7u) % 8u)
				{
				case 7u:
					_deck.RemoveAt(0);
					num = ((int)num2 * -194240694) ^ -148971155;
					continue;
				case 5u:
				{
					int num3;
					int num4;
					if (flag)
					{
						num3 = -1786044811;
						num4 = -1786044811;
					}
					else
					{
						num3 = -1486664156;
						num4 = -1486664156;
					}
					num = num3 ^ ((int)num2 * -1297739120);
					continue;
				}
				case 4u:
					result = card;
					num = (int)((num2 * 1600157527) ^ 0xB03E9B5);
					continue;
				case 3u:
					card = _deck[0];
					num = 118040200;
					continue;
				case 2u:
					ShuffleCards();
					num = ((int)num2 * -996942835) ^ 0x48DEA4EE;
					continue;
				case 1u:
					flag = _deck.Count <= 0;
					num = ((int)num2 * -549592537) ^ -1013929163;
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
		bool flag = default(bool);
		int num3 = default(int);
		string result = default(string);
		while (true)
		{
			int num = 824758065;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x2197CF9Fu) % 9u)
				{
				case 8u:
				{
					int num4;
					int num5;
					if (flag)
					{
						num4 = -1235204089;
						num5 = -1235204089;
					}
					else
					{
						num4 = -1697751586;
						num5 = -1697751586;
					}
					num = num4 ^ ((int)num2 * -329950238);
					continue;
				}
				case 7u:
					num3++;
					num = ((int)num2 * -1285793832) ^ -1863897092;
					continue;
				case 6u:
					num3 = 0;
					num = (int)(num2 * 179291417) ^ -484993246;
					continue;
				case 5u:
					flag = num3 < _playerStates.Length;
					num = 944126179;
					continue;
				case 3u:
					num = (int)(num2 * 1451450280) ^ -564974575;
					continue;
				case 2u:
					result = text;
					num = ((int)num2 * -1508604558) ^ -1183272667;
					continue;
				case 1u:
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
					num = 815873427;
					continue;
				}
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
		string result = default(string);
		while (true)
		{
			int num = -1161407238;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x992356D7u) % 4u)
				{
				case 2u:
					num = (int)(num2 * 730983506) ^ -1506335997;
					continue;
				case 1u:
					result = ToString(initial: false);
					num = ((int)num2 * -1479054434) ^ -1800888221;
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
