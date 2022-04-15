using System.ComponentModel.DataAnnotations;

namespace ApiFilmes.Models
{
    public class Filme
    {
        public int Id {get;set;}
        [Required(ErrorMessage ="O campo título é obrigatório")]        
        [MinLength(3, ErrorMessage ="O título do filme deve conter no mínimo 3 caracteres")]
        public string Titulo {get;set;}
        
        [Required(ErrorMessage ="O campo diretor é obrigatório")]
        [MinLength(5, ErrorMessage ="O nme do diretor do filme deve conter no mínimo 5 caracteres")]
        public string Diretor {get;set;}
        
        [Required(ErrorMessage ="O campo gênero é obrigatório")]
        [StringLength(30, ErrorMessage ="O gênero do filme deve conter no máximo 30 caracteres")]
        [MinLength(3, ErrorMessage ="O gênero do filme deve conter no mínimo 3 caracteres")]
        public string Genero {get;set;}
       
        [Required]
        [Range(1895, 2022, ErrorMessage="Ano Inválido")]
        public int Ano {get;set;}
        
        [Range(30, 300, ErrorMessage ="A duração do filme deve ser entre 30 e 300 minutos")]
        public int TempoDuracao {get;set;}
    }
}