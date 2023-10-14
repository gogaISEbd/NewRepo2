using Models;
using System;
using System.Collections.Generic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.Model;

namespace Controllers
{
    public class RoomsController
    {
        private HostelContext context;
        public RoomsController(HostelContext context)
        {
            this.context = context;
        }
        public List<Room> GetList()
        {
            
            List<Room> result = context.Rooms.AsEnumerable().Select(rec => new Room
            {
                Id = rec.Id,
                Name = rec.Name,
                Price = rec.Price,
                Location = rec.Location,
                Rooms = rec.Rooms,
                Size = rec.Size
               
                
            })
           .ToList();
            return result;
        }
        public Room GetElement(int id)
        {
            Room element = context.Rooms.FirstOrDefault(rec => rec.Id == id);
            if (element != null)
            {
                return new Room
                {
                    Id = element.Id,
                    Name = element.Name,
                    Price = element.Price,
                    Location = element.Location,
                    Rooms = element.Rooms,
                    Size = element.Size,
                };
            }
            throw new Exception("Объект не найден");
        }

        public void AddElement(Room model)
        {
            Room element = context.Rooms.FirstOrDefault(rec => rec.Name ==
           model.Name);
            if (element != null)
            {
                throw new Exception("Такая квартира уже существует");
            }
            context.Rooms.Add(new Room
            {
                Name = model.Name,
                Price = model.Price,
                Location = model.Location,
                Rooms = model.Rooms,
                Size = model.Size
            });
            context.SaveChanges();
        }

        public void UpdElement(Room model)
        {
            Room element = context.Rooms.FirstOrDefault(rec => rec.Id == model.Id);
            if (element == null)
            {
                throw new Exception("Объект не найден");
            }
            element.Name = model.Name;
            element.Price = model.Price;
            
            element.Location = model.Location;
            element.Rooms = model.Rooms;
            element.Size = model.Size;
            context.SaveChanges();
        }

        public void DelElement(int id)
        {
            Room element = context.Rooms.FirstOrDefault(rec => rec.Id == id);
            if (element != null)
            {
                context.Rooms.Remove(element);
                context.SaveChanges();
            }
            else
            {
                throw new Exception("Объект не найден");
            }
        }
    }
}
