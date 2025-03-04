using SimpleTaskManager.Communication.Enums;

namespace SimpleTaskManager.Communication.Requests;
public class RequestTaskJson
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public PriorityType Priority { get; set; }
    public DateTime MaximumDate { get; set; }
    public StatusType Status { get; set; }

}
