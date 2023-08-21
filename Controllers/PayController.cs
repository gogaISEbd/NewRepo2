using Models.Model;
using Models;

namespace Controllers
{
    public class PayController
    {
        private HostelContext context;
        public PayController(HostelContext context)
        {
            this.context = context;
        }
        public List<MainOperation> GetList()
        {

            List<MainOperation> result = context.MainOperations.AsEnumerable().Select(rec => new MainOperation
            {
                Id = rec.Id,
                Date = rec.Date,
                ClientId = rec.ClientId,
                DateStart = rec.DateStart,
                DateEnd = rec.DateEnd,
                RoomsId=rec.RoomsId,
                Cost=rec.Cost,
                Payed=rec.Payed,
                Condit=rec.Condit,


            })
           .ToList();
            return result;
        }
        public MainOperation GetElement(int id)
        {
            MainOperation element = context.MainOperations.FirstOrDefault(rec => rec.Id == id);
            if (element != null)
            {
                return new MainOperation
                {
                    Id = element.Id,
                    Date = element.Date,
                    ClientId = element.ClientId,
                    DateStart = element.DateStart,
                    DateEnd = element.DateEnd,
                    RoomsId = element.RoomsId,
                    Cost = element.Cost,
                    Payed=element.Payed,
                    Condit=element.Condit,
                };
            }
            throw new Exception("Объект не найден");
        }

        public void AddElement(MainOperation model)
        {
            MainOperation element = context.MainOperations.FirstOrDefault(rec => rec.Id ==
           model.Id);
            if (element != null)
            {
                throw new Exception("Такая квартира уже существует");
            }
            context.MainOperations.Add(new MainOperation
            {
                Id = element.Id,
                Date = element.Date,
                ClientId = element.ClientId,
                DateStart = element.DateStart,
                DateEnd = element.DateEnd,
                RoomsId = element.RoomsId,
                Cost = element.Cost,
                Payed=element.Payed,
                Condit = false,
            });
            context.SaveChanges();
        }

        public void UpdElement(MainOperation model)
        {
            MainOperation element = context.MainOperations.FirstOrDefault(rec => rec.Id != model.Id);
            if (element != null)
            {
                throw new Exception("Такая квартира в доме уже существует");
            }
            element = context.MainOperations.FirstOrDefault(rec => rec.Id == model.Id);
            if (element == null)
            {
                throw new Exception("Объект не найден");
            }
            element.DateStart = model.DateStart;
            element.DateEnd = model.DateEnd;
            element.Cost = model.Cost;
            context.SaveChanges();
        }
        public void UpdPay(MainOperation model)
        {
            MainOperation element = context.MainOperations.FirstOrDefault(rec => rec.Id != model.Id);

            if (model.Condit == true)
                return;
            if (model.Condit == false && model.Cost <= element.Payed) { 
                model.Condit = true;
                model.Payed=element.Payed;
            }
            if (model.Payed + element.Payed < model.Cost)
            { model.Payed = +element.Payed; }
            else
            {
                model.Payed = model.Payed+element.Payed;
                model.Condit= true;
            }
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