﻿using JTDLib.Model;
using System.Linq;

namespace JTDBusiness.Model
{
    public class GuestDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Cpf { get; set; }
        public string City { get; set; }
        public string ContactName { get; set; }
        public string Phone { get; set; }

        public static implicit operator GuestDto(Guest model)
        {
            return new GuestDto()
            {
                Phone = model.Person.Phones.Where(p => p.IsMain).Select(p => p.PhoneNumber).FirstOrDefault(),
                ContactName = model.Person.Phones.Where(p => p.IsMain).Select(p => p.Contact).FirstOrDefault(),
                City = model.Person.City.Name,
                Name = model.Person.Name,
                Cpf = model.Cpf,
                Id = model.Id
            };
        }
    }
}
