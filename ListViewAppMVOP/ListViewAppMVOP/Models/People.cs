using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace ListViewAppMVOP.Model
{
    class People
    {
        public ObservableCollection<AMan> AllPeople { get; set; }

        public People()
        {
            AllPeople = new ObservableCollection<AMan>();
            AllPeople.Add(new AMan { FirstName = "Jan", SurName = "Novák", Age = 20 });
            AllPeople.Add(new AMan { FirstName = "Jana", SurName = "Svobodová", Age = 18 });
            AllPeople.Add(new AMan { FirstName = "Anna", SurName = "Květná", Age = 21 });
            AllPeople.Add(new AMan { FirstName = "René", SurName = "Vydarený", Age = 35 });
            AllPeople.Add(new AMan { FirstName = "Jan", SurName = "Suchánek", Age = 28 });
            AllPeople.Add(new AMan { FirstName = "Jiří", SurName = "Štěpnička", Age = 18 });
            AllPeople.Add(new AMan { FirstName = "Wan", SurName = "Sun", Age = 21 });
            AllPeople.Add(new AMan { FirstName = "Richard", SurName = "Burton", Age = 35 });
        }
    }
}
