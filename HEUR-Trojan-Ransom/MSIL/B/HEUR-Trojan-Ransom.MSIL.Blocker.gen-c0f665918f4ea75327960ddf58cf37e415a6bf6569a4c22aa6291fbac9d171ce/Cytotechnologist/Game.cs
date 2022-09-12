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
			PlayerState playerState = default(PlayerState);
			PlayerState[] playerStates = default(PlayerState[]);
			int num3 = default(int);
			bool result = default(bool);
			while (true)
			{
				int num = 107322083;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x5AF6DECu) % 14u)
					{
					case 13u:
						num = (int)(num2 * 414829085) ^ -2067267139;
						continue;
					case 12u:
						playerState = playerStates[num3];
						num = 922831680;
						continue;
					case 11u:
						result = true;
						num = ((int)num2 * -9029485) ^ 0x602DB50;
						continue;
					case 9u:
						playerStates = _playerStates;
						num3 = 0;
						num = 1723606039;
						continue;
					case 8u:
					{
						int num5;
						int num6;
						if (playerState.State != 0)
						{
							num5 = -1747984794;
							num6 = -1747984794;
						}
						else
						{
							num5 = -1987445077;
							num6 = -1987445077;
						}
						num = num5 ^ (int)(num2 * 296519567);
						continue;
					}
					case 7u:
						num = ((int)num2 * -689013082) ^ 0x6798756C;
						continue;
					case 6u:
						num3++;
						num = 1723606039;
						continue;
					case 5u:
						result = false;
						num = ((int)num2 * -651633509) ^ -1865340481;
						continue;
					case 4u:
						result = true;
						num = (int)(num2 * 1385861224) ^ -1028010707;
						continue;
					case 3u:
					{
						int num7;
						int num8;
						if (!_finished)
						{
							num7 = 658687096;
							num8 = 658687096;
						}
						else
						{
							num7 = 847900316;
							num8 = 847900316;
						}
						num = num7 ^ ((int)num2 * -2088733701);
						continue;
					}
					case 2u:
						num = (int)(num2 * 188381787) ^ -20907860;
						continue;
					case 1u:
					{
						int num4;
						if (num3 >= playerStates.Length)
						{
							num = 1807566132;
							num4 = 1807566132;
						}
						else
						{
							num = 647407850;
							num4 = 647407850;
						}
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
	}

	public Game(JSONNode json, StringBuilder buffer)
	{
		int count = default(int);
		int num6 = default(int);
		bool flag = default(bool);
		JSONNode jSONNode = default(JSONNode);
		int num3 = default(int);
		bool flag2 = default(bool);
		while (true)
		{
			int num = 1187241950;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x639C80DBu) % 16u)
				{
				case 15u:
					num = (int)(num2 * 1222462710) ^ -1926786109;
					continue;
				case 14u:
					Players = new Player[count];
					num6 = 0;
					num = (int)((num2 * 147109198) ^ 0x2C518D97);
					continue;
				case 13u:
				{
					int num7;
					int num8;
					if (flag)
					{
						num7 = 756097299;
						num8 = 756097299;
					}
					else
					{
						num7 = 989444049;
						num8 = 989444049;
					}
					num = num7 ^ ((int)num2 * -164228115);
					continue;
				}
				case 12u:
					_dice = new Dice();
					jSONNode = json["players"];
					count = jSONNode.Count;
					num = (int)(num2 * 809130325) ^ -1062388583;
					continue;
				case 11u:
					Players[num6] = Player.Deserialize(jSONNode[num6]);
					num6++;
					num = 1089085139;
					continue;
				case 9u:
					num3 = 0;
					num = ((int)num2 * -1607758789) ^ 0x3C9F71E8;
					continue;
				case 8u:
					flag2 = num6 < count;
					num = 1942925996;
					continue;
				case 7u:
				{
					int num4;
					int num5;
					if (flag2)
					{
						num4 = -1828225889;
						num5 = -1828225889;
					}
					else
					{
						num4 = -1673523070;
						num5 = -1673523070;
					}
					num = num4 ^ ((int)num2 * -1471537879);
					continue;
				}
				case 6u:
					_playerStates = new PlayerState[count];
					num = ((int)num2 * -220916341) ^ -1779819728;
					continue;
				case 5u:
					num = (int)(num2 * 1213916764) ^ -1246384328;
					continue;
				case 4u:
					_random = Game.smethod_0((int)DateTime.Now.Ticks);
					Rules = Rules.Deserialize(json["rules"]);
					num = (int)(num2 * 1432723259) ^ -1598189685;
					continue;
				case 2u:
					_buffer = buffer;
					num = ((int)num2 * -77781924) ^ -1855826041;
					continue;
				case 1u:
					_playerStates[num3] = new PlayerState();
					num3++;
					num = 623463531;
					continue;
				case 0u:
					flag = num3 < count;
					num = 1076346966;
					continue;
				default:
					return;
				case 10u:
					break;
				case 3u:
					return;
				}
				break;
			}
		}
	}

	public void ShuffleCards()
	{
		_deck = new List<Card>(Rules.Cards);
	}

	public void StartNew()
	{
		ShuffleCards();
		Winners.Clear();
		while (true)
		{
			int num = -1186614009;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x9E887EF5u) % 8u)
				{
				case 6u:
					_finished = false;
					_currentChanceIndex = -1;
					num = (int)((num2 * 1365616920) ^ 0x10CB47A5);
					continue;
				case 5u:
					Losers.Clear();
					num = ((int)num2 * -2125901086) ^ -1173837756;
					continue;
				case 4u:
					_currentTurn = 0;
					num = (int)((num2 * 206328208) ^ 0x26D969F3);
					continue;
				case 3u:
					num = ((int)num2 * -20156941) ^ -1062097371;
					continue;
				case 2u:
					num = ((int)num2 * -617843970) ^ -1430803076;
					continue;
				case 1u:
					_currentPlayer = Players.Length;
					num = (int)(num2 * 681916971) ^ -534915966;
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
		int num = 0;
		int num4 = default(int);
		int planningCardsCount = default(int);
		PlayerState playerState = default(PlayerState);
		Player player = default(Player);
		bool flag = default(bool);
		while (true)
		{
			int num2 = 557194740;
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)num2 ^ 0x4D94CA8Du) % 25u)
				{
				case 22u:
					num++;
					num2 = ((int)num3 * -950641310) ^ 0x4DCAFCFE;
					continue;
				case 21u:
					num2 = (int)((num3 * 1208807402) ^ 0x1261FA14);
					continue;
				case 20u:
					num2 = (int)((num3 * 185837554) ^ 0x2717B0FF);
					continue;
				case 19u:
					num4 = planningCardsCount - Rules.NormalPlanningCount;
					num2 = (int)((num3 * 929194238) ^ 0x73183877);
					continue;
				case 18u:
					playerState.State = State.Playing;
					planningCardsCount = player.PlanningCardsCount;
					num2 = ((int)num3 * -863216929) ^ 0x26E4D4EB;
					continue;
				case 17u:
				{
					int num7;
					int num8;
					if (!player.UseOneMorePlanningSprint)
					{
						num7 = 869221952;
						num8 = 869221952;
					}
					else
					{
						num7 = 1184923066;
						num8 = 1184923066;
					}
					num2 = num7 ^ (int)(num3 * 1975309328);
					continue;
				}
				case 16u:
					num2 = 1324214380;
					continue;
				case 15u:
				{
					int num11;
					if (num < Players.Length)
					{
						num2 = 611474927;
						num11 = 611474927;
					}
					else
					{
						num2 = 1348511922;
						num11 = 1348511922;
					}
					continue;
				}
				case 14u:
					num2 = 1720580741;
					continue;
				case 13u:
					num2 = ((int)num3 * -1114509845) ^ -659379757;
					continue;
				case 12u:
					flag = num4 > 0;
					num2 = 1117513265;
					continue;
				case 11u:
					playerState.Resources = Rules.InitialResources;
					num2 = ((int)num3 * -658243450) ^ 0x6E8E2AB5;
					continue;
				case 10u:
					playerState.Resources -= num4 * Rules.NormalPlanningCost;
					num2 = (int)((num3 * 1377992206) ^ 0x407F81D5);
					continue;
				case 9u:
					player = Players[num];
					playerState = _playerStates[num];
					playerState.Sprint = 0;
					num2 = (int)((num3 * 419956617) ^ 0x440D33F);
					continue;
				case 8u:
					playerState.Resources -= (planningCardsCount - num4) * Rules.NormalPlanningCost;
					num2 = 497585920;
					continue;
				case 7u:
				{
					int num9;
					int num10;
					if (flag)
					{
						num9 = -2086409612;
						num10 = -2086409612;
					}
					else
					{
						num9 = -1081894388;
						num10 = -1081894388;
					}
					num2 = num9 ^ (int)(num3 * 350885410);
					continue;
				}
				case 6u:
					num2 = (int)((num3 * 2037054880) ^ 0x2F5DC5EC);
					continue;
				case 5u:
					playerState.Resources -= num4 * Rules.OverPlanningCost;
					num2 = (int)((num3 * 1135165867) ^ 0x9C6C854);
					continue;
				case 4u:
					num2 = 1328124063;
					continue;
				case 3u:
					playerState.Sprint = 1;
					num2 = (int)(num3 * 1121838405) ^ -244813860;
					continue;
				case 2u:
					playerState.Sprint = -1;
					num2 = (int)(num3 * 248208524) ^ -815682518;
					continue;
				case 1u:
				{
					num4 = 0;
					int num5;
					int num6;
					if (planningCardsCount == 0)
					{
						num5 = 1886831048;
						num6 = 1886831048;
					}
					else
					{
						num5 = 1362754128;
						num6 = 1362754128;
					}
					num2 = num5 ^ (int)(num3 * 631327374);
					continue;
				}
				case 0u:
					num4 = 0;
					num2 = 1078026751;
					continue;
				default:
					return;
				case 23u:
					break;
				case 24u:
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
			int num = 1869348823;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x2A5AE4A2u) % 12u)
				{
				case 11u:
					Print(Game.smethod_1("-- BEGINNING OF TURN ", (++_currentTurn).ToString(), " --"));
					num = 141742633;
					continue;
				case 10u:
					_currentPlayer = 0;
					flag2 = _currentTurn > 0;
					num = ((int)num2 * -1137628556) ^ -25686881;
					continue;
				case 8u:
					num = (int)(num2 * 1237354521) ^ -2078129615;
					continue;
				case 7u:
					num = ((int)num2 * -970797641) ^ -2092425739;
					continue;
				case 5u:
				{
					int num5;
					int num6;
					if (flag2)
					{
						num5 = 233195741;
						num6 = 233195741;
					}
					else
					{
						num5 = 436018974;
						num6 = 436018974;
					}
					num = num5 ^ ((int)num2 * -205810921);
					continue;
				}
				case 4u:
					Print("\n\nGAME STATE\n{0}\n\n-- END OF TURN {1} --\n\n", this, _currentTurn);
					num = ((int)num2 * -1420249690) ^ 0x1522E0B6;
					continue;
				case 3u:
					_currentChanceIndex = (_currentChanceIndex + 1) % _chances.Count;
					num = ((int)num2 * -1806271294) ^ 0x59FF6098;
					continue;
				case 2u:
					PlayerTurn(_currentPlayer);
					num = 1018675955;
					continue;
				case 1u:
				{
					int num3;
					int num4;
					if (!flag)
					{
						num3 = 513857527;
						num4 = 513857527;
					}
					else
					{
						num3 = 1476986075;
						num4 = 1476986075;
					}
					num = num3 ^ ((int)num2 * -127327525);
					continue;
				}
				case 0u:
					Print(Game.smethod_2("RISK CHANCE: ", Rules.RiskChances[_currentChanceIndex].ToString()));
					num = ((int)num2 * -1179550475) ^ 0x3AA7976D;
					continue;
				default:
					return;
				case 6u:
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
		Player player = Players[playerIndex];
		PlayerState playerState = _playerStates[playerIndex];
		Print(Game.smethod_2("\nPLAYER ", playerIndex.ToString()));
		bool flag7 = default(bool);
		bool flag14 = default(bool);
		int num5 = default(int);
		bool flag10 = default(bool);
		int num9 = default(int);
		int num6 = default(int);
		int num17 = default(int);
		bool flag11 = default(bool);
		bool flag15 = default(bool);
		Card card = default(Card);
		PlayerState playerState2 = default(PlayerState);
		bool flag13 = default(bool);
		bool flag9 = default(bool);
		bool flag2 = default(bool);
		bool flag5 = default(bool);
		bool flag8 = default(bool);
		bool flag12 = default(bool);
		bool flag6 = default(bool);
		bool flag = default(bool);
		bool flag4 = default(bool);
		bool flag3 = default(bool);
		while (true)
		{
			int num = 321498869;
			while (true)
			{
				uint num2;
				int num16;
				switch ((num2 = (uint)num ^ 0x17600108u) % 84u)
				{
				case 83u:
				{
					int num34;
					int num35;
					if (flag7)
					{
						num34 = -115470847;
						num35 = -115470847;
					}
					else
					{
						num34 = -1300275357;
						num35 = -1300275357;
					}
					num = num34 ^ (int)(num2 * 1902888244);
					continue;
				}
				case 82u:
					playerState.State = State.Won;
					num = (int)((num2 * 295418423) ^ 0x56E28E62);
					continue;
				case 81u:
					num = ((int)num2 * -1594512125) ^ -855315847;
					continue;
				case 80u:
					Print(Game.smethod_2("\t", (playerState != null) ? Game.smethod_5((object)playerState) : null));
					num = 673048144;
					continue;
				case 79u:
					num = ((int)num2 * -1015878119) ^ 0x1D1DFE42;
					continue;
				case 78u:
					num = ((int)num2 * -322008518) ^ -513476747;
					continue;
				case 77u:
					num = ((int)num2 * -864022490) ^ 0x7DC5A164;
					continue;
				case 76u:
					flag14 = num5 < _playerStates.Length;
					num = 657373696;
					continue;
				case 75u:
					playerState.Sprint++;
					num = (int)(num2 * 878655952) ^ -898644952;
					continue;
				case 74u:
				{
					int num24;
					int num25;
					if (flag10)
					{
						num24 = -2004795735;
						num25 = -2004795735;
					}
					else
					{
						num24 = -1634604647;
						num25 = -1634604647;
					}
					num = num24 ^ ((int)num2 * -378710045);
					continue;
				}
				case 73u:
					Losers.Add(num9);
					num = ((int)num2 * -1372387967) ^ 0xA9B7014;
					continue;
				case 72u:
					num = (int)((num2 * 64834416) ^ 0x6A0F7BA8);
					continue;
				case 71u:
					Print(playerState.State);
					num = ((int)num2 * -827436486) ^ 0x21D7A865;
					continue;
				case 70u:
					num6 = Game.smethod_3(0, num17);
					num = ((int)num2 * -1567651091) ^ 0x4109B87F;
					continue;
				case 69u:
				{
					int num10;
					int num11;
					if (num9 == playerIndex)
					{
						num10 = -1193956346;
						num11 = -1193956346;
					}
					else
					{
						num10 = -100693250;
						num11 = -100693250;
					}
					num = num10 ^ ((int)num2 * -1033613638);
					continue;
				}
				case 68u:
				{
					int num38;
					int num39;
					if (!flag11)
					{
						num38 = 690707530;
						num39 = 690707530;
					}
					else
					{
						num38 = 428579318;
						num39 = 428579318;
					}
					num = num38 ^ (int)(num2 * 1577387427);
					continue;
				}
				case 67u:
					num = ((int)num2 * -629168522) ^ 0x9FC72BA;
					continue;
				case 66u:
					num = 712316339;
					continue;
				case 65u:
				{
					int num30;
					int num31;
					if (flag15)
					{
						num30 = 1140365300;
						num31 = 1140365300;
					}
					else
					{
						num30 = 1686517363;
						num31 = 1686517363;
					}
					num = num30 ^ (int)(num2 * 771497441);
					continue;
				}
				case 63u:
					num16 = ((card.Type == 4) ? 1 : 0);
					goto IL_0270;
				case 62u:
					playerState2 = _playerStates[num5];
					playerState2.Resources -= Game.smethod_3(0, num6 - Players[num5].PlannedForCard(card.Type));
					num = ((int)num2 * -2009604165) ^ -895026507;
					continue;
				case 61u:
					num = 1121673395;
					continue;
				case 60u:
					num = 192620580;
					continue;
				case 59u:
					num = (int)(num2 * 1095282710) ^ -1686775027;
					continue;
				case 58u:
					num = ((int)num2 * -1842050723) ^ 0x108CFAA;
					continue;
				case 57u:
				{
					int num22;
					int num23;
					if (!flag13)
					{
						num22 = 1135432908;
						num23 = 1135432908;
					}
					else
					{
						num22 = 546541432;
						num23 = 546541432;
					}
					num = num22 ^ ((int)num2 * -1683512323);
					continue;
				}
				case 56u:
				{
					int num20;
					int num21;
					if (flag9)
					{
						num20 = -2129859791;
						num21 = -2129859791;
					}
					else
					{
						num20 = -1512793724;
						num21 = -1512793724;
					}
					num = num20 ^ (int)(num2 * 1427060972);
					continue;
				}
				case 55u:
					card = DrawCard();
					flag2 = card.Impact < 0;
					if (Rules.EconomicsAffectsAll)
					{
						num = (int)((num2 * 358804298) ^ 0xDA7BDB9);
						continue;
					}
					num16 = 0;
					goto IL_0270;
				case 54u:
				{
					int num12;
					int num13;
					if (!flag5)
					{
						num12 = 396418986;
						num13 = 396418986;
					}
					else
					{
						num12 = 1984665811;
						num13 = 1984665811;
					}
					num = num12 ^ ((int)num2 * -1149806094);
					continue;
				}
				case 53u:
					Losers.Add(num5);
					num = ((int)num2 * -1604883821) ^ 0x747B820A;
					continue;
				case 52u:
					Print("Still planning");
					num = (int)(num2 * 1969309521) ^ -1043244430;
					continue;
				case 51u:
					num = ((int)num2 * -114769483) ^ 0x37496E92;
					continue;
				case 50u:
					num = ((int)num2 * -102812470) ^ 0x28D60003;
					continue;
				case 49u:
					flag8 = !flag12;
					num = ((int)num2 * -697235596) ^ 0x409EC08B;
					continue;
				case 48u:
				{
					Winners.Add(playerIndex);
					int num36;
					int num37;
					if (Rules.OnlyOneWinner)
					{
						num36 = 2076486096;
						num37 = 2076486096;
					}
					else
					{
						num36 = 510411496;
						num37 = 510411496;
					}
					num = num36 ^ (int)(num2 * 1975577602);
					continue;
				}
				case 47u:
					num = 1220441587;
					continue;
				case 46u:
					num = ((int)num2 * -2011041730) ^ 0x4167304C;
					continue;
				case 45u:
					num9 = 0;
					num = (int)(num2 * 439235520) ^ -650003221;
					continue;
				case 44u:
					flag13 = !Losers.Contains(num9);
					num = 2111658705;
					continue;
				case 43u:
					flag9 = playerState.Sprint > Rules.SprintCount;
					num = 41547696;
					continue;
				case 42u:
					playerState2.State = State.Lose;
					flag15 = !Losers.Contains(num5);
					num = 1329025713;
					continue;
				case 41u:
				{
					int num32;
					int num33;
					if (playerState.Resources < 0)
					{
						num32 = 2096744357;
						num33 = 2096744357;
					}
					else
					{
						num32 = 1177073879;
						num33 = 1177073879;
					}
					num = num32 ^ (int)(num2 * 2126435969);
					continue;
				}
				case 39u:
				{
					int num28;
					int num29;
					if (playerState2.Resources < 0)
					{
						num28 = -1973389891;
						num29 = -1973389891;
					}
					else
					{
						num28 = -1583746525;
						num29 = -1583746525;
					}
					num = num28 ^ (int)(num2 * 1560605517);
					continue;
				}
				case 38u:
					num = ((int)num2 * -543217117) ^ -2007022918;
					continue;
				case 37u:
					num = ((int)num2 * -1410566480) ^ -787942589;
					continue;
				case 36u:
				{
					int num26;
					int num27;
					if (!flag14)
					{
						num26 = 812803366;
						num27 = 812803366;
					}
					else
					{
						num26 = 1220880486;
						num27 = 1220880486;
					}
					num = num26 ^ (int)(num2 * 1743132692);
					continue;
				}
				case 35u:
					flag6 = true;
					num = (int)(num2 * 1849140193) ^ -281616696;
					continue;
				case 34u:
					num = 70836213;
					continue;
				case 33u:
					flag = num9 < _playerStates.Length;
					num = 827816082;
					continue;
				case 32u:
					_finished = true;
					num = ((int)num2 * -868371510) ^ -1719533447;
					continue;
				case 31u:
					num = ((int)num2 * -273025001) ^ 0x35E7474D;
					continue;
				case 30u:
					num = 566982671;
					continue;
				case 29u:
					Print("CARD: {0}, {1}{2} {3} and {4}", card, flag12 ? "ALL " : "", flag2 ? "receives" : "pays", Game.smethod_4(num6), flag6 ? "advance" : "stay");
					num = 1856576749;
					continue;
				case 28u:
					num5 = 0;
					num = 1664642746;
					continue;
				case 27u:
					num = 1069751591;
					continue;
				case 26u:
					flag11 = !_dice.Roll(_chances[_currentChanceIndex]);
					num = 913409284;
					continue;
				case 25u:
					flag10 = playerState.State != State.Playing;
					num = ((int)num2 * -425025789) ^ -213079579;
					continue;
				case 24u:
					num = (int)((num2 * 1451053097) ^ 0xEE4D78F);
					continue;
				case 23u:
				{
					int num18;
					int num19;
					if (!flag8)
					{
						num18 = 1954704001;
						num19 = 1954704001;
					}
					else
					{
						num18 = 1546087974;
						num19 = 1546087974;
					}
					num = num18 ^ ((int)num2 * -1439009057);
					continue;
				}
				case 22u:
					num = 1833370998;
					continue;
				case 21u:
					Losers.Add(playerIndex);
					num = ((int)num2 * -2074898050) ^ -919579429;
					continue;
				case 20u:
					playerState.Resources -= num6;
					num = ((int)num2 * -369493898) ^ 0xF616499;
					continue;
				case 19u:
					num9++;
					num = 1029916969;
					continue;
				case 18u:
					flag6 = true;
					Print("CARD: none, advance");
					num = ((int)num2 * -1323651716) ^ 0x4F962FC6;
					continue;
				case 17u:
					num17 = card.Impact - player.PlannedForCard(card.Type);
					flag6 = num17 < Rules.StayOnSprintMinDiff;
					num = ((int)num2 * -972476212) ^ 0x3289D4BA;
					continue;
				case 16u:
					num = ((int)num2 * -392404411) ^ 0x44935FA2;
					continue;
				case 15u:
					flag7 = flag6;
					num = 1836958723;
					continue;
				case 14u:
					num = 1252052854;
					continue;
				case 13u:
					flag6 = false;
					num = 806999140;
					continue;
				case 12u:
					num = ((int)num2 * -1117870288) ^ -1707613322;
					continue;
				case 11u:
					flag5 = playerState.Sprint < 0;
					num = 1193528266;
					continue;
				case 10u:
					flag4 = !Losers.Contains(playerIndex);
					num = ((int)num2 * -248441336) ^ 0x40C1E9E9;
					continue;
				case 9u:
					num = (int)(num2 * 2144374712) ^ -807665599;
					continue;
				case 8u:
				{
					int num14;
					int num15;
					if (flag3)
					{
						num14 = 1764963311;
						num15 = 1764963311;
					}
					else
					{
						num14 = 964916599;
						num15 = 964916599;
					}
					num = num14 ^ ((int)num2 * -374812575);
					continue;
				}
				case 7u:
					num = (int)((num2 * 1585296842) ^ 0x3B8A06BF);
					continue;
				case 6u:
					num5++;
					num = 1299504464;
					continue;
				case 5u:
				{
					int num7;
					int num8;
					if (!flag4)
					{
						num7 = -1986655942;
						num8 = -1986655942;
					}
					else
					{
						num7 = -933395346;
						num8 = -933395346;
					}
					num = num7 ^ ((int)num2 * -1020471873);
					continue;
				}
				case 4u:
					flag3 = !flag2;
					num = (int)(num2 * 116033619) ^ -1944350780;
					continue;
				case 3u:
					num6 = card.Impact;
					num = ((int)num2 * -979985489) ^ 0x79275E56;
					continue;
				case 2u:
				{
					int num3;
					int num4;
					if (!flag)
					{
						num3 = 956538568;
						num4 = 956538568;
					}
					else
					{
						num3 = 1374694140;
						num4 = 1374694140;
					}
					num = num3 ^ ((int)num2 * -537469117);
					continue;
				}
				case 1u:
					playerState.Sprint++;
					num = (int)(num2 * 734709401) ^ -958784014;
					continue;
				case 0u:
					playerState.State = State.Lose;
					num = (int)((num2 * 2055977591) ^ 0x364B2276);
					continue;
				default:
					return;
				case 64u:
					break;
				case 40u:
					return;
					IL_0270:
					flag12 = (byte)num16 != 0;
					num = 1263055864;
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
			int num = -813304233;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xB9AD3F77u) % 9u)
				{
				case 8u:
					num = ((int)num2 * -1996967091) ^ 0x1A43DA82;
					continue;
				case 7u:
					num = (int)(num2 * 826131946) ^ -1266625717;
					continue;
				case 6u:
					_deck.RemoveAt(0);
					result = card;
					num = ((int)num2 * -54161482) ^ 0x71B75E86;
					continue;
				case 5u:
					ShuffleCards();
					num = (int)((num2 * 259231923) ^ 0x280AE8E4);
					continue;
				case 3u:
				{
					int num3;
					int num4;
					if (flag)
					{
						num3 = -1339823980;
						num4 = -1339823980;
					}
					else
					{
						num3 = -523925613;
						num4 = -523925613;
					}
					num = num3 ^ (int)(num2 * 1288269794);
					continue;
				}
				case 2u:
					card = _deck[0];
					num = -1112131817;
					continue;
				case 1u:
					flag = _deck.Count <= 0;
					num = (int)((num2 * 1335483003) ^ 0x364A3355);
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

	public string ToString(bool initial)
	{
		string text = "";
		bool flag = default(bool);
		int num3 = default(int);
		string result = default(string);
		while (true)
		{
			int num = 1175283520;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x5BF0769u) % 9u)
				{
				case 8u:
				{
					int num4;
					int num5;
					if (!flag)
					{
						num4 = -99234985;
						num5 = -99234985;
					}
					else
					{
						num4 = -2029509098;
						num5 = -2029509098;
					}
					num = num4 ^ (int)(num2 * 1039219160);
					continue;
				}
				case 7u:
					num3++;
					num = (int)(num2 * 1624674232) ^ -791606002;
					continue;
				case 5u:
					result = text;
					num = ((int)num2 * -849701543) ^ 0x719D53A6;
					continue;
				case 4u:
					num = (int)((num2 * 413226313) ^ 0x5851EDD0);
					continue;
				case 3u:
					flag = num3 < _playerStates.Length;
					num = 1440979702;
					continue;
				case 1u:
					num3 = 0;
					num = ((int)num2 * -1680759007) ^ 0x35E5DD47;
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
					num = 1569813225;
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
			int num = 83150331;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x3DA3476Du) % 3u)
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
				num = ((int)num2 * -766531538) ^ 0x429A9A93;
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
