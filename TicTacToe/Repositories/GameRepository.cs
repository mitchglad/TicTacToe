using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore.InMemory.Infrastructure.Internal;
using TicTacToe.Models;

namespace TicTacToe.Repositories
{
    
    public class GameRepository : IRepository<Game>
    {
        private List<Game> _gameList;

        public GameRepository()
        {
           _gameList = new List<Game>();
        }

        public Game GetById(Guid id)
        {
            Game game = _gameList.SingleOrDefault(x => x._gameId.Equals(id));
            if (game == null)
            {
                throw new Exception(); 
            }
            return game;
        }

        public Game GetAll()
        {
            throw new System.NotImplementedException();
        }

        public Guid[] ReturnAllGameID()
        {
           return _gameList.Select(x => x._gameId).ToArray();
        }

        public void Add(Game obj)
        {
            _gameList.Add(obj);
        }

        public void Delete(Guid objId)
        {
            Game remove = this.GetById(objId);
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