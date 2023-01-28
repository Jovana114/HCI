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
    public class RenovationRepository
    {

        private static RenovationRepository _instance;
        public ObservableCollection<RenovationSimple> renovation;
        private string location;

        public static RenovationRepository Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new RenovationRepository();
                }
                return _instance;
            }
        }

        private RenovationRepository()
        {
            renovation = new ObservableCollection<RenovationSimple>();
            this.location = @"..\..\..\HCI\Resources\Data\Renovation.json"; ;
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


        public ObservableCollection<RenovationSimple> GetAll()
        {
            List<RenovationSimple> renovation1 = new List<RenovationSimple>();
            if (File.Exists(location))
            {
                string jsonText = File.ReadAllText(location);
                if (!string.IsNullOrEmpty(jsonText))
                {
                    renovation1 = JsonConvert.DeserializeObject<List<RenovationSimple>>(jsonText);
                }
            }
            if (renovation1 != null)
            {
                this.renovation = new ObservableCollection<RenovationSimple>(renovation1);
            }
            return this.renovation;
        }

    }
}
