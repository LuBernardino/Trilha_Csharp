using SimpleTaskManager.Communication.Enums;
using SimpleTaskManager.Communication.Responses;

namespace SimpleTaskManager.Application.UseCases.Tasks.GetById;

public class GetTaskByIdUseCase
{
    public ResponseTaskJson Execute(int id)
    {
        return new ResponseTaskJson
        {
            Id = id,
            Name = "Task 1",
            Description = "Description 1",
            MaximumDate = DateTime.Now,
            Priority = PriorityType.High,
            Status = StatusType.waiting
        };
    }
}
