using Models;
using System;
using System.Collections.Generic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.Model;
using Task = Models.Model.Task;

namespace Controllers
{
    public class TaskController
    {
        private HostelContext context;
        public TaskController(HostelContext context)
        {
            this.context = context;
        }

        public List<Task> GetList(int idUser)
        {
            List<Task> result = context.Tasks.AsEnumerable().Select(rec => new Task
            {
                Id = rec.Id,
                Task1 = rec.Task1,
                Date = rec.Date,
                IsDone = rec.IsDone,
                Staff = rec.Staff
            }).Where(rec => rec.StaffId == idUser)
           .ToList();
            return result;
        }
        public Task GetElement(int id)
        {
            Task element = context.Tasks.FirstOrDefault(rec => rec.Id == id);
            if (element != null)
            {
                return new Task
                {
                    Id = element.Id,
                    Task1 = element.Task1,
                    Date = element.Date,
                    IsDone = element.IsDone
                };
            }
            throw new Exception("Объект не найден");
        }

        public void RepformTask(Task model)
        {
            Task element = context.Tasks.FirstOrDefault(rec => rec.Id == model.Id);
            if (element == null)
            {
                throw new Exception("Объект не найден");
            }
            element.IsDone = model.IsDone;
            context.SaveChanges();
        }

        public void CancelTask(Task model)
        {
            Task element = context.Tasks.FirstOrDefault(rec => rec.Id == model.Id);
            if (element == null)
            {
                throw new Exception("Объект не найден");
            }
            element.IsDone = model.IsDone;
            context.SaveChanges();
        }
        public void AddElement(Task model)
        {
            Task element = new Task
            {
                Task1 = model.Task1,
                Date = model.Date,
                StaffId = model.StaffId, 
            };
            context.Tasks.Add(element);
            context.SaveChanges();
        }

        public void UpdElement(Task model)
        {
            Task element = context.Tasks.FirstOrDefault(rec => rec.Id == model.Id);
            if (element == null)
            {
                throw new Exception("Объект не найден");
            }
            element.StaffId = model.StaffId;
            element.Date = model.Date;
            element.Task1 = model.Task1;
            context.SaveChanges();
        }

        public void DelElement(int id)
        {
            Task element = context.Tasks.FirstOrDefault(rec => rec.Id == id);
            if (element != null)
            {
                context.Tasks.Remove(element);
                context.SaveChanges();
            }
            else
            {
                throw new Exception("Объект не найден");
            }
        }
    }
}
