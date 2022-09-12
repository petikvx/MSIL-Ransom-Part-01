using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Threading;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Controls;
using MySql.Data.MySqlClient;
using Renci.SshNet;

namespace WindowsFormsApplication1;

public class Register : UserControl
{
	private struct status_of_app
	{
		public string status;

		public bool permission;

		public bool pro_tools;

		public bool pro_leads;

		public bool pro_schedules;

		public bool pro_enl;

		public int apps_allowed;
	}

	private Thread messagebox_thread;

	private IContainer components = null;

	private SplitContainer splitContainer1;

	private MetroButton registration_Button1;

	private MetroLabel label1;

	private MetroLabel Alert_label;

	public MetroLabel Regitsration_Status__label;

	public MetroTextBox metroTextBox1;

	private Label label3;

	public MetroTextBox license_key_TextBox1;

	private Label label2;

	public Register()
	{
		InitializeComponent();
	}

	public static DataTable run_querry(string querry)
	{
		string host = "34.73.11.211";
		int port = 20889;
		string username = "poshmarktools";
		string password = "iQ1YOJxvPC5WCQL";
		for (int i = 0; i < 2; i++)
		{
			try
			{
				PasswordConnectionInfo passwordConnectionInfo = new PasswordConnectionInfo(host, port, username, password);
				passwordConnectionInfo.Timeout = TimeSpan.FromSeconds(30.0);
				using SshClient sshClient = new SshClient(passwordConnectionInfo);
				sshClient.Connect();
				if (!sshClient.IsConnected)
				{
					Console.WriteLine("SSH connection has failed: {0}", sshClient.ConnectionInfo.ToString());
				}
				Console.WriteLine("\r\nTrying port forwarding...");
				ForwardedPortLocal forwardedPortLocal = new ForwardedPortLocal("127.0.0.1", 3306u, "127.0.0.1", 3306u);
				sshClient.AddForwardedPort(forwardedPortLocal);
				forwardedPortLocal.Start();
				if (forwardedPortLocal.IsStarted)
				{
					DataTable dataTable = new DataTable();
					string connectionString = "SERVER = 127.0.0.1; PORT = 3306; UID = poshmarktools; PASSWORD = ID7zMSYKBzz0yAb; DATABASE = poshmarktools";
					MySqlConnection mySqlConnection = new MySqlConnection(connectionString);
					MySqlCommand selectCommand = new MySqlCommand(querry, mySqlConnection);
					mySqlConnection.Open();
					MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(selectCommand);
					mySqlDataAdapter.Fill(dataTable);
					mySqlConnection.Close();
					mySqlDataAdapter.Dispose();
					return dataTable;
				}
			}
			catch (Exception)
			{
				try
				{
				}
				catch
				{
				}
			}
		}
		return null;
	}

	public void registration_Button1_Click(object sender, EventArgs e)
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Expected O, but got Unknown
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected O, but got Unknown
		//IL_0154: Unknown result type (might be due to invalid IL or missing references)
		//IL_0159: Unknown result type (might be due to invalid IL or missing references)
		//IL_015f: Expected O, but got Unknown
		//IL_017a: Unknown result type (might be due to invalid IL or missing references)
		//IL_017f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0185: Expected O, but got Unknown
		//IL_0325: Unknown result type (might be due to invalid IL or missing references)
		//IL_032f: Expected O, but got Unknown
		//IL_0347: Unknown result type (might be due to invalid IL or missing references)
		//IL_034c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0352: Expected O, but got Unknown
		//IL_036d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0372: Unknown result type (might be due to invalid IL or missing references)
		//IL_0378: Expected O, but got Unknown
		//IL_0386: Unknown result type (might be due to invalid IL or missing references)
		//IL_0390: Expected O, but got Unknown
		try
		{
			if (!((Control)this).get_IsHandleCreated())
			{
				((Control)this).CreateControl();
			}
			object obj = _003C_003Ec._003C_003E9__3_0;
			if (obj == null)
			{
				MethodInvoker val = delegate
				{
					((Control)Form1.mainform.Start_button1).set_Enabled(false);
				};
				obj = (object)val;
				_003C_003Ec._003C_003E9__3_0 = val;
			}
			((Control)this).Invoke((Delegate)obj);
			object obj2 = _003C_003Ec._003C_003E9__3_1;
			if (obj2 == null)
			{
				MethodInvoker val2 = delegate
				{
					((Control)Form1.mainform.Stop_button1).set_Enabled(false);
				};
				obj2 = (object)val2;
				_003C_003Ec._003C_003E9__3_1 = val2;
			}
			((Control)this).Invoke((Delegate)obj2);
		}
		catch
		{
		}
		try
		{
			if (!(((Control)license_key_TextBox1).get_Text().TrimStart(new char[0]).TrimEnd(new char[0]) != ""))
			{
				return;
			}
			try
			{
				File.WriteAllText(Form1.credential_path, ((Control)license_key_TextBox1).get_Text().TrimStart(new char[0]).TrimEnd(new char[0]));
			}
			catch
			{
			}
			status_of_app sop = activate_deactivate(((Control)license_key_TextBox1).get_Text().TrimStart(new char[0]).TrimEnd(new char[0]));
			if (Form1.status_check_iter < 2)
			{
				if (sop.status == "Not Activated - Problem in Connecting With Server")
				{
					Form1.status_check_iter++;
					return;
				}
			}
			else
			{
				Form1.status_check_iter = 0;
			}
			if (sop.permission)
			{
				object obj5 = _003C_003Ec._003C_003E9__3_2;
				if (obj5 == null)
				{
					MethodInvoker val3 = delegate
					{
						((Control)Form1.mainform.Start_button1).set_Enabled(true);
					};
					obj5 = (object)val3;
					_003C_003Ec._003C_003E9__3_2 = val3;
				}
				((Control)this).Invoke((Delegate)obj5);
				object obj6 = _003C_003Ec._003C_003E9__3_3;
				if (obj6 == null)
				{
					MethodInvoker val4 = delegate
					{
						((Control)Form1.mainform.Stop_button1).set_Enabled(true);
					};
					obj6 = (object)val4;
					_003C_003Ec._003C_003E9__3_3 = val4;
				}
				((Control)this).Invoke((Delegate)obj6);
				string text = ((Control)license_key_TextBox1).get_Text().TrimStart(new char[0]).TrimEnd(new char[0]);
				if ((text[0] == 'v') & (text[1] == 'e') & (text[2] == 'r') & (text[3] == '-') & (text[4] == '2'))
				{
					if (sop.pro_enl)
					{
						Form1.Enl_permission = "permitted";
					}
					else
					{
						Form1.Enl_permission = "Expire";
					}
					Form1.schedule_end_date = Form1.expiry;
					if (sop.pro_schedules)
					{
						Form1.schedule_rows = "9";
					}
					else
					{
						Form1.schedule_rows = "0";
					}
					if (sop.pro_tools)
					{
						Form1.protoll_registration = "permitted";
					}
					else
					{
						Form1.protoll_registration = "Expire";
					}
					if (sop.pro_leads)
					{
						Form1.proLeed_registration = "permitted";
					}
					else
					{
						Form1.proLeed_registration = "Expire";
					}
					Form1.pinterest_registration = "permitted";
					Form1.report_registration = "permitted";
					Form1.bulk_edit_permission = "permitted";
					Form1.app_instances_MAX = sop.apps_allowed;
					Form1.InstaPosh_registration = "permitted";
				}
				else
				{
					Form1.Enl_permission = "permitted";
					Form1.schedule_end_date = Form1.expiry;
					Form1.schedule_rows = "9";
					Form1.protoll_registration = "permitted";
					Form1.proLeed_registration = "permitted";
					Form1.pinterest_registration = "permitted";
					Form1.report_registration = "permitted";
					Form1.bulk_edit_permission = "permitted";
					Form1.app_instances_MAX = 4;
					Form1.InstaPosh_registration = "permitted";
				}
				((Control)this).Invoke((Delegate)(MethodInvoker)delegate
				{
					((Control)Form1.mainform.version_label).set_Text("Version: " + Assembly.GetExecutingAssembly().GetName().Version!.ToString() + ", " + sop.status);
				});
				return;
			}
			object obj7 = _003C_003Ec._003C_003E9__3_5;
			if (obj7 == null)
			{
				MethodInvoker val5 = delegate
				{
					((Control)Form1.mainform.Start_button1).set_Enabled(false);
				};
				obj7 = (object)val5;
				_003C_003Ec._003C_003E9__3_5 = val5;
			}
			((Control)this).Invoke((Delegate)obj7);
			object obj8 = _003C_003Ec._003C_003E9__3_6;
			if (obj8 == null)
			{
				MethodInvoker val6 = delegate
				{
					((Control)Form1.mainform.Stop_button1).set_Enabled(false);
				};
				obj8 = (object)val6;
				_003C_003Ec._003C_003E9__3_6 = val6;
			}
			((Control)this).Invoke((Delegate)obj8);
			((Control)this).Invoke((Delegate)(MethodInvoker)delegate
			{
				((Control)Form1.mainform.version_label).set_Text("Version: " + Assembly.GetExecutingAssembly().GetName().Version!.ToString() + ", " + sop.status);
			});
		}
		catch (Exception)
		{
			if (!Directory.Exists("logs"))
			{
				Directory.CreateDirectory("logs");
			}
			File.AppendAllText("logs//logs.jk", "rg) " + e.ToString() + "\r\n");
		}
	}

	public void force_update_app()
	{
		update_app update_app2 = new update_app();
		update_app2.MakeRequests(Form1.mainform, "false");
	}

	public void ShowMessageBox(string message)
	{
		try
		{
			messagebox_thread.Abort();
		}
		catch
		{
		}
		messagebox_thread = new Thread((ThreadStart)delegate
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			MessageBox.Show(message);
		});
		messagebox_thread.Start();
	}

	private status_of_app activate_deactivate(string license_key)
	{
		//IL_0254: Unknown result type (might be due to invalid IL or missing references)
		//IL_0259: Unknown result type (might be due to invalid IL or missing references)
		//IL_025b: Unknown result type (might be due to invalid IL or missing references)
		//IL_025e: Invalid comparison between Unknown and I4
		//IL_0851: Unknown result type (might be due to invalid IL or missing references)
		//IL_0856: Unknown result type (might be due to invalid IL or missing references)
		//IL_0858: Unknown result type (might be due to invalid IL or missing references)
		//IL_085b: Invalid comparison between Unknown and I4
		//IL_0b73: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b78: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b7a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b7d: Invalid comparison between Unknown and I4
		//IL_0f6b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f70: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f72: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f75: Invalid comparison between Unknown and I4
		//IL_1332: Unknown result type (might be due to invalid IL or missing references)
		//IL_1337: Unknown result type (might be due to invalid IL or missing references)
		//IL_1339: Unknown result type (might be due to invalid IL or missing references)
		//IL_133c: Invalid comparison between Unknown and I4
		status_of_app result = default(status_of_app);
		result.status = "Not permitted";
		result.permission = false;
		try
		{
			string new_user_key = Form1._new_user_key;
			if ((license_key[0] == 'v') & (license_key[1] == 'e') & (license_key[2] == 'r') & (license_key[3] == '-') & (license_key[4] == '2'))
			{
				DataTable dataTable = run_querry("Select * from license_details WHERE password LIKE '" + ((Control)license_key_TextBox1).get_Text().TrimStart(new char[0]).TrimEnd(new char[0]) + "'");
				if (dataTable.Rows.Count > 0)
				{
					string text = dataTable.Rows[0]["status"].ToString();
					string text2 = dataTable.Rows[0]["macid"].ToString();
					string text3 = dataTable.Rows[0]["force_update"].ToString();
					try
					{
						string text4 = dataTable.Rows[0]["pro_tools"].ToString();
						string text5 = dataTable.Rows[0]["pro_leads"].ToString();
						string text6 = dataTable.Rows[0]["enl"].ToString();
						string text7 = dataTable.Rows[0]["schedules"].ToString();
						string s = dataTable.Rows[0]["apps_allowed"].ToString();
						if (text4 != "")
						{
							result.pro_tools = true;
						}
						if (text5 != "")
						{
							result.pro_leads = true;
						}
						if (text6 != "")
						{
							result.pro_enl = true;
						}
						if (text7 != "")
						{
							result.pro_schedules = true;
						}
						try
						{
							int num = int.Parse(s);
							if (num == 0)
							{
								result.apps_allowed = 4;
							}
							else
							{
								result.apps_allowed = num;
							}
						}
						catch
						{
							result.apps_allowed = 4;
						}
					}
					catch
					{
					}
					if (text2 != new_user_key && text2 != "")
					{
						text2 = new_user_key;
						force_stop();
						DialogResult val = MessageBox.Show("This license is activated on someother pc", "Click yes if you want to activate license on this pc", (MessageBoxButtons)4, (MessageBoxIcon)48);
						if ((int)val == 6)
						{
							run_querry(string.Concat("UPDATE license_details SET macid = '", text2, "', status_of_app ='", Form1.today_date_microsolft, "-", Assembly.GetExecutingAssembly().GetName().Version!.ToString(), "' WHERE password LIKE '", license_key, "'"));
							result.permission = true;
							result.status = "Active";
						}
						else
						{
							result.permission = false;
							result.status = "License Activated on Other pc";
						}
					}
					else if (text2 == "")
					{
						run_querry(string.Concat("UPDATE license_details SET macid = '", new_user_key, "', status_of_app ='", Form1.today_date_microsolft, "-", Assembly.GetExecutingAssembly().GetName().Version!.ToString(), "' WHERE password LIKE '", license_key, "'"));
						if (text.ToLower() == "active")
						{
							result.status = "Active";
							result.permission = true;
						}
						else
						{
							result.status = "Not permitted";
							result.permission = false;
						}
					}
					else
					{
						run_querry(string.Concat("UPDATE license_details SET status_of_app ='", Form1.today_date_microsolft, "-", Assembly.GetExecutingAssembly().GetName().Version!.ToString(), "' WHERE password LIKE '", license_key, "'"));
						if (text.ToLower() == "active")
						{
							result.status = "Active";
							result.permission = true;
						}
						else
						{
							result.status = "Not permitted";
							result.permission = false;
						}
					}
					if (!(text3 == ""))
					{
						if (text3 == "0")
						{
							run_querry(string.Concat("UPDATE license_details SET force_update = '', status_of_app ='", Form1.today_date_microsolft, "-", Assembly.GetExecutingAssembly().GetName().Version!.ToString(), "' WHERE password LIKE '", license_key, "'"));
							Thread thread = new Thread(force_update_app);
							thread.Start();
						}
						else
						{
							try
							{
								string text8 = text3;
								DataTable dataTable2 = run_querry(("Select * From user_warning Where id = " + text8) ?? "");
								result.status = dataTable2.Rows[0]["warning"].ToString();
								dataTable2 = run_querry(string.Concat("UPDATE license_details_trials SET status_of_app ='", Form1.today_date_microsolft, "-", Assembly.GetExecutingAssembly().GetName().Version!.ToString(), "' WHERE password LIKE '", license_key, "'"));
							}
							catch
							{
								result.status = "Not Permitted";
							}
							result.permission = false;
						}
					}
				}
				else
				{
					ShowMessageBox("Invalid license key");
				}
			}
			else
			{
				DataTable dataTable3 = run_querry("Select * from license_details_trials WHERE password LIKE '" + ((Control)license_key_TextBox1).get_Text().TrimStart(new char[0]).TrimEnd(new char[0]) + "'");
				if (dataTable3.Rows.Count > 0)
				{
					string text9 = dataTable3.Rows[0]["status"].ToString();
					string text10 = dataTable3.Rows[0]["macid"].ToString();
					string s2 = dataTable3.Rows[0]["expiry"].ToString();
					string text11 = dataTable3.Rows[0]["force_update"].ToString();
					run_querry(string.Concat("UPDATE license_details_trials SET status_of_app ='", Form1.today_date_microsolft, "-", Assembly.GetExecutingAssembly().GetName().Version!.ToString(), "' WHERE password LIKE '", license_key, "'"));
					if (text10 == new_user_key)
					{
						if (text9 == "3 days trial")
						{
							DateTime dateTime = DateTime.ParseExact(s2, "dd/MM/yyyy", null);
							TimeSpan timeSpan = dateTime - Form1.today_date_microsolft;
							if (timeSpan.Days > 0)
							{
								result.permission = true;
								result.status = "3 days trial Expiry(" + dateTime.ToString("yyyy/MM/dd") + ")";
								if (timeSpan.Days == 2)
								{
									((Control)Form1.mainform.coupon_metroLabel2).set_Visible(true);
									((Control)Form1.mainform.coupon_metroLabel2).set_Text("Get 15% off, use coupon code 15offppttrial <valid for today>");
									result.status = "3 days trial (2 days left)";
								}
								else if (timeSpan.Days == 1)
								{
									((Control)Form1.mainform.coupon_metroLabel2).set_Visible(true);
									((Control)Form1.mainform.coupon_metroLabel2).set_Text("Get 10% off, use coupon code lucky10offppt <valid for today>");
									result.status = "3 days trial (1 day left)";
								}
								else
								{
									((Control)Form1.mainform.coupon_metroLabel2).set_Visible(false);
								}
							}
							else
							{
								result.permission = false;
								result.status = "expired (" + dateTime.ToString("yyyy/MM/dd") + ")";
								((Control)Form1.mainform.coupon_metroLabel2).set_Visible(false);
							}
						}
						else if (text9 == "active")
						{
							result.permission = true;
							result.status = "active";
						}
					}
					else
					{
						force_stop();
						DialogResult val2 = MessageBox.Show("This license is activated on someother pc", "Click yes if you want to activate license on this pc", (MessageBoxButtons)4, (MessageBoxIcon)48);
						if ((int)val2 == 6)
						{
							dataTable3 = run_querry("UPDATE license_details_trials SET macid = '" + new_user_key + "' WHERE password LIKE '" + license_key + "'");
							result.permission = true;
							result.status = "Active";
						}
						else
						{
							result.permission = false;
							result.status = "License Activated on Other pc";
						}
					}
					if (!(text11 == ""))
					{
						if (text11 == "0")
						{
							run_querry(string.Concat("UPDATE license_details_trials SET force_update = '', status_of_app ='", Form1.today_date_microsolft, "-", Assembly.GetExecutingAssembly().GetName().Version!.ToString(), "' WHERE password LIKE '", license_key, "'"));
							Thread thread2 = new Thread(force_update_app);
							thread2.Start();
						}
						else
						{
							try
							{
								string text12 = text11;
								DataTable dataTable4 = run_querry(("Select * From user_warning Where id = " + text12) ?? "");
								result.status = dataTable4.Rows[0]["warning"].ToString();
								dataTable4 = run_querry(string.Concat("UPDATE license_details_trials SET status_of_app ='", Form1.today_date_microsolft, "-", Assembly.GetExecutingAssembly().GetName().Version!.ToString(), "' WHERE password LIKE '", license_key, "'"));
							}
							catch
							{
								result.status = "Not Permitted";
							}
							result.permission = false;
						}
					}
				}
				else
				{
					dataTable3 = run_querry("Select * from wpec_edd_subscriptions WHERE password LIKE '" + license_key + "'");
					if (dataTable3.Rows.Count > 0)
					{
						string text13 = dataTable3.Rows[0]["status"].ToString();
						string text14 = dataTable3.Rows[0]["force_update"].ToString();
						run_querry(string.Concat("UPDATE wpec_edd_subscriptions SET status_of_app ='", Form1.today_date_microsolft, "-", Assembly.GetExecutingAssembly().GetName().Version!.ToString(), "' WHERE password LIKE '", license_key, "'"));
						if (text13 == "active")
						{
							string text15 = dataTable3.Rows[0]["macid"].ToString();
							if (text15 == "")
							{
								dataTable3 = run_querry("UPDATE wpec_edd_subscriptions SET macid = '" + new_user_key + "' WHERE password LIKE '" + license_key + "'");
								result.permission = true;
								result.status = "Active";
							}
							else if (text15 != new_user_key)
							{
								force_stop();
								DialogResult val3 = MessageBox.Show("This license is activated on someother pc", "Click yes if you want to activate license on this pc", (MessageBoxButtons)4, (MessageBoxIcon)48);
								if ((int)val3 == 6)
								{
									dataTable3 = run_querry("UPDATE wpec_edd_subscriptions SET macid = '" + new_user_key + "' WHERE password LIKE '" + license_key + "'");
									result.permission = true;
									result.status = "Active";
								}
								else
								{
									result.permission = false;
									result.status = "License activated on Other pc";
								}
							}
							else if (text15 == new_user_key)
							{
								result.permission = true;
								result.status = "Active";
							}
							if (!(text14 == ""))
							{
								if (text14 == "0")
								{
									run_querry(string.Concat("UPDATE wpec_edd_subscriptions SET force_update = '', status_of_app ='", Form1.today_date_microsolft, "-", Assembly.GetExecutingAssembly().GetName().Version!.ToString(), "' WHERE password LIKE '", license_key, "'"));
									Thread thread3 = new Thread(force_update_app);
									thread3.Start();
								}
								else
								{
									try
									{
										string text16 = text14;
										DataTable dataTable5 = run_querry(("Select * From user_warning Where id = " + text16) ?? "");
										result.status = dataTable5.Rows[0]["warning"].ToString();
										dataTable5 = run_querry(string.Concat("UPDATE license_details_trials SET status_of_app ='", Form1.today_date_microsolft, "-", Assembly.GetExecutingAssembly().GetName().Version!.ToString(), "' WHERE password LIKE '", license_key, "'"));
									}
									catch
									{
										result.status = "Not Permitted";
									}
									result.permission = false;
								}
							}
						}
						else
						{
							result.permission = false;
							result.status = "License Expired/Cancelled by user";
						}
					}
					else
					{
						dataTable3 = run_querry("Select * from wpec_postmeta WHERE meta_value LIKE '" + license_key + "'");
						if (dataTable3.Rows.Count > 0)
						{
							string text17 = dataTable3.Rows[0]["post_id"].ToString();
							dataTable3 = run_querry("Select * from wpec_postmeta WHERE meta_key LIKE '_edd_payment_meta' AND post_id LIKE " + text17);
							if (dataTable3.Rows.Count > 0)
							{
								string text18 = dataTable3.Rows[0]["meta_value"].ToString();
								string text19 = "";
								try
								{
									text19 = text18.Substring(text18.IndexOf("\"email\";") + 7, text18.Length - (text18.IndexOf("\"email\";") + 7));
									text19 = text19.Substring(0, text19.IndexOf("\";"));
									text19 = text19.Substring(text19.IndexOf("\"") + 1, text19.Length - (text19.IndexOf("\"") + 1));
								}
								catch
								{
								}
								if (text18.Contains("Poshmark Pro Tools – FREE 3 Day Trial"))
								{
									string text20 = "3 days trial";
									dataTable3 = run_querry("Select * from license_details_trials WHERE macid LIKE '" + new_user_key + "'");
									if (dataTable3.Rows.Count > 0)
									{
										bool flag = false;
										string text21 = dataTable3.Rows[0]["status"].ToString();
										if (File.Exists(Form1.hidden_path_trial) && text21 != "active")
										{
											flag = true;
										}
										else if (text21 == text20 || text21 == "active")
										{
											ShowMessageBox("you alredy used a trial on this pc");
											flag = true;
										}
										if (!flag)
										{
											string text22 = dataTable3.Rows[0]["password"].ToString();
											if (text22 != license_key)
											{
												force_stop();
												DialogResult val4 = MessageBox.Show("There is another license activated on this pc", "Click yes if you want to activate new license", (MessageBoxButtons)4, (MessageBoxIcon)48);
												if ((int)val4 == 6)
												{
													dataTable3 = run_querry("UPDATE license_details_trials SET username ='" + text19 + "-" + text17 + "', password = '" + license_key + "', status = '3 days trial', expiry ='" + Form1.today_date_microsolft.AddDays(4.0).ToString("dd/MM/yyyy") + "' WHERE macid LIKE '" + new_user_key + "' ");
													File.WriteAllText(Form1.hidden_path_trial, "");
													result.permission = true;
													result.status = "3 days trial";
												}
												else if (text21 != "active")
												{
													string s3 = dataTable3.Rows[0]["expiry"].ToString();
													DateTime dateTime2 = DateTime.ParseExact(s3, "dd/MM/yyyy", null);
													if ((dateTime2 - Form1.today_date_microsolft).Days > 0)
													{
														result.permission = true;
														result.status = text21;
													}
													else
													{
														result.permission = false;
														result.status = "expired";
													}
												}
												else
												{
													result.permission = true;
													result.status = text21;
												}
											}
											else
											{
												ShowMessageBox("Erro 202 contact support");
												result.permission = false;
												result.status = "Expired";
											}
										}
										else
										{
											result.permission = false;
											result.status = "Trial Expired";
										}
									}
									else
									{
										dataTable3 = run_querry("INSERT INTO license_details_trials(username,password,macid,status,expiry) VALUES('" + text19 + "-" + text17 + "', '" + license_key + "', '" + new_user_key + "', '" + text20 + "', '" + Form1.today_date_microsolft.AddDays(4.0).ToString("dd/MM/yyyy") + "')");
										if (dataTable3 != null)
										{
											ShowMessageBox("congratulations, you have successfully activated 3 days trial, your plan will expire on " + Form1.today_date_microsolft.AddDays(4.0).ToString("dd/MM/yyyy"));
											File.WriteAllText(Form1.hidden_path_trial, "");
											result.permission = true;
											result.status = text20;
										}
									}
								}
								else if (text18.Contains("\"recurring\""))
								{
									dataTable3 = run_querry("Select * from wpec_edd_subscriptions WHERE parent_payment_id LIKE '" + text17 + "'");
									if (dataTable3.Rows.Count > 0)
									{
										string text23 = dataTable3.Rows[0]["status"].ToString();
										if (text23 == "active")
										{
											string text24 = dataTable3.Rows[0]["macid"].ToString();
											dataTable3 = run_querry("UPDATE wpec_edd_subscriptions SET username ='" + text19 + "-" + text17 + "', password = '" + license_key + "' WHERE parent_payment_id LIKE '" + text17 + "'");
											if (text24 == "")
											{
												dataTable3 = run_querry("UPDATE wpec_edd_subscriptions SET macid = '" + new_user_key + "' WHERE parent_payment_id LIKE '" + text17 + "'");
												result.permission = true;
												result.status = "Active";
											}
											else if (text24 != new_user_key)
											{
												force_stop();
												DialogResult val5 = MessageBox.Show("This license is activated on someother pc", "Click yes if you want to activate license on this pc", (MessageBoxButtons)4, (MessageBoxIcon)48);
												if ((int)val5 == 6)
												{
													dataTable3 = run_querry("UPDATE wpec_edd_subscriptions SET username ='" + text19 + "-" + text17 + "', macid = '" + new_user_key + "' WHERE parent_payment_id LIKE '" + text17 + "'");
													result.permission = true;
													result.status = "Active";
												}
												else
												{
													result.permission = false;
													result.status = "License activated on Other pc";
												}
											}
											else
											{
												result.permission = true;
												result.status = "Active";
											}
										}
										else
										{
											result.permission = false;
											result.status = "Cancelled/Expired";
										}
									}
								}
								else
								{
									ShowMessageBox("Invalid id");
								}
							}
							else
							{
								ShowMessageBox("Invalid license key data");
							}
						}
						else
						{
							ShowMessageBox("Invalid license key");
						}
					}
				}
			}
		}
		catch
		{
			result.permission = false;
			result.status = "Not Activated - Problem in Connecting With Server";
		}
		return result;
	}

	public void force_stop()
	{
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected O, but got Unknown
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Expected O, but got Unknown
		try
		{
			object obj = _003C_003Ec._003C_003E9__8_0;
			if (obj == null)
			{
				MethodInvoker val = delegate
				{
					Form1.mainform.Stop_button1_Click(null, null);
				};
				obj = (object)val;
				_003C_003Ec._003C_003E9__8_0 = val;
			}
			((Control)this).Invoke((Delegate)obj);
			object obj2 = _003C_003Ec._003C_003E9__8_1;
			if (obj2 == null)
			{
				MethodInvoker val2 = delegate
				{
					((Control)Form1.mainform.Start_button1).set_Enabled(false);
				};
				obj2 = (object)val2;
				_003C_003Ec._003C_003E9__8_1 = val2;
			}
			((Control)this).Invoke((Delegate)obj2);
			object obj3 = _003C_003Ec._003C_003E9__8_2;
			if (obj3 == null)
			{
				MethodInvoker val3 = delegate
				{
					((Control)Form1.mainform.Stop_button1).set_Enabled(false);
				};
				obj3 = (object)val3;
				_003C_003Ec._003C_003E9__8_2 = val3;
			}
			((Control)this).Invoke((Delegate)obj3);
		}
		catch
		{
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
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected O, but got Unknown
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected O, but got Unknown
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Expected O, but got Unknown
		//IL_0230: Unknown result type (might be due to invalid IL or missing references)
		//IL_023a: Expected O, but got Unknown
		//IL_043d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0447: Expected O, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Register));
		splitContainer1 = new SplitContainer();
		label2 = new Label();
		registration_Button1 = new MetroButton();
		label1 = new MetroLabel();
		license_key_TextBox1 = new MetroTextBox();
		label3 = new Label();
		metroTextBox1 = new MetroTextBox();
		Regitsration_Status__label = new MetroLabel();
		Alert_label = new MetroLabel();
		((ISupportInitialize)splitContainer1).BeginInit();
		((Control)splitContainer1.get_Panel1()).SuspendLayout();
		((Control)splitContainer1.get_Panel2()).SuspendLayout();
		((Control)splitContainer1).SuspendLayout();
		((Control)this).SuspendLayout();
		splitContainer1.set_Dock((DockStyle)5);
		((Control)splitContainer1).set_Location(new Point(0, 0));
		((Control)splitContainer1).set_Name("splitContainer1");
		splitContainer1.set_Orientation((Orientation)0);
		((Control)splitContainer1.get_Panel1()).get_Controls().Add((Control)(object)label2);
		((Control)splitContainer1.get_Panel1()).get_Controls().Add((Control)(object)registration_Button1);
		((Control)splitContainer1.get_Panel1()).get_Controls().Add((Control)(object)label1);
		((Control)splitContainer1.get_Panel1()).get_Controls().Add((Control)(object)license_key_TextBox1);
		splitContainer1.set_Panel1MinSize(50);
		((Control)splitContainer1.get_Panel2()).get_Controls().Add((Control)(object)label3);
		((Control)splitContainer1.get_Panel2()).get_Controls().Add((Control)(object)metroTextBox1);
		((Control)splitContainer1.get_Panel2()).get_Controls().Add((Control)(object)Regitsration_Status__label);
		((Control)splitContainer1.get_Panel2()).get_Controls().Add((Control)(object)Alert_label);
		splitContainer1.set_Panel2MinSize(50);
		((Control)splitContainer1).set_Size(new Size(768, 383));
		splitContainer1.set_SplitterDistance(228);
		((Control)splitContainer1).set_TabIndex(1);
		((Control)label2).set_AutoSize(true);
		((Control)label2).set_Font(new Font("Microsoft Sans Serif", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)label2).set_ForeColor(Color.FromArgb(192, 64, 0));
		((Control)label2).set_Location(new Point(91, 126));
		((Control)label2).set_Name("label2");
		((Control)label2).set_Size(new Size(457, 20));
		((Control)label2).set_TabIndex(8);
		((Control)label2).set_Text("Type your License Key below, that your received in email");
		((Control)label2).set_Visible(false);
		((Control)registration_Button1).set_Location(new Point(512, 193));
		((Control)registration_Button1).set_Name("registration_Button1");
		((Control)registration_Button1).set_Size(new Size(109, 29));
		registration_Button1.Style = MetroColorStyle.Brown;
		((Control)registration_Button1).set_TabIndex(2);
		((Control)registration_Button1).set_Text("Activate");
		((Control)registration_Button1).add_Click((EventHandler)registration_Button1_Click);
		((Control)label1).set_AutoSize(true);
		label1.CustomBackground = true;
		((Control)label1).set_Location(new Point(95, 170));
		((Control)label1).set_Name("label1");
		((Control)label1).set_Size(new Size(74, 19));
		label1.Style = MetroColorStyle.Brown;
		((Control)label1).set_TabIndex(1);
		((Control)label1).set_Text("License Key");
		label1.UseStyleColors = true;
		((Control)license_key_TextBox1).set_Location(new Point(228, 164));
		((Control)license_key_TextBox1).set_Name("license_key_TextBox1");
		((Control)license_key_TextBox1).set_Size(new Size(393, 23));
		license_key_TextBox1.Style = MetroColorStyle.Brown;
		((Control)license_key_TextBox1).set_TabIndex(0);
		license_key_TextBox1.UseStyleColors = true;
		((Control)label3).set_AutoSize(true);
		((Control)label3).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)label3).set_ForeColor(Color.FromArgb(192, 64, 0));
		((Control)label3).set_Location(new Point(481, 49));
		((Control)label3).set_Name("label3");
		((Control)label3).set_Size(new Size(269, 52));
		((Control)label3).set_TabIndex(3);
		((Control)label3).set_Text("Register User => License is activated,\r\n and a paid user\r\nTrial user => Not a paid user, and trial running\r\nTrial Expired => Trial period is finished");
		((Control)label3).set_Visible(false);
		metroTextBox1.FontSize = MetroTextBoxSize.Medium;
		((Control)metroTextBox1).set_ForeColor(Color.Maroon);
		((Control)metroTextBox1).set_Location(new Point(228, 22));
		metroTextBox1.Multiline = true;
		((Control)metroTextBox1).set_Name("metroTextBox1");
		metroTextBox1.ReadOnly = true;
		((Control)metroTextBox1).set_Size(new Size(281, 184));
		metroTextBox1.Style = MetroColorStyle.Brown;
		((Control)metroTextBox1).set_TabIndex(7);
		((Control)metroTextBox1).set_Text(componentResourceManager.GetString("metroTextBox1.Text"));
		metroTextBox1.UseStyleColors = true;
		((Control)metroTextBox1).set_Visible(false);
		((Control)Regitsration_Status__label).set_AutoSize(true);
		Regitsration_Status__label.CustomBackground = true;
		Regitsration_Status__label.FontWeight = MetroLabelWeight.Regular;
		((Control)Regitsration_Status__label).set_Location(new Point(16, 154));
		((Control)Regitsration_Status__label).set_Name("Regitsration_Status__label");
		((Control)Regitsration_Status__label).set_Size(new Size(51, 19));
		Regitsration_Status__label.Style = MetroColorStyle.Brown;
		((Control)Regitsration_Status__label).set_TabIndex(6);
		((Control)Regitsration_Status__label).set_Text("_______");
		Regitsration_Status__label.UseStyleColors = true;
		((Control)Regitsration_Status__label).set_Visible(false);
		((Control)Alert_label).set_AutoSize(true);
		Alert_label.CustomBackground = true;
		Alert_label.FontWeight = MetroLabelWeight.Regular;
		((Control)Alert_label).set_Location(new Point(16, 54));
		((Control)Alert_label).set_Name("Alert_label");
		((Control)Alert_label).set_Size(new Size(51, 19));
		Alert_label.Style = MetroColorStyle.Brown;
		((Control)Alert_label).set_TabIndex(5);
		((Control)Alert_label).set_Text("_______");
		Alert_label.UseStyleColors = true;
		((Control)Alert_label).set_Visible(false);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((UserControl)this).set_BorderStyle((BorderStyle)1);
		((Control)this).get_Controls().Add((Control)(object)splitContainer1);
		((Control)this).set_Name("Register");
		((Control)this).set_Size(new Size(768, 383));
		((Control)splitContainer1.get_Panel1()).ResumeLayout(false);
		((Control)splitContainer1.get_Panel1()).PerformLayout();
		((Control)splitContainer1.get_Panel2()).ResumeLayout(false);
		((Control)splitContainer1.get_Panel2()).PerformLayout();
		((ISupportInitialize)splitContainer1).EndInit();
		((Control)splitContainer1).ResumeLayout(false);
		((Control)this).ResumeLayout(false);
	}
}
