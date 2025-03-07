﻿namespace Library.Communication.Responses;

public class ResponseRegisterBookJson
{
    public int Id { get; set; }
    public string? Title { get; set; }
    public string? Author { get; set; }
    public string? Genre { get; set; }
    public double Price { get; set; }
    public int Quantity { get; set; }
}
