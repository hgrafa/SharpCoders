namespace Heranca.Model; 

public class Arqueiro : Personagem {

    public Arco Arco { get; set; }

    public Arqueiro() {
        Nome = "Arqueiro";
        Arco = new Arco(TipoDoArco.COMUM);
    }

    public void AdquirirNovoArco(Arco novoArco) {
        Arco = novoArco;
    }

}
