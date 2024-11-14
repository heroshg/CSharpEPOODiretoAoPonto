﻿using ProgramacaoOO;

var professor = new Professor(5000m, "João", "12345", new DateTime(1980, 1, 1));
var estudante = new Estudante("A", "Luís", "54321", new DateTime(1992, 1, 1));

var pessoas = new List<Pessoa> { estudante, professor };

foreach (var pessoa in pessoas)
{
    pessoa.SeApresentar();
}
