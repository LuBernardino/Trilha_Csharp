using SimpleTaskManager.Communication.Requests;
using SimpleTaskManager.Communication.Responses;

namespace SimpleTaskManager.Application.UseCases.Tasks.Register;
public class RegisterTaskUseCase
{
    public ResponseRegisterTaskJson Execute(RequestTaskJson request)
    {
       return new ResponseRegisterTaskJson
       {
           Id = request.Id,
           Name = request.Name,
           Description = request.Description,
           MaximumDate = request.MaximumDate
       };
    }
}
