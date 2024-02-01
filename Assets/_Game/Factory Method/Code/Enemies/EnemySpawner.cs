using UnityEngine;

namespace FactoryMethod
{
    public class EnemySpawner : MonoBehaviour
    {
        [SerializeField] private EnemyId[] _enemyIds;
        [SerializeField] private EnemyDataBase _dataBase;

        private EnemyFactory _enemyFactory;

        private void Awake()
        {
            _enemyFactory = new EnemyFactory(Instantiate(_dataBase));
        }

        private void Update()
        {

            int id = Random.Range(0, _enemyIds.Length);

            _enemyFactory.Create(_enemyIds[id].Value);


        }
    }
}