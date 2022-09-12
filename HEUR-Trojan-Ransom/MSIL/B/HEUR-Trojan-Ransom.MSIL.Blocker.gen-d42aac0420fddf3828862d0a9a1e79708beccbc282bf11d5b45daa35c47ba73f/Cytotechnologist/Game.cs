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
			int num3 = default(int);
			PlayerState[] playerStates = default(PlayerState[]);
			bool finished = default(bool);
			while (true)
			{
				int num = -1413188458;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xB315F400u) % 16u)
					{
					case 15u:
						num = ((int)num2 * -880213798) ^ 0x4FA44636;
						continue;
					case 14u:
						result = false;
						num = ((int)num2 * -1865970916) ^ -1662172201;
						continue;
					case 13u:
						num = (int)((num2 * 1614453882) ^ 0x50E402A2);
						continue;
					case 12u:
					{
						int num6;
						if (num3 >= playerStates.Length)
						{
							num = -1513015419;
							num6 = -1513015419;
						}
						else
						{
							num = -1937545350;
							num6 = -1937545350;
						}
						continue;
					}
					case 11u:
						playerStates = _playerStates;
						num = -629453167;
						continue;
					case 10u:
					{
						PlayerState playerState = playerStates[num3];
						int num7;
						if (playerState.State == State.Playing)
						{
							num = -340920738;
							num7 = -340920738;
						}
						else
						{
							num = -741925596;
							num7 = -741925596;
						}
						continue;
					}
					case 9u:
						result = true;
						num = ((int)num2 * -239746759) ^ 0x76E3D19C;
						continue;
					case 8u:
						num = ((int)num2 * -714139022) ^ -1744102420;
						continue;
					case 7u:
						num = (int)(num2 * 1491202968) ^ -1466433800;
						continue;
					case 6u:
						finished = _finished;
						num = (int)((num2 * 1110891284) ^ 0x3ED95DCA);
						continue;
					case 5u:
						result = true;
						num = (int)(num2 * 76832198) ^ -2123347223;
						continue;
					case 4u:
						num3++;
						num = -1410410532;
						continue;
					case 2u:
					{
						int num4;
						int num5;
						if (finished)
						{
							num4 = -1624148433;
							num5 = -1624148433;
						}
						else
						{
							num4 = -1831371571;
							num5 = -1831371571;
						}
						num = num4 ^ (int)(num2 * 1829754115);
						continue;
					}
					case 1u:
						num3 = 0;
						num = (int)((num2 * 1755521534) ^ 0x5BE69606);
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
			int num = 1745417125;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x71E5875Eu) % 3u)
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
				num = ((int)num2 * -725677063) ^ -51802781;
			}
		}
	}

	public void StartNew()
	{
		while (true)
		{
			int num = -1901887683;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xE86D8B8Bu) % 9u)
				{
				case 8u:
					_currentPlayer = Players.Length;
					_currentTurn = 0;
					_finished = false;
					num = ((int)num2 * -1312227560) ^ 0x78A6BCF2;
					continue;
				case 7u:
					_currentChanceIndex = -1;
					num = (int)(num2 * 1038538057) ^ -1116765283;
					continue;
				case 6u:
					Losers.Clear();
					num = (int)((num2 * 88936548) ^ 0x685BF65A);
					continue;
				case 5u:
					num = ((int)num2 * -516657761) ^ 0x20524A76;
					continue;
				case 3u:
					num = ((int)num2 * -505606979) ^ -296162587;
					continue;
				case 2u:
					ShuffleCards();
					num = ((int)num2 * -176408229) ^ -346900884;
					continue;
				case 1u:
					Winners.Clear();
					num = ((int)num2 * -988273372) ^ 0x7344E083;
					continue;
				case 4u:
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
		Player player = default(Player);
		PlayerState playerState = default(PlayerState);
		bool useOneMorePlanningSprint = default(bool);
		int planningCardsCount = default(int);
		bool flag2 = default(bool);
		while (true)
		{
			bool flag = num < Players.Length;
			int num2 = -459722698;
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)num2 ^ 0xFC366274u) % 26u)
				{
				case 25u:
					num4 = 0;
					num2 = -1566976554;
					continue;
				case 24u:
					player = Players[num];
					playerState = _playerStates[num];
					num2 = -1420609164;
					continue;
				case 23u:
				{
					int num10;
					int num11;
					if (!useOneMorePlanningSprint)
					{
						num10 = 1002461348;
						num11 = 1002461348;
					}
					else
					{
						num10 = 1859877576;
						num11 = 1859877576;
					}
					num2 = num10 ^ ((int)num3 * -2044319568);
					continue;
				}
				case 22u:
					playerState.Sprint = -1;
					num2 = ((int)num3 * -2038813970) ^ 0x36DD7411;
					continue;
				case 21u:
					num++;
					num2 = ((int)num3 * -1097900028) ^ -1700297415;
					continue;
				case 19u:
					playerState.Sprint = 1;
					num2 = ((int)num3 * -99469988) ^ -2007281818;
					continue;
				case 18u:
					num2 = -371018096;
					continue;
				case 17u:
					num2 = ((int)num3 * -1622034026) ^ -658356140;
					continue;
				case 16u:
					num4 = planningCardsCount - Rules.NormalPlanningCount;
					useOneMorePlanningSprint = player.UseOneMorePlanningSprint;
					num2 = -1360579145;
					continue;
				case 15u:
					playerState.Resources -= num4 * Rules.NormalPlanningCost;
					num2 = (int)((num3 * 489902579) ^ 0x8D02685);
					continue;
				case 14u:
				{
					int num8;
					int num9;
					if (flag)
					{
						num8 = -1996026872;
						num9 = -1996026872;
					}
					else
					{
						num8 = -190175766;
						num9 = -190175766;
					}
					num2 = num8 ^ ((int)num3 * -754829364);
					continue;
				}
				case 13u:
					planningCardsCount = player.PlanningCardsCount;
					num4 = 0;
					num2 = ((int)num3 * -2052750218) ^ 0x4A535A26;
					continue;
				case 12u:
					num2 = ((int)num3 * -1328291103) ^ 0x26D06DE3;
					continue;
				case 10u:
					num2 = -1641642507;
					continue;
				case 9u:
					playerState.Resources = Rules.InitialResources;
					num2 = ((int)num3 * -1365824982) ^ -74559505;
					continue;
				case 8u:
				{
					int num7;
					if (num4 > 0)
					{
						num2 = -1275711795;
						num7 = -1275711795;
					}
					else
					{
						num2 = -1383646649;
						num7 = -1383646649;
					}
					continue;
				}
				case 7u:
				{
					int num5;
					int num6;
					if (flag2)
					{
						num5 = 529670063;
						num6 = 529670063;
					}
					else
					{
						num5 = 678496250;
						num6 = 678496250;
					}
					num2 = num5 ^ (int)(num3 * 336133980);
					continue;
				}
				case 6u:
					num2 = ((int)num3 * -1028521952) ^ 0x35EA8B16;
					continue;
				case 5u:
					playerState.State = State.Playing;
					num2 = (int)((num3 * 139052676) ^ 0x128AA53F);
					continue;
				case 4u:
					num2 = ((int)num3 * -1482254252) ^ 0x3F4CFF2F;
					continue;
				case 3u:
					playerState.Resources -= num4 * Rules.OverPlanningCost;
					num2 = ((int)num3 * -1686747617) ^ 0x40DCB8E5;
					continue;
				case 2u:
					flag2 = planningCardsCount == 0;
					num2 = (int)((num3 * 406060743) ^ 0x796E9091);
					continue;
				case 1u:
					playerState.Resources -= (planningCardsCount - num4) * Rules.NormalPlanningCost;
					num2 = -1552775611;
					continue;
				case 0u:
					playerState.Sprint = 0;
					num2 = (int)((num3 * 121027496) ^ 0x40469443);
					continue;
				default:
					return;
				case 11u:
					break;
				case 20u:
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
			int num = 1872981308;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x3D298D9Du) % 15u)
				{
				case 14u:
				{
					int num5;
					int num6;
					if (_currentTurn <= 0)
					{
						num5 = 831697943;
						num6 = 831697943;
					}
					else
					{
						num5 = 394443248;
						num6 = 394443248;
					}
					num = num5 ^ ((int)num2 * -635907785);
					continue;
				}
				case 13u:
					num = ((int)num2 * -1724708018) ^ 0x26159457;
					continue;
				case 12u:
					_currentPlayer = 0;
					num = ((int)num2 * -2117528707) ^ -1003728423;
					continue;
				case 10u:
					Print("\n\nGAME STATE\n{0}\n\n-- END OF TURN {1} --\n\n", this, _currentTurn);
					num = (int)((num2 * 1952910048) ^ 0x7A488533);
					continue;
				case 9u:
					num = ((int)num2 * -1821565510) ^ -1795873136;
					continue;
				case 8u:
					PlayerTurn(_currentPlayer);
					num = 718067057;
					continue;
				case 7u:
					num = ((int)num2 * -537088064) ^ 0x2C2B8480;
					continue;
				case 6u:
					num = ((int)num2 * -719979530) ^ 0x37412B1D;
					continue;
				case 5u:
					_currentPlayer++;
					flag = _currentPlayer >= Players.Length;
					num = ((int)num2 * -1468465669) ^ 0x386FF656;
					continue;
				case 3u:
					Print(Game.smethod_2("RISK CHANCE: ", Rules.RiskChances[_currentChanceIndex].ToString()));
					num = ((int)num2 * -77624545) ^ -1215047503;
					continue;
				case 2u:
					_currentChanceIndex = (_currentChanceIndex + 1) % _chances.Count;
					num = (int)(num2 * 1727978117) ^ -90216720;
					continue;
				case 1u:
				{
					int num3;
					int num4;
					if (flag)
					{
						num3 = 1702143421;
						num4 = 1702143421;
					}
					else
					{
						num3 = 1062208105;
						num4 = 1062208105;
					}
					num = num3 ^ ((int)num2 * -1079878070);
					continue;
				}
				case 0u:
					Print(Game.smethod_1("-- BEGINNING OF TURN ", (++_currentTurn).ToString(), " --"));
					num = 590734227;
					continue;
				default:
					return;
				case 4u:
					break;
				case 11u:
					return;
				}
				break;
			}
		}
	}

	private void PlayerTurn(int playerIndex)
	{
		Player player = Players[playerIndex];
		bool flag2 = default(bool);
		int num3 = default(int);
		int num16 = default(int);
		Card card = default(Card);
		PlayerState playerState = default(PlayerState);
		bool flag8 = default(bool);
		bool flag9 = default(bool);
		bool flag12 = default(bool);
		bool flag5 = default(bool);
		bool flag11 = default(bool);
		bool flag14 = default(bool);
		bool flag3 = default(bool);
		int num22 = default(int);
		int num11 = default(int);
		PlayerState playerState3 = default(PlayerState);
		bool flag7 = default(bool);
		bool flag6 = default(bool);
		bool flag15 = default(bool);
		bool flag = default(bool);
		bool flag4 = default(bool);
		bool flag13 = default(bool);
		bool flag10 = default(bool);
		while (true)
		{
			int num = -1642777215;
			while (true)
			{
				uint num2;
				int num8;
				switch ((num2 = (uint)num ^ 0xC3AA3E9Cu) % 82u)
				{
				case 81u:
					flag2 = num3 == playerIndex;
					num = (int)((num2 * 1817162916) ^ 0x407AF9DE);
					continue;
				case 80u:
					num16 = card.Impact;
					num = ((int)num2 * -1870852091) ^ 0x35E8C9F7;
					continue;
				case 79u:
					Print(playerState.State);
					num = (int)((num2 * 329950048) ^ 0x2C5D67FB);
					continue;
				case 78u:
				{
					int num34;
					int num35;
					if (flag8)
					{
						num34 = 470238418;
						num35 = 470238418;
					}
					else
					{
						num34 = 1519726146;
						num35 = 1519726146;
					}
					num = num34 ^ (int)(num2 * 770448055);
					continue;
				}
				case 77u:
					playerState.Sprint++;
					num = ((int)num2 * -129912101) ^ -1224517754;
					continue;
				case 76u:
				{
					int num36;
					int num37;
					if (!flag9)
					{
						num36 = -43470515;
						num37 = -43470515;
					}
					else
					{
						num36 = -1519607918;
						num37 = -1519607918;
					}
					num = num36 ^ (int)(num2 * 599411245);
					continue;
				}
				case 75u:
				{
					int num25;
					int num26;
					if (flag12)
					{
						num25 = 457442328;
						num26 = 457442328;
					}
					else
					{
						num25 = 1446832888;
						num26 = 1446832888;
					}
					num = num25 ^ ((int)num2 * -1875693283);
					continue;
				}
				case 74u:
					card = DrawCard();
					flag5 = card.Impact < 0;
					if (Rules.EconomicsAffectsAll)
					{
						num = (int)(num2 * 796063178) ^ -1506954291;
						continue;
					}
					num8 = 0;
					goto IL_013f;
				case 73u:
					num = -742245390;
					continue;
				case 72u:
				{
					int num30;
					int num31;
					if (!flag2)
					{
						num30 = -96499236;
						num31 = -96499236;
					}
					else
					{
						num30 = -2107687345;
						num31 = -2107687345;
					}
					num = num30 ^ (int)(num2 * 65732769);
					continue;
				}
				case 71u:
					flag11 = playerState.Sprint > Rules.SprintCount;
					num = -772056002;
					continue;
				case 70u:
					Print(Game.smethod_2("\nPLAYER ", playerIndex.ToString()));
					num = (int)((num2 * 1398532406) ^ 0x5EE13219);
					continue;
				case 69u:
					num = ((int)num2 * -1846829506) ^ -999847456;
					continue;
				case 68u:
					num = ((int)num2 * -563262718) ^ 0x1F8E88DA;
					continue;
				case 67u:
					num = ((int)num2 * -442857879) ^ -1229334492;
					continue;
				case 66u:
				{
					int num23;
					int num24;
					if (!flag14)
					{
						num23 = 27662857;
						num24 = 27662857;
					}
					else
					{
						num23 = 628886859;
						num24 = 628886859;
					}
					num = num23 ^ ((int)num2 * -138709641);
					continue;
				}
				case 65u:
					num = ((int)num2 * -1279947461) ^ 0x984E833;
					continue;
				case 64u:
					num = -622453521;
					continue;
				case 63u:
					playerState = _playerStates[playerIndex];
					num = ((int)num2 * -1403991141) ^ -1655813435;
					continue;
				case 62u:
					flag3 = num22 < Rules.StayOnSprintMinDiff;
					num = ((int)num2 * -235491638) ^ -712086492;
					continue;
				case 61u:
					num = -1727462811;
					continue;
				case 60u:
					flag3 = true;
					num = (int)((num2 * 2106318764) ^ 0x7904F7BD);
					continue;
				case 59u:
					Losers.Add(num11);
					num = ((int)num2 * -1796449121) ^ 0x1D4F300;
					continue;
				case 58u:
					num11++;
					num = -746493201;
					continue;
				case 57u:
					flag12 = flag3;
					num = -1160377981;
					continue;
				case 56u:
					num = -614159328;
					continue;
				case 55u:
					playerState3.Resources -= Game.smethod_3(0, num16 - Players[num11].PlannedForCard(card.Type));
					num = (int)((num2 * 596759010) ^ 0x52BEB9D9);
					continue;
				case 54u:
					num = (int)(num2 * 1750007324) ^ -1527316678;
					continue;
				case 53u:
					flag8 = playerState3.Resources >= 0;
					num = ((int)num2 * -203502984) ^ 0x67106B14;
					continue;
				case 52u:
					playerState.Resources -= num16;
					flag9 = playerState.Resources < 0;
					num = ((int)num2 * -923947329) ^ 0x36CEC8AA;
					continue;
				case 51u:
					flag7 = playerState.State != State.Playing;
					num = ((int)num2 * -1222278518) ^ -147227134;
					continue;
				case 50u:
					flag6 = !Losers.Contains(num3);
					num = -1558983512;
					continue;
				case 49u:
					Losers.Add(playerIndex);
					num = (int)(num2 * 600903985) ^ -1489111042;
					continue;
				case 48u:
					num11 = 0;
					num = -947492871;
					continue;
				case 47u:
					num = ((int)num2 * -634746090) ^ -564357620;
					continue;
				case 46u:
				{
					playerState.State = State.Won;
					Winners.Add(playerIndex);
					int num6;
					int num7;
					if (Rules.OnlyOneWinner)
					{
						num6 = 879546940;
						num7 = 879546940;
					}
					else
					{
						num6 = 726858098;
						num7 = 726858098;
					}
					num = num6 ^ ((int)num2 * -682608044);
					continue;
				}
				case 45u:
					playerState.Sprint++;
					Print("Still planning");
					num = (int)(num2 * 539660515) ^ -1861658704;
					continue;
				case 44u:
					num = -443451522;
					continue;
				case 43u:
					num = ((int)num2 * -2042829715) ^ -877826322;
					continue;
				case 42u:
					num = (int)((num2 * 611303378) ^ 0x59B52ADF);
					continue;
				case 41u:
					num22 = card.Impact - player.PlannedForCard(card.Type);
					num = (int)((num2 * 491416229) ^ 0x3EBE4885);
					continue;
				case 40u:
				{
					int num32;
					int num33;
					if (flag6)
					{
						num32 = -2144116278;
						num33 = -2144116278;
					}
					else
					{
						num32 = -797089418;
						num33 = -797089418;
					}
					num = num32 ^ (int)(num2 * 413143700);
					continue;
				}
				case 39u:
					num = -1123226920;
					continue;
				case 38u:
					num = -1592989005;
					continue;
				case 37u:
					playerState3 = _playerStates[num11];
					num = -1862242187;
					continue;
				case 36u:
					playerState3.State = State.Lose;
					flag14 = !Losers.Contains(num11);
					num = -690960462;
					continue;
				case 34u:
					num16 = Game.smethod_3(0, num22);
					num = (int)((num2 * 1513802057) ^ 0x64F46C19);
					continue;
				case 32u:
				{
					int num28;
					int num29;
					if (flag15)
					{
						num28 = -1371985047;
						num29 = -1371985047;
					}
					else
					{
						num28 = -1161946114;
						num29 = -1161946114;
					}
					num = num28 ^ (int)(num2 * 657832932);
					continue;
				}
				case 31u:
					flag = !_dice.Roll(_chances[_currentChanceIndex]);
					num = -109736642;
					continue;
				case 30u:
					num = ((int)num2 * -658931772) ^ -1462526689;
					continue;
				case 29u:
					flag3 = false;
					num = -1977352922;
					continue;
				case 28u:
				{
					int num27;
					if (num3 < _playerStates.Length)
					{
						num = -750085030;
						num27 = -750085030;
					}
					else
					{
						num = -842197068;
						num27 = -842197068;
					}
					continue;
				}
				case 27u:
					_finished = true;
					num3 = 0;
					num = ((int)num2 * -928234659) ^ 0x5D703380;
					continue;
				case 26u:
					flag4 = playerState.Sprint < 0;
					num = -1196360483;
					continue;
				case 25u:
					num = ((int)num2 * -536375394) ^ 0x7EF7DA6;
					continue;
				case 24u:
					num = ((int)num2 * -1037017764) ^ -1121748994;
					continue;
				case 23u:
				{
					Print("CARD: {0}, {1}{2} {3} and {4}", card, flag13 ? "ALL " : "", flag5 ? "receives" : "pays", Game.smethod_4(num16), flag3 ? "advance" : "stay");
					int num21;
					if (flag13)
					{
						num = -2004843712;
						num21 = -2004843712;
					}
					else
					{
						num = -1151570640;
						num21 = -1151570640;
					}
					continue;
				}
				case 22u:
					num = ((int)num2 * -1039652860) ^ -2119590171;
					continue;
				case 21u:
					num = (int)(num2 * 1833063684) ^ -880644079;
					continue;
				case 20u:
				{
					int num19;
					int num20;
					if (flag10)
					{
						num19 = 520463927;
						num20 = 520463927;
					}
					else
					{
						num19 = 1969548120;
						num20 = 1969548120;
					}
					num = num19 ^ ((int)num2 * -847311394);
					continue;
				}
				case 19u:
					num = ((int)num2 * -1248894423) ^ 0x4C1B6282;
					continue;
				case 18u:
				{
					int num17;
					int num18;
					if (flag11)
					{
						num17 = -769364104;
						num18 = -769364104;
					}
					else
					{
						num17 = -1012748516;
						num18 = -1012748516;
					}
					num = num17 ^ ((int)num2 * -2083531551);
					continue;
				}
				case 17u:
					flag10 = num11 < _playerStates.Length;
					num = -1892480282;
					continue;
				case 16u:
				{
					int num14;
					int num15;
					if (flag7)
					{
						num14 = 30676365;
						num15 = 30676365;
					}
					else
					{
						num14 = 1455653964;
						num15 = 1455653964;
					}
					num = num14 ^ ((int)num2 * -422802288);
					continue;
				}
				case 15u:
					num = (int)((num2 * 770818482) ^ 0x6CA7DAAD);
					continue;
				case 14u:
				{
					playerState.State = State.Lose;
					int num12;
					int num13;
					if (!Losers.Contains(playerIndex))
					{
						num12 = -1940625957;
						num13 = -1940625957;
					}
					else
					{
						num12 = -102338765;
						num13 = -102338765;
					}
					num = num12 ^ (int)(num2 * 1859023475);
					continue;
				}
				case 13u:
				{
					int num9;
					int num10;
					if (!flag4)
					{
						num9 = -1840398183;
						num10 = -1840398183;
					}
					else
					{
						num9 = -1534961195;
						num10 = -1534961195;
					}
					num = num9 ^ ((int)num2 * -265124480);
					continue;
				}
				case 12u:
					num = ((int)num2 * -1444795960) ^ -1376793627;
					continue;
				case 11u:
					num8 = ((card.Type == 4) ? 1 : 0);
					goto IL_013f;
				case 10u:
					Losers.Add(num3);
					num = ((int)num2 * -613560613) ^ -20583116;
					continue;
				case 9u:
					flag3 = true;
					num = ((int)num2 * -29907278) ^ -923995196;
					continue;
				case 8u:
					num = ((int)num2 * -236255275) ^ -573106189;
					continue;
				case 7u:
					num = -1217317467;
					continue;
				case 6u:
				{
					int num4;
					int num5;
					if (flag)
					{
						num4 = 1675794300;
						num5 = 1675794300;
					}
					else
					{
						num4 = 74543223;
						num5 = 74543223;
					}
					num = num4 ^ ((int)num2 * -808595078);
					continue;
				}
				case 5u:
					num = (int)(num2 * 200559637) ^ -1195476004;
					continue;
				case 4u:
					num = (int)(num2 * 282406583) ^ -1931193254;
					continue;
				case 3u:
					num = ((int)num2 * -997828997) ^ -1761114594;
					continue;
				case 2u:
				{
					PlayerState playerState2 = playerState;
					Print(Game.smethod_2("\t", (playerState2 != null) ? Game.smethod_5((object)playerState2) : null));
					num = -1320637807;
					continue;
				}
				case 1u:
					Print("CARD: none, advance");
					num = (int)(num2 * 690066152) ^ -1486378975;
					continue;
				case 0u:
					num3++;
					num = -1347396534;
					continue;
				default:
					return;
				case 35u:
					break;
				case 33u:
					return;
					IL_013f:
					flag13 = (byte)num8 != 0;
					flag15 = !flag5;
					num = -1442121104;
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
			goto IL_0048;
		}
		goto IL_009a;
		IL_009a:
		Card card = _deck[0];
		int num = 1493532643;
		goto IL_006d;
		IL_006d:
		Card result = default(Card);
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)num ^ 0x1D55C40Au) % 7u)
			{
			case 6u:
				ShuffleCards();
				num = ((int)num2 * -1312905655) ^ -1292136242;
				continue;
			case 5u:
				_deck.RemoveAt(0);
				num = (int)((num2 * 1834771785) ^ 0x39598F5B);
				continue;
			case 4u:
				break;
			case 2u:
				result = card;
				num = (int)((num2 * 1387600270) ^ 0x1C775555);
				continue;
			case 0u:
				num = (int)(num2 * 100603067) ^ -1768205982;
				continue;
			case 3u:
				goto IL_009a;
			default:
				return result;
			}
			break;
		}
		goto IL_0048;
		IL_0048:
		num = 432020362;
		goto IL_006d;
	}

	public string ToString(bool initial)
	{
		string text = "";
		bool flag = default(bool);
		int num3 = default(int);
		string result = default(string);
		while (true)
		{
			int num = 871270940;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x51C95930u) % 8u)
				{
				case 7u:
					flag = num3 < _playerStates.Length;
					num = 881913037;
					continue;
				case 5u:
				{
					int num4;
					int num5;
					if (flag)
					{
						num4 = 1651129781;
						num5 = 1651129781;
					}
					else
					{
						num4 = 1724363879;
						num5 = 1724363879;
					}
					num = num4 ^ (int)(num2 * 505744025);
					continue;
				}
				case 4u:
					num3 = 0;
					num = (int)((num2 * 813330716) ^ 0x773BC073);
					continue;
				case 3u:
					num = ((int)num2 * -1047586610) ^ 0x2EC11735;
					continue;
				case 2u:
					result = text;
					num = (int)((num2 * 1777012756) ^ 0x2DF685A1);
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
					num = 87393151;
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
		string result = default(string);
		while (true)
		{
			int num = 418433723;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x755D6418u) % 3u)
				{
				case 1u:
					goto IL_0003;
				case 2u:
					break;
				default:
					return result;
				}
				break;
				IL_0003:
				result = ToString(initial: false);
				num = (int)(num2 * 1350103383) ^ -294993000;
			}
		}
	}

	private void Print(object text, params object[] more)
	{
		string string_ = default(string);
		while (true)
		{
			int num = 1261724271;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x2E022E8u) % 4u)
				{
				case 3u:
					string_ = Game.smethod_7(Game.smethod_5(text), more);
					num = (int)(num2 * 467247226) ^ -47947645;
					continue;
				case 1u:
					Game.smethod_8(_buffer, string_);
					num = (int)((num2 * 592470673) ^ 0x3C2DA50B);
					continue;
				default:
					return;
				case 0u:
					break;
				case 2u:
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
