﻿namespace SimpleTaskManager.Communication.Responses;
public class ResponseRegisterTaskJson
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public DateTime MaximumDate { get; set; }
}
