﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace IdeventLibrary.Models
{
    public class EventModel
    {
        public EventModel(){}
        public EventModel(int id, string name)
        {
            Id = id;
            Name = name;
        }
        public EventModel(string name, CompanyModel company) 
        { 
            Name = name;
            Company = company;
        }
        public EventModel(string name, CompanyModel company, int amountOfConnectedChips)
        {
            Name = name;
            Company = company;
            NumberOfConnectedChips = amountOfConnectedChips;
        }
        public int Id { get; set; }
        [Required]
        [MinLength(2)]
        [MaxLength(50)]
        public string Name { get; set; }
        [Required]
        public CompanyModel Company { get; set; }
        public int NumberOfConnectedChips { get; set; } // data comes from a count on the Chips table.
        [JsonIgnore]
        public List<EventStandModel> EventStands { get; set; } = new List<EventStandModel>();
    }
}
