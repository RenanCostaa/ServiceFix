using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Servico
{
    public List<PrestadordeServico> prestadordeServicos = new List<PrestadordeServico>();

    public void AdicionaPrestadorServico(PrestadordeServico arg)
    {
        prestadordeServicos.Add(arg);
    }
    
    public void PopulaPrestadorServico(){
        prestadordeServicos.Add(new PrestadordeServico(
            "LevLimpe",
            "33010485",
            "Limpeza de Caixa D'Agua",
            "limpeja@gmail.com",
            "2 horas",
            70,
            140
        ));
        prestadordeServicos.Add(new PrestadordeServico(
            "WaterWash",
            "30424421",
            "Limpeza de Caixa D'Agua",
            "caixaslimpas.service@outlook.com",
            "2 horas",
            64,
            115
        ));

        prestadordeServicos.Add(new PrestadordeServico(
            "Good Furniture",
            "44286031",
            "Restauração de Móveis.",
            "restaura.moveis@servicos.com",
            "6 dias uteis",
            160,
            250
        ));
        prestadordeServicos.Add(new PrestadordeServico(
            "Jorge restaurador",
            "999581273",
            "Restauração de Móveis.",
            "restaurajorge@hotmail.com",
            "3 dias",
            75,
            190
        ));

        prestadordeServicos.Add(new PrestadordeServico(
            "CleanPool",
            "33038988",
            "Limpeza de Piscina",
            "piscinalimpa@cleanpool.com",
            "2 dias",
            125,
            260
        ));
        prestadordeServicos.Add(new PrestadordeServico(
            "Lava tudo",
            "36459102",
            "Limpeza de Piscina",
            "piscinas@lavatudo.com",
            "2 dias",
            99,
            249
        ));

        prestadordeServicos.Add(new PrestadordeServico(
            "Gabriel Garden's",
            "32208540",
            "Jardineiro",
            "jardimtop@ggardens.com",
            "1 dia",
            175,
            250
        ));
        prestadordeServicos.Add(new PrestadordeServico(
            "Jardins Merlin",
            "33234383",
            "Jardineiro",
            "contato@jardinsmerlin.com",
            "2 dias",
            160,
            299
        ));
    }
}
 