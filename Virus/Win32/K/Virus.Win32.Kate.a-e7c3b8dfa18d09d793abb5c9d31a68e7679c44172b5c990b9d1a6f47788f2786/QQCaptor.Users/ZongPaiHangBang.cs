using System.Collections.ObjectModel;
using System.Text;
using System.Text.RegularExpressions;
using Helper;
using QQCaptor.Tools;

namespace QQCaptor.Users;

internal class ZongPaiHangBang
{
	public HttpHelper m_hh = new HttpHelper();

	public Collection<PaiMinInfo> m_PaiMinInfoList = new Collection<PaiMinInfo>();

	public string DeleteHtml(string html)
	{
		Regex regex = new Regex("<script[sS]+</script *>", RegexOptions.IgnoreCase);
		Regex regex2 = new Regex(" href *= *[sS]*script *:", RegexOptions.IgnoreCase);
		Regex regex3 = new Regex(" no[sS]*=", RegexOptions.IgnoreCase);
		Regex regex4 = new Regex("<iframe[sS]+</iframe *>", RegexOptions.IgnoreCase);
		Regex regex5 = new Regex("<frameset[sS]+</frameset *>", RegexOptions.IgnoreCase);
		Regex regex6 = new Regex("<img[^>]+>", RegexOptions.IgnoreCase);
		Regex regex7 = new Regex("</p>", RegexOptions.IgnoreCase);
		Regex regex8 = new Regex("<p>", RegexOptions.IgnoreCase);
		Regex regex9 = new Regex("<[^>]*>", RegexOptions.IgnoreCase);
		html = regex.Replace(html, "");
		html = regex2.Replace(html, "");
		html = regex3.Replace(html, " _disibledevent=");
		html = regex4.Replace(html, "");
		html = regex5.Replace(html, "");
		html = regex6.Replace(html, "");
		html = regex7.Replace(html, "");
		html = regex8.Replace(html, "");
		html = regex9.Replace(html, "");
		html = html.Replace(" ", "");
		html = html.Replace("</strong>", "");
		html = html.Replace("<strong>", "");
		return html;
	}

	public string ProGetPaiMin(long iPaiHangPageNo)
	{
		m_PaiMinInfoList.Clear();
		string text = m_hh.Get("http://qbit.100steps.net/javascript/qq_parker.php?page=" + iPaiHangPageNo + "&count=351179&order=&createtime=", Encoding.Default);
		try
		{
			int startIndex = 0;
			int num = 0;
			int num2 = 0;
			int num3 = 1;
			string text2 = "";
			while (true)
			{
				PaiMinInfo paiMinInfo = new PaiMinInfo();
				paiMinInfo.strID = num3.ToString();
				num = text.IndexOf("<td><a href=\"?action=show&qq=", startIndex);
				if (num != -1)
				{
					num2 = text.IndexOf("\">", num);
					if (num != -1 && num2 != -1)
					{
						num += 29;
						startIndex = num2;
						text2 = (paiMinInfo.QQNum = text.Substring(num, num2 - num));
						num = text.IndexOf("\">", startIndex);
						if (num != -1)
						{
							num2 = text.IndexOf("</a></td>", num);
							if (num != -1 && num2 != -1)
							{
								num += 2;
								startIndex = num2;
								text2 = text.Substring(num, num2 - num);
								text2 = (paiMinInfo.QQName = StringChar.ReplaceAllHtml(text2));
								num = text.IndexOf("<td>", startIndex);
								if (num != -1)
								{
									num2 = text.IndexOf("</td>", num);
									if (num != -1 && num2 != -1)
									{
										num += 4;
										startIndex = num2;
										text2 = text.Substring(num, num2 - num);
										paiMinInfo.strZongZiChan = DeleteHtml(text2);
										num = text.IndexOf("<td>", startIndex);
										if (num != -1)
										{
											num2 = text.IndexOf("</td>", num);
											if (num != -1 && num2 != -1)
											{
												num += 4;
												startIndex = num2;
												text2 = (paiMinInfo.strXianJin = text.Substring(num, num2 - num));
												num = text.IndexOf("catch(e){}\">", startIndex);
												if (num != -1)
												{
													num2 = text.IndexOf("</a></td>", num);
													if (num != -1 && num2 != -1)
													{
														num += 12;
														startIndex = num2;
														text2 = (paiMinInfo.strQiChe = text.Substring(num, num2 - num));
														num = text.IndexOf("<td>", startIndex);
														if (num != -1)
														{
															num2 = text.IndexOf("</td>", num);
															if (num != -1 && num2 != -1)
															{
																num += 4;
																startIndex = num2;
																text2 = (paiMinInfo.strJingYan = text.Substring(num, num2 - num));
																num = text.IndexOf("<td><a href=\"?createtime=", startIndex);
																if (num != -1)
																{
																	num2 = text.IndexOf("\">", num);
																	if (num != -1 && num2 != -1)
																	{
																		num += 25;
																		startIndex = num2;
																		text2 = (paiMinInfo.strTime = text.Substring(num, num2 - num));
																		m_PaiMinInfoList.Add(paiMinInfo);
																		num3++;
																		continue;
																	}
																	break;
																}
																break;
															}
															break;
														}
														break;
													}
													break;
												}
												break;
											}
											break;
										}
										break;
									}
									break;
								}
								break;
							}
							break;
						}
						break;
					}
					break;
				}
				break;
			}
		}
		catch
		{
		}
		return null;
	}

	public long GetCount()
	{
		return m_PaiMinInfoList.Count;
	}

	public PaiMinInfo GetPaiMinInfo(int iIndex)
	{
		if (iIndex < m_PaiMinInfoList.Count)
		{
			return m_PaiMinInfoList[iIndex];
		}
		return null;
	}
}
