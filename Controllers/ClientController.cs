using Models.Model;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controllers
{
    public class ClientController
    {
        private HostelContext context;
        
        public ClientController(HostelContext context)
        {
            this.context = context;
        }
        public List<Client> GetList()
        {
            List<Client> result = context.Clients.Select(rec => new Client
            {
                Id = rec.Id,
                Fio = rec.Fio,
                Age = rec.Age,
                Passport = rec.Passport,
                Phone = rec.Phone
            })
            .ToList();
            return result;
        }
        public Client GetElement(int id)
        {
            Client element = context.Clients.FirstOrDefault(rec => rec.Id == id);
            if (element != null)
            {
                return new Client
                {
                    Id = element.Id,
                    Fio = element.Fio,
                    Age = element.Age,
                    Passport = element.Passport,
                    Phone = element.Phone
                };
            }
            throw new Exception("Объект не найден");
        }
        public void AddElement(Client model)
        {
            Client element = context.Clients.FirstOrDefault(rec => rec.Fio == model.Fio || rec.Passport == model.Passport);
            if (element != null)
            {
                throw new Exception("Уже есть пользователь с таким ФИО или логином");
            }
            element = new Client
            {
                //Password = encryptionService.Encrypt("UniverObschaga", model.Password),
                Passport = model.Passport,
                Age = model.Age,
                Phone = model.Phone,
                Fio = model.Fio
            };
            context.Clients.Add(element);
            context.SaveChanges();
        }
        public void UpdElement(Client model)
        {
            Client element = context.Clients.FirstOrDefault(rec => rec.Id == model.Id);
            if (element == null)
            {
                throw new Exception("Объект не найден");
            }
            element.Fio = model.Fio;
            element.Age = model.Age;
            element.Passport = model.Passport;
            element.Phone = model.Phone;
            context.SaveChanges();
        }
        public void DelElement(int id)
        {
            Client element = context.Clients.FirstOrDefault(rec => rec.Id == id);
            if (element != null)
            {
                context.Clients.Remove(element);
                context.SaveChanges();
            }
            else
            {
                throw new Exception("Объект не найден");
            }
        }
    }
}
