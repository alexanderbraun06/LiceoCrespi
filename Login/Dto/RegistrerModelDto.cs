using System.ComponentModel.DataAnnotations;

namespace Login.Dto
{
    public class RegistrerModelDto
    {
        public class RegistrerModel
        {
            public string Id { get; set; }
            public required String Nome { get; set; }
            public required String Cognome { get; set; }
            public required DateOnly DataDiNascita { get; set; }
            public required string CodiceFiscale { get; set; }
            public required string ComuneDiNascita { get; set; }

            [Required(ErrorMessage = "Username è obbligatorio")]
            public string? Username { get; set; }

            [EmailAddress]
            [Required(ErrorMessage = "L'email è obbligatoria")]
            public string? Email { get; set; }
            public required string IndirizzoEmail { get; set; }
            public required int NumeroDiTelefono { get; set; }
            [Required(ErrorMessage = "La password è richiesta")]
            public string? Password { get; set; }
            public required string ConfermaPassword { get; set; }
            public required string IndirizzoDiResidenzaCompleto { get; set; }
            public required string UserRole { get; set; }
        }
    }

}
