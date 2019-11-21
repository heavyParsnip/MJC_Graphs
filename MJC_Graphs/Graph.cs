using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MJC_Graphs
{
    class Graph
    {
        //FIELDS
        private Dictionary<String, List<String>> adjacency = new Dictionary<string, List<string>>();

        //CONSTRUCTORS
        public Graph()
        {
            List<string> courtyard = new List<string>()
            {
                "boiler room",
                "foyer",
                "library"
            };
            List<string> boiler = new List<string>()
            {
                "courtyard"
            };
            List<string> foyer = new List<string>()
            {
                "courtyard",
                "library"
            };
            List<string> library = new List<string>()
            {
                "courtyard",
                "foyer",
                "archive",
                "exit"
            };
            List<string> archive = new List<string>()
            {
                "library",
                "exit"
            };
            List<string> exit = new List<string>()
            {
                "library",
                "archive",
                "exit"
            };

            adjacency.Add("courtyard", courtyard);
            adjacency.Add("boiler room", boiler);
            adjacency.Add("foyer", foyer);
            adjacency.Add("library", library);
            adjacency.Add("archive", archive);
            adjacency.Add("exit", exit);
        }

        //METHODS
        public List<string> GetAdjacentList(string room)
        {
            if(adjacency.ContainsKey(room) == true)
            {
                return adjacency[room];
            }
            else
            {
                return null;
            }
        }

        public bool IsConnected(string room1, string room2)
        {
            if(adjacency[room1].Contains(room2) == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
