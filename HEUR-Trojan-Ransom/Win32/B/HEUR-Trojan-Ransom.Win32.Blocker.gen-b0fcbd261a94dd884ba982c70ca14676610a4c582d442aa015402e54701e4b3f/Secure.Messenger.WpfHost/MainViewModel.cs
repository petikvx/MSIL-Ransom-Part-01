using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows;
using System.Windows.Threading;
using Secure.Messenger.Server;
using Secure.Messenger.Shared;

namespace Secure.Messenger.WpfHost;

public class MainViewModel : INotifyPropertyChanged
{
	private CryptoServer _server;

	private TcpClient _client;

	private NetworkStream _strm;

	public AutoResetEvent _serverStarted = MainViewModel.smethod_0(bool_0: false);

	private Thread ServerThread;

	private int _port = 9050;

	private Visibility _notConnectedVisibility = (Visibility)0;

	private string _remoteIPAddress = string.Empty;

	private string _sendMessage = string.Empty;

	private ObservableCollection<string> _receivedMessages = new ObservableCollection<string>();

	private ObservableCollection<string> _sentMessages = new ObservableCollection<string>();

	private ObservableCollection<string> _statusMessages = new ObservableCollection<string>();

	public Visibility NotConnectedVisibility
	{
		get
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			return _notConnectedVisibility;
		}
		set
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			_notConnectedVisibility = value;
			RaisePropertyChanged("NotConnectedVisibility");
		}
	}

	public Command SendData { get; set; }

	public Command ConnectToServer { get; set; }

	public string RemoteIPAddress
	{
		get
		{
			return _remoteIPAddress;
		}
		set
		{
			_remoteIPAddress = value;
			RaisePropertyChanged("RemoteIPAddress");
		}
	}

	public string SendMessage
	{
		get
		{
			return _sendMessage;
		}
		set
		{
			_sendMessage = value;
			RaisePropertyChanged("SendMessage");
		}
	}

	public ObservableCollection<string> ReceivedMessages
	{
		get
		{
			return _receivedMessages;
		}
		set
		{
			_receivedMessages = value;
			RaisePropertyChanged("ReceivedMessages");
		}
	}

	public ObservableCollection<string> SentMessages
	{
		get
		{
			return _sentMessages;
		}
		set
		{
			_sentMessages = value;
			RaisePropertyChanged("SentMessages");
		}
	}

	public ObservableCollection<string> StatusMessages
	{
		get
		{
			return _statusMessages;
		}
		set
		{
			_statusMessages = value;
			RaisePropertyChanged("StatusMessages");
		}
	}

	public event PropertyChangedEventHandler PropertyChanged
	{
		[CompilerGenerated]
		add
		{
			PropertyChangedEventHandler propertyChangedEventHandler = this.PropertyChanged;
			PropertyChangedEventHandler propertyChangedEventHandler2;
			do
			{
				propertyChangedEventHandler2 = propertyChangedEventHandler;
				PropertyChangedEventHandler value2 = (PropertyChangedEventHandler)MainViewModel.smethod_24((Delegate)propertyChangedEventHandler2, (Delegate)value);
				propertyChangedEventHandler = Interlocked.CompareExchange(ref this.PropertyChanged, value2, propertyChangedEventHandler2);
			}
			while ((object)propertyChangedEventHandler != propertyChangedEventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			PropertyChangedEventHandler propertyChangedEventHandler = this.PropertyChanged;
			PropertyChangedEventHandler propertyChangedEventHandler2;
			do
			{
				propertyChangedEventHandler2 = propertyChangedEventHandler;
				PropertyChangedEventHandler value2 = (PropertyChangedEventHandler)MainViewModel.smethod_25((Delegate)propertyChangedEventHandler2, (Delegate)value);
				propertyChangedEventHandler = Interlocked.CompareExchange(ref this.PropertyChanged, value2, propertyChangedEventHandler2);
			}
			while ((object)propertyChangedEventHandler != propertyChangedEventHandler2);
		}
	}

	public MainViewModel()
	{
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		SendData = new Command(SendDataExecute, SendDataCanExecute);
		ConnectToServer = new Command(ConnectToServerExecute, ConnectToServerCanExecute);
		RemoteIPAddress = MainViewModel.smethod_1((object)LocalIPAddress());
		SendMessage = "Hello";
		if (!MainViewModel.smethod_3(MainViewModel.smethod_2()))
		{
			StartServerThread();
		}
	}

	private void StartServerThread()
	{
		try
		{
			ServerThread = MainViewModel.smethod_4((ThreadStart)StartServer);
			MainViewModel.smethod_5(ServerThread, bool_0: true);
			MainViewModel.smethod_6(ServerThread, ThreadPriority.Normal);
			MainViewModel.smethod_7(ServerThread);
			MainViewModel.smethod_8((WaitHandle)_serverStarted);
			StatusMessages.Add(MainViewModel.smethod_9("Local Server Started Successfully at : ", _remoteIPAddress));
		}
		catch (Exception exception_)
		{
			StatusMessages.Add(MainViewModel.smethod_9("Problem Starting The Local Server : ", MainViewModel.smethod_10(exception_)));
		}
	}

	private void ConnectingToServer()
	{
		try
		{
			MessageData mes = new MessageData("Connection Message 123");
			_client = MainViewModel.smethod_11(_remoteIPAddress, _port);
			_strm = MainViewModel.smethod_12(_client);
			if (!CryptoHelper.SendData(_strm, mes))
			{
				throw MainViewModel.smethod_13("Send data failed");
			}
			MainViewModel.smethod_14((Stream)_strm);
			MainViewModel.smethod_15(_client);
			StatusMessages.Add(MainViewModel.smethod_9("Remote Server Connection Successfull to : ", _remoteIPAddress));
			NotConnectedVisibility = (Visibility)1;
		}
		catch (Exception exception_)
		{
			StatusMessages.Add(MainViewModel.smethod_9("Problem Connecting to Remote Server at : ", _remoteIPAddress));
			StatusMessages.Add(MainViewModel.smethod_9("Message : ", MainViewModel.smethod_10(exception_)));
		}
	}

	private void SendTextData()
	{
		MessageData mes = new MessageData(SendMessage);
		_client = MainViewModel.smethod_11(MainViewModel.smethod_1((object)_remoteIPAddress), _port);
		_strm = MainViewModel.smethod_12(_client);
		CryptoHelper.SendData(_strm, mes);
		MainViewModel.smethod_14((Stream)_strm);
		MainViewModel.smethod_15(_client);
		SentMessages.Add(MainViewModel.smethod_16("Sent to ", MainViewModel.smethod_1((object)_remoteIPAddress), " > ", SendMessage));
	}

	private void StartServer()
	{
		_server = new CryptoServer(_serverStarted);
		_server.ReceivedData += server_ReceivedData;
		_server.StartServer(LocalIPAddress(), _port);
	}

	private void server_ReceivedData(object sender, EventArgs<string> e)
	{
		MainViewModel.smethod_19(MainViewModel.smethod_18((DispatcherObject)(object)MainViewModel.smethod_17()), (Delegate)(Action)delegate
		{
			ReceivedMessages.Add(_003C_003Ec__DisplayClass11_0.smethod_0("Received from ", _remoteIPAddress, " > ", e.Value));
		}, new object[0]);
	}

	private IPAddress LocalIPAddress()
	{
		if (MainViewModel.smethod_20())
		{
			IPHostEntry iphostEntry_ = MainViewModel.smethod_22(MainViewModel.smethod_21());
			return MainViewModel.smethod_23(iphostEntry_).FirstOrDefault((IPAddress ip) => _003C_003Ec.smethod_0(ip) == AddressFamily.InterNetwork);
		}
		return null;
	}

	public bool SendDataCanExecute(object parameter)
	{
		return true;
	}

	public void SendDataExecute(object parameter)
	{
		SendTextData();
	}

	public bool ConnectToServerCanExecute(object parameter)
	{
		return true;
	}

	public void ConnectToServerExecute(object parameter)
	{
		ConnectingToServer();
	}

	private void RaisePropertyChanged(string propertyName)
	{
		this.PropertyChanged?.Invoke(this, MainViewModel.smethod_26(MainViewModel.smethod_1((object)propertyName)));
	}

	static AutoResetEvent smethod_0(bool bool_0)
	{
		return new AutoResetEvent(bool_0);
	}

	static string smethod_1(object object_0)
	{
		return object_0.ToString();
	}

	static DependencyObject smethod_2()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new DependencyObject();
	}

	static bool smethod_3(DependencyObject dependencyObject_0)
	{
		return DesignerProperties.GetIsInDesignMode(dependencyObject_0);
	}

	static Thread smethod_4(ThreadStart threadStart_0)
	{
		return new Thread(threadStart_0);
	}

	static void smethod_5(Thread thread_0, bool bool_0)
	{
		thread_0.IsBackground = bool_0;
	}

	static void smethod_6(Thread thread_0, ThreadPriority threadPriority_0)
	{
		thread_0.Priority = threadPriority_0;
	}

	static void smethod_7(Thread thread_0)
	{
		thread_0.Start();
	}

	static bool smethod_8(WaitHandle waitHandle_0)
	{
		return waitHandle_0.WaitOne();
	}

	static string smethod_9(string string_0, string string_1)
	{
		return string_0 + string_1;
	}

	static string smethod_10(Exception exception_0)
	{
		return exception_0.Message;
	}

	static TcpClient smethod_11(string string_0, int int_0)
	{
		return new TcpClient(string_0, int_0);
	}

	static NetworkStream smethod_12(TcpClient tcpClient_0)
	{
		return tcpClient_0.GetStream();
	}

	static Exception smethod_13(string string_0)
	{
		return new Exception(string_0);
	}

	static void smethod_14(Stream stream_0)
	{
		stream_0.Close();
	}

	static void smethod_15(TcpClient tcpClient_0)
	{
		tcpClient_0.Close();
	}

	static string smethod_16(string string_0, string string_1, string string_2, string string_3)
	{
		return string_0 + string_1 + string_2 + string_3;
	}

	static Application smethod_17()
	{
		return Application.get_Current();
	}

	static Dispatcher smethod_18(DispatcherObject dispatcherObject_0)
	{
		return dispatcherObject_0.get_Dispatcher();
	}

	static object smethod_19(Dispatcher dispatcher_0, Delegate delegate_0, object[] object_0)
	{
		return dispatcher_0.Invoke(delegate_0, object_0);
	}

	static bool smethod_20()
	{
		return NetworkInterface.GetIsNetworkAvailable();
	}

	static string smethod_21()
	{
		return Dns.GetHostName();
	}

	static IPHostEntry smethod_22(string string_0)
	{
		return Dns.GetHostEntry(string_0);
	}

	static IPAddress[] smethod_23(IPHostEntry iphostEntry_0)
	{
		return iphostEntry_0.AddressList;
	}

	static Delegate smethod_24(Delegate delegate_0, Delegate delegate_1)
	{
		return Delegate.Combine(delegate_0, delegate_1);
	}

	static Delegate smethod_25(Delegate delegate_0, Delegate delegate_1)
	{
		return Delegate.Remove(delegate_0, delegate_1);
	}

	static PropertyChangedEventArgs smethod_26(string string_0)
	{
		return new PropertyChangedEventArgs(string_0);
	}
}
