namespace Heranca.Model; 

public class Arco {

    public TipoDoArco TipoDoArco { get; set; }

    public double Forca {
        get {
            switch (TipoDoArco) {
                case TipoDoArco.EXPLOSIVO:
                    return 200.0;
                case TipoDoArco.VENENOSO:
                    return 30.0;
                default:
                    return 80.0;
            }
        }
    }
   
    public Arco(TipoDoArco tipoDoArco) {
        TipoDoArco = tipoDoArco;
    }

}