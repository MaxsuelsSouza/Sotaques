namespace Domain.Events;

public record RevoltaArmadaDeclarada(
    Guid GiriaId,
    string NomeGiria,
    string EstadoGeografico,
    DateTime DataDisparo
);
