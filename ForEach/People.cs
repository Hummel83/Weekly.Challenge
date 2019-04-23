﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ForEach
{
    public  class People
    {
        private readonly IList<IPersonModell> _persons;

        public People(IList<IPersonModell> persons)
        {
            _persons = persons ?? throw new ArgumentNullException(nameof(persons));
        }

        public IList<IPersonModell> SetNames(IList<string> firstname, IList<string> lastname)
        {
            if (firstname.Count <= lastname.Count)
            {
                for (int i = 0; i < lastname.Count; i++)
                {
                    _persons.Add(new PersonModell {Firstname= firstname[i] ,Lastname = lastname[i] });
                }
            }
            else
            {
                for (int i = 0; i < firstname.Count; i++)
                {
                    _persons.Add(new PersonModell { Firstname = firstname[i], Lastname = lastname[i] });
                }
            }
           
            return _persons;

        }

        
    }
}