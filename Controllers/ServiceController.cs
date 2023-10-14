using Models.Model;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Controllers
{
    public class ServiceController
    {
        private HostelContext context;
        public ServiceController(HostelContext context)
        {
            this.context = context;
        }
        public List<AdditionalService> GetList()
        {
            List<AdditionalService> result = context.AdditionalServices.AsEnumerable().Select(rec => new AdditionalService
            {
                Id = rec.Id,
                Name = rec.Name,
                Price = rec.Price,
   
            })
           .ToList();
            return result;
        }
        public AdditionalService GetElement(int id)
        {
            AdditionalService element = context.AdditionalServices.FirstOrDefault(rec => rec.Id == id);
            if (element != null)
            {
                return new AdditionalService
                {
                    Id = element.Id,
                    Name = element.Name,
                    Price = element.Price,
                    
                };
            }
            throw new Exception("Объект не найден");
        }

        public void AddElement(AdditionalService model)
        {
            AdditionalService element = context.AdditionalServices.FirstOrDefault(rec => rec.Name == model.Name);
            if (element != null)
            {
                throw new Exception("Такая квартира уже существует");
            }
            context.AdditionalServices.Add(new AdditionalService
            {
                Name = model.Name,
                Price = model.Price,
              
            });
            context.SaveChanges();
        }

        public void UpdElement(AdditionalService model)
        {
                
            AdditionalService element = context.AdditionalServices.FirstOrDefault(rec => rec.Id == model.Id);
            if (element == null)
            {
                throw new Exception("Объект не найден");
            }
            element.Name = model.Name;
            element.Price = model.Price;
            context.SaveChanges();
        }

        public void DelElement(int id)
        {
            AdditionalService element = context.AdditionalServices.FirstOrDefault(rec => rec.Id == id);
            if (element != null)
            {
                context.AdditionalServices.Remove(element);
                context.SaveChanges();
            }
            else
            {
                throw new Exception("Объект не найден");
            }
        }
    }
}
