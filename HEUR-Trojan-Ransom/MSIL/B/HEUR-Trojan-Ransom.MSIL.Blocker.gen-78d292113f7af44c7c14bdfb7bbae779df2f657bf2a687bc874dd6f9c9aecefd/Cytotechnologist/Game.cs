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
			bool result = default(bool);
			int num3 = default(int);
			PlayerState[] playerStates = default(PlayerState[]);
			PlayerState playerState = default(PlayerState);
			while (true)
			{
				int num = 736110319;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xF0D2440u) % 14u)
					{
					case 13u:
						result = true;
						num = ((int)num2 * -251625272) ^ 0x186BE0AF;
						continue;
					case 12u:
						result = false;
						num = (int)(num2 * 1720366294) ^ -2112465509;
						continue;
					case 10u:
						result = true;
						num = (int)(num2 * 329335123) ^ -1952206330;
						continue;
					case 9u:
					{
						int num6;
						if (num3 >= playerStates.Length)
						{
							num = 33786932;
							num6 = 33786932;
						}
						else
						{
							num = 288423794;
							num6 = 288423794;
						}
						continue;
					}
					case 8u:
						playerStates = _playerStates;
						num = 962836437;
						continue;
					case 7u:
					{
						int num7;
						int num8;
						if (finished)
						{
							num7 = -2018995252;
							num8 = -2018995252;
						}
						else
						{
							num7 = -1148958197;
							num8 = -1148958197;
						}
						num = num7 ^ (int)(num2 * 136917355);
						continue;
					}
					case 6u:
						num3++;
						num = 535052807;
						continue;
					case 4u:
						num = ((int)num2 * -1858032839) ^ -2066337491;
						continue;
					case 3u:
						num3 = 0;
						num = (int)((num2 * 896464123) ^ 0x7DFF5C50);
						continue;
					case 2u:
					{
						int num4;
						int num5;
						if (playerState.State == State.Playing)
						{
							num4 = 1709480684;
							num5 = 1709480684;
						}
						else
						{
							num4 = 1435617278;
							num5 = 1435617278;
						}
						num = num4 ^ ((int)num2 * -1040505923);
						continue;
					}
					case 1u:
						num = (int)((num2 * 251281381) ^ 0x71EDA844);
						continue;
					case 0u:
						playerState = playerStates[num3];
						num = 2066851950;
						continue;
					case 11u:
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
		while (true)
		{
			int num = -814841675;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x9098115Cu) % 3u)
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
				num = ((int)num2 * -1045501952) ^ -701979845;
			}
		}
	}

	public void StartNew()
	{
		while (true)
		{
			int num = -1922576518;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xFE88B749u) % 10u)
				{
				case 9u:
					_currentPlayer = Players.Length;
					num = ((int)num2 * -1708869905) ^ -799717644;
					continue;
				case 8u:
					Losers.Clear();
					num = (int)(num2 * 1351372677) ^ -411414820;
					continue;
				case 5u:
					ShuffleCards();
					num = ((int)num2 * -328426853) ^ 0x30B1E480;
					continue;
				case 4u:
					_currentTurn = 0;
					_finished = false;
					num = (int)(num2 * 507577689) ^ -1946298280;
					continue;
				case 3u:
					_chances = new List<float>(Rules.RiskChances);
					num = (int)(num2 * 1970043105) ^ -867877435;
					continue;
				case 2u:
					Winners.Clear();
					num = ((int)num2 * -1375075214) ^ -1914157171;
					continue;
				case 1u:
					_currentChanceIndex = -1;
					num = ((int)num2 * -1781520949) ^ 0x1A649A0D;
					continue;
				case 0u:
					num = ((int)num2 * -947315151) ^ 0x497AC06F;
					continue;
				default:
					return;
				case 6u:
					break;
				case 7u:
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
		int num4 = default(int);
		Player player = default(Player);
		bool flag2 = default(bool);
		bool flag = default(bool);
		while (true)
		{
			int num2 = -1327162452;
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)num2 ^ 0xAAB7369Fu) % 26u)
				{
				case 25u:
					playerState.Resources = Rules.InitialResources;
					num2 = (int)((num3 * 52607316) ^ 0x7CD2EF6F);
					continue;
				case 24u:
				{
					int num11;
					int num12;
					if (planningCardsCount == 0)
					{
						num11 = -192670121;
						num12 = -192670121;
					}
					else
					{
						num11 = -720834044;
						num12 = -720834044;
					}
					num2 = num11 ^ (int)(num3 * 831905920);
					continue;
				}
				case 23u:
					num2 = -306055724;
					continue;
				case 22u:
					num2 = (int)((num3 * 410619160) ^ 0x6365DDD4);
					continue;
				case 21u:
					num2 = (int)((num3 * 306694299) ^ 0x48886D03);
					continue;
				case 20u:
					num2 = -1855932955;
					continue;
				case 19u:
					playerState.Resources -= (planningCardsCount - num4) * Rules.NormalPlanningCost;
					num2 = -1138454877;
					continue;
				case 18u:
					playerState.State = State.Playing;
					num2 = (int)((num3 * 1917241617) ^ 0x67AFFE97);
					continue;
				case 17u:
					num4 = planningCardsCount - Rules.NormalPlanningCount;
					num2 = -2019005929;
					continue;
				case 16u:
					player = Players[num];
					playerState = _playerStates[num];
					num2 = ((int)num3 * -1516012932) ^ -1158922600;
					continue;
				case 15u:
				{
					int num9;
					int num10;
					if (!flag2)
					{
						num9 = 1755768206;
						num10 = 1755768206;
					}
					else
					{
						num9 = 1011649231;
						num10 = 1011649231;
					}
					num2 = num9 ^ (int)(num3 * 1499553032);
					continue;
				}
				case 14u:
				{
					int num7;
					int num8;
					if (flag)
					{
						num7 = 1662396790;
						num8 = 1662396790;
					}
					else
					{
						num7 = 1578279389;
						num8 = 1578279389;
					}
					num2 = num7 ^ (int)(num3 * 1429243531);
					continue;
				}
				case 13u:
					num2 = (int)(num3 * 1017383930) ^ -465303844;
					continue;
				case 12u:
					playerState.Sprint = 1;
					num2 = (int)((num3 * 496333447) ^ 0x2E7E7FE7);
					continue;
				case 11u:
					flag2 = num < Players.Length;
					num2 = -1823247132;
					continue;
				case 10u:
				{
					int num5;
					int num6;
					if (player.UseOneMorePlanningSprint)
					{
						num5 = -1587172383;
						num6 = -1587172383;
					}
					else
					{
						num5 = -668068957;
						num6 = -668068957;
					}
					num2 = num5 ^ ((int)num3 * -1920411195);
					continue;
				}
				case 9u:
					num2 = (int)(num3 * 1793090595) ^ -618566825;
					continue;
				case 8u:
					num++;
					num2 = ((int)num3 * -1545814378) ^ -1539102406;
					continue;
				case 6u:
					playerState.Sprint = -1;
					playerState.Resources -= num4 * Rules.NormalPlanningCost;
					num2 = ((int)num3 * -289758285) ^ 0x2CADDAB2;
					continue;
				case 4u:
					num4 = 0;
					num2 = -1244239142;
					continue;
				case 3u:
					playerState.Resources -= num4 * Rules.OverPlanningCost;
					num2 = ((int)num3 * -975295121) ^ -60687877;
					continue;
				case 2u:
					planningCardsCount = player.PlanningCardsCount;
					num4 = 0;
					num2 = (int)(num3 * 1031504438) ^ -606379583;
					continue;
				case 1u:
					playerState.Sprint = 0;
					num2 = (int)(num3 * 1881988551) ^ -1490987479;
					continue;
				case 0u:
					flag = num4 > 0;
					num2 = -52577449;
					continue;
				default:
					return;
				case 7u:
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
		_currentPlayer++;
		bool flag = default(bool);
		while (true)
		{
			int num = 1223819520;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x718473B6u) % 12u)
				{
				case 11u:
					num = ((int)num2 * -433765342) ^ -377267644;
					continue;
				case 10u:
					num = ((int)num2 * -1529882955) ^ 0x546534D7;
					continue;
				case 9u:
				{
					int num5;
					int num6;
					if (flag)
					{
						num5 = -1635255560;
						num6 = -1635255560;
					}
					else
					{
						num5 = -280829359;
						num6 = -280829359;
					}
					num = num5 ^ ((int)num2 * -1566625678);
					continue;
				}
				case 8u:
					_currentChanceIndex = (_currentChanceIndex + 1) % _chances.Count;
					Print(Game.smethod_2("RISK CHANCE: ", Rules.RiskChances[_currentChanceIndex].ToString()));
					num = ((int)num2 * -2130679869) ^ -275298927;
					continue;
				case 7u:
					num = ((int)num2 * -1842102739) ^ 0x108E07D3;
					continue;
				case 6u:
				{
					int num3;
					int num4;
					if (_currentPlayer >= Players.Length)
					{
						num3 = 2015926402;
						num4 = 2015926402;
					}
					else
					{
						num3 = 415282270;
						num4 = 415282270;
					}
					num = num3 ^ ((int)num2 * -624285629);
					continue;
				}
				case 4u:
					num = ((int)num2 * -1941938178) ^ 0x21D918D3;
					continue;
				case 3u:
					_currentPlayer = 0;
					flag = _currentTurn > 0;
					num = ((int)num2 * -1460911409) ^ 0x170DD82E;
					continue;
				case 1u:
					Print(Game.smethod_1("-- BEGINNING OF TURN ", (++_currentTurn).ToString(), " --"));
					num = 2077478797;
					continue;
				case 0u:
					Print("\n\nGAME STATE\n{0}\n\n-- END OF TURN {1} --\n\n", this, _currentTurn);
					num = (int)((num2 * 810466403) ^ 0x7A27C82);
					continue;
				case 5u:
					break;
				default:
					PlayerTurn(_currentPlayer);
					return;
				}
				break;
			}
		}
	}

	private void PlayerTurn(int playerIndex)
	{
		int num7 = default(int);
		int num4 = default(int);
		Card card = default(Card);
		PlayerState playerState2 = default(PlayerState);
		bool flag9 = default(bool);
		int num3 = default(int);
		bool flag10 = default(bool);
		Player player = default(Player);
		bool flag6 = default(bool);
		bool flag2 = default(bool);
		bool flag5 = default(bool);
		bool flag = default(bool);
		bool flag3 = default(bool);
		bool flag8 = default(bool);
		bool flag7 = default(bool);
		PlayerState playerState = default(PlayerState);
		bool flag4 = default(bool);
		while (true)
		{
			int num = -1121338502;
			while (true)
			{
				uint num2;
				int num5;
				switch ((num2 = (uint)num ^ 0xE4C839E1u) % 80u)
				{
				case 79u:
					Losers.Add(num7);
					num = (int)(num2 * 1186832933) ^ -1440800080;
					continue;
				case 78u:
					num = ((int)num2 * -1804589426) ^ -1169768992;
					continue;
				case 77u:
					num4 = card.Impact;
					num = (int)((num2 * 904611548) ^ 0x6B5AC04B);
					continue;
				case 76u:
					playerState2.Resources -= num4;
					num = ((int)num2 * -2096239572) ^ 0x76F1C14C;
					continue;
				case 75u:
				{
					int num28;
					int num29;
					if (!flag9)
					{
						num28 = 149649228;
						num29 = 149649228;
					}
					else
					{
						num28 = 1961627429;
						num29 = 1961627429;
					}
					num = num28 ^ (int)(num2 * 415842932);
					continue;
				}
				case 74u:
					num = (int)(num2 * 1946769666) ^ -1991450848;
					continue;
				case 73u:
					num = ((int)num2 * -803043834) ^ 0x5CD3095E;
					continue;
				case 72u:
					playerState2.Sprint++;
					num = ((int)num2 * -676934642) ^ 0x3CC496A0;
					continue;
				case 71u:
					num = -57173064;
					continue;
				case 70u:
					Print(playerState2.State);
					num = (int)((num2 * 295016313) ^ 0x17009EC7);
					continue;
				case 69u:
					num = (int)((num2 * 1967982930) ^ 0x41E3EA54);
					continue;
				case 68u:
					num = ((int)num2 * -1729684423) ^ 0x5FB2E8AC;
					continue;
				case 67u:
					num3 = 0;
					num = -888382631;
					continue;
				case 66u:
					num = ((int)num2 * -1286017300) ^ -1595312769;
					continue;
				case 65u:
					num = ((int)num2 * -1800912815) ^ -551484441;
					continue;
				case 64u:
					Losers.Add(playerIndex);
					num = ((int)num2 * -695517883) ^ -955301148;
					continue;
				case 63u:
					playerState2.Sprint++;
					num = ((int)num2 * -127636095) ^ -2121859619;
					continue;
				case 62u:
				{
					int num33;
					int num34;
					if (flag10)
					{
						num33 = -397833065;
						num34 = -397833065;
					}
					else
					{
						num33 = -1377758868;
						num34 = -1377758868;
					}
					num = num33 ^ ((int)num2 * -1030361021);
					continue;
				}
				case 61u:
					num = -1693282325;
					continue;
				case 60u:
					num = -1106696145;
					continue;
				case 59u:
					player = Players[playerIndex];
					num = ((int)num2 * -1786205668) ^ -559789906;
					continue;
				case 58u:
				{
					int num30;
					if (!Losers.Contains(num7))
					{
						num = -162413538;
						num30 = -162413538;
					}
					else
					{
						num = -1656535262;
						num30 = -1656535262;
					}
					continue;
				}
				case 56u:
					flag10 = num7 < _playerStates.Length;
					num = -281345297;
					continue;
				case 55u:
					num = ((int)num2 * -965200649) ^ -1163510854;
					continue;
				case 54u:
					num = ((int)num2 * -1752986049) ^ 0x34A2FEA4;
					continue;
				case 53u:
					_finished = true;
					num = (int)(num2 * 975780577) ^ -1097334286;
					continue;
				case 52u:
					num = (int)(num2 * 791090117) ^ -925294068;
					continue;
				case 51u:
					num = -448954081;
					continue;
				case 50u:
					flag6 = true;
					num = ((int)num2 * -1218493649) ^ 0x1EF7B4FF;
					continue;
				case 49u:
					num = (int)((num2 * 917817913) ^ 0x769CABF4);
					continue;
				case 48u:
					Print("CARD: none, advance");
					num = (int)((num2 * 1702850822) ^ 0x5EB6B095);
					continue;
				case 47u:
					flag6 = false;
					num = -1783722330;
					continue;
				case 46u:
				{
					int num17;
					int num18;
					if (num7 != playerIndex)
					{
						num17 = -217164589;
						num18 = -217164589;
					}
					else
					{
						num17 = -594801660;
						num18 = -594801660;
					}
					num = num17 ^ (int)(num2 * 1597736332);
					continue;
				}
				case 45u:
					num = (int)((num2 * 732194015) ^ 0x18961A2B);
					continue;
				case 44u:
				{
					int num13;
					int num14;
					if (!flag2)
					{
						num13 = -978095746;
						num14 = -978095746;
					}
					else
					{
						num13 = -1909455199;
						num14 = -1909455199;
					}
					num = num13 ^ ((int)num2 * -459831524);
					continue;
				}
				case 43u:
				{
					playerState2 = _playerStates[playerIndex];
					Print(Game.smethod_2("\nPLAYER ", playerIndex.ToString()));
					int num11;
					int num12;
					if (playerState2.State != 0)
					{
						num11 = 1102114142;
						num12 = 1102114142;
					}
					else
					{
						num11 = 228507877;
						num12 = 228507877;
					}
					num = num11 ^ ((int)num2 * -1430484569);
					continue;
				}
				case 42u:
					card = DrawCard();
					flag5 = card.Impact < 0;
					num = ((int)num2 * -1249877694) ^ 0x57928587;
					continue;
				case 41u:
				{
					int num6;
					if (playerState2.Sprint < 0)
					{
						num = -248916794;
						num6 = -248916794;
					}
					else
					{
						num = -194997959;
						num6 = -194997959;
					}
					continue;
				}
				case 40u:
				{
					int num35;
					if (num3 >= _playerStates.Length)
					{
						num = -523731600;
						num35 = -523731600;
					}
					else
					{
						num = -745131383;
						num35 = -745131383;
					}
					continue;
				}
				case 39u:
					num = -1802124160;
					continue;
				case 38u:
				{
					PlayerState playerState3 = playerState2;
					Print(Game.smethod_2("\t", (playerState3 != null) ? Game.smethod_5((object)playerState3) : null));
					num = -1757715096;
					continue;
				}
				case 37u:
					num = ((int)num2 * -1857112720) ^ 0x3939F0D8;
					continue;
				case 35u:
					flag6 = true;
					num = -1784121268;
					continue;
				case 34u:
				{
					int num31;
					int num32;
					if (flag)
					{
						num31 = -1452792567;
						num32 = -1452792567;
					}
					else
					{
						num31 = -1453891261;
						num32 = -1453891261;
					}
					num = num31 ^ ((int)num2 * -2143144326);
					continue;
				}
				case 33u:
				{
					int num26;
					int num27;
					if (flag3)
					{
						num26 = -1895726754;
						num27 = -1895726754;
					}
					else
					{
						num26 = -1729407855;
						num27 = -1729407855;
					}
					num = num26 ^ (int)(num2 * 1369500093);
					continue;
				}
				case 32u:
					num = ((int)num2 * -1654566862) ^ -407918948;
					continue;
				case 31u:
					num = (int)((num2 * 486812116) ^ 0xC4B3AE5);
					continue;
				case 30u:
				{
					int num24;
					int num25;
					if (flag8)
					{
						num24 = 1114251614;
						num25 = 1114251614;
					}
					else
					{
						num24 = 999992438;
						num25 = 999992438;
					}
					num = num24 ^ (int)(num2 * 1502144174);
					continue;
				}
				case 29u:
				{
					int num22;
					int num23;
					if (playerState2.Resources >= 0)
					{
						num22 = 118696379;
						num23 = 118696379;
					}
					else
					{
						num22 = 313973746;
						num23 = 313973746;
					}
					num = num22 ^ ((int)num2 * -2032288159);
					continue;
				}
				case 28u:
					num = ((int)num2 * -399783936) ^ 0x42B5EB36;
					continue;
				case 27u:
					flag7 = playerState.Resources >= 0;
					num = ((int)num2 * -951187130) ^ -476103021;
					continue;
				case 26u:
					num = ((int)num2 * -1051962100) ^ 0x52A17F5A;
					continue;
				case 25u:
					flag9 = flag6;
					num = -1721055766;
					continue;
				case 24u:
					num = -1054079519;
					continue;
				case 23u:
					playerState2.State = State.Won;
					Winners.Add(playerIndex);
					num = ((int)num2 * -1979638255) ^ -155279358;
					continue;
				case 22u:
				{
					playerState.State = State.Lose;
					int num21;
					if (Losers.Contains(num3))
					{
						num = -2073283003;
						num21 = -2073283003;
					}
					else
					{
						num = -833444221;
						num21 = -833444221;
					}
					continue;
				}
				case 21u:
					num5 = ((card.Type == 4) ? 1 : 0);
					goto IL_062a;
				case 20u:
				{
					int num19;
					int num20;
					if (Rules.OnlyOneWinner)
					{
						num19 = -1183859385;
						num20 = -1183859385;
					}
					else
					{
						num19 = -437536745;
						num20 = -437536745;
					}
					num = num19 ^ (int)(num2 * 59081099);
					continue;
				}
				case 19u:
					Print("Still planning");
					num = (int)(num2 * 1564705663) ^ -349835015;
					continue;
				case 18u:
					Losers.Add(num3);
					num = (int)(num2 * 1541214198) ^ -370552727;
					continue;
				case 17u:
					num = ((int)num2 * -1897639864) ^ 0x338F09E;
					continue;
				case 16u:
				{
					int num15;
					int num16;
					if (!flag7)
					{
						num15 = -578426953;
						num16 = -578426953;
					}
					else
					{
						num15 = -1780212112;
						num16 = -1780212112;
					}
					num = num15 ^ ((int)num2 * -541929472);
					continue;
				}
				case 15u:
					Print("CARD: {0}, {1}{2} {3} and {4}", card, flag4 ? "ALL " : "", flag5 ? "receives" : "pays", Game.smethod_4(num4), flag6 ? "advance" : "stay");
					num = -42209307;
					continue;
				case 14u:
					num7++;
					num = -49642423;
					continue;
				case 13u:
					num = (int)(num2 * 1953638303) ^ -10956084;
					continue;
				case 12u:
					num3++;
					num = -888382631;
					continue;
				case 11u:
				{
					int num10 = card.Impact - player.PlannedForCard(card.Type);
					flag6 = num10 < Rules.StayOnSprintMinDiff;
					num4 = Game.smethod_3(0, num10);
					num = ((int)num2 * -1147148794) ^ -759523920;
					continue;
				}
				case 10u:
					num = -1521661001;
					continue;
				case 9u:
				{
					int num8;
					int num9;
					if (!flag4)
					{
						num8 = -32525597;
						num9 = -32525597;
					}
					else
					{
						num8 = -1790337332;
						num9 = -1790337332;
					}
					num = num8 ^ ((int)num2 * -1022916514);
					continue;
				}
				case 8u:
					flag3 = !_dice.Roll(_chances[_currentChanceIndex]);
					num = -1449135232;
					continue;
				case 7u:
					num = (int)(num2 * 397176628) ^ -1852135710;
					continue;
				case 6u:
					num7 = 0;
					num = ((int)num2 * -2087261919) ^ 0x8402CD8;
					continue;
				case 5u:
					playerState2.State = State.Lose;
					flag2 = !Losers.Contains(playerIndex);
					num = ((int)num2 * -1435699992) ^ -167626795;
					continue;
				case 4u:
					num = -1927376195;
					continue;
				case 3u:
					num = ((int)num2 * -1370457850) ^ -187447316;
					continue;
				case 2u:
					if (Rules.EconomicsAffectsAll)
					{
						num = ((int)num2 * -650531562) ^ -914464648;
						continue;
					}
					num5 = 0;
					goto IL_062a;
				case 1u:
					flag = playerState2.Sprint > Rules.SprintCount;
					num = -271027485;
					continue;
				case 0u:
					playerState = _playerStates[num3];
					playerState.Resources -= Game.smethod_3(0, num4 - Players[num3].PlannedForCard(card.Type));
					num = ((int)num2 * -242833812) ^ -1912344934;
					continue;
				default:
					return;
				case 36u:
					break;
				case 57u:
					return;
					IL_062a:
					flag4 = (byte)num5 != 0;
					flag8 = !flag5;
					num = -1300962929;
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
		while (true)
		{
			int num = 1530948412;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x7C9D08A8u) % 9u)
				{
				case 8u:
					ShuffleCards();
					num = ((int)num2 * -743644813) ^ 0x70C259CC;
					continue;
				case 7u:
					result = card;
					num = (int)((num2 * 808367086) ^ 0x1B9FDB09);
					continue;
				case 6u:
				{
					int num3;
					int num4;
					if (_deck.Count > 0)
					{
						num3 = -91237099;
						num4 = -91237099;
					}
					else
					{
						num3 = -1006596245;
						num4 = -1006596245;
					}
					num = num3 ^ ((int)num2 * -2053589624);
					continue;
				}
				case 4u:
					_deck.RemoveAt(0);
					num = ((int)num2 * -2079618608) ^ 0x2664ECB;
					continue;
				case 3u:
					num = (int)((num2 * 1921632187) ^ 0x2440806);
					continue;
				case 1u:
					card = _deck[0];
					num = 1034244225;
					continue;
				case 0u:
					num = ((int)num2 * -312074657) ^ -270731872;
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
		string text = default(string);
		int num3 = default(int);
		string result = default(string);
		while (true)
		{
			int num = 1983978575;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x2397F949u) % 10u)
				{
				case 9u:
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
					num = 554850168;
					continue;
				}
				case 8u:
					num = (int)((num2 * 1886601812) ^ 0x19E996F6);
					continue;
				case 6u:
					num3 = 0;
					num = ((int)num2 * -1819235166) ^ 0x3C87F7D9;
					continue;
				case 5u:
				{
					int num4;
					if (num3 >= _playerStates.Length)
					{
						num = 1592761644;
						num4 = 1592761644;
					}
					else
					{
						num = 809336348;
						num4 = 809336348;
					}
					continue;
				}
				case 4u:
					text = "";
					num = ((int)num2 * -1766134924) ^ 0x64E05D93;
					continue;
				case 3u:
					num3++;
					num = ((int)num2 * -1410358029) ^ 0x66B6F2E5;
					continue;
				case 1u:
					result = text;
					num = (int)(num2 * 2053210602) ^ -688868617;
					continue;
				case 0u:
					num = (int)((num2 * 1694203211) ^ 0x7A28EDC8);
					continue;
				case 2u:
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
			int num = 1806949026;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x48560E0Fu) % 3u)
				{
				case 1u:
					goto IL_000a;
				case 0u:
					break;
				default:
					return result;
				}
				break;
				IL_000a:
				num = ((int)num2 * -40026551) ^ 0x54A1917C;
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
