﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HackatonApp.Entities;

namespace HackatonApp.Data.Repositories
{
    public interface ICandidatoRepository
    {
        Candidato AddCandidato(Candidato candidato);

        Candidato UpdateCandidato(Candidato candidato);

        Candidato GetCandidato(int idCandidato);

        IEnumerable<Candidato> GetCandidatos();

        void DeleteCandidato(int idCandidato);
    }
}
