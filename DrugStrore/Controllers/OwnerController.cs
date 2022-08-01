using Core.Entities;
using Core.Helpers;
using DataAcces.Repostories.Implementations;
using System;

namespace DrugStrore.Controllers
{
    public class OwnerController 
    {
        private OwnerRepository ownerRepository;

        public OwnerController()
        {
            ownerRepository = new OwnerRepository();
        }

        public void Creat()
        {
            Helper.WriteTextWithColor(ConsoleColor.Green, "Enter Owner name:");
            string name = Console.ReadLine();
            Helper.WriteTextWithColor(ConsoleColor.Green, "Enter Owner surname:");
            string surname = Console.ReadLine();
            Owner owner = new Owner()
            {
                Name = name,
                Surname = surname
            };
            var creatOwner = ownerRepository.Create(owner);
            Helper.WriteTextWithColor(ConsoleColor.Green, $"Owner is created {name} {surname} ");
        }
        public void GetAll()
        {
            var ownerRepository = new OwnerRepository();
            ownerRepository.GetAll();
        }
    }
}
