using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UFSJ.Sharp;

namespace UFSJ.Resources
{
    public class Contributors
    {
        public List<uContributor> Names
        {
            get
            {
                return new List<uContributor>(){
                    new uContributor {Name="Muhammad Fahmi Rasyid", Contributions="Programmer, Designer, Planner",Mail="rasyid.ufasoft@gmail.com"},
                    new uContributor {Name="Supriyono", Contributions="Project Manager", Mail= "priyono.ufasoft@gmail.com"},
                    new uContributor {Name="Muhammad Uswan Hasan", Contributions= "Beta Tester", Mail="-"},
                    new uContributor {Name="Muhammad Aswin Azhar", Contributions= "Beta Tester", Mail="-"},
                    new uContributor {Name="Aqila Fitra Khairunnisa", Contributions="Beta Tester", Mail="aqilafitrakh@gmail.com"},
                    new uContributor {Name="Bagas Christianto", Contributions= "Beta Tester", Mail="bagaschristianto@gmail.com"},
                    new uContributor {Name="Philu Annasa", Contributions="Beta Tester", Mail="philu_anassa@yahoo.com"}
                };

            }
        }

    }
}
