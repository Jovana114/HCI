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
    public class RearrangeDinamicEquipmentRepository
    {

        private static RearrangeDinamicEquipmentRepository _instance;
        public ObservableCollection<RearrangeEquipmentDinamic> rearrangeEquipment;
        private string location;

        public static RearrangeDinamicEquipmentRepository Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new RearrangeDinamicEquipmentRepository();
                }
                return _instance;
            }
        }

        private RearrangeDinamicEquipmentRepository()
        {
            rearrangeEquipment = new ObservableCollection<RearrangeEquipmentDinamic>();
            this.location = @"..\..\..\HCI\Resources\Data\RearrangeDinamicEquipment.json"; ;
        }

        public void Save()
        {
            JsonSerializer serializer = new JsonSerializer();
            serializer.ReferenceLoopHandling = ReferenceLoopHandling.Ignore;
            serializer.Formatting = Formatting.Indented;
            StreamWriter writer = new StreamWriter(location);
            JsonWriter jWriter = new JsonTextWriter(writer);
            serializer.Serialize(jWriter, rearrangeEquipment);
            jWriter.Close();
            writer.Close();
        }


        public ObservableCollection<RearrangeEquipmentDinamic> GetAll()
        {
            List<RearrangeEquipmentDinamic> rearranged = new List<RearrangeEquipmentDinamic>();
            if (File.Exists(location))
            {
                string jsonText = File.ReadAllText(location);
                if (!string.IsNullOrEmpty(jsonText))
                {
                    rearranged = JsonConvert.DeserializeObject<List<RearrangeEquipmentDinamic>>(jsonText);
                }
            }
            if (rearranged != null)
            {
                this.rearrangeEquipment = new ObservableCollection<RearrangeEquipmentDinamic>(rearranged);
            }
            return this.rearrangeEquipment;
        }

    }
}
