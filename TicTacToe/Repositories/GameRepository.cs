using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore.InMemory.Infrastructure.Internal;
using TicTacToe.Models;

namespace TicTacToe.Repositories
{
    
    public class GameRepository : IRepository<NewGameModel>
    {
        private List<NewGameModel> _gameList;

        public GameRepository()
        {
           _gameList = new List<NewGameModel>();
        }

        public NewGameModel GetById(Guid id)
        {
            var game = _gameList.SingleOrDefault(x => x.gameId.Equals(id));
            if (game == null)
            {
                throw new Exception(); 
            }
            return game;
        }

        public NewGameModel GetAll()
        {
            throw new System.NotImplementedException();
        }

        public Guid[] ReturnAllGameID()
        {
           return _gameList.Select(x => x.gameId).ToArray();
        }

        public void Add(NewGameModel obj)
        {
            _gameList.Add(obj);
        }

        public void Delete(Guid objId)
        {
            NewGameModel remove = this.GetById(objId);
           _gameList.Remove(remove);
        }
    }

    public interface IRepository<T>
    {
        T GetById(Guid id);
        T GetAll();
        void Add(T obj);
        void Delete(Guid objId);

    }
}