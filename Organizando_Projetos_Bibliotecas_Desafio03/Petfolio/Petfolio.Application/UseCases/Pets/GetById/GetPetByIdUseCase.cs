using Petfolio.Communication.Enums;
using Petfolio.Communication.Responses;

namespace Petfolio.Application.UseCases.Pets.GetById;
public class GetPetByIdUseCase
{
    public ResponsePetJson Execute(int id)
    {
        return new ResponsePetJson
        {
            Id = id,
            Name = "Titico",
            BirthDate = new DateTime(year: 2021,month: 02, day: 11),
            Type = PetType.Dog
        };
    }
}
