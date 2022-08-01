using Core.Abstract;
using System.Collections.Generic;

namespace Core.Entities
{
    public class Owner : IEntity
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Surname { get; set; }

        public List<DrugStore> DrugStores { get; set; }

    }
}
