using Models;
using System;
using System.Collections.Generic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.Model;
using Models;

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
                Size = rec.Size,
                Location= rec.Location,
                Rooms= rec.Rooms
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
                    Size = element.Size,
                    Location = element.Location,
                    Rooms = element.Rooms
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
                Size = model.Size,
                Location = model.Location,
                Rooms = model.Rooms
            });
            context.SaveChanges();
        }

        public void UpdElement(Room model)
        {
                Room element = context.Rooms.FirstOrDefault(rec =>rec.Id != model.Id);
            if (element != null)
            {
                throw new Exception("Такая квартира в доме уже существует");
            }
            element = context.Rooms.FirstOrDefault(rec => rec.Id == model.Id);
            if (element == null)
            {
                throw new Exception("Объект не найден");
            }
            element.Name = model.Name;
            element.Price = model.Price;
            element.Size = model.Size;
            element.Location = model.Location;
            element.Rooms = model.Rooms;
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
