using System.Collections.Generic;
using UnityEngine;

namespace FactoryMethod
{
    [CreateAssetMenu(fileName = "Database", menuName = "Factory Method/Enemy Database")]
    public class EnemyDataBase : ScriptableObject
    {
        [Header("---- REFERENCES ----")]
        [SerializeField] private Enemy[] _enemiesPrefabs;

        private Dictionary<string, Enemy> _idToEnemiesPrefabs;

        private void Awake()
        {
            _idToEnemiesPrefabs = new();
            foreach (var enemyPrefab in _enemiesPrefabs)
            {
                _idToEnemiesPrefabs.Add(enemyPrefab.ID, enemyPrefab);
            }
        }

        public Enemy GetEnemyById(string id)
        {
            return _idToEnemiesPrefabs[id];
        }
    }
}