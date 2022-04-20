using DesafioFinal.ValueObjects;

namespace DesafioFinal.Domain
{
    public class Curso
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public int Duracao { get; set; }
        public StatusCurso StatusCurso { get; set; }
    }
}
