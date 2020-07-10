using System.Collections.Generic;
using Atlas.Common.Framework.AutoMapper;
using Atlas.Common.Framework.Transactions;

namespace OverwatchProject
{
    public class HeroApplicationService : IHeroApplicationService
    {
        private readonly ITransactionFactory _transactionFactory;

        private readonly IHeroRepository _heroRepository;

        private readonly ITankHeroRepository _tankRepository;

        public HeroApplicationService(ITransactionFactory transactionFactory, IHeroRepository heroRepository, ITankHeroRepository tankRepository)
        {
            _transactionFactory = transactionFactory;
            _heroRepository = heroRepository;
            _tankRepository = tankRepository;
        }

        public IEnumerable<TankHeroAdto> GetAll()
        {
            using (ITransaction transaction = _transactionFactory.Create())
            {
                IEnumerable<Hero> heroes = _heroRepository.GetAll();

                IEnumerable<TankHeroAdto> heroAdtos = ObjectMapper.MapList<Hero, TankHeroAdto>(heroes);

                transaction.Commit();

                return heroAdtos;
            }
        }

        public void FillTankHeroRepository()
        {
            using (ITransaction transaction = _transactionFactory.Create())
                //{
                //    Hero roadHog = new Hero(1, "Roadhog", 600, 150);
                //    Hero reinhardt = new Hero(2, "Reinhardt", 500, 75);
                //    Hero dva = new Hero(3, "D.Va", 500, 50);
                //    Hero zarya = new Hero(4, "Zarya", 400, 100);
                //    Hero winston = new Hero(5, "Winston", 500, 40);


                //    _tankRepository.Add(roadHog);
                //    _tankRepository.Add(reinhardt);
                //    _tankRepository.Add(dva);
                //    _tankRepository.Add(zarya);
                //    _tankRepository.Add(winston);

                transaction.Commit();
        }
    }
}
