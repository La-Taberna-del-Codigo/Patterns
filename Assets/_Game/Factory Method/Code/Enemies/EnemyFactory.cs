using UnityEngine;

namespace FactoryMethod
{
    public class EnemyFactory
    {
        private readonly EnemyDataBase _database;

        public EnemyFactory(EnemyDataBase database)
        {
            _database = database;
        }

        public void Create(string id)
        {
            var enemy = _database.GetEnemyById(id);
            Object.Instantiate(enemy, Random.onUnitSphere * Random.Range(0, 25), Quaternion.identity);
        }
    }
}