﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace OMF.Objects
{
    public class Legend : DateAndDescriptionBase, IObject
    {
        public string name { get; set; }
        public string __class__ { get; set; }
        public string values { get; set; }

        [JsonIgnore]
        public ColorArray Colors { get; set; }

        public void Deserialize(Dictionary<string, object> json, BinaryReader br)
        {
            Colors = (ColorArray)ObjectFactory.GetObjectFromGuid(json, br, values);
        }

        public void Serialize(Dictionary<string, object> json, BinaryWriter bw, string guid)
        {
            values = ObjectFactory.SerializeObject(Colors, json, bw);

            ObjectFactory.GetObjectToData(json, this, guid);
        }
    }
}