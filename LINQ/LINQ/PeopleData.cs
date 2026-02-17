using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using LINQ.Models;

namespace LINQ
{
    class PeopleData
    {
        public static readonly List<PeopleList> peoples = new List<PeopleList>
        {
          new PeopleList()
          {
              Id = 1,
              Name = "Liina",
              Age = 31,
              GenderId = Guid.Parse("3bc2d839-1e41-4f75-bb04-1c96053ffcca")
          },
          new PeopleList()
          {
              Id = 2,
              Name = "Moona",
              Age = 21,
              GenderId = Guid.Parse("7850d48f-a6d8-4c36-9cbf-938bdad5b10f")
          },
          new PeopleList()
          {
              Id = 3,
              Name = "Ronna",
              Age = 4,
              GenderId = Guid.Parse("5ee1e5bc-9e78-42b3-a610-4783ba4ec048")
          },
          new PeopleList()
          {
              Id = 4,
              Name = "Mari",
              Age = 21,
              GenderId = Guid.Parse("e2ed2cb9-8740-4e1e-b4e5-c5b08694e0e9")
          },
          new PeopleList()
          {
              Id = 5,
              Name = "Mari",
              Age = 19,
              GenderId = Guid.Parse("1bdfaa5e-0da3-483d-8ce1-2ee986700e7b")
          },
          new PeopleList()
          {
              Id = 6,
              Name = "Jelizaveta",
              Age = 16,
              GenderId = Guid.Parse("0e10312a-54c6-4bd4-96f2-0c919bb744d2")
          },
        };
    }
}
