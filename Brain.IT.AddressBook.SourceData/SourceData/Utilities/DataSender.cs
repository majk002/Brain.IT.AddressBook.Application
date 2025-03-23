using Newtonsoft.Json;
using SourceData.Data;
using System.Collections.Generic;
using System.Configuration;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SourceData.Utilities
{
    class DataSender
    {
		public DataSender() 
        {
		}

		public async Task<bool> SendData(List<Contact> payload)
		{
			string apiUrl = ConfigurationManager.AppSettings["ApiUrl"];
			string bearerToken = ConfigurationManager.AppSettings["BearerToken"];

			return await SendDataToApi(apiUrl, bearerToken, payload);
		}

		private async Task<bool> SendDataToApi(string apiUrl, string bearerToken, List<Contact> payload)
		{
			using (HttpClient client = new HttpClient())
			{
				// Nastavenie Bearer tokenu v hlavičke
				client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", bearerToken);

				string jsonContent = JsonConvert.SerializeObject(payload);
				var httpContent = new StringContent(jsonContent, Encoding.UTF8, "application/json");

				var response = await client.PostAsync(apiUrl, httpContent);

				if (response.IsSuccessStatusCode)
				{
					return true;
				}
				else
				{
					MessageBox.Show($"Sending error: {response.StatusCode} \n\n {await response.Content.ReadAsStringAsync()}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return false;
				}
			}
		}
	}
}
