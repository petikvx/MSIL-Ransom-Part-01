using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Net;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;
using BookMarkingSites;
using MetroFramework;
using MetroFramework.Controls;
using PinBot;
using SBLogic.DataAccessLayer;
using SBLogic.LogicLayer;
using WindowsFormsApplication1;

namespace Poshmark_tools;

public class Pro_pinterest : UserControl
{
	private List<AccountDetail> listPinterest = new List<AccountDetail>();

	private DbController dbController = new DbController();

	private CHelperFunctions cHelper = new CHelperFunctions();

	private DataTable lstData = new DataTable();

	private string localDescription = string.Empty;

	private string localWords = string.Empty;

	private Thread th;

	private IContainer components = null;

	private MetroButton btnStart;

	public MetroTextBox tbdelay;

	private MetroButton TestPinAccounts;

	public MetroTextBox username_pinterest;

	public MetroTextBox password_pinterest;

	private MetroLabel metroLabel1;

	private MetroLabel metroLabel2;

	private MetroLabel metroLabel3;

	public DataGridView dataGridView1__pinterest;

	private DataGridViewTextBoxColumn Title;

	private DataGridViewTextBoxColumn Description;

	private DataGridViewTextBoxColumn Price;

	private DataGridViewTextBoxColumn Image;

	private DataGridViewTextBoxColumn Link;

	private MetroLabel metroLabel4;

	private MetroLabel label18;

	public MetroCheckBox allItem_pinterest_checkBox1;

	public MetroTextBox quantity_pinterest_textBox2;

	public MetroComboBox board_dropdown;

	private MetroLabel metroLabel5;

	public List<AccountDetail> PinterestList
	{
		get
		{
			return listPinterest;
		}
		set
		{
			listPinterest = value;
		}
	}

	public Pro_pinterest()
	{
		InitializeComponent();
		listPinterest = new List<AccountDetail>();
		listPinterest = dbController.GetAccsOfAGroup("Main", "Pinterest");
		PinterestList = listPinterest;
		dataGridView1__pinterest.get_Rows().Clear();
		((Control)dataGridView1__pinterest).Refresh();
	}

	public void start_pin__posh()
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Expected O, but got Unknown
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Expected O, but got Unknown
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Expected O, but got Unknown
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Expected O, but got Unknown
		//IL_0130: Unknown result type (might be due to invalid IL or missing references)
		//IL_0239: Unknown result type (might be due to invalid IL or missing references)
		//IL_0243: Expected O, but got Unknown
		//IL_027e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0283: Unknown result type (might be due to invalid IL or missing references)
		//IL_0289: Expected O, but got Unknown
		//IL_029c: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a6: Expected O, but got Unknown
		((Control)btnStart).Invoke((Delegate)(MethodInvoker)delegate
		{
			((Control)btnStart).set_Enabled(false);
		});
		MetroTextBox status_textBox = Form1.mainform.status_textBox1;
		object obj = _003C_003Ec._003C_003E9__11_1;
		if (obj == null)
		{
			MethodInvoker val = delegate
			{
				((Control)Form1.mainform.status_textBox1).set_Text("Starting Extracting Data From Closet\r\n");
			};
			obj = (object)val;
			_003C_003Ec._003C_003E9__11_1 = val;
		}
		((Control)status_textBox).Invoke((Delegate)obj);
		((Control)dataGridView1__pinterest).Invoke((Delegate)(MethodInvoker)delegate
		{
			dataGridView1__pinterest.get_Rows().Clear();
		});
		((Control)dataGridView1__pinterest).Invoke((Delegate)(MethodInvoker)delegate
		{
			((Control)dataGridView1__pinterest).Refresh();
		});
		try
		{
			if (!Directory.Exists(Directory.GetCurrentDirectory() + "\\images"))
			{
				Directory.CreateDirectory(Directory.GetCurrentDirectory() + "\\images");
			}
			string[] files = Directory.GetFiles(Directory.GetCurrentDirectory() + "\\\\images\\\\");
			string[] array = files;
			foreach (string path in array)
			{
				File.Delete(path);
			}
		}
		catch
		{
		}
		string text = Form1.lg.check_who_is_logined(Form1.ck);
		string closet_name = "";
		string text2 = "";
		if (text != null)
		{
			closet_name = text.Substring(text.LastIndexOf("/") + 1, text.Length - (text.LastIndexOf("/") + 1));
		}
		else
		{
			MessageBox.Show("Eror101");
		}
		text2 = ((!((CheckBox)allItem_pinterest_checkBox1).get_Checked()) ? ((Control)quantity_pinterest_textBox2).get_Text() : Form1.ed.get_logined_available_items(Form1.ck));
		string token = Form1.ed.return_csrf_token(Form1.ck);
		string party_id = Form1.ed.get_eventid(Form1.ck, token);
		List<extract_data.Listing_info> list = Form1.ed.extract_listings_from_closet(closet_name, text2, party_id, ref token, ref Form1.ck, default(EditSchdParameters.SchdParametersStruct));
		foreach (extract_data.Listing_info listing in list)
		{
			extract_data.Listng_data Ld = default(extract_data.Listng_data);
			Ld = Form1.ed.extract_listings_data_listinglink(listing.listing_link.Replace("share?post_id=", ""), ref token, ref Form1.ck);
			((Control)dataGridView1__pinterest).Invoke((Delegate)(MethodInvoker)delegate
			{
				dataGridView1__pinterest.get_Rows().Add(new object[5] { Ld.title, Ld.description, Ld.price, Ld.image_url, listing.listing_link });
			});
		}
		MetroTextBox status_textBox2 = Form1.mainform.status_textBox1;
		object obj3 = _003C_003Ec._003C_003E9__11_5;
		if (obj3 == null)
		{
			MethodInvoker val2 = delegate
			{
				((Control)Form1.mainform.status_textBox1).set_Text("Data Extraction Completed from poshmark, click upload button to upload on Pinterest\r\n");
			};
			obj3 = (object)val2;
			_003C_003Ec._003C_003E9__11_5 = val2;
		}
		((Control)status_textBox2).Invoke((Delegate)obj3);
		((Control)btnStart).Invoke((Delegate)(MethodInvoker)delegate
		{
			((Control)btnStart).set_Enabled(true);
		});
	}

	private void btnStart_Click(object sender, EventArgs e)
	{
		bool flag = true;
		if (((ComboBox)board_dropdown).get_SelectedItem() != null)
		{
			foreach (AccountDetail pinterest in PinterestList)
			{
				pinterest.ShortenUrl = ((ComboBox)board_dropdown).get_SelectedItem().ToString();
				if (pinterest.Checked && (pinterest.ShortenUrl == null || pinterest.ShortenUrl == ""))
				{
					flag = false;
					Form1.mainform.status_textBox1.AppendText("Select Board of " + pinterest.UserNameTemp + "\r\n");
				}
			}
		}
		else
		{
			Form1.mainform.status_textBox1.AppendText("Select Board First\r\n");
			flag = false;
		}
		if (flag)
		{
			List<extract_data.Listng_data> ListingsDetails_list = new List<extract_data.Listng_data>();
			for (int i = 0; i < dataGridView1__pinterest.get_Rows().get_Count(); i++)
			{
				extract_data.Listng_data item = default(extract_data.Listng_data);
				item.title = dataGridView1__pinterest.get_Rows().get_Item(i).get_Cells()
					.get_Item(0)
					.get_Value()
					.ToString();
				item.price = dataGridView1__pinterest.get_Rows().get_Item(i).get_Cells()
					.get_Item(2)
					.get_Value()
					.ToString();
				item.description = dataGridView1__pinterest.get_Rows().get_Item(i).get_Cells()
					.get_Item(1)
					.get_Value()
					.ToString();
				item.image_link = dataGridView1__pinterest.get_Rows().get_Item(i).get_Cells()
					.get_Item(3)
					.get_Value()
					.ToString();
				item.listing_link = dataGridView1__pinterest.get_Rows().get_Item(i).get_Cells()
					.get_Item(4)
					.get_Value()
					.ToString();
				item.listing_link = item.listing_link.Replace("share?post_id=", "");
				ListingsDetails_list.Add(item);
			}
			Form1.mainform.status_textBox1.AppendText("Upload Process Started.\r\n");
			th = new Thread((ThreadStart)delegate
			{
				PerformAction(ListingsDetails_list);
			});
			th.IsBackground = true;
			th.Start();
		}
		else
		{
			Form1.mainform.status_textBox1.AppendText("Login to pinterest, select board, click start to fetch poshmark listings, then click upload button to upload on pinterest\r\n");
		}
	}

	private void PerformAction(List<extract_data.Listng_data> Listings_data)
	{
		string delay = "";
		((Control)this).Invoke((Delegate)(Action)delegate
		{
			delay = ((Control)tbdelay).get_Text();
		});
		string title;
		foreach (extract_data.Listng_data r in Listings_data)
		{
			try
			{
				((Control)this).Invoke((Delegate)(Action)delegate
				{
					((Control)btnStart).set_Enabled(false);
				});
				string image_link = r.image_link;
				string fName = string.Empty;
				((Control)this).Invoke((Delegate)(Action)delegate
				{
					Form1.mainform.status_textBox1.AppendText("Downloading Image from Poshmark, " + r.title + "\r\n");
				});
				string txt = image_link;
				title = r.title;
				string description = r.description;
				string listing_link = r.listing_link;
				SaveImageToDisk(txt, ref fName);
				fName = Environment.CurrentDirectory + "\\App\\Images\\" + fName;
				string input = title + "%2C" + description.Replace("\r\n", "").Replace("\t", " ");
				input = Regex.Replace(input, "[^a-zA-Z0-9.: ]", "");
				if (File.Exists(fName))
				{
					foreach (AccountDetail item in PinterestList)
					{
						if (!item.Checked || item.ShortenUrl == null || !(item.ShortenUrl != ""))
						{
							continue;
						}
						if (item.Cookies == null || item.Cookies == "")
						{
							PinterestClient pinterestClient = new PinterestClient();
							pinterestClient.User = new User();
							pinterestClient.User.Username = item.UserNameTemp;
							pinterestClient.User.Pass = item.Password;
							pinterestClient.User.ProxyUsername = item.ProxyUsername;
							pinterestClient.User.ProxyPasswords = item.ProxyPassword;
							pinterestClient.User.ProxyIp = item.ProxyIP;
							pinterestClient.User.ProxyPort = item.ProxyPort;
							ResponseType responseType = pinterestClient.Login(item.UserNameTemp, item.Password);
							if (responseType == ResponseType.LoginSuccess)
							{
								string prof = "https://www.pinterest.com/";
								if (item.TumblrUrl == "")
								{
									prof += pinterestClient.User.Username;
									dbController.UpdateBlogUrl("Main", item.id.ToString(), prof);
								}
								else
								{
									prof = item.TumblrUrl;
								}
								((Control)this).Invoke((Delegate)(Action)delegate
								{
									item.TumblrUrl = prof;
									item.TestAccountStatus = "Successful";
									((ComboBox)board_dropdown).set_DataSource((object)item.ItemCollection);
								});
								byte[] inArray = ObjectToByteArray(pinterestClient.GetCookies());
								string cookies = Convert.ToBase64String(inArray);
								item.Cookies = cookies;
								dbController.UpdateCookies("Main", item.id.ToString(), cookies);
								List<string> allPinsDescriptins = pinterestClient.GetAllPinsDescriptins(pinterestClient.User.Username);
								bool flag = false;
								foreach (string item2 in allPinsDescriptins)
								{
									string stringBetween = cHelper.GetStringBetween(item2, "\"grid_description\":\"", "\"");
									if (input.ToLower() != "" && input.ToLower() == stringBetween.ToLower())
									{
										flag = true;
									}
								}
								if (flag)
								{
									continue;
								}
								string text = pinterestClient.UploadPin(pinterestClient.User.Username, fName, input, listing_link, item.ShortenUrl);
								if (text != "")
								{
									((Control)this).Invoke((Delegate)(Action)delegate
									{
										Form1.mainform.status_textBox1.AppendText("Pin Uploaded " + title + "\r\n");
									});
								}
							}
							else
							{
								((Control)this).Invoke((Delegate)(Action)delegate
								{
									item.TestAccountStatus = "Login Failed";
									((ComboBox)board_dropdown).set_DataSource((object)item.ItemCollection);
									Form1.mainform.status_textBox1.AppendText("Login Failed\r\n");
								});
							}
							continue;
						}
						byte[] arrBytes = Convert.FromBase64String(item.Cookies.ToString());
						CookieContainer ck = (CookieContainer)ByteArrayToObject(arrBytes);
						PinterestClient pinterestClient2 = new PinterestClient(ck);
						pinterestClient2.User = new User();
						pinterestClient2.User.Username = item.UserNameTemp;
						pinterestClient2.User.Pass = item.Password;
						pinterestClient2.User.ProxyUsername = item.ProxyUsername;
						pinterestClient2.User.ProxyPasswords = item.ProxyPassword;
						pinterestClient2.User.ProxyIp = item.ProxyIP;
						pinterestClient2.User.ProxyPort = item.ProxyPort;
						pinterestClient2.User.Username = item.UserNameTemp;
						pinterestClient2.UserAgent = item.UserAgent;
						ResponseType responseType2 = pinterestClient2.IsLogined();
						if (responseType2 == ResponseType.LoginSuccess)
						{
							input = cHelper.RemoveHtmlTags(input);
							List<string> allPinsDescriptins2 = pinterestClient2.GetAllPinsDescriptins(pinterestClient2.User.Username);
							bool flag2 = false;
							foreach (string item3 in allPinsDescriptins2)
							{
								string stringBetween2 = cHelper.GetStringBetween(item3, "\"grid_description\":\"", "\"");
								if (input.ToLower() != "" && input.ToLower() == stringBetween2.ToLower())
								{
									flag2 = true;
								}
							}
							if (flag2)
							{
								continue;
							}
							string text2 = pinterestClient2.UploadPin(pinterestClient2.User.Username, fName, input, listing_link, item.ShortenUrl);
							if (text2 != "")
							{
								((Control)this).Invoke((Delegate)(Action)delegate
								{
									Form1.mainform.status_textBox1.AppendText("Pin Uploaded in " + item.UserNameTemp + "-> " + title + "\r\n");
								});
							}
							else
							{
								((Control)this).Invoke((Delegate)(Action)delegate
								{
									Form1.mainform.status_textBox1.AppendText("Pin Not Uploaded in " + item.UserNameTemp + "-> " + title + "\r\n");
								});
							}
						}
						else
						{
							((Control)this).Invoke((Delegate)(Action)delegate
							{
								item.TestAccountStatus = "Login Failed";
								((ComboBox)board_dropdown).set_DataSource((object)item.ItemCollection);
								Form1.mainform.status_textBox1.AppendText("Login Failed ->\r\n");
							});
						}
					}
				}
				else
				{
					((Control)this).Invoke((Delegate)(Action)delegate
					{
						Form1.mainform.status_textBox1.AppendText("Not Uploaded because Image not downloaded ->" + title + "\r\n");
					});
				}
				int num = Form1.ed.delay_value_getter(delay);
				Thread.Sleep(num * 1000);
			}
			catch
			{
			}
		}
		((Control)this).Invoke((Delegate)(Action)delegate
		{
			Form1.mainform.status_textBox1.AppendText("Uploading Finished\r\n");
		});
		((Control)this).Invoke((Delegate)(Action)delegate
		{
			((Control)btnStart).set_Enabled(true);
		});
	}

	public void SaveImageToDisk(string txt, ref string fName)
	{
		for (int i = 0; i < 2; i++)
		{
			ServicePointManager.Expect100Continue = true;
			ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12;
			string text = Environment.CurrentDirectory + "\\App";
			try
			{
				WebRequest webRequest = WebRequest.Create(txt);
				ServicePointManager.DefaultConnectionLimit = 1000;
				WebResponse response = webRequest.GetResponse();
				Stream responseStream = response.GetResponseStream();
				MemoryStream memoryStream = new MemoryStream();
				responseStream.CopyTo(memoryStream);
				memoryStream.Position = 0L;
				responseStream = memoryStream;
				Image val = Image.FromStream(responseStream);
				string text2 = Path.GetExtension(txt);
				if (text2.Length > 5 || text2 == "")
				{
					text2 = ".jpg";
				}
				fName = "img_" + dbController.GetTimeInSeconds(DateTime.Now) + text2;
				if (!Directory.Exists(text + "\\Images\\"))
				{
					Directory.CreateDirectory(text + "\\Images\\");
				}
				if (!File.Exists(text + "\\Images\\" + fName))
				{
					val.Save(text + "\\Images\\" + fName);
				}
				else
				{
					fName = "";
				}
				break;
			}
			catch (Exception)
			{
			}
		}
	}

	public byte[] ObjectToByteArray(object obj)
	{
		BinaryFormatter binaryFormatter = new BinaryFormatter();
		using MemoryStream memoryStream = new MemoryStream();
		binaryFormatter.Serialize(memoryStream, obj);
		return memoryStream.ToArray();
	}

	public object ByteArrayToObject(byte[] arrBytes)
	{
		using MemoryStream memoryStream = new MemoryStream();
		BinaryFormatter binaryFormatter = new BinaryFormatter();
		memoryStream.Write(arrBytes, 0, arrBytes.Length);
		memoryStream.Seek(0L, SeekOrigin.Begin);
		return binaryFormatter.Deserialize(memoryStream);
	}

	private void TestPinAccounts_Click(object sender, EventArgs e)
	{
		Thread thread = new Thread(TestAccounts);
		thread.IsBackground = true;
		thread.Start();
	}

	private void TestAccounts()
	{
		try
		{
			listPinterest = new List<AccountDetail>();
			uint timeInSeconds = dbController.GetTimeInSeconds(DateTime.Now);
			AccountDetail accountDetail = new AccountDetail
			{
				Checked = true,
				Notes = "",
				id = timeInSeconds,
				PageAuth = "",
				Password = ((Control)password_pinterest).get_Text(),
				TestAccountStatus = "",
				TrustFlow = "",
				TumblrUrl = "",
				UserNameTemp = ((Control)username_pinterest).get_Text(),
				ProxyIP = "",
				ProxyPassword = "",
				ProxyPort = "",
				ProxyUsername = ""
			};
			listPinterest.Add(accountDetail);
			PinterestList = listPinterest;
			dbController.InsertAccValues(accountDetail, "Main");
			foreach (AccountDetail item in PinterestList)
			{
				if (!item.Checked)
				{
					continue;
				}
				item.TestAccountStatus = "Checking";
				if (item.Cookies == null || item.Cookies == "")
				{
					PinterestClient pinterestClient = new PinterestClient();
					pinterestClient.User = new User();
					pinterestClient.User.Username = item.UserNameTemp;
					pinterestClient.User.Pass = item.Password;
					pinterestClient.User.ProxyUsername = item.ProxyUsername;
					pinterestClient.User.ProxyPasswords = item.ProxyPassword;
					pinterestClient.User.ProxyIp = item.ProxyIP;
					pinterestClient.User.ProxyPort = item.ProxyPort;
					ResponseType responseType = pinterestClient.Login(item.UserNameTemp, item.Password);
					if (responseType == ResponseType.LoginSuccess)
					{
						string prof3 = "https://www.pinterest.com/";
						if (item.TumblrUrl == "")
						{
							prof3 += pinterestClient.User.Username;
							dbController.UpdateBlogUrl("Main", item.id.ToString(), prof3);
						}
						else
						{
							prof3 = item.TumblrUrl;
						}
						List<string> boardNames = pinterestClient.GetBoardNames();
						((Control)this).Invoke((Delegate)(Action)delegate
						{
							item.ItemCollection.Clear();
							((ComboBox)board_dropdown).get_Items().Clear();
						});
						foreach (string item2 in boardNames)
						{
							string name2 = cHelper.GetStringBetween("?" + item2, "?", "\"");
							((Control)this).Invoke((Delegate)(Action)delegate
							{
								item.ItemCollection.Add(name2);
								((ComboBox)board_dropdown).get_Items().Add((object)name2);
							});
						}
						((Control)this).Invoke((Delegate)(Action)delegate
						{
							item.TumblrUrl = prof3;
							item.TestAccountStatus = "Successful";
						});
						byte[] inArray = ObjectToByteArray(pinterestClient.GetCookies());
						string cookies = Convert.ToBase64String(inArray);
						item.Cookies = cookies;
						dbController.UpdateCookies("Main", item.id.ToString(), cookies);
						item.ItemCollection.Add("Tuhheed");
					}
					else
					{
						((Control)this).Invoke((Delegate)(Action)delegate
						{
							item.TestAccountStatus = "Login Failed";
							((ComboBox)board_dropdown).set_DataSource((object)item.ItemCollection);
							((ComboBox)board_dropdown).get_Items().Clear();
						});
					}
					continue;
				}
				byte[] arrBytes = Convert.FromBase64String(item.Cookies.ToString());
				CookieContainer ck = (CookieContainer)ByteArrayToObject(arrBytes);
				PinterestClient pinterestClient2 = new PinterestClient(ck);
				pinterestClient2.User = new User();
				pinterestClient2.User.Username = item.UserNameTemp;
				pinterestClient2.User.Pass = item.Password;
				pinterestClient2.User.ProxyUsername = item.ProxyUsername;
				pinterestClient2.User.ProxyPasswords = item.ProxyPassword;
				pinterestClient2.User.ProxyIp = item.ProxyIP;
				pinterestClient2.User.ProxyPort = item.ProxyPort;
				pinterestClient2.User.Username = item.UserNameTemp;
				ResponseType responseType2 = pinterestClient2.IsLogined();
				if (responseType2 == ResponseType.LoginSuccess)
				{
					string prof2 = "https://www.pinterest.com/";
					if (item.TumblrUrl == "")
					{
						prof2 += pinterestClient2.User.Username;
						dbController.UpdateBlogUrl("Main", item.id.ToString(), prof2);
					}
					else
					{
						prof2 = item.TumblrUrl;
					}
					List<string> boardNames2 = pinterestClient2.GetBoardNames();
					((Control)this).Invoke((Delegate)(Action)delegate
					{
						item.ItemCollection.Clear();
						((ComboBox)board_dropdown).get_Items().Clear();
					});
					foreach (string item3 in boardNames2)
					{
						string name = cHelper.GetStringBetween("?" + item3, "?", "\"");
						((Control)this).Invoke((Delegate)(Action)delegate
						{
							item.ItemCollection.Add(name);
							((ComboBox)board_dropdown).get_Items().Add((object)name);
						});
					}
					((Control)this).Invoke((Delegate)(Action)delegate
					{
						item.TumblrUrl = prof2;
						item.TestAccountStatus = "Successful";
					});
					byte[] inArray2 = ObjectToByteArray(pinterestClient2.GetCookies());
					string cookies2 = Convert.ToBase64String(inArray2);
					item.Cookies = cookies2;
					dbController.UpdateCookies("Main", item.id.ToString(), cookies2);
					continue;
				}
				pinterestClient2 = new PinterestClient();
				pinterestClient2.User = new User();
				pinterestClient2.User.Username = item.UserNameTemp;
				pinterestClient2.User.Pass = item.Password;
				pinterestClient2.User.ProxyUsername = item.ProxyUsername;
				pinterestClient2.User.ProxyPasswords = item.ProxyPassword;
				pinterestClient2.User.ProxyIp = item.ProxyIP;
				pinterestClient2.User.ProxyPort = item.ProxyPort;
				pinterestClient2.User.Username = item.UserNameTemp;
				responseType2 = pinterestClient2.Login(item.UserNameTemp, item.Password);
				if (responseType2 == ResponseType.LoginSuccess)
				{
					string prof = "https://www.pinterest.com/";
					if (item.TumblrUrl == "")
					{
						prof += pinterestClient2.User.Username;
						dbController.UpdateBlogUrl("Main", item.id.ToString(), prof);
					}
					else
					{
						prof = item.TumblrUrl;
					}
					((Control)this).Invoke((Delegate)(Action)delegate
					{
						item.TumblrUrl = prof;
						item.TestAccountStatus = "Successful";
					});
					byte[] inArray3 = ObjectToByteArray(pinterestClient2.GetCookies());
					string cookies3 = Convert.ToBase64String(inArray3);
					item.Cookies = cookies3;
					dbController.UpdateCookies("Main", item.id.ToString(), cookies3);
				}
				else
				{
					((Control)this).Invoke((Delegate)(Action)delegate
					{
						item.TestAccountStatus = "Login Failed";
						((ComboBox)board_dropdown).get_Items().Clear();
					});
				}
			}
		}
		catch (Exception)
		{
		}
	}

	private void tbdelay_Click(object sender, EventArgs e)
	{
		MetroTextBox metroTextBox = sender as MetroTextBox;
		((Control)metroTextBox).set_Text("");
		((Control)metroTextBox).set_ForeColor(Color.Black);
	}

	private void tbdelay_KeyPress(object sender, KeyPressEventArgs e)
	{
		MetroTextBox metroTextBox = sender as MetroTextBox;
		string name = ((Control)metroTextBox).get_Name();
		if (name.Contains("delay"))
		{
			if (!char.IsControl(e.get_KeyChar()) && !char.IsDigit(e.get_KeyChar()) && e.get_KeyChar() != ',')
			{
				e.set_Handled(true);
			}
		}
		else if (!char.IsControl(e.get_KeyChar()) && !char.IsDigit(e.get_KeyChar()))
		{
			e.set_Handled(true);
		}
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && components != null)
		{
			components.Dispose();
		}
		((ContainerControl)this).Dispose(disposing);
	}

	private void InitializeComponent()
	{
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Expected O, but got Unknown
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Expected O, but got Unknown
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Expected O, but got Unknown
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Expected O, but got Unknown
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Expected O, but got Unknown
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Expected O, but got Unknown
		//IL_01fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0207: Expected O, but got Unknown
		//IL_07db: Unknown result type (might be due to invalid IL or missing references)
		//IL_07e5: Expected O, but got Unknown
		btnStart = new MetroButton();
		tbdelay = new MetroTextBox();
		TestPinAccounts = new MetroButton();
		username_pinterest = new MetroTextBox();
		password_pinterest = new MetroTextBox();
		metroLabel1 = new MetroLabel();
		metroLabel2 = new MetroLabel();
		metroLabel3 = new MetroLabel();
		dataGridView1__pinterest = new DataGridView();
		Title = new DataGridViewTextBoxColumn();
		Description = new DataGridViewTextBoxColumn();
		Price = new DataGridViewTextBoxColumn();
		Image = new DataGridViewTextBoxColumn();
		Link = new DataGridViewTextBoxColumn();
		metroLabel4 = new MetroLabel();
		allItem_pinterest_checkBox1 = new MetroCheckBox();
		quantity_pinterest_textBox2 = new MetroTextBox();
		label18 = new MetroLabel();
		board_dropdown = new MetroComboBox();
		metroLabel5 = new MetroLabel();
		((ISupportInitialize)dataGridView1__pinterest).BeginInit();
		((Control)this).SuspendLayout();
		((Control)btnStart).set_Location(new Point(599, 88));
		((Control)btnStart).set_Name("btnStart");
		((Control)btnStart).set_Size(new Size(149, 41));
		btnStart.Style = MetroColorStyle.Brown;
		((Control)btnStart).set_TabIndex(0);
		((Control)btnStart).set_Text("upload on Pinterest");
		((Control)btnStart).add_Click((EventHandler)btnStart_Click);
		((Control)tbdelay).set_Location(new Point(132, 106));
		((Control)tbdelay).set_Name("tbdelay");
		((Control)tbdelay).set_Size(new Size(57, 23));
		tbdelay.Style = MetroColorStyle.Brown;
		((Control)tbdelay).set_TabIndex(1);
		((Control)tbdelay).set_Text("5,7");
		tbdelay.UseStyleColors = true;
		((Control)tbdelay).add_Click((EventHandler)tbdelay_Click);
		((Control)tbdelay).add_KeyPress(new KeyPressEventHandler(tbdelay_KeyPress));
		((Control)TestPinAccounts).set_Location(new Point(4, 72));
		((Control)TestPinAccounts).set_Name("TestPinAccounts");
		((Control)TestPinAccounts).set_Size(new Size(127, 29));
		TestPinAccounts.Style = MetroColorStyle.Brown;
		((Control)TestPinAccounts).set_TabIndex(2);
		((Control)TestPinAccounts).set_Text("Login account");
		((Control)TestPinAccounts).add_Click((EventHandler)TestPinAccounts_Click);
		((Control)username_pinterest).set_Location(new Point(132, 13));
		((Control)username_pinterest).set_Name("username_pinterest");
		((Control)username_pinterest).set_Size(new Size(177, 23));
		username_pinterest.Style = MetroColorStyle.Brown;
		((Control)username_pinterest).set_TabIndex(3);
		username_pinterest.UseStyleColors = true;
		((Control)password_pinterest).set_Location(new Point(132, 42));
		((Control)password_pinterest).set_Name("password_pinterest");
		password_pinterest.PasswordChar = '●';
		((Control)password_pinterest).set_Size(new Size(177, 23));
		password_pinterest.Style = MetroColorStyle.Brown;
		((Control)password_pinterest).set_TabIndex(4);
		password_pinterest.UseStyleColors = true;
		password_pinterest.UseSystemPasswordChar = true;
		((Control)metroLabel1).set_AutoSize(true);
		((Control)metroLabel1).set_Location(new Point(4, 13));
		((Control)metroLabel1).set_Name("metroLabel1");
		((Control)metroLabel1).set_Size(new Size(122, 19));
		metroLabel1.Style = MetroColorStyle.Brown;
		((Control)metroLabel1).set_TabIndex(6);
		((Control)metroLabel1).set_Text("Pinterest Username");
		metroLabel1.UseStyleColors = true;
		((Control)metroLabel2).set_AutoSize(true);
		((Control)metroLabel2).set_Location(new Point(4, 42));
		((Control)metroLabel2).set_Name("metroLabel2");
		((Control)metroLabel2).set_Size(new Size(117, 19));
		metroLabel2.Style = MetroColorStyle.Brown;
		((Control)metroLabel2).set_TabIndex(7);
		((Control)metroLabel2).set_Text("Pinterest Password");
		metroLabel2.UseStyleColors = true;
		((Control)metroLabel3).set_AutoSize(true);
		((Control)metroLabel3).set_Location(new Point(4, 109));
		((Control)metroLabel3).set_Name("metroLabel3");
		((Control)metroLabel3).set_Size(new Size(41, 19));
		metroLabel3.Style = MetroColorStyle.Brown;
		((Control)metroLabel3).set_TabIndex(8);
		((Control)metroLabel3).set_Text("Delay");
		metroLabel3.UseStyleColors = true;
		dataGridView1__pinterest.set_AllowUserToAddRows(false);
		dataGridView1__pinterest.set_AutoSizeColumnsMode((DataGridViewAutoSizeColumnsMode)16);
		dataGridView1__pinterest.set_ColumnHeadersHeightSizeMode((DataGridViewColumnHeadersHeightSizeMode)2);
		dataGridView1__pinterest.get_Columns().AddRange((DataGridViewColumn[])(object)new DataGridViewColumn[5]
		{
			(DataGridViewColumn)Title,
			(DataGridViewColumn)Description,
			(DataGridViewColumn)Price,
			(DataGridViewColumn)Image,
			(DataGridViewColumn)Link
		});
		((Control)dataGridView1__pinterest).set_Location(new Point(4, 135));
		((Control)dataGridView1__pinterest).set_Name("dataGridView1__pinterest");
		((Control)dataGridView1__pinterest).set_Size(new Size(769, 208));
		((Control)dataGridView1__pinterest).set_TabIndex(37);
		((DataGridViewColumn)Title).set_HeaderText("Title");
		((DataGridViewColumn)Title).set_Name("Title");
		((DataGridViewBand)Title).set_ReadOnly(true);
		((DataGridViewColumn)Description).set_HeaderText("Description");
		((DataGridViewColumn)Description).set_Name("Description");
		((DataGridViewBand)Description).set_ReadOnly(true);
		((DataGridViewColumn)Price).set_HeaderText("Price");
		((DataGridViewColumn)Price).set_Name("Price");
		((DataGridViewBand)Price).set_ReadOnly(true);
		((DataGridViewColumn)Image).set_HeaderText("image");
		((DataGridViewColumn)Image).set_Name("Image");
		((DataGridViewBand)Image).set_ReadOnly(true);
		((DataGridViewColumn)Link).set_HeaderText("Link");
		((DataGridViewColumn)Link).set_Name("Link");
		((Control)metroLabel4).set_AutoSize(true);
		((Control)metroLabel4).set_Location(new Point(565, 36));
		((Control)metroLabel4).set_Name("metroLabel4");
		((Control)metroLabel4).set_Size(new Size(28, 19));
		metroLabel4.Style = MetroColorStyle.Brown;
		((Control)metroLabel4).set_TabIndex(43);
		((Control)metroLabel4).set_Text("OR");
		metroLabel4.UseStyleColors = true;
		((Control)allItem_pinterest_checkBox1).set_AutoSize(true);
		((Control)allItem_pinterest_checkBox1).set_Location(new Point(599, 39));
		((Control)allItem_pinterest_checkBox1).set_Name("allItem_pinterest_checkBox1");
		((Control)allItem_pinterest_checkBox1).set_Size(new Size(159, 15));
		allItem_pinterest_checkBox1.Style = MetroColorStyle.Brown;
		((Control)allItem_pinterest_checkBox1).set_TabIndex(42);
		((Control)allItem_pinterest_checkBox1).set_Text("Upload All available items");
		allItem_pinterest_checkBox1.UseStyleColors = true;
		((ButtonBase)allItem_pinterest_checkBox1).set_UseVisualStyleBackColor(true);
		((Control)quantity_pinterest_textBox2).set_ForeColor(Color.LightGray);
		((Control)quantity_pinterest_textBox2).set_Location(new Point(515, 35));
		((Control)quantity_pinterest_textBox2).set_Name("quantity_pinterest_textBox2");
		((Control)quantity_pinterest_textBox2).set_Size(new Size(44, 20));
		quantity_pinterest_textBox2.Style = MetroColorStyle.Brown;
		((Control)quantity_pinterest_textBox2).set_TabIndex(41);
		((Control)quantity_pinterest_textBox2).set_Text("30");
		quantity_pinterest_textBox2.UseStyleColors = true;
		((Control)quantity_pinterest_textBox2).add_KeyPress(new KeyPressEventHandler(tbdelay_KeyPress));
		((Control)label18).set_AutoSize(true);
		((Control)label18).set_Location(new Point(515, 13));
		((Control)label18).set_Name("label18");
		((Control)label18).set_Size(new Size(233, 19));
		label18.Style = MetroColorStyle.Brown;
		((Control)label18).set_TabIndex(40);
		((Control)label18).set_Text("# of Listings to import from Poshmark");
		label18.UseStyleColors = true;
		((ListControl)board_dropdown).set_FormattingEnabled(true);
		((ComboBox)board_dropdown).set_ItemHeight(23);
		((Control)board_dropdown).set_Location(new Point(132, 72));
		((Control)board_dropdown).set_Name("board_dropdown");
		((Control)board_dropdown).set_Size(new Size(177, 29));
		board_dropdown.Style = MetroColorStyle.Brown;
		((Control)board_dropdown).set_TabIndex(44);
		((Control)metroLabel5).set_AutoSize(true);
		((Control)metroLabel5).set_Location(new Point(4, 346));
		((Control)metroLabel5).set_Name("metroLabel5");
		((Control)metroLabel5).set_Size(new Size(278, 19));
		metroLabel5.Style = MetroColorStyle.Brown;
		((Control)metroLabel5).set_TabIndex(45);
		((Control)metroLabel5).set_Text("Delete unwanted rows and click upload button");
		metroLabel5.UseStyleColors = true;
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).get_Controls().Add((Control)(object)metroLabel5);
		((Control)this).get_Controls().Add((Control)(object)board_dropdown);
		((Control)this).get_Controls().Add((Control)(object)metroLabel4);
		((Control)this).get_Controls().Add((Control)(object)allItem_pinterest_checkBox1);
		((Control)this).get_Controls().Add((Control)(object)quantity_pinterest_textBox2);
		((Control)this).get_Controls().Add((Control)(object)label18);
		((Control)this).get_Controls().Add((Control)(object)dataGridView1__pinterest);
		((Control)this).get_Controls().Add((Control)(object)metroLabel3);
		((Control)this).get_Controls().Add((Control)(object)metroLabel2);
		((Control)this).get_Controls().Add((Control)(object)metroLabel1);
		((Control)this).get_Controls().Add((Control)(object)password_pinterest);
		((Control)this).get_Controls().Add((Control)(object)username_pinterest);
		((Control)this).get_Controls().Add((Control)(object)TestPinAccounts);
		((Control)this).get_Controls().Add((Control)(object)tbdelay);
		((Control)this).get_Controls().Add((Control)(object)btnStart);
		((Control)this).set_Name("Pro_pinterest");
		((Control)this).set_Size(new Size(784, 403));
		((ISupportInitialize)dataGridView1__pinterest).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
