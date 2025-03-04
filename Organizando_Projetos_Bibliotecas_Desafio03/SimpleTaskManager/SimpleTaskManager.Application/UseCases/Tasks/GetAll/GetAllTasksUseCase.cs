using SimpleTaskManager.Communication.Enums;
using SimpleTaskManager.Communication.Responses;

namespace SimpleTaskManager.Application.UseCases.Tasks.GetAll;
public class GetAllTasksUseCase
{
    public ResponseAllTaskJson Execute()
    {
        return new ResponseAllTaskJson
        {
            Tasks = new List<ResponseShortTaskJson>
            {
                new ResponseShortTaskJson
                {
                    Id = 1,
                    Name = "Passeio",
                    Description = "Levar cão ao passeio",
                    MaximumDate = DateTime.Now,
                    Priority = PriorityType.High,
                    Status = StatusType.waiting
                },
                new ResponseShortTaskJson
                {
                    Id = 2,
                    Name = "Jantar",
                    Description = "Happy hour com amigos",
                    MaximumDate = DateTime.Now,
                    Priority = PriorityType.High,
                    Status = StatusType.waiting
                },
            },
        };
    }
}