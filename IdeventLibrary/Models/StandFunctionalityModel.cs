﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdeventLibrary.Models
{
    public class StandFunctionalityModel
    {
        private int _id;
        private string _name;

        public StandFunctionalityModel()
        {
            
        }
        public StandFunctionalityModel(string name)
        {
            _name = name;
        }

        public StandFunctionalityModel(int id,string name)
        {
            _id = id;
            _name = name;
        }

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        

    }
}
