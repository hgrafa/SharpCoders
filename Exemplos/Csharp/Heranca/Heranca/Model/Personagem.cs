using System.Linq.Expressions;

namespace Heranca.Model; 


public class Personagem {

    public string Nome { get; set; } = null!; // not nullable

    public double Forca { get; protected set; }

    public double Velocidade { get; protected set; }

    public double Defesa { get; protected set; }

    public bool IsAlive { get; protected set; } = true;

}
