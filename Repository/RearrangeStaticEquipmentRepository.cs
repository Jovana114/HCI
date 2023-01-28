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
    public class RearrangeStaticEquipmentRepository
    {

        private static RearrangeStaticEquipmentRepository _instance;
        public ObservableCollection<RearrangeEquipmentStatic> rearrangeEquipment;
        private string location;

        public static RearrangeStaticEquipmentRepository Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new RearrangeStaticEquipmentRepository();
                }
                return _instance;
            }
        }

        private RearrangeStaticEquipmentRepository()
        {
            rearrangeEquipment = new ObservableCollection<RearrangeEquipmentStatic>();
            this.location = @"..\..\..\HCI\Resources\Data\RearrangeStaticEquipment.json"; ;
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


        public ObservableCollection<RearrangeEquipmentStatic> GetAll()
        {
            List<RearrangeEquipmentStatic> rearranged = new List<RearrangeEquipmentStatic>();
            if (File.Exists(location))
            {
                string jsonText = File.ReadAllText(location);
                if (!string.IsNullOrEmpty(jsonText))
                {
                    rearranged = JsonConvert.DeserializeObject<List<RearrangeEquipmentStatic>>(jsonText);
                }
            }
            if (rearranged != null)
            {
                this.rearrangeEquipment = new ObservableCollection<RearrangeEquipmentStatic>(rearranged);
            }
            return this.rearrangeEquipment;
        }

    }
}
