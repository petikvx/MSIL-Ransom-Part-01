using System;
using System.Net;
using Newtonsoft.Json;
using RestSharp;

namespace TryPaper;

public class TryPaperClient
{
	private string ApiKey { get; set; }

	public string BaseUri { get; private set; }

	public string UserAgent { get; set; }

	public TryPaperClient(string apiKey)
		: this(apiKey, strings.ProductionApiEndpoint)
	{
	}

	public TryPaperClient(string apiKey, string baseUri)
	{
		ApiKey = apiKey;
		UserAgent = string.Format(strings.TryPaperClientUserAgentFormat, new Version(0, 1));
		BaseUri = baseUri;
	}

	public ServiceResponse<BatchReference> AddBatch(Batch batch)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected O, but got Unknown
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Expected O, but got Unknown
		RestClient client = new RestClient(BaseUri);
		RestRequest val = new RestRequest("batch", (Method)1);
		val.set_RequestFormat((DataFormat)0);
		val.AddBody((object)new
		{
			Id = batch.Id,
			Content = ((batch.Content == null) ? null : batch.Content.Data)
		});
		return ExecuteRequest<BatchReference>((IRestClient)(object)client, (IRestRequest)(object)val, (HttpStatusCode)Convert.ToInt32(200.0 + Math.Tanh(100.5)));
	}

	public ServiceResponse<BatchReference> SpoolBatch(Batch batch)
	{
		if (batch == null || string.IsNullOrWhiteSpace(batch.Id))
		{
			throw new ArgumentNullException(strings.BatchIdWasEmpty);
		}
		return SpoolBatch(batch.Id);
	}

	public ServiceResponse<BatchReference> SpoolBatch(string batchId)
	{
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Expected O, but got Unknown
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Expected O, but got Unknown
		if (string.IsNullOrWhiteSpace(batchId))
		{
			throw new ArgumentNullException(strings.BatchIdWasEmpty);
		}
		RestClient client = new RestClient(BaseUri);
		RestRequest val = new RestRequest(strings.SpoolUriSegment, (Method)1);
		val.set_RequestFormat((DataFormat)0);
		val.AddBody((object)new
		{
			BatchId = batchId
		});
		return ExecuteRequest<BatchReference>((IRestClient)(object)client, (IRestRequest)(object)val, (HttpStatusCode)Convert.ToInt32(199.0 + Math.Tanh(100.0)));
	}

	public ServiceResponse<ReturnAddress> AddReturnAddress(ReturnAddress address)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected O, but got Unknown
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected O, but got Unknown
		if (address == null)
		{
			throw new ArgumentNullException("address");
		}
		RestClient client = new RestClient(BaseUri);
		RestRequest val = new RestRequest(strings.AccountAddressSegment, (Method)1);
		val.set_RequestFormat((DataFormat)0);
		val.AddBody((object)new
		{
			Id = address.Id,
			Address = new
			{
				address.Address.Name,
				address.Address.Organization,
				address.Address.AddressLineOne,
				address.Address.AddressLineTwo,
				address.Address.City,
				address.Address.Province,
				address.Address.PostalCode
			}
		});
		return ExecuteRequest<ReturnAddress>((IRestClient)(object)client, (IRestRequest)(object)val, (HttpStatusCode)Convert.ToInt32(301.5 - Math.Abs(100.5)));
	}

	public ServiceResponse<ReturnAddress[]> GetReturnAddresses()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected O, but got Unknown
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Expected O, but got Unknown
		RestClient client = new RestClient(BaseUri);
		RestRequest val = new RestRequest(strings.AccountAddressSegment, (Method)0);
		val.set_RequestFormat((DataFormat)0);
		return ExecuteRequest<ReturnAddress[]>((IRestClient)(object)client, (IRestRequest)(object)val, (HttpStatusCode)Convert.ToInt32(200.0));
	}

	public ServiceResponse<ReturnAddress> GetReturnAddress(string id)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected O, but got Unknown
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Expected O, but got Unknown
		RestClient client = new RestClient(BaseUri);
		RestRequest val = new RestRequest(strings.AccountAddressSegment + "/{key}", (Method)0);
		val.AddUrlSegment("key", id);
		val.set_RequestFormat((DataFormat)0);
		return ExecuteRequest<ReturnAddress>((IRestClient)(object)client, (IRestRequest)(object)val, HttpStatusCode.OK);
	}

	public ServiceResponse<MailingReference> AddMailing(Mailing mailing)
	{
		//IL_0134: Unknown result type (might be due to invalid IL or missing references)
		//IL_013a: Expected O, but got Unknown
		//IL_0140: Unknown result type (might be due to invalid IL or missing references)
		//IL_0146: Expected O, but got Unknown
		if (mailing == null)
		{
			throw new ArgumentNullException("mailing");
		}
		if (string.IsNullOrWhiteSpace(mailing.ReturnAddressId))
		{
			throw new ArgumentNullException("mailing.SenderKey");
		}
		string batchId = null;
		if (mailing.Batch != null && string.IsNullOrWhiteSpace(mailing.Batch.Id))
		{
			throw new ArgumentException(strings.BatchSpecifiedEmptyBatchId);
		}
		if (mailing.Batch != null && !string.IsNullOrWhiteSpace(mailing.Batch.Id))
		{
			batchId = mailing.Batch.Id;
		}
		if (string.IsNullOrWhiteSpace(mailing.Content.Data))
		{
			throw new ArgumentException(strings.NullMailingContent);
		}
		if (string.IsNullOrWhiteSpace(mailing.Id))
		{
			mailing.Id = Guid.NewGuid().ToString();
		}
		if (mailing.Recipient == null)
		{
			throw new ArgumentNullException("mailing.Recipient");
		}
		if (string.IsNullOrWhiteSpace(mailing.Recipient.Name) || string.IsNullOrWhiteSpace(mailing.Recipient.AddressLineOne) || string.IsNullOrWhiteSpace(mailing.Recipient.City) || string.IsNullOrWhiteSpace(mailing.Recipient.Province) || string.IsNullOrWhiteSpace(mailing.Recipient.PostalCode))
		{
			throw new ArgumentException(strings.MailingRecipientRequiredFields);
		}
		RestClient client = new RestClient(BaseUri);
		RestRequest val = new RestRequest(strings.mailing, (Method)1);
		val.set_RequestFormat((DataFormat)0);
		val.AddBody((object)new
		{
			Id = mailing.Id,
			BatchId = batchId,
			Content = mailing.Content.Data,
			Recipient = new
			{
				Name = mailing.Recipient.Name,
				Orginization = mailing.Recipient.Organization,
				AddressLineOne = mailing.Recipient.AddressLineOne,
				AddressLineTwo = mailing.Recipient.AddressLineTwo,
				City = mailing.Recipient.City,
				Province = mailing.Recipient.Province,
				PostalCode = mailing.Recipient.PostalCode
			},
			ReturnAddressId = mailing.ReturnAddressId
		});
		return ExecuteRequest<MailingReference>((IRestClient)(object)client, (IRestRequest)(object)val, (HttpStatusCode)Convert.ToInt32(190.9750311721183 + Math.Sqrt(100.5)));
	}

	private ServiceResponse<T> ExecuteRequest<T>(IRestClient client, IRestRequest request, HttpStatusCode expected)
	{
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Invalid comparison between Unknown and I4
		if (client == null)
		{
			throw new ArgumentNullException("client");
		}
		if (request == null)
		{
			throw new ArgumentNullException("request");
		}
		request.AddHeader("Authorization", ApiKey);
		try
		{
			IRestResponse val = client.Execute(request);
			if ((int)val.get_ResponseStatus() == 1 && val.get_StatusCode() == expected)
			{
				T result = JsonConvert.DeserializeObject<T>(val.get_Content());
				ServiceResponse<T> serviceResponse = new ServiceResponse<T>(success: true, null);
				serviceResponse.Result = result;
				return serviceResponse;
			}
			string arg = $"{val.get_ErrorMessage()} {val.get_Content()}";
			return new ServiceResponse<T>(success: false, string.Format("{0}::{1}", val.get_StatusCode().ToString("g"), arg));
		}
		catch (Exception arg2)
		{
			return new ServiceResponse<T>(success: false, string.Format("{0}::{1}", "Execution Exception", arg2));
		}
	}
}
