using System;
using System.Collections.Generic;
using System.Linq;
using HCI;
using Newtonsoft.Json;
using System.IO;
using System.Collections.ObjectModel;
using HCI.Model;

namespace HCI.Repository
{
    public class RenovationAdvancedSplitRepository
    {

        private static RenovationAdvancedSplitRepository _instance;
        public ObservableCollection<RenovationAdvanced> renovation;
        private string location;

        public static RenovationAdvancedSplitRepository Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new RenovationAdvancedSplitRepository();
                }
                return _instance;
            }
        }

        private RenovationAdvancedSplitRepository()
        {
            renovation = new ObservableCollection<RenovationAdvanced>();
            this.location = @"..\..\..\HCI\Resources\Data\RenovationAdvancedSplit.json"; ;
        }

        public void Save()
        {
            JsonSerializer serializer = new JsonSerializer();
            serializer.ReferenceLoopHandling = ReferenceLoopHandling.Ignore;
            serializer.Formatting = Formatting.Indented;
            StreamWriter writer = new StreamWriter(location);
            JsonWriter jWriter = new JsonTextWriter(writer);
            serializer.Serialize(jWriter, renovation);
            jWriter.Close();
            writer.Close();
        }


        public ObservableCollection<RenovationAdvanced> GetAll()
        {
            List<RenovationAdvanced> renovation1 = new List<RenovationAdvanced>();
            if (File.Exists(location))
            {
                string jsonText = File.ReadAllText(location);
                if (!string.IsNullOrEmpty(jsonText))
                {
                    renovation1 = JsonConvert.DeserializeObject<List<RenovationAdvanced>>(jsonText);
                }
            }
            if (renovation1 != null)
            {
                this.renovation = new ObservableCollection<RenovationAdvanced>(renovation1);
            }
            return this.renovation;
        }

    }
}
