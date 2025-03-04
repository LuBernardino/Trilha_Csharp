using Petfolio.Communication.Enums;

namespace Petfolio.Communication.Requests;
public class RequestPetJson
{
    public string? Name { get; set; }
    public DateTime BirthDate { get; set; }
    public PetType Type { get; set; }
}
