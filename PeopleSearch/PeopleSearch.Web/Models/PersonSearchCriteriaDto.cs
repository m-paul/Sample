﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace PeopleSearch.Web.Models
{
    [DataContract]
    [Serializable]
    public class PersonSearchCriteriaDto
    {
        [DataMember]
        public string Name { get; set; }
    }
}