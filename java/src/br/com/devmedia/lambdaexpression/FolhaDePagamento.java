package br.com.devmedia.lambdaexpression;

import java.util.ArrayList;
import java.util.List;

public class FolhaDePagamento {

    public List<Funcionario> getFuncionarios(Condicao<Funcionario> condicao) {
        List<Funcionario> funcionarios = new ArrayList<Funcionario>() {{
            add(new Funcionario(1903.98F, "João"));
            add(new Funcionario(2826.65F, "Aline"));
            add(new Funcionario(3751.0F, "Marcela"));
            add(new Funcionario(500.0F, "André"));
        }};

        List<Funcionario> funcionariosComCondicao = new ArrayList<>();

        funcionarios.forEach(f -> {
            if(condicao.teste(f)){
                funcionariosComCondicao.add(f);
            }
        });

        return funcionariosComCondicao;
    }
}
