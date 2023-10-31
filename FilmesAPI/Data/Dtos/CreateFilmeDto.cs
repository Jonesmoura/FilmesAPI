using System.ComponentModel.DataAnnotations;

namespace FilmesAPI.Data.Dtos
{
    public class CreateFilmeDto
    {
        [Required(ErrorMessage = "O título do filme é obrigatório")]
        [StringLength(50, ErrorMessage = "O titulo não pode conter mais de 50 caracteres")]
        public string Titulo { get; set; }
        [Required(ErrorMessage = "O gênero do filme é obrigatório")]
        [MaxLength(50, ErrorMessage = "O tamanho do gênero não pode exceder 50 caracteres")]
        public string Genero { get; set; }
        [Required(ErrorMessage = "A duração do filme é obrigatório")]
        [Range(1, 360, ErrorMessage = "A duração deve ter no mínimo 1 e no máximo 360 minutos")]
        public int Duracao { get; set; }
    }
}
