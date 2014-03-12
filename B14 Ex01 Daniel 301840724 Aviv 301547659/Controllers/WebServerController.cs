
namespace B14_Ex01_Daniel_301840724_Aviv_301547659.Logic
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Net;
    using System.Runtime.Serialization.Json;
    using Newtonsoft.Json;

    public delegate void FinishedDownloadedingDelegate(List<RagePersonJson> i_RagePersons);

    public class WebServerController
    {
        private const string k_RageFacesURLQuery = "http://alltheragefaces.com/api/all/faces";
        public event FinishedDownloadedingDelegate m_notifyFinishedLoadingRagePersons;
        public void LoadRagePersonsFromServer()
        {
            WebClient client = new WebClient();
            client.DownloadStringCompleted += (sender, e) =>
            {
                if (m_notifyFinishedLoadingRagePersons != null)
                {
                    m_notifyFinishedLoadingRagePersons.Invoke(JsonConvert.DeserializeObject<List<RagePersonJson>>(e.Result));
                }
            };

            client.DownloadStringAsync(new Uri(k_RageFacesURLQuery));
        }
    }
}
