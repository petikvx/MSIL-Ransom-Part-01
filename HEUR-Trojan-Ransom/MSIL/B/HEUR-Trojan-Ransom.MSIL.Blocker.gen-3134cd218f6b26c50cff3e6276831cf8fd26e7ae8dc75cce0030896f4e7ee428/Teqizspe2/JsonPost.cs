using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Reflection;
using System.Text;
using Newtonsoft.Json;

namespace Teqizspe2;

public class JsonPost
{
	private string urlToPost = "";

	public JsonPost(string urlToPost)
	{
		AppDomain.CurrentDomain.AssemblyResolve += CurrentDomain_AssemblyResolve;
		this.urlToPost = urlToPost;
	}

	private Assembly CurrentDomain_AssemblyResolve(object sender, ResolveEventArgs args)
	{
		using Stream stream = Assembly.GetExecutingAssembly().GetManifestResourceStream("Teqizspe.Undtwd.dll");
		using MemoryStream memoryStream = new MemoryStream();
		stream.CopyTo(memoryStream);
		return AppDomain.CurrentDomain.Load(memoryStream.ToArray());
	}

	public bool postData(Dictionary<string, object> dictData)
	{
		WebClient webClient = new WebClient();
		try
		{
			webClient.Headers["content-type"] = "application/json";
			byte[] bytes = Encoding.Default.GetBytes(JsonConvert.SerializeObject((object)dictData, (Formatting)1));
			byte[] bytes2 = webClient.UploadData(urlToPost, "post", bytes);
			Console.WriteLine(Encoding.Default.GetString(bytes2));
			webClient.Dispose();
			return true;
		}
		catch (Exception ex)
		{
			Console.WriteLine(ex.Message);
		}
		return false;
	}
}
