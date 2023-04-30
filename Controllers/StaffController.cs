using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.Model;
using Models;

namespace Controllers
{
    public class StaffController
    {
        private HostelContext context;
        private readonly EncryptiontController encryptionService;
        public StaffController(HostelContext context, EncryptiontController encryptionService)
        {
            this.context = context;
            this.encryptionService = encryptionService;
        }
        public List<Staff> GetList()
        {
            List<Staff> result = context.Staff.Select(rec => new Staff
            {
                Id = rec.Id,
                Fio = rec.Fio,
                Login = rec.Login,
                Password = rec.Password,
                Role = rec.Role
            })
            .ToList();
            return result;
        }
        public Staff GetElement(int id)
        {
            Staff element = context.Staff.FirstOrDefault(rec => rec.Id == id);
            if (element != null)
            {
                return new Staff
                {
                    Id = element.Id,
                    Fio = element.Fio,
                    Login = element.Login,
                    Password = element.Password,
                    Role = element.Role
                };
            }
            throw new Exception("Объект не найден");
        }

        public Staff GetElement(string login, string password)
        {
            //string passwordDecrypt = encryptionService.Encrypt("UniverObschaga", password);
            Staff element = context.Staff.FirstOrDefault(rec => rec.Login == login);
            if (element != null)
            {
                //if (passwordDecrypt != element.Password) throw new Exception("Неверный логин или пароль");

                return new Staff
                {
                    Id = element.Id,
                    Fio = element.Fio,
                    Login = element.Login,
                    Password = element.Password,
                    Role = element.Role
                };
            }
            throw new Exception("Неверный логин или пароль");
        }

        public void AddElement(Staff model)
        {
            Staff element = context.Staff.FirstOrDefault(rec => rec.Fio == model.Fio || rec.Login == model.Login);
            if (element != null)
            {
                throw new Exception("Уже есть пользователь с таким ФИО или логином");
            }
            element = new Staff
            {
                //Password = encryptionService.Encrypt("UniverObschaga", model.Password),
                Password = model.Password,
                Login = model.Login,
                Role = model.Role,
                Fio = model.Fio
            };
            context.Staff.Add(element);
            context.SaveChanges();
        }
        public void UpdElement(Staff model)
        {
            Staff element = context.Staff.FirstOrDefault(rec => rec.Id != model.Id);
            if (element != null)
            {
                throw new Exception("Такая квартира в доме уже существует");
            }
            element = context.Staff.FirstOrDefault(rec => rec.Id == model.Id);
            if (element == null)
            {
                throw new Exception("Объект не найден");
            }
            element.Fio = model.Fio;
            element.Login = model.Login;
            element.Role = model.Role;
            element.Password= model.Password;
            context.SaveChanges();
        }
        public void DelElement(int id)
        {
            Staff element = context.Staff.FirstOrDefault(rec => rec.Id == id);
            if (element != null)
            {
                context.Staff.Remove(element);
                context.SaveChanges();
            }
            else
            {
                throw new Exception("Объект не найден");
            }
        }
    }

}
