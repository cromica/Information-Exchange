using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace InformationExchange.Order.Web.Extensions
{
	public static class ObjectExtensions
	{

		public static Stream ToJsonStream(this object obj)
		{
			var jsonSettings = new JsonSerializerSettings()
			{
				Converters = new JsonConverter[] { new StringEnumConverter() },
				ContractResolver = new CustomContractResolver()
			};

			var response = JsonConvert.SerializeObject(obj, jsonSettings);

			var memoryStream = new MemoryStream();
			var writer = new StreamWriter(memoryStream);
			writer.Write(response);
			writer.Flush();
			memoryStream.Flush();
			memoryStream.Seek(0, SeekOrigin.Begin);

			return memoryStream;
		}
	}

	public class CustomContractResolver : DefaultContractResolver
	{
		protected override JsonContract CreateContract(Type objectType)
		{
			JsonContract jsonContract = base.CreateContract(objectType);
			if (!(jsonContract is JsonStringContract))
			{
				return jsonContract;
			}
			return this.CreateObjectContract(objectType);
		}
	}
}