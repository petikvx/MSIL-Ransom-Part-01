using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using Ubiety.Dns.Core.Records;
using Ubiety.Dns.Core.Records.General;
using Ubiety.Dns.Core.Records.Mail;

namespace Ubiety.Dns.Core;

public class Response
{
	public List<Question> Questions { get; }

	public List<AnswerRR> Answers { get; }

	public List<AuthorityRR> Authorities { get; }

	public List<AdditionalRR> Additionals { get; }

	public Header Header { get; }

	public string Error { get; set; }

	public int MessageSize { get; set; }

	public DateTime TimeStamp { get; }

	public IPEndPoint Server { get; }

	public List<RecordMx> RecordMx
	{
		get
		{
			List<RecordMx> list = new List<RecordMx>();
			foreach (AnswerRR answer in Answers)
			{
				RecordMx recordMx = answer.Record as RecordMx;
				if (recordMx != null)
				{
					list.Add(recordMx);
				}
			}
			list.Sort();
			return list;
		}
	}

	public List<RecordTxt> RecordTxt
	{
		get
		{
			List<RecordTxt> list = new List<RecordTxt>();
			foreach (AnswerRR answer in Answers)
			{
				if (answer.Record is RecordTxt item)
				{
					list.Add(item);
				}
			}
			return list;
		}
	}

	public List<RecordA> RecordA
	{
		get
		{
			List<RecordA> list = new List<RecordA>();
			foreach (AnswerRR answer in Answers)
			{
				if (answer.Record is RecordA item)
				{
					list.Add(item);
				}
			}
			return list;
		}
	}

	public List<RecordPtr> RecordPtr
	{
		get
		{
			List<RecordPtr> list = new List<RecordPtr>();
			foreach (AnswerRR answer in Answers)
			{
				if (answer.Record is RecordPtr item)
				{
					list.Add(item);
				}
			}
			return list;
		}
	}

	public List<RecordCname> RecordCname
	{
		get
		{
			List<RecordCname> list = new List<RecordCname>();
			foreach (AnswerRR answer in Answers)
			{
				if (answer.Record is RecordCname item)
				{
					list.Add(item);
				}
			}
			return list;
		}
	}

	public List<RecordAaaa> RecordAaaa
	{
		get
		{
			List<RecordAaaa> list = new List<RecordAaaa>();
			foreach (AnswerRR answer in Answers)
			{
				if (answer.Record is RecordAaaa item)
				{
					list.Add(item);
				}
			}
			return list;
		}
	}

	public List<RecordNs> RecordNs
	{
		get
		{
			List<RecordNs> list = new List<RecordNs>();
			foreach (AnswerRR answer in Answers)
			{
				if (answer.Record is RecordNs item)
				{
					list.Add(item);
				}
			}
			return list;
		}
	}

	public List<RecordSoa> RecordSoa
	{
		get
		{
			List<RecordSoa> list = new List<RecordSoa>();
			foreach (AnswerRR answer in Answers)
			{
				if (answer.Record is RecordSoa item)
				{
					list.Add(item);
				}
			}
			return list;
		}
	}

	public List<RecordCert> RecordCert
	{
		get
		{
			List<RecordCert> list = new List<RecordCert>();
			foreach (AnswerRR answer in Answers)
			{
				if (answer.Record is RecordCert item)
				{
					list.Add(item);
				}
			}
			return list;
		}
	}

	public List<RecordSrv> RecordSrv
	{
		get
		{
			List<RecordSrv> list = new List<RecordSrv>();
			foreach (AnswerRR answer in Answers)
			{
				if (answer.Record is RecordSrv item)
				{
					list.Add(item);
				}
			}
			return list;
		}
	}

	public IEnumerable<ResourceRecord> ResourceRecords
	{
		get
		{
			List<ResourceRecord> list = Answers.Cast<ResourceRecord>().ToList();
			list.AddRange(Authorities);
			list.AddRange(Additionals);
			return list;
		}
	}

	public Response()
	{
		Questions = new List<Question>();
		Answers = new List<AnswerRR>();
		Authorities = new List<AuthorityRR>();
		Additionals = new List<AdditionalRR>();
		Server = new IPEndPoint(0L, 0);
		Error = string.Empty;
		MessageSize = 0;
		TimeStamp = DateTime.Now;
		Header = new Header();
	}

	public Response(IPEndPoint iPEndPoint, byte[] data)
	{
		Error = string.Empty;
		Server = iPEndPoint;
		TimeStamp = DateTime.Now;
		MessageSize = data.Length;
		RecordReader recordReader = new RecordReader(data);
		Questions = new List<Question>();
		Answers = new List<AnswerRR>();
		Authorities = new List<AuthorityRR>();
		Additionals = new List<AdditionalRR>();
		Header = new Header(recordReader);
		for (int i = 0; i < Header.QuestionCount; i++)
		{
			Questions.Add(new Question(recordReader));
		}
		for (int j = 0; j < Header.AnswerCount; j++)
		{
			Answers.Add(new AnswerRR(recordReader));
		}
		for (int k = 0; k < Header.NameserverCount; k++)
		{
			Authorities.Add(new AuthorityRR(recordReader));
		}
		for (int l = 0; l < Header.AdditionalRecordsCount; l++)
		{
			Additionals.Add(new AdditionalRR(recordReader));
		}
	}
}
