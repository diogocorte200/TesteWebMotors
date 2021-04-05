using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TesteWebMotors.Domain.Domain;
using TesteWebMotors.Domain.Service.Generic;
using TesteWebMotors.Entity.Entity;
using TesteWebMotors.Entity.Repositories.Interfaces;
using TesteWebMotors.Entity.UnitofWork;

namespace TesteWebMotors.Domain.Service
{
    public class AnuncioService<Tv, Te> : GenericServiceAsync<Tv, Te>
                                              where Tv : AnuncionWebMotorsModel
                                              where Te : AnuncioWebMotorsEntity
    {
        private readonly IAnuncioRepository _anuncioRepository;

        public AnuncioService(IUnitOfWork unitOfWork, IMapper mapper,
                             IAnuncioRepository anuncioRepository)
        {
            if (_unitOfWork == null)
                _unitOfWork = unitOfWork;
            if (_mapper == null)
                _mapper = mapper;

            if (_anuncioRepository == null)
                _anuncioRepository = anuncioRepository;
        }


        public async Task<RetornoControllerViewModel<ExibicaoMensagemViewModel, AnuncionWebMotorsModel>> Incluir(AnuncionWebMotorsModel obj)
        {
            var result = new RetornoControllerViewModel<ExibicaoMensagemViewModel, AnuncionWebMotorsModel>(obj);
            try
            {
                var entity = new AnuncioWebMotorsEntity()
                {
                    Ano = obj.Ano,
                    Marca = obj.Marca,
                    Modelo = obj.Modelo,
                    Observacao = obj.Observacao,
                    Quilometragem = obj.Quilometragem,
                    Versao = obj.Versao
                };

                _anuncioRepository.Add(entity);
                _anuncioRepository.Save();
                obj.Id = entity.Id;
                return result;
            }
            catch
            {
                return null;
            }
        }

        public async Task<RetornoControllerViewModel<ExibicaoMensagemViewModel, AnuncionWebMotorsModel>> Atualizar(AnuncionWebMotorsModel obj)
        {
            var result = new RetornoControllerViewModel<ExibicaoMensagemViewModel, AnuncionWebMotorsModel>(obj);
            try
            {
                var entity = new AnuncioWebMotorsEntity()
                {
                    Ano = obj.Ano,
                    Marca = obj.Marca,
                    Modelo = obj.Modelo,
                    Observacao = obj.Observacao,
                    Quilometragem = obj.Quilometragem,
                    Versao = obj.Versao,
                    Id = obj.Id
                };

                _anuncioRepository.Update(entity);
                _anuncioRepository.Save();
                return result;
            }
            catch
            {
                return null;
            }
        }

        public async Task<RetornoControllerViewModel<ExibicaoMensagemViewModel, AnuncionWebMotorsModel>> Selecionar(int id)
        {
            var anuncio = new AnuncionWebMotorsModel();
            var result = new RetornoControllerViewModel<ExibicaoMensagemViewModel, AnuncionWebMotorsModel>(anuncio);
            try
            {
                
                var ret = _anuncioRepository.Find(x=>x.Id == id).SingleOrDefault();
                anuncio.Id = id;
                anuncio.Ano = ret.Ano;
                anuncio.Marca = ret.Marca;
                anuncio.Modelo = ret.Modelo;
                anuncio.Observacao = ret.Observacao;
                anuncio.Quilometragem = ret.Quilometragem;
                anuncio.Versao = ret.Versao;
                
                return result ;
            }
            catch
            {
                return null;
            }
        }
        public async Task<RetornoControllerViewModel<ExibicaoMensagemViewModel, AnuncionWebMotorsModel>> Deletar(int id)
        {
            var anuncio = new AnuncionWebMotorsModel();
            var result = new RetornoControllerViewModel<ExibicaoMensagemViewModel, AnuncionWebMotorsModel>(anuncio);
            try
            {

                var ret = _anuncioRepository.Find(x => x.Id == id).SingleOrDefault();
                anuncio.Id = id;
                anuncio.Ano = ret.Ano;
                anuncio.Marca = ret.Marca;
                anuncio.Modelo = ret.Modelo;
                anuncio.Observacao = ret.Observacao;
                anuncio.Quilometragem = ret.Quilometragem;
                anuncio.Versao = ret.Versao;
                _anuncioRepository.Remove(ret);
                _anuncioRepository.Save();
                return result;
            }
            catch
            {
                return null;
            }
        }

        public async Task<List<AnuncionWebMotorsModel>> Listar()
        {
            try
            {
                List<AnuncionWebMotorsModel> lst = new List<AnuncionWebMotorsModel>();
                var anuncios =  _anuncioRepository.GetAll().ToList();
                foreach (var a in anuncios)
                {
                    var obj = new AnuncionWebMotorsModel()
                    {
                        Ano = a.Ano,
                        Id = a.Id,
                        Marca = a.Marca,
                        Modelo = a.Modelo,
                        Observacao = a.Observacao,
                        Quilometragem = a.Quilometragem,
                        Versao = a.Versao
                    };
                    lst.Add(obj);
                }
                return lst;
            }
            catch
            {
                return null;
            }
        }


    }
}
